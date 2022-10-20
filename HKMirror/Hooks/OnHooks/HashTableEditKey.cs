using MonoMod.RuntimeDetour;
using MonoMod.RuntimeDetour.HookGen;

namespace HKMirror.Hooks.OnHooks;

/// <summary>
///     Contains different types of On Hooks for HashTableEditKey class.<br />
///     Contains hooks that aren't generated by monomod, and before and after orig hooks for easier hooking.
/// </summary>
public static class OnHashTableEditKey
{
    internal static class HookHandler
    {
        private static readonly List<string> HookedList = new();

        internal static void HookReset()
        {
            if (!HookedList.Contains("Reset"))
            {
                HookedList.Add("Reset");
                new Hook(ReflectionHelper.GetMethodInfo(typeof(HashTableEditKey), "Reset"), Reset);
            }
        }

        internal static event Delegates.Reset_BeforeArgs _beforeReset;
        internal static event Delegates.Reset_NormalArgs _afterReset;

        private static void Reset(Action<HashTableEditKey> orig, HashTableEditKey self)
        {
            Delegates.Params_Reset @params = new()
            {
                self = self
            };
            _beforeReset?.Invoke(@params);
            self = @params.self;
            orig(self);
            if (_afterReset != null) _afterReset.Invoke(@params);
        }

        internal static void HookOnEnter()
        {
            if (!HookedList.Contains("OnEnter"))
            {
                HookedList.Add("OnEnter");
                new Hook(ReflectionHelper.GetMethodInfo(typeof(HashTableEditKey), "OnEnter"), OnEnter);
            }
        }

        internal static event Delegates.OnEnter_BeforeArgs _beforeOnEnter;
        internal static event Delegates.OnEnter_NormalArgs _afterOnEnter;

        private static void OnEnter(Action<HashTableEditKey> orig, HashTableEditKey self)
        {
            Delegates.Params_OnEnter @params = new()
            {
                self = self
            };
            _beforeOnEnter?.Invoke(@params);
            self = @params.self;
            orig(self);
            if (_afterOnEnter != null) _afterOnEnter.Invoke(@params);
        }

        internal static void HookEditHashTableKey()
        {
            if (!HookedList.Contains("EditHashTableKey"))
            {
                HookedList.Add("EditHashTableKey");
                new Hook(ReflectionHelper.GetMethodInfo(typeof(HashTableEditKey), "EditHashTableKey"),
                    EditHashTableKey);
            }
        }

        internal static event Delegates.EditHashTableKey_BeforeArgs _beforeEditHashTableKey;
        internal static event Delegates.EditHashTableKey_NormalArgs _afterEditHashTableKey;

        private static void EditHashTableKey(Action<HashTableEditKey> orig, HashTableEditKey self)
        {
            Delegates.Params_EditHashTableKey @params = new()
            {
                self = self
            };
            _beforeEditHashTableKey?.Invoke(@params);
            self = @params.self;
            orig(self);
            if (_afterEditHashTableKey != null) _afterEditHashTableKey.Invoke(@params);
        }
    }

    /// <summary>
    ///     Contains necessary information to create Hooks. Does not contain any hooks
    /// </summary>
    public static class Delegates
    {
        public delegate void EditHashTableKey_BeforeArgs(Params_EditHashTableKey args);

        public delegate void EditHashTableKey_NormalArgs(Params_EditHashTableKey args);

        public delegate void OnEnter_BeforeArgs(Params_OnEnter args);

        public delegate void OnEnter_NormalArgs(Params_OnEnter args);

        public delegate void Reset_BeforeArgs(Params_Reset args);

        public delegate void Reset_NormalArgs(Params_Reset args);

        public sealed class Params_Reset
        {
            public HashTableEditKey self;
        }

        public sealed class Params_OnEnter
        {
            public HashTableEditKey self;
        }

        public sealed class Params_EditHashTableKey
        {
            public HashTableEditKey self;
        }
    }

    /// <summary>
    ///     Contains Hooks to that run code before orig(self) is called
    /// </summary>
    public static class BeforeOrig
    {
        public static event Delegates.Reset_BeforeArgs Reset
        {
            add
            {
                HookHandler._beforeReset += value;
                HookHandler.HookReset();
            }
            remove => HookHandler._beforeReset -= value;
        }

        public static event Delegates.OnEnter_BeforeArgs OnEnter
        {
            add
            {
                HookHandler._beforeOnEnter += value;
                HookHandler.HookOnEnter();
            }
            remove => HookHandler._beforeOnEnter -= value;
        }

        public static event Delegates.EditHashTableKey_BeforeArgs EditHashTableKey
        {
            add
            {
                HookHandler._beforeEditHashTableKey += value;
                HookHandler.HookEditHashTableKey();
            }
            remove => HookHandler._beforeEditHashTableKey -= value;
        }
    }

    /// <summary>
    ///     Contains Hooks to that run code after orig(self) is called
    /// </summary>
    public static class AfterOrig
    {
        public static event Delegates.Reset_NormalArgs Reset
        {
            add
            {
                HookHandler._afterReset += value;
                HookHandler.HookReset();
            }
            remove => HookHandler._afterReset -= value;
        }

        public static event Delegates.OnEnter_NormalArgs OnEnter
        {
            add
            {
                HookHandler._afterOnEnter += value;
                HookHandler.HookOnEnter();
            }
            remove => HookHandler._afterOnEnter -= value;
        }

        public static event Delegates.EditHashTableKey_NormalArgs EditHashTableKey
        {
            add
            {
                HookHandler._afterEditHashTableKey += value;
                HookHandler.HookEditHashTableKey();
            }
            remove => HookHandler._afterEditHashTableKey -= value;
        }
    }

    /// <summary>
    ///     Contains all On Hooks, even those that aren't in the On namespace such as API generated functions and property
    ///     getters/setters
    /// </summary>
    public static class WithOrig
    {
        public static event Delegates.Reset_NormalArgs Reset
        {
            add => HookEndpointManager.Add<Delegates.Reset_NormalArgs>(
                ReflectionHelper.GetMethodInfo(typeof(HashTableEditKey), "Reset"), value);
            remove => HookEndpointManager.Remove<Delegates.Reset_NormalArgs>(
                ReflectionHelper.GetMethodInfo(typeof(HashTableEditKey), "Reset"), value);
        }

        public static event Delegates.OnEnter_NormalArgs OnEnter
        {
            add => HookEndpointManager.Add<Delegates.OnEnter_NormalArgs>(
                ReflectionHelper.GetMethodInfo(typeof(HashTableEditKey), "OnEnter"), value);
            remove => HookEndpointManager.Remove<Delegates.OnEnter_NormalArgs>(
                ReflectionHelper.GetMethodInfo(typeof(HashTableEditKey), "OnEnter"), value);
        }

        public static event Delegates.EditHashTableKey_NormalArgs EditHashTableKey
        {
            add => HookEndpointManager.Add<Delegates.EditHashTableKey_NormalArgs>(
                ReflectionHelper.GetMethodInfo(typeof(HashTableEditKey), "EditHashTableKey"), value);
            remove => HookEndpointManager.Remove<Delegates.EditHashTableKey_NormalArgs>(
                ReflectionHelper.GetMethodInfo(typeof(HashTableEditKey), "EditHashTableKey"), value);
        }
    }
}