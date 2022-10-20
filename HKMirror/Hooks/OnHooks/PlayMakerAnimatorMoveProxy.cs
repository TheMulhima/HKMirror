namespace HKMirror.Hooks.OnHooks;

/// <summary>
///     Contains different types of On Hooks for PlayMakerAnimatorMoveProxy class.<br />
///     Contains hooks that aren't generated by monomod, and before and after orig hooks for easier hooking.
/// </summary>
public static class OnPlayMakerAnimatorMoveProxy
{
    internal static class HookHandler
    {
        private static readonly List<string> HookedList = new();

        internal static void HookStart()
        {
            if (!HookedList.Contains("Start"))
            {
                HookedList.Add("Start");
                On.PlayMakerAnimatorMoveProxy.Start += Start;
            }
        }

        internal static event Delegates.Start_BeforeArgs _beforeStart;
        internal static event Delegates.Start_NormalArgs _afterStart;

        private static void Start(On.PlayMakerAnimatorMoveProxy.orig_Start orig, PlayMakerAnimatorMoveProxy self)
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

        internal static void HookUpdate()
        {
            if (!HookedList.Contains("Update"))
            {
                HookedList.Add("Update");
                On.PlayMakerAnimatorMoveProxy.Update += Update;
            }
        }

        internal static event Delegates.Update_BeforeArgs _beforeUpdate;
        internal static event Delegates.Update_NormalArgs _afterUpdate;

        private static void Update(On.PlayMakerAnimatorMoveProxy.orig_Update orig, PlayMakerAnimatorMoveProxy self)
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

        internal static void HookOnAnimatorMove()
        {
            if (!HookedList.Contains("OnAnimatorMove"))
            {
                HookedList.Add("OnAnimatorMove");
                On.PlayMakerAnimatorMoveProxy.OnAnimatorMove += OnAnimatorMove;
            }
        }

        internal static event Delegates.OnAnimatorMove_BeforeArgs _beforeOnAnimatorMove;
        internal static event Delegates.OnAnimatorMove_NormalArgs _afterOnAnimatorMove;

        private static void OnAnimatorMove(On.PlayMakerAnimatorMoveProxy.orig_OnAnimatorMove orig,
            PlayMakerAnimatorMoveProxy self)
        {
            Delegates.Params_OnAnimatorMove @params = new()
            {
                self = self
            };
            _beforeOnAnimatorMove?.Invoke(@params);
            self = @params.self;
            orig(self);
            if (_afterOnAnimatorMove != null) _afterOnAnimatorMove.Invoke(@params);
        }
    }

    /// <summary>
    ///     Contains necessary information to create Hooks. Does not contain any hooks
    /// </summary>
    public static class Delegates
    {
        public delegate void OnAnimatorMove_BeforeArgs(Params_OnAnimatorMove args);

        public delegate void OnAnimatorMove_NormalArgs(Params_OnAnimatorMove args);

        public delegate void Start_BeforeArgs(Params_Start args);

        public delegate void Start_NormalArgs(Params_Start args);

        public delegate void Update_BeforeArgs(Params_Update args);

        public delegate void Update_NormalArgs(Params_Update args);

        public sealed class Params_Start
        {
            public PlayMakerAnimatorMoveProxy self;
        }

        public sealed class Params_Update
        {
            public PlayMakerAnimatorMoveProxy self;
        }

        public sealed class Params_OnAnimatorMove
        {
            public PlayMakerAnimatorMoveProxy self;
        }
    }

    /// <summary>
    ///     Contains Hooks to that run code before orig(self) is called
    /// </summary>
    public static class BeforeOrig
    {
        public static event Delegates.Start_BeforeArgs Start
        {
            add
            {
                HookHandler._beforeStart += value;
                HookHandler.HookStart();
            }
            remove => HookHandler._beforeStart -= value;
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

        public static event Delegates.OnAnimatorMove_BeforeArgs OnAnimatorMove
        {
            add
            {
                HookHandler._beforeOnAnimatorMove += value;
                HookHandler.HookOnAnimatorMove();
            }
            remove => HookHandler._beforeOnAnimatorMove -= value;
        }
    }

    /// <summary>
    ///     Contains Hooks to that run code after orig(self) is called
    /// </summary>
    public static class AfterOrig
    {
        public static event Delegates.Start_NormalArgs Start
        {
            add
            {
                HookHandler._afterStart += value;
                HookHandler.HookStart();
            }
            remove => HookHandler._afterStart -= value;
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

        public static event Delegates.OnAnimatorMove_NormalArgs OnAnimatorMove
        {
            add
            {
                HookHandler._afterOnAnimatorMove += value;
                HookHandler.HookOnAnimatorMove();
            }
            remove => HookHandler._afterOnAnimatorMove -= value;
        }
    }

    /// <summary>
    ///     Contains all On Hooks, even those that aren't in the On namespace such as API generated functions and property
    ///     getters/setters
    /// </summary>
    public static class WithOrig
    {
        public static event On.PlayMakerAnimatorMoveProxy.hook_Start Start
        {
            add => On.PlayMakerAnimatorMoveProxy.Start += value;
            remove => On.PlayMakerAnimatorMoveProxy.Start -= value;
        }

        public static event On.PlayMakerAnimatorMoveProxy.hook_Update Update
        {
            add => On.PlayMakerAnimatorMoveProxy.Update += value;
            remove => On.PlayMakerAnimatorMoveProxy.Update -= value;
        }

        public static event On.PlayMakerAnimatorMoveProxy.hook_OnAnimatorMove OnAnimatorMove
        {
            add => On.PlayMakerAnimatorMoveProxy.OnAnimatorMove += value;
            remove => On.PlayMakerAnimatorMoveProxy.OnAnimatorMove -= value;
        }
    }
}