using MonoMod.RuntimeDetour;
using MonoMod.RuntimeDetour.HookGen;

namespace HKMirror.Hooks.OnHooks;

/// <summary>
///     Contains different types of On Hooks for HashTableContains class.<br />
///     Contains hooks that aren't generated by monomod, and before and after orig hooks for easier hooking.
/// </summary>
public static class OnHashTableContains
{
    internal static class HookHandler
    {
        private static readonly List<string> HookedList = new();

        internal static void HookReset()
        {
            if (!HookedList.Contains("Reset"))
            {
                HookedList.Add("Reset");
                new Hook(ReflectionHelper.GetMethodInfo(typeof(HashTableContains), "Reset"), Reset);
            }
        }

        internal static event Delegates.Reset_BeforeArgs _beforeReset;
        internal static event Delegates.Reset_AfterArgs _afterReset;

        private static void Reset(Action<HashTableContains> orig, HashTableContains self)
        {
            Delegates.Params_Reset @params = new()
            {
                self = self
            };
            if (_beforeReset != null)
                foreach (Delegates.Reset_BeforeArgs toInvoke in _beforeReset.GetInvocationList())
                    try
                    {
                        _beforeReset?.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }

            self = @params.self;
            orig(self);
            if (_afterReset != null)
                foreach (Delegates.Reset_AfterArgs toInvoke in _afterReset.GetInvocationList())
                    try
                    {
                        _afterReset.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }
        }

        internal static void HookOnEnter()
        {
            if (!HookedList.Contains("OnEnter"))
            {
                HookedList.Add("OnEnter");
                new Hook(ReflectionHelper.GetMethodInfo(typeof(HashTableContains), "OnEnter"), OnEnter);
            }
        }

        internal static event Delegates.OnEnter_BeforeArgs _beforeOnEnter;
        internal static event Delegates.OnEnter_AfterArgs _afterOnEnter;

        private static void OnEnter(Action<HashTableContains> orig, HashTableContains self)
        {
            Delegates.Params_OnEnter @params = new()
            {
                self = self
            };
            if (_beforeOnEnter != null)
                foreach (Delegates.OnEnter_BeforeArgs toInvoke in _beforeOnEnter.GetInvocationList())
                    try
                    {
                        _beforeOnEnter?.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }

            self = @params.self;
            orig(self);
            if (_afterOnEnter != null)
                foreach (Delegates.OnEnter_AfterArgs toInvoke in _afterOnEnter.GetInvocationList())
                    try
                    {
                        _afterOnEnter.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }
        }

        internal static void HookcheckIfContainsKey()
        {
            if (!HookedList.Contains("checkIfContainsKey"))
            {
                HookedList.Add("checkIfContainsKey");
                new Hook(ReflectionHelper.GetMethodInfo(typeof(HashTableContains), "checkIfContainsKey"),
                    checkIfContainsKey);
            }
        }

        internal static event Delegates.checkIfContainsKey_BeforeArgs _beforecheckIfContainsKey;
        internal static event Delegates.checkIfContainsKey_AfterArgs _aftercheckIfContainsKey;

        private static void checkIfContainsKey(Action<HashTableContains> orig, HashTableContains self)
        {
            Delegates.Params_checkIfContainsKey @params = new()
            {
                self = self
            };
            if (_beforecheckIfContainsKey != null)
                foreach (Delegates.checkIfContainsKey_BeforeArgs toInvoke in
                         _beforecheckIfContainsKey.GetInvocationList())
                    try
                    {
                        _beforecheckIfContainsKey?.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }

            self = @params.self;
            orig(self);
            if (_aftercheckIfContainsKey != null)
                foreach (Delegates.checkIfContainsKey_AfterArgs toInvoke in
                         _aftercheckIfContainsKey.GetInvocationList())
                    try
                    {
                        _aftercheckIfContainsKey.Invoke(@params);
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
        public delegate void checkIfContainsKey_AfterArgs(Params_checkIfContainsKey args);

        public delegate void checkIfContainsKey_BeforeArgs(Params_checkIfContainsKey args);

        public delegate void checkIfContainsKey_WithArgs(Action<HashTableContains> orig, HashTableContains self);

        public delegate void OnEnter_AfterArgs(Params_OnEnter args);

        public delegate void OnEnter_BeforeArgs(Params_OnEnter args);

        public delegate void OnEnter_WithArgs(Action<HashTableContains> orig, HashTableContains self);

        public delegate void Reset_AfterArgs(Params_Reset args);

        public delegate void Reset_BeforeArgs(Params_Reset args);

        public delegate void Reset_WithArgs(Action<HashTableContains> orig, HashTableContains self);

        public sealed class Params_Reset
        {
            public HashTableContains self;
        }

        public sealed class Params_OnEnter
        {
            public HashTableContains self;
        }

        public sealed class Params_checkIfContainsKey
        {
            public HashTableContains self;
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

        public static event Delegates.checkIfContainsKey_BeforeArgs checkIfContainsKey
        {
            add
            {
                HookHandler._beforecheckIfContainsKey += value;
                HookHandler.HookcheckIfContainsKey();
            }
            remove => HookHandler._beforecheckIfContainsKey -= value;
        }
    }

    /// <summary>
    ///     Contains Hooks to that run code after orig(self) is called
    /// </summary>
    public static class AfterOrig
    {
        public static event Delegates.Reset_AfterArgs Reset
        {
            add
            {
                HookHandler._afterReset += value;
                HookHandler.HookReset();
            }
            remove => HookHandler._afterReset -= value;
        }

        public static event Delegates.OnEnter_AfterArgs OnEnter
        {
            add
            {
                HookHandler._afterOnEnter += value;
                HookHandler.HookOnEnter();
            }
            remove => HookHandler._afterOnEnter -= value;
        }

        public static event Delegates.checkIfContainsKey_AfterArgs checkIfContainsKey
        {
            add
            {
                HookHandler._aftercheckIfContainsKey += value;
                HookHandler.HookcheckIfContainsKey();
            }
            remove => HookHandler._aftercheckIfContainsKey -= value;
        }
    }

    /// <summary>
    ///     Contains all On Hooks, even those that aren't in the On namespace such as API generated functions and property
    ///     getters/setters
    /// </summary>
    public static class WithOrig
    {
        public static event Delegates.Reset_WithArgs Reset
        {
            add => HookEndpointManager.Add<Delegates.Reset_WithArgs>(
                ReflectionHelper.GetMethodInfo(typeof(HashTableContains), "Reset"), value);
            remove => HookEndpointManager.Remove<Delegates.Reset_WithArgs>(
                ReflectionHelper.GetMethodInfo(typeof(HashTableContains), "Reset"), value);
        }

        public static event Delegates.OnEnter_WithArgs OnEnter
        {
            add => HookEndpointManager.Add<Delegates.OnEnter_WithArgs>(
                ReflectionHelper.GetMethodInfo(typeof(HashTableContains), "OnEnter"), value);
            remove => HookEndpointManager.Remove<Delegates.OnEnter_WithArgs>(
                ReflectionHelper.GetMethodInfo(typeof(HashTableContains), "OnEnter"), value);
        }

        public static event Delegates.checkIfContainsKey_WithArgs checkIfContainsKey
        {
            add => HookEndpointManager.Add<Delegates.checkIfContainsKey_WithArgs>(
                ReflectionHelper.GetMethodInfo(typeof(HashTableContains), "checkIfContainsKey"), value);
            remove => HookEndpointManager.Remove<Delegates.checkIfContainsKey_WithArgs>(
                ReflectionHelper.GetMethodInfo(typeof(HashTableContains), "checkIfContainsKey"), value);
        }
    }
}