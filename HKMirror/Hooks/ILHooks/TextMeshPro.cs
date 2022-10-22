using MonoMod.RuntimeDetour.HookGen;
namespace HKMirror.Hooks.ILHooks;
/// <summary>
/// Contains all correct IL Hooks for TextMeshPro,
/// Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
/// Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILTextMeshPro
{
public static event ILContext.Manipulator Awake
{
add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TMPro.TextMeshPro), "Awake", true), value);
remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(TMPro.TextMeshPro), "Awake", true), value);
}
public static event ILContext.Manipulator OnEnable
{
add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TMPro.TextMeshPro), "OnEnable", true), value);
remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(TMPro.TextMeshPro), "OnEnable", true), value);
}
public static event ILContext.Manipulator OnDisable
{
add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TMPro.TextMeshPro), "OnDisable", true), value);
remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(TMPro.TextMeshPro), "OnDisable", true), value);
}
public static event ILContext.Manipulator OnDestroy
{
add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TMPro.TextMeshPro), "OnDestroy", true), value);
remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(TMPro.TextMeshPro), "OnDestroy", true), value);
}
public static event ILContext.Manipulator LoadFontAsset
{
add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TMPro.TextMeshPro), "LoadFontAsset", true), value);
remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(TMPro.TextMeshPro), "LoadFontAsset", true), value);
}
public static event ILContext.Manipulator UpdateEnvMapMatrix
{
add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TMPro.TextMeshPro), "UpdateEnvMapMatrix", true), value);
remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(TMPro.TextMeshPro), "UpdateEnvMapMatrix", true), value);
}
public static event ILContext.Manipulator SetMask_MaskingTypes
{
add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TMPro.TextMeshPro), "SetMask", true), value);
remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(TMPro.TextMeshPro), "SetMask", true), value);
}
public static event ILContext.Manipulator SetMaskCoordinates_Vector4
{
add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TMPro.TextMeshPro), "SetMaskCoordinates", true), value);
remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(TMPro.TextMeshPro), "SetMaskCoordinates", true), value);
}
public static event ILContext.Manipulator SetMaskCoordinates_Vector4_float_float
{
add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TMPro.TextMeshPro), "SetMaskCoordinates", true), value);
remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(TMPro.TextMeshPro), "SetMaskCoordinates", true), value);
}
public static event ILContext.Manipulator EnableMasking
{
add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TMPro.TextMeshPro), "EnableMasking", true), value);
remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(TMPro.TextMeshPro), "EnableMasking", true), value);
}
public static event ILContext.Manipulator DisableMasking
{
add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TMPro.TextMeshPro), "DisableMasking", true), value);
remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(TMPro.TextMeshPro), "DisableMasking", true), value);
}
public static event ILContext.Manipulator UpdateMask
{
add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TMPro.TextMeshPro), "UpdateMask", true), value);
remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(TMPro.TextMeshPro), "UpdateMask", true), value);
}
public static event ILContext.Manipulator GetMaterial
{
add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TMPro.TextMeshPro), "GetMaterial", true), value);
remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(TMPro.TextMeshPro), "GetMaterial", true), value);
}
public static event ILContext.Manipulator GetMaterials
{
add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TMPro.TextMeshPro), "GetMaterials", true), value);
remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(TMPro.TextMeshPro), "GetMaterials", true), value);
}
public static event ILContext.Manipulator SetSharedMaterial
{
add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TMPro.TextMeshPro), "SetSharedMaterial", true), value);
remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(TMPro.TextMeshPro), "SetSharedMaterial", true), value);
}
public static event ILContext.Manipulator GetSharedMaterials
{
add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TMPro.TextMeshPro), "GetSharedMaterials", true), value);
remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(TMPro.TextMeshPro), "GetSharedMaterials", true), value);
}
public static event ILContext.Manipulator SetSharedMaterials
{
add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TMPro.TextMeshPro), "SetSharedMaterials", true), value);
remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(TMPro.TextMeshPro), "SetSharedMaterials", true), value);
}
public static event ILContext.Manipulator SetOutlineThickness
{
add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TMPro.TextMeshPro), "SetOutlineThickness", true), value);
remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(TMPro.TextMeshPro), "SetOutlineThickness", true), value);
}
public static event ILContext.Manipulator SetFaceColor
{
add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TMPro.TextMeshPro), "SetFaceColor", true), value);
remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(TMPro.TextMeshPro), "SetFaceColor", true), value);
}
public static event ILContext.Manipulator SetOutlineColor
{
add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TMPro.TextMeshPro), "SetOutlineColor", true), value);
remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(TMPro.TextMeshPro), "SetOutlineColor", true), value);
}
public static event ILContext.Manipulator CreateMaterialInstance
{
add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TMPro.TextMeshPro), "CreateMaterialInstance", true), value);
remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(TMPro.TextMeshPro), "CreateMaterialInstance", true), value);
}
public static event ILContext.Manipulator SetShaderDepth
{
add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TMPro.TextMeshPro), "SetShaderDepth", true), value);
remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(TMPro.TextMeshPro), "SetShaderDepth", true), value);
}
public static event ILContext.Manipulator SetCulling
{
add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TMPro.TextMeshPro), "SetCulling", true), value);
remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(TMPro.TextMeshPro), "SetCulling", true), value);
}
public static event ILContext.Manipulator SetPerspectiveCorrection
{
add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TMPro.TextMeshPro), "SetPerspectiveCorrection", true), value);
remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(TMPro.TextMeshPro), "SetPerspectiveCorrection", true), value);
}
public static event ILContext.Manipulator GetPaddingForMaterial_Material
{
add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TMPro.TextMeshPro), "GetPaddingForMaterial", true), value);
remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(TMPro.TextMeshPro), "GetPaddingForMaterial", true), value);
}
public static event ILContext.Manipulator GetPaddingForMaterial
{
add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TMPro.TextMeshPro), "GetPaddingForMaterial", true), value);
remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(TMPro.TextMeshPro), "GetPaddingForMaterial", true), value);
}
public static event ILContext.Manipulator SetArraySizes
{
add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TMPro.TextMeshPro), "SetArraySizes", true), value);
remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(TMPro.TextMeshPro), "SetArraySizes", true), value);
}
public static event ILContext.Manipulator ComputeMarginSize
{
add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TMPro.TextMeshPro), "ComputeMarginSize", true), value);
remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(TMPro.TextMeshPro), "ComputeMarginSize", true), value);
}
public static event ILContext.Manipulator OnDidApplyAnimationProperties
{
add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TMPro.TextMeshPro), "OnDidApplyAnimationProperties", true), value);
remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(TMPro.TextMeshPro), "OnDidApplyAnimationProperties", true), value);
}
public static event ILContext.Manipulator OnTransformParentChanged
{
add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TMPro.TextMeshPro), "OnTransformParentChanged", true), value);
remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(TMPro.TextMeshPro), "OnTransformParentChanged", true), value);
}
public static event ILContext.Manipulator OnRectTransformDimensionsChange
{
add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TMPro.TextMeshPro), "OnRectTransformDimensionsChange", true), value);
remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(TMPro.TextMeshPro), "OnRectTransformDimensionsChange", true), value);
}
public static event ILContext.Manipulator LateUpdate
{
add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TMPro.TextMeshPro), "LateUpdate", true), value);
remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(TMPro.TextMeshPro), "LateUpdate", true), value);
}
public static event ILContext.Manipulator OnPreRenderObject
{
add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TMPro.TextMeshPro), "OnPreRenderObject", true), value);
remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(TMPro.TextMeshPro), "OnPreRenderObject", true), value);
}
public static event ILContext.Manipulator GenerateTextMesh
{
add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TMPro.TextMeshPro), "GenerateTextMesh", true), value);
remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(TMPro.TextMeshPro), "GenerateTextMesh", true), value);
}
public static event ILContext.Manipulator GetTextContainerLocalCorners
{
add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TMPro.TextMeshPro), "GetTextContainerLocalCorners", true), value);
remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(TMPro.TextMeshPro), "GetTextContainerLocalCorners", true), value);
}
public static event ILContext.Manipulator ClearMesh
{
add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TMPro.TextMeshPro), "ClearMesh", true), value);
remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(TMPro.TextMeshPro), "ClearMesh", true), value);
}
public static event ILContext.Manipulator SetMeshFilters
{
add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TMPro.TextMeshPro), "SetMeshFilters", true), value);
remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(TMPro.TextMeshPro), "SetMeshFilters", true), value);
}
public static event ILContext.Manipulator SetActiveSubMeshes
{
add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TMPro.TextMeshPro), "SetActiveSubMeshes", true), value);
remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(TMPro.TextMeshPro), "SetActiveSubMeshes", true), value);
}
public static event ILContext.Manipulator GetCompoundBounds
{
add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TMPro.TextMeshPro), "GetCompoundBounds", true), value);
remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(TMPro.TextMeshPro), "GetCompoundBounds", true), value);
}
public static event ILContext.Manipulator UpdateSDFScale
{
add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TMPro.TextMeshPro), "UpdateSDFScale", true), value);
remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(TMPro.TextMeshPro), "UpdateSDFScale", true), value);
}
public static event ILContext.Manipulator AdjustLineOffset
{
add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TMPro.TextMeshPro), "AdjustLineOffset", true), value);
remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(TMPro.TextMeshPro), "AdjustLineOffset", true), value);
}
public static event ILContext.Manipulator get_lineLength
{
add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TMPro.TextMeshPro), "get_lineLength", true), value);
remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(TMPro.TextMeshPro), "get_lineLength", true), value);
}
public static event ILContext.Manipulator set_lineLength
{
add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TMPro.TextMeshPro), "set_lineLength", true), value);
remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(TMPro.TextMeshPro), "set_lineLength", true), value);
}
public static event ILContext.Manipulator set_anchor
{
add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TMPro.TextMeshPro), "set_anchor", true), value);
remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(TMPro.TextMeshPro), "set_anchor", true), value);
}
public static event ILContext.Manipulator get_margin
{
add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TMPro.TextMeshPro), "get_margin", true), value);
remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(TMPro.TextMeshPro), "get_margin", true), value);
}
public static event ILContext.Manipulator set_margin
{
add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TMPro.TextMeshPro), "set_margin", true), value);
remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(TMPro.TextMeshPro), "set_margin", true), value);
}
public static event ILContext.Manipulator get_sortingLayerID
{
add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TMPro.TextMeshPro), "get_sortingLayerID", true), value);
remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(TMPro.TextMeshPro), "get_sortingLayerID", true), value);
}
public static event ILContext.Manipulator set_sortingLayerID
{
add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TMPro.TextMeshPro), "set_sortingLayerID", true), value);
remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(TMPro.TextMeshPro), "set_sortingLayerID", true), value);
}
public static event ILContext.Manipulator get_sortingOrder
{
add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TMPro.TextMeshPro), "get_sortingOrder", true), value);
remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(TMPro.TextMeshPro), "get_sortingOrder", true), value);
}
public static event ILContext.Manipulator set_sortingOrder
{
add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TMPro.TextMeshPro), "set_sortingOrder", true), value);
remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(TMPro.TextMeshPro), "set_sortingOrder", true), value);
}
public static event ILContext.Manipulator get_autoSizeTextContainer
{
add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TMPro.TextMeshPro), "get_autoSizeTextContainer", true), value);
remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(TMPro.TextMeshPro), "get_autoSizeTextContainer", true), value);
}
public static event ILContext.Manipulator set_autoSizeTextContainer
{
add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TMPro.TextMeshPro), "set_autoSizeTextContainer", true), value);
remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(TMPro.TextMeshPro), "set_autoSizeTextContainer", true), value);
}
public static event ILContext.Manipulator get_textContainer
{
add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TMPro.TextMeshPro), "get_textContainer", true), value);
remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(TMPro.TextMeshPro), "get_textContainer", true), value);
}
public static event ILContext.Manipulator get_transform
{
add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TMPro.TextMeshPro), "get_transform", true), value);
remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(TMPro.TextMeshPro), "get_transform", true), value);
}
public static event ILContext.Manipulator get_renderer
{
add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TMPro.TextMeshPro), "get_renderer", true), value);
remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(TMPro.TextMeshPro), "get_renderer", true), value);
}
public static event ILContext.Manipulator get_mesh
{
add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TMPro.TextMeshPro), "get_mesh", true), value);
remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(TMPro.TextMeshPro), "get_mesh", true), value);
}
public static event ILContext.Manipulator get_meshFilter
{
add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TMPro.TextMeshPro), "get_meshFilter", true), value);
remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(TMPro.TextMeshPro), "get_meshFilter", true), value);
}
public static event ILContext.Manipulator get_maskType
{
add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TMPro.TextMeshPro), "get_maskType", true), value);
remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(TMPro.TextMeshPro), "get_maskType", true), value);
}
public static event ILContext.Manipulator set_maskType
{
add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TMPro.TextMeshPro), "set_maskType", true), value);
remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(TMPro.TextMeshPro), "set_maskType", true), value);
}
public static event ILContext.Manipulator SetMask_MaskingTypes_Vector4
{
add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TMPro.TextMeshPro), "SetMask", true), value);
remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(TMPro.TextMeshPro), "SetMask", true), value);
}
public static event ILContext.Manipulator SetMask_MaskingTypes_Vector4_float_float
{
add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TMPro.TextMeshPro), "SetMask", true), value);
remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(TMPro.TextMeshPro), "SetMask", true), value);
}
public static event ILContext.Manipulator SetVerticesDirty
{
add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TMPro.TextMeshPro), "SetVerticesDirty", true), value);
remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(TMPro.TextMeshPro), "SetVerticesDirty", true), value);
}
public static event ILContext.Manipulator SetLayoutDirty
{
add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TMPro.TextMeshPro), "SetLayoutDirty", true), value);
remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(TMPro.TextMeshPro), "SetLayoutDirty", true), value);
}
public static event ILContext.Manipulator SetMaterialDirty
{
add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TMPro.TextMeshPro), "SetMaterialDirty", true), value);
remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(TMPro.TextMeshPro), "SetMaterialDirty", true), value);
}
public static event ILContext.Manipulator SetAllDirty
{
add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TMPro.TextMeshPro), "SetAllDirty", true), value);
remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(TMPro.TextMeshPro), "SetAllDirty", true), value);
}
public static event ILContext.Manipulator Rebuild
{
add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TMPro.TextMeshPro), "Rebuild", true), value);
remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(TMPro.TextMeshPro), "Rebuild", true), value);
}
public static event ILContext.Manipulator UpdateMaterial
{
add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TMPro.TextMeshPro), "UpdateMaterial", true), value);
remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(TMPro.TextMeshPro), "UpdateMaterial", true), value);
}
public static event ILContext.Manipulator UpdateMeshPadding
{
add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TMPro.TextMeshPro), "UpdateMeshPadding", true), value);
remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(TMPro.TextMeshPro), "UpdateMeshPadding", true), value);
}
public static event ILContext.Manipulator ForceMeshUpdate
{
add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TMPro.TextMeshPro), "ForceMeshUpdate", true), value);
remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(TMPro.TextMeshPro), "ForceMeshUpdate", true), value);
}
public static event ILContext.Manipulator ForceMeshUpdate_bool
{
add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TMPro.TextMeshPro), "ForceMeshUpdate", true), value);
remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(TMPro.TextMeshPro), "ForceMeshUpdate", true), value);
}
public static event ILContext.Manipulator GetTextInfo
{
add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TMPro.TextMeshPro), "GetTextInfo", true), value);
remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(TMPro.TextMeshPro), "GetTextInfo", true), value);
}
public static event ILContext.Manipulator UpdateGeometry
{
add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TMPro.TextMeshPro), "UpdateGeometry", true), value);
remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(TMPro.TextMeshPro), "UpdateGeometry", true), value);
}
public static event ILContext.Manipulator UpdateVertexData_TMP_VertexDataUpdateFlags
{
add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TMPro.TextMeshPro), "UpdateVertexData", true), value);
remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(TMPro.TextMeshPro), "UpdateVertexData", true), value);
}
public static event ILContext.Manipulator UpdateVertexData
{
add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TMPro.TextMeshPro), "UpdateVertexData", true), value);
remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(TMPro.TextMeshPro), "UpdateVertexData", true), value);
}
public static event ILContext.Manipulator UpdateFontAsset
{
add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TMPro.TextMeshPro), "UpdateFontAsset", true), value);
remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(TMPro.TextMeshPro), "UpdateFontAsset", true), value);
}
public static event ILContext.Manipulator CalculateLayoutInputHorizontal
{
add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TMPro.TextMeshPro), "CalculateLayoutInputHorizontal", true), value);
remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(TMPro.TextMeshPro), "CalculateLayoutInputHorizontal", true), value);
}
public static event ILContext.Manipulator CalculateLayoutInputVertical
{
add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TMPro.TextMeshPro), "CalculateLayoutInputVertical", true), value);
remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(TMPro.TextMeshPro), "CalculateLayoutInputVertical", true), value);
}
}
