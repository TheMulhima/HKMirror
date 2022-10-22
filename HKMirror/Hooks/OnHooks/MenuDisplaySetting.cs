using MonoMod.RuntimeDetour;
using MonoMod.RuntimeDetour.HookGen;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace HKMirror.Hooks.OnHooks;

/// <summary>
///     Contains different types of On Hooks for MenuDisplaySetting class.<br />
///     Contains hooks that aren't generated by monomod, and before and after orig hooks for easier hooking.
/// </summary>
public static class OnMenuDisplaySetting
{
    internal static class HookHandler
    {
        private static readonly List<string> HookedList = new();

        internal static void HookOnEnable()
        {
            if (!HookedList.Contains("OnEnable"))
            {
                HookedList.Add("OnEnable");
                new Hook(ReflectionHelper.GetMethodInfo(typeof(MenuDisplaySetting), "OnEnable"), OnEnable);
            }
        }

        internal static event Delegates.OnEnable_BeforeArgs _beforeOnEnable;
        internal static event Delegates.OnEnable_AfterArgs _afterOnEnable;

        private static void OnEnable(Action<MenuDisplaySetting> orig, MenuDisplaySetting self)
        {
            Delegates.Params_OnEnable @params = new()
            {
                self = self
            };
            if (_beforeOnEnable != null)
                foreach (Delegates.OnEnable_BeforeArgs toInvoke in _beforeOnEnable.GetInvocationList())
                    try
                    {
                        _beforeOnEnable?.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }

            self = @params.self;
            orig(self);
            if (_afterOnEnable != null)
                foreach (Delegates.OnEnable_AfterArgs toInvoke in _afterOnEnable.GetInvocationList())
                    try
                    {
                        _afterOnEnable.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }
        }

        internal static void HookOnMove()
        {
            if (!HookedList.Contains("OnMove"))
            {
                HookedList.Add("OnMove");
                new Hook(ReflectionHelper.GetMethodInfo(typeof(MenuDisplaySetting), "OnMove"), OnMove);
            }
        }

        internal static event Delegates.OnMove_BeforeArgs _beforeOnMove;
        internal static event Delegates.OnMove_AfterArgs _afterOnMove;

        private static void OnMove(Action<MenuDisplaySetting, AxisEventData> orig, MenuDisplaySetting self,
            AxisEventData move)
        {
            Delegates.Params_OnMove @params = new()
            {
                self = self, move = move
            };
            if (_beforeOnMove != null)
                foreach (Delegates.OnMove_BeforeArgs toInvoke in _beforeOnMove.GetInvocationList())
                    try
                    {
                        _beforeOnMove?.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }

            self = @params.self;
            move = @params.move;
            orig(self, move);
            if (_afterOnMove != null)
                foreach (Delegates.OnMove_AfterArgs toInvoke in _afterOnMove.GetInvocationList())
                    try
                    {
                        _afterOnMove.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }
        }

        internal static void HookOnPointerClick()
        {
            if (!HookedList.Contains("OnPointerClick"))
            {
                HookedList.Add("OnPointerClick");
                new Hook(ReflectionHelper.GetMethodInfo(typeof(MenuDisplaySetting), "OnPointerClick"), OnPointerClick);
            }
        }

        internal static event Delegates.OnPointerClick_BeforeArgs _beforeOnPointerClick;
        internal static event Delegates.OnPointerClick_AfterArgs _afterOnPointerClick;

        private static void OnPointerClick(Action<MenuDisplaySetting, PointerEventData> orig, MenuDisplaySetting self,
            PointerEventData eventData)
        {
            Delegates.Params_OnPointerClick @params = new()
            {
                self = self, eventData = eventData
            };
            if (_beforeOnPointerClick != null)
                foreach (Delegates.OnPointerClick_BeforeArgs toInvoke in _beforeOnPointerClick.GetInvocationList())
                    try
                    {
                        _beforeOnPointerClick?.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }

            self = @params.self;
            eventData = @params.eventData;
            orig(self, eventData);
            if (_afterOnPointerClick != null)
                foreach (Delegates.OnPointerClick_AfterArgs toInvoke in _afterOnPointerClick.GetInvocationList())
                    try
                    {
                        _afterOnPointerClick.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }
        }

        internal static void HookRefreshControls()
        {
            if (!HookedList.Contains("RefreshControls"))
            {
                HookedList.Add("RefreshControls");
                new Hook(ReflectionHelper.GetMethodInfo(typeof(MenuDisplaySetting), "RefreshControls"),
                    RefreshControls);
            }
        }

        internal static event Delegates.RefreshControls_BeforeArgs _beforeRefreshControls;
        internal static event Delegates.RefreshControls_AfterArgs _afterRefreshControls;

        private static void RefreshControls(Action<MenuDisplaySetting> orig, MenuDisplaySetting self)
        {
            Delegates.Params_RefreshControls @params = new()
            {
                self = self
            };
            if (_beforeRefreshControls != null)
                foreach (Delegates.RefreshControls_BeforeArgs toInvoke in _beforeRefreshControls.GetInvocationList())
                    try
                    {
                        _beforeRefreshControls?.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }

            self = @params.self;
            orig(self);
            if (_afterRefreshControls != null)
                foreach (Delegates.RefreshControls_AfterArgs toInvoke in _afterRefreshControls.GetInvocationList())
                    try
                    {
                        _afterRefreshControls.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }
        }

        internal static void HookDisableMonitorSelectSetting()
        {
            if (!HookedList.Contains("DisableMonitorSelectSetting"))
            {
                HookedList.Add("DisableMonitorSelectSetting");
                new Hook(ReflectionHelper.GetMethodInfo(typeof(MenuDisplaySetting), "DisableMonitorSelectSetting"),
                    DisableMonitorSelectSetting);
            }
        }

        internal static event Delegates.DisableMonitorSelectSetting_BeforeArgs _beforeDisableMonitorSelectSetting;
        internal static event Delegates.DisableMonitorSelectSetting_AfterArgs _afterDisableMonitorSelectSetting;

        private static void DisableMonitorSelectSetting(Action<MenuDisplaySetting> orig, MenuDisplaySetting self)
        {
            Delegates.Params_DisableMonitorSelectSetting @params = new()
            {
                self = self
            };
            if (_beforeDisableMonitorSelectSetting != null)
                foreach (Delegates.DisableMonitorSelectSetting_BeforeArgs toInvoke in _beforeDisableMonitorSelectSetting
                             .GetInvocationList())
                    try
                    {
                        _beforeDisableMonitorSelectSetting?.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }

            self = @params.self;
            orig(self);
            if (_afterDisableMonitorSelectSetting != null)
                foreach (Delegates.DisableMonitorSelectSetting_AfterArgs toInvoke in _afterDisableMonitorSelectSetting
                             .GetInvocationList())
                    try
                    {
                        _afterDisableMonitorSelectSetting.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }
        }

        internal static void HookUpdateMonitorSetting()
        {
            if (!HookedList.Contains("UpdateMonitorSetting"))
            {
                HookedList.Add("UpdateMonitorSetting");
                new Hook(ReflectionHelper.GetMethodInfo(typeof(MenuDisplaySetting), "UpdateMonitorSetting"),
                    UpdateMonitorSetting);
            }
        }

        internal static event Delegates.UpdateMonitorSetting_BeforeArgs _beforeUpdateMonitorSetting;
        internal static event Delegates.UpdateMonitorSetting_AfterArgs _afterUpdateMonitorSetting;

        private static void UpdateMonitorSetting(Action<MenuDisplaySetting> orig, MenuDisplaySetting self)
        {
            Delegates.Params_UpdateMonitorSetting @params = new()
            {
                self = self
            };
            if (_beforeUpdateMonitorSetting != null)
                foreach (Delegates.UpdateMonitorSetting_BeforeArgs toInvoke in _beforeUpdateMonitorSetting
                             .GetInvocationList())
                    try
                    {
                        _beforeUpdateMonitorSetting?.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }

            self = @params.self;
            orig(self);
            if (_afterUpdateMonitorSetting != null)
                foreach (Delegates.UpdateMonitorSetting_AfterArgs toInvoke in _afterUpdateMonitorSetting
                             .GetInvocationList())
                    try
                    {
                        _afterUpdateMonitorSetting.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }
        }

        internal static void HookRefreshCurrentIndex()
        {
            if (!HookedList.Contains("RefreshCurrentIndex"))
            {
                HookedList.Add("RefreshCurrentIndex");
                new Hook(ReflectionHelper.GetMethodInfo(typeof(MenuDisplaySetting), "RefreshCurrentIndex"),
                    RefreshCurrentIndex);
            }
        }

        internal static event Delegates.RefreshCurrentIndex_BeforeArgs _beforeRefreshCurrentIndex;
        internal static event Delegates.RefreshCurrentIndex_AfterArgs _afterRefreshCurrentIndex;

        private static void RefreshCurrentIndex(Action<MenuDisplaySetting> orig, MenuDisplaySetting self)
        {
            Delegates.Params_RefreshCurrentIndex @params = new()
            {
                self = self
            };
            if (_beforeRefreshCurrentIndex != null)
                foreach (Delegates.RefreshCurrentIndex_BeforeArgs toInvoke in _beforeRefreshCurrentIndex
                             .GetInvocationList())
                    try
                    {
                        _beforeRefreshCurrentIndex?.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }

            self = @params.self;
            orig(self);
            if (_afterRefreshCurrentIndex != null)
                foreach (Delegates.RefreshCurrentIndex_AfterArgs toInvoke in
                         _afterRefreshCurrentIndex.GetInvocationList())
                    try
                    {
                        _afterRefreshCurrentIndex.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }
        }

        internal static void HookPushUpdateOptionList()
        {
            if (!HookedList.Contains("PushUpdateOptionList"))
            {
                HookedList.Add("PushUpdateOptionList");
                new Hook(ReflectionHelper.GetMethodInfo(typeof(MenuDisplaySetting), "PushUpdateOptionList"),
                    PushUpdateOptionList);
            }
        }

        internal static event Delegates.PushUpdateOptionList_BeforeArgs _beforePushUpdateOptionList;
        internal static event Delegates.PushUpdateOptionList_AfterArgs _afterPushUpdateOptionList;

        private static void PushUpdateOptionList(Action<MenuDisplaySetting> orig, MenuDisplaySetting self)
        {
            Delegates.Params_PushUpdateOptionList @params = new()
            {
                self = self
            };
            if (_beforePushUpdateOptionList != null)
                foreach (Delegates.PushUpdateOptionList_BeforeArgs toInvoke in _beforePushUpdateOptionList
                             .GetInvocationList())
                    try
                    {
                        _beforePushUpdateOptionList?.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }

            self = @params.self;
            orig(self);
            if (_afterPushUpdateOptionList != null)
                foreach (Delegates.PushUpdateOptionList_AfterArgs toInvoke in _afterPushUpdateOptionList
                             .GetInvocationList())
                    try
                    {
                        _afterPushUpdateOptionList.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }
        }

        internal static void HookTargetDisplayHack()
        {
            if (!HookedList.Contains("TargetDisplayHack"))
            {
                HookedList.Add("TargetDisplayHack");
                new Hook(ReflectionHelper.GetMethodInfo(typeof(MenuDisplaySetting), "TargetDisplayHack"),
                    TargetDisplayHack);
            }
        }

        internal static event Delegates.TargetDisplayHack_BeforeArgs _beforeTargetDisplayHack;

        private static IEnumerator TargetDisplayHack(Func<MenuDisplaySetting, int, IEnumerator> orig,
            MenuDisplaySetting self, int targetDisplay)
        {
            Delegates.Params_TargetDisplayHack @params = new()
            {
                self = self, targetDisplay = targetDisplay
            };
            if (_beforeTargetDisplayHack != null)
                foreach (Delegates.TargetDisplayHack_BeforeArgs toInvoke in
                         _beforeTargetDisplayHack.GetInvocationList())
                    try
                    {
                        _beforeTargetDisplayHack?.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }

            self = @params.self;
            targetDisplay = @params.targetDisplay;
            return orig(self, targetDisplay);
        }
    }

    /// <summary>
    ///     Contains necessary information to create Hooks. Does not contain any hooks
    /// </summary>
    public static class Delegates
    {
        public delegate void DisableMonitorSelectSetting_AfterArgs(Params_DisableMonitorSelectSetting args);

        public delegate void DisableMonitorSelectSetting_BeforeArgs(Params_DisableMonitorSelectSetting args);

        public delegate void DisableMonitorSelectSetting_WithArgs(Action<MenuDisplaySetting> orig,
            MenuDisplaySetting self);

        public delegate void OnEnable_AfterArgs(Params_OnEnable args);

        public delegate void OnEnable_BeforeArgs(Params_OnEnable args);

        public delegate void OnEnable_WithArgs(Action<MenuDisplaySetting> orig, MenuDisplaySetting self);

        public delegate void OnMove_AfterArgs(Params_OnMove args);

        public delegate void OnMove_BeforeArgs(Params_OnMove args);

        public delegate void OnMove_WithArgs(Action<MenuDisplaySetting, AxisEventData> orig, MenuDisplaySetting self,
            AxisEventData move);

        public delegate void OnPointerClick_AfterArgs(Params_OnPointerClick args);

        public delegate void OnPointerClick_BeforeArgs(Params_OnPointerClick args);

        public delegate void OnPointerClick_WithArgs(Action<MenuDisplaySetting, PointerEventData> orig,
            MenuDisplaySetting self, PointerEventData eventData);

        public delegate void PushUpdateOptionList_AfterArgs(Params_PushUpdateOptionList args);

        public delegate void PushUpdateOptionList_BeforeArgs(Params_PushUpdateOptionList args);

        public delegate void PushUpdateOptionList_WithArgs(Action<MenuDisplaySetting> orig, MenuDisplaySetting self);

        public delegate void RefreshControls_AfterArgs(Params_RefreshControls args);

        public delegate void RefreshControls_BeforeArgs(Params_RefreshControls args);

        public delegate void RefreshControls_WithArgs(Action<MenuDisplaySetting> orig, MenuDisplaySetting self);

        public delegate void RefreshCurrentIndex_AfterArgs(Params_RefreshCurrentIndex args);

        public delegate void RefreshCurrentIndex_BeforeArgs(Params_RefreshCurrentIndex args);

        public delegate void RefreshCurrentIndex_WithArgs(Action<MenuDisplaySetting> orig, MenuDisplaySetting self);

        public delegate IEnumerator TargetDisplayHack_AfterArgs(Params_TargetDisplayHack args, IEnumerator ret);

        public delegate void TargetDisplayHack_BeforeArgs(Params_TargetDisplayHack args);

        public delegate IEnumerator TargetDisplayHack_WithArgs(Func<MenuDisplaySetting, int, IEnumerator> orig,
            MenuDisplaySetting self, int targetDisplay);

        public delegate void UpdateMonitorSetting_AfterArgs(Params_UpdateMonitorSetting args);

        public delegate void UpdateMonitorSetting_BeforeArgs(Params_UpdateMonitorSetting args);

        public delegate void UpdateMonitorSetting_WithArgs(Action<MenuDisplaySetting> orig, MenuDisplaySetting self);

        public sealed class Params_OnEnable
        {
            public MenuDisplaySetting self;
        }

        public sealed class Params_OnMove
        {
            public AxisEventData move;
            public MenuDisplaySetting self;
        }

        public sealed class Params_OnPointerClick
        {
            public PointerEventData eventData;
            public MenuDisplaySetting self;
        }

        public sealed class Params_RefreshControls
        {
            public MenuDisplaySetting self;
        }

        public sealed class Params_DisableMonitorSelectSetting
        {
            public MenuDisplaySetting self;
        }

        public sealed class Params_UpdateMonitorSetting
        {
            public MenuDisplaySetting self;
        }

        public sealed class Params_RefreshCurrentIndex
        {
            public MenuDisplaySetting self;
        }

        public sealed class Params_PushUpdateOptionList
        {
            public MenuDisplaySetting self;
        }

        public sealed class Params_TargetDisplayHack
        {
            public MenuDisplaySetting self;
            public int targetDisplay;
        }
    }

    /// <summary>
    ///     Contains Hooks to that run code before orig(self) is called
    /// </summary>
    public static class BeforeOrig
    {
        public static event Delegates.OnEnable_BeforeArgs OnEnable
        {
            add
            {
                HookHandler._beforeOnEnable += value;
                HookHandler.HookOnEnable();
            }
            remove => HookHandler._beforeOnEnable -= value;
        }

        public static event Delegates.OnMove_BeforeArgs OnMove
        {
            add
            {
                HookHandler._beforeOnMove += value;
                HookHandler.HookOnMove();
            }
            remove => HookHandler._beforeOnMove -= value;
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

        public static event Delegates.RefreshControls_BeforeArgs RefreshControls
        {
            add
            {
                HookHandler._beforeRefreshControls += value;
                HookHandler.HookRefreshControls();
            }
            remove => HookHandler._beforeRefreshControls -= value;
        }

        public static event Delegates.DisableMonitorSelectSetting_BeforeArgs DisableMonitorSelectSetting
        {
            add
            {
                HookHandler._beforeDisableMonitorSelectSetting += value;
                HookHandler.HookDisableMonitorSelectSetting();
            }
            remove => HookHandler._beforeDisableMonitorSelectSetting -= value;
        }

        public static event Delegates.UpdateMonitorSetting_BeforeArgs UpdateMonitorSetting
        {
            add
            {
                HookHandler._beforeUpdateMonitorSetting += value;
                HookHandler.HookUpdateMonitorSetting();
            }
            remove => HookHandler._beforeUpdateMonitorSetting -= value;
        }

        public static event Delegates.RefreshCurrentIndex_BeforeArgs RefreshCurrentIndex
        {
            add
            {
                HookHandler._beforeRefreshCurrentIndex += value;
                HookHandler.HookRefreshCurrentIndex();
            }
            remove => HookHandler._beforeRefreshCurrentIndex -= value;
        }

        public static event Delegates.PushUpdateOptionList_BeforeArgs PushUpdateOptionList
        {
            add
            {
                HookHandler._beforePushUpdateOptionList += value;
                HookHandler.HookPushUpdateOptionList();
            }
            remove => HookHandler._beforePushUpdateOptionList -= value;
        }

        public static event Delegates.TargetDisplayHack_BeforeArgs TargetDisplayHack
        {
            add
            {
                HookHandler._beforeTargetDisplayHack += value;
                HookHandler.HookTargetDisplayHack();
            }
            remove => HookHandler._beforeTargetDisplayHack -= value;
        }
    }

    /// <summary>
    ///     Contains Hooks to that run code after orig(self) is called
    /// </summary>
    public static class AfterOrig
    {
        public static event Delegates.OnEnable_AfterArgs OnEnable
        {
            add
            {
                HookHandler._afterOnEnable += value;
                HookHandler.HookOnEnable();
            }
            remove => HookHandler._afterOnEnable -= value;
        }

        public static event Delegates.OnMove_AfterArgs OnMove
        {
            add
            {
                HookHandler._afterOnMove += value;
                HookHandler.HookOnMove();
            }
            remove => HookHandler._afterOnMove -= value;
        }

        public static event Delegates.OnPointerClick_AfterArgs OnPointerClick
        {
            add
            {
                HookHandler._afterOnPointerClick += value;
                HookHandler.HookOnPointerClick();
            }
            remove => HookHandler._afterOnPointerClick -= value;
        }

        public static event Delegates.RefreshControls_AfterArgs RefreshControls
        {
            add
            {
                HookHandler._afterRefreshControls += value;
                HookHandler.HookRefreshControls();
            }
            remove => HookHandler._afterRefreshControls -= value;
        }

        public static event Delegates.DisableMonitorSelectSetting_AfterArgs DisableMonitorSelectSetting
        {
            add
            {
                HookHandler._afterDisableMonitorSelectSetting += value;
                HookHandler.HookDisableMonitorSelectSetting();
            }
            remove => HookHandler._afterDisableMonitorSelectSetting -= value;
        }

        public static event Delegates.UpdateMonitorSetting_AfterArgs UpdateMonitorSetting
        {
            add
            {
                HookHandler._afterUpdateMonitorSetting += value;
                HookHandler.HookUpdateMonitorSetting();
            }
            remove => HookHandler._afterUpdateMonitorSetting -= value;
        }

        public static event Delegates.RefreshCurrentIndex_AfterArgs RefreshCurrentIndex
        {
            add
            {
                HookHandler._afterRefreshCurrentIndex += value;
                HookHandler.HookRefreshCurrentIndex();
            }
            remove => HookHandler._afterRefreshCurrentIndex -= value;
        }

        public static event Delegates.PushUpdateOptionList_AfterArgs PushUpdateOptionList
        {
            add
            {
                HookHandler._afterPushUpdateOptionList += value;
                HookHandler.HookPushUpdateOptionList();
            }
            remove => HookHandler._afterPushUpdateOptionList -= value;
        }
    }

    /// <summary>
    ///     Contains all On Hooks, even those that aren't in the On namespace such as API generated functions and property
    ///     getters/setters
    /// </summary>
    public static class WithOrig
    {
        public static event Delegates.OnEnable_WithArgs OnEnable
        {
            add => HookEndpointManager.Add<Delegates.OnEnable_WithArgs>(
                ReflectionHelper.GetMethodInfo(typeof(MenuDisplaySetting), "OnEnable"), value);
            remove => HookEndpointManager.Remove<Delegates.OnEnable_WithArgs>(
                ReflectionHelper.GetMethodInfo(typeof(MenuDisplaySetting), "OnEnable"), value);
        }

        public static event Delegates.OnMove_WithArgs OnMove
        {
            add => HookEndpointManager.Add<Delegates.OnMove_WithArgs>(
                ReflectionHelper.GetMethodInfo(typeof(MenuDisplaySetting), "OnMove"), value);
            remove => HookEndpointManager.Remove<Delegates.OnMove_WithArgs>(
                ReflectionHelper.GetMethodInfo(typeof(MenuDisplaySetting), "OnMove"), value);
        }

        public static event Delegates.OnPointerClick_WithArgs OnPointerClick
        {
            add => HookEndpointManager.Add<Delegates.OnPointerClick_WithArgs>(
                ReflectionHelper.GetMethodInfo(typeof(MenuDisplaySetting), "OnPointerClick"), value);
            remove => HookEndpointManager.Remove<Delegates.OnPointerClick_WithArgs>(
                ReflectionHelper.GetMethodInfo(typeof(MenuDisplaySetting), "OnPointerClick"), value);
        }

        public static event Delegates.RefreshControls_WithArgs RefreshControls
        {
            add => HookEndpointManager.Add<Delegates.RefreshControls_WithArgs>(
                ReflectionHelper.GetMethodInfo(typeof(MenuDisplaySetting), "RefreshControls"), value);
            remove => HookEndpointManager.Remove<Delegates.RefreshControls_WithArgs>(
                ReflectionHelper.GetMethodInfo(typeof(MenuDisplaySetting), "RefreshControls"), value);
        }

        public static event Delegates.DisableMonitorSelectSetting_WithArgs DisableMonitorSelectSetting
        {
            add => HookEndpointManager.Add<Delegates.DisableMonitorSelectSetting_WithArgs>(
                ReflectionHelper.GetMethodInfo(typeof(MenuDisplaySetting), "DisableMonitorSelectSetting"), value);
            remove => HookEndpointManager.Remove<Delegates.DisableMonitorSelectSetting_WithArgs>(
                ReflectionHelper.GetMethodInfo(typeof(MenuDisplaySetting), "DisableMonitorSelectSetting"), value);
        }

        public static event Delegates.UpdateMonitorSetting_WithArgs UpdateMonitorSetting
        {
            add => HookEndpointManager.Add<Delegates.UpdateMonitorSetting_WithArgs>(
                ReflectionHelper.GetMethodInfo(typeof(MenuDisplaySetting), "UpdateMonitorSetting"), value);
            remove => HookEndpointManager.Remove<Delegates.UpdateMonitorSetting_WithArgs>(
                ReflectionHelper.GetMethodInfo(typeof(MenuDisplaySetting), "UpdateMonitorSetting"), value);
        }

        public static event Delegates.RefreshCurrentIndex_WithArgs RefreshCurrentIndex
        {
            add => HookEndpointManager.Add<Delegates.RefreshCurrentIndex_WithArgs>(
                ReflectionHelper.GetMethodInfo(typeof(MenuDisplaySetting), "RefreshCurrentIndex"), value);
            remove => HookEndpointManager.Remove<Delegates.RefreshCurrentIndex_WithArgs>(
                ReflectionHelper.GetMethodInfo(typeof(MenuDisplaySetting), "RefreshCurrentIndex"), value);
        }

        public static event Delegates.PushUpdateOptionList_WithArgs PushUpdateOptionList
        {
            add => HookEndpointManager.Add<Delegates.PushUpdateOptionList_WithArgs>(
                ReflectionHelper.GetMethodInfo(typeof(MenuDisplaySetting), "PushUpdateOptionList"), value);
            remove => HookEndpointManager.Remove<Delegates.PushUpdateOptionList_WithArgs>(
                ReflectionHelper.GetMethodInfo(typeof(MenuDisplaySetting), "PushUpdateOptionList"), value);
        }

        public static event Delegates.TargetDisplayHack_WithArgs TargetDisplayHack
        {
            add => HookEndpointManager.Add<Delegates.TargetDisplayHack_WithArgs>(
                ReflectionHelper.GetMethodInfo(typeof(MenuDisplaySetting), "TargetDisplayHack"), value);
            remove => HookEndpointManager.Remove<Delegates.TargetDisplayHack_WithArgs>(
                ReflectionHelper.GetMethodInfo(typeof(MenuDisplaySetting), "TargetDisplayHack"), value);
        }
    }
}