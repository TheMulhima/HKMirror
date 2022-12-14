using MonoMod.RuntimeDetour;
using MonoMod.RuntimeDetour.HookGen;

namespace HKMirror.Hooks.OnHooks;

/// <summary>
///     Contains different types of On Hooks for StartManager class.<br />
///     Contains hooks that aren't generated by monomod, and before and after orig hooks for easier hooking.
/// </summary>
public static class OnStartManager
{
    internal static class HookHandler
    {
        private static readonly List<string> HookedList = new();

        internal static void HookAwake()
        {
            if (!HookedList.Contains("Awake"))
            {
                HookedList.Add("Awake");
                On.StartManager.Awake += Awake;
            }
        }

        internal static event Delegates.Awake_BeforeArgs _beforeAwake;
        internal static event Delegates.Awake_AfterArgs _afterAwake;

        private static void Awake(On.StartManager.orig_Awake orig, StartManager self)
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

        internal static void HookStart()
        {
            if (!HookedList.Contains("Start"))
            {
                HookedList.Add("Start");
                On.StartManager.Start += Start;
            }
        }

        internal static event Delegates.Start_BeforeArgs _beforeStart;

        private static IEnumerator Start(On.StartManager.orig_Start orig, StartManager self)
        {
            Delegates.Params_Start @params = new()
            {
                self = self
            };
            if (_beforeStart != null)
                foreach (Delegates.Start_BeforeArgs toInvoke in _beforeStart.GetInvocationList())
                    try
                    {
                        _beforeStart?.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }

            self = @params.self;
            return orig(self);
        }

        internal static void HookGetControllerSpriteForPlatform()
        {
            if (!HookedList.Contains("GetControllerSpriteForPlatform"))
            {
                HookedList.Add("GetControllerSpriteForPlatform");
                On.StartManager.GetControllerSpriteForPlatform += GetControllerSpriteForPlatform;
            }
        }

        internal static event Delegates.GetControllerSpriteForPlatform_BeforeArgs _beforeGetControllerSpriteForPlatform;
        internal static event Delegates.GetControllerSpriteForPlatform_AfterArgs _afterGetControllerSpriteForPlatform;

        private static Sprite GetControllerSpriteForPlatform(On.StartManager.orig_GetControllerSpriteForPlatform orig,
            StartManager self, RuntimePlatform runtimePlatform)
        {
            Delegates.Params_GetControllerSpriteForPlatform @params = new()
            {
                self = self, runtimePlatform = runtimePlatform
            };
            if (_beforeGetControllerSpriteForPlatform != null)
                foreach (Delegates.GetControllerSpriteForPlatform_BeforeArgs toInvoke in
                         _beforeGetControllerSpriteForPlatform.GetInvocationList())
                    try
                    {
                        _beforeGetControllerSpriteForPlatform?.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }

            self = @params.self;
            runtimePlatform = @params.runtimePlatform;
            var retVal = orig(self, runtimePlatform);
            if (_afterGetControllerSpriteForPlatform != null)
                foreach (Delegates.GetControllerSpriteForPlatform_AfterArgs toInvoke in
                         _afterGetControllerSpriteForPlatform.GetInvocationList())
                    try
                    {
                        retVal = _afterGetControllerSpriteForPlatform.Invoke(@params, retVal);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }

            return retVal;
        }

        internal static void HookSwitchToMenuScene()
        {
            if (!HookedList.Contains("SwitchToMenuScene"))
            {
                HookedList.Add("SwitchToMenuScene");
                On.StartManager.SwitchToMenuScene += SwitchToMenuScene;
            }
        }

        internal static event Delegates.SwitchToMenuScene_BeforeArgs _beforeSwitchToMenuScene;
        internal static event Delegates.SwitchToMenuScene_AfterArgs _afterSwitchToMenuScene;

        private static void SwitchToMenuScene(On.StartManager.orig_SwitchToMenuScene orig, StartManager self)
        {
            Delegates.Params_SwitchToMenuScene @params = new()
            {
                self = self
            };
            if (_beforeSwitchToMenuScene != null)
                foreach (Delegates.SwitchToMenuScene_BeforeArgs toInvoke in
                         _beforeSwitchToMenuScene.GetInvocationList())
                    try
                    {
                        _beforeSwitchToMenuScene?.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }

            self = @params.self;
            orig(self);
            if (_afterSwitchToMenuScene != null)
                foreach (Delegates.SwitchToMenuScene_AfterArgs toInvoke in _afterSwitchToMenuScene.GetInvocationList())
                    try
                    {
                        _afterSwitchToMenuScene.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }
        }

        internal static void HookSetLanguage()
        {
            if (!HookedList.Contains("SetLanguage"))
            {
                HookedList.Add("SetLanguage");
                On.StartManager.SetLanguage += SetLanguage;
            }
        }

        internal static event Delegates.SetLanguage_BeforeArgs _beforeSetLanguage;
        internal static event Delegates.SetLanguage_AfterArgs _afterSetLanguage;

        private static void SetLanguage(On.StartManager.orig_SetLanguage orig, StartManager self, string newLanguage)
        {
            Delegates.Params_SetLanguage @params = new()
            {
                self = self, newLanguage = newLanguage
            };
            if (_beforeSetLanguage != null)
                foreach (Delegates.SetLanguage_BeforeArgs toInvoke in _beforeSetLanguage.GetInvocationList())
                    try
                    {
                        _beforeSetLanguage?.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }

            self = @params.self;
            newLanguage = @params.newLanguage;
            orig(self, newLanguage);
            if (_afterSetLanguage != null)
                foreach (Delegates.SetLanguage_AfterArgs toInvoke in _afterSetLanguage.GetInvocationList())
                    try
                    {
                        _afterSetLanguage.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }
        }

        internal static void HookFadeIn()
        {
            if (!HookedList.Contains("FadeIn"))
            {
                HookedList.Add("FadeIn");
                On.StartManager.FadeIn += FadeIn;
            }
        }

        internal static event Delegates.FadeIn_BeforeArgs _beforeFadeIn;

        private static IEnumerator FadeIn(On.StartManager.orig_FadeIn orig, StartManager self, CanvasGroup group,
            float duration)
        {
            Delegates.Params_FadeIn @params = new()
            {
                self = self, group = group, duration = duration
            };
            if (_beforeFadeIn != null)
                foreach (Delegates.FadeIn_BeforeArgs toInvoke in _beforeFadeIn.GetInvocationList())
                    try
                    {
                        _beforeFadeIn?.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }

            self = @params.self;
            group = @params.group;
            duration = @params.duration;
            return orig(self, group, duration);
        }

        internal static void HookFadeOut()
        {
            if (!HookedList.Contains("FadeOut"))
            {
                HookedList.Add("FadeOut");
                On.StartManager.FadeOut += FadeOut;
            }
        }

        internal static event Delegates.FadeOut_BeforeArgs _beforeFadeOut;

        private static IEnumerator FadeOut(On.StartManager.orig_FadeOut orig, StartManager self, CanvasGroup group,
            float duration)
        {
            Delegates.Params_FadeOut @params = new()
            {
                self = self, group = group, duration = duration
            };
            if (_beforeFadeOut != null)
                foreach (Delegates.FadeOut_BeforeArgs toInvoke in _beforeFadeOut.GetInvocationList())
                    try
                    {
                        _beforeFadeOut?.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }

            self = @params.self;
            group = @params.group;
            duration = @params.duration;
            return orig(self, group, duration);
        }

        internal static void HookCheckIsLanguageSet()
        {
            if (!HookedList.Contains("CheckIsLanguageSet"))
            {
                HookedList.Add("CheckIsLanguageSet");
                On.StartManager.CheckIsLanguageSet += CheckIsLanguageSet;
            }
        }

        internal static event Delegates.CheckIsLanguageSet_BeforeArgs _beforeCheckIsLanguageSet;
        internal static event Delegates.CheckIsLanguageSet_AfterArgs _afterCheckIsLanguageSet;

        private static bool CheckIsLanguageSet(On.StartManager.orig_CheckIsLanguageSet orig, StartManager self)
        {
            Delegates.Params_CheckIsLanguageSet @params = new()
            {
                self = self
            };
            if (_beforeCheckIsLanguageSet != null)
                foreach (Delegates.CheckIsLanguageSet_BeforeArgs toInvoke in
                         _beforeCheckIsLanguageSet.GetInvocationList())
                    try
                    {
                        _beforeCheckIsLanguageSet?.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }

            self = @params.self;
            var retVal = orig(self);
            if (_afterCheckIsLanguageSet != null)
                foreach (Delegates.CheckIsLanguageSet_AfterArgs toInvoke in
                         _afterCheckIsLanguageSet.GetInvocationList())
                    try
                    {
                        retVal = _afterCheckIsLanguageSet.Invoke(@params, retVal);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }

            return retVal;
        }

        internal static void HookConfirmLanguage()
        {
            if (!HookedList.Contains("ConfirmLanguage"))
            {
                HookedList.Add("ConfirmLanguage");
                On.StartManager.ConfirmLanguage += ConfirmLanguage;
            }
        }

        internal static event Delegates.ConfirmLanguage_BeforeArgs _beforeConfirmLanguage;
        internal static event Delegates.ConfirmLanguage_AfterArgs _afterConfirmLanguage;

        private static void ConfirmLanguage(On.StartManager.orig_ConfirmLanguage orig, StartManager self)
        {
            Delegates.Params_ConfirmLanguage @params = new()
            {
                self = self
            };
            if (_beforeConfirmLanguage != null)
                foreach (Delegates.ConfirmLanguage_BeforeArgs toInvoke in _beforeConfirmLanguage.GetInvocationList())
                    try
                    {
                        _beforeConfirmLanguage?.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }

            self = @params.self;
            orig(self);
            if (_afterConfirmLanguage != null)
                foreach (Delegates.ConfirmLanguage_AfterArgs toInvoke in _afterConfirmLanguage.GetInvocationList())
                    try
                    {
                        _afterConfirmLanguage.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }
        }

        internal static void HookCancelLanguage()
        {
            if (!HookedList.Contains("CancelLanguage"))
            {
                HookedList.Add("CancelLanguage");
                On.StartManager.CancelLanguage += CancelLanguage;
            }
        }

        internal static event Delegates.CancelLanguage_BeforeArgs _beforeCancelLanguage;
        internal static event Delegates.CancelLanguage_AfterArgs _afterCancelLanguage;

        private static void CancelLanguage(On.StartManager.orig_CancelLanguage orig, StartManager self)
        {
            Delegates.Params_CancelLanguage @params = new()
            {
                self = self
            };
            if (_beforeCancelLanguage != null)
                foreach (Delegates.CancelLanguage_BeforeArgs toInvoke in _beforeCancelLanguage.GetInvocationList())
                    try
                    {
                        _beforeCancelLanguage?.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }

            self = @params.self;
            orig(self);
            if (_afterCancelLanguage != null)
                foreach (Delegates.CancelLanguage_AfterArgs toInvoke in _afterCancelLanguage.GetInvocationList())
                    try
                    {
                        _afterCancelLanguage.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }
        }

        internal static void HookShowLanguageSelect()
        {
            if (!HookedList.Contains("ShowLanguageSelect"))
            {
                HookedList.Add("ShowLanguageSelect");
                On.StartManager.ShowLanguageSelect += ShowLanguageSelect;
            }
        }

        internal static event Delegates.ShowLanguageSelect_BeforeArgs _beforeShowLanguageSelect;

        private static IEnumerator ShowLanguageSelect(On.StartManager.orig_ShowLanguageSelect orig, StartManager self)
        {
            Delegates.Params_ShowLanguageSelect @params = new()
            {
                self = self
            };
            if (_beforeShowLanguageSelect != null)
                foreach (Delegates.ShowLanguageSelect_BeforeArgs toInvoke in
                         _beforeShowLanguageSelect.GetInvocationList())
                    try
                    {
                        _beforeShowLanguageSelect?.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }

            self = @params.self;
            return orig(self);
        }

        internal static void HookLanguageSettingDone()
        {
            if (!HookedList.Contains("LanguageSettingDone"))
            {
                HookedList.Add("LanguageSettingDone");
                On.StartManager.LanguageSettingDone += LanguageSettingDone;
            }
        }

        internal static event Delegates.LanguageSettingDone_BeforeArgs _beforeLanguageSettingDone;

        private static IEnumerator LanguageSettingDone(On.StartManager.orig_LanguageSettingDone orig, StartManager self)
        {
            Delegates.Params_LanguageSettingDone @params = new()
            {
                self = self
            };
            if (_beforeLanguageSettingDone != null)
                foreach (Delegates.LanguageSettingDone_BeforeArgs toInvoke in _beforeLanguageSettingDone
                             .GetInvocationList())
                    try
                    {
                        _beforeLanguageSettingDone?.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }

            self = @params.self;
            return orig(self);
        }

        internal static void Hookorig_Start()
        {
            if (!HookedList.Contains("orig_Start"))
            {
                HookedList.Add("orig_Start");
                new Hook(ReflectionHelper.GetMethodInfo(typeof(StartManager), "orig_Start"), orig_Start);
            }
        }

        internal static event Delegates.orig_Start_BeforeArgs _beforeorig_Start;

        private static IEnumerator orig_Start(Func<StartManager, IEnumerator> orig, StartManager self)
        {
            Delegates.Params_orig_Start @params = new()
            {
                self = self
            };
            if (_beforeorig_Start != null)
                foreach (Delegates.orig_Start_BeforeArgs toInvoke in _beforeorig_Start.GetInvocationList())
                    try
                    {
                        _beforeorig_Start?.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }

            self = @params.self;
            return orig(self);
        }
    }

    /// <summary>
    ///     Contains necessary information to create Hooks. Does not contain any hooks
    /// </summary>
    public static class Delegates
    {
        public delegate void Awake_AfterArgs(Params_Awake args);

        public delegate void Awake_BeforeArgs(Params_Awake args);

        public delegate void Awake_WithArgs(Action<StartManager> orig, StartManager self);

        public delegate void CancelLanguage_AfterArgs(Params_CancelLanguage args);

        public delegate void CancelLanguage_BeforeArgs(Params_CancelLanguage args);

        public delegate void CancelLanguage_WithArgs(Action<StartManager> orig, StartManager self);

        public delegate bool CheckIsLanguageSet_AfterArgs(Params_CheckIsLanguageSet args, bool ret);

        public delegate void CheckIsLanguageSet_BeforeArgs(Params_CheckIsLanguageSet args);

        public delegate bool CheckIsLanguageSet_WithArgs(Func<StartManager, bool> orig, StartManager self);

        public delegate void ConfirmLanguage_AfterArgs(Params_ConfirmLanguage args);

        public delegate void ConfirmLanguage_BeforeArgs(Params_ConfirmLanguage args);

        public delegate void ConfirmLanguage_WithArgs(Action<StartManager> orig, StartManager self);

        public delegate IEnumerator FadeIn_AfterArgs(Params_FadeIn args, IEnumerator ret);

        public delegate void FadeIn_BeforeArgs(Params_FadeIn args);

        public delegate IEnumerator FadeIn_WithArgs(Func<StartManager, CanvasGroup, float, IEnumerator> orig,
            StartManager self, CanvasGroup group, float duration);

        public delegate IEnumerator FadeOut_AfterArgs(Params_FadeOut args, IEnumerator ret);

        public delegate void FadeOut_BeforeArgs(Params_FadeOut args);

        public delegate IEnumerator FadeOut_WithArgs(Func<StartManager, CanvasGroup, float, IEnumerator> orig,
            StartManager self, CanvasGroup group, float duration);

        public delegate Sprite GetControllerSpriteForPlatform_AfterArgs(Params_GetControllerSpriteForPlatform args,
            Sprite ret);

        public delegate void GetControllerSpriteForPlatform_BeforeArgs(Params_GetControllerSpriteForPlatform args);

        public delegate Sprite GetControllerSpriteForPlatform_WithArgs(Func<StartManager, RuntimePlatform, Sprite> orig,
            StartManager self, RuntimePlatform runtimePlatform);

        public delegate IEnumerator LanguageSettingDone_AfterArgs(Params_LanguageSettingDone args, IEnumerator ret);

        public delegate void LanguageSettingDone_BeforeArgs(Params_LanguageSettingDone args);

        public delegate IEnumerator LanguageSettingDone_WithArgs(Func<StartManager, IEnumerator> orig,
            StartManager self);

        public delegate IEnumerator orig_Start_AfterArgs(Params_orig_Start args, IEnumerator ret);

        public delegate void orig_Start_BeforeArgs(Params_orig_Start args);

        public delegate IEnumerator orig_Start_WithArgs(Func<StartManager, IEnumerator> orig, StartManager self);

        public delegate void SetLanguage_AfterArgs(Params_SetLanguage args);

        public delegate void SetLanguage_BeforeArgs(Params_SetLanguage args);

        public delegate void SetLanguage_WithArgs(Action<StartManager, string> orig, StartManager self,
            string newLanguage);

        public delegate IEnumerator ShowLanguageSelect_AfterArgs(Params_ShowLanguageSelect args, IEnumerator ret);

        public delegate void ShowLanguageSelect_BeforeArgs(Params_ShowLanguageSelect args);

        public delegate IEnumerator
            ShowLanguageSelect_WithArgs(Func<StartManager, IEnumerator> orig, StartManager self);

        public delegate IEnumerator Start_AfterArgs(Params_Start args, IEnumerator ret);

        public delegate void Start_BeforeArgs(Params_Start args);

        public delegate IEnumerator Start_WithArgs(Func<StartManager, IEnumerator> orig, StartManager self);

        public delegate void SwitchToMenuScene_AfterArgs(Params_SwitchToMenuScene args);

        public delegate void SwitchToMenuScene_BeforeArgs(Params_SwitchToMenuScene args);

        public delegate void SwitchToMenuScene_WithArgs(Action<StartManager> orig, StartManager self);

        public sealed class Params_Awake
        {
            public StartManager self;
        }

        public sealed class Params_Start
        {
            public StartManager self;
        }

        public sealed class Params_GetControllerSpriteForPlatform
        {
            public RuntimePlatform runtimePlatform;
            public StartManager self;
        }

        public sealed class Params_SwitchToMenuScene
        {
            public StartManager self;
        }

        public sealed class Params_SetLanguage
        {
            public string newLanguage;
            public StartManager self;
        }

        public sealed class Params_FadeIn
        {
            public float duration;
            public CanvasGroup group;
            public StartManager self;
        }

        public sealed class Params_FadeOut
        {
            public float duration;
            public CanvasGroup group;
            public StartManager self;
        }

        public sealed class Params_CheckIsLanguageSet
        {
            public StartManager self;
        }

        public sealed class Params_ConfirmLanguage
        {
            public StartManager self;
        }

        public sealed class Params_CancelLanguage
        {
            public StartManager self;
        }

        public sealed class Params_ShowLanguageSelect
        {
            public StartManager self;
        }

        public sealed class Params_LanguageSettingDone
        {
            public StartManager self;
        }

        public sealed class Params_orig_Start
        {
            public StartManager self;
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

        public static event Delegates.Start_BeforeArgs Start
        {
            add
            {
                HookHandler._beforeStart += value;
                HookHandler.HookStart();
            }
            remove => HookHandler._beforeStart -= value;
        }

        public static event Delegates.GetControllerSpriteForPlatform_BeforeArgs GetControllerSpriteForPlatform
        {
            add
            {
                HookHandler._beforeGetControllerSpriteForPlatform += value;
                HookHandler.HookGetControllerSpriteForPlatform();
            }
            remove => HookHandler._beforeGetControllerSpriteForPlatform -= value;
        }

        public static event Delegates.SwitchToMenuScene_BeforeArgs SwitchToMenuScene
        {
            add
            {
                HookHandler._beforeSwitchToMenuScene += value;
                HookHandler.HookSwitchToMenuScene();
            }
            remove => HookHandler._beforeSwitchToMenuScene -= value;
        }

        public static event Delegates.SetLanguage_BeforeArgs SetLanguage
        {
            add
            {
                HookHandler._beforeSetLanguage += value;
                HookHandler.HookSetLanguage();
            }
            remove => HookHandler._beforeSetLanguage -= value;
        }

        public static event Delegates.FadeIn_BeforeArgs FadeIn
        {
            add
            {
                HookHandler._beforeFadeIn += value;
                HookHandler.HookFadeIn();
            }
            remove => HookHandler._beforeFadeIn -= value;
        }

        public static event Delegates.FadeOut_BeforeArgs FadeOut
        {
            add
            {
                HookHandler._beforeFadeOut += value;
                HookHandler.HookFadeOut();
            }
            remove => HookHandler._beforeFadeOut -= value;
        }

        public static event Delegates.CheckIsLanguageSet_BeforeArgs CheckIsLanguageSet
        {
            add
            {
                HookHandler._beforeCheckIsLanguageSet += value;
                HookHandler.HookCheckIsLanguageSet();
            }
            remove => HookHandler._beforeCheckIsLanguageSet -= value;
        }

        public static event Delegates.ConfirmLanguage_BeforeArgs ConfirmLanguage
        {
            add
            {
                HookHandler._beforeConfirmLanguage += value;
                HookHandler.HookConfirmLanguage();
            }
            remove => HookHandler._beforeConfirmLanguage -= value;
        }

        public static event Delegates.CancelLanguage_BeforeArgs CancelLanguage
        {
            add
            {
                HookHandler._beforeCancelLanguage += value;
                HookHandler.HookCancelLanguage();
            }
            remove => HookHandler._beforeCancelLanguage -= value;
        }

        public static event Delegates.ShowLanguageSelect_BeforeArgs ShowLanguageSelect
        {
            add
            {
                HookHandler._beforeShowLanguageSelect += value;
                HookHandler.HookShowLanguageSelect();
            }
            remove => HookHandler._beforeShowLanguageSelect -= value;
        }

        public static event Delegates.LanguageSettingDone_BeforeArgs LanguageSettingDone
        {
            add
            {
                HookHandler._beforeLanguageSettingDone += value;
                HookHandler.HookLanguageSettingDone();
            }
            remove => HookHandler._beforeLanguageSettingDone -= value;
        }

        public static event Delegates.orig_Start_BeforeArgs orig_Start
        {
            add
            {
                HookHandler._beforeorig_Start += value;
                HookHandler.Hookorig_Start();
            }
            remove => HookHandler._beforeorig_Start -= value;
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

        public static event Delegates.GetControllerSpriteForPlatform_AfterArgs GetControllerSpriteForPlatform
        {
            add
            {
                HookHandler._afterGetControllerSpriteForPlatform += value;
                HookHandler.HookGetControllerSpriteForPlatform();
            }
            remove => HookHandler._afterGetControllerSpriteForPlatform -= value;
        }

        public static event Delegates.SwitchToMenuScene_AfterArgs SwitchToMenuScene
        {
            add
            {
                HookHandler._afterSwitchToMenuScene += value;
                HookHandler.HookSwitchToMenuScene();
            }
            remove => HookHandler._afterSwitchToMenuScene -= value;
        }

        public static event Delegates.SetLanguage_AfterArgs SetLanguage
        {
            add
            {
                HookHandler._afterSetLanguage += value;
                HookHandler.HookSetLanguage();
            }
            remove => HookHandler._afterSetLanguage -= value;
        }

        public static event Delegates.CheckIsLanguageSet_AfterArgs CheckIsLanguageSet
        {
            add
            {
                HookHandler._afterCheckIsLanguageSet += value;
                HookHandler.HookCheckIsLanguageSet();
            }
            remove => HookHandler._afterCheckIsLanguageSet -= value;
        }

        public static event Delegates.ConfirmLanguage_AfterArgs ConfirmLanguage
        {
            add
            {
                HookHandler._afterConfirmLanguage += value;
                HookHandler.HookConfirmLanguage();
            }
            remove => HookHandler._afterConfirmLanguage -= value;
        }

        public static event Delegates.CancelLanguage_AfterArgs CancelLanguage
        {
            add
            {
                HookHandler._afterCancelLanguage += value;
                HookHandler.HookCancelLanguage();
            }
            remove => HookHandler._afterCancelLanguage -= value;
        }
    }

    /// <summary>
    ///     Contains all On Hooks, even those that aren't in the On namespace such as API generated functions and property
    ///     getters/setters
    /// </summary>
    public static class WithOrig
    {
        public static event On.StartManager.hook_Awake Awake
        {
            add => On.StartManager.Awake += value;
            remove => On.StartManager.Awake -= value;
        }

        public static event On.StartManager.hook_Start Start
        {
            add => On.StartManager.Start += value;
            remove => On.StartManager.Start -= value;
        }

        public static event On.StartManager.hook_GetControllerSpriteForPlatform GetControllerSpriteForPlatform
        {
            add => On.StartManager.GetControllerSpriteForPlatform += value;
            remove => On.StartManager.GetControllerSpriteForPlatform -= value;
        }

        public static event On.StartManager.hook_SwitchToMenuScene SwitchToMenuScene
        {
            add => On.StartManager.SwitchToMenuScene += value;
            remove => On.StartManager.SwitchToMenuScene -= value;
        }

        public static event On.StartManager.hook_SetLanguage SetLanguage
        {
            add => On.StartManager.SetLanguage += value;
            remove => On.StartManager.SetLanguage -= value;
        }

        public static event On.StartManager.hook_FadeIn FadeIn
        {
            add => On.StartManager.FadeIn += value;
            remove => On.StartManager.FadeIn -= value;
        }

        public static event On.StartManager.hook_FadeOut FadeOut
        {
            add => On.StartManager.FadeOut += value;
            remove => On.StartManager.FadeOut -= value;
        }

        public static event On.StartManager.hook_CheckIsLanguageSet CheckIsLanguageSet
        {
            add => On.StartManager.CheckIsLanguageSet += value;
            remove => On.StartManager.CheckIsLanguageSet -= value;
        }

        public static event On.StartManager.hook_ConfirmLanguage ConfirmLanguage
        {
            add => On.StartManager.ConfirmLanguage += value;
            remove => On.StartManager.ConfirmLanguage -= value;
        }

        public static event On.StartManager.hook_CancelLanguage CancelLanguage
        {
            add => On.StartManager.CancelLanguage += value;
            remove => On.StartManager.CancelLanguage -= value;
        }

        public static event On.StartManager.hook_ShowLanguageSelect ShowLanguageSelect
        {
            add => On.StartManager.ShowLanguageSelect += value;
            remove => On.StartManager.ShowLanguageSelect -= value;
        }

        public static event On.StartManager.hook_LanguageSettingDone LanguageSettingDone
        {
            add => On.StartManager.LanguageSettingDone += value;
            remove => On.StartManager.LanguageSettingDone -= value;
        }

        public static event Delegates.orig_Start_WithArgs orig_Start
        {
            add => HookEndpointManager.Add<Delegates.orig_Start_WithArgs>(
                ReflectionHelper.GetMethodInfo(typeof(StartManager), "orig_Start"), value);
            remove => HookEndpointManager.Remove<Delegates.orig_Start_WithArgs>(
                ReflectionHelper.GetMethodInfo(typeof(StartManager), "orig_Start"), value);
        }
    }
}