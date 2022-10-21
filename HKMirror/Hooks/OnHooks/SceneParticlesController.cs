using MonoMod.RuntimeDetour;
using MonoMod.RuntimeDetour.HookGen;

namespace HKMirror.Hooks.OnHooks;

/// <summary>
/// Contains different types of On Hooks for SceneParticlesController class.<br />
/// Contains hooks that aren't generated by monomod, and before and after orig hooks for easier hooking.
/// </summary>
public static class OnSceneParticlesController
{
    internal static class HookHandler
    {
        private static List<string> HookedList = new List<string>();

        internal static void HookSceneInit()
        {
            if (!HookedList.Contains("SceneInit"))
            {
                HookedList.Add("SceneInit");
                On.SceneParticlesController.SceneInit += SceneInit;
            }
        }

        internal static event Delegates.SceneInit_BeforeArgs _beforeSceneInit;
        internal static event Delegates.SceneInit_AfterArgs _afterSceneInit;

        private static void SceneInit(On.SceneParticlesController.orig_SceneInit orig, SceneParticlesController self)
        {
            Delegates.Params_SceneInit @params = new()
            {
                self = self
            };
            if (_beforeSceneInit != null)
            {
                foreach (Delegates.SceneInit_BeforeArgs toInvoke in _beforeSceneInit.GetInvocationList())
                {
                    try
                    {
                        _beforeSceneInit?.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }
                }
            }

            self = @params.self;
            orig(self);
            if (_afterSceneInit != null)
            {
                foreach (Delegates.SceneInit_AfterArgs toInvoke in _afterSceneInit.GetInvocationList())
                {
                    try
                    {
                        _afterSceneInit.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }
                }
            }
        }

        internal static void HookEnableParticles()
        {
            if (!HookedList.Contains("EnableParticles"))
            {
                HookedList.Add("EnableParticles");
                On.SceneParticlesController.EnableParticles += EnableParticles;
            }
        }

        internal static event Delegates.EnableParticles_BeforeArgs _beforeEnableParticles;
        internal static event Delegates.EnableParticles_AfterArgs _afterEnableParticles;

        private static void EnableParticles(On.SceneParticlesController.orig_EnableParticles orig,
            SceneParticlesController self)
        {
            Delegates.Params_EnableParticles @params = new()
            {
                self = self
            };
            if (_beforeEnableParticles != null)
            {
                foreach (Delegates.EnableParticles_BeforeArgs toInvoke in _beforeEnableParticles.GetInvocationList())
                {
                    try
                    {
                        _beforeEnableParticles?.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }
                }
            }

            self = @params.self;
            orig(self);
            if (_afterEnableParticles != null)
            {
                foreach (Delegates.EnableParticles_AfterArgs toInvoke in _afterEnableParticles.GetInvocationList())
                {
                    try
                    {
                        _afterEnableParticles.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }
                }
            }
        }

        internal static void HookDisableParticles()
        {
            if (!HookedList.Contains("DisableParticles"))
            {
                HookedList.Add("DisableParticles");
                On.SceneParticlesController.DisableParticles += DisableParticles;
            }
        }

        internal static event Delegates.DisableParticles_BeforeArgs _beforeDisableParticles;
        internal static event Delegates.DisableParticles_AfterArgs _afterDisableParticles;

        private static void DisableParticles(On.SceneParticlesController.orig_DisableParticles orig,
            SceneParticlesController self)
        {
            Delegates.Params_DisableParticles @params = new()
            {
                self = self
            };
            if (_beforeDisableParticles != null)
            {
                foreach (Delegates.DisableParticles_BeforeArgs toInvoke in _beforeDisableParticles.GetInvocationList())
                {
                    try
                    {
                        _beforeDisableParticles?.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }
                }
            }

            self = @params.self;
            orig(self);
            if (_afterDisableParticles != null)
            {
                foreach (Delegates.DisableParticles_AfterArgs toInvoke in _afterDisableParticles.GetInvocationList())
                {
                    try
                    {
                        _afterDisableParticles.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }
                }
            }
        }

        internal static void HookBeginScene()
        {
            if (!HookedList.Contains("BeginScene"))
            {
                HookedList.Add("BeginScene");
                On.SceneParticlesController.BeginScene += BeginScene;
            }
        }

        internal static event Delegates.BeginScene_BeforeArgs _beforeBeginScene;
        internal static event Delegates.BeginScene_AfterArgs _afterBeginScene;

        private static void BeginScene(On.SceneParticlesController.orig_BeginScene orig, SceneParticlesController self)
        {
            Delegates.Params_BeginScene @params = new()
            {
                self = self
            };
            if (_beforeBeginScene != null)
            {
                foreach (Delegates.BeginScene_BeforeArgs toInvoke in _beforeBeginScene.GetInvocationList())
                {
                    try
                    {
                        _beforeBeginScene?.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }
                }
            }

            self = @params.self;
            orig(self);
            if (_afterBeginScene != null)
            {
                foreach (Delegates.BeginScene_AfterArgs toInvoke in _afterBeginScene.GetInvocationList())
                {
                    try
                    {
                        _afterBeginScene.Invoke(@params);
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
        public sealed class Params_SceneInit
        {
            public SceneParticlesController self;
        }

        public delegate void SceneInit_BeforeArgs(Params_SceneInit args);

        public delegate void SceneInit_AfterArgs(Params_SceneInit args);

        public delegate void SceneInit_WithArgs(Action<SceneParticlesController> orig, SceneParticlesController self);

        public sealed class Params_EnableParticles
        {
            public SceneParticlesController self;
        }

        public delegate void EnableParticles_BeforeArgs(Params_EnableParticles args);

        public delegate void EnableParticles_AfterArgs(Params_EnableParticles args);

        public delegate void EnableParticles_WithArgs(Action<SceneParticlesController> orig,
            SceneParticlesController self);

        public sealed class Params_DisableParticles
        {
            public SceneParticlesController self;
        }

        public delegate void DisableParticles_BeforeArgs(Params_DisableParticles args);

        public delegate void DisableParticles_AfterArgs(Params_DisableParticles args);

        public delegate void DisableParticles_WithArgs(Action<SceneParticlesController> orig,
            SceneParticlesController self);

        public sealed class Params_BeginScene
        {
            public SceneParticlesController self;
        }

        public delegate void BeginScene_BeforeArgs(Params_BeginScene args);

        public delegate void BeginScene_AfterArgs(Params_BeginScene args);

        public delegate void BeginScene_WithArgs(Action<SceneParticlesController> orig, SceneParticlesController self);
    }

    /// <summary>
    /// Contains Hooks to that run code before orig(self) is called
    /// </summary>
    public static class BeforeOrig
    {
        public static event Delegates.SceneInit_BeforeArgs SceneInit
        {
            add
            {
                HookHandler._beforeSceneInit += value;
                HookHandler.HookSceneInit();
            }
            remove => HookHandler._beforeSceneInit -= value;
        }

        public static event Delegates.EnableParticles_BeforeArgs EnableParticles
        {
            add
            {
                HookHandler._beforeEnableParticles += value;
                HookHandler.HookEnableParticles();
            }
            remove => HookHandler._beforeEnableParticles -= value;
        }

        public static event Delegates.DisableParticles_BeforeArgs DisableParticles
        {
            add
            {
                HookHandler._beforeDisableParticles += value;
                HookHandler.HookDisableParticles();
            }
            remove => HookHandler._beforeDisableParticles -= value;
        }

        public static event Delegates.BeginScene_BeforeArgs BeginScene
        {
            add
            {
                HookHandler._beforeBeginScene += value;
                HookHandler.HookBeginScene();
            }
            remove => HookHandler._beforeBeginScene -= value;
        }
    }

    /// <summary>
    /// Contains Hooks to that run code after orig(self) is called
    /// </summary>
    public static class AfterOrig
    {
        public static event Delegates.SceneInit_AfterArgs SceneInit
        {
            add
            {
                HookHandler._afterSceneInit += value;
                HookHandler.HookSceneInit();
            }
            remove => HookHandler._afterSceneInit -= value;
        }

        public static event Delegates.EnableParticles_AfterArgs EnableParticles
        {
            add
            {
                HookHandler._afterEnableParticles += value;
                HookHandler.HookEnableParticles();
            }
            remove => HookHandler._afterEnableParticles -= value;
        }

        public static event Delegates.DisableParticles_AfterArgs DisableParticles
        {
            add
            {
                HookHandler._afterDisableParticles += value;
                HookHandler.HookDisableParticles();
            }
            remove => HookHandler._afterDisableParticles -= value;
        }

        public static event Delegates.BeginScene_AfterArgs BeginScene
        {
            add
            {
                HookHandler._afterBeginScene += value;
                HookHandler.HookBeginScene();
            }
            remove => HookHandler._afterBeginScene -= value;
        }
    }

    /// <summary>
    /// Contains all On Hooks, even those that aren't in the On namespace such as API generated functions and property getters/setters
    /// </summary>
    public static class WithOrig
    {
        public static event On.SceneParticlesController.hook_SceneInit SceneInit
        {
            add => On.SceneParticlesController.SceneInit += value;
            remove => On.SceneParticlesController.SceneInit -= value;
        }

        public static event On.SceneParticlesController.hook_EnableParticles EnableParticles
        {
            add => On.SceneParticlesController.EnableParticles += value;
            remove => On.SceneParticlesController.EnableParticles -= value;
        }

        public static event On.SceneParticlesController.hook_DisableParticles DisableParticles
        {
            add => On.SceneParticlesController.DisableParticles += value;
            remove => On.SceneParticlesController.DisableParticles -= value;
        }

        public static event On.SceneParticlesController.hook_BeginScene BeginScene
        {
            add => On.SceneParticlesController.BeginScene += value;
            remove => On.SceneParticlesController.BeginScene -= value;
        }
    }
}