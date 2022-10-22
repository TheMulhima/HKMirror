using MonoMod.RuntimeDetour.HookGen;
namespace HKMirror.Hooks.ILHooks;
/// <summary>
/// Contains all correct IL Hooks for ShineAnimSequence_ShineObject,
/// Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
/// Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILShineAnimSequence_ShineObject
{
public static event ILContext.Manipulator ShineAnim
{
add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(ShineAnimSequence.ShineObject), "ShineAnim", true).GetStateMachineTarget(), value);
remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(ShineAnimSequence.ShineObject), "ShineAnim", true).GetStateMachineTarget(), value);
}
}
