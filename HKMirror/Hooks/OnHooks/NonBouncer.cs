namespace HKMirror.Hooks.OnHooks;

/// <summary>
///     Contains different types of On Hooks for NonBouncer class.<br />
///     Contains hooks that aren't generated by monomod, and before and after orig hooks for easier hooking.
/// </summary>
public static class OnNonBouncer
{
    internal static class HookHandler
    {
        private static readonly List<string> HookedList = new();

        internal static void HookSetActive()
        {
            if (!HookedList.Contains("SetActive"))
            {
                HookedList.Add("SetActive");
                On.NonBouncer.SetActive += SetActive;
            }
        }

        internal static event Delegates.SetActive_BeforeArgs _beforeSetActive;
        internal static event Delegates.SetActive_AfterArgs _afterSetActive;

        private static void SetActive(On.NonBouncer.orig_SetActive orig, NonBouncer self, bool set_active)
        {
            Delegates.Params_SetActive @params = new()
            {
                self = self, set_active = set_active
            };
            if (_beforeSetActive != null)
                foreach (Delegates.SetActive_BeforeArgs toInvoke in _beforeSetActive.GetInvocationList())
                    try
                    {
                        _beforeSetActive?.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }

            self = @params.self;
            set_active = @params.set_active;
            orig(self, set_active);
            if (_afterSetActive != null)
                foreach (Delegates.SetActive_AfterArgs toInvoke in _afterSetActive.GetInvocationList())
                    try
                    {
                        _afterSetActive.Invoke(@params);
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
        public delegate void SetActive_AfterArgs(Params_SetActive args);

        public delegate void SetActive_BeforeArgs(Params_SetActive args);

        public delegate void SetActive_WithArgs(Action<NonBouncer, bool> orig, NonBouncer self, bool set_active);

        public sealed class Params_SetActive
        {
            public NonBouncer self;
            public bool set_active;
        }
    }

    /// <summary>
    ///     Contains Hooks to that run code before orig(self) is called
    /// </summary>
    public static class BeforeOrig
    {
        public static event Delegates.SetActive_BeforeArgs SetActive
        {
            add
            {
                HookHandler._beforeSetActive += value;
                HookHandler.HookSetActive();
            }
            remove => HookHandler._beforeSetActive -= value;
        }
    }

    /// <summary>
    ///     Contains Hooks to that run code after orig(self) is called
    /// </summary>
    public static class AfterOrig
    {
        public static event Delegates.SetActive_AfterArgs SetActive
        {
            add
            {
                HookHandler._afterSetActive += value;
                HookHandler.HookSetActive();
            }
            remove => HookHandler._afterSetActive -= value;
        }
    }

    /// <summary>
    ///     Contains all On Hooks, even those that aren't in the On namespace such as API generated functions and property
    ///     getters/setters
    /// </summary>
    public static class WithOrig
    {
        public static event On.NonBouncer.hook_SetActive SetActive
        {
            add => On.NonBouncer.SetActive += value;
            remove => On.NonBouncer.SetActive -= value;
        }
    }
}