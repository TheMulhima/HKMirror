using InControl.UnityDeviceProfiles;
using MonoMod.RuntimeDetour;
using MonoMod.RuntimeDetour.HookGen;

namespace HKMirror.Hooks.OnHooks;

/// <summary>
///     Contains different types of On Hooks for EightBitdoFC30ProAndroidUnityProfile class.<br />
///     Contains hooks that aren't generated by monomod, and before and after orig hooks for easier hooking.
/// </summary>
public static class OnEightBitdoFC30ProAndroidUnityProfile
{
    internal static class HookHandler
    {
        private static readonly List<string> HookedList = new();

        internal static void HookDefine()
        {
            if (!HookedList.Contains("Define"))
            {
                HookedList.Add("Define");
                new Hook(ReflectionHelper.GetMethodInfo(typeof(EightBitdoFC30ProAndroidUnityProfile), "Define"),
                    Define);
            }
        }

        internal static event Delegates.Define_BeforeArgs _beforeDefine;
        internal static event Delegates.Define_AfterArgs _afterDefine;

        private static void Define(Action<EightBitdoFC30ProAndroidUnityProfile> orig,
            EightBitdoFC30ProAndroidUnityProfile self)
        {
            Delegates.Params_Define @params = new()
            {
                self = self
            };
            if (_beforeDefine != null)
                foreach (Delegates.Define_BeforeArgs toInvoke in _beforeDefine.GetInvocationList())
                    try
                    {
                        _beforeDefine?.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }

            self = @params.self;
            orig(self);
            if (_afterDefine != null)
                foreach (Delegates.Define_AfterArgs toInvoke in _afterDefine.GetInvocationList())
                    try
                    {
                        _afterDefine.Invoke(@params);
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
        public delegate void Define_AfterArgs(Params_Define args);

        public delegate void Define_BeforeArgs(Params_Define args);

        public delegate void Define_WithArgs(Action<EightBitdoFC30ProAndroidUnityProfile> orig,
            EightBitdoFC30ProAndroidUnityProfile self);

        public sealed class Params_Define
        {
            public EightBitdoFC30ProAndroidUnityProfile self;
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
        public static event Delegates.Define_AfterArgs Define
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
        public static event Delegates.Define_WithArgs Define
        {
            add => HookEndpointManager.Add<Delegates.Define_WithArgs>(
                ReflectionHelper.GetMethodInfo(typeof(EightBitdoFC30ProAndroidUnityProfile), "Define"), value);
            remove => HookEndpointManager.Remove<Delegates.Define_WithArgs>(
                ReflectionHelper.GetMethodInfo(typeof(EightBitdoFC30ProAndroidUnityProfile), "Define"), value);
        }
    }
}