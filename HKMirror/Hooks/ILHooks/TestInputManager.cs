using MonoMod.RuntimeDetour.HookGen;

namespace HKMirror.Hooks.ILHooks;

/// <summary>
///     Contains all correct IL Hooks for TestInputManager.<br />
///     Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
///     Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILTestInputManager
{
    public static event ILContext.Manipulator OnEnable
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TestInputManager), "OnEnable"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(TestInputManager), "OnEnable"),
            value);
    }

    public static event ILContext.Manipulator HandleInputUpdate
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TestInputManager), "HandleInputUpdate"),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(TestInputManager), "HandleInputUpdate"), value);
    }

    public static event ILContext.Manipulator Start
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TestInputManager), "Start"), value);
        remove =>
            HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(TestInputManager), "Start"), value);
    }

    public static event ILContext.Manipulator Update
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TestInputManager), "Update"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(TestInputManager), "Update"),
            value);
    }

    public static event ILContext.Manipulator CheckForPauseButton
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(TestInputManager), "CheckForPauseButton"), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(TestInputManager), "CheckForPauseButton"), value);
    }

    public static event ILContext.Manipulator SetColor
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TestInputManager), "SetColor"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(TestInputManager), "SetColor"),
            value);
    }

    public static event ILContext.Manipulator OnGUI
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TestInputManager), "OnGUI"), value);
        remove =>
            HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(TestInputManager), "OnGUI"), value);
    }

    public static event ILContext.Manipulator DrawUnityInputDebugger
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(TestInputManager), "DrawUnityInputDebugger"), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(TestInputManager), "DrawUnityInputDebugger"), value);
    }

    public static event ILContext.Manipulator OnDrawGizmos
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TestInputManager), "OnDrawGizmos"),
            value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(TestInputManager), "OnDrawGizmos"),
            value);
    }
}