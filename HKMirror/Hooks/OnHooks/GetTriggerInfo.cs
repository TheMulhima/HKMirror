using MonoMod.RuntimeDetour;
using MonoMod.RuntimeDetour.HookGen;

namespace HKMirror.Hooks.OnHooks;

/// <summary>
///     Contains different types of On Hooks for GetTriggerInfo class.<br />
///     Contains hooks that aren't generated by monomod, and before and after orig hooks for easier hooking.
/// </summary>
public static class OnGetTriggerInfo
{
    internal static class HookHandler
    {
        private static readonly List<string> HookedList = new();

        internal static void HookReset()
        {
            if (!HookedList.Contains("Reset"))
            {
                HookedList.Add("Reset");
                new Hook(ReflectionHelper.GetMethodInfo(typeof(GetTriggerInfo), "Reset"), Reset);
            }
        }

        internal static event Delegates.Reset_BeforeArgs _beforeReset;
        internal static event Delegates.Reset_AfterArgs _afterReset;

        private static void Reset(Action<GetTriggerInfo> orig, GetTriggerInfo self)
        {
            Delegates.Params_Reset @params = new()
            {
                self = self
            };
            if (_beforeReset != null)
                foreach (Delegates.Reset_BeforeArgs toInvoke in _beforeReset.GetInvocationList())
                    try
                    {
                        _beforeReset?.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }

            self = @params.self;
            orig(self);
            if (_afterReset != null)
                foreach (Delegates.Reset_AfterArgs toInvoke in _afterReset.GetInvocationList())
                    try
                    {
                        _afterReset.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }
        }

        internal static void HookStoreTriggerInfo()
        {
            if (!HookedList.Contains("StoreTriggerInfo"))
            {
                HookedList.Add("StoreTriggerInfo");
                new Hook(ReflectionHelper.GetMethodInfo(typeof(GetTriggerInfo), "StoreTriggerInfo"), StoreTriggerInfo);
            }
        }

        internal static event Delegates.StoreTriggerInfo_BeforeArgs _beforeStoreTriggerInfo;
        internal static event Delegates.StoreTriggerInfo_AfterArgs _afterStoreTriggerInfo;

        private static void StoreTriggerInfo(Action<GetTriggerInfo> orig, GetTriggerInfo self)
        {
            Delegates.Params_StoreTriggerInfo @params = new()
            {
                self = self
            };
            if (_beforeStoreTriggerInfo != null)
                foreach (Delegates.StoreTriggerInfo_BeforeArgs toInvoke in _beforeStoreTriggerInfo.GetInvocationList())
                    try
                    {
                        _beforeStoreTriggerInfo?.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }

            self = @params.self;
            orig(self);
            if (_afterStoreTriggerInfo != null)
                foreach (Delegates.StoreTriggerInfo_AfterArgs toInvoke in _afterStoreTriggerInfo.GetInvocationList())
                    try
                    {
                        _afterStoreTriggerInfo.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }
        }

        internal static void HookOnEnter()
        {
            if (!HookedList.Contains("OnEnter"))
            {
                HookedList.Add("OnEnter");
                new Hook(ReflectionHelper.GetMethodInfo(typeof(GetTriggerInfo), "OnEnter"), OnEnter);
            }
        }

        internal static event Delegates.OnEnter_BeforeArgs _beforeOnEnter;
        internal static event Delegates.OnEnter_AfterArgs _afterOnEnter;

        private static void OnEnter(Action<GetTriggerInfo> orig, GetTriggerInfo self)
        {
            Delegates.Params_OnEnter @params = new()
            {
                self = self
            };
            if (_beforeOnEnter != null)
                foreach (Delegates.OnEnter_BeforeArgs toInvoke in _beforeOnEnter.GetInvocationList())
                    try
                    {
                        _beforeOnEnter?.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }

            self = @params.self;
            orig(self);
            if (_afterOnEnter != null)
                foreach (Delegates.OnEnter_AfterArgs toInvoke in _afterOnEnter.GetInvocationList())
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

    /// <summary>
    ///     Contains necessary information to create Hooks. Does not contain any hooks
    /// </summary>
    public static class Delegates
    {
        public delegate void OnEnter_AfterArgs(Params_OnEnter args);

        public delegate void OnEnter_BeforeArgs(Params_OnEnter args);

        public delegate void OnEnter_WithArgs(Action<GetTriggerInfo> orig, GetTriggerInfo self);

        public delegate void Reset_AfterArgs(Params_Reset args);

        public delegate void Reset_BeforeArgs(Params_Reset args);

        public delegate void Reset_WithArgs(Action<GetTriggerInfo> orig, GetTriggerInfo self);

        public delegate void StoreTriggerInfo_AfterArgs(Params_StoreTriggerInfo args);

        public delegate void StoreTriggerInfo_BeforeArgs(Params_StoreTriggerInfo args);

        public delegate void StoreTriggerInfo_WithArgs(Action<GetTriggerInfo> orig, GetTriggerInfo self);

        public sealed class Params_Reset
        {
            public GetTriggerInfo self;
        }

        public sealed class Params_StoreTriggerInfo
        {
            public GetTriggerInfo self;
        }

        public sealed class Params_OnEnter
        {
            public GetTriggerInfo self;
        }
    }

    /// <summary>
    ///     Contains Hooks to that run code before orig(self) is called
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

        public static event Delegates.StoreTriggerInfo_BeforeArgs StoreTriggerInfo
        {
            add
            {
                HookHandler._beforeStoreTriggerInfo += value;
                HookHandler.HookStoreTriggerInfo();
            }
            remove => HookHandler._beforeStoreTriggerInfo -= value;
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
    }

    /// <summary>
    ///     Contains Hooks to that run code after orig(self) is called
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

        public static event Delegates.StoreTriggerInfo_AfterArgs StoreTriggerInfo
        {
            add
            {
                HookHandler._afterStoreTriggerInfo += value;
                HookHandler.HookStoreTriggerInfo();
            }
            remove => HookHandler._afterStoreTriggerInfo -= value;
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
    }

    /// <summary>
    ///     Contains all On Hooks, even those that aren't in the On namespace such as API generated functions and property
    ///     getters/setters
    /// </summary>
    public static class WithOrig
    {
        public static event Delegates.Reset_WithArgs Reset
        {
            add => HookEndpointManager.Add<Delegates.Reset_WithArgs>(
                ReflectionHelper.GetMethodInfo(typeof(GetTriggerInfo), "Reset"), value);
            remove => HookEndpointManager.Remove<Delegates.Reset_WithArgs>(
                ReflectionHelper.GetMethodInfo(typeof(GetTriggerInfo), "Reset"), value);
        }

        public static event Delegates.StoreTriggerInfo_WithArgs StoreTriggerInfo
        {
            add => HookEndpointManager.Add<Delegates.StoreTriggerInfo_WithArgs>(
                ReflectionHelper.GetMethodInfo(typeof(GetTriggerInfo), "StoreTriggerInfo"), value);
            remove => HookEndpointManager.Remove<Delegates.StoreTriggerInfo_WithArgs>(
                ReflectionHelper.GetMethodInfo(typeof(GetTriggerInfo), "StoreTriggerInfo"), value);
        }

        public static event Delegates.OnEnter_WithArgs OnEnter
        {
            add => HookEndpointManager.Add<Delegates.OnEnter_WithArgs>(
                ReflectionHelper.GetMethodInfo(typeof(GetTriggerInfo), "OnEnter"), value);
            remove => HookEndpointManager.Remove<Delegates.OnEnter_WithArgs>(
                ReflectionHelper.GetMethodInfo(typeof(GetTriggerInfo), "OnEnter"), value);
        }
    }
}