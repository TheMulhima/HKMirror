namespace HKMirror.Hooks.OnHooks;

/// <summary>
///     Contains different types of On Hooks for SpawnBlood class.<br />
///     Contains hooks that aren't generated by monomod, and before and after orig hooks for easier hooking.
/// </summary>
public static class OnSpawnBlood
{
    internal static class HookHandler
    {
        private static readonly List<string> HookedList = new();

        internal static void HookReset()
        {
            if (!HookedList.Contains("Reset"))
            {
                HookedList.Add("Reset");
                On.SpawnBlood.Reset += Reset;
            }
        }

        internal static event Delegates.Reset_BeforeArgs _beforeReset;
        internal static event Delegates.Reset_AfterArgs _afterReset;

        private static void Reset(On.SpawnBlood.orig_Reset orig, SpawnBlood self)
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

        internal static void HookOnEnter()
        {
            if (!HookedList.Contains("OnEnter"))
            {
                HookedList.Add("OnEnter");
                On.SpawnBlood.OnEnter += OnEnter;
            }
        }

        internal static event Delegates.OnEnter_BeforeArgs _beforeOnEnter;
        internal static event Delegates.OnEnter_AfterArgs _afterOnEnter;

        private static void OnEnter(On.SpawnBlood.orig_OnEnter orig, SpawnBlood self)
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

        internal static void HookSpawn()
        {
            if (!HookedList.Contains("Spawn"))
            {
                HookedList.Add("Spawn");
                On.SpawnBlood.Spawn += Spawn;
            }
        }

        internal static event Delegates.Spawn_BeforeArgs _beforeSpawn;
        internal static event Delegates.Spawn_AfterArgs _afterSpawn;

        private static void Spawn(On.SpawnBlood.orig_Spawn orig, SpawnBlood self)
        {
            Delegates.Params_Spawn @params = new()
            {
                self = self
            };
            if (_beforeSpawn != null)
                foreach (Delegates.Spawn_BeforeArgs toInvoke in _beforeSpawn.GetInvocationList())
                    try
                    {
                        _beforeSpawn?.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }

            self = @params.self;
            orig(self);
            if (_afterSpawn != null)
                foreach (Delegates.Spawn_AfterArgs toInvoke in _afterSpawn.GetInvocationList())
                    try
                    {
                        _afterSpawn.Invoke(@params);
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

        public delegate void OnEnter_WithArgs(Action<SpawnBlood> orig, SpawnBlood self);

        public delegate void Reset_AfterArgs(Params_Reset args);

        public delegate void Reset_BeforeArgs(Params_Reset args);

        public delegate void Reset_WithArgs(Action<SpawnBlood> orig, SpawnBlood self);

        public delegate void Spawn_AfterArgs(Params_Spawn args);

        public delegate void Spawn_BeforeArgs(Params_Spawn args);

        public delegate void Spawn_WithArgs(Action<SpawnBlood> orig, SpawnBlood self);

        public sealed class Params_Reset
        {
            public SpawnBlood self;
        }

        public sealed class Params_OnEnter
        {
            public SpawnBlood self;
        }

        public sealed class Params_Spawn
        {
            public SpawnBlood self;
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

        public static event Delegates.Spawn_BeforeArgs Spawn
        {
            add
            {
                HookHandler._beforeSpawn += value;
                HookHandler.HookSpawn();
            }
            remove => HookHandler._beforeSpawn -= value;
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

        public static event Delegates.OnEnter_AfterArgs OnEnter
        {
            add
            {
                HookHandler._afterOnEnter += value;
                HookHandler.HookOnEnter();
            }
            remove => HookHandler._afterOnEnter -= value;
        }

        public static event Delegates.Spawn_AfterArgs Spawn
        {
            add
            {
                HookHandler._afterSpawn += value;
                HookHandler.HookSpawn();
            }
            remove => HookHandler._afterSpawn -= value;
        }
    }

    /// <summary>
    ///     Contains all On Hooks, even those that aren't in the On namespace such as API generated functions and property
    ///     getters/setters
    /// </summary>
    public static class WithOrig
    {
        public static event On.SpawnBlood.hook_Reset Reset
        {
            add => On.SpawnBlood.Reset += value;
            remove => On.SpawnBlood.Reset -= value;
        }

        public static event On.SpawnBlood.hook_OnEnter OnEnter
        {
            add => On.SpawnBlood.OnEnter += value;
            remove => On.SpawnBlood.OnEnter -= value;
        }

        public static event On.SpawnBlood.hook_Spawn Spawn
        {
            add => On.SpawnBlood.Spawn += value;
            remove => On.SpawnBlood.Spawn -= value;
        }
    }
}