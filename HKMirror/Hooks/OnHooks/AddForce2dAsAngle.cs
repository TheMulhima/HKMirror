using MonoMod.RuntimeDetour;
using MonoMod.RuntimeDetour.HookGen;

namespace HKMirror.Hooks.OnHooks;

/// <summary>
///     Contains different types of On Hooks for AddForce2dAsAngle class.<br />
///     Contains hooks that aren't generated by monomod, and before and after orig hooks for easier hooking.
/// </summary>
public static class OnAddForce2dAsAngle
{
    internal static class HookHandler
    {
        private static readonly List<string> HookedList = new();

        internal static void HookReset()
        {
            if (!HookedList.Contains("Reset"))
            {
                HookedList.Add("Reset");
                new Hook(ReflectionHelper.GetMethodInfo(typeof(AddForce2dAsAngle), "Reset"), Reset);
            }
        }

        internal static event Delegates.Reset_BeforeArgs _beforeReset;
        internal static event Delegates.Reset_AfterArgs _afterReset;

        private static void Reset(Action<AddForce2dAsAngle> orig, AddForce2dAsAngle self)
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
                new Hook(ReflectionHelper.GetMethodInfo(typeof(AddForce2dAsAngle), "Awake"), Awake);
            }
        }

        internal static event Delegates.Awake_BeforeArgs _beforeAwake;
        internal static event Delegates.Awake_AfterArgs _afterAwake;

        private static void Awake(Action<AddForce2dAsAngle> orig, AddForce2dAsAngle self)
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

        internal static void HookOnPreprocess()
        {
            if (!HookedList.Contains("OnPreprocess"))
            {
                HookedList.Add("OnPreprocess");
                new Hook(ReflectionHelper.GetMethodInfo(typeof(AddForce2dAsAngle), "OnPreprocess"), OnPreprocess);
            }
        }

        internal static event Delegates.OnPreprocess_BeforeArgs _beforeOnPreprocess;
        internal static event Delegates.OnPreprocess_AfterArgs _afterOnPreprocess;

        private static void OnPreprocess(Action<AddForce2dAsAngle> orig, AddForce2dAsAngle self)
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
                new Hook(ReflectionHelper.GetMethodInfo(typeof(AddForce2dAsAngle), "OnEnter"), OnEnter);
            }
        }

        internal static event Delegates.OnEnter_BeforeArgs _beforeOnEnter;
        internal static event Delegates.OnEnter_AfterArgs _afterOnEnter;

        private static void OnEnter(Action<AddForce2dAsAngle> orig, AddForce2dAsAngle self)
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

        internal static void HookOnFixedUpdate()
        {
            if (!HookedList.Contains("OnFixedUpdate"))
            {
                HookedList.Add("OnFixedUpdate");
                new Hook(ReflectionHelper.GetMethodInfo(typeof(AddForce2dAsAngle), "OnFixedUpdate"), OnFixedUpdate);
            }
        }

        internal static event Delegates.OnFixedUpdate_BeforeArgs _beforeOnFixedUpdate;
        internal static event Delegates.OnFixedUpdate_AfterArgs _afterOnFixedUpdate;

        private static void OnFixedUpdate(Action<AddForce2dAsAngle> orig, AddForce2dAsAngle self)
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

        internal static void HookDoAddForce()
        {
            if (!HookedList.Contains("DoAddForce"))
            {
                HookedList.Add("DoAddForce");
                new Hook(ReflectionHelper.GetMethodInfo(typeof(AddForce2dAsAngle), "DoAddForce"), DoAddForce);
            }
        }

        internal static event Delegates.DoAddForce_BeforeArgs _beforeDoAddForce;
        internal static event Delegates.DoAddForce_AfterArgs _afterDoAddForce;

        private static void DoAddForce(Action<AddForce2dAsAngle> orig, AddForce2dAsAngle self)
        {
            Delegates.Params_DoAddForce @params = new()
            {
                self = self
            };
            if (_beforeDoAddForce != null)
                foreach (Delegates.DoAddForce_BeforeArgs toInvoke in _beforeDoAddForce.GetInvocationList())
                    try
                    {
                        _beforeDoAddForce?.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }

            self = @params.self;
            orig(self);
            if (_afterDoAddForce != null)
                foreach (Delegates.DoAddForce_AfterArgs toInvoke in _afterDoAddForce.GetInvocationList())
                    try
                    {
                        _afterDoAddForce.Invoke(@params);
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

        public delegate void Awake_WithArgs(Action<AddForce2dAsAngle> orig, AddForce2dAsAngle self);

        public delegate void DoAddForce_AfterArgs(Params_DoAddForce args);

        public delegate void DoAddForce_BeforeArgs(Params_DoAddForce args);

        public delegate void DoAddForce_WithArgs(Action<AddForce2dAsAngle> orig, AddForce2dAsAngle self);

        public delegate void OnEnter_AfterArgs(Params_OnEnter args);

        public delegate void OnEnter_BeforeArgs(Params_OnEnter args);

        public delegate void OnEnter_WithArgs(Action<AddForce2dAsAngle> orig, AddForce2dAsAngle self);

        public delegate void OnFixedUpdate_AfterArgs(Params_OnFixedUpdate args);

        public delegate void OnFixedUpdate_BeforeArgs(Params_OnFixedUpdate args);

        public delegate void OnFixedUpdate_WithArgs(Action<AddForce2dAsAngle> orig, AddForce2dAsAngle self);

        public delegate void OnPreprocess_AfterArgs(Params_OnPreprocess args);

        public delegate void OnPreprocess_BeforeArgs(Params_OnPreprocess args);

        public delegate void OnPreprocess_WithArgs(Action<AddForce2dAsAngle> orig, AddForce2dAsAngle self);

        public delegate void Reset_AfterArgs(Params_Reset args);

        public delegate void Reset_BeforeArgs(Params_Reset args);

        public delegate void Reset_WithArgs(Action<AddForce2dAsAngle> orig, AddForce2dAsAngle self);

        public sealed class Params_Reset
        {
            public AddForce2dAsAngle self;
        }

        public sealed class Params_Awake
        {
            public AddForce2dAsAngle self;
        }

        public sealed class Params_OnPreprocess
        {
            public AddForce2dAsAngle self;
        }

        public sealed class Params_OnEnter
        {
            public AddForce2dAsAngle self;
        }

        public sealed class Params_OnFixedUpdate
        {
            public AddForce2dAsAngle self;
        }

        public sealed class Params_DoAddForce
        {
            public AddForce2dAsAngle self;
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

        public static event Delegates.OnFixedUpdate_BeforeArgs OnFixedUpdate
        {
            add
            {
                HookHandler._beforeOnFixedUpdate += value;
                HookHandler.HookOnFixedUpdate();
            }
            remove => HookHandler._beforeOnFixedUpdate -= value;
        }

        public static event Delegates.DoAddForce_BeforeArgs DoAddForce
        {
            add
            {
                HookHandler._beforeDoAddForce += value;
                HookHandler.HookDoAddForce();
            }
            remove => HookHandler._beforeDoAddForce -= value;
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

        public static event Delegates.OnFixedUpdate_AfterArgs OnFixedUpdate
        {
            add
            {
                HookHandler._afterOnFixedUpdate += value;
                HookHandler.HookOnFixedUpdate();
            }
            remove => HookHandler._afterOnFixedUpdate -= value;
        }

        public static event Delegates.DoAddForce_AfterArgs DoAddForce
        {
            add
            {
                HookHandler._afterDoAddForce += value;
                HookHandler.HookDoAddForce();
            }
            remove => HookHandler._afterDoAddForce -= value;
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
                ReflectionHelper.GetMethodInfo(typeof(AddForce2dAsAngle), "Reset"), value);
            remove => HookEndpointManager.Remove<Delegates.Reset_WithArgs>(
                ReflectionHelper.GetMethodInfo(typeof(AddForce2dAsAngle), "Reset"), value);
        }

        public static event Delegates.Awake_WithArgs Awake
        {
            add => HookEndpointManager.Add<Delegates.Awake_WithArgs>(
                ReflectionHelper.GetMethodInfo(typeof(AddForce2dAsAngle), "Awake"), value);
            remove => HookEndpointManager.Remove<Delegates.Awake_WithArgs>(
                ReflectionHelper.GetMethodInfo(typeof(AddForce2dAsAngle), "Awake"), value);
        }

        public static event Delegates.OnPreprocess_WithArgs OnPreprocess
        {
            add => HookEndpointManager.Add<Delegates.OnPreprocess_WithArgs>(
                ReflectionHelper.GetMethodInfo(typeof(AddForce2dAsAngle), "OnPreprocess"), value);
            remove => HookEndpointManager.Remove<Delegates.OnPreprocess_WithArgs>(
                ReflectionHelper.GetMethodInfo(typeof(AddForce2dAsAngle), "OnPreprocess"), value);
        }

        public static event Delegates.OnEnter_WithArgs OnEnter
        {
            add => HookEndpointManager.Add<Delegates.OnEnter_WithArgs>(
                ReflectionHelper.GetMethodInfo(typeof(AddForce2dAsAngle), "OnEnter"), value);
            remove => HookEndpointManager.Remove<Delegates.OnEnter_WithArgs>(
                ReflectionHelper.GetMethodInfo(typeof(AddForce2dAsAngle), "OnEnter"), value);
        }

        public static event Delegates.OnFixedUpdate_WithArgs OnFixedUpdate
        {
            add => HookEndpointManager.Add<Delegates.OnFixedUpdate_WithArgs>(
                ReflectionHelper.GetMethodInfo(typeof(AddForce2dAsAngle), "OnFixedUpdate"), value);
            remove => HookEndpointManager.Remove<Delegates.OnFixedUpdate_WithArgs>(
                ReflectionHelper.GetMethodInfo(typeof(AddForce2dAsAngle), "OnFixedUpdate"), value);
        }

        public static event Delegates.DoAddForce_WithArgs DoAddForce
        {
            add => HookEndpointManager.Add<Delegates.DoAddForce_WithArgs>(
                ReflectionHelper.GetMethodInfo(typeof(AddForce2dAsAngle), "DoAddForce"), value);
            remove => HookEndpointManager.Remove<Delegates.DoAddForce_WithArgs>(
                ReflectionHelper.GetMethodInfo(typeof(AddForce2dAsAngle), "DoAddForce"), value);
        }
    }
}