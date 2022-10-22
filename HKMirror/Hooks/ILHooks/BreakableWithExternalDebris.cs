using MonoMod.RuntimeDetour.HookGen;
namespace HKMirror.Hooks.ILHooks;
/// <summary>
/// Contains all correct IL Hooks for BreakableWithExternalDebris,
/// Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
/// Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILBreakableWithExternalDebris
{
public static event ILContext.Manipulator CreateAdditionalDebrisParts
{
add => IL.BreakableWithExternalDebris.CreateAdditionalDebrisParts += value;
remove => IL.BreakableWithExternalDebris.CreateAdditionalDebrisParts -= value;
}
public static event ILContext.Manipulator Spawn
{
add => IL.BreakableWithExternalDebris.Spawn += value;
remove => IL.BreakableWithExternalDebris.Spawn -= value;
}
}
