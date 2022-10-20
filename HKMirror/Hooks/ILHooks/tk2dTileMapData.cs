using MonoMod.RuntimeDetour.HookGen;

namespace HKMirror.Hooks.ILHooks;

/// <summary>
///     Contains all correct IL Hooks for tk2dTileMapData.<br />
///     Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
///     Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILtk2dTileMapData
{
    public static event ILContext.Manipulator get_NumLayers
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(tk2dTileMapData), "get_NumLayers"),
            value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(tk2dTileMapData), "get_NumLayers"),
            value);
    }

    public static event ILContext.Manipulator get_Layers
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(tk2dTileMapData), "get_Layers"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(tk2dTileMapData), "get_Layers"),
            value);
    }

    public static event ILContext.Manipulator GetTileInfoForSprite
    {
        add => IL.tk2dTileMapData.GetTileInfoForSprite += value;
        remove => IL.tk2dTileMapData.GetTileInfoForSprite -= value;
    }

    public static event ILContext.Manipulator GetOrCreateTileInfo
    {
        add => IL.tk2dTileMapData.GetOrCreateTileInfo += value;
        remove => IL.tk2dTileMapData.GetOrCreateTileInfo -= value;
    }

    public static event ILContext.Manipulator GetTileOffset
    {
        add => IL.tk2dTileMapData.GetTileOffset += value;
        remove => IL.tk2dTileMapData.GetTileOffset -= value;
    }

    public static event ILContext.Manipulator InitLayers
    {
        add => IL.tk2dTileMapData.InitLayers += value;
        remove => IL.tk2dTileMapData.InitLayers -= value;
    }
}