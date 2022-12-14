using MonoMod.RuntimeDetour;
using MonoMod.RuntimeDetour.HookGen;

namespace HKMirror.Hooks.OnHooks;

/// <summary>
///     Contains different types of On Hooks for PlatformSimulation class.<br />
///     Contains hooks that aren't generated by monomod, and before and after orig hooks for easier hooking.
/// </summary>
public static class OnPlatformSimulation
{
    internal static class HookHandler
    {
        private static readonly List<string> HookedList = new();

        internal static void Hookget_IsPlatformSimulationEnabled()
        {
            if (!HookedList.Contains("get_IsPlatformSimulationEnabled"))
            {
                HookedList.Add("get_IsPlatformSimulationEnabled");
                new Hook(
                    ReflectionHelper.GetMethodInfo(typeof(PlatformSimulation), "get_IsPlatformSimulationEnabled",
                        false), get_IsPlatformSimulationEnabled);
            }
        }

        internal static event Delegates.get_IsPlatformSimulationEnabled_BeforeArgs
            _beforeget_IsPlatformSimulationEnabled;

        internal static event Delegates.get_IsPlatformSimulationEnabled_AfterArgs _afterget_IsPlatformSimulationEnabled;

        private static bool get_IsPlatformSimulationEnabled(Func<bool> orig)
        {
            if (_beforeget_IsPlatformSimulationEnabled != null)
                foreach (Delegates.get_IsPlatformSimulationEnabled_BeforeArgs toInvoke in
                         _beforeget_IsPlatformSimulationEnabled.GetInvocationList())
                    try
                    {
                        _beforeget_IsPlatformSimulationEnabled?.Invoke();
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }

            var retVal = orig();
            if (_afterget_IsPlatformSimulationEnabled != null)
                foreach (Delegates.get_IsPlatformSimulationEnabled_AfterArgs toInvoke in
                         _afterget_IsPlatformSimulationEnabled.GetInvocationList())
                    try
                    {
                        retVal = _afterget_IsPlatformSimulationEnabled.Invoke(retVal);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }

            return retVal;
        }
    }

    /// <summary>
    ///     Contains necessary information to create Hooks. Does not contain any hooks
    /// </summary>
    public static class Delegates
    {
        public delegate bool get_IsPlatformSimulationEnabled_AfterArgs(bool ret);

        public delegate void get_IsPlatformSimulationEnabled_BeforeArgs();

        public delegate bool get_IsPlatformSimulationEnabled_WithArgs(Func<bool> orig);
    }

    /// <summary>
    ///     Contains Hooks to that run code before orig(self) is called
    /// </summary>
    public static class BeforeOrig
    {
        public static event Delegates.get_IsPlatformSimulationEnabled_BeforeArgs get_IsPlatformSimulationEnabled
        {
            add
            {
                HookHandler._beforeget_IsPlatformSimulationEnabled += value;
                HookHandler.Hookget_IsPlatformSimulationEnabled();
            }
            remove => HookHandler._beforeget_IsPlatformSimulationEnabled -= value;
        }
    }

    /// <summary>
    ///     Contains Hooks to that run code after orig(self) is called
    /// </summary>
    public static class AfterOrig
    {
        public static event Delegates.get_IsPlatformSimulationEnabled_AfterArgs get_IsPlatformSimulationEnabled
        {
            add
            {
                HookHandler._afterget_IsPlatformSimulationEnabled += value;
                HookHandler.Hookget_IsPlatformSimulationEnabled();
            }
            remove => HookHandler._afterget_IsPlatformSimulationEnabled -= value;
        }
    }

    /// <summary>
    ///     Contains all On Hooks, even those that aren't in the On namespace such as API generated functions and property
    ///     getters/setters
    /// </summary>
    public static class WithOrig
    {
        public static event Delegates.get_IsPlatformSimulationEnabled_WithArgs get_IsPlatformSimulationEnabled
        {
            add => HookEndpointManager.Add<Delegates.get_IsPlatformSimulationEnabled_WithArgs>(
                ReflectionHelper.GetMethodInfo(typeof(PlatformSimulation), "get_IsPlatformSimulationEnabled", false),
                value);
            remove => HookEndpointManager.Remove<Delegates.get_IsPlatformSimulationEnabled_WithArgs>(
                ReflectionHelper.GetMethodInfo(typeof(PlatformSimulation), "get_IsPlatformSimulationEnabled", false),
                value);
        }
    }
}