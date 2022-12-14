using MonoMod.RuntimeDetour;
using MonoMod.RuntimeDetour.HookGen;

namespace HKMirror.Hooks.OnHooks;

/// <summary>
///     Contains different types of On Hooks for GGSetCanTransition class.<br />
///     Contains hooks that aren't generated by monomod, and before and after orig hooks for easier hooking.
/// </summary>
public static class OnGGSetCanTransition
{
    internal static class HookHandler
    {
        private static readonly List<string> HookedList = new();

        internal static void Hookset_BoolValue()
        {
            if (!HookedList.Contains("set_BoolValue"))
            {
                HookedList.Add("set_BoolValue");
                new Hook(ReflectionHelper.GetMethodInfo(typeof(GGSetCanTransition), "set_BoolValue"), set_BoolValue);
            }
        }

        internal static event Delegates.set_BoolValue_BeforeArgs _beforeset_BoolValue;
        internal static event Delegates.set_BoolValue_AfterArgs _afterset_BoolValue;

        private static void set_BoolValue(Action<GGSetCanTransition, bool> orig, GGSetCanTransition self, bool value)
        {
            Delegates.Params_set_BoolValue @params = new()
            {
                self = self, value = value
            };
            if (_beforeset_BoolValue != null)
                foreach (Delegates.set_BoolValue_BeforeArgs toInvoke in _beforeset_BoolValue.GetInvocationList())
                    try
                    {
                        _beforeset_BoolValue?.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }

            self = @params.self;
            value = @params.value;
            orig(self, value);
            if (_afterset_BoolValue != null)
                foreach (Delegates.set_BoolValue_AfterArgs toInvoke in _afterset_BoolValue.GetInvocationList())
                    try
                    {
                        _afterset_BoolValue.Invoke(@params);
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
        public delegate void set_BoolValue_AfterArgs(Params_set_BoolValue args);

        public delegate void set_BoolValue_BeforeArgs(Params_set_BoolValue args);

        public delegate void set_BoolValue_WithArgs(Action<GGSetCanTransition, bool> orig, GGSetCanTransition self,
            bool value);

        public sealed class Params_set_BoolValue
        {
            public GGSetCanTransition self;
            public bool value;
        }
    }

    /// <summary>
    ///     Contains Hooks to that run code before orig(self) is called
    /// </summary>
    public static class BeforeOrig
    {
        public static event Delegates.set_BoolValue_BeforeArgs set_BoolValue
        {
            add
            {
                HookHandler._beforeset_BoolValue += value;
                HookHandler.Hookset_BoolValue();
            }
            remove => HookHandler._beforeset_BoolValue -= value;
        }
    }

    /// <summary>
    ///     Contains Hooks to that run code after orig(self) is called
    /// </summary>
    public static class AfterOrig
    {
        public static event Delegates.set_BoolValue_AfterArgs set_BoolValue
        {
            add
            {
                HookHandler._afterset_BoolValue += value;
                HookHandler.Hookset_BoolValue();
            }
            remove => HookHandler._afterset_BoolValue -= value;
        }
    }

    /// <summary>
    ///     Contains all On Hooks, even those that aren't in the On namespace such as API generated functions and property
    ///     getters/setters
    /// </summary>
    public static class WithOrig
    {
        public static event Delegates.set_BoolValue_WithArgs set_BoolValue
        {
            add => HookEndpointManager.Add<Delegates.set_BoolValue_WithArgs>(
                ReflectionHelper.GetMethodInfo(typeof(GGSetCanTransition), "set_BoolValue"), value);
            remove => HookEndpointManager.Remove<Delegates.set_BoolValue_WithArgs>(
                ReflectionHelper.GetMethodInfo(typeof(GGSetCanTransition), "set_BoolValue"), value);
        }
    }
}