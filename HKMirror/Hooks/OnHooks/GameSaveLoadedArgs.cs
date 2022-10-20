using Microsoft.Xbox;
using MonoMod.RuntimeDetour;
using MonoMod.RuntimeDetour.HookGen;

namespace HKMirror.Hooks.OnHooks;

/// <summary>
///     Contains different types of On Hooks for GameSaveLoadedArgs class.<br />
///     Contains hooks that aren't generated by monomod, and before and after orig hooks for easier hooking.
/// </summary>
public static class OnGameSaveLoadedArgs
{
    internal static class HookHandler
    {
        private static readonly List<string> HookedList = new();

        internal static void Hookget_Data()
        {
            if (!HookedList.Contains("get_Data"))
            {
                HookedList.Add("get_Data");
                new Hook(ReflectionHelper.GetMethodInfo(typeof(GameSaveLoadedArgs), "get_Data"), get_Data);
            }
        }

        internal static event Delegates.get_Data_BeforeArgs _beforeget_Data;
        internal static event Delegates.get_Data_NormalArgs _afterget_Data;

        private static byte[] get_Data(Func<GameSaveLoadedArgs, byte[]> orig, GameSaveLoadedArgs self)
        {
            Delegates.Params_get_Data @params = new()
            {
                self = self
            };
            _beforeget_Data?.Invoke(@params);
            self = @params.self;
            var retVal = orig(self);
            if (_afterget_Data != null) retVal = _afterget_Data.Invoke(@params);
            return retVal;
        }

        internal static void Hookset_Data()
        {
            if (!HookedList.Contains("set_Data"))
            {
                HookedList.Add("set_Data");
                new Hook(ReflectionHelper.GetMethodInfo(typeof(GameSaveLoadedArgs), "set_Data"), set_Data);
            }
        }

        internal static event Delegates.set_Data_BeforeArgs _beforeset_Data;
        internal static event Delegates.set_Data_NormalArgs _afterset_Data;

        private static void set_Data(Action<GameSaveLoadedArgs, byte[]> orig, GameSaveLoadedArgs self, byte[] value)
        {
            Delegates.Params_set_Data @params = new()
            {
                self = self, value = value
            };
            _beforeset_Data?.Invoke(@params);
            self = @params.self;
            value = @params.value;
            orig(self, value);
            if (_afterset_Data != null) _afterset_Data.Invoke(@params);
        }
    }

    /// <summary>
    ///     Contains necessary information to create Hooks. Does not contain any hooks
    /// </summary>
    public static class Delegates
    {
        public delegate void get_Data_BeforeArgs(Params_get_Data args);

        public delegate byte[] get_Data_NormalArgs(Params_get_Data args);

        public delegate void set_Data_BeforeArgs(Params_set_Data args);

        public delegate void set_Data_NormalArgs(Params_set_Data args);

        public sealed class Params_get_Data
        {
            public GameSaveLoadedArgs self;
        }

        public sealed class Params_set_Data
        {
            public GameSaveLoadedArgs self;
            public byte[] value;
        }
    }

    /// <summary>
    ///     Contains Hooks to that run code before orig(self) is called
    /// </summary>
    public static class BeforeOrig
    {
        public static event Delegates.get_Data_BeforeArgs get_Data
        {
            add
            {
                HookHandler._beforeget_Data += value;
                HookHandler.Hookget_Data();
            }
            remove => HookHandler._beforeget_Data -= value;
        }

        public static event Delegates.set_Data_BeforeArgs set_Data
        {
            add
            {
                HookHandler._beforeset_Data += value;
                HookHandler.Hookset_Data();
            }
            remove => HookHandler._beforeset_Data -= value;
        }
    }

    /// <summary>
    ///     Contains Hooks to that run code after orig(self) is called
    /// </summary>
    public static class AfterOrig
    {
        public static event Delegates.get_Data_NormalArgs get_Data
        {
            add
            {
                HookHandler._afterget_Data += value;
                HookHandler.Hookget_Data();
            }
            remove => HookHandler._afterget_Data -= value;
        }

        public static event Delegates.set_Data_NormalArgs set_Data
        {
            add
            {
                HookHandler._afterset_Data += value;
                HookHandler.Hookset_Data();
            }
            remove => HookHandler._afterset_Data -= value;
        }
    }

    /// <summary>
    ///     Contains all On Hooks, even those that aren't in the On namespace such as API generated functions and property
    ///     getters/setters
    /// </summary>
    public static class WithOrig
    {
        public static event Delegates.get_Data_NormalArgs get_Data
        {
            add => HookEndpointManager.Add<Delegates.get_Data_NormalArgs>(
                ReflectionHelper.GetMethodInfo(typeof(GameSaveLoadedArgs), "get_Data"), value);
            remove => HookEndpointManager.Remove<Delegates.get_Data_NormalArgs>(
                ReflectionHelper.GetMethodInfo(typeof(GameSaveLoadedArgs), "get_Data"), value);
        }

        public static event Delegates.set_Data_NormalArgs set_Data
        {
            add => HookEndpointManager.Add<Delegates.set_Data_NormalArgs>(
                ReflectionHelper.GetMethodInfo(typeof(GameSaveLoadedArgs), "set_Data"), value);
            remove => HookEndpointManager.Remove<Delegates.set_Data_NormalArgs>(
                ReflectionHelper.GetMethodInfo(typeof(GameSaveLoadedArgs), "set_Data"), value);
        }
    }
}