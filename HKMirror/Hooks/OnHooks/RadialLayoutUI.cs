using MonoMod.RuntimeDetour;
using MonoMod.RuntimeDetour.HookGen;

namespace HKMirror.Hooks.OnHooks;

/// <summary>
/// Contains different types of On Hooks for RadialLayoutUI class.<br />
/// Contains hooks that aren't generated by monomod, and before and after orig hooks for easier hooking.
/// </summary>
public static class OnRadialLayoutUI
{
    internal static class HookHandler
    {
        private static List<string> HookedList = new List<string>();

        internal static void HookUpdate()
        {
            if (!HookedList.Contains("Update"))
            {
                HookedList.Add("Update");
                On.RadialLayoutUI.Update += Update;
            }
        }

        internal static event Delegates.Update_BeforeArgs _beforeUpdate;
        internal static event Delegates.Update_AfterArgs _afterUpdate;

        private static void Update(On.RadialLayoutUI.orig_Update orig, RadialLayoutUI self)
        {
            Delegates.Params_Update @params = new()
            {
                self = self
            };
            if (_beforeUpdate != null)
            {
                foreach (Delegates.Update_BeforeArgs toInvoke in _beforeUpdate.GetInvocationList())
                {
                    try
                    {
                        _beforeUpdate?.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }
                }
            }

            self = @params.self;
            orig(self);
            if (_afterUpdate != null)
            {
                foreach (Delegates.Update_AfterArgs toInvoke in _afterUpdate.GetInvocationList())
                {
                    try
                    {
                        _afterUpdate.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }
                }
            }
        }

        internal static void HookOnTransformChildrenChanged()
        {
            if (!HookedList.Contains("OnTransformChildrenChanged"))
            {
                HookedList.Add("OnTransformChildrenChanged");
                On.RadialLayoutUI.OnTransformChildrenChanged += OnTransformChildrenChanged;
            }
        }

        internal static event Delegates.OnTransformChildrenChanged_BeforeArgs _beforeOnTransformChildrenChanged;
        internal static event Delegates.OnTransformChildrenChanged_AfterArgs _afterOnTransformChildrenChanged;

        private static void OnTransformChildrenChanged(On.RadialLayoutUI.orig_OnTransformChildrenChanged orig,
            RadialLayoutUI self)
        {
            Delegates.Params_OnTransformChildrenChanged @params = new()
            {
                self = self
            };
            if (_beforeOnTransformChildrenChanged != null)
            {
                foreach (Delegates.OnTransformChildrenChanged_BeforeArgs toInvoke in _beforeOnTransformChildrenChanged
                             .GetInvocationList())
                {
                    try
                    {
                        _beforeOnTransformChildrenChanged?.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }
                }
            }

            self = @params.self;
            orig(self);
            if (_afterOnTransformChildrenChanged != null)
            {
                foreach (Delegates.OnTransformChildrenChanged_AfterArgs toInvoke in _afterOnTransformChildrenChanged
                             .GetInvocationList())
                {
                    try
                    {
                        _afterOnTransformChildrenChanged.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }
                }
            }
        }

        internal static void HookHasValueChanged()
        {
            if (!HookedList.Contains("HasValueChanged"))
            {
                HookedList.Add("HasValueChanged");
                On.RadialLayoutUI.HasValueChanged += HasValueChanged;
            }
        }

        internal static event Delegates.HasValueChanged_BeforeArgs _beforeHasValueChanged;
        internal static event Delegates.HasValueChanged_AfterArgs _afterHasValueChanged;

        private static bool HasValueChanged(On.RadialLayoutUI.orig_HasValueChanged orig, RadialLayoutUI self)
        {
            Delegates.Params_HasValueChanged @params = new()
            {
                self = self
            };
            if (_beforeHasValueChanged != null)
            {
                foreach (Delegates.HasValueChanged_BeforeArgs toInvoke in _beforeHasValueChanged.GetInvocationList())
                {
                    try
                    {
                        _beforeHasValueChanged?.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }
                }
            }

            self = @params.self;
            var retVal = orig(self);
            if (_afterHasValueChanged != null)
            {
                foreach (Delegates.HasValueChanged_AfterArgs toInvoke in _afterHasValueChanged.GetInvocationList())
                {
                    try
                    {
                        retVal = _afterHasValueChanged.Invoke(@params, retVal);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }
                }
            }

            return retVal;
        }

        internal static void HookUpdateUI()
        {
            if (!HookedList.Contains("UpdateUI"))
            {
                HookedList.Add("UpdateUI");
                On.RadialLayoutUI.UpdateUI += UpdateUI;
            }
        }

        internal static event Delegates.UpdateUI_BeforeArgs _beforeUpdateUI;
        internal static event Delegates.UpdateUI_AfterArgs _afterUpdateUI;

        private static void UpdateUI(On.RadialLayoutUI.orig_UpdateUI orig, RadialLayoutUI self)
        {
            Delegates.Params_UpdateUI @params = new()
            {
                self = self
            };
            if (_beforeUpdateUI != null)
            {
                foreach (Delegates.UpdateUI_BeforeArgs toInvoke in _beforeUpdateUI.GetInvocationList())
                {
                    try
                    {
                        _beforeUpdateUI?.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }
                }
            }

            self = @params.self;
            orig(self);
            if (_afterUpdateUI != null)
            {
                foreach (Delegates.UpdateUI_AfterArgs toInvoke in _afterUpdateUI.GetInvocationList())
                {
                    try
                    {
                        _afterUpdateUI.Invoke(@params);
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
        public sealed class Params_Update
        {
            public RadialLayoutUI self;
        }

        public delegate void Update_BeforeArgs(Params_Update args);

        public delegate void Update_AfterArgs(Params_Update args);

        public delegate void Update_WithArgs(Action<RadialLayoutUI> orig, RadialLayoutUI self);

        public sealed class Params_OnTransformChildrenChanged
        {
            public RadialLayoutUI self;
        }

        public delegate void OnTransformChildrenChanged_BeforeArgs(Params_OnTransformChildrenChanged args);

        public delegate void OnTransformChildrenChanged_AfterArgs(Params_OnTransformChildrenChanged args);

        public delegate void OnTransformChildrenChanged_WithArgs(Action<RadialLayoutUI> orig, RadialLayoutUI self);

        public sealed class Params_HasValueChanged
        {
            public RadialLayoutUI self;
        }

        public delegate void HasValueChanged_BeforeArgs(Params_HasValueChanged args);

        public delegate bool HasValueChanged_AfterArgs(Params_HasValueChanged args, bool ret);

        public delegate bool HasValueChanged_WithArgs(Func<RadialLayoutUI, bool> orig, RadialLayoutUI self);

        public sealed class Params_UpdateUI
        {
            public RadialLayoutUI self;
        }

        public delegate void UpdateUI_BeforeArgs(Params_UpdateUI args);

        public delegate void UpdateUI_AfterArgs(Params_UpdateUI args);

        public delegate void UpdateUI_WithArgs(Action<RadialLayoutUI> orig, RadialLayoutUI self);
    }

    /// <summary>
    /// Contains Hooks to that run code before orig(self) is called
    /// </summary>
    public static class BeforeOrig
    {
        public static event Delegates.Update_BeforeArgs Update
        {
            add
            {
                HookHandler._beforeUpdate += value;
                HookHandler.HookUpdate();
            }
            remove => HookHandler._beforeUpdate -= value;
        }

        public static event Delegates.OnTransformChildrenChanged_BeforeArgs OnTransformChildrenChanged
        {
            add
            {
                HookHandler._beforeOnTransformChildrenChanged += value;
                HookHandler.HookOnTransformChildrenChanged();
            }
            remove => HookHandler._beforeOnTransformChildrenChanged -= value;
        }

        public static event Delegates.HasValueChanged_BeforeArgs HasValueChanged
        {
            add
            {
                HookHandler._beforeHasValueChanged += value;
                HookHandler.HookHasValueChanged();
            }
            remove => HookHandler._beforeHasValueChanged -= value;
        }

        public static event Delegates.UpdateUI_BeforeArgs UpdateUI
        {
            add
            {
                HookHandler._beforeUpdateUI += value;
                HookHandler.HookUpdateUI();
            }
            remove => HookHandler._beforeUpdateUI -= value;
        }
    }

    /// <summary>
    /// Contains Hooks to that run code after orig(self) is called
    /// </summary>
    public static class AfterOrig
    {
        public static event Delegates.Update_AfterArgs Update
        {
            add
            {
                HookHandler._afterUpdate += value;
                HookHandler.HookUpdate();
            }
            remove => HookHandler._afterUpdate -= value;
        }

        public static event Delegates.OnTransformChildrenChanged_AfterArgs OnTransformChildrenChanged
        {
            add
            {
                HookHandler._afterOnTransformChildrenChanged += value;
                HookHandler.HookOnTransformChildrenChanged();
            }
            remove => HookHandler._afterOnTransformChildrenChanged -= value;
        }

        public static event Delegates.HasValueChanged_AfterArgs HasValueChanged
        {
            add
            {
                HookHandler._afterHasValueChanged += value;
                HookHandler.HookHasValueChanged();
            }
            remove => HookHandler._afterHasValueChanged -= value;
        }

        public static event Delegates.UpdateUI_AfterArgs UpdateUI
        {
            add
            {
                HookHandler._afterUpdateUI += value;
                HookHandler.HookUpdateUI();
            }
            remove => HookHandler._afterUpdateUI -= value;
        }
    }

    /// <summary>
    /// Contains all On Hooks, even those that aren't in the On namespace such as API generated functions and property getters/setters
    /// </summary>
    public static class WithOrig
    {
        public static event On.RadialLayoutUI.hook_Update Update
        {
            add => On.RadialLayoutUI.Update += value;
            remove => On.RadialLayoutUI.Update -= value;
        }

        public static event On.RadialLayoutUI.hook_OnTransformChildrenChanged OnTransformChildrenChanged
        {
            add => On.RadialLayoutUI.OnTransformChildrenChanged += value;
            remove => On.RadialLayoutUI.OnTransformChildrenChanged -= value;
        }

        public static event On.RadialLayoutUI.hook_HasValueChanged HasValueChanged
        {
            add => On.RadialLayoutUI.HasValueChanged += value;
            remove => On.RadialLayoutUI.HasValueChanged -= value;
        }

        public static event On.RadialLayoutUI.hook_UpdateUI UpdateUI
        {
            add => On.RadialLayoutUI.UpdateUI += value;
            remove => On.RadialLayoutUI.UpdateUI -= value;
        }
    }
}