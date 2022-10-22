using MonoMod.RuntimeDetour.HookGen;
namespace HKMirror.Hooks.ILHooks;
/// <summary>
/// Contains all correct IL Hooks for tk2dSlicedSprite,
/// Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
/// Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILtk2dSlicedSprite
{
public static event ILContext.Manipulator get_BorderOnly
{
add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(tk2dSlicedSprite), "get_BorderOnly", true), value);
remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(tk2dSlicedSprite), "get_BorderOnly", true), value);
}
public static event ILContext.Manipulator set_BorderOnly
{
add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(tk2dSlicedSprite), "set_BorderOnly", true), value);
remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(tk2dSlicedSprite), "set_BorderOnly", true), value);
}
public static event ILContext.Manipulator get_dimensions
{
add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(tk2dSlicedSprite), "get_dimensions", true), value);
remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(tk2dSlicedSprite), "get_dimensions", true), value);
}
public static event ILContext.Manipulator set_dimensions
{
add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(tk2dSlicedSprite), "set_dimensions", true), value);
remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(tk2dSlicedSprite), "set_dimensions", true), value);
}
public static event ILContext.Manipulator set_anchor
{
add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(tk2dSlicedSprite), "set_anchor", true), value);
remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(tk2dSlicedSprite), "set_anchor", true), value);
}
public static event ILContext.Manipulator SetBorder
{
add => IL.tk2dSlicedSprite.SetBorder += value;
remove => IL.tk2dSlicedSprite.SetBorder -= value;
}
public static event ILContext.Manipulator get_CreateBoxCollider
{
add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(tk2dSlicedSprite), "get_CreateBoxCollider", true), value);
remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(tk2dSlicedSprite), "get_CreateBoxCollider", true), value);
}
public static event ILContext.Manipulator set_CreateBoxCollider
{
add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(tk2dSlicedSprite), "set_CreateBoxCollider", true), value);
remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(tk2dSlicedSprite), "set_CreateBoxCollider", true), value);
}
public static event ILContext.Manipulator Awake
{
add => IL.tk2dSlicedSprite.Awake += value;
remove => IL.tk2dSlicedSprite.Awake -= value;
}
public static event ILContext.Manipulator OnDestroy
{
add => IL.tk2dSlicedSprite.OnDestroy += value;
remove => IL.tk2dSlicedSprite.OnDestroy -= value;
}
public static event ILContext.Manipulator SetColors
{
add => IL.tk2dSlicedSprite.SetColors += value;
remove => IL.tk2dSlicedSprite.SetColors -= value;
}
public static event ILContext.Manipulator SetGeometry
{
add => IL.tk2dSlicedSprite.SetGeometry += value;
remove => IL.tk2dSlicedSprite.SetGeometry -= value;
}
public static event ILContext.Manipulator SetIndices
{
add => IL.tk2dSlicedSprite.SetIndices += value;
remove => IL.tk2dSlicedSprite.SetIndices -= value;
}
public static event ILContext.Manipulator NearEnough
{
add => IL.tk2dSlicedSprite.NearEnough += value;
remove => IL.tk2dSlicedSprite.NearEnough -= value;
}
public static event ILContext.Manipulator PermanentUpgradeLegacyMode
{
add => IL.tk2dSlicedSprite.PermanentUpgradeLegacyMode += value;
remove => IL.tk2dSlicedSprite.PermanentUpgradeLegacyMode -= value;
}
public static event ILContext.Manipulator Build
{
add => IL.tk2dSlicedSprite.Build += value;
remove => IL.tk2dSlicedSprite.Build -= value;
}
public static event ILContext.Manipulator UpdateGeometry
{
add => IL.tk2dSlicedSprite.UpdateGeometry += value;
remove => IL.tk2dSlicedSprite.UpdateGeometry -= value;
}
public static event ILContext.Manipulator UpdateColors
{
add => IL.tk2dSlicedSprite.UpdateColors += value;
remove => IL.tk2dSlicedSprite.UpdateColors -= value;
}
public static event ILContext.Manipulator UpdateVertices
{
add => IL.tk2dSlicedSprite.UpdateVertices += value;
remove => IL.tk2dSlicedSprite.UpdateVertices -= value;
}
public static event ILContext.Manipulator UpdateIndices
{
add => IL.tk2dSlicedSprite.UpdateIndices += value;
remove => IL.tk2dSlicedSprite.UpdateIndices -= value;
}
public static event ILContext.Manipulator UpdateColorsImpl
{
add => IL.tk2dSlicedSprite.UpdateColorsImpl += value;
remove => IL.tk2dSlicedSprite.UpdateColorsImpl -= value;
}
public static event ILContext.Manipulator UpdateGeometryImpl
{
add => IL.tk2dSlicedSprite.UpdateGeometryImpl += value;
remove => IL.tk2dSlicedSprite.UpdateGeometryImpl -= value;
}
public static event ILContext.Manipulator UpdateCollider
{
add => IL.tk2dSlicedSprite.UpdateCollider += value;
remove => IL.tk2dSlicedSprite.UpdateCollider -= value;
}
public static event ILContext.Manipulator CreateCollider
{
add => IL.tk2dSlicedSprite.CreateCollider += value;
remove => IL.tk2dSlicedSprite.CreateCollider -= value;
}
public static event ILContext.Manipulator UpdateMaterial
{
add => IL.tk2dSlicedSprite.UpdateMaterial += value;
remove => IL.tk2dSlicedSprite.UpdateMaterial -= value;
}
public static event ILContext.Manipulator GetCurrentVertexCount
{
add => IL.tk2dSlicedSprite.GetCurrentVertexCount += value;
remove => IL.tk2dSlicedSprite.GetCurrentVertexCount -= value;
}
public static event ILContext.Manipulator ReshapeBounds
{
add => IL.tk2dSlicedSprite.ReshapeBounds += value;
remove => IL.tk2dSlicedSprite.ReshapeBounds -= value;
}
}
