using MonoMod.RuntimeDetour;
using MonoMod.RuntimeDetour.HookGen;

namespace HKMirror.Hooks.OnHooks;

/// <summary>
///     Contains different types of On Hooks for ObjectJitterLocal class.<br />
///     Contains hooks that aren't generated by monomod, and before and after orig hooks for easier hooking.
/// </summary>
public static class OnObjectJitterLocal
{
    internal static class HookHandler
    {
        private static readonly List<string> HookedList = new();

        internal static void HookReset()
        {
            if (!HookedList.Contains("Reset"))
            {
                HookedList.Add("Reset");
                new Hook(ReflectionHelper.GetMethodInfo(typeof(ObjectJitterLocal), "Reset"), Reset);
            }
        }

        internal static event Delegates.Reset_BeforeArgs _beforeReset;
        internal static event Delegates.Reset_NormalArgs _afterReset;

        private static void Reset(Action<ObjectJitterLocal> orig, ObjectJitterLocal self)
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

        internal static void HookOnPreprocess()
        {
            if (!HookedList.Contains("OnPreprocess"))
            {
                HookedList.Add("OnPreprocess");
                new Hook(ReflectionHelper.GetMethodInfo(typeof(ObjectJitterLocal), "OnPreprocess"), OnPreprocess);
            }
        }

        internal static event Delegates.OnPreprocess_BeforeArgs _beforeOnPreprocess;
        internal static event Delegates.OnPreprocess_NormalArgs _afterOnPreprocess;

        private static void OnPreprocess(Action<ObjectJitterLocal> orig, ObjectJitterLocal self)
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
                new Hook(ReflectionHelper.GetMethodInfo(typeof(ObjectJitterLocal), "OnEnter"), OnEnter);
            }
        }

        internal static event Delegates.OnEnter_BeforeArgs _beforeOnEnter;
        internal static event Delegates.OnEnter_NormalArgs _afterOnEnter;

        private static void OnEnter(Action<ObjectJitterLocal> orig, ObjectJitterLocal self)
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

        internal static void HookOnFixedUpdate()
        {
            if (!HookedList.Contains("OnFixedUpdate"))
            {
                HookedList.Add("OnFixedUpdate");
                new Hook(ReflectionHelper.GetMethodInfo(typeof(ObjectJitterLocal), "OnFixedUpdate"), OnFixedUpdate);
            }
        }

        internal static event Delegates.OnFixedUpdate_BeforeArgs _beforeOnFixedUpdate;
        internal static event Delegates.OnFixedUpdate_NormalArgs _afterOnFixedUpdate;

        private static void OnFixedUpdate(Action<ObjectJitterLocal> orig, ObjectJitterLocal self)
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

        internal static void HookDoTranslate()
        {
            if (!HookedList.Contains("DoTranslate"))
            {
                HookedList.Add("DoTranslate");
                new Hook(ReflectionHelper.GetMethodInfo(typeof(ObjectJitterLocal), "DoTranslate"), DoTranslate);
            }
        }

        internal static event Delegates.DoTranslate_BeforeArgs _beforeDoTranslate;
        internal static event Delegates.DoTranslate_NormalArgs _afterDoTranslate;

        private static void DoTranslate(Action<ObjectJitterLocal> orig, ObjectJitterLocal self)
        {
            Delegates.Params_DoTranslate @params = new()
            {
                self = self
            };
            _beforeDoTranslate?.Invoke(@params);
            self = @params.self;
            orig(self);
            if (_afterDoTranslate != null) _afterDoTranslate.Invoke(@params);
        }
    }

    /// <summary>
    ///     Contains necessary information to create Hooks. Does not contain any hooks
    /// </summary>
    public static class Delegates
    {
        public delegate void DoTranslate_BeforeArgs(Params_DoTranslate args);

        public delegate void DoTranslate_NormalArgs(Params_DoTranslate args);

        public delegate void OnEnter_BeforeArgs(Params_OnEnter args);

        public delegate void OnEnter_NormalArgs(Params_OnEnter args);

        public delegate void OnFixedUpdate_BeforeArgs(Params_OnFixedUpdate args);

        public delegate void OnFixedUpdate_NormalArgs(Params_OnFixedUpdate args);

        public delegate void OnPreprocess_BeforeArgs(Params_OnPreprocess args);

        public delegate void OnPreprocess_NormalArgs(Params_OnPreprocess args);

        public delegate void Reset_BeforeArgs(Params_Reset args);

        public delegate void Reset_NormalArgs(Params_Reset args);

        public sealed class Params_Reset
        {
            public ObjectJitterLocal self;
        }

        public sealed class Params_OnPreprocess
        {
            public ObjectJitterLocal self;
        }

        public sealed class Params_OnEnter
        {
            public ObjectJitterLocal self;
        }

        public sealed class Params_OnFixedUpdate
        {
            public ObjectJitterLocal self;
        }

        public sealed class Params_DoTranslate
        {
            public ObjectJitterLocal self;
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

        public static event Delegates.OnFixedUpdate_BeforeArgs OnFixedUpdate
        {
            add
            {
                HookHandler._beforeOnFixedUpdate += value;
                HookHandler.HookOnFixedUpdate();
            }
            remove => HookHandler._beforeOnFixedUpdate -= value;
        }

        public static event Delegates.DoTranslate_BeforeArgs DoTranslate
        {
            add
            {
                HookHandler._beforeDoTranslate += value;
                HookHandler.HookDoTranslate();
            }
            remove => HookHandler._beforeDoTranslate -= value;
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

        public static event Delegates.OnFixedUpdate_NormalArgs OnFixedUpdate
        {
            add
            {
                HookHandler._afterOnFixedUpdate += value;
                HookHandler.HookOnFixedUpdate();
            }
            remove => HookHandler._afterOnFixedUpdate -= value;
        }

        public static event Delegates.DoTranslate_NormalArgs DoTranslate
        {
            add
            {
                HookHandler._afterDoTranslate += value;
                HookHandler.HookDoTranslate();
            }
            remove => HookHandler._afterDoTranslate -= value;
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
                ReflectionHelper.GetMethodInfo(typeof(ObjectJitterLocal), "Reset"), value);
            remove => HookEndpointManager.Remove<Delegates.Reset_NormalArgs>(
                ReflectionHelper.GetMethodInfo(typeof(ObjectJitterLocal), "Reset"), value);
        }

        public static event Delegates.OnPreprocess_NormalArgs OnPreprocess
        {
            add => HookEndpointManager.Add<Delegates.OnPreprocess_NormalArgs>(
                ReflectionHelper.GetMethodInfo(typeof(ObjectJitterLocal), "OnPreprocess"), value);
            remove => HookEndpointManager.Remove<Delegates.OnPreprocess_NormalArgs>(
                ReflectionHelper.GetMethodInfo(typeof(ObjectJitterLocal), "OnPreprocess"), value);
        }

        public static event Delegates.OnEnter_NormalArgs OnEnter
        {
            add => HookEndpointManager.Add<Delegates.OnEnter_NormalArgs>(
                ReflectionHelper.GetMethodInfo(typeof(ObjectJitterLocal), "OnEnter"), value);
            remove => HookEndpointManager.Remove<Delegates.OnEnter_NormalArgs>(
                ReflectionHelper.GetMethodInfo(typeof(ObjectJitterLocal), "OnEnter"), value);
        }

        public static event Delegates.OnFixedUpdate_NormalArgs OnFixedUpdate
        {
            add => HookEndpointManager.Add<Delegates.OnFixedUpdate_NormalArgs>(
                ReflectionHelper.GetMethodInfo(typeof(ObjectJitterLocal), "OnFixedUpdate"), value);
            remove => HookEndpointManager.Remove<Delegates.OnFixedUpdate_NormalArgs>(
                ReflectionHelper.GetMethodInfo(typeof(ObjectJitterLocal), "OnFixedUpdate"), value);
        }

        public static event Delegates.DoTranslate_NormalArgs DoTranslate
        {
            add => HookEndpointManager.Add<Delegates.DoTranslate_NormalArgs>(
                ReflectionHelper.GetMethodInfo(typeof(ObjectJitterLocal), "DoTranslate"), value);
            remove => HookEndpointManager.Remove<Delegates.DoTranslate_NormalArgs>(
                ReflectionHelper.GetMethodInfo(typeof(ObjectJitterLocal), "DoTranslate"), value);
        }
    }
}