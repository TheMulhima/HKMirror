using MonoMod.RuntimeDetour.HookGen;
namespace HKMirror.Hooks.ILHooks;
/// <summary>
/// Contains all correct IL Hooks for tk2dSpriteAttachPoint,
/// Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
/// Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILtk2dSpriteAttachPoint
{
public static event ILContext.Manipulator Awake
{
add => IL.tk2dSpriteAttachPoint.Awake += value;
remove => IL.tk2dSpriteAttachPoint.Awake -= value;
}
public static event ILContext.Manipulator OnEnable
{
add => IL.tk2dSpriteAttachPoint.OnEnable += value;
remove => IL.tk2dSpriteAttachPoint.OnEnable -= value;
}
public static event ILContext.Manipulator OnDisable
{
add => IL.tk2dSpriteAttachPoint.OnDisable += value;
remove => IL.tk2dSpriteAttachPoint.OnDisable -= value;
}
public static event ILContext.Manipulator UpdateAttachPointTransform
{
add => IL.tk2dSpriteAttachPoint.UpdateAttachPointTransform += value;
remove => IL.tk2dSpriteAttachPoint.UpdateAttachPointTransform -= value;
}
public static event ILContext.Manipulator GetInstanceName
{
add => IL.tk2dSpriteAttachPoint.GetInstanceName += value;
remove => IL.tk2dSpriteAttachPoint.GetInstanceName -= value;
}
public static event ILContext.Manipulator HandleSpriteChanged
{
add => IL.tk2dSpriteAttachPoint.HandleSpriteChanged += value;
remove => IL.tk2dSpriteAttachPoint.HandleSpriteChanged -= value;
}
}
