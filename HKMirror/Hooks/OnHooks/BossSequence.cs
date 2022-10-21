using MonoMod.RuntimeDetour;
using MonoMod.RuntimeDetour.HookGen;

namespace HKMirror.Hooks.OnHooks;

/// <summary>
/// Contains different types of On Hooks for BossSequence class.<br />
/// Contains hooks that aren't generated by monomod, and before and after orig hooks for easier hooking.
/// </summary>
public static class OnBossSequence
{
    internal static class HookHandler
    {
        private static List<string> HookedList = new List<string>();

        internal static void Hookget_Count()
        {
            if (!HookedList.Contains("get_Count"))
            {
                HookedList.Add("get_Count");
                new Hook(ReflectionHelper.GetMethodInfo(typeof(BossSequence), "get_Count", true), get_Count);
            }
        }

        internal static event Delegates.get_Count_BeforeArgs _beforeget_Count;
        internal static event Delegates.get_Count_AfterArgs _afterget_Count;

        private static int get_Count(Func<BossSequence, int> orig, BossSequence self)
        {
            Delegates.Params_get_Count @params = new()
            {
                self = self
            };
            if (_beforeget_Count != null)
            {
                foreach (Delegates.get_Count_BeforeArgs toInvoke in _beforeget_Count.GetInvocationList())
                {
                    try
                    {
                        _beforeget_Count?.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }
                }
            }

            self = @params.self;
            var retVal = orig(self);
            if (_afterget_Count != null)
            {
                foreach (Delegates.get_Count_AfterArgs toInvoke in _afterget_Count.GetInvocationList())
                {
                    try
                    {
                        retVal = _afterget_Count.Invoke(@params, retVal);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }
                }
            }

            return retVal;
        }

        internal static void HookGetSceneAt()
        {
            if (!HookedList.Contains("GetSceneAt"))
            {
                HookedList.Add("GetSceneAt");
                On.BossSequence.GetSceneAt += GetSceneAt;
            }
        }

        internal static event Delegates.GetSceneAt_BeforeArgs _beforeGetSceneAt;
        internal static event Delegates.GetSceneAt_AfterArgs _afterGetSceneAt;

        private static string GetSceneAt(On.BossSequence.orig_GetSceneAt orig, BossSequence self, int index)
        {
            Delegates.Params_GetSceneAt @params = new()
            {
                self = self, index = index
            };
            if (_beforeGetSceneAt != null)
            {
                foreach (Delegates.GetSceneAt_BeforeArgs toInvoke in _beforeGetSceneAt.GetInvocationList())
                {
                    try
                    {
                        _beforeGetSceneAt?.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }
                }
            }

            self = @params.self;
            index = @params.index;
            var retVal = orig(self, index);
            if (_afterGetSceneAt != null)
            {
                foreach (Delegates.GetSceneAt_AfterArgs toInvoke in _afterGetSceneAt.GetInvocationList())
                {
                    try
                    {
                        retVal = _afterGetSceneAt.Invoke(@params, retVal);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }
                }
            }

            return retVal;
        }

        internal static void HookGetSceneObjectName()
        {
            if (!HookedList.Contains("GetSceneObjectName"))
            {
                HookedList.Add("GetSceneObjectName");
                On.BossSequence.GetSceneObjectName += GetSceneObjectName;
            }
        }

        internal static event Delegates.GetSceneObjectName_BeforeArgs _beforeGetSceneObjectName;
        internal static event Delegates.GetSceneObjectName_AfterArgs _afterGetSceneObjectName;

        private static string GetSceneObjectName(On.BossSequence.orig_GetSceneObjectName orig, BossSequence self,
            int index)
        {
            Delegates.Params_GetSceneObjectName @params = new()
            {
                self = self, index = index
            };
            if (_beforeGetSceneObjectName != null)
            {
                foreach (Delegates.GetSceneObjectName_BeforeArgs toInvoke in
                         _beforeGetSceneObjectName.GetInvocationList())
                {
                    try
                    {
                        _beforeGetSceneObjectName?.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }
                }
            }

            self = @params.self;
            index = @params.index;
            var retVal = orig(self, index);
            if (_afterGetSceneObjectName != null)
            {
                foreach (Delegates.GetSceneObjectName_AfterArgs toInvoke in
                         _afterGetSceneObjectName.GetInvocationList())
                {
                    try
                    {
                        retVal = _afterGetSceneObjectName.Invoke(@params, retVal);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }
                }
            }

            return retVal;
        }

        internal static void HookCanLoad()
        {
            if (!HookedList.Contains("CanLoad"))
            {
                HookedList.Add("CanLoad");
                On.BossSequence.CanLoad += CanLoad;
            }
        }

        internal static event Delegates.CanLoad_BeforeArgs _beforeCanLoad;
        internal static event Delegates.CanLoad_AfterArgs _afterCanLoad;

        private static bool CanLoad(On.BossSequence.orig_CanLoad orig, BossSequence self, int index)
        {
            Delegates.Params_CanLoad @params = new()
            {
                self = self, index = index
            };
            if (_beforeCanLoad != null)
            {
                foreach (Delegates.CanLoad_BeforeArgs toInvoke in _beforeCanLoad.GetInvocationList())
                {
                    try
                    {
                        _beforeCanLoad?.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }
                }
            }

            self = @params.self;
            index = @params.index;
            var retVal = orig(self, index);
            if (_afterCanLoad != null)
            {
                foreach (Delegates.CanLoad_AfterArgs toInvoke in _afterCanLoad.GetInvocationList())
                {
                    try
                    {
                        retVal = _afterCanLoad.Invoke(@params, retVal);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }
                }
            }

            return retVal;
        }

        internal static void HookGetBossScene()
        {
            if (!HookedList.Contains("GetBossScene"))
            {
                HookedList.Add("GetBossScene");
                On.BossSequence.GetBossScene += GetBossScene;
            }
        }

        internal static event Delegates.GetBossScene_BeforeArgs _beforeGetBossScene;
        internal static event Delegates.GetBossScene_AfterArgs _afterGetBossScene;

        private static BossScene GetBossScene(On.BossSequence.orig_GetBossScene orig, BossSequence self, int index)
        {
            Delegates.Params_GetBossScene @params = new()
            {
                self = self, index = index
            };
            if (_beforeGetBossScene != null)
            {
                foreach (Delegates.GetBossScene_BeforeArgs toInvoke in _beforeGetBossScene.GetInvocationList())
                {
                    try
                    {
                        _beforeGetBossScene?.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }
                }
            }

            self = @params.self;
            index = @params.index;
            var retVal = orig(self, index);
            if (_afterGetBossScene != null)
            {
                foreach (Delegates.GetBossScene_AfterArgs toInvoke in _afterGetBossScene.GetInvocationList())
                {
                    try
                    {
                        retVal = _afterGetBossScene.Invoke(@params, retVal);
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
                On.BossSequence.IsUnlocked += IsUnlocked;
            }
        }

        internal static event Delegates.IsUnlocked_BeforeArgs _beforeIsUnlocked;
        internal static event Delegates.IsUnlocked_AfterArgs _afterIsUnlocked;

        private static bool IsUnlocked(On.BossSequence.orig_IsUnlocked orig, BossSequence self)
        {
            Delegates.Params_IsUnlocked @params = new()
            {
                self = self
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
            var retVal = orig(self);
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

        internal static void HookIsSceneHidden()
        {
            if (!HookedList.Contains("IsSceneHidden"))
            {
                HookedList.Add("IsSceneHidden");
                On.BossSequence.IsSceneHidden += IsSceneHidden;
            }
        }

        internal static event Delegates.IsSceneHidden_BeforeArgs _beforeIsSceneHidden;
        internal static event Delegates.IsSceneHidden_AfterArgs _afterIsSceneHidden;

        private static bool IsSceneHidden(On.BossSequence.orig_IsSceneHidden orig, BossSequence self, int index)
        {
            Delegates.Params_IsSceneHidden @params = new()
            {
                self = self, index = index
            };
            if (_beforeIsSceneHidden != null)
            {
                foreach (Delegates.IsSceneHidden_BeforeArgs toInvoke in _beforeIsSceneHidden.GetInvocationList())
                {
                    try
                    {
                        _beforeIsSceneHidden?.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }
                }
            }

            self = @params.self;
            index = @params.index;
            var retVal = orig(self, index);
            if (_afterIsSceneHidden != null)
            {
                foreach (Delegates.IsSceneHidden_AfterArgs toInvoke in _afterIsSceneHidden.GetInvocationList())
                {
                    try
                    {
                        retVal = _afterIsSceneHidden.Invoke(@params, retVal);
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
        public sealed class Params_get_Count
        {
            public BossSequence self;
        }

        public delegate void get_Count_BeforeArgs(Params_get_Count args);

        public delegate int get_Count_AfterArgs(Params_get_Count args, int ret);

        public delegate int get_Count_WithArgs(Func<BossSequence, int> orig, BossSequence self);

        public sealed class Params_GetSceneAt
        {
            public BossSequence self;
            public int index;
        }

        public delegate void GetSceneAt_BeforeArgs(Params_GetSceneAt args);

        public delegate string GetSceneAt_AfterArgs(Params_GetSceneAt args, string ret);

        public delegate string GetSceneAt_WithArgs(Func<BossSequence, int, string> orig, BossSequence self, int index);

        public sealed class Params_GetSceneObjectName
        {
            public BossSequence self;
            public int index;
        }

        public delegate void GetSceneObjectName_BeforeArgs(Params_GetSceneObjectName args);

        public delegate string GetSceneObjectName_AfterArgs(Params_GetSceneObjectName args, string ret);

        public delegate string GetSceneObjectName_WithArgs(Func<BossSequence, int, string> orig, BossSequence self,
            int index);

        public sealed class Params_CanLoad
        {
            public BossSequence self;
            public int index;
        }

        public delegate void CanLoad_BeforeArgs(Params_CanLoad args);

        public delegate bool CanLoad_AfterArgs(Params_CanLoad args, bool ret);

        public delegate bool CanLoad_WithArgs(Func<BossSequence, int, bool> orig, BossSequence self, int index);

        public sealed class Params_GetBossScene
        {
            public BossSequence self;
            public int index;
        }

        public delegate void GetBossScene_BeforeArgs(Params_GetBossScene args);

        public delegate BossScene GetBossScene_AfterArgs(Params_GetBossScene args, BossScene ret);

        public delegate BossScene GetBossScene_WithArgs(Func<BossSequence, int, BossScene> orig, BossSequence self,
            int index);

        public sealed class Params_IsUnlocked
        {
            public BossSequence self;
        }

        public delegate void IsUnlocked_BeforeArgs(Params_IsUnlocked args);

        public delegate bool IsUnlocked_AfterArgs(Params_IsUnlocked args, bool ret);

        public delegate bool IsUnlocked_WithArgs(Func<BossSequence, bool> orig, BossSequence self);

        public sealed class Params_IsSceneHidden
        {
            public BossSequence self;
            public int index;
        }

        public delegate void IsSceneHidden_BeforeArgs(Params_IsSceneHidden args);

        public delegate bool IsSceneHidden_AfterArgs(Params_IsSceneHidden args, bool ret);

        public delegate bool IsSceneHidden_WithArgs(Func<BossSequence, int, bool> orig, BossSequence self, int index);
    }

    /// <summary>
    /// Contains Hooks to that run code before orig(self) is called
    /// </summary>
    public static class BeforeOrig
    {
        public static event Delegates.get_Count_BeforeArgs get_Count
        {
            add
            {
                HookHandler._beforeget_Count += value;
                HookHandler.Hookget_Count();
            }
            remove => HookHandler._beforeget_Count -= value;
        }

        public static event Delegates.GetSceneAt_BeforeArgs GetSceneAt
        {
            add
            {
                HookHandler._beforeGetSceneAt += value;
                HookHandler.HookGetSceneAt();
            }
            remove => HookHandler._beforeGetSceneAt -= value;
        }

        public static event Delegates.GetSceneObjectName_BeforeArgs GetSceneObjectName
        {
            add
            {
                HookHandler._beforeGetSceneObjectName += value;
                HookHandler.HookGetSceneObjectName();
            }
            remove => HookHandler._beforeGetSceneObjectName -= value;
        }

        public static event Delegates.CanLoad_BeforeArgs CanLoad
        {
            add
            {
                HookHandler._beforeCanLoad += value;
                HookHandler.HookCanLoad();
            }
            remove => HookHandler._beforeCanLoad -= value;
        }

        public static event Delegates.GetBossScene_BeforeArgs GetBossScene
        {
            add
            {
                HookHandler._beforeGetBossScene += value;
                HookHandler.HookGetBossScene();
            }
            remove => HookHandler._beforeGetBossScene -= value;
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

        public static event Delegates.IsSceneHidden_BeforeArgs IsSceneHidden
        {
            add
            {
                HookHandler._beforeIsSceneHidden += value;
                HookHandler.HookIsSceneHidden();
            }
            remove => HookHandler._beforeIsSceneHidden -= value;
        }
    }

    /// <summary>
    /// Contains Hooks to that run code after orig(self) is called
    /// </summary>
    public static class AfterOrig
    {
        public static event Delegates.get_Count_AfterArgs get_Count
        {
            add
            {
                HookHandler._afterget_Count += value;
                HookHandler.Hookget_Count();
            }
            remove => HookHandler._afterget_Count -= value;
        }

        public static event Delegates.GetSceneAt_AfterArgs GetSceneAt
        {
            add
            {
                HookHandler._afterGetSceneAt += value;
                HookHandler.HookGetSceneAt();
            }
            remove => HookHandler._afterGetSceneAt -= value;
        }

        public static event Delegates.GetSceneObjectName_AfterArgs GetSceneObjectName
        {
            add
            {
                HookHandler._afterGetSceneObjectName += value;
                HookHandler.HookGetSceneObjectName();
            }
            remove => HookHandler._afterGetSceneObjectName -= value;
        }

        public static event Delegates.CanLoad_AfterArgs CanLoad
        {
            add
            {
                HookHandler._afterCanLoad += value;
                HookHandler.HookCanLoad();
            }
            remove => HookHandler._afterCanLoad -= value;
        }

        public static event Delegates.GetBossScene_AfterArgs GetBossScene
        {
            add
            {
                HookHandler._afterGetBossScene += value;
                HookHandler.HookGetBossScene();
            }
            remove => HookHandler._afterGetBossScene -= value;
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

        public static event Delegates.IsSceneHidden_AfterArgs IsSceneHidden
        {
            add
            {
                HookHandler._afterIsSceneHidden += value;
                HookHandler.HookIsSceneHidden();
            }
            remove => HookHandler._afterIsSceneHidden -= value;
        }
    }

    /// <summary>
    /// Contains all On Hooks, even those that aren't in the On namespace such as API generated functions and property getters/setters
    /// </summary>
    public static class WithOrig
    {
        public static event Delegates.get_Count_WithArgs get_Count
        {
            add => HookEndpointManager.Add<Delegates.get_Count_WithArgs>(
                ReflectionHelper.GetMethodInfo(typeof(BossSequence), "get_Count", true), value);
            remove => HookEndpointManager.Remove<Delegates.get_Count_WithArgs>(
                ReflectionHelper.GetMethodInfo(typeof(BossSequence), "get_Count", true), value);
        }

        public static event On.BossSequence.hook_GetSceneAt GetSceneAt
        {
            add => On.BossSequence.GetSceneAt += value;
            remove => On.BossSequence.GetSceneAt -= value;
        }

        public static event On.BossSequence.hook_GetSceneObjectName GetSceneObjectName
        {
            add => On.BossSequence.GetSceneObjectName += value;
            remove => On.BossSequence.GetSceneObjectName -= value;
        }

        public static event On.BossSequence.hook_CanLoad CanLoad
        {
            add => On.BossSequence.CanLoad += value;
            remove => On.BossSequence.CanLoad -= value;
        }

        public static event On.BossSequence.hook_GetBossScene GetBossScene
        {
            add => On.BossSequence.GetBossScene += value;
            remove => On.BossSequence.GetBossScene -= value;
        }

        public static event On.BossSequence.hook_IsUnlocked IsUnlocked
        {
            add => On.BossSequence.IsUnlocked += value;
            remove => On.BossSequence.IsUnlocked -= value;
        }

        public static event On.BossSequence.hook_IsSceneHidden IsSceneHidden
        {
            add => On.BossSequence.IsSceneHidden += value;
            remove => On.BossSequence.IsSceneHidden -= value;
        }
    }
}