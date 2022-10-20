using MonoMod.RuntimeDetour;
using MonoMod.RuntimeDetour.HookGen;

namespace HKMirror.Hooks.OnHooks;

/// <summary>
///     Contains different types of On Hooks for Decelerate class.<br />
///     Contains hooks that aren't generated by monomod, and before and after orig hooks for easier hooking.
/// </summary>
public static class OnDecelerate
{
    internal static class HookHandler
    {
        private static readonly List<string> HookedList = new();

        internal static void HookReset()
        {
            if (!HookedList.Contains("Reset"))
            {
                HookedList.Add("Reset");
                new Hook(ReflectionHelper.GetMethodInfo(typeof(Decelerate), "Reset"), Reset);
            }
        }

        internal static event Delegates.Reset_BeforeArgs _beforeReset;
        internal static event Delegates.Reset_NormalArgs _afterReset;

        private static void Reset(Action<Decelerate> orig, Decelerate self)
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
                new Hook(ReflectionHelper.GetMethodInfo(typeof(Decelerate), "OnPreprocess"), OnPreprocess);
            }
        }

        internal static event Delegates.OnPreprocess_BeforeArgs _beforeOnPreprocess;
        internal static event Delegates.OnPreprocess_NormalArgs _afterOnPreprocess;

        private static void OnPreprocess(Action<Decelerate> orig, Decelerate self)
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

        internal static void HookAwake()
        {
            if (!HookedList.Contains("Awake"))
            {
                HookedList.Add("Awake");
                new Hook(ReflectionHelper.GetMethodInfo(typeof(Decelerate), "Awake"), Awake);
            }
        }

        internal static event Delegates.Awake_BeforeArgs _beforeAwake;
        internal static event Delegates.Awake_NormalArgs _afterAwake;

        private static void Awake(Action<Decelerate> orig, Decelerate self)
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

        internal static void HookOnEnter()
        {
            if (!HookedList.Contains("OnEnter"))
            {
                HookedList.Add("OnEnter");
                new Hook(ReflectionHelper.GetMethodInfo(typeof(Decelerate), "OnEnter"), OnEnter);
            }
        }

        internal static event Delegates.OnEnter_BeforeArgs _beforeOnEnter;
        internal static event Delegates.OnEnter_NormalArgs _afterOnEnter;

        private static void OnEnter(Action<Decelerate> orig, Decelerate self)
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
                new Hook(ReflectionHelper.GetMethodInfo(typeof(Decelerate), "OnFixedUpdate"), OnFixedUpdate);
            }
        }

        internal static event Delegates.OnFixedUpdate_BeforeArgs _beforeOnFixedUpdate;
        internal static event Delegates.OnFixedUpdate_NormalArgs _afterOnFixedUpdate;

        private static void OnFixedUpdate(Action<Decelerate> orig, Decelerate self)
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

        internal static void HookDecelerateSelf()
        {
            if (!HookedList.Contains("DecelerateSelf"))
            {
                HookedList.Add("DecelerateSelf");
                new Hook(ReflectionHelper.GetMethodInfo(typeof(Decelerate), "DecelerateSelf"), DecelerateSelf);
            }
        }

        internal static event Delegates.DecelerateSelf_BeforeArgs _beforeDecelerateSelf;
        internal static event Delegates.DecelerateSelf_NormalArgs _afterDecelerateSelf;

        private static void DecelerateSelf(Action<Decelerate> orig, Decelerate self)
        {
            Delegates.Params_DecelerateSelf @params = new()
            {
                self = self
            };
            _beforeDecelerateSelf?.Invoke(@params);
            self = @params.self;
            orig(self);
            if (_afterDecelerateSelf != null) _afterDecelerateSelf.Invoke(@params);
        }
    }

    /// <summary>
    ///     Contains necessary information to create Hooks. Does not contain any hooks
    /// </summary>
    public static class Delegates
    {
        public delegate void Awake_BeforeArgs(Params_Awake args);

        public delegate void Awake_NormalArgs(Params_Awake args);

        public delegate void DecelerateSelf_BeforeArgs(Params_DecelerateSelf args);

        public delegate void DecelerateSelf_NormalArgs(Params_DecelerateSelf args);

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
            public Decelerate self;
        }

        public sealed class Params_OnPreprocess
        {
            public Decelerate self;
        }

        public sealed class Params_Awake
        {
            public Decelerate self;
        }

        public sealed class Params_OnEnter
        {
            public Decelerate self;
        }

        public sealed class Params_OnFixedUpdate
        {
            public Decelerate self;
        }

        public sealed class Params_DecelerateSelf
        {
            public Decelerate self;
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

        public static event Delegates.OnFixedUpdate_BeforeArgs OnFixedUpdate
        {
            add
            {
                HookHandler._beforeOnFixedUpdate += value;
                HookHandler.HookOnFixedUpdate();
            }
            remove => HookHandler._beforeOnFixedUpdate -= value;
        }

        public static event Delegates.DecelerateSelf_BeforeArgs DecelerateSelf
        {
            add
            {
                HookHandler._beforeDecelerateSelf += value;
                HookHandler.HookDecelerateSelf();
            }
            remove => HookHandler._beforeDecelerateSelf -= value;
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

        public static event Delegates.Awake_NormalArgs Awake
        {
            add
            {
                HookHandler._afterAwake += value;
                HookHandler.HookAwake();
            }
            remove => HookHandler._afterAwake -= value;
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

        public static event Delegates.DecelerateSelf_NormalArgs DecelerateSelf
        {
            add
            {
                HookHandler._afterDecelerateSelf += value;
                HookHandler.HookDecelerateSelf();
            }
            remove => HookHandler._afterDecelerateSelf -= value;
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
                ReflectionHelper.GetMethodInfo(typeof(Decelerate), "Reset"), value);
            remove => HookEndpointManager.Remove<Delegates.Reset_NormalArgs>(
                ReflectionHelper.GetMethodInfo(typeof(Decelerate), "Reset"), value);
        }

        public static event Delegates.OnPreprocess_NormalArgs OnPreprocess
        {
            add => HookEndpointManager.Add<Delegates.OnPreprocess_NormalArgs>(
                ReflectionHelper.GetMethodInfo(typeof(Decelerate), "OnPreprocess"), value);
            remove => HookEndpointManager.Remove<Delegates.OnPreprocess_NormalArgs>(
                ReflectionHelper.GetMethodInfo(typeof(Decelerate), "OnPreprocess"), value);
        }

        public static event Delegates.Awake_NormalArgs Awake
        {
            add => HookEndpointManager.Add<Delegates.Awake_NormalArgs>(
                ReflectionHelper.GetMethodInfo(typeof(Decelerate), "Awake"), value);
            remove => HookEndpointManager.Remove<Delegates.Awake_NormalArgs>(
                ReflectionHelper.GetMethodInfo(typeof(Decelerate), "Awake"), value);
        }

        public static event Delegates.OnEnter_NormalArgs OnEnter
        {
            add => HookEndpointManager.Add<Delegates.OnEnter_NormalArgs>(
                ReflectionHelper.GetMethodInfo(typeof(Decelerate), "OnEnter"), value);
            remove => HookEndpointManager.Remove<Delegates.OnEnter_NormalArgs>(
                ReflectionHelper.GetMethodInfo(typeof(Decelerate), "OnEnter"), value);
        }

        public static event Delegates.OnFixedUpdate_NormalArgs OnFixedUpdate
        {
            add => HookEndpointManager.Add<Delegates.OnFixedUpdate_NormalArgs>(
                ReflectionHelper.GetMethodInfo(typeof(Decelerate), "OnFixedUpdate"), value);
            remove => HookEndpointManager.Remove<Delegates.OnFixedUpdate_NormalArgs>(
                ReflectionHelper.GetMethodInfo(typeof(Decelerate), "OnFixedUpdate"), value);
        }

        public static event Delegates.DecelerateSelf_NormalArgs DecelerateSelf
        {
            add => HookEndpointManager.Add<Delegates.DecelerateSelf_NormalArgs>(
                ReflectionHelper.GetMethodInfo(typeof(Decelerate), "DecelerateSelf"), value);
            remove => HookEndpointManager.Remove<Delegates.DecelerateSelf_NormalArgs>(
                ReflectionHelper.GetMethodInfo(typeof(Decelerate), "DecelerateSelf"), value);
        }
    }
}