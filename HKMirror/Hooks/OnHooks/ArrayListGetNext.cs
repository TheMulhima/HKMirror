using MonoMod.RuntimeDetour;
using MonoMod.RuntimeDetour.HookGen;

namespace HKMirror.Hooks.OnHooks;

/// <summary>
///     Contains different types of On Hooks for ArrayListGetNext class.<br />
///     Contains hooks that aren't generated by monomod, and before and after orig hooks for easier hooking.
/// </summary>
public static class OnArrayListGetNext
{
    internal static class HookHandler
    {
        private static readonly List<string> HookedList = new();

        internal static void HookReset()
        {
            if (!HookedList.Contains("Reset"))
            {
                HookedList.Add("Reset");
                new Hook(ReflectionHelper.GetMethodInfo(typeof(ArrayListGetNext), "Reset"), Reset);
            }
        }

        internal static event Delegates.Reset_BeforeArgs _beforeReset;
        internal static event Delegates.Reset_NormalArgs _afterReset;

        private static void Reset(Action<ArrayListGetNext> orig, ArrayListGetNext self)
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
                new Hook(ReflectionHelper.GetMethodInfo(typeof(ArrayListGetNext), "OnEnter"), OnEnter);
            }
        }

        internal static event Delegates.OnEnter_BeforeArgs _beforeOnEnter;
        internal static event Delegates.OnEnter_NormalArgs _afterOnEnter;

        private static void OnEnter(Action<ArrayListGetNext> orig, ArrayListGetNext self)
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

        internal static void HookDoGetNextItem()
        {
            if (!HookedList.Contains("DoGetNextItem"))
            {
                HookedList.Add("DoGetNextItem");
                new Hook(ReflectionHelper.GetMethodInfo(typeof(ArrayListGetNext), "DoGetNextItem"), DoGetNextItem);
            }
        }

        internal static event Delegates.DoGetNextItem_BeforeArgs _beforeDoGetNextItem;
        internal static event Delegates.DoGetNextItem_NormalArgs _afterDoGetNextItem;

        private static void DoGetNextItem(Action<ArrayListGetNext> orig, ArrayListGetNext self)
        {
            Delegates.Params_DoGetNextItem @params = new()
            {
                self = self
            };
            _beforeDoGetNextItem?.Invoke(@params);
            self = @params.self;
            orig(self);
            if (_afterDoGetNextItem != null) _afterDoGetNextItem.Invoke(@params);
        }

        internal static void HookGetItemAtIndex()
        {
            if (!HookedList.Contains("GetItemAtIndex"))
            {
                HookedList.Add("GetItemAtIndex");
                new Hook(ReflectionHelper.GetMethodInfo(typeof(ArrayListGetNext), "GetItemAtIndex"), GetItemAtIndex);
            }
        }

        internal static event Delegates.GetItemAtIndex_BeforeArgs _beforeGetItemAtIndex;
        internal static event Delegates.GetItemAtIndex_NormalArgs _afterGetItemAtIndex;

        private static void GetItemAtIndex(Action<ArrayListGetNext> orig, ArrayListGetNext self)
        {
            Delegates.Params_GetItemAtIndex @params = new()
            {
                self = self
            };
            _beforeGetItemAtIndex?.Invoke(@params);
            self = @params.self;
            orig(self);
            if (_afterGetItemAtIndex != null) _afterGetItemAtIndex.Invoke(@params);
        }
    }

    /// <summary>
    ///     Contains necessary information to create Hooks. Does not contain any hooks
    /// </summary>
    public static class Delegates
    {
        public delegate void DoGetNextItem_BeforeArgs(Params_DoGetNextItem args);

        public delegate void DoGetNextItem_NormalArgs(Params_DoGetNextItem args);

        public delegate void GetItemAtIndex_BeforeArgs(Params_GetItemAtIndex args);

        public delegate void GetItemAtIndex_NormalArgs(Params_GetItemAtIndex args);

        public delegate void OnEnter_BeforeArgs(Params_OnEnter args);

        public delegate void OnEnter_NormalArgs(Params_OnEnter args);

        public delegate void Reset_BeforeArgs(Params_Reset args);

        public delegate void Reset_NormalArgs(Params_Reset args);

        public sealed class Params_Reset
        {
            public ArrayListGetNext self;
        }

        public sealed class Params_OnEnter
        {
            public ArrayListGetNext self;
        }

        public sealed class Params_DoGetNextItem
        {
            public ArrayListGetNext self;
        }

        public sealed class Params_GetItemAtIndex
        {
            public ArrayListGetNext self;
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

        public static event Delegates.DoGetNextItem_BeforeArgs DoGetNextItem
        {
            add
            {
                HookHandler._beforeDoGetNextItem += value;
                HookHandler.HookDoGetNextItem();
            }
            remove => HookHandler._beforeDoGetNextItem -= value;
        }

        public static event Delegates.GetItemAtIndex_BeforeArgs GetItemAtIndex
        {
            add
            {
                HookHandler._beforeGetItemAtIndex += value;
                HookHandler.HookGetItemAtIndex();
            }
            remove => HookHandler._beforeGetItemAtIndex -= value;
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

        public static event Delegates.DoGetNextItem_NormalArgs DoGetNextItem
        {
            add
            {
                HookHandler._afterDoGetNextItem += value;
                HookHandler.HookDoGetNextItem();
            }
            remove => HookHandler._afterDoGetNextItem -= value;
        }

        public static event Delegates.GetItemAtIndex_NormalArgs GetItemAtIndex
        {
            add
            {
                HookHandler._afterGetItemAtIndex += value;
                HookHandler.HookGetItemAtIndex();
            }
            remove => HookHandler._afterGetItemAtIndex -= value;
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
                ReflectionHelper.GetMethodInfo(typeof(ArrayListGetNext), "Reset"), value);
            remove => HookEndpointManager.Remove<Delegates.Reset_NormalArgs>(
                ReflectionHelper.GetMethodInfo(typeof(ArrayListGetNext), "Reset"), value);
        }

        public static event Delegates.OnEnter_NormalArgs OnEnter
        {
            add => HookEndpointManager.Add<Delegates.OnEnter_NormalArgs>(
                ReflectionHelper.GetMethodInfo(typeof(ArrayListGetNext), "OnEnter"), value);
            remove => HookEndpointManager.Remove<Delegates.OnEnter_NormalArgs>(
                ReflectionHelper.GetMethodInfo(typeof(ArrayListGetNext), "OnEnter"), value);
        }

        public static event Delegates.DoGetNextItem_NormalArgs DoGetNextItem
        {
            add => HookEndpointManager.Add<Delegates.DoGetNextItem_NormalArgs>(
                ReflectionHelper.GetMethodInfo(typeof(ArrayListGetNext), "DoGetNextItem"), value);
            remove => HookEndpointManager.Remove<Delegates.DoGetNextItem_NormalArgs>(
                ReflectionHelper.GetMethodInfo(typeof(ArrayListGetNext), "DoGetNextItem"), value);
        }

        public static event Delegates.GetItemAtIndex_NormalArgs GetItemAtIndex
        {
            add => HookEndpointManager.Add<Delegates.GetItemAtIndex_NormalArgs>(
                ReflectionHelper.GetMethodInfo(typeof(ArrayListGetNext), "GetItemAtIndex"), value);
            remove => HookEndpointManager.Remove<Delegates.GetItemAtIndex_NormalArgs>(
                ReflectionHelper.GetMethodInfo(typeof(ArrayListGetNext), "GetItemAtIndex"), value);
        }
    }
}