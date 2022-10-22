using MonoMod.RuntimeDetour;
using MonoMod.RuntimeDetour.HookGen;

namespace HKMirror.Hooks.OnHooks;

/// <summary>
///     Contains different types of On Hooks for uGuiSetButtonNormalColor class.<br />
///     Contains hooks that aren't generated by monomod, and before and after orig hooks for easier hooking.
/// </summary>
public static class OnuGuiSetButtonNormalColor
{
    internal static class HookHandler
    {
        private static readonly List<string> HookedList = new();

        internal static void HookReset()
        {
            if (!HookedList.Contains("Reset"))
            {
                HookedList.Add("Reset");
                new Hook(ReflectionHelper.GetMethodInfo(typeof(uGuiSetButtonNormalColor), "Reset"), Reset);
            }
        }

        internal static event Delegates.Reset_BeforeArgs _beforeReset;
        internal static event Delegates.Reset_AfterArgs _afterReset;

        private static void Reset(Action<uGuiSetButtonNormalColor> orig, uGuiSetButtonNormalColor self)
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
                new Hook(ReflectionHelper.GetMethodInfo(typeof(uGuiSetButtonNormalColor), "OnEnter"), OnEnter);
            }
        }

        internal static event Delegates.OnEnter_BeforeArgs _beforeOnEnter;
        internal static event Delegates.OnEnter_AfterArgs _afterOnEnter;

        private static void OnEnter(Action<uGuiSetButtonNormalColor> orig, uGuiSetButtonNormalColor self)
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
                new Hook(ReflectionHelper.GetMethodInfo(typeof(uGuiSetButtonNormalColor), "OnUpdate"), OnUpdate);
            }
        }

        internal static event Delegates.OnUpdate_BeforeArgs _beforeOnUpdate;
        internal static event Delegates.OnUpdate_AfterArgs _afterOnUpdate;

        private static void OnUpdate(Action<uGuiSetButtonNormalColor> orig, uGuiSetButtonNormalColor self)
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

        internal static void HookOnExit()
        {
            if (!HookedList.Contains("OnExit"))
            {
                HookedList.Add("OnExit");
                new Hook(ReflectionHelper.GetMethodInfo(typeof(uGuiSetButtonNormalColor), "OnExit"), OnExit);
            }
        }

        internal static event Delegates.OnExit_BeforeArgs _beforeOnExit;
        internal static event Delegates.OnExit_AfterArgs _afterOnExit;

        private static void OnExit(Action<uGuiSetButtonNormalColor> orig, uGuiSetButtonNormalColor self)
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

        internal static void HookInitialize()
        {
            if (!HookedList.Contains("Initialize"))
            {
                HookedList.Add("Initialize");
                new Hook(ReflectionHelper.GetMethodInfo(typeof(uGuiSetButtonNormalColor), "Initialize"), Initialize);
            }
        }

        internal static event Delegates.Initialize_BeforeArgs _beforeInitialize;
        internal static event Delegates.Initialize_AfterArgs _afterInitialize;

        private static void Initialize(Action<uGuiSetButtonNormalColor, GameObject> orig, uGuiSetButtonNormalColor self,
            GameObject go)
        {
            Delegates.Params_Initialize @params = new()
            {
                self = self, go = go
            };
            if (_beforeInitialize != null)
                foreach (Delegates.Initialize_BeforeArgs toInvoke in _beforeInitialize.GetInvocationList())
                    try
                    {
                        _beforeInitialize?.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }

            self = @params.self;
            go = @params.go;
            orig(self, go);
            if (_afterInitialize != null)
                foreach (Delegates.Initialize_AfterArgs toInvoke in _afterInitialize.GetInvocationList())
                    try
                    {
                        _afterInitialize.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }
        }

        internal static void HookDoSetButtonColor()
        {
            if (!HookedList.Contains("DoSetButtonColor"))
            {
                HookedList.Add("DoSetButtonColor");
                new Hook(ReflectionHelper.GetMethodInfo(typeof(uGuiSetButtonNormalColor), "DoSetButtonColor"),
                    DoSetButtonColor);
            }
        }

        internal static event Delegates.DoSetButtonColor_BeforeArgs _beforeDoSetButtonColor;
        internal static event Delegates.DoSetButtonColor_AfterArgs _afterDoSetButtonColor;

        private static void DoSetButtonColor(Action<uGuiSetButtonNormalColor> orig, uGuiSetButtonNormalColor self)
        {
            Delegates.Params_DoSetButtonColor @params = new()
            {
                self = self
            };
            if (_beforeDoSetButtonColor != null)
                foreach (Delegates.DoSetButtonColor_BeforeArgs toInvoke in _beforeDoSetButtonColor.GetInvocationList())
                    try
                    {
                        _beforeDoSetButtonColor?.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }

            self = @params.self;
            orig(self);
            if (_afterDoSetButtonColor != null)
                foreach (Delegates.DoSetButtonColor_AfterArgs toInvoke in _afterDoSetButtonColor.GetInvocationList())
                    try
                    {
                        _afterDoSetButtonColor.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }
        }

        internal static void HookDoSetOldColorValue()
        {
            if (!HookedList.Contains("DoSetOldColorValue"))
            {
                HookedList.Add("DoSetOldColorValue");
                new Hook(ReflectionHelper.GetMethodInfo(typeof(uGuiSetButtonNormalColor), "DoSetOldColorValue"),
                    DoSetOldColorValue);
            }
        }

        internal static event Delegates.DoSetOldColorValue_BeforeArgs _beforeDoSetOldColorValue;
        internal static event Delegates.DoSetOldColorValue_AfterArgs _afterDoSetOldColorValue;

        private static void DoSetOldColorValue(Action<uGuiSetButtonNormalColor> orig, uGuiSetButtonNormalColor self)
        {
            Delegates.Params_DoSetOldColorValue @params = new()
            {
                self = self
            };
            if (_beforeDoSetOldColorValue != null)
                foreach (Delegates.DoSetOldColorValue_BeforeArgs toInvoke in
                         _beforeDoSetOldColorValue.GetInvocationList())
                    try
                    {
                        _beforeDoSetOldColorValue?.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }

            self = @params.self;
            orig(self);
            if (_afterDoSetOldColorValue != null)
                foreach (Delegates.DoSetOldColorValue_AfterArgs toInvoke in
                         _afterDoSetOldColorValue.GetInvocationList())
                    try
                    {
                        _afterDoSetOldColorValue.Invoke(@params);
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
        public delegate void DoSetButtonColor_AfterArgs(Params_DoSetButtonColor args);

        public delegate void DoSetButtonColor_BeforeArgs(Params_DoSetButtonColor args);

        public delegate void DoSetButtonColor_WithArgs(Action<uGuiSetButtonNormalColor> orig,
            uGuiSetButtonNormalColor self);

        public delegate void DoSetOldColorValue_AfterArgs(Params_DoSetOldColorValue args);

        public delegate void DoSetOldColorValue_BeforeArgs(Params_DoSetOldColorValue args);

        public delegate void DoSetOldColorValue_WithArgs(Action<uGuiSetButtonNormalColor> orig,
            uGuiSetButtonNormalColor self);

        public delegate void Initialize_AfterArgs(Params_Initialize args);

        public delegate void Initialize_BeforeArgs(Params_Initialize args);

        public delegate void Initialize_WithArgs(Action<uGuiSetButtonNormalColor, GameObject> orig,
            uGuiSetButtonNormalColor self, GameObject go);

        public delegate void OnEnter_AfterArgs(Params_OnEnter args);

        public delegate void OnEnter_BeforeArgs(Params_OnEnter args);

        public delegate void OnEnter_WithArgs(Action<uGuiSetButtonNormalColor> orig, uGuiSetButtonNormalColor self);

        public delegate void OnExit_AfterArgs(Params_OnExit args);

        public delegate void OnExit_BeforeArgs(Params_OnExit args);

        public delegate void OnExit_WithArgs(Action<uGuiSetButtonNormalColor> orig, uGuiSetButtonNormalColor self);

        public delegate void OnUpdate_AfterArgs(Params_OnUpdate args);

        public delegate void OnUpdate_BeforeArgs(Params_OnUpdate args);

        public delegate void OnUpdate_WithArgs(Action<uGuiSetButtonNormalColor> orig, uGuiSetButtonNormalColor self);

        public delegate void Reset_AfterArgs(Params_Reset args);

        public delegate void Reset_BeforeArgs(Params_Reset args);

        public delegate void Reset_WithArgs(Action<uGuiSetButtonNormalColor> orig, uGuiSetButtonNormalColor self);

        public sealed class Params_Reset
        {
            public uGuiSetButtonNormalColor self;
        }

        public sealed class Params_OnEnter
        {
            public uGuiSetButtonNormalColor self;
        }

        public sealed class Params_OnUpdate
        {
            public uGuiSetButtonNormalColor self;
        }

        public sealed class Params_OnExit
        {
            public uGuiSetButtonNormalColor self;
        }

        public sealed class Params_Initialize
        {
            public GameObject go;
            public uGuiSetButtonNormalColor self;
        }

        public sealed class Params_DoSetButtonColor
        {
            public uGuiSetButtonNormalColor self;
        }

        public sealed class Params_DoSetOldColorValue
        {
            public uGuiSetButtonNormalColor self;
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

        public static event Delegates.OnExit_BeforeArgs OnExit
        {
            add
            {
                HookHandler._beforeOnExit += value;
                HookHandler.HookOnExit();
            }
            remove => HookHandler._beforeOnExit -= value;
        }

        public static event Delegates.Initialize_BeforeArgs Initialize
        {
            add
            {
                HookHandler._beforeInitialize += value;
                HookHandler.HookInitialize();
            }
            remove => HookHandler._beforeInitialize -= value;
        }

        public static event Delegates.DoSetButtonColor_BeforeArgs DoSetButtonColor
        {
            add
            {
                HookHandler._beforeDoSetButtonColor += value;
                HookHandler.HookDoSetButtonColor();
            }
            remove => HookHandler._beforeDoSetButtonColor -= value;
        }

        public static event Delegates.DoSetOldColorValue_BeforeArgs DoSetOldColorValue
        {
            add
            {
                HookHandler._beforeDoSetOldColorValue += value;
                HookHandler.HookDoSetOldColorValue();
            }
            remove => HookHandler._beforeDoSetOldColorValue -= value;
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

        public static event Delegates.OnExit_AfterArgs OnExit
        {
            add
            {
                HookHandler._afterOnExit += value;
                HookHandler.HookOnExit();
            }
            remove => HookHandler._afterOnExit -= value;
        }

        public static event Delegates.Initialize_AfterArgs Initialize
        {
            add
            {
                HookHandler._afterInitialize += value;
                HookHandler.HookInitialize();
            }
            remove => HookHandler._afterInitialize -= value;
        }

        public static event Delegates.DoSetButtonColor_AfterArgs DoSetButtonColor
        {
            add
            {
                HookHandler._afterDoSetButtonColor += value;
                HookHandler.HookDoSetButtonColor();
            }
            remove => HookHandler._afterDoSetButtonColor -= value;
        }

        public static event Delegates.DoSetOldColorValue_AfterArgs DoSetOldColorValue
        {
            add
            {
                HookHandler._afterDoSetOldColorValue += value;
                HookHandler.HookDoSetOldColorValue();
            }
            remove => HookHandler._afterDoSetOldColorValue -= value;
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
                ReflectionHelper.GetMethodInfo(typeof(uGuiSetButtonNormalColor), "Reset"), value);
            remove => HookEndpointManager.Remove<Delegates.Reset_WithArgs>(
                ReflectionHelper.GetMethodInfo(typeof(uGuiSetButtonNormalColor), "Reset"), value);
        }

        public static event Delegates.OnEnter_WithArgs OnEnter
        {
            add => HookEndpointManager.Add<Delegates.OnEnter_WithArgs>(
                ReflectionHelper.GetMethodInfo(typeof(uGuiSetButtonNormalColor), "OnEnter"), value);
            remove => HookEndpointManager.Remove<Delegates.OnEnter_WithArgs>(
                ReflectionHelper.GetMethodInfo(typeof(uGuiSetButtonNormalColor), "OnEnter"), value);
        }

        public static event Delegates.OnUpdate_WithArgs OnUpdate
        {
            add => HookEndpointManager.Add<Delegates.OnUpdate_WithArgs>(
                ReflectionHelper.GetMethodInfo(typeof(uGuiSetButtonNormalColor), "OnUpdate"), value);
            remove => HookEndpointManager.Remove<Delegates.OnUpdate_WithArgs>(
                ReflectionHelper.GetMethodInfo(typeof(uGuiSetButtonNormalColor), "OnUpdate"), value);
        }

        public static event Delegates.OnExit_WithArgs OnExit
        {
            add => HookEndpointManager.Add<Delegates.OnExit_WithArgs>(
                ReflectionHelper.GetMethodInfo(typeof(uGuiSetButtonNormalColor), "OnExit"), value);
            remove => HookEndpointManager.Remove<Delegates.OnExit_WithArgs>(
                ReflectionHelper.GetMethodInfo(typeof(uGuiSetButtonNormalColor), "OnExit"), value);
        }

        public static event Delegates.Initialize_WithArgs Initialize
        {
            add => HookEndpointManager.Add<Delegates.Initialize_WithArgs>(
                ReflectionHelper.GetMethodInfo(typeof(uGuiSetButtonNormalColor), "Initialize"), value);
            remove => HookEndpointManager.Remove<Delegates.Initialize_WithArgs>(
                ReflectionHelper.GetMethodInfo(typeof(uGuiSetButtonNormalColor), "Initialize"), value);
        }

        public static event Delegates.DoSetButtonColor_WithArgs DoSetButtonColor
        {
            add => HookEndpointManager.Add<Delegates.DoSetButtonColor_WithArgs>(
                ReflectionHelper.GetMethodInfo(typeof(uGuiSetButtonNormalColor), "DoSetButtonColor"), value);
            remove => HookEndpointManager.Remove<Delegates.DoSetButtonColor_WithArgs>(
                ReflectionHelper.GetMethodInfo(typeof(uGuiSetButtonNormalColor), "DoSetButtonColor"), value);
        }

        public static event Delegates.DoSetOldColorValue_WithArgs DoSetOldColorValue
        {
            add => HookEndpointManager.Add<Delegates.DoSetOldColorValue_WithArgs>(
                ReflectionHelper.GetMethodInfo(typeof(uGuiSetButtonNormalColor), "DoSetOldColorValue"), value);
            remove => HookEndpointManager.Remove<Delegates.DoSetOldColorValue_WithArgs>(
                ReflectionHelper.GetMethodInfo(typeof(uGuiSetButtonNormalColor), "DoSetOldColorValue"), value);
        }
    }
}