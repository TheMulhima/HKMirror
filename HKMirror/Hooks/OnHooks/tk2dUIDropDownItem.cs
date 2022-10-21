using MonoMod.RuntimeDetour;
using MonoMod.RuntimeDetour.HookGen;

namespace HKMirror.Hooks.OnHooks;

/// <summary>
/// Contains different types of On Hooks for tk2dUIDropDownItem class.<br />
/// Contains hooks that aren't generated by monomod, and before and after orig hooks for easier hooking.
/// </summary>
public static class Ontk2dUIDropDownItem
{
    internal static class HookHandler
    {
        private static List<string> HookedList = new List<string>();

        internal static void Hookget_Index()
        {
            if (!HookedList.Contains("get_Index"))
            {
                HookedList.Add("get_Index");
                new Hook(ReflectionHelper.GetMethodInfo(typeof(tk2dUIDropDownItem), "get_Index", true), get_Index);
            }
        }

        internal static event Delegates.get_Index_BeforeArgs _beforeget_Index;
        internal static event Delegates.get_Index_AfterArgs _afterget_Index;

        private static int get_Index(Func<tk2dUIDropDownItem, int> orig, tk2dUIDropDownItem self)
        {
            Delegates.Params_get_Index @params = new()
            {
                self = self
            };
            if (_beforeget_Index != null)
            {
                foreach (Delegates.get_Index_BeforeArgs toInvoke in _beforeget_Index.GetInvocationList())
                {
                    try
                    {
                        _beforeget_Index?.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }
                }
            }

            self = @params.self;
            var retVal = orig(self);
            if (_afterget_Index != null)
            {
                foreach (Delegates.get_Index_AfterArgs toInvoke in _afterget_Index.GetInvocationList())
                {
                    try
                    {
                        retVal = _afterget_Index.Invoke(@params, retVal);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }
                }
            }

            return retVal;
        }

        internal static void Hookset_Index()
        {
            if (!HookedList.Contains("set_Index"))
            {
                HookedList.Add("set_Index");
                new Hook(ReflectionHelper.GetMethodInfo(typeof(tk2dUIDropDownItem), "set_Index", true), set_Index);
            }
        }

        internal static event Delegates.set_Index_BeforeArgs _beforeset_Index;
        internal static event Delegates.set_Index_AfterArgs _afterset_Index;

        private static void set_Index(Action<tk2dUIDropDownItem, int> orig, tk2dUIDropDownItem self, int value)
        {
            Delegates.Params_set_Index @params = new()
            {
                self = self, value = value
            };
            if (_beforeset_Index != null)
            {
                foreach (Delegates.set_Index_BeforeArgs toInvoke in _beforeset_Index.GetInvocationList())
                {
                    try
                    {
                        _beforeset_Index?.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }
                }
            }

            self = @params.self;
            value = @params.value;
            orig(self, value);
            if (_afterset_Index != null)
            {
                foreach (Delegates.set_Index_AfterArgs toInvoke in _afterset_Index.GetInvocationList())
                {
                    try
                    {
                        _afterset_Index.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }
                }
            }
        }

        internal static void Hookget_LabelText()
        {
            if (!HookedList.Contains("get_LabelText"))
            {
                HookedList.Add("get_LabelText");
                new Hook(ReflectionHelper.GetMethodInfo(typeof(tk2dUIDropDownItem), "get_LabelText", true),
                    get_LabelText);
            }
        }

        internal static event Delegates.get_LabelText_BeforeArgs _beforeget_LabelText;
        internal static event Delegates.get_LabelText_AfterArgs _afterget_LabelText;

        private static string get_LabelText(Func<tk2dUIDropDownItem, string> orig, tk2dUIDropDownItem self)
        {
            Delegates.Params_get_LabelText @params = new()
            {
                self = self
            };
            if (_beforeget_LabelText != null)
            {
                foreach (Delegates.get_LabelText_BeforeArgs toInvoke in _beforeget_LabelText.GetInvocationList())
                {
                    try
                    {
                        _beforeget_LabelText?.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }
                }
            }

            self = @params.self;
            var retVal = orig(self);
            if (_afterget_LabelText != null)
            {
                foreach (Delegates.get_LabelText_AfterArgs toInvoke in _afterget_LabelText.GetInvocationList())
                {
                    try
                    {
                        retVal = _afterget_LabelText.Invoke(@params, retVal);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }
                }
            }

            return retVal;
        }

        internal static void Hookset_LabelText()
        {
            if (!HookedList.Contains("set_LabelText"))
            {
                HookedList.Add("set_LabelText");
                new Hook(ReflectionHelper.GetMethodInfo(typeof(tk2dUIDropDownItem), "set_LabelText", true),
                    set_LabelText);
            }
        }

        internal static event Delegates.set_LabelText_BeforeArgs _beforeset_LabelText;
        internal static event Delegates.set_LabelText_AfterArgs _afterset_LabelText;

        private static void set_LabelText(Action<tk2dUIDropDownItem, string> orig, tk2dUIDropDownItem self,
            string value)
        {
            Delegates.Params_set_LabelText @params = new()
            {
                self = self, value = value
            };
            if (_beforeset_LabelText != null)
            {
                foreach (Delegates.set_LabelText_BeforeArgs toInvoke in _beforeset_LabelText.GetInvocationList())
                {
                    try
                    {
                        _beforeset_LabelText?.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }
                }
            }

            self = @params.self;
            value = @params.value;
            orig(self, value);
            if (_afterset_LabelText != null)
            {
                foreach (Delegates.set_LabelText_AfterArgs toInvoke in _afterset_LabelText.GetInvocationList())
                {
                    try
                    {
                        _afterset_LabelText.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }
                }
            }
        }

        internal static void HookOnEnable()
        {
            if (!HookedList.Contains("OnEnable"))
            {
                HookedList.Add("OnEnable");
                On.tk2dUIDropDownItem.OnEnable += OnEnable;
            }
        }

        internal static event Delegates.OnEnable_BeforeArgs _beforeOnEnable;
        internal static event Delegates.OnEnable_AfterArgs _afterOnEnable;

        private static void OnEnable(On.tk2dUIDropDownItem.orig_OnEnable orig, tk2dUIDropDownItem self)
        {
            Delegates.Params_OnEnable @params = new()
            {
                self = self
            };
            if (_beforeOnEnable != null)
            {
                foreach (Delegates.OnEnable_BeforeArgs toInvoke in _beforeOnEnable.GetInvocationList())
                {
                    try
                    {
                        _beforeOnEnable?.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }
                }
            }

            self = @params.self;
            orig(self);
            if (_afterOnEnable != null)
            {
                foreach (Delegates.OnEnable_AfterArgs toInvoke in _afterOnEnable.GetInvocationList())
                {
                    try
                    {
                        _afterOnEnable.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }
                }
            }
        }

        internal static void HookOnDisable()
        {
            if (!HookedList.Contains("OnDisable"))
            {
                HookedList.Add("OnDisable");
                On.tk2dUIDropDownItem.OnDisable += OnDisable;
            }
        }

        internal static event Delegates.OnDisable_BeforeArgs _beforeOnDisable;
        internal static event Delegates.OnDisable_AfterArgs _afterOnDisable;

        private static void OnDisable(On.tk2dUIDropDownItem.orig_OnDisable orig, tk2dUIDropDownItem self)
        {
            Delegates.Params_OnDisable @params = new()
            {
                self = self
            };
            if (_beforeOnDisable != null)
            {
                foreach (Delegates.OnDisable_BeforeArgs toInvoke in _beforeOnDisable.GetInvocationList())
                {
                    try
                    {
                        _beforeOnDisable?.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }
                }
            }

            self = @params.self;
            orig(self);
            if (_afterOnDisable != null)
            {
                foreach (Delegates.OnDisable_AfterArgs toInvoke in _afterOnDisable.GetInvocationList())
                {
                    try
                    {
                        _afterOnDisable.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }
                }
            }
        }

        internal static void HookItemSelected()
        {
            if (!HookedList.Contains("ItemSelected"))
            {
                HookedList.Add("ItemSelected");
                On.tk2dUIDropDownItem.ItemSelected += ItemSelected;
            }
        }

        internal static event Delegates.ItemSelected_BeforeArgs _beforeItemSelected;
        internal static event Delegates.ItemSelected_AfterArgs _afterItemSelected;

        private static void ItemSelected(On.tk2dUIDropDownItem.orig_ItemSelected orig, tk2dUIDropDownItem self)
        {
            Delegates.Params_ItemSelected @params = new()
            {
                self = self
            };
            if (_beforeItemSelected != null)
            {
                foreach (Delegates.ItemSelected_BeforeArgs toInvoke in _beforeItemSelected.GetInvocationList())
                {
                    try
                    {
                        _beforeItemSelected?.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }
                }
            }

            self = @params.self;
            orig(self);
            if (_afterItemSelected != null)
            {
                foreach (Delegates.ItemSelected_AfterArgs toInvoke in _afterItemSelected.GetInvocationList())
                {
                    try
                    {
                        _afterItemSelected.Invoke(@params);
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
        public sealed class Params_get_Index
        {
            public tk2dUIDropDownItem self;
        }

        public delegate void get_Index_BeforeArgs(Params_get_Index args);

        public delegate int get_Index_AfterArgs(Params_get_Index args, int ret);

        public delegate int get_Index_WithArgs(Func<tk2dUIDropDownItem, int> orig, tk2dUIDropDownItem self);

        public sealed class Params_set_Index
        {
            public tk2dUIDropDownItem self;
            public int value;
        }

        public delegate void set_Index_BeforeArgs(Params_set_Index args);

        public delegate void set_Index_AfterArgs(Params_set_Index args);

        public delegate void set_Index_WithArgs(Action<tk2dUIDropDownItem, int> orig, tk2dUIDropDownItem self,
            int value);

        public sealed class Params_get_LabelText
        {
            public tk2dUIDropDownItem self;
        }

        public delegate void get_LabelText_BeforeArgs(Params_get_LabelText args);

        public delegate string get_LabelText_AfterArgs(Params_get_LabelText args, string ret);

        public delegate string get_LabelText_WithArgs(Func<tk2dUIDropDownItem, string> orig, tk2dUIDropDownItem self);

        public sealed class Params_set_LabelText
        {
            public tk2dUIDropDownItem self;
            public string value;
        }

        public delegate void set_LabelText_BeforeArgs(Params_set_LabelText args);

        public delegate void set_LabelText_AfterArgs(Params_set_LabelText args);

        public delegate void set_LabelText_WithArgs(Action<tk2dUIDropDownItem, string> orig, tk2dUIDropDownItem self,
            string value);

        public sealed class Params_OnEnable
        {
            public tk2dUIDropDownItem self;
        }

        public delegate void OnEnable_BeforeArgs(Params_OnEnable args);

        public delegate void OnEnable_AfterArgs(Params_OnEnable args);

        public delegate void OnEnable_WithArgs(Action<tk2dUIDropDownItem> orig, tk2dUIDropDownItem self);

        public sealed class Params_OnDisable
        {
            public tk2dUIDropDownItem self;
        }

        public delegate void OnDisable_BeforeArgs(Params_OnDisable args);

        public delegate void OnDisable_AfterArgs(Params_OnDisable args);

        public delegate void OnDisable_WithArgs(Action<tk2dUIDropDownItem> orig, tk2dUIDropDownItem self);

        public sealed class Params_ItemSelected
        {
            public tk2dUIDropDownItem self;
        }

        public delegate void ItemSelected_BeforeArgs(Params_ItemSelected args);

        public delegate void ItemSelected_AfterArgs(Params_ItemSelected args);

        public delegate void ItemSelected_WithArgs(Action<tk2dUIDropDownItem> orig, tk2dUIDropDownItem self);
    }

    /// <summary>
    /// Contains Hooks to that run code before orig(self) is called
    /// </summary>
    public static class BeforeOrig
    {
        public static event Delegates.get_Index_BeforeArgs get_Index
        {
            add
            {
                HookHandler._beforeget_Index += value;
                HookHandler.Hookget_Index();
            }
            remove => HookHandler._beforeget_Index -= value;
        }

        public static event Delegates.set_Index_BeforeArgs set_Index
        {
            add
            {
                HookHandler._beforeset_Index += value;
                HookHandler.Hookset_Index();
            }
            remove => HookHandler._beforeset_Index -= value;
        }

        public static event Delegates.get_LabelText_BeforeArgs get_LabelText
        {
            add
            {
                HookHandler._beforeget_LabelText += value;
                HookHandler.Hookget_LabelText();
            }
            remove => HookHandler._beforeget_LabelText -= value;
        }

        public static event Delegates.set_LabelText_BeforeArgs set_LabelText
        {
            add
            {
                HookHandler._beforeset_LabelText += value;
                HookHandler.Hookset_LabelText();
            }
            remove => HookHandler._beforeset_LabelText -= value;
        }

        public static event Delegates.OnEnable_BeforeArgs OnEnable
        {
            add
            {
                HookHandler._beforeOnEnable += value;
                HookHandler.HookOnEnable();
            }
            remove => HookHandler._beforeOnEnable -= value;
        }

        public static event Delegates.OnDisable_BeforeArgs OnDisable
        {
            add
            {
                HookHandler._beforeOnDisable += value;
                HookHandler.HookOnDisable();
            }
            remove => HookHandler._beforeOnDisable -= value;
        }

        public static event Delegates.ItemSelected_BeforeArgs ItemSelected
        {
            add
            {
                HookHandler._beforeItemSelected += value;
                HookHandler.HookItemSelected();
            }
            remove => HookHandler._beforeItemSelected -= value;
        }
    }

    /// <summary>
    /// Contains Hooks to that run code after orig(self) is called
    /// </summary>
    public static class AfterOrig
    {
        public static event Delegates.get_Index_AfterArgs get_Index
        {
            add
            {
                HookHandler._afterget_Index += value;
                HookHandler.Hookget_Index();
            }
            remove => HookHandler._afterget_Index -= value;
        }

        public static event Delegates.set_Index_AfterArgs set_Index
        {
            add
            {
                HookHandler._afterset_Index += value;
                HookHandler.Hookset_Index();
            }
            remove => HookHandler._afterset_Index -= value;
        }

        public static event Delegates.get_LabelText_AfterArgs get_LabelText
        {
            add
            {
                HookHandler._afterget_LabelText += value;
                HookHandler.Hookget_LabelText();
            }
            remove => HookHandler._afterget_LabelText -= value;
        }

        public static event Delegates.set_LabelText_AfterArgs set_LabelText
        {
            add
            {
                HookHandler._afterset_LabelText += value;
                HookHandler.Hookset_LabelText();
            }
            remove => HookHandler._afterset_LabelText -= value;
        }

        public static event Delegates.OnEnable_AfterArgs OnEnable
        {
            add
            {
                HookHandler._afterOnEnable += value;
                HookHandler.HookOnEnable();
            }
            remove => HookHandler._afterOnEnable -= value;
        }

        public static event Delegates.OnDisable_AfterArgs OnDisable
        {
            add
            {
                HookHandler._afterOnDisable += value;
                HookHandler.HookOnDisable();
            }
            remove => HookHandler._afterOnDisable -= value;
        }

        public static event Delegates.ItemSelected_AfterArgs ItemSelected
        {
            add
            {
                HookHandler._afterItemSelected += value;
                HookHandler.HookItemSelected();
            }
            remove => HookHandler._afterItemSelected -= value;
        }
    }

    /// <summary>
    /// Contains all On Hooks, even those that aren't in the On namespace such as API generated functions and property getters/setters
    /// </summary>
    public static class WithOrig
    {
        public static event Delegates.get_Index_WithArgs get_Index
        {
            add => HookEndpointManager.Add<Delegates.get_Index_WithArgs>(
                ReflectionHelper.GetMethodInfo(typeof(tk2dUIDropDownItem), "get_Index", true), value);
            remove => HookEndpointManager.Remove<Delegates.get_Index_WithArgs>(
                ReflectionHelper.GetMethodInfo(typeof(tk2dUIDropDownItem), "get_Index", true), value);
        }

        public static event Delegates.set_Index_WithArgs set_Index
        {
            add => HookEndpointManager.Add<Delegates.set_Index_WithArgs>(
                ReflectionHelper.GetMethodInfo(typeof(tk2dUIDropDownItem), "set_Index", true), value);
            remove => HookEndpointManager.Remove<Delegates.set_Index_WithArgs>(
                ReflectionHelper.GetMethodInfo(typeof(tk2dUIDropDownItem), "set_Index", true), value);
        }

        public static event Delegates.get_LabelText_WithArgs get_LabelText
        {
            add => HookEndpointManager.Add<Delegates.get_LabelText_WithArgs>(
                ReflectionHelper.GetMethodInfo(typeof(tk2dUIDropDownItem), "get_LabelText", true), value);
            remove => HookEndpointManager.Remove<Delegates.get_LabelText_WithArgs>(
                ReflectionHelper.GetMethodInfo(typeof(tk2dUIDropDownItem), "get_LabelText", true), value);
        }

        public static event Delegates.set_LabelText_WithArgs set_LabelText
        {
            add => HookEndpointManager.Add<Delegates.set_LabelText_WithArgs>(
                ReflectionHelper.GetMethodInfo(typeof(tk2dUIDropDownItem), "set_LabelText", true), value);
            remove => HookEndpointManager.Remove<Delegates.set_LabelText_WithArgs>(
                ReflectionHelper.GetMethodInfo(typeof(tk2dUIDropDownItem), "set_LabelText", true), value);
        }

        public static event On.tk2dUIDropDownItem.hook_OnEnable OnEnable
        {
            add => On.tk2dUIDropDownItem.OnEnable += value;
            remove => On.tk2dUIDropDownItem.OnEnable -= value;
        }

        public static event On.tk2dUIDropDownItem.hook_OnDisable OnDisable
        {
            add => On.tk2dUIDropDownItem.OnDisable += value;
            remove => On.tk2dUIDropDownItem.OnDisable -= value;
        }

        public static event On.tk2dUIDropDownItem.hook_ItemSelected ItemSelected
        {
            add => On.tk2dUIDropDownItem.ItemSelected += value;
            remove => On.tk2dUIDropDownItem.ItemSelected -= value;
        }
    }
}