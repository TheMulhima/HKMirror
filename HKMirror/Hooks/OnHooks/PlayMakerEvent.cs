using MonoMod.RuntimeDetour;
using MonoMod.RuntimeDetour.HookGen;

namespace HKMirror.Hooks.OnHooks;

/// <summary>
/// Contains different types of On Hooks for PlayMakerEvent class.<br />
/// Contains hooks that aren't generated by monomod, and before and after orig hooks for easier hooking.
/// </summary>
public static class OnPlayMakerEvent
{
    internal static class HookHandler
    {
        private static List<string> HookedList = new List<string>();

        internal static void HookSendEvent()
        {
            if (!HookedList.Contains("SendEvent"))
            {
                HookedList.Add("SendEvent");
                new Hook(
                    ReflectionHelper.GetMethodInfo(typeof(HutongGames.PlayMaker.Ecosystem.Utils.PlayMakerEvent),
                        "SendEvent", true), SendEvent);
            }
        }

        internal static event Delegates.SendEvent_BeforeArgs _beforeSendEvent;
        internal static event Delegates.SendEvent_AfterArgs _afterSendEvent;

        private static bool SendEvent(
            Func<HutongGames.PlayMaker.Ecosystem.Utils.PlayMakerEvent, PlayMakerFSM,
                HutongGames.PlayMaker.Ecosystem.Utils.PlayMakerEventTarget, bool> orig,
            HutongGames.PlayMaker.Ecosystem.Utils.PlayMakerEvent self, PlayMakerFSM fromFsm,
            HutongGames.PlayMaker.Ecosystem.Utils.PlayMakerEventTarget eventTarget)
        {
            Delegates.Params_SendEvent @params = new()
            {
                self = self, fromFsm = fromFsm, eventTarget = eventTarget
            };
            if (_beforeSendEvent != null)
            {
                foreach (Delegates.SendEvent_BeforeArgs toInvoke in _beforeSendEvent.GetInvocationList())
                {
                    try
                    {
                        _beforeSendEvent?.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }
                }
            }

            self = @params.self;
            fromFsm = @params.fromFsm;
            eventTarget = @params.eventTarget;
            var retVal = orig(self, fromFsm, eventTarget);
            if (_afterSendEvent != null)
            {
                foreach (Delegates.SendEvent_AfterArgs toInvoke in _afterSendEvent.GetInvocationList())
                {
                    try
                    {
                        retVal = _afterSendEvent.Invoke(@params, retVal);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }
                }
            }

            return retVal;
        }
    }

    /// <summary>
    /// Contains necessary information to create Hooks. Does not contain any hooks
    /// </summary>
    public static class Delegates
    {
        public sealed class Params_SendEvent
        {
            public HutongGames.PlayMaker.Ecosystem.Utils.PlayMakerEvent self;
            public PlayMakerFSM fromFsm;
            public HutongGames.PlayMaker.Ecosystem.Utils.PlayMakerEventTarget eventTarget;
        }

        public delegate void SendEvent_BeforeArgs(Params_SendEvent args);

        public delegate bool SendEvent_AfterArgs(Params_SendEvent args, bool ret);

        public delegate bool SendEvent_WithArgs(
            Func<HutongGames.PlayMaker.Ecosystem.Utils.PlayMakerEvent, PlayMakerFSM,
                HutongGames.PlayMaker.Ecosystem.Utils.PlayMakerEventTarget, bool> orig,
            HutongGames.PlayMaker.Ecosystem.Utils.PlayMakerEvent self, PlayMakerFSM fromFsm,
            HutongGames.PlayMaker.Ecosystem.Utils.PlayMakerEventTarget eventTarget);
    }

    /// <summary>
    /// Contains Hooks to that run code before orig(self) is called
    /// </summary>
    public static class BeforeOrig
    {
        public static event Delegates.SendEvent_BeforeArgs SendEvent
        {
            add
            {
                HookHandler._beforeSendEvent += value;
                HookHandler.HookSendEvent();
            }
            remove => HookHandler._beforeSendEvent -= value;
        }
    }

    /// <summary>
    /// Contains Hooks to that run code after orig(self) is called
    /// </summary>
    public static class AfterOrig
    {
        public static event Delegates.SendEvent_AfterArgs SendEvent
        {
            add
            {
                HookHandler._afterSendEvent += value;
                HookHandler.HookSendEvent();
            }
            remove => HookHandler._afterSendEvent -= value;
        }
    }

    /// <summary>
    /// Contains all On Hooks, even those that aren't in the On namespace such as API generated functions and property getters/setters
    /// </summary>
    public static class WithOrig
    {
        public static event Delegates.SendEvent_WithArgs SendEvent
        {
            add => HookEndpointManager.Add<Delegates.SendEvent_WithArgs>(
                ReflectionHelper.GetMethodInfo(typeof(HutongGames.PlayMaker.Ecosystem.Utils.PlayMakerEvent),
                    "SendEvent", true), value);
            remove => HookEndpointManager.Remove<Delegates.SendEvent_WithArgs>(
                ReflectionHelper.GetMethodInfo(typeof(HutongGames.PlayMaker.Ecosystem.Utils.PlayMakerEvent),
                    "SendEvent", true), value);
        }
    }
}