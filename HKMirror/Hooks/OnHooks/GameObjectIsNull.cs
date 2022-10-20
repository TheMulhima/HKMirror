using MonoMod.RuntimeDetour;
using MonoMod.RuntimeDetour.HookGen;

namespace HKMirror.Hooks.OnHooks;

/// <summary>
///     Contains different types of On Hooks for GameObjectIsNull class.<br />
///     Contains hooks that aren't generated by monomod, and before and after orig hooks for easier hooking.
/// </summary>
public static class OnGameObjectIsNull
{
    internal static class HookHandler
    {
        private static readonly List<string> HookedList = new();

        internal static void HookReset()
        {
            if (!HookedList.Contains("Reset"))
            {
                HookedList.Add("Reset");
                new Hook(ReflectionHelper.GetMethodInfo(typeof(GameObjectIsNull), "Reset"), Reset);
            }
        }

        internal static event Delegates.Reset_BeforeArgs _beforeReset;
        internal static event Delegates.Reset_NormalArgs _afterReset;

        private static void Reset(Action<GameObjectIsNull> orig, GameObjectIsNull self)
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

        internal static void HookOnEnter()
        {
            if (!HookedList.Contains("OnEnter"))
            {
                HookedList.Add("OnEnter");
                new Hook(ReflectionHelper.GetMethodInfo(typeof(GameObjectIsNull), "OnEnter"), OnEnter);
            }
        }

        internal static event Delegates.OnEnter_BeforeArgs _beforeOnEnter;
        internal static event Delegates.OnEnter_NormalArgs _afterOnEnter;

        private static void OnEnter(Action<GameObjectIsNull> orig, GameObjectIsNull self)
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

        internal static void HookOnUpdate()
        {
            if (!HookedList.Contains("OnUpdate"))
            {
                HookedList.Add("OnUpdate");
                new Hook(ReflectionHelper.GetMethodInfo(typeof(GameObjectIsNull), "OnUpdate"), OnUpdate);
            }
        }

        internal static event Delegates.OnUpdate_BeforeArgs _beforeOnUpdate;
        internal static event Delegates.OnUpdate_NormalArgs _afterOnUpdate;

        private static void OnUpdate(Action<GameObjectIsNull> orig, GameObjectIsNull self)
        {
            Delegates.Params_OnUpdate @params = new()
            {
                self = self
            };
            _beforeOnUpdate?.Invoke(@params);
            self = @params.self;
            orig(self);
            if (_afterOnUpdate != null) _afterOnUpdate.Invoke(@params);
        }

        internal static void HookDoIsGameObjectNull()
        {
            if (!HookedList.Contains("DoIsGameObjectNull"))
            {
                HookedList.Add("DoIsGameObjectNull");
                new Hook(ReflectionHelper.GetMethodInfo(typeof(GameObjectIsNull), "DoIsGameObjectNull"),
                    DoIsGameObjectNull);
            }
        }

        internal static event Delegates.DoIsGameObjectNull_BeforeArgs _beforeDoIsGameObjectNull;
        internal static event Delegates.DoIsGameObjectNull_NormalArgs _afterDoIsGameObjectNull;

        private static void DoIsGameObjectNull(Action<GameObjectIsNull> orig, GameObjectIsNull self)
        {
            Delegates.Params_DoIsGameObjectNull @params = new()
            {
                self = self
            };
            _beforeDoIsGameObjectNull?.Invoke(@params);
            self = @params.self;
            orig(self);
            if (_afterDoIsGameObjectNull != null) _afterDoIsGameObjectNull.Invoke(@params);
        }
    }

    /// <summary>
    ///     Contains necessary information to create Hooks. Does not contain any hooks
    /// </summary>
    public static class Delegates
    {
        public delegate void DoIsGameObjectNull_BeforeArgs(Params_DoIsGameObjectNull args);

        public delegate void DoIsGameObjectNull_NormalArgs(Params_DoIsGameObjectNull args);

        public delegate void OnEnter_BeforeArgs(Params_OnEnter args);

        public delegate void OnEnter_NormalArgs(Params_OnEnter args);

        public delegate void OnUpdate_BeforeArgs(Params_OnUpdate args);

        public delegate void OnUpdate_NormalArgs(Params_OnUpdate args);

        public delegate void Reset_BeforeArgs(Params_Reset args);

        public delegate void Reset_NormalArgs(Params_Reset args);

        public sealed class Params_Reset
        {
            public GameObjectIsNull self;
        }

        public sealed class Params_OnEnter
        {
            public GameObjectIsNull self;
        }

        public sealed class Params_OnUpdate
        {
            public GameObjectIsNull self;
        }

        public sealed class Params_DoIsGameObjectNull
        {
            public GameObjectIsNull self;
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

        public static event Delegates.DoIsGameObjectNull_BeforeArgs DoIsGameObjectNull
        {
            add
            {
                HookHandler._beforeDoIsGameObjectNull += value;
                HookHandler.HookDoIsGameObjectNull();
            }
            remove => HookHandler._beforeDoIsGameObjectNull -= value;
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

        public static event Delegates.OnEnter_NormalArgs OnEnter
        {
            add
            {
                HookHandler._afterOnEnter += value;
                HookHandler.HookOnEnter();
            }
            remove => HookHandler._afterOnEnter -= value;
        }

        public static event Delegates.OnUpdate_NormalArgs OnUpdate
        {
            add
            {
                HookHandler._afterOnUpdate += value;
                HookHandler.HookOnUpdate();
            }
            remove => HookHandler._afterOnUpdate -= value;
        }

        public static event Delegates.DoIsGameObjectNull_NormalArgs DoIsGameObjectNull
        {
            add
            {
                HookHandler._afterDoIsGameObjectNull += value;
                HookHandler.HookDoIsGameObjectNull();
            }
            remove => HookHandler._afterDoIsGameObjectNull -= value;
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
                ReflectionHelper.GetMethodInfo(typeof(GameObjectIsNull), "Reset"), value);
            remove => HookEndpointManager.Remove<Delegates.Reset_NormalArgs>(
                ReflectionHelper.GetMethodInfo(typeof(GameObjectIsNull), "Reset"), value);
        }

        public static event Delegates.OnEnter_NormalArgs OnEnter
        {
            add => HookEndpointManager.Add<Delegates.OnEnter_NormalArgs>(
                ReflectionHelper.GetMethodInfo(typeof(GameObjectIsNull), "OnEnter"), value);
            remove => HookEndpointManager.Remove<Delegates.OnEnter_NormalArgs>(
                ReflectionHelper.GetMethodInfo(typeof(GameObjectIsNull), "OnEnter"), value);
        }

        public static event Delegates.OnUpdate_NormalArgs OnUpdate
        {
            add => HookEndpointManager.Add<Delegates.OnUpdate_NormalArgs>(
                ReflectionHelper.GetMethodInfo(typeof(GameObjectIsNull), "OnUpdate"), value);
            remove => HookEndpointManager.Remove<Delegates.OnUpdate_NormalArgs>(
                ReflectionHelper.GetMethodInfo(typeof(GameObjectIsNull), "OnUpdate"), value);
        }

        public static event Delegates.DoIsGameObjectNull_NormalArgs DoIsGameObjectNull
        {
            add => HookEndpointManager.Add<Delegates.DoIsGameObjectNull_NormalArgs>(
                ReflectionHelper.GetMethodInfo(typeof(GameObjectIsNull), "DoIsGameObjectNull"), value);
            remove => HookEndpointManager.Remove<Delegates.DoIsGameObjectNull_NormalArgs>(
                ReflectionHelper.GetMethodInfo(typeof(GameObjectIsNull), "DoIsGameObjectNull"), value);
        }
    }
}