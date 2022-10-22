using MonoMod.RuntimeDetour;
using MonoMod.RuntimeDetour.HookGen;

namespace HKMirror.Hooks.OnHooks;

/// <summary>
///     Contains different types of On Hooks for HashTableTakeSnapShot class.<br />
///     Contains hooks that aren't generated by monomod, and before and after orig hooks for easier hooking.
/// </summary>
public static class OnHashTableTakeSnapShot
{
    internal static class HookHandler
    {
        private static readonly List<string> HookedList = new();

        internal static void HookReset()
        {
            if (!HookedList.Contains("Reset"))
            {
                HookedList.Add("Reset");
                new Hook(ReflectionHelper.GetMethodInfo(typeof(HashTableTakeSnapShot), "Reset"), Reset);
            }
        }

        internal static event Delegates.Reset_BeforeArgs _beforeReset;
        internal static event Delegates.Reset_AfterArgs _afterReset;

        private static void Reset(Action<HashTableTakeSnapShot> orig, HashTableTakeSnapShot self)
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
                new Hook(ReflectionHelper.GetMethodInfo(typeof(HashTableTakeSnapShot), "OnEnter"), OnEnter);
            }
        }

        internal static event Delegates.OnEnter_BeforeArgs _beforeOnEnter;
        internal static event Delegates.OnEnter_AfterArgs _afterOnEnter;

        private static void OnEnter(Action<HashTableTakeSnapShot> orig, HashTableTakeSnapShot self)
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

        internal static void HookDoHashTableTakeSnapShot()
        {
            if (!HookedList.Contains("DoHashTableTakeSnapShot"))
            {
                HookedList.Add("DoHashTableTakeSnapShot");
                new Hook(ReflectionHelper.GetMethodInfo(typeof(HashTableTakeSnapShot), "DoHashTableTakeSnapShot"),
                    DoHashTableTakeSnapShot);
            }
        }

        internal static event Delegates.DoHashTableTakeSnapShot_BeforeArgs _beforeDoHashTableTakeSnapShot;
        internal static event Delegates.DoHashTableTakeSnapShot_AfterArgs _afterDoHashTableTakeSnapShot;

        private static void DoHashTableTakeSnapShot(Action<HashTableTakeSnapShot> orig, HashTableTakeSnapShot self)
        {
            Delegates.Params_DoHashTableTakeSnapShot @params = new()
            {
                self = self
            };
            if (_beforeDoHashTableTakeSnapShot != null)
                foreach (Delegates.DoHashTableTakeSnapShot_BeforeArgs toInvoke in _beforeDoHashTableTakeSnapShot
                             .GetInvocationList())
                    try
                    {
                        _beforeDoHashTableTakeSnapShot?.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }

            self = @params.self;
            orig(self);
            if (_afterDoHashTableTakeSnapShot != null)
                foreach (Delegates.DoHashTableTakeSnapShot_AfterArgs toInvoke in _afterDoHashTableTakeSnapShot
                             .GetInvocationList())
                    try
                    {
                        _afterDoHashTableTakeSnapShot.Invoke(@params);
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
        public delegate void DoHashTableTakeSnapShot_AfterArgs(Params_DoHashTableTakeSnapShot args);

        public delegate void DoHashTableTakeSnapShot_BeforeArgs(Params_DoHashTableTakeSnapShot args);

        public delegate void DoHashTableTakeSnapShot_WithArgs(Action<HashTableTakeSnapShot> orig,
            HashTableTakeSnapShot self);

        public delegate void OnEnter_AfterArgs(Params_OnEnter args);

        public delegate void OnEnter_BeforeArgs(Params_OnEnter args);

        public delegate void OnEnter_WithArgs(Action<HashTableTakeSnapShot> orig, HashTableTakeSnapShot self);

        public delegate void Reset_AfterArgs(Params_Reset args);

        public delegate void Reset_BeforeArgs(Params_Reset args);

        public delegate void Reset_WithArgs(Action<HashTableTakeSnapShot> orig, HashTableTakeSnapShot self);

        public sealed class Params_Reset
        {
            public HashTableTakeSnapShot self;
        }

        public sealed class Params_OnEnter
        {
            public HashTableTakeSnapShot self;
        }

        public sealed class Params_DoHashTableTakeSnapShot
        {
            public HashTableTakeSnapShot self;
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

        public static event Delegates.DoHashTableTakeSnapShot_BeforeArgs DoHashTableTakeSnapShot
        {
            add
            {
                HookHandler._beforeDoHashTableTakeSnapShot += value;
                HookHandler.HookDoHashTableTakeSnapShot();
            }
            remove => HookHandler._beforeDoHashTableTakeSnapShot -= value;
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

        public static event Delegates.DoHashTableTakeSnapShot_AfterArgs DoHashTableTakeSnapShot
        {
            add
            {
                HookHandler._afterDoHashTableTakeSnapShot += value;
                HookHandler.HookDoHashTableTakeSnapShot();
            }
            remove => HookHandler._afterDoHashTableTakeSnapShot -= value;
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
                ReflectionHelper.GetMethodInfo(typeof(HashTableTakeSnapShot), "Reset"), value);
            remove => HookEndpointManager.Remove<Delegates.Reset_WithArgs>(
                ReflectionHelper.GetMethodInfo(typeof(HashTableTakeSnapShot), "Reset"), value);
        }

        public static event Delegates.OnEnter_WithArgs OnEnter
        {
            add => HookEndpointManager.Add<Delegates.OnEnter_WithArgs>(
                ReflectionHelper.GetMethodInfo(typeof(HashTableTakeSnapShot), "OnEnter"), value);
            remove => HookEndpointManager.Remove<Delegates.OnEnter_WithArgs>(
                ReflectionHelper.GetMethodInfo(typeof(HashTableTakeSnapShot), "OnEnter"), value);
        }

        public static event Delegates.DoHashTableTakeSnapShot_WithArgs DoHashTableTakeSnapShot
        {
            add => HookEndpointManager.Add<Delegates.DoHashTableTakeSnapShot_WithArgs>(
                ReflectionHelper.GetMethodInfo(typeof(HashTableTakeSnapShot), "DoHashTableTakeSnapShot"), value);
            remove => HookEndpointManager.Remove<Delegates.DoHashTableTakeSnapShot_WithArgs>(
                ReflectionHelper.GetMethodInfo(typeof(HashTableTakeSnapShot), "DoHashTableTakeSnapShot"), value);
        }
    }
}