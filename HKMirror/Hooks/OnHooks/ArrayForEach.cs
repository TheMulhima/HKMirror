using MonoMod.RuntimeDetour;
using MonoMod.RuntimeDetour.HookGen;

namespace HKMirror.Hooks.OnHooks;

/// <summary>
///     Contains different types of On Hooks for ArrayForEach class.<br />
///     Contains hooks that aren't generated by monomod, and before and after orig hooks for easier hooking.
/// </summary>
public static class OnArrayForEach
{
    internal static class HookHandler
    {
        private static readonly List<string> HookedList = new();

        internal static void HookReset()
        {
            if (!HookedList.Contains("Reset"))
            {
                HookedList.Add("Reset");
                new Hook(ReflectionHelper.GetMethodInfo(typeof(ArrayForEach), "Reset"), Reset);
            }
        }

        internal static event Delegates.Reset_BeforeArgs _beforeReset;
        internal static event Delegates.Reset_NormalArgs _afterReset;

        private static void Reset(Action<ArrayForEach> orig, ArrayForEach self)
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

        internal static void HookAwake()
        {
            if (!HookedList.Contains("Awake"))
            {
                HookedList.Add("Awake");
                new Hook(ReflectionHelper.GetMethodInfo(typeof(ArrayForEach), "Awake"), Awake);
            }
        }

        internal static event Delegates.Awake_BeforeArgs _beforeAwake;
        internal static event Delegates.Awake_NormalArgs _afterAwake;

        private static void Awake(Action<ArrayForEach> orig, ArrayForEach self)
        {
            Delegates.Params_Awake @params = new()
            {
                self = self
            };
            _beforeAwake?.Invoke(@params);
            self = @params.self;
            orig(self);
            if (_afterAwake != null) _afterAwake.Invoke(@params);
        }

        internal static void HookOnPreprocess()
        {
            if (!HookedList.Contains("OnPreprocess"))
            {
                HookedList.Add("OnPreprocess");
                new Hook(ReflectionHelper.GetMethodInfo(typeof(ArrayForEach), "OnPreprocess"), OnPreprocess);
            }
        }

        internal static event Delegates.OnPreprocess_BeforeArgs _beforeOnPreprocess;
        internal static event Delegates.OnPreprocess_NormalArgs _afterOnPreprocess;

        private static void OnPreprocess(Action<ArrayForEach> orig, ArrayForEach self)
        {
            Delegates.Params_OnPreprocess @params = new()
            {
                self = self
            };
            _beforeOnPreprocess?.Invoke(@params);
            self = @params.self;
            orig(self);
            if (_afterOnPreprocess != null) _afterOnPreprocess.Invoke(@params);
        }

        internal static void HookOnEnter()
        {
            if (!HookedList.Contains("OnEnter"))
            {
                HookedList.Add("OnEnter");
                new Hook(ReflectionHelper.GetMethodInfo(typeof(ArrayForEach), "OnEnter"), OnEnter);
            }
        }

        internal static event Delegates.OnEnter_BeforeArgs _beforeOnEnter;
        internal static event Delegates.OnEnter_NormalArgs _afterOnEnter;

        private static void OnEnter(Action<ArrayForEach> orig, ArrayForEach self)
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

        internal static void HookOnUpdate()
        {
            if (!HookedList.Contains("OnUpdate"))
            {
                HookedList.Add("OnUpdate");
                new Hook(ReflectionHelper.GetMethodInfo(typeof(ArrayForEach), "OnUpdate"), OnUpdate);
            }
        }

        internal static event Delegates.OnUpdate_BeforeArgs _beforeOnUpdate;
        internal static event Delegates.OnUpdate_NormalArgs _afterOnUpdate;

        private static void OnUpdate(Action<ArrayForEach> orig, ArrayForEach self)
        {
            Delegates.Params_OnUpdate @params = new()
            {
                self = self
            };
            _beforeOnUpdate?.Invoke(@params);
            self = @params.self;
            orig(self);
            if (_afterOnUpdate != null) _afterOnUpdate.Invoke(@params);
        }

        internal static void HookOnFixedUpdate()
        {
            if (!HookedList.Contains("OnFixedUpdate"))
            {
                HookedList.Add("OnFixedUpdate");
                new Hook(ReflectionHelper.GetMethodInfo(typeof(ArrayForEach), "OnFixedUpdate"), OnFixedUpdate);
            }
        }

        internal static event Delegates.OnFixedUpdate_BeforeArgs _beforeOnFixedUpdate;
        internal static event Delegates.OnFixedUpdate_NormalArgs _afterOnFixedUpdate;

        private static void OnFixedUpdate(Action<ArrayForEach> orig, ArrayForEach self)
        {
            Delegates.Params_OnFixedUpdate @params = new()
            {
                self = self
            };
            _beforeOnFixedUpdate?.Invoke(@params);
            self = @params.self;
            orig(self);
            if (_afterOnFixedUpdate != null) _afterOnFixedUpdate.Invoke(@params);
        }

        internal static void HookOnLateUpdate()
        {
            if (!HookedList.Contains("OnLateUpdate"))
            {
                HookedList.Add("OnLateUpdate");
                new Hook(ReflectionHelper.GetMethodInfo(typeof(ArrayForEach), "OnLateUpdate"), OnLateUpdate);
            }
        }

        internal static event Delegates.OnLateUpdate_BeforeArgs _beforeOnLateUpdate;
        internal static event Delegates.OnLateUpdate_NormalArgs _afterOnLateUpdate;

        private static void OnLateUpdate(Action<ArrayForEach> orig, ArrayForEach self)
        {
            Delegates.Params_OnLateUpdate @params = new()
            {
                self = self
            };
            _beforeOnLateUpdate?.Invoke(@params);
            self = @params.self;
            orig(self);
            if (_afterOnLateUpdate != null) _afterOnLateUpdate.Invoke(@params);
        }

        internal static void HookStartNextFsm()
        {
            if (!HookedList.Contains("StartNextFsm"))
            {
                HookedList.Add("StartNextFsm");
                new Hook(ReflectionHelper.GetMethodInfo(typeof(ArrayForEach), "StartNextFsm"), StartNextFsm);
            }
        }

        internal static event Delegates.StartNextFsm_BeforeArgs _beforeStartNextFsm;
        internal static event Delegates.StartNextFsm_NormalArgs _afterStartNextFsm;

        private static void StartNextFsm(Action<ArrayForEach> orig, ArrayForEach self)
        {
            Delegates.Params_StartNextFsm @params = new()
            {
                self = self
            };
            _beforeStartNextFsm?.Invoke(@params);
            self = @params.self;
            orig(self);
            if (_afterStartNextFsm != null) _afterStartNextFsm.Invoke(@params);
        }

        internal static void HookStartFsm()
        {
            if (!HookedList.Contains("StartFsm"))
            {
                HookedList.Add("StartFsm");
                new Hook(ReflectionHelper.GetMethodInfo(typeof(ArrayForEach), "StartFsm"), StartFsm);
            }
        }

        internal static event Delegates.StartFsm_BeforeArgs _beforeStartFsm;
        internal static event Delegates.StartFsm_NormalArgs _afterStartFsm;

        private static void StartFsm(Action<ArrayForEach> orig, ArrayForEach self)
        {
            Delegates.Params_StartFsm @params = new()
            {
                self = self
            };
            _beforeStartFsm?.Invoke(@params);
            self = @params.self;
            orig(self);
            if (_afterStartFsm != null) _afterStartFsm.Invoke(@params);
        }

        internal static void HookDoStartFsm()
        {
            if (!HookedList.Contains("DoStartFsm"))
            {
                HookedList.Add("DoStartFsm");
                new Hook(ReflectionHelper.GetMethodInfo(typeof(ArrayForEach), "DoStartFsm"), DoStartFsm);
            }
        }

        internal static event Delegates.DoStartFsm_BeforeArgs _beforeDoStartFsm;
        internal static event Delegates.DoStartFsm_NormalArgs _afterDoStartFsm;

        private static void DoStartFsm(Action<ArrayForEach> orig, ArrayForEach self)
        {
            Delegates.Params_DoStartFsm @params = new()
            {
                self = self
            };
            _beforeDoStartFsm?.Invoke(@params);
            self = @params.self;
            orig(self);
            if (_afterDoStartFsm != null) _afterDoStartFsm.Invoke(@params);
        }

        internal static void HookCheckIfFinished()
        {
            if (!HookedList.Contains("CheckIfFinished"))
            {
                HookedList.Add("CheckIfFinished");
                new Hook(ReflectionHelper.GetMethodInfo(typeof(ArrayForEach), "CheckIfFinished"), CheckIfFinished);
            }
        }

        internal static event Delegates.CheckIfFinished_BeforeArgs _beforeCheckIfFinished;
        internal static event Delegates.CheckIfFinished_NormalArgs _afterCheckIfFinished;

        private static void CheckIfFinished(Action<ArrayForEach> orig, ArrayForEach self)
        {
            Delegates.Params_CheckIfFinished @params = new()
            {
                self = self
            };
            _beforeCheckIfFinished?.Invoke(@params);
            self = @params.self;
            orig(self);
            if (_afterCheckIfFinished != null) _afterCheckIfFinished.Invoke(@params);
        }
    }

    /// <summary>
    ///     Contains necessary information to create Hooks. Does not contain any hooks
    /// </summary>
    public static class Delegates
    {
        public delegate void Awake_BeforeArgs(Params_Awake args);

        public delegate void Awake_NormalArgs(Params_Awake args);

        public delegate void CheckIfFinished_BeforeArgs(Params_CheckIfFinished args);

        public delegate void CheckIfFinished_NormalArgs(Params_CheckIfFinished args);

        public delegate void DoStartFsm_BeforeArgs(Params_DoStartFsm args);

        public delegate void DoStartFsm_NormalArgs(Params_DoStartFsm args);

        public delegate void OnEnter_BeforeArgs(Params_OnEnter args);

        public delegate void OnEnter_NormalArgs(Params_OnEnter args);

        public delegate void OnFixedUpdate_BeforeArgs(Params_OnFixedUpdate args);

        public delegate void OnFixedUpdate_NormalArgs(Params_OnFixedUpdate args);

        public delegate void OnLateUpdate_BeforeArgs(Params_OnLateUpdate args);

        public delegate void OnLateUpdate_NormalArgs(Params_OnLateUpdate args);

        public delegate void OnPreprocess_BeforeArgs(Params_OnPreprocess args);

        public delegate void OnPreprocess_NormalArgs(Params_OnPreprocess args);

        public delegate void OnUpdate_BeforeArgs(Params_OnUpdate args);

        public delegate void OnUpdate_NormalArgs(Params_OnUpdate args);

        public delegate void Reset_BeforeArgs(Params_Reset args);

        public delegate void Reset_NormalArgs(Params_Reset args);

        public delegate void StartFsm_BeforeArgs(Params_StartFsm args);

        public delegate void StartFsm_NormalArgs(Params_StartFsm args);

        public delegate void StartNextFsm_BeforeArgs(Params_StartNextFsm args);

        public delegate void StartNextFsm_NormalArgs(Params_StartNextFsm args);

        public sealed class Params_Reset
        {
            public ArrayForEach self;
        }

        public sealed class Params_Awake
        {
            public ArrayForEach self;
        }

        public sealed class Params_OnPreprocess
        {
            public ArrayForEach self;
        }

        public sealed class Params_OnEnter
        {
            public ArrayForEach self;
        }

        public sealed class Params_OnUpdate
        {
            public ArrayForEach self;
        }

        public sealed class Params_OnFixedUpdate
        {
            public ArrayForEach self;
        }

        public sealed class Params_OnLateUpdate
        {
            public ArrayForEach self;
        }

        public sealed class Params_StartNextFsm
        {
            public ArrayForEach self;
        }

        public sealed class Params_StartFsm
        {
            public ArrayForEach self;
        }

        public sealed class Params_DoStartFsm
        {
            public ArrayForEach self;
        }

        public sealed class Params_CheckIfFinished
        {
            public ArrayForEach self;
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

        public static event Delegates.Awake_BeforeArgs Awake
        {
            add
            {
                HookHandler._beforeAwake += value;
                HookHandler.HookAwake();
            }
            remove => HookHandler._beforeAwake -= value;
        }

        public static event Delegates.OnPreprocess_BeforeArgs OnPreprocess
        {
            add
            {
                HookHandler._beforeOnPreprocess += value;
                HookHandler.HookOnPreprocess();
            }
            remove => HookHandler._beforeOnPreprocess -= value;
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

        public static event Delegates.OnUpdate_BeforeArgs OnUpdate
        {
            add
            {
                HookHandler._beforeOnUpdate += value;
                HookHandler.HookOnUpdate();
            }
            remove => HookHandler._beforeOnUpdate -= value;
        }

        public static event Delegates.OnFixedUpdate_BeforeArgs OnFixedUpdate
        {
            add
            {
                HookHandler._beforeOnFixedUpdate += value;
                HookHandler.HookOnFixedUpdate();
            }
            remove => HookHandler._beforeOnFixedUpdate -= value;
        }

        public static event Delegates.OnLateUpdate_BeforeArgs OnLateUpdate
        {
            add
            {
                HookHandler._beforeOnLateUpdate += value;
                HookHandler.HookOnLateUpdate();
            }
            remove => HookHandler._beforeOnLateUpdate -= value;
        }

        public static event Delegates.StartNextFsm_BeforeArgs StartNextFsm
        {
            add
            {
                HookHandler._beforeStartNextFsm += value;
                HookHandler.HookStartNextFsm();
            }
            remove => HookHandler._beforeStartNextFsm -= value;
        }

        public static event Delegates.StartFsm_BeforeArgs StartFsm
        {
            add
            {
                HookHandler._beforeStartFsm += value;
                HookHandler.HookStartFsm();
            }
            remove => HookHandler._beforeStartFsm -= value;
        }

        public static event Delegates.DoStartFsm_BeforeArgs DoStartFsm
        {
            add
            {
                HookHandler._beforeDoStartFsm += value;
                HookHandler.HookDoStartFsm();
            }
            remove => HookHandler._beforeDoStartFsm -= value;
        }

        public static event Delegates.CheckIfFinished_BeforeArgs CheckIfFinished
        {
            add
            {
                HookHandler._beforeCheckIfFinished += value;
                HookHandler.HookCheckIfFinished();
            }
            remove => HookHandler._beforeCheckIfFinished -= value;
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

        public static event Delegates.Awake_NormalArgs Awake
        {
            add
            {
                HookHandler._afterAwake += value;
                HookHandler.HookAwake();
            }
            remove => HookHandler._afterAwake -= value;
        }

        public static event Delegates.OnPreprocess_NormalArgs OnPreprocess
        {
            add
            {
                HookHandler._afterOnPreprocess += value;
                HookHandler.HookOnPreprocess();
            }
            remove => HookHandler._afterOnPreprocess -= value;
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

        public static event Delegates.OnUpdate_NormalArgs OnUpdate
        {
            add
            {
                HookHandler._afterOnUpdate += value;
                HookHandler.HookOnUpdate();
            }
            remove => HookHandler._afterOnUpdate -= value;
        }

        public static event Delegates.OnFixedUpdate_NormalArgs OnFixedUpdate
        {
            add
            {
                HookHandler._afterOnFixedUpdate += value;
                HookHandler.HookOnFixedUpdate();
            }
            remove => HookHandler._afterOnFixedUpdate -= value;
        }

        public static event Delegates.OnLateUpdate_NormalArgs OnLateUpdate
        {
            add
            {
                HookHandler._afterOnLateUpdate += value;
                HookHandler.HookOnLateUpdate();
            }
            remove => HookHandler._afterOnLateUpdate -= value;
        }

        public static event Delegates.StartNextFsm_NormalArgs StartNextFsm
        {
            add
            {
                HookHandler._afterStartNextFsm += value;
                HookHandler.HookStartNextFsm();
            }
            remove => HookHandler._afterStartNextFsm -= value;
        }

        public static event Delegates.StartFsm_NormalArgs StartFsm
        {
            add
            {
                HookHandler._afterStartFsm += value;
                HookHandler.HookStartFsm();
            }
            remove => HookHandler._afterStartFsm -= value;
        }

        public static event Delegates.DoStartFsm_NormalArgs DoStartFsm
        {
            add
            {
                HookHandler._afterDoStartFsm += value;
                HookHandler.HookDoStartFsm();
            }
            remove => HookHandler._afterDoStartFsm -= value;
        }

        public static event Delegates.CheckIfFinished_NormalArgs CheckIfFinished
        {
            add
            {
                HookHandler._afterCheckIfFinished += value;
                HookHandler.HookCheckIfFinished();
            }
            remove => HookHandler._afterCheckIfFinished -= value;
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
                ReflectionHelper.GetMethodInfo(typeof(ArrayForEach), "Reset"), value);
            remove => HookEndpointManager.Remove<Delegates.Reset_NormalArgs>(
                ReflectionHelper.GetMethodInfo(typeof(ArrayForEach), "Reset"), value);
        }

        public static event Delegates.Awake_NormalArgs Awake
        {
            add => HookEndpointManager.Add<Delegates.Awake_NormalArgs>(
                ReflectionHelper.GetMethodInfo(typeof(ArrayForEach), "Awake"), value);
            remove => HookEndpointManager.Remove<Delegates.Awake_NormalArgs>(
                ReflectionHelper.GetMethodInfo(typeof(ArrayForEach), "Awake"), value);
        }

        public static event Delegates.OnPreprocess_NormalArgs OnPreprocess
        {
            add => HookEndpointManager.Add<Delegates.OnPreprocess_NormalArgs>(
                ReflectionHelper.GetMethodInfo(typeof(ArrayForEach), "OnPreprocess"), value);
            remove => HookEndpointManager.Remove<Delegates.OnPreprocess_NormalArgs>(
                ReflectionHelper.GetMethodInfo(typeof(ArrayForEach), "OnPreprocess"), value);
        }

        public static event Delegates.OnEnter_NormalArgs OnEnter
        {
            add => HookEndpointManager.Add<Delegates.OnEnter_NormalArgs>(
                ReflectionHelper.GetMethodInfo(typeof(ArrayForEach), "OnEnter"), value);
            remove => HookEndpointManager.Remove<Delegates.OnEnter_NormalArgs>(
                ReflectionHelper.GetMethodInfo(typeof(ArrayForEach), "OnEnter"), value);
        }

        public static event Delegates.OnUpdate_NormalArgs OnUpdate
        {
            add => HookEndpointManager.Add<Delegates.OnUpdate_NormalArgs>(
                ReflectionHelper.GetMethodInfo(typeof(ArrayForEach), "OnUpdate"), value);
            remove => HookEndpointManager.Remove<Delegates.OnUpdate_NormalArgs>(
                ReflectionHelper.GetMethodInfo(typeof(ArrayForEach), "OnUpdate"), value);
        }

        public static event Delegates.OnFixedUpdate_NormalArgs OnFixedUpdate
        {
            add => HookEndpointManager.Add<Delegates.OnFixedUpdate_NormalArgs>(
                ReflectionHelper.GetMethodInfo(typeof(ArrayForEach), "OnFixedUpdate"), value);
            remove => HookEndpointManager.Remove<Delegates.OnFixedUpdate_NormalArgs>(
                ReflectionHelper.GetMethodInfo(typeof(ArrayForEach), "OnFixedUpdate"), value);
        }

        public static event Delegates.OnLateUpdate_NormalArgs OnLateUpdate
        {
            add => HookEndpointManager.Add<Delegates.OnLateUpdate_NormalArgs>(
                ReflectionHelper.GetMethodInfo(typeof(ArrayForEach), "OnLateUpdate"), value);
            remove => HookEndpointManager.Remove<Delegates.OnLateUpdate_NormalArgs>(
                ReflectionHelper.GetMethodInfo(typeof(ArrayForEach), "OnLateUpdate"), value);
        }

        public static event Delegates.StartNextFsm_NormalArgs StartNextFsm
        {
            add => HookEndpointManager.Add<Delegates.StartNextFsm_NormalArgs>(
                ReflectionHelper.GetMethodInfo(typeof(ArrayForEach), "StartNextFsm"), value);
            remove => HookEndpointManager.Remove<Delegates.StartNextFsm_NormalArgs>(
                ReflectionHelper.GetMethodInfo(typeof(ArrayForEach), "StartNextFsm"), value);
        }

        public static event Delegates.StartFsm_NormalArgs StartFsm
        {
            add => HookEndpointManager.Add<Delegates.StartFsm_NormalArgs>(
                ReflectionHelper.GetMethodInfo(typeof(ArrayForEach), "StartFsm"), value);
            remove => HookEndpointManager.Remove<Delegates.StartFsm_NormalArgs>(
                ReflectionHelper.GetMethodInfo(typeof(ArrayForEach), "StartFsm"), value);
        }

        public static event Delegates.DoStartFsm_NormalArgs DoStartFsm
        {
            add => HookEndpointManager.Add<Delegates.DoStartFsm_NormalArgs>(
                ReflectionHelper.GetMethodInfo(typeof(ArrayForEach), "DoStartFsm"), value);
            remove => HookEndpointManager.Remove<Delegates.DoStartFsm_NormalArgs>(
                ReflectionHelper.GetMethodInfo(typeof(ArrayForEach), "DoStartFsm"), value);
        }

        public static event Delegates.CheckIfFinished_NormalArgs CheckIfFinished
        {
            add => HookEndpointManager.Add<Delegates.CheckIfFinished_NormalArgs>(
                ReflectionHelper.GetMethodInfo(typeof(ArrayForEach), "CheckIfFinished"), value);
            remove => HookEndpointManager.Remove<Delegates.CheckIfFinished_NormalArgs>(
                ReflectionHelper.GetMethodInfo(typeof(ArrayForEach), "CheckIfFinished"), value);
        }
    }
}