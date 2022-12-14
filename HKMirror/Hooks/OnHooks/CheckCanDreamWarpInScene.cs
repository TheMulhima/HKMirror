using MonoMod.RuntimeDetour;
using MonoMod.RuntimeDetour.HookGen;

namespace HKMirror.Hooks.OnHooks;

/// <summary>
///     Contains different types of On Hooks for CheckCanDreamWarpInScene class.<br />
///     Contains hooks that aren't generated by monomod, and before and after orig hooks for easier hooking.
/// </summary>
public static class OnCheckCanDreamWarpInScene
{
    internal static class HookHandler
    {
        private static readonly List<string> HookedList = new();

        internal static void Hookget_IsTrue()
        {
            if (!HookedList.Contains("get_IsTrue"))
            {
                HookedList.Add("get_IsTrue");
                new Hook(ReflectionHelper.GetMethodInfo(typeof(CheckCanDreamWarpInScene), "get_IsTrue"), get_IsTrue);
            }
        }

        internal static event Delegates.get_IsTrue_BeforeArgs _beforeget_IsTrue;
        internal static event Delegates.get_IsTrue_AfterArgs _afterget_IsTrue;

        private static bool get_IsTrue(Func<CheckCanDreamWarpInScene, bool> orig, CheckCanDreamWarpInScene self)
        {
            Delegates.Params_get_IsTrue @params = new()
            {
                self = self
            };
            if (_beforeget_IsTrue != null)
                foreach (Delegates.get_IsTrue_BeforeArgs toInvoke in _beforeget_IsTrue.GetInvocationList())
                    try
                    {
                        _beforeget_IsTrue?.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }

            self = @params.self;
            var retVal = orig(self);
            if (_afterget_IsTrue != null)
                foreach (Delegates.get_IsTrue_AfterArgs toInvoke in _afterget_IsTrue.GetInvocationList())
                    try
                    {
                        retVal = _afterget_IsTrue.Invoke(@params, retVal);
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
        public delegate bool get_IsTrue_AfterArgs(Params_get_IsTrue args, bool ret);

        public delegate void get_IsTrue_BeforeArgs(Params_get_IsTrue args);

        public delegate bool get_IsTrue_WithArgs(Func<CheckCanDreamWarpInScene, bool> orig,
            CheckCanDreamWarpInScene self);

        public sealed class Params_get_IsTrue
        {
            public CheckCanDreamWarpInScene self;
        }
    }

    /// <summary>
    ///     Contains Hooks to that run code before orig(self) is called
    /// </summary>
    public static class BeforeOrig
    {
        public static event Delegates.get_IsTrue_BeforeArgs get_IsTrue
        {
            add
            {
                HookHandler._beforeget_IsTrue += value;
                HookHandler.Hookget_IsTrue();
            }
            remove => HookHandler._beforeget_IsTrue -= value;
        }
    }

    /// <summary>
    ///     Contains Hooks to that run code after orig(self) is called
    /// </summary>
    public static class AfterOrig
    {
        public static event Delegates.get_IsTrue_AfterArgs get_IsTrue
        {
            add
            {
                HookHandler._afterget_IsTrue += value;
                HookHandler.Hookget_IsTrue();
            }
            remove => HookHandler._afterget_IsTrue -= value;
        }
    }

    /// <summary>
    ///     Contains all On Hooks, even those that aren't in the On namespace such as API generated functions and property
    ///     getters/setters
    /// </summary>
    public static class WithOrig
    {
        public static event Delegates.get_IsTrue_WithArgs get_IsTrue
        {
            add => HookEndpointManager.Add<Delegates.get_IsTrue_WithArgs>(
                ReflectionHelper.GetMethodInfo(typeof(CheckCanDreamWarpInScene), "get_IsTrue"), value);
            remove => HookEndpointManager.Remove<Delegates.get_IsTrue_WithArgs>(
                ReflectionHelper.GetMethodInfo(typeof(CheckCanDreamWarpInScene), "get_IsTrue"), value);
        }
    }
}