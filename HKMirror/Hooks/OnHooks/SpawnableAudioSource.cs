namespace HKMirror.Hooks.OnHooks;

/// <summary>
///     Contains different types of On Hooks for SpawnableAudioSource class.<br />
///     Contains hooks that aren't generated by monomod, and before and after orig hooks for easier hooking.
/// </summary>
public static class OnSpawnableAudioSource
{
    internal static class HookHandler
    {
        private static readonly List<string> HookedList = new();

        internal static void HookAwake()
        {
            if (!HookedList.Contains("Awake"))
            {
                HookedList.Add("Awake");
                On.SpawnableAudioSource.Awake += Awake;
            }
        }

        internal static event Delegates.Awake_BeforeArgs _beforeAwake;
        internal static event Delegates.Awake_AfterArgs _afterAwake;

        private static void Awake(On.SpawnableAudioSource.orig_Awake orig, SpawnableAudioSource self)
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

        internal static void HookOnEnable()
        {
            if (!HookedList.Contains("OnEnable"))
            {
                HookedList.Add("OnEnable");
                On.SpawnableAudioSource.OnEnable += OnEnable;
            }
        }

        internal static event Delegates.OnEnable_BeforeArgs _beforeOnEnable;
        internal static event Delegates.OnEnable_AfterArgs _afterOnEnable;

        private static void OnEnable(On.SpawnableAudioSource.orig_OnEnable orig, SpawnableAudioSource self)
        {
            Delegates.Params_OnEnable @params = new()
            {
                self = self
            };
            if (_beforeOnEnable != null)
                foreach (Delegates.OnEnable_BeforeArgs toInvoke in _beforeOnEnable.GetInvocationList())
                    try
                    {
                        _beforeOnEnable?.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }

            self = @params.self;
            orig(self);
            if (_afterOnEnable != null)
                foreach (Delegates.OnEnable_AfterArgs toInvoke in _afterOnEnable.GetInvocationList())
                    try
                    {
                        _afterOnEnable.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }
        }

        internal static void HookUpdate()
        {
            if (!HookedList.Contains("Update"))
            {
                HookedList.Add("Update");
                On.SpawnableAudioSource.Update += Update;
            }
        }

        internal static event Delegates.Update_BeforeArgs _beforeUpdate;
        internal static event Delegates.Update_AfterArgs _afterUpdate;

        private static void Update(On.SpawnableAudioSource.orig_Update orig, SpawnableAudioSource self)
        {
            Delegates.Params_Update @params = new()
            {
                self = self
            };
            if (_beforeUpdate != null)
                foreach (Delegates.Update_BeforeArgs toInvoke in _beforeUpdate.GetInvocationList())
                    try
                    {
                        _beforeUpdate?.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }

            self = @params.self;
            orig(self);
            if (_afterUpdate != null)
                foreach (Delegates.Update_AfterArgs toInvoke in _afterUpdate.GetInvocationList())
                    try
                    {
                        _afterUpdate.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }
        }

        internal static void HookStop()
        {
            if (!HookedList.Contains("Stop"))
            {
                HookedList.Add("Stop");
                On.SpawnableAudioSource.Stop += Stop;
            }
        }

        internal static event Delegates.Stop_BeforeArgs _beforeStop;
        internal static event Delegates.Stop_AfterArgs _afterStop;

        private static void Stop(On.SpawnableAudioSource.orig_Stop orig, SpawnableAudioSource self)
        {
            Delegates.Params_Stop @params = new()
            {
                self = self
            };
            if (_beforeStop != null)
                foreach (Delegates.Stop_BeforeArgs toInvoke in _beforeStop.GetInvocationList())
                    try
                    {
                        _beforeStop?.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }

            self = @params.self;
            orig(self);
            if (_afterStop != null)
                foreach (Delegates.Stop_AfterArgs toInvoke in _afterStop.GetInvocationList())
                    try
                    {
                        _afterStop.Invoke(@params);
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

        public delegate void Awake_WithArgs(Action<SpawnableAudioSource> orig, SpawnableAudioSource self);

        public delegate void OnEnable_AfterArgs(Params_OnEnable args);

        public delegate void OnEnable_BeforeArgs(Params_OnEnable args);

        public delegate void OnEnable_WithArgs(Action<SpawnableAudioSource> orig, SpawnableAudioSource self);

        public delegate void Stop_AfterArgs(Params_Stop args);

        public delegate void Stop_BeforeArgs(Params_Stop args);

        public delegate void Stop_WithArgs(Action<SpawnableAudioSource> orig, SpawnableAudioSource self);

        public delegate void Update_AfterArgs(Params_Update args);

        public delegate void Update_BeforeArgs(Params_Update args);

        public delegate void Update_WithArgs(Action<SpawnableAudioSource> orig, SpawnableAudioSource self);

        public sealed class Params_Awake
        {
            public SpawnableAudioSource self;
        }

        public sealed class Params_OnEnable
        {
            public SpawnableAudioSource self;
        }

        public sealed class Params_Update
        {
            public SpawnableAudioSource self;
        }

        public sealed class Params_Stop
        {
            public SpawnableAudioSource self;
        }
    }

    /// <summary>
    ///     Contains Hooks to that run code before orig(self) is called
    /// </summary>
    public static class BeforeOrig
    {
        public static event Delegates.Awake_BeforeArgs Awake
        {
            add
            {
                HookHandler._beforeAwake += value;
                HookHandler.HookAwake();
            }
            remove => HookHandler._beforeAwake -= value;
        }

        public static event Delegates.OnEnable_BeforeArgs OnEnable
        {
            add
            {
                HookHandler._beforeOnEnable += value;
                HookHandler.HookOnEnable();
            }
            remove => HookHandler._beforeOnEnable -= value;
        }

        public static event Delegates.Update_BeforeArgs Update
        {
            add
            {
                HookHandler._beforeUpdate += value;
                HookHandler.HookUpdate();
            }
            remove => HookHandler._beforeUpdate -= value;
        }

        public static event Delegates.Stop_BeforeArgs Stop
        {
            add
            {
                HookHandler._beforeStop += value;
                HookHandler.HookStop();
            }
            remove => HookHandler._beforeStop -= value;
        }
    }

    /// <summary>
    ///     Contains Hooks to that run code after orig(self) is called
    /// </summary>
    public static class AfterOrig
    {
        public static event Delegates.Awake_AfterArgs Awake
        {
            add
            {
                HookHandler._afterAwake += value;
                HookHandler.HookAwake();
            }
            remove => HookHandler._afterAwake -= value;
        }

        public static event Delegates.OnEnable_AfterArgs OnEnable
        {
            add
            {
                HookHandler._afterOnEnable += value;
                HookHandler.HookOnEnable();
            }
            remove => HookHandler._afterOnEnable -= value;
        }

        public static event Delegates.Update_AfterArgs Update
        {
            add
            {
                HookHandler._afterUpdate += value;
                HookHandler.HookUpdate();
            }
            remove => HookHandler._afterUpdate -= value;
        }

        public static event Delegates.Stop_AfterArgs Stop
        {
            add
            {
                HookHandler._afterStop += value;
                HookHandler.HookStop();
            }
            remove => HookHandler._afterStop -= value;
        }
    }

    /// <summary>
    ///     Contains all On Hooks, even those that aren't in the On namespace such as API generated functions and property
    ///     getters/setters
    /// </summary>
    public static class WithOrig
    {
        public static event On.SpawnableAudioSource.hook_Awake Awake
        {
            add => On.SpawnableAudioSource.Awake += value;
            remove => On.SpawnableAudioSource.Awake -= value;
        }

        public static event On.SpawnableAudioSource.hook_OnEnable OnEnable
        {
            add => On.SpawnableAudioSource.OnEnable += value;
            remove => On.SpawnableAudioSource.OnEnable -= value;
        }

        public static event On.SpawnableAudioSource.hook_Update Update
        {
            add => On.SpawnableAudioSource.Update += value;
            remove => On.SpawnableAudioSource.Update -= value;
        }

        public static event On.SpawnableAudioSource.hook_Stop Stop
        {
            add => On.SpawnableAudioSource.Stop += value;
            remove => On.SpawnableAudioSource.Stop -= value;
        }
    }
}