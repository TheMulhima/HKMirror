using MonoMod.RuntimeDetour;
using MonoMod.RuntimeDetour.HookGen;

namespace HKMirror.Hooks.OnHooks;

/// <summary>
///     Contains different types of On Hooks for AccelerateVelocity class.<br />
///     Contains hooks that aren't generated by monomod, and before and after orig hooks for easier hooking.
/// </summary>
public static class OnAccelerateVelocity
{
    internal static class HookHandler
    {
        private static readonly List<string> HookedList = new();

        internal static void HookReset()
        {
            if (!HookedList.Contains("Reset"))
            {
                HookedList.Add("Reset");
                new Hook(ReflectionHelper.GetMethodInfo(typeof(AccelerateVelocity), "Reset"), Reset);
            }
        }

        internal static event Delegates.Reset_BeforeArgs _beforeReset;
        internal static event Delegates.Reset_AfterArgs _afterReset;

        private static void Reset(Action<AccelerateVelocity> orig, AccelerateVelocity self)
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

        internal static void HookAwake()
        {
            if (!HookedList.Contains("Awake"))
            {
                HookedList.Add("Awake");
                new Hook(ReflectionHelper.GetMethodInfo(typeof(AccelerateVelocity), "Awake"), Awake);
            }
        }

        internal static event Delegates.Awake_BeforeArgs _beforeAwake;
        internal static event Delegates.Awake_AfterArgs _afterAwake;

        private static void Awake(Action<AccelerateVelocity> orig, AccelerateVelocity self)
        {
            Delegates.Params_Awake @params = new()
            {
                self = self
            };
            if (_beforeAwake != null)
                foreach (Delegates.Awake_BeforeArgs toInvoke in _beforeAwake.GetInvocationList())
                    try
                    {
                        _beforeAwake?.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }

            self = @params.self;
            orig(self);
            if (_afterAwake != null)
                foreach (Delegates.Awake_AfterArgs toInvoke in _afterAwake.GetInvocationList())
                    try
                    {
                        _afterAwake.Invoke(@params);
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
                new Hook(ReflectionHelper.GetMethodInfo(typeof(AccelerateVelocity), "OnEnter"), OnEnter);
            }
        }

        internal static event Delegates.OnEnter_BeforeArgs _beforeOnEnter;
        internal static event Delegates.OnEnter_AfterArgs _afterOnEnter;

        private static void OnEnter(Action<AccelerateVelocity> orig, AccelerateVelocity self)
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

        internal static void HookOnPreprocess()
        {
            if (!HookedList.Contains("OnPreprocess"))
            {
                HookedList.Add("OnPreprocess");
                new Hook(ReflectionHelper.GetMethodInfo(typeof(AccelerateVelocity), "OnPreprocess"), OnPreprocess);
            }
        }

        internal static event Delegates.OnPreprocess_BeforeArgs _beforeOnPreprocess;
        internal static event Delegates.OnPreprocess_AfterArgs _afterOnPreprocess;

        private static void OnPreprocess(Action<AccelerateVelocity> orig, AccelerateVelocity self)
        {
            Delegates.Params_OnPreprocess @params = new()
            {
                self = self
            };
            if (_beforeOnPreprocess != null)
                foreach (Delegates.OnPreprocess_BeforeArgs toInvoke in _beforeOnPreprocess.GetInvocationList())
                    try
                    {
                        _beforeOnPreprocess?.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }

            self = @params.self;
            orig(self);
            if (_afterOnPreprocess != null)
                foreach (Delegates.OnPreprocess_AfterArgs toInvoke in _afterOnPreprocess.GetInvocationList())
                    try
                    {
                        _afterOnPreprocess.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }
        }

        internal static void HookOnFixedUpdate()
        {
            if (!HookedList.Contains("OnFixedUpdate"))
            {
                HookedList.Add("OnFixedUpdate");
                new Hook(ReflectionHelper.GetMethodInfo(typeof(AccelerateVelocity), "OnFixedUpdate"), OnFixedUpdate);
            }
        }

        internal static event Delegates.OnFixedUpdate_BeforeArgs _beforeOnFixedUpdate;
        internal static event Delegates.OnFixedUpdate_AfterArgs _afterOnFixedUpdate;

        private static void OnFixedUpdate(Action<AccelerateVelocity> orig, AccelerateVelocity self)
        {
            Delegates.Params_OnFixedUpdate @params = new()
            {
                self = self
            };
            if (_beforeOnFixedUpdate != null)
                foreach (Delegates.OnFixedUpdate_BeforeArgs toInvoke in _beforeOnFixedUpdate.GetInvocationList())
                    try
                    {
                        _beforeOnFixedUpdate?.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }

            self = @params.self;
            orig(self);
            if (_afterOnFixedUpdate != null)
                foreach (Delegates.OnFixedUpdate_AfterArgs toInvoke in _afterOnFixedUpdate.GetInvocationList())
                    try
                    {
                        _afterOnFixedUpdate.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }
        }

        internal static void HookDoSetVelocity()
        {
            if (!HookedList.Contains("DoSetVelocity"))
            {
                HookedList.Add("DoSetVelocity");
                new Hook(ReflectionHelper.GetMethodInfo(typeof(AccelerateVelocity), "DoSetVelocity"), DoSetVelocity);
            }
        }

        internal static event Delegates.DoSetVelocity_BeforeArgs _beforeDoSetVelocity;
        internal static event Delegates.DoSetVelocity_AfterArgs _afterDoSetVelocity;

        private static void DoSetVelocity(Action<AccelerateVelocity> orig, AccelerateVelocity self)
        {
            Delegates.Params_DoSetVelocity @params = new()
            {
                self = self
            };
            if (_beforeDoSetVelocity != null)
                foreach (Delegates.DoSetVelocity_BeforeArgs toInvoke in _beforeDoSetVelocity.GetInvocationList())
                    try
                    {
                        _beforeDoSetVelocity?.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }

            self = @params.self;
            orig(self);
            if (_afterDoSetVelocity != null)
                foreach (Delegates.DoSetVelocity_AfterArgs toInvoke in _afterDoSetVelocity.GetInvocationList())
                    try
                    {
                        _afterDoSetVelocity.Invoke(@params);
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
        public delegate void Awake_AfterArgs(Params_Awake args);

        public delegate void Awake_BeforeArgs(Params_Awake args);

        public delegate void Awake_WithArgs(Action<AccelerateVelocity> orig, AccelerateVelocity self);

        public delegate void DoSetVelocity_AfterArgs(Params_DoSetVelocity args);

        public delegate void DoSetVelocity_BeforeArgs(Params_DoSetVelocity args);

        public delegate void DoSetVelocity_WithArgs(Action<AccelerateVelocity> orig, AccelerateVelocity self);

        public delegate void OnEnter_AfterArgs(Params_OnEnter args);

        public delegate void OnEnter_BeforeArgs(Params_OnEnter args);

        public delegate void OnEnter_WithArgs(Action<AccelerateVelocity> orig, AccelerateVelocity self);

        public delegate void OnFixedUpdate_AfterArgs(Params_OnFixedUpdate args);

        public delegate void OnFixedUpdate_BeforeArgs(Params_OnFixedUpdate args);

        public delegate void OnFixedUpdate_WithArgs(Action<AccelerateVelocity> orig, AccelerateVelocity self);

        public delegate void OnPreprocess_AfterArgs(Params_OnPreprocess args);

        public delegate void OnPreprocess_BeforeArgs(Params_OnPreprocess args);

        public delegate void OnPreprocess_WithArgs(Action<AccelerateVelocity> orig, AccelerateVelocity self);

        public delegate void Reset_AfterArgs(Params_Reset args);

        public delegate void Reset_BeforeArgs(Params_Reset args);

        public delegate void Reset_WithArgs(Action<AccelerateVelocity> orig, AccelerateVelocity self);

        public sealed class Params_Reset
        {
            public AccelerateVelocity self;
        }

        public sealed class Params_Awake
        {
            public AccelerateVelocity self;
        }

        public sealed class Params_OnEnter
        {
            public AccelerateVelocity self;
        }

        public sealed class Params_OnPreprocess
        {
            public AccelerateVelocity self;
        }

        public sealed class Params_OnFixedUpdate
        {
            public AccelerateVelocity self;
        }

        public sealed class Params_DoSetVelocity
        {
            public AccelerateVelocity self;
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

        public static event Delegates.OnEnter_BeforeArgs OnEnter
        {
            add
            {
                HookHandler._beforeOnEnter += value;
                HookHandler.HookOnEnter();
            }
            remove => HookHandler._beforeOnEnter -= value;
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

        public static event Delegates.OnFixedUpdate_BeforeArgs OnFixedUpdate
        {
            add
            {
                HookHandler._beforeOnFixedUpdate += value;
                HookHandler.HookOnFixedUpdate();
            }
            remove => HookHandler._beforeOnFixedUpdate -= value;
        }

        public static event Delegates.DoSetVelocity_BeforeArgs DoSetVelocity
        {
            add
            {
                HookHandler._beforeDoSetVelocity += value;
                HookHandler.HookDoSetVelocity();
            }
            remove => HookHandler._beforeDoSetVelocity -= value;
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

        public static event Delegates.Awake_AfterArgs Awake
        {
            add
            {
                HookHandler._afterAwake += value;
                HookHandler.HookAwake();
            }
            remove => HookHandler._afterAwake -= value;
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

        public static event Delegates.OnPreprocess_AfterArgs OnPreprocess
        {
            add
            {
                HookHandler._afterOnPreprocess += value;
                HookHandler.HookOnPreprocess();
            }
            remove => HookHandler._afterOnPreprocess -= value;
        }

        public static event Delegates.OnFixedUpdate_AfterArgs OnFixedUpdate
        {
            add
            {
                HookHandler._afterOnFixedUpdate += value;
                HookHandler.HookOnFixedUpdate();
            }
            remove => HookHandler._afterOnFixedUpdate -= value;
        }

        public static event Delegates.DoSetVelocity_AfterArgs DoSetVelocity
        {
            add
            {
                HookHandler._afterDoSetVelocity += value;
                HookHandler.HookDoSetVelocity();
            }
            remove => HookHandler._afterDoSetVelocity -= value;
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
                ReflectionHelper.GetMethodInfo(typeof(AccelerateVelocity), "Reset"), value);
            remove => HookEndpointManager.Remove<Delegates.Reset_WithArgs>(
                ReflectionHelper.GetMethodInfo(typeof(AccelerateVelocity), "Reset"), value);
        }

        public static event Delegates.Awake_WithArgs Awake
        {
            add => HookEndpointManager.Add<Delegates.Awake_WithArgs>(
                ReflectionHelper.GetMethodInfo(typeof(AccelerateVelocity), "Awake"), value);
            remove => HookEndpointManager.Remove<Delegates.Awake_WithArgs>(
                ReflectionHelper.GetMethodInfo(typeof(AccelerateVelocity), "Awake"), value);
        }

        public static event Delegates.OnEnter_WithArgs OnEnter
        {
            add => HookEndpointManager.Add<Delegates.OnEnter_WithArgs>(
                ReflectionHelper.GetMethodInfo(typeof(AccelerateVelocity), "OnEnter"), value);
            remove => HookEndpointManager.Remove<Delegates.OnEnter_WithArgs>(
                ReflectionHelper.GetMethodInfo(typeof(AccelerateVelocity), "OnEnter"), value);
        }

        public static event Delegates.OnPreprocess_WithArgs OnPreprocess
        {
            add => HookEndpointManager.Add<Delegates.OnPreprocess_WithArgs>(
                ReflectionHelper.GetMethodInfo(typeof(AccelerateVelocity), "OnPreprocess"), value);
            remove => HookEndpointManager.Remove<Delegates.OnPreprocess_WithArgs>(
                ReflectionHelper.GetMethodInfo(typeof(AccelerateVelocity), "OnPreprocess"), value);
        }

        public static event Delegates.OnFixedUpdate_WithArgs OnFixedUpdate
        {
            add => HookEndpointManager.Add<Delegates.OnFixedUpdate_WithArgs>(
                ReflectionHelper.GetMethodInfo(typeof(AccelerateVelocity), "OnFixedUpdate"), value);
            remove => HookEndpointManager.Remove<Delegates.OnFixedUpdate_WithArgs>(
                ReflectionHelper.GetMethodInfo(typeof(AccelerateVelocity), "OnFixedUpdate"), value);
        }

        public static event Delegates.DoSetVelocity_WithArgs DoSetVelocity
        {
            add => HookEndpointManager.Add<Delegates.DoSetVelocity_WithArgs>(
                ReflectionHelper.GetMethodInfo(typeof(AccelerateVelocity), "DoSetVelocity"), value);
            remove => HookEndpointManager.Remove<Delegates.DoSetVelocity_WithArgs>(
                ReflectionHelper.GetMethodInfo(typeof(AccelerateVelocity), "DoSetVelocity"), value);
        }
    }
}