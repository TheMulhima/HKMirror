using MonoMod.RuntimeDetour.HookGen;
using TMPro;

namespace HKMirror.Hooks.ILHooks;

/// <summary>
///     Contains all correct IL Hooks for TMP_MaterialManager,
///     Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
///     Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILTMP_MaterialManager
{
    public static event ILContext.Manipulator GetStencilMaterial
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(TMP_MaterialManager), "GetStencilMaterial", false), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(TMP_MaterialManager), "GetStencilMaterial", false), value);
    }

    public static event ILContext.Manipulator ReleaseStencilMaterial
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(TMP_MaterialManager), "ReleaseStencilMaterial", false), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(TMP_MaterialManager), "ReleaseStencilMaterial", false), value);
    }

    public static event ILContext.Manipulator GetBaseMaterial
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(TMP_MaterialManager), "GetBaseMaterial", false), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(TMP_MaterialManager), "GetBaseMaterial", false), value);
    }

    public static event ILContext.Manipulator SetStencil
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(TMP_MaterialManager), "SetStencil", false), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(TMP_MaterialManager), "SetStencil", false), value);
    }

    public static event ILContext.Manipulator AddMaskingMaterial
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(TMP_MaterialManager), "AddMaskingMaterial", false), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(TMP_MaterialManager), "AddMaskingMaterial", false), value);
    }

    public static event ILContext.Manipulator RemoveStencilMaterial
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(TMP_MaterialManager), "RemoveStencilMaterial", false), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(TMP_MaterialManager), "RemoveStencilMaterial", false), value);
    }

    public static event ILContext.Manipulator ReleaseBaseMaterial
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(TMP_MaterialManager), "ReleaseBaseMaterial", false), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(TMP_MaterialManager), "ReleaseBaseMaterial", false), value);
    }

    public static event ILContext.Manipulator ClearMaterials
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(TMP_MaterialManager), "ClearMaterials", false), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(TMP_MaterialManager), "ClearMaterials", false), value);
    }

    public static event ILContext.Manipulator GetStencilID
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(TMP_MaterialManager), "GetStencilID", false), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(TMP_MaterialManager), "GetStencilID", false), value);
    }

    public static event ILContext.Manipulator GetFallbackMaterial
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(TMP_MaterialManager), "GetFallbackMaterial", false), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(TMP_MaterialManager), "GetFallbackMaterial", false), value);
    }

    public static event ILContext.Manipulator AddFallbackMaterialReference
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(TMP_MaterialManager), "AddFallbackMaterialReference", false), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(TMP_MaterialManager), "AddFallbackMaterialReference", false), value);
    }

    public static event ILContext.Manipulator RemoveFallbackMaterialReference
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(TMP_MaterialManager), "RemoveFallbackMaterialReference", false),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(TMP_MaterialManager), "RemoveFallbackMaterialReference", false),
            value);
    }

    public static event ILContext.Manipulator CleanupFallbackMaterials
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(TMP_MaterialManager), "CleanupFallbackMaterials", false), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(TMP_MaterialManager), "CleanupFallbackMaterials", false), value);
    }

    public static event ILContext.Manipulator ReleaseFallbackMaterial
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(TMP_MaterialManager), "ReleaseFallbackMaterial", false), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(TMP_MaterialManager), "ReleaseFallbackMaterial", false), value);
    }

    public static event ILContext.Manipulator CopyMaterialPresetProperties
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(TMP_MaterialManager), "CopyMaterialPresetProperties", false), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(TMP_MaterialManager), "CopyMaterialPresetProperties", false), value);
    }
}