using MonoMod.RuntimeDetour;
using MonoMod.RuntimeDetour.HookGen;
using UnityEngine.UI.Extensions;

namespace HKMirror.Hooks.OnHooks;

/// <summary>
///     Contains different types of On Hooks for SoftMaskScript class.<br />
///     Contains hooks that aren't generated by monomod, and before and after orig hooks for easier hooking.
/// </summary>
public static class OnSoftMaskScript
{
    internal static class HookHandler
    {
        private static readonly List<string> HookedList = new();

        internal static void HookStart()
        {
            if (!HookedList.Contains("Start"))
            {
                HookedList.Add("Start");
                new Hook(ReflectionHelper.GetMethodInfo(typeof(SoftMaskScript), "Start"), Start);
            }
        }

        internal static event Delegates.Start_BeforeArgs _beforeStart;
        internal static event Delegates.Start_AfterArgs _afterStart;

        private static void Start(Action<SoftMaskScript> orig, SoftMaskScript self)
        {
            Delegates.Params_Start @params = new()
            {
                self = self
            };
            if (_beforeStart != null)
                foreach (Delegates.Start_BeforeArgs toInvoke in _beforeStart.GetInvocationList())
                    try
                    {
                        _beforeStart?.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }

            self = @params.self;
            orig(self);
            if (_afterStart != null)
                foreach (Delegates.Start_AfterArgs toInvoke in _afterStart.GetInvocationList())
                    try
                    {
                        _afterStart.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }
        }

        internal static void HookUpdate()
        {
            if (!HookedList.Contains("Update"))
            {
                HookedList.Add("Update");
                new Hook(ReflectionHelper.GetMethodInfo(typeof(SoftMaskScript), "Update"), Update);
            }
        }

        internal static event Delegates.Update_BeforeArgs _beforeUpdate;
        internal static event Delegates.Update_AfterArgs _afterUpdate;

        private static void Update(Action<SoftMaskScript> orig, SoftMaskScript self)
        {
            Delegates.Params_Update @params = new()
            {
                self = self
            };
            if (_beforeUpdate != null)
                foreach (Delegates.Update_BeforeArgs toInvoke in _beforeUpdate.GetInvocationList())
                    try
                    {
                        _beforeUpdate?.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }

            self = @params.self;
            orig(self);
            if (_afterUpdate != null)
                foreach (Delegates.Update_AfterArgs toInvoke in _afterUpdate.GetInvocationList())
                    try
                    {
                        _afterUpdate.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }
        }

        internal static void HookSetMask()
        {
            if (!HookedList.Contains("SetMask"))
            {
                HookedList.Add("SetMask");
                new Hook(ReflectionHelper.GetMethodInfo(typeof(SoftMaskScript), "SetMask"), SetMask);
            }
        }

        internal static event Delegates.SetMask_BeforeArgs _beforeSetMask;
        internal static event Delegates.SetMask_AfterArgs _afterSetMask;

        private static void SetMask(Action<SoftMaskScript> orig, SoftMaskScript self)
        {
            Delegates.Params_SetMask @params = new()
            {
                self = self
            };
            if (_beforeSetMask != null)
                foreach (Delegates.SetMask_BeforeArgs toInvoke in _beforeSetMask.GetInvocationList())
                    try
                    {
                        _beforeSetMask?.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }

            self = @params.self;
            orig(self);
            if (_afterSetMask != null)
                foreach (Delegates.SetMask_AfterArgs toInvoke in _afterSetMask.GetInvocationList())
                    try
                    {
                        _afterSetMask.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }
        }

        internal static void HookGetCanvasRect()
        {
            if (!HookedList.Contains("GetCanvasRect"))
            {
                HookedList.Add("GetCanvasRect");
                new Hook(ReflectionHelper.GetMethodInfo(typeof(SoftMaskScript), "GetCanvasRect"), GetCanvasRect);
            }
        }

        internal static event Delegates.GetCanvasRect_BeforeArgs _beforeGetCanvasRect;
        internal static event Delegates.GetCanvasRect_AfterArgs _afterGetCanvasRect;

        private static Rect GetCanvasRect(Func<SoftMaskScript, Rect> orig, SoftMaskScript self)
        {
            Delegates.Params_GetCanvasRect @params = new()
            {
                self = self
            };
            if (_beforeGetCanvasRect != null)
                foreach (Delegates.GetCanvasRect_BeforeArgs toInvoke in _beforeGetCanvasRect.GetInvocationList())
                    try
                    {
                        _beforeGetCanvasRect?.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }

            self = @params.self;
            var retVal = orig(self);
            if (_afterGetCanvasRect != null)
                foreach (Delegates.GetCanvasRect_AfterArgs toInvoke in _afterGetCanvasRect.GetInvocationList())
                    try
                    {
                        retVal = _afterGetCanvasRect.Invoke(@params, retVal);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }

            return retVal;
        }
    }

    /// <summary>
    ///     Contains necessary information to create Hooks. Does not contain any hooks
    /// </summary>
    public static class Delegates
    {
        public delegate Rect GetCanvasRect_AfterArgs(Params_GetCanvasRect args, Rect ret);

        public delegate void GetCanvasRect_BeforeArgs(Params_GetCanvasRect args);

        public delegate Rect GetCanvasRect_WithArgs(Func<SoftMaskScript, Rect> orig, SoftMaskScript self);

        public delegate void SetMask_AfterArgs(Params_SetMask args);

        public delegate void SetMask_BeforeArgs(Params_SetMask args);

        public delegate void SetMask_WithArgs(Action<SoftMaskScript> orig, SoftMaskScript self);

        public delegate void Start_AfterArgs(Params_Start args);

        public delegate void Start_BeforeArgs(Params_Start args);

        public delegate void Start_WithArgs(Action<SoftMaskScript> orig, SoftMaskScript self);

        public delegate void Update_AfterArgs(Params_Update args);

        public delegate void Update_BeforeArgs(Params_Update args);

        public delegate void Update_WithArgs(Action<SoftMaskScript> orig, SoftMaskScript self);

        public sealed class Params_Start
        {
            public SoftMaskScript self;
        }

        public sealed class Params_Update
        {
            public SoftMaskScript self;
        }

        public sealed class Params_SetMask
        {
            public SoftMaskScript self;
        }

        public sealed class Params_GetCanvasRect
        {
            public SoftMaskScript self;
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

        public static event Delegates.SetMask_BeforeArgs SetMask
        {
            add
            {
                HookHandler._beforeSetMask += value;
                HookHandler.HookSetMask();
            }
            remove => HookHandler._beforeSetMask -= value;
        }

        public static event Delegates.GetCanvasRect_BeforeArgs GetCanvasRect
        {
            add
            {
                HookHandler._beforeGetCanvasRect += value;
                HookHandler.HookGetCanvasRect();
            }
            remove => HookHandler._beforeGetCanvasRect -= value;
        }
    }

    /// <summary>
    ///     Contains Hooks to that run code after orig(self) is called
    /// </summary>
    public static class AfterOrig
    {
        public static event Delegates.Start_AfterArgs Start
        {
            add
            {
                HookHandler._afterStart += value;
                HookHandler.HookStart();
            }
            remove => HookHandler._afterStart -= value;
        }

        public static event Delegates.Update_AfterArgs Update
        {
            add
            {
                HookHandler._afterUpdate += value;
                HookHandler.HookUpdate();
            }
            remove => HookHandler._afterUpdate -= value;
        }

        public static event Delegates.SetMask_AfterArgs SetMask
        {
            add
            {
                HookHandler._afterSetMask += value;
                HookHandler.HookSetMask();
            }
            remove => HookHandler._afterSetMask -= value;
        }

        public static event Delegates.GetCanvasRect_AfterArgs GetCanvasRect
        {
            add
            {
                HookHandler._afterGetCanvasRect += value;
                HookHandler.HookGetCanvasRect();
            }
            remove => HookHandler._afterGetCanvasRect -= value;
        }
    }

    /// <summary>
    ///     Contains all On Hooks, even those that aren't in the On namespace such as API generated functions and property
    ///     getters/setters
    /// </summary>
    public static class WithOrig
    {
        public static event Delegates.Start_WithArgs Start
        {
            add => HookEndpointManager.Add<Delegates.Start_WithArgs>(
                ReflectionHelper.GetMethodInfo(typeof(SoftMaskScript), "Start"), value);
            remove => HookEndpointManager.Remove<Delegates.Start_WithArgs>(
                ReflectionHelper.GetMethodInfo(typeof(SoftMaskScript), "Start"), value);
        }

        public static event Delegates.Update_WithArgs Update
        {
            add => HookEndpointManager.Add<Delegates.Update_WithArgs>(
                ReflectionHelper.GetMethodInfo(typeof(SoftMaskScript), "Update"), value);
            remove => HookEndpointManager.Remove<Delegates.Update_WithArgs>(
                ReflectionHelper.GetMethodInfo(typeof(SoftMaskScript), "Update"), value);
        }

        public static event Delegates.SetMask_WithArgs SetMask
        {
            add => HookEndpointManager.Add<Delegates.SetMask_WithArgs>(
                ReflectionHelper.GetMethodInfo(typeof(SoftMaskScript), "SetMask"), value);
            remove => HookEndpointManager.Remove<Delegates.SetMask_WithArgs>(
                ReflectionHelper.GetMethodInfo(typeof(SoftMaskScript), "SetMask"), value);
        }

        public static event Delegates.GetCanvasRect_WithArgs GetCanvasRect
        {
            add => HookEndpointManager.Add<Delegates.GetCanvasRect_WithArgs>(
                ReflectionHelper.GetMethodInfo(typeof(SoftMaskScript), "GetCanvasRect"), value);
            remove => HookEndpointManager.Remove<Delegates.GetCanvasRect_WithArgs>(
                ReflectionHelper.GetMethodInfo(typeof(SoftMaskScript), "GetCanvasRect"), value);
        }
    }
}