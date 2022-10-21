using MonoMod.RuntimeDetour;
using MonoMod.RuntimeDetour.HookGen;

namespace HKMirror.Hooks.OnHooks;

/// <summary>
/// Contains different types of On Hooks for PlayMakerUGuiPointerEventsProxy class.<br />
/// Contains hooks that aren't generated by monomod, and before and after orig hooks for easier hooking.
/// </summary>
public static class OnPlayMakerUGuiPointerEventsProxy
{
    internal static class HookHandler
    {
        private static List<string> HookedList = new List<string>();

        internal static void HookOnPointerClick()
        {
            if (!HookedList.Contains("OnPointerClick"))
            {
                HookedList.Add("OnPointerClick");
                On.PlayMakerUGuiPointerEventsProxy.OnPointerClick += OnPointerClick;
            }
        }

        internal static event Delegates.OnPointerClick_BeforeArgs _beforeOnPointerClick;
        internal static event Delegates.OnPointerClick_AfterArgs _afterOnPointerClick;

        private static void OnPointerClick(On.PlayMakerUGuiPointerEventsProxy.orig_OnPointerClick orig,
            PlayMakerUGuiPointerEventsProxy self, UnityEngine.EventSystems.PointerEventData data)
        {
            Delegates.Params_OnPointerClick @params = new()
            {
                self = self, data = data
            };
            if (_beforeOnPointerClick != null)
            {
                foreach (Delegates.OnPointerClick_BeforeArgs toInvoke in _beforeOnPointerClick.GetInvocationList())
                {
                    try
                    {
                        _beforeOnPointerClick?.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }
                }
            }

            self = @params.self;
            data = @params.data;
            orig(self, data);
            if (_afterOnPointerClick != null)
            {
                foreach (Delegates.OnPointerClick_AfterArgs toInvoke in _afterOnPointerClick.GetInvocationList())
                {
                    try
                    {
                        _afterOnPointerClick.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }
                }
            }
        }

        internal static void HookOnPointerDown()
        {
            if (!HookedList.Contains("OnPointerDown"))
            {
                HookedList.Add("OnPointerDown");
                On.PlayMakerUGuiPointerEventsProxy.OnPointerDown += OnPointerDown;
            }
        }

        internal static event Delegates.OnPointerDown_BeforeArgs _beforeOnPointerDown;
        internal static event Delegates.OnPointerDown_AfterArgs _afterOnPointerDown;

        private static void OnPointerDown(On.PlayMakerUGuiPointerEventsProxy.orig_OnPointerDown orig,
            PlayMakerUGuiPointerEventsProxy self, UnityEngine.EventSystems.PointerEventData data)
        {
            Delegates.Params_OnPointerDown @params = new()
            {
                self = self, data = data
            };
            if (_beforeOnPointerDown != null)
            {
                foreach (Delegates.OnPointerDown_BeforeArgs toInvoke in _beforeOnPointerDown.GetInvocationList())
                {
                    try
                    {
                        _beforeOnPointerDown?.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }
                }
            }

            self = @params.self;
            data = @params.data;
            orig(self, data);
            if (_afterOnPointerDown != null)
            {
                foreach (Delegates.OnPointerDown_AfterArgs toInvoke in _afterOnPointerDown.GetInvocationList())
                {
                    try
                    {
                        _afterOnPointerDown.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }
                }
            }
        }

        internal static void HookOnPointerEnter()
        {
            if (!HookedList.Contains("OnPointerEnter"))
            {
                HookedList.Add("OnPointerEnter");
                On.PlayMakerUGuiPointerEventsProxy.OnPointerEnter += OnPointerEnter;
            }
        }

        internal static event Delegates.OnPointerEnter_BeforeArgs _beforeOnPointerEnter;
        internal static event Delegates.OnPointerEnter_AfterArgs _afterOnPointerEnter;

        private static void OnPointerEnter(On.PlayMakerUGuiPointerEventsProxy.orig_OnPointerEnter orig,
            PlayMakerUGuiPointerEventsProxy self, UnityEngine.EventSystems.PointerEventData data)
        {
            Delegates.Params_OnPointerEnter @params = new()
            {
                self = self, data = data
            };
            if (_beforeOnPointerEnter != null)
            {
                foreach (Delegates.OnPointerEnter_BeforeArgs toInvoke in _beforeOnPointerEnter.GetInvocationList())
                {
                    try
                    {
                        _beforeOnPointerEnter?.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }
                }
            }

            self = @params.self;
            data = @params.data;
            orig(self, data);
            if (_afterOnPointerEnter != null)
            {
                foreach (Delegates.OnPointerEnter_AfterArgs toInvoke in _afterOnPointerEnter.GetInvocationList())
                {
                    try
                    {
                        _afterOnPointerEnter.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }
                }
            }
        }

        internal static void HookOnPointerExit()
        {
            if (!HookedList.Contains("OnPointerExit"))
            {
                HookedList.Add("OnPointerExit");
                On.PlayMakerUGuiPointerEventsProxy.OnPointerExit += OnPointerExit;
            }
        }

        internal static event Delegates.OnPointerExit_BeforeArgs _beforeOnPointerExit;
        internal static event Delegates.OnPointerExit_AfterArgs _afterOnPointerExit;

        private static void OnPointerExit(On.PlayMakerUGuiPointerEventsProxy.orig_OnPointerExit orig,
            PlayMakerUGuiPointerEventsProxy self, UnityEngine.EventSystems.PointerEventData data)
        {
            Delegates.Params_OnPointerExit @params = new()
            {
                self = self, data = data
            };
            if (_beforeOnPointerExit != null)
            {
                foreach (Delegates.OnPointerExit_BeforeArgs toInvoke in _beforeOnPointerExit.GetInvocationList())
                {
                    try
                    {
                        _beforeOnPointerExit?.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }
                }
            }

            self = @params.self;
            data = @params.data;
            orig(self, data);
            if (_afterOnPointerExit != null)
            {
                foreach (Delegates.OnPointerExit_AfterArgs toInvoke in _afterOnPointerExit.GetInvocationList())
                {
                    try
                    {
                        _afterOnPointerExit.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }
                }
            }
        }

        internal static void HookOnPointerUp()
        {
            if (!HookedList.Contains("OnPointerUp"))
            {
                HookedList.Add("OnPointerUp");
                On.PlayMakerUGuiPointerEventsProxy.OnPointerUp += OnPointerUp;
            }
        }

        internal static event Delegates.OnPointerUp_BeforeArgs _beforeOnPointerUp;
        internal static event Delegates.OnPointerUp_AfterArgs _afterOnPointerUp;

        private static void OnPointerUp(On.PlayMakerUGuiPointerEventsProxy.orig_OnPointerUp orig,
            PlayMakerUGuiPointerEventsProxy self, UnityEngine.EventSystems.PointerEventData data)
        {
            Delegates.Params_OnPointerUp @params = new()
            {
                self = self, data = data
            };
            if (_beforeOnPointerUp != null)
            {
                foreach (Delegates.OnPointerUp_BeforeArgs toInvoke in _beforeOnPointerUp.GetInvocationList())
                {
                    try
                    {
                        _beforeOnPointerUp?.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }
                }
            }

            self = @params.self;
            data = @params.data;
            orig(self, data);
            if (_afterOnPointerUp != null)
            {
                foreach (Delegates.OnPointerUp_AfterArgs toInvoke in _afterOnPointerUp.GetInvocationList())
                {
                    try
                    {
                        _afterOnPointerUp.Invoke(@params);
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
        public sealed class Params_OnPointerClick
        {
            public PlayMakerUGuiPointerEventsProxy self;
            public UnityEngine.EventSystems.PointerEventData data;
        }

        public delegate void OnPointerClick_BeforeArgs(Params_OnPointerClick args);

        public delegate void OnPointerClick_AfterArgs(Params_OnPointerClick args);

        public delegate void OnPointerClick_WithArgs(
            Action<PlayMakerUGuiPointerEventsProxy, UnityEngine.EventSystems.PointerEventData> orig,
            PlayMakerUGuiPointerEventsProxy self, UnityEngine.EventSystems.PointerEventData data);

        public sealed class Params_OnPointerDown
        {
            public PlayMakerUGuiPointerEventsProxy self;
            public UnityEngine.EventSystems.PointerEventData data;
        }

        public delegate void OnPointerDown_BeforeArgs(Params_OnPointerDown args);

        public delegate void OnPointerDown_AfterArgs(Params_OnPointerDown args);

        public delegate void OnPointerDown_WithArgs(
            Action<PlayMakerUGuiPointerEventsProxy, UnityEngine.EventSystems.PointerEventData> orig,
            PlayMakerUGuiPointerEventsProxy self, UnityEngine.EventSystems.PointerEventData data);

        public sealed class Params_OnPointerEnter
        {
            public PlayMakerUGuiPointerEventsProxy self;
            public UnityEngine.EventSystems.PointerEventData data;
        }

        public delegate void OnPointerEnter_BeforeArgs(Params_OnPointerEnter args);

        public delegate void OnPointerEnter_AfterArgs(Params_OnPointerEnter args);

        public delegate void OnPointerEnter_WithArgs(
            Action<PlayMakerUGuiPointerEventsProxy, UnityEngine.EventSystems.PointerEventData> orig,
            PlayMakerUGuiPointerEventsProxy self, UnityEngine.EventSystems.PointerEventData data);

        public sealed class Params_OnPointerExit
        {
            public PlayMakerUGuiPointerEventsProxy self;
            public UnityEngine.EventSystems.PointerEventData data;
        }

        public delegate void OnPointerExit_BeforeArgs(Params_OnPointerExit args);

        public delegate void OnPointerExit_AfterArgs(Params_OnPointerExit args);

        public delegate void OnPointerExit_WithArgs(
            Action<PlayMakerUGuiPointerEventsProxy, UnityEngine.EventSystems.PointerEventData> orig,
            PlayMakerUGuiPointerEventsProxy self, UnityEngine.EventSystems.PointerEventData data);

        public sealed class Params_OnPointerUp
        {
            public PlayMakerUGuiPointerEventsProxy self;
            public UnityEngine.EventSystems.PointerEventData data;
        }

        public delegate void OnPointerUp_BeforeArgs(Params_OnPointerUp args);

        public delegate void OnPointerUp_AfterArgs(Params_OnPointerUp args);

        public delegate void OnPointerUp_WithArgs(
            Action<PlayMakerUGuiPointerEventsProxy, UnityEngine.EventSystems.PointerEventData> orig,
            PlayMakerUGuiPointerEventsProxy self, UnityEngine.EventSystems.PointerEventData data);
    }

    /// <summary>
    /// Contains Hooks to that run code before orig(self) is called
    /// </summary>
    public static class BeforeOrig
    {
        public static event Delegates.OnPointerClick_BeforeArgs OnPointerClick
        {
            add
            {
                HookHandler._beforeOnPointerClick += value;
                HookHandler.HookOnPointerClick();
            }
            remove => HookHandler._beforeOnPointerClick -= value;
        }

        public static event Delegates.OnPointerDown_BeforeArgs OnPointerDown
        {
            add
            {
                HookHandler._beforeOnPointerDown += value;
                HookHandler.HookOnPointerDown();
            }
            remove => HookHandler._beforeOnPointerDown -= value;
        }

        public static event Delegates.OnPointerEnter_BeforeArgs OnPointerEnter
        {
            add
            {
                HookHandler._beforeOnPointerEnter += value;
                HookHandler.HookOnPointerEnter();
            }
            remove => HookHandler._beforeOnPointerEnter -= value;
        }

        public static event Delegates.OnPointerExit_BeforeArgs OnPointerExit
        {
            add
            {
                HookHandler._beforeOnPointerExit += value;
                HookHandler.HookOnPointerExit();
            }
            remove => HookHandler._beforeOnPointerExit -= value;
        }

        public static event Delegates.OnPointerUp_BeforeArgs OnPointerUp
        {
            add
            {
                HookHandler._beforeOnPointerUp += value;
                HookHandler.HookOnPointerUp();
            }
            remove => HookHandler._beforeOnPointerUp -= value;
        }
    }

    /// <summary>
    /// Contains Hooks to that run code after orig(self) is called
    /// </summary>
    public static class AfterOrig
    {
        public static event Delegates.OnPointerClick_AfterArgs OnPointerClick
        {
            add
            {
                HookHandler._afterOnPointerClick += value;
                HookHandler.HookOnPointerClick();
            }
            remove => HookHandler._afterOnPointerClick -= value;
        }

        public static event Delegates.OnPointerDown_AfterArgs OnPointerDown
        {
            add
            {
                HookHandler._afterOnPointerDown += value;
                HookHandler.HookOnPointerDown();
            }
            remove => HookHandler._afterOnPointerDown -= value;
        }

        public static event Delegates.OnPointerEnter_AfterArgs OnPointerEnter
        {
            add
            {
                HookHandler._afterOnPointerEnter += value;
                HookHandler.HookOnPointerEnter();
            }
            remove => HookHandler._afterOnPointerEnter -= value;
        }

        public static event Delegates.OnPointerExit_AfterArgs OnPointerExit
        {
            add
            {
                HookHandler._afterOnPointerExit += value;
                HookHandler.HookOnPointerExit();
            }
            remove => HookHandler._afterOnPointerExit -= value;
        }

        public static event Delegates.OnPointerUp_AfterArgs OnPointerUp
        {
            add
            {
                HookHandler._afterOnPointerUp += value;
                HookHandler.HookOnPointerUp();
            }
            remove => HookHandler._afterOnPointerUp -= value;
        }
    }

    /// <summary>
    /// Contains all On Hooks, even those that aren't in the On namespace such as API generated functions and property getters/setters
    /// </summary>
    public static class WithOrig
    {
        public static event On.PlayMakerUGuiPointerEventsProxy.hook_OnPointerClick OnPointerClick
        {
            add => On.PlayMakerUGuiPointerEventsProxy.OnPointerClick += value;
            remove => On.PlayMakerUGuiPointerEventsProxy.OnPointerClick -= value;
        }

        public static event On.PlayMakerUGuiPointerEventsProxy.hook_OnPointerDown OnPointerDown
        {
            add => On.PlayMakerUGuiPointerEventsProxy.OnPointerDown += value;
            remove => On.PlayMakerUGuiPointerEventsProxy.OnPointerDown -= value;
        }

        public static event On.PlayMakerUGuiPointerEventsProxy.hook_OnPointerEnter OnPointerEnter
        {
            add => On.PlayMakerUGuiPointerEventsProxy.OnPointerEnter += value;
            remove => On.PlayMakerUGuiPointerEventsProxy.OnPointerEnter -= value;
        }

        public static event On.PlayMakerUGuiPointerEventsProxy.hook_OnPointerExit OnPointerExit
        {
            add => On.PlayMakerUGuiPointerEventsProxy.OnPointerExit += value;
            remove => On.PlayMakerUGuiPointerEventsProxy.OnPointerExit -= value;
        }

        public static event On.PlayMakerUGuiPointerEventsProxy.hook_OnPointerUp OnPointerUp
        {
            add => On.PlayMakerUGuiPointerEventsProxy.OnPointerUp += value;
            remove => On.PlayMakerUGuiPointerEventsProxy.OnPointerUp -= value;
        }
    }
}