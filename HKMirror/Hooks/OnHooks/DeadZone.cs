using MonoMod.RuntimeDetour;
using MonoMod.RuntimeDetour.HookGen;

namespace HKMirror.Hooks.OnHooks;

/// <summary>
///     Contains different types of On Hooks for DeadZone class.<br />
///     Contains hooks that aren't generated by monomod, and before and after orig hooks for easier hooking.
/// </summary>
public static class OnDeadZone
{
    internal static class HookHandler
    {
        private static readonly List<string> HookedList = new();

        internal static void HookSeparateNotNormalized()
        {
            if (!HookedList.Contains("SeparateNotNormalized"))
            {
                HookedList.Add("SeparateNotNormalized");
                new Hook(ReflectionHelper.GetMethodInfo(typeof(DeadZone), "SeparateNotNormalized", false),
                    SeparateNotNormalized);
            }
        }

        internal static event Delegates.SeparateNotNormalized_BeforeArgs _beforeSeparateNotNormalized;
        internal static event Delegates.SeparateNotNormalized_AfterArgs _afterSeparateNotNormalized;

        private static Vector2 SeparateNotNormalized(Func<float, float, float, float, Vector2> orig, float x, float y,
            float lowerDeadZone, float upperDeadZone)
        {
            Delegates.Params_SeparateNotNormalized @params = new()
            {
                x = x, y = y, lowerDeadZone = lowerDeadZone, upperDeadZone = upperDeadZone
            };
            if (_beforeSeparateNotNormalized != null)
                foreach (Delegates.SeparateNotNormalized_BeforeArgs toInvoke in _beforeSeparateNotNormalized
                             .GetInvocationList())
                    try
                    {
                        _beforeSeparateNotNormalized?.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }

            x = @params.x;
            y = @params.y;
            lowerDeadZone = @params.lowerDeadZone;
            upperDeadZone = @params.upperDeadZone;
            var retVal = orig(x, y, lowerDeadZone, upperDeadZone);
            if (_afterSeparateNotNormalized != null)
                foreach (Delegates.SeparateNotNormalized_AfterArgs toInvoke in _afterSeparateNotNormalized
                             .GetInvocationList())
                    try
                    {
                        retVal = _afterSeparateNotNormalized.Invoke(@params, retVal);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }

            return retVal;
        }

        internal static void HookSeparate()
        {
            if (!HookedList.Contains("Separate"))
            {
                HookedList.Add("Separate");
                new Hook(ReflectionHelper.GetMethodInfo(typeof(DeadZone), "Separate", false), Separate);
            }
        }

        internal static event Delegates.Separate_BeforeArgs _beforeSeparate;
        internal static event Delegates.Separate_AfterArgs _afterSeparate;

        private static Vector2 Separate(Func<float, float, float, float, Vector2> orig, float x, float y,
            float lowerDeadZone, float upperDeadZone)
        {
            Delegates.Params_Separate @params = new()
            {
                x = x, y = y, lowerDeadZone = lowerDeadZone, upperDeadZone = upperDeadZone
            };
            if (_beforeSeparate != null)
                foreach (Delegates.Separate_BeforeArgs toInvoke in _beforeSeparate.GetInvocationList())
                    try
                    {
                        _beforeSeparate?.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }

            x = @params.x;
            y = @params.y;
            lowerDeadZone = @params.lowerDeadZone;
            upperDeadZone = @params.upperDeadZone;
            var retVal = orig(x, y, lowerDeadZone, upperDeadZone);
            if (_afterSeparate != null)
                foreach (Delegates.Separate_AfterArgs toInvoke in _afterSeparate.GetInvocationList())
                    try
                    {
                        retVal = _afterSeparate.Invoke(@params, retVal);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }

            return retVal;
        }

        internal static void HookCircular()
        {
            if (!HookedList.Contains("Circular"))
            {
                HookedList.Add("Circular");
                new Hook(ReflectionHelper.GetMethodInfo(typeof(DeadZone), "Circular", false), Circular);
            }
        }

        internal static event Delegates.Circular_BeforeArgs _beforeCircular;
        internal static event Delegates.Circular_AfterArgs _afterCircular;

        private static Vector2 Circular(Func<float, float, float, float, Vector2> orig, float x, float y,
            float lowerDeadZone, float upperDeadZone)
        {
            Delegates.Params_Circular @params = new()
            {
                x = x, y = y, lowerDeadZone = lowerDeadZone, upperDeadZone = upperDeadZone
            };
            if (_beforeCircular != null)
                foreach (Delegates.Circular_BeforeArgs toInvoke in _beforeCircular.GetInvocationList())
                    try
                    {
                        _beforeCircular?.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }

            x = @params.x;
            y = @params.y;
            lowerDeadZone = @params.lowerDeadZone;
            upperDeadZone = @params.upperDeadZone;
            var retVal = orig(x, y, lowerDeadZone, upperDeadZone);
            if (_afterCircular != null)
                foreach (Delegates.Circular_AfterArgs toInvoke in _afterCircular.GetInvocationList())
                    try
                    {
                        retVal = _afterCircular.Invoke(@params, retVal);
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
        public delegate Vector2 Circular_AfterArgs(Params_Circular args, Vector2 ret);

        public delegate void Circular_BeforeArgs(Params_Circular args);

        public delegate Vector2 Circular_WithArgs(Func<float, float, float, float, Vector2> orig, float x, float y,
            float lowerDeadZone, float upperDeadZone);

        public delegate Vector2 Separate_AfterArgs(Params_Separate args, Vector2 ret);

        public delegate void Separate_BeforeArgs(Params_Separate args);

        public delegate Vector2 Separate_WithArgs(Func<float, float, float, float, Vector2> orig, float x, float y,
            float lowerDeadZone, float upperDeadZone);

        public delegate Vector2 SeparateNotNormalized_AfterArgs(Params_SeparateNotNormalized args, Vector2 ret);

        public delegate void SeparateNotNormalized_BeforeArgs(Params_SeparateNotNormalized args);

        public delegate Vector2 SeparateNotNormalized_WithArgs(Func<float, float, float, float, Vector2> orig, float x,
            float y, float lowerDeadZone, float upperDeadZone);

        public sealed class Params_SeparateNotNormalized
        {
            public float lowerDeadZone;
            public float upperDeadZone;
            public float x;
            public float y;
        }

        public sealed class Params_Separate
        {
            public float lowerDeadZone;
            public float upperDeadZone;
            public float x;
            public float y;
        }

        public sealed class Params_Circular
        {
            public float lowerDeadZone;
            public float upperDeadZone;
            public float x;
            public float y;
        }
    }

    /// <summary>
    ///     Contains Hooks to that run code before orig(self) is called
    /// </summary>
    public static class BeforeOrig
    {
        public static event Delegates.SeparateNotNormalized_BeforeArgs SeparateNotNormalized
        {
            add
            {
                HookHandler._beforeSeparateNotNormalized += value;
                HookHandler.HookSeparateNotNormalized();
            }
            remove => HookHandler._beforeSeparateNotNormalized -= value;
        }

        public static event Delegates.Separate_BeforeArgs Separate
        {
            add
            {
                HookHandler._beforeSeparate += value;
                HookHandler.HookSeparate();
            }
            remove => HookHandler._beforeSeparate -= value;
        }

        public static event Delegates.Circular_BeforeArgs Circular
        {
            add
            {
                HookHandler._beforeCircular += value;
                HookHandler.HookCircular();
            }
            remove => HookHandler._beforeCircular -= value;
        }
    }

    /// <summary>
    ///     Contains Hooks to that run code after orig(self) is called
    /// </summary>
    public static class AfterOrig
    {
        public static event Delegates.SeparateNotNormalized_AfterArgs SeparateNotNormalized
        {
            add
            {
                HookHandler._afterSeparateNotNormalized += value;
                HookHandler.HookSeparateNotNormalized();
            }
            remove => HookHandler._afterSeparateNotNormalized -= value;
        }

        public static event Delegates.Separate_AfterArgs Separate
        {
            add
            {
                HookHandler._afterSeparate += value;
                HookHandler.HookSeparate();
            }
            remove => HookHandler._afterSeparate -= value;
        }

        public static event Delegates.Circular_AfterArgs Circular
        {
            add
            {
                HookHandler._afterCircular += value;
                HookHandler.HookCircular();
            }
            remove => HookHandler._afterCircular -= value;
        }
    }

    /// <summary>
    ///     Contains all On Hooks, even those that aren't in the On namespace such as API generated functions and property
    ///     getters/setters
    /// </summary>
    public static class WithOrig
    {
        public static event Delegates.SeparateNotNormalized_WithArgs SeparateNotNormalized
        {
            add => HookEndpointManager.Add<Delegates.SeparateNotNormalized_WithArgs>(
                ReflectionHelper.GetMethodInfo(typeof(DeadZone), "SeparateNotNormalized", false), value);
            remove => HookEndpointManager.Remove<Delegates.SeparateNotNormalized_WithArgs>(
                ReflectionHelper.GetMethodInfo(typeof(DeadZone), "SeparateNotNormalized", false), value);
        }

        public static event Delegates.Separate_WithArgs Separate
        {
            add => HookEndpointManager.Add<Delegates.Separate_WithArgs>(
                ReflectionHelper.GetMethodInfo(typeof(DeadZone), "Separate", false), value);
            remove => HookEndpointManager.Remove<Delegates.Separate_WithArgs>(
                ReflectionHelper.GetMethodInfo(typeof(DeadZone), "Separate", false), value);
        }

        public static event Delegates.Circular_WithArgs Circular
        {
            add => HookEndpointManager.Add<Delegates.Circular_WithArgs>(
                ReflectionHelper.GetMethodInfo(typeof(DeadZone), "Circular", false), value);
            remove => HookEndpointManager.Remove<Delegates.Circular_WithArgs>(
                ReflectionHelper.GetMethodInfo(typeof(DeadZone), "Circular", false), value);
        }
    }
}