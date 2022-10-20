using MonoMod.RuntimeDetour;
using MonoMod.RuntimeDetour.HookGen;

namespace HKMirror.Hooks.OnHooks;

/// <summary>
///     Contains different types of On Hooks for BindingListenOptions class.<br />
///     Contains hooks that aren't generated by monomod, and before and after orig hooks for easier hooking.
/// </summary>
public static class OnBindingListenOptions
{
    internal static class HookHandler
    {
        private static readonly List<string> HookedList = new();

        internal static void HookCallOnBindingFound()
        {
            if (!HookedList.Contains("CallOnBindingFound"))
            {
                HookedList.Add("CallOnBindingFound");
                new Hook(ReflectionHelper.GetMethodInfo(typeof(BindingListenOptions), "CallOnBindingFound"),
                    CallOnBindingFound);
            }
        }

        internal static event Delegates.CallOnBindingFound_BeforeArgs _beforeCallOnBindingFound;
        internal static event Delegates.CallOnBindingFound_NormalArgs _afterCallOnBindingFound;

        private static bool CallOnBindingFound(Func<BindingListenOptions, PlayerAction, BindingSource, bool> orig,
            BindingListenOptions self, PlayerAction playerAction, BindingSource bindingSource)
        {
            Delegates.Params_CallOnBindingFound @params = new()
            {
                self = self, playerAction = playerAction, bindingSource = bindingSource
            };
            _beforeCallOnBindingFound?.Invoke(@params);
            self = @params.self;
            playerAction = @params.playerAction;
            bindingSource = @params.bindingSource;
            var retVal = orig(self, playerAction, bindingSource);
            if (_afterCallOnBindingFound != null) retVal = _afterCallOnBindingFound.Invoke(@params);
            return retVal;
        }

        internal static void HookCallOnBindingAdded()
        {
            if (!HookedList.Contains("CallOnBindingAdded"))
            {
                HookedList.Add("CallOnBindingAdded");
                new Hook(ReflectionHelper.GetMethodInfo(typeof(BindingListenOptions), "CallOnBindingAdded"),
                    CallOnBindingAdded);
            }
        }

        internal static event Delegates.CallOnBindingAdded_BeforeArgs _beforeCallOnBindingAdded;
        internal static event Delegates.CallOnBindingAdded_NormalArgs _afterCallOnBindingAdded;

        private static void CallOnBindingAdded(Action<BindingListenOptions, PlayerAction, BindingSource> orig,
            BindingListenOptions self, PlayerAction playerAction, BindingSource bindingSource)
        {
            Delegates.Params_CallOnBindingAdded @params = new()
            {
                self = self, playerAction = playerAction, bindingSource = bindingSource
            };
            _beforeCallOnBindingAdded?.Invoke(@params);
            self = @params.self;
            playerAction = @params.playerAction;
            bindingSource = @params.bindingSource;
            orig(self, playerAction, bindingSource);
            if (_afterCallOnBindingAdded != null) _afterCallOnBindingAdded.Invoke(@params);
        }

        internal static void HookCallOnBindingRejected()
        {
            if (!HookedList.Contains("CallOnBindingRejected"))
            {
                HookedList.Add("CallOnBindingRejected");
                new Hook(ReflectionHelper.GetMethodInfo(typeof(BindingListenOptions), "CallOnBindingRejected"),
                    CallOnBindingRejected);
            }
        }

        internal static event Delegates.CallOnBindingRejected_BeforeArgs _beforeCallOnBindingRejected;
        internal static event Delegates.CallOnBindingRejected_NormalArgs _afterCallOnBindingRejected;

        private static void CallOnBindingRejected(
            Action<BindingListenOptions, PlayerAction, BindingSource, BindingSourceRejectionType> orig,
            BindingListenOptions self, PlayerAction playerAction, BindingSource bindingSource,
            BindingSourceRejectionType bindingSourceRejectionType)
        {
            Delegates.Params_CallOnBindingRejected @params = new()
            {
                self = self, playerAction = playerAction, bindingSource = bindingSource,
                bindingSourceRejectionType = bindingSourceRejectionType
            };
            _beforeCallOnBindingRejected?.Invoke(@params);
            self = @params.self;
            playerAction = @params.playerAction;
            bindingSource = @params.bindingSource;
            bindingSourceRejectionType = @params.bindingSourceRejectionType;
            orig(self, playerAction, bindingSource, bindingSourceRejectionType);
            if (_afterCallOnBindingRejected != null) _afterCallOnBindingRejected.Invoke(@params);
        }

        internal static void HookCallOnBindingEnded()
        {
            if (!HookedList.Contains("CallOnBindingEnded"))
            {
                HookedList.Add("CallOnBindingEnded");
                new Hook(ReflectionHelper.GetMethodInfo(typeof(BindingListenOptions), "CallOnBindingEnded"),
                    CallOnBindingEnded);
            }
        }

        internal static event Delegates.CallOnBindingEnded_BeforeArgs _beforeCallOnBindingEnded;
        internal static event Delegates.CallOnBindingEnded_NormalArgs _afterCallOnBindingEnded;

        private static void CallOnBindingEnded(Action<BindingListenOptions, PlayerAction> orig,
            BindingListenOptions self, PlayerAction playerAction)
        {
            Delegates.Params_CallOnBindingEnded @params = new()
            {
                self = self, playerAction = playerAction
            };
            _beforeCallOnBindingEnded?.Invoke(@params);
            self = @params.self;
            playerAction = @params.playerAction;
            orig(self, playerAction);
            if (_afterCallOnBindingEnded != null) _afterCallOnBindingEnded.Invoke(@params);
        }
    }

    /// <summary>
    ///     Contains necessary information to create Hooks. Does not contain any hooks
    /// </summary>
    public static class Delegates
    {
        public delegate void CallOnBindingAdded_BeforeArgs(Params_CallOnBindingAdded args);

        public delegate void CallOnBindingAdded_NormalArgs(Params_CallOnBindingAdded args);

        public delegate void CallOnBindingEnded_BeforeArgs(Params_CallOnBindingEnded args);

        public delegate void CallOnBindingEnded_NormalArgs(Params_CallOnBindingEnded args);

        public delegate void CallOnBindingFound_BeforeArgs(Params_CallOnBindingFound args);

        public delegate bool CallOnBindingFound_NormalArgs(Params_CallOnBindingFound args);

        public delegate void CallOnBindingRejected_BeforeArgs(Params_CallOnBindingRejected args);

        public delegate void CallOnBindingRejected_NormalArgs(Params_CallOnBindingRejected args);

        public sealed class Params_CallOnBindingFound
        {
            public BindingSource bindingSource;
            public PlayerAction playerAction;
            public BindingListenOptions self;
        }

        public sealed class Params_CallOnBindingAdded
        {
            public BindingSource bindingSource;
            public PlayerAction playerAction;
            public BindingListenOptions self;
        }

        public sealed class Params_CallOnBindingRejected
        {
            public BindingSource bindingSource;
            public BindingSourceRejectionType bindingSourceRejectionType;
            public PlayerAction playerAction;
            public BindingListenOptions self;
        }

        public sealed class Params_CallOnBindingEnded
        {
            public PlayerAction playerAction;
            public BindingListenOptions self;
        }
    }

    /// <summary>
    ///     Contains Hooks to that run code before orig(self) is called
    /// </summary>
    public static class BeforeOrig
    {
        public static event Delegates.CallOnBindingFound_BeforeArgs CallOnBindingFound
        {
            add
            {
                HookHandler._beforeCallOnBindingFound += value;
                HookHandler.HookCallOnBindingFound();
            }
            remove => HookHandler._beforeCallOnBindingFound -= value;
        }

        public static event Delegates.CallOnBindingAdded_BeforeArgs CallOnBindingAdded
        {
            add
            {
                HookHandler._beforeCallOnBindingAdded += value;
                HookHandler.HookCallOnBindingAdded();
            }
            remove => HookHandler._beforeCallOnBindingAdded -= value;
        }

        public static event Delegates.CallOnBindingRejected_BeforeArgs CallOnBindingRejected
        {
            add
            {
                HookHandler._beforeCallOnBindingRejected += value;
                HookHandler.HookCallOnBindingRejected();
            }
            remove => HookHandler._beforeCallOnBindingRejected -= value;
        }

        public static event Delegates.CallOnBindingEnded_BeforeArgs CallOnBindingEnded
        {
            add
            {
                HookHandler._beforeCallOnBindingEnded += value;
                HookHandler.HookCallOnBindingEnded();
            }
            remove => HookHandler._beforeCallOnBindingEnded -= value;
        }
    }

    /// <summary>
    ///     Contains Hooks to that run code after orig(self) is called
    /// </summary>
    public static class AfterOrig
    {
        public static event Delegates.CallOnBindingFound_NormalArgs CallOnBindingFound
        {
            add
            {
                HookHandler._afterCallOnBindingFound += value;
                HookHandler.HookCallOnBindingFound();
            }
            remove => HookHandler._afterCallOnBindingFound -= value;
        }

        public static event Delegates.CallOnBindingAdded_NormalArgs CallOnBindingAdded
        {
            add
            {
                HookHandler._afterCallOnBindingAdded += value;
                HookHandler.HookCallOnBindingAdded();
            }
            remove => HookHandler._afterCallOnBindingAdded -= value;
        }

        public static event Delegates.CallOnBindingRejected_NormalArgs CallOnBindingRejected
        {
            add
            {
                HookHandler._afterCallOnBindingRejected += value;
                HookHandler.HookCallOnBindingRejected();
            }
            remove => HookHandler._afterCallOnBindingRejected -= value;
        }

        public static event Delegates.CallOnBindingEnded_NormalArgs CallOnBindingEnded
        {
            add
            {
                HookHandler._afterCallOnBindingEnded += value;
                HookHandler.HookCallOnBindingEnded();
            }
            remove => HookHandler._afterCallOnBindingEnded -= value;
        }
    }

    /// <summary>
    ///     Contains all On Hooks, even those that aren't in the On namespace such as API generated functions and property
    ///     getters/setters
    /// </summary>
    public static class WithOrig
    {
        public static event Delegates.CallOnBindingFound_NormalArgs CallOnBindingFound
        {
            add => HookEndpointManager.Add<Delegates.CallOnBindingFound_NormalArgs>(
                ReflectionHelper.GetMethodInfo(typeof(BindingListenOptions), "CallOnBindingFound"), value);
            remove => HookEndpointManager.Remove<Delegates.CallOnBindingFound_NormalArgs>(
                ReflectionHelper.GetMethodInfo(typeof(BindingListenOptions), "CallOnBindingFound"), value);
        }

        public static event Delegates.CallOnBindingAdded_NormalArgs CallOnBindingAdded
        {
            add => HookEndpointManager.Add<Delegates.CallOnBindingAdded_NormalArgs>(
                ReflectionHelper.GetMethodInfo(typeof(BindingListenOptions), "CallOnBindingAdded"), value);
            remove => HookEndpointManager.Remove<Delegates.CallOnBindingAdded_NormalArgs>(
                ReflectionHelper.GetMethodInfo(typeof(BindingListenOptions), "CallOnBindingAdded"), value);
        }

        public static event Delegates.CallOnBindingRejected_NormalArgs CallOnBindingRejected
        {
            add => HookEndpointManager.Add<Delegates.CallOnBindingRejected_NormalArgs>(
                ReflectionHelper.GetMethodInfo(typeof(BindingListenOptions), "CallOnBindingRejected"), value);
            remove => HookEndpointManager.Remove<Delegates.CallOnBindingRejected_NormalArgs>(
                ReflectionHelper.GetMethodInfo(typeof(BindingListenOptions), "CallOnBindingRejected"), value);
        }

        public static event Delegates.CallOnBindingEnded_NormalArgs CallOnBindingEnded
        {
            add => HookEndpointManager.Add<Delegates.CallOnBindingEnded_NormalArgs>(
                ReflectionHelper.GetMethodInfo(typeof(BindingListenOptions), "CallOnBindingEnded"), value);
            remove => HookEndpointManager.Remove<Delegates.CallOnBindingEnded_NormalArgs>(
                ReflectionHelper.GetMethodInfo(typeof(BindingListenOptions), "CallOnBindingEnded"), value);
        }
    }
}