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
        internal static event Delegates.get_Direction_AfterArgs _afterget_Direction;

        private static float get_Direction(Func<WalkLeftRight, float> orig, WalkLeftRight self)
        {
            Delegates.Params_get_Direction @params = new()
            {
                self = self
            };
            if (_beforeget_Direction != null)
                foreach (Delegates.get_Direction_BeforeArgs toInvoke in _beforeget_Direction.GetInvocationList())
                    try
                    {
                        _beforeget_Direction?.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }

            self = @params.self;
            var retVal = orig(self);
            if (_afterget_Direction != null)
                foreach (Delegates.get_Direction_AfterArgs toInvoke in _afterget_Direction.GetInvocationList())
                    try
                    {
                        retVal = _afterget_Direction.Invoke(@params, retVal);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }

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
        internal static event Delegates.OnEnter_AfterArgs _afterOnEnter;

        private static void OnEnter(Action<WalkLeftRight> orig, WalkLeftRight self)
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

        internal static void HookOnExit()
        {
            if (!HookedList.Contains("OnExit"))
            {
                HookedList.Add("OnExit");
                new Hook(ReflectionHelper.GetMethodInfo(typeof(WalkLeftRight), "OnExit"), OnExit);
            }
        }

        internal static event Delegates.OnExit_BeforeArgs _beforeOnExit;
        internal static event Delegates.OnExit_AfterArgs _afterOnExit;

        private static void OnExit(Action<WalkLeftRight> orig, WalkLeftRight self)
        {
            Delegates.Params_OnExit @params = new()
            {
                self = self
            };
            if (_beforeOnExit != null)
                foreach (Delegates.OnExit_BeforeArgs toInvoke in _beforeOnExit.GetInvocationList())
                    try
                    {
                        _beforeOnExit?.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }

            self = @params.self;
            orig(self);
            if (_afterOnExit != null)
                foreach (Delegates.OnExit_AfterArgs toInvoke in _afterOnExit.GetInvocationList())
                    try
                    {
                        _afterOnExit.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }
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
        internal static event Delegates.UpdateIfTargetChanged_AfterArgs _afterUpdateIfTargetChanged;

        private static void UpdateIfTargetChanged(Action<WalkLeftRight> orig, WalkLeftRight self)
        {
            Delegates.Params_UpdateIfTargetChanged @params = new()
            {
                self = self
            };
            if (_beforeUpdateIfTargetChanged != null)
                foreach (Delegates.UpdateIfTargetChanged_BeforeArgs toInvoke in _beforeUpdateIfTargetChanged
                             .GetInvocationList())
                    try
                    {
                        _beforeUpdateIfTargetChanged?.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }

            self = @params.self;
            orig(self);
            if (_afterUpdateIfTargetChanged != null)
                foreach (Delegates.UpdateIfTargetChanged_AfterArgs toInvoke in _afterUpdateIfTargetChanged
                             .GetInvocationList())
                    try
                    {
                        _afterUpdateIfTargetChanged.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }
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
            if (_beforeWalk != null)
                foreach (Delegates.Walk_BeforeArgs toInvoke in _beforeWalk.GetInvocationList())
                    try
                    {
                        _beforeWalk?.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }

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
            if (_beforeTurn != null)
                foreach (Delegates.Turn_BeforeArgs toInvoke in _beforeTurn.GetInvocationList())
                    try
                    {
                        _beforeTurn?.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }

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
        internal static event Delegates.CheckWall_AfterArgs _afterCheckWall;

        private static bool CheckWall(Func<WalkLeftRight, bool> orig, WalkLeftRight self)
        {
            Delegates.Params_CheckWall @params = new()
            {
                self = self
            };
            if (_beforeCheckWall != null)
                foreach (Delegates.CheckWall_BeforeArgs toInvoke in _beforeCheckWall.GetInvocationList())
                    try
                    {
                        _beforeCheckWall?.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }

            self = @params.self;
            var retVal = orig(self);
            if (_afterCheckWall != null)
                foreach (Delegates.CheckWall_AfterArgs toInvoke in _afterCheckWall.GetInvocationList())
                    try
                    {
                        retVal = _afterCheckWall.Invoke(@params, retVal);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }

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
        internal static event Delegates.CheckFloor_AfterArgs _afterCheckFloor;

        private static bool CheckFloor(Func<WalkLeftRight, bool> orig, WalkLeftRight self)
        {
            Delegates.Params_CheckFloor @params = new()
            {
                self = self
            };
            if (_beforeCheckFloor != null)
                foreach (Delegates.CheckFloor_BeforeArgs toInvoke in _beforeCheckFloor.GetInvocationList())
                    try
                    {
                        _beforeCheckFloor?.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }

            self = @params.self;
            var retVal = orig(self);
            if (_afterCheckFloor != null)
                foreach (Delegates.CheckFloor_AfterArgs toInvoke in _afterCheckFloor.GetInvocationList())
                    try
                    {
                        retVal = _afterCheckFloor.Invoke(@params, retVal);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }

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
        internal static event Delegates.CheckIsGrounded_AfterArgs _afterCheckIsGrounded;

        private static bool CheckIsGrounded(Func<WalkLeftRight, bool> orig, WalkLeftRight self)
        {
            Delegates.Params_CheckIsGrounded @params = new()
            {
                self = self
            };
            if (_beforeCheckIsGrounded != null)
                foreach (Delegates.CheckIsGrounded_BeforeArgs toInvoke in _beforeCheckIsGrounded.GetInvocationList())
                    try
                    {
                        _beforeCheckIsGrounded?.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }

            self = @params.self;
            var retVal = orig(self);
            if (_afterCheckIsGrounded != null)
                foreach (Delegates.CheckIsGrounded_AfterArgs toInvoke in _afterCheckIsGrounded.GetInvocationList())
                    try
                    {
                        retVal = _afterCheckIsGrounded.Invoke(@params, retVal);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }

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
        internal static event Delegates.SetupStartingDirection_AfterArgs _afterSetupStartingDirection;

        private static void SetupStartingDirection(Action<WalkLeftRight> orig, WalkLeftRight self)
        {
            Delegates.Params_SetupStartingDirection @params = new()
            {
                self = self
            };
            if (_beforeSetupStartingDirection != null)
                foreach (Delegates.SetupStartingDirection_BeforeArgs toInvoke in _beforeSetupStartingDirection
                             .GetInvocationList())
                    try
                    {
                        _beforeSetupStartingDirection?.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }

            self = @params.self;
            orig(self);
            if (_afterSetupStartingDirection != null)
                foreach (Delegates.SetupStartingDirection_AfterArgs toInvoke in _afterSetupStartingDirection
                             .GetInvocationList())
                    try
                    {
                        _afterSetupStartingDirection.Invoke(@params);
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
        public delegate bool CheckFloor_AfterArgs(Params_CheckFloor args, bool ret);

        public delegate void CheckFloor_BeforeArgs(Params_CheckFloor args);

        public delegate bool CheckFloor_WithArgs(Func<WalkLeftRight, bool> orig, WalkLeftRight self);

        public delegate bool CheckIsGrounded_AfterArgs(Params_CheckIsGrounded args, bool ret);

        public delegate void CheckIsGrounded_BeforeArgs(Params_CheckIsGrounded args);

        public delegate bool CheckIsGrounded_WithArgs(Func<WalkLeftRight, bool> orig, WalkLeftRight self);

        public delegate bool CheckWall_AfterArgs(Params_CheckWall args, bool ret);

        public delegate void CheckWall_BeforeArgs(Params_CheckWall args);

        public delegate bool CheckWall_WithArgs(Func<WalkLeftRight, bool> orig, WalkLeftRight self);

        public delegate float get_Direction_AfterArgs(Params_get_Direction args, float ret);

        public delegate void get_Direction_BeforeArgs(Params_get_Direction args);

        public delegate float get_Direction_WithArgs(Func<WalkLeftRight, float> orig, WalkLeftRight self);

        public delegate void OnEnter_AfterArgs(Params_OnEnter args);

        public delegate void OnEnter_BeforeArgs(Params_OnEnter args);

        public delegate void OnEnter_WithArgs(Action<WalkLeftRight> orig, WalkLeftRight self);

        public delegate void OnExit_AfterArgs(Params_OnExit args);

        public delegate void OnExit_BeforeArgs(Params_OnExit args);

        public delegate void OnExit_WithArgs(Action<WalkLeftRight> orig, WalkLeftRight self);

        public delegate void SetupStartingDirection_AfterArgs(Params_SetupStartingDirection args);

        public delegate void SetupStartingDirection_BeforeArgs(Params_SetupStartingDirection args);

        public delegate void SetupStartingDirection_WithArgs(Action<WalkLeftRight> orig, WalkLeftRight self);

        public delegate IEnumerator Turn_AfterArgs(Params_Turn args, IEnumerator ret);

        public delegate void Turn_BeforeArgs(Params_Turn args);

        public delegate IEnumerator Turn_WithArgs(Func<WalkLeftRight, IEnumerator> orig, WalkLeftRight self);

        public delegate void UpdateIfTargetChanged_AfterArgs(Params_UpdateIfTargetChanged args);

        public delegate void UpdateIfTargetChanged_BeforeArgs(Params_UpdateIfTargetChanged args);

        public delegate void UpdateIfTargetChanged_WithArgs(Action<WalkLeftRight> orig, WalkLeftRight self);

        public delegate IEnumerator Walk_AfterArgs(Params_Walk args, IEnumerator ret);

        public delegate void Walk_BeforeArgs(Params_Walk args);

        public delegate IEnumerator Walk_WithArgs(Func<WalkLeftRight, IEnumerator> orig, WalkLeftRight self);

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
        public static event Delegates.get_Direction_AfterArgs get_Direction
        {
            add
            {
                HookHandler._afterget_Direction += value;
                HookHandler.Hookget_Direction();
            }
            remove => HookHandler._afterget_Direction -= value;
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

        public static event Delegates.OnExit_AfterArgs OnExit
        {
            add
            {
                HookHandler._afterOnExit += value;
                HookHandler.HookOnExit();
            }
            remove => HookHandler._afterOnExit -= value;
        }

        public static event Delegates.UpdateIfTargetChanged_AfterArgs UpdateIfTargetChanged
        {
            add
            {
                HookHandler._afterUpdateIfTargetChanged += value;
                HookHandler.HookUpdateIfTargetChanged();
            }
            remove => HookHandler._afterUpdateIfTargetChanged -= value;
        }

        public static event Delegates.CheckWall_AfterArgs CheckWall
        {
            add
            {
                HookHandler._afterCheckWall += value;
                HookHandler.HookCheckWall();
            }
            remove => HookHandler._afterCheckWall -= value;
        }

        public static event Delegates.CheckFloor_AfterArgs CheckFloor
        {
            add
            {
                HookHandler._afterCheckFloor += value;
                HookHandler.HookCheckFloor();
            }
            remove => HookHandler._afterCheckFloor -= value;
        }

        public static event Delegates.CheckIsGrounded_AfterArgs CheckIsGrounded
        {
            add
            {
                HookHandler._afterCheckIsGrounded += value;
                HookHandler.HookCheckIsGrounded();
            }
            remove => HookHandler._afterCheckIsGrounded -= value;
        }

        public static event Delegates.SetupStartingDirection_AfterArgs SetupStartingDirection
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
        public static event Delegates.get_Direction_WithArgs get_Direction
        {
            add => HookEndpointManager.Add<Delegates.get_Direction_WithArgs>(
                ReflectionHelper.GetMethodInfo(typeof(WalkLeftRight), "get_Direction"), value);
            remove => HookEndpointManager.Remove<Delegates.get_Direction_WithArgs>(
                ReflectionHelper.GetMethodInfo(typeof(WalkLeftRight), "get_Direction"), value);
        }

        public static event Delegates.OnEnter_WithArgs OnEnter
        {
            add => HookEndpointManager.Add<Delegates.OnEnter_WithArgs>(
                ReflectionHelper.GetMethodInfo(typeof(WalkLeftRight), "OnEnter"), value);
            remove => HookEndpointManager.Remove<Delegates.OnEnter_WithArgs>(
                ReflectionHelper.GetMethodInfo(typeof(WalkLeftRight), "OnEnter"), value);
        }

        public static event Delegates.OnExit_WithArgs OnExit
        {
            add => HookEndpointManager.Add<Delegates.OnExit_WithArgs>(
                ReflectionHelper.GetMethodInfo(typeof(WalkLeftRight), "OnExit"), value);
            remove => HookEndpointManager.Remove<Delegates.OnExit_WithArgs>(
                ReflectionHelper.GetMethodInfo(typeof(WalkLeftRight), "OnExit"), value);
        }

        public static event Delegates.UpdateIfTargetChanged_WithArgs UpdateIfTargetChanged
        {
            add => HookEndpointManager.Add<Delegates.UpdateIfTargetChanged_WithArgs>(
                ReflectionHelper.GetMethodInfo(typeof(WalkLeftRight), "UpdateIfTargetChanged"), value);
            remove => HookEndpointManager.Remove<Delegates.UpdateIfTargetChanged_WithArgs>(
                ReflectionHelper.GetMethodInfo(typeof(WalkLeftRight), "UpdateIfTargetChanged"), value);
        }

        public static event Delegates.Walk_WithArgs Walk
        {
            add => HookEndpointManager.Add<Delegates.Walk_WithArgs>(
                ReflectionHelper.GetMethodInfo(typeof(WalkLeftRight), "Walk"), value);
            remove => HookEndpointManager.Remove<Delegates.Walk_WithArgs>(
                ReflectionHelper.GetMethodInfo(typeof(WalkLeftRight), "Walk"), value);
        }

        public static event Delegates.Turn_WithArgs Turn
        {
            add => HookEndpointManager.Add<Delegates.Turn_WithArgs>(
                ReflectionHelper.GetMethodInfo(typeof(WalkLeftRight), "Turn"), value);
            remove => HookEndpointManager.Remove<Delegates.Turn_WithArgs>(
                ReflectionHelper.GetMethodInfo(typeof(WalkLeftRight), "Turn"), value);
        }

        public static event Delegates.CheckWall_WithArgs CheckWall
        {
            add => HookEndpointManager.Add<Delegates.CheckWall_WithArgs>(
                ReflectionHelper.GetMethodInfo(typeof(WalkLeftRight), "CheckWall"), value);
            remove => HookEndpointManager.Remove<Delegates.CheckWall_WithArgs>(
                ReflectionHelper.GetMethodInfo(typeof(WalkLeftRight), "CheckWall"), value);
        }

        public static event Delegates.CheckFloor_WithArgs CheckFloor
        {
            add => HookEndpointManager.Add<Delegates.CheckFloor_WithArgs>(
                ReflectionHelper.GetMethodInfo(typeof(WalkLeftRight), "CheckFloor"), value);
            remove => HookEndpointManager.Remove<Delegates.CheckFloor_WithArgs>(
                ReflectionHelper.GetMethodInfo(typeof(WalkLeftRight), "CheckFloor"), value);
        }

        public static event Delegates.CheckIsGrounded_WithArgs CheckIsGrounded
        {
            add => HookEndpointManager.Add<Delegates.CheckIsGrounded_WithArgs>(
                ReflectionHelper.GetMethodInfo(typeof(WalkLeftRight), "CheckIsGrounded"), value);
            remove => HookEndpointManager.Remove<Delegates.CheckIsGrounded_WithArgs>(
                ReflectionHelper.GetMethodInfo(typeof(WalkLeftRight), "CheckIsGrounded"), value);
        }

        public static event Delegates.SetupStartingDirection_WithArgs SetupStartingDirection
        {
            add => HookEndpointManager.Add<Delegates.SetupStartingDirection_WithArgs>(
                ReflectionHelper.GetMethodInfo(typeof(WalkLeftRight), "SetupStartingDirection"), value);
            remove => HookEndpointManager.Remove<Delegates.SetupStartingDirection_WithArgs>(
                ReflectionHelper.GetMethodInfo(typeof(WalkLeftRight), "SetupStartingDirection"), value);
        }
    }
}