using MonoMod.RuntimeDetour;
using MonoMod.RuntimeDetour.HookGen;

namespace HKMirror.Hooks.OnHooks;

/// <summary>
///     Contains different types of On Hooks for CheckCollisionSide class.<br />
///     Contains hooks that aren't generated by monomod, and before and after orig hooks for easier hooking.
/// </summary>
public static class OnCheckCollisionSide
{
    internal static class HookHandler
    {
        private static readonly List<string> HookedList = new();

        internal static void HookReset()
        {
            if (!HookedList.Contains("Reset"))
            {
                HookedList.Add("Reset");
                new Hook(ReflectionHelper.GetMethodInfo(typeof(CheckCollisionSide), "Reset"), Reset);
            }
        }

        internal static event Delegates.Reset_BeforeArgs _beforeReset;
        internal static event Delegates.Reset_NormalArgs _afterReset;

        private static void Reset(Action<CheckCollisionSide> orig, CheckCollisionSide self)
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

        internal static void HookOnEnter()
        {
            if (!HookedList.Contains("OnEnter"))
            {
                HookedList.Add("OnEnter");
                new Hook(ReflectionHelper.GetMethodInfo(typeof(CheckCollisionSide), "OnEnter"), OnEnter);
            }
        }

        internal static event Delegates.OnEnter_BeforeArgs _beforeOnEnter;
        internal static event Delegates.OnEnter_NormalArgs _afterOnEnter;

        private static void OnEnter(Action<CheckCollisionSide> orig, CheckCollisionSide self)
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

        internal static void HookOnExit()
        {
            if (!HookedList.Contains("OnExit"))
            {
                HookedList.Add("OnExit");
                new Hook(ReflectionHelper.GetMethodInfo(typeof(CheckCollisionSide), "OnExit"), OnExit);
            }
        }

        internal static event Delegates.OnExit_BeforeArgs _beforeOnExit;
        internal static event Delegates.OnExit_NormalArgs _afterOnExit;

        private static void OnExit(Action<CheckCollisionSide> orig, CheckCollisionSide self)
        {
            Delegates.Params_OnExit @params = new()
            {
                self = self
            };
            _beforeOnExit?.Invoke(@params);
            self = @params.self;
            orig(self);
            if (_afterOnExit != null) _afterOnExit.Invoke(@params);
        }

        internal static void HookOnUpdate()
        {
            if (!HookedList.Contains("OnUpdate"))
            {
                HookedList.Add("OnUpdate");
                new Hook(ReflectionHelper.GetMethodInfo(typeof(CheckCollisionSide), "OnUpdate"), OnUpdate);
            }
        }

        internal static event Delegates.OnUpdate_BeforeArgs _beforeOnUpdate;
        internal static event Delegates.OnUpdate_NormalArgs _afterOnUpdate;

        private static void OnUpdate(Action<CheckCollisionSide> orig, CheckCollisionSide self)
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

        internal static void HookDoCollisionStay2D()
        {
            if (!HookedList.Contains("DoCollisionStay2D"))
            {
                HookedList.Add("DoCollisionStay2D");
                new Hook(ReflectionHelper.GetMethodInfo(typeof(CheckCollisionSide), "DoCollisionStay2D"),
                    DoCollisionStay2D);
            }
        }

        internal static event Delegates.DoCollisionStay2D_BeforeArgs _beforeDoCollisionStay2D;
        internal static event Delegates.DoCollisionStay2D_NormalArgs _afterDoCollisionStay2D;

        private static void DoCollisionStay2D(Action<CheckCollisionSide, Collision2D> orig, CheckCollisionSide self,
            Collision2D collision)
        {
            Delegates.Params_DoCollisionStay2D @params = new()
            {
                self = self, collision = collision
            };
            _beforeDoCollisionStay2D?.Invoke(@params);
            self = @params.self;
            collision = @params.collision;
            orig(self, collision);
            if (_afterDoCollisionStay2D != null) _afterDoCollisionStay2D.Invoke(@params);
        }

        internal static void HookDoCollisionExit2D()
        {
            if (!HookedList.Contains("DoCollisionExit2D"))
            {
                HookedList.Add("DoCollisionExit2D");
                new Hook(ReflectionHelper.GetMethodInfo(typeof(CheckCollisionSide), "DoCollisionExit2D"),
                    DoCollisionExit2D);
            }
        }

        internal static event Delegates.DoCollisionExit2D_BeforeArgs _beforeDoCollisionExit2D;
        internal static event Delegates.DoCollisionExit2D_NormalArgs _afterDoCollisionExit2D;

        private static void DoCollisionExit2D(Action<CheckCollisionSide, Collision2D> orig, CheckCollisionSide self,
            Collision2D collision)
        {
            Delegates.Params_DoCollisionExit2D @params = new()
            {
                self = self, collision = collision
            };
            _beforeDoCollisionExit2D?.Invoke(@params);
            self = @params.self;
            collision = @params.collision;
            orig(self, collision);
            if (_afterDoCollisionExit2D != null) _afterDoCollisionExit2D.Invoke(@params);
        }

        internal static void HookCheckTouching()
        {
            if (!HookedList.Contains("CheckTouching"))
            {
                HookedList.Add("CheckTouching");
                new Hook(ReflectionHelper.GetMethodInfo(typeof(CheckCollisionSide), "CheckTouching"), CheckTouching);
            }
        }

        internal static event Delegates.CheckTouching_BeforeArgs _beforeCheckTouching;
        internal static event Delegates.CheckTouching_NormalArgs _afterCheckTouching;

        private static void CheckTouching(Action<CheckCollisionSide, LayerMask> orig, CheckCollisionSide self,
            LayerMask layer)
        {
            Delegates.Params_CheckTouching @params = new()
            {
                self = self, layer = layer
            };
            _beforeCheckTouching?.Invoke(@params);
            self = @params.self;
            layer = @params.layer;
            orig(self, layer);
            if (_afterCheckTouching != null) _afterCheckTouching.Invoke(@params);
        }
    }

    /// <summary>
    ///     Contains necessary information to create Hooks. Does not contain any hooks
    /// </summary>
    public static class Delegates
    {
        public delegate void CheckTouching_BeforeArgs(Params_CheckTouching args);

        public delegate void CheckTouching_NormalArgs(Params_CheckTouching args);

        public delegate void DoCollisionExit2D_BeforeArgs(Params_DoCollisionExit2D args);

        public delegate void DoCollisionExit2D_NormalArgs(Params_DoCollisionExit2D args);

        public delegate void DoCollisionStay2D_BeforeArgs(Params_DoCollisionStay2D args);

        public delegate void DoCollisionStay2D_NormalArgs(Params_DoCollisionStay2D args);

        public delegate void OnEnter_BeforeArgs(Params_OnEnter args);

        public delegate void OnEnter_NormalArgs(Params_OnEnter args);

        public delegate void OnExit_BeforeArgs(Params_OnExit args);

        public delegate void OnExit_NormalArgs(Params_OnExit args);

        public delegate void OnUpdate_BeforeArgs(Params_OnUpdate args);

        public delegate void OnUpdate_NormalArgs(Params_OnUpdate args);

        public delegate void Reset_BeforeArgs(Params_Reset args);

        public delegate void Reset_NormalArgs(Params_Reset args);

        public sealed class Params_Reset
        {
            public CheckCollisionSide self;
        }

        public sealed class Params_OnEnter
        {
            public CheckCollisionSide self;
        }

        public sealed class Params_OnExit
        {
            public CheckCollisionSide self;
        }

        public sealed class Params_OnUpdate
        {
            public CheckCollisionSide self;
        }

        public sealed class Params_DoCollisionStay2D
        {
            public Collision2D collision;
            public CheckCollisionSide self;
        }

        public sealed class Params_DoCollisionExit2D
        {
            public Collision2D collision;
            public CheckCollisionSide self;
        }

        public sealed class Params_CheckTouching
        {
            public LayerMask layer;
            public CheckCollisionSide self;
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

        public static event Delegates.OnExit_BeforeArgs OnExit
        {
            add
            {
                HookHandler._beforeOnExit += value;
                HookHandler.HookOnExit();
            }
            remove => HookHandler._beforeOnExit -= value;
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

        public static event Delegates.DoCollisionStay2D_BeforeArgs DoCollisionStay2D
        {
            add
            {
                HookHandler._beforeDoCollisionStay2D += value;
                HookHandler.HookDoCollisionStay2D();
            }
            remove => HookHandler._beforeDoCollisionStay2D -= value;
        }

        public static event Delegates.DoCollisionExit2D_BeforeArgs DoCollisionExit2D
        {
            add
            {
                HookHandler._beforeDoCollisionExit2D += value;
                HookHandler.HookDoCollisionExit2D();
            }
            remove => HookHandler._beforeDoCollisionExit2D -= value;
        }

        public static event Delegates.CheckTouching_BeforeArgs CheckTouching
        {
            add
            {
                HookHandler._beforeCheckTouching += value;
                HookHandler.HookCheckTouching();
            }
            remove => HookHandler._beforeCheckTouching -= value;
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

        public static event Delegates.OnEnter_NormalArgs OnEnter
        {
            add
            {
                HookHandler._afterOnEnter += value;
                HookHandler.HookOnEnter();
            }
            remove => HookHandler._afterOnEnter -= value;
        }

        public static event Delegates.OnExit_NormalArgs OnExit
        {
            add
            {
                HookHandler._afterOnExit += value;
                HookHandler.HookOnExit();
            }
            remove => HookHandler._afterOnExit -= value;
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

        public static event Delegates.DoCollisionStay2D_NormalArgs DoCollisionStay2D
        {
            add
            {
                HookHandler._afterDoCollisionStay2D += value;
                HookHandler.HookDoCollisionStay2D();
            }
            remove => HookHandler._afterDoCollisionStay2D -= value;
        }

        public static event Delegates.DoCollisionExit2D_NormalArgs DoCollisionExit2D
        {
            add
            {
                HookHandler._afterDoCollisionExit2D += value;
                HookHandler.HookDoCollisionExit2D();
            }
            remove => HookHandler._afterDoCollisionExit2D -= value;
        }

        public static event Delegates.CheckTouching_NormalArgs CheckTouching
        {
            add
            {
                HookHandler._afterCheckTouching += value;
                HookHandler.HookCheckTouching();
            }
            remove => HookHandler._afterCheckTouching -= value;
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
                ReflectionHelper.GetMethodInfo(typeof(CheckCollisionSide), "Reset"), value);
            remove => HookEndpointManager.Remove<Delegates.Reset_NormalArgs>(
                ReflectionHelper.GetMethodInfo(typeof(CheckCollisionSide), "Reset"), value);
        }

        public static event Delegates.OnEnter_NormalArgs OnEnter
        {
            add => HookEndpointManager.Add<Delegates.OnEnter_NormalArgs>(
                ReflectionHelper.GetMethodInfo(typeof(CheckCollisionSide), "OnEnter"), value);
            remove => HookEndpointManager.Remove<Delegates.OnEnter_NormalArgs>(
                ReflectionHelper.GetMethodInfo(typeof(CheckCollisionSide), "OnEnter"), value);
        }

        public static event Delegates.OnExit_NormalArgs OnExit
        {
            add => HookEndpointManager.Add<Delegates.OnExit_NormalArgs>(
                ReflectionHelper.GetMethodInfo(typeof(CheckCollisionSide), "OnExit"), value);
            remove => HookEndpointManager.Remove<Delegates.OnExit_NormalArgs>(
                ReflectionHelper.GetMethodInfo(typeof(CheckCollisionSide), "OnExit"), value);
        }

        public static event Delegates.OnUpdate_NormalArgs OnUpdate
        {
            add => HookEndpointManager.Add<Delegates.OnUpdate_NormalArgs>(
                ReflectionHelper.GetMethodInfo(typeof(CheckCollisionSide), "OnUpdate"), value);
            remove => HookEndpointManager.Remove<Delegates.OnUpdate_NormalArgs>(
                ReflectionHelper.GetMethodInfo(typeof(CheckCollisionSide), "OnUpdate"), value);
        }

        public static event Delegates.DoCollisionStay2D_NormalArgs DoCollisionStay2D
        {
            add => HookEndpointManager.Add<Delegates.DoCollisionStay2D_NormalArgs>(
                ReflectionHelper.GetMethodInfo(typeof(CheckCollisionSide), "DoCollisionStay2D"), value);
            remove => HookEndpointManager.Remove<Delegates.DoCollisionStay2D_NormalArgs>(
                ReflectionHelper.GetMethodInfo(typeof(CheckCollisionSide), "DoCollisionStay2D"), value);
        }

        public static event Delegates.DoCollisionExit2D_NormalArgs DoCollisionExit2D
        {
            add => HookEndpointManager.Add<Delegates.DoCollisionExit2D_NormalArgs>(
                ReflectionHelper.GetMethodInfo(typeof(CheckCollisionSide), "DoCollisionExit2D"), value);
            remove => HookEndpointManager.Remove<Delegates.DoCollisionExit2D_NormalArgs>(
                ReflectionHelper.GetMethodInfo(typeof(CheckCollisionSide), "DoCollisionExit2D"), value);
        }

        public static event Delegates.CheckTouching_NormalArgs CheckTouching
        {
            add => HookEndpointManager.Add<Delegates.CheckTouching_NormalArgs>(
                ReflectionHelper.GetMethodInfo(typeof(CheckCollisionSide), "CheckTouching"), value);
            remove => HookEndpointManager.Remove<Delegates.CheckTouching_NormalArgs>(
                ReflectionHelper.GetMethodInfo(typeof(CheckCollisionSide), "CheckTouching"), value);
        }
    }
}