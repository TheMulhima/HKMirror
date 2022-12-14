using MonoMod.RuntimeDetour;
using MonoMod.RuntimeDetour.HookGen;

namespace HKMirror.Hooks.OnHooks;

/// <summary>
///     Contains different types of On Hooks for LensCAAndDistortion class.<br />
///     Contains hooks that aren't generated by monomod, and before and after orig hooks for easier hooking.
/// </summary>
public static class OnLensCAAndDistortion
{
    internal static class HookHandler
    {
        private static readonly List<string> HookedList = new();

        internal static void Hookget_material()
        {
            if (!HookedList.Contains("get_material"))
            {
                HookedList.Add("get_material");
                new Hook(ReflectionHelper.GetMethodInfo(typeof(LensCAAndDistortion), "get_material"), get_material);
            }
        }

        internal static event Delegates.get_material_BeforeArgs _beforeget_material;
        internal static event Delegates.get_material_AfterArgs _afterget_material;

        private static Material get_material(Func<LensCAAndDistortion, Material> orig, LensCAAndDistortion self)
        {
            Delegates.Params_get_material @params = new()
            {
                self = self
            };
            if (_beforeget_material != null)
                foreach (Delegates.get_material_BeforeArgs toInvoke in _beforeget_material.GetInvocationList())
                    try
                    {
                        _beforeget_material?.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }

            self = @params.self;
            var retVal = orig(self);
            if (_afterget_material != null)
                foreach (Delegates.get_material_AfterArgs toInvoke in _afterget_material.GetInvocationList())
                    try
                    {
                        retVal = _afterget_material.Invoke(@params, retVal);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }

            return retVal;
        }

        internal static void HookStart()
        {
            if (!HookedList.Contains("Start"))
            {
                HookedList.Add("Start");
                On.LensCAAndDistortion.Start += Start;
            }
        }

        internal static event Delegates.Start_BeforeArgs _beforeStart;
        internal static event Delegates.Start_AfterArgs _afterStart;

        private static void Start(On.LensCAAndDistortion.orig_Start orig, LensCAAndDistortion self)
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

        internal static void HookOnRenderImage()
        {
            if (!HookedList.Contains("OnRenderImage"))
            {
                HookedList.Add("OnRenderImage");
                On.LensCAAndDistortion.OnRenderImage += OnRenderImage;
            }
        }

        internal static event Delegates.OnRenderImage_BeforeArgs _beforeOnRenderImage;
        internal static event Delegates.OnRenderImage_AfterArgs _afterOnRenderImage;

        private static void OnRenderImage(On.LensCAAndDistortion.orig_OnRenderImage orig, LensCAAndDistortion self,
            RenderTexture sourceTexture, RenderTexture destTexture)
        {
            Delegates.Params_OnRenderImage @params = new()
            {
                self = self, sourceTexture = sourceTexture, destTexture = destTexture
            };
            if (_beforeOnRenderImage != null)
                foreach (Delegates.OnRenderImage_BeforeArgs toInvoke in _beforeOnRenderImage.GetInvocationList())
                    try
                    {
                        _beforeOnRenderImage?.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }

            self = @params.self;
            sourceTexture = @params.sourceTexture;
            destTexture = @params.destTexture;
            orig(self, sourceTexture, destTexture);
            if (_afterOnRenderImage != null)
                foreach (Delegates.OnRenderImage_AfterArgs toInvoke in _afterOnRenderImage.GetInvocationList())
                    try
                    {
                        _afterOnRenderImage.Invoke(@params);
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
                On.LensCAAndDistortion.Update += Update;
            }
        }

        internal static event Delegates.Update_BeforeArgs _beforeUpdate;
        internal static event Delegates.Update_AfterArgs _afterUpdate;

        private static void Update(On.LensCAAndDistortion.orig_Update orig, LensCAAndDistortion self)
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

        internal static void HookOnDisable()
        {
            if (!HookedList.Contains("OnDisable"))
            {
                HookedList.Add("OnDisable");
                On.LensCAAndDistortion.OnDisable += OnDisable;
            }
        }

        internal static event Delegates.OnDisable_BeforeArgs _beforeOnDisable;
        internal static event Delegates.OnDisable_AfterArgs _afterOnDisable;

        private static void OnDisable(On.LensCAAndDistortion.orig_OnDisable orig, LensCAAndDistortion self)
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
    }

    /// <summary>
    ///     Contains necessary information to create Hooks. Does not contain any hooks
    /// </summary>
    public static class Delegates
    {
        public delegate Material get_material_AfterArgs(Params_get_material args, Material ret);

        public delegate void get_material_BeforeArgs(Params_get_material args);

        public delegate Material get_material_WithArgs(Func<LensCAAndDistortion, Material> orig,
            LensCAAndDistortion self);

        public delegate void OnDisable_AfterArgs(Params_OnDisable args);

        public delegate void OnDisable_BeforeArgs(Params_OnDisable args);

        public delegate void OnDisable_WithArgs(Action<LensCAAndDistortion> orig, LensCAAndDistortion self);

        public delegate void OnRenderImage_AfterArgs(Params_OnRenderImage args);

        public delegate void OnRenderImage_BeforeArgs(Params_OnRenderImage args);

        public delegate void OnRenderImage_WithArgs(Action<LensCAAndDistortion, RenderTexture, RenderTexture> orig,
            LensCAAndDistortion self, RenderTexture sourceTexture, RenderTexture destTexture);

        public delegate void Start_AfterArgs(Params_Start args);

        public delegate void Start_BeforeArgs(Params_Start args);

        public delegate void Start_WithArgs(Action<LensCAAndDistortion> orig, LensCAAndDistortion self);

        public delegate void Update_AfterArgs(Params_Update args);

        public delegate void Update_BeforeArgs(Params_Update args);

        public delegate void Update_WithArgs(Action<LensCAAndDistortion> orig, LensCAAndDistortion self);

        public sealed class Params_get_material
        {
            public LensCAAndDistortion self;
        }

        public sealed class Params_Start
        {
            public LensCAAndDistortion self;
        }

        public sealed class Params_OnRenderImage
        {
            public RenderTexture destTexture;
            public LensCAAndDistortion self;
            public RenderTexture sourceTexture;
        }

        public sealed class Params_Update
        {
            public LensCAAndDistortion self;
        }

        public sealed class Params_OnDisable
        {
            public LensCAAndDistortion self;
        }
    }

    /// <summary>
    ///     Contains Hooks to that run code before orig(self) is called
    /// </summary>
    public static class BeforeOrig
    {
        public static event Delegates.get_material_BeforeArgs get_material
        {
            add
            {
                HookHandler._beforeget_material += value;
                HookHandler.Hookget_material();
            }
            remove => HookHandler._beforeget_material -= value;
        }

        public static event Delegates.Start_BeforeArgs Start
        {
            add
            {
                HookHandler._beforeStart += value;
                HookHandler.HookStart();
            }
            remove => HookHandler._beforeStart -= value;
        }

        public static event Delegates.OnRenderImage_BeforeArgs OnRenderImage
        {
            add
            {
                HookHandler._beforeOnRenderImage += value;
                HookHandler.HookOnRenderImage();
            }
            remove => HookHandler._beforeOnRenderImage -= value;
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

        public static event Delegates.OnDisable_BeforeArgs OnDisable
        {
            add
            {
                HookHandler._beforeOnDisable += value;
                HookHandler.HookOnDisable();
            }
            remove => HookHandler._beforeOnDisable -= value;
        }
    }

    /// <summary>
    ///     Contains Hooks to that run code after orig(self) is called
    /// </summary>
    public static class AfterOrig
    {
        public static event Delegates.get_material_AfterArgs get_material
        {
            add
            {
                HookHandler._afterget_material += value;
                HookHandler.Hookget_material();
            }
            remove => HookHandler._afterget_material -= value;
        }

        public static event Delegates.Start_AfterArgs Start
        {
            add
            {
                HookHandler._afterStart += value;
                HookHandler.HookStart();
            }
            remove => HookHandler._afterStart -= value;
        }

        public static event Delegates.OnRenderImage_AfterArgs OnRenderImage
        {
            add
            {
                HookHandler._afterOnRenderImage += value;
                HookHandler.HookOnRenderImage();
            }
            remove => HookHandler._afterOnRenderImage -= value;
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

        public static event Delegates.OnDisable_AfterArgs OnDisable
        {
            add
            {
                HookHandler._afterOnDisable += value;
                HookHandler.HookOnDisable();
            }
            remove => HookHandler._afterOnDisable -= value;
        }
    }

    /// <summary>
    ///     Contains all On Hooks, even those that aren't in the On namespace such as API generated functions and property
    ///     getters/setters
    /// </summary>
    public static class WithOrig
    {
        public static event Delegates.get_material_WithArgs get_material
        {
            add => HookEndpointManager.Add<Delegates.get_material_WithArgs>(
                ReflectionHelper.GetMethodInfo(typeof(LensCAAndDistortion), "get_material"), value);
            remove => HookEndpointManager.Remove<Delegates.get_material_WithArgs>(
                ReflectionHelper.GetMethodInfo(typeof(LensCAAndDistortion), "get_material"), value);
        }

        public static event On.LensCAAndDistortion.hook_Start Start
        {
            add => On.LensCAAndDistortion.Start += value;
            remove => On.LensCAAndDistortion.Start -= value;
        }

        public static event On.LensCAAndDistortion.hook_OnRenderImage OnRenderImage
        {
            add => On.LensCAAndDistortion.OnRenderImage += value;
            remove => On.LensCAAndDistortion.OnRenderImage -= value;
        }

        public static event On.LensCAAndDistortion.hook_Update Update
        {
            add => On.LensCAAndDistortion.Update += value;
            remove => On.LensCAAndDistortion.Update -= value;
        }

        public static event On.LensCAAndDistortion.hook_OnDisable OnDisable
        {
            add => On.LensCAAndDistortion.OnDisable += value;
            remove => On.LensCAAndDistortion.OnDisable -= value;
        }
    }
}