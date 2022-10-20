using MonoMod.RuntimeDetour;
using MonoMod.RuntimeDetour.HookGen;

namespace HKMirror.Hooks.OnHooks;

/// <summary>
///     Contains different types of On Hooks for CinematicVideoPlayerConfig class.<br />
///     Contains hooks that aren't generated by monomod, and before and after orig hooks for easier hooking.
/// </summary>
public static class OnCinematicVideoPlayerConfig
{
    internal static class HookHandler
    {
        private static readonly List<string> HookedList = new();

        internal static void Hookget_VideoReference()
        {
            if (!HookedList.Contains("get_VideoReference"))
            {
                HookedList.Add("get_VideoReference");
                new Hook(ReflectionHelper.GetMethodInfo(typeof(CinematicVideoPlayerConfig), "get_VideoReference"),
                    get_VideoReference);
            }
        }

        internal static event Delegates.get_VideoReference_BeforeArgs _beforeget_VideoReference;
        internal static event Delegates.get_VideoReference_NormalArgs _afterget_VideoReference;

        private static CinematicVideoReference get_VideoReference(
            Func<CinematicVideoPlayerConfig, CinematicVideoReference> orig, CinematicVideoPlayerConfig self)
        {
            Delegates.Params_get_VideoReference @params = new()
            {
                self = self
            };
            _beforeget_VideoReference?.Invoke(@params);
            self = @params.self;
            var retVal = orig(self);
            if (_afterget_VideoReference != null) retVal = _afterget_VideoReference.Invoke(@params);
            return retVal;
        }

        internal static void Hookget_MeshRenderer()
        {
            if (!HookedList.Contains("get_MeshRenderer"))
            {
                HookedList.Add("get_MeshRenderer");
                new Hook(ReflectionHelper.GetMethodInfo(typeof(CinematicVideoPlayerConfig), "get_MeshRenderer"),
                    get_MeshRenderer);
            }
        }

        internal static event Delegates.get_MeshRenderer_BeforeArgs _beforeget_MeshRenderer;
        internal static event Delegates.get_MeshRenderer_NormalArgs _afterget_MeshRenderer;

        private static MeshRenderer get_MeshRenderer(Func<CinematicVideoPlayerConfig, MeshRenderer> orig,
            CinematicVideoPlayerConfig self)
        {
            Delegates.Params_get_MeshRenderer @params = new()
            {
                self = self
            };
            _beforeget_MeshRenderer?.Invoke(@params);
            self = @params.self;
            var retVal = orig(self);
            if (_afterget_MeshRenderer != null) retVal = _afterget_MeshRenderer.Invoke(@params);
            return retVal;
        }

        internal static void Hookget_AudioSource()
        {
            if (!HookedList.Contains("get_AudioSource"))
            {
                HookedList.Add("get_AudioSource");
                new Hook(ReflectionHelper.GetMethodInfo(typeof(CinematicVideoPlayerConfig), "get_AudioSource"),
                    get_AudioSource);
            }
        }

        internal static event Delegates.get_AudioSource_BeforeArgs _beforeget_AudioSource;
        internal static event Delegates.get_AudioSource_NormalArgs _afterget_AudioSource;

        private static AudioSource get_AudioSource(Func<CinematicVideoPlayerConfig, AudioSource> orig,
            CinematicVideoPlayerConfig self)
        {
            Delegates.Params_get_AudioSource @params = new()
            {
                self = self
            };
            _beforeget_AudioSource?.Invoke(@params);
            self = @params.self;
            var retVal = orig(self);
            if (_afterget_AudioSource != null) retVal = _afterget_AudioSource.Invoke(@params);
            return retVal;
        }

        internal static void Hookget_FaderStyle()
        {
            if (!HookedList.Contains("get_FaderStyle"))
            {
                HookedList.Add("get_FaderStyle");
                new Hook(ReflectionHelper.GetMethodInfo(typeof(CinematicVideoPlayerConfig), "get_FaderStyle"),
                    get_FaderStyle);
            }
        }

        internal static event Delegates.get_FaderStyle_BeforeArgs _beforeget_FaderStyle;
        internal static event Delegates.get_FaderStyle_NormalArgs _afterget_FaderStyle;

        private static CinematicVideoFaderStyles get_FaderStyle(
            Func<CinematicVideoPlayerConfig, CinematicVideoFaderStyles> orig, CinematicVideoPlayerConfig self)
        {
            Delegates.Params_get_FaderStyle @params = new()
            {
                self = self
            };
            _beforeget_FaderStyle?.Invoke(@params);
            self = @params.self;
            var retVal = orig(self);
            if (_afterget_FaderStyle != null) retVal = _afterget_FaderStyle.Invoke(@params);
            return retVal;
        }

        internal static void Hookget_ImplicitVolume()
        {
            if (!HookedList.Contains("get_ImplicitVolume"))
            {
                HookedList.Add("get_ImplicitVolume");
                new Hook(ReflectionHelper.GetMethodInfo(typeof(CinematicVideoPlayerConfig), "get_ImplicitVolume"),
                    get_ImplicitVolume);
            }
        }

        internal static event Delegates.get_ImplicitVolume_BeforeArgs _beforeget_ImplicitVolume;
        internal static event Delegates.get_ImplicitVolume_NormalArgs _afterget_ImplicitVolume;

        private static float get_ImplicitVolume(Func<CinematicVideoPlayerConfig, float> orig,
            CinematicVideoPlayerConfig self)
        {
            Delegates.Params_get_ImplicitVolume @params = new()
            {
                self = self
            };
            _beforeget_ImplicitVolume?.Invoke(@params);
            self = @params.self;
            var retVal = orig(self);
            if (_afterget_ImplicitVolume != null) retVal = _afterget_ImplicitVolume.Invoke(@params);
            return retVal;
        }
    }

    /// <summary>
    ///     Contains necessary information to create Hooks. Does not contain any hooks
    /// </summary>
    public static class Delegates
    {
        public delegate void get_AudioSource_BeforeArgs(Params_get_AudioSource args);

        public delegate AudioSource get_AudioSource_NormalArgs(Params_get_AudioSource args);

        public delegate void get_FaderStyle_BeforeArgs(Params_get_FaderStyle args);

        public delegate CinematicVideoFaderStyles get_FaderStyle_NormalArgs(Params_get_FaderStyle args);

        public delegate void get_ImplicitVolume_BeforeArgs(Params_get_ImplicitVolume args);

        public delegate float get_ImplicitVolume_NormalArgs(Params_get_ImplicitVolume args);

        public delegate void get_MeshRenderer_BeforeArgs(Params_get_MeshRenderer args);

        public delegate MeshRenderer get_MeshRenderer_NormalArgs(Params_get_MeshRenderer args);

        public delegate void get_VideoReference_BeforeArgs(Params_get_VideoReference args);

        public delegate CinematicVideoReference get_VideoReference_NormalArgs(Params_get_VideoReference args);

        public sealed class Params_get_VideoReference
        {
            public CinematicVideoPlayerConfig self;
        }

        public sealed class Params_get_MeshRenderer
        {
            public CinematicVideoPlayerConfig self;
        }

        public sealed class Params_get_AudioSource
        {
            public CinematicVideoPlayerConfig self;
        }

        public sealed class Params_get_FaderStyle
        {
            public CinematicVideoPlayerConfig self;
        }

        public sealed class Params_get_ImplicitVolume
        {
            public CinematicVideoPlayerConfig self;
        }
    }

    /// <summary>
    ///     Contains Hooks to that run code before orig(self) is called
    /// </summary>
    public static class BeforeOrig
    {
        public static event Delegates.get_VideoReference_BeforeArgs get_VideoReference
        {
            add
            {
                HookHandler._beforeget_VideoReference += value;
                HookHandler.Hookget_VideoReference();
            }
            remove => HookHandler._beforeget_VideoReference -= value;
        }

        public static event Delegates.get_MeshRenderer_BeforeArgs get_MeshRenderer
        {
            add
            {
                HookHandler._beforeget_MeshRenderer += value;
                HookHandler.Hookget_MeshRenderer();
            }
            remove => HookHandler._beforeget_MeshRenderer -= value;
        }

        public static event Delegates.get_AudioSource_BeforeArgs get_AudioSource
        {
            add
            {
                HookHandler._beforeget_AudioSource += value;
                HookHandler.Hookget_AudioSource();
            }
            remove => HookHandler._beforeget_AudioSource -= value;
        }

        public static event Delegates.get_FaderStyle_BeforeArgs get_FaderStyle
        {
            add
            {
                HookHandler._beforeget_FaderStyle += value;
                HookHandler.Hookget_FaderStyle();
            }
            remove => HookHandler._beforeget_FaderStyle -= value;
        }

        public static event Delegates.get_ImplicitVolume_BeforeArgs get_ImplicitVolume
        {
            add
            {
                HookHandler._beforeget_ImplicitVolume += value;
                HookHandler.Hookget_ImplicitVolume();
            }
            remove => HookHandler._beforeget_ImplicitVolume -= value;
        }
    }

    /// <summary>
    ///     Contains Hooks to that run code after orig(self) is called
    /// </summary>
    public static class AfterOrig
    {
        public static event Delegates.get_VideoReference_NormalArgs get_VideoReference
        {
            add
            {
                HookHandler._afterget_VideoReference += value;
                HookHandler.Hookget_VideoReference();
            }
            remove => HookHandler._afterget_VideoReference -= value;
        }

        public static event Delegates.get_MeshRenderer_NormalArgs get_MeshRenderer
        {
            add
            {
                HookHandler._afterget_MeshRenderer += value;
                HookHandler.Hookget_MeshRenderer();
            }
            remove => HookHandler._afterget_MeshRenderer -= value;
        }

        public static event Delegates.get_AudioSource_NormalArgs get_AudioSource
        {
            add
            {
                HookHandler._afterget_AudioSource += value;
                HookHandler.Hookget_AudioSource();
            }
            remove => HookHandler._afterget_AudioSource -= value;
        }

        public static event Delegates.get_FaderStyle_NormalArgs get_FaderStyle
        {
            add
            {
                HookHandler._afterget_FaderStyle += value;
                HookHandler.Hookget_FaderStyle();
            }
            remove => HookHandler._afterget_FaderStyle -= value;
        }

        public static event Delegates.get_ImplicitVolume_NormalArgs get_ImplicitVolume
        {
            add
            {
                HookHandler._afterget_ImplicitVolume += value;
                HookHandler.Hookget_ImplicitVolume();
            }
            remove => HookHandler._afterget_ImplicitVolume -= value;
        }
    }

    /// <summary>
    ///     Contains all On Hooks, even those that aren't in the On namespace such as API generated functions and property
    ///     getters/setters
    /// </summary>
    public static class WithOrig
    {
        public static event Delegates.get_VideoReference_NormalArgs get_VideoReference
        {
            add => HookEndpointManager.Add<Delegates.get_VideoReference_NormalArgs>(
                ReflectionHelper.GetMethodInfo(typeof(CinematicVideoPlayerConfig), "get_VideoReference"), value);
            remove => HookEndpointManager.Remove<Delegates.get_VideoReference_NormalArgs>(
                ReflectionHelper.GetMethodInfo(typeof(CinematicVideoPlayerConfig), "get_VideoReference"), value);
        }

        public static event Delegates.get_MeshRenderer_NormalArgs get_MeshRenderer
        {
            add => HookEndpointManager.Add<Delegates.get_MeshRenderer_NormalArgs>(
                ReflectionHelper.GetMethodInfo(typeof(CinematicVideoPlayerConfig), "get_MeshRenderer"), value);
            remove => HookEndpointManager.Remove<Delegates.get_MeshRenderer_NormalArgs>(
                ReflectionHelper.GetMethodInfo(typeof(CinematicVideoPlayerConfig), "get_MeshRenderer"), value);
        }

        public static event Delegates.get_AudioSource_NormalArgs get_AudioSource
        {
            add => HookEndpointManager.Add<Delegates.get_AudioSource_NormalArgs>(
                ReflectionHelper.GetMethodInfo(typeof(CinematicVideoPlayerConfig), "get_AudioSource"), value);
            remove => HookEndpointManager.Remove<Delegates.get_AudioSource_NormalArgs>(
                ReflectionHelper.GetMethodInfo(typeof(CinematicVideoPlayerConfig), "get_AudioSource"), value);
        }

        public static event Delegates.get_FaderStyle_NormalArgs get_FaderStyle
        {
            add => HookEndpointManager.Add<Delegates.get_FaderStyle_NormalArgs>(
                ReflectionHelper.GetMethodInfo(typeof(CinematicVideoPlayerConfig), "get_FaderStyle"), value);
            remove => HookEndpointManager.Remove<Delegates.get_FaderStyle_NormalArgs>(
                ReflectionHelper.GetMethodInfo(typeof(CinematicVideoPlayerConfig), "get_FaderStyle"), value);
        }

        public static event Delegates.get_ImplicitVolume_NormalArgs get_ImplicitVolume
        {
            add => HookEndpointManager.Add<Delegates.get_ImplicitVolume_NormalArgs>(
                ReflectionHelper.GetMethodInfo(typeof(CinematicVideoPlayerConfig), "get_ImplicitVolume"), value);
            remove => HookEndpointManager.Remove<Delegates.get_ImplicitVolume_NormalArgs>(
                ReflectionHelper.GetMethodInfo(typeof(CinematicVideoPlayerConfig), "get_ImplicitVolume"), value);
        }
    }
}