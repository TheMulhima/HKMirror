using MonoMod.RuntimeDetour;
using MonoMod.RuntimeDetour.HookGen;

namespace HKMirror.Hooks.OnHooks;

/// <summary>
/// Contains different types of On Hooks for MousePick2dEvent class.<br />
/// Contains hooks that aren't generated by monomod, and before and after orig hooks for easier hooking.
/// </summary>
public static class OnMousePick2dEvent
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
                    ReflectionHelper.GetMethodInfo(typeof(HutongGames.PlayMaker.Actions.MousePick2dEvent), "Reset",
                        true), Reset);
            }
        }

        internal static event Delegates.Reset_BeforeArgs _beforeReset;
        internal static event Delegates.Reset_AfterArgs _afterReset;

        private static void Reset(Action<HutongGames.PlayMaker.Actions.MousePick2dEvent> orig,
            HutongGames.PlayMaker.Actions.MousePick2dEvent self)
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

        internal static void HookOnEnter()
        {
            if (!HookedList.Contains("OnEnter"))
            {
                HookedList.Add("OnEnter");
                new Hook(
                    ReflectionHelper.GetMethodInfo(typeof(HutongGames.PlayMaker.Actions.MousePick2dEvent), "OnEnter",
                        true), OnEnter);
            }
        }

        internal static event Delegates.OnEnter_BeforeArgs _beforeOnEnter;
        internal static event Delegates.OnEnter_AfterArgs _afterOnEnter;

        private static void OnEnter(Action<HutongGames.PlayMaker.Actions.MousePick2dEvent> orig,
            HutongGames.PlayMaker.Actions.MousePick2dEvent self)
        {
            Delegates.Params_OnEnter @params = new()
            {
                self = self
            };
            if (_beforeOnEnter != null)
            {
                foreach (Delegates.OnEnter_BeforeArgs toInvoke in _beforeOnEnter.GetInvocationList())
                {
                    try
                    {
                        _beforeOnEnter?.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }
                }
            }

            self = @params.self;
            orig(self);
            if (_afterOnEnter != null)
            {
                foreach (Delegates.OnEnter_AfterArgs toInvoke in _afterOnEnter.GetInvocationList())
                {
                    try
                    {
                        _afterOnEnter.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }
                }
            }
        }

        internal static void HookOnUpdate()
        {
            if (!HookedList.Contains("OnUpdate"))
            {
                HookedList.Add("OnUpdate");
                new Hook(
                    ReflectionHelper.GetMethodInfo(typeof(HutongGames.PlayMaker.Actions.MousePick2dEvent), "OnUpdate",
                        true), OnUpdate);
            }
        }

        internal static event Delegates.OnUpdate_BeforeArgs _beforeOnUpdate;
        internal static event Delegates.OnUpdate_AfterArgs _afterOnUpdate;

        private static void OnUpdate(Action<HutongGames.PlayMaker.Actions.MousePick2dEvent> orig,
            HutongGames.PlayMaker.Actions.MousePick2dEvent self)
        {
            Delegates.Params_OnUpdate @params = new()
            {
                self = self
            };
            if (_beforeOnUpdate != null)
            {
                foreach (Delegates.OnUpdate_BeforeArgs toInvoke in _beforeOnUpdate.GetInvocationList())
                {
                    try
                    {
                        _beforeOnUpdate?.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }
                }
            }

            self = @params.self;
            orig(self);
            if (_afterOnUpdate != null)
            {
                foreach (Delegates.OnUpdate_AfterArgs toInvoke in _afterOnUpdate.GetInvocationList())
                {
                    try
                    {
                        _afterOnUpdate.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }
                }
            }
        }

        internal static void HookDoMousePickEvent()
        {
            if (!HookedList.Contains("DoMousePickEvent"))
            {
                HookedList.Add("DoMousePickEvent");
                new Hook(
                    ReflectionHelper.GetMethodInfo(typeof(HutongGames.PlayMaker.Actions.MousePick2dEvent),
                        "DoMousePickEvent", true), DoMousePickEvent);
            }
        }

        internal static event Delegates.DoMousePickEvent_BeforeArgs _beforeDoMousePickEvent;
        internal static event Delegates.DoMousePickEvent_AfterArgs _afterDoMousePickEvent;

        private static void DoMousePickEvent(Action<HutongGames.PlayMaker.Actions.MousePick2dEvent> orig,
            HutongGames.PlayMaker.Actions.MousePick2dEvent self)
        {
            Delegates.Params_DoMousePickEvent @params = new()
            {
                self = self
            };
            if (_beforeDoMousePickEvent != null)
            {
                foreach (Delegates.DoMousePickEvent_BeforeArgs toInvoke in _beforeDoMousePickEvent.GetInvocationList())
                {
                    try
                    {
                        _beforeDoMousePickEvent?.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }
                }
            }

            self = @params.self;
            orig(self);
            if (_afterDoMousePickEvent != null)
            {
                foreach (Delegates.DoMousePickEvent_AfterArgs toInvoke in _afterDoMousePickEvent.GetInvocationList())
                {
                    try
                    {
                        _afterDoMousePickEvent.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }
                }
            }
        }

        internal static void HookDoRaycast()
        {
            if (!HookedList.Contains("DoRaycast"))
            {
                HookedList.Add("DoRaycast");
                new Hook(
                    ReflectionHelper.GetMethodInfo(typeof(HutongGames.PlayMaker.Actions.MousePick2dEvent), "DoRaycast",
                        true), DoRaycast);
            }
        }

        internal static event Delegates.DoRaycast_BeforeArgs _beforeDoRaycast;
        internal static event Delegates.DoRaycast_AfterArgs _afterDoRaycast;

        private static bool DoRaycast(Func<HutongGames.PlayMaker.Actions.MousePick2dEvent, bool> orig,
            HutongGames.PlayMaker.Actions.MousePick2dEvent self)
        {
            Delegates.Params_DoRaycast @params = new()
            {
                self = self
            };
            if (_beforeDoRaycast != null)
            {
                foreach (Delegates.DoRaycast_BeforeArgs toInvoke in _beforeDoRaycast.GetInvocationList())
                {
                    try
                    {
                        _beforeDoRaycast?.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }
                }
            }

            self = @params.self;
            var retVal = orig(self);
            if (_afterDoRaycast != null)
            {
                foreach (Delegates.DoRaycast_AfterArgs toInvoke in _afterDoRaycast.GetInvocationList())
                {
                    try
                    {
                        retVal = _afterDoRaycast.Invoke(@params, retVal);
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
            public HutongGames.PlayMaker.Actions.MousePick2dEvent self;
        }

        public delegate void Reset_BeforeArgs(Params_Reset args);

        public delegate void Reset_AfterArgs(Params_Reset args);

        public delegate void Reset_WithArgs(Action<HutongGames.PlayMaker.Actions.MousePick2dEvent> orig,
            HutongGames.PlayMaker.Actions.MousePick2dEvent self);

        public sealed class Params_OnEnter
        {
            public HutongGames.PlayMaker.Actions.MousePick2dEvent self;
        }

        public delegate void OnEnter_BeforeArgs(Params_OnEnter args);

        public delegate void OnEnter_AfterArgs(Params_OnEnter args);

        public delegate void OnEnter_WithArgs(Action<HutongGames.PlayMaker.Actions.MousePick2dEvent> orig,
            HutongGames.PlayMaker.Actions.MousePick2dEvent self);

        public sealed class Params_OnUpdate
        {
            public HutongGames.PlayMaker.Actions.MousePick2dEvent self;
        }

        public delegate void OnUpdate_BeforeArgs(Params_OnUpdate args);

        public delegate void OnUpdate_AfterArgs(Params_OnUpdate args);

        public delegate void OnUpdate_WithArgs(Action<HutongGames.PlayMaker.Actions.MousePick2dEvent> orig,
            HutongGames.PlayMaker.Actions.MousePick2dEvent self);

        public sealed class Params_DoMousePickEvent
        {
            public HutongGames.PlayMaker.Actions.MousePick2dEvent self;
        }

        public delegate void DoMousePickEvent_BeforeArgs(Params_DoMousePickEvent args);

        public delegate void DoMousePickEvent_AfterArgs(Params_DoMousePickEvent args);

        public delegate void DoMousePickEvent_WithArgs(Action<HutongGames.PlayMaker.Actions.MousePick2dEvent> orig,
            HutongGames.PlayMaker.Actions.MousePick2dEvent self);

        public sealed class Params_DoRaycast
        {
            public HutongGames.PlayMaker.Actions.MousePick2dEvent self;
        }

        public delegate void DoRaycast_BeforeArgs(Params_DoRaycast args);

        public delegate bool DoRaycast_AfterArgs(Params_DoRaycast args, bool ret);

        public delegate bool DoRaycast_WithArgs(Func<HutongGames.PlayMaker.Actions.MousePick2dEvent, bool> orig,
            HutongGames.PlayMaker.Actions.MousePick2dEvent self);
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

        public static event Delegates.OnEnter_BeforeArgs OnEnter
        {
            add
            {
                HookHandler._beforeOnEnter += value;
                HookHandler.HookOnEnter();
            }
            remove => HookHandler._beforeOnEnter -= value;
        }

        public static event Delegates.OnUpdate_BeforeArgs OnUpdate
        {
            add
            {
                HookHandler._beforeOnUpdate += value;
                HookHandler.HookOnUpdate();
            }
            remove => HookHandler._beforeOnUpdate -= value;
        }

        public static event Delegates.DoMousePickEvent_BeforeArgs DoMousePickEvent
        {
            add
            {
                HookHandler._beforeDoMousePickEvent += value;
                HookHandler.HookDoMousePickEvent();
            }
            remove => HookHandler._beforeDoMousePickEvent -= value;
        }

        public static event Delegates.DoRaycast_BeforeArgs DoRaycast
        {
            add
            {
                HookHandler._beforeDoRaycast += value;
                HookHandler.HookDoRaycast();
            }
            remove => HookHandler._beforeDoRaycast -= value;
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

        public static event Delegates.OnEnter_AfterArgs OnEnter
        {
            add
            {
                HookHandler._afterOnEnter += value;
                HookHandler.HookOnEnter();
            }
            remove => HookHandler._afterOnEnter -= value;
        }

        public static event Delegates.OnUpdate_AfterArgs OnUpdate
        {
            add
            {
                HookHandler._afterOnUpdate += value;
                HookHandler.HookOnUpdate();
            }
            remove => HookHandler._afterOnUpdate -= value;
        }

        public static event Delegates.DoMousePickEvent_AfterArgs DoMousePickEvent
        {
            add
            {
                HookHandler._afterDoMousePickEvent += value;
                HookHandler.HookDoMousePickEvent();
            }
            remove => HookHandler._afterDoMousePickEvent -= value;
        }

        public static event Delegates.DoRaycast_AfterArgs DoRaycast
        {
            add
            {
                HookHandler._afterDoRaycast += value;
                HookHandler.HookDoRaycast();
            }
            remove => HookHandler._afterDoRaycast -= value;
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
                ReflectionHelper.GetMethodInfo(typeof(HutongGames.PlayMaker.Actions.MousePick2dEvent), "Reset", true),
                value);
            remove => HookEndpointManager.Remove<Delegates.Reset_WithArgs>(
                ReflectionHelper.GetMethodInfo(typeof(HutongGames.PlayMaker.Actions.MousePick2dEvent), "Reset", true),
                value);
        }

        public static event Delegates.OnEnter_WithArgs OnEnter
        {
            add => HookEndpointManager.Add<Delegates.OnEnter_WithArgs>(
                ReflectionHelper.GetMethodInfo(typeof(HutongGames.PlayMaker.Actions.MousePick2dEvent), "OnEnter", true),
                value);
            remove => HookEndpointManager.Remove<Delegates.OnEnter_WithArgs>(
                ReflectionHelper.GetMethodInfo(typeof(HutongGames.PlayMaker.Actions.MousePick2dEvent), "OnEnter", true),
                value);
        }

        public static event Delegates.OnUpdate_WithArgs OnUpdate
        {
            add => HookEndpointManager.Add<Delegates.OnUpdate_WithArgs>(
                ReflectionHelper.GetMethodInfo(typeof(HutongGames.PlayMaker.Actions.MousePick2dEvent), "OnUpdate",
                    true), value);
            remove => HookEndpointManager.Remove<Delegates.OnUpdate_WithArgs>(
                ReflectionHelper.GetMethodInfo(typeof(HutongGames.PlayMaker.Actions.MousePick2dEvent), "OnUpdate",
                    true), value);
        }

        public static event Delegates.DoMousePickEvent_WithArgs DoMousePickEvent
        {
            add => HookEndpointManager.Add<Delegates.DoMousePickEvent_WithArgs>(
                ReflectionHelper.GetMethodInfo(typeof(HutongGames.PlayMaker.Actions.MousePick2dEvent),
                    "DoMousePickEvent", true), value);
            remove => HookEndpointManager.Remove<Delegates.DoMousePickEvent_WithArgs>(
                ReflectionHelper.GetMethodInfo(typeof(HutongGames.PlayMaker.Actions.MousePick2dEvent),
                    "DoMousePickEvent", true), value);
        }

        public static event Delegates.DoRaycast_WithArgs DoRaycast
        {
            add => HookEndpointManager.Add<Delegates.DoRaycast_WithArgs>(
                ReflectionHelper.GetMethodInfo(typeof(HutongGames.PlayMaker.Actions.MousePick2dEvent), "DoRaycast",
                    true), value);
            remove => HookEndpointManager.Remove<Delegates.DoRaycast_WithArgs>(
                ReflectionHelper.GetMethodInfo(typeof(HutongGames.PlayMaker.Actions.MousePick2dEvent), "DoRaycast",
                    true), value);
        }
    }
}