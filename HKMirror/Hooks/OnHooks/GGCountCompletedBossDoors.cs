using MonoMod.RuntimeDetour;
using MonoMod.RuntimeDetour.HookGen;

namespace HKMirror.Hooks.OnHooks;

/// <summary>
///     Contains different types of On Hooks for GGCountCompletedBossDoors class.<br />
///     Contains hooks that aren't generated by monomod, and before and after orig hooks for easier hooking.
/// </summary>
public static class OnGGCountCompletedBossDoors
{
    internal static class HookHandler
    {
        private static readonly List<string> HookedList = new();

        internal static void Hookget_IntValue()
        {
            if (!HookedList.Contains("get_IntValue"))
            {
                HookedList.Add("get_IntValue");
                new Hook(ReflectionHelper.GetMethodInfo(typeof(GGCountCompletedBossDoors), "get_IntValue"),
                    get_IntValue);
            }
        }

        internal static event Delegates.get_IntValue_BeforeArgs _beforeget_IntValue;
        internal static event Delegates.get_IntValue_AfterArgs _afterget_IntValue;

        private static int get_IntValue(Func<GGCountCompletedBossDoors, int> orig, GGCountCompletedBossDoors self)
        {
            Delegates.Params_get_IntValue @params = new()
            {
                self = self
            };
            if (_beforeget_IntValue != null)
                foreach (Delegates.get_IntValue_BeforeArgs toInvoke in _beforeget_IntValue.GetInvocationList())
                    try
                    {
                        _beforeget_IntValue?.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }

            self = @params.self;
            var retVal = orig(self);
            if (_afterget_IntValue != null)
                foreach (Delegates.get_IntValue_AfterArgs toInvoke in _afterget_IntValue.GetInvocationList())
                    try
                    {
                        retVal = _afterget_IntValue.Invoke(@params, retVal);
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
        public delegate int get_IntValue_AfterArgs(Params_get_IntValue args, int ret);

        public delegate void get_IntValue_BeforeArgs(Params_get_IntValue args);

        public delegate int get_IntValue_WithArgs(Func<GGCountCompletedBossDoors, int> orig,
            GGCountCompletedBossDoors self);

        public sealed class Params_get_IntValue
        {
            public GGCountCompletedBossDoors self;
        }
    }

    /// <summary>
    ///     Contains Hooks to that run code before orig(self) is called
    /// </summary>
    public static class BeforeOrig
    {
        public static event Delegates.get_IntValue_BeforeArgs get_IntValue
        {
            add
            {
                HookHandler._beforeget_IntValue += value;
                HookHandler.Hookget_IntValue();
            }
            remove => HookHandler._beforeget_IntValue -= value;
        }
    }

    /// <summary>
    ///     Contains Hooks to that run code after orig(self) is called
    /// </summary>
    public static class AfterOrig
    {
        public static event Delegates.get_IntValue_AfterArgs get_IntValue
        {
            add
            {
                HookHandler._afterget_IntValue += value;
                HookHandler.Hookget_IntValue();
            }
            remove => HookHandler._afterget_IntValue -= value;
        }
    }

    /// <summary>
    ///     Contains all On Hooks, even those that aren't in the On namespace such as API generated functions and property
    ///     getters/setters
    /// </summary>
    public static class WithOrig
    {
        public static event Delegates.get_IntValue_WithArgs get_IntValue
        {
            add => HookEndpointManager.Add<Delegates.get_IntValue_WithArgs>(
                ReflectionHelper.GetMethodInfo(typeof(GGCountCompletedBossDoors), "get_IntValue"), value);
            remove => HookEndpointManager.Remove<Delegates.get_IntValue_WithArgs>(
                ReflectionHelper.GetMethodInfo(typeof(GGCountCompletedBossDoors), "get_IntValue"), value);
        }
    }
}