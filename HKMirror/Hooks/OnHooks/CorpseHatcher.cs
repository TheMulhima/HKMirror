namespace HKMirror.Hooks.OnHooks;

/// <summary>
///     Contains different types of On Hooks for CorpseHatcher class.<br />
///     Contains hooks that aren't generated by monomod, and before and after orig hooks for easier hooking.
/// </summary>
public static class OnCorpseHatcher
{
    internal static class HookHandler
    {
        private static readonly List<string> HookedList = new();

        internal static void HookSmash()
        {
            if (!HookedList.Contains("Smash"))
            {
                HookedList.Add("Smash");
                On.CorpseHatcher.Smash += Smash;
            }
        }

        internal static event Delegates.Smash_BeforeArgs _beforeSmash;
        internal static event Delegates.Smash_AfterArgs _afterSmash;

        private static void Smash(On.CorpseHatcher.orig_Smash orig, CorpseHatcher self)
        {
            Delegates.Params_Smash @params = new()
            {
                self = self
            };
            if (_beforeSmash != null)
                foreach (Delegates.Smash_BeforeArgs toInvoke in _beforeSmash.GetInvocationList())
                    try
                    {
                        _beforeSmash?.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }

            self = @params.self;
            orig(self);
            if (_afterSmash != null)
                foreach (Delegates.Smash_AfterArgs toInvoke in _afterSmash.GetInvocationList())
                    try
                    {
                        _afterSmash.Invoke(@params);
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
        public delegate void Smash_AfterArgs(Params_Smash args);

        public delegate void Smash_BeforeArgs(Params_Smash args);

        public delegate void Smash_WithArgs(Action<CorpseHatcher> orig, CorpseHatcher self);

        public sealed class Params_Smash
        {
            public CorpseHatcher self;
        }
    }

    /// <summary>
    ///     Contains Hooks to that run code before orig(self) is called
    /// </summary>
    public static class BeforeOrig
    {
        public static event Delegates.Smash_BeforeArgs Smash
        {
            add
            {
                HookHandler._beforeSmash += value;
                HookHandler.HookSmash();
            }
            remove => HookHandler._beforeSmash -= value;
        }
    }

    /// <summary>
    ///     Contains Hooks to that run code after orig(self) is called
    /// </summary>
    public static class AfterOrig
    {
        public static event Delegates.Smash_AfterArgs Smash
        {
            add
            {
                HookHandler._afterSmash += value;
                HookHandler.HookSmash();
            }
            remove => HookHandler._afterSmash -= value;
        }
    }

    /// <summary>
    ///     Contains all On Hooks, even those that aren't in the On namespace such as API generated functions and property
    ///     getters/setters
    /// </summary>
    public static class WithOrig
    {
        public static event On.CorpseHatcher.hook_Smash Smash
        {
            add => On.CorpseHatcher.Smash += value;
            remove => On.CorpseHatcher.Smash -= value;
        }
    }
}