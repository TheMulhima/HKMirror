using MonoMod.RuntimeDetour.HookGen;

namespace HKMirror.Hooks.ILHooks;

/// <summary>
///     Contains all correct IL Hooks for tk2dSpriteFromTexture.<br />
///     Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
///     Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILtk2dSpriteFromTexture
{
    public static event ILContext.Manipulator get_Sprite
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(tk2dSpriteFromTexture), "get_Sprite"),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(tk2dSpriteFromTexture), "get_Sprite"), value);
    }

    public static event ILContext.Manipulator Awake
    {
        add => IL.tk2dSpriteFromTexture.Awake += value;
        remove => IL.tk2dSpriteFromTexture.Awake -= value;
    }

    public static event ILContext.Manipulator get_HasSpriteCollection
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(tk2dSpriteFromTexture), "get_HasSpriteCollection"), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(tk2dSpriteFromTexture), "get_HasSpriteCollection"), value);
    }

    public static event ILContext.Manipulator OnDestroy
    {
        add => IL.tk2dSpriteFromTexture.OnDestroy += value;
        remove => IL.tk2dSpriteFromTexture.OnDestroy -= value;
    }

    public static event ILContext.Manipulator Clear
    {
        add => IL.tk2dSpriteFromTexture.Clear += value;
        remove => IL.tk2dSpriteFromTexture.Clear -= value;
    }

    public static event ILContext.Manipulator ForceBuild
    {
        add => IL.tk2dSpriteFromTexture.ForceBuild += value;
        remove => IL.tk2dSpriteFromTexture.ForceBuild -= value;
    }

    public static event ILContext.Manipulator DestroyInternal
    {
        add => IL.tk2dSpriteFromTexture.DestroyInternal += value;
        remove => IL.tk2dSpriteFromTexture.DestroyInternal -= value;
    }
}