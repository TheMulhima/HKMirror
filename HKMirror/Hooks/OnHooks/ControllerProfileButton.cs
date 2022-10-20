using MonoMod.RuntimeDetour;
using MonoMod.RuntimeDetour.HookGen;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace HKMirror.Hooks.OnHooks;

/// <summary>
///     Contains different types of On Hooks for ControllerProfileButton class.<br />
///     Contains hooks that aren't generated by monomod, and before and after orig hooks for easier hooking.
/// </summary>
public static class OnControllerProfileButton
{
    internal static class HookHandler
    {
        private static readonly List<string> HookedList = new();

        internal static void HookOnSelect()
        {
            if (!HookedList.Contains("OnSelect"))
            {
                HookedList.Add("OnSelect");
                new Hook(ReflectionHelper.GetMethodInfo(typeof(ControllerProfileButton), "OnSelect"), OnSelect);
            }
        }

        internal static event Delegates.OnSelect_BeforeArgs _beforeOnSelect;
        internal static event Delegates.OnSelect_NormalArgs _afterOnSelect;

        private static void OnSelect(Action<ControllerProfileButton, BaseEventData> orig, ControllerProfileButton self,
            BaseEventData eventData)
        {
            Delegates.Params_OnSelect @params = new()
            {
                self = self, eventData = eventData
            };
            _beforeOnSelect?.Invoke(@params);
            self = @params.self;
            eventData = @params.eventData;
            orig(self, eventData);
            if (_afterOnSelect != null) _afterOnSelect.Invoke(@params);
        }

        internal static void HookOnDeselect()
        {
            if (!HookedList.Contains("OnDeselect"))
            {
                HookedList.Add("OnDeselect");
                new Hook(ReflectionHelper.GetMethodInfo(typeof(ControllerProfileButton), "OnDeselect"), OnDeselect);
            }
        }

        internal static event Delegates.OnDeselect_BeforeArgs _beforeOnDeselect;
        internal static event Delegates.OnDeselect_NormalArgs _afterOnDeselect;

        private static void OnDeselect(Action<ControllerProfileButton, BaseEventData> orig,
            ControllerProfileButton self, BaseEventData eventData)
        {
            Delegates.Params_OnDeselect @params = new()
            {
                self = self, eventData = eventData
            };
            _beforeOnDeselect?.Invoke(@params);
            self = @params.self;
            eventData = @params.eventData;
            orig(self, eventData);
            if (_afterOnDeselect != null) _afterOnDeselect.Invoke(@params);
        }

        internal static void HookOnSubmit()
        {
            if (!HookedList.Contains("OnSubmit"))
            {
                HookedList.Add("OnSubmit");
                new Hook(ReflectionHelper.GetMethodInfo(typeof(ControllerProfileButton), "OnSubmit"), OnSubmit);
            }
        }

        internal static event Delegates.OnSubmit_BeforeArgs _beforeOnSubmit;
        internal static event Delegates.OnSubmit_NormalArgs _afterOnSubmit;

        private static void OnSubmit(Action<ControllerProfileButton, BaseEventData> orig, ControllerProfileButton self,
            BaseEventData eventData)
        {
            Delegates.Params_OnSubmit @params = new()
            {
                self = self, eventData = eventData
            };
            _beforeOnSubmit?.Invoke(@params);
            self = @params.self;
            eventData = @params.eventData;
            orig(self, eventData);
            if (_afterOnSubmit != null) _afterOnSubmit.Invoke(@params);
        }

        internal static void HookOnPointerClick()
        {
            if (!HookedList.Contains("OnPointerClick"))
            {
                HookedList.Add("OnPointerClick");
                new Hook(ReflectionHelper.GetMethodInfo(typeof(ControllerProfileButton), "OnPointerClick"),
                    OnPointerClick);
            }
        }

        internal static event Delegates.OnPointerClick_BeforeArgs _beforeOnPointerClick;
        internal static event Delegates.OnPointerClick_NormalArgs _afterOnPointerClick;

        private static void OnPointerClick(Action<ControllerProfileButton, PointerEventData> orig,
            ControllerProfileButton self, PointerEventData eventData)
        {
            Delegates.Params_OnPointerClick @params = new()
            {
                self = self, eventData = eventData
            };
            _beforeOnPointerClick?.Invoke(@params);
            self = @params.self;
            eventData = @params.eventData;
            orig(self, eventData);
            if (_afterOnPointerClick != null) _afterOnPointerClick.Invoke(@params);
        }

        internal static void HookValidateDeselect()
        {
            if (!HookedList.Contains("ValidateDeselect"))
            {
                HookedList.Add("ValidateDeselect");
                new Hook(ReflectionHelper.GetMethodInfo(typeof(ControllerProfileButton), "ValidateDeselect"),
                    ValidateDeselect);
            }
        }

        internal static event Delegates.ValidateDeselect_BeforeArgs _beforeValidateDeselect;

        private static IEnumerator ValidateDeselect(Func<ControllerProfileButton, IEnumerator> orig,
            ControllerProfileButton self)
        {
            Delegates.Params_ValidateDeselect @params = new()
            {
                self = self
            };
            _beforeValidateDeselect?.Invoke(@params);
            self = @params.self;
            return orig(self);
        }
    }

    /// <summary>
    ///     Contains necessary information to create Hooks. Does not contain any hooks
    /// </summary>
    public static class Delegates
    {
        public delegate void OnDeselect_BeforeArgs(Params_OnDeselect args);

        public delegate void OnDeselect_NormalArgs(Params_OnDeselect args);

        public delegate void OnPointerClick_BeforeArgs(Params_OnPointerClick args);

        public delegate void OnPointerClick_NormalArgs(Params_OnPointerClick args);

        public delegate void OnSelect_BeforeArgs(Params_OnSelect args);

        public delegate void OnSelect_NormalArgs(Params_OnSelect args);

        public delegate void OnSubmit_BeforeArgs(Params_OnSubmit args);

        public delegate void OnSubmit_NormalArgs(Params_OnSubmit args);

        public delegate void ValidateDeselect_BeforeArgs(Params_ValidateDeselect args);

        public delegate IEnumerator ValidateDeselect_NormalArgs(Params_ValidateDeselect args);

        public sealed class Params_OnSelect
        {
            public BaseEventData eventData;
            public ControllerProfileButton self;
        }

        public sealed class Params_OnDeselect
        {
            public BaseEventData eventData;
            public ControllerProfileButton self;
        }

        public sealed class Params_OnSubmit
        {
            public BaseEventData eventData;
            public ControllerProfileButton self;
        }

        public sealed class Params_OnPointerClick
        {
            public PointerEventData eventData;
            public ControllerProfileButton self;
        }

        public sealed class Params_ValidateDeselect
        {
            public ControllerProfileButton self;
        }
    }

    /// <summary>
    ///     Contains Hooks to that run code before orig(self) is called
    /// </summary>
    public static class BeforeOrig
    {
        public static event Delegates.OnSelect_BeforeArgs OnSelect
        {
            add
            {
                HookHandler._beforeOnSelect += value;
                HookHandler.HookOnSelect();
            }
            remove => HookHandler._beforeOnSelect -= value;
        }

        public static event Delegates.OnDeselect_BeforeArgs OnDeselect
        {
            add
            {
                HookHandler._beforeOnDeselect += value;
                HookHandler.HookOnDeselect();
            }
            remove => HookHandler._beforeOnDeselect -= value;
        }

        public static event Delegates.OnSubmit_BeforeArgs OnSubmit
        {
            add
            {
                HookHandler._beforeOnSubmit += value;
                HookHandler.HookOnSubmit();
            }
            remove => HookHandler._beforeOnSubmit -= value;
        }

        public static event Delegates.OnPointerClick_BeforeArgs OnPointerClick
        {
            add
            {
                HookHandler._beforeOnPointerClick += value;
                HookHandler.HookOnPointerClick();
            }
            remove => HookHandler._beforeOnPointerClick -= value;
        }

        public static event Delegates.ValidateDeselect_BeforeArgs ValidateDeselect
        {
            add
            {
                HookHandler._beforeValidateDeselect += value;
                HookHandler.HookValidateDeselect();
            }
            remove => HookHandler._beforeValidateDeselect -= value;
        }
    }

    /// <summary>
    ///     Contains Hooks to that run code after orig(self) is called
    /// </summary>
    public static class AfterOrig
    {
        public static event Delegates.OnSelect_NormalArgs OnSelect
        {
            add
            {
                HookHandler._afterOnSelect += value;
                HookHandler.HookOnSelect();
            }
            remove => HookHandler._afterOnSelect -= value;
        }

        public static event Delegates.OnDeselect_NormalArgs OnDeselect
        {
            add
            {
                HookHandler._afterOnDeselect += value;
                HookHandler.HookOnDeselect();
            }
            remove => HookHandler._afterOnDeselect -= value;
        }

        public static event Delegates.OnSubmit_NormalArgs OnSubmit
        {
            add
            {
                HookHandler._afterOnSubmit += value;
                HookHandler.HookOnSubmit();
            }
            remove => HookHandler._afterOnSubmit -= value;
        }

        public static event Delegates.OnPointerClick_NormalArgs OnPointerClick
        {
            add
            {
                HookHandler._afterOnPointerClick += value;
                HookHandler.HookOnPointerClick();
            }
            remove => HookHandler._afterOnPointerClick -= value;
        }
    }

    /// <summary>
    ///     Contains all On Hooks, even those that aren't in the On namespace such as API generated functions and property
    ///     getters/setters
    /// </summary>
    public static class WithOrig
    {
        public static event Delegates.OnSelect_NormalArgs OnSelect
        {
            add => HookEndpointManager.Add<Delegates.OnSelect_NormalArgs>(
                ReflectionHelper.GetMethodInfo(typeof(ControllerProfileButton), "OnSelect"), value);
            remove => HookEndpointManager.Remove<Delegates.OnSelect_NormalArgs>(
                ReflectionHelper.GetMethodInfo(typeof(ControllerProfileButton), "OnSelect"), value);
        }

        public static event Delegates.OnDeselect_NormalArgs OnDeselect
        {
            add => HookEndpointManager.Add<Delegates.OnDeselect_NormalArgs>(
                ReflectionHelper.GetMethodInfo(typeof(ControllerProfileButton), "OnDeselect"), value);
            remove => HookEndpointManager.Remove<Delegates.OnDeselect_NormalArgs>(
                ReflectionHelper.GetMethodInfo(typeof(ControllerProfileButton), "OnDeselect"), value);
        }

        public static event Delegates.OnSubmit_NormalArgs OnSubmit
        {
            add => HookEndpointManager.Add<Delegates.OnSubmit_NormalArgs>(
                ReflectionHelper.GetMethodInfo(typeof(ControllerProfileButton), "OnSubmit"), value);
            remove => HookEndpointManager.Remove<Delegates.OnSubmit_NormalArgs>(
                ReflectionHelper.GetMethodInfo(typeof(ControllerProfileButton), "OnSubmit"), value);
        }

        public static event Delegates.OnPointerClick_NormalArgs OnPointerClick
        {
            add => HookEndpointManager.Add<Delegates.OnPointerClick_NormalArgs>(
                ReflectionHelper.GetMethodInfo(typeof(ControllerProfileButton), "OnPointerClick"), value);
            remove => HookEndpointManager.Remove<Delegates.OnPointerClick_NormalArgs>(
                ReflectionHelper.GetMethodInfo(typeof(ControllerProfileButton), "OnPointerClick"), value);
        }

        public static event Delegates.ValidateDeselect_NormalArgs ValidateDeselect
        {
            add => HookEndpointManager.Add<Delegates.ValidateDeselect_NormalArgs>(
                ReflectionHelper.GetMethodInfo(typeof(ControllerProfileButton), "ValidateDeselect"), value);
            remove => HookEndpointManager.Remove<Delegates.ValidateDeselect_NormalArgs>(
                ReflectionHelper.GetMethodInfo(typeof(ControllerProfileButton), "ValidateDeselect"), value);
        }
    }
}