using MonoMod.RuntimeDetour;
using MonoMod.RuntimeDetour.HookGen;

namespace HKMirror.Hooks.OnHooks;

/// <summary>
/// Contains different types of On Hooks for Climber class.<br />
/// Contains hooks that aren't generated by monomod, and before and after orig hooks for easier hooking.
/// </summary>
public static class OnClimber
{
    internal static class HookHandler
    {
        private static List<string> HookedList = new List<string>();

        internal static void HookAwake()
        {
            if (!HookedList.Contains("Awake"))
            {
                HookedList.Add("Awake");
                On.Climber.Awake += Awake;
            }
        }

        internal static event Delegates.Awake_BeforeArgs _beforeAwake;
        internal static event Delegates.Awake_AfterArgs _afterAwake;

        private static void Awake(On.Climber.orig_Awake orig, Climber self)
        {
            Delegates.Params_Awake @params = new()
            {
                self = self
            };
            if (_beforeAwake != null)
            {
                foreach (Delegates.Awake_BeforeArgs toInvoke in _beforeAwake.GetInvocationList())
                {
                    try
                    {
                        _beforeAwake?.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }
                }
            }

            self = @params.self;
            orig(self);
            if (_afterAwake != null)
            {
                foreach (Delegates.Awake_AfterArgs toInvoke in _afterAwake.GetInvocationList())
                {
                    try
                    {
                        _afterAwake.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }
                }
            }
        }

        internal static void HookStart()
        {
            if (!HookedList.Contains("Start"))
            {
                HookedList.Add("Start");
                On.Climber.Start += Start;
            }
        }

        internal static event Delegates.Start_BeforeArgs _beforeStart;
        internal static event Delegates.Start_AfterArgs _afterStart;

        private static void Start(On.Climber.orig_Start orig, Climber self)
        {
            Delegates.Params_Start @params = new()
            {
                self = self
            };
            if (_beforeStart != null)
            {
                foreach (Delegates.Start_BeforeArgs toInvoke in _beforeStart.GetInvocationList())
                {
                    try
                    {
                        _beforeStart?.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }
                }
            }

            self = @params.self;
            orig(self);
            if (_afterStart != null)
            {
                foreach (Delegates.Start_AfterArgs toInvoke in _afterStart.GetInvocationList())
                {
                    try
                    {
                        _afterStart.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }
                }
            }
        }

        internal static void HookWalk()
        {
            if (!HookedList.Contains("Walk"))
            {
                HookedList.Add("Walk");
                On.Climber.Walk += Walk;
            }
        }

        internal static event Delegates.Walk_BeforeArgs _beforeWalk;

        private static System.Collections.IEnumerator Walk(On.Climber.orig_Walk orig, Climber self)
        {
            Delegates.Params_Walk @params = new()
            {
                self = self
            };
            if (_beforeWalk != null)
            {
                foreach (Delegates.Walk_BeforeArgs toInvoke in _beforeWalk.GetInvocationList())
                {
                    try
                    {
                        _beforeWalk?.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }
                }
            }

            self = @params.self;
            return orig(self);
        }

        internal static void HookTurn()
        {
            if (!HookedList.Contains("Turn"))
            {
                HookedList.Add("Turn");
                On.Climber.Turn += Turn;
            }
        }

        internal static event Delegates.Turn_BeforeArgs _beforeTurn;

        private static System.Collections.IEnumerator Turn(On.Climber.orig_Turn orig, Climber self, bool turnClockwise,
            bool tweenPos)
        {
            Delegates.Params_Turn @params = new()
            {
                self = self, turnClockwise = turnClockwise, tweenPos = tweenPos
            };
            if (_beforeTurn != null)
            {
                foreach (Delegates.Turn_BeforeArgs toInvoke in _beforeTurn.GetInvocationList())
                {
                    try
                    {
                        _beforeTurn?.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }
                }
            }

            self = @params.self;
            turnClockwise = @params.turnClockwise;
            tweenPos = @params.tweenPos;
            return orig(self, turnClockwise, tweenPos);
        }

        internal static void HookCheckGround()
        {
            if (!HookedList.Contains("CheckGround"))
            {
                HookedList.Add("CheckGround");
                On.Climber.CheckGround += CheckGround;
            }
        }

        internal static event Delegates.CheckGround_BeforeArgs _beforeCheckGround;
        internal static event Delegates.CheckGround_AfterArgs _afterCheckGround;

        private static bool CheckGround(On.Climber.orig_CheckGround orig, Climber self)
        {
            Delegates.Params_CheckGround @params = new()
            {
                self = self
            };
            if (_beforeCheckGround != null)
            {
                foreach (Delegates.CheckGround_BeforeArgs toInvoke in _beforeCheckGround.GetInvocationList())
                {
                    try
                    {
                        _beforeCheckGround?.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }
                }
            }

            self = @params.self;
            var retVal = orig(self);
            if (_afterCheckGround != null)
            {
                foreach (Delegates.CheckGround_AfterArgs toInvoke in _afterCheckGround.GetInvocationList())
                {
                    try
                    {
                        retVal = _afterCheckGround.Invoke(@params, retVal);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }
                }
            }

            return retVal;
        }

        internal static void HookCheckWall()
        {
            if (!HookedList.Contains("CheckWall"))
            {
                HookedList.Add("CheckWall");
                On.Climber.CheckWall += CheckWall;
            }
        }

        internal static event Delegates.CheckWall_BeforeArgs _beforeCheckWall;
        internal static event Delegates.CheckWall_AfterArgs _afterCheckWall;

        private static bool CheckWall(On.Climber.orig_CheckWall orig, Climber self)
        {
            Delegates.Params_CheckWall @params = new()
            {
                self = self
            };
            if (_beforeCheckWall != null)
            {
                foreach (Delegates.CheckWall_BeforeArgs toInvoke in _beforeCheckWall.GetInvocationList())
                {
                    try
                    {
                        _beforeCheckWall?.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }
                }
            }

            self = @params.self;
            var retVal = orig(self);
            if (_afterCheckWall != null)
            {
                foreach (Delegates.CheckWall_AfterArgs toInvoke in _afterCheckWall.GetInvocationList())
                {
                    try
                    {
                        retVal = _afterCheckWall.Invoke(@params, retVal);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }
                }
            }

            return retVal;
        }

        internal static void HookStun()
        {
            if (!HookedList.Contains("Stun"))
            {
                HookedList.Add("Stun");
                On.Climber.Stun += Stun;
            }
        }

        internal static event Delegates.Stun_BeforeArgs _beforeStun;
        internal static event Delegates.Stun_AfterArgs _afterStun;

        private static void Stun(On.Climber.orig_Stun orig, Climber self)
        {
            Delegates.Params_Stun @params = new()
            {
                self = self
            };
            if (_beforeStun != null)
            {
                foreach (Delegates.Stun_BeforeArgs toInvoke in _beforeStun.GetInvocationList())
                {
                    try
                    {
                        _beforeStun?.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }
                }
            }

            self = @params.self;
            orig(self);
            if (_afterStun != null)
            {
                foreach (Delegates.Stun_AfterArgs toInvoke in _afterStun.GetInvocationList())
                {
                    try
                    {
                        _afterStun.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }
                }
            }
        }

        internal static void HookDoStun()
        {
            if (!HookedList.Contains("DoStun"))
            {
                HookedList.Add("DoStun");
                On.Climber.DoStun += DoStun;
            }
        }

        internal static event Delegates.DoStun_BeforeArgs _beforeDoStun;

        private static System.Collections.IEnumerator DoStun(On.Climber.orig_DoStun orig, Climber self)
        {
            Delegates.Params_DoStun @params = new()
            {
                self = self
            };
            if (_beforeDoStun != null)
            {
                foreach (Delegates.DoStun_BeforeArgs toInvoke in _beforeDoStun.GetInvocationList())
                {
                    try
                    {
                        _beforeDoStun?.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }
                }
            }

            self = @params.self;
            return orig(self);
        }

        internal static void HookFireRayLocal()
        {
            if (!HookedList.Contains("FireRayLocal"))
            {
                HookedList.Add("FireRayLocal");
                On.Climber.FireRayLocal += FireRayLocal;
            }
        }

        internal static event Delegates.FireRayLocal_BeforeArgs _beforeFireRayLocal;
        internal static event Delegates.FireRayLocal_AfterArgs _afterFireRayLocal;

        private static UnityEngine.RaycastHit2D FireRayLocal(On.Climber.orig_FireRayLocal orig, Climber self,
            UnityEngine.Vector2 direction, float length)
        {
            Delegates.Params_FireRayLocal @params = new()
            {
                self = self, direction = direction, length = length
            };
            if (_beforeFireRayLocal != null)
            {
                foreach (Delegates.FireRayLocal_BeforeArgs toInvoke in _beforeFireRayLocal.GetInvocationList())
                {
                    try
                    {
                        _beforeFireRayLocal?.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }
                }
            }

            self = @params.self;
            direction = @params.direction;
            length = @params.length;
            var retVal = orig(self, direction, length);
            if (_afterFireRayLocal != null)
            {
                foreach (Delegates.FireRayLocal_AfterArgs toInvoke in _afterFireRayLocal.GetInvocationList())
                {
                    try
                    {
                        retVal = _afterFireRayLocal.Invoke(@params, retVal);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }
                }
            }

            return retVal;
        }

        internal static void HookStickToGround()
        {
            if (!HookedList.Contains("StickToGround"))
            {
                HookedList.Add("StickToGround");
                On.Climber.StickToGround += StickToGround;
            }
        }

        internal static event Delegates.StickToGround_BeforeArgs _beforeStickToGround;
        internal static event Delegates.StickToGround_AfterArgs _afterStickToGround;

        private static void StickToGround(On.Climber.orig_StickToGround orig, Climber self)
        {
            Delegates.Params_StickToGround @params = new()
            {
                self = self
            };
            if (_beforeStickToGround != null)
            {
                foreach (Delegates.StickToGround_BeforeArgs toInvoke in _beforeStickToGround.GetInvocationList())
                {
                    try
                    {
                        _beforeStickToGround?.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }
                }
            }

            self = @params.self;
            orig(self);
            if (_afterStickToGround != null)
            {
                foreach (Delegates.StickToGround_AfterArgs toInvoke in _afterStickToGround.GetInvocationList())
                {
                    try
                    {
                        _afterStickToGround.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }
                }
            }
        }
    }

    /// <summary>
    /// Contains necessary information to create Hooks. Does not contain any hooks
    /// </summary>
    public static class Delegates
    {
        public sealed class Params_Awake
        {
            public Climber self;
        }

        public delegate void Awake_BeforeArgs(Params_Awake args);

        public delegate void Awake_AfterArgs(Params_Awake args);

        public delegate void Awake_WithArgs(Action<Climber> orig, Climber self);

        public sealed class Params_Start
        {
            public Climber self;
        }

        public delegate void Start_BeforeArgs(Params_Start args);

        public delegate void Start_AfterArgs(Params_Start args);

        public delegate void Start_WithArgs(Action<Climber> orig, Climber self);

        public sealed class Params_Walk
        {
            public Climber self;
        }

        public delegate void Walk_BeforeArgs(Params_Walk args);

        public delegate System.Collections.IEnumerator Walk_AfterArgs(Params_Walk args,
            System.Collections.IEnumerator ret);

        public delegate System.Collections.IEnumerator Walk_WithArgs(Func<Climber, System.Collections.IEnumerator> orig,
            Climber self);

        public sealed class Params_Turn
        {
            public Climber self;
            public bool turnClockwise;
            public bool tweenPos;
        }

        public delegate void Turn_BeforeArgs(Params_Turn args);

        public delegate System.Collections.IEnumerator Turn_AfterArgs(Params_Turn args,
            System.Collections.IEnumerator ret);

        public delegate System.Collections.IEnumerator Turn_WithArgs(
            Func<Climber, bool, bool, System.Collections.IEnumerator> orig, Climber self, bool turnClockwise,
            bool tweenPos);

        public sealed class Params_CheckGround
        {
            public Climber self;
        }

        public delegate void CheckGround_BeforeArgs(Params_CheckGround args);

        public delegate bool CheckGround_AfterArgs(Params_CheckGround args, bool ret);

        public delegate bool CheckGround_WithArgs(Func<Climber, bool> orig, Climber self);

        public sealed class Params_CheckWall
        {
            public Climber self;
        }

        public delegate void CheckWall_BeforeArgs(Params_CheckWall args);

        public delegate bool CheckWall_AfterArgs(Params_CheckWall args, bool ret);

        public delegate bool CheckWall_WithArgs(Func<Climber, bool> orig, Climber self);

        public sealed class Params_Stun
        {
            public Climber self;
        }

        public delegate void Stun_BeforeArgs(Params_Stun args);

        public delegate void Stun_AfterArgs(Params_Stun args);

        public delegate void Stun_WithArgs(Action<Climber> orig, Climber self);

        public sealed class Params_DoStun
        {
            public Climber self;
        }

        public delegate void DoStun_BeforeArgs(Params_DoStun args);

        public delegate System.Collections.IEnumerator DoStun_AfterArgs(Params_DoStun args,
            System.Collections.IEnumerator ret);

        public delegate System.Collections.IEnumerator DoStun_WithArgs(
            Func<Climber, System.Collections.IEnumerator> orig, Climber self);

        public sealed class Params_FireRayLocal
        {
            public Climber self;
            public UnityEngine.Vector2 direction;
            public float length;
        }

        public delegate void FireRayLocal_BeforeArgs(Params_FireRayLocal args);

        public delegate UnityEngine.RaycastHit2D FireRayLocal_AfterArgs(Params_FireRayLocal args,
            UnityEngine.RaycastHit2D ret);

        public delegate UnityEngine.RaycastHit2D FireRayLocal_WithArgs(
            Func<Climber, UnityEngine.Vector2, float, UnityEngine.RaycastHit2D> orig, Climber self,
            UnityEngine.Vector2 direction, float length);

        public sealed class Params_StickToGround
        {
            public Climber self;
        }

        public delegate void StickToGround_BeforeArgs(Params_StickToGround args);

        public delegate void StickToGround_AfterArgs(Params_StickToGround args);

        public delegate void StickToGround_WithArgs(Action<Climber> orig, Climber self);
    }

    /// <summary>
    /// Contains Hooks to that run code before orig(self) is called
    /// </summary>
    public static class BeforeOrig
    {
        public static event Delegates.Awake_BeforeArgs Awake
        {
            add
            {
                HookHandler._beforeAwake += value;
                HookHandler.HookAwake();
            }
            remove => HookHandler._beforeAwake -= value;
        }

        public static event Delegates.Start_BeforeArgs Start
        {
            add
            {
                HookHandler._beforeStart += value;
                HookHandler.HookStart();
            }
            remove => HookHandler._beforeStart -= value;
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

        public static event Delegates.CheckGround_BeforeArgs CheckGround
        {
            add
            {
                HookHandler._beforeCheckGround += value;
                HookHandler.HookCheckGround();
            }
            remove => HookHandler._beforeCheckGround -= value;
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

        public static event Delegates.Stun_BeforeArgs Stun
        {
            add
            {
                HookHandler._beforeStun += value;
                HookHandler.HookStun();
            }
            remove => HookHandler._beforeStun -= value;
        }

        public static event Delegates.DoStun_BeforeArgs DoStun
        {
            add
            {
                HookHandler._beforeDoStun += value;
                HookHandler.HookDoStun();
            }
            remove => HookHandler._beforeDoStun -= value;
        }

        public static event Delegates.FireRayLocal_BeforeArgs FireRayLocal
        {
            add
            {
                HookHandler._beforeFireRayLocal += value;
                HookHandler.HookFireRayLocal();
            }
            remove => HookHandler._beforeFireRayLocal -= value;
        }

        public static event Delegates.StickToGround_BeforeArgs StickToGround
        {
            add
            {
                HookHandler._beforeStickToGround += value;
                HookHandler.HookStickToGround();
            }
            remove => HookHandler._beforeStickToGround -= value;
        }
    }

    /// <summary>
    /// Contains Hooks to that run code after orig(self) is called
    /// </summary>
    public static class AfterOrig
    {
        public static event Delegates.Awake_AfterArgs Awake
        {
            add
            {
                HookHandler._afterAwake += value;
                HookHandler.HookAwake();
            }
            remove => HookHandler._afterAwake -= value;
        }

        public static event Delegates.Start_AfterArgs Start
        {
            add
            {
                HookHandler._afterStart += value;
                HookHandler.HookStart();
            }
            remove => HookHandler._afterStart -= value;
        }

        public static event Delegates.CheckGround_AfterArgs CheckGround
        {
            add
            {
                HookHandler._afterCheckGround += value;
                HookHandler.HookCheckGround();
            }
            remove => HookHandler._afterCheckGround -= value;
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

        public static event Delegates.Stun_AfterArgs Stun
        {
            add
            {
                HookHandler._afterStun += value;
                HookHandler.HookStun();
            }
            remove => HookHandler._afterStun -= value;
        }

        public static event Delegates.FireRayLocal_AfterArgs FireRayLocal
        {
            add
            {
                HookHandler._afterFireRayLocal += value;
                HookHandler.HookFireRayLocal();
            }
            remove => HookHandler._afterFireRayLocal -= value;
        }

        public static event Delegates.StickToGround_AfterArgs StickToGround
        {
            add
            {
                HookHandler._afterStickToGround += value;
                HookHandler.HookStickToGround();
            }
            remove => HookHandler._afterStickToGround -= value;
        }
    }

    /// <summary>
    /// Contains all On Hooks, even those that aren't in the On namespace such as API generated functions and property getters/setters
    /// </summary>
    public static class WithOrig
    {
        public static event On.Climber.hook_Awake Awake
        {
            add => On.Climber.Awake += value;
            remove => On.Climber.Awake -= value;
        }

        public static event On.Climber.hook_Start Start
        {
            add => On.Climber.Start += value;
            remove => On.Climber.Start -= value;
        }

        public static event On.Climber.hook_Walk Walk
        {
            add => On.Climber.Walk += value;
            remove => On.Climber.Walk -= value;
        }

        public static event On.Climber.hook_Turn Turn
        {
            add => On.Climber.Turn += value;
            remove => On.Climber.Turn -= value;
        }

        public static event On.Climber.hook_CheckGround CheckGround
        {
            add => On.Climber.CheckGround += value;
            remove => On.Climber.CheckGround -= value;
        }

        public static event On.Climber.hook_CheckWall CheckWall
        {
            add => On.Climber.CheckWall += value;
            remove => On.Climber.CheckWall -= value;
        }

        public static event On.Climber.hook_Stun Stun
        {
            add => On.Climber.Stun += value;
            remove => On.Climber.Stun -= value;
        }

        public static event On.Climber.hook_DoStun DoStun
        {
            add => On.Climber.DoStun += value;
            remove => On.Climber.DoStun -= value;
        }

        public static event On.Climber.hook_FireRayLocal FireRayLocal
        {
            add => On.Climber.FireRayLocal += value;
            remove => On.Climber.FireRayLocal -= value;
        }

        public static event On.Climber.hook_StickToGround StickToGround
        {
            add => On.Climber.StickToGround += value;
            remove => On.Climber.StickToGround -= value;
        }
    }
}