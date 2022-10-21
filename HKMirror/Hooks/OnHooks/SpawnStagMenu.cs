using MonoMod.RuntimeDetour;
using MonoMod.RuntimeDetour.HookGen;

namespace HKMirror.Hooks.OnHooks;

/// <summary>
/// Contains different types of On Hooks for SpawnStagMenu class.<br />
/// Contains hooks that aren't generated by monomod, and before and after orig hooks for easier hooking.
/// </summary>
public static class OnSpawnStagMenu
{
    internal static class HookHandler
    {
        private static List<string> HookedList = new List<string>();

        internal static void HookStart()
        {
            if (!HookedList.Contains("Start"))
            {
                HookedList.Add("Start");
                On.SpawnStagMenu.Start += Start;
            }
        }

        internal static event Delegates.Start_BeforeArgs _beforeStart;
        internal static event Delegates.Start_AfterArgs _afterStart;

        private static void Start(On.SpawnStagMenu.orig_Start orig, SpawnStagMenu self)
        {
            Delegates.Params_Start @params = new()
            {
                self = self
            };
            if (_beforeStart != null)
            {
                foreach (Delegates.Start_BeforeArgs toInvoke in _beforeStart.GetInvocationList())
                {
                    try
                    {
                        _beforeStart?.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }
                }
            }

            self = @params.self;
            orig(self);
            if (_afterStart != null)
            {
                foreach (Delegates.Start_AfterArgs toInvoke in _afterStart.GetInvocationList())
                {
                    try
                    {
                        _afterStart.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }
                }
            }
        }

        internal static void HookSendEvent()
        {
            if (!HookedList.Contains("SendEvent"))
            {
                HookedList.Add("SendEvent");
                On.SpawnStagMenu.SendEvent += SendEvent;
            }
        }

        internal static event Delegates.SendEvent_BeforeArgs _beforeSendEvent;
        internal static event Delegates.SendEvent_AfterArgs _afterSendEvent;

        private static void SendEvent(On.SpawnStagMenu.orig_SendEvent orig, SpawnStagMenu self)
        {
            Delegates.Params_SendEvent @params = new()
            {
                self = self
            };
            if (_beforeSendEvent != null)
            {
                foreach (Delegates.SendEvent_BeforeArgs toInvoke in _beforeSendEvent.GetInvocationList())
                {
                    try
                    {
                        _beforeSendEvent?.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }
                }
            }

            self = @params.self;
            orig(self);
            if (_afterSendEvent != null)
            {
                foreach (Delegates.SendEvent_AfterArgs toInvoke in _afterSendEvent.GetInvocationList())
                {
                    try
                    {
                        _afterSendEvent.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }
                }
            }
        }

        internal static void HookOnDestroy()
        {
            if (!HookedList.Contains("OnDestroy"))
            {
                HookedList.Add("OnDestroy");
                On.SpawnStagMenu.OnDestroy += OnDestroy;
            }
        }

        internal static event Delegates.OnDestroy_BeforeArgs _beforeOnDestroy;
        internal static event Delegates.OnDestroy_AfterArgs _afterOnDestroy;

        private static void OnDestroy(On.SpawnStagMenu.orig_OnDestroy orig, SpawnStagMenu self)
        {
            Delegates.Params_OnDestroy @params = new()
            {
                self = self
            };
            if (_beforeOnDestroy != null)
            {
                foreach (Delegates.OnDestroy_BeforeArgs toInvoke in _beforeOnDestroy.GetInvocationList())
                {
                    try
                    {
                        _beforeOnDestroy?.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }
                }
            }

            self = @params.self;
            orig(self);
            if (_afterOnDestroy != null)
            {
                foreach (Delegates.OnDestroy_AfterArgs toInvoke in _afterOnDestroy.GetInvocationList())
                {
                    try
                    {
                        _afterOnDestroy.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }
                }
            }
        }
    }

    /// <summary>
    /// Contains necessary information to create Hooks. Does not contain any hooks
    /// </summary>
    public static class Delegates
    {
        public sealed class Params_Start
        {
            public SpawnStagMenu self;
        }

        public delegate void Start_BeforeArgs(Params_Start args);

        public delegate void Start_AfterArgs(Params_Start args);

        public delegate void Start_WithArgs(Action<SpawnStagMenu> orig, SpawnStagMenu self);

        public sealed class Params_SendEvent
        {
            public SpawnStagMenu self;
        }

        public delegate void SendEvent_BeforeArgs(Params_SendEvent args);

        public delegate void SendEvent_AfterArgs(Params_SendEvent args);

        public delegate void SendEvent_WithArgs(Action<SpawnStagMenu> orig, SpawnStagMenu self);

        public sealed class Params_OnDestroy
        {
            public SpawnStagMenu self;
        }

        public delegate void OnDestroy_BeforeArgs(Params_OnDestroy args);

        public delegate void OnDestroy_AfterArgs(Params_OnDestroy args);

        public delegate void OnDestroy_WithArgs(Action<SpawnStagMenu> orig, SpawnStagMenu self);
    }

    /// <summary>
    /// Contains Hooks to that run code before orig(self) is called
    /// </summary>
    public static class BeforeOrig
    {
        public static event Delegates.Start_BeforeArgs Start
        {
            add
            {
                HookHandler._beforeStart += value;
                HookHandler.HookStart();
            }
            remove => HookHandler._beforeStart -= value;
        }

        public static event Delegates.SendEvent_BeforeArgs SendEvent
        {
            add
            {
                HookHandler._beforeSendEvent += value;
                HookHandler.HookSendEvent();
            }
            remove => HookHandler._beforeSendEvent -= value;
        }

        public static event Delegates.OnDestroy_BeforeArgs OnDestroy
        {
            add
            {
                HookHandler._beforeOnDestroy += value;
                HookHandler.HookOnDestroy();
            }
            remove => HookHandler._beforeOnDestroy -= value;
        }
    }

    /// <summary>
    /// Contains Hooks to that run code after orig(self) is called
    /// </summary>
    public static class AfterOrig
    {
        public static event Delegates.Start_AfterArgs Start
        {
            add
            {
                HookHandler._afterStart += value;
                HookHandler.HookStart();
            }
            remove => HookHandler._afterStart -= value;
        }

        public static event Delegates.SendEvent_AfterArgs SendEvent
        {
            add
            {
                HookHandler._afterSendEvent += value;
                HookHandler.HookSendEvent();
            }
            remove => HookHandler._afterSendEvent -= value;
        }

        public static event Delegates.OnDestroy_AfterArgs OnDestroy
        {
            add
            {
                HookHandler._afterOnDestroy += value;
                HookHandler.HookOnDestroy();
            }
            remove => HookHandler._afterOnDestroy -= value;
        }
    }

    /// <summary>
    /// Contains all On Hooks, even those that aren't in the On namespace such as API generated functions and property getters/setters
    /// </summary>
    public static class WithOrig
    {
        public static event On.SpawnStagMenu.hook_Start Start
        {
            add => On.SpawnStagMenu.Start += value;
            remove => On.SpawnStagMenu.Start -= value;
        }

        public static event On.SpawnStagMenu.hook_SendEvent SendEvent
        {
            add => On.SpawnStagMenu.SendEvent += value;
            remove => On.SpawnStagMenu.SendEvent -= value;
        }

        public static event On.SpawnStagMenu.hook_OnDestroy OnDestroy
        {
            add => On.SpawnStagMenu.OnDestroy += value;
            remove => On.SpawnStagMenu.OnDestroy -= value;
        }
    }
}