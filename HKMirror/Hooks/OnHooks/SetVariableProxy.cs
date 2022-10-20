using Modding.Delegates;
using MonoMod.RuntimeDetour;
using MonoMod.RuntimeDetour.HookGen;

namespace HKMirror.Hooks.OnHooks;

/// <summary>
///     Contains different types of On Hooks for SetVariableProxy class.<br />
///     Contains hooks that aren't generated by monomod, and before and after orig hooks for easier hooking.
/// </summary>
public static class OnSetVariableProxy
{
    internal static class HookHandler
    {
        private static readonly List<string> HookedList = new();

        internal static void HookInvoke()
        {
            if (!HookedList.Contains("Invoke"))
            {
                HookedList.Add("Invoke");
                new Hook(ReflectionHelper.GetMethodInfo(typeof(SetVariableProxy), "Invoke"), Invoke);
            }
        }

        internal static event Delegates.Invoke_BeforeArgs _beforeInvoke;
        internal static event Delegates.Invoke_NormalArgs _afterInvoke;

        private static object Invoke(Func<SetVariableProxy, Type, string, object, object> orig, SetVariableProxy self,
            Type type, string name, object value)
        {
            Delegates.Params_Invoke @params = new()
            {
                self = self, type = type, name = name, value = value
            };
            _beforeInvoke?.Invoke(@params);
            self = @params.self;
            type = @params.type;
            name = @params.name;
            value = @params.value;
            var retVal = orig(self, type, name, value);
            if (_afterInvoke != null) retVal = _afterInvoke.Invoke(@params);
            return retVal;
        }

        internal static void HookEndInvoke()
        {
            if (!HookedList.Contains("EndInvoke"))
            {
                HookedList.Add("EndInvoke");
                new Hook(ReflectionHelper.GetMethodInfo(typeof(SetVariableProxy), "EndInvoke"), EndInvoke);
            }
        }

        internal static event Delegates.EndInvoke_BeforeArgs _beforeEndInvoke;
        internal static event Delegates.EndInvoke_NormalArgs _afterEndInvoke;

        private static object EndInvoke(Func<SetVariableProxy, IAsyncResult, object> orig, SetVariableProxy self,
            IAsyncResult result)
        {
            Delegates.Params_EndInvoke @params = new()
            {
                self = self, result = result
            };
            _beforeEndInvoke?.Invoke(@params);
            self = @params.self;
            result = @params.result;
            var retVal = orig(self, result);
            if (_afterEndInvoke != null) retVal = _afterEndInvoke.Invoke(@params);
            return retVal;
        }
    }

    /// <summary>
    ///     Contains necessary information to create Hooks. Does not contain any hooks
    /// </summary>
    public static class Delegates
    {
        public delegate void EndInvoke_BeforeArgs(Params_EndInvoke args);

        public delegate object EndInvoke_NormalArgs(Params_EndInvoke args);

        public delegate void Invoke_BeforeArgs(Params_Invoke args);

        public delegate object Invoke_NormalArgs(Params_Invoke args);

        public sealed class Params_Invoke
        {
            public string name;
            public SetVariableProxy self;
            public Type type;
            public object value;
        }

        public sealed class Params_EndInvoke
        {
            public IAsyncResult result;
            public SetVariableProxy self;
        }
    }

    /// <summary>
    ///     Contains Hooks to that run code before orig(self) is called
    /// </summary>
    public static class BeforeOrig
    {
        public static event Delegates.Invoke_BeforeArgs Invoke
        {
            add
            {
                HookHandler._beforeInvoke += value;
                HookHandler.HookInvoke();
            }
            remove => HookHandler._beforeInvoke -= value;
        }

        public static event Delegates.EndInvoke_BeforeArgs EndInvoke
        {
            add
            {
                HookHandler._beforeEndInvoke += value;
                HookHandler.HookEndInvoke();
            }
            remove => HookHandler._beforeEndInvoke -= value;
        }
    }

    /// <summary>
    ///     Contains Hooks to that run code after orig(self) is called
    /// </summary>
    public static class AfterOrig
    {
        public static event Delegates.Invoke_NormalArgs Invoke
        {
            add
            {
                HookHandler._afterInvoke += value;
                HookHandler.HookInvoke();
            }
            remove => HookHandler._afterInvoke -= value;
        }

        public static event Delegates.EndInvoke_NormalArgs EndInvoke
        {
            add
            {
                HookHandler._afterEndInvoke += value;
                HookHandler.HookEndInvoke();
            }
            remove => HookHandler._afterEndInvoke -= value;
        }
    }

    /// <summary>
    ///     Contains all On Hooks, even those that aren't in the On namespace such as API generated functions and property
    ///     getters/setters
    /// </summary>
    public static class WithOrig
    {
        public static event Delegates.Invoke_NormalArgs Invoke
        {
            add => HookEndpointManager.Add<Delegates.Invoke_NormalArgs>(
                ReflectionHelper.GetMethodInfo(typeof(SetVariableProxy), "Invoke"), value);
            remove => HookEndpointManager.Remove<Delegates.Invoke_NormalArgs>(
                ReflectionHelper.GetMethodInfo(typeof(SetVariableProxy), "Invoke"), value);
        }

        public static event Delegates.EndInvoke_NormalArgs EndInvoke
        {
            add => HookEndpointManager.Add<Delegates.EndInvoke_NormalArgs>(
                ReflectionHelper.GetMethodInfo(typeof(SetVariableProxy), "EndInvoke"), value);
            remove => HookEndpointManager.Remove<Delegates.EndInvoke_NormalArgs>(
                ReflectionHelper.GetMethodInfo(typeof(SetVariableProxy), "EndInvoke"), value);
        }
    }
}