using MonoMod.RuntimeDetour;
using MonoMod.RuntimeDetour.HookGen;

namespace HKMirror.Hooks.OnHooks;

/// <summary>
/// Contains different types of On Hooks for tk2dSpriteCollection class.<br />
/// Contains hooks that aren't generated by monomod, and before and after orig hooks for easier hooking.
/// </summary>
public static class Ontk2dSpriteCollection
{
    internal static class HookHandler
    {
        private static List<string> HookedList = new List<string>();

        internal static void Hookget_DoNotUse__TextureRefs()
        {
            if (!HookedList.Contains("get_DoNotUse__TextureRefs"))
            {
                HookedList.Add("get_DoNotUse__TextureRefs");
                new Hook(
                    ReflectionHelper.GetMethodInfo(typeof(tk2dSpriteCollection), "get_DoNotUse__TextureRefs", true),
                    get_DoNotUse__TextureRefs);
            }
        }

        internal static event Delegates.get_DoNotUse__TextureRefs_BeforeArgs _beforeget_DoNotUse__TextureRefs;
        internal static event Delegates.get_DoNotUse__TextureRefs_AfterArgs _afterget_DoNotUse__TextureRefs;

        private static UnityEngine.Texture2D[] get_DoNotUse__TextureRefs(
            Func<tk2dSpriteCollection, UnityEngine.Texture2D[]> orig, tk2dSpriteCollection self)
        {
            Delegates.Params_get_DoNotUse__TextureRefs @params = new()
            {
                self = self
            };
            if (_beforeget_DoNotUse__TextureRefs != null)
            {
                foreach (Delegates.get_DoNotUse__TextureRefs_BeforeArgs toInvoke in _beforeget_DoNotUse__TextureRefs
                             .GetInvocationList())
                {
                    try
                    {
                        _beforeget_DoNotUse__TextureRefs?.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }
                }
            }

            self = @params.self;
            var retVal = orig(self);
            if (_afterget_DoNotUse__TextureRefs != null)
            {
                foreach (Delegates.get_DoNotUse__TextureRefs_AfterArgs toInvoke in _afterget_DoNotUse__TextureRefs
                             .GetInvocationList())
                {
                    try
                    {
                        retVal = _afterget_DoNotUse__TextureRefs.Invoke(@params, retVal);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }
                }
            }

            return retVal;
        }

        internal static void Hookset_DoNotUse__TextureRefs()
        {
            if (!HookedList.Contains("set_DoNotUse__TextureRefs"))
            {
                HookedList.Add("set_DoNotUse__TextureRefs");
                new Hook(
                    ReflectionHelper.GetMethodInfo(typeof(tk2dSpriteCollection), "set_DoNotUse__TextureRefs", true),
                    set_DoNotUse__TextureRefs);
            }
        }

        internal static event Delegates.set_DoNotUse__TextureRefs_BeforeArgs _beforeset_DoNotUse__TextureRefs;
        internal static event Delegates.set_DoNotUse__TextureRefs_AfterArgs _afterset_DoNotUse__TextureRefs;

        private static void set_DoNotUse__TextureRefs(Action<tk2dSpriteCollection, UnityEngine.Texture2D[]> orig,
            tk2dSpriteCollection self, UnityEngine.Texture2D[] value)
        {
            Delegates.Params_set_DoNotUse__TextureRefs @params = new()
            {
                self = self, value = value
            };
            if (_beforeset_DoNotUse__TextureRefs != null)
            {
                foreach (Delegates.set_DoNotUse__TextureRefs_BeforeArgs toInvoke in _beforeset_DoNotUse__TextureRefs
                             .GetInvocationList())
                {
                    try
                    {
                        _beforeset_DoNotUse__TextureRefs?.Invoke(@params);
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
            if (_afterset_DoNotUse__TextureRefs != null)
            {
                foreach (Delegates.set_DoNotUse__TextureRefs_AfterArgs toInvoke in _afterset_DoNotUse__TextureRefs
                             .GetInvocationList())
                {
                    try
                    {
                        _afterset_DoNotUse__TextureRefs.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }
                }
            }
        }

        internal static void Hookget_HasPlatformData()
        {
            if (!HookedList.Contains("get_HasPlatformData"))
            {
                HookedList.Add("get_HasPlatformData");
                new Hook(ReflectionHelper.GetMethodInfo(typeof(tk2dSpriteCollection), "get_HasPlatformData", true),
                    get_HasPlatformData);
            }
        }

        internal static event Delegates.get_HasPlatformData_BeforeArgs _beforeget_HasPlatformData;
        internal static event Delegates.get_HasPlatformData_AfterArgs _afterget_HasPlatformData;

        private static bool get_HasPlatformData(Func<tk2dSpriteCollection, bool> orig, tk2dSpriteCollection self)
        {
            Delegates.Params_get_HasPlatformData @params = new()
            {
                self = self
            };
            if (_beforeget_HasPlatformData != null)
            {
                foreach (Delegates.get_HasPlatformData_BeforeArgs toInvoke in _beforeget_HasPlatformData
                             .GetInvocationList())
                {
                    try
                    {
                        _beforeget_HasPlatformData?.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }
                }
            }

            self = @params.self;
            var retVal = orig(self);
            if (_afterget_HasPlatformData != null)
            {
                foreach (Delegates.get_HasPlatformData_AfterArgs toInvoke in
                         _afterget_HasPlatformData.GetInvocationList())
                {
                    try
                    {
                        retVal = _afterget_HasPlatformData.Invoke(@params, retVal);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }
                }
            }

            return retVal;
        }

        internal static void HookUpgrade()
        {
            if (!HookedList.Contains("Upgrade"))
            {
                HookedList.Add("Upgrade");
                On.tk2dSpriteCollection.Upgrade += Upgrade;
            }
        }

        internal static event Delegates.Upgrade_BeforeArgs _beforeUpgrade;
        internal static event Delegates.Upgrade_AfterArgs _afterUpgrade;

        private static void Upgrade(On.tk2dSpriteCollection.orig_Upgrade orig, tk2dSpriteCollection self)
        {
            Delegates.Params_Upgrade @params = new()
            {
                self = self
            };
            if (_beforeUpgrade != null)
            {
                foreach (Delegates.Upgrade_BeforeArgs toInvoke in _beforeUpgrade.GetInvocationList())
                {
                    try
                    {
                        _beforeUpgrade?.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }
                }
            }

            self = @params.self;
            orig(self);
            if (_afterUpgrade != null)
            {
                foreach (Delegates.Upgrade_AfterArgs toInvoke in _afterUpgrade.GetInvocationList())
                {
                    try
                    {
                        _afterUpgrade.Invoke(@params);
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
        public sealed class Params_get_DoNotUse__TextureRefs
        {
            public tk2dSpriteCollection self;
        }

        public delegate void get_DoNotUse__TextureRefs_BeforeArgs(Params_get_DoNotUse__TextureRefs args);

        public delegate UnityEngine.Texture2D[] get_DoNotUse__TextureRefs_AfterArgs(
            Params_get_DoNotUse__TextureRefs args, UnityEngine.Texture2D[] ret);

        public delegate UnityEngine.Texture2D[] get_DoNotUse__TextureRefs_WithArgs(
            Func<tk2dSpriteCollection, UnityEngine.Texture2D[]> orig, tk2dSpriteCollection self);

        public sealed class Params_set_DoNotUse__TextureRefs
        {
            public tk2dSpriteCollection self;
            public UnityEngine.Texture2D[] value;
        }

        public delegate void set_DoNotUse__TextureRefs_BeforeArgs(Params_set_DoNotUse__TextureRefs args);

        public delegate void set_DoNotUse__TextureRefs_AfterArgs(Params_set_DoNotUse__TextureRefs args);

        public delegate void set_DoNotUse__TextureRefs_WithArgs(
            Action<tk2dSpriteCollection, UnityEngine.Texture2D[]> orig, tk2dSpriteCollection self,
            UnityEngine.Texture2D[] value);

        public sealed class Params_get_HasPlatformData
        {
            public tk2dSpriteCollection self;
        }

        public delegate void get_HasPlatformData_BeforeArgs(Params_get_HasPlatformData args);

        public delegate bool get_HasPlatformData_AfterArgs(Params_get_HasPlatformData args, bool ret);

        public delegate bool get_HasPlatformData_WithArgs(Func<tk2dSpriteCollection, bool> orig,
            tk2dSpriteCollection self);

        public sealed class Params_Upgrade
        {
            public tk2dSpriteCollection self;
        }

        public delegate void Upgrade_BeforeArgs(Params_Upgrade args);

        public delegate void Upgrade_AfterArgs(Params_Upgrade args);

        public delegate void Upgrade_WithArgs(Action<tk2dSpriteCollection> orig, tk2dSpriteCollection self);
    }

    /// <summary>
    /// Contains Hooks to that run code before orig(self) is called
    /// </summary>
    public static class BeforeOrig
    {
        public static event Delegates.get_DoNotUse__TextureRefs_BeforeArgs get_DoNotUse__TextureRefs
        {
            add
            {
                HookHandler._beforeget_DoNotUse__TextureRefs += value;
                HookHandler.Hookget_DoNotUse__TextureRefs();
            }
            remove => HookHandler._beforeget_DoNotUse__TextureRefs -= value;
        }

        public static event Delegates.set_DoNotUse__TextureRefs_BeforeArgs set_DoNotUse__TextureRefs
        {
            add
            {
                HookHandler._beforeset_DoNotUse__TextureRefs += value;
                HookHandler.Hookset_DoNotUse__TextureRefs();
            }
            remove => HookHandler._beforeset_DoNotUse__TextureRefs -= value;
        }

        public static event Delegates.get_HasPlatformData_BeforeArgs get_HasPlatformData
        {
            add
            {
                HookHandler._beforeget_HasPlatformData += value;
                HookHandler.Hookget_HasPlatformData();
            }
            remove => HookHandler._beforeget_HasPlatformData -= value;
        }

        public static event Delegates.Upgrade_BeforeArgs Upgrade
        {
            add
            {
                HookHandler._beforeUpgrade += value;
                HookHandler.HookUpgrade();
            }
            remove => HookHandler._beforeUpgrade -= value;
        }
    }

    /// <summary>
    /// Contains Hooks to that run code after orig(self) is called
    /// </summary>
    public static class AfterOrig
    {
        public static event Delegates.get_DoNotUse__TextureRefs_AfterArgs get_DoNotUse__TextureRefs
        {
            add
            {
                HookHandler._afterget_DoNotUse__TextureRefs += value;
                HookHandler.Hookget_DoNotUse__TextureRefs();
            }
            remove => HookHandler._afterget_DoNotUse__TextureRefs -= value;
        }

        public static event Delegates.set_DoNotUse__TextureRefs_AfterArgs set_DoNotUse__TextureRefs
        {
            add
            {
                HookHandler._afterset_DoNotUse__TextureRefs += value;
                HookHandler.Hookset_DoNotUse__TextureRefs();
            }
            remove => HookHandler._afterset_DoNotUse__TextureRefs -= value;
        }

        public static event Delegates.get_HasPlatformData_AfterArgs get_HasPlatformData
        {
            add
            {
                HookHandler._afterget_HasPlatformData += value;
                HookHandler.Hookget_HasPlatformData();
            }
            remove => HookHandler._afterget_HasPlatformData -= value;
        }

        public static event Delegates.Upgrade_AfterArgs Upgrade
        {
            add
            {
                HookHandler._afterUpgrade += value;
                HookHandler.HookUpgrade();
            }
            remove => HookHandler._afterUpgrade -= value;
        }
    }

    /// <summary>
    /// Contains all On Hooks, even those that aren't in the On namespace such as API generated functions and property getters/setters
    /// </summary>
    public static class WithOrig
    {
        public static event Delegates.get_DoNotUse__TextureRefs_WithArgs get_DoNotUse__TextureRefs
        {
            add => HookEndpointManager.Add<Delegates.get_DoNotUse__TextureRefs_WithArgs>(
                ReflectionHelper.GetMethodInfo(typeof(tk2dSpriteCollection), "get_DoNotUse__TextureRefs", true), value);
            remove => HookEndpointManager.Remove<Delegates.get_DoNotUse__TextureRefs_WithArgs>(
                ReflectionHelper.GetMethodInfo(typeof(tk2dSpriteCollection), "get_DoNotUse__TextureRefs", true), value);
        }

        public static event Delegates.set_DoNotUse__TextureRefs_WithArgs set_DoNotUse__TextureRefs
        {
            add => HookEndpointManager.Add<Delegates.set_DoNotUse__TextureRefs_WithArgs>(
                ReflectionHelper.GetMethodInfo(typeof(tk2dSpriteCollection), "set_DoNotUse__TextureRefs", true), value);
            remove => HookEndpointManager.Remove<Delegates.set_DoNotUse__TextureRefs_WithArgs>(
                ReflectionHelper.GetMethodInfo(typeof(tk2dSpriteCollection), "set_DoNotUse__TextureRefs", true), value);
        }

        public static event Delegates.get_HasPlatformData_WithArgs get_HasPlatformData
        {
            add => HookEndpointManager.Add<Delegates.get_HasPlatformData_WithArgs>(
                ReflectionHelper.GetMethodInfo(typeof(tk2dSpriteCollection), "get_HasPlatformData", true), value);
            remove => HookEndpointManager.Remove<Delegates.get_HasPlatformData_WithArgs>(
                ReflectionHelper.GetMethodInfo(typeof(tk2dSpriteCollection), "get_HasPlatformData", true), value);
        }

        public static event On.tk2dSpriteCollection.hook_Upgrade Upgrade
        {
            add => On.tk2dSpriteCollection.Upgrade += value;
            remove => On.tk2dSpriteCollection.Upgrade -= value;
        }
    }
}