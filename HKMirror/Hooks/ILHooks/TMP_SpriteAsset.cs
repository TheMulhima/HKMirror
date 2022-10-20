using MonoMod.RuntimeDetour.HookGen;
using TMPro;

namespace HKMirror.Hooks.ILHooks;

/// <summary>
///     Contains all correct IL Hooks for TMP_SpriteAsset.<br />
///     Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
///     Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILTMP_SpriteAsset
{
    public static event ILContext.Manipulator get_defaultSpriteAsset
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(TMP_SpriteAsset), "get_defaultSpriteAsset", false), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(TMP_SpriteAsset), "get_defaultSpriteAsset", false), value);
    }

    public static event ILContext.Manipulator OnEnable
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TMP_SpriteAsset), "OnEnable"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(TMP_SpriteAsset), "OnEnable"),
            value);
    }

    public static event ILContext.Manipulator GetDefaultSpriteMaterial
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(TMP_SpriteAsset), "GetDefaultSpriteMaterial"), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(TMP_SpriteAsset), "GetDefaultSpriteMaterial"), value);
    }

    public static event ILContext.Manipulator GetSpriteIndex
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TMP_SpriteAsset), "GetSpriteIndex"),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(TMP_SpriteAsset), "GetSpriteIndex"), value);
    }
}