using MonoMod.RuntimeDetour;
using MonoMod.RuntimeDetour.HookGen;
using TMPro;

namespace HKMirror.Hooks.OnHooks;

/// <summary>
///     Contains different types of On Hooks for TMP_Glyph class.<br />
///     Contains hooks that aren't generated by monomod, and before and after orig hooks for easier hooking.
/// </summary>
public static class OnTMP_Glyph
{
    internal static class HookHandler
    {
        private static readonly List<string> HookedList = new();

        internal static void HookClone()
        {
            if (!HookedList.Contains("Clone"))
            {
                HookedList.Add("Clone");
                new Hook(ReflectionHelper.GetMethodInfo(typeof(TMP_Glyph), "Clone", false), Clone);
            }
        }

        internal static event Delegates.Clone_BeforeArgs _beforeClone;
        internal static event Delegates.Clone_NormalArgs _afterClone;

        private static TMP_Glyph Clone(Func<TMP_Glyph, TMP_Glyph> orig, TMP_Glyph source)
        {
            Delegates.Params_Clone @params = new()
            {
                source = source
            };
            _beforeClone?.Invoke(@params);
            source = @params.source;
            var retVal = orig(source);
            if (_afterClone != null) retVal = _afterClone.Invoke(@params);
            return retVal;
        }
    }

    /// <summary>
    ///     Contains necessary information to create Hooks. Does not contain any hooks
    /// </summary>
    public static class Delegates
    {
        public delegate void Clone_BeforeArgs(Params_Clone args);

        public delegate TMP_Glyph Clone_NormalArgs(Params_Clone args);

        public sealed class Params_Clone
        {
            public TMP_Glyph source;
        }
    }

    /// <summary>
    ///     Contains Hooks to that run code before orig(self) is called
    /// </summary>
    public static class BeforeOrig
    {
        public static event Delegates.Clone_BeforeArgs Clone
        {
            add
            {
                HookHandler._beforeClone += value;
                HookHandler.HookClone();
            }
            remove => HookHandler._beforeClone -= value;
        }
    }

    /// <summary>
    ///     Contains Hooks to that run code after orig(self) is called
    /// </summary>
    public static class AfterOrig
    {
        public static event Delegates.Clone_NormalArgs Clone
        {
            add
            {
                HookHandler._afterClone += value;
                HookHandler.HookClone();
            }
            remove => HookHandler._afterClone -= value;
        }
    }

    /// <summary>
    ///     Contains all On Hooks, even those that aren't in the On namespace such as API generated functions and property
    ///     getters/setters
    /// </summary>
    public static class WithOrig
    {
        public static event Delegates.Clone_NormalArgs Clone
        {
            add => HookEndpointManager.Add<Delegates.Clone_NormalArgs>(
                ReflectionHelper.GetMethodInfo(typeof(TMP_Glyph), "Clone", false), value);
            remove => HookEndpointManager.Remove<Delegates.Clone_NormalArgs>(
                ReflectionHelper.GetMethodInfo(typeof(TMP_Glyph), "Clone", false), value);
        }
    }
}