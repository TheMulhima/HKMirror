using MonoMod.RuntimeDetour;
using MonoMod.RuntimeDetour.HookGen;

namespace HKMirror.Hooks.OnHooks;

/// <summary>
///     Contains different types of On Hooks for ModalDialog class.<br />
///     Contains hooks that aren't generated by monomod, and before and after orig hooks for easier hooking.
/// </summary>
public static class OnModalDialog
{
    internal static class HookHandler
    {
        private static readonly List<string> HookedList = new();

        internal static void Hookget_modalWindow()
        {
            if (!HookedList.Contains("get_modalWindow"))
            {
                HookedList.Add("get_modalWindow");
                new Hook(ReflectionHelper.GetMethodInfo(typeof(ModalDialog), "get_modalWindow"), get_modalWindow);
            }
        }

        internal static event Delegates.get_modalWindow_BeforeArgs _beforeget_modalWindow;
        internal static event Delegates.get_modalWindow_AfterArgs _afterget_modalWindow;

        private static CanvasGroup get_modalWindow(Func<ModalDialog, CanvasGroup> orig, ModalDialog self)
        {
            Delegates.Params_get_modalWindow @params = new()
            {
                self = self
            };
            if (_beforeget_modalWindow != null)
                foreach (Delegates.get_modalWindow_BeforeArgs toInvoke in _beforeget_modalWindow.GetInvocationList())
                    try
                    {
                        _beforeget_modalWindow?.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }

            self = @params.self;
            var retVal = orig(self);
            if (_afterget_modalWindow != null)
                foreach (Delegates.get_modalWindow_AfterArgs toInvoke in _afterget_modalWindow.GetInvocationList())
                    try
                    {
                        retVal = _afterget_modalWindow.Invoke(@params, retVal);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }

            return retVal;
        }

        internal static void HookHighlightDefault()
        {
            if (!HookedList.Contains("HighlightDefault"))
            {
                HookedList.Add("HighlightDefault");
                On.ModalDialog.HighlightDefault += HighlightDefault;
            }
        }

        internal static event Delegates.HighlightDefault_BeforeArgs _beforeHighlightDefault;
        internal static event Delegates.HighlightDefault_AfterArgs _afterHighlightDefault;

        private static void HighlightDefault(On.ModalDialog.orig_HighlightDefault orig, ModalDialog self)
        {
            Delegates.Params_HighlightDefault @params = new()
            {
                self = self
            };
            if (_beforeHighlightDefault != null)
                foreach (Delegates.HighlightDefault_BeforeArgs toInvoke in _beforeHighlightDefault.GetInvocationList())
                    try
                    {
                        _beforeHighlightDefault?.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }

            self = @params.self;
            orig(self);
            if (_afterHighlightDefault != null)
                foreach (Delegates.HighlightDefault_AfterArgs toInvoke in _afterHighlightDefault.GetInvocationList())
                    try
                    {
                        _afterHighlightDefault.Invoke(@params);
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
        public delegate CanvasGroup get_modalWindow_AfterArgs(Params_get_modalWindow args, CanvasGroup ret);

        public delegate void get_modalWindow_BeforeArgs(Params_get_modalWindow args);

        public delegate CanvasGroup get_modalWindow_WithArgs(Func<ModalDialog, CanvasGroup> orig, ModalDialog self);

        public delegate void HighlightDefault_AfterArgs(Params_HighlightDefault args);

        public delegate void HighlightDefault_BeforeArgs(Params_HighlightDefault args);

        public delegate void HighlightDefault_WithArgs(Action<ModalDialog> orig, ModalDialog self);

        public sealed class Params_get_modalWindow
        {
            public ModalDialog self;
        }

        public sealed class Params_HighlightDefault
        {
            public ModalDialog self;
        }
    }

    /// <summary>
    ///     Contains Hooks to that run code before orig(self) is called
    /// </summary>
    public static class BeforeOrig
    {
        public static event Delegates.get_modalWindow_BeforeArgs get_modalWindow
        {
            add
            {
                HookHandler._beforeget_modalWindow += value;
                HookHandler.Hookget_modalWindow();
            }
            remove => HookHandler._beforeget_modalWindow -= value;
        }

        public static event Delegates.HighlightDefault_BeforeArgs HighlightDefault
        {
            add
            {
                HookHandler._beforeHighlightDefault += value;
                HookHandler.HookHighlightDefault();
            }
            remove => HookHandler._beforeHighlightDefault -= value;
        }
    }

    /// <summary>
    ///     Contains Hooks to that run code after orig(self) is called
    /// </summary>
    public static class AfterOrig
    {
        public static event Delegates.get_modalWindow_AfterArgs get_modalWindow
        {
            add
            {
                HookHandler._afterget_modalWindow += value;
                HookHandler.Hookget_modalWindow();
            }
            remove => HookHandler._afterget_modalWindow -= value;
        }

        public static event Delegates.HighlightDefault_AfterArgs HighlightDefault
        {
            add
            {
                HookHandler._afterHighlightDefault += value;
                HookHandler.HookHighlightDefault();
            }
            remove => HookHandler._afterHighlightDefault -= value;
        }
    }

    /// <summary>
    ///     Contains all On Hooks, even those that aren't in the On namespace such as API generated functions and property
    ///     getters/setters
    /// </summary>
    public static class WithOrig
    {
        public static event Delegates.get_modalWindow_WithArgs get_modalWindow
        {
            add => HookEndpointManager.Add<Delegates.get_modalWindow_WithArgs>(
                ReflectionHelper.GetMethodInfo(typeof(ModalDialog), "get_modalWindow"), value);
            remove => HookEndpointManager.Remove<Delegates.get_modalWindow_WithArgs>(
                ReflectionHelper.GetMethodInfo(typeof(ModalDialog), "get_modalWindow"), value);
        }

        public static event On.ModalDialog.hook_HighlightDefault HighlightDefault
        {
            add => On.ModalDialog.HighlightDefault += value;
            remove => On.ModalDialog.HighlightDefault -= value;
        }
    }
}