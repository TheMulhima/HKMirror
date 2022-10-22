using MonoMod.RuntimeDetour;
using MonoMod.RuntimeDetour.HookGen;

namespace HKMirror.Hooks.OnHooks;

/// <summary>
///     Contains different types of On Hooks for SetPosition class.<br />
///     Contains hooks that aren't generated by monomod, and before and after orig hooks for easier hooking.
/// </summary>
public static class OnSetPosition
{
    internal static class HookHandler
    {
        private static readonly List<string> HookedList = new();

        internal static void HookReset()
        {
            if (!HookedList.Contains("Reset"))
            {
                HookedList.Add("Reset");
                new Hook(ReflectionHelper.GetMethodInfo(typeof(SetPosition), "Reset"), Reset);
            }
        }

        internal static event Delegates.Reset_BeforeArgs _beforeReset;
        internal static event Delegates.Reset_AfterArgs _afterReset;

        private static void Reset(Action<SetPosition> orig, SetPosition self)
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
                new Hook(ReflectionHelper.GetMethodInfo(typeof(SetPosition), "OnPreprocess"), OnPreprocess);
            }
        }

        internal static event Delegates.OnPreprocess_BeforeArgs _beforeOnPreprocess;
        internal static event Delegates.OnPreprocess_AfterArgs _afterOnPreprocess;

        private static void OnPreprocess(Action<SetPosition> orig, SetPosition self)
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

        internal static void HookOnEnter()
        {
            if (!HookedList.Contains("OnEnter"))
            {
                HookedList.Add("OnEnter");
                new Hook(ReflectionHelper.GetMethodInfo(typeof(SetPosition), "OnEnter"), OnEnter);
            }
        }

        internal static event Delegates.OnEnter_BeforeArgs _beforeOnEnter;
        internal static event Delegates.OnEnter_AfterArgs _afterOnEnter;

        private static void OnEnter(Action<SetPosition> orig, SetPosition self)
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
                new Hook(ReflectionHelper.GetMethodInfo(typeof(SetPosition), "OnUpdate"), OnUpdate);
            }
        }

        internal static event Delegates.OnUpdate_BeforeArgs _beforeOnUpdate;
        internal static event Delegates.OnUpdate_AfterArgs _afterOnUpdate;

        private static void OnUpdate(Action<SetPosition> orig, SetPosition self)
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
                new Hook(ReflectionHelper.GetMethodInfo(typeof(SetPosition), "OnLateUpdate"), OnLateUpdate);
            }
        }

        internal static event Delegates.OnLateUpdate_BeforeArgs _beforeOnLateUpdate;
        internal static event Delegates.OnLateUpdate_AfterArgs _afterOnLateUpdate;

        private static void OnLateUpdate(Action<SetPosition> orig, SetPosition self)
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

        internal static void HookDoSetPosition()
        {
            if (!HookedList.Contains("DoSetPosition"))
            {
                HookedList.Add("DoSetPosition");
                new Hook(ReflectionHelper.GetMethodInfo(typeof(SetPosition), "DoSetPosition"), DoSetPosition);
            }
        }

        internal static event Delegates.DoSetPosition_BeforeArgs _beforeDoSetPosition;
        internal static event Delegates.DoSetPosition_AfterArgs _afterDoSetPosition;

        private static void DoSetPosition(Action<SetPosition> orig, SetPosition self)
        {
            Delegates.Params_DoSetPosition @params = new()
            {
                self = self
            };
            if (_beforeDoSetPosition != null)
                foreach (Delegates.DoSetPosition_BeforeArgs toInvoke in _beforeDoSetPosition.GetInvocationList())
                    try
                    {
                        _beforeDoSetPosition?.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }

            self = @params.self;
            orig(self);
            if (_afterDoSetPosition != null)
                foreach (Delegates.DoSetPosition_AfterArgs toInvoke in _afterDoSetPosition.GetInvocationList())
                    try
                    {
                        _afterDoSetPosition.Invoke(@params);
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
        public delegate void DoSetPosition_AfterArgs(Params_DoSetPosition args);

        public delegate void DoSetPosition_BeforeArgs(Params_DoSetPosition args);

        public delegate void DoSetPosition_WithArgs(Action<SetPosition> orig, SetPosition self);

        public delegate void OnEnter_AfterArgs(Params_OnEnter args);

        public delegate void OnEnter_BeforeArgs(Params_OnEnter args);

        public delegate void OnEnter_WithArgs(Action<SetPosition> orig, SetPosition self);

        public delegate void OnLateUpdate_AfterArgs(Params_OnLateUpdate args);

        public delegate void OnLateUpdate_BeforeArgs(Params_OnLateUpdate args);

        public delegate void OnLateUpdate_WithArgs(Action<SetPosition> orig, SetPosition self);

        public delegate void OnPreprocess_AfterArgs(Params_OnPreprocess args);

        public delegate void OnPreprocess_BeforeArgs(Params_OnPreprocess args);

        public delegate void OnPreprocess_WithArgs(Action<SetPosition> orig, SetPosition self);

        public delegate void OnUpdate_AfterArgs(Params_OnUpdate args);

        public delegate void OnUpdate_BeforeArgs(Params_OnUpdate args);

        public delegate void OnUpdate_WithArgs(Action<SetPosition> orig, SetPosition self);

        public delegate void Reset_AfterArgs(Params_Reset args);

        public delegate void Reset_BeforeArgs(Params_Reset args);

        public delegate void Reset_WithArgs(Action<SetPosition> orig, SetPosition self);

        public sealed class Params_Reset
        {
            public SetPosition self;
        }

        public sealed class Params_OnPreprocess
        {
            public SetPosition self;
        }

        public sealed class Params_OnEnter
        {
            public SetPosition self;
        }

        public sealed class Params_OnUpdate
        {
            public SetPosition self;
        }

        public sealed class Params_OnLateUpdate
        {
            public SetPosition self;
        }

        public sealed class Params_DoSetPosition
        {
            public SetPosition self;
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

        public static event Delegates.DoSetPosition_BeforeArgs DoSetPosition
        {
            add
            {
                HookHandler._beforeDoSetPosition += value;
                HookHandler.HookDoSetPosition();
            }
            remove => HookHandler._beforeDoSetPosition -= value;
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

        public static event Delegates.DoSetPosition_AfterArgs DoSetPosition
        {
            add
            {
                HookHandler._afterDoSetPosition += value;
                HookHandler.HookDoSetPosition();
            }
            remove => HookHandler._afterDoSetPosition -= value;
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
                ReflectionHelper.GetMethodInfo(typeof(SetPosition), "Reset"), value);
            remove => HookEndpointManager.Remove<Delegates.Reset_WithArgs>(
                ReflectionHelper.GetMethodInfo(typeof(SetPosition), "Reset"), value);
        }

        public static event Delegates.OnPreprocess_WithArgs OnPreprocess
        {
            add => HookEndpointManager.Add<Delegates.OnPreprocess_WithArgs>(
                ReflectionHelper.GetMethodInfo(typeof(SetPosition), "OnPreprocess"), value);
            remove => HookEndpointManager.Remove<Delegates.OnPreprocess_WithArgs>(
                ReflectionHelper.GetMethodInfo(typeof(SetPosition), "OnPreprocess"), value);
        }

        public static event Delegates.OnEnter_WithArgs OnEnter
        {
            add => HookEndpointManager.Add<Delegates.OnEnter_WithArgs>(
                ReflectionHelper.GetMethodInfo(typeof(SetPosition), "OnEnter"), value);
            remove => HookEndpointManager.Remove<Delegates.OnEnter_WithArgs>(
                ReflectionHelper.GetMethodInfo(typeof(SetPosition), "OnEnter"), value);
        }

        public static event Delegates.OnUpdate_WithArgs OnUpdate
        {
            add => HookEndpointManager.Add<Delegates.OnUpdate_WithArgs>(
                ReflectionHelper.GetMethodInfo(typeof(SetPosition), "OnUpdate"), value);
            remove => HookEndpointManager.Remove<Delegates.OnUpdate_WithArgs>(
                ReflectionHelper.GetMethodInfo(typeof(SetPosition), "OnUpdate"), value);
        }

        public static event Delegates.OnLateUpdate_WithArgs OnLateUpdate
        {
            add => HookEndpointManager.Add<Delegates.OnLateUpdate_WithArgs>(
                ReflectionHelper.GetMethodInfo(typeof(SetPosition), "OnLateUpdate"), value);
            remove => HookEndpointManager.Remove<Delegates.OnLateUpdate_WithArgs>(
                ReflectionHelper.GetMethodInfo(typeof(SetPosition), "OnLateUpdate"), value);
        }

        public static event Delegates.DoSetPosition_WithArgs DoSetPosition
        {
            add => HookEndpointManager.Add<Delegates.DoSetPosition_WithArgs>(
                ReflectionHelper.GetMethodInfo(typeof(SetPosition), "DoSetPosition"), value);
            remove => HookEndpointManager.Remove<Delegates.DoSetPosition_WithArgs>(
                ReflectionHelper.GetMethodInfo(typeof(SetPosition), "DoSetPosition"), value);
        }
    }
}