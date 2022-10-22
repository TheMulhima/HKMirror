using MonoMod.RuntimeDetour.HookGen;
namespace HKMirror.Hooks.ILHooks;
/// <summary>
/// Contains all correct IL Hooks for Mask,
/// Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
/// Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILMask
{
public static event ILContext.Manipulator set_maskMappingWorldAxis
{
add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(ToJ.Mask), "set_maskMappingWorldAxis", true), value);
remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(ToJ.Mask), "set_maskMappingWorldAxis", true), value);
}
public static event ILContext.Manipulator get_invertAxis
{
add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(ToJ.Mask), "get_invertAxis", true), value);
remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(ToJ.Mask), "get_invertAxis", true), value);
}
public static event ILContext.Manipulator set_invertAxis
{
add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(ToJ.Mask), "set_invertAxis", true), value);
remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(ToJ.Mask), "set_invertAxis", true), value);
}
public static event ILContext.Manipulator get_clampAlphaHorizontally
{
add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(ToJ.Mask), "get_clampAlphaHorizontally", true), value);
remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(ToJ.Mask), "get_clampAlphaHorizontally", true), value);
}
public static event ILContext.Manipulator set_clampAlphaHorizontally
{
add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(ToJ.Mask), "set_clampAlphaHorizontally", true), value);
remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(ToJ.Mask), "set_clampAlphaHorizontally", true), value);
}
public static event ILContext.Manipulator get_clampAlphaVertically
{
add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(ToJ.Mask), "get_clampAlphaVertically", true), value);
remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(ToJ.Mask), "get_clampAlphaVertically", true), value);
}
public static event ILContext.Manipulator set_clampAlphaVertically
{
add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(ToJ.Mask), "set_clampAlphaVertically", true), value);
remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(ToJ.Mask), "set_clampAlphaVertically", true), value);
}
public static event ILContext.Manipulator get_clampingBorder
{
add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(ToJ.Mask), "get_clampingBorder", true), value);
remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(ToJ.Mask), "get_clampingBorder", true), value);
}
public static event ILContext.Manipulator set_clampingBorder
{
add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(ToJ.Mask), "set_clampingBorder", true), value);
remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(ToJ.Mask), "set_clampingBorder", true), value);
}
public static event ILContext.Manipulator get_useMaskAlphaChannel
{
add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(ToJ.Mask), "get_useMaskAlphaChannel", true), value);
remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(ToJ.Mask), "get_useMaskAlphaChannel", true), value);
}
public static event ILContext.Manipulator set_useMaskAlphaChannel
{
add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(ToJ.Mask), "set_useMaskAlphaChannel", true), value);
remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(ToJ.Mask), "set_useMaskAlphaChannel", true), value);
}
public static event ILContext.Manipulator Start
{
add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(ToJ.Mask), "Start", true), value);
remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(ToJ.Mask), "Start", true), value);
}
public static event ILContext.Manipulator Update
{
add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(ToJ.Mask), "Update", true), value);
remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(ToJ.Mask), "Update", true), value);
}
public static event ILContext.Manipulator RotateVector
{
add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(ToJ.Mask), "RotateVector", true), value);
remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(ToJ.Mask), "RotateVector", true), value);
}
public static event ILContext.Manipulator SetMaskMappingAxisInMaterials
{
add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(ToJ.Mask), "SetMaskMappingAxisInMaterials", true), value);
remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(ToJ.Mask), "SetMaskMappingAxisInMaterials", true), value);
}
public static event ILContext.Manipulator SetMaskMappingAxisInMaterial
{
add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(ToJ.Mask), "SetMaskMappingAxisInMaterial", true), value);
remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(ToJ.Mask), "SetMaskMappingAxisInMaterial", true), value);
}
public static event ILContext.Manipulator SetMaskFloatValueInMaterials
{
add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(ToJ.Mask), "SetMaskFloatValueInMaterials", true), value);
remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(ToJ.Mask), "SetMaskFloatValueInMaterials", true), value);
}
public static event ILContext.Manipulator SetMaskBoolValueInMaterials
{
add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(ToJ.Mask), "SetMaskBoolValueInMaterials", true), value);
remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(ToJ.Mask), "SetMaskBoolValueInMaterials", true), value);
}
public static event ILContext.Manipulator SetMaskBoolValueInMaterial
{
add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(ToJ.Mask), "SetMaskBoolValueInMaterial", true), value);
remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(ToJ.Mask), "SetMaskBoolValueInMaterial", true), value);
}
public static event ILContext.Manipulator CreateAndAssignQuad
{
add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(ToJ.Mask), "CreateAndAssignQuad", true), value);
remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(ToJ.Mask), "CreateAndAssignQuad", true), value);
}
public static event ILContext.Manipulator SetMaskRendererActive
{
add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(ToJ.Mask), "SetMaskRendererActive", true), value);
remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(ToJ.Mask), "SetMaskRendererActive", true), value);
}
public static event ILContext.Manipulator ChangeMappingAxis
{
add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(ToJ.Mask), "ChangeMappingAxis", true), value);
remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(ToJ.Mask), "ChangeMappingAxis", true), value);
}
}
