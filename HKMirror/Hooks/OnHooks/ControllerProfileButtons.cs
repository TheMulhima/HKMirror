using MonoMod.RuntimeDetour;
using MonoMod.RuntimeDetour.HookGen;
using UnityEngine.UI;

namespace HKMirror.Hooks.OnHooks;

/// <summary>
///     Contains different types of On Hooks for ControllerProfileButtons class.<br />
///     Contains hooks that aren't generated by monomod, and before and after orig hooks for easier hooking.
/// </summary>
public static class OnControllerProfileButtons
{
    internal static class HookHandler
    {
        private static readonly List<string> HookedList = new();

        internal static void HookSelectItem()
        {
            if (!HookedList.Contains("SelectItem"))
            {
                HookedList.Add("SelectItem");
                new Hook(ReflectionHelper.GetMethodInfo(typeof(ControllerProfileButtons), "SelectItem"), SelectItem);
            }
        }

        internal static event Delegates.SelectItem_BeforeArgs _beforeSelectItem;
        internal static event Delegates.SelectItem_NormalArgs _afterSelectItem;

        private static void SelectItem(Action<ControllerProfileButtons, int> orig, ControllerProfileButtons self,
            int num)
        {
            Delegates.Params_SelectItem @params = new()
            {
                self = self, num = num
            };
            _beforeSelectItem?.Invoke(@params);
            self = @params.self;
            num = @params.num;
            orig(self, num);
            if (_afterSelectItem != null) _afterSelectItem.Invoke(@params);
        }
    }

    /// <summary>
    ///     Contains necessary information to create Hooks. Does not contain any hooks
    /// </summary>
    public static class Delegates
    {
        public delegate void SelectItem_BeforeArgs(Params_SelectItem args);

        public delegate void SelectItem_NormalArgs(Params_SelectItem args);

        public sealed class Params_SelectItem
        {
            public int num;
            public ControllerProfileButtons self;
        }
    }

    /// <summary>
    ///     Contains Hooks to that run code before orig(self) is called
    /// </summary>
    public static class BeforeOrig
    {
        public static event Delegates.SelectItem_BeforeArgs SelectItem
        {
            add
            {
                HookHandler._beforeSelectItem += value;
                HookHandler.HookSelectItem();
            }
            remove => HookHandler._beforeSelectItem -= value;
        }
    }

    /// <summary>
    ///     Contains Hooks to that run code after orig(self) is called
    /// </summary>
    public static class AfterOrig
    {
        public static event Delegates.SelectItem_NormalArgs SelectItem
        {
            add
            {
                HookHandler._afterSelectItem += value;
                HookHandler.HookSelectItem();
            }
            remove => HookHandler._afterSelectItem -= value;
        }
    }

    /// <summary>
    ///     Contains all On Hooks, even those that aren't in the On namespace such as API generated functions and property
    ///     getters/setters
    /// </summary>
    public static class WithOrig
    {
        public static event Delegates.SelectItem_NormalArgs SelectItem
        {
            add => HookEndpointManager.Add<Delegates.SelectItem_NormalArgs>(
                ReflectionHelper.GetMethodInfo(typeof(ControllerProfileButtons), "SelectItem"), value);
            remove => HookEndpointManager.Remove<Delegates.SelectItem_NormalArgs>(
                ReflectionHelper.GetMethodInfo(typeof(ControllerProfileButtons), "SelectItem"), value);
        }
    }
}