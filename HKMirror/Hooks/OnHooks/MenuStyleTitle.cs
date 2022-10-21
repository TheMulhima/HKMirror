using MonoMod.RuntimeDetour;
using MonoMod.RuntimeDetour.HookGen;

namespace HKMirror.Hooks.OnHooks;

/// <summary>
/// Contains different types of On Hooks for MenuStyleTitle class.<br />
/// Contains hooks that aren't generated by monomod, and before and after orig hooks for easier hooking.
/// </summary>
public static class OnMenuStyleTitle
{
    internal static class HookHandler
    {
        private static List<string> HookedList = new List<string>();

        internal static void HookSetTitle()
        {
            if (!HookedList.Contains("SetTitle"))
            {
                HookedList.Add("SetTitle");
                On.MenuStyleTitle.SetTitle += SetTitle;
            }
        }

        internal static event Delegates.SetTitle_BeforeArgs _beforeSetTitle;
        internal static event Delegates.SetTitle_AfterArgs _afterSetTitle;

        private static void SetTitle(On.MenuStyleTitle.orig_SetTitle orig, MenuStyleTitle self, int index)
        {
            Delegates.Params_SetTitle @params = new()
            {
                self = self, index = index
            };
            if (_beforeSetTitle != null)
            {
                foreach (Delegates.SetTitle_BeforeArgs toInvoke in _beforeSetTitle.GetInvocationList())
                {
                    try
                    {
                        _beforeSetTitle?.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }
                }
            }

            self = @params.self;
            index = @params.index;
            orig(self, index);
            if (_afterSetTitle != null)
            {
                foreach (Delegates.SetTitle_AfterArgs toInvoke in _afterSetTitle.GetInvocationList())
                {
                    try
                    {
                        _afterSetTitle.Invoke(@params);
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
        public sealed class Params_SetTitle
        {
            public MenuStyleTitle self;
            public int index;
        }

        public delegate void SetTitle_BeforeArgs(Params_SetTitle args);

        public delegate void SetTitle_AfterArgs(Params_SetTitle args);

        public delegate void SetTitle_WithArgs(Action<MenuStyleTitle, int> orig, MenuStyleTitle self, int index);
    }

    /// <summary>
    /// Contains Hooks to that run code before orig(self) is called
    /// </summary>
    public static class BeforeOrig
    {
        public static event Delegates.SetTitle_BeforeArgs SetTitle
        {
            add
            {
                HookHandler._beforeSetTitle += value;
                HookHandler.HookSetTitle();
            }
            remove => HookHandler._beforeSetTitle -= value;
        }
    }

    /// <summary>
    /// Contains Hooks to that run code after orig(self) is called
    /// </summary>
    public static class AfterOrig
    {
        public static event Delegates.SetTitle_AfterArgs SetTitle
        {
            add
            {
                HookHandler._afterSetTitle += value;
                HookHandler.HookSetTitle();
            }
            remove => HookHandler._afterSetTitle -= value;
        }
    }

    /// <summary>
    /// Contains all On Hooks, even those that aren't in the On namespace such as API generated functions and property getters/setters
    /// </summary>
    public static class WithOrig
    {
        public static event On.MenuStyleTitle.hook_SetTitle SetTitle
        {
            add => On.MenuStyleTitle.SetTitle += value;
            remove => On.MenuStyleTitle.SetTitle -= value;
        }
    }
}