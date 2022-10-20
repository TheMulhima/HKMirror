using MonoMod.RuntimeDetour.HookGen;
using TMPro;

namespace HKMirror.Hooks.ILHooks;

/// <summary>
///     Contains all correct IL Hooks for TMP_SubMeshUI.<br />
///     Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
///     Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILTMP_SubMeshUI
{
    public static event ILContext.Manipulator get_fontAsset
    {
        add =>
            HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TMP_SubMeshUI), "get_fontAsset"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(TMP_SubMeshUI), "get_fontAsset"),
            value);
    }

    public static event ILContext.Manipulator set_fontAsset
    {
        add =>
            HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TMP_SubMeshUI), "set_fontAsset"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(TMP_SubMeshUI), "set_fontAsset"),
            value);
    }

    public static event ILContext.Manipulator get_spriteAsset
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TMP_SubMeshUI), "get_spriteAsset"),
            value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(TMP_SubMeshUI), "get_spriteAsset"),
            value);
    }

    public static event ILContext.Manipulator set_spriteAsset
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TMP_SubMeshUI), "set_spriteAsset"),
            value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(TMP_SubMeshUI), "set_spriteAsset"),
            value);
    }

    public static event ILContext.Manipulator get_mainTexture
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TMP_SubMeshUI), "get_mainTexture"),
            value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(TMP_SubMeshUI), "get_mainTexture"),
            value);
    }

    public static event ILContext.Manipulator get_material
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TMP_SubMeshUI), "get_material"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(TMP_SubMeshUI), "get_material"),
            value);
    }

    public static event ILContext.Manipulator set_material
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TMP_SubMeshUI), "set_material"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(TMP_SubMeshUI), "set_material"),
            value);
    }

    public static event ILContext.Manipulator get_sharedMaterial
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TMP_SubMeshUI), "get_sharedMaterial"),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(TMP_SubMeshUI), "get_sharedMaterial"), value);
    }

    public static event ILContext.Manipulator set_sharedMaterial
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TMP_SubMeshUI), "set_sharedMaterial"),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(TMP_SubMeshUI), "set_sharedMaterial"), value);
    }

    public static event ILContext.Manipulator get_fallbackMaterial
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TMP_SubMeshUI), "get_fallbackMaterial"),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(TMP_SubMeshUI), "get_fallbackMaterial"), value);
    }

    public static event ILContext.Manipulator set_fallbackMaterial
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TMP_SubMeshUI), "set_fallbackMaterial"),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(TMP_SubMeshUI), "set_fallbackMaterial"), value);
    }

    public static event ILContext.Manipulator get_fallbackSourceMaterial
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(TMP_SubMeshUI), "get_fallbackSourceMaterial"), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(TMP_SubMeshUI), "get_fallbackSourceMaterial"), value);
    }

    public static event ILContext.Manipulator set_fallbackSourceMaterial
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(TMP_SubMeshUI), "set_fallbackSourceMaterial"), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(TMP_SubMeshUI), "set_fallbackSourceMaterial"), value);
    }

    public static event ILContext.Manipulator get_materialForRendering
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(TMP_SubMeshUI), "get_materialForRendering"), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(TMP_SubMeshUI), "get_materialForRendering"), value);
    }

    public static event ILContext.Manipulator get_isDefaultMaterial
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(TMP_SubMeshUI), "get_isDefaultMaterial"), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(TMP_SubMeshUI), "get_isDefaultMaterial"), value);
    }

    public static event ILContext.Manipulator set_isDefaultMaterial
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(TMP_SubMeshUI), "set_isDefaultMaterial"), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(TMP_SubMeshUI), "set_isDefaultMaterial"), value);
    }

    public static event ILContext.Manipulator get_padding
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TMP_SubMeshUI), "get_padding"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(TMP_SubMeshUI), "get_padding"),
            value);
    }

    public static event ILContext.Manipulator set_padding
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TMP_SubMeshUI), "set_padding"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(TMP_SubMeshUI), "set_padding"),
            value);
    }

    public static event ILContext.Manipulator get_canvasRenderer
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TMP_SubMeshUI), "get_canvasRenderer"),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(TMP_SubMeshUI), "get_canvasRenderer"), value);
    }

    public static event ILContext.Manipulator get_mesh
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TMP_SubMeshUI), "get_mesh"), value);
        remove =>
            HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(TMP_SubMeshUI), "get_mesh"), value);
    }

    public static event ILContext.Manipulator set_mesh
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TMP_SubMeshUI), "set_mesh"), value);
        remove =>
            HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(TMP_SubMeshUI), "set_mesh"), value);
    }

    public static event ILContext.Manipulator AddSubTextObject
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(TMP_SubMeshUI), "AddSubTextObject", false), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(TMP_SubMeshUI), "AddSubTextObject", false), value);
    }

    public static event ILContext.Manipulator OnEnable
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TMP_SubMeshUI), "OnEnable"), value);
        remove =>
            HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(TMP_SubMeshUI), "OnEnable"), value);
    }

    public static event ILContext.Manipulator OnDisable
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TMP_SubMeshUI), "OnDisable"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(TMP_SubMeshUI), "OnDisable"),
            value);
    }

    public static event ILContext.Manipulator OnDestroy
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TMP_SubMeshUI), "OnDestroy"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(TMP_SubMeshUI), "OnDestroy"),
            value);
    }

    public static event ILContext.Manipulator OnTransformParentChanged
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(TMP_SubMeshUI), "OnTransformParentChanged"), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(TMP_SubMeshUI), "OnTransformParentChanged"), value);
    }

    public static event ILContext.Manipulator GetModifiedMaterial
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TMP_SubMeshUI), "GetModifiedMaterial"),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(TMP_SubMeshUI), "GetModifiedMaterial"), value);
    }

    public static event ILContext.Manipulator GetPaddingForMaterial
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(TMP_SubMeshUI), "GetPaddingForMaterial"), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(TMP_SubMeshUI), "GetPaddingForMaterial"), value);
    }

    public static event ILContext.Manipulator GetPaddingForMaterial_Material
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(TMP_SubMeshUI), "GetPaddingForMaterial"), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(TMP_SubMeshUI), "GetPaddingForMaterial"), value);
    }

    public static event ILContext.Manipulator UpdateMeshPadding
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TMP_SubMeshUI), "UpdateMeshPadding"),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(TMP_SubMeshUI), "UpdateMeshPadding"), value);
    }

    public static event ILContext.Manipulator SetAllDirty
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TMP_SubMeshUI), "SetAllDirty"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(TMP_SubMeshUI), "SetAllDirty"),
            value);
    }

    public static event ILContext.Manipulator SetVerticesDirty
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TMP_SubMeshUI), "SetVerticesDirty"),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(TMP_SubMeshUI), "SetVerticesDirty"), value);
    }

    public static event ILContext.Manipulator SetLayoutDirty
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TMP_SubMeshUI), "SetLayoutDirty"),
            value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(TMP_SubMeshUI), "SetLayoutDirty"),
            value);
    }

    public static event ILContext.Manipulator SetMaterialDirty
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TMP_SubMeshUI), "SetMaterialDirty"),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(TMP_SubMeshUI), "SetMaterialDirty"), value);
    }

    public static event ILContext.Manipulator SetPivotDirty
    {
        add =>
            HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TMP_SubMeshUI), "SetPivotDirty"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(TMP_SubMeshUI), "SetPivotDirty"),
            value);
    }

    public static event ILContext.Manipulator UpdateGeometry
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TMP_SubMeshUI), "UpdateGeometry"),
            value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(TMP_SubMeshUI), "UpdateGeometry"),
            value);
    }

    public static event ILContext.Manipulator Rebuild
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TMP_SubMeshUI), "Rebuild"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(TMP_SubMeshUI), "Rebuild"), value);
    }

    public static event ILContext.Manipulator RefreshMaterial
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TMP_SubMeshUI), "RefreshMaterial"),
            value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(TMP_SubMeshUI), "RefreshMaterial"),
            value);
    }

    public static event ILContext.Manipulator UpdateMaterial
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TMP_SubMeshUI), "UpdateMaterial"),
            value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(TMP_SubMeshUI), "UpdateMaterial"),
            value);
    }

    public static event ILContext.Manipulator RecalculateClipping
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TMP_SubMeshUI), "RecalculateClipping"),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(TMP_SubMeshUI), "RecalculateClipping"), value);
    }

    public static event ILContext.Manipulator RecalculateMasking
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TMP_SubMeshUI), "RecalculateMasking"),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(TMP_SubMeshUI), "RecalculateMasking"), value);
    }

    public static event ILContext.Manipulator GetMaterial
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TMP_SubMeshUI), "GetMaterial"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(TMP_SubMeshUI), "GetMaterial"),
            value);
    }

    public static event ILContext.Manipulator GetMaterial_Material
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TMP_SubMeshUI), "GetMaterial"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(TMP_SubMeshUI), "GetMaterial"),
            value);
    }

    public static event ILContext.Manipulator CreateMaterialInstance
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(TMP_SubMeshUI), "CreateMaterialInstance"), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(TMP_SubMeshUI), "CreateMaterialInstance"), value);
    }

    public static event ILContext.Manipulator GetSharedMaterial
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TMP_SubMeshUI), "GetSharedMaterial"),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(TMP_SubMeshUI), "GetSharedMaterial"), value);
    }

    public static event ILContext.Manipulator SetSharedMaterial
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TMP_SubMeshUI), "SetSharedMaterial"),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(TMP_SubMeshUI), "SetSharedMaterial"), value);
    }

    public static event ILContext.Manipulator GetInstanceID
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(TMP_SubMeshUI), "TMPro.ITextElement.GetInstanceID"), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(TMP_SubMeshUI), "TMPro.ITextElement.GetInstanceID"), value);
    }
}