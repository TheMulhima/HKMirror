using MonoMod.RuntimeDetour;
using MonoMod.RuntimeDetour.HookGen;

namespace HKMirror.Hooks.OnHooks;

/// <summary>
///     Contains different types of On Hooks for GetParticleCollisionInfo class.<br />
///     Contains hooks that aren't generated by monomod, and before and after orig hooks for easier hooking.
/// </summary>
public static class OnGetParticleCollisionInfo
{
    internal static class HookHandler
    {
        private static readonly List<string> HookedList = new();

        internal static void HookReset()
        {
            if (!HookedList.Contains("Reset"))
            {
                HookedList.Add("Reset");
                new Hook(ReflectionHelper.GetMethodInfo(typeof(GetParticleCollisionInfo), "Reset"), Reset);
            }
        }

        internal static event Delegates.Reset_BeforeArgs _beforeReset;
        internal static event Delegates.Reset_NormalArgs _afterReset;

        private static void Reset(Action<GetParticleCollisionInfo> orig, GetParticleCollisionInfo self)
        {
            Delegates.Params_Reset @params = new()
            {
                self = self
            };
            _beforeReset?.Invoke(@params);
            self = @params.self;
            orig(self);
            if (_afterReset != null) _afterReset.Invoke(@params);
        }

        internal static void HookStoreCollisionInfo()
        {
            if (!HookedList.Contains("StoreCollisionInfo"))
            {
                HookedList.Add("StoreCollisionInfo");
                new Hook(ReflectionHelper.GetMethodInfo(typeof(GetParticleCollisionInfo), "StoreCollisionInfo"),
                    StoreCollisionInfo);
            }
        }

        internal static event Delegates.StoreCollisionInfo_BeforeArgs _beforeStoreCollisionInfo;
        internal static event Delegates.StoreCollisionInfo_NormalArgs _afterStoreCollisionInfo;

        private static void StoreCollisionInfo(Action<GetParticleCollisionInfo> orig, GetParticleCollisionInfo self)
        {
            Delegates.Params_StoreCollisionInfo @params = new()
            {
                self = self
            };
            _beforeStoreCollisionInfo?.Invoke(@params);
            self = @params.self;
            orig(self);
            if (_afterStoreCollisionInfo != null) _afterStoreCollisionInfo.Invoke(@params);
        }

        internal static void HookOnEnter()
        {
            if (!HookedList.Contains("OnEnter"))
            {
                HookedList.Add("OnEnter");
                new Hook(ReflectionHelper.GetMethodInfo(typeof(GetParticleCollisionInfo), "OnEnter"), OnEnter);
            }
        }

        internal static event Delegates.OnEnter_BeforeArgs _beforeOnEnter;
        internal static event Delegates.OnEnter_NormalArgs _afterOnEnter;

        private static void OnEnter(Action<GetParticleCollisionInfo> orig, GetParticleCollisionInfo self)
        {
            Delegates.Params_OnEnter @params = new()
            {
                self = self
            };
            _beforeOnEnter?.Invoke(@params);
            self = @params.self;
            orig(self);
            if (_afterOnEnter != null) _afterOnEnter.Invoke(@params);
        }
    }

    /// <summary>
    ///     Contains necessary information to create Hooks. Does not contain any hooks
    /// </summary>
    public static class Delegates
    {
        public delegate void OnEnter_BeforeArgs(Params_OnEnter args);

        public delegate void OnEnter_NormalArgs(Params_OnEnter args);

        public delegate void Reset_BeforeArgs(Params_Reset args);

        public delegate void Reset_NormalArgs(Params_Reset args);

        public delegate void StoreCollisionInfo_BeforeArgs(Params_StoreCollisionInfo args);

        public delegate void StoreCollisionInfo_NormalArgs(Params_StoreCollisionInfo args);

        public sealed class Params_Reset
        {
            public GetParticleCollisionInfo self;
        }

        public sealed class Params_StoreCollisionInfo
        {
            public GetParticleCollisionInfo self;
        }

        public sealed class Params_OnEnter
        {
            public GetParticleCollisionInfo self;
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

        public static event Delegates.StoreCollisionInfo_BeforeArgs StoreCollisionInfo
        {
            add
            {
                HookHandler._beforeStoreCollisionInfo += value;
                HookHandler.HookStoreCollisionInfo();
            }
            remove => HookHandler._beforeStoreCollisionInfo -= value;
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
        public static event Delegates.Reset_NormalArgs Reset
        {
            add
            {
                HookHandler._afterReset += value;
                HookHandler.HookReset();
            }
            remove => HookHandler._afterReset -= value;
        }

        public static event Delegates.StoreCollisionInfo_NormalArgs StoreCollisionInfo
        {
            add
            {
                HookHandler._afterStoreCollisionInfo += value;
                HookHandler.HookStoreCollisionInfo();
            }
            remove => HookHandler._afterStoreCollisionInfo -= value;
        }

        public static event Delegates.OnEnter_NormalArgs OnEnter
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
        public static event Delegates.Reset_NormalArgs Reset
        {
            add => HookEndpointManager.Add<Delegates.Reset_NormalArgs>(
                ReflectionHelper.GetMethodInfo(typeof(GetParticleCollisionInfo), "Reset"), value);
            remove => HookEndpointManager.Remove<Delegates.Reset_NormalArgs>(
                ReflectionHelper.GetMethodInfo(typeof(GetParticleCollisionInfo), "Reset"), value);
        }

        public static event Delegates.StoreCollisionInfo_NormalArgs StoreCollisionInfo
        {
            add => HookEndpointManager.Add<Delegates.StoreCollisionInfo_NormalArgs>(
                ReflectionHelper.GetMethodInfo(typeof(GetParticleCollisionInfo), "StoreCollisionInfo"), value);
            remove => HookEndpointManager.Remove<Delegates.StoreCollisionInfo_NormalArgs>(
                ReflectionHelper.GetMethodInfo(typeof(GetParticleCollisionInfo), "StoreCollisionInfo"), value);
        }

        public static event Delegates.OnEnter_NormalArgs OnEnter
        {
            add => HookEndpointManager.Add<Delegates.OnEnter_NormalArgs>(
                ReflectionHelper.GetMethodInfo(typeof(GetParticleCollisionInfo), "OnEnter"), value);
            remove => HookEndpointManager.Remove<Delegates.OnEnter_NormalArgs>(
                ReflectionHelper.GetMethodInfo(typeof(GetParticleCollisionInfo), "OnEnter"), value);
        }
    }
}