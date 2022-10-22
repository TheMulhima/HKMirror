using MonoMod.RuntimeDetour;
using MonoMod.RuntimeDetour.HookGen;

namespace HKMirror.Hooks.OnHooks;

/// <summary>
///     Contains different types of On Hooks for GUILayoutToolbar class.<br />
///     Contains hooks that aren't generated by monomod, and before and after orig hooks for easier hooking.
/// </summary>
public static class OnGUILayoutToolbar
{
    internal static class HookHandler
    {
        private static readonly List<string> HookedList = new();

        internal static void Hookget_Contents()
        {
            if (!HookedList.Contains("get_Contents"))
            {
                HookedList.Add("get_Contents");
                new Hook(ReflectionHelper.GetMethodInfo(typeof(GUILayoutToolbar), "get_Contents"), get_Contents);
            }
        }

        internal static event Delegates.get_Contents_BeforeArgs _beforeget_Contents;
        internal static event Delegates.get_Contents_AfterArgs _afterget_Contents;

        private static GUIContent[] get_Contents(Func<GUILayoutToolbar, GUIContent[]> orig, GUILayoutToolbar self)
        {
            Delegates.Params_get_Contents @params = new()
            {
                self = self
            };
            if (_beforeget_Contents != null)
                foreach (Delegates.get_Contents_BeforeArgs toInvoke in _beforeget_Contents.GetInvocationList())
                    try
                    {
                        _beforeget_Contents?.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }

            self = @params.self;
            var retVal = orig(self);
            if (_afterget_Contents != null)
                foreach (Delegates.get_Contents_AfterArgs toInvoke in _afterget_Contents.GetInvocationList())
                    try
                    {
                        retVal = _afterget_Contents.Invoke(@params, retVal);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }

            return retVal;
        }

        internal static void HookSetButtonsContent()
        {
            if (!HookedList.Contains("SetButtonsContent"))
            {
                HookedList.Add("SetButtonsContent");
                new Hook(ReflectionHelper.GetMethodInfo(typeof(GUILayoutToolbar), "SetButtonsContent"),
                    SetButtonsContent);
            }
        }

        internal static event Delegates.SetButtonsContent_BeforeArgs _beforeSetButtonsContent;
        internal static event Delegates.SetButtonsContent_AfterArgs _afterSetButtonsContent;

        private static void SetButtonsContent(Action<GUILayoutToolbar> orig, GUILayoutToolbar self)
        {
            Delegates.Params_SetButtonsContent @params = new()
            {
                self = self
            };
            if (_beforeSetButtonsContent != null)
                foreach (Delegates.SetButtonsContent_BeforeArgs toInvoke in
                         _beforeSetButtonsContent.GetInvocationList())
                    try
                    {
                        _beforeSetButtonsContent?.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }

            self = @params.self;
            orig(self);
            if (_afterSetButtonsContent != null)
                foreach (Delegates.SetButtonsContent_AfterArgs toInvoke in _afterSetButtonsContent.GetInvocationList())
                    try
                    {
                        _afterSetButtonsContent.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }
        }

        internal static void HookReset()
        {
            if (!HookedList.Contains("Reset"))
            {
                HookedList.Add("Reset");
                new Hook(ReflectionHelper.GetMethodInfo(typeof(GUILayoutToolbar), "Reset"), Reset);
            }
        }

        internal static event Delegates.Reset_BeforeArgs _beforeReset;
        internal static event Delegates.Reset_AfterArgs _afterReset;

        private static void Reset(Action<GUILayoutToolbar> orig, GUILayoutToolbar self)
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
                new Hook(ReflectionHelper.GetMethodInfo(typeof(GUILayoutToolbar), "OnEnter"), OnEnter);
            }
        }

        internal static event Delegates.OnEnter_BeforeArgs _beforeOnEnter;
        internal static event Delegates.OnEnter_AfterArgs _afterOnEnter;

        private static void OnEnter(Action<GUILayoutToolbar> orig, GUILayoutToolbar self)
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

        internal static void HookOnGUI()
        {
            if (!HookedList.Contains("OnGUI"))
            {
                HookedList.Add("OnGUI");
                new Hook(ReflectionHelper.GetMethodInfo(typeof(GUILayoutToolbar), "OnGUI"), OnGUI);
            }
        }

        internal static event Delegates.OnGUI_BeforeArgs _beforeOnGUI;
        internal static event Delegates.OnGUI_AfterArgs _afterOnGUI;

        private static void OnGUI(Action<GUILayoutToolbar> orig, GUILayoutToolbar self)
        {
            Delegates.Params_OnGUI @params = new()
            {
                self = self
            };
            if (_beforeOnGUI != null)
                foreach (Delegates.OnGUI_BeforeArgs toInvoke in _beforeOnGUI.GetInvocationList())
                    try
                    {
                        _beforeOnGUI?.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }

            self = @params.self;
            orig(self);
            if (_afterOnGUI != null)
                foreach (Delegates.OnGUI_AfterArgs toInvoke in _afterOnGUI.GetInvocationList())
                    try
                    {
                        _afterOnGUI.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }
        }

        internal static void HookErrorCheck()
        {
            if (!HookedList.Contains("ErrorCheck"))
            {
                HookedList.Add("ErrorCheck");
                new Hook(ReflectionHelper.GetMethodInfo(typeof(GUILayoutToolbar), "ErrorCheck"), ErrorCheck);
            }
        }

        internal static event Delegates.ErrorCheck_BeforeArgs _beforeErrorCheck;
        internal static event Delegates.ErrorCheck_AfterArgs _afterErrorCheck;

        private static string ErrorCheck(Func<GUILayoutToolbar, string> orig, GUILayoutToolbar self)
        {
            Delegates.Params_ErrorCheck @params = new()
            {
                self = self
            };
            if (_beforeErrorCheck != null)
                foreach (Delegates.ErrorCheck_BeforeArgs toInvoke in _beforeErrorCheck.GetInvocationList())
                    try
                    {
                        _beforeErrorCheck?.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }

            self = @params.self;
            var retVal = orig(self);
            if (_afterErrorCheck != null)
                foreach (Delegates.ErrorCheck_AfterArgs toInvoke in _afterErrorCheck.GetInvocationList())
                    try
                    {
                        retVal = _afterErrorCheck.Invoke(@params, retVal);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }

            return retVal;
        }
    }

    /// <summary>
    ///     Contains necessary information to create Hooks. Does not contain any hooks
    /// </summary>
    public static class Delegates
    {
        public delegate string ErrorCheck_AfterArgs(Params_ErrorCheck args, string ret);

        public delegate void ErrorCheck_BeforeArgs(Params_ErrorCheck args);

        public delegate string ErrorCheck_WithArgs(Func<GUILayoutToolbar, string> orig, GUILayoutToolbar self);

        public delegate GUIContent[] get_Contents_AfterArgs(Params_get_Contents args, GUIContent[] ret);

        public delegate void get_Contents_BeforeArgs(Params_get_Contents args);

        public delegate GUIContent[] get_Contents_WithArgs(Func<GUILayoutToolbar, GUIContent[]> orig,
            GUILayoutToolbar self);

        public delegate void OnEnter_AfterArgs(Params_OnEnter args);

        public delegate void OnEnter_BeforeArgs(Params_OnEnter args);

        public delegate void OnEnter_WithArgs(Action<GUILayoutToolbar> orig, GUILayoutToolbar self);

        public delegate void OnGUI_AfterArgs(Params_OnGUI args);

        public delegate void OnGUI_BeforeArgs(Params_OnGUI args);

        public delegate void OnGUI_WithArgs(Action<GUILayoutToolbar> orig, GUILayoutToolbar self);

        public delegate void Reset_AfterArgs(Params_Reset args);

        public delegate void Reset_BeforeArgs(Params_Reset args);

        public delegate void Reset_WithArgs(Action<GUILayoutToolbar> orig, GUILayoutToolbar self);

        public delegate void SetButtonsContent_AfterArgs(Params_SetButtonsContent args);

        public delegate void SetButtonsContent_BeforeArgs(Params_SetButtonsContent args);

        public delegate void SetButtonsContent_WithArgs(Action<GUILayoutToolbar> orig, GUILayoutToolbar self);

        public sealed class Params_get_Contents
        {
            public GUILayoutToolbar self;
        }

        public sealed class Params_SetButtonsContent
        {
            public GUILayoutToolbar self;
        }

        public sealed class Params_Reset
        {
            public GUILayoutToolbar self;
        }

        public sealed class Params_OnEnter
        {
            public GUILayoutToolbar self;
        }

        public sealed class Params_OnGUI
        {
            public GUILayoutToolbar self;
        }

        public sealed class Params_ErrorCheck
        {
            public GUILayoutToolbar self;
        }
    }

    /// <summary>
    ///     Contains Hooks to that run code before orig(self) is called
    /// </summary>
    public static class BeforeOrig
    {
        public static event Delegates.get_Contents_BeforeArgs get_Contents
        {
            add
            {
                HookHandler._beforeget_Contents += value;
                HookHandler.Hookget_Contents();
            }
            remove => HookHandler._beforeget_Contents -= value;
        }

        public static event Delegates.SetButtonsContent_BeforeArgs SetButtonsContent
        {
            add
            {
                HookHandler._beforeSetButtonsContent += value;
                HookHandler.HookSetButtonsContent();
            }
            remove => HookHandler._beforeSetButtonsContent -= value;
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

        public static event Delegates.OnEnter_BeforeArgs OnEnter
        {
            add
            {
                HookHandler._beforeOnEnter += value;
                HookHandler.HookOnEnter();
            }
            remove => HookHandler._beforeOnEnter -= value;
        }

        public static event Delegates.OnGUI_BeforeArgs OnGUI
        {
            add
            {
                HookHandler._beforeOnGUI += value;
                HookHandler.HookOnGUI();
            }
            remove => HookHandler._beforeOnGUI -= value;
        }

        public static event Delegates.ErrorCheck_BeforeArgs ErrorCheck
        {
            add
            {
                HookHandler._beforeErrorCheck += value;
                HookHandler.HookErrorCheck();
            }
            remove => HookHandler._beforeErrorCheck -= value;
        }
    }

    /// <summary>
    ///     Contains Hooks to that run code after orig(self) is called
    /// </summary>
    public static class AfterOrig
    {
        public static event Delegates.get_Contents_AfterArgs get_Contents
        {
            add
            {
                HookHandler._afterget_Contents += value;
                HookHandler.Hookget_Contents();
            }
            remove => HookHandler._afterget_Contents -= value;
        }

        public static event Delegates.SetButtonsContent_AfterArgs SetButtonsContent
        {
            add
            {
                HookHandler._afterSetButtonsContent += value;
                HookHandler.HookSetButtonsContent();
            }
            remove => HookHandler._afterSetButtonsContent -= value;
        }

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

        public static event Delegates.OnGUI_AfterArgs OnGUI
        {
            add
            {
                HookHandler._afterOnGUI += value;
                HookHandler.HookOnGUI();
            }
            remove => HookHandler._afterOnGUI -= value;
        }

        public static event Delegates.ErrorCheck_AfterArgs ErrorCheck
        {
            add
            {
                HookHandler._afterErrorCheck += value;
                HookHandler.HookErrorCheck();
            }
            remove => HookHandler._afterErrorCheck -= value;
        }
    }

    /// <summary>
    ///     Contains all On Hooks, even those that aren't in the On namespace such as API generated functions and property
    ///     getters/setters
    /// </summary>
    public static class WithOrig
    {
        public static event Delegates.get_Contents_WithArgs get_Contents
        {
            add => HookEndpointManager.Add<Delegates.get_Contents_WithArgs>(
                ReflectionHelper.GetMethodInfo(typeof(GUILayoutToolbar), "get_Contents"), value);
            remove => HookEndpointManager.Remove<Delegates.get_Contents_WithArgs>(
                ReflectionHelper.GetMethodInfo(typeof(GUILayoutToolbar), "get_Contents"), value);
        }

        public static event Delegates.SetButtonsContent_WithArgs SetButtonsContent
        {
            add => HookEndpointManager.Add<Delegates.SetButtonsContent_WithArgs>(
                ReflectionHelper.GetMethodInfo(typeof(GUILayoutToolbar), "SetButtonsContent"), value);
            remove => HookEndpointManager.Remove<Delegates.SetButtonsContent_WithArgs>(
                ReflectionHelper.GetMethodInfo(typeof(GUILayoutToolbar), "SetButtonsContent"), value);
        }

        public static event Delegates.Reset_WithArgs Reset
        {
            add => HookEndpointManager.Add<Delegates.Reset_WithArgs>(
                ReflectionHelper.GetMethodInfo(typeof(GUILayoutToolbar), "Reset"), value);
            remove => HookEndpointManager.Remove<Delegates.Reset_WithArgs>(
                ReflectionHelper.GetMethodInfo(typeof(GUILayoutToolbar), "Reset"), value);
        }

        public static event Delegates.OnEnter_WithArgs OnEnter
        {
            add => HookEndpointManager.Add<Delegates.OnEnter_WithArgs>(
                ReflectionHelper.GetMethodInfo(typeof(GUILayoutToolbar), "OnEnter"), value);
            remove => HookEndpointManager.Remove<Delegates.OnEnter_WithArgs>(
                ReflectionHelper.GetMethodInfo(typeof(GUILayoutToolbar), "OnEnter"), value);
        }

        public static event Delegates.OnGUI_WithArgs OnGUI
        {
            add => HookEndpointManager.Add<Delegates.OnGUI_WithArgs>(
                ReflectionHelper.GetMethodInfo(typeof(GUILayoutToolbar), "OnGUI"), value);
            remove => HookEndpointManager.Remove<Delegates.OnGUI_WithArgs>(
                ReflectionHelper.GetMethodInfo(typeof(GUILayoutToolbar), "OnGUI"), value);
        }

        public static event Delegates.ErrorCheck_WithArgs ErrorCheck
        {
            add => HookEndpointManager.Add<Delegates.ErrorCheck_WithArgs>(
                ReflectionHelper.GetMethodInfo(typeof(GUILayoutToolbar), "ErrorCheck"), value);
            remove => HookEndpointManager.Remove<Delegates.ErrorCheck_WithArgs>(
                ReflectionHelper.GetMethodInfo(typeof(GUILayoutToolbar), "ErrorCheck"), value);
        }
    }
}