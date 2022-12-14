namespace HKMirror.Hooks.OnHooks;

/// <summary>
///     Contains different types of On Hooks for PlayMakerAnimatorIKProxy class.<br />
///     Contains hooks that aren't generated by monomod, and before and after orig hooks for easier hooking.
/// </summary>
public static class OnPlayMakerAnimatorIKProxy
{
    internal static class HookHandler
    {
        private static readonly List<string> HookedList = new();

        internal static void HookOnAnimatorIK()
        {
            if (!HookedList.Contains("OnAnimatorIK"))
            {
                HookedList.Add("OnAnimatorIK");
                On.PlayMakerAnimatorIKProxy.OnAnimatorIK += OnAnimatorIK;
            }
        }

        internal static event Delegates.OnAnimatorIK_BeforeArgs _beforeOnAnimatorIK;
        internal static event Delegates.OnAnimatorIK_AfterArgs _afterOnAnimatorIK;

        private static void OnAnimatorIK(On.PlayMakerAnimatorIKProxy.orig_OnAnimatorIK orig,
            PlayMakerAnimatorIKProxy self, int layerIndex)
        {
            Delegates.Params_OnAnimatorIK @params = new()
            {
                self = self, layerIndex = layerIndex
            };
            if (_beforeOnAnimatorIK != null)
                foreach (Delegates.OnAnimatorIK_BeforeArgs toInvoke in _beforeOnAnimatorIK.GetInvocationList())
                    try
                    {
                        _beforeOnAnimatorIK?.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }

            self = @params.self;
            layerIndex = @params.layerIndex;
            orig(self, layerIndex);
            if (_afterOnAnimatorIK != null)
                foreach (Delegates.OnAnimatorIK_AfterArgs toInvoke in _afterOnAnimatorIK.GetInvocationList())
                    try
                    {
                        _afterOnAnimatorIK.Invoke(@params);
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
        public delegate void OnAnimatorIK_AfterArgs(Params_OnAnimatorIK args);

        public delegate void OnAnimatorIK_BeforeArgs(Params_OnAnimatorIK args);

        public delegate void OnAnimatorIK_WithArgs(Action<PlayMakerAnimatorIKProxy, int> orig,
            PlayMakerAnimatorIKProxy self, int layerIndex);

        public sealed class Params_OnAnimatorIK
        {
            public int layerIndex;
            public PlayMakerAnimatorIKProxy self;
        }
    }

    /// <summary>
    ///     Contains Hooks to that run code before orig(self) is called
    /// </summary>
    public static class BeforeOrig
    {
        public static event Delegates.OnAnimatorIK_BeforeArgs OnAnimatorIK
        {
            add
            {
                HookHandler._beforeOnAnimatorIK += value;
                HookHandler.HookOnAnimatorIK();
            }
            remove => HookHandler._beforeOnAnimatorIK -= value;
        }
    }

    /// <summary>
    ///     Contains Hooks to that run code after orig(self) is called
    /// </summary>
    public static class AfterOrig
    {
        public static event Delegates.OnAnimatorIK_AfterArgs OnAnimatorIK
        {
            add
            {
                HookHandler._afterOnAnimatorIK += value;
                HookHandler.HookOnAnimatorIK();
            }
            remove => HookHandler._afterOnAnimatorIK -= value;
        }
    }

    /// <summary>
    ///     Contains all On Hooks, even those that aren't in the On namespace such as API generated functions and property
    ///     getters/setters
    /// </summary>
    public static class WithOrig
    {
        public static event On.PlayMakerAnimatorIKProxy.hook_OnAnimatorIK OnAnimatorIK
        {
            add => On.PlayMakerAnimatorIKProxy.OnAnimatorIK += value;
            remove => On.PlayMakerAnimatorIKProxy.OnAnimatorIK -= value;
        }
    }
}