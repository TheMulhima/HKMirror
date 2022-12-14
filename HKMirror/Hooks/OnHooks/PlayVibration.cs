namespace HKMirror.Hooks.OnHooks;

/// <summary>
///     Contains different types of On Hooks for PlayVibration class.<br />
///     Contains hooks that aren't generated by monomod, and before and after orig hooks for easier hooking.
/// </summary>
public static class OnPlayVibration
{
    internal static class HookHandler
    {
        private static readonly List<string> HookedList = new();

        internal static void HookReset()
        {
            if (!HookedList.Contains("Reset"))
            {
                HookedList.Add("Reset");
                On.PlayVibration.Reset += Reset;
            }
        }

        internal static event Delegates.Reset_BeforeArgs _beforeReset;
        internal static event Delegates.Reset_AfterArgs _afterReset;

        private static void Reset(On.PlayVibration.orig_Reset orig, PlayVibration self)
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
                On.PlayVibration.OnEnter += OnEnter;
            }
        }

        internal static event Delegates.OnEnter_BeforeArgs _beforeOnEnter;
        internal static event Delegates.OnEnter_AfterArgs _afterOnEnter;

        private static void OnEnter(On.PlayVibration.orig_OnEnter orig, PlayVibration self)
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

        internal static void HookPlay()
        {
            if (!HookedList.Contains("Play"))
            {
                HookedList.Add("Play");
                On.PlayVibration.Play += Play;
            }
        }

        internal static event Delegates.Play_BeforeArgs _beforePlay;
        internal static event Delegates.Play_AfterArgs _afterPlay;

        private static void Play(On.PlayVibration.orig_Play orig, PlayVibration self, bool loop)
        {
            Delegates.Params_Play @params = new()
            {
                self = self, loop = loop
            };
            if (_beforePlay != null)
                foreach (Delegates.Play_BeforeArgs toInvoke in _beforePlay.GetInvocationList())
                    try
                    {
                        _beforePlay?.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }

            self = @params.self;
            loop = @params.loop;
            orig(self, loop);
            if (_afterPlay != null)
                foreach (Delegates.Play_AfterArgs toInvoke in _afterPlay.GetInvocationList())
                    try
                    {
                        _afterPlay.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }
        }

        internal static void HookOnUpdate()
        {
            if (!HookedList.Contains("OnUpdate"))
            {
                HookedList.Add("OnUpdate");
                On.PlayVibration.OnUpdate += OnUpdate;
            }
        }

        internal static event Delegates.OnUpdate_BeforeArgs _beforeOnUpdate;
        internal static event Delegates.OnUpdate_AfterArgs _afterOnUpdate;

        private static void OnUpdate(On.PlayVibration.orig_OnUpdate orig, PlayVibration self)
        {
            Delegates.Params_OnUpdate @params = new()
            {
                self = self
            };
            if (_beforeOnUpdate != null)
                foreach (Delegates.OnUpdate_BeforeArgs toInvoke in _beforeOnUpdate.GetInvocationList())
                    try
                    {
                        _beforeOnUpdate?.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }

            self = @params.self;
            orig(self);
            if (_afterOnUpdate != null)
                foreach (Delegates.OnUpdate_AfterArgs toInvoke in _afterOnUpdate.GetInvocationList())
                    try
                    {
                        _afterOnUpdate.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }
        }

        internal static void HookEnqueueNextLoop()
        {
            if (!HookedList.Contains("EnqueueNextLoop"))
            {
                HookedList.Add("EnqueueNextLoop");
                On.PlayVibration.EnqueueNextLoop += EnqueueNextLoop;
            }
        }

        internal static event Delegates.EnqueueNextLoop_BeforeArgs _beforeEnqueueNextLoop;
        internal static event Delegates.EnqueueNextLoop_AfterArgs _afterEnqueueNextLoop;

        private static void EnqueueNextLoop(On.PlayVibration.orig_EnqueueNextLoop orig, PlayVibration self)
        {
            Delegates.Params_EnqueueNextLoop @params = new()
            {
                self = self
            };
            if (_beforeEnqueueNextLoop != null)
                foreach (Delegates.EnqueueNextLoop_BeforeArgs toInvoke in _beforeEnqueueNextLoop.GetInvocationList())
                    try
                    {
                        _beforeEnqueueNextLoop?.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }

            self = @params.self;
            orig(self);
            if (_afterEnqueueNextLoop != null)
                foreach (Delegates.EnqueueNextLoop_AfterArgs toInvoke in _afterEnqueueNextLoop.GetInvocationList())
                    try
                    {
                        _afterEnqueueNextLoop.Invoke(@params);
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
        public delegate void EnqueueNextLoop_AfterArgs(Params_EnqueueNextLoop args);

        public delegate void EnqueueNextLoop_BeforeArgs(Params_EnqueueNextLoop args);

        public delegate void EnqueueNextLoop_WithArgs(Action<PlayVibration> orig, PlayVibration self);

        public delegate void OnEnter_AfterArgs(Params_OnEnter args);

        public delegate void OnEnter_BeforeArgs(Params_OnEnter args);

        public delegate void OnEnter_WithArgs(Action<PlayVibration> orig, PlayVibration self);

        public delegate void OnUpdate_AfterArgs(Params_OnUpdate args);

        public delegate void OnUpdate_BeforeArgs(Params_OnUpdate args);

        public delegate void OnUpdate_WithArgs(Action<PlayVibration> orig, PlayVibration self);

        public delegate void Play_AfterArgs(Params_Play args);

        public delegate void Play_BeforeArgs(Params_Play args);

        public delegate void Play_WithArgs(Action<PlayVibration, bool> orig, PlayVibration self, bool loop);

        public delegate void Reset_AfterArgs(Params_Reset args);

        public delegate void Reset_BeforeArgs(Params_Reset args);

        public delegate void Reset_WithArgs(Action<PlayVibration> orig, PlayVibration self);

        public sealed class Params_Reset
        {
            public PlayVibration self;
        }

        public sealed class Params_OnEnter
        {
            public PlayVibration self;
        }

        public sealed class Params_Play
        {
            public bool loop;
            public PlayVibration self;
        }

        public sealed class Params_OnUpdate
        {
            public PlayVibration self;
        }

        public sealed class Params_EnqueueNextLoop
        {
            public PlayVibration self;
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

        public static event Delegates.Play_BeforeArgs Play
        {
            add
            {
                HookHandler._beforePlay += value;
                HookHandler.HookPlay();
            }
            remove => HookHandler._beforePlay -= value;
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

        public static event Delegates.EnqueueNextLoop_BeforeArgs EnqueueNextLoop
        {
            add
            {
                HookHandler._beforeEnqueueNextLoop += value;
                HookHandler.HookEnqueueNextLoop();
            }
            remove => HookHandler._beforeEnqueueNextLoop -= value;
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

        public static event Delegates.Play_AfterArgs Play
        {
            add
            {
                HookHandler._afterPlay += value;
                HookHandler.HookPlay();
            }
            remove => HookHandler._afterPlay -= value;
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

        public static event Delegates.EnqueueNextLoop_AfterArgs EnqueueNextLoop
        {
            add
            {
                HookHandler._afterEnqueueNextLoop += value;
                HookHandler.HookEnqueueNextLoop();
            }
            remove => HookHandler._afterEnqueueNextLoop -= value;
        }
    }

    /// <summary>
    ///     Contains all On Hooks, even those that aren't in the On namespace such as API generated functions and property
    ///     getters/setters
    /// </summary>
    public static class WithOrig
    {
        public static event On.PlayVibration.hook_Reset Reset
        {
            add => On.PlayVibration.Reset += value;
            remove => On.PlayVibration.Reset -= value;
        }

        public static event On.PlayVibration.hook_OnEnter OnEnter
        {
            add => On.PlayVibration.OnEnter += value;
            remove => On.PlayVibration.OnEnter -= value;
        }

        public static event On.PlayVibration.hook_Play Play
        {
            add => On.PlayVibration.Play += value;
            remove => On.PlayVibration.Play -= value;
        }

        public static event On.PlayVibration.hook_OnUpdate OnUpdate
        {
            add => On.PlayVibration.OnUpdate += value;
            remove => On.PlayVibration.OnUpdate -= value;
        }

        public static event On.PlayVibration.hook_EnqueueNextLoop EnqueueNextLoop
        {
            add => On.PlayVibration.EnqueueNextLoop += value;
            remove => On.PlayVibration.EnqueueNextLoop -= value;
        }
    }
}