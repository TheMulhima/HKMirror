using MonoMod.RuntimeDetour;
using MonoMod.RuntimeDetour.HookGen;

namespace HKMirror.Hooks.OnHooks;

/// <summary>
///     Contains different types of On Hooks for GUILayoutEndCentered class.<br />
///     Contains hooks that aren't generated by monomod, and before and after orig hooks for easier hooking.
/// </summary>
public static class OnGUILayoutEndCentered
{
    internal static class HookHandler
    {
        private static readonly List<string> HookedList = new();

        internal static void HookReset()
        {
            if (!HookedList.Contains("Reset"))
            {
                HookedList.Add("Reset");
                new Hook(ReflectionHelper.GetMethodInfo(typeof(GUILayoutEndCentered), "Reset"), Reset);
            }
        }

        internal static event Delegates.Reset_BeforeArgs _beforeReset;
        internal static event Delegates.Reset_AfterArgs _afterReset;

        private static void Reset(Action<GUILayoutEndCentered> orig, GUILayoutEndCentered self)
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

        internal static void HookOnGUI()
        {
            if (!HookedList.Contains("OnGUI"))
            {
                HookedList.Add("OnGUI");
                new Hook(ReflectionHelper.GetMethodInfo(typeof(GUILayoutEndCentered), "OnGUI"), OnGUI);
            }
        }

        internal static event Delegates.OnGUI_BeforeArgs _beforeOnGUI;
        internal static event Delegates.OnGUI_AfterArgs _afterOnGUI;

        private static void OnGUI(Action<GUILayoutEndCentered> orig, GUILayoutEndCentered self)
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
    }

    /// <summary>
    ///     Contains necessary information to create Hooks. Does not contain any hooks
    /// </summary>
    public static class Delegates
    {
        public delegate void OnGUI_AfterArgs(Params_OnGUI args);

        public delegate void OnGUI_BeforeArgs(Params_OnGUI args);

        public delegate void OnGUI_WithArgs(Action<GUILayoutEndCentered> orig, GUILayoutEndCentered self);

        public delegate void Reset_AfterArgs(Params_Reset args);

        public delegate void Reset_BeforeArgs(Params_Reset args);

        public delegate void Reset_WithArgs(Action<GUILayoutEndCentered> orig, GUILayoutEndCentered self);

        public sealed class Params_Reset
        {
            public GUILayoutEndCentered self;
        }

        public sealed class Params_OnGUI
        {
            public GUILayoutEndCentered self;
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

        public static event Delegates.OnGUI_BeforeArgs OnGUI
        {
            add
            {
                HookHandler._beforeOnGUI += value;
                HookHandler.HookOnGUI();
            }
            remove => HookHandler._beforeOnGUI -= value;
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

        public static event Delegates.OnGUI_AfterArgs OnGUI
        {
            add
            {
                HookHandler._afterOnGUI += value;
                HookHandler.HookOnGUI();
            }
            remove => HookHandler._afterOnGUI -= value;
        }
    }

    /// <summary>
    ///     Contains all On Hooks, even those that aren't in the On namespace such as API generated functions and property
    ///     getters/setters
    /// </summary>
    public static class WithOrig
    {
        public static event Delegates.Reset_WithArgs Reset
        {
            add => HookEndpointManager.Add<Delegates.Reset_WithArgs>(
                ReflectionHelper.GetMethodInfo(typeof(GUILayoutEndCentered), "Reset"), value);
            remove => HookEndpointManager.Remove<Delegates.Reset_WithArgs>(
                ReflectionHelper.GetMethodInfo(typeof(GUILayoutEndCentered), "Reset"), value);
        }

        public static event Delegates.OnGUI_WithArgs OnGUI
        {
            add => HookEndpointManager.Add<Delegates.OnGUI_WithArgs>(
                ReflectionHelper.GetMethodInfo(typeof(GUILayoutEndCentered), "OnGUI"), value);
            remove => HookEndpointManager.Remove<Delegates.OnGUI_WithArgs>(
                ReflectionHelper.GetMethodInfo(typeof(GUILayoutEndCentered), "OnGUI"), value);
        }
    }
}