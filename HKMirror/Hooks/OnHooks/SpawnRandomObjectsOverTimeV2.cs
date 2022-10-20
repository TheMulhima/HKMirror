using MonoMod.RuntimeDetour;
using MonoMod.RuntimeDetour.HookGen;

namespace HKMirror.Hooks.OnHooks;

/// <summary>
///     Contains different types of On Hooks for SpawnRandomObjectsOverTimeV2 class.<br />
///     Contains hooks that aren't generated by monomod, and before and after orig hooks for easier hooking.
/// </summary>
public static class OnSpawnRandomObjectsOverTimeV2
{
    internal static class HookHandler
    {
        private static readonly List<string> HookedList = new();

        internal static void HookOnEnter()
        {
            if (!HookedList.Contains("OnEnter"))
            {
                HookedList.Add("OnEnter");
                new Hook(ReflectionHelper.GetMethodInfo(typeof(SpawnRandomObjectsOverTimeV2), "OnEnter"), OnEnter);
            }
        }

        internal static event Delegates.OnEnter_BeforeArgs _beforeOnEnter;
        internal static event Delegates.OnEnter_NormalArgs _afterOnEnter;

        private static void OnEnter(Action<SpawnRandomObjectsOverTimeV2> orig, SpawnRandomObjectsOverTimeV2 self)
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

        internal static void HookReset()
        {
            if (!HookedList.Contains("Reset"))
            {
                HookedList.Add("Reset");
                new Hook(ReflectionHelper.GetMethodInfo(typeof(SpawnRandomObjectsOverTimeV2), "Reset"), Reset);
            }
        }

        internal static event Delegates.Reset_BeforeArgs _beforeReset;
        internal static event Delegates.Reset_NormalArgs _afterReset;

        private static void Reset(Action<SpawnRandomObjectsOverTimeV2> orig, SpawnRandomObjectsOverTimeV2 self)
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

        internal static void HookOnUpdate()
        {
            if (!HookedList.Contains("OnUpdate"))
            {
                HookedList.Add("OnUpdate");
                new Hook(ReflectionHelper.GetMethodInfo(typeof(SpawnRandomObjectsOverTimeV2), "OnUpdate"), OnUpdate);
            }
        }

        internal static event Delegates.OnUpdate_BeforeArgs _beforeOnUpdate;
        internal static event Delegates.OnUpdate_NormalArgs _afterOnUpdate;

        private static void OnUpdate(Action<SpawnRandomObjectsOverTimeV2> orig, SpawnRandomObjectsOverTimeV2 self)
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

        internal static void HookDoSpawn()
        {
            if (!HookedList.Contains("DoSpawn"))
            {
                HookedList.Add("DoSpawn");
                new Hook(ReflectionHelper.GetMethodInfo(typeof(SpawnRandomObjectsOverTimeV2), "DoSpawn"), DoSpawn);
            }
        }

        internal static event Delegates.DoSpawn_BeforeArgs _beforeDoSpawn;
        internal static event Delegates.DoSpawn_NormalArgs _afterDoSpawn;

        private static void DoSpawn(Action<SpawnRandomObjectsOverTimeV2> orig, SpawnRandomObjectsOverTimeV2 self)
        {
            Delegates.Params_DoSpawn @params = new()
            {
                self = self
            };
            _beforeDoSpawn?.Invoke(@params);
            self = @params.self;
            orig(self);
            if (_afterDoSpawn != null) _afterDoSpawn.Invoke(@params);
        }
    }

    /// <summary>
    ///     Contains necessary information to create Hooks. Does not contain any hooks
    /// </summary>
    public static class Delegates
    {
        public delegate void DoSpawn_BeforeArgs(Params_DoSpawn args);

        public delegate void DoSpawn_NormalArgs(Params_DoSpawn args);

        public delegate void OnEnter_BeforeArgs(Params_OnEnter args);

        public delegate void OnEnter_NormalArgs(Params_OnEnter args);

        public delegate void OnUpdate_BeforeArgs(Params_OnUpdate args);

        public delegate void OnUpdate_NormalArgs(Params_OnUpdate args);

        public delegate void Reset_BeforeArgs(Params_Reset args);

        public delegate void Reset_NormalArgs(Params_Reset args);

        public sealed class Params_OnEnter
        {
            public SpawnRandomObjectsOverTimeV2 self;
        }

        public sealed class Params_Reset
        {
            public SpawnRandomObjectsOverTimeV2 self;
        }

        public sealed class Params_OnUpdate
        {
            public SpawnRandomObjectsOverTimeV2 self;
        }

        public sealed class Params_DoSpawn
        {
            public SpawnRandomObjectsOverTimeV2 self;
        }
    }

    /// <summary>
    ///     Contains Hooks to that run code before orig(self) is called
    /// </summary>
    public static class BeforeOrig
    {
        public static event Delegates.OnEnter_BeforeArgs OnEnter
        {
            add
            {
                HookHandler._beforeOnEnter += value;
                HookHandler.HookOnEnter();
            }
            remove => HookHandler._beforeOnEnter -= value;
        }

        public static event Delegates.Reset_BeforeArgs Reset
        {
            add
            {
                HookHandler._beforeReset += value;
                HookHandler.HookReset();
            }
            remove => HookHandler._beforeReset -= value;
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

        public static event Delegates.DoSpawn_BeforeArgs DoSpawn
        {
            add
            {
                HookHandler._beforeDoSpawn += value;
                HookHandler.HookDoSpawn();
            }
            remove => HookHandler._beforeDoSpawn -= value;
        }
    }

    /// <summary>
    ///     Contains Hooks to that run code after orig(self) is called
    /// </summary>
    public static class AfterOrig
    {
        public static event Delegates.OnEnter_NormalArgs OnEnter
        {
            add
            {
                HookHandler._afterOnEnter += value;
                HookHandler.HookOnEnter();
            }
            remove => HookHandler._afterOnEnter -= value;
        }

        public static event Delegates.Reset_NormalArgs Reset
        {
            add
            {
                HookHandler._afterReset += value;
                HookHandler.HookReset();
            }
            remove => HookHandler._afterReset -= value;
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

        public static event Delegates.DoSpawn_NormalArgs DoSpawn
        {
            add
            {
                HookHandler._afterDoSpawn += value;
                HookHandler.HookDoSpawn();
            }
            remove => HookHandler._afterDoSpawn -= value;
        }
    }

    /// <summary>
    ///     Contains all On Hooks, even those that aren't in the On namespace such as API generated functions and property
    ///     getters/setters
    /// </summary>
    public static class WithOrig
    {
        public static event Delegates.OnEnter_NormalArgs OnEnter
        {
            add => HookEndpointManager.Add<Delegates.OnEnter_NormalArgs>(
                ReflectionHelper.GetMethodInfo(typeof(SpawnRandomObjectsOverTimeV2), "OnEnter"), value);
            remove => HookEndpointManager.Remove<Delegates.OnEnter_NormalArgs>(
                ReflectionHelper.GetMethodInfo(typeof(SpawnRandomObjectsOverTimeV2), "OnEnter"), value);
        }

        public static event Delegates.Reset_NormalArgs Reset
        {
            add => HookEndpointManager.Add<Delegates.Reset_NormalArgs>(
                ReflectionHelper.GetMethodInfo(typeof(SpawnRandomObjectsOverTimeV2), "Reset"), value);
            remove => HookEndpointManager.Remove<Delegates.Reset_NormalArgs>(
                ReflectionHelper.GetMethodInfo(typeof(SpawnRandomObjectsOverTimeV2), "Reset"), value);
        }

        public static event Delegates.OnUpdate_NormalArgs OnUpdate
        {
            add => HookEndpointManager.Add<Delegates.OnUpdate_NormalArgs>(
                ReflectionHelper.GetMethodInfo(typeof(SpawnRandomObjectsOverTimeV2), "OnUpdate"), value);
            remove => HookEndpointManager.Remove<Delegates.OnUpdate_NormalArgs>(
                ReflectionHelper.GetMethodInfo(typeof(SpawnRandomObjectsOverTimeV2), "OnUpdate"), value);
        }

        public static event Delegates.DoSpawn_NormalArgs DoSpawn
        {
            add => HookEndpointManager.Add<Delegates.DoSpawn_NormalArgs>(
                ReflectionHelper.GetMethodInfo(typeof(SpawnRandomObjectsOverTimeV2), "DoSpawn"), value);
            remove => HookEndpointManager.Remove<Delegates.DoSpawn_NormalArgs>(
                ReflectionHelper.GetMethodInfo(typeof(SpawnRandomObjectsOverTimeV2), "DoSpawn"), value);
        }
    }
}