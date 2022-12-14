namespace HKMirror.Hooks.OnHooks;

/// <summary>
///     Contains different types of On Hooks for SaveSlotOverrides class.<br />
///     Contains hooks that aren't generated by monomod, and before and after orig hooks for easier hooking.
/// </summary>
public static class OnSaveSlotOverrides
{
    internal static class HookHandler
    {
        private static readonly List<string> HookedList = new();

        internal static void HookOnValidate()
        {
            if (!HookedList.Contains("OnValidate"))
            {
                HookedList.Add("OnValidate");
                On.SaveSlotOverrides.OnValidate += OnValidate;
            }
        }

        internal static event Delegates.OnValidate_BeforeArgs _beforeOnValidate;
        internal static event Delegates.OnValidate_AfterArgs _afterOnValidate;

        private static void OnValidate(On.SaveSlotOverrides.orig_OnValidate orig, SaveSlotOverrides self)
        {
            Delegates.Params_OnValidate @params = new()
            {
                self = self
            };
            if (_beforeOnValidate != null)
                foreach (Delegates.OnValidate_BeforeArgs toInvoke in _beforeOnValidate.GetInvocationList())
                    try
                    {
                        _beforeOnValidate?.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }

            self = @params.self;
            orig(self);
            if (_afterOnValidate != null)
                foreach (Delegates.OnValidate_AfterArgs toInvoke in _afterOnValidate.GetInvocationList())
                    try
                    {
                        _afterOnValidate.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }
        }

        internal static void HookAwake()
        {
            if (!HookedList.Contains("Awake"))
            {
                HookedList.Add("Awake");
                On.SaveSlotOverrides.Awake += Awake;
            }
        }

        internal static event Delegates.Awake_BeforeArgs _beforeAwake;
        internal static event Delegates.Awake_AfterArgs _afterAwake;

        private static void Awake(On.SaveSlotOverrides.orig_Awake orig, SaveSlotOverrides self)
        {
            Delegates.Params_Awake @params = new()
            {
                self = self
            };
            if (_beforeAwake != null)
                foreach (Delegates.Awake_BeforeArgs toInvoke in _beforeAwake.GetInvocationList())
                    try
                    {
                        _beforeAwake?.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }

            self = @params.self;
            orig(self);
            if (_afterAwake != null)
                foreach (Delegates.Awake_AfterArgs toInvoke in _afterAwake.GetInvocationList())
                    try
                    {
                        _afterAwake.Invoke(@params);
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
        public delegate void Awake_AfterArgs(Params_Awake args);

        public delegate void Awake_BeforeArgs(Params_Awake args);

        public delegate void Awake_WithArgs(Action<SaveSlotOverrides> orig, SaveSlotOverrides self);

        public delegate void OnValidate_AfterArgs(Params_OnValidate args);

        public delegate void OnValidate_BeforeArgs(Params_OnValidate args);

        public delegate void OnValidate_WithArgs(Action<SaveSlotOverrides> orig, SaveSlotOverrides self);

        public sealed class Params_OnValidate
        {
            public SaveSlotOverrides self;
        }

        public sealed class Params_Awake
        {
            public SaveSlotOverrides self;
        }
    }

    /// <summary>
    ///     Contains Hooks to that run code before orig(self) is called
    /// </summary>
    public static class BeforeOrig
    {
        public static event Delegates.OnValidate_BeforeArgs OnValidate
        {
            add
            {
                HookHandler._beforeOnValidate += value;
                HookHandler.HookOnValidate();
            }
            remove => HookHandler._beforeOnValidate -= value;
        }

        public static event Delegates.Awake_BeforeArgs Awake
        {
            add
            {
                HookHandler._beforeAwake += value;
                HookHandler.HookAwake();
            }
            remove => HookHandler._beforeAwake -= value;
        }
    }

    /// <summary>
    ///     Contains Hooks to that run code after orig(self) is called
    /// </summary>
    public static class AfterOrig
    {
        public static event Delegates.OnValidate_AfterArgs OnValidate
        {
            add
            {
                HookHandler._afterOnValidate += value;
                HookHandler.HookOnValidate();
            }
            remove => HookHandler._afterOnValidate -= value;
        }

        public static event Delegates.Awake_AfterArgs Awake
        {
            add
            {
                HookHandler._afterAwake += value;
                HookHandler.HookAwake();
            }
            remove => HookHandler._afterAwake -= value;
        }
    }

    /// <summary>
    ///     Contains all On Hooks, even those that aren't in the On namespace such as API generated functions and property
    ///     getters/setters
    /// </summary>
    public static class WithOrig
    {
        public static event On.SaveSlotOverrides.hook_OnValidate OnValidate
        {
            add => On.SaveSlotOverrides.OnValidate += value;
            remove => On.SaveSlotOverrides.OnValidate -= value;
        }

        public static event On.SaveSlotOverrides.hook_Awake Awake
        {
            add => On.SaveSlotOverrides.Awake += value;
            remove => On.SaveSlotOverrides.Awake -= value;
        }
    }
}