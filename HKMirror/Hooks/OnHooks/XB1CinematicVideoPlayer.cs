using MonoMod.RuntimeDetour;
using MonoMod.RuntimeDetour.HookGen;

namespace HKMirror.Hooks.OnHooks;

/// <summary>
/// Contains different types of On Hooks for XB1CinematicVideoPlayer class.<br />
/// Contains hooks that aren't generated by monomod, and before and after orig hooks for easier hooking.
/// </summary>
public static class OnXB1CinematicVideoPlayer
{
    internal static class HookHandler
    {
        private static List<string> HookedList = new List<string>();

        internal static void HookDispose()
        {
            if (!HookedList.Contains("Dispose"))
            {
                HookedList.Add("Dispose");
                On.XB1CinematicVideoPlayer.Dispose += Dispose;
            }
        }

        internal static event Delegates.Dispose_BeforeArgs _beforeDispose;
        internal static event Delegates.Dispose_AfterArgs _afterDispose;

        private static void Dispose(On.XB1CinematicVideoPlayer.orig_Dispose orig, XB1CinematicVideoPlayer self)
        {
            Delegates.Params_Dispose @params = new()
            {
                self = self
            };
            if (_beforeDispose != null)
            {
                foreach (Delegates.Dispose_BeforeArgs toInvoke in _beforeDispose.GetInvocationList())
                {
                    try
                    {
                        _beforeDispose?.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }
                }
            }

            self = @params.self;
            orig(self);
            if (_afterDispose != null)
            {
                foreach (Delegates.Dispose_AfterArgs toInvoke in _afterDispose.GetInvocationList())
                {
                    try
                    {
                        _afterDispose.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }
                }
            }
        }

        internal static void Hookget_Volume()
        {
            if (!HookedList.Contains("get_Volume"))
            {
                HookedList.Add("get_Volume");
                new Hook(ReflectionHelper.GetMethodInfo(typeof(XB1CinematicVideoPlayer), "get_Volume", true),
                    get_Volume);
            }
        }

        internal static event Delegates.get_Volume_BeforeArgs _beforeget_Volume;
        internal static event Delegates.get_Volume_AfterArgs _afterget_Volume;

        private static float get_Volume(Func<XB1CinematicVideoPlayer, float> orig, XB1CinematicVideoPlayer self)
        {
            Delegates.Params_get_Volume @params = new()
            {
                self = self
            };
            if (_beforeget_Volume != null)
            {
                foreach (Delegates.get_Volume_BeforeArgs toInvoke in _beforeget_Volume.GetInvocationList())
                {
                    try
                    {
                        _beforeget_Volume?.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }
                }
            }

            self = @params.self;
            var retVal = orig(self);
            if (_afterget_Volume != null)
            {
                foreach (Delegates.get_Volume_AfterArgs toInvoke in _afterget_Volume.GetInvocationList())
                {
                    try
                    {
                        retVal = _afterget_Volume.Invoke(@params, retVal);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }
                }
            }

            return retVal;
        }

        internal static void Hookset_Volume()
        {
            if (!HookedList.Contains("set_Volume"))
            {
                HookedList.Add("set_Volume");
                new Hook(ReflectionHelper.GetMethodInfo(typeof(XB1CinematicVideoPlayer), "set_Volume", true),
                    set_Volume);
            }
        }

        internal static event Delegates.set_Volume_BeforeArgs _beforeset_Volume;
        internal static event Delegates.set_Volume_AfterArgs _afterset_Volume;

        private static void set_Volume(Action<XB1CinematicVideoPlayer, float> orig, XB1CinematicVideoPlayer self,
            float value)
        {
            Delegates.Params_set_Volume @params = new()
            {
                self = self, value = value
            };
            if (_beforeset_Volume != null)
            {
                foreach (Delegates.set_Volume_BeforeArgs toInvoke in _beforeset_Volume.GetInvocationList())
                {
                    try
                    {
                        _beforeset_Volume?.Invoke(@params);
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
            if (_afterset_Volume != null)
            {
                foreach (Delegates.set_Volume_AfterArgs toInvoke in _afterset_Volume.GetInvocationList())
                {
                    try
                    {
                        _afterset_Volume.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }
                }
            }
        }

        internal static void Hookget_IsLoading()
        {
            if (!HookedList.Contains("get_IsLoading"))
            {
                HookedList.Add("get_IsLoading");
                new Hook(ReflectionHelper.GetMethodInfo(typeof(XB1CinematicVideoPlayer), "get_IsLoading", true),
                    get_IsLoading);
            }
        }

        internal static event Delegates.get_IsLoading_BeforeArgs _beforeget_IsLoading;
        internal static event Delegates.get_IsLoading_AfterArgs _afterget_IsLoading;

        private static bool get_IsLoading(Func<XB1CinematicVideoPlayer, bool> orig, XB1CinematicVideoPlayer self)
        {
            Delegates.Params_get_IsLoading @params = new()
            {
                self = self
            };
            if (_beforeget_IsLoading != null)
            {
                foreach (Delegates.get_IsLoading_BeforeArgs toInvoke in _beforeget_IsLoading.GetInvocationList())
                {
                    try
                    {
                        _beforeget_IsLoading?.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }
                }
            }

            self = @params.self;
            var retVal = orig(self);
            if (_afterget_IsLoading != null)
            {
                foreach (Delegates.get_IsLoading_AfterArgs toInvoke in _afterget_IsLoading.GetInvocationList())
                {
                    try
                    {
                        retVal = _afterget_IsLoading.Invoke(@params, retVal);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }
                }
            }

            return retVal;
        }

        internal static void Hookget_IsLooping()
        {
            if (!HookedList.Contains("get_IsLooping"))
            {
                HookedList.Add("get_IsLooping");
                new Hook(ReflectionHelper.GetMethodInfo(typeof(XB1CinematicVideoPlayer), "get_IsLooping", true),
                    get_IsLooping);
            }
        }

        internal static event Delegates.get_IsLooping_BeforeArgs _beforeget_IsLooping;
        internal static event Delegates.get_IsLooping_AfterArgs _afterget_IsLooping;

        private static bool get_IsLooping(Func<XB1CinematicVideoPlayer, bool> orig, XB1CinematicVideoPlayer self)
        {
            Delegates.Params_get_IsLooping @params = new()
            {
                self = self
            };
            if (_beforeget_IsLooping != null)
            {
                foreach (Delegates.get_IsLooping_BeforeArgs toInvoke in _beforeget_IsLooping.GetInvocationList())
                {
                    try
                    {
                        _beforeget_IsLooping?.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }
                }
            }

            self = @params.self;
            var retVal = orig(self);
            if (_afterget_IsLooping != null)
            {
                foreach (Delegates.get_IsLooping_AfterArgs toInvoke in _afterget_IsLooping.GetInvocationList())
                {
                    try
                    {
                        retVal = _afterget_IsLooping.Invoke(@params, retVal);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }
                }
            }

            return retVal;
        }

        internal static void Hookset_IsLooping()
        {
            if (!HookedList.Contains("set_IsLooping"))
            {
                HookedList.Add("set_IsLooping");
                new Hook(ReflectionHelper.GetMethodInfo(typeof(XB1CinematicVideoPlayer), "set_IsLooping", true),
                    set_IsLooping);
            }
        }

        internal static event Delegates.set_IsLooping_BeforeArgs _beforeset_IsLooping;
        internal static event Delegates.set_IsLooping_AfterArgs _afterset_IsLooping;

        private static void set_IsLooping(Action<XB1CinematicVideoPlayer, bool> orig, XB1CinematicVideoPlayer self,
            bool value)
        {
            Delegates.Params_set_IsLooping @params = new()
            {
                self = self, value = value
            };
            if (_beforeset_IsLooping != null)
            {
                foreach (Delegates.set_IsLooping_BeforeArgs toInvoke in _beforeset_IsLooping.GetInvocationList())
                {
                    try
                    {
                        _beforeset_IsLooping?.Invoke(@params);
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
            if (_afterset_IsLooping != null)
            {
                foreach (Delegates.set_IsLooping_AfterArgs toInvoke in _afterset_IsLooping.GetInvocationList())
                {
                    try
                    {
                        _afterset_IsLooping.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }
                }
            }
        }

        internal static void Hookget_IsPlaying()
        {
            if (!HookedList.Contains("get_IsPlaying"))
            {
                HookedList.Add("get_IsPlaying");
                new Hook(ReflectionHelper.GetMethodInfo(typeof(XB1CinematicVideoPlayer), "get_IsPlaying", true),
                    get_IsPlaying);
            }
        }

        internal static event Delegates.get_IsPlaying_BeforeArgs _beforeget_IsPlaying;
        internal static event Delegates.get_IsPlaying_AfterArgs _afterget_IsPlaying;

        private static bool get_IsPlaying(Func<XB1CinematicVideoPlayer, bool> orig, XB1CinematicVideoPlayer self)
        {
            Delegates.Params_get_IsPlaying @params = new()
            {
                self = self
            };
            if (_beforeget_IsPlaying != null)
            {
                foreach (Delegates.get_IsPlaying_BeforeArgs toInvoke in _beforeget_IsPlaying.GetInvocationList())
                {
                    try
                    {
                        _beforeget_IsPlaying?.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }
                }
            }

            self = @params.self;
            var retVal = orig(self);
            if (_afterget_IsPlaying != null)
            {
                foreach (Delegates.get_IsPlaying_AfterArgs toInvoke in _afterget_IsPlaying.GetInvocationList())
                {
                    try
                    {
                        retVal = _afterget_IsPlaying.Invoke(@params, retVal);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }
                }
            }

            return retVal;
        }

        internal static void HookPlay()
        {
            if (!HookedList.Contains("Play"))
            {
                HookedList.Add("Play");
                On.XB1CinematicVideoPlayer.Play += Play;
            }
        }

        internal static event Delegates.Play_BeforeArgs _beforePlay;
        internal static event Delegates.Play_AfterArgs _afterPlay;

        private static void Play(On.XB1CinematicVideoPlayer.orig_Play orig, XB1CinematicVideoPlayer self)
        {
            Delegates.Params_Play @params = new()
            {
                self = self
            };
            if (_beforePlay != null)
            {
                foreach (Delegates.Play_BeforeArgs toInvoke in _beforePlay.GetInvocationList())
                {
                    try
                    {
                        _beforePlay?.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }
                }
            }

            self = @params.self;
            orig(self);
            if (_afterPlay != null)
            {
                foreach (Delegates.Play_AfterArgs toInvoke in _afterPlay.GetInvocationList())
                {
                    try
                    {
                        _afterPlay.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }
                }
            }
        }

        internal static void HookStop()
        {
            if (!HookedList.Contains("Stop"))
            {
                HookedList.Add("Stop");
                On.XB1CinematicVideoPlayer.Stop += Stop;
            }
        }

        internal static event Delegates.Stop_BeforeArgs _beforeStop;
        internal static event Delegates.Stop_AfterArgs _afterStop;

        private static void Stop(On.XB1CinematicVideoPlayer.orig_Stop orig, XB1CinematicVideoPlayer self)
        {
            Delegates.Params_Stop @params = new()
            {
                self = self
            };
            if (_beforeStop != null)
            {
                foreach (Delegates.Stop_BeforeArgs toInvoke in _beforeStop.GetInvocationList())
                {
                    try
                    {
                        _beforeStop?.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }
                }
            }

            self = @params.self;
            orig(self);
            if (_afterStop != null)
            {
                foreach (Delegates.Stop_AfterArgs toInvoke in _afterStop.GetInvocationList())
                {
                    try
                    {
                        _afterStop.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }
                }
            }
        }

        internal static void HookOnPrepareCompleted()
        {
            if (!HookedList.Contains("OnPrepareCompleted"))
            {
                HookedList.Add("OnPrepareCompleted");
                On.XB1CinematicVideoPlayer.OnPrepareCompleted += OnPrepareCompleted;
            }
        }

        internal static event Delegates.OnPrepareCompleted_BeforeArgs _beforeOnPrepareCompleted;
        internal static event Delegates.OnPrepareCompleted_AfterArgs _afterOnPrepareCompleted;

        private static void OnPrepareCompleted(On.XB1CinematicVideoPlayer.orig_OnPrepareCompleted orig,
            XB1CinematicVideoPlayer self, UnityEngine.Video.VideoPlayer source)
        {
            Delegates.Params_OnPrepareCompleted @params = new()
            {
                self = self, source = source
            };
            if (_beforeOnPrepareCompleted != null)
            {
                foreach (Delegates.OnPrepareCompleted_BeforeArgs toInvoke in
                         _beforeOnPrepareCompleted.GetInvocationList())
                {
                    try
                    {
                        _beforeOnPrepareCompleted?.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }
                }
            }

            self = @params.self;
            source = @params.source;
            orig(self, source);
            if (_afterOnPrepareCompleted != null)
            {
                foreach (Delegates.OnPrepareCompleted_AfterArgs toInvoke in
                         _afterOnPrepareCompleted.GetInvocationList())
                {
                    try
                    {
                        _afterOnPrepareCompleted.Invoke(@params);
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
        public sealed class Params_Dispose
        {
            public XB1CinematicVideoPlayer self;
        }

        public delegate void Dispose_BeforeArgs(Params_Dispose args);

        public delegate void Dispose_AfterArgs(Params_Dispose args);

        public delegate void Dispose_WithArgs(Action<XB1CinematicVideoPlayer> orig, XB1CinematicVideoPlayer self);

        public sealed class Params_get_Volume
        {
            public XB1CinematicVideoPlayer self;
        }

        public delegate void get_Volume_BeforeArgs(Params_get_Volume args);

        public delegate float get_Volume_AfterArgs(Params_get_Volume args, float ret);

        public delegate float get_Volume_WithArgs(Func<XB1CinematicVideoPlayer, float> orig,
            XB1CinematicVideoPlayer self);

        public sealed class Params_set_Volume
        {
            public XB1CinematicVideoPlayer self;
            public float value;
        }

        public delegate void set_Volume_BeforeArgs(Params_set_Volume args);

        public delegate void set_Volume_AfterArgs(Params_set_Volume args);

        public delegate void set_Volume_WithArgs(Action<XB1CinematicVideoPlayer, float> orig,
            XB1CinematicVideoPlayer self, float value);

        public sealed class Params_get_IsLoading
        {
            public XB1CinematicVideoPlayer self;
        }

        public delegate void get_IsLoading_BeforeArgs(Params_get_IsLoading args);

        public delegate bool get_IsLoading_AfterArgs(Params_get_IsLoading args, bool ret);

        public delegate bool get_IsLoading_WithArgs(Func<XB1CinematicVideoPlayer, bool> orig,
            XB1CinematicVideoPlayer self);

        public sealed class Params_get_IsLooping
        {
            public XB1CinematicVideoPlayer self;
        }

        public delegate void get_IsLooping_BeforeArgs(Params_get_IsLooping args);

        public delegate bool get_IsLooping_AfterArgs(Params_get_IsLooping args, bool ret);

        public delegate bool get_IsLooping_WithArgs(Func<XB1CinematicVideoPlayer, bool> orig,
            XB1CinematicVideoPlayer self);

        public sealed class Params_set_IsLooping
        {
            public XB1CinematicVideoPlayer self;
            public bool value;
        }

        public delegate void set_IsLooping_BeforeArgs(Params_set_IsLooping args);

        public delegate void set_IsLooping_AfterArgs(Params_set_IsLooping args);

        public delegate void set_IsLooping_WithArgs(Action<XB1CinematicVideoPlayer, bool> orig,
            XB1CinematicVideoPlayer self, bool value);

        public sealed class Params_get_IsPlaying
        {
            public XB1CinematicVideoPlayer self;
        }

        public delegate void get_IsPlaying_BeforeArgs(Params_get_IsPlaying args);

        public delegate bool get_IsPlaying_AfterArgs(Params_get_IsPlaying args, bool ret);

        public delegate bool get_IsPlaying_WithArgs(Func<XB1CinematicVideoPlayer, bool> orig,
            XB1CinematicVideoPlayer self);

        public sealed class Params_Play
        {
            public XB1CinematicVideoPlayer self;
        }

        public delegate void Play_BeforeArgs(Params_Play args);

        public delegate void Play_AfterArgs(Params_Play args);

        public delegate void Play_WithArgs(Action<XB1CinematicVideoPlayer> orig, XB1CinematicVideoPlayer self);

        public sealed class Params_Stop
        {
            public XB1CinematicVideoPlayer self;
        }

        public delegate void Stop_BeforeArgs(Params_Stop args);

        public delegate void Stop_AfterArgs(Params_Stop args);

        public delegate void Stop_WithArgs(Action<XB1CinematicVideoPlayer> orig, XB1CinematicVideoPlayer self);

        public sealed class Params_OnPrepareCompleted
        {
            public XB1CinematicVideoPlayer self;
            public UnityEngine.Video.VideoPlayer source;
        }

        public delegate void OnPrepareCompleted_BeforeArgs(Params_OnPrepareCompleted args);

        public delegate void OnPrepareCompleted_AfterArgs(Params_OnPrepareCompleted args);

        public delegate void OnPrepareCompleted_WithArgs(
            Action<XB1CinematicVideoPlayer, UnityEngine.Video.VideoPlayer> orig, XB1CinematicVideoPlayer self,
            UnityEngine.Video.VideoPlayer source);
    }

    /// <summary>
    /// Contains Hooks to that run code before orig(self) is called
    /// </summary>
    public static class BeforeOrig
    {
        public static event Delegates.Dispose_BeforeArgs Dispose
        {
            add
            {
                HookHandler._beforeDispose += value;
                HookHandler.HookDispose();
            }
            remove => HookHandler._beforeDispose -= value;
        }

        public static event Delegates.get_Volume_BeforeArgs get_Volume
        {
            add
            {
                HookHandler._beforeget_Volume += value;
                HookHandler.Hookget_Volume();
            }
            remove => HookHandler._beforeget_Volume -= value;
        }

        public static event Delegates.set_Volume_BeforeArgs set_Volume
        {
            add
            {
                HookHandler._beforeset_Volume += value;
                HookHandler.Hookset_Volume();
            }
            remove => HookHandler._beforeset_Volume -= value;
        }

        public static event Delegates.get_IsLoading_BeforeArgs get_IsLoading
        {
            add
            {
                HookHandler._beforeget_IsLoading += value;
                HookHandler.Hookget_IsLoading();
            }
            remove => HookHandler._beforeget_IsLoading -= value;
        }

        public static event Delegates.get_IsLooping_BeforeArgs get_IsLooping
        {
            add
            {
                HookHandler._beforeget_IsLooping += value;
                HookHandler.Hookget_IsLooping();
            }
            remove => HookHandler._beforeget_IsLooping -= value;
        }

        public static event Delegates.set_IsLooping_BeforeArgs set_IsLooping
        {
            add
            {
                HookHandler._beforeset_IsLooping += value;
                HookHandler.Hookset_IsLooping();
            }
            remove => HookHandler._beforeset_IsLooping -= value;
        }

        public static event Delegates.get_IsPlaying_BeforeArgs get_IsPlaying
        {
            add
            {
                HookHandler._beforeget_IsPlaying += value;
                HookHandler.Hookget_IsPlaying();
            }
            remove => HookHandler._beforeget_IsPlaying -= value;
        }

        public static event Delegates.Play_BeforeArgs Play
        {
            add
            {
                HookHandler._beforePlay += value;
                HookHandler.HookPlay();
            }
            remove => HookHandler._beforePlay -= value;
        }

        public static event Delegates.Stop_BeforeArgs Stop
        {
            add
            {
                HookHandler._beforeStop += value;
                HookHandler.HookStop();
            }
            remove => HookHandler._beforeStop -= value;
        }

        public static event Delegates.OnPrepareCompleted_BeforeArgs OnPrepareCompleted
        {
            add
            {
                HookHandler._beforeOnPrepareCompleted += value;
                HookHandler.HookOnPrepareCompleted();
            }
            remove => HookHandler._beforeOnPrepareCompleted -= value;
        }
    }

    /// <summary>
    /// Contains Hooks to that run code after orig(self) is called
    /// </summary>
    public static class AfterOrig
    {
        public static event Delegates.Dispose_AfterArgs Dispose
        {
            add
            {
                HookHandler._afterDispose += value;
                HookHandler.HookDispose();
            }
            remove => HookHandler._afterDispose -= value;
        }

        public static event Delegates.get_Volume_AfterArgs get_Volume
        {
            add
            {
                HookHandler._afterget_Volume += value;
                HookHandler.Hookget_Volume();
            }
            remove => HookHandler._afterget_Volume -= value;
        }

        public static event Delegates.set_Volume_AfterArgs set_Volume
        {
            add
            {
                HookHandler._afterset_Volume += value;
                HookHandler.Hookset_Volume();
            }
            remove => HookHandler._afterset_Volume -= value;
        }

        public static event Delegates.get_IsLoading_AfterArgs get_IsLoading
        {
            add
            {
                HookHandler._afterget_IsLoading += value;
                HookHandler.Hookget_IsLoading();
            }
            remove => HookHandler._afterget_IsLoading -= value;
        }

        public static event Delegates.get_IsLooping_AfterArgs get_IsLooping
        {
            add
            {
                HookHandler._afterget_IsLooping += value;
                HookHandler.Hookget_IsLooping();
            }
            remove => HookHandler._afterget_IsLooping -= value;
        }

        public static event Delegates.set_IsLooping_AfterArgs set_IsLooping
        {
            add
            {
                HookHandler._afterset_IsLooping += value;
                HookHandler.Hookset_IsLooping();
            }
            remove => HookHandler._afterset_IsLooping -= value;
        }

        public static event Delegates.get_IsPlaying_AfterArgs get_IsPlaying
        {
            add
            {
                HookHandler._afterget_IsPlaying += value;
                HookHandler.Hookget_IsPlaying();
            }
            remove => HookHandler._afterget_IsPlaying -= value;
        }

        public static event Delegates.Play_AfterArgs Play
        {
            add
            {
                HookHandler._afterPlay += value;
                HookHandler.HookPlay();
            }
            remove => HookHandler._afterPlay -= value;
        }

        public static event Delegates.Stop_AfterArgs Stop
        {
            add
            {
                HookHandler._afterStop += value;
                HookHandler.HookStop();
            }
            remove => HookHandler._afterStop -= value;
        }

        public static event Delegates.OnPrepareCompleted_AfterArgs OnPrepareCompleted
        {
            add
            {
                HookHandler._afterOnPrepareCompleted += value;
                HookHandler.HookOnPrepareCompleted();
            }
            remove => HookHandler._afterOnPrepareCompleted -= value;
        }
    }

    /// <summary>
    /// Contains all On Hooks, even those that aren't in the On namespace such as API generated functions and property getters/setters
    /// </summary>
    public static class WithOrig
    {
        public static event On.XB1CinematicVideoPlayer.hook_Dispose Dispose
        {
            add => On.XB1CinematicVideoPlayer.Dispose += value;
            remove => On.XB1CinematicVideoPlayer.Dispose -= value;
        }

        public static event Delegates.get_Volume_WithArgs get_Volume
        {
            add => HookEndpointManager.Add<Delegates.get_Volume_WithArgs>(
                ReflectionHelper.GetMethodInfo(typeof(XB1CinematicVideoPlayer), "get_Volume", true), value);
            remove => HookEndpointManager.Remove<Delegates.get_Volume_WithArgs>(
                ReflectionHelper.GetMethodInfo(typeof(XB1CinematicVideoPlayer), "get_Volume", true), value);
        }

        public static event Delegates.set_Volume_WithArgs set_Volume
        {
            add => HookEndpointManager.Add<Delegates.set_Volume_WithArgs>(
                ReflectionHelper.GetMethodInfo(typeof(XB1CinematicVideoPlayer), "set_Volume", true), value);
            remove => HookEndpointManager.Remove<Delegates.set_Volume_WithArgs>(
                ReflectionHelper.GetMethodInfo(typeof(XB1CinematicVideoPlayer), "set_Volume", true), value);
        }

        public static event Delegates.get_IsLoading_WithArgs get_IsLoading
        {
            add => HookEndpointManager.Add<Delegates.get_IsLoading_WithArgs>(
                ReflectionHelper.GetMethodInfo(typeof(XB1CinematicVideoPlayer), "get_IsLoading", true), value);
            remove => HookEndpointManager.Remove<Delegates.get_IsLoading_WithArgs>(
                ReflectionHelper.GetMethodInfo(typeof(XB1CinematicVideoPlayer), "get_IsLoading", true), value);
        }

        public static event Delegates.get_IsLooping_WithArgs get_IsLooping
        {
            add => HookEndpointManager.Add<Delegates.get_IsLooping_WithArgs>(
                ReflectionHelper.GetMethodInfo(typeof(XB1CinematicVideoPlayer), "get_IsLooping", true), value);
            remove => HookEndpointManager.Remove<Delegates.get_IsLooping_WithArgs>(
                ReflectionHelper.GetMethodInfo(typeof(XB1CinematicVideoPlayer), "get_IsLooping", true), value);
        }

        public static event Delegates.set_IsLooping_WithArgs set_IsLooping
        {
            add => HookEndpointManager.Add<Delegates.set_IsLooping_WithArgs>(
                ReflectionHelper.GetMethodInfo(typeof(XB1CinematicVideoPlayer), "set_IsLooping", true), value);
            remove => HookEndpointManager.Remove<Delegates.set_IsLooping_WithArgs>(
                ReflectionHelper.GetMethodInfo(typeof(XB1CinematicVideoPlayer), "set_IsLooping", true), value);
        }

        public static event Delegates.get_IsPlaying_WithArgs get_IsPlaying
        {
            add => HookEndpointManager.Add<Delegates.get_IsPlaying_WithArgs>(
                ReflectionHelper.GetMethodInfo(typeof(XB1CinematicVideoPlayer), "get_IsPlaying", true), value);
            remove => HookEndpointManager.Remove<Delegates.get_IsPlaying_WithArgs>(
                ReflectionHelper.GetMethodInfo(typeof(XB1CinematicVideoPlayer), "get_IsPlaying", true), value);
        }

        public static event On.XB1CinematicVideoPlayer.hook_Play Play
        {
            add => On.XB1CinematicVideoPlayer.Play += value;
            remove => On.XB1CinematicVideoPlayer.Play -= value;
        }

        public static event On.XB1CinematicVideoPlayer.hook_Stop Stop
        {
            add => On.XB1CinematicVideoPlayer.Stop += value;
            remove => On.XB1CinematicVideoPlayer.Stop -= value;
        }

        public static event On.XB1CinematicVideoPlayer.hook_OnPrepareCompleted OnPrepareCompleted
        {
            add => On.XB1CinematicVideoPlayer.OnPrepareCompleted += value;
            remove => On.XB1CinematicVideoPlayer.OnPrepareCompleted -= value;
        }
    }
}