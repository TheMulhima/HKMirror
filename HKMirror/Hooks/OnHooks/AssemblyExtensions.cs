using Modding.Utils;
using MonoMod.RuntimeDetour;
using MonoMod.RuntimeDetour.HookGen;

namespace HKMirror.Hooks.OnHooks;

/// <summary>
///     Contains different types of On Hooks for AssemblyExtensions class.<br />
///     Contains hooks that aren't generated by monomod, and before and after orig hooks for easier hooking.
/// </summary>
public static class OnAssemblyExtensions
{
    internal static class HookHandler
    {
        private static readonly List<string> HookedList = new();

        internal static void HookGetTypesSafely()
        {
            if (!HookedList.Contains("GetTypesSafely"))
            {
                HookedList.Add("GetTypesSafely");
                new Hook(ReflectionHelper.GetMethodInfo(typeof(AssemblyExtensions), "GetTypesSafely", false),
                    GetTypesSafely);
            }
        }

        internal static event Delegates.GetTypesSafely_BeforeArgs _beforeGetTypesSafely;
        internal static event Delegates.GetTypesSafely_AfterArgs _afterGetTypesSafely;

        private static IEnumerable<Type> GetTypesSafely(Func<Assembly, IEnumerable<Type>> orig, Assembly asm)
        {
            Delegates.Params_GetTypesSafely @params = new()
            {
                asm = asm
            };
            if (_beforeGetTypesSafely != null)
                foreach (Delegates.GetTypesSafely_BeforeArgs toInvoke in _beforeGetTypesSafely.GetInvocationList())
                    try
                    {
                        _beforeGetTypesSafely?.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }

            asm = @params.asm;
            var retVal = orig(asm);
            if (_afterGetTypesSafely != null)
                foreach (Delegates.GetTypesSafely_AfterArgs toInvoke in _afterGetTypesSafely.GetInvocationList())
                    try
                    {
                        retVal = _afterGetTypesSafely.Invoke(@params, retVal);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }

            return retVal;
        }

        internal static void HookLoadEmbeddedSprite()
        {
            if (!HookedList.Contains("LoadEmbeddedSprite"))
            {
                HookedList.Add("LoadEmbeddedSprite");
                new Hook(ReflectionHelper.GetMethodInfo(typeof(AssemblyExtensions), "LoadEmbeddedSprite", false),
                    LoadEmbeddedSprite);
            }
        }

        internal static event Delegates.LoadEmbeddedSprite_BeforeArgs _beforeLoadEmbeddedSprite;
        internal static event Delegates.LoadEmbeddedSprite_AfterArgs _afterLoadEmbeddedSprite;

        private static Sprite LoadEmbeddedSprite(Func<Assembly, string, float, Sprite> orig, Assembly asm, string path,
            float pixelsPerUnit)
        {
            Delegates.Params_LoadEmbeddedSprite @params = new()
            {
                asm = asm, path = path, pixelsPerUnit = pixelsPerUnit
            };
            if (_beforeLoadEmbeddedSprite != null)
                foreach (Delegates.LoadEmbeddedSprite_BeforeArgs toInvoke in
                         _beforeLoadEmbeddedSprite.GetInvocationList())
                    try
                    {
                        _beforeLoadEmbeddedSprite?.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }

            asm = @params.asm;
            path = @params.path;
            pixelsPerUnit = @params.pixelsPerUnit;
            var retVal = orig(asm, path, pixelsPerUnit);
            if (_afterLoadEmbeddedSprite != null)
                foreach (Delegates.LoadEmbeddedSprite_AfterArgs toInvoke in
                         _afterLoadEmbeddedSprite.GetInvocationList())
                    try
                    {
                        retVal = _afterLoadEmbeddedSprite.Invoke(@params, retVal);
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
        public delegate IEnumerable<Type> GetTypesSafely_AfterArgs(Params_GetTypesSafely args, IEnumerable<Type> ret);

        public delegate void GetTypesSafely_BeforeArgs(Params_GetTypesSafely args);

        public delegate IEnumerable<Type> GetTypesSafely_WithArgs(Func<Assembly, IEnumerable<Type>> orig, Assembly asm);

        public delegate Sprite LoadEmbeddedSprite_AfterArgs(Params_LoadEmbeddedSprite args, Sprite ret);

        public delegate void LoadEmbeddedSprite_BeforeArgs(Params_LoadEmbeddedSprite args);

        public delegate Sprite LoadEmbeddedSprite_WithArgs(Func<Assembly, string, float, Sprite> orig, Assembly asm,
            string path, float pixelsPerUnit);

        public sealed class Params_GetTypesSafely
        {
            public Assembly asm;
        }

        public sealed class Params_LoadEmbeddedSprite
        {
            public Assembly asm;
            public string path;
            public float pixelsPerUnit;
        }
    }

    /// <summary>
    ///     Contains Hooks to that run code before orig(self) is called
    /// </summary>
    public static class BeforeOrig
    {
        public static event Delegates.GetTypesSafely_BeforeArgs GetTypesSafely
        {
            add
            {
                HookHandler._beforeGetTypesSafely += value;
                HookHandler.HookGetTypesSafely();
            }
            remove => HookHandler._beforeGetTypesSafely -= value;
        }

        public static event Delegates.LoadEmbeddedSprite_BeforeArgs LoadEmbeddedSprite
        {
            add
            {
                HookHandler._beforeLoadEmbeddedSprite += value;
                HookHandler.HookLoadEmbeddedSprite();
            }
            remove => HookHandler._beforeLoadEmbeddedSprite -= value;
        }
    }

    /// <summary>
    ///     Contains Hooks to that run code after orig(self) is called
    /// </summary>
    public static class AfterOrig
    {
        public static event Delegates.GetTypesSafely_AfterArgs GetTypesSafely
        {
            add
            {
                HookHandler._afterGetTypesSafely += value;
                HookHandler.HookGetTypesSafely();
            }
            remove => HookHandler._afterGetTypesSafely -= value;
        }

        public static event Delegates.LoadEmbeddedSprite_AfterArgs LoadEmbeddedSprite
        {
            add
            {
                HookHandler._afterLoadEmbeddedSprite += value;
                HookHandler.HookLoadEmbeddedSprite();
            }
            remove => HookHandler._afterLoadEmbeddedSprite -= value;
        }
    }

    /// <summary>
    ///     Contains all On Hooks, even those that aren't in the On namespace such as API generated functions and property
    ///     getters/setters
    /// </summary>
    public static class WithOrig
    {
        public static event Delegates.GetTypesSafely_WithArgs GetTypesSafely
        {
            add => HookEndpointManager.Add<Delegates.GetTypesSafely_WithArgs>(
                ReflectionHelper.GetMethodInfo(typeof(AssemblyExtensions), "GetTypesSafely", false), value);
            remove => HookEndpointManager.Remove<Delegates.GetTypesSafely_WithArgs>(
                ReflectionHelper.GetMethodInfo(typeof(AssemblyExtensions), "GetTypesSafely", false), value);
        }

        public static event Delegates.LoadEmbeddedSprite_WithArgs LoadEmbeddedSprite
        {
            add => HookEndpointManager.Add<Delegates.LoadEmbeddedSprite_WithArgs>(
                ReflectionHelper.GetMethodInfo(typeof(AssemblyExtensions), "LoadEmbeddedSprite", false), value);
            remove => HookEndpointManager.Remove<Delegates.LoadEmbeddedSprite_WithArgs>(
                ReflectionHelper.GetMethodInfo(typeof(AssemblyExtensions), "LoadEmbeddedSprite", false), value);
        }
    }
}