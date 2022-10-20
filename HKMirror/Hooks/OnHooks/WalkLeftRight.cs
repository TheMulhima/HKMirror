using MonoMod.RuntimeDetour;
using MonoMod.RuntimeDetour.HookGen;

namespace HKMirror.Hooks.OnHooks;

/// <summary>
///     Contains different types of On Hooks for WalkLeftRight class.<br />
///     Contains hooks that aren't generated by monomod, and before and after orig hooks for easier hooking.
/// </summary>
public static class OnWalkLeftRight
{
    internal static class HookHandler
    {
        private static readonly List<string> HookedList = new();

        internal static void Hookget_Direction()
        {
            if (!HookedList.Contains("get_Direction"))
            {
                HookedList.Add("get_Direction");
                new Hook(ReflectionHelper.GetMethodInfo(typeof(WalkLeftRight), "get_Direction"), get_Direction);
            }
        }

        internal static event Delegates.get_Direction_BeforeArgs _beforeget_Direction;
        internal static event Delegates.get_Direction_NormalArgs _afterget_Direction;

        private static float get_Direction(Func<WalkLeftRight, float> orig, WalkLeftRight self)
        {
            Delegates.Params_get_Direction @params = new()
            {
                self = self
            };
            _beforeget_Direction?.Invoke(@params);
            self = @params.self;
            var retVal = orig(self);
            if (_afterget_Direction != null) retVal = _afterget_Direction.Invoke(@params);
            return retVal;
        }

        internal static void HookOnEnter()
        {
            if (!HookedList.Contains("OnEnter"))
            {
                HookedList.Add("OnEnter");
                new Hook(ReflectionHelper.GetMethodInfo(typeof(WalkLeftRight), "OnEnter"), OnEnter);
            }
        }

        internal static event Delegates.OnEnter_BeforeArgs _beforeOnEnter;
        internal static event Delegates.OnEnter_NormalArgs _afterOnEnter;

        private static void OnEnter(Action<WalkLeftRight> orig, WalkLeftRight self)
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
                new Hook(ReflectionHelper.GetMethodInfo(typeof(WalkLeftRight), "OnExit"), OnExit);
            }
        }

        internal static event Delegates.OnExit_BeforeArgs _beforeOnExit;
        internal static event Delegates.OnExit_NormalArgs _afterOnExit;

        private static void OnExit(Action<WalkLeftRight> orig, WalkLeftRight self)
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

        internal static void HookUpdateIfTargetChanged()
        {
            if (!HookedList.Contains("UpdateIfTargetChanged"))
            {
                HookedList.Add("UpdateIfTargetChanged");
                new Hook(ReflectionHelper.GetMethodInfo(typeof(WalkLeftRight), "UpdateIfTargetChanged"),
                    UpdateIfTargetChanged);
            }
        }

        internal static event Delegates.UpdateIfTargetChanged_BeforeArgs _beforeUpdateIfTargetChanged;
        internal static event Delegates.UpdateIfTargetChanged_NormalArgs _afterUpdateIfTargetChanged;

        private static void UpdateIfTargetChanged(Action<WalkLeftRight> orig, WalkLeftRight self)
        {
            Delegates.Params_UpdateIfTargetChanged @params = new()
            {
                self = self
            };
            _beforeUpdateIfTargetChanged?.Invoke(@params);
            self = @params.self;
            orig(self);
            if (_afterUpdateIfTargetChanged != null) _afterUpdateIfTargetChanged.Invoke(@params);
        }

        internal static void HookWalk()
        {
            if (!HookedList.Contains("Walk"))
            {
                HookedList.Add("Walk");
                new Hook(ReflectionHelper.GetMethodInfo(typeof(WalkLeftRight), "Walk"), Walk);
            }
        }

        internal static event Delegates.Walk_BeforeArgs _beforeWalk;

        private static IEnumerator Walk(Func<WalkLeftRight, IEnumerator> orig, WalkLeftRight self)
        {
            Delegates.Params_Walk @params = new()
            {
                self = self
            };
            _beforeWalk?.Invoke(@params);
            self = @params.self;
            return orig(self);
        }

        internal static void HookTurn()
        {
            if (!HookedList.Contains("Turn"))
            {
                HookedList.Add("Turn");
                new Hook(ReflectionHelper.GetMethodInfo(typeof(WalkLeftRight), "Turn"), Turn);
            }
        }

        internal static event Delegates.Turn_BeforeArgs _beforeTurn;

        private static IEnumerator Turn(Func<WalkLeftRight, IEnumerator> orig, WalkLeftRight self)
        {
            Delegates.Params_Turn @params = new()
            {
                self = self
            };
            _beforeTurn?.Invoke(@params);
            self = @params.self;
            return orig(self);
        }

        internal static void HookCheckWall()
        {
            if (!HookedList.Contains("CheckWall"))
            {
                HookedList.Add("CheckWall");
                new Hook(ReflectionHelper.GetMethodInfo(typeof(WalkLeftRight), "CheckWall"), CheckWall);
            }
        }

        internal static event Delegates.CheckWall_BeforeArgs _beforeCheckWall;
        internal static event Delegates.CheckWall_NormalArgs _afterCheckWall;

        private static bool CheckWall(Func<WalkLeftRight, bool> orig, WalkLeftRight self)
        {
            Delegates.Params_CheckWall @params = new()
            {
                self = self
            };
            _beforeCheckWall?.Invoke(@params);
            self = @params.self;
            var retVal = orig(self);
            if (_afterCheckWall != null) retVal = _afterCheckWall.Invoke(@params);
            return retVal;
        }

        internal static void HookCheckFloor()
        {
            if (!HookedList.Contains("CheckFloor"))
            {
                HookedList.Add("CheckFloor");
                new Hook(ReflectionHelper.GetMethodInfo(typeof(WalkLeftRight), "CheckFloor"), CheckFloor);
            }
        }

        internal static event Delegates.CheckFloor_BeforeArgs _beforeCheckFloor;
        internal static event Delegates.CheckFloor_NormalArgs _afterCheckFloor;

        private static bool CheckFloor(Func<WalkLeftRight, bool> orig, WalkLeftRight self)
        {
            Delegates.Params_CheckFloor @params = new()
            {
                self = self
            };
            _beforeCheckFloor?.Invoke(@params);
            self = @params.self;
            var retVal = orig(self);
            if (_afterCheckFloor != null) retVal = _afterCheckFloor.Invoke(@params);
            return retVal;
        }

        internal static void HookCheckIsGrounded()
        {
            if (!HookedList.Contains("CheckIsGrounded"))
            {
                HookedList.Add("CheckIsGrounded");
                new Hook(ReflectionHelper.GetMethodInfo(typeof(WalkLeftRight), "CheckIsGrounded"), CheckIsGrounded);
            }
        }

        internal static event Delegates.CheckIsGrounded_BeforeArgs _beforeCheckIsGrounded;
        internal static event Delegates.CheckIsGrounded_NormalArgs _afterCheckIsGrounded;

        private static bool CheckIsGrounded(Func<WalkLeftRight, bool> orig, WalkLeftRight self)
        {
            Delegates.Params_CheckIsGrounded @params = new()
            {
                self = self
            };
            _beforeCheckIsGrounded?.Invoke(@params);
            self = @params.self;
            var retVal = orig(self);
            if (_afterCheckIsGrounded != null) retVal = _afterCheckIsGrounded.Invoke(@params);
            return retVal;
        }

        internal static void HookSetupStartingDirection()
        {
            if (!HookedList.Contains("SetupStartingDirection"))
            {
                HookedList.Add("SetupStartingDirection");
                new Hook(ReflectionHelper.GetMethodInfo(typeof(WalkLeftRight), "SetupStartingDirection"),
                    SetupStartingDirection);
            }
        }

        internal static event Delegates.SetupStartingDirection_BeforeArgs _beforeSetupStartingDirection;
        internal static event Delegates.SetupStartingDirection_NormalArgs _afterSetupStartingDirection;

        private static void SetupStartingDirection(Action<WalkLeftRight> orig, WalkLeftRight self)
        {
            Delegates.Params_SetupStartingDirection @params = new()
            {
                self = self
            };
            _beforeSetupStartingDirection?.Invoke(@params);
            self = @params.self;
            orig(self);
            if (_afterSetupStartingDirection != null) _afterSetupStartingDirection.Invoke(@params);
        }
    }

    /// <summary>
    ///     Contains necessary information to create Hooks. Does not contain any hooks
    /// </summary>
    public static class Delegates
    {
        public delegate void CheckFloor_BeforeArgs(Params_CheckFloor args);

        public delegate bool CheckFloor_NormalArgs(Params_CheckFloor args);

        public delegate void CheckIsGrounded_BeforeArgs(Params_CheckIsGrounded args);

        public delegate bool CheckIsGrounded_NormalArgs(Params_CheckIsGrounded args);

        public delegate void CheckWall_BeforeArgs(Params_CheckWall args);

        public delegate bool CheckWall_NormalArgs(Params_CheckWall args);

        public delegate void get_Direction_BeforeArgs(Params_get_Direction args);

        public delegate float get_Direction_NormalArgs(Params_get_Direction args);

        public delegate void OnEnter_BeforeArgs(Params_OnEnter args);

        public delegate void OnEnter_NormalArgs(Params_OnEnter args);

        public delegate void OnExit_BeforeArgs(Params_OnExit args);

        public delegate void OnExit_NormalArgs(Params_OnExit args);

        public delegate void SetupStartingDirection_BeforeArgs(Params_SetupStartingDirection args);

        public delegate void SetupStartingDirection_NormalArgs(Params_SetupStartingDirection args);

        public delegate void Turn_BeforeArgs(Params_Turn args);

        public delegate IEnumerator Turn_NormalArgs(Params_Turn args);

        public delegate void UpdateIfTargetChanged_BeforeArgs(Params_UpdateIfTargetChanged args);

        public delegate void UpdateIfTargetChanged_NormalArgs(Params_UpdateIfTargetChanged args);

        public delegate void Walk_BeforeArgs(Params_Walk args);

        public delegate IEnumerator Walk_NormalArgs(Params_Walk args);

        public sealed class Params_get_Direction
        {
            public WalkLeftRight self;
        }

        public sealed class Params_OnEnter
        {
            public WalkLeftRight self;
        }

        public sealed class Params_OnExit
        {
            public WalkLeftRight self;
        }

        public sealed class Params_UpdateIfTargetChanged
        {
            public WalkLeftRight self;
        }

        public sealed class Params_Walk
        {
            public WalkLeftRight self;
        }

        public sealed class Params_Turn
        {
            public WalkLeftRight self;
        }

        public sealed class Params_CheckWall
        {
            public WalkLeftRight self;
        }

        public sealed class Params_CheckFloor
        {
            public WalkLeftRight self;
        }

        public sealed class Params_CheckIsGrounded
        {
            public WalkLeftRight self;
        }

        public sealed class Params_SetupStartingDirection
        {
            public WalkLeftRight self;
        }
    }

    /// <summary>
    ///     Contains Hooks to that run code before orig(self) is called
    /// </summary>
    public static class BeforeOrig
    {
        public static event Delegates.get_Direction_BeforeArgs get_Direction
        {
            add
            {
                HookHandler._beforeget_Direction += value;
                HookHandler.Hookget_Direction();
            }
            remove => HookHandler._beforeget_Direction -= value;
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

        public static event Delegates.UpdateIfTargetChanged_BeforeArgs UpdateIfTargetChanged
        {
            add
            {
                HookHandler._beforeUpdateIfTargetChanged += value;
                HookHandler.HookUpdateIfTargetChanged();
            }
            remove => HookHandler._beforeUpdateIfTargetChanged -= value;
        }

        public static event Delegates.Walk_BeforeArgs Walk
        {
            add
            {
                HookHandler._beforeWalk += value;
                HookHandler.HookWalk();
            }
            remove => HookHandler._beforeWalk -= value;
        }

        public static event Delegates.Turn_BeforeArgs Turn
        {
            add
            {
                HookHandler._beforeTurn += value;
                HookHandler.HookTurn();
            }
            remove => HookHandler._beforeTurn -= value;
        }

        public static event Delegates.CheckWall_BeforeArgs CheckWall
        {
            add
            {
                HookHandler._beforeCheckWall += value;
                HookHandler.HookCheckWall();
            }
            remove => HookHandler._beforeCheckWall -= value;
        }

        public static event Delegates.CheckFloor_BeforeArgs CheckFloor
        {
            add
            {
                HookHandler._beforeCheckFloor += value;
                HookHandler.HookCheckFloor();
            }
            remove => HookHandler._beforeCheckFloor -= value;
        }

        public static event Delegates.CheckIsGrounded_BeforeArgs CheckIsGrounded
        {
            add
            {
                HookHandler._beforeCheckIsGrounded += value;
                HookHandler.HookCheckIsGrounded();
            }
            remove => HookHandler._beforeCheckIsGrounded -= value;
        }

        public static event Delegates.SetupStartingDirection_BeforeArgs SetupStartingDirection
        {
            add
            {
                HookHandler._beforeSetupStartingDirection += value;
                HookHandler.HookSetupStartingDirection();
            }
            remove => HookHandler._beforeSetupStartingDirection -= value;
        }
    }

    /// <summary>
    ///     Contains Hooks to that run code after orig(self) is called
    /// </summary>
    public static class AfterOrig
    {
        public static event Delegates.get_Direction_NormalArgs get_Direction
        {
            add
            {
                HookHandler._afterget_Direction += value;
                HookHandler.Hookget_Direction();
            }
            remove => HookHandler._afterget_Direction -= value;
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

        public static event Delegates.UpdateIfTargetChanged_NormalArgs UpdateIfTargetChanged
        {
            add
            {
                HookHandler._afterUpdateIfTargetChanged += value;
                HookHandler.HookUpdateIfTargetChanged();
            }
            remove => HookHandler._afterUpdateIfTargetChanged -= value;
        }

        public static event Delegates.CheckWall_NormalArgs CheckWall
        {
            add
            {
                HookHandler._afterCheckWall += value;
                HookHandler.HookCheckWall();
            }
            remove => HookHandler._afterCheckWall -= value;
        }

        public static event Delegates.CheckFloor_NormalArgs CheckFloor
        {
            add
            {
                HookHandler._afterCheckFloor += value;
                HookHandler.HookCheckFloor();
            }
            remove => HookHandler._afterCheckFloor -= value;
        }

        public static event Delegates.CheckIsGrounded_NormalArgs CheckIsGrounded
        {
            add
            {
                HookHandler._afterCheckIsGrounded += value;
                HookHandler.HookCheckIsGrounded();
            }
            remove => HookHandler._afterCheckIsGrounded -= value;
        }

        public static event Delegates.SetupStartingDirection_NormalArgs SetupStartingDirection
        {
            add
            {
                HookHandler._afterSetupStartingDirection += value;
                HookHandler.HookSetupStartingDirection();
            }
            remove => HookHandler._afterSetupStartingDirection -= value;
        }
    }

    /// <summary>
    ///     Contains all On Hooks, even those that aren't in the On namespace such as API generated functions and property
    ///     getters/setters
    /// </summary>
    public static class WithOrig
    {
        public static event Delegates.get_Direction_NormalArgs get_Direction
        {
            add => HookEndpointManager.Add<Delegates.get_Direction_NormalArgs>(
                ReflectionHelper.GetMethodInfo(typeof(WalkLeftRight), "get_Direction"), value);
            remove => HookEndpointManager.Remove<Delegates.get_Direction_NormalArgs>(
                ReflectionHelper.GetMethodInfo(typeof(WalkLeftRight), "get_Direction"), value);
        }

        public static event Delegates.OnEnter_NormalArgs OnEnter
        {
            add => HookEndpointManager.Add<Delegates.OnEnter_NormalArgs>(
                ReflectionHelper.GetMethodInfo(typeof(WalkLeftRight), "OnEnter"), value);
            remove => HookEndpointManager.Remove<Delegates.OnEnter_NormalArgs>(
                ReflectionHelper.GetMethodInfo(typeof(WalkLeftRight), "OnEnter"), value);
        }

        public static event Delegates.OnExit_NormalArgs OnExit
        {
            add => HookEndpointManager.Add<Delegates.OnExit_NormalArgs>(
                ReflectionHelper.GetMethodInfo(typeof(WalkLeftRight), "OnExit"), value);
            remove => HookEndpointManager.Remove<Delegates.OnExit_NormalArgs>(
                ReflectionHelper.GetMethodInfo(typeof(WalkLeftRight), "OnExit"), value);
        }

        public static event Delegates.UpdateIfTargetChanged_NormalArgs UpdateIfTargetChanged
        {
            add => HookEndpointManager.Add<Delegates.UpdateIfTargetChanged_NormalArgs>(
                ReflectionHelper.GetMethodInfo(typeof(WalkLeftRight), "UpdateIfTargetChanged"), value);
            remove => HookEndpointManager.Remove<Delegates.UpdateIfTargetChanged_NormalArgs>(
                ReflectionHelper.GetMethodInfo(typeof(WalkLeftRight), "UpdateIfTargetChanged"), value);
        }

        public static event Delegates.Walk_NormalArgs Walk
        {
            add => HookEndpointManager.Add<Delegates.Walk_NormalArgs>(
                ReflectionHelper.GetMethodInfo(typeof(WalkLeftRight), "Walk"), value);
            remove => HookEndpointManager.Remove<Delegates.Walk_NormalArgs>(
                ReflectionHelper.GetMethodInfo(typeof(WalkLeftRight), "Walk"), value);
        }

        public static event Delegates.Turn_NormalArgs Turn
        {
            add => HookEndpointManager.Add<Delegates.Turn_NormalArgs>(
                ReflectionHelper.GetMethodInfo(typeof(WalkLeftRight), "Turn"), value);
            remove => HookEndpointManager.Remove<Delegates.Turn_NormalArgs>(
                ReflectionHelper.GetMethodInfo(typeof(WalkLeftRight), "Turn"), value);
        }

        public static event Delegates.CheckWall_NormalArgs CheckWall
        {
            add => HookEndpointManager.Add<Delegates.CheckWall_NormalArgs>(
                ReflectionHelper.GetMethodInfo(typeof(WalkLeftRight), "CheckWall"), value);
            remove => HookEndpointManager.Remove<Delegates.CheckWall_NormalArgs>(
                ReflectionHelper.GetMethodInfo(typeof(WalkLeftRight), "CheckWall"), value);
        }

        public static event Delegates.CheckFloor_NormalArgs CheckFloor
        {
            add => HookEndpointManager.Add<Delegates.CheckFloor_NormalArgs>(
                ReflectionHelper.GetMethodInfo(typeof(WalkLeftRight), "CheckFloor"), value);
            remove => HookEndpointManager.Remove<Delegates.CheckFloor_NormalArgs>(
                ReflectionHelper.GetMethodInfo(typeof(WalkLeftRight), "CheckFloor"), value);
        }

        public static event Delegates.CheckIsGrounded_NormalArgs CheckIsGrounded
        {
            add => HookEndpointManager.Add<Delegates.CheckIsGrounded_NormalArgs>(
                ReflectionHelper.GetMethodInfo(typeof(WalkLeftRight), "CheckIsGrounded"), value);
            remove => HookEndpointManager.Remove<Delegates.CheckIsGrounded_NormalArgs>(
                ReflectionHelper.GetMethodInfo(typeof(WalkLeftRight), "CheckIsGrounded"), value);
        }

        public static event Delegates.SetupStartingDirection_NormalArgs SetupStartingDirection
        {
            add => HookEndpointManager.Add<Delegates.SetupStartingDirection_NormalArgs>(
                ReflectionHelper.GetMethodInfo(typeof(WalkLeftRight), "SetupStartingDirection"), value);
            remove => HookEndpointManager.Remove<Delegates.SetupStartingDirection_NormalArgs>(
                ReflectionHelper.GetMethodInfo(typeof(WalkLeftRight), "SetupStartingDirection"), value);
        }
    }
}