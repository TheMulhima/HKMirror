using MonoMod.RuntimeDetour;
using MonoMod.RuntimeDetour.HookGen;

namespace HKMirror.Hooks.OnHooks;

/// <summary>
///     Contains different types of On Hooks for ArrayListShuffle class.<br />
///     Contains hooks that aren't generated by monomod, and before and after orig hooks for easier hooking.
/// </summary>
public static class OnArrayListShuffle
{
    internal static class HookHandler
    {
        private static readonly List<string> HookedList = new();

        internal static void HookReset()
        {
            if (!HookedList.Contains("Reset"))
            {
                HookedList.Add("Reset");
                new Hook(ReflectionHelper.GetMethodInfo(typeof(ArrayListShuffle), "Reset"), Reset);
            }
        }

        internal static event Delegates.Reset_BeforeArgs _beforeReset;
        internal static event Delegates.Reset_NormalArgs _afterReset;

        private static void Reset(Action<ArrayListShuffle> orig, ArrayListShuffle self)
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
                new Hook(ReflectionHelper.GetMethodInfo(typeof(ArrayListShuffle), "OnEnter"), OnEnter);
            }
        }

        internal static event Delegates.OnEnter_BeforeArgs _beforeOnEnter;
        internal static event Delegates.OnEnter_NormalArgs _afterOnEnter;

        private static void OnEnter(Action<ArrayListShuffle> orig, ArrayListShuffle self)
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

        internal static void HookDoArrayListShuffle()
        {
            if (!HookedList.Contains("DoArrayListShuffle"))
            {
                HookedList.Add("DoArrayListShuffle");
                new Hook(ReflectionHelper.GetMethodInfo(typeof(ArrayListShuffle), "DoArrayListShuffle"),
                    DoArrayListShuffle);
            }
        }

        internal static event Delegates.DoArrayListShuffle_BeforeArgs _beforeDoArrayListShuffle;
        internal static event Delegates.DoArrayListShuffle_NormalArgs _afterDoArrayListShuffle;

        private static void DoArrayListShuffle(Action<ArrayListShuffle, ArrayList> orig, ArrayListShuffle self,
            ArrayList source)
        {
            Delegates.Params_DoArrayListShuffle @params = new()
            {
                self = self, source = source
            };
            _beforeDoArrayListShuffle?.Invoke(@params);
            self = @params.self;
            source = @params.source;
            orig(self, source);
            if (_afterDoArrayListShuffle != null) _afterDoArrayListShuffle.Invoke(@params);
        }
    }

    /// <summary>
    ///     Contains necessary information to create Hooks. Does not contain any hooks
    /// </summary>
    public static class Delegates
    {
        public delegate void DoArrayListShuffle_BeforeArgs(Params_DoArrayListShuffle args);

        public delegate void DoArrayListShuffle_NormalArgs(Params_DoArrayListShuffle args);

        public delegate void OnEnter_BeforeArgs(Params_OnEnter args);

        public delegate void OnEnter_NormalArgs(Params_OnEnter args);

        public delegate void Reset_BeforeArgs(Params_Reset args);

        public delegate void Reset_NormalArgs(Params_Reset args);

        public sealed class Params_Reset
        {
            public ArrayListShuffle self;
        }

        public sealed class Params_OnEnter
        {
            public ArrayListShuffle self;
        }

        public sealed class Params_DoArrayListShuffle
        {
            public ArrayListShuffle self;
            public ArrayList source;
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

        public static event Delegates.DoArrayListShuffle_BeforeArgs DoArrayListShuffle
        {
            add
            {
                HookHandler._beforeDoArrayListShuffle += value;
                HookHandler.HookDoArrayListShuffle();
            }
            remove => HookHandler._beforeDoArrayListShuffle -= value;
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

        public static event Delegates.DoArrayListShuffle_NormalArgs DoArrayListShuffle
        {
            add
            {
                HookHandler._afterDoArrayListShuffle += value;
                HookHandler.HookDoArrayListShuffle();
            }
            remove => HookHandler._afterDoArrayListShuffle -= value;
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
                ReflectionHelper.GetMethodInfo(typeof(ArrayListShuffle), "Reset"), value);
            remove => HookEndpointManager.Remove<Delegates.Reset_NormalArgs>(
                ReflectionHelper.GetMethodInfo(typeof(ArrayListShuffle), "Reset"), value);
        }

        public static event Delegates.OnEnter_NormalArgs OnEnter
        {
            add => HookEndpointManager.Add<Delegates.OnEnter_NormalArgs>(
                ReflectionHelper.GetMethodInfo(typeof(ArrayListShuffle), "OnEnter"), value);
            remove => HookEndpointManager.Remove<Delegates.OnEnter_NormalArgs>(
                ReflectionHelper.GetMethodInfo(typeof(ArrayListShuffle), "OnEnter"), value);
        }

        public static event Delegates.DoArrayListShuffle_NormalArgs DoArrayListShuffle
        {
            add => HookEndpointManager.Add<Delegates.DoArrayListShuffle_NormalArgs>(
                ReflectionHelper.GetMethodInfo(typeof(ArrayListShuffle), "DoArrayListShuffle"), value);
            remove => HookEndpointManager.Remove<Delegates.DoArrayListShuffle_NormalArgs>(
                ReflectionHelper.GetMethodInfo(typeof(ArrayListShuffle), "DoArrayListShuffle"), value);
        }
    }
}