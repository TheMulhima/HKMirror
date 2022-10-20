using MonoMod.RuntimeDetour;
using MonoMod.RuntimeDetour.HookGen;

namespace HKMirror.Hooks.OnHooks;

/// <summary>
///     Contains different types of On Hooks for tk2dUIAudioManager class.<br />
///     Contains hooks that aren't generated by monomod, and before and after orig hooks for easier hooking.
/// </summary>
public static class Ontk2dUIAudioManager
{
    internal static class HookHandler
    {
        private static readonly List<string> HookedList = new();

        internal static void Hookget_Instance()
        {
            if (!HookedList.Contains("get_Instance"))
            {
                HookedList.Add("get_Instance");
                new Hook(ReflectionHelper.GetMethodInfo(typeof(tk2dUIAudioManager), "get_Instance", false),
                    get_Instance);
            }
        }

        internal static event Delegates.get_Instance_BeforeArgs _beforeget_Instance;
        internal static event Delegates.get_Instance_NormalArgs _afterget_Instance;

        private static tk2dUIAudioManager get_Instance(Func<tk2dUIAudioManager> orig)
        {
            _beforeget_Instance?.Invoke();
            var retVal = orig();
            if (_afterget_Instance != null) retVal = _afterget_Instance.Invoke();
            return retVal;
        }

        internal static void HookAwake()
        {
            if (!HookedList.Contains("Awake"))
            {
                HookedList.Add("Awake");
                On.tk2dUIAudioManager.Awake += Awake;
            }
        }

        internal static event Delegates.Awake_BeforeArgs _beforeAwake;
        internal static event Delegates.Awake_NormalArgs _afterAwake;

        private static void Awake(On.tk2dUIAudioManager.orig_Awake orig, tk2dUIAudioManager self)
        {
            Delegates.Params_Awake @params = new()
            {
                self = self
            };
            _beforeAwake?.Invoke(@params);
            self = @params.self;
            orig(self);
            if (_afterAwake != null) _afterAwake.Invoke(@params);
        }

        internal static void HookSetup()
        {
            if (!HookedList.Contains("Setup"))
            {
                HookedList.Add("Setup");
                On.tk2dUIAudioManager.Setup += Setup;
            }
        }

        internal static event Delegates.Setup_BeforeArgs _beforeSetup;
        internal static event Delegates.Setup_NormalArgs _afterSetup;

        private static void Setup(On.tk2dUIAudioManager.orig_Setup orig, tk2dUIAudioManager self)
        {
            Delegates.Params_Setup @params = new()
            {
                self = self
            };
            _beforeSetup?.Invoke(@params);
            self = @params.self;
            orig(self);
            if (_afterSetup != null) _afterSetup.Invoke(@params);
        }

        internal static void HookPlay()
        {
            if (!HookedList.Contains("Play"))
            {
                HookedList.Add("Play");
                On.tk2dUIAudioManager.Play += Play;
            }
        }

        internal static event Delegates.Play_BeforeArgs _beforePlay;
        internal static event Delegates.Play_NormalArgs _afterPlay;

        private static void Play(On.tk2dUIAudioManager.orig_Play orig, tk2dUIAudioManager self, AudioClip clip)
        {
            Delegates.Params_Play @params = new()
            {
                self = self, clip = clip
            };
            _beforePlay?.Invoke(@params);
            self = @params.self;
            clip = @params.clip;
            orig(self, clip);
            if (_afterPlay != null) _afterPlay.Invoke(@params);
        }
    }

    /// <summary>
    ///     Contains necessary information to create Hooks. Does not contain any hooks
    /// </summary>
    public static class Delegates
    {
        public delegate void Awake_BeforeArgs(Params_Awake args);

        public delegate void Awake_NormalArgs(Params_Awake args);

        public delegate void get_Instance_BeforeArgs();

        public delegate tk2dUIAudioManager get_Instance_NormalArgs();

        public delegate void Play_BeforeArgs(Params_Play args);

        public delegate void Play_NormalArgs(Params_Play args);

        public delegate void Setup_BeforeArgs(Params_Setup args);

        public delegate void Setup_NormalArgs(Params_Setup args);

        public sealed class Params_Awake
        {
            public tk2dUIAudioManager self;
        }

        public sealed class Params_Setup
        {
            public tk2dUIAudioManager self;
        }

        public sealed class Params_Play
        {
            public AudioClip clip;
            public tk2dUIAudioManager self;
        }
    }

    /// <summary>
    ///     Contains Hooks to that run code before orig(self) is called
    /// </summary>
    public static class BeforeOrig
    {
        public static event Delegates.get_Instance_BeforeArgs get_Instance
        {
            add
            {
                HookHandler._beforeget_Instance += value;
                HookHandler.Hookget_Instance();
            }
            remove => HookHandler._beforeget_Instance -= value;
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

        public static event Delegates.Setup_BeforeArgs Setup
        {
            add
            {
                HookHandler._beforeSetup += value;
                HookHandler.HookSetup();
            }
            remove => HookHandler._beforeSetup -= value;
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
    }

    /// <summary>
    ///     Contains Hooks to that run code after orig(self) is called
    /// </summary>
    public static class AfterOrig
    {
        public static event Delegates.get_Instance_NormalArgs get_Instance
        {
            add
            {
                HookHandler._afterget_Instance += value;
                HookHandler.Hookget_Instance();
            }
            remove => HookHandler._afterget_Instance -= value;
        }

        public static event Delegates.Awake_NormalArgs Awake
        {
            add
            {
                HookHandler._afterAwake += value;
                HookHandler.HookAwake();
            }
            remove => HookHandler._afterAwake -= value;
        }

        public static event Delegates.Setup_NormalArgs Setup
        {
            add
            {
                HookHandler._afterSetup += value;
                HookHandler.HookSetup();
            }
            remove => HookHandler._afterSetup -= value;
        }

        public static event Delegates.Play_NormalArgs Play
        {
            add
            {
                HookHandler._afterPlay += value;
                HookHandler.HookPlay();
            }
            remove => HookHandler._afterPlay -= value;
        }
    }

    /// <summary>
    ///     Contains all On Hooks, even those that aren't in the On namespace such as API generated functions and property
    ///     getters/setters
    /// </summary>
    public static class WithOrig
    {
        public static event Delegates.get_Instance_NormalArgs get_Instance
        {
            add => HookEndpointManager.Add<Delegates.get_Instance_NormalArgs>(
                ReflectionHelper.GetMethodInfo(typeof(tk2dUIAudioManager), "get_Instance", false), value);
            remove => HookEndpointManager.Remove<Delegates.get_Instance_NormalArgs>(
                ReflectionHelper.GetMethodInfo(typeof(tk2dUIAudioManager), "get_Instance", false), value);
        }

        public static event On.tk2dUIAudioManager.hook_Awake Awake
        {
            add => On.tk2dUIAudioManager.Awake += value;
            remove => On.tk2dUIAudioManager.Awake -= value;
        }

        public static event On.tk2dUIAudioManager.hook_Setup Setup
        {
            add => On.tk2dUIAudioManager.Setup += value;
            remove => On.tk2dUIAudioManager.Setup -= value;
        }

        public static event On.tk2dUIAudioManager.hook_Play Play
        {
            add => On.tk2dUIAudioManager.Play += value;
            remove => On.tk2dUIAudioManager.Play -= value;
        }
    }
}