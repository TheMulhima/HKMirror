using MonoMod.RuntimeDetour.HookGen;
using TMPro;

namespace HKMirror.Hooks.ILHooks;

/// <summary>
///     Contains all correct IL Hooks for TMP_SubMesh.<br />
///     Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
///     Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILTMP_SubMesh
{
    public static event ILContext.Manipulator get_fontAsset
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TMP_SubMesh), "get_fontAsset"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(TMP_SubMesh), "get_fontAsset"),
            value);
    }

    public static event ILContext.Manipulator set_fontAsset
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TMP_SubMesh), "set_fontAsset"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(TMP_SubMesh), "set_fontAsset"),
            value);
    }

    public static event ILContext.Manipulator get_spriteAsset
    {
        add =>
            HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TMP_SubMesh), "get_spriteAsset"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(TMP_SubMesh), "get_spriteAsset"),
            value);
    }

    public static event ILContext.Manipulator set_spriteAsset
    {
        add =>
            HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TMP_SubMesh), "set_spriteAsset"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(TMP_SubMesh), "set_spriteAsset"),
            value);
    }

    public static event ILContext.Manipulator get_material
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TMP_SubMesh), "get_material"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(TMP_SubMesh), "get_material"),
            value);
    }

    public static event ILContext.Manipulator set_material
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TMP_SubMesh), "set_material"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(TMP_SubMesh), "set_material"),
            value);
    }

    public static event ILContext.Manipulator get_sharedMaterial
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TMP_SubMesh), "get_sharedMaterial"),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(TMP_SubMesh), "get_sharedMaterial"), value);
    }

    public static event ILContext.Manipulator set_sharedMaterial
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TMP_SubMesh), "set_sharedMaterial"),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(TMP_SubMesh), "set_sharedMaterial"), value);
    }

    public static event ILContext.Manipulator get_fallbackMaterial
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TMP_SubMesh), "get_fallbackMaterial"),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(TMP_SubMesh), "get_fallbackMaterial"), value);
    }

    public static event ILContext.Manipulator set_fallbackMaterial
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TMP_SubMesh), "set_fallbackMaterial"),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(TMP_SubMesh), "set_fallbackMaterial"), value);
    }

    public static event ILContext.Manipulator get_fallbackSourceMaterial
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(TMP_SubMesh), "get_fallbackSourceMaterial"), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(TMP_SubMesh), "get_fallbackSourceMaterial"), value);
    }

    public static event ILContext.Manipulator set_fallbackSourceMaterial
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(TMP_SubMesh), "set_fallbackSourceMaterial"), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(TMP_SubMesh), "set_fallbackSourceMaterial"), value);
    }

    public static event ILContext.Manipulator get_isDefaultMaterial
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TMP_SubMesh), "get_isDefaultMaterial"),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(TMP_SubMesh), "get_isDefaultMaterial"), value);
    }

    public static event ILContext.Manipulator set_isDefaultMaterial
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TMP_SubMesh), "set_isDefaultMaterial"),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(TMP_SubMesh), "set_isDefaultMaterial"), value);
    }

    public static event ILContext.Manipulator get_padding
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TMP_SubMesh), "get_padding"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(TMP_SubMesh), "get_padding"),
            value);
    }

    public static event ILContext.Manipulator set_padding
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TMP_SubMesh), "set_padding"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(TMP_SubMesh), "set_padding"),
            value);
    }

    public static event ILContext.Manipulator get_renderer
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TMP_SubMesh), "get_renderer"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(TMP_SubMesh), "get_renderer"),
            value);
    }

    public static event ILContext.Manipulator get_meshFilter
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TMP_SubMesh), "get_meshFilter"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(TMP_SubMesh), "get_meshFilter"),
            value);
    }

    public static event ILContext.Manipulator get_mesh
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TMP_SubMesh), "get_mesh"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(TMP_SubMesh), "get_mesh"), value);
    }

    public static event ILContext.Manipulator set_mesh
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TMP_SubMesh), "set_mesh"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(TMP_SubMesh), "set_mesh"), value);
    }

    public static event ILContext.Manipulator OnEnable
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TMP_SubMesh), "OnEnable"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(TMP_SubMesh), "OnEnable"), value);
    }

    public static event ILContext.Manipulator OnDisable
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TMP_SubMesh), "OnDisable"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(TMP_SubMesh), "OnDisable"), value);
    }

    public static event ILContext.Manipulator OnDestroy
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TMP_SubMesh), "OnDestroy"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(TMP_SubMesh), "OnDestroy"), value);
    }

    public static event ILContext.Manipulator AddSubTextObject
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(TMP_SubMesh), "AddSubTextObject", false), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(TMP_SubMesh), "AddSubTextObject", false), value);
    }

    public static event ILContext.Manipulator DestroySelf
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TMP_SubMesh), "DestroySelf"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(TMP_SubMesh), "DestroySelf"),
            value);
    }

    public static event ILContext.Manipulator GetMaterial
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TMP_SubMesh), "GetMaterial"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(TMP_SubMesh), "GetMaterial"),
            value);
    }

    public static event ILContext.Manipulator CreateMaterialInstance
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TMP_SubMesh), "CreateMaterialInstance"),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(TMP_SubMesh), "CreateMaterialInstance"), value);
    }

    public static event ILContext.Manipulator GetSharedMaterial
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TMP_SubMesh), "GetSharedMaterial"),
            value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(TMP_SubMesh), "GetSharedMaterial"),
            value);
    }

    public static event ILContext.Manipulator SetSharedMaterial
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TMP_SubMesh), "SetSharedMaterial"),
            value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(TMP_SubMesh), "SetSharedMaterial"),
            value);
    }

    public static event ILContext.Manipulator GetPaddingForMaterial
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TMP_SubMesh), "GetPaddingForMaterial"),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(TMP_SubMesh), "GetPaddingForMaterial"), value);
    }

    public static event ILContext.Manipulator UpdateMeshPadding
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TMP_SubMesh), "UpdateMeshPadding"),
            value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(TMP_SubMesh), "UpdateMeshPadding"),
            value);
    }

    public static event ILContext.Manipulator SetVerticesDirty
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TMP_SubMesh), "SetVerticesDirty"),
            value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(TMP_SubMesh), "SetVerticesDirty"),
            value);
    }

    public static event ILContext.Manipulator SetMaterialDirty
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TMP_SubMesh), "SetMaterialDirty"),
            value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(TMP_SubMesh), "SetMaterialDirty"),
            value);
    }

    public static event ILContext.Manipulator UpdateMaterial
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TMP_SubMesh), "UpdateMaterial"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(TMP_SubMesh), "UpdateMaterial"),
            value);
    }
}