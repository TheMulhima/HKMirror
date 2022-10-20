using InControl.UnityDeviceProfiles;
using MonoMod.RuntimeDetour;
using MonoMod.RuntimeDetour.HookGen;

namespace HKMirror.Hooks.OnHooks;

/// <summary>
///     Contains different types of On Hooks for IpegaPG9068AndroidUnityProfile class.<br />
///     Contains hooks that aren't generated by monomod, and before and after orig hooks for easier hooking.
/// </summary>
public static class OnIpegaPG9068AndroidUnityProfile
{
    internal static class HookHandler
    {
        private static readonly List<string> HookedList = new();

        internal static void HookDefine()
        {
            if (!HookedList.Contains("Define"))
            {
                HookedList.Add("Define");
                new Hook(ReflectionHelper.GetMethodInfo(typeof(IpegaPG9068AndroidUnityProfile), "Define"), Define);
            }
        }

        internal static event Delegates.Define_BeforeArgs _beforeDefine;
        internal static event Delegates.Define_NormalArgs _afterDefine;

        private static void Define(Action<IpegaPG9068AndroidUnityProfile> orig, IpegaPG9068AndroidUnityProfile self)
        {
            Delegates.Params_Define @params = new()
            {
                self = self
            };
            _beforeDefine?.Invoke(@params);
            self = @params.self;
            orig(self);
            if (_afterDefine != null) _afterDefine.Invoke(@params);
        }
    }

    /// <summary>
    ///     Contains necessary information to create Hooks. Does not contain any hooks
    /// </summary>
    public static class Delegates
    {
        public delegate void Define_BeforeArgs(Params_Define args);

        public delegate void Define_NormalArgs(Params_Define args);

        public sealed class Params_Define
        {
            public IpegaPG9068AndroidUnityProfile self;
        }
    }

    /// <summary>
    ///     Contains Hooks to that run code before orig(self) is called
    /// </summary>
    public static class BeforeOrig
    {
        public static event Delegates.Define_BeforeArgs Define
        {
            add
            {
                HookHandler._beforeDefine += value;
                HookHandler.HookDefine();
            }
            remove => HookHandler._beforeDefine -= value;
        }
    }

    /// <summary>
    ///     Contains Hooks to that run code after orig(self) is called
    /// </summary>
    public static class AfterOrig
    {
        public static event Delegates.Define_NormalArgs Define
        {
            add
            {
                HookHandler._afterDefine += value;
                HookHandler.HookDefine();
            }
            remove => HookHandler._afterDefine -= value;
        }
    }

    /// <summary>
    ///     Contains all On Hooks, even those that aren't in the On namespace such as API generated functions and property
    ///     getters/setters
    /// </summary>
    public static class WithOrig
    {
        public static event Delegates.Define_NormalArgs Define
        {
            add => HookEndpointManager.Add<Delegates.Define_NormalArgs>(
                ReflectionHelper.GetMethodInfo(typeof(IpegaPG9068AndroidUnityProfile), "Define"), value);
            remove => HookEndpointManager.Remove<Delegates.Define_NormalArgs>(
                ReflectionHelper.GetMethodInfo(typeof(IpegaPG9068AndroidUnityProfile), "Define"), value);
        }
    }
}