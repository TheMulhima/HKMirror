using MonoMod.RuntimeDetour;
using MonoMod.RuntimeDetour.HookGen;

namespace HKMirror.Hooks.OnHooks;

/// <summary>
/// Contains different types of On Hooks for ForwardEvent class.<br />
/// Contains hooks that aren't generated by monomod, and before and after orig hooks for easier hooking.
/// </summary>
public static class OnForwardEvent
{
    internal static class HookHandler
    {
        private static List<string> HookedList = new List<string>();

        internal static void HookReset()
        {
            if (!HookedList.Contains("Reset"))
            {
                HookedList.Add("Reset");
                new Hook(
                    ReflectionHelper.GetMethodInfo(typeof(HutongGames.PlayMaker.Actions.ForwardEvent), "Reset", true),
                    Reset);
            }
        }

        internal static event Delegates.Reset_BeforeArgs _beforeReset;
        internal static event Delegates.Reset_AfterArgs _afterReset;

        private static void Reset(Action<HutongGames.PlayMaker.Actions.ForwardEvent> orig,
            HutongGames.PlayMaker.Actions.ForwardEvent self)
        {
            Delegates.Params_Reset @params = new()
            {
                self = self
            };
            if (_beforeReset != null)
            {
                foreach (Delegates.Reset_BeforeArgs toInvoke in _beforeReset.GetInvocationList())
                {
                    try
                    {
                        _beforeReset?.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }
                }
            }

            self = @params.self;
            orig(self);
            if (_afterReset != null)
            {
                foreach (Delegates.Reset_AfterArgs toInvoke in _afterReset.GetInvocationList())
                {
                    try
                    {
                        _afterReset.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }
                }
            }
        }

        internal static void HookEvent()
        {
            if (!HookedList.Contains("Event"))
            {
                HookedList.Add("Event");
                new Hook(
                    ReflectionHelper.GetMethodInfo(typeof(HutongGames.PlayMaker.Actions.ForwardEvent), "Event", true),
                    Event);
            }
        }

        internal static event Delegates.Event_BeforeArgs _beforeEvent;
        internal static event Delegates.Event_AfterArgs _afterEvent;

        private static bool Event(
            Func<HutongGames.PlayMaker.Actions.ForwardEvent, HutongGames.PlayMaker.FsmEvent, bool> orig,
            HutongGames.PlayMaker.Actions.ForwardEvent self, HutongGames.PlayMaker.FsmEvent fsmEvent)
        {
            Delegates.Params_Event @params = new()
            {
                self = self, fsmEvent = fsmEvent
            };
            if (_beforeEvent != null)
            {
                foreach (Delegates.Event_BeforeArgs toInvoke in _beforeEvent.GetInvocationList())
                {
                    try
                    {
                        _beforeEvent?.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }
                }
            }

            self = @params.self;
            fsmEvent = @params.fsmEvent;
            var retVal = orig(self, fsmEvent);
            if (_afterEvent != null)
            {
                foreach (Delegates.Event_AfterArgs toInvoke in _afterEvent.GetInvocationList())
                {
                    try
                    {
                        retVal = _afterEvent.Invoke(@params, retVal);
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
        public sealed class Params_Reset
        {
            public HutongGames.PlayMaker.Actions.ForwardEvent self;
        }

        public delegate void Reset_BeforeArgs(Params_Reset args);

        public delegate void Reset_AfterArgs(Params_Reset args);

        public delegate void Reset_WithArgs(Action<HutongGames.PlayMaker.Actions.ForwardEvent> orig,
            HutongGames.PlayMaker.Actions.ForwardEvent self);

        public sealed class Params_Event
        {
            public HutongGames.PlayMaker.Actions.ForwardEvent self;
            public HutongGames.PlayMaker.FsmEvent fsmEvent;
        }

        public delegate void Event_BeforeArgs(Params_Event args);

        public delegate bool Event_AfterArgs(Params_Event args, bool ret);

        public delegate bool Event_WithArgs(
            Func<HutongGames.PlayMaker.Actions.ForwardEvent, HutongGames.PlayMaker.FsmEvent, bool> orig,
            HutongGames.PlayMaker.Actions.ForwardEvent self, HutongGames.PlayMaker.FsmEvent fsmEvent);
    }

    /// <summary>
    /// Contains Hooks to that run code before orig(self) is called
    /// </summary>
    public static class BeforeOrig
    {
        public static event Delegates.Reset_BeforeArgs Reset
        {
            add
            {
                HookHandler._beforeReset += value;
                HookHandler.HookReset();
            }
            remove => HookHandler._beforeReset -= value;
        }

        public static event Delegates.Event_BeforeArgs Event
        {
            add
            {
                HookHandler._beforeEvent += value;
                HookHandler.HookEvent();
            }
            remove => HookHandler._beforeEvent -= value;
        }
    }

    /// <summary>
    /// Contains Hooks to that run code after orig(self) is called
    /// </summary>
    public static class AfterOrig
    {
        public static event Delegates.Reset_AfterArgs Reset
        {
            add
            {
                HookHandler._afterReset += value;
                HookHandler.HookReset();
            }
            remove => HookHandler._afterReset -= value;
        }

        public static event Delegates.Event_AfterArgs Event
        {
            add
            {
                HookHandler._afterEvent += value;
                HookHandler.HookEvent();
            }
            remove => HookHandler._afterEvent -= value;
        }
    }

    /// <summary>
    /// Contains all On Hooks, even those that aren't in the On namespace such as API generated functions and property getters/setters
    /// </summary>
    public static class WithOrig
    {
        public static event Delegates.Reset_WithArgs Reset
        {
            add => HookEndpointManager.Add<Delegates.Reset_WithArgs>(
                ReflectionHelper.GetMethodInfo(typeof(HutongGames.PlayMaker.Actions.ForwardEvent), "Reset", true),
                value);
            remove => HookEndpointManager.Remove<Delegates.Reset_WithArgs>(
                ReflectionHelper.GetMethodInfo(typeof(HutongGames.PlayMaker.Actions.ForwardEvent), "Reset", true),
                value);
        }

        public static event Delegates.Event_WithArgs Event
        {
            add => HookEndpointManager.Add<Delegates.Event_WithArgs>(
                ReflectionHelper.GetMethodInfo(typeof(HutongGames.PlayMaker.Actions.ForwardEvent), "Event", true),
                value);
            remove => HookEndpointManager.Remove<Delegates.Event_WithArgs>(
                ReflectionHelper.GetMethodInfo(typeof(HutongGames.PlayMaker.Actions.ForwardEvent), "Event", true),
                value);
        }
    }
}