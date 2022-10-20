using MonoMod.RuntimeDetour;
using MonoMod.RuntimeDetour.HookGen;

namespace HKMirror.Hooks.OnHooks;

/// <summary>
///     Contains different types of On Hooks for TrackSpawnedEnemies class.<br />
///     Contains hooks that aren't generated by monomod, and before and after orig hooks for easier hooking.
/// </summary>
public static class OnTrackSpawnedEnemies
{
    internal static class HookHandler
    {
        private static readonly List<string> HookedList = new();

        internal static void Hookget_TotalTracked()
        {
            if (!HookedList.Contains("get_TotalTracked"))
            {
                HookedList.Add("get_TotalTracked");
                new Hook(ReflectionHelper.GetMethodInfo(typeof(TrackSpawnedEnemies), "get_TotalTracked"),
                    get_TotalTracked);
            }
        }

        internal static event Delegates.get_TotalTracked_BeforeArgs _beforeget_TotalTracked;
        internal static event Delegates.get_TotalTracked_NormalArgs _afterget_TotalTracked;

        private static int get_TotalTracked(Func<TrackSpawnedEnemies, int> orig, TrackSpawnedEnemies self)
        {
            Delegates.Params_get_TotalTracked @params = new()
            {
                self = self
            };
            _beforeget_TotalTracked?.Invoke(@params);
            self = @params.self;
            var retVal = orig(self);
            if (_afterget_TotalTracked != null) retVal = _afterget_TotalTracked.Invoke(@params);
            return retVal;
        }

        internal static void Hookget_TotalAlive()
        {
            if (!HookedList.Contains("get_TotalAlive"))
            {
                HookedList.Add("get_TotalAlive");
                new Hook(ReflectionHelper.GetMethodInfo(typeof(TrackSpawnedEnemies), "get_TotalAlive"), get_TotalAlive);
            }
        }

        internal static event Delegates.get_TotalAlive_BeforeArgs _beforeget_TotalAlive;
        internal static event Delegates.get_TotalAlive_NormalArgs _afterget_TotalAlive;

        private static int get_TotalAlive(Func<TrackSpawnedEnemies, int> orig, TrackSpawnedEnemies self)
        {
            Delegates.Params_get_TotalAlive @params = new()
            {
                self = self
            };
            _beforeget_TotalAlive?.Invoke(@params);
            self = @params.self;
            var retVal = orig(self);
            if (_afterget_TotalAlive != null) retVal = _afterget_TotalAlive.Invoke(@params);
            return retVal;
        }

        internal static void HookAdd()
        {
            if (!HookedList.Contains("Add"))
            {
                HookedList.Add("Add");
                On.TrackSpawnedEnemies.Add += Add;
            }
        }

        internal static event Delegates.Add_BeforeArgs _beforeAdd;
        internal static event Delegates.Add_NormalArgs _afterAdd;

        private static void Add(On.TrackSpawnedEnemies.orig_Add orig, TrackSpawnedEnemies self,
            HealthManager enemyHealthManager)
        {
            Delegates.Params_Add @params = new()
            {
                self = self, enemyHealthManager = enemyHealthManager
            };
            _beforeAdd?.Invoke(@params);
            self = @params.self;
            enemyHealthManager = @params.enemyHealthManager;
            orig(self, enemyHealthManager);
            if (_afterAdd != null) _afterAdd.Invoke(@params);
        }
    }

    /// <summary>
    ///     Contains necessary information to create Hooks. Does not contain any hooks
    /// </summary>
    public static class Delegates
    {
        public delegate void Add_BeforeArgs(Params_Add args);

        public delegate void Add_NormalArgs(Params_Add args);

        public delegate void get_TotalAlive_BeforeArgs(Params_get_TotalAlive args);

        public delegate int get_TotalAlive_NormalArgs(Params_get_TotalAlive args);

        public delegate void get_TotalTracked_BeforeArgs(Params_get_TotalTracked args);

        public delegate int get_TotalTracked_NormalArgs(Params_get_TotalTracked args);

        public sealed class Params_get_TotalTracked
        {
            public TrackSpawnedEnemies self;
        }

        public sealed class Params_get_TotalAlive
        {
            public TrackSpawnedEnemies self;
        }

        public sealed class Params_Add
        {
            public HealthManager enemyHealthManager;
            public TrackSpawnedEnemies self;
        }
    }

    /// <summary>
    ///     Contains Hooks to that run code before orig(self) is called
    /// </summary>
    public static class BeforeOrig
    {
        public static event Delegates.get_TotalTracked_BeforeArgs get_TotalTracked
        {
            add
            {
                HookHandler._beforeget_TotalTracked += value;
                HookHandler.Hookget_TotalTracked();
            }
            remove => HookHandler._beforeget_TotalTracked -= value;
        }

        public static event Delegates.get_TotalAlive_BeforeArgs get_TotalAlive
        {
            add
            {
                HookHandler._beforeget_TotalAlive += value;
                HookHandler.Hookget_TotalAlive();
            }
            remove => HookHandler._beforeget_TotalAlive -= value;
        }

        public static event Delegates.Add_BeforeArgs Add
        {
            add
            {
                HookHandler._beforeAdd += value;
                HookHandler.HookAdd();
            }
            remove => HookHandler._beforeAdd -= value;
        }
    }

    /// <summary>
    ///     Contains Hooks to that run code after orig(self) is called
    /// </summary>
    public static class AfterOrig
    {
        public static event Delegates.get_TotalTracked_NormalArgs get_TotalTracked
        {
            add
            {
                HookHandler._afterget_TotalTracked += value;
                HookHandler.Hookget_TotalTracked();
            }
            remove => HookHandler._afterget_TotalTracked -= value;
        }

        public static event Delegates.get_TotalAlive_NormalArgs get_TotalAlive
        {
            add
            {
                HookHandler._afterget_TotalAlive += value;
                HookHandler.Hookget_TotalAlive();
            }
            remove => HookHandler._afterget_TotalAlive -= value;
        }

        public static event Delegates.Add_NormalArgs Add
        {
            add
            {
                HookHandler._afterAdd += value;
                HookHandler.HookAdd();
            }
            remove => HookHandler._afterAdd -= value;
        }
    }

    /// <summary>
    ///     Contains all On Hooks, even those that aren't in the On namespace such as API generated functions and property
    ///     getters/setters
    /// </summary>
    public static class WithOrig
    {
        public static event Delegates.get_TotalTracked_NormalArgs get_TotalTracked
        {
            add => HookEndpointManager.Add<Delegates.get_TotalTracked_NormalArgs>(
                ReflectionHelper.GetMethodInfo(typeof(TrackSpawnedEnemies), "get_TotalTracked"), value);
            remove => HookEndpointManager.Remove<Delegates.get_TotalTracked_NormalArgs>(
                ReflectionHelper.GetMethodInfo(typeof(TrackSpawnedEnemies), "get_TotalTracked"), value);
        }

        public static event Delegates.get_TotalAlive_NormalArgs get_TotalAlive
        {
            add => HookEndpointManager.Add<Delegates.get_TotalAlive_NormalArgs>(
                ReflectionHelper.GetMethodInfo(typeof(TrackSpawnedEnemies), "get_TotalAlive"), value);
            remove => HookEndpointManager.Remove<Delegates.get_TotalAlive_NormalArgs>(
                ReflectionHelper.GetMethodInfo(typeof(TrackSpawnedEnemies), "get_TotalAlive"), value);
        }

        public static event On.TrackSpawnedEnemies.hook_Add Add
        {
            add => On.TrackSpawnedEnemies.Add += value;
            remove => On.TrackSpawnedEnemies.Add -= value;
        }
    }
}