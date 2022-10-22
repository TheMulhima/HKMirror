namespace HKMirror.Hooks.OnHooks;

/// <summary>
///     Contains different types of On Hooks for BreakableWithExternalDebris class.<br />
///     Contains hooks that aren't generated by monomod, and before and after orig hooks for easier hooking.
/// </summary>
public static class OnBreakableWithExternalDebris
{
    internal static class HookHandler
    {
        private static readonly List<string> HookedList = new();

        internal static void HookCreateAdditionalDebrisParts()
        {
            if (!HookedList.Contains("CreateAdditionalDebrisParts"))
            {
                HookedList.Add("CreateAdditionalDebrisParts");
                On.BreakableWithExternalDebris.CreateAdditionalDebrisParts += CreateAdditionalDebrisParts;
            }
        }

        internal static event Delegates.CreateAdditionalDebrisParts_BeforeArgs _beforeCreateAdditionalDebrisParts;
        internal static event Delegates.CreateAdditionalDebrisParts_AfterArgs _afterCreateAdditionalDebrisParts;

        private static void CreateAdditionalDebrisParts(
            On.BreakableWithExternalDebris.orig_CreateAdditionalDebrisParts orig, BreakableWithExternalDebris self,
            List<GameObject> debrisParts)
        {
            Delegates.Params_CreateAdditionalDebrisParts @params = new()
            {
                self = self, debrisParts = debrisParts
            };
            if (_beforeCreateAdditionalDebrisParts != null)
                foreach (Delegates.CreateAdditionalDebrisParts_BeforeArgs toInvoke in _beforeCreateAdditionalDebrisParts
                             .GetInvocationList())
                    try
                    {
                        _beforeCreateAdditionalDebrisParts?.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }

            self = @params.self;
            debrisParts = @params.debrisParts;
            orig(self, debrisParts);
            if (_afterCreateAdditionalDebrisParts != null)
                foreach (Delegates.CreateAdditionalDebrisParts_AfterArgs toInvoke in _afterCreateAdditionalDebrisParts
                             .GetInvocationList())
                    try
                    {
                        _afterCreateAdditionalDebrisParts.Invoke(@params);
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
                On.BreakableWithExternalDebris.Spawn += Spawn;
            }
        }

        internal static event Delegates.Spawn_BeforeArgs _beforeSpawn;
        internal static event Delegates.Spawn_AfterArgs _afterSpawn;

        private static void Spawn(On.BreakableWithExternalDebris.orig_Spawn orig, BreakableWithExternalDebris self,
            BreakableWithExternalDebris.ExternalDebris externalDebris, List<GameObject> debrisParts)
        {
            Delegates.Params_Spawn @params = new()
            {
                self = self, externalDebris = externalDebris, debrisParts = debrisParts
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
            externalDebris = @params.externalDebris;
            debrisParts = @params.debrisParts;
            orig(self, externalDebris, debrisParts);
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
        public delegate void CreateAdditionalDebrisParts_AfterArgs(Params_CreateAdditionalDebrisParts args);

        public delegate void CreateAdditionalDebrisParts_BeforeArgs(Params_CreateAdditionalDebrisParts args);

        public delegate void CreateAdditionalDebrisParts_WithArgs(
            Action<BreakableWithExternalDebris, List<GameObject>> orig, BreakableWithExternalDebris self,
            List<GameObject> debrisParts);

        public delegate void Spawn_AfterArgs(Params_Spawn args);

        public delegate void Spawn_BeforeArgs(Params_Spawn args);

        public delegate void Spawn_WithArgs(
            Action<BreakableWithExternalDebris, BreakableWithExternalDebris.ExternalDebris, List<GameObject>> orig,
            BreakableWithExternalDebris self, BreakableWithExternalDebris.ExternalDebris externalDebris,
            List<GameObject> debrisParts);

        public sealed class Params_CreateAdditionalDebrisParts
        {
            public List<GameObject> debrisParts;
            public BreakableWithExternalDebris self;
        }

        public sealed class Params_Spawn
        {
            public List<GameObject> debrisParts;
            public BreakableWithExternalDebris.ExternalDebris externalDebris;
            public BreakableWithExternalDebris self;
        }
    }

    /// <summary>
    ///     Contains Hooks to that run code before orig(self) is called
    /// </summary>
    public static class BeforeOrig
    {
        public static event Delegates.CreateAdditionalDebrisParts_BeforeArgs CreateAdditionalDebrisParts
        {
            add
            {
                HookHandler._beforeCreateAdditionalDebrisParts += value;
                HookHandler.HookCreateAdditionalDebrisParts();
            }
            remove => HookHandler._beforeCreateAdditionalDebrisParts -= value;
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
        public static event Delegates.CreateAdditionalDebrisParts_AfterArgs CreateAdditionalDebrisParts
        {
            add
            {
                HookHandler._afterCreateAdditionalDebrisParts += value;
                HookHandler.HookCreateAdditionalDebrisParts();
            }
            remove => HookHandler._afterCreateAdditionalDebrisParts -= value;
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
        public static event On.BreakableWithExternalDebris.hook_CreateAdditionalDebrisParts CreateAdditionalDebrisParts
        {
            add => On.BreakableWithExternalDebris.CreateAdditionalDebrisParts += value;
            remove => On.BreakableWithExternalDebris.CreateAdditionalDebrisParts -= value;
        }

        public static event On.BreakableWithExternalDebris.hook_Spawn Spawn
        {
            add => On.BreakableWithExternalDebris.Spawn += value;
            remove => On.BreakableWithExternalDebris.Spawn -= value;
        }
    }
}