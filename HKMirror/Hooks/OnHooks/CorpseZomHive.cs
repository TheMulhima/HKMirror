namespace HKMirror.Hooks.OnHooks;

/// <summary>
///     Contains different types of On Hooks for CorpseZomHive class.<br />
///     Contains hooks that aren't generated by monomod, and before and after orig hooks for easier hooking.
/// </summary>
public static class OnCorpseZomHive
{
    internal static class HookHandler
    {
        private static readonly List<string> HookedList = new();

        internal static void HookLandEffects()
        {
            if (!HookedList.Contains("LandEffects"))
            {
                HookedList.Add("LandEffects");
                On.CorpseZomHive.LandEffects += LandEffects;
            }
        }

        internal static event Delegates.LandEffects_BeforeArgs _beforeLandEffects;
        internal static event Delegates.LandEffects_AfterArgs _afterLandEffects;

        private static void LandEffects(On.CorpseZomHive.orig_LandEffects orig, CorpseZomHive self)
        {
            Delegates.Params_LandEffects @params = new()
            {
                self = self
            };
            if (_beforeLandEffects != null)
                foreach (Delegates.LandEffects_BeforeArgs toInvoke in _beforeLandEffects.GetInvocationList())
                    try
                    {
                        _beforeLandEffects?.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }

            self = @params.self;
            orig(self);
            if (_afterLandEffects != null)
                foreach (Delegates.LandEffects_AfterArgs toInvoke in _afterLandEffects.GetInvocationList())
                    try
                    {
                        _afterLandEffects.Invoke(@params);
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
        public delegate void LandEffects_AfterArgs(Params_LandEffects args);

        public delegate void LandEffects_BeforeArgs(Params_LandEffects args);

        public delegate void LandEffects_WithArgs(Action<CorpseZomHive> orig, CorpseZomHive self);

        public sealed class Params_LandEffects
        {
            public CorpseZomHive self;
        }
    }

    /// <summary>
    ///     Contains Hooks to that run code before orig(self) is called
    /// </summary>
    public static class BeforeOrig
    {
        public static event Delegates.LandEffects_BeforeArgs LandEffects
        {
            add
            {
                HookHandler._beforeLandEffects += value;
                HookHandler.HookLandEffects();
            }
            remove => HookHandler._beforeLandEffects -= value;
        }
    }

    /// <summary>
    ///     Contains Hooks to that run code after orig(self) is called
    /// </summary>
    public static class AfterOrig
    {
        public static event Delegates.LandEffects_AfterArgs LandEffects
        {
            add
            {
                HookHandler._afterLandEffects += value;
                HookHandler.HookLandEffects();
            }
            remove => HookHandler._afterLandEffects -= value;
        }
    }

    /// <summary>
    ///     Contains all On Hooks, even those that aren't in the On namespace such as API generated functions and property
    ///     getters/setters
    /// </summary>
    public static class WithOrig
    {
        public static event On.CorpseZomHive.hook_LandEffects LandEffects
        {
            add => On.CorpseZomHive.LandEffects += value;
            remove => On.CorpseZomHive.LandEffects -= value;
        }
    }
}