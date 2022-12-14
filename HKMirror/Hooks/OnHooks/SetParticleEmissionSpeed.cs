using MonoMod.RuntimeDetour;
using MonoMod.RuntimeDetour.HookGen;

namespace HKMirror.Hooks.OnHooks;

/// <summary>
///     Contains different types of On Hooks for SetParticleEmissionSpeed class.<br />
///     Contains hooks that aren't generated by monomod, and before and after orig hooks for easier hooking.
/// </summary>
public static class OnSetParticleEmissionSpeed
{
    internal static class HookHandler
    {
        private static readonly List<string> HookedList = new();

        internal static void HookReset()
        {
            if (!HookedList.Contains("Reset"))
            {
                HookedList.Add("Reset");
                new Hook(ReflectionHelper.GetMethodInfo(typeof(SetParticleEmissionSpeed), "Reset"), Reset);
            }
        }

        internal static event Delegates.Reset_BeforeArgs _beforeReset;
        internal static event Delegates.Reset_AfterArgs _afterReset;

        private static void Reset(Action<SetParticleEmissionSpeed> orig, SetParticleEmissionSpeed self)
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
                new Hook(ReflectionHelper.GetMethodInfo(typeof(SetParticleEmissionSpeed), "OnEnter"), OnEnter);
            }
        }

        internal static event Delegates.OnEnter_BeforeArgs _beforeOnEnter;
        internal static event Delegates.OnEnter_AfterArgs _afterOnEnter;

        private static void OnEnter(Action<SetParticleEmissionSpeed> orig, SetParticleEmissionSpeed self)
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

        internal static void HookOnUpdate()
        {
            if (!HookedList.Contains("OnUpdate"))
            {
                HookedList.Add("OnUpdate");
                new Hook(ReflectionHelper.GetMethodInfo(typeof(SetParticleEmissionSpeed), "OnUpdate"), OnUpdate);
            }
        }

        internal static event Delegates.OnUpdate_BeforeArgs _beforeOnUpdate;
        internal static event Delegates.OnUpdate_AfterArgs _afterOnUpdate;

        private static void OnUpdate(Action<SetParticleEmissionSpeed> orig, SetParticleEmissionSpeed self)
        {
            Delegates.Params_OnUpdate @params = new()
            {
                self = self
            };
            if (_beforeOnUpdate != null)
                foreach (Delegates.OnUpdate_BeforeArgs toInvoke in _beforeOnUpdate.GetInvocationList())
                    try
                    {
                        _beforeOnUpdate?.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }

            self = @params.self;
            orig(self);
            if (_afterOnUpdate != null)
                foreach (Delegates.OnUpdate_AfterArgs toInvoke in _afterOnUpdate.GetInvocationList())
                    try
                    {
                        _afterOnUpdate.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }
        }

        internal static void HookDoSetEmitSpeed()
        {
            if (!HookedList.Contains("DoSetEmitSpeed"))
            {
                HookedList.Add("DoSetEmitSpeed");
                new Hook(ReflectionHelper.GetMethodInfo(typeof(SetParticleEmissionSpeed), "DoSetEmitSpeed"),
                    DoSetEmitSpeed);
            }
        }

        internal static event Delegates.DoSetEmitSpeed_BeforeArgs _beforeDoSetEmitSpeed;
        internal static event Delegates.DoSetEmitSpeed_AfterArgs _afterDoSetEmitSpeed;

        private static void DoSetEmitSpeed(Action<SetParticleEmissionSpeed> orig, SetParticleEmissionSpeed self)
        {
            Delegates.Params_DoSetEmitSpeed @params = new()
            {
                self = self
            };
            if (_beforeDoSetEmitSpeed != null)
                foreach (Delegates.DoSetEmitSpeed_BeforeArgs toInvoke in _beforeDoSetEmitSpeed.GetInvocationList())
                    try
                    {
                        _beforeDoSetEmitSpeed?.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }

            self = @params.self;
            orig(self);
            if (_afterDoSetEmitSpeed != null)
                foreach (Delegates.DoSetEmitSpeed_AfterArgs toInvoke in _afterDoSetEmitSpeed.GetInvocationList())
                    try
                    {
                        _afterDoSetEmitSpeed.Invoke(@params);
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
        public delegate void DoSetEmitSpeed_AfterArgs(Params_DoSetEmitSpeed args);

        public delegate void DoSetEmitSpeed_BeforeArgs(Params_DoSetEmitSpeed args);

        public delegate void DoSetEmitSpeed_WithArgs(Action<SetParticleEmissionSpeed> orig,
            SetParticleEmissionSpeed self);

        public delegate void OnEnter_AfterArgs(Params_OnEnter args);

        public delegate void OnEnter_BeforeArgs(Params_OnEnter args);

        public delegate void OnEnter_WithArgs(Action<SetParticleEmissionSpeed> orig, SetParticleEmissionSpeed self);

        public delegate void OnUpdate_AfterArgs(Params_OnUpdate args);

        public delegate void OnUpdate_BeforeArgs(Params_OnUpdate args);

        public delegate void OnUpdate_WithArgs(Action<SetParticleEmissionSpeed> orig, SetParticleEmissionSpeed self);

        public delegate void Reset_AfterArgs(Params_Reset args);

        public delegate void Reset_BeforeArgs(Params_Reset args);

        public delegate void Reset_WithArgs(Action<SetParticleEmissionSpeed> orig, SetParticleEmissionSpeed self);

        public sealed class Params_Reset
        {
            public SetParticleEmissionSpeed self;
        }

        public sealed class Params_OnEnter
        {
            public SetParticleEmissionSpeed self;
        }

        public sealed class Params_OnUpdate
        {
            public SetParticleEmissionSpeed self;
        }

        public sealed class Params_DoSetEmitSpeed
        {
            public SetParticleEmissionSpeed self;
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

        public static event Delegates.OnUpdate_BeforeArgs OnUpdate
        {
            add
            {
                HookHandler._beforeOnUpdate += value;
                HookHandler.HookOnUpdate();
            }
            remove => HookHandler._beforeOnUpdate -= value;
        }

        public static event Delegates.DoSetEmitSpeed_BeforeArgs DoSetEmitSpeed
        {
            add
            {
                HookHandler._beforeDoSetEmitSpeed += value;
                HookHandler.HookDoSetEmitSpeed();
            }
            remove => HookHandler._beforeDoSetEmitSpeed -= value;
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

        public static event Delegates.OnUpdate_AfterArgs OnUpdate
        {
            add
            {
                HookHandler._afterOnUpdate += value;
                HookHandler.HookOnUpdate();
            }
            remove => HookHandler._afterOnUpdate -= value;
        }

        public static event Delegates.DoSetEmitSpeed_AfterArgs DoSetEmitSpeed
        {
            add
            {
                HookHandler._afterDoSetEmitSpeed += value;
                HookHandler.HookDoSetEmitSpeed();
            }
            remove => HookHandler._afterDoSetEmitSpeed -= value;
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
                ReflectionHelper.GetMethodInfo(typeof(SetParticleEmissionSpeed), "Reset"), value);
            remove => HookEndpointManager.Remove<Delegates.Reset_WithArgs>(
                ReflectionHelper.GetMethodInfo(typeof(SetParticleEmissionSpeed), "Reset"), value);
        }

        public static event Delegates.OnEnter_WithArgs OnEnter
        {
            add => HookEndpointManager.Add<Delegates.OnEnter_WithArgs>(
                ReflectionHelper.GetMethodInfo(typeof(SetParticleEmissionSpeed), "OnEnter"), value);
            remove => HookEndpointManager.Remove<Delegates.OnEnter_WithArgs>(
                ReflectionHelper.GetMethodInfo(typeof(SetParticleEmissionSpeed), "OnEnter"), value);
        }

        public static event Delegates.OnUpdate_WithArgs OnUpdate
        {
            add => HookEndpointManager.Add<Delegates.OnUpdate_WithArgs>(
                ReflectionHelper.GetMethodInfo(typeof(SetParticleEmissionSpeed), "OnUpdate"), value);
            remove => HookEndpointManager.Remove<Delegates.OnUpdate_WithArgs>(
                ReflectionHelper.GetMethodInfo(typeof(SetParticleEmissionSpeed), "OnUpdate"), value);
        }

        public static event Delegates.DoSetEmitSpeed_WithArgs DoSetEmitSpeed
        {
            add => HookEndpointManager.Add<Delegates.DoSetEmitSpeed_WithArgs>(
                ReflectionHelper.GetMethodInfo(typeof(SetParticleEmissionSpeed), "DoSetEmitSpeed"), value);
            remove => HookEndpointManager.Remove<Delegates.DoSetEmitSpeed_WithArgs>(
                ReflectionHelper.GetMethodInfo(typeof(SetParticleEmissionSpeed), "DoSetEmitSpeed"), value);
        }
    }
}