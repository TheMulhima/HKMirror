using MonoMod.RuntimeDetour.HookGen;
using TMPro;

namespace HKMirror.Hooks.ILHooks;

/// <summary>
///     Contains all correct IL Hooks for MaterialReferenceManager.<br />
///     Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
///     Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILMaterialReferenceManager
{
    public static event ILContext.Manipulator get_instance
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(MaterialReferenceManager), "get_instance", false), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(MaterialReferenceManager), "get_instance", false), value);
    }

    public static event ILContext.Manipulator AddFontAsset
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(MaterialReferenceManager), "AddFontAsset", false), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(MaterialReferenceManager), "AddFontAsset", false), value);
    }

    public static event ILContext.Manipulator AddFontAssetInternal
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(MaterialReferenceManager), "AddFontAssetInternal"), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(MaterialReferenceManager), "AddFontAssetInternal"), value);
    }

    public static event ILContext.Manipulator AddSpriteAsset_TMP_SpriteAsset
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(MaterialReferenceManager), "AddSpriteAsset", false), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(MaterialReferenceManager), "AddSpriteAsset", false), value);
    }

    public static event ILContext.Manipulator AddSpriteAssetInternal_TMP_SpriteAsset
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(MaterialReferenceManager), "AddSpriteAssetInternal"), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(MaterialReferenceManager), "AddSpriteAssetInternal"), value);
    }

    public static event ILContext.Manipulator AddSpriteAsset_int_TMP_SpriteAsset
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(MaterialReferenceManager), "AddSpriteAsset", false), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(MaterialReferenceManager), "AddSpriteAsset", false), value);
    }

    public static event ILContext.Manipulator AddSpriteAssetInternal_int_TMP_SpriteAsset
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(MaterialReferenceManager), "AddSpriteAssetInternal"), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(MaterialReferenceManager), "AddSpriteAssetInternal"), value);
    }

    public static event ILContext.Manipulator AddFontMaterial
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(MaterialReferenceManager), "AddFontMaterial", false), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(MaterialReferenceManager), "AddFontMaterial", false), value);
    }

    public static event ILContext.Manipulator AddFontMaterialInternal
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(MaterialReferenceManager), "AddFontMaterialInternal"), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(MaterialReferenceManager), "AddFontMaterialInternal"), value);
    }

    public static event ILContext.Manipulator Contains_TMP_FontAsset
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(MaterialReferenceManager), "Contains"),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(MaterialReferenceManager), "Contains"), value);
    }

    public static event ILContext.Manipulator Contains_TMP_SpriteAsset
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(MaterialReferenceManager), "Contains"),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(MaterialReferenceManager), "Contains"), value);
    }

    public static event ILContext.Manipulator TryGetFontAsset
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(MaterialReferenceManager), "TryGetFontAsset", false), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(MaterialReferenceManager), "TryGetFontAsset", false), value);
    }

    public static event ILContext.Manipulator TryGetFontAssetInternal
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(MaterialReferenceManager), "TryGetFontAssetInternal"), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(MaterialReferenceManager), "TryGetFontAssetInternal"), value);
    }

    public static event ILContext.Manipulator TryGetSpriteAsset
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(MaterialReferenceManager), "TryGetSpriteAsset", false), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(MaterialReferenceManager), "TryGetSpriteAsset", false), value);
    }

    public static event ILContext.Manipulator TryGetSpriteAssetInternal
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(MaterialReferenceManager), "TryGetSpriteAssetInternal"), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(MaterialReferenceManager), "TryGetSpriteAssetInternal"), value);
    }

    public static event ILContext.Manipulator TryGetMaterial
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(MaterialReferenceManager), "TryGetMaterial", false), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(MaterialReferenceManager), "TryGetMaterial", false), value);
    }

    public static event ILContext.Manipulator TryGetMaterialInternal
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(MaterialReferenceManager), "TryGetMaterialInternal"), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(MaterialReferenceManager), "TryGetMaterialInternal"), value);
    }
}