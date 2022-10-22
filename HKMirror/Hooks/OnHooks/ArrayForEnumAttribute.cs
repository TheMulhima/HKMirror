using MonoMod.RuntimeDetour;
using MonoMod.RuntimeDetour.HookGen;

namespace HKMirror.Hooks.OnHooks;

/// <summary>
///     Contains different types of On Hooks for ArrayForEnumAttribute class.<br />
///     Contains hooks that aren't generated by monomod, and before and after orig hooks for easier hooking.
/// </summary>
public static class OnArrayForEnumAttribute
{
    internal static class HookHandler
    {
        private static readonly List<string> HookedList = new();

        internal static void Hookget_IsValid()
        {
            if (!HookedList.Contains("get_IsValid"))
            {
                HookedList.Add("get_IsValid");
                new Hook(ReflectionHelper.GetMethodInfo(typeof(ArrayForEnumAttribute), "get_IsValid"), get_IsValid);
            }
        }

        internal static event Delegates.get_IsValid_BeforeArgs _beforeget_IsValid;
        internal static event Delegates.get_IsValid_AfterArgs _afterget_IsValid;

        private static bool get_IsValid(Func<ArrayForEnumAttribute, bool> orig, ArrayForEnumAttribute self)
        {
            Delegates.Params_get_IsValid @params = new()
            {
                self = self
            };
            if (_beforeget_IsValid != null)
                foreach (Delegates.get_IsValid_BeforeArgs toInvoke in _beforeget_IsValid.GetInvocationList())
                    try
                    {
                        _beforeget_IsValid?.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }

            self = @params.self;
            var retVal = orig(self);
            if (_afterget_IsValid != null)
                foreach (Delegates.get_IsValid_AfterArgs toInvoke in _afterget_IsValid.GetInvocationList())
                    try
                    {
                        retVal = _afterget_IsValid.Invoke(@params, retVal);
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
        public delegate bool get_IsValid_AfterArgs(Params_get_IsValid args, bool ret);

        public delegate void get_IsValid_BeforeArgs(Params_get_IsValid args);

        public delegate bool get_IsValid_WithArgs(Func<ArrayForEnumAttribute, bool> orig, ArrayForEnumAttribute self);

        public sealed class Params_get_IsValid
        {
            public ArrayForEnumAttribute self;
        }
    }

    /// <summary>
    ///     Contains Hooks to that run code before orig(self) is called
    /// </summary>
    public static class BeforeOrig
    {
        public static event Delegates.get_IsValid_BeforeArgs get_IsValid
        {
            add
            {
                HookHandler._beforeget_IsValid += value;
                HookHandler.Hookget_IsValid();
            }
            remove => HookHandler._beforeget_IsValid -= value;
        }
    }

    /// <summary>
    ///     Contains Hooks to that run code after orig(self) is called
    /// </summary>
    public static class AfterOrig
    {
        public static event Delegates.get_IsValid_AfterArgs get_IsValid
        {
            add
            {
                HookHandler._afterget_IsValid += value;
                HookHandler.Hookget_IsValid();
            }
            remove => HookHandler._afterget_IsValid -= value;
        }
    }

    /// <summary>
    ///     Contains all On Hooks, even those that aren't in the On namespace such as API generated functions and property
    ///     getters/setters
    /// </summary>
    public static class WithOrig
    {
        public static event Delegates.get_IsValid_WithArgs get_IsValid
        {
            add => HookEndpointManager.Add<Delegates.get_IsValid_WithArgs>(
                ReflectionHelper.GetMethodInfo(typeof(ArrayForEnumAttribute), "get_IsValid"), value);
            remove => HookEndpointManager.Remove<Delegates.get_IsValid_WithArgs>(
                ReflectionHelper.GetMethodInfo(typeof(ArrayForEnumAttribute), "get_IsValid"), value);
        }
    }
}