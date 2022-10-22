using Language;
using MonoMod.RuntimeDetour;
using MonoMod.RuntimeDetour.HookGen;

namespace HKMirror.Hooks.OnHooks;

/// <summary>
///     Contains different types of On Hooks for StringExtensions class.<br />
///     Contains hooks that aren't generated by monomod, and before and after orig hooks for easier hooking.
/// </summary>
public static class OnStringExtensions
{
    internal static class HookHandler
    {
        private static readonly List<string> HookedList = new();

        internal static void HookUnescapeXML()
        {
            if (!HookedList.Contains("UnescapeXML"))
            {
                HookedList.Add("UnescapeXML");
                new Hook(ReflectionHelper.GetMethodInfo(typeof(StringExtensions), "UnescapeXML", false), UnescapeXML);
            }
        }

        internal static event Delegates.UnescapeXML_BeforeArgs _beforeUnescapeXML;
        internal static event Delegates.UnescapeXML_AfterArgs _afterUnescapeXML;

        private static string UnescapeXML(Func<string, string> orig, string s)
        {
            Delegates.Params_UnescapeXML @params = new()
            {
                s = s
            };
            if (_beforeUnescapeXML != null)
                foreach (Delegates.UnescapeXML_BeforeArgs toInvoke in _beforeUnescapeXML.GetInvocationList())
                    try
                    {
                        _beforeUnescapeXML?.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }

            s = @params.s;
            var retVal = orig(s);
            if (_afterUnescapeXML != null)
                foreach (Delegates.UnescapeXML_AfterArgs toInvoke in _afterUnescapeXML.GetInvocationList())
                    try
                    {
                        retVal = _afterUnescapeXML.Invoke(@params, retVal);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }

            return retVal;
        }
    }

    /// <summary>
    ///     Contains necessary information to create Hooks. Does not contain any hooks
    /// </summary>
    public static class Delegates
    {
        public delegate string UnescapeXML_AfterArgs(Params_UnescapeXML args, string ret);

        public delegate void UnescapeXML_BeforeArgs(Params_UnescapeXML args);

        public delegate string UnescapeXML_WithArgs(Func<string, string> orig, string s);

        public sealed class Params_UnescapeXML
        {
            public string s;
        }
    }

    /// <summary>
    ///     Contains Hooks to that run code before orig(self) is called
    /// </summary>
    public static class BeforeOrig
    {
        public static event Delegates.UnescapeXML_BeforeArgs UnescapeXML
        {
            add
            {
                HookHandler._beforeUnescapeXML += value;
                HookHandler.HookUnescapeXML();
            }
            remove => HookHandler._beforeUnescapeXML -= value;
        }
    }

    /// <summary>
    ///     Contains Hooks to that run code after orig(self) is called
    /// </summary>
    public static class AfterOrig
    {
        public static event Delegates.UnescapeXML_AfterArgs UnescapeXML
        {
            add
            {
                HookHandler._afterUnescapeXML += value;
                HookHandler.HookUnescapeXML();
            }
            remove => HookHandler._afterUnescapeXML -= value;
        }
    }

    /// <summary>
    ///     Contains all On Hooks, even those that aren't in the On namespace such as API generated functions and property
    ///     getters/setters
    /// </summary>
    public static class WithOrig
    {
        public static event Delegates.UnescapeXML_WithArgs UnescapeXML
        {
            add => HookEndpointManager.Add<Delegates.UnescapeXML_WithArgs>(
                ReflectionHelper.GetMethodInfo(typeof(StringExtensions), "UnescapeXML", false), value);
            remove => HookEndpointManager.Remove<Delegates.UnescapeXML_WithArgs>(
                ReflectionHelper.GetMethodInfo(typeof(StringExtensions), "UnescapeXML", false), value);
        }
    }
}