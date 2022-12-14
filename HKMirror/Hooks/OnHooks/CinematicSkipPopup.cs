namespace HKMirror.Hooks.OnHooks;

/// <summary>
///     Contains different types of On Hooks for CinematicSkipPopup class.<br />
///     Contains hooks that aren't generated by monomod, and before and after orig hooks for easier hooking.
/// </summary>
public static class OnCinematicSkipPopup
{
    internal static class HookHandler
    {
        private static readonly List<string> HookedList = new();

        internal static void HookAwake()
        {
            if (!HookedList.Contains("Awake"))
            {
                HookedList.Add("Awake");
                On.CinematicSkipPopup.Awake += Awake;
            }
        }

        internal static event Delegates.Awake_BeforeArgs _beforeAwake;
        internal static event Delegates.Awake_AfterArgs _afterAwake;

        private static void Awake(On.CinematicSkipPopup.orig_Awake orig, CinematicSkipPopup self)
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

        internal static void HookShow()
        {
            if (!HookedList.Contains("Show"))
            {
                HookedList.Add("Show");
                On.CinematicSkipPopup.Show += Show;
            }
        }

        internal static event Delegates.Show_BeforeArgs _beforeShow;
        internal static event Delegates.Show_AfterArgs _afterShow;

        private static void Show(On.CinematicSkipPopup.orig_Show orig, CinematicSkipPopup self,
            CinematicSkipPopup.Texts text)
        {
            Delegates.Params_Show @params = new()
            {
                self = self, text = text
            };
            if (_beforeShow != null)
                foreach (Delegates.Show_BeforeArgs toInvoke in _beforeShow.GetInvocationList())
                    try
                    {
                        _beforeShow?.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }

            self = @params.self;
            text = @params.text;
            orig(self, text);
            if (_afterShow != null)
                foreach (Delegates.Show_AfterArgs toInvoke in _afterShow.GetInvocationList())
                    try
                    {
                        _afterShow.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }
        }

        internal static void HookShowRoutine()
        {
            if (!HookedList.Contains("ShowRoutine"))
            {
                HookedList.Add("ShowRoutine");
                On.CinematicSkipPopup.ShowRoutine += ShowRoutine;
            }
        }

        internal static event Delegates.ShowRoutine_BeforeArgs _beforeShowRoutine;

        private static IEnumerator ShowRoutine(On.CinematicSkipPopup.orig_ShowRoutine orig, CinematicSkipPopup self)
        {
            Delegates.Params_ShowRoutine @params = new()
            {
                self = self
            };
            if (_beforeShowRoutine != null)
                foreach (Delegates.ShowRoutine_BeforeArgs toInvoke in _beforeShowRoutine.GetInvocationList())
                    try
                    {
                        _beforeShowRoutine?.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }

            self = @params.self;
            return orig(self);
        }

        internal static void HookHide()
        {
            if (!HookedList.Contains("Hide"))
            {
                HookedList.Add("Hide");
                On.CinematicSkipPopup.Hide += Hide;
            }
        }

        internal static event Delegates.Hide_BeforeArgs _beforeHide;
        internal static event Delegates.Hide_AfterArgs _afterHide;

        private static void Hide(On.CinematicSkipPopup.orig_Hide orig, CinematicSkipPopup self)
        {
            Delegates.Params_Hide @params = new()
            {
                self = self
            };
            if (_beforeHide != null)
                foreach (Delegates.Hide_BeforeArgs toInvoke in _beforeHide.GetInvocationList())
                    try
                    {
                        _beforeHide?.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }

            self = @params.self;
            orig(self);
            if (_afterHide != null)
                foreach (Delegates.Hide_AfterArgs toInvoke in _afterHide.GetInvocationList())
                    try
                    {
                        _afterHide.Invoke(@params);
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
                On.CinematicSkipPopup.Update += Update;
            }
        }

        internal static event Delegates.Update_BeforeArgs _beforeUpdate;
        internal static event Delegates.Update_AfterArgs _afterUpdate;

        private static void Update(On.CinematicSkipPopup.orig_Update orig, CinematicSkipPopup self)
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
    }

    /// <summary>
    ///     Contains necessary information to create Hooks. Does not contain any hooks
    /// </summary>
    public static class Delegates
    {
        public delegate void Awake_AfterArgs(Params_Awake args);

        public delegate void Awake_BeforeArgs(Params_Awake args);

        public delegate void Awake_WithArgs(Action<CinematicSkipPopup> orig, CinematicSkipPopup self);

        public delegate void Hide_AfterArgs(Params_Hide args);

        public delegate void Hide_BeforeArgs(Params_Hide args);

        public delegate void Hide_WithArgs(Action<CinematicSkipPopup> orig, CinematicSkipPopup self);

        public delegate void Show_AfterArgs(Params_Show args);

        public delegate void Show_BeforeArgs(Params_Show args);

        public delegate void Show_WithArgs(Action<CinematicSkipPopup, CinematicSkipPopup.Texts> orig,
            CinematicSkipPopup self, CinematicSkipPopup.Texts text);

        public delegate IEnumerator ShowRoutine_AfterArgs(Params_ShowRoutine args, IEnumerator ret);

        public delegate void ShowRoutine_BeforeArgs(Params_ShowRoutine args);

        public delegate IEnumerator ShowRoutine_WithArgs(Func<CinematicSkipPopup, IEnumerator> orig,
            CinematicSkipPopup self);

        public delegate void Update_AfterArgs(Params_Update args);

        public delegate void Update_BeforeArgs(Params_Update args);

        public delegate void Update_WithArgs(Action<CinematicSkipPopup> orig, CinematicSkipPopup self);

        public sealed class Params_Awake
        {
            public CinematicSkipPopup self;
        }

        public sealed class Params_Show
        {
            public CinematicSkipPopup self;
            public CinematicSkipPopup.Texts text;
        }

        public sealed class Params_ShowRoutine
        {
            public CinematicSkipPopup self;
        }

        public sealed class Params_Hide
        {
            public CinematicSkipPopup self;
        }

        public sealed class Params_Update
        {
            public CinematicSkipPopup self;
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

        public static event Delegates.Show_BeforeArgs Show
        {
            add
            {
                HookHandler._beforeShow += value;
                HookHandler.HookShow();
            }
            remove => HookHandler._beforeShow -= value;
        }

        public static event Delegates.ShowRoutine_BeforeArgs ShowRoutine
        {
            add
            {
                HookHandler._beforeShowRoutine += value;
                HookHandler.HookShowRoutine();
            }
            remove => HookHandler._beforeShowRoutine -= value;
        }

        public static event Delegates.Hide_BeforeArgs Hide
        {
            add
            {
                HookHandler._beforeHide += value;
                HookHandler.HookHide();
            }
            remove => HookHandler._beforeHide -= value;
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

        public static event Delegates.Show_AfterArgs Show
        {
            add
            {
                HookHandler._afterShow += value;
                HookHandler.HookShow();
            }
            remove => HookHandler._afterShow -= value;
        }

        public static event Delegates.Hide_AfterArgs Hide
        {
            add
            {
                HookHandler._afterHide += value;
                HookHandler.HookHide();
            }
            remove => HookHandler._afterHide -= value;
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
    }

    /// <summary>
    ///     Contains all On Hooks, even those that aren't in the On namespace such as API generated functions and property
    ///     getters/setters
    /// </summary>
    public static class WithOrig
    {
        public static event On.CinematicSkipPopup.hook_Awake Awake
        {
            add => On.CinematicSkipPopup.Awake += value;
            remove => On.CinematicSkipPopup.Awake -= value;
        }

        public static event On.CinematicSkipPopup.hook_Show Show
        {
            add => On.CinematicSkipPopup.Show += value;
            remove => On.CinematicSkipPopup.Show -= value;
        }

        public static event On.CinematicSkipPopup.hook_ShowRoutine ShowRoutine
        {
            add => On.CinematicSkipPopup.ShowRoutine += value;
            remove => On.CinematicSkipPopup.ShowRoutine -= value;
        }

        public static event On.CinematicSkipPopup.hook_Hide Hide
        {
            add => On.CinematicSkipPopup.Hide += value;
            remove => On.CinematicSkipPopup.Hide -= value;
        }

        public static event On.CinematicSkipPopup.hook_Update Update
        {
            add => On.CinematicSkipPopup.Update += value;
            remove => On.CinematicSkipPopup.Update -= value;
        }
    }
}