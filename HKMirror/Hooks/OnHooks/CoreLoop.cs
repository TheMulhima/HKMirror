namespace HKMirror.Hooks.OnHooks;

/// <summary>
///     Contains different types of On Hooks for CoreLoop class.<br />
///     Contains hooks that aren't generated by monomod, and before and after orig hooks for easier hooking.
/// </summary>
public static class OnCoreLoop
{
    internal static class HookHandler
    {
        private static readonly List<string> HookedList = new();

        internal static void HookInit()
        {
            if (!HookedList.Contains("Init"))
            {
                HookedList.Add("Init");
                On.CoreLoop.Init += Init;
            }
        }

        internal static event Delegates.Init_BeforeArgs _beforeInit;
        internal static event Delegates.Init_NormalArgs _afterInit;

        private static void Init(On.CoreLoop.orig_Init orig)
        {
            _beforeInit?.Invoke();
            orig();
            if (_afterInit != null) _afterInit.Invoke();
        }

        internal static void HookInvokeNext()
        {
            if (!HookedList.Contains("InvokeNext"))
            {
                HookedList.Add("InvokeNext");
                On.CoreLoop.InvokeNext += InvokeNext;
            }
        }

        internal static event Delegates.InvokeNext_BeforeArgs _beforeInvokeNext;
        internal static event Delegates.InvokeNext_NormalArgs _afterInvokeNext;

        private static void InvokeNext(On.CoreLoop.orig_InvokeNext orig, Action action)
        {
            Delegates.Params_InvokeNext @params = new()
            {
                action = action
            };
            _beforeInvokeNext?.Invoke(@params);
            action = @params.action;
            orig(action);
            if (_afterInvokeNext != null) _afterInvokeNext.Invoke(@params);
        }

        internal static void HookEnqueueInvokeNext()
        {
            if (!HookedList.Contains("EnqueueInvokeNext"))
            {
                HookedList.Add("EnqueueInvokeNext");
                On.CoreLoop.EnqueueInvokeNext += EnqueueInvokeNext;
            }
        }

        internal static event Delegates.EnqueueInvokeNext_BeforeArgs _beforeEnqueueInvokeNext;
        internal static event Delegates.EnqueueInvokeNext_NormalArgs _afterEnqueueInvokeNext;

        private static void EnqueueInvokeNext(On.CoreLoop.orig_EnqueueInvokeNext orig)
        {
            _beforeEnqueueInvokeNext?.Invoke();
            orig();
            if (_afterEnqueueInvokeNext != null) _afterEnqueueInvokeNext.Invoke();
        }

        internal static void HookFireInvokeNext()
        {
            if (!HookedList.Contains("FireInvokeNext"))
            {
                HookedList.Add("FireInvokeNext");
                On.CoreLoop.FireInvokeNext += FireInvokeNext;
            }
        }

        internal static event Delegates.FireInvokeNext_BeforeArgs _beforeFireInvokeNext;
        internal static event Delegates.FireInvokeNext_NormalArgs _afterFireInvokeNext;

        private static void FireInvokeNext(On.CoreLoop.orig_FireInvokeNext orig, CoreLoop self)
        {
            Delegates.Params_FireInvokeNext @params = new()
            {
                self = self
            };
            _beforeFireInvokeNext?.Invoke(@params);
            self = @params.self;
            orig(self);
            if (_afterFireInvokeNext != null) _afterFireInvokeNext.Invoke(@params);
        }

        internal static void HookUpdate()
        {
            if (!HookedList.Contains("Update"))
            {
                HookedList.Add("Update");
                On.CoreLoop.Update += Update;
            }
        }

        internal static event Delegates.Update_BeforeArgs _beforeUpdate;
        internal static event Delegates.Update_NormalArgs _afterUpdate;

        private static void Update(On.CoreLoop.orig_Update orig, CoreLoop self)
        {
            Delegates.Params_Update @params = new()
            {
                self = self
            };
            _beforeUpdate?.Invoke(@params);
            self = @params.self;
            orig(self);
            if (_afterUpdate != null) _afterUpdate.Invoke(@params);
        }
    }

    /// <summary>
    ///     Contains necessary information to create Hooks. Does not contain any hooks
    /// </summary>
    public static class Delegates
    {
        public delegate void EnqueueInvokeNext_BeforeArgs();

        public delegate void EnqueueInvokeNext_NormalArgs();

        public delegate void FireInvokeNext_BeforeArgs(Params_FireInvokeNext args);

        public delegate void FireInvokeNext_NormalArgs(Params_FireInvokeNext args);

        public delegate void Init_BeforeArgs();

        public delegate void Init_NormalArgs();

        public delegate void InvokeNext_BeforeArgs(Params_InvokeNext args);

        public delegate void InvokeNext_NormalArgs(Params_InvokeNext args);

        public delegate void Update_BeforeArgs(Params_Update args);

        public delegate void Update_NormalArgs(Params_Update args);

        public sealed class Params_InvokeNext
        {
            public Action action;
        }

        public sealed class Params_FireInvokeNext
        {
            public CoreLoop self;
        }

        public sealed class Params_Update
        {
            public CoreLoop self;
        }
    }

    /// <summary>
    ///     Contains Hooks to that run code before orig(self) is called
    /// </summary>
    public static class BeforeOrig
    {
        public static event Delegates.Init_BeforeArgs Init
        {
            add
            {
                HookHandler._beforeInit += value;
                HookHandler.HookInit();
            }
            remove => HookHandler._beforeInit -= value;
        }

        public static event Delegates.InvokeNext_BeforeArgs InvokeNext
        {
            add
            {
                HookHandler._beforeInvokeNext += value;
                HookHandler.HookInvokeNext();
            }
            remove => HookHandler._beforeInvokeNext -= value;
        }

        public static event Delegates.EnqueueInvokeNext_BeforeArgs EnqueueInvokeNext
        {
            add
            {
                HookHandler._beforeEnqueueInvokeNext += value;
                HookHandler.HookEnqueueInvokeNext();
            }
            remove => HookHandler._beforeEnqueueInvokeNext -= value;
        }

        public static event Delegates.FireInvokeNext_BeforeArgs FireInvokeNext
        {
            add
            {
                HookHandler._beforeFireInvokeNext += value;
                HookHandler.HookFireInvokeNext();
            }
            remove => HookHandler._beforeFireInvokeNext -= value;
        }

        public static event Delegates.Update_BeforeArgs Update
        {
            add
            {
                HookHandler._beforeUpdate += value;
                HookHandler.HookUpdate();
            }
            remove => HookHandler._beforeUpdate -= value;
        }
    }

    /// <summary>
    ///     Contains Hooks to that run code after orig(self) is called
    /// </summary>
    public static class AfterOrig
    {
        public static event Delegates.Init_NormalArgs Init
        {
            add
            {
                HookHandler._afterInit += value;
                HookHandler.HookInit();
            }
            remove => HookHandler._afterInit -= value;
        }

        public static event Delegates.InvokeNext_NormalArgs InvokeNext
        {
            add
            {
                HookHandler._afterInvokeNext += value;
                HookHandler.HookInvokeNext();
            }
            remove => HookHandler._afterInvokeNext -= value;
        }

        public static event Delegates.EnqueueInvokeNext_NormalArgs EnqueueInvokeNext
        {
            add
            {
                HookHandler._afterEnqueueInvokeNext += value;
                HookHandler.HookEnqueueInvokeNext();
            }
            remove => HookHandler._afterEnqueueInvokeNext -= value;
        }

        public static event Delegates.FireInvokeNext_NormalArgs FireInvokeNext
        {
            add
            {
                HookHandler._afterFireInvokeNext += value;
                HookHandler.HookFireInvokeNext();
            }
            remove => HookHandler._afterFireInvokeNext -= value;
        }

        public static event Delegates.Update_NormalArgs Update
        {
            add
            {
                HookHandler._afterUpdate += value;
                HookHandler.HookUpdate();
            }
            remove => HookHandler._afterUpdate -= value;
        }
    }

    /// <summary>
    ///     Contains all On Hooks, even those that aren't in the On namespace such as API generated functions and property
    ///     getters/setters
    /// </summary>
    public static class WithOrig
    {
        public static event On.CoreLoop.hook_Init Init
        {
            add => On.CoreLoop.Init += value;
            remove => On.CoreLoop.Init -= value;
        }

        public static event On.CoreLoop.hook_InvokeNext InvokeNext
        {
            add => On.CoreLoop.InvokeNext += value;
            remove => On.CoreLoop.InvokeNext -= value;
        }

        public static event On.CoreLoop.hook_EnqueueInvokeNext EnqueueInvokeNext
        {
            add => On.CoreLoop.EnqueueInvokeNext += value;
            remove => On.CoreLoop.EnqueueInvokeNext -= value;
        }

        public static event On.CoreLoop.hook_FireInvokeNext FireInvokeNext
        {
            add => On.CoreLoop.FireInvokeNext += value;
            remove => On.CoreLoop.FireInvokeNext -= value;
        }

        public static event On.CoreLoop.hook_Update Update
        {
            add => On.CoreLoop.Update += value;
            remove => On.CoreLoop.Update -= value;
        }
    }
}