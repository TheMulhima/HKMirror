using MonoMod.RuntimeDetour.HookGen;
namespace HKMirror.Hooks.ILHooks;
/// <summary>
/// Contains all correct IL Hooks for tk2dSpriteCollectionDefinition_ColliderData,
/// Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
/// Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILtk2dSpriteCollectionDefinition_ColliderData
{
public static event ILContext.Manipulator CopyFrom
{
add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(tk2dSpriteCollectionDefinition.ColliderData), "CopyFrom", true), value);
remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(tk2dSpriteCollectionDefinition.ColliderData), "CopyFrom", true), value);
}
public static event ILContext.Manipulator CompareTo
{
add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(tk2dSpriteCollectionDefinition.ColliderData), "CompareTo", true), value);
remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(tk2dSpriteCollectionDefinition.ColliderData), "CompareTo", true), value);
}
}
