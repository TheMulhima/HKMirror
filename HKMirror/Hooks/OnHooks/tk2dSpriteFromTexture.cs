using MonoMod.RuntimeDetour;
using MonoMod.RuntimeDetour.HookGen;

namespace HKMirror.Hooks.OnHooks;

/// <summary>
///     Contains different types of On Hooks for tk2dSpriteFromTexture class.<br />
///     Contains hooks that aren't generated by monomod, and before and after orig hooks for easier hooking.
/// </summary>
public static class Ontk2dSpriteFromTexture
{
    internal static class HookHandler
    {
        private static readonly List<string> HookedList = new();

        internal static void Hookget_Sprite()
        {
            if (!HookedList.Contains("get_Sprite"))
            {
                HookedList.Add("get_Sprite");
                new Hook(ReflectionHelper.GetMethodInfo(typeof(tk2dSpriteFromTexture), "get_Sprite"), get_Sprite);
            }
        }

        internal static event Delegates.get_Sprite_BeforeArgs _beforeget_Sprite;
        internal static event Delegates.get_Sprite_AfterArgs _afterget_Sprite;

        private static tk2dBaseSprite get_Sprite(Func<tk2dSpriteFromTexture, tk2dBaseSprite> orig,
            tk2dSpriteFromTexture self)
        {
            Delegates.Params_get_Sprite @params = new()
            {
                self = self
            };
            if (_beforeget_Sprite != null)
                foreach (Delegates.get_Sprite_BeforeArgs toInvoke in _beforeget_Sprite.GetInvocationList())
                    try
                    {
                        _beforeget_Sprite?.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }

            self = @params.self;
            var retVal = orig(self);
            if (_afterget_Sprite != null)
                foreach (Delegates.get_Sprite_AfterArgs toInvoke in _afterget_Sprite.GetInvocationList())
                    try
                    {
                        retVal = _afterget_Sprite.Invoke(@params, retVal);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }

            return retVal;
        }

        internal static void HookAwake()
        {
            if (!HookedList.Contains("Awake"))
            {
                HookedList.Add("Awake");
                On.tk2dSpriteFromTexture.Awake += Awake;
            }
        }

        internal static event Delegates.Awake_BeforeArgs _beforeAwake;
        internal static event Delegates.Awake_AfterArgs _afterAwake;

        private static void Awake(On.tk2dSpriteFromTexture.orig_Awake orig, tk2dSpriteFromTexture self)
        {
            Delegates.Params_Awake @params = new()
            {
                self = self
            };
            if (_beforeAwake != null)
                foreach (Delegates.Awake_BeforeArgs toInvoke in _beforeAwake.GetInvocationList())
                    try
                    {
                        _beforeAwake?.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }

            self = @params.self;
            orig(self);
            if (_afterAwake != null)
                foreach (Delegates.Awake_AfterArgs toInvoke in _afterAwake.GetInvocationList())
                    try
                    {
                        _afterAwake.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }
        }

        internal static void Hookget_HasSpriteCollection()
        {
            if (!HookedList.Contains("get_HasSpriteCollection"))
            {
                HookedList.Add("get_HasSpriteCollection");
                new Hook(ReflectionHelper.GetMethodInfo(typeof(tk2dSpriteFromTexture), "get_HasSpriteCollection"),
                    get_HasSpriteCollection);
            }
        }

        internal static event Delegates.get_HasSpriteCollection_BeforeArgs _beforeget_HasSpriteCollection;
        internal static event Delegates.get_HasSpriteCollection_AfterArgs _afterget_HasSpriteCollection;

        private static bool get_HasSpriteCollection(Func<tk2dSpriteFromTexture, bool> orig, tk2dSpriteFromTexture self)
        {
            Delegates.Params_get_HasSpriteCollection @params = new()
            {
                self = self
            };
            if (_beforeget_HasSpriteCollection != null)
                foreach (Delegates.get_HasSpriteCollection_BeforeArgs toInvoke in _beforeget_HasSpriteCollection
                             .GetInvocationList())
                    try
                    {
                        _beforeget_HasSpriteCollection?.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }

            self = @params.self;
            var retVal = orig(self);
            if (_afterget_HasSpriteCollection != null)
                foreach (Delegates.get_HasSpriteCollection_AfterArgs toInvoke in _afterget_HasSpriteCollection
                             .GetInvocationList())
                    try
                    {
                        retVal = _afterget_HasSpriteCollection.Invoke(@params, retVal);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }

            return retVal;
        }

        internal static void HookOnDestroy()
        {
            if (!HookedList.Contains("OnDestroy"))
            {
                HookedList.Add("OnDestroy");
                On.tk2dSpriteFromTexture.OnDestroy += OnDestroy;
            }
        }

        internal static event Delegates.OnDestroy_BeforeArgs _beforeOnDestroy;
        internal static event Delegates.OnDestroy_AfterArgs _afterOnDestroy;

        private static void OnDestroy(On.tk2dSpriteFromTexture.orig_OnDestroy orig, tk2dSpriteFromTexture self)
        {
            Delegates.Params_OnDestroy @params = new()
            {
                self = self
            };
            if (_beforeOnDestroy != null)
                foreach (Delegates.OnDestroy_BeforeArgs toInvoke in _beforeOnDestroy.GetInvocationList())
                    try
                    {
                        _beforeOnDestroy?.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }

            self = @params.self;
            orig(self);
            if (_afterOnDestroy != null)
                foreach (Delegates.OnDestroy_AfterArgs toInvoke in _afterOnDestroy.GetInvocationList())
                    try
                    {
                        _afterOnDestroy.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }
        }

        internal static void HookClear()
        {
            if (!HookedList.Contains("Clear"))
            {
                HookedList.Add("Clear");
                On.tk2dSpriteFromTexture.Clear += Clear;
            }
        }

        internal static event Delegates.Clear_BeforeArgs _beforeClear;
        internal static event Delegates.Clear_AfterArgs _afterClear;

        private static void Clear(On.tk2dSpriteFromTexture.orig_Clear orig, tk2dSpriteFromTexture self)
        {
            Delegates.Params_Clear @params = new()
            {
                self = self
            };
            if (_beforeClear != null)
                foreach (Delegates.Clear_BeforeArgs toInvoke in _beforeClear.GetInvocationList())
                    try
                    {
                        _beforeClear?.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }

            self = @params.self;
            orig(self);
            if (_afterClear != null)
                foreach (Delegates.Clear_AfterArgs toInvoke in _afterClear.GetInvocationList())
                    try
                    {
                        _afterClear.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }
        }

        internal static void HookForceBuild()
        {
            if (!HookedList.Contains("ForceBuild"))
            {
                HookedList.Add("ForceBuild");
                On.tk2dSpriteFromTexture.ForceBuild += ForceBuild;
            }
        }

        internal static event Delegates.ForceBuild_BeforeArgs _beforeForceBuild;
        internal static event Delegates.ForceBuild_AfterArgs _afterForceBuild;

        private static void ForceBuild(On.tk2dSpriteFromTexture.orig_ForceBuild orig, tk2dSpriteFromTexture self)
        {
            Delegates.Params_ForceBuild @params = new()
            {
                self = self
            };
            if (_beforeForceBuild != null)
                foreach (Delegates.ForceBuild_BeforeArgs toInvoke in _beforeForceBuild.GetInvocationList())
                    try
                    {
                        _beforeForceBuild?.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }

            self = @params.self;
            orig(self);
            if (_afterForceBuild != null)
                foreach (Delegates.ForceBuild_AfterArgs toInvoke in _afterForceBuild.GetInvocationList())
                    try
                    {
                        _afterForceBuild.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }
        }

        internal static void HookDestroyInternal()
        {
            if (!HookedList.Contains("DestroyInternal"))
            {
                HookedList.Add("DestroyInternal");
                On.tk2dSpriteFromTexture.DestroyInternal += DestroyInternal;
            }
        }

        internal static event Delegates.DestroyInternal_BeforeArgs _beforeDestroyInternal;
        internal static event Delegates.DestroyInternal_AfterArgs _afterDestroyInternal;

        private static void DestroyInternal(On.tk2dSpriteFromTexture.orig_DestroyInternal orig,
            tk2dSpriteFromTexture self)
        {
            Delegates.Params_DestroyInternal @params = new()
            {
                self = self
            };
            if (_beforeDestroyInternal != null)
                foreach (Delegates.DestroyInternal_BeforeArgs toInvoke in _beforeDestroyInternal.GetInvocationList())
                    try
                    {
                        _beforeDestroyInternal?.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }

            self = @params.self;
            orig(self);
            if (_afterDestroyInternal != null)
                foreach (Delegates.DestroyInternal_AfterArgs toInvoke in _afterDestroyInternal.GetInvocationList())
                    try
                    {
                        _afterDestroyInternal.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }
        }
    }

    /// <summary>
    ///     Contains necessary information to create Hooks. Does not contain any hooks
    /// </summary>
    public static class Delegates
    {
        public delegate void Awake_AfterArgs(Params_Awake args);

        public delegate void Awake_BeforeArgs(Params_Awake args);

        public delegate void Awake_WithArgs(Action<tk2dSpriteFromTexture> orig, tk2dSpriteFromTexture self);

        public delegate void Clear_AfterArgs(Params_Clear args);

        public delegate void Clear_BeforeArgs(Params_Clear args);

        public delegate void Clear_WithArgs(Action<tk2dSpriteFromTexture> orig, tk2dSpriteFromTexture self);

        public delegate void DestroyInternal_AfterArgs(Params_DestroyInternal args);

        public delegate void DestroyInternal_BeforeArgs(Params_DestroyInternal args);

        public delegate void DestroyInternal_WithArgs(Action<tk2dSpriteFromTexture> orig, tk2dSpriteFromTexture self);

        public delegate void ForceBuild_AfterArgs(Params_ForceBuild args);

        public delegate void ForceBuild_BeforeArgs(Params_ForceBuild args);

        public delegate void ForceBuild_WithArgs(Action<tk2dSpriteFromTexture> orig, tk2dSpriteFromTexture self);

        public delegate bool get_HasSpriteCollection_AfterArgs(Params_get_HasSpriteCollection args, bool ret);

        public delegate void get_HasSpriteCollection_BeforeArgs(Params_get_HasSpriteCollection args);

        public delegate bool get_HasSpriteCollection_WithArgs(Func<tk2dSpriteFromTexture, bool> orig,
            tk2dSpriteFromTexture self);

        public delegate tk2dBaseSprite get_Sprite_AfterArgs(Params_get_Sprite args, tk2dBaseSprite ret);

        public delegate void get_Sprite_BeforeArgs(Params_get_Sprite args);

        public delegate tk2dBaseSprite get_Sprite_WithArgs(Func<tk2dSpriteFromTexture, tk2dBaseSprite> orig,
            tk2dSpriteFromTexture self);

        public delegate void OnDestroy_AfterArgs(Params_OnDestroy args);

        public delegate void OnDestroy_BeforeArgs(Params_OnDestroy args);

        public delegate void OnDestroy_WithArgs(Action<tk2dSpriteFromTexture> orig, tk2dSpriteFromTexture self);

        public sealed class Params_get_Sprite
        {
            public tk2dSpriteFromTexture self;
        }

        public sealed class Params_Awake
        {
            public tk2dSpriteFromTexture self;
        }

        public sealed class Params_get_HasSpriteCollection
        {
            public tk2dSpriteFromTexture self;
        }

        public sealed class Params_OnDestroy
        {
            public tk2dSpriteFromTexture self;
        }

        public sealed class Params_Clear
        {
            public tk2dSpriteFromTexture self;
        }

        public sealed class Params_ForceBuild
        {
            public tk2dSpriteFromTexture self;
        }

        public sealed class Params_DestroyInternal
        {
            public tk2dSpriteFromTexture self;
        }
    }

    /// <summary>
    ///     Contains Hooks to that run code before orig(self) is called
    /// </summary>
    public static class BeforeOrig
    {
        public static event Delegates.get_Sprite_BeforeArgs get_Sprite
        {
            add
            {
                HookHandler._beforeget_Sprite += value;
                HookHandler.Hookget_Sprite();
            }
            remove => HookHandler._beforeget_Sprite -= value;
        }

        public static event Delegates.Awake_BeforeArgs Awake
        {
            add
            {
                HookHandler._beforeAwake += value;
                HookHandler.HookAwake();
            }
            remove => HookHandler._beforeAwake -= value;
        }

        public static event Delegates.get_HasSpriteCollection_BeforeArgs get_HasSpriteCollection
        {
            add
            {
                HookHandler._beforeget_HasSpriteCollection += value;
                HookHandler.Hookget_HasSpriteCollection();
            }
            remove => HookHandler._beforeget_HasSpriteCollection -= value;
        }

        public static event Delegates.OnDestroy_BeforeArgs OnDestroy
        {
            add
            {
                HookHandler._beforeOnDestroy += value;
                HookHandler.HookOnDestroy();
            }
            remove => HookHandler._beforeOnDestroy -= value;
        }

        public static event Delegates.Clear_BeforeArgs Clear
        {
            add
            {
                HookHandler._beforeClear += value;
                HookHandler.HookClear();
            }
            remove => HookHandler._beforeClear -= value;
        }

        public static event Delegates.ForceBuild_BeforeArgs ForceBuild
        {
            add
            {
                HookHandler._beforeForceBuild += value;
                HookHandler.HookForceBuild();
            }
            remove => HookHandler._beforeForceBuild -= value;
        }

        public static event Delegates.DestroyInternal_BeforeArgs DestroyInternal
        {
            add
            {
                HookHandler._beforeDestroyInternal += value;
                HookHandler.HookDestroyInternal();
            }
            remove => HookHandler._beforeDestroyInternal -= value;
        }
    }

    /// <summary>
    ///     Contains Hooks to that run code after orig(self) is called
    /// </summary>
    public static class AfterOrig
    {
        public static event Delegates.get_Sprite_AfterArgs get_Sprite
        {
            add
            {
                HookHandler._afterget_Sprite += value;
                HookHandler.Hookget_Sprite();
            }
            remove => HookHandler._afterget_Sprite -= value;
        }

        public static event Delegates.Awake_AfterArgs Awake
        {
            add
            {
                HookHandler._afterAwake += value;
                HookHandler.HookAwake();
            }
            remove => HookHandler._afterAwake -= value;
        }

        public static event Delegates.get_HasSpriteCollection_AfterArgs get_HasSpriteCollection
        {
            add
            {
                HookHandler._afterget_HasSpriteCollection += value;
                HookHandler.Hookget_HasSpriteCollection();
            }
            remove => HookHandler._afterget_HasSpriteCollection -= value;
        }

        public static event Delegates.OnDestroy_AfterArgs OnDestroy
        {
            add
            {
                HookHandler._afterOnDestroy += value;
                HookHandler.HookOnDestroy();
            }
            remove => HookHandler._afterOnDestroy -= value;
        }

        public static event Delegates.Clear_AfterArgs Clear
        {
            add
            {
                HookHandler._afterClear += value;
                HookHandler.HookClear();
            }
            remove => HookHandler._afterClear -= value;
        }

        public static event Delegates.ForceBuild_AfterArgs ForceBuild
        {
            add
            {
                HookHandler._afterForceBuild += value;
                HookHandler.HookForceBuild();
            }
            remove => HookHandler._afterForceBuild -= value;
        }

        public static event Delegates.DestroyInternal_AfterArgs DestroyInternal
        {
            add
            {
                HookHandler._afterDestroyInternal += value;
                HookHandler.HookDestroyInternal();
            }
            remove => HookHandler._afterDestroyInternal -= value;
        }
    }

    /// <summary>
    ///     Contains all On Hooks, even those that aren't in the On namespace such as API generated functions and property
    ///     getters/setters
    /// </summary>
    public static class WithOrig
    {
        public static event Delegates.get_Sprite_WithArgs get_Sprite
        {
            add => HookEndpointManager.Add<Delegates.get_Sprite_WithArgs>(
                ReflectionHelper.GetMethodInfo(typeof(tk2dSpriteFromTexture), "get_Sprite"), value);
            remove => HookEndpointManager.Remove<Delegates.get_Sprite_WithArgs>(
                ReflectionHelper.GetMethodInfo(typeof(tk2dSpriteFromTexture), "get_Sprite"), value);
        }

        public static event On.tk2dSpriteFromTexture.hook_Awake Awake
        {
            add => On.tk2dSpriteFromTexture.Awake += value;
            remove => On.tk2dSpriteFromTexture.Awake -= value;
        }

        public static event Delegates.get_HasSpriteCollection_WithArgs get_HasSpriteCollection
        {
            add => HookEndpointManager.Add<Delegates.get_HasSpriteCollection_WithArgs>(
                ReflectionHelper.GetMethodInfo(typeof(tk2dSpriteFromTexture), "get_HasSpriteCollection"), value);
            remove => HookEndpointManager.Remove<Delegates.get_HasSpriteCollection_WithArgs>(
                ReflectionHelper.GetMethodInfo(typeof(tk2dSpriteFromTexture), "get_HasSpriteCollection"), value);
        }

        public static event On.tk2dSpriteFromTexture.hook_OnDestroy OnDestroy
        {
            add => On.tk2dSpriteFromTexture.OnDestroy += value;
            remove => On.tk2dSpriteFromTexture.OnDestroy -= value;
        }

        public static event On.tk2dSpriteFromTexture.hook_Clear Clear
        {
            add => On.tk2dSpriteFromTexture.Clear += value;
            remove => On.tk2dSpriteFromTexture.Clear -= value;
        }

        public static event On.tk2dSpriteFromTexture.hook_ForceBuild ForceBuild
        {
            add => On.tk2dSpriteFromTexture.ForceBuild += value;
            remove => On.tk2dSpriteFromTexture.ForceBuild -= value;
        }

        public static event On.tk2dSpriteFromTexture.hook_DestroyInternal DestroyInternal
        {
            add => On.tk2dSpriteFromTexture.DestroyInternal += value;
            remove => On.tk2dSpriteFromTexture.DestroyInternal -= value;
        }
    }
}