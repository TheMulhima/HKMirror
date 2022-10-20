using MonoMod.RuntimeDetour;
using MonoMod.RuntimeDetour.HookGen;

namespace HKMirror.Hooks.OnHooks;

/// <summary>
///     Contains different types of On Hooks for BigCentipede class.<br />
///     Contains hooks that aren't generated by monomod, and before and after orig hooks for easier hooking.
/// </summary>
public static class OnBigCentipede
{
    internal static class HookHandler
    {
        private static readonly List<string> HookedList = new();

        internal static void Hookget_EntryPoint()
        {
            if (!HookedList.Contains("get_EntryPoint"))
            {
                HookedList.Add("get_EntryPoint");
                new Hook(ReflectionHelper.GetMethodInfo(typeof(BigCentipede), "get_EntryPoint"), get_EntryPoint);
            }
        }

        internal static event Delegates.get_EntryPoint_BeforeArgs _beforeget_EntryPoint;
        internal static event Delegates.get_EntryPoint_NormalArgs _afterget_EntryPoint;

        private static Vector2 get_EntryPoint(Func<BigCentipede, Vector2> orig, BigCentipede self)
        {
            Delegates.Params_get_EntryPoint @params = new()
            {
                self = self
            };
            _beforeget_EntryPoint?.Invoke(@params);
            self = @params.self;
            var retVal = orig(self);
            if (_afterget_EntryPoint != null) retVal = _afterget_EntryPoint.Invoke(@params);
            return retVal;
        }

        internal static void Hookget_ExitPoint()
        {
            if (!HookedList.Contains("get_ExitPoint"))
            {
                HookedList.Add("get_ExitPoint");
                new Hook(ReflectionHelper.GetMethodInfo(typeof(BigCentipede), "get_ExitPoint"), get_ExitPoint);
            }
        }

        internal static event Delegates.get_ExitPoint_BeforeArgs _beforeget_ExitPoint;
        internal static event Delegates.get_ExitPoint_NormalArgs _afterget_ExitPoint;

        private static Vector2 get_ExitPoint(Func<BigCentipede, Vector2> orig, BigCentipede self)
        {
            Delegates.Params_get_ExitPoint @params = new()
            {
                self = self
            };
            _beforeget_ExitPoint?.Invoke(@params);
            self = @params.self;
            var retVal = orig(self);
            if (_afterget_ExitPoint != null) retVal = _afterget_ExitPoint.Invoke(@params);
            return retVal;
        }

        internal static void Hookget_Direction()
        {
            if (!HookedList.Contains("get_Direction"))
            {
                HookedList.Add("get_Direction");
                new Hook(ReflectionHelper.GetMethodInfo(typeof(BigCentipede), "get_Direction"), get_Direction);
            }
        }

        internal static event Delegates.get_Direction_BeforeArgs _beforeget_Direction;
        internal static event Delegates.get_Direction_NormalArgs _afterget_Direction;

        private static Vector2 get_Direction(Func<BigCentipede, Vector2> orig, BigCentipede self)
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

        internal static void HookAwake()
        {
            if (!HookedList.Contains("Awake"))
            {
                HookedList.Add("Awake");
                On.BigCentipede.Awake += Awake;
            }
        }

        internal static event Delegates.Awake_BeforeArgs _beforeAwake;
        internal static event Delegates.Awake_NormalArgs _afterAwake;

        private static void Awake(On.BigCentipede.orig_Awake orig, BigCentipede self)
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

        internal static void HookStart()
        {
            if (!HookedList.Contains("Start"))
            {
                HookedList.Add("Start");
                On.BigCentipede.Start += Start;
            }
        }

        internal static event Delegates.Start_BeforeArgs _beforeStart;
        internal static event Delegates.Start_NormalArgs _afterStart;

        private static void Start(On.BigCentipede.orig_Start orig, BigCentipede self)
        {
            Delegates.Params_Start @params = new()
            {
                self = self
            };
            _beforeStart?.Invoke(@params);
            self = @params.self;
            orig(self);
            if (_afterStart != null) _afterStart.Invoke(@params);
        }

        internal static void HookUnBurrow()
        {
            if (!HookedList.Contains("UnBurrow"))
            {
                HookedList.Add("UnBurrow");
                On.BigCentipede.UnBurrow += UnBurrow;
            }
        }

        internal static event Delegates.UnBurrow_BeforeArgs _beforeUnBurrow;
        internal static event Delegates.UnBurrow_NormalArgs _afterUnBurrow;

        private static void UnBurrow(On.BigCentipede.orig_UnBurrow orig, BigCentipede self, bool changePosition)
        {
            Delegates.Params_UnBurrow @params = new()
            {
                self = self, changePosition = changePosition
            };
            _beforeUnBurrow?.Invoke(@params);
            self = @params.self;
            changePosition = @params.changePosition;
            orig(self, changePosition);
            if (_afterUnBurrow != null) _afterUnBurrow.Invoke(@params);
        }

        internal static void HookBurrow()
        {
            if (!HookedList.Contains("Burrow"))
            {
                HookedList.Add("Burrow");
                On.BigCentipede.Burrow += Burrow;
            }
        }

        internal static event Delegates.Burrow_BeforeArgs _beforeBurrow;
        internal static event Delegates.Burrow_NormalArgs _afterBurrow;

        private static void Burrow(On.BigCentipede.orig_Burrow orig, BigCentipede self)
        {
            Delegates.Params_Burrow @params = new()
            {
                self = self
            };
            _beforeBurrow?.Invoke(@params);
            self = @params.self;
            orig(self);
            if (_afterBurrow != null) _afterBurrow.Invoke(@params);
        }

        internal static void HookFixedUpdate()
        {
            if (!HookedList.Contains("FixedUpdate"))
            {
                HookedList.Add("FixedUpdate");
                On.BigCentipede.FixedUpdate += FixedUpdate;
            }
        }

        internal static event Delegates.FixedUpdate_BeforeArgs _beforeFixedUpdate;
        internal static event Delegates.FixedUpdate_NormalArgs _afterFixedUpdate;

        private static void FixedUpdate(On.BigCentipede.orig_FixedUpdate orig, BigCentipede self)
        {
            Delegates.Params_FixedUpdate @params = new()
            {
                self = self
            };
            _beforeFixedUpdate?.Invoke(@params);
            self = @params.self;
            orig(self);
            if (_afterFixedUpdate != null) _afterFixedUpdate.Invoke(@params);
        }

        internal static void HookUpdate()
        {
            if (!HookedList.Contains("Update"))
            {
                HookedList.Add("Update");
                On.BigCentipede.Update += Update;
            }
        }

        internal static event Delegates.Update_BeforeArgs _beforeUpdate;
        internal static event Delegates.Update_NormalArgs _afterUpdate;

        private static void Update(On.BigCentipede.orig_Update orig, BigCentipede self)
        {
            Delegates.Params_Update @params = new()
            {
                self = self
            };
            _beforeUpdate?.Invoke(@params);
            self = @params.self;
            orig(self);
            if (_afterUpdate != null) _afterUpdate.Invoke(@params);
        }
    }

    /// <summary>
    ///     Contains necessary information to create Hooks. Does not contain any hooks
    /// </summary>
    public static class Delegates
    {
        public delegate void Awake_BeforeArgs(Params_Awake args);

        public delegate void Awake_NormalArgs(Params_Awake args);

        public delegate void Burrow_BeforeArgs(Params_Burrow args);

        public delegate void Burrow_NormalArgs(Params_Burrow args);

        public delegate void FixedUpdate_BeforeArgs(Params_FixedUpdate args);

        public delegate void FixedUpdate_NormalArgs(Params_FixedUpdate args);

        public delegate void get_Direction_BeforeArgs(Params_get_Direction args);

        public delegate Vector2 get_Direction_NormalArgs(Params_get_Direction args);

        public delegate void get_EntryPoint_BeforeArgs(Params_get_EntryPoint args);

        public delegate Vector2 get_EntryPoint_NormalArgs(Params_get_EntryPoint args);

        public delegate void get_ExitPoint_BeforeArgs(Params_get_ExitPoint args);

        public delegate Vector2 get_ExitPoint_NormalArgs(Params_get_ExitPoint args);

        public delegate void Start_BeforeArgs(Params_Start args);

        public delegate void Start_NormalArgs(Params_Start args);

        public delegate void UnBurrow_BeforeArgs(Params_UnBurrow args);

        public delegate void UnBurrow_NormalArgs(Params_UnBurrow args);

        public delegate void Update_BeforeArgs(Params_Update args);

        public delegate void Update_NormalArgs(Params_Update args);

        public sealed class Params_get_EntryPoint
        {
            public BigCentipede self;
        }

        public sealed class Params_get_ExitPoint
        {
            public BigCentipede self;
        }

        public sealed class Params_get_Direction
        {
            public BigCentipede self;
        }

        public sealed class Params_Awake
        {
            public BigCentipede self;
        }

        public sealed class Params_Start
        {
            public BigCentipede self;
        }

        public sealed class Params_UnBurrow
        {
            public bool changePosition;
            public BigCentipede self;
        }

        public sealed class Params_Burrow
        {
            public BigCentipede self;
        }

        public sealed class Params_FixedUpdate
        {
            public BigCentipede self;
        }

        public sealed class Params_Update
        {
            public BigCentipede self;
        }
    }

    /// <summary>
    ///     Contains Hooks to that run code before orig(self) is called
    /// </summary>
    public static class BeforeOrig
    {
        public static event Delegates.get_EntryPoint_BeforeArgs get_EntryPoint
        {
            add
            {
                HookHandler._beforeget_EntryPoint += value;
                HookHandler.Hookget_EntryPoint();
            }
            remove => HookHandler._beforeget_EntryPoint -= value;
        }

        public static event Delegates.get_ExitPoint_BeforeArgs get_ExitPoint
        {
            add
            {
                HookHandler._beforeget_ExitPoint += value;
                HookHandler.Hookget_ExitPoint();
            }
            remove => HookHandler._beforeget_ExitPoint -= value;
        }

        public static event Delegates.get_Direction_BeforeArgs get_Direction
        {
            add
            {
                HookHandler._beforeget_Direction += value;
                HookHandler.Hookget_Direction();
            }
            remove => HookHandler._beforeget_Direction -= value;
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

        public static event Delegates.Start_BeforeArgs Start
        {
            add
            {
                HookHandler._beforeStart += value;
                HookHandler.HookStart();
            }
            remove => HookHandler._beforeStart -= value;
        }

        public static event Delegates.UnBurrow_BeforeArgs UnBurrow
        {
            add
            {
                HookHandler._beforeUnBurrow += value;
                HookHandler.HookUnBurrow();
            }
            remove => HookHandler._beforeUnBurrow -= value;
        }

        public static event Delegates.Burrow_BeforeArgs Burrow
        {
            add
            {
                HookHandler._beforeBurrow += value;
                HookHandler.HookBurrow();
            }
            remove => HookHandler._beforeBurrow -= value;
        }

        public static event Delegates.FixedUpdate_BeforeArgs FixedUpdate
        {
            add
            {
                HookHandler._beforeFixedUpdate += value;
                HookHandler.HookFixedUpdate();
            }
            remove => HookHandler._beforeFixedUpdate -= value;
        }

        public static event Delegates.Update_BeforeArgs Update
        {
            add
            {
                HookHandler._beforeUpdate += value;
                HookHandler.HookUpdate();
            }
            remove => HookHandler._beforeUpdate -= value;
        }
    }

    /// <summary>
    ///     Contains Hooks to that run code after orig(self) is called
    /// </summary>
    public static class AfterOrig
    {
        public static event Delegates.get_EntryPoint_NormalArgs get_EntryPoint
        {
            add
            {
                HookHandler._afterget_EntryPoint += value;
                HookHandler.Hookget_EntryPoint();
            }
            remove => HookHandler._afterget_EntryPoint -= value;
        }

        public static event Delegates.get_ExitPoint_NormalArgs get_ExitPoint
        {
            add
            {
                HookHandler._afterget_ExitPoint += value;
                HookHandler.Hookget_ExitPoint();
            }
            remove => HookHandler._afterget_ExitPoint -= value;
        }

        public static event Delegates.get_Direction_NormalArgs get_Direction
        {
            add
            {
                HookHandler._afterget_Direction += value;
                HookHandler.Hookget_Direction();
            }
            remove => HookHandler._afterget_Direction -= value;
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

        public static event Delegates.Start_NormalArgs Start
        {
            add
            {
                HookHandler._afterStart += value;
                HookHandler.HookStart();
            }
            remove => HookHandler._afterStart -= value;
        }

        public static event Delegates.UnBurrow_NormalArgs UnBurrow
        {
            add
            {
                HookHandler._afterUnBurrow += value;
                HookHandler.HookUnBurrow();
            }
            remove => HookHandler._afterUnBurrow -= value;
        }

        public static event Delegates.Burrow_NormalArgs Burrow
        {
            add
            {
                HookHandler._afterBurrow += value;
                HookHandler.HookBurrow();
            }
            remove => HookHandler._afterBurrow -= value;
        }

        public static event Delegates.FixedUpdate_NormalArgs FixedUpdate
        {
            add
            {
                HookHandler._afterFixedUpdate += value;
                HookHandler.HookFixedUpdate();
            }
            remove => HookHandler._afterFixedUpdate -= value;
        }

        public static event Delegates.Update_NormalArgs Update
        {
            add
            {
                HookHandler._afterUpdate += value;
                HookHandler.HookUpdate();
            }
            remove => HookHandler._afterUpdate -= value;
        }
    }

    /// <summary>
    ///     Contains all On Hooks, even those that aren't in the On namespace such as API generated functions and property
    ///     getters/setters
    /// </summary>
    public static class WithOrig
    {
        public static event Delegates.get_EntryPoint_NormalArgs get_EntryPoint
        {
            add => HookEndpointManager.Add<Delegates.get_EntryPoint_NormalArgs>(
                ReflectionHelper.GetMethodInfo(typeof(BigCentipede), "get_EntryPoint"), value);
            remove => HookEndpointManager.Remove<Delegates.get_EntryPoint_NormalArgs>(
                ReflectionHelper.GetMethodInfo(typeof(BigCentipede), "get_EntryPoint"), value);
        }

        public static event Delegates.get_ExitPoint_NormalArgs get_ExitPoint
        {
            add => HookEndpointManager.Add<Delegates.get_ExitPoint_NormalArgs>(
                ReflectionHelper.GetMethodInfo(typeof(BigCentipede), "get_ExitPoint"), value);
            remove => HookEndpointManager.Remove<Delegates.get_ExitPoint_NormalArgs>(
                ReflectionHelper.GetMethodInfo(typeof(BigCentipede), "get_ExitPoint"), value);
        }

        public static event Delegates.get_Direction_NormalArgs get_Direction
        {
            add => HookEndpointManager.Add<Delegates.get_Direction_NormalArgs>(
                ReflectionHelper.GetMethodInfo(typeof(BigCentipede), "get_Direction"), value);
            remove => HookEndpointManager.Remove<Delegates.get_Direction_NormalArgs>(
                ReflectionHelper.GetMethodInfo(typeof(BigCentipede), "get_Direction"), value);
        }

        public static event On.BigCentipede.hook_Awake Awake
        {
            add => On.BigCentipede.Awake += value;
            remove => On.BigCentipede.Awake -= value;
        }

        public static event On.BigCentipede.hook_Start Start
        {
            add => On.BigCentipede.Start += value;
            remove => On.BigCentipede.Start -= value;
        }

        public static event On.BigCentipede.hook_UnBurrow UnBurrow
        {
            add => On.BigCentipede.UnBurrow += value;
            remove => On.BigCentipede.UnBurrow -= value;
        }

        public static event On.BigCentipede.hook_Burrow Burrow
        {
            add => On.BigCentipede.Burrow += value;
            remove => On.BigCentipede.Burrow -= value;
        }

        public static event On.BigCentipede.hook_FixedUpdate FixedUpdate
        {
            add => On.BigCentipede.FixedUpdate += value;
            remove => On.BigCentipede.FixedUpdate -= value;
        }

        public static event On.BigCentipede.hook_Update Update
        {
            add => On.BigCentipede.Update += value;
            remove => On.BigCentipede.Update -= value;
        }
    }
}