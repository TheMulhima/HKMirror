namespace HKMirror.Hooks.OnHooks;

/// <summary>
///     Contains different types of On Hooks for TimeUtility class.<br />
///     Contains hooks that aren't generated by monomod, and before and after orig hooks for easier hooking.
/// </summary>
public static class OnTimeUtility
{
    internal static class HookHandler
    {
        private static readonly List<string> HookedList = new();

        internal static void HookWait()
        {
            if (!HookedList.Contains("Wait"))
            {
                HookedList.Add("Wait");
                On.TimeUtility.Wait += Wait;
            }
        }

        internal static event Delegates.Wait_BeforeArgs _beforeWait;

        private static IEnumerator Wait(On.TimeUtility.orig_Wait orig, float duration)
        {
            Delegates.Params_Wait @params = new()
            {
                duration = duration
            };
            if (_beforeWait != null)
                foreach (Delegates.Wait_BeforeArgs toInvoke in _beforeWait.GetInvocationList())
                    try
                    {
                        _beforeWait?.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }

            duration = @params.duration;
            return orig(duration);
        }

        internal static void HookWaitForRealSeconds()
        {
            if (!HookedList.Contains("WaitForRealSeconds"))
            {
                HookedList.Add("WaitForRealSeconds");
                On.TimeUtility.WaitForRealSeconds += WaitForRealSeconds;
            }
        }

        internal static event Delegates.WaitForRealSeconds_BeforeArgs _beforeWaitForRealSeconds;

        private static IEnumerator WaitForRealSeconds(On.TimeUtility.orig_WaitForRealSeconds orig, float time)
        {
            Delegates.Params_WaitForRealSeconds @params = new()
            {
                time = time
            };
            if (_beforeWaitForRealSeconds != null)
                foreach (Delegates.WaitForRealSeconds_BeforeArgs toInvoke in
                         _beforeWaitForRealSeconds.GetInvocationList())
                    try
                    {
                        _beforeWaitForRealSeconds?.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }

            time = @params.time;
            return orig(time);
        }
    }

    /// <summary>
    ///     Contains necessary information to create Hooks. Does not contain any hooks
    /// </summary>
    public static class Delegates
    {
        public delegate IEnumerator Wait_AfterArgs(Params_Wait args, IEnumerator ret);

        public delegate void Wait_BeforeArgs(Params_Wait args);

        public delegate IEnumerator Wait_WithArgs(Func<float, IEnumerator> orig, float duration);

        public delegate IEnumerator WaitForRealSeconds_AfterArgs(Params_WaitForRealSeconds args, IEnumerator ret);

        public delegate void WaitForRealSeconds_BeforeArgs(Params_WaitForRealSeconds args);

        public delegate IEnumerator WaitForRealSeconds_WithArgs(Func<float, IEnumerator> orig, float time);

        public sealed class Params_Wait
        {
            public float duration;
        }

        public sealed class Params_WaitForRealSeconds
        {
            public float time;
        }
    }

    /// <summary>
    ///     Contains Hooks to that run code before orig(self) is called
    /// </summary>
    public static class BeforeOrig
    {
        public static event Delegates.Wait_BeforeArgs Wait
        {
            add
            {
                HookHandler._beforeWait += value;
                HookHandler.HookWait();
            }
            remove => HookHandler._beforeWait -= value;
        }

        public static event Delegates.WaitForRealSeconds_BeforeArgs WaitForRealSeconds
        {
            add
            {
                HookHandler._beforeWaitForRealSeconds += value;
                HookHandler.HookWaitForRealSeconds();
            }
            remove => HookHandler._beforeWaitForRealSeconds -= value;
        }
    }

    /// <summary>
    ///     Contains Hooks to that run code after orig(self) is called
    /// </summary>
    public static class AfterOrig
    {
    }

    /// <summary>
    ///     Contains all On Hooks, even those that aren't in the On namespace such as API generated functions and property
    ///     getters/setters
    /// </summary>
    public static class WithOrig
    {
        public static event On.TimeUtility.hook_Wait Wait
        {
            add => On.TimeUtility.Wait += value;
            remove => On.TimeUtility.Wait -= value;
        }

        public static event On.TimeUtility.hook_WaitForRealSeconds WaitForRealSeconds
        {
            add => On.TimeUtility.WaitForRealSeconds += value;
            remove => On.TimeUtility.WaitForRealSeconds -= value;
        }
    }
}