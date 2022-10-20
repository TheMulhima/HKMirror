using MonoMod.RuntimeDetour;
using MonoMod.RuntimeDetour.HookGen;
using TMPro;

namespace HKMirror.Hooks.OnHooks;

/// <summary>
///     Contains different types of On Hooks for TMP_StyleSheet class.<br />
///     Contains hooks that aren't generated by monomod, and before and after orig hooks for easier hooking.
/// </summary>
public static class OnTMP_StyleSheet
{
    internal static class HookHandler
    {
        private static readonly List<string> HookedList = new();

        internal static void Hookget_instance()
        {
            if (!HookedList.Contains("get_instance"))
            {
                HookedList.Add("get_instance");
                new Hook(ReflectionHelper.GetMethodInfo(typeof(TMP_StyleSheet), "get_instance", false), get_instance);
            }
        }

        internal static event Delegates.get_instance_BeforeArgs _beforeget_instance;
        internal static event Delegates.get_instance_NormalArgs _afterget_instance;

        private static TMP_StyleSheet get_instance(Func<TMP_StyleSheet> orig)
        {
            _beforeget_instance?.Invoke();
            var retVal = orig();
            if (_afterget_instance != null) retVal = _afterget_instance.Invoke();
            return retVal;
        }

        internal static void HookLoadDefaultStyleSheet()
        {
            if (!HookedList.Contains("LoadDefaultStyleSheet"))
            {
                HookedList.Add("LoadDefaultStyleSheet");
                new Hook(ReflectionHelper.GetMethodInfo(typeof(TMP_StyleSheet), "LoadDefaultStyleSheet", false),
                    LoadDefaultStyleSheet);
            }
        }

        internal static event Delegates.LoadDefaultStyleSheet_BeforeArgs _beforeLoadDefaultStyleSheet;
        internal static event Delegates.LoadDefaultStyleSheet_NormalArgs _afterLoadDefaultStyleSheet;

        private static TMP_StyleSheet LoadDefaultStyleSheet(Func<TMP_StyleSheet> orig)
        {
            _beforeLoadDefaultStyleSheet?.Invoke();
            var retVal = orig();
            if (_afterLoadDefaultStyleSheet != null) retVal = _afterLoadDefaultStyleSheet.Invoke();
            return retVal;
        }

        internal static void HookGetStyle()
        {
            if (!HookedList.Contains("GetStyle"))
            {
                HookedList.Add("GetStyle");
                new Hook(ReflectionHelper.GetMethodInfo(typeof(TMP_StyleSheet), "GetStyle", false), GetStyle);
            }
        }

        internal static event Delegates.GetStyle_BeforeArgs _beforeGetStyle;
        internal static event Delegates.GetStyle_NormalArgs _afterGetStyle;

        private static TMP_Style GetStyle(Func<int, TMP_Style> orig, int hashCode)
        {
            Delegates.Params_GetStyle @params = new()
            {
                hashCode = hashCode
            };
            _beforeGetStyle?.Invoke(@params);
            hashCode = @params.hashCode;
            var retVal = orig(hashCode);
            if (_afterGetStyle != null) retVal = _afterGetStyle.Invoke(@params);
            return retVal;
        }

        internal static void HookGetStyleInternal()
        {
            if (!HookedList.Contains("GetStyleInternal"))
            {
                HookedList.Add("GetStyleInternal");
                new Hook(ReflectionHelper.GetMethodInfo(typeof(TMP_StyleSheet), "GetStyleInternal"), GetStyleInternal);
            }
        }

        internal static event Delegates.GetStyleInternal_BeforeArgs _beforeGetStyleInternal;
        internal static event Delegates.GetStyleInternal_NormalArgs _afterGetStyleInternal;

        private static TMP_Style GetStyleInternal(Func<TMP_StyleSheet, int, TMP_Style> orig, TMP_StyleSheet self,
            int hashCode)
        {
            Delegates.Params_GetStyleInternal @params = new()
            {
                self = self, hashCode = hashCode
            };
            _beforeGetStyleInternal?.Invoke(@params);
            self = @params.self;
            hashCode = @params.hashCode;
            var retVal = orig(self, hashCode);
            if (_afterGetStyleInternal != null) retVal = _afterGetStyleInternal.Invoke(@params);
            return retVal;
        }

        internal static void HookUpdateStyleDictionaryKey()
        {
            if (!HookedList.Contains("UpdateStyleDictionaryKey"))
            {
                HookedList.Add("UpdateStyleDictionaryKey");
                new Hook(ReflectionHelper.GetMethodInfo(typeof(TMP_StyleSheet), "UpdateStyleDictionaryKey"),
                    UpdateStyleDictionaryKey);
            }
        }

        internal static event Delegates.UpdateStyleDictionaryKey_BeforeArgs _beforeUpdateStyleDictionaryKey;
        internal static event Delegates.UpdateStyleDictionaryKey_NormalArgs _afterUpdateStyleDictionaryKey;

        private static void UpdateStyleDictionaryKey(Action<TMP_StyleSheet, int, int> orig, TMP_StyleSheet self,
            int old_key, int new_key)
        {
            Delegates.Params_UpdateStyleDictionaryKey @params = new()
            {
                self = self, old_key = old_key, new_key = new_key
            };
            _beforeUpdateStyleDictionaryKey?.Invoke(@params);
            self = @params.self;
            old_key = @params.old_key;
            new_key = @params.new_key;
            orig(self, old_key, new_key);
            if (_afterUpdateStyleDictionaryKey != null) _afterUpdateStyleDictionaryKey.Invoke(@params);
        }

        internal static void HookRefreshStyles()
        {
            if (!HookedList.Contains("RefreshStyles"))
            {
                HookedList.Add("RefreshStyles");
                new Hook(ReflectionHelper.GetMethodInfo(typeof(TMP_StyleSheet), "RefreshStyles", false), RefreshStyles);
            }
        }

        internal static event Delegates.RefreshStyles_BeforeArgs _beforeRefreshStyles;
        internal static event Delegates.RefreshStyles_NormalArgs _afterRefreshStyles;

        private static void RefreshStyles(Action orig)
        {
            _beforeRefreshStyles?.Invoke();
            orig();
            if (_afterRefreshStyles != null) _afterRefreshStyles.Invoke();
        }

        internal static void HookLoadStyleDictionaryInternal()
        {
            if (!HookedList.Contains("LoadStyleDictionaryInternal"))
            {
                HookedList.Add("LoadStyleDictionaryInternal");
                new Hook(ReflectionHelper.GetMethodInfo(typeof(TMP_StyleSheet), "LoadStyleDictionaryInternal"),
                    LoadStyleDictionaryInternal);
            }
        }

        internal static event Delegates.LoadStyleDictionaryInternal_BeforeArgs _beforeLoadStyleDictionaryInternal;
        internal static event Delegates.LoadStyleDictionaryInternal_NormalArgs _afterLoadStyleDictionaryInternal;

        private static void LoadStyleDictionaryInternal(Action<TMP_StyleSheet> orig, TMP_StyleSheet self)
        {
            Delegates.Params_LoadStyleDictionaryInternal @params = new()
            {
                self = self
            };
            _beforeLoadStyleDictionaryInternal?.Invoke(@params);
            self = @params.self;
            orig(self);
            if (_afterLoadStyleDictionaryInternal != null) _afterLoadStyleDictionaryInternal.Invoke(@params);
        }
    }

    /// <summary>
    ///     Contains necessary information to create Hooks. Does not contain any hooks
    /// </summary>
    public static class Delegates
    {
        public delegate void get_instance_BeforeArgs();

        public delegate TMP_StyleSheet get_instance_NormalArgs();

        public delegate void GetStyle_BeforeArgs(Params_GetStyle args);

        public delegate TMP_Style GetStyle_NormalArgs(Params_GetStyle args);

        public delegate void GetStyleInternal_BeforeArgs(Params_GetStyleInternal args);

        public delegate TMP_Style GetStyleInternal_NormalArgs(Params_GetStyleInternal args);

        public delegate void LoadDefaultStyleSheet_BeforeArgs();

        public delegate TMP_StyleSheet LoadDefaultStyleSheet_NormalArgs();

        public delegate void LoadStyleDictionaryInternal_BeforeArgs(Params_LoadStyleDictionaryInternal args);

        public delegate void LoadStyleDictionaryInternal_NormalArgs(Params_LoadStyleDictionaryInternal args);

        public delegate void RefreshStyles_BeforeArgs();

        public delegate void RefreshStyles_NormalArgs();

        public delegate void UpdateStyleDictionaryKey_BeforeArgs(Params_UpdateStyleDictionaryKey args);

        public delegate void UpdateStyleDictionaryKey_NormalArgs(Params_UpdateStyleDictionaryKey args);

        public sealed class Params_GetStyle
        {
            public int hashCode;
        }

        public sealed class Params_GetStyleInternal
        {
            public int hashCode;
            public TMP_StyleSheet self;
        }

        public sealed class Params_UpdateStyleDictionaryKey
        {
            public int new_key;
            public int old_key;
            public TMP_StyleSheet self;
        }

        public sealed class Params_LoadStyleDictionaryInternal
        {
            public TMP_StyleSheet self;
        }
    }

    /// <summary>
    ///     Contains Hooks to that run code before orig(self) is called
    /// </summary>
    public static class BeforeOrig
    {
        public static event Delegates.get_instance_BeforeArgs get_instance
        {
            add
            {
                HookHandler._beforeget_instance += value;
                HookHandler.Hookget_instance();
            }
            remove => HookHandler._beforeget_instance -= value;
        }

        public static event Delegates.LoadDefaultStyleSheet_BeforeArgs LoadDefaultStyleSheet
        {
            add
            {
                HookHandler._beforeLoadDefaultStyleSheet += value;
                HookHandler.HookLoadDefaultStyleSheet();
            }
            remove => HookHandler._beforeLoadDefaultStyleSheet -= value;
        }

        public static event Delegates.GetStyle_BeforeArgs GetStyle
        {
            add
            {
                HookHandler._beforeGetStyle += value;
                HookHandler.HookGetStyle();
            }
            remove => HookHandler._beforeGetStyle -= value;
        }

        public static event Delegates.GetStyleInternal_BeforeArgs GetStyleInternal
        {
            add
            {
                HookHandler._beforeGetStyleInternal += value;
                HookHandler.HookGetStyleInternal();
            }
            remove => HookHandler._beforeGetStyleInternal -= value;
        }

        public static event Delegates.UpdateStyleDictionaryKey_BeforeArgs UpdateStyleDictionaryKey
        {
            add
            {
                HookHandler._beforeUpdateStyleDictionaryKey += value;
                HookHandler.HookUpdateStyleDictionaryKey();
            }
            remove => HookHandler._beforeUpdateStyleDictionaryKey -= value;
        }

        public static event Delegates.RefreshStyles_BeforeArgs RefreshStyles
        {
            add
            {
                HookHandler._beforeRefreshStyles += value;
                HookHandler.HookRefreshStyles();
            }
            remove => HookHandler._beforeRefreshStyles -= value;
        }

        public static event Delegates.LoadStyleDictionaryInternal_BeforeArgs LoadStyleDictionaryInternal
        {
            add
            {
                HookHandler._beforeLoadStyleDictionaryInternal += value;
                HookHandler.HookLoadStyleDictionaryInternal();
            }
            remove => HookHandler._beforeLoadStyleDictionaryInternal -= value;
        }
    }

    /// <summary>
    ///     Contains Hooks to that run code after orig(self) is called
    /// </summary>
    public static class AfterOrig
    {
        public static event Delegates.get_instance_NormalArgs get_instance
        {
            add
            {
                HookHandler._afterget_instance += value;
                HookHandler.Hookget_instance();
            }
            remove => HookHandler._afterget_instance -= value;
        }

        public static event Delegates.LoadDefaultStyleSheet_NormalArgs LoadDefaultStyleSheet
        {
            add
            {
                HookHandler._afterLoadDefaultStyleSheet += value;
                HookHandler.HookLoadDefaultStyleSheet();
            }
            remove => HookHandler._afterLoadDefaultStyleSheet -= value;
        }

        public static event Delegates.GetStyle_NormalArgs GetStyle
        {
            add
            {
                HookHandler._afterGetStyle += value;
                HookHandler.HookGetStyle();
            }
            remove => HookHandler._afterGetStyle -= value;
        }

        public static event Delegates.GetStyleInternal_NormalArgs GetStyleInternal
        {
            add
            {
                HookHandler._afterGetStyleInternal += value;
                HookHandler.HookGetStyleInternal();
            }
            remove => HookHandler._afterGetStyleInternal -= value;
        }

        public static event Delegates.UpdateStyleDictionaryKey_NormalArgs UpdateStyleDictionaryKey
        {
            add
            {
                HookHandler._afterUpdateStyleDictionaryKey += value;
                HookHandler.HookUpdateStyleDictionaryKey();
            }
            remove => HookHandler._afterUpdateStyleDictionaryKey -= value;
        }

        public static event Delegates.RefreshStyles_NormalArgs RefreshStyles
        {
            add
            {
                HookHandler._afterRefreshStyles += value;
                HookHandler.HookRefreshStyles();
            }
            remove => HookHandler._afterRefreshStyles -= value;
        }

        public static event Delegates.LoadStyleDictionaryInternal_NormalArgs LoadStyleDictionaryInternal
        {
            add
            {
                HookHandler._afterLoadStyleDictionaryInternal += value;
                HookHandler.HookLoadStyleDictionaryInternal();
            }
            remove => HookHandler._afterLoadStyleDictionaryInternal -= value;
        }
    }

    /// <summary>
    ///     Contains all On Hooks, even those that aren't in the On namespace such as API generated functions and property
    ///     getters/setters
    /// </summary>
    public static class WithOrig
    {
        public static event Delegates.get_instance_NormalArgs get_instance
        {
            add => HookEndpointManager.Add<Delegates.get_instance_NormalArgs>(
                ReflectionHelper.GetMethodInfo(typeof(TMP_StyleSheet), "get_instance", false), value);
            remove => HookEndpointManager.Remove<Delegates.get_instance_NormalArgs>(
                ReflectionHelper.GetMethodInfo(typeof(TMP_StyleSheet), "get_instance", false), value);
        }

        public static event Delegates.LoadDefaultStyleSheet_NormalArgs LoadDefaultStyleSheet
        {
            add => HookEndpointManager.Add<Delegates.LoadDefaultStyleSheet_NormalArgs>(
                ReflectionHelper.GetMethodInfo(typeof(TMP_StyleSheet), "LoadDefaultStyleSheet", false), value);
            remove => HookEndpointManager.Remove<Delegates.LoadDefaultStyleSheet_NormalArgs>(
                ReflectionHelper.GetMethodInfo(typeof(TMP_StyleSheet), "LoadDefaultStyleSheet", false), value);
        }

        public static event Delegates.GetStyle_NormalArgs GetStyle
        {
            add => HookEndpointManager.Add<Delegates.GetStyle_NormalArgs>(
                ReflectionHelper.GetMethodInfo(typeof(TMP_StyleSheet), "GetStyle", false), value);
            remove => HookEndpointManager.Remove<Delegates.GetStyle_NormalArgs>(
                ReflectionHelper.GetMethodInfo(typeof(TMP_StyleSheet), "GetStyle", false), value);
        }

        public static event Delegates.GetStyleInternal_NormalArgs GetStyleInternal
        {
            add => HookEndpointManager.Add<Delegates.GetStyleInternal_NormalArgs>(
                ReflectionHelper.GetMethodInfo(typeof(TMP_StyleSheet), "GetStyleInternal"), value);
            remove => HookEndpointManager.Remove<Delegates.GetStyleInternal_NormalArgs>(
                ReflectionHelper.GetMethodInfo(typeof(TMP_StyleSheet), "GetStyleInternal"), value);
        }

        public static event Delegates.UpdateStyleDictionaryKey_NormalArgs UpdateStyleDictionaryKey
        {
            add => HookEndpointManager.Add<Delegates.UpdateStyleDictionaryKey_NormalArgs>(
                ReflectionHelper.GetMethodInfo(typeof(TMP_StyleSheet), "UpdateStyleDictionaryKey"), value);
            remove => HookEndpointManager.Remove<Delegates.UpdateStyleDictionaryKey_NormalArgs>(
                ReflectionHelper.GetMethodInfo(typeof(TMP_StyleSheet), "UpdateStyleDictionaryKey"), value);
        }

        public static event Delegates.RefreshStyles_NormalArgs RefreshStyles
        {
            add => HookEndpointManager.Add<Delegates.RefreshStyles_NormalArgs>(
                ReflectionHelper.GetMethodInfo(typeof(TMP_StyleSheet), "RefreshStyles", false), value);
            remove => HookEndpointManager.Remove<Delegates.RefreshStyles_NormalArgs>(
                ReflectionHelper.GetMethodInfo(typeof(TMP_StyleSheet), "RefreshStyles", false), value);
        }

        public static event Delegates.LoadStyleDictionaryInternal_NormalArgs LoadStyleDictionaryInternal
        {
            add => HookEndpointManager.Add<Delegates.LoadStyleDictionaryInternal_NormalArgs>(
                ReflectionHelper.GetMethodInfo(typeof(TMP_StyleSheet), "LoadStyleDictionaryInternal"), value);
            remove => HookEndpointManager.Remove<Delegates.LoadStyleDictionaryInternal_NormalArgs>(
                ReflectionHelper.GetMethodInfo(typeof(TMP_StyleSheet), "LoadStyleDictionaryInternal"), value);
        }
    }
}