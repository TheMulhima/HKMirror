using MonoMod.RuntimeDetour.HookGen;

namespace HKMirror.Hooks.ILHooks;

/// <summary>
///     Contains all correct IL Hooks for ShineAnimSequence.<br />
///     Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
///     Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILShineAnimSequence
{
    public static event ILContext.Manipulator Start
    {
        add => IL.ShineAnimSequence.Start += value;
        remove => IL.ShineAnimSequence.Start -= value;
    }

    public static event ILContext.Manipulator ShineSequence
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(ShineAnimSequence), "ShineSequence").GetStateMachineTarget(), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(ShineAnimSequence), "ShineSequence").GetStateMachineTarget(), value);
    }
}