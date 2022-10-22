using MonoMod.RuntimeDetour;
using MonoMod.RuntimeDetour.HookGen;

namespace HKMirror.Hooks.OnHooks;

/// <summary>
///     Contains different types of On Hooks for SetTagsOnChildren class.<br />
///     Contains hooks that aren't generated by monomod, and before and after orig hooks for easier hooking.
/// </summary>
public static class OnSetTagsOnChildren
{
    internal static class HookHandler
    {
        private static readonly List<string> HookedList = new();

        internal static void HookReset()
        {
            if (!HookedList.Contains("Reset"))
            {
                HookedList.Add("Reset");
                new Hook(ReflectionHelper.GetMethodInfo(typeof(SetTagsOnChildren), "Reset"), Reset);
            }
        }

        internal static event Delegates.Reset_BeforeArgs _beforeReset;
        internal static event Delegates.Reset_AfterArgs _afterReset;

        private static void Reset(Action<SetTagsOnChildren> orig, SetTagsOnChildren self)
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
                new Hook(ReflectionHelper.GetMethodInfo(typeof(SetTagsOnChildren), "OnEnter"), OnEnter);
            }
        }

        internal static event Delegates.OnEnter_BeforeArgs _beforeOnEnter;
        internal static event Delegates.OnEnter_AfterArgs _afterOnEnter;

        private static void OnEnter(Action<SetTagsOnChildren> orig, SetTagsOnChildren self)
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

        internal static void HookSetTag()
        {
            if (!HookedList.Contains("SetTag"))
            {
                HookedList.Add("SetTag");
                new Hook(ReflectionHelper.GetMethodInfo(typeof(SetTagsOnChildren), "SetTag"), SetTag);
            }
        }

        internal static event Delegates.SetTag_BeforeArgs _beforeSetTag;
        internal static event Delegates.SetTag_AfterArgs _afterSetTag;

        private static void SetTag(Action<SetTagsOnChildren, GameObject> orig, SetTagsOnChildren self,
            GameObject parent)
        {
            Delegates.Params_SetTag @params = new()
            {
                self = self, parent = parent
            };
            if (_beforeSetTag != null)
                foreach (Delegates.SetTag_BeforeArgs toInvoke in _beforeSetTag.GetInvocationList())
                    try
                    {
                        _beforeSetTag?.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }

            self = @params.self;
            parent = @params.parent;
            orig(self, parent);
            if (_afterSetTag != null)
                foreach (Delegates.SetTag_AfterArgs toInvoke in _afterSetTag.GetInvocationList())
                    try
                    {
                        _afterSetTag.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }
        }

        internal static void HookUpdateComponentFilter()
        {
            if (!HookedList.Contains("UpdateComponentFilter"))
            {
                HookedList.Add("UpdateComponentFilter");
                new Hook(ReflectionHelper.GetMethodInfo(typeof(SetTagsOnChildren), "UpdateComponentFilter"),
                    UpdateComponentFilter);
            }
        }

        internal static event Delegates.UpdateComponentFilter_BeforeArgs _beforeUpdateComponentFilter;
        internal static event Delegates.UpdateComponentFilter_AfterArgs _afterUpdateComponentFilter;

        private static void UpdateComponentFilter(Action<SetTagsOnChildren> orig, SetTagsOnChildren self)
        {
            Delegates.Params_UpdateComponentFilter @params = new()
            {
                self = self
            };
            if (_beforeUpdateComponentFilter != null)
                foreach (Delegates.UpdateComponentFilter_BeforeArgs toInvoke in _beforeUpdateComponentFilter
                             .GetInvocationList())
                    try
                    {
                        _beforeUpdateComponentFilter?.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }

            self = @params.self;
            orig(self);
            if (_afterUpdateComponentFilter != null)
                foreach (Delegates.UpdateComponentFilter_AfterArgs toInvoke in _afterUpdateComponentFilter
                             .GetInvocationList())
                    try
                    {
                        _afterUpdateComponentFilter.Invoke(@params);
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
        public delegate void OnEnter_AfterArgs(Params_OnEnter args);

        public delegate void OnEnter_BeforeArgs(Params_OnEnter args);

        public delegate void OnEnter_WithArgs(Action<SetTagsOnChildren> orig, SetTagsOnChildren self);

        public delegate void Reset_AfterArgs(Params_Reset args);

        public delegate void Reset_BeforeArgs(Params_Reset args);

        public delegate void Reset_WithArgs(Action<SetTagsOnChildren> orig, SetTagsOnChildren self);

        public delegate void SetTag_AfterArgs(Params_SetTag args);

        public delegate void SetTag_BeforeArgs(Params_SetTag args);

        public delegate void SetTag_WithArgs(Action<SetTagsOnChildren, GameObject> orig, SetTagsOnChildren self,
            GameObject parent);

        public delegate void UpdateComponentFilter_AfterArgs(Params_UpdateComponentFilter args);

        public delegate void UpdateComponentFilter_BeforeArgs(Params_UpdateComponentFilter args);

        public delegate void UpdateComponentFilter_WithArgs(Action<SetTagsOnChildren> orig, SetTagsOnChildren self);

        public sealed class Params_Reset
        {
            public SetTagsOnChildren self;
        }

        public sealed class Params_OnEnter
        {
            public SetTagsOnChildren self;
        }

        public sealed class Params_SetTag
        {
            public GameObject parent;
            public SetTagsOnChildren self;
        }

        public sealed class Params_UpdateComponentFilter
        {
            public SetTagsOnChildren self;
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

        public static event Delegates.SetTag_BeforeArgs SetTag
        {
            add
            {
                HookHandler._beforeSetTag += value;
                HookHandler.HookSetTag();
            }
            remove => HookHandler._beforeSetTag -= value;
        }

        public static event Delegates.UpdateComponentFilter_BeforeArgs UpdateComponentFilter
        {
            add
            {
                HookHandler._beforeUpdateComponentFilter += value;
                HookHandler.HookUpdateComponentFilter();
            }
            remove => HookHandler._beforeUpdateComponentFilter -= value;
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

        public static event Delegates.SetTag_AfterArgs SetTag
        {
            add
            {
                HookHandler._afterSetTag += value;
                HookHandler.HookSetTag();
            }
            remove => HookHandler._afterSetTag -= value;
        }

        public static event Delegates.UpdateComponentFilter_AfterArgs UpdateComponentFilter
        {
            add
            {
                HookHandler._afterUpdateComponentFilter += value;
                HookHandler.HookUpdateComponentFilter();
            }
            remove => HookHandler._afterUpdateComponentFilter -= value;
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
                ReflectionHelper.GetMethodInfo(typeof(SetTagsOnChildren), "Reset"), value);
            remove => HookEndpointManager.Remove<Delegates.Reset_WithArgs>(
                ReflectionHelper.GetMethodInfo(typeof(SetTagsOnChildren), "Reset"), value);
        }

        public static event Delegates.OnEnter_WithArgs OnEnter
        {
            add => HookEndpointManager.Add<Delegates.OnEnter_WithArgs>(
                ReflectionHelper.GetMethodInfo(typeof(SetTagsOnChildren), "OnEnter"), value);
            remove => HookEndpointManager.Remove<Delegates.OnEnter_WithArgs>(
                ReflectionHelper.GetMethodInfo(typeof(SetTagsOnChildren), "OnEnter"), value);
        }

        public static event Delegates.SetTag_WithArgs SetTag
        {
            add => HookEndpointManager.Add<Delegates.SetTag_WithArgs>(
                ReflectionHelper.GetMethodInfo(typeof(SetTagsOnChildren), "SetTag"), value);
            remove => HookEndpointManager.Remove<Delegates.SetTag_WithArgs>(
                ReflectionHelper.GetMethodInfo(typeof(SetTagsOnChildren), "SetTag"), value);
        }

        public static event Delegates.UpdateComponentFilter_WithArgs UpdateComponentFilter
        {
            add => HookEndpointManager.Add<Delegates.UpdateComponentFilter_WithArgs>(
                ReflectionHelper.GetMethodInfo(typeof(SetTagsOnChildren), "UpdateComponentFilter"), value);
            remove => HookEndpointManager.Remove<Delegates.UpdateComponentFilter_WithArgs>(
                ReflectionHelper.GetMethodInfo(typeof(SetTagsOnChildren), "UpdateComponentFilter"), value);
        }
    }
}