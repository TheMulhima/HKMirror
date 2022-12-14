using MonoMod.RuntimeDetour;
using MonoMod.RuntimeDetour.HookGen;

namespace HKMirror.Hooks.OnHooks;

/// <summary>
///     Contains different types of On Hooks for GetQuaternionMultipliedByVector class.<br />
///     Contains hooks that aren't generated by monomod, and before and after orig hooks for easier hooking.
/// </summary>
public static class OnGetQuaternionMultipliedByVector
{
    internal static class HookHandler
    {
        private static readonly List<string> HookedList = new();

        internal static void HookReset()
        {
            if (!HookedList.Contains("Reset"))
            {
                HookedList.Add("Reset");
                new Hook(ReflectionHelper.GetMethodInfo(typeof(GetQuaternionMultipliedByVector), "Reset"), Reset);
            }
        }

        internal static event Delegates.Reset_BeforeArgs _beforeReset;
        internal static event Delegates.Reset_AfterArgs _afterReset;

        private static void Reset(Action<GetQuaternionMultipliedByVector> orig, GetQuaternionMultipliedByVector self)
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
                new Hook(ReflectionHelper.GetMethodInfo(typeof(GetQuaternionMultipliedByVector), "OnEnter"), OnEnter);
            }
        }

        internal static event Delegates.OnEnter_BeforeArgs _beforeOnEnter;
        internal static event Delegates.OnEnter_AfterArgs _afterOnEnter;

        private static void OnEnter(Action<GetQuaternionMultipliedByVector> orig, GetQuaternionMultipliedByVector self)
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
                new Hook(ReflectionHelper.GetMethodInfo(typeof(GetQuaternionMultipliedByVector), "OnUpdate"), OnUpdate);
            }
        }

        internal static event Delegates.OnUpdate_BeforeArgs _beforeOnUpdate;
        internal static event Delegates.OnUpdate_AfterArgs _afterOnUpdate;

        private static void OnUpdate(Action<GetQuaternionMultipliedByVector> orig, GetQuaternionMultipliedByVector self)
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

        internal static void HookOnLateUpdate()
        {
            if (!HookedList.Contains("OnLateUpdate"))
            {
                HookedList.Add("OnLateUpdate");
                new Hook(ReflectionHelper.GetMethodInfo(typeof(GetQuaternionMultipliedByVector), "OnLateUpdate"),
                    OnLateUpdate);
            }
        }

        internal static event Delegates.OnLateUpdate_BeforeArgs _beforeOnLateUpdate;
        internal static event Delegates.OnLateUpdate_AfterArgs _afterOnLateUpdate;

        private static void OnLateUpdate(Action<GetQuaternionMultipliedByVector> orig,
            GetQuaternionMultipliedByVector self)
        {
            Delegates.Params_OnLateUpdate @params = new()
            {
                self = self
            };
            if (_beforeOnLateUpdate != null)
                foreach (Delegates.OnLateUpdate_BeforeArgs toInvoke in _beforeOnLateUpdate.GetInvocationList())
                    try
                    {
                        _beforeOnLateUpdate?.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }

            self = @params.self;
            orig(self);
            if (_afterOnLateUpdate != null)
                foreach (Delegates.OnLateUpdate_AfterArgs toInvoke in _afterOnLateUpdate.GetInvocationList())
                    try
                    {
                        _afterOnLateUpdate.Invoke(@params);
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
                new Hook(ReflectionHelper.GetMethodInfo(typeof(GetQuaternionMultipliedByVector), "OnFixedUpdate"),
                    OnFixedUpdate);
            }
        }

        internal static event Delegates.OnFixedUpdate_BeforeArgs _beforeOnFixedUpdate;
        internal static event Delegates.OnFixedUpdate_AfterArgs _afterOnFixedUpdate;

        private static void OnFixedUpdate(Action<GetQuaternionMultipliedByVector> orig,
            GetQuaternionMultipliedByVector self)
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

        internal static void HookDoQuatMult()
        {
            if (!HookedList.Contains("DoQuatMult"))
            {
                HookedList.Add("DoQuatMult");
                new Hook(ReflectionHelper.GetMethodInfo(typeof(GetQuaternionMultipliedByVector), "DoQuatMult"),
                    DoQuatMult);
            }
        }

        internal static event Delegates.DoQuatMult_BeforeArgs _beforeDoQuatMult;
        internal static event Delegates.DoQuatMult_AfterArgs _afterDoQuatMult;

        private static void DoQuatMult(Action<GetQuaternionMultipliedByVector> orig,
            GetQuaternionMultipliedByVector self)
        {
            Delegates.Params_DoQuatMult @params = new()
            {
                self = self
            };
            if (_beforeDoQuatMult != null)
                foreach (Delegates.DoQuatMult_BeforeArgs toInvoke in _beforeDoQuatMult.GetInvocationList())
                    try
                    {
                        _beforeDoQuatMult?.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }

            self = @params.self;
            orig(self);
            if (_afterDoQuatMult != null)
                foreach (Delegates.DoQuatMult_AfterArgs toInvoke in _afterDoQuatMult.GetInvocationList())
                    try
                    {
                        _afterDoQuatMult.Invoke(@params);
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
        public delegate void DoQuatMult_AfterArgs(Params_DoQuatMult args);

        public delegate void DoQuatMult_BeforeArgs(Params_DoQuatMult args);

        public delegate void DoQuatMult_WithArgs(Action<GetQuaternionMultipliedByVector> orig,
            GetQuaternionMultipliedByVector self);

        public delegate void OnEnter_AfterArgs(Params_OnEnter args);

        public delegate void OnEnter_BeforeArgs(Params_OnEnter args);

        public delegate void OnEnter_WithArgs(Action<GetQuaternionMultipliedByVector> orig,
            GetQuaternionMultipliedByVector self);

        public delegate void OnFixedUpdate_AfterArgs(Params_OnFixedUpdate args);

        public delegate void OnFixedUpdate_BeforeArgs(Params_OnFixedUpdate args);

        public delegate void OnFixedUpdate_WithArgs(Action<GetQuaternionMultipliedByVector> orig,
            GetQuaternionMultipliedByVector self);

        public delegate void OnLateUpdate_AfterArgs(Params_OnLateUpdate args);

        public delegate void OnLateUpdate_BeforeArgs(Params_OnLateUpdate args);

        public delegate void OnLateUpdate_WithArgs(Action<GetQuaternionMultipliedByVector> orig,
            GetQuaternionMultipliedByVector self);

        public delegate void OnUpdate_AfterArgs(Params_OnUpdate args);

        public delegate void OnUpdate_BeforeArgs(Params_OnUpdate args);

        public delegate void OnUpdate_WithArgs(Action<GetQuaternionMultipliedByVector> orig,
            GetQuaternionMultipliedByVector self);

        public delegate void Reset_AfterArgs(Params_Reset args);

        public delegate void Reset_BeforeArgs(Params_Reset args);

        public delegate void Reset_WithArgs(Action<GetQuaternionMultipliedByVector> orig,
            GetQuaternionMultipliedByVector self);

        public sealed class Params_Reset
        {
            public GetQuaternionMultipliedByVector self;
        }

        public sealed class Params_OnEnter
        {
            public GetQuaternionMultipliedByVector self;
        }

        public sealed class Params_OnUpdate
        {
            public GetQuaternionMultipliedByVector self;
        }

        public sealed class Params_OnLateUpdate
        {
            public GetQuaternionMultipliedByVector self;
        }

        public sealed class Params_OnFixedUpdate
        {
            public GetQuaternionMultipliedByVector self;
        }

        public sealed class Params_DoQuatMult
        {
            public GetQuaternionMultipliedByVector self;
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

        public static event Delegates.OnLateUpdate_BeforeArgs OnLateUpdate
        {
            add
            {
                HookHandler._beforeOnLateUpdate += value;
                HookHandler.HookOnLateUpdate();
            }
            remove => HookHandler._beforeOnLateUpdate -= value;
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

        public static event Delegates.DoQuatMult_BeforeArgs DoQuatMult
        {
            add
            {
                HookHandler._beforeDoQuatMult += value;
                HookHandler.HookDoQuatMult();
            }
            remove => HookHandler._beforeDoQuatMult -= value;
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

        public static event Delegates.OnLateUpdate_AfterArgs OnLateUpdate
        {
            add
            {
                HookHandler._afterOnLateUpdate += value;
                HookHandler.HookOnLateUpdate();
            }
            remove => HookHandler._afterOnLateUpdate -= value;
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

        public static event Delegates.DoQuatMult_AfterArgs DoQuatMult
        {
            add
            {
                HookHandler._afterDoQuatMult += value;
                HookHandler.HookDoQuatMult();
            }
            remove => HookHandler._afterDoQuatMult -= value;
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
                ReflectionHelper.GetMethodInfo(typeof(GetQuaternionMultipliedByVector), "Reset"), value);
            remove => HookEndpointManager.Remove<Delegates.Reset_WithArgs>(
                ReflectionHelper.GetMethodInfo(typeof(GetQuaternionMultipliedByVector), "Reset"), value);
        }

        public static event Delegates.OnEnter_WithArgs OnEnter
        {
            add => HookEndpointManager.Add<Delegates.OnEnter_WithArgs>(
                ReflectionHelper.GetMethodInfo(typeof(GetQuaternionMultipliedByVector), "OnEnter"), value);
            remove => HookEndpointManager.Remove<Delegates.OnEnter_WithArgs>(
                ReflectionHelper.GetMethodInfo(typeof(GetQuaternionMultipliedByVector), "OnEnter"), value);
        }

        public static event Delegates.OnUpdate_WithArgs OnUpdate
        {
            add => HookEndpointManager.Add<Delegates.OnUpdate_WithArgs>(
                ReflectionHelper.GetMethodInfo(typeof(GetQuaternionMultipliedByVector), "OnUpdate"), value);
            remove => HookEndpointManager.Remove<Delegates.OnUpdate_WithArgs>(
                ReflectionHelper.GetMethodInfo(typeof(GetQuaternionMultipliedByVector), "OnUpdate"), value);
        }

        public static event Delegates.OnLateUpdate_WithArgs OnLateUpdate
        {
            add => HookEndpointManager.Add<Delegates.OnLateUpdate_WithArgs>(
                ReflectionHelper.GetMethodInfo(typeof(GetQuaternionMultipliedByVector), "OnLateUpdate"), value);
            remove => HookEndpointManager.Remove<Delegates.OnLateUpdate_WithArgs>(
                ReflectionHelper.GetMethodInfo(typeof(GetQuaternionMultipliedByVector), "OnLateUpdate"), value);
        }

        public static event Delegates.OnFixedUpdate_WithArgs OnFixedUpdate
        {
            add => HookEndpointManager.Add<Delegates.OnFixedUpdate_WithArgs>(
                ReflectionHelper.GetMethodInfo(typeof(GetQuaternionMultipliedByVector), "OnFixedUpdate"), value);
            remove => HookEndpointManager.Remove<Delegates.OnFixedUpdate_WithArgs>(
                ReflectionHelper.GetMethodInfo(typeof(GetQuaternionMultipliedByVector), "OnFixedUpdate"), value);
        }

        public static event Delegates.DoQuatMult_WithArgs DoQuatMult
        {
            add => HookEndpointManager.Add<Delegates.DoQuatMult_WithArgs>(
                ReflectionHelper.GetMethodInfo(typeof(GetQuaternionMultipliedByVector), "DoQuatMult"), value);
            remove => HookEndpointManager.Remove<Delegates.DoQuatMult_WithArgs>(
                ReflectionHelper.GetMethodInfo(typeof(GetQuaternionMultipliedByVector), "DoQuatMult"), value);
        }
    }
}