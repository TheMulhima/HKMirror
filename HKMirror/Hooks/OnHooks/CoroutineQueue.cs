namespace HKMirror.Hooks.OnHooks;

/// <summary>
///     Contains different types of On Hooks for CoroutineQueue class.<br />
///     Contains hooks that aren't generated by monomod, and before and after orig hooks for easier hooking.
/// </summary>
public static class OnCoroutineQueue
{
    internal static class HookHandler
    {
        private static readonly List<string> HookedList = new();

        internal static void HookEnqueue()
        {
            if (!HookedList.Contains("Enqueue"))
            {
                HookedList.Add("Enqueue");
                On.CoroutineQueue.Enqueue += Enqueue;
            }
        }

        internal static event Delegates.Enqueue_BeforeArgs _beforeEnqueue;
        internal static event Delegates.Enqueue_AfterArgs _afterEnqueue;

        private static void Enqueue(On.CoroutineQueue.orig_Enqueue orig, CoroutineQueue self, IEnumerator coroutine)
        {
            Delegates.Params_Enqueue @params = new()
            {
                self = self, coroutine = coroutine
            };
            if (_beforeEnqueue != null)
                foreach (Delegates.Enqueue_BeforeArgs toInvoke in _beforeEnqueue.GetInvocationList())
                    try
                    {
                        _beforeEnqueue?.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }

            self = @params.self;
            coroutine = @params.coroutine;
            orig(self, coroutine);
            if (_afterEnqueue != null)
                foreach (Delegates.Enqueue_AfterArgs toInvoke in _afterEnqueue.GetInvocationList())
                    try
                    {
                        _afterEnqueue.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }
        }

        internal static void HookRun()
        {
            if (!HookedList.Contains("Run"))
            {
                HookedList.Add("Run");
                On.CoroutineQueue.Run += Run;
            }
        }

        internal static event Delegates.Run_BeforeArgs _beforeRun;

        private static IEnumerator Run(On.CoroutineQueue.orig_Run orig, CoroutineQueue self)
        {
            Delegates.Params_Run @params = new()
            {
                self = self
            };
            if (_beforeRun != null)
                foreach (Delegates.Run_BeforeArgs toInvoke in _beforeRun.GetInvocationList())
                    try
                    {
                        _beforeRun?.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }

            self = @params.self;
            return orig(self);
        }
    }

    /// <summary>
    ///     Contains necessary information to create Hooks. Does not contain any hooks
    /// </summary>
    public static class Delegates
    {
        public delegate void Enqueue_AfterArgs(Params_Enqueue args);

        public delegate void Enqueue_BeforeArgs(Params_Enqueue args);

        public delegate void Enqueue_WithArgs(Action<CoroutineQueue, IEnumerator> orig, CoroutineQueue self,
            IEnumerator coroutine);

        public delegate IEnumerator Run_AfterArgs(Params_Run args, IEnumerator ret);

        public delegate void Run_BeforeArgs(Params_Run args);

        public delegate IEnumerator Run_WithArgs(Func<CoroutineQueue, IEnumerator> orig, CoroutineQueue self);

        public sealed class Params_Enqueue
        {
            public IEnumerator coroutine;
            public CoroutineQueue self;
        }

        public sealed class Params_Run
        {
            public CoroutineQueue self;
        }
    }

    /// <summary>
    ///     Contains Hooks to that run code before orig(self) is called
    /// </summary>
    public static class BeforeOrig
    {
        public static event Delegates.Enqueue_BeforeArgs Enqueue
        {
            add
            {
                HookHandler._beforeEnqueue += value;
                HookHandler.HookEnqueue();
            }
            remove => HookHandler._beforeEnqueue -= value;
        }

        public static event Delegates.Run_BeforeArgs Run
        {
            add
            {
                HookHandler._beforeRun += value;
                HookHandler.HookRun();
            }
            remove => HookHandler._beforeRun -= value;
        }
    }

    /// <summary>
    ///     Contains Hooks to that run code after orig(self) is called
    /// </summary>
    public static class AfterOrig
    {
        public static event Delegates.Enqueue_AfterArgs Enqueue
        {
            add
            {
                HookHandler._afterEnqueue += value;
                HookHandler.HookEnqueue();
            }
            remove => HookHandler._afterEnqueue -= value;
        }
    }

    /// <summary>
    ///     Contains all On Hooks, even those that aren't in the On namespace such as API generated functions and property
    ///     getters/setters
    /// </summary>
    public static class WithOrig
    {
        public static event On.CoroutineQueue.hook_Enqueue Enqueue
        {
            add => On.CoroutineQueue.Enqueue += value;
            remove => On.CoroutineQueue.Enqueue -= value;
        }

        public static event On.CoroutineQueue.hook_Run Run
        {
            add => On.CoroutineQueue.Run += value;
            remove => On.CoroutineQueue.Run -= value;
        }
    }
}