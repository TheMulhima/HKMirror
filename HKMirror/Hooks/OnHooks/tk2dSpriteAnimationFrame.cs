namespace HKMirror.Hooks.OnHooks;

/// <summary>
///     Contains different types of On Hooks for tk2dSpriteAnimationFrame class.<br />
///     Contains hooks that aren't generated by monomod, and before and after orig hooks for easier hooking.
/// </summary>
public static class Ontk2dSpriteAnimationFrame
{
    internal static class HookHandler
    {
        private static readonly List<string> HookedList = new();

        internal static void HookCopyFrom_tk2dSpriteAnimationFrame()
        {
            if (!HookedList.Contains("CopyFrom_tk2dSpriteAnimationFrame"))
            {
                HookedList.Add("CopyFrom_tk2dSpriteAnimationFrame");
                On.tk2dSpriteAnimationFrame.CopyFrom_tk2dSpriteAnimationFrame += CopyFrom_tk2dSpriteAnimationFrame;
            }
        }

        internal static event Delegates.CopyFrom_tk2dSpriteAnimationFrame_BeforeArgs
            _beforeCopyFrom_tk2dSpriteAnimationFrame;

        internal static event Delegates.CopyFrom_tk2dSpriteAnimationFrame_AfterArgs
            _afterCopyFrom_tk2dSpriteAnimationFrame;

        private static void CopyFrom_tk2dSpriteAnimationFrame(
            On.tk2dSpriteAnimationFrame.orig_CopyFrom_tk2dSpriteAnimationFrame orig, tk2dSpriteAnimationFrame self,
            tk2dSpriteAnimationFrame source)
        {
            Delegates.Params_CopyFrom_tk2dSpriteAnimationFrame @params = new()
            {
                self = self, source = source
            };
            if (_beforeCopyFrom_tk2dSpriteAnimationFrame != null)
                foreach (Delegates.CopyFrom_tk2dSpriteAnimationFrame_BeforeArgs toInvoke in
                         _beforeCopyFrom_tk2dSpriteAnimationFrame.GetInvocationList())
                    try
                    {
                        _beforeCopyFrom_tk2dSpriteAnimationFrame?.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }

            self = @params.self;
            source = @params.source;
            orig(self, source);
            if (_afterCopyFrom_tk2dSpriteAnimationFrame != null)
                foreach (Delegates.CopyFrom_tk2dSpriteAnimationFrame_AfterArgs toInvoke in
                         _afterCopyFrom_tk2dSpriteAnimationFrame.GetInvocationList())
                    try
                    {
                        _afterCopyFrom_tk2dSpriteAnimationFrame.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }
        }

        internal static void HookCopyTriggerFrom()
        {
            if (!HookedList.Contains("CopyTriggerFrom"))
            {
                HookedList.Add("CopyTriggerFrom");
                On.tk2dSpriteAnimationFrame.CopyTriggerFrom += CopyTriggerFrom;
            }
        }

        internal static event Delegates.CopyTriggerFrom_BeforeArgs _beforeCopyTriggerFrom;
        internal static event Delegates.CopyTriggerFrom_AfterArgs _afterCopyTriggerFrom;

        private static void CopyTriggerFrom(On.tk2dSpriteAnimationFrame.orig_CopyTriggerFrom orig,
            tk2dSpriteAnimationFrame self, tk2dSpriteAnimationFrame source)
        {
            Delegates.Params_CopyTriggerFrom @params = new()
            {
                self = self, source = source
            };
            if (_beforeCopyTriggerFrom != null)
                foreach (Delegates.CopyTriggerFrom_BeforeArgs toInvoke in _beforeCopyTriggerFrom.GetInvocationList())
                    try
                    {
                        _beforeCopyTriggerFrom?.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }

            self = @params.self;
            source = @params.source;
            orig(self, source);
            if (_afterCopyTriggerFrom != null)
                foreach (Delegates.CopyTriggerFrom_AfterArgs toInvoke in _afterCopyTriggerFrom.GetInvocationList())
                    try
                    {
                        _afterCopyTriggerFrom.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }
        }

        internal static void HookClearTrigger()
        {
            if (!HookedList.Contains("ClearTrigger"))
            {
                HookedList.Add("ClearTrigger");
                On.tk2dSpriteAnimationFrame.ClearTrigger += ClearTrigger;
            }
        }

        internal static event Delegates.ClearTrigger_BeforeArgs _beforeClearTrigger;
        internal static event Delegates.ClearTrigger_AfterArgs _afterClearTrigger;

        private static void ClearTrigger(On.tk2dSpriteAnimationFrame.orig_ClearTrigger orig,
            tk2dSpriteAnimationFrame self)
        {
            Delegates.Params_ClearTrigger @params = new()
            {
                self = self
            };
            if (_beforeClearTrigger != null)
                foreach (Delegates.ClearTrigger_BeforeArgs toInvoke in _beforeClearTrigger.GetInvocationList())
                    try
                    {
                        _beforeClearTrigger?.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }

            self = @params.self;
            orig(self);
            if (_afterClearTrigger != null)
                foreach (Delegates.ClearTrigger_AfterArgs toInvoke in _afterClearTrigger.GetInvocationList())
                    try
                    {
                        _afterClearTrigger.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }
        }

        internal static void HookCopyFrom_tk2dSpriteAnimationFrame_bool()
        {
            if (!HookedList.Contains("CopyFrom_tk2dSpriteAnimationFrame_bool"))
            {
                HookedList.Add("CopyFrom_tk2dSpriteAnimationFrame_bool");
                On.tk2dSpriteAnimationFrame.CopyFrom_tk2dSpriteAnimationFrame_bool +=
                    CopyFrom_tk2dSpriteAnimationFrame_bool;
            }
        }

        internal static event Delegates.CopyFrom_tk2dSpriteAnimationFrame_bool_BeforeArgs
            _beforeCopyFrom_tk2dSpriteAnimationFrame_bool;

        internal static event Delegates.CopyFrom_tk2dSpriteAnimationFrame_bool_AfterArgs
            _afterCopyFrom_tk2dSpriteAnimationFrame_bool;

        private static void CopyFrom_tk2dSpriteAnimationFrame_bool(
            On.tk2dSpriteAnimationFrame.orig_CopyFrom_tk2dSpriteAnimationFrame_bool orig, tk2dSpriteAnimationFrame self,
            tk2dSpriteAnimationFrame source, bool full)
        {
            Delegates.Params_CopyFrom_tk2dSpriteAnimationFrame_bool @params = new()
            {
                self = self, source = source, full = full
            };
            if (_beforeCopyFrom_tk2dSpriteAnimationFrame_bool != null)
                foreach (Delegates.CopyFrom_tk2dSpriteAnimationFrame_bool_BeforeArgs toInvoke in
                         _beforeCopyFrom_tk2dSpriteAnimationFrame_bool.GetInvocationList())
                    try
                    {
                        _beforeCopyFrom_tk2dSpriteAnimationFrame_bool?.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }

            self = @params.self;
            source = @params.source;
            full = @params.full;
            orig(self, source, full);
            if (_afterCopyFrom_tk2dSpriteAnimationFrame_bool != null)
                foreach (Delegates.CopyFrom_tk2dSpriteAnimationFrame_bool_AfterArgs toInvoke in
                         _afterCopyFrom_tk2dSpriteAnimationFrame_bool.GetInvocationList())
                    try
                    {
                        _afterCopyFrom_tk2dSpriteAnimationFrame_bool.Invoke(@params);
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
        public delegate void ClearTrigger_AfterArgs(Params_ClearTrigger args);

        public delegate void ClearTrigger_BeforeArgs(Params_ClearTrigger args);

        public delegate void ClearTrigger_WithArgs(Action<tk2dSpriteAnimationFrame> orig,
            tk2dSpriteAnimationFrame self);

        public delegate void CopyFrom_tk2dSpriteAnimationFrame_AfterArgs(Params_CopyFrom_tk2dSpriteAnimationFrame args);

        public delegate void
            CopyFrom_tk2dSpriteAnimationFrame_BeforeArgs(Params_CopyFrom_tk2dSpriteAnimationFrame args);

        public delegate void CopyFrom_tk2dSpriteAnimationFrame_bool_AfterArgs(
            Params_CopyFrom_tk2dSpriteAnimationFrame_bool args);

        public delegate void CopyFrom_tk2dSpriteAnimationFrame_bool_BeforeArgs(
            Params_CopyFrom_tk2dSpriteAnimationFrame_bool args);

        public delegate void CopyFrom_tk2dSpriteAnimationFrame_bool_WithArgs(
            Action<tk2dSpriteAnimationFrame, tk2dSpriteAnimationFrame, bool> orig, tk2dSpriteAnimationFrame self,
            tk2dSpriteAnimationFrame source, bool full);

        public delegate void CopyFrom_tk2dSpriteAnimationFrame_WithArgs(
            Action<tk2dSpriteAnimationFrame, tk2dSpriteAnimationFrame> orig, tk2dSpriteAnimationFrame self,
            tk2dSpriteAnimationFrame source);

        public delegate void CopyTriggerFrom_AfterArgs(Params_CopyTriggerFrom args);

        public delegate void CopyTriggerFrom_BeforeArgs(Params_CopyTriggerFrom args);

        public delegate void CopyTriggerFrom_WithArgs(Action<tk2dSpriteAnimationFrame, tk2dSpriteAnimationFrame> orig,
            tk2dSpriteAnimationFrame self, tk2dSpriteAnimationFrame source);

        public sealed class Params_CopyFrom_tk2dSpriteAnimationFrame
        {
            public tk2dSpriteAnimationFrame self;
            public tk2dSpriteAnimationFrame source;
        }

        public sealed class Params_CopyTriggerFrom
        {
            public tk2dSpriteAnimationFrame self;
            public tk2dSpriteAnimationFrame source;
        }

        public sealed class Params_ClearTrigger
        {
            public tk2dSpriteAnimationFrame self;
        }

        public sealed class Params_CopyFrom_tk2dSpriteAnimationFrame_bool
        {
            public bool full;
            public tk2dSpriteAnimationFrame self;
            public tk2dSpriteAnimationFrame source;
        }
    }

    /// <summary>
    ///     Contains Hooks to that run code before orig(self) is called
    /// </summary>
    public static class BeforeOrig
    {
        public static event Delegates.CopyFrom_tk2dSpriteAnimationFrame_BeforeArgs CopyFrom_tk2dSpriteAnimationFrame
        {
            add
            {
                HookHandler._beforeCopyFrom_tk2dSpriteAnimationFrame += value;
                HookHandler.HookCopyFrom_tk2dSpriteAnimationFrame();
            }
            remove => HookHandler._beforeCopyFrom_tk2dSpriteAnimationFrame -= value;
        }

        public static event Delegates.CopyTriggerFrom_BeforeArgs CopyTriggerFrom
        {
            add
            {
                HookHandler._beforeCopyTriggerFrom += value;
                HookHandler.HookCopyTriggerFrom();
            }
            remove => HookHandler._beforeCopyTriggerFrom -= value;
        }

        public static event Delegates.ClearTrigger_BeforeArgs ClearTrigger
        {
            add
            {
                HookHandler._beforeClearTrigger += value;
                HookHandler.HookClearTrigger();
            }
            remove => HookHandler._beforeClearTrigger -= value;
        }

        public static event Delegates.CopyFrom_tk2dSpriteAnimationFrame_bool_BeforeArgs
            CopyFrom_tk2dSpriteAnimationFrame_bool
            {
                add
                {
                    HookHandler._beforeCopyFrom_tk2dSpriteAnimationFrame_bool += value;
                    HookHandler.HookCopyFrom_tk2dSpriteAnimationFrame_bool();
                }
                remove => HookHandler._beforeCopyFrom_tk2dSpriteAnimationFrame_bool -= value;
            }
    }

    /// <summary>
    ///     Contains Hooks to that run code after orig(self) is called
    /// </summary>
    public static class AfterOrig
    {
        public static event Delegates.CopyFrom_tk2dSpriteAnimationFrame_AfterArgs CopyFrom_tk2dSpriteAnimationFrame
        {
            add
            {
                HookHandler._afterCopyFrom_tk2dSpriteAnimationFrame += value;
                HookHandler.HookCopyFrom_tk2dSpriteAnimationFrame();
            }
            remove => HookHandler._afterCopyFrom_tk2dSpriteAnimationFrame -= value;
        }

        public static event Delegates.CopyTriggerFrom_AfterArgs CopyTriggerFrom
        {
            add
            {
                HookHandler._afterCopyTriggerFrom += value;
                HookHandler.HookCopyTriggerFrom();
            }
            remove => HookHandler._afterCopyTriggerFrom -= value;
        }

        public static event Delegates.ClearTrigger_AfterArgs ClearTrigger
        {
            add
            {
                HookHandler._afterClearTrigger += value;
                HookHandler.HookClearTrigger();
            }
            remove => HookHandler._afterClearTrigger -= value;
        }

        public static event Delegates.CopyFrom_tk2dSpriteAnimationFrame_bool_AfterArgs
            CopyFrom_tk2dSpriteAnimationFrame_bool
            {
                add
                {
                    HookHandler._afterCopyFrom_tk2dSpriteAnimationFrame_bool += value;
                    HookHandler.HookCopyFrom_tk2dSpriteAnimationFrame_bool();
                }
                remove => HookHandler._afterCopyFrom_tk2dSpriteAnimationFrame_bool -= value;
            }
    }

    /// <summary>
    ///     Contains all On Hooks, even those that aren't in the On namespace such as API generated functions and property
    ///     getters/setters
    /// </summary>
    public static class WithOrig
    {
        public static event On.tk2dSpriteAnimationFrame.hook_CopyFrom_tk2dSpriteAnimationFrame
            CopyFrom_tk2dSpriteAnimationFrame
            {
                add => On.tk2dSpriteAnimationFrame.CopyFrom_tk2dSpriteAnimationFrame += value;
                remove => On.tk2dSpriteAnimationFrame.CopyFrom_tk2dSpriteAnimationFrame -= value;
            }

        public static event On.tk2dSpriteAnimationFrame.hook_CopyTriggerFrom CopyTriggerFrom
        {
            add => On.tk2dSpriteAnimationFrame.CopyTriggerFrom += value;
            remove => On.tk2dSpriteAnimationFrame.CopyTriggerFrom -= value;
        }

        public static event On.tk2dSpriteAnimationFrame.hook_ClearTrigger ClearTrigger
        {
            add => On.tk2dSpriteAnimationFrame.ClearTrigger += value;
            remove => On.tk2dSpriteAnimationFrame.ClearTrigger -= value;
        }

        public static event On.tk2dSpriteAnimationFrame.hook_CopyFrom_tk2dSpriteAnimationFrame_bool
            CopyFrom_tk2dSpriteAnimationFrame_bool
            {
                add => On.tk2dSpriteAnimationFrame.CopyFrom_tk2dSpriteAnimationFrame_bool += value;
                remove => On.tk2dSpriteAnimationFrame.CopyFrom_tk2dSpriteAnimationFrame_bool -= value;
            }
    }
}