using MonoMod.RuntimeDetour;
using MonoMod.RuntimeDetour.HookGen;

namespace HKMirror.Hooks.OnHooks;

/// <summary>
///     Contains different types of On Hooks for InControlManager class.<br />
///     Contains hooks that aren't generated by monomod, and before and after orig hooks for easier hooking.
/// </summary>
public static class OnInControlManager
{
    internal static class HookHandler
    {
        private static readonly List<string> HookedList = new();

        internal static void HookOnEnable()
        {
            if (!HookedList.Contains("OnEnable"))
            {
                HookedList.Add("OnEnable");
                new Hook(ReflectionHelper.GetMethodInfo(typeof(InControlManager), "OnEnable"), OnEnable);
            }
        }

        internal static event Delegates.OnEnable_BeforeArgs _beforeOnEnable;
        internal static event Delegates.OnEnable_NormalArgs _afterOnEnable;

        private static void OnEnable(Action<InControlManager> orig, InControlManager self)
        {
            Delegates.Params_OnEnable @params = new()
            {
                self = self
            };
            _beforeOnEnable?.Invoke(@params);
            self = @params.self;
            orig(self);
            if (_afterOnEnable != null) _afterOnEnable.Invoke(@params);
        }

        internal static void HookOnDisable()
        {
            if (!HookedList.Contains("OnDisable"))
            {
                HookedList.Add("OnDisable");
                new Hook(ReflectionHelper.GetMethodInfo(typeof(InControlManager), "OnDisable"), OnDisable);
            }
        }

        internal static event Delegates.OnDisable_BeforeArgs _beforeOnDisable;
        internal static event Delegates.OnDisable_NormalArgs _afterOnDisable;

        private static void OnDisable(Action<InControlManager> orig, InControlManager self)
        {
            Delegates.Params_OnDisable @params = new()
            {
                self = self
            };
            _beforeOnDisable?.Invoke(@params);
            self = @params.self;
            orig(self);
            if (_afterOnDisable != null) _afterOnDisable.Invoke(@params);
        }

        internal static void HookUpdate()
        {
            if (!HookedList.Contains("Update"))
            {
                HookedList.Add("Update");
                new Hook(ReflectionHelper.GetMethodInfo(typeof(InControlManager), "Update"), Update);
            }
        }

        internal static event Delegates.Update_BeforeArgs _beforeUpdate;
        internal static event Delegates.Update_NormalArgs _afterUpdate;

        private static void Update(Action<InControlManager> orig, InControlManager self)
        {
            Delegates.Params_Update @params = new()
            {
                self = self
            };
            _beforeUpdate?.Invoke(@params);
            self = @params.self;
            orig(self);
            if (_afterUpdate != null) _afterUpdate.Invoke(@params);
        }

        internal static void HookFixedUpdate()
        {
            if (!HookedList.Contains("FixedUpdate"))
            {
                HookedList.Add("FixedUpdate");
                new Hook(ReflectionHelper.GetMethodInfo(typeof(InControlManager), "FixedUpdate"), FixedUpdate);
            }
        }

        internal static event Delegates.FixedUpdate_BeforeArgs _beforeFixedUpdate;
        internal static event Delegates.FixedUpdate_NormalArgs _afterFixedUpdate;

        private static void FixedUpdate(Action<InControlManager> orig, InControlManager self)
        {
            Delegates.Params_FixedUpdate @params = new()
            {
                self = self
            };
            _beforeFixedUpdate?.Invoke(@params);
            self = @params.self;
            orig(self);
            if (_afterFixedUpdate != null) _afterFixedUpdate.Invoke(@params);
        }

        internal static void HookOnApplicationFocus()
        {
            if (!HookedList.Contains("OnApplicationFocus"))
            {
                HookedList.Add("OnApplicationFocus");
                new Hook(ReflectionHelper.GetMethodInfo(typeof(InControlManager), "OnApplicationFocus"),
                    OnApplicationFocus);
            }
        }

        internal static event Delegates.OnApplicationFocus_BeforeArgs _beforeOnApplicationFocus;
        internal static event Delegates.OnApplicationFocus_NormalArgs _afterOnApplicationFocus;

        private static void OnApplicationFocus(Action<InControlManager, bool> orig, InControlManager self,
            bool focusState)
        {
            Delegates.Params_OnApplicationFocus @params = new()
            {
                self = self, focusState = focusState
            };
            _beforeOnApplicationFocus?.Invoke(@params);
            self = @params.self;
            focusState = @params.focusState;
            orig(self, focusState);
            if (_afterOnApplicationFocus != null) _afterOnApplicationFocus.Invoke(@params);
        }

        internal static void HookOnApplicationPause()
        {
            if (!HookedList.Contains("OnApplicationPause"))
            {
                HookedList.Add("OnApplicationPause");
                new Hook(ReflectionHelper.GetMethodInfo(typeof(InControlManager), "OnApplicationPause"),
                    OnApplicationPause);
            }
        }

        internal static event Delegates.OnApplicationPause_BeforeArgs _beforeOnApplicationPause;
        internal static event Delegates.OnApplicationPause_NormalArgs _afterOnApplicationPause;

        private static void OnApplicationPause(Action<InControlManager, bool> orig, InControlManager self,
            bool pauseState)
        {
            Delegates.Params_OnApplicationPause @params = new()
            {
                self = self, pauseState = pauseState
            };
            _beforeOnApplicationPause?.Invoke(@params);
            self = @params.self;
            pauseState = @params.pauseState;
            orig(self, pauseState);
            if (_afterOnApplicationPause != null) _afterOnApplicationPause.Invoke(@params);
        }

        internal static void HookOnApplicationQuit()
        {
            if (!HookedList.Contains("OnApplicationQuit"))
            {
                HookedList.Add("OnApplicationQuit");
                new Hook(ReflectionHelper.GetMethodInfo(typeof(InControlManager), "OnApplicationQuit"),
                    OnApplicationQuit);
            }
        }

        internal static event Delegates.OnApplicationQuit_BeforeArgs _beforeOnApplicationQuit;
        internal static event Delegates.OnApplicationQuit_NormalArgs _afterOnApplicationQuit;

        private static void OnApplicationQuit(Action<InControlManager> orig, InControlManager self)
        {
            Delegates.Params_OnApplicationQuit @params = new()
            {
                self = self
            };
            _beforeOnApplicationQuit?.Invoke(@params);
            self = @params.self;
            orig(self);
            if (_afterOnApplicationQuit != null) _afterOnApplicationQuit.Invoke(@params);
        }

        internal static void HookOnSceneWasLoaded()
        {
            if (!HookedList.Contains("OnSceneWasLoaded"))
            {
                HookedList.Add("OnSceneWasLoaded");
                new Hook(ReflectionHelper.GetMethodInfo(typeof(InControlManager), "OnSceneWasLoaded"),
                    OnSceneWasLoaded);
            }
        }

        internal static event Delegates.OnSceneWasLoaded_BeforeArgs _beforeOnSceneWasLoaded;
        internal static event Delegates.OnSceneWasLoaded_NormalArgs _afterOnSceneWasLoaded;

        private static void OnSceneWasLoaded(Action<InControlManager, Scene, LoadSceneMode> orig, InControlManager self,
            Scene scene, LoadSceneMode loadSceneMode)
        {
            Delegates.Params_OnSceneWasLoaded @params = new()
            {
                self = self, scene = scene, loadSceneMode = loadSceneMode
            };
            _beforeOnSceneWasLoaded?.Invoke(@params);
            self = @params.self;
            scene = @params.scene;
            loadSceneMode = @params.loadSceneMode;
            orig(self, scene, loadSceneMode);
            if (_afterOnSceneWasLoaded != null) _afterOnSceneWasLoaded.Invoke(@params);
        }

        internal static void HookLogMessage()
        {
            if (!HookedList.Contains("LogMessage"))
            {
                HookedList.Add("LogMessage");
                new Hook(ReflectionHelper.GetMethodInfo(typeof(InControlManager), "LogMessage", false), LogMessage);
            }
        }

        internal static event Delegates.LogMessage_BeforeArgs _beforeLogMessage;
        internal static event Delegates.LogMessage_NormalArgs _afterLogMessage;

        private static void LogMessage(Action<LogMessage> orig, LogMessage logMessage)
        {
            Delegates.Params_LogMessage @params = new()
            {
                logMessage = logMessage
            };
            _beforeLogMessage?.Invoke(@params);
            logMessage = @params.logMessage;
            orig(logMessage);
            if (_afterLogMessage != null) _afterLogMessage.Invoke(@params);
        }
    }

    /// <summary>
    ///     Contains necessary information to create Hooks. Does not contain any hooks
    /// </summary>
    public static class Delegates
    {
        public delegate void FixedUpdate_BeforeArgs(Params_FixedUpdate args);

        public delegate void FixedUpdate_NormalArgs(Params_FixedUpdate args);

        public delegate void LogMessage_BeforeArgs(Params_LogMessage args);

        public delegate void LogMessage_NormalArgs(Params_LogMessage args);

        public delegate void OnApplicationFocus_BeforeArgs(Params_OnApplicationFocus args);

        public delegate void OnApplicationFocus_NormalArgs(Params_OnApplicationFocus args);

        public delegate void OnApplicationPause_BeforeArgs(Params_OnApplicationPause args);

        public delegate void OnApplicationPause_NormalArgs(Params_OnApplicationPause args);

        public delegate void OnApplicationQuit_BeforeArgs(Params_OnApplicationQuit args);

        public delegate void OnApplicationQuit_NormalArgs(Params_OnApplicationQuit args);

        public delegate void OnDisable_BeforeArgs(Params_OnDisable args);

        public delegate void OnDisable_NormalArgs(Params_OnDisable args);

        public delegate void OnEnable_BeforeArgs(Params_OnEnable args);

        public delegate void OnEnable_NormalArgs(Params_OnEnable args);

        public delegate void OnSceneWasLoaded_BeforeArgs(Params_OnSceneWasLoaded args);

        public delegate void OnSceneWasLoaded_NormalArgs(Params_OnSceneWasLoaded args);

        public delegate void Update_BeforeArgs(Params_Update args);

        public delegate void Update_NormalArgs(Params_Update args);

        public sealed class Params_OnEnable
        {
            public InControlManager self;
        }

        public sealed class Params_OnDisable
        {
            public InControlManager self;
        }

        public sealed class Params_Update
        {
            public InControlManager self;
        }

        public sealed class Params_FixedUpdate
        {
            public InControlManager self;
        }

        public sealed class Params_OnApplicationFocus
        {
            public bool focusState;
            public InControlManager self;
        }

        public sealed class Params_OnApplicationPause
        {
            public bool pauseState;
            public InControlManager self;
        }

        public sealed class Params_OnApplicationQuit
        {
            public InControlManager self;
        }

        public sealed class Params_OnSceneWasLoaded
        {
            public LoadSceneMode loadSceneMode;
            public Scene scene;
            public InControlManager self;
        }

        public sealed class Params_LogMessage
        {
            public LogMessage logMessage;
        }
    }

    /// <summary>
    ///     Contains Hooks to that run code before orig(self) is called
    /// </summary>
    public static class BeforeOrig
    {
        public static event Delegates.OnEnable_BeforeArgs OnEnable
        {
            add
            {
                HookHandler._beforeOnEnable += value;
                HookHandler.HookOnEnable();
            }
            remove => HookHandler._beforeOnEnable -= value;
        }

        public static event Delegates.OnDisable_BeforeArgs OnDisable
        {
            add
            {
                HookHandler._beforeOnDisable += value;
                HookHandler.HookOnDisable();
            }
            remove => HookHandler._beforeOnDisable -= value;
        }

        public static event Delegates.Update_BeforeArgs Update
        {
            add
            {
                HookHandler._beforeUpdate += value;
                HookHandler.HookUpdate();
            }
            remove => HookHandler._beforeUpdate -= value;
        }

        public static event Delegates.FixedUpdate_BeforeArgs FixedUpdate
        {
            add
            {
                HookHandler._beforeFixedUpdate += value;
                HookHandler.HookFixedUpdate();
            }
            remove => HookHandler._beforeFixedUpdate -= value;
        }

        public static event Delegates.OnApplicationFocus_BeforeArgs OnApplicationFocus
        {
            add
            {
                HookHandler._beforeOnApplicationFocus += value;
                HookHandler.HookOnApplicationFocus();
            }
            remove => HookHandler._beforeOnApplicationFocus -= value;
        }

        public static event Delegates.OnApplicationPause_BeforeArgs OnApplicationPause
        {
            add
            {
                HookHandler._beforeOnApplicationPause += value;
                HookHandler.HookOnApplicationPause();
            }
            remove => HookHandler._beforeOnApplicationPause -= value;
        }

        public static event Delegates.OnApplicationQuit_BeforeArgs OnApplicationQuit
        {
            add
            {
                HookHandler._beforeOnApplicationQuit += value;
                HookHandler.HookOnApplicationQuit();
            }
            remove => HookHandler._beforeOnApplicationQuit -= value;
        }

        public static event Delegates.OnSceneWasLoaded_BeforeArgs OnSceneWasLoaded
        {
            add
            {
                HookHandler._beforeOnSceneWasLoaded += value;
                HookHandler.HookOnSceneWasLoaded();
            }
            remove => HookHandler._beforeOnSceneWasLoaded -= value;
        }

        public static event Delegates.LogMessage_BeforeArgs LogMessage
        {
            add
            {
                HookHandler._beforeLogMessage += value;
                HookHandler.HookLogMessage();
            }
            remove => HookHandler._beforeLogMessage -= value;
        }
    }

    /// <summary>
    ///     Contains Hooks to that run code after orig(self) is called
    /// </summary>
    public static class AfterOrig
    {
        public static event Delegates.OnEnable_NormalArgs OnEnable
        {
            add
            {
                HookHandler._afterOnEnable += value;
                HookHandler.HookOnEnable();
            }
            remove => HookHandler._afterOnEnable -= value;
        }

        public static event Delegates.OnDisable_NormalArgs OnDisable
        {
            add
            {
                HookHandler._afterOnDisable += value;
                HookHandler.HookOnDisable();
            }
            remove => HookHandler._afterOnDisable -= value;
        }

        public static event Delegates.Update_NormalArgs Update
        {
            add
            {
                HookHandler._afterUpdate += value;
                HookHandler.HookUpdate();
            }
            remove => HookHandler._afterUpdate -= value;
        }

        public static event Delegates.FixedUpdate_NormalArgs FixedUpdate
        {
            add
            {
                HookHandler._afterFixedUpdate += value;
                HookHandler.HookFixedUpdate();
            }
            remove => HookHandler._afterFixedUpdate -= value;
        }

        public static event Delegates.OnApplicationFocus_NormalArgs OnApplicationFocus
        {
            add
            {
                HookHandler._afterOnApplicationFocus += value;
                HookHandler.HookOnApplicationFocus();
            }
            remove => HookHandler._afterOnApplicationFocus -= value;
        }

        public static event Delegates.OnApplicationPause_NormalArgs OnApplicationPause
        {
            add
            {
                HookHandler._afterOnApplicationPause += value;
                HookHandler.HookOnApplicationPause();
            }
            remove => HookHandler._afterOnApplicationPause -= value;
        }

        public static event Delegates.OnApplicationQuit_NormalArgs OnApplicationQuit
        {
            add
            {
                HookHandler._afterOnApplicationQuit += value;
                HookHandler.HookOnApplicationQuit();
            }
            remove => HookHandler._afterOnApplicationQuit -= value;
        }

        public static event Delegates.OnSceneWasLoaded_NormalArgs OnSceneWasLoaded
        {
            add
            {
                HookHandler._afterOnSceneWasLoaded += value;
                HookHandler.HookOnSceneWasLoaded();
            }
            remove => HookHandler._afterOnSceneWasLoaded -= value;
        }

        public static event Delegates.LogMessage_NormalArgs LogMessage
        {
            add
            {
                HookHandler._afterLogMessage += value;
                HookHandler.HookLogMessage();
            }
            remove => HookHandler._afterLogMessage -= value;
        }
    }

    /// <summary>
    ///     Contains all On Hooks, even those that aren't in the On namespace such as API generated functions and property
    ///     getters/setters
    /// </summary>
    public static class WithOrig
    {
        public static event Delegates.OnEnable_NormalArgs OnEnable
        {
            add => HookEndpointManager.Add<Delegates.OnEnable_NormalArgs>(
                ReflectionHelper.GetMethodInfo(typeof(InControlManager), "OnEnable"), value);
            remove => HookEndpointManager.Remove<Delegates.OnEnable_NormalArgs>(
                ReflectionHelper.GetMethodInfo(typeof(InControlManager), "OnEnable"), value);
        }

        public static event Delegates.OnDisable_NormalArgs OnDisable
        {
            add => HookEndpointManager.Add<Delegates.OnDisable_NormalArgs>(
                ReflectionHelper.GetMethodInfo(typeof(InControlManager), "OnDisable"), value);
            remove => HookEndpointManager.Remove<Delegates.OnDisable_NormalArgs>(
                ReflectionHelper.GetMethodInfo(typeof(InControlManager), "OnDisable"), value);
        }

        public static event Delegates.Update_NormalArgs Update
        {
            add => HookEndpointManager.Add<Delegates.Update_NormalArgs>(
                ReflectionHelper.GetMethodInfo(typeof(InControlManager), "Update"), value);
            remove => HookEndpointManager.Remove<Delegates.Update_NormalArgs>(
                ReflectionHelper.GetMethodInfo(typeof(InControlManager), "Update"), value);
        }

        public static event Delegates.FixedUpdate_NormalArgs FixedUpdate
        {
            add => HookEndpointManager.Add<Delegates.FixedUpdate_NormalArgs>(
                ReflectionHelper.GetMethodInfo(typeof(InControlManager), "FixedUpdate"), value);
            remove => HookEndpointManager.Remove<Delegates.FixedUpdate_NormalArgs>(
                ReflectionHelper.GetMethodInfo(typeof(InControlManager), "FixedUpdate"), value);
        }

        public static event Delegates.OnApplicationFocus_NormalArgs OnApplicationFocus
        {
            add => HookEndpointManager.Add<Delegates.OnApplicationFocus_NormalArgs>(
                ReflectionHelper.GetMethodInfo(typeof(InControlManager), "OnApplicationFocus"), value);
            remove => HookEndpointManager.Remove<Delegates.OnApplicationFocus_NormalArgs>(
                ReflectionHelper.GetMethodInfo(typeof(InControlManager), "OnApplicationFocus"), value);
        }

        public static event Delegates.OnApplicationPause_NormalArgs OnApplicationPause
        {
            add => HookEndpointManager.Add<Delegates.OnApplicationPause_NormalArgs>(
                ReflectionHelper.GetMethodInfo(typeof(InControlManager), "OnApplicationPause"), value);
            remove => HookEndpointManager.Remove<Delegates.OnApplicationPause_NormalArgs>(
                ReflectionHelper.GetMethodInfo(typeof(InControlManager), "OnApplicationPause"), value);
        }

        public static event Delegates.OnApplicationQuit_NormalArgs OnApplicationQuit
        {
            add => HookEndpointManager.Add<Delegates.OnApplicationQuit_NormalArgs>(
                ReflectionHelper.GetMethodInfo(typeof(InControlManager), "OnApplicationQuit"), value);
            remove => HookEndpointManager.Remove<Delegates.OnApplicationQuit_NormalArgs>(
                ReflectionHelper.GetMethodInfo(typeof(InControlManager), "OnApplicationQuit"), value);
        }

        public static event Delegates.OnSceneWasLoaded_NormalArgs OnSceneWasLoaded
        {
            add => HookEndpointManager.Add<Delegates.OnSceneWasLoaded_NormalArgs>(
                ReflectionHelper.GetMethodInfo(typeof(InControlManager), "OnSceneWasLoaded"), value);
            remove => HookEndpointManager.Remove<Delegates.OnSceneWasLoaded_NormalArgs>(
                ReflectionHelper.GetMethodInfo(typeof(InControlManager), "OnSceneWasLoaded"), value);
        }

        public static event Delegates.LogMessage_NormalArgs LogMessage
        {
            add => HookEndpointManager.Add<Delegates.LogMessage_NormalArgs>(
                ReflectionHelper.GetMethodInfo(typeof(InControlManager), "LogMessage", false), value);
            remove => HookEndpointManager.Remove<Delegates.LogMessage_NormalArgs>(
                ReflectionHelper.GetMethodInfo(typeof(InControlManager), "LogMessage", false), value);
        }
    }
}