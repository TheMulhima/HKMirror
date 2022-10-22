using MonoMod.RuntimeDetour;
using MonoMod.RuntimeDetour.HookGen;
using tk2dRuntime.TileMap;

namespace HKMirror.Hooks.OnHooks;

/// <summary>
///     Contains different types of On Hooks for SpriteChunk class.<br />
///     Contains hooks that aren't generated by monomod, and before and after orig hooks for easier hooking.
/// </summary>
public static class OnSpriteChunk
{
    internal static class HookHandler
    {
        private static readonly List<string> HookedList = new();

        internal static void Hookget_Dirty()
        {
            if (!HookedList.Contains("get_Dirty"))
            {
                HookedList.Add("get_Dirty");
                new Hook(ReflectionHelper.GetMethodInfo(typeof(SpriteChunk), "get_Dirty"), get_Dirty);
            }
        }

        internal static event Delegates.get_Dirty_BeforeArgs _beforeget_Dirty;
        internal static event Delegates.get_Dirty_AfterArgs _afterget_Dirty;

        private static bool get_Dirty(Func<SpriteChunk, bool> orig, SpriteChunk self)
        {
            Delegates.Params_get_Dirty @params = new()
            {
                self = self
            };
            if (_beforeget_Dirty != null)
                foreach (Delegates.get_Dirty_BeforeArgs toInvoke in _beforeget_Dirty.GetInvocationList())
                    try
                    {
                        _beforeget_Dirty?.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }

            self = @params.self;
            var retVal = orig(self);
            if (_afterget_Dirty != null)
                foreach (Delegates.get_Dirty_AfterArgs toInvoke in _afterget_Dirty.GetInvocationList())
                    try
                    {
                        retVal = _afterget_Dirty.Invoke(@params, retVal);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }

            return retVal;
        }

        internal static void Hookset_Dirty()
        {
            if (!HookedList.Contains("set_Dirty"))
            {
                HookedList.Add("set_Dirty");
                new Hook(ReflectionHelper.GetMethodInfo(typeof(SpriteChunk), "set_Dirty"), set_Dirty);
            }
        }

        internal static event Delegates.set_Dirty_BeforeArgs _beforeset_Dirty;
        internal static event Delegates.set_Dirty_AfterArgs _afterset_Dirty;

        private static void set_Dirty(Action<SpriteChunk, bool> orig, SpriteChunk self, bool value)
        {
            Delegates.Params_set_Dirty @params = new()
            {
                self = self, value = value
            };
            if (_beforeset_Dirty != null)
                foreach (Delegates.set_Dirty_BeforeArgs toInvoke in _beforeset_Dirty.GetInvocationList())
                    try
                    {
                        _beforeset_Dirty?.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }

            self = @params.self;
            value = @params.value;
            orig(self, value);
            if (_afterset_Dirty != null)
                foreach (Delegates.set_Dirty_AfterArgs toInvoke in _afterset_Dirty.GetInvocationList())
                    try
                    {
                        _afterset_Dirty.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }
        }

        internal static void Hookget_IsEmpty()
        {
            if (!HookedList.Contains("get_IsEmpty"))
            {
                HookedList.Add("get_IsEmpty");
                new Hook(ReflectionHelper.GetMethodInfo(typeof(SpriteChunk), "get_IsEmpty"), get_IsEmpty);
            }
        }

        internal static event Delegates.get_IsEmpty_BeforeArgs _beforeget_IsEmpty;
        internal static event Delegates.get_IsEmpty_AfterArgs _afterget_IsEmpty;

        private static bool get_IsEmpty(Func<SpriteChunk, bool> orig, SpriteChunk self)
        {
            Delegates.Params_get_IsEmpty @params = new()
            {
                self = self
            };
            if (_beforeget_IsEmpty != null)
                foreach (Delegates.get_IsEmpty_BeforeArgs toInvoke in _beforeget_IsEmpty.GetInvocationList())
                    try
                    {
                        _beforeget_IsEmpty?.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }

            self = @params.self;
            var retVal = orig(self);
            if (_afterget_IsEmpty != null)
                foreach (Delegates.get_IsEmpty_AfterArgs toInvoke in _afterget_IsEmpty.GetInvocationList())
                    try
                    {
                        retVal = _afterget_IsEmpty.Invoke(@params, retVal);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }

            return retVal;
        }

        internal static void Hookget_HasGameData()
        {
            if (!HookedList.Contains("get_HasGameData"))
            {
                HookedList.Add("get_HasGameData");
                new Hook(ReflectionHelper.GetMethodInfo(typeof(SpriteChunk), "get_HasGameData"), get_HasGameData);
            }
        }

        internal static event Delegates.get_HasGameData_BeforeArgs _beforeget_HasGameData;
        internal static event Delegates.get_HasGameData_AfterArgs _afterget_HasGameData;

        private static bool get_HasGameData(Func<SpriteChunk, bool> orig, SpriteChunk self)
        {
            Delegates.Params_get_HasGameData @params = new()
            {
                self = self
            };
            if (_beforeget_HasGameData != null)
                foreach (Delegates.get_HasGameData_BeforeArgs toInvoke in _beforeget_HasGameData.GetInvocationList())
                    try
                    {
                        _beforeget_HasGameData?.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }

            self = @params.self;
            var retVal = orig(self);
            if (_afterget_HasGameData != null)
                foreach (Delegates.get_HasGameData_AfterArgs toInvoke in _afterget_HasGameData.GetInvocationList())
                    try
                    {
                        retVal = _afterget_HasGameData.Invoke(@params, retVal);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }

            return retVal;
        }

        internal static void HookDestroyGameData()
        {
            if (!HookedList.Contains("DestroyGameData"))
            {
                HookedList.Add("DestroyGameData");
                new Hook(ReflectionHelper.GetMethodInfo(typeof(SpriteChunk), "DestroyGameData"), DestroyGameData);
            }
        }

        internal static event Delegates.DestroyGameData_BeforeArgs _beforeDestroyGameData;
        internal static event Delegates.DestroyGameData_AfterArgs _afterDestroyGameData;

        private static void DestroyGameData(Action<SpriteChunk, tk2dTileMap> orig, SpriteChunk self,
            tk2dTileMap tileMap)
        {
            Delegates.Params_DestroyGameData @params = new()
            {
                self = self, tileMap = tileMap
            };
            if (_beforeDestroyGameData != null)
                foreach (Delegates.DestroyGameData_BeforeArgs toInvoke in _beforeDestroyGameData.GetInvocationList())
                    try
                    {
                        _beforeDestroyGameData?.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }

            self = @params.self;
            tileMap = @params.tileMap;
            orig(self, tileMap);
            if (_afterDestroyGameData != null)
                foreach (Delegates.DestroyGameData_AfterArgs toInvoke in _afterDestroyGameData.GetInvocationList())
                    try
                    {
                        _afterDestroyGameData.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }
        }

        internal static void HookDestroyColliderData()
        {
            if (!HookedList.Contains("DestroyColliderData"))
            {
                HookedList.Add("DestroyColliderData");
                new Hook(ReflectionHelper.GetMethodInfo(typeof(SpriteChunk), "DestroyColliderData"),
                    DestroyColliderData);
            }
        }

        internal static event Delegates.DestroyColliderData_BeforeArgs _beforeDestroyColliderData;
        internal static event Delegates.DestroyColliderData_AfterArgs _afterDestroyColliderData;

        private static void DestroyColliderData(Action<SpriteChunk, tk2dTileMap> orig, SpriteChunk self,
            tk2dTileMap tileMap)
        {
            Delegates.Params_DestroyColliderData @params = new()
            {
                self = self, tileMap = tileMap
            };
            if (_beforeDestroyColliderData != null)
                foreach (Delegates.DestroyColliderData_BeforeArgs toInvoke in _beforeDestroyColliderData
                             .GetInvocationList())
                    try
                    {
                        _beforeDestroyColliderData?.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }

            self = @params.self;
            tileMap = @params.tileMap;
            orig(self, tileMap);
            if (_afterDestroyColliderData != null)
                foreach (Delegates.DestroyColliderData_AfterArgs toInvoke in
                         _afterDestroyColliderData.GetInvocationList())
                    try
                    {
                        _afterDestroyColliderData.Invoke(@params);
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
        public delegate void DestroyColliderData_AfterArgs(Params_DestroyColliderData args);

        public delegate void DestroyColliderData_BeforeArgs(Params_DestroyColliderData args);

        public delegate void DestroyColliderData_WithArgs(Action<SpriteChunk, tk2dTileMap> orig, SpriteChunk self,
            tk2dTileMap tileMap);

        public delegate void DestroyGameData_AfterArgs(Params_DestroyGameData args);

        public delegate void DestroyGameData_BeforeArgs(Params_DestroyGameData args);

        public delegate void DestroyGameData_WithArgs(Action<SpriteChunk, tk2dTileMap> orig, SpriteChunk self,
            tk2dTileMap tileMap);

        public delegate bool get_Dirty_AfterArgs(Params_get_Dirty args, bool ret);

        public delegate void get_Dirty_BeforeArgs(Params_get_Dirty args);

        public delegate bool get_Dirty_WithArgs(Func<SpriteChunk, bool> orig, SpriteChunk self);

        public delegate bool get_HasGameData_AfterArgs(Params_get_HasGameData args, bool ret);

        public delegate void get_HasGameData_BeforeArgs(Params_get_HasGameData args);

        public delegate bool get_HasGameData_WithArgs(Func<SpriteChunk, bool> orig, SpriteChunk self);

        public delegate bool get_IsEmpty_AfterArgs(Params_get_IsEmpty args, bool ret);

        public delegate void get_IsEmpty_BeforeArgs(Params_get_IsEmpty args);

        public delegate bool get_IsEmpty_WithArgs(Func<SpriteChunk, bool> orig, SpriteChunk self);

        public delegate void set_Dirty_AfterArgs(Params_set_Dirty args);

        public delegate void set_Dirty_BeforeArgs(Params_set_Dirty args);

        public delegate void set_Dirty_WithArgs(Action<SpriteChunk, bool> orig, SpriteChunk self, bool value);

        public sealed class Params_get_Dirty
        {
            public SpriteChunk self;
        }

        public sealed class Params_set_Dirty
        {
            public SpriteChunk self;
            public bool value;
        }

        public sealed class Params_get_IsEmpty
        {
            public SpriteChunk self;
        }

        public sealed class Params_get_HasGameData
        {
            public SpriteChunk self;
        }

        public sealed class Params_DestroyGameData
        {
            public SpriteChunk self;
            public tk2dTileMap tileMap;
        }

        public sealed class Params_DestroyColliderData
        {
            public SpriteChunk self;
            public tk2dTileMap tileMap;
        }
    }

    /// <summary>
    ///     Contains Hooks to that run code before orig(self) is called
    /// </summary>
    public static class BeforeOrig
    {
        public static event Delegates.get_Dirty_BeforeArgs get_Dirty
        {
            add
            {
                HookHandler._beforeget_Dirty += value;
                HookHandler.Hookget_Dirty();
            }
            remove => HookHandler._beforeget_Dirty -= value;
        }

        public static event Delegates.set_Dirty_BeforeArgs set_Dirty
        {
            add
            {
                HookHandler._beforeset_Dirty += value;
                HookHandler.Hookset_Dirty();
            }
            remove => HookHandler._beforeset_Dirty -= value;
        }

        public static event Delegates.get_IsEmpty_BeforeArgs get_IsEmpty
        {
            add
            {
                HookHandler._beforeget_IsEmpty += value;
                HookHandler.Hookget_IsEmpty();
            }
            remove => HookHandler._beforeget_IsEmpty -= value;
        }

        public static event Delegates.get_HasGameData_BeforeArgs get_HasGameData
        {
            add
            {
                HookHandler._beforeget_HasGameData += value;
                HookHandler.Hookget_HasGameData();
            }
            remove => HookHandler._beforeget_HasGameData -= value;
        }

        public static event Delegates.DestroyGameData_BeforeArgs DestroyGameData
        {
            add
            {
                HookHandler._beforeDestroyGameData += value;
                HookHandler.HookDestroyGameData();
            }
            remove => HookHandler._beforeDestroyGameData -= value;
        }

        public static event Delegates.DestroyColliderData_BeforeArgs DestroyColliderData
        {
            add
            {
                HookHandler._beforeDestroyColliderData += value;
                HookHandler.HookDestroyColliderData();
            }
            remove => HookHandler._beforeDestroyColliderData -= value;
        }
    }

    /// <summary>
    ///     Contains Hooks to that run code after orig(self) is called
    /// </summary>
    public static class AfterOrig
    {
        public static event Delegates.get_Dirty_AfterArgs get_Dirty
        {
            add
            {
                HookHandler._afterget_Dirty += value;
                HookHandler.Hookget_Dirty();
            }
            remove => HookHandler._afterget_Dirty -= value;
        }

        public static event Delegates.set_Dirty_AfterArgs set_Dirty
        {
            add
            {
                HookHandler._afterset_Dirty += value;
                HookHandler.Hookset_Dirty();
            }
            remove => HookHandler._afterset_Dirty -= value;
        }

        public static event Delegates.get_IsEmpty_AfterArgs get_IsEmpty
        {
            add
            {
                HookHandler._afterget_IsEmpty += value;
                HookHandler.Hookget_IsEmpty();
            }
            remove => HookHandler._afterget_IsEmpty -= value;
        }

        public static event Delegates.get_HasGameData_AfterArgs get_HasGameData
        {
            add
            {
                HookHandler._afterget_HasGameData += value;
                HookHandler.Hookget_HasGameData();
            }
            remove => HookHandler._afterget_HasGameData -= value;
        }

        public static event Delegates.DestroyGameData_AfterArgs DestroyGameData
        {
            add
            {
                HookHandler._afterDestroyGameData += value;
                HookHandler.HookDestroyGameData();
            }
            remove => HookHandler._afterDestroyGameData -= value;
        }

        public static event Delegates.DestroyColliderData_AfterArgs DestroyColliderData
        {
            add
            {
                HookHandler._afterDestroyColliderData += value;
                HookHandler.HookDestroyColliderData();
            }
            remove => HookHandler._afterDestroyColliderData -= value;
        }
    }

    /// <summary>
    ///     Contains all On Hooks, even those that aren't in the On namespace such as API generated functions and property
    ///     getters/setters
    /// </summary>
    public static class WithOrig
    {
        public static event Delegates.get_Dirty_WithArgs get_Dirty
        {
            add => HookEndpointManager.Add<Delegates.get_Dirty_WithArgs>(
                ReflectionHelper.GetMethodInfo(typeof(SpriteChunk), "get_Dirty"), value);
            remove => HookEndpointManager.Remove<Delegates.get_Dirty_WithArgs>(
                ReflectionHelper.GetMethodInfo(typeof(SpriteChunk), "get_Dirty"), value);
        }

        public static event Delegates.set_Dirty_WithArgs set_Dirty
        {
            add => HookEndpointManager.Add<Delegates.set_Dirty_WithArgs>(
                ReflectionHelper.GetMethodInfo(typeof(SpriteChunk), "set_Dirty"), value);
            remove => HookEndpointManager.Remove<Delegates.set_Dirty_WithArgs>(
                ReflectionHelper.GetMethodInfo(typeof(SpriteChunk), "set_Dirty"), value);
        }

        public static event Delegates.get_IsEmpty_WithArgs get_IsEmpty
        {
            add => HookEndpointManager.Add<Delegates.get_IsEmpty_WithArgs>(
                ReflectionHelper.GetMethodInfo(typeof(SpriteChunk), "get_IsEmpty"), value);
            remove => HookEndpointManager.Remove<Delegates.get_IsEmpty_WithArgs>(
                ReflectionHelper.GetMethodInfo(typeof(SpriteChunk), "get_IsEmpty"), value);
        }

        public static event Delegates.get_HasGameData_WithArgs get_HasGameData
        {
            add => HookEndpointManager.Add<Delegates.get_HasGameData_WithArgs>(
                ReflectionHelper.GetMethodInfo(typeof(SpriteChunk), "get_HasGameData"), value);
            remove => HookEndpointManager.Remove<Delegates.get_HasGameData_WithArgs>(
                ReflectionHelper.GetMethodInfo(typeof(SpriteChunk), "get_HasGameData"), value);
        }

        public static event Delegates.DestroyGameData_WithArgs DestroyGameData
        {
            add => HookEndpointManager.Add<Delegates.DestroyGameData_WithArgs>(
                ReflectionHelper.GetMethodInfo(typeof(SpriteChunk), "DestroyGameData"), value);
            remove => HookEndpointManager.Remove<Delegates.DestroyGameData_WithArgs>(
                ReflectionHelper.GetMethodInfo(typeof(SpriteChunk), "DestroyGameData"), value);
        }

        public static event Delegates.DestroyColliderData_WithArgs DestroyColliderData
        {
            add => HookEndpointManager.Add<Delegates.DestroyColliderData_WithArgs>(
                ReflectionHelper.GetMethodInfo(typeof(SpriteChunk), "DestroyColliderData"), value);
            remove => HookEndpointManager.Remove<Delegates.DestroyColliderData_WithArgs>(
                ReflectionHelper.GetMethodInfo(typeof(SpriteChunk), "DestroyColliderData"), value);
        }
    }
}