using MonoMod.RuntimeDetour.HookGen;
using TMPro;

namespace HKMirror.Hooks.ILHooks;

/// <summary>
///     Contains all correct IL Hooks for TextMeshPro.<br />
///     Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
///     Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILTextMeshPro
{
    public static event ILContext.Manipulator Awake
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TextMeshPro), "Awake"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(TextMeshPro), "Awake"), value);
    }

    public static event ILContext.Manipulator OnEnable
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TextMeshPro), "OnEnable"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(TextMeshPro), "OnEnable"), value);
    }

    public static event ILContext.Manipulator OnDisable
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TextMeshPro), "OnDisable"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(TextMeshPro), "OnDisable"), value);
    }

    public static event ILContext.Manipulator OnDestroy
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TextMeshPro), "OnDestroy"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(TextMeshPro), "OnDestroy"), value);
    }

    public static event ILContext.Manipulator LoadFontAsset
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TextMeshPro), "LoadFontAsset"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(TextMeshPro), "LoadFontAsset"),
            value);
    }

    public static event ILContext.Manipulator UpdateEnvMapMatrix
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TextMeshPro), "UpdateEnvMapMatrix"),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(TextMeshPro), "UpdateEnvMapMatrix"), value);
    }

    public static event ILContext.Manipulator SetMask_MaskingTypes
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TextMeshPro), "SetMask"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(TextMeshPro), "SetMask"), value);
    }

    public static event ILContext.Manipulator SetMaskCoordinates_Vector4
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TextMeshPro), "SetMaskCoordinates"),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(TextMeshPro), "SetMaskCoordinates"), value);
    }

    public static event ILContext.Manipulator SetMaskCoordinates_Vector4_float_float
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TextMeshPro), "SetMaskCoordinates"),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(TextMeshPro), "SetMaskCoordinates"), value);
    }

    public static event ILContext.Manipulator EnableMasking
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TextMeshPro), "EnableMasking"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(TextMeshPro), "EnableMasking"),
            value);
    }

    public static event ILContext.Manipulator DisableMasking
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TextMeshPro), "DisableMasking"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(TextMeshPro), "DisableMasking"),
            value);
    }

    public static event ILContext.Manipulator UpdateMask
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TextMeshPro), "UpdateMask"), value);
        remove =>
            HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(TextMeshPro), "UpdateMask"), value);
    }

    public static event ILContext.Manipulator GetMaterial
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TextMeshPro), "GetMaterial"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(TextMeshPro), "GetMaterial"),
            value);
    }

    public static event ILContext.Manipulator GetMaterials
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TextMeshPro), "GetMaterials"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(TextMeshPro), "GetMaterials"),
            value);
    }

    public static event ILContext.Manipulator SetSharedMaterial
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TextMeshPro), "SetSharedMaterial"),
            value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(TextMeshPro), "SetSharedMaterial"),
            value);
    }

    public static event ILContext.Manipulator GetSharedMaterials
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TextMeshPro), "GetSharedMaterials"),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(TextMeshPro), "GetSharedMaterials"), value);
    }

    public static event ILContext.Manipulator SetSharedMaterials
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TextMeshPro), "SetSharedMaterials"),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(TextMeshPro), "SetSharedMaterials"), value);
    }

    public static event ILContext.Manipulator SetOutlineThickness
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TextMeshPro), "SetOutlineThickness"),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(TextMeshPro), "SetOutlineThickness"), value);
    }

    public static event ILContext.Manipulator SetFaceColor
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TextMeshPro), "SetFaceColor"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(TextMeshPro), "SetFaceColor"),
            value);
    }

    public static event ILContext.Manipulator SetOutlineColor
    {
        add =>
            HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TextMeshPro), "SetOutlineColor"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(TextMeshPro), "SetOutlineColor"),
            value);
    }

    public static event ILContext.Manipulator CreateMaterialInstance
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TextMeshPro), "CreateMaterialInstance"),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(TextMeshPro), "CreateMaterialInstance"), value);
    }

    public static event ILContext.Manipulator SetShaderDepth
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TextMeshPro), "SetShaderDepth"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(TextMeshPro), "SetShaderDepth"),
            value);
    }

    public static event ILContext.Manipulator SetCulling
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TextMeshPro), "SetCulling"), value);
        remove =>
            HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(TextMeshPro), "SetCulling"), value);
    }

    public static event ILContext.Manipulator SetPerspectiveCorrection
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(TextMeshPro), "SetPerspectiveCorrection"), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(TextMeshPro), "SetPerspectiveCorrection"), value);
    }

    public static event ILContext.Manipulator GetPaddingForMaterial_Material
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TextMeshPro), "GetPaddingForMaterial"),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(TextMeshPro), "GetPaddingForMaterial"), value);
    }

    public static event ILContext.Manipulator GetPaddingForMaterial
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TextMeshPro), "GetPaddingForMaterial"),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(TextMeshPro), "GetPaddingForMaterial"), value);
    }

    public static event ILContext.Manipulator SetArraySizes
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TextMeshPro), "SetArraySizes"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(TextMeshPro), "SetArraySizes"),
            value);
    }

    public static event ILContext.Manipulator ComputeMarginSize
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TextMeshPro), "ComputeMarginSize"),
            value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(TextMeshPro), "ComputeMarginSize"),
            value);
    }

    public static event ILContext.Manipulator OnDidApplyAnimationProperties
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(TextMeshPro), "OnDidApplyAnimationProperties"), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(TextMeshPro), "OnDidApplyAnimationProperties"), value);
    }

    public static event ILContext.Manipulator OnTransformParentChanged
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(TextMeshPro), "OnTransformParentChanged"), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(TextMeshPro), "OnTransformParentChanged"), value);
    }

    public static event ILContext.Manipulator OnRectTransformDimensionsChange
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(TextMeshPro), "OnRectTransformDimensionsChange"), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(TextMeshPro), "OnRectTransformDimensionsChange"), value);
    }

    public static event ILContext.Manipulator LateUpdate
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TextMeshPro), "LateUpdate"), value);
        remove =>
            HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(TextMeshPro), "LateUpdate"), value);
    }

    public static event ILContext.Manipulator OnPreRenderObject
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TextMeshPro), "OnPreRenderObject"),
            value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(TextMeshPro), "OnPreRenderObject"),
            value);
    }

    public static event ILContext.Manipulator GenerateTextMesh
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TextMeshPro), "GenerateTextMesh"),
            value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(TextMeshPro), "GenerateTextMesh"),
            value);
    }

    public static event ILContext.Manipulator GetTextContainerLocalCorners
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(TextMeshPro), "GetTextContainerLocalCorners"), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(TextMeshPro), "GetTextContainerLocalCorners"), value);
    }

    public static event ILContext.Manipulator ClearMesh
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TextMeshPro), "ClearMesh"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(TextMeshPro), "ClearMesh"), value);
    }

    public static event ILContext.Manipulator SetMeshFilters
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TextMeshPro), "SetMeshFilters"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(TextMeshPro), "SetMeshFilters"),
            value);
    }

    public static event ILContext.Manipulator SetActiveSubMeshes
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TextMeshPro), "SetActiveSubMeshes"),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(TextMeshPro), "SetActiveSubMeshes"), value);
    }

    public static event ILContext.Manipulator GetCompoundBounds
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TextMeshPro), "GetCompoundBounds"),
            value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(TextMeshPro), "GetCompoundBounds"),
            value);
    }

    public static event ILContext.Manipulator UpdateSDFScale
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TextMeshPro), "UpdateSDFScale"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(TextMeshPro), "UpdateSDFScale"),
            value);
    }

    public static event ILContext.Manipulator AdjustLineOffset
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TextMeshPro), "AdjustLineOffset"),
            value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(TextMeshPro), "AdjustLineOffset"),
            value);
    }

    public static event ILContext.Manipulator get_lineLength
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TextMeshPro), "get_lineLength"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(TextMeshPro), "get_lineLength"),
            value);
    }

    public static event ILContext.Manipulator set_lineLength
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TextMeshPro), "set_lineLength"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(TextMeshPro), "set_lineLength"),
            value);
    }

    public static event ILContext.Manipulator get_margin
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TextMeshPro), "get_margin"), value);
        remove =>
            HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(TextMeshPro), "get_margin"), value);
    }

    public static event ILContext.Manipulator set_margin
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TextMeshPro), "set_margin"), value);
        remove =>
            HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(TextMeshPro), "set_margin"), value);
    }

    public static event ILContext.Manipulator get_sortingLayerID
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TextMeshPro), "get_sortingLayerID"),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(TextMeshPro), "get_sortingLayerID"), value);
    }

    public static event ILContext.Manipulator set_sortingLayerID
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TextMeshPro), "set_sortingLayerID"),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(TextMeshPro), "set_sortingLayerID"), value);
    }

    public static event ILContext.Manipulator get_sortingOrder
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TextMeshPro), "get_sortingOrder"),
            value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(TextMeshPro), "get_sortingOrder"),
            value);
    }

    public static event ILContext.Manipulator set_sortingOrder
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TextMeshPro), "set_sortingOrder"),
            value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(TextMeshPro), "set_sortingOrder"),
            value);
    }

    public static event ILContext.Manipulator get_autoSizeTextContainer
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(TextMeshPro), "get_autoSizeTextContainer"), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(TextMeshPro), "get_autoSizeTextContainer"), value);
    }

    public static event ILContext.Manipulator set_autoSizeTextContainer
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(TextMeshPro), "set_autoSizeTextContainer"), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(TextMeshPro), "set_autoSizeTextContainer"), value);
    }

    public static event ILContext.Manipulator get_textContainer
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TextMeshPro), "get_textContainer"),
            value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(TextMeshPro), "get_textContainer"),
            value);
    }

    public static event ILContext.Manipulator get_transform
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TextMeshPro), "get_transform"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(TextMeshPro), "get_transform"),
            value);
    }

    public static event ILContext.Manipulator get_renderer
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TextMeshPro), "get_renderer"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(TextMeshPro), "get_renderer"),
            value);
    }

    public static event ILContext.Manipulator get_mesh
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TextMeshPro), "get_mesh"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(TextMeshPro), "get_mesh"), value);
    }

    public static event ILContext.Manipulator get_meshFilter
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TextMeshPro), "get_meshFilter"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(TextMeshPro), "get_meshFilter"),
            value);
    }

    public static event ILContext.Manipulator get_maskType
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TextMeshPro), "get_maskType"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(TextMeshPro), "get_maskType"),
            value);
    }

    public static event ILContext.Manipulator set_maskType
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TextMeshPro), "set_maskType"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(TextMeshPro), "set_maskType"),
            value);
    }

    public static event ILContext.Manipulator SetMask_MaskingTypes_Vector4
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TextMeshPro), "SetMask"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(TextMeshPro), "SetMask"), value);
    }

    public static event ILContext.Manipulator SetMask_MaskingTypes_Vector4_float_float
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TextMeshPro), "SetMask"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(TextMeshPro), "SetMask"), value);
    }

    public static event ILContext.Manipulator SetVerticesDirty
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TextMeshPro), "SetVerticesDirty"),
            value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(TextMeshPro), "SetVerticesDirty"),
            value);
    }

    public static event ILContext.Manipulator SetLayoutDirty
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TextMeshPro), "SetLayoutDirty"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(TextMeshPro), "SetLayoutDirty"),
            value);
    }

    public static event ILContext.Manipulator SetMaterialDirty
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TextMeshPro), "SetMaterialDirty"),
            value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(TextMeshPro), "SetMaterialDirty"),
            value);
    }

    public static event ILContext.Manipulator SetAllDirty
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TextMeshPro), "SetAllDirty"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(TextMeshPro), "SetAllDirty"),
            value);
    }

    public static event ILContext.Manipulator Rebuild
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TextMeshPro), "Rebuild"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(TextMeshPro), "Rebuild"), value);
    }

    public static event ILContext.Manipulator UpdateMaterial
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TextMeshPro), "UpdateMaterial"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(TextMeshPro), "UpdateMaterial"),
            value);
    }

    public static event ILContext.Manipulator UpdateMeshPadding
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TextMeshPro), "UpdateMeshPadding"),
            value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(TextMeshPro), "UpdateMeshPadding"),
            value);
    }

    public static event ILContext.Manipulator ForceMeshUpdate
    {
        add =>
            HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TextMeshPro), "ForceMeshUpdate"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(TextMeshPro), "ForceMeshUpdate"),
            value);
    }

    public static event ILContext.Manipulator ForceMeshUpdate_bool
    {
        add =>
            HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TextMeshPro), "ForceMeshUpdate"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(TextMeshPro), "ForceMeshUpdate"),
            value);
    }

    public static event ILContext.Manipulator GetTextInfo
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TextMeshPro), "GetTextInfo"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(TextMeshPro), "GetTextInfo"),
            value);
    }

    public static event ILContext.Manipulator UpdateGeometry
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TextMeshPro), "UpdateGeometry"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(TextMeshPro), "UpdateGeometry"),
            value);
    }

    public static event ILContext.Manipulator UpdateVertexData_TMP_VertexDataUpdateFlags
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TextMeshPro), "UpdateVertexData"),
            value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(TextMeshPro), "UpdateVertexData"),
            value);
    }

    public static event ILContext.Manipulator UpdateVertexData
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TextMeshPro), "UpdateVertexData"),
            value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(TextMeshPro), "UpdateVertexData"),
            value);
    }

    public static event ILContext.Manipulator UpdateFontAsset
    {
        add =>
            HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TextMeshPro), "UpdateFontAsset"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(TextMeshPro), "UpdateFontAsset"),
            value);
    }

    public static event ILContext.Manipulator CalculateLayoutInputHorizontal
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(TextMeshPro), "CalculateLayoutInputHorizontal"), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(TextMeshPro), "CalculateLayoutInputHorizontal"), value);
    }

    public static event ILContext.Manipulator CalculateLayoutInputVertical
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(TextMeshPro), "CalculateLayoutInputVertical"), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(TextMeshPro), "CalculateLayoutInputVertical"), value);
    }
}