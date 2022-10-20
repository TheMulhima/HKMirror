using Modding.Delegates;
using MonoMod.RuntimeDetour;
using MonoMod.RuntimeDetour.HookGen;

namespace HKMirror.Hooks.OnHooks;

/// <summary>
///     Contains different types of On Hooks for SetBoolProxy class.<br />
///     Contains hooks that aren't generated by monomod, and before and after orig hooks for easier hooking.
/// </summary>
public static class OnSetBoolProxy
{
    internal static class HookHandler
    {
        private static readonly List<string> HookedList = new();

        internal static void HookInvoke()
        {
            if (!HookedList.Contains("Invoke"))
            {
                HookedList.Add("Invoke");
                new Hook(ReflectionHelper.GetMethodInfo(typeof(SetBoolProxy), "Invoke"), Invoke);
            }
        }

        internal static event Delegates.Invoke_BeforeArgs _beforeInvoke;
        internal static event Delegates.Invoke_NormalArgs _afterInvoke;

        private static bool Invoke(Func<SetBoolProxy, string, bool, bool> orig, SetBoolProxy self, string name,
            bool orig_)
        {
            Delegates.Params_Invoke @params = new()
            {
                self = self, name = name, orig_ = orig_
            };
            _beforeInvoke?.Invoke(@params);
            self = @params.self;
            name = @params.name;
            orig_ = @params.orig_;
            var retVal = orig(self, name, orig_);
            if (_afterInvoke != null) retVal = _afterInvoke.Invoke(@params);
            return retVal;
        }

        internal static void HookEndInvoke()
        {
            if (!HookedList.Contains("EndInvoke"))
            {
                HookedList.Add("EndInvoke");
                new Hook(ReflectionHelper.GetMethodInfo(typeof(SetBoolProxy), "EndInvoke"), EndInvoke);
            }
        }

        internal static event Delegates.EndInvoke_BeforeArgs _beforeEndInvoke;
        internal static event Delegates.EndInvoke_NormalArgs _afterEndInvoke;

        private static bool EndInvoke(Func<SetBoolProxy, IAsyncResult, bool> orig, SetBoolProxy self,
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

        public delegate bool EndInvoke_NormalArgs(Params_EndInvoke args);

        public delegate void Invoke_BeforeArgs(Params_Invoke args);

        public delegate bool Invoke_NormalArgs(Params_Invoke args);

        public sealed class Params_Invoke
        {
            public string name;
            public bool orig_;
            public SetBoolProxy self;
        }

        public sealed class Params_EndInvoke
        {
            public IAsyncResult result;
            public SetBoolProxy self;
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
                ReflectionHelper.GetMethodInfo(typeof(SetBoolProxy), "Invoke"), value);
            remove => HookEndpointManager.Remove<Delegates.Invoke_NormalArgs>(
                ReflectionHelper.GetMethodInfo(typeof(SetBoolProxy), "Invoke"), value);
        }

        public static event Delegates.EndInvoke_NormalArgs EndInvoke
        {
            add => HookEndpointManager.Add<Delegates.EndInvoke_NormalArgs>(
                ReflectionHelper.GetMethodInfo(typeof(SetBoolProxy), "EndInvoke"), value);
            remove => HookEndpointManager.Remove<Delegates.EndInvoke_NormalArgs>(
                ReflectionHelper.GetMethodInfo(typeof(SetBoolProxy), "EndInvoke"), value);
        }
    }
}