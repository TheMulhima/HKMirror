using MonoMod.RuntimeDetour.HookGen;
using TMPro;

namespace HKMirror.Hooks.ILHooks;

/// <summary>
///     Contains all correct IL Hooks for TextMeshProUGUI.<br />
///     Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
///     Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILTextMeshProUGUI
{
    public static event ILContext.Manipulator Awake
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TextMeshProUGUI), "Awake"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(TextMeshProUGUI), "Awake"), value);
    }

    public static event ILContext.Manipulator OnEnable
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TextMeshProUGUI), "OnEnable"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(TextMeshProUGUI), "OnEnable"),
            value);
    }

    public static event ILContext.Manipulator OnDisable
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TextMeshProUGUI), "OnDisable"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(TextMeshProUGUI), "OnDisable"),
            value);
    }

    public static event ILContext.Manipulator OnDestroy
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TextMeshProUGUI), "OnDestroy"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(TextMeshProUGUI), "OnDestroy"),
            value);
    }

    public static event ILContext.Manipulator LoadFontAsset
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TextMeshProUGUI), "LoadFontAsset"),
            value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(TextMeshProUGUI), "LoadFontAsset"),
            value);
    }

    public static event ILContext.Manipulator GetCanvas
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TextMeshProUGUI), "GetCanvas"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(TextMeshProUGUI), "GetCanvas"),
            value);
    }

    public static event ILContext.Manipulator UpdateEnvMapMatrix
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TextMeshProUGUI), "UpdateEnvMapMatrix"),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(TextMeshProUGUI), "UpdateEnvMapMatrix"), value);
    }

    public static event ILContext.Manipulator EnableMasking
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TextMeshProUGUI), "EnableMasking"),
            value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(TextMeshProUGUI), "EnableMasking"),
            value);
    }

    public static event ILContext.Manipulator DisableMasking
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TextMeshProUGUI), "DisableMasking"),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(TextMeshProUGUI), "DisableMasking"), value);
    }

    public static event ILContext.Manipulator UpdateMask
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TextMeshProUGUI), "UpdateMask"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(TextMeshProUGUI), "UpdateMask"),
            value);
    }

    public static event ILContext.Manipulator GetMaterial
    {
        add =>
            HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TextMeshProUGUI), "GetMaterial"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(TextMeshProUGUI), "GetMaterial"),
            value);
    }

    public static event ILContext.Manipulator GetMaterials
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TextMeshProUGUI), "GetMaterials"),
            value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(TextMeshProUGUI), "GetMaterials"),
            value);
    }

    public static event ILContext.Manipulator SetSharedMaterial
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TextMeshProUGUI), "SetSharedMaterial"),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(TextMeshProUGUI), "SetSharedMaterial"), value);
    }

    public static event ILContext.Manipulator GetSharedMaterials
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TextMeshProUGUI), "GetSharedMaterials"),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(TextMeshProUGUI), "GetSharedMaterials"), value);
    }

    public static event ILContext.Manipulator SetSharedMaterials
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TextMeshProUGUI), "SetSharedMaterials"),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(TextMeshProUGUI), "SetSharedMaterials"), value);
    }

    public static event ILContext.Manipulator SetOutlineThickness
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(TextMeshProUGUI), "SetOutlineThickness"), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(TextMeshProUGUI), "SetOutlineThickness"), value);
    }

    public static event ILContext.Manipulator SetFaceColor
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TextMeshProUGUI), "SetFaceColor"),
            value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(TextMeshProUGUI), "SetFaceColor"),
            value);
    }

    public static event ILContext.Manipulator SetOutlineColor
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TextMeshProUGUI), "SetOutlineColor"),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(TextMeshProUGUI), "SetOutlineColor"), value);
    }

    public static event ILContext.Manipulator SetShaderDepth
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TextMeshProUGUI), "SetShaderDepth"),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(TextMeshProUGUI), "SetShaderDepth"), value);
    }

    public static event ILContext.Manipulator SetCulling
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TextMeshProUGUI), "SetCulling"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(TextMeshProUGUI), "SetCulling"),
            value);
    }

    public static event ILContext.Manipulator SetPerspectiveCorrection
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(TextMeshProUGUI), "SetPerspectiveCorrection"), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(TextMeshProUGUI), "SetPerspectiveCorrection"), value);
    }

    public static event ILContext.Manipulator GetPaddingForMaterial_Material
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(TextMeshProUGUI), "GetPaddingForMaterial"), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(TextMeshProUGUI), "GetPaddingForMaterial"), value);
    }

    public static event ILContext.Manipulator GetPaddingForMaterial
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(TextMeshProUGUI), "GetPaddingForMaterial"), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(TextMeshProUGUI), "GetPaddingForMaterial"), value);
    }

    public static event ILContext.Manipulator SetMeshArrays
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TextMeshProUGUI), "SetMeshArrays"),
            value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(TextMeshProUGUI), "SetMeshArrays"),
            value);
    }

    public static event ILContext.Manipulator SetArraySizes
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TextMeshProUGUI), "SetArraySizes"),
            value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(TextMeshProUGUI), "SetArraySizes"),
            value);
    }

    public static event ILContext.Manipulator ComputeMarginSize
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TextMeshProUGUI), "ComputeMarginSize"),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(TextMeshProUGUI), "ComputeMarginSize"), value);
    }

    public static event ILContext.Manipulator OnDidApplyAnimationProperties
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(TextMeshProUGUI), "OnDidApplyAnimationProperties"), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(TextMeshProUGUI), "OnDidApplyAnimationProperties"), value);
    }

    public static event ILContext.Manipulator OnCanvasHierarchyChanged
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(TextMeshProUGUI), "OnCanvasHierarchyChanged"), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(TextMeshProUGUI), "OnCanvasHierarchyChanged"), value);
    }

    public static event ILContext.Manipulator OnTransformParentChanged
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(TextMeshProUGUI), "OnTransformParentChanged"), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(TextMeshProUGUI), "OnTransformParentChanged"), value);
    }

    public static event ILContext.Manipulator OnRectTransformDimensionsChange
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(TextMeshProUGUI), "OnRectTransformDimensionsChange"), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(TextMeshProUGUI), "OnRectTransformDimensionsChange"), value);
    }

    public static event ILContext.Manipulator LateUpdate
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TextMeshProUGUI), "LateUpdate"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(TextMeshProUGUI), "LateUpdate"),
            value);
    }

    public static event ILContext.Manipulator OnPreRenderCanvas
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TextMeshProUGUI), "OnPreRenderCanvas"),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(TextMeshProUGUI), "OnPreRenderCanvas"), value);
    }

    public static event ILContext.Manipulator GenerateTextMesh
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TextMeshProUGUI), "GenerateTextMesh"),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(TextMeshProUGUI), "GenerateTextMesh"), value);
    }

    public static event ILContext.Manipulator GetTextContainerLocalCorners
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(TextMeshProUGUI), "GetTextContainerLocalCorners"), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(TextMeshProUGUI), "GetTextContainerLocalCorners"), value);
    }

    public static event ILContext.Manipulator ClearMesh
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TextMeshProUGUI), "ClearMesh"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(TextMeshProUGUI), "ClearMesh"),
            value);
    }

    public static event ILContext.Manipulator SetActiveSubMeshes
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TextMeshProUGUI), "SetActiveSubMeshes"),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(TextMeshProUGUI), "SetActiveSubMeshes"), value);
    }

    public static event ILContext.Manipulator GetCompoundBounds
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TextMeshProUGUI), "GetCompoundBounds"),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(TextMeshProUGUI), "GetCompoundBounds"), value);
    }

    public static event ILContext.Manipulator UpdateSDFScale
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TextMeshProUGUI), "UpdateSDFScale"),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(TextMeshProUGUI), "UpdateSDFScale"), value);
    }

    public static event ILContext.Manipulator AdjustLineOffset
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TextMeshProUGUI), "AdjustLineOffset"),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(TextMeshProUGUI), "AdjustLineOffset"), value);
    }

    public static event ILContext.Manipulator get_materialForRendering
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(TextMeshProUGUI), "get_materialForRendering"), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(TextMeshProUGUI), "get_materialForRendering"), value);
    }

    public static event ILContext.Manipulator get_mesh
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TextMeshProUGUI), "get_mesh"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(TextMeshProUGUI), "get_mesh"),
            value);
    }

    public static event ILContext.Manipulator get_canvasRenderer
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TextMeshProUGUI), "get_canvasRenderer"),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(TextMeshProUGUI), "get_canvasRenderer"), value);
    }

    public static event ILContext.Manipulator get_inlineGraphicManager
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(TextMeshProUGUI), "get_inlineGraphicManager"), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(TextMeshProUGUI), "get_inlineGraphicManager"), value);
    }

    public static event ILContext.Manipulator CalculateLayoutInputHorizontal
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(TextMeshProUGUI), "CalculateLayoutInputHorizontal"), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(TextMeshProUGUI), "CalculateLayoutInputHorizontal"), value);
    }

    public static event ILContext.Manipulator CalculateLayoutInputVertical
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(TextMeshProUGUI), "CalculateLayoutInputVertical"), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(TextMeshProUGUI), "CalculateLayoutInputVertical"), value);
    }

    public static event ILContext.Manipulator SetVerticesDirty
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TextMeshProUGUI), "SetVerticesDirty"),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(TextMeshProUGUI), "SetVerticesDirty"), value);
    }

    public static event ILContext.Manipulator SetLayoutDirty
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TextMeshProUGUI), "SetLayoutDirty"),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(TextMeshProUGUI), "SetLayoutDirty"), value);
    }

    public static event ILContext.Manipulator SetMaterialDirty
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TextMeshProUGUI), "SetMaterialDirty"),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(TextMeshProUGUI), "SetMaterialDirty"), value);
    }

    public static event ILContext.Manipulator SetAllDirty
    {
        add =>
            HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TextMeshProUGUI), "SetAllDirty"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(TextMeshProUGUI), "SetAllDirty"),
            value);
    }

    public static event ILContext.Manipulator Rebuild
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TextMeshProUGUI), "Rebuild"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(TextMeshProUGUI), "Rebuild"),
            value);
    }

    public static event ILContext.Manipulator UpdateSubObjectPivot
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(TextMeshProUGUI), "UpdateSubObjectPivot"), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(TextMeshProUGUI), "UpdateSubObjectPivot"), value);
    }

    public static event ILContext.Manipulator GetModifiedMaterial
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(TextMeshProUGUI), "GetModifiedMaterial"), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(TextMeshProUGUI), "GetModifiedMaterial"), value);
    }

    public static event ILContext.Manipulator UpdateMaterial
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TextMeshProUGUI), "UpdateMaterial"),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(TextMeshProUGUI), "UpdateMaterial"), value);
    }

    public static event ILContext.Manipulator get_maskOffset
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TextMeshProUGUI), "get_maskOffset"),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(TextMeshProUGUI), "get_maskOffset"), value);
    }

    public static event ILContext.Manipulator set_maskOffset
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TextMeshProUGUI), "set_maskOffset"),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(TextMeshProUGUI), "set_maskOffset"), value);
    }

    public static event ILContext.Manipulator RecalculateClipping
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(TextMeshProUGUI), "RecalculateClipping"), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(TextMeshProUGUI), "RecalculateClipping"), value);
    }

    public static event ILContext.Manipulator RecalculateMasking
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TextMeshProUGUI), "RecalculateMasking"),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(TextMeshProUGUI), "RecalculateMasking"), value);
    }

    public static event ILContext.Manipulator UpdateMeshPadding
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TextMeshProUGUI), "UpdateMeshPadding"),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(TextMeshProUGUI), "UpdateMeshPadding"), value);
    }

    public static event ILContext.Manipulator InternalCrossFadeColor
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(TextMeshProUGUI), "InternalCrossFadeColor"), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(TextMeshProUGUI), "InternalCrossFadeColor"), value);
    }

    public static event ILContext.Manipulator InternalCrossFadeAlpha
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(TextMeshProUGUI), "InternalCrossFadeAlpha"), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(TextMeshProUGUI), "InternalCrossFadeAlpha"), value);
    }

    public static event ILContext.Manipulator ForceMeshUpdate
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TextMeshProUGUI), "ForceMeshUpdate"),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(TextMeshProUGUI), "ForceMeshUpdate"), value);
    }

    public static event ILContext.Manipulator ForceMeshUpdate_bool
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TextMeshProUGUI), "ForceMeshUpdate"),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(TextMeshProUGUI), "ForceMeshUpdate"), value);
    }

    public static event ILContext.Manipulator GetTextInfo
    {
        add =>
            HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TextMeshProUGUI), "GetTextInfo"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(TextMeshProUGUI), "GetTextInfo"),
            value);
    }

    public static event ILContext.Manipulator UpdateGeometry
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TextMeshProUGUI), "UpdateGeometry"),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(TextMeshProUGUI), "UpdateGeometry"), value);
    }

    public static event ILContext.Manipulator UpdateVertexData_TMP_VertexDataUpdateFlags
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TextMeshProUGUI), "UpdateVertexData"),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(TextMeshProUGUI), "UpdateVertexData"), value);
    }

    public static event ILContext.Manipulator UpdateVertexData
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TextMeshProUGUI), "UpdateVertexData"),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(TextMeshProUGUI), "UpdateVertexData"), value);
    }

    public static event ILContext.Manipulator UpdateFontAsset
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TextMeshProUGUI), "UpdateFontAsset"),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(TextMeshProUGUI), "UpdateFontAsset"), value);
    }
}