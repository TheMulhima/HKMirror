using MonoMod.RuntimeDetour;
using MonoMod.RuntimeDetour.HookGen;

namespace HKMirror.Hooks.OnHooks;

/// <summary>
///     Contains different types of On Hooks for GetAngleToTarget class.<br />
///     Contains hooks that aren't generated by monomod, and before and after orig hooks for easier hooking.
/// </summary>
public static class OnGetAngleToTarget
{
    internal static class HookHandler
    {
        private static readonly List<string> HookedList = new();

        internal static void HookReset()
        {
            if (!HookedList.Contains("Reset"))
            {
                HookedList.Add("Reset");
                new Hook(ReflectionHelper.GetMethodInfo(typeof(GetAngleToTarget), "Reset"), Reset);
            }
        }

        internal static event Delegates.Reset_BeforeArgs _beforeReset;
        internal static event Delegates.Reset_AfterArgs _afterReset;

        private static void Reset(Action<GetAngleToTarget> orig, GetAngleToTarget self)
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

        internal static void HookOnPreprocess()
        {
            if (!HookedList.Contains("OnPreprocess"))
            {
                HookedList.Add("OnPreprocess");
                new Hook(ReflectionHelper.GetMethodInfo(typeof(GetAngleToTarget), "OnPreprocess"), OnPreprocess);
            }
        }

        internal static event Delegates.OnPreprocess_BeforeArgs _beforeOnPreprocess;
        internal static event Delegates.OnPreprocess_AfterArgs _afterOnPreprocess;

        private static void OnPreprocess(Action<GetAngleToTarget> orig, GetAngleToTarget self)
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

        internal static void HookOnLateUpdate()
        {
            if (!HookedList.Contains("OnLateUpdate"))
            {
                HookedList.Add("OnLateUpdate");
                new Hook(ReflectionHelper.GetMethodInfo(typeof(GetAngleToTarget), "OnLateUpdate"), OnLateUpdate);
            }
        }

        internal static event Delegates.OnLateUpdate_BeforeArgs _beforeOnLateUpdate;
        internal static event Delegates.OnLateUpdate_AfterArgs _afterOnLateUpdate;

        private static void OnLateUpdate(Action<GetAngleToTarget> orig, GetAngleToTarget self)
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

        internal static void HookDoGetAngleToTarget()
        {
            if (!HookedList.Contains("DoGetAngleToTarget"))
            {
                HookedList.Add("DoGetAngleToTarget");
                new Hook(ReflectionHelper.GetMethodInfo(typeof(GetAngleToTarget), "DoGetAngleToTarget"),
                    DoGetAngleToTarget);
            }
        }

        internal static event Delegates.DoGetAngleToTarget_BeforeArgs _beforeDoGetAngleToTarget;
        internal static event Delegates.DoGetAngleToTarget_AfterArgs _afterDoGetAngleToTarget;

        private static void DoGetAngleToTarget(Action<GetAngleToTarget> orig, GetAngleToTarget self)
        {
            Delegates.Params_DoGetAngleToTarget @params = new()
            {
                self = self
            };
            if (_beforeDoGetAngleToTarget != null)
                foreach (Delegates.DoGetAngleToTarget_BeforeArgs toInvoke in
                         _beforeDoGetAngleToTarget.GetInvocationList())
                    try
                    {
                        _beforeDoGetAngleToTarget?.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }

            self = @params.self;
            orig(self);
            if (_afterDoGetAngleToTarget != null)
                foreach (Delegates.DoGetAngleToTarget_AfterArgs toInvoke in
                         _afterDoGetAngleToTarget.GetInvocationList())
                    try
                    {
                        _afterDoGetAngleToTarget.Invoke(@params);
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
        public delegate void DoGetAngleToTarget_AfterArgs(Params_DoGetAngleToTarget args);

        public delegate void DoGetAngleToTarget_BeforeArgs(Params_DoGetAngleToTarget args);

        public delegate void DoGetAngleToTarget_WithArgs(Action<GetAngleToTarget> orig, GetAngleToTarget self);

        public delegate void OnLateUpdate_AfterArgs(Params_OnLateUpdate args);

        public delegate void OnLateUpdate_BeforeArgs(Params_OnLateUpdate args);

        public delegate void OnLateUpdate_WithArgs(Action<GetAngleToTarget> orig, GetAngleToTarget self);

        public delegate void OnPreprocess_AfterArgs(Params_OnPreprocess args);

        public delegate void OnPreprocess_BeforeArgs(Params_OnPreprocess args);

        public delegate void OnPreprocess_WithArgs(Action<GetAngleToTarget> orig, GetAngleToTarget self);

        public delegate void Reset_AfterArgs(Params_Reset args);

        public delegate void Reset_BeforeArgs(Params_Reset args);

        public delegate void Reset_WithArgs(Action<GetAngleToTarget> orig, GetAngleToTarget self);

        public sealed class Params_Reset
        {
            public GetAngleToTarget self;
        }

        public sealed class Params_OnPreprocess
        {
            public GetAngleToTarget self;
        }

        public sealed class Params_OnLateUpdate
        {
            public GetAngleToTarget self;
        }

        public sealed class Params_DoGetAngleToTarget
        {
            public GetAngleToTarget self;
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

        public static event Delegates.OnLateUpdate_BeforeArgs OnLateUpdate
        {
            add
            {
                HookHandler._beforeOnLateUpdate += value;
                HookHandler.HookOnLateUpdate();
            }
            remove => HookHandler._beforeOnLateUpdate -= value;
        }

        public static event Delegates.DoGetAngleToTarget_BeforeArgs DoGetAngleToTarget
        {
            add
            {
                HookHandler._beforeDoGetAngleToTarget += value;
                HookHandler.HookDoGetAngleToTarget();
            }
            remove => HookHandler._beforeDoGetAngleToTarget -= value;
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

        public static event Delegates.OnPreprocess_AfterArgs OnPreprocess
        {
            add
            {
                HookHandler._afterOnPreprocess += value;
                HookHandler.HookOnPreprocess();
            }
            remove => HookHandler._afterOnPreprocess -= value;
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

        public static event Delegates.DoGetAngleToTarget_AfterArgs DoGetAngleToTarget
        {
            add
            {
                HookHandler._afterDoGetAngleToTarget += value;
                HookHandler.HookDoGetAngleToTarget();
            }
            remove => HookHandler._afterDoGetAngleToTarget -= value;
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
                ReflectionHelper.GetMethodInfo(typeof(GetAngleToTarget), "Reset"), value);
            remove => HookEndpointManager.Remove<Delegates.Reset_WithArgs>(
                ReflectionHelper.GetMethodInfo(typeof(GetAngleToTarget), "Reset"), value);
        }

        public static event Delegates.OnPreprocess_WithArgs OnPreprocess
        {
            add => HookEndpointManager.Add<Delegates.OnPreprocess_WithArgs>(
                ReflectionHelper.GetMethodInfo(typeof(GetAngleToTarget), "OnPreprocess"), value);
            remove => HookEndpointManager.Remove<Delegates.OnPreprocess_WithArgs>(
                ReflectionHelper.GetMethodInfo(typeof(GetAngleToTarget), "OnPreprocess"), value);
        }

        public static event Delegates.OnLateUpdate_WithArgs OnLateUpdate
        {
            add => HookEndpointManager.Add<Delegates.OnLateUpdate_WithArgs>(
                ReflectionHelper.GetMethodInfo(typeof(GetAngleToTarget), "OnLateUpdate"), value);
            remove => HookEndpointManager.Remove<Delegates.OnLateUpdate_WithArgs>(
                ReflectionHelper.GetMethodInfo(typeof(GetAngleToTarget), "OnLateUpdate"), value);
        }

        public static event Delegates.DoGetAngleToTarget_WithArgs DoGetAngleToTarget
        {
            add => HookEndpointManager.Add<Delegates.DoGetAngleToTarget_WithArgs>(
                ReflectionHelper.GetMethodInfo(typeof(GetAngleToTarget), "DoGetAngleToTarget"), value);
            remove => HookEndpointManager.Remove<Delegates.DoGetAngleToTarget_WithArgs>(
                ReflectionHelper.GetMethodInfo(typeof(GetAngleToTarget), "DoGetAngleToTarget"), value);
        }
    }
}