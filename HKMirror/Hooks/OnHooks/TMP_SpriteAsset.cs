using MonoMod.RuntimeDetour;
using MonoMod.RuntimeDetour.HookGen;
using TMPro;

namespace HKMirror.Hooks.OnHooks;

/// <summary>
///     Contains different types of On Hooks for TMP_SpriteAsset class.<br />
///     Contains hooks that aren't generated by monomod, and before and after orig hooks for easier hooking.
/// </summary>
public static class OnTMP_SpriteAsset
{
    internal static class HookHandler
    {
        private static readonly List<string> HookedList = new();

        internal static void Hookget_defaultSpriteAsset()
        {
            if (!HookedList.Contains("get_defaultSpriteAsset"))
            {
                HookedList.Add("get_defaultSpriteAsset");
                new Hook(ReflectionHelper.GetMethodInfo(typeof(TMP_SpriteAsset), "get_defaultSpriteAsset", false),
                    get_defaultSpriteAsset);
            }
        }

        internal static event Delegates.get_defaultSpriteAsset_BeforeArgs _beforeget_defaultSpriteAsset;
        internal static event Delegates.get_defaultSpriteAsset_NormalArgs _afterget_defaultSpriteAsset;

        private static TMP_SpriteAsset get_defaultSpriteAsset(Func<TMP_SpriteAsset> orig)
        {
            _beforeget_defaultSpriteAsset?.Invoke();
            var retVal = orig();
            if (_afterget_defaultSpriteAsset != null) retVal = _afterget_defaultSpriteAsset.Invoke();
            return retVal;
        }

        internal static void HookOnEnable()
        {
            if (!HookedList.Contains("OnEnable"))
            {
                HookedList.Add("OnEnable");
                new Hook(ReflectionHelper.GetMethodInfo(typeof(TMP_SpriteAsset), "OnEnable"), OnEnable);
            }
        }

        internal static event Delegates.OnEnable_BeforeArgs _beforeOnEnable;
        internal static event Delegates.OnEnable_NormalArgs _afterOnEnable;

        private static void OnEnable(Action<TMP_SpriteAsset> orig, TMP_SpriteAsset self)
        {
            Delegates.Params_OnEnable @params = new()
            {
                self = self
            };
            _beforeOnEnable?.Invoke(@params);
            self = @params.self;
            orig(self);
            if (_afterOnEnable != null) _afterOnEnable.Invoke(@params);
        }

        internal static void HookGetDefaultSpriteMaterial()
        {
            if (!HookedList.Contains("GetDefaultSpriteMaterial"))
            {
                HookedList.Add("GetDefaultSpriteMaterial");
                new Hook(ReflectionHelper.GetMethodInfo(typeof(TMP_SpriteAsset), "GetDefaultSpriteMaterial"),
                    GetDefaultSpriteMaterial);
            }
        }

        internal static event Delegates.GetDefaultSpriteMaterial_BeforeArgs _beforeGetDefaultSpriteMaterial;
        internal static event Delegates.GetDefaultSpriteMaterial_NormalArgs _afterGetDefaultSpriteMaterial;

        private static Material GetDefaultSpriteMaterial(Func<TMP_SpriteAsset, Material> orig, TMP_SpriteAsset self)
        {
            Delegates.Params_GetDefaultSpriteMaterial @params = new()
            {
                self = self
            };
            _beforeGetDefaultSpriteMaterial?.Invoke(@params);
            self = @params.self;
            var retVal = orig(self);
            if (_afterGetDefaultSpriteMaterial != null) retVal = _afterGetDefaultSpriteMaterial.Invoke(@params);
            return retVal;
        }

        internal static void HookGetSpriteIndex()
        {
            if (!HookedList.Contains("GetSpriteIndex"))
            {
                HookedList.Add("GetSpriteIndex");
                new Hook(ReflectionHelper.GetMethodInfo(typeof(TMP_SpriteAsset), "GetSpriteIndex"), GetSpriteIndex);
            }
        }

        internal static event Delegates.GetSpriteIndex_BeforeArgs _beforeGetSpriteIndex;
        internal static event Delegates.GetSpriteIndex_NormalArgs _afterGetSpriteIndex;

        private static int GetSpriteIndex(Func<TMP_SpriteAsset, int, int> orig, TMP_SpriteAsset self, int hashCode)
        {
            Delegates.Params_GetSpriteIndex @params = new()
            {
                self = self, hashCode = hashCode
            };
            _beforeGetSpriteIndex?.Invoke(@params);
            self = @params.self;
            hashCode = @params.hashCode;
            var retVal = orig(self, hashCode);
            if (_afterGetSpriteIndex != null) retVal = _afterGetSpriteIndex.Invoke(@params);
            return retVal;
        }
    }

    /// <summary>
    ///     Contains necessary information to create Hooks. Does not contain any hooks
    /// </summary>
    public static class Delegates
    {
        public delegate void get_defaultSpriteAsset_BeforeArgs();

        public delegate TMP_SpriteAsset get_defaultSpriteAsset_NormalArgs();

        public delegate void GetDefaultSpriteMaterial_BeforeArgs(Params_GetDefaultSpriteMaterial args);

        public delegate Material GetDefaultSpriteMaterial_NormalArgs(Params_GetDefaultSpriteMaterial args);

        public delegate void GetSpriteIndex_BeforeArgs(Params_GetSpriteIndex args);

        public delegate int GetSpriteIndex_NormalArgs(Params_GetSpriteIndex args);

        public delegate void OnEnable_BeforeArgs(Params_OnEnable args);

        public delegate void OnEnable_NormalArgs(Params_OnEnable args);

        public sealed class Params_OnEnable
        {
            public TMP_SpriteAsset self;
        }

        public sealed class Params_GetDefaultSpriteMaterial
        {
            public TMP_SpriteAsset self;
        }

        public sealed class Params_GetSpriteIndex
        {
            public int hashCode;
            public TMP_SpriteAsset self;
        }
    }

    /// <summary>
    ///     Contains Hooks to that run code before orig(self) is called
    /// </summary>
    public static class BeforeOrig
    {
        public static event Delegates.get_defaultSpriteAsset_BeforeArgs get_defaultSpriteAsset
        {
            add
            {
                HookHandler._beforeget_defaultSpriteAsset += value;
                HookHandler.Hookget_defaultSpriteAsset();
            }
            remove => HookHandler._beforeget_defaultSpriteAsset -= value;
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

        public static event Delegates.GetDefaultSpriteMaterial_BeforeArgs GetDefaultSpriteMaterial
        {
            add
            {
                HookHandler._beforeGetDefaultSpriteMaterial += value;
                HookHandler.HookGetDefaultSpriteMaterial();
            }
            remove => HookHandler._beforeGetDefaultSpriteMaterial -= value;
        }

        public static event Delegates.GetSpriteIndex_BeforeArgs GetSpriteIndex
        {
            add
            {
                HookHandler._beforeGetSpriteIndex += value;
                HookHandler.HookGetSpriteIndex();
            }
            remove => HookHandler._beforeGetSpriteIndex -= value;
        }
    }

    /// <summary>
    ///     Contains Hooks to that run code after orig(self) is called
    /// </summary>
    public static class AfterOrig
    {
        public static event Delegates.get_defaultSpriteAsset_NormalArgs get_defaultSpriteAsset
        {
            add
            {
                HookHandler._afterget_defaultSpriteAsset += value;
                HookHandler.Hookget_defaultSpriteAsset();
            }
            remove => HookHandler._afterget_defaultSpriteAsset -= value;
        }

        public static event Delegates.OnEnable_NormalArgs OnEnable
        {
            add
            {
                HookHandler._afterOnEnable += value;
                HookHandler.HookOnEnable();
            }
            remove => HookHandler._afterOnEnable -= value;
        }

        public static event Delegates.GetDefaultSpriteMaterial_NormalArgs GetDefaultSpriteMaterial
        {
            add
            {
                HookHandler._afterGetDefaultSpriteMaterial += value;
                HookHandler.HookGetDefaultSpriteMaterial();
            }
            remove => HookHandler._afterGetDefaultSpriteMaterial -= value;
        }

        public static event Delegates.GetSpriteIndex_NormalArgs GetSpriteIndex
        {
            add
            {
                HookHandler._afterGetSpriteIndex += value;
                HookHandler.HookGetSpriteIndex();
            }
            remove => HookHandler._afterGetSpriteIndex -= value;
        }
    }

    /// <summary>
    ///     Contains all On Hooks, even those that aren't in the On namespace such as API generated functions and property
    ///     getters/setters
    /// </summary>
    public static class WithOrig
    {
        public static event Delegates.get_defaultSpriteAsset_NormalArgs get_defaultSpriteAsset
        {
            add => HookEndpointManager.Add<Delegates.get_defaultSpriteAsset_NormalArgs>(
                ReflectionHelper.GetMethodInfo(typeof(TMP_SpriteAsset), "get_defaultSpriteAsset", false), value);
            remove => HookEndpointManager.Remove<Delegates.get_defaultSpriteAsset_NormalArgs>(
                ReflectionHelper.GetMethodInfo(typeof(TMP_SpriteAsset), "get_defaultSpriteAsset", false), value);
        }

        public static event Delegates.OnEnable_NormalArgs OnEnable
        {
            add => HookEndpointManager.Add<Delegates.OnEnable_NormalArgs>(
                ReflectionHelper.GetMethodInfo(typeof(TMP_SpriteAsset), "OnEnable"), value);
            remove => HookEndpointManager.Remove<Delegates.OnEnable_NormalArgs>(
                ReflectionHelper.GetMethodInfo(typeof(TMP_SpriteAsset), "OnEnable"), value);
        }

        public static event Delegates.GetDefaultSpriteMaterial_NormalArgs GetDefaultSpriteMaterial
        {
            add => HookEndpointManager.Add<Delegates.GetDefaultSpriteMaterial_NormalArgs>(
                ReflectionHelper.GetMethodInfo(typeof(TMP_SpriteAsset), "GetDefaultSpriteMaterial"), value);
            remove => HookEndpointManager.Remove<Delegates.GetDefaultSpriteMaterial_NormalArgs>(
                ReflectionHelper.GetMethodInfo(typeof(TMP_SpriteAsset), "GetDefaultSpriteMaterial"), value);
        }

        public static event Delegates.GetSpriteIndex_NormalArgs GetSpriteIndex
        {
            add => HookEndpointManager.Add<Delegates.GetSpriteIndex_NormalArgs>(
                ReflectionHelper.GetMethodInfo(typeof(TMP_SpriteAsset), "GetSpriteIndex"), value);
            remove => HookEndpointManager.Remove<Delegates.GetSpriteIndex_NormalArgs>(
                ReflectionHelper.GetMethodInfo(typeof(TMP_SpriteAsset), "GetSpriteIndex"), value);
        }
    }
}