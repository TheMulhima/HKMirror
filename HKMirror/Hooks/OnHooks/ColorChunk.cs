using MonoMod.RuntimeDetour;
using MonoMod.RuntimeDetour.HookGen;

namespace HKMirror.Hooks.OnHooks;

/// <summary>
/// Contains different types of On Hooks for ColorChunk class.<br />
/// Contains hooks that aren't generated by monomod, and before and after orig hooks for easier hooking.
/// </summary>
public static class OnColorChunk
{
    internal static class HookHandler
    {
        private static List<string> HookedList = new List<string>();

        internal static void Hookget_Dirty()
        {
            if (!HookedList.Contains("get_Dirty"))
            {
                HookedList.Add("get_Dirty");
                new Hook(ReflectionHelper.GetMethodInfo(typeof(tk2dRuntime.TileMap.ColorChunk), "get_Dirty", true),
                    get_Dirty);
            }
        }

        internal static event Delegates.get_Dirty_BeforeArgs _beforeget_Dirty;
        internal static event Delegates.get_Dirty_AfterArgs _afterget_Dirty;

        private static bool get_Dirty(Func<tk2dRuntime.TileMap.ColorChunk, bool> orig,
            tk2dRuntime.TileMap.ColorChunk self)
        {
            Delegates.Params_get_Dirty @params = new()
            {
                self = self
            };
            if (_beforeget_Dirty != null)
            {
                foreach (Delegates.get_Dirty_BeforeArgs toInvoke in _beforeget_Dirty.GetInvocationList())
                {
                    try
                    {
                        _beforeget_Dirty?.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }
                }
            }

            self = @params.self;
            var retVal = orig(self);
            if (_afterget_Dirty != null)
            {
                foreach (Delegates.get_Dirty_AfterArgs toInvoke in _afterget_Dirty.GetInvocationList())
                {
                    try
                    {
                        retVal = _afterget_Dirty.Invoke(@params, retVal);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }
                }
            }

            return retVal;
        }

        internal static void Hookset_Dirty()
        {
            if (!HookedList.Contains("set_Dirty"))
            {
                HookedList.Add("set_Dirty");
                new Hook(ReflectionHelper.GetMethodInfo(typeof(tk2dRuntime.TileMap.ColorChunk), "set_Dirty", true),
                    set_Dirty);
            }
        }

        internal static event Delegates.set_Dirty_BeforeArgs _beforeset_Dirty;
        internal static event Delegates.set_Dirty_AfterArgs _afterset_Dirty;

        private static void set_Dirty(Action<tk2dRuntime.TileMap.ColorChunk, bool> orig,
            tk2dRuntime.TileMap.ColorChunk self, bool value)
        {
            Delegates.Params_set_Dirty @params = new()
            {
                self = self, value = value
            };
            if (_beforeset_Dirty != null)
            {
                foreach (Delegates.set_Dirty_BeforeArgs toInvoke in _beforeset_Dirty.GetInvocationList())
                {
                    try
                    {
                        _beforeset_Dirty?.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }
                }
            }

            self = @params.self;
            value = @params.value;
            orig(self, value);
            if (_afterset_Dirty != null)
            {
                foreach (Delegates.set_Dirty_AfterArgs toInvoke in _afterset_Dirty.GetInvocationList())
                {
                    try
                    {
                        _afterset_Dirty.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }
                }
            }
        }

        internal static void Hookget_Empty()
        {
            if (!HookedList.Contains("get_Empty"))
            {
                HookedList.Add("get_Empty");
                new Hook(ReflectionHelper.GetMethodInfo(typeof(tk2dRuntime.TileMap.ColorChunk), "get_Empty", true),
                    get_Empty);
            }
        }

        internal static event Delegates.get_Empty_BeforeArgs _beforeget_Empty;
        internal static event Delegates.get_Empty_AfterArgs _afterget_Empty;

        private static bool get_Empty(Func<tk2dRuntime.TileMap.ColorChunk, bool> orig,
            tk2dRuntime.TileMap.ColorChunk self)
        {
            Delegates.Params_get_Empty @params = new()
            {
                self = self
            };
            if (_beforeget_Empty != null)
            {
                foreach (Delegates.get_Empty_BeforeArgs toInvoke in _beforeget_Empty.GetInvocationList())
                {
                    try
                    {
                        _beforeget_Empty?.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }
                }
            }

            self = @params.self;
            var retVal = orig(self);
            if (_afterget_Empty != null)
            {
                foreach (Delegates.get_Empty_AfterArgs toInvoke in _afterget_Empty.GetInvocationList())
                {
                    try
                    {
                        retVal = _afterget_Empty.Invoke(@params, retVal);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }
                }
            }

            return retVal;
        }
    }

    /// <summary>
    /// Contains necessary information to create Hooks. Does not contain any hooks
    /// </summary>
    public static class Delegates
    {
        public sealed class Params_get_Dirty
        {
            public tk2dRuntime.TileMap.ColorChunk self;
        }

        public delegate void get_Dirty_BeforeArgs(Params_get_Dirty args);

        public delegate bool get_Dirty_AfterArgs(Params_get_Dirty args, bool ret);

        public delegate bool get_Dirty_WithArgs(Func<tk2dRuntime.TileMap.ColorChunk, bool> orig,
            tk2dRuntime.TileMap.ColorChunk self);

        public sealed class Params_set_Dirty
        {
            public tk2dRuntime.TileMap.ColorChunk self;
            public bool value;
        }

        public delegate void set_Dirty_BeforeArgs(Params_set_Dirty args);

        public delegate void set_Dirty_AfterArgs(Params_set_Dirty args);

        public delegate void set_Dirty_WithArgs(Action<tk2dRuntime.TileMap.ColorChunk, bool> orig,
            tk2dRuntime.TileMap.ColorChunk self, bool value);

        public sealed class Params_get_Empty
        {
            public tk2dRuntime.TileMap.ColorChunk self;
        }

        public delegate void get_Empty_BeforeArgs(Params_get_Empty args);

        public delegate bool get_Empty_AfterArgs(Params_get_Empty args, bool ret);

        public delegate bool get_Empty_WithArgs(Func<tk2dRuntime.TileMap.ColorChunk, bool> orig,
            tk2dRuntime.TileMap.ColorChunk self);
    }

    /// <summary>
    /// Contains Hooks to that run code before orig(self) is called
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

        public static event Delegates.get_Empty_BeforeArgs get_Empty
        {
            add
            {
                HookHandler._beforeget_Empty += value;
                HookHandler.Hookget_Empty();
            }
            remove => HookHandler._beforeget_Empty -= value;
        }
    }

    /// <summary>
    /// Contains Hooks to that run code after orig(self) is called
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

        public static event Delegates.get_Empty_AfterArgs get_Empty
        {
            add
            {
                HookHandler._afterget_Empty += value;
                HookHandler.Hookget_Empty();
            }
            remove => HookHandler._afterget_Empty -= value;
        }
    }

    /// <summary>
    /// Contains all On Hooks, even those that aren't in the On namespace such as API generated functions and property getters/setters
    /// </summary>
    public static class WithOrig
    {
        public static event Delegates.get_Dirty_WithArgs get_Dirty
        {
            add => HookEndpointManager.Add<Delegates.get_Dirty_WithArgs>(
                ReflectionHelper.GetMethodInfo(typeof(tk2dRuntime.TileMap.ColorChunk), "get_Dirty", true), value);
            remove => HookEndpointManager.Remove<Delegates.get_Dirty_WithArgs>(
                ReflectionHelper.GetMethodInfo(typeof(tk2dRuntime.TileMap.ColorChunk), "get_Dirty", true), value);
        }

        public static event Delegates.set_Dirty_WithArgs set_Dirty
        {
            add => HookEndpointManager.Add<Delegates.set_Dirty_WithArgs>(
                ReflectionHelper.GetMethodInfo(typeof(tk2dRuntime.TileMap.ColorChunk), "set_Dirty", true), value);
            remove => HookEndpointManager.Remove<Delegates.set_Dirty_WithArgs>(
                ReflectionHelper.GetMethodInfo(typeof(tk2dRuntime.TileMap.ColorChunk), "set_Dirty", true), value);
        }

        public static event Delegates.get_Empty_WithArgs get_Empty
        {
            add => HookEndpointManager.Add<Delegates.get_Empty_WithArgs>(
                ReflectionHelper.GetMethodInfo(typeof(tk2dRuntime.TileMap.ColorChunk), "get_Empty", true), value);
            remove => HookEndpointManager.Remove<Delegates.get_Empty_WithArgs>(
                ReflectionHelper.GetMethodInfo(typeof(tk2dRuntime.TileMap.ColorChunk), "get_Empty", true), value);
        }
    }
}