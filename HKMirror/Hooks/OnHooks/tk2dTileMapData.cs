using MonoMod.RuntimeDetour;
using MonoMod.RuntimeDetour.HookGen;
using tk2dRuntime.TileMap;

namespace HKMirror.Hooks.OnHooks;

/// <summary>
///     Contains different types of On Hooks for tk2dTileMapData class.<br />
///     Contains hooks that aren't generated by monomod, and before and after orig hooks for easier hooking.
/// </summary>
public static class Ontk2dTileMapData
{
    internal static class HookHandler
    {
        private static readonly List<string> HookedList = new();

        internal static void Hookget_NumLayers()
        {
            if (!HookedList.Contains("get_NumLayers"))
            {
                HookedList.Add("get_NumLayers");
                new Hook(ReflectionHelper.GetMethodInfo(typeof(tk2dTileMapData), "get_NumLayers"), get_NumLayers);
            }
        }

        internal static event Delegates.get_NumLayers_BeforeArgs _beforeget_NumLayers;
        internal static event Delegates.get_NumLayers_AfterArgs _afterget_NumLayers;

        private static int get_NumLayers(Func<tk2dTileMapData, int> orig, tk2dTileMapData self)
        {
            Delegates.Params_get_NumLayers @params = new()
            {
                self = self
            };
            if (_beforeget_NumLayers != null)
                foreach (Delegates.get_NumLayers_BeforeArgs toInvoke in _beforeget_NumLayers.GetInvocationList())
                    try
                    {
                        _beforeget_NumLayers?.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }

            self = @params.self;
            var retVal = orig(self);
            if (_afterget_NumLayers != null)
                foreach (Delegates.get_NumLayers_AfterArgs toInvoke in _afterget_NumLayers.GetInvocationList())
                    try
                    {
                        retVal = _afterget_NumLayers.Invoke(@params, retVal);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }

            return retVal;
        }

        internal static void Hookget_Layers()
        {
            if (!HookedList.Contains("get_Layers"))
            {
                HookedList.Add("get_Layers");
                new Hook(ReflectionHelper.GetMethodInfo(typeof(tk2dTileMapData), "get_Layers"), get_Layers);
            }
        }

        internal static event Delegates.get_Layers_BeforeArgs _beforeget_Layers;
        internal static event Delegates.get_Layers_AfterArgs _afterget_Layers;

        private static LayerInfo[] get_Layers(Func<tk2dTileMapData, LayerInfo[]> orig, tk2dTileMapData self)
        {
            Delegates.Params_get_Layers @params = new()
            {
                self = self
            };
            if (_beforeget_Layers != null)
                foreach (Delegates.get_Layers_BeforeArgs toInvoke in _beforeget_Layers.GetInvocationList())
                    try
                    {
                        _beforeget_Layers?.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }

            self = @params.self;
            var retVal = orig(self);
            if (_afterget_Layers != null)
                foreach (Delegates.get_Layers_AfterArgs toInvoke in _afterget_Layers.GetInvocationList())
                    try
                    {
                        retVal = _afterget_Layers.Invoke(@params, retVal);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }

            return retVal;
        }

        internal static void HookGetTileInfoForSprite()
        {
            if (!HookedList.Contains("GetTileInfoForSprite"))
            {
                HookedList.Add("GetTileInfoForSprite");
                On.tk2dTileMapData.GetTileInfoForSprite += GetTileInfoForSprite;
            }
        }

        internal static event Delegates.GetTileInfoForSprite_BeforeArgs _beforeGetTileInfoForSprite;
        internal static event Delegates.GetTileInfoForSprite_AfterArgs _afterGetTileInfoForSprite;

        private static TileInfo GetTileInfoForSprite(On.tk2dTileMapData.orig_GetTileInfoForSprite orig,
            tk2dTileMapData self, int tileId)
        {
            Delegates.Params_GetTileInfoForSprite @params = new()
            {
                self = self, tileId = tileId
            };
            if (_beforeGetTileInfoForSprite != null)
                foreach (Delegates.GetTileInfoForSprite_BeforeArgs toInvoke in _beforeGetTileInfoForSprite
                             .GetInvocationList())
                    try
                    {
                        _beforeGetTileInfoForSprite?.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }

            self = @params.self;
            tileId = @params.tileId;
            var retVal = orig(self, tileId);
            if (_afterGetTileInfoForSprite != null)
                foreach (Delegates.GetTileInfoForSprite_AfterArgs toInvoke in _afterGetTileInfoForSprite
                             .GetInvocationList())
                    try
                    {
                        retVal = _afterGetTileInfoForSprite.Invoke(@params, retVal);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }

            return retVal;
        }

        internal static void HookGetOrCreateTileInfo()
        {
            if (!HookedList.Contains("GetOrCreateTileInfo"))
            {
                HookedList.Add("GetOrCreateTileInfo");
                On.tk2dTileMapData.GetOrCreateTileInfo += GetOrCreateTileInfo;
            }
        }

        internal static event Delegates.GetOrCreateTileInfo_BeforeArgs _beforeGetOrCreateTileInfo;
        internal static event Delegates.GetOrCreateTileInfo_AfterArgs _afterGetOrCreateTileInfo;

        private static TileInfo[] GetOrCreateTileInfo(On.tk2dTileMapData.orig_GetOrCreateTileInfo orig,
            tk2dTileMapData self, int numTiles)
        {
            Delegates.Params_GetOrCreateTileInfo @params = new()
            {
                self = self, numTiles = numTiles
            };
            if (_beforeGetOrCreateTileInfo != null)
                foreach (Delegates.GetOrCreateTileInfo_BeforeArgs toInvoke in _beforeGetOrCreateTileInfo
                             .GetInvocationList())
                    try
                    {
                        _beforeGetOrCreateTileInfo?.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }

            self = @params.self;
            numTiles = @params.numTiles;
            var retVal = orig(self, numTiles);
            if (_afterGetOrCreateTileInfo != null)
                foreach (Delegates.GetOrCreateTileInfo_AfterArgs toInvoke in
                         _afterGetOrCreateTileInfo.GetInvocationList())
                    try
                    {
                        retVal = _afterGetOrCreateTileInfo.Invoke(@params, retVal);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }

            return retVal;
        }

        internal static void HookGetTileOffset()
        {
            if (!HookedList.Contains("GetTileOffset"))
            {
                HookedList.Add("GetTileOffset");
                On.tk2dTileMapData.GetTileOffset += GetTileOffset;
            }
        }

        internal static event Delegates.GetTileOffset_BeforeArgs _beforeGetTileOffset;
        internal static event Delegates.GetTileOffset_AfterArgs _afterGetTileOffset;

        private static void GetTileOffset(On.tk2dTileMapData.orig_GetTileOffset orig, tk2dTileMapData self, out float x,
            out float y)
        {
            Delegates.Params_GetTileOffset @params = new()
            {
                self = self
            };
            if (_beforeGetTileOffset != null)
                foreach (Delegates.GetTileOffset_BeforeArgs toInvoke in _beforeGetTileOffset.GetInvocationList())
                    try
                    {
                        _beforeGetTileOffset?.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }

            self = @params.self;
            x = @params.x;
            y = @params.y;
            orig(self, out x, out y);
            if (_afterGetTileOffset != null)
                foreach (Delegates.GetTileOffset_AfterArgs toInvoke in _afterGetTileOffset.GetInvocationList())
                    try
                    {
                        _afterGetTileOffset.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }
        }

        internal static void HookInitLayers()
        {
            if (!HookedList.Contains("InitLayers"))
            {
                HookedList.Add("InitLayers");
                On.tk2dTileMapData.InitLayers += InitLayers;
            }
        }

        internal static event Delegates.InitLayers_BeforeArgs _beforeInitLayers;
        internal static event Delegates.InitLayers_AfterArgs _afterInitLayers;

        private static void InitLayers(On.tk2dTileMapData.orig_InitLayers orig, tk2dTileMapData self)
        {
            Delegates.Params_InitLayers @params = new()
            {
                self = self
            };
            if (_beforeInitLayers != null)
                foreach (Delegates.InitLayers_BeforeArgs toInvoke in _beforeInitLayers.GetInvocationList())
                    try
                    {
                        _beforeInitLayers?.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }

            self = @params.self;
            orig(self);
            if (_afterInitLayers != null)
                foreach (Delegates.InitLayers_AfterArgs toInvoke in _afterInitLayers.GetInvocationList())
                    try
                    {
                        _afterInitLayers.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }
        }
    }

    /// <summary>
    ///     Contains necessary information to create Hooks. Does not contain any hooks
    /// </summary>
    public static class Delegates
    {
        public delegate LayerInfo[] get_Layers_AfterArgs(Params_get_Layers args, LayerInfo[] ret);

        public delegate void get_Layers_BeforeArgs(Params_get_Layers args);

        public delegate LayerInfo[] get_Layers_WithArgs(Func<tk2dTileMapData, LayerInfo[]> orig, tk2dTileMapData self);

        public delegate int get_NumLayers_AfterArgs(Params_get_NumLayers args, int ret);

        public delegate void get_NumLayers_BeforeArgs(Params_get_NumLayers args);

        public delegate int get_NumLayers_WithArgs(Func<tk2dTileMapData, int> orig, tk2dTileMapData self);

        public delegate TileInfo[] GetOrCreateTileInfo_AfterArgs(Params_GetOrCreateTileInfo args, TileInfo[] ret);

        public delegate void GetOrCreateTileInfo_BeforeArgs(Params_GetOrCreateTileInfo args);

        public delegate TileInfo[] GetOrCreateTileInfo_WithArgs(Func<tk2dTileMapData, int, TileInfo[]> orig,
            tk2dTileMapData self, int numTiles);

        public delegate TileInfo GetTileInfoForSprite_AfterArgs(Params_GetTileInfoForSprite args, TileInfo ret);

        public delegate void GetTileInfoForSprite_BeforeArgs(Params_GetTileInfoForSprite args);

        public delegate TileInfo GetTileInfoForSprite_WithArgs(Func<tk2dTileMapData, int, TileInfo> orig,
            tk2dTileMapData self, int tileId);

        public delegate void GetTileOffset_AfterArgs(Params_GetTileOffset args);

        public delegate void GetTileOffset_BeforeArgs(Params_GetTileOffset args);

        public delegate void GetTileOffset_WithArgs(Action<tk2dTileMapData, float, float> orig, tk2dTileMapData self,
            out float x, out float y);

        public delegate void InitLayers_AfterArgs(Params_InitLayers args);

        public delegate void InitLayers_BeforeArgs(Params_InitLayers args);

        public delegate void InitLayers_WithArgs(Action<tk2dTileMapData> orig, tk2dTileMapData self);

        public sealed class Params_get_NumLayers
        {
            public tk2dTileMapData self;
        }

        public sealed class Params_get_Layers
        {
            public tk2dTileMapData self;
        }

        public sealed class Params_GetTileInfoForSprite
        {
            public tk2dTileMapData self;
            public int tileId;
        }

        public sealed class Params_GetOrCreateTileInfo
        {
            public int numTiles;
            public tk2dTileMapData self;
        }

        public sealed class Params_GetTileOffset
        {
            public tk2dTileMapData self;
            public float x;
            public float y;
        }

        public sealed class Params_InitLayers
        {
            public tk2dTileMapData self;
        }
    }

    /// <summary>
    ///     Contains Hooks to that run code before orig(self) is called
    /// </summary>
    public static class BeforeOrig
    {
        public static event Delegates.get_NumLayers_BeforeArgs get_NumLayers
        {
            add
            {
                HookHandler._beforeget_NumLayers += value;
                HookHandler.Hookget_NumLayers();
            }
            remove => HookHandler._beforeget_NumLayers -= value;
        }

        public static event Delegates.get_Layers_BeforeArgs get_Layers
        {
            add
            {
                HookHandler._beforeget_Layers += value;
                HookHandler.Hookget_Layers();
            }
            remove => HookHandler._beforeget_Layers -= value;
        }

        public static event Delegates.GetTileInfoForSprite_BeforeArgs GetTileInfoForSprite
        {
            add
            {
                HookHandler._beforeGetTileInfoForSprite += value;
                HookHandler.HookGetTileInfoForSprite();
            }
            remove => HookHandler._beforeGetTileInfoForSprite -= value;
        }

        public static event Delegates.GetOrCreateTileInfo_BeforeArgs GetOrCreateTileInfo
        {
            add
            {
                HookHandler._beforeGetOrCreateTileInfo += value;
                HookHandler.HookGetOrCreateTileInfo();
            }
            remove => HookHandler._beforeGetOrCreateTileInfo -= value;
        }

        public static event Delegates.GetTileOffset_BeforeArgs GetTileOffset
        {
            add
            {
                HookHandler._beforeGetTileOffset += value;
                HookHandler.HookGetTileOffset();
            }
            remove => HookHandler._beforeGetTileOffset -= value;
        }

        public static event Delegates.InitLayers_BeforeArgs InitLayers
        {
            add
            {
                HookHandler._beforeInitLayers += value;
                HookHandler.HookInitLayers();
            }
            remove => HookHandler._beforeInitLayers -= value;
        }
    }

    /// <summary>
    ///     Contains Hooks to that run code after orig(self) is called
    /// </summary>
    public static class AfterOrig
    {
        public static event Delegates.get_NumLayers_AfterArgs get_NumLayers
        {
            add
            {
                HookHandler._afterget_NumLayers += value;
                HookHandler.Hookget_NumLayers();
            }
            remove => HookHandler._afterget_NumLayers -= value;
        }

        public static event Delegates.get_Layers_AfterArgs get_Layers
        {
            add
            {
                HookHandler._afterget_Layers += value;
                HookHandler.Hookget_Layers();
            }
            remove => HookHandler._afterget_Layers -= value;
        }

        public static event Delegates.GetTileInfoForSprite_AfterArgs GetTileInfoForSprite
        {
            add
            {
                HookHandler._afterGetTileInfoForSprite += value;
                HookHandler.HookGetTileInfoForSprite();
            }
            remove => HookHandler._afterGetTileInfoForSprite -= value;
        }

        public static event Delegates.GetOrCreateTileInfo_AfterArgs GetOrCreateTileInfo
        {
            add
            {
                HookHandler._afterGetOrCreateTileInfo += value;
                HookHandler.HookGetOrCreateTileInfo();
            }
            remove => HookHandler._afterGetOrCreateTileInfo -= value;
        }

        public static event Delegates.GetTileOffset_AfterArgs GetTileOffset
        {
            add
            {
                HookHandler._afterGetTileOffset += value;
                HookHandler.HookGetTileOffset();
            }
            remove => HookHandler._afterGetTileOffset -= value;
        }

        public static event Delegates.InitLayers_AfterArgs InitLayers
        {
            add
            {
                HookHandler._afterInitLayers += value;
                HookHandler.HookInitLayers();
            }
            remove => HookHandler._afterInitLayers -= value;
        }
    }

    /// <summary>
    ///     Contains all On Hooks, even those that aren't in the On namespace such as API generated functions and property
    ///     getters/setters
    /// </summary>
    public static class WithOrig
    {
        public static event Delegates.get_NumLayers_WithArgs get_NumLayers
        {
            add => HookEndpointManager.Add<Delegates.get_NumLayers_WithArgs>(
                ReflectionHelper.GetMethodInfo(typeof(tk2dTileMapData), "get_NumLayers"), value);
            remove => HookEndpointManager.Remove<Delegates.get_NumLayers_WithArgs>(
                ReflectionHelper.GetMethodInfo(typeof(tk2dTileMapData), "get_NumLayers"), value);
        }

        public static event Delegates.get_Layers_WithArgs get_Layers
        {
            add => HookEndpointManager.Add<Delegates.get_Layers_WithArgs>(
                ReflectionHelper.GetMethodInfo(typeof(tk2dTileMapData), "get_Layers"), value);
            remove => HookEndpointManager.Remove<Delegates.get_Layers_WithArgs>(
                ReflectionHelper.GetMethodInfo(typeof(tk2dTileMapData), "get_Layers"), value);
        }

        public static event On.tk2dTileMapData.hook_GetTileInfoForSprite GetTileInfoForSprite
        {
            add => On.tk2dTileMapData.GetTileInfoForSprite += value;
            remove => On.tk2dTileMapData.GetTileInfoForSprite -= value;
        }

        public static event On.tk2dTileMapData.hook_GetOrCreateTileInfo GetOrCreateTileInfo
        {
            add => On.tk2dTileMapData.GetOrCreateTileInfo += value;
            remove => On.tk2dTileMapData.GetOrCreateTileInfo -= value;
        }

        public static event On.tk2dTileMapData.hook_GetTileOffset GetTileOffset
        {
            add => On.tk2dTileMapData.GetTileOffset += value;
            remove => On.tk2dTileMapData.GetTileOffset -= value;
        }

        public static event On.tk2dTileMapData.hook_InitLayers InitLayers
        {
            add => On.tk2dTileMapData.InitLayers += value;
            remove => On.tk2dTileMapData.InitLayers -= value;
        }
    }
}