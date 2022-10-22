using MonoMod.RuntimeDetour.HookGen;
namespace HKMirror.Hooks.ILHooks;
/// <summary>
/// Contains all correct IL Hooks for HealthCocoon,
/// Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
/// Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILHealthCocoon
{
public static event ILContext.Manipulator Awake
{
add => IL.HealthCocoon.Awake += value;
remove => IL.HealthCocoon.Awake -= value;
}
public static event ILContext.Manipulator Start
{
add => IL.HealthCocoon.Start += value;
remove => IL.HealthCocoon.Start -= value;
}
public static event ILContext.Manipulator PlaySound
{
add => IL.HealthCocoon.PlaySound += value;
remove => IL.HealthCocoon.PlaySound -= value;
}
public static event ILContext.Manipulator Animate
{
add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(HealthCocoon), "Animate", true).GetStateMachineTarget(), value);
remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(HealthCocoon), "Animate", true).GetStateMachineTarget(), value);
}
public static event ILContext.Manipulator OnTriggerEnter2D
{
add => IL.HealthCocoon.OnTriggerEnter2D += value;
remove => IL.HealthCocoon.OnTriggerEnter2D -= value;
}
public static event ILContext.Manipulator SetBroken
{
add => IL.HealthCocoon.SetBroken += value;
remove => IL.HealthCocoon.SetBroken -= value;
}
public static event ILContext.Manipulator FlingObjects
{
add => IL.HealthCocoon.FlingObjects += value;
remove => IL.HealthCocoon.FlingObjects -= value;
}
public static event ILContext.Manipulator SetScuttlerAmount
{
add => IL.HealthCocoon.SetScuttlerAmount += value;
remove => IL.HealthCocoon.SetScuttlerAmount -= value;
}
}
