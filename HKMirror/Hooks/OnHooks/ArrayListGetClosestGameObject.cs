using MonoMod.RuntimeDetour;
using MonoMod.RuntimeDetour.HookGen;

namespace HKMirror.Hooks.OnHooks;

/// <summary>
///     Contains different types of On Hooks for ArrayListGetClosestGameObject class.<br />
///     Contains hooks that aren't generated by monomod, and before and after orig hooks for easier hooking.
/// </summary>
public static class OnArrayListGetClosestGameObject
{
    internal static class HookHandler
    {
        private static readonly List<string> HookedList = new();

        internal static void HookReset()
        {
            if (!HookedList.Contains("Reset"))
            {
                HookedList.Add("Reset");
                new Hook(ReflectionHelper.GetMethodInfo(typeof(ArrayListGetClosestGameObject), "Reset"), Reset);
            }
        }

        internal static event Delegates.Reset_BeforeArgs _beforeReset;
        internal static event Delegates.Reset_AfterArgs _afterReset;

        private static void Reset(Action<ArrayListGetClosestGameObject> orig, ArrayListGetClosestGameObject self)
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
                new Hook(ReflectionHelper.GetMethodInfo(typeof(ArrayListGetClosestGameObject), "OnEnter"), OnEnter);
            }
        }

        internal static event Delegates.OnEnter_BeforeArgs _beforeOnEnter;
        internal static event Delegates.OnEnter_AfterArgs _afterOnEnter;

        private static void OnEnter(Action<ArrayListGetClosestGameObject> orig, ArrayListGetClosestGameObject self)
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

        internal static void HookOnUpdate()
        {
            if (!HookedList.Contains("OnUpdate"))
            {
                HookedList.Add("OnUpdate");
                new Hook(ReflectionHelper.GetMethodInfo(typeof(ArrayListGetClosestGameObject), "OnUpdate"), OnUpdate);
            }
        }

        internal static event Delegates.OnUpdate_BeforeArgs _beforeOnUpdate;
        internal static event Delegates.OnUpdate_AfterArgs _afterOnUpdate;

        private static void OnUpdate(Action<ArrayListGetClosestGameObject> orig, ArrayListGetClosestGameObject self)
        {
            Delegates.Params_OnUpdate @params = new()
            {
                self = self
            };
            if (_beforeOnUpdate != null)
                foreach (Delegates.OnUpdate_BeforeArgs toInvoke in _beforeOnUpdate.GetInvocationList())
                    try
                    {
                        _beforeOnUpdate?.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }

            self = @params.self;
            orig(self);
            if (_afterOnUpdate != null)
                foreach (Delegates.OnUpdate_AfterArgs toInvoke in _afterOnUpdate.GetInvocationList())
                    try
                    {
                        _afterOnUpdate.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }
        }

        internal static void HookDoFindClosestGo()
        {
            if (!HookedList.Contains("DoFindClosestGo"))
            {
                HookedList.Add("DoFindClosestGo");
                new Hook(ReflectionHelper.GetMethodInfo(typeof(ArrayListGetClosestGameObject), "DoFindClosestGo"),
                    DoFindClosestGo);
            }
        }

        internal static event Delegates.DoFindClosestGo_BeforeArgs _beforeDoFindClosestGo;
        internal static event Delegates.DoFindClosestGo_AfterArgs _afterDoFindClosestGo;

        private static void DoFindClosestGo(Action<ArrayListGetClosestGameObject> orig,
            ArrayListGetClosestGameObject self)
        {
            Delegates.Params_DoFindClosestGo @params = new()
            {
                self = self
            };
            if (_beforeDoFindClosestGo != null)
                foreach (Delegates.DoFindClosestGo_BeforeArgs toInvoke in _beforeDoFindClosestGo.GetInvocationList())
                    try
                    {
                        _beforeDoFindClosestGo?.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }

            self = @params.self;
            orig(self);
            if (_afterDoFindClosestGo != null)
                foreach (Delegates.DoFindClosestGo_AfterArgs toInvoke in _afterDoFindClosestGo.GetInvocationList())
                    try
                    {
                        _afterDoFindClosestGo.Invoke(@params);
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
        public delegate void DoFindClosestGo_AfterArgs(Params_DoFindClosestGo args);

        public delegate void DoFindClosestGo_BeforeArgs(Params_DoFindClosestGo args);

        public delegate void DoFindClosestGo_WithArgs(Action<ArrayListGetClosestGameObject> orig,
            ArrayListGetClosestGameObject self);

        public delegate void OnEnter_AfterArgs(Params_OnEnter args);

        public delegate void OnEnter_BeforeArgs(Params_OnEnter args);

        public delegate void OnEnter_WithArgs(Action<ArrayListGetClosestGameObject> orig,
            ArrayListGetClosestGameObject self);

        public delegate void OnUpdate_AfterArgs(Params_OnUpdate args);

        public delegate void OnUpdate_BeforeArgs(Params_OnUpdate args);

        public delegate void OnUpdate_WithArgs(Action<ArrayListGetClosestGameObject> orig,
            ArrayListGetClosestGameObject self);

        public delegate void Reset_AfterArgs(Params_Reset args);

        public delegate void Reset_BeforeArgs(Params_Reset args);

        public delegate void Reset_WithArgs(Action<ArrayListGetClosestGameObject> orig,
            ArrayListGetClosestGameObject self);

        public sealed class Params_Reset
        {
            public ArrayListGetClosestGameObject self;
        }

        public sealed class Params_OnEnter
        {
            public ArrayListGetClosestGameObject self;
        }

        public sealed class Params_OnUpdate
        {
            public ArrayListGetClosestGameObject self;
        }

        public sealed class Params_DoFindClosestGo
        {
            public ArrayListGetClosestGameObject self;
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

        public static event Delegates.OnUpdate_BeforeArgs OnUpdate
        {
            add
            {
                HookHandler._beforeOnUpdate += value;
                HookHandler.HookOnUpdate();
            }
            remove => HookHandler._beforeOnUpdate -= value;
        }

        public static event Delegates.DoFindClosestGo_BeforeArgs DoFindClosestGo
        {
            add
            {
                HookHandler._beforeDoFindClosestGo += value;
                HookHandler.HookDoFindClosestGo();
            }
            remove => HookHandler._beforeDoFindClosestGo -= value;
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

        public static event Delegates.OnUpdate_AfterArgs OnUpdate
        {
            add
            {
                HookHandler._afterOnUpdate += value;
                HookHandler.HookOnUpdate();
            }
            remove => HookHandler._afterOnUpdate -= value;
        }

        public static event Delegates.DoFindClosestGo_AfterArgs DoFindClosestGo
        {
            add
            {
                HookHandler._afterDoFindClosestGo += value;
                HookHandler.HookDoFindClosestGo();
            }
            remove => HookHandler._afterDoFindClosestGo -= value;
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
                ReflectionHelper.GetMethodInfo(typeof(ArrayListGetClosestGameObject), "Reset"), value);
            remove => HookEndpointManager.Remove<Delegates.Reset_WithArgs>(
                ReflectionHelper.GetMethodInfo(typeof(ArrayListGetClosestGameObject), "Reset"), value);
        }

        public static event Delegates.OnEnter_WithArgs OnEnter
        {
            add => HookEndpointManager.Add<Delegates.OnEnter_WithArgs>(
                ReflectionHelper.GetMethodInfo(typeof(ArrayListGetClosestGameObject), "OnEnter"), value);
            remove => HookEndpointManager.Remove<Delegates.OnEnter_WithArgs>(
                ReflectionHelper.GetMethodInfo(typeof(ArrayListGetClosestGameObject), "OnEnter"), value);
        }

        public static event Delegates.OnUpdate_WithArgs OnUpdate
        {
            add => HookEndpointManager.Add<Delegates.OnUpdate_WithArgs>(
                ReflectionHelper.GetMethodInfo(typeof(ArrayListGetClosestGameObject), "OnUpdate"), value);
            remove => HookEndpointManager.Remove<Delegates.OnUpdate_WithArgs>(
                ReflectionHelper.GetMethodInfo(typeof(ArrayListGetClosestGameObject), "OnUpdate"), value);
        }

        public static event Delegates.DoFindClosestGo_WithArgs DoFindClosestGo
        {
            add => HookEndpointManager.Add<Delegates.DoFindClosestGo_WithArgs>(
                ReflectionHelper.GetMethodInfo(typeof(ArrayListGetClosestGameObject), "DoFindClosestGo"), value);
            remove => HookEndpointManager.Remove<Delegates.DoFindClosestGo_WithArgs>(
                ReflectionHelper.GetMethodInfo(typeof(ArrayListGetClosestGameObject), "DoFindClosestGo"), value);
        }
    }
}