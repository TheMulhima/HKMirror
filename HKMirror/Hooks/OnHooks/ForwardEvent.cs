using MonoMod.RuntimeDetour;
using MonoMod.RuntimeDetour.HookGen;

namespace HKMirror.Hooks.OnHooks;

/// <summary>
///     Contains different types of On Hooks for ForwardEvent class.<br />
///     Contains hooks that aren't generated by monomod, and before and after orig hooks for easier hooking.
/// </summary>
public static class OnForwardEvent
{
    internal static class HookHandler
    {
        private static readonly List<string> HookedList = new();

        internal static void HookReset()
        {
            if (!HookedList.Contains("Reset"))
            {
                HookedList.Add("Reset");
                new Hook(ReflectionHelper.GetMethodInfo(typeof(ForwardEvent), "Reset"), Reset);
            }
        }

        internal static event Delegates.Reset_BeforeArgs _beforeReset;
        internal static event Delegates.Reset_NormalArgs _afterReset;

        private static void Reset(Action<ForwardEvent> orig, ForwardEvent self)
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

        internal static void HookEvent()
        {
            if (!HookedList.Contains("Event"))
            {
                HookedList.Add("Event");
                new Hook(ReflectionHelper.GetMethodInfo(typeof(ForwardEvent), "Event"), Event);
            }
        }

        internal static event Delegates.Event_BeforeArgs _beforeEvent;
        internal static event Delegates.Event_NormalArgs _afterEvent;

        private static bool Event(Func<ForwardEvent, FsmEvent, bool> orig, ForwardEvent self, FsmEvent fsmEvent)
        {
            Delegates.Params_Event @params = new()
            {
                self = self, fsmEvent = fsmEvent
            };
            _beforeEvent?.Invoke(@params);
            self = @params.self;
            fsmEvent = @params.fsmEvent;
            var retVal = orig(self, fsmEvent);
            if (_afterEvent != null) retVal = _afterEvent.Invoke(@params);
            return retVal;
        }
    }

    /// <summary>
    ///     Contains necessary information to create Hooks. Does not contain any hooks
    /// </summary>
    public static class Delegates
    {
        public delegate void Event_BeforeArgs(Params_Event args);

        public delegate bool Event_NormalArgs(Params_Event args);

        public delegate void Reset_BeforeArgs(Params_Reset args);

        public delegate void Reset_NormalArgs(Params_Reset args);

        public sealed class Params_Reset
        {
            public ForwardEvent self;
        }

        public sealed class Params_Event
        {
            public FsmEvent fsmEvent;
            public ForwardEvent self;
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

        public static event Delegates.Event_BeforeArgs Event
        {
            add
            {
                HookHandler._beforeEvent += value;
                HookHandler.HookEvent();
            }
            remove => HookHandler._beforeEvent -= value;
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

        public static event Delegates.Event_NormalArgs Event
        {
            add
            {
                HookHandler._afterEvent += value;
                HookHandler.HookEvent();
            }
            remove => HookHandler._afterEvent -= value;
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
                ReflectionHelper.GetMethodInfo(typeof(ForwardEvent), "Reset"), value);
            remove => HookEndpointManager.Remove<Delegates.Reset_NormalArgs>(
                ReflectionHelper.GetMethodInfo(typeof(ForwardEvent), "Reset"), value);
        }

        public static event Delegates.Event_NormalArgs Event
        {
            add => HookEndpointManager.Add<Delegates.Event_NormalArgs>(
                ReflectionHelper.GetMethodInfo(typeof(ForwardEvent), "Event"), value);
            remove => HookEndpointManager.Remove<Delegates.Event_NormalArgs>(
                ReflectionHelper.GetMethodInfo(typeof(ForwardEvent), "Event"), value);
        }
    }
}