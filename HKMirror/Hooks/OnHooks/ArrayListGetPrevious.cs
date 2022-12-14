using MonoMod.RuntimeDetour;
using MonoMod.RuntimeDetour.HookGen;

namespace HKMirror.Hooks.OnHooks;

/// <summary>
///     Contains different types of On Hooks for ArrayListGetPrevious class.<br />
///     Contains hooks that aren't generated by monomod, and before and after orig hooks for easier hooking.
/// </summary>
public static class OnArrayListGetPrevious
{
    internal static class HookHandler
    {
        private static readonly List<string> HookedList = new();

        internal static void HookReset()
        {
            if (!HookedList.Contains("Reset"))
            {
                HookedList.Add("Reset");
                new Hook(ReflectionHelper.GetMethodInfo(typeof(ArrayListGetPrevious), "Reset"), Reset);
            }
        }

        internal static event Delegates.Reset_BeforeArgs _beforeReset;
        internal static event Delegates.Reset_AfterArgs _afterReset;

        private static void Reset(Action<ArrayListGetPrevious> orig, ArrayListGetPrevious self)
        {
            Delegates.Params_Reset @params = new()
            {
                self = self
            };
            if (_beforeReset != null)
                foreach (Delegates.Reset_BeforeArgs toInvoke in _beforeReset.GetInvocationList())
                    try
                    {
                        _beforeReset?.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }

            self = @params.self;
            orig(self);
            if (_afterReset != null)
                foreach (Delegates.Reset_AfterArgs toInvoke in _afterReset.GetInvocationList())
                    try
                    {
                        _afterReset.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }
        }

        internal static void HookOnEnter()
        {
            if (!HookedList.Contains("OnEnter"))
            {
                HookedList.Add("OnEnter");
                new Hook(ReflectionHelper.GetMethodInfo(typeof(ArrayListGetPrevious), "OnEnter"), OnEnter);
            }
        }

        internal static event Delegates.OnEnter_BeforeArgs _beforeOnEnter;
        internal static event Delegates.OnEnter_AfterArgs _afterOnEnter;

        private static void OnEnter(Action<ArrayListGetPrevious> orig, ArrayListGetPrevious self)
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

        internal static void HookDoGetPreviousItem()
        {
            if (!HookedList.Contains("DoGetPreviousItem"))
            {
                HookedList.Add("DoGetPreviousItem");
                new Hook(ReflectionHelper.GetMethodInfo(typeof(ArrayListGetPrevious), "DoGetPreviousItem"),
                    DoGetPreviousItem);
            }
        }

        internal static event Delegates.DoGetPreviousItem_BeforeArgs _beforeDoGetPreviousItem;
        internal static event Delegates.DoGetPreviousItem_AfterArgs _afterDoGetPreviousItem;

        private static void DoGetPreviousItem(Action<ArrayListGetPrevious> orig, ArrayListGetPrevious self)
        {
            Delegates.Params_DoGetPreviousItem @params = new()
            {
                self = self
            };
            if (_beforeDoGetPreviousItem != null)
                foreach (Delegates.DoGetPreviousItem_BeforeArgs toInvoke in
                         _beforeDoGetPreviousItem.GetInvocationList())
                    try
                    {
                        _beforeDoGetPreviousItem?.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }

            self = @params.self;
            orig(self);
            if (_afterDoGetPreviousItem != null)
                foreach (Delegates.DoGetPreviousItem_AfterArgs toInvoke in _afterDoGetPreviousItem.GetInvocationList())
                    try
                    {
                        _afterDoGetPreviousItem.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }
        }

        internal static void HookGetItemAtIndex()
        {
            if (!HookedList.Contains("GetItemAtIndex"))
            {
                HookedList.Add("GetItemAtIndex");
                new Hook(ReflectionHelper.GetMethodInfo(typeof(ArrayListGetPrevious), "GetItemAtIndex"),
                    GetItemAtIndex);
            }
        }

        internal static event Delegates.GetItemAtIndex_BeforeArgs _beforeGetItemAtIndex;
        internal static event Delegates.GetItemAtIndex_AfterArgs _afterGetItemAtIndex;

        private static void GetItemAtIndex(Action<ArrayListGetPrevious> orig, ArrayListGetPrevious self)
        {
            Delegates.Params_GetItemAtIndex @params = new()
            {
                self = self
            };
            if (_beforeGetItemAtIndex != null)
                foreach (Delegates.GetItemAtIndex_BeforeArgs toInvoke in _beforeGetItemAtIndex.GetInvocationList())
                    try
                    {
                        _beforeGetItemAtIndex?.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }

            self = @params.self;
            orig(self);
            if (_afterGetItemAtIndex != null)
                foreach (Delegates.GetItemAtIndex_AfterArgs toInvoke in _afterGetItemAtIndex.GetInvocationList())
                    try
                    {
                        _afterGetItemAtIndex.Invoke(@params);
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
        public delegate void DoGetPreviousItem_AfterArgs(Params_DoGetPreviousItem args);

        public delegate void DoGetPreviousItem_BeforeArgs(Params_DoGetPreviousItem args);

        public delegate void DoGetPreviousItem_WithArgs(Action<ArrayListGetPrevious> orig, ArrayListGetPrevious self);

        public delegate void GetItemAtIndex_AfterArgs(Params_GetItemAtIndex args);

        public delegate void GetItemAtIndex_BeforeArgs(Params_GetItemAtIndex args);

        public delegate void GetItemAtIndex_WithArgs(Action<ArrayListGetPrevious> orig, ArrayListGetPrevious self);

        public delegate void OnEnter_AfterArgs(Params_OnEnter args);

        public delegate void OnEnter_BeforeArgs(Params_OnEnter args);

        public delegate void OnEnter_WithArgs(Action<ArrayListGetPrevious> orig, ArrayListGetPrevious self);

        public delegate void Reset_AfterArgs(Params_Reset args);

        public delegate void Reset_BeforeArgs(Params_Reset args);

        public delegate void Reset_WithArgs(Action<ArrayListGetPrevious> orig, ArrayListGetPrevious self);

        public sealed class Params_Reset
        {
            public ArrayListGetPrevious self;
        }

        public sealed class Params_OnEnter
        {
            public ArrayListGetPrevious self;
        }

        public sealed class Params_DoGetPreviousItem
        {
            public ArrayListGetPrevious self;
        }

        public sealed class Params_GetItemAtIndex
        {
            public ArrayListGetPrevious self;
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

        public static event Delegates.DoGetPreviousItem_BeforeArgs DoGetPreviousItem
        {
            add
            {
                HookHandler._beforeDoGetPreviousItem += value;
                HookHandler.HookDoGetPreviousItem();
            }
            remove => HookHandler._beforeDoGetPreviousItem -= value;
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
        public static event Delegates.Reset_AfterArgs Reset
        {
            add
            {
                HookHandler._afterReset += value;
                HookHandler.HookReset();
            }
            remove => HookHandler._afterReset -= value;
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

        public static event Delegates.DoGetPreviousItem_AfterArgs DoGetPreviousItem
        {
            add
            {
                HookHandler._afterDoGetPreviousItem += value;
                HookHandler.HookDoGetPreviousItem();
            }
            remove => HookHandler._afterDoGetPreviousItem -= value;
        }

        public static event Delegates.GetItemAtIndex_AfterArgs GetItemAtIndex
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
        public static event Delegates.Reset_WithArgs Reset
        {
            add => HookEndpointManager.Add<Delegates.Reset_WithArgs>(
                ReflectionHelper.GetMethodInfo(typeof(ArrayListGetPrevious), "Reset"), value);
            remove => HookEndpointManager.Remove<Delegates.Reset_WithArgs>(
                ReflectionHelper.GetMethodInfo(typeof(ArrayListGetPrevious), "Reset"), value);
        }

        public static event Delegates.OnEnter_WithArgs OnEnter
        {
            add => HookEndpointManager.Add<Delegates.OnEnter_WithArgs>(
                ReflectionHelper.GetMethodInfo(typeof(ArrayListGetPrevious), "OnEnter"), value);
            remove => HookEndpointManager.Remove<Delegates.OnEnter_WithArgs>(
                ReflectionHelper.GetMethodInfo(typeof(ArrayListGetPrevious), "OnEnter"), value);
        }

        public static event Delegates.DoGetPreviousItem_WithArgs DoGetPreviousItem
        {
            add => HookEndpointManager.Add<Delegates.DoGetPreviousItem_WithArgs>(
                ReflectionHelper.GetMethodInfo(typeof(ArrayListGetPrevious), "DoGetPreviousItem"), value);
            remove => HookEndpointManager.Remove<Delegates.DoGetPreviousItem_WithArgs>(
                ReflectionHelper.GetMethodInfo(typeof(ArrayListGetPrevious), "DoGetPreviousItem"), value);
        }

        public static event Delegates.GetItemAtIndex_WithArgs GetItemAtIndex
        {
            add => HookEndpointManager.Add<Delegates.GetItemAtIndex_WithArgs>(
                ReflectionHelper.GetMethodInfo(typeof(ArrayListGetPrevious), "GetItemAtIndex"), value);
            remove => HookEndpointManager.Remove<Delegates.GetItemAtIndex_WithArgs>(
                ReflectionHelper.GetMethodInfo(typeof(ArrayListGetPrevious), "GetItemAtIndex"), value);
        }
    }
}