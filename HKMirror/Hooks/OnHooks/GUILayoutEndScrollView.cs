using MonoMod.RuntimeDetour;
using MonoMod.RuntimeDetour.HookGen;

namespace HKMirror.Hooks.OnHooks;

/// <summary>
/// Contains different types of On Hooks for GUILayoutEndScrollView class.<br />
/// Contains hooks that aren't generated by monomod, and before and after orig hooks for easier hooking.
/// </summary>
public static class OnGUILayoutEndScrollView
{
    internal static class HookHandler
    {
        private static List<string> HookedList = new List<string>();

        internal static void HookOnGUI()
        {
            if (!HookedList.Contains("OnGUI"))
            {
                HookedList.Add("OnGUI");
                new Hook(
                    ReflectionHelper.GetMethodInfo(typeof(HutongGames.PlayMaker.Actions.GUILayoutEndScrollView),
                        "OnGUI", true), OnGUI);
            }
        }

        internal static event Delegates.OnGUI_BeforeArgs _beforeOnGUI;
        internal static event Delegates.OnGUI_AfterArgs _afterOnGUI;

        private static void OnGUI(Action<HutongGames.PlayMaker.Actions.GUILayoutEndScrollView> orig,
            HutongGames.PlayMaker.Actions.GUILayoutEndScrollView self)
        {
            Delegates.Params_OnGUI @params = new()
            {
                self = self
            };
            if (_beforeOnGUI != null)
            {
                foreach (Delegates.OnGUI_BeforeArgs toInvoke in _beforeOnGUI.GetInvocationList())
                {
                    try
                    {
                        _beforeOnGUI?.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }
                }
            }

            self = @params.self;
            orig(self);
            if (_afterOnGUI != null)
            {
                foreach (Delegates.OnGUI_AfterArgs toInvoke in _afterOnGUI.GetInvocationList())
                {
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
        }
    }

    /// <summary>
    /// Contains necessary information to create Hooks. Does not contain any hooks
    /// </summary>
    public static class Delegates
    {
        public sealed class Params_OnGUI
        {
            public HutongGames.PlayMaker.Actions.GUILayoutEndScrollView self;
        }

        public delegate void OnGUI_BeforeArgs(Params_OnGUI args);

        public delegate void OnGUI_AfterArgs(Params_OnGUI args);

        public delegate void OnGUI_WithArgs(Action<HutongGames.PlayMaker.Actions.GUILayoutEndScrollView> orig,
            HutongGames.PlayMaker.Actions.GUILayoutEndScrollView self);
    }

    /// <summary>
    /// Contains Hooks to that run code before orig(self) is called
    /// </summary>
    public static class BeforeOrig
    {
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
    /// Contains Hooks to that run code after orig(self) is called
    /// </summary>
    public static class AfterOrig
    {
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
    /// Contains all On Hooks, even those that aren't in the On namespace such as API generated functions and property getters/setters
    /// </summary>
    public static class WithOrig
    {
        public static event Delegates.OnGUI_WithArgs OnGUI
        {
            add => HookEndpointManager.Add<Delegates.OnGUI_WithArgs>(
                ReflectionHelper.GetMethodInfo(typeof(HutongGames.PlayMaker.Actions.GUILayoutEndScrollView), "OnGUI",
                    true), value);
            remove => HookEndpointManager.Remove<Delegates.OnGUI_WithArgs>(
                ReflectionHelper.GetMethodInfo(typeof(HutongGames.PlayMaker.Actions.GUILayoutEndScrollView), "OnGUI",
                    true), value);
        }
    }
}