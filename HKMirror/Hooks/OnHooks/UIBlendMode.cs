using GUIBlendModes;
using MonoMod.RuntimeDetour;
using MonoMod.RuntimeDetour.HookGen;

namespace HKMirror.Hooks.OnHooks;

/// <summary>
///     Contains different types of On Hooks for UIBlendMode class.<br />
///     Contains hooks that aren't generated by monomod, and before and after orig hooks for easier hooking.
/// </summary>
public static class OnUIBlendMode
{
    internal static class HookHandler
    {
        private static readonly List<string> HookedList = new();

        internal static void Hookget_BlendMode()
        {
            if (!HookedList.Contains("get_BlendMode"))
            {
                HookedList.Add("get_BlendMode");
                new Hook(ReflectionHelper.GetMethodInfo(typeof(UIBlendMode), "get_BlendMode"), get_BlendMode);
            }
        }

        internal static event Delegates.get_BlendMode_BeforeArgs _beforeget_BlendMode;
        internal static event Delegates.get_BlendMode_AfterArgs _afterget_BlendMode;

        private static BlendMode get_BlendMode(Func<UIBlendMode, BlendMode> orig, UIBlendMode self)
        {
            Delegates.Params_get_BlendMode @params = new()
            {
                self = self
            };
            if (_beforeget_BlendMode != null)
                foreach (Delegates.get_BlendMode_BeforeArgs toInvoke in _beforeget_BlendMode.GetInvocationList())
                    try
                    {
                        _beforeget_BlendMode?.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }

            self = @params.self;
            var retVal = orig(self);
            if (_afterget_BlendMode != null)
                foreach (Delegates.get_BlendMode_AfterArgs toInvoke in _afterget_BlendMode.GetInvocationList())
                    try
                    {
                        retVal = _afterget_BlendMode.Invoke(@params, retVal);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }

            return retVal;
        }

        internal static void Hookset_BlendMode()
        {
            if (!HookedList.Contains("set_BlendMode"))
            {
                HookedList.Add("set_BlendMode");
                new Hook(ReflectionHelper.GetMethodInfo(typeof(UIBlendMode), "set_BlendMode"), set_BlendMode);
            }
        }

        internal static event Delegates.set_BlendMode_BeforeArgs _beforeset_BlendMode;
        internal static event Delegates.set_BlendMode_AfterArgs _afterset_BlendMode;

        private static void set_BlendMode(Action<UIBlendMode, BlendMode> orig, UIBlendMode self, BlendMode value)
        {
            Delegates.Params_set_BlendMode @params = new()
            {
                self = self, value = value
            };
            if (_beforeset_BlendMode != null)
                foreach (Delegates.set_BlendMode_BeforeArgs toInvoke in _beforeset_BlendMode.GetInvocationList())
                    try
                    {
                        _beforeset_BlendMode?.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }

            self = @params.self;
            value = @params.value;
            orig(self, value);
            if (_afterset_BlendMode != null)
                foreach (Delegates.set_BlendMode_AfterArgs toInvoke in _afterset_BlendMode.GetInvocationList())
                    try
                    {
                        _afterset_BlendMode.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }
        }

        internal static void Hookget_ShaderOptimization()
        {
            if (!HookedList.Contains("get_ShaderOptimization"))
            {
                HookedList.Add("get_ShaderOptimization");
                new Hook(ReflectionHelper.GetMethodInfo(typeof(UIBlendMode), "get_ShaderOptimization"),
                    get_ShaderOptimization);
            }
        }

        internal static event Delegates.get_ShaderOptimization_BeforeArgs _beforeget_ShaderOptimization;
        internal static event Delegates.get_ShaderOptimization_AfterArgs _afterget_ShaderOptimization;

        private static bool get_ShaderOptimization(Func<UIBlendMode, bool> orig, UIBlendMode self)
        {
            Delegates.Params_get_ShaderOptimization @params = new()
            {
                self = self
            };
            if (_beforeget_ShaderOptimization != null)
                foreach (Delegates.get_ShaderOptimization_BeforeArgs toInvoke in _beforeget_ShaderOptimization
                             .GetInvocationList())
                    try
                    {
                        _beforeget_ShaderOptimization?.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }

            self = @params.self;
            var retVal = orig(self);
            if (_afterget_ShaderOptimization != null)
                foreach (Delegates.get_ShaderOptimization_AfterArgs toInvoke in _afterget_ShaderOptimization
                             .GetInvocationList())
                    try
                    {
                        retVal = _afterget_ShaderOptimization.Invoke(@params, retVal);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }

            return retVal;
        }

        internal static void Hookset_ShaderOptimization()
        {
            if (!HookedList.Contains("set_ShaderOptimization"))
            {
                HookedList.Add("set_ShaderOptimization");
                new Hook(ReflectionHelper.GetMethodInfo(typeof(UIBlendMode), "set_ShaderOptimization"),
                    set_ShaderOptimization);
            }
        }

        internal static event Delegates.set_ShaderOptimization_BeforeArgs _beforeset_ShaderOptimization;
        internal static event Delegates.set_ShaderOptimization_AfterArgs _afterset_ShaderOptimization;

        private static void set_ShaderOptimization(Action<UIBlendMode, bool> orig, UIBlendMode self, bool value)
        {
            Delegates.Params_set_ShaderOptimization @params = new()
            {
                self = self, value = value
            };
            if (_beforeset_ShaderOptimization != null)
                foreach (Delegates.set_ShaderOptimization_BeforeArgs toInvoke in _beforeset_ShaderOptimization
                             .GetInvocationList())
                    try
                    {
                        _beforeset_ShaderOptimization?.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }

            self = @params.self;
            value = @params.value;
            orig(self, value);
            if (_afterset_ShaderOptimization != null)
                foreach (Delegates.set_ShaderOptimization_AfterArgs toInvoke in _afterset_ShaderOptimization
                             .GetInvocationList())
                    try
                    {
                        _afterset_ShaderOptimization.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }
        }

        internal static void HookOnEnable()
        {
            if (!HookedList.Contains("OnEnable"))
            {
                HookedList.Add("OnEnable");
                new Hook(ReflectionHelper.GetMethodInfo(typeof(UIBlendMode), "OnEnable"), OnEnable);
            }
        }

        internal static event Delegates.OnEnable_BeforeArgs _beforeOnEnable;
        internal static event Delegates.OnEnable_AfterArgs _afterOnEnable;

        private static void OnEnable(Action<UIBlendMode> orig, UIBlendMode self)
        {
            Delegates.Params_OnEnable @params = new()
            {
                self = self
            };
            if (_beforeOnEnable != null)
                foreach (Delegates.OnEnable_BeforeArgs toInvoke in _beforeOnEnable.GetInvocationList())
                    try
                    {
                        _beforeOnEnable?.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }

            self = @params.self;
            orig(self);
            if (_afterOnEnable != null)
                foreach (Delegates.OnEnable_AfterArgs toInvoke in _afterOnEnable.GetInvocationList())
                    try
                    {
                        _afterOnEnable.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }
        }

        internal static void HookOnDisable()
        {
            if (!HookedList.Contains("OnDisable"))
            {
                HookedList.Add("OnDisable");
                new Hook(ReflectionHelper.GetMethodInfo(typeof(UIBlendMode), "OnDisable"), OnDisable);
            }
        }

        internal static event Delegates.OnDisable_BeforeArgs _beforeOnDisable;
        internal static event Delegates.OnDisable_AfterArgs _afterOnDisable;

        private static void OnDisable(Action<UIBlendMode> orig, UIBlendMode self)
        {
            Delegates.Params_OnDisable @params = new()
            {
                self = self
            };
            if (_beforeOnDisable != null)
                foreach (Delegates.OnDisable_BeforeArgs toInvoke in _beforeOnDisable.GetInvocationList())
                    try
                    {
                        _beforeOnDisable?.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }

            self = @params.self;
            orig(self);
            if (_afterOnDisable != null)
                foreach (Delegates.OnDisable_AfterArgs toInvoke in _afterOnDisable.GetInvocationList())
                    try
                    {
                        _afterOnDisable.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }
        }

        internal static void HookSetBlendMode()
        {
            if (!HookedList.Contains("SetBlendMode"))
            {
                HookedList.Add("SetBlendMode");
                new Hook(ReflectionHelper.GetMethodInfo(typeof(UIBlendMode), "SetBlendMode"), SetBlendMode);
            }
        }

        internal static event Delegates.SetBlendMode_BeforeArgs _beforeSetBlendMode;
        internal static event Delegates.SetBlendMode_AfterArgs _afterSetBlendMode;

        private static void SetBlendMode(Action<UIBlendMode, BlendMode, bool> orig, UIBlendMode self,
            BlendMode blendMode, bool shaderOptimization)
        {
            Delegates.Params_SetBlendMode @params = new()
            {
                self = self, blendMode = blendMode, shaderOptimization = shaderOptimization
            };
            if (_beforeSetBlendMode != null)
                foreach (Delegates.SetBlendMode_BeforeArgs toInvoke in _beforeSetBlendMode.GetInvocationList())
                    try
                    {
                        _beforeSetBlendMode?.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }

            self = @params.self;
            blendMode = @params.blendMode;
            shaderOptimization = @params.shaderOptimization;
            orig(self, blendMode, shaderOptimization);
            if (_afterSetBlendMode != null)
                foreach (Delegates.SetBlendMode_AfterArgs toInvoke in _afterSetBlendMode.GetInvocationList())
                    try
                    {
                        _afterSetBlendMode.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }
        }

        internal static void HookSyncEditor()
        {
            if (!HookedList.Contains("SyncEditor"))
            {
                HookedList.Add("SyncEditor");
                new Hook(ReflectionHelper.GetMethodInfo(typeof(UIBlendMode), "SyncEditor"), SyncEditor);
            }
        }

        internal static event Delegates.SyncEditor_BeforeArgs _beforeSyncEditor;
        internal static event Delegates.SyncEditor_AfterArgs _afterSyncEditor;

        private static void SyncEditor(Action<UIBlendMode> orig, UIBlendMode self)
        {
            Delegates.Params_SyncEditor @params = new()
            {
                self = self
            };
            if (_beforeSyncEditor != null)
                foreach (Delegates.SyncEditor_BeforeArgs toInvoke in _beforeSyncEditor.GetInvocationList())
                    try
                    {
                        _beforeSyncEditor?.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }

            self = @params.self;
            orig(self);
            if (_afterSyncEditor != null)
                foreach (Delegates.SyncEditor_AfterArgs toInvoke in _afterSyncEditor.GetInvocationList())
                    try
                    {
                        _afterSyncEditor.Invoke(@params);
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
        public delegate BlendMode get_BlendMode_AfterArgs(Params_get_BlendMode args, BlendMode ret);

        public delegate void get_BlendMode_BeforeArgs(Params_get_BlendMode args);

        public delegate BlendMode get_BlendMode_WithArgs(Func<UIBlendMode, BlendMode> orig, UIBlendMode self);

        public delegate bool get_ShaderOptimization_AfterArgs(Params_get_ShaderOptimization args, bool ret);

        public delegate void get_ShaderOptimization_BeforeArgs(Params_get_ShaderOptimization args);

        public delegate bool get_ShaderOptimization_WithArgs(Func<UIBlendMode, bool> orig, UIBlendMode self);

        public delegate void OnDisable_AfterArgs(Params_OnDisable args);

        public delegate void OnDisable_BeforeArgs(Params_OnDisable args);

        public delegate void OnDisable_WithArgs(Action<UIBlendMode> orig, UIBlendMode self);

        public delegate void OnEnable_AfterArgs(Params_OnEnable args);

        public delegate void OnEnable_BeforeArgs(Params_OnEnable args);

        public delegate void OnEnable_WithArgs(Action<UIBlendMode> orig, UIBlendMode self);

        public delegate void set_BlendMode_AfterArgs(Params_set_BlendMode args);

        public delegate void set_BlendMode_BeforeArgs(Params_set_BlendMode args);

        public delegate void set_BlendMode_WithArgs(Action<UIBlendMode, BlendMode> orig, UIBlendMode self,
            BlendMode value);

        public delegate void set_ShaderOptimization_AfterArgs(Params_set_ShaderOptimization args);

        public delegate void set_ShaderOptimization_BeforeArgs(Params_set_ShaderOptimization args);

        public delegate void set_ShaderOptimization_WithArgs(Action<UIBlendMode, bool> orig, UIBlendMode self,
            bool value);

        public delegate void SetBlendMode_AfterArgs(Params_SetBlendMode args);

        public delegate void SetBlendMode_BeforeArgs(Params_SetBlendMode args);

        public delegate void SetBlendMode_WithArgs(Action<UIBlendMode, BlendMode, bool> orig, UIBlendMode self,
            BlendMode blendMode, bool shaderOptimization);

        public delegate void SyncEditor_AfterArgs(Params_SyncEditor args);

        public delegate void SyncEditor_BeforeArgs(Params_SyncEditor args);

        public delegate void SyncEditor_WithArgs(Action<UIBlendMode> orig, UIBlendMode self);

        public sealed class Params_get_BlendMode
        {
            public UIBlendMode self;
        }

        public sealed class Params_set_BlendMode
        {
            public UIBlendMode self;
            public BlendMode value;
        }

        public sealed class Params_get_ShaderOptimization
        {
            public UIBlendMode self;
        }

        public sealed class Params_set_ShaderOptimization
        {
            public UIBlendMode self;
            public bool value;
        }

        public sealed class Params_OnEnable
        {
            public UIBlendMode self;
        }

        public sealed class Params_OnDisable
        {
            public UIBlendMode self;
        }

        public sealed class Params_SetBlendMode
        {
            public BlendMode blendMode;
            public UIBlendMode self;
            public bool shaderOptimization;
        }

        public sealed class Params_SyncEditor
        {
            public UIBlendMode self;
        }
    }

    /// <summary>
    ///     Contains Hooks to that run code before orig(self) is called
    /// </summary>
    public static class BeforeOrig
    {
        public static event Delegates.get_BlendMode_BeforeArgs get_BlendMode
        {
            add
            {
                HookHandler._beforeget_BlendMode += value;
                HookHandler.Hookget_BlendMode();
            }
            remove => HookHandler._beforeget_BlendMode -= value;
        }

        public static event Delegates.set_BlendMode_BeforeArgs set_BlendMode
        {
            add
            {
                HookHandler._beforeset_BlendMode += value;
                HookHandler.Hookset_BlendMode();
            }
            remove => HookHandler._beforeset_BlendMode -= value;
        }

        public static event Delegates.get_ShaderOptimization_BeforeArgs get_ShaderOptimization
        {
            add
            {
                HookHandler._beforeget_ShaderOptimization += value;
                HookHandler.Hookget_ShaderOptimization();
            }
            remove => HookHandler._beforeget_ShaderOptimization -= value;
        }

        public static event Delegates.set_ShaderOptimization_BeforeArgs set_ShaderOptimization
        {
            add
            {
                HookHandler._beforeset_ShaderOptimization += value;
                HookHandler.Hookset_ShaderOptimization();
            }
            remove => HookHandler._beforeset_ShaderOptimization -= value;
        }

        public static event Delegates.OnEnable_BeforeArgs OnEnable
        {
            add
            {
                HookHandler._beforeOnEnable += value;
                HookHandler.HookOnEnable();
            }
            remove => HookHandler._beforeOnEnable -= value;
        }

        public static event Delegates.OnDisable_BeforeArgs OnDisable
        {
            add
            {
                HookHandler._beforeOnDisable += value;
                HookHandler.HookOnDisable();
            }
            remove => HookHandler._beforeOnDisable -= value;
        }

        public static event Delegates.SetBlendMode_BeforeArgs SetBlendMode
        {
            add
            {
                HookHandler._beforeSetBlendMode += value;
                HookHandler.HookSetBlendMode();
            }
            remove => HookHandler._beforeSetBlendMode -= value;
        }

        public static event Delegates.SyncEditor_BeforeArgs SyncEditor
        {
            add
            {
                HookHandler._beforeSyncEditor += value;
                HookHandler.HookSyncEditor();
            }
            remove => HookHandler._beforeSyncEditor -= value;
        }
    }

    /// <summary>
    ///     Contains Hooks to that run code after orig(self) is called
    /// </summary>
    public static class AfterOrig
    {
        public static event Delegates.get_BlendMode_AfterArgs get_BlendMode
        {
            add
            {
                HookHandler._afterget_BlendMode += value;
                HookHandler.Hookget_BlendMode();
            }
            remove => HookHandler._afterget_BlendMode -= value;
        }

        public static event Delegates.set_BlendMode_AfterArgs set_BlendMode
        {
            add
            {
                HookHandler._afterset_BlendMode += value;
                HookHandler.Hookset_BlendMode();
            }
            remove => HookHandler._afterset_BlendMode -= value;
        }

        public static event Delegates.get_ShaderOptimization_AfterArgs get_ShaderOptimization
        {
            add
            {
                HookHandler._afterget_ShaderOptimization += value;
                HookHandler.Hookget_ShaderOptimization();
            }
            remove => HookHandler._afterget_ShaderOptimization -= value;
        }

        public static event Delegates.set_ShaderOptimization_AfterArgs set_ShaderOptimization
        {
            add
            {
                HookHandler._afterset_ShaderOptimization += value;
                HookHandler.Hookset_ShaderOptimization();
            }
            remove => HookHandler._afterset_ShaderOptimization -= value;
        }

        public static event Delegates.OnEnable_AfterArgs OnEnable
        {
            add
            {
                HookHandler._afterOnEnable += value;
                HookHandler.HookOnEnable();
            }
            remove => HookHandler._afterOnEnable -= value;
        }

        public static event Delegates.OnDisable_AfterArgs OnDisable
        {
            add
            {
                HookHandler._afterOnDisable += value;
                HookHandler.HookOnDisable();
            }
            remove => HookHandler._afterOnDisable -= value;
        }

        public static event Delegates.SetBlendMode_AfterArgs SetBlendMode
        {
            add
            {
                HookHandler._afterSetBlendMode += value;
                HookHandler.HookSetBlendMode();
            }
            remove => HookHandler._afterSetBlendMode -= value;
        }

        public static event Delegates.SyncEditor_AfterArgs SyncEditor
        {
            add
            {
                HookHandler._afterSyncEditor += value;
                HookHandler.HookSyncEditor();
            }
            remove => HookHandler._afterSyncEditor -= value;
        }
    }

    /// <summary>
    ///     Contains all On Hooks, even those that aren't in the On namespace such as API generated functions and property
    ///     getters/setters
    /// </summary>
    public static class WithOrig
    {
        public static event Delegates.get_BlendMode_WithArgs get_BlendMode
        {
            add => HookEndpointManager.Add<Delegates.get_BlendMode_WithArgs>(
                ReflectionHelper.GetMethodInfo(typeof(UIBlendMode), "get_BlendMode"), value);
            remove => HookEndpointManager.Remove<Delegates.get_BlendMode_WithArgs>(
                ReflectionHelper.GetMethodInfo(typeof(UIBlendMode), "get_BlendMode"), value);
        }

        public static event Delegates.set_BlendMode_WithArgs set_BlendMode
        {
            add => HookEndpointManager.Add<Delegates.set_BlendMode_WithArgs>(
                ReflectionHelper.GetMethodInfo(typeof(UIBlendMode), "set_BlendMode"), value);
            remove => HookEndpointManager.Remove<Delegates.set_BlendMode_WithArgs>(
                ReflectionHelper.GetMethodInfo(typeof(UIBlendMode), "set_BlendMode"), value);
        }

        public static event Delegates.get_ShaderOptimization_WithArgs get_ShaderOptimization
        {
            add => HookEndpointManager.Add<Delegates.get_ShaderOptimization_WithArgs>(
                ReflectionHelper.GetMethodInfo(typeof(UIBlendMode), "get_ShaderOptimization"), value);
            remove => HookEndpointManager.Remove<Delegates.get_ShaderOptimization_WithArgs>(
                ReflectionHelper.GetMethodInfo(typeof(UIBlendMode), "get_ShaderOptimization"), value);
        }

        public static event Delegates.set_ShaderOptimization_WithArgs set_ShaderOptimization
        {
            add => HookEndpointManager.Add<Delegates.set_ShaderOptimization_WithArgs>(
                ReflectionHelper.GetMethodInfo(typeof(UIBlendMode), "set_ShaderOptimization"), value);
            remove => HookEndpointManager.Remove<Delegates.set_ShaderOptimization_WithArgs>(
                ReflectionHelper.GetMethodInfo(typeof(UIBlendMode), "set_ShaderOptimization"), value);
        }

        public static event Delegates.OnEnable_WithArgs OnEnable
        {
            add => HookEndpointManager.Add<Delegates.OnEnable_WithArgs>(
                ReflectionHelper.GetMethodInfo(typeof(UIBlendMode), "OnEnable"), value);
            remove => HookEndpointManager.Remove<Delegates.OnEnable_WithArgs>(
                ReflectionHelper.GetMethodInfo(typeof(UIBlendMode), "OnEnable"), value);
        }

        public static event Delegates.OnDisable_WithArgs OnDisable
        {
            add => HookEndpointManager.Add<Delegates.OnDisable_WithArgs>(
                ReflectionHelper.GetMethodInfo(typeof(UIBlendMode), "OnDisable"), value);
            remove => HookEndpointManager.Remove<Delegates.OnDisable_WithArgs>(
                ReflectionHelper.GetMethodInfo(typeof(UIBlendMode), "OnDisable"), value);
        }

        public static event Delegates.SetBlendMode_WithArgs SetBlendMode
        {
            add => HookEndpointManager.Add<Delegates.SetBlendMode_WithArgs>(
                ReflectionHelper.GetMethodInfo(typeof(UIBlendMode), "SetBlendMode"), value);
            remove => HookEndpointManager.Remove<Delegates.SetBlendMode_WithArgs>(
                ReflectionHelper.GetMethodInfo(typeof(UIBlendMode), "SetBlendMode"), value);
        }

        public static event Delegates.SyncEditor_WithArgs SyncEditor
        {
            add => HookEndpointManager.Add<Delegates.SyncEditor_WithArgs>(
                ReflectionHelper.GetMethodInfo(typeof(UIBlendMode), "SyncEditor"), value);
            remove => HookEndpointManager.Remove<Delegates.SyncEditor_WithArgs>(
                ReflectionHelper.GetMethodInfo(typeof(UIBlendMode), "SyncEditor"), value);
        }
    }
}