using MonoMod.RuntimeDetour.HookGen;

namespace HKMirror.Hooks.ILHooks;

/// <summary>
///     Contains all correct IL Hooks for tk2dSpriteCollectionData.<br />
///     Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
///     Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILtk2dSpriteCollectionData
{
    public static event ILContext.Manipulator get_Transient
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(tk2dSpriteCollectionData), "get_Transient"), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(tk2dSpriteCollectionData), "get_Transient"), value);
    }

    public static event ILContext.Manipulator set_Transient
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(tk2dSpriteCollectionData), "set_Transient"), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(tk2dSpriteCollectionData), "set_Transient"), value);
    }

    public static event ILContext.Manipulator get_Count
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(tk2dSpriteCollectionData), "get_Count"),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(tk2dSpriteCollectionData), "get_Count"), value);
    }

    public static event ILContext.Manipulator GetSpriteIdByName_string
    {
        add => IL.tk2dSpriteCollectionData.GetSpriteIdByName_string += value;
        remove => IL.tk2dSpriteCollectionData.GetSpriteIdByName_string -= value;
    }

    public static event ILContext.Manipulator GetSpriteIdByName_string_int
    {
        add => IL.tk2dSpriteCollectionData.GetSpriteIdByName_string_int += value;
        remove => IL.tk2dSpriteCollectionData.GetSpriteIdByName_string_int -= value;
    }

    public static event ILContext.Manipulator ClearDictionary
    {
        add => IL.tk2dSpriteCollectionData.ClearDictionary += value;
        remove => IL.tk2dSpriteCollectionData.ClearDictionary -= value;
    }

    public static event ILContext.Manipulator GetSpriteDefinition
    {
        add => IL.tk2dSpriteCollectionData.GetSpriteDefinition += value;
        remove => IL.tk2dSpriteCollectionData.GetSpriteDefinition -= value;
    }

    public static event ILContext.Manipulator InitDictionary
    {
        add => IL.tk2dSpriteCollectionData.InitDictionary += value;
        remove => IL.tk2dSpriteCollectionData.InitDictionary -= value;
    }

    public static event ILContext.Manipulator get_FirstValidDefinition
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(tk2dSpriteCollectionData), "get_FirstValidDefinition"), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(tk2dSpriteCollectionData), "get_FirstValidDefinition"), value);
    }

    public static event ILContext.Manipulator IsValidSpriteId
    {
        add => IL.tk2dSpriteCollectionData.IsValidSpriteId += value;
        remove => IL.tk2dSpriteCollectionData.IsValidSpriteId -= value;
    }

    public static event ILContext.Manipulator get_FirstValidDefinitionIndex
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(tk2dSpriteCollectionData), "get_FirstValidDefinitionIndex"), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(tk2dSpriteCollectionData), "get_FirstValidDefinitionIndex"), value);
    }

    public static event ILContext.Manipulator InitMaterialIds
    {
        add => IL.tk2dSpriteCollectionData.InitMaterialIds += value;
        remove => IL.tk2dSpriteCollectionData.InitMaterialIds -= value;
    }

    public static event ILContext.Manipulator get_inst
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(tk2dSpriteCollectionData), "get_inst"),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(tk2dSpriteCollectionData), "get_inst"), value);
    }

    public static event ILContext.Manipulator Init
    {
        add => IL.tk2dSpriteCollectionData.Init += value;
        remove => IL.tk2dSpriteCollectionData.Init -= value;
    }

    public static event ILContext.Manipulator CreateFromTexture
    {
        add => IL.tk2dSpriteCollectionData.CreateFromTexture += value;
        remove => IL.tk2dSpriteCollectionData.CreateFromTexture -= value;
    }

    public static event ILContext.Manipulator CreateFromTexturePacker
    {
        add => IL.tk2dSpriteCollectionData.CreateFromTexturePacker += value;
        remove => IL.tk2dSpriteCollectionData.CreateFromTexturePacker -= value;
    }

    public static event ILContext.Manipulator ResetPlatformData
    {
        add => IL.tk2dSpriteCollectionData.ResetPlatformData += value;
        remove => IL.tk2dSpriteCollectionData.ResetPlatformData -= value;
    }

    public static event ILContext.Manipulator DestroyTextureInsts
    {
        add => IL.tk2dSpriteCollectionData.DestroyTextureInsts += value;
        remove => IL.tk2dSpriteCollectionData.DestroyTextureInsts -= value;
    }

    public static event ILContext.Manipulator UnloadTextures
    {
        add => IL.tk2dSpriteCollectionData.UnloadTextures += value;
        remove => IL.tk2dSpriteCollectionData.UnloadTextures -= value;
    }

    public static event ILContext.Manipulator DestroyMaterialInsts
    {
        add => IL.tk2dSpriteCollectionData.DestroyMaterialInsts += value;
        remove => IL.tk2dSpriteCollectionData.DestroyMaterialInsts -= value;
    }

    public static event ILContext.Manipulator OnDestroy
    {
        add => IL.tk2dSpriteCollectionData.OnDestroy += value;
        remove => IL.tk2dSpriteCollectionData.OnDestroy -= value;
    }
}