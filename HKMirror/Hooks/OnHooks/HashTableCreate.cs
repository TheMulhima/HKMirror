using MonoMod.RuntimeDetour;
using MonoMod.RuntimeDetour.HookGen;

namespace HKMirror.Hooks.OnHooks;

/// <summary>
///     Contains different types of On Hooks for HashTableCreate class.<br />
///     Contains hooks that aren't generated by monomod, and before and after orig hooks for easier hooking.
/// </summary>
public static class OnHashTableCreate
{
    internal static class HookHandler
    {
        private static readonly List<string> HookedList = new();

        internal static void HookReset()
        {
            if (!HookedList.Contains("Reset"))
            {
                HookedList.Add("Reset");
                new Hook(ReflectionHelper.GetMethodInfo(typeof(HashTableCreate), "Reset"), Reset);
            }
        }

        internal static event Delegates.Reset_BeforeArgs _beforeReset;
        internal static event Delegates.Reset_AfterArgs _afterReset;

        private static void Reset(Action<HashTableCreate> orig, HashTableCreate self)
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
                new Hook(ReflectionHelper.GetMethodInfo(typeof(HashTableCreate), "OnEnter"), OnEnter);
            }
        }

        internal static event Delegates.OnEnter_BeforeArgs _beforeOnEnter;
        internal static event Delegates.OnEnter_AfterArgs _afterOnEnter;

        private static void OnEnter(Action<HashTableCreate> orig, HashTableCreate self)
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

        internal static void HookOnExit()
        {
            if (!HookedList.Contains("OnExit"))
            {
                HookedList.Add("OnExit");
                new Hook(ReflectionHelper.GetMethodInfo(typeof(HashTableCreate), "OnExit"), OnExit);
            }
        }

        internal static event Delegates.OnExit_BeforeArgs _beforeOnExit;
        internal static event Delegates.OnExit_AfterArgs _afterOnExit;

        private static void OnExit(Action<HashTableCreate> orig, HashTableCreate self)
        {
            Delegates.Params_OnExit @params = new()
            {
                self = self
            };
            if (_beforeOnExit != null)
                foreach (Delegates.OnExit_BeforeArgs toInvoke in _beforeOnExit.GetInvocationList())
                    try
                    {
                        _beforeOnExit?.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }

            self = @params.self;
            orig(self);
            if (_afterOnExit != null)
                foreach (Delegates.OnExit_AfterArgs toInvoke in _afterOnExit.GetInvocationList())
                    try
                    {
                        _afterOnExit.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }
        }

        internal static void HookDoAddPlayMakerHashTable()
        {
            if (!HookedList.Contains("DoAddPlayMakerHashTable"))
            {
                HookedList.Add("DoAddPlayMakerHashTable");
                new Hook(ReflectionHelper.GetMethodInfo(typeof(HashTableCreate), "DoAddPlayMakerHashTable"),
                    DoAddPlayMakerHashTable);
            }
        }

        internal static event Delegates.DoAddPlayMakerHashTable_BeforeArgs _beforeDoAddPlayMakerHashTable;
        internal static event Delegates.DoAddPlayMakerHashTable_AfterArgs _afterDoAddPlayMakerHashTable;

        private static void DoAddPlayMakerHashTable(Action<HashTableCreate> orig, HashTableCreate self)
        {
            Delegates.Params_DoAddPlayMakerHashTable @params = new()
            {
                self = self
            };
            if (_beforeDoAddPlayMakerHashTable != null)
                foreach (Delegates.DoAddPlayMakerHashTable_BeforeArgs toInvoke in _beforeDoAddPlayMakerHashTable
                             .GetInvocationList())
                    try
                    {
                        _beforeDoAddPlayMakerHashTable?.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }

            self = @params.self;
            orig(self);
            if (_afterDoAddPlayMakerHashTable != null)
                foreach (Delegates.DoAddPlayMakerHashTable_AfterArgs toInvoke in _afterDoAddPlayMakerHashTable
                             .GetInvocationList())
                    try
                    {
                        _afterDoAddPlayMakerHashTable.Invoke(@params);
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
        public delegate void DoAddPlayMakerHashTable_AfterArgs(Params_DoAddPlayMakerHashTable args);

        public delegate void DoAddPlayMakerHashTable_BeforeArgs(Params_DoAddPlayMakerHashTable args);

        public delegate void DoAddPlayMakerHashTable_WithArgs(Action<HashTableCreate> orig, HashTableCreate self);

        public delegate void OnEnter_AfterArgs(Params_OnEnter args);

        public delegate void OnEnter_BeforeArgs(Params_OnEnter args);

        public delegate void OnEnter_WithArgs(Action<HashTableCreate> orig, HashTableCreate self);

        public delegate void OnExit_AfterArgs(Params_OnExit args);

        public delegate void OnExit_BeforeArgs(Params_OnExit args);

        public delegate void OnExit_WithArgs(Action<HashTableCreate> orig, HashTableCreate self);

        public delegate void Reset_AfterArgs(Params_Reset args);

        public delegate void Reset_BeforeArgs(Params_Reset args);

        public delegate void Reset_WithArgs(Action<HashTableCreate> orig, HashTableCreate self);

        public sealed class Params_Reset
        {
            public HashTableCreate self;
        }

        public sealed class Params_OnEnter
        {
            public HashTableCreate self;
        }

        public sealed class Params_OnExit
        {
            public HashTableCreate self;
        }

        public sealed class Params_DoAddPlayMakerHashTable
        {
            public HashTableCreate self;
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

        public static event Delegates.OnExit_BeforeArgs OnExit
        {
            add
            {
                HookHandler._beforeOnExit += value;
                HookHandler.HookOnExit();
            }
            remove => HookHandler._beforeOnExit -= value;
        }

        public static event Delegates.DoAddPlayMakerHashTable_BeforeArgs DoAddPlayMakerHashTable
        {
            add
            {
                HookHandler._beforeDoAddPlayMakerHashTable += value;
                HookHandler.HookDoAddPlayMakerHashTable();
            }
            remove => HookHandler._beforeDoAddPlayMakerHashTable -= value;
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

        public static event Delegates.OnExit_AfterArgs OnExit
        {
            add
            {
                HookHandler._afterOnExit += value;
                HookHandler.HookOnExit();
            }
            remove => HookHandler._afterOnExit -= value;
        }

        public static event Delegates.DoAddPlayMakerHashTable_AfterArgs DoAddPlayMakerHashTable
        {
            add
            {
                HookHandler._afterDoAddPlayMakerHashTable += value;
                HookHandler.HookDoAddPlayMakerHashTable();
            }
            remove => HookHandler._afterDoAddPlayMakerHashTable -= value;
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
                ReflectionHelper.GetMethodInfo(typeof(HashTableCreate), "Reset"), value);
            remove => HookEndpointManager.Remove<Delegates.Reset_WithArgs>(
                ReflectionHelper.GetMethodInfo(typeof(HashTableCreate), "Reset"), value);
        }

        public static event Delegates.OnEnter_WithArgs OnEnter
        {
            add => HookEndpointManager.Add<Delegates.OnEnter_WithArgs>(
                ReflectionHelper.GetMethodInfo(typeof(HashTableCreate), "OnEnter"), value);
            remove => HookEndpointManager.Remove<Delegates.OnEnter_WithArgs>(
                ReflectionHelper.GetMethodInfo(typeof(HashTableCreate), "OnEnter"), value);
        }

        public static event Delegates.OnExit_WithArgs OnExit
        {
            add => HookEndpointManager.Add<Delegates.OnExit_WithArgs>(
                ReflectionHelper.GetMethodInfo(typeof(HashTableCreate), "OnExit"), value);
            remove => HookEndpointManager.Remove<Delegates.OnExit_WithArgs>(
                ReflectionHelper.GetMethodInfo(typeof(HashTableCreate), "OnExit"), value);
        }

        public static event Delegates.DoAddPlayMakerHashTable_WithArgs DoAddPlayMakerHashTable
        {
            add => HookEndpointManager.Add<Delegates.DoAddPlayMakerHashTable_WithArgs>(
                ReflectionHelper.GetMethodInfo(typeof(HashTableCreate), "DoAddPlayMakerHashTable"), value);
            remove => HookEndpointManager.Remove<Delegates.DoAddPlayMakerHashTable_WithArgs>(
                ReflectionHelper.GetMethodInfo(typeof(HashTableCreate), "DoAddPlayMakerHashTable"), value);
        }
    }
}