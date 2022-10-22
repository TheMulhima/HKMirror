using MonoMod.RuntimeDetour;
using MonoMod.RuntimeDetour.HookGen;

namespace HKMirror.Hooks.OnHooks;

/// <summary>
///     Contains different types of On Hooks for InputDeviceStyleExtensions class.<br />
///     Contains hooks that aren't generated by monomod, and before and after orig hooks for easier hooking.
/// </summary>
public static class OnInputDeviceStyleExtensions
{
    internal static class HookHandler
    {
        private static readonly List<string> HookedList = new();

        internal static void HookLeftCommandControl()
        {
            if (!HookedList.Contains("LeftCommandControl"))
            {
                HookedList.Add("LeftCommandControl");
                new Hook(
                    ReflectionHelper.GetMethodInfo(typeof(InputDeviceStyleExtensions), "LeftCommandControl", false),
                    LeftCommandControl);
            }
        }

        internal static event Delegates.LeftCommandControl_BeforeArgs _beforeLeftCommandControl;
        internal static event Delegates.LeftCommandControl_AfterArgs _afterLeftCommandControl;

        private static InputControlType LeftCommandControl(Func<InputDeviceStyle, InputControlType> orig,
            InputDeviceStyle deviceStyle)
        {
            Delegates.Params_LeftCommandControl @params = new()
            {
                deviceStyle = deviceStyle
            };
            if (_beforeLeftCommandControl != null)
                foreach (Delegates.LeftCommandControl_BeforeArgs toInvoke in
                         _beforeLeftCommandControl.GetInvocationList())
                    try
                    {
                        _beforeLeftCommandControl?.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }

            deviceStyle = @params.deviceStyle;
            var retVal = orig(deviceStyle);
            if (_afterLeftCommandControl != null)
                foreach (Delegates.LeftCommandControl_AfterArgs toInvoke in
                         _afterLeftCommandControl.GetInvocationList())
                    try
                    {
                        retVal = _afterLeftCommandControl.Invoke(@params, retVal);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }

            return retVal;
        }

        internal static void HookRightCommandControl()
        {
            if (!HookedList.Contains("RightCommandControl"))
            {
                HookedList.Add("RightCommandControl");
                new Hook(
                    ReflectionHelper.GetMethodInfo(typeof(InputDeviceStyleExtensions), "RightCommandControl", false),
                    RightCommandControl);
            }
        }

        internal static event Delegates.RightCommandControl_BeforeArgs _beforeRightCommandControl;
        internal static event Delegates.RightCommandControl_AfterArgs _afterRightCommandControl;

        private static InputControlType RightCommandControl(Func<InputDeviceStyle, InputControlType> orig,
            InputDeviceStyle deviceStyle)
        {
            Delegates.Params_RightCommandControl @params = new()
            {
                deviceStyle = deviceStyle
            };
            if (_beforeRightCommandControl != null)
                foreach (Delegates.RightCommandControl_BeforeArgs toInvoke in _beforeRightCommandControl
                             .GetInvocationList())
                    try
                    {
                        _beforeRightCommandControl?.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }

            deviceStyle = @params.deviceStyle;
            var retVal = orig(deviceStyle);
            if (_afterRightCommandControl != null)
                foreach (Delegates.RightCommandControl_AfterArgs toInvoke in
                         _afterRightCommandControl.GetInvocationList())
                    try
                    {
                        retVal = _afterRightCommandControl.Invoke(@params, retVal);
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
        public delegate InputControlType LeftCommandControl_AfterArgs(Params_LeftCommandControl args,
            InputControlType ret);

        public delegate void LeftCommandControl_BeforeArgs(Params_LeftCommandControl args);

        public delegate InputControlType LeftCommandControl_WithArgs(Func<InputDeviceStyle, InputControlType> orig,
            InputDeviceStyle deviceStyle);

        public delegate InputControlType RightCommandControl_AfterArgs(Params_RightCommandControl args,
            InputControlType ret);

        public delegate void RightCommandControl_BeforeArgs(Params_RightCommandControl args);

        public delegate InputControlType RightCommandControl_WithArgs(Func<InputDeviceStyle, InputControlType> orig,
            InputDeviceStyle deviceStyle);

        public sealed class Params_LeftCommandControl
        {
            public InputDeviceStyle deviceStyle;
        }

        public sealed class Params_RightCommandControl
        {
            public InputDeviceStyle deviceStyle;
        }
    }

    /// <summary>
    ///     Contains Hooks to that run code before orig(self) is called
    /// </summary>
    public static class BeforeOrig
    {
        public static event Delegates.LeftCommandControl_BeforeArgs LeftCommandControl
        {
            add
            {
                HookHandler._beforeLeftCommandControl += value;
                HookHandler.HookLeftCommandControl();
            }
            remove => HookHandler._beforeLeftCommandControl -= value;
        }

        public static event Delegates.RightCommandControl_BeforeArgs RightCommandControl
        {
            add
            {
                HookHandler._beforeRightCommandControl += value;
                HookHandler.HookRightCommandControl();
            }
            remove => HookHandler._beforeRightCommandControl -= value;
        }
    }

    /// <summary>
    ///     Contains Hooks to that run code after orig(self) is called
    /// </summary>
    public static class AfterOrig
    {
        public static event Delegates.LeftCommandControl_AfterArgs LeftCommandControl
        {
            add
            {
                HookHandler._afterLeftCommandControl += value;
                HookHandler.HookLeftCommandControl();
            }
            remove => HookHandler._afterLeftCommandControl -= value;
        }

        public static event Delegates.RightCommandControl_AfterArgs RightCommandControl
        {
            add
            {
                HookHandler._afterRightCommandControl += value;
                HookHandler.HookRightCommandControl();
            }
            remove => HookHandler._afterRightCommandControl -= value;
        }
    }

    /// <summary>
    ///     Contains all On Hooks, even those that aren't in the On namespace such as API generated functions and property
    ///     getters/setters
    /// </summary>
    public static class WithOrig
    {
        public static event Delegates.LeftCommandControl_WithArgs LeftCommandControl
        {
            add => HookEndpointManager.Add<Delegates.LeftCommandControl_WithArgs>(
                ReflectionHelper.GetMethodInfo(typeof(InputDeviceStyleExtensions), "LeftCommandControl", false), value);
            remove => HookEndpointManager.Remove<Delegates.LeftCommandControl_WithArgs>(
                ReflectionHelper.GetMethodInfo(typeof(InputDeviceStyleExtensions), "LeftCommandControl", false), value);
        }

        public static event Delegates.RightCommandControl_WithArgs RightCommandControl
        {
            add => HookEndpointManager.Add<Delegates.RightCommandControl_WithArgs>(
                ReflectionHelper.GetMethodInfo(typeof(InputDeviceStyleExtensions), "RightCommandControl", false),
                value);
            remove => HookEndpointManager.Remove<Delegates.RightCommandControl_WithArgs>(
                ReflectionHelper.GetMethodInfo(typeof(InputDeviceStyleExtensions), "RightCommandControl", false),
                value);
        }
    }
}