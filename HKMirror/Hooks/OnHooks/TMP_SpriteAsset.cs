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
        internal static event Delegates.get_defaultSpriteAsset_AfterArgs _afterget_defaultSpriteAsset;

        private static TMP_SpriteAsset get_defaultSpriteAsset(Func<TMP_SpriteAsset> orig)
        {
            if (_beforeget_defaultSpriteAsset != null)
                foreach (Delegates.get_defaultSpriteAsset_BeforeArgs toInvoke in _beforeget_defaultSpriteAsset
                             .GetInvocationList())
                    try
                    {
                        _beforeget_defaultSpriteAsset?.Invoke();
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }

            var retVal = orig();
            if (_afterget_defaultSpriteAsset != null)
                foreach (Delegates.get_defaultSpriteAsset_AfterArgs toInvoke in _afterget_defaultSpriteAsset
                             .GetInvocationList())
                    try
                    {
                        retVal = _afterget_defaultSpriteAsset.Invoke(retVal);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }

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
        internal static event Delegates.OnEnable_AfterArgs _afterOnEnable;

        private static void OnEnable(Action<TMP_SpriteAsset> orig, TMP_SpriteAsset self)
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
        internal static event Delegates.GetDefaultSpriteMaterial_AfterArgs _afterGetDefaultSpriteMaterial;

        private static Material GetDefaultSpriteMaterial(Func<TMP_SpriteAsset, Material> orig, TMP_SpriteAsset self)
        {
            Delegates.Params_GetDefaultSpriteMaterial @params = new()
            {
                self = self
            };
            if (_beforeGetDefaultSpriteMaterial != null)
                foreach (Delegates.GetDefaultSpriteMaterial_BeforeArgs toInvoke in _beforeGetDefaultSpriteMaterial
                             .GetInvocationList())
                    try
                    {
                        _beforeGetDefaultSpriteMaterial?.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }

            self = @params.self;
            var retVal = orig(self);
            if (_afterGetDefaultSpriteMaterial != null)
                foreach (Delegates.GetDefaultSpriteMaterial_AfterArgs toInvoke in _afterGetDefaultSpriteMaterial
                             .GetInvocationList())
                    try
                    {
                        retVal = _afterGetDefaultSpriteMaterial.Invoke(@params, retVal);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }

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
        internal static event Delegates.GetSpriteIndex_AfterArgs _afterGetSpriteIndex;

        private static int GetSpriteIndex(Func<TMP_SpriteAsset, int, int> orig, TMP_SpriteAsset self, int hashCode)
        {
            Delegates.Params_GetSpriteIndex @params = new()
            {
                self = self, hashCode = hashCode
            };
            if (_beforeGetSpriteIndex != null)
                foreach (Delegates.GetSpriteIndex_BeforeArgs toInvoke in _beforeGetSpriteIndex.GetInvocationList())
                    try
                    {
                        _beforeGetSpriteIndex?.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }

            self = @params.self;
            hashCode = @params.hashCode;
            var retVal = orig(self, hashCode);
            if (_afterGetSpriteIndex != null)
                foreach (Delegates.GetSpriteIndex_AfterArgs toInvoke in _afterGetSpriteIndex.GetInvocationList())
                    try
                    {
                        retVal = _afterGetSpriteIndex.Invoke(@params, retVal);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }

            return retVal;
        }
    }

    /// <summary>
    ///     Contains necessary information to create Hooks. Does not contain any hooks
    /// </summary>
    public static class Delegates
    {
        public delegate TMP_SpriteAsset get_defaultSpriteAsset_AfterArgs(TMP_SpriteAsset ret);

        public delegate void get_defaultSpriteAsset_BeforeArgs();

        public delegate TMP_SpriteAsset get_defaultSpriteAsset_WithArgs(Func<TMP_SpriteAsset> orig);

        public delegate Material GetDefaultSpriteMaterial_AfterArgs(Params_GetDefaultSpriteMaterial args, Material ret);

        public delegate void GetDefaultSpriteMaterial_BeforeArgs(Params_GetDefaultSpriteMaterial args);

        public delegate Material GetDefaultSpriteMaterial_WithArgs(Func<TMP_SpriteAsset, Material> orig,
            TMP_SpriteAsset self);

        public delegate int GetSpriteIndex_AfterArgs(Params_GetSpriteIndex args, int ret);

        public delegate void GetSpriteIndex_BeforeArgs(Params_GetSpriteIndex args);

        public delegate int GetSpriteIndex_WithArgs(Func<TMP_SpriteAsset, int, int> orig, TMP_SpriteAsset self,
            int hashCode);

        public delegate void OnEnable_AfterArgs(Params_OnEnable args);

        public delegate void OnEnable_BeforeArgs(Params_OnEnable args);

        public delegate void OnEnable_WithArgs(Action<TMP_SpriteAsset> orig, TMP_SpriteAsset self);

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
        public static event Delegates.get_defaultSpriteAsset_AfterArgs get_defaultSpriteAsset
        {
            add
            {
                HookHandler._afterget_defaultSpriteAsset += value;
                HookHandler.Hookget_defaultSpriteAsset();
            }
            remove => HookHandler._afterget_defaultSpriteAsset -= value;
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

        public static event Delegates.GetDefaultSpriteMaterial_AfterArgs GetDefaultSpriteMaterial
        {
            add
            {
                HookHandler._afterGetDefaultSpriteMaterial += value;
                HookHandler.HookGetDefaultSpriteMaterial();
            }
            remove => HookHandler._afterGetDefaultSpriteMaterial -= value;
        }

        public static event Delegates.GetSpriteIndex_AfterArgs GetSpriteIndex
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
        public static event Delegates.get_defaultSpriteAsset_WithArgs get_defaultSpriteAsset
        {
            add => HookEndpointManager.Add<Delegates.get_defaultSpriteAsset_WithArgs>(
                ReflectionHelper.GetMethodInfo(typeof(TMP_SpriteAsset), "get_defaultSpriteAsset", false), value);
            remove => HookEndpointManager.Remove<Delegates.get_defaultSpriteAsset_WithArgs>(
                ReflectionHelper.GetMethodInfo(typeof(TMP_SpriteAsset), "get_defaultSpriteAsset", false), value);
        }

        public static event Delegates.OnEnable_WithArgs OnEnable
        {
            add => HookEndpointManager.Add<Delegates.OnEnable_WithArgs>(
                ReflectionHelper.GetMethodInfo(typeof(TMP_SpriteAsset), "OnEnable"), value);
            remove => HookEndpointManager.Remove<Delegates.OnEnable_WithArgs>(
                ReflectionHelper.GetMethodInfo(typeof(TMP_SpriteAsset), "OnEnable"), value);
        }

        public static event Delegates.GetDefaultSpriteMaterial_WithArgs GetDefaultSpriteMaterial
        {
            add => HookEndpointManager.Add<Delegates.GetDefaultSpriteMaterial_WithArgs>(
                ReflectionHelper.GetMethodInfo(typeof(TMP_SpriteAsset), "GetDefaultSpriteMaterial"), value);
            remove => HookEndpointManager.Remove<Delegates.GetDefaultSpriteMaterial_WithArgs>(
                ReflectionHelper.GetMethodInfo(typeof(TMP_SpriteAsset), "GetDefaultSpriteMaterial"), value);
        }

        public static event Delegates.GetSpriteIndex_WithArgs GetSpriteIndex
        {
            add => HookEndpointManager.Add<Delegates.GetSpriteIndex_WithArgs>(
                ReflectionHelper.GetMethodInfo(typeof(TMP_SpriteAsset), "GetSpriteIndex"), value);
            remove => HookEndpointManager.Remove<Delegates.GetSpriteIndex_WithArgs>(
                ReflectionHelper.GetMethodInfo(typeof(TMP_SpriteAsset), "GetSpriteIndex"), value);
        }
    }
}