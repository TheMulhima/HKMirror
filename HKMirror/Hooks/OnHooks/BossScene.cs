using MonoMod.RuntimeDetour;
using MonoMod.RuntimeDetour.HookGen;

namespace HKMirror.Hooks.OnHooks;

/// <summary>
/// Contains different types of On Hooks for BossScene class.<br />
/// Contains hooks that aren't generated by monomod, and before and after orig hooks for easier hooking.
/// </summary>
public static class OnBossScene
{
    internal static class HookHandler
    {
        private static List<string> HookedList = new List<string>();

        internal static void Hookget_DisplayIcon()
        {
            if (!HookedList.Contains("get_DisplayIcon"))
            {
                HookedList.Add("get_DisplayIcon");
                new Hook(ReflectionHelper.GetMethodInfo(typeof(BossScene), "get_DisplayIcon", true), get_DisplayIcon);
            }
        }

        internal static event Delegates.get_DisplayIcon_BeforeArgs _beforeget_DisplayIcon;
        internal static event Delegates.get_DisplayIcon_AfterArgs _afterget_DisplayIcon;

        private static UnityEngine.Sprite get_DisplayIcon(Func<BossScene, UnityEngine.Sprite> orig, BossScene self)
        {
            Delegates.Params_get_DisplayIcon @params = new()
            {
                self = self
            };
            if (_beforeget_DisplayIcon != null)
            {
                foreach (Delegates.get_DisplayIcon_BeforeArgs toInvoke in _beforeget_DisplayIcon.GetInvocationList())
                {
                    try
                    {
                        _beforeget_DisplayIcon?.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }
                }
            }

            self = @params.self;
            var retVal = orig(self);
            if (_afterget_DisplayIcon != null)
            {
                foreach (Delegates.get_DisplayIcon_AfterArgs toInvoke in _afterget_DisplayIcon.GetInvocationList())
                {
                    try
                    {
                        retVal = _afterget_DisplayIcon.Invoke(@params, retVal);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }
                }
            }

            return retVal;
        }

        internal static void Hookget_ForceAssetUnload()
        {
            if (!HookedList.Contains("get_ForceAssetUnload"))
            {
                HookedList.Add("get_ForceAssetUnload");
                new Hook(ReflectionHelper.GetMethodInfo(typeof(BossScene), "get_ForceAssetUnload", true),
                    get_ForceAssetUnload);
            }
        }

        internal static event Delegates.get_ForceAssetUnload_BeforeArgs _beforeget_ForceAssetUnload;
        internal static event Delegates.get_ForceAssetUnload_AfterArgs _afterget_ForceAssetUnload;

        private static bool get_ForceAssetUnload(Func<BossScene, bool> orig, BossScene self)
        {
            Delegates.Params_get_ForceAssetUnload @params = new()
            {
                self = self
            };
            if (_beforeget_ForceAssetUnload != null)
            {
                foreach (Delegates.get_ForceAssetUnload_BeforeArgs toInvoke in _beforeget_ForceAssetUnload
                             .GetInvocationList())
                {
                    try
                    {
                        _beforeget_ForceAssetUnload?.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }
                }
            }

            self = @params.self;
            var retVal = orig(self);
            if (_afterget_ForceAssetUnload != null)
            {
                foreach (Delegates.get_ForceAssetUnload_AfterArgs toInvoke in _afterget_ForceAssetUnload
                             .GetInvocationList())
                {
                    try
                    {
                        retVal = _afterget_ForceAssetUnload.Invoke(@params, retVal);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }
                }
            }

            return retVal;
        }

        internal static void Hookget_Tier1Scene()
        {
            if (!HookedList.Contains("get_Tier1Scene"))
            {
                HookedList.Add("get_Tier1Scene");
                new Hook(ReflectionHelper.GetMethodInfo(typeof(BossScene), "get_Tier1Scene", true), get_Tier1Scene);
            }
        }

        internal static event Delegates.get_Tier1Scene_BeforeArgs _beforeget_Tier1Scene;
        internal static event Delegates.get_Tier1Scene_AfterArgs _afterget_Tier1Scene;

        private static string get_Tier1Scene(Func<BossScene, string> orig, BossScene self)
        {
            Delegates.Params_get_Tier1Scene @params = new()
            {
                self = self
            };
            if (_beforeget_Tier1Scene != null)
            {
                foreach (Delegates.get_Tier1Scene_BeforeArgs toInvoke in _beforeget_Tier1Scene.GetInvocationList())
                {
                    try
                    {
                        _beforeget_Tier1Scene?.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }
                }
            }

            self = @params.self;
            var retVal = orig(self);
            if (_afterget_Tier1Scene != null)
            {
                foreach (Delegates.get_Tier1Scene_AfterArgs toInvoke in _afterget_Tier1Scene.GetInvocationList())
                {
                    try
                    {
                        retVal = _afterget_Tier1Scene.Invoke(@params, retVal);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }
                }
            }

            return retVal;
        }

        internal static void Hookget_Tier2Scene()
        {
            if (!HookedList.Contains("get_Tier2Scene"))
            {
                HookedList.Add("get_Tier2Scene");
                new Hook(ReflectionHelper.GetMethodInfo(typeof(BossScene), "get_Tier2Scene", true), get_Tier2Scene);
            }
        }

        internal static event Delegates.get_Tier2Scene_BeforeArgs _beforeget_Tier2Scene;
        internal static event Delegates.get_Tier2Scene_AfterArgs _afterget_Tier2Scene;

        private static string get_Tier2Scene(Func<BossScene, string> orig, BossScene self)
        {
            Delegates.Params_get_Tier2Scene @params = new()
            {
                self = self
            };
            if (_beforeget_Tier2Scene != null)
            {
                foreach (Delegates.get_Tier2Scene_BeforeArgs toInvoke in _beforeget_Tier2Scene.GetInvocationList())
                {
                    try
                    {
                        _beforeget_Tier2Scene?.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }
                }
            }

            self = @params.self;
            var retVal = orig(self);
            if (_afterget_Tier2Scene != null)
            {
                foreach (Delegates.get_Tier2Scene_AfterArgs toInvoke in _afterget_Tier2Scene.GetInvocationList())
                {
                    try
                    {
                        retVal = _afterget_Tier2Scene.Invoke(@params, retVal);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }
                }
            }

            return retVal;
        }

        internal static void Hookget_Tier3Scene()
        {
            if (!HookedList.Contains("get_Tier3Scene"))
            {
                HookedList.Add("get_Tier3Scene");
                new Hook(ReflectionHelper.GetMethodInfo(typeof(BossScene), "get_Tier3Scene", true), get_Tier3Scene);
            }
        }

        internal static event Delegates.get_Tier3Scene_BeforeArgs _beforeget_Tier3Scene;
        internal static event Delegates.get_Tier3Scene_AfterArgs _afterget_Tier3Scene;

        private static string get_Tier3Scene(Func<BossScene, string> orig, BossScene self)
        {
            Delegates.Params_get_Tier3Scene @params = new()
            {
                self = self
            };
            if (_beforeget_Tier3Scene != null)
            {
                foreach (Delegates.get_Tier3Scene_BeforeArgs toInvoke in _beforeget_Tier3Scene.GetInvocationList())
                {
                    try
                    {
                        _beforeget_Tier3Scene?.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }
                }
            }

            self = @params.self;
            var retVal = orig(self);
            if (_afterget_Tier3Scene != null)
            {
                foreach (Delegates.get_Tier3Scene_AfterArgs toInvoke in _afterget_Tier3Scene.GetInvocationList())
                {
                    try
                    {
                        retVal = _afterget_Tier3Scene.Invoke(@params, retVal);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }
                }
            }

            return retVal;
        }

        internal static void HookIsUnlocked()
        {
            if (!HookedList.Contains("IsUnlocked"))
            {
                HookedList.Add("IsUnlocked");
                On.BossScene.IsUnlocked += IsUnlocked;
            }
        }

        internal static event Delegates.IsUnlocked_BeforeArgs _beforeIsUnlocked;
        internal static event Delegates.IsUnlocked_AfterArgs _afterIsUnlocked;

        private static bool IsUnlocked(On.BossScene.orig_IsUnlocked orig, BossScene self, BossSceneCheckSource source)
        {
            Delegates.Params_IsUnlocked @params = new()
            {
                self = self, source = source
            };
            if (_beforeIsUnlocked != null)
            {
                foreach (Delegates.IsUnlocked_BeforeArgs toInvoke in _beforeIsUnlocked.GetInvocationList())
                {
                    try
                    {
                        _beforeIsUnlocked?.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }
                }
            }

            self = @params.self;
            source = @params.source;
            var retVal = orig(self, source);
            if (_afterIsUnlocked != null)
            {
                foreach (Delegates.IsUnlocked_AfterArgs toInvoke in _afterIsUnlocked.GetInvocationList())
                {
                    try
                    {
                        retVal = _afterIsUnlocked.Invoke(@params, retVal);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }
                }
            }

            return retVal;
        }

        internal static void HookIsUnlockedSelf()
        {
            if (!HookedList.Contains("IsUnlockedSelf"))
            {
                HookedList.Add("IsUnlockedSelf");
                On.BossScene.IsUnlockedSelf += IsUnlockedSelf;
            }
        }

        internal static event Delegates.IsUnlockedSelf_BeforeArgs _beforeIsUnlockedSelf;
        internal static event Delegates.IsUnlockedSelf_AfterArgs _afterIsUnlockedSelf;

        private static bool IsUnlockedSelf(On.BossScene.orig_IsUnlockedSelf orig, BossScene self,
            BossSceneCheckSource source)
        {
            Delegates.Params_IsUnlockedSelf @params = new()
            {
                self = self, source = source
            };
            if (_beforeIsUnlockedSelf != null)
            {
                foreach (Delegates.IsUnlockedSelf_BeforeArgs toInvoke in _beforeIsUnlockedSelf.GetInvocationList())
                {
                    try
                    {
                        _beforeIsUnlockedSelf?.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }
                }
            }

            self = @params.self;
            source = @params.source;
            var retVal = orig(self, source);
            if (_afterIsUnlockedSelf != null)
            {
                foreach (Delegates.IsUnlockedSelf_AfterArgs toInvoke in _afterIsUnlockedSelf.GetInvocationList())
                {
                    try
                    {
                        retVal = _afterIsUnlockedSelf.Invoke(@params, retVal);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }
                }
            }

            return retVal;
        }
    }

    /// <summary>
    /// Contains necessary information to create Hooks. Does not contain any hooks
    /// </summary>
    public static class Delegates
    {
        public sealed class Params_get_DisplayIcon
        {
            public BossScene self;
        }

        public delegate void get_DisplayIcon_BeforeArgs(Params_get_DisplayIcon args);

        public delegate UnityEngine.Sprite get_DisplayIcon_AfterArgs(Params_get_DisplayIcon args,
            UnityEngine.Sprite ret);

        public delegate UnityEngine.Sprite get_DisplayIcon_WithArgs(Func<BossScene, UnityEngine.Sprite> orig,
            BossScene self);

        public sealed class Params_get_ForceAssetUnload
        {
            public BossScene self;
        }

        public delegate void get_ForceAssetUnload_BeforeArgs(Params_get_ForceAssetUnload args);

        public delegate bool get_ForceAssetUnload_AfterArgs(Params_get_ForceAssetUnload args, bool ret);

        public delegate bool get_ForceAssetUnload_WithArgs(Func<BossScene, bool> orig, BossScene self);

        public sealed class Params_get_Tier1Scene
        {
            public BossScene self;
        }

        public delegate void get_Tier1Scene_BeforeArgs(Params_get_Tier1Scene args);

        public delegate string get_Tier1Scene_AfterArgs(Params_get_Tier1Scene args, string ret);

        public delegate string get_Tier1Scene_WithArgs(Func<BossScene, string> orig, BossScene self);

        public sealed class Params_get_Tier2Scene
        {
            public BossScene self;
        }

        public delegate void get_Tier2Scene_BeforeArgs(Params_get_Tier2Scene args);

        public delegate string get_Tier2Scene_AfterArgs(Params_get_Tier2Scene args, string ret);

        public delegate string get_Tier2Scene_WithArgs(Func<BossScene, string> orig, BossScene self);

        public sealed class Params_get_Tier3Scene
        {
            public BossScene self;
        }

        public delegate void get_Tier3Scene_BeforeArgs(Params_get_Tier3Scene args);

        public delegate string get_Tier3Scene_AfterArgs(Params_get_Tier3Scene args, string ret);

        public delegate string get_Tier3Scene_WithArgs(Func<BossScene, string> orig, BossScene self);

        public sealed class Params_IsUnlocked
        {
            public BossScene self;
            public BossSceneCheckSource source;
        }

        public delegate void IsUnlocked_BeforeArgs(Params_IsUnlocked args);

        public delegate bool IsUnlocked_AfterArgs(Params_IsUnlocked args, bool ret);

        public delegate bool IsUnlocked_WithArgs(Func<BossScene, BossSceneCheckSource, bool> orig, BossScene self,
            BossSceneCheckSource source);

        public sealed class Params_IsUnlockedSelf
        {
            public BossScene self;
            public BossSceneCheckSource source;
        }

        public delegate void IsUnlockedSelf_BeforeArgs(Params_IsUnlockedSelf args);

        public delegate bool IsUnlockedSelf_AfterArgs(Params_IsUnlockedSelf args, bool ret);

        public delegate bool IsUnlockedSelf_WithArgs(Func<BossScene, BossSceneCheckSource, bool> orig, BossScene self,
            BossSceneCheckSource source);
    }

    /// <summary>
    /// Contains Hooks to that run code before orig(self) is called
    /// </summary>
    public static class BeforeOrig
    {
        public static event Delegates.get_DisplayIcon_BeforeArgs get_DisplayIcon
        {
            add
            {
                HookHandler._beforeget_DisplayIcon += value;
                HookHandler.Hookget_DisplayIcon();
            }
            remove => HookHandler._beforeget_DisplayIcon -= value;
        }

        public static event Delegates.get_ForceAssetUnload_BeforeArgs get_ForceAssetUnload
        {
            add
            {
                HookHandler._beforeget_ForceAssetUnload += value;
                HookHandler.Hookget_ForceAssetUnload();
            }
            remove => HookHandler._beforeget_ForceAssetUnload -= value;
        }

        public static event Delegates.get_Tier1Scene_BeforeArgs get_Tier1Scene
        {
            add
            {
                HookHandler._beforeget_Tier1Scene += value;
                HookHandler.Hookget_Tier1Scene();
            }
            remove => HookHandler._beforeget_Tier1Scene -= value;
        }

        public static event Delegates.get_Tier2Scene_BeforeArgs get_Tier2Scene
        {
            add
            {
                HookHandler._beforeget_Tier2Scene += value;
                HookHandler.Hookget_Tier2Scene();
            }
            remove => HookHandler._beforeget_Tier2Scene -= value;
        }

        public static event Delegates.get_Tier3Scene_BeforeArgs get_Tier3Scene
        {
            add
            {
                HookHandler._beforeget_Tier3Scene += value;
                HookHandler.Hookget_Tier3Scene();
            }
            remove => HookHandler._beforeget_Tier3Scene -= value;
        }

        public static event Delegates.IsUnlocked_BeforeArgs IsUnlocked
        {
            add
            {
                HookHandler._beforeIsUnlocked += value;
                HookHandler.HookIsUnlocked();
            }
            remove => HookHandler._beforeIsUnlocked -= value;
        }

        public static event Delegates.IsUnlockedSelf_BeforeArgs IsUnlockedSelf
        {
            add
            {
                HookHandler._beforeIsUnlockedSelf += value;
                HookHandler.HookIsUnlockedSelf();
            }
            remove => HookHandler._beforeIsUnlockedSelf -= value;
        }
    }

    /// <summary>
    /// Contains Hooks to that run code after orig(self) is called
    /// </summary>
    public static class AfterOrig
    {
        public static event Delegates.get_DisplayIcon_AfterArgs get_DisplayIcon
        {
            add
            {
                HookHandler._afterget_DisplayIcon += value;
                HookHandler.Hookget_DisplayIcon();
            }
            remove => HookHandler._afterget_DisplayIcon -= value;
        }

        public static event Delegates.get_ForceAssetUnload_AfterArgs get_ForceAssetUnload
        {
            add
            {
                HookHandler._afterget_ForceAssetUnload += value;
                HookHandler.Hookget_ForceAssetUnload();
            }
            remove => HookHandler._afterget_ForceAssetUnload -= value;
        }

        public static event Delegates.get_Tier1Scene_AfterArgs get_Tier1Scene
        {
            add
            {
                HookHandler._afterget_Tier1Scene += value;
                HookHandler.Hookget_Tier1Scene();
            }
            remove => HookHandler._afterget_Tier1Scene -= value;
        }

        public static event Delegates.get_Tier2Scene_AfterArgs get_Tier2Scene
        {
            add
            {
                HookHandler._afterget_Tier2Scene += value;
                HookHandler.Hookget_Tier2Scene();
            }
            remove => HookHandler._afterget_Tier2Scene -= value;
        }

        public static event Delegates.get_Tier3Scene_AfterArgs get_Tier3Scene
        {
            add
            {
                HookHandler._afterget_Tier3Scene += value;
                HookHandler.Hookget_Tier3Scene();
            }
            remove => HookHandler._afterget_Tier3Scene -= value;
        }

        public static event Delegates.IsUnlocked_AfterArgs IsUnlocked
        {
            add
            {
                HookHandler._afterIsUnlocked += value;
                HookHandler.HookIsUnlocked();
            }
            remove => HookHandler._afterIsUnlocked -= value;
        }

        public static event Delegates.IsUnlockedSelf_AfterArgs IsUnlockedSelf
        {
            add
            {
                HookHandler._afterIsUnlockedSelf += value;
                HookHandler.HookIsUnlockedSelf();
            }
            remove => HookHandler._afterIsUnlockedSelf -= value;
        }
    }

    /// <summary>
    /// Contains all On Hooks, even those that aren't in the On namespace such as API generated functions and property getters/setters
    /// </summary>
    public static class WithOrig
    {
        public static event Delegates.get_DisplayIcon_WithArgs get_DisplayIcon
        {
            add => HookEndpointManager.Add<Delegates.get_DisplayIcon_WithArgs>(
                ReflectionHelper.GetMethodInfo(typeof(BossScene), "get_DisplayIcon", true), value);
            remove => HookEndpointManager.Remove<Delegates.get_DisplayIcon_WithArgs>(
                ReflectionHelper.GetMethodInfo(typeof(BossScene), "get_DisplayIcon", true), value);
        }

        public static event Delegates.get_ForceAssetUnload_WithArgs get_ForceAssetUnload
        {
            add => HookEndpointManager.Add<Delegates.get_ForceAssetUnload_WithArgs>(
                ReflectionHelper.GetMethodInfo(typeof(BossScene), "get_ForceAssetUnload", true), value);
            remove => HookEndpointManager.Remove<Delegates.get_ForceAssetUnload_WithArgs>(
                ReflectionHelper.GetMethodInfo(typeof(BossScene), "get_ForceAssetUnload", true), value);
        }

        public static event Delegates.get_Tier1Scene_WithArgs get_Tier1Scene
        {
            add => HookEndpointManager.Add<Delegates.get_Tier1Scene_WithArgs>(
                ReflectionHelper.GetMethodInfo(typeof(BossScene), "get_Tier1Scene", true), value);
            remove => HookEndpointManager.Remove<Delegates.get_Tier1Scene_WithArgs>(
                ReflectionHelper.GetMethodInfo(typeof(BossScene), "get_Tier1Scene", true), value);
        }

        public static event Delegates.get_Tier2Scene_WithArgs get_Tier2Scene
        {
            add => HookEndpointManager.Add<Delegates.get_Tier2Scene_WithArgs>(
                ReflectionHelper.GetMethodInfo(typeof(BossScene), "get_Tier2Scene", true), value);
            remove => HookEndpointManager.Remove<Delegates.get_Tier2Scene_WithArgs>(
                ReflectionHelper.GetMethodInfo(typeof(BossScene), "get_Tier2Scene", true), value);
        }

        public static event Delegates.get_Tier3Scene_WithArgs get_Tier3Scene
        {
            add => HookEndpointManager.Add<Delegates.get_Tier3Scene_WithArgs>(
                ReflectionHelper.GetMethodInfo(typeof(BossScene), "get_Tier3Scene", true), value);
            remove => HookEndpointManager.Remove<Delegates.get_Tier3Scene_WithArgs>(
                ReflectionHelper.GetMethodInfo(typeof(BossScene), "get_Tier3Scene", true), value);
        }

        public static event On.BossScene.hook_IsUnlocked IsUnlocked
        {
            add => On.BossScene.IsUnlocked += value;
            remove => On.BossScene.IsUnlocked -= value;
        }

        public static event On.BossScene.hook_IsUnlockedSelf IsUnlockedSelf
        {
            add => On.BossScene.IsUnlockedSelf += value;
            remove => On.BossScene.IsUnlockedSelf -= value;
        }
    }
}