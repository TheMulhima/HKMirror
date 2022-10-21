using MonoMod.RuntimeDetour;
using MonoMod.RuntimeDetour.HookGen;

namespace HKMirror.Hooks.OnHooks;

/// <summary>
/// Contains different types of On Hooks for FadeSequence class.<br />
/// Contains hooks that aren't generated by monomod, and before and after orig hooks for easier hooking.
/// </summary>
public static class OnFadeSequence
{
    internal static class HookHandler
    {
        private static List<string> HookedList = new List<string>();

        internal static void Hookget_IsSkipped()
        {
            if (!HookedList.Contains("get_IsSkipped"))
            {
                HookedList.Add("get_IsSkipped");
                new Hook(ReflectionHelper.GetMethodInfo(typeof(FadeSequence), "get_IsSkipped", true), get_IsSkipped);
            }
        }

        internal static event Delegates.get_IsSkipped_BeforeArgs _beforeget_IsSkipped;
        internal static event Delegates.get_IsSkipped_AfterArgs _afterget_IsSkipped;

        private static bool get_IsSkipped(Func<FadeSequence, bool> orig, FadeSequence self)
        {
            Delegates.Params_get_IsSkipped @params = new()
            {
                self = self
            };
            if (_beforeget_IsSkipped != null)
            {
                foreach (Delegates.get_IsSkipped_BeforeArgs toInvoke in _beforeget_IsSkipped.GetInvocationList())
                {
                    try
                    {
                        _beforeget_IsSkipped?.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }
                }
            }

            self = @params.self;
            var retVal = orig(self);
            if (_afterget_IsSkipped != null)
            {
                foreach (Delegates.get_IsSkipped_AfterArgs toInvoke in _afterget_IsSkipped.GetInvocationList())
                {
                    try
                    {
                        retVal = _afterget_IsSkipped.Invoke(@params, retVal);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }
                }
            }

            return retVal;
        }

        internal static void Hookget_FadeRate()
        {
            if (!HookedList.Contains("get_FadeRate"))
            {
                HookedList.Add("get_FadeRate");
                new Hook(ReflectionHelper.GetMethodInfo(typeof(FadeSequence), "get_FadeRate", true), get_FadeRate);
            }
        }

        internal static event Delegates.get_FadeRate_BeforeArgs _beforeget_FadeRate;
        internal static event Delegates.get_FadeRate_AfterArgs _afterget_FadeRate;

        private static float get_FadeRate(Func<FadeSequence, float> orig, FadeSequence self)
        {
            Delegates.Params_get_FadeRate @params = new()
            {
                self = self
            };
            if (_beforeget_FadeRate != null)
            {
                foreach (Delegates.get_FadeRate_BeforeArgs toInvoke in _beforeget_FadeRate.GetInvocationList())
                {
                    try
                    {
                        _beforeget_FadeRate?.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }
                }
            }

            self = @params.self;
            var retVal = orig(self);
            if (_afterget_FadeRate != null)
            {
                foreach (Delegates.get_FadeRate_AfterArgs toInvoke in _afterget_FadeRate.GetInvocationList())
                {
                    try
                    {
                        retVal = _afterget_FadeRate.Invoke(@params, retVal);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }
                }
            }

            return retVal;
        }

        internal static void Hookget_FadeByController()
        {
            if (!HookedList.Contains("get_FadeByController"))
            {
                HookedList.Add("get_FadeByController");
                new Hook(ReflectionHelper.GetMethodInfo(typeof(FadeSequence), "get_FadeByController", true),
                    get_FadeByController);
            }
        }

        internal static event Delegates.get_FadeByController_BeforeArgs _beforeget_FadeByController;
        internal static event Delegates.get_FadeByController_AfterArgs _afterget_FadeByController;

        private static float get_FadeByController(Func<FadeSequence, float> orig, FadeSequence self)
        {
            Delegates.Params_get_FadeByController @params = new()
            {
                self = self
            };
            if (_beforeget_FadeByController != null)
            {
                foreach (Delegates.get_FadeByController_BeforeArgs toInvoke in _beforeget_FadeByController
                             .GetInvocationList())
                {
                    try
                    {
                        _beforeget_FadeByController?.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }
                }
            }

            self = @params.self;
            var retVal = orig(self);
            if (_afterget_FadeByController != null)
            {
                foreach (Delegates.get_FadeByController_AfterArgs toInvoke in _afterget_FadeByController
                             .GetInvocationList())
                {
                    try
                    {
                        retVal = _afterget_FadeByController.Invoke(@params, retVal);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }
                }
            }

            return retVal;
        }

        internal static void Hookset_FadeByController()
        {
            if (!HookedList.Contains("set_FadeByController"))
            {
                HookedList.Add("set_FadeByController");
                new Hook(ReflectionHelper.GetMethodInfo(typeof(FadeSequence), "set_FadeByController", true),
                    set_FadeByController);
            }
        }

        internal static event Delegates.set_FadeByController_BeforeArgs _beforeset_FadeByController;
        internal static event Delegates.set_FadeByController_AfterArgs _afterset_FadeByController;

        private static void set_FadeByController(Action<FadeSequence, float> orig, FadeSequence self, float value)
        {
            Delegates.Params_set_FadeByController @params = new()
            {
                self = self, value = value
            };
            if (_beforeset_FadeByController != null)
            {
                foreach (Delegates.set_FadeByController_BeforeArgs toInvoke in _beforeset_FadeByController
                             .GetInvocationList())
                {
                    try
                    {
                        _beforeset_FadeByController?.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }
                }
            }

            self = @params.self;
            value = @params.value;
            orig(self, value);
            if (_afterset_FadeByController != null)
            {
                foreach (Delegates.set_FadeByController_AfterArgs toInvoke in _afterset_FadeByController
                             .GetInvocationList())
                {
                    try
                    {
                        _afterset_FadeByController.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }
                }
            }
        }

        internal static void Hookget_IsPlaying()
        {
            if (!HookedList.Contains("get_IsPlaying"))
            {
                HookedList.Add("get_IsPlaying");
                new Hook(ReflectionHelper.GetMethodInfo(typeof(FadeSequence), "get_IsPlaying", true), get_IsPlaying);
            }
        }

        internal static event Delegates.get_IsPlaying_BeforeArgs _beforeget_IsPlaying;
        internal static event Delegates.get_IsPlaying_AfterArgs _afterget_IsPlaying;

        private static bool get_IsPlaying(Func<FadeSequence, bool> orig, FadeSequence self)
        {
            Delegates.Params_get_IsPlaying @params = new()
            {
                self = self
            };
            if (_beforeget_IsPlaying != null)
            {
                foreach (Delegates.get_IsPlaying_BeforeArgs toInvoke in _beforeget_IsPlaying.GetInvocationList())
                {
                    try
                    {
                        _beforeget_IsPlaying?.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }
                }
            }

            self = @params.self;
            var retVal = orig(self);
            if (_afterget_IsPlaying != null)
            {
                foreach (Delegates.get_IsPlaying_AfterArgs toInvoke in _afterget_IsPlaying.GetInvocationList())
                {
                    try
                    {
                        retVal = _afterget_IsPlaying.Invoke(@params, retVal);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }
                }
            }

            return retVal;
        }

        internal static void HookAwake()
        {
            if (!HookedList.Contains("Awake"))
            {
                HookedList.Add("Awake");
                On.FadeSequence.Awake += Awake;
            }
        }

        internal static event Delegates.Awake_BeforeArgs _beforeAwake;
        internal static event Delegates.Awake_AfterArgs _afterAwake;

        private static void Awake(On.FadeSequence.orig_Awake orig, FadeSequence self)
        {
            Delegates.Params_Awake @params = new()
            {
                self = self
            };
            if (_beforeAwake != null)
            {
                foreach (Delegates.Awake_BeforeArgs toInvoke in _beforeAwake.GetInvocationList())
                {
                    try
                    {
                        _beforeAwake?.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }
                }
            }

            self = @params.self;
            orig(self);
            if (_afterAwake != null)
            {
                foreach (Delegates.Awake_AfterArgs toInvoke in _afterAwake.GetInvocationList())
                {
                    try
                    {
                        _afterAwake.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }
                }
            }
        }

        internal static void HookBegin()
        {
            if (!HookedList.Contains("Begin"))
            {
                HookedList.Add("Begin");
                On.FadeSequence.Begin += Begin;
            }
        }

        internal static event Delegates.Begin_BeforeArgs _beforeBegin;
        internal static event Delegates.Begin_AfterArgs _afterBegin;

        private static void Begin(On.FadeSequence.orig_Begin orig, FadeSequence self)
        {
            Delegates.Params_Begin @params = new()
            {
                self = self
            };
            if (_beforeBegin != null)
            {
                foreach (Delegates.Begin_BeforeArgs toInvoke in _beforeBegin.GetInvocationList())
                {
                    try
                    {
                        _beforeBegin?.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }
                }
            }

            self = @params.self;
            orig(self);
            if (_afterBegin != null)
            {
                foreach (Delegates.Begin_AfterArgs toInvoke in _afterBegin.GetInvocationList())
                {
                    try
                    {
                        _afterBegin.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }
                }
            }
        }

        internal static void HookUpdate()
        {
            if (!HookedList.Contains("Update"))
            {
                HookedList.Add("Update");
                On.FadeSequence.Update += Update;
            }
        }

        internal static event Delegates.Update_BeforeArgs _beforeUpdate;
        internal static event Delegates.Update_AfterArgs _afterUpdate;

        private static void Update(On.FadeSequence.orig_Update orig, FadeSequence self)
        {
            Delegates.Params_Update @params = new()
            {
                self = self
            };
            if (_beforeUpdate != null)
            {
                foreach (Delegates.Update_BeforeArgs toInvoke in _beforeUpdate.GetInvocationList())
                {
                    try
                    {
                        _beforeUpdate?.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }
                }
            }

            self = @params.self;
            orig(self);
            if (_afterUpdate != null)
            {
                foreach (Delegates.Update_AfterArgs toInvoke in _afterUpdate.GetInvocationList())
                {
                    try
                    {
                        _afterUpdate.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }
                }
            }
        }

        internal static void HookSkip()
        {
            if (!HookedList.Contains("Skip"))
            {
                HookedList.Add("Skip");
                On.FadeSequence.Skip += Skip;
            }
        }

        internal static event Delegates.Skip_BeforeArgs _beforeSkip;
        internal static event Delegates.Skip_AfterArgs _afterSkip;

        private static void Skip(On.FadeSequence.orig_Skip orig, FadeSequence self)
        {
            Delegates.Params_Skip @params = new()
            {
                self = self
            };
            if (_beforeSkip != null)
            {
                foreach (Delegates.Skip_BeforeArgs toInvoke in _beforeSkip.GetInvocationList())
                {
                    try
                    {
                        _beforeSkip?.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }
                }
            }

            self = @params.self;
            orig(self);
            if (_afterSkip != null)
            {
                foreach (Delegates.Skip_AfterArgs toInvoke in _afterSkip.GetInvocationList())
                {
                    try
                    {
                        _afterSkip.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }
                }
            }
        }

        internal static void HookUpdateFade()
        {
            if (!HookedList.Contains("UpdateFade"))
            {
                HookedList.Add("UpdateFade");
                On.FadeSequence.UpdateFade += UpdateFade;
            }
        }

        internal static event Delegates.UpdateFade_BeforeArgs _beforeUpdateFade;
        internal static event Delegates.UpdateFade_AfterArgs _afterUpdateFade;

        private static void UpdateFade(On.FadeSequence.orig_UpdateFade orig, FadeSequence self)
        {
            Delegates.Params_UpdateFade @params = new()
            {
                self = self
            };
            if (_beforeUpdateFade != null)
            {
                foreach (Delegates.UpdateFade_BeforeArgs toInvoke in _beforeUpdateFade.GetInvocationList())
                {
                    try
                    {
                        _beforeUpdateFade?.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }
                }
            }

            self = @params.self;
            orig(self);
            if (_afterUpdateFade != null)
            {
                foreach (Delegates.UpdateFade_AfterArgs toInvoke in _afterUpdateFade.GetInvocationList())
                {
                    try
                    {
                        _afterUpdateFade.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }
                }
            }
        }
    }

    /// <summary>
    /// Contains necessary information to create Hooks. Does not contain any hooks
    /// </summary>
    public static class Delegates
    {
        public sealed class Params_get_IsSkipped
        {
            public FadeSequence self;
        }

        public delegate void get_IsSkipped_BeforeArgs(Params_get_IsSkipped args);

        public delegate bool get_IsSkipped_AfterArgs(Params_get_IsSkipped args, bool ret);

        public delegate bool get_IsSkipped_WithArgs(Func<FadeSequence, bool> orig, FadeSequence self);

        public sealed class Params_get_FadeRate
        {
            public FadeSequence self;
        }

        public delegate void get_FadeRate_BeforeArgs(Params_get_FadeRate args);

        public delegate float get_FadeRate_AfterArgs(Params_get_FadeRate args, float ret);

        public delegate float get_FadeRate_WithArgs(Func<FadeSequence, float> orig, FadeSequence self);

        public sealed class Params_get_FadeByController
        {
            public FadeSequence self;
        }

        public delegate void get_FadeByController_BeforeArgs(Params_get_FadeByController args);

        public delegate float get_FadeByController_AfterArgs(Params_get_FadeByController args, float ret);

        public delegate float get_FadeByController_WithArgs(Func<FadeSequence, float> orig, FadeSequence self);

        public sealed class Params_set_FadeByController
        {
            public FadeSequence self;
            public float value;
        }

        public delegate void set_FadeByController_BeforeArgs(Params_set_FadeByController args);

        public delegate void set_FadeByController_AfterArgs(Params_set_FadeByController args);

        public delegate void set_FadeByController_WithArgs(Action<FadeSequence, float> orig, FadeSequence self,
            float value);

        public sealed class Params_get_IsPlaying
        {
            public FadeSequence self;
        }

        public delegate void get_IsPlaying_BeforeArgs(Params_get_IsPlaying args);

        public delegate bool get_IsPlaying_AfterArgs(Params_get_IsPlaying args, bool ret);

        public delegate bool get_IsPlaying_WithArgs(Func<FadeSequence, bool> orig, FadeSequence self);

        public sealed class Params_Awake
        {
            public FadeSequence self;
        }

        public delegate void Awake_BeforeArgs(Params_Awake args);

        public delegate void Awake_AfterArgs(Params_Awake args);

        public delegate void Awake_WithArgs(Action<FadeSequence> orig, FadeSequence self);

        public sealed class Params_Begin
        {
            public FadeSequence self;
        }

        public delegate void Begin_BeforeArgs(Params_Begin args);

        public delegate void Begin_AfterArgs(Params_Begin args);

        public delegate void Begin_WithArgs(Action<FadeSequence> orig, FadeSequence self);

        public sealed class Params_Update
        {
            public FadeSequence self;
        }

        public delegate void Update_BeforeArgs(Params_Update args);

        public delegate void Update_AfterArgs(Params_Update args);

        public delegate void Update_WithArgs(Action<FadeSequence> orig, FadeSequence self);

        public sealed class Params_Skip
        {
            public FadeSequence self;
        }

        public delegate void Skip_BeforeArgs(Params_Skip args);

        public delegate void Skip_AfterArgs(Params_Skip args);

        public delegate void Skip_WithArgs(Action<FadeSequence> orig, FadeSequence self);

        public sealed class Params_UpdateFade
        {
            public FadeSequence self;
        }

        public delegate void UpdateFade_BeforeArgs(Params_UpdateFade args);

        public delegate void UpdateFade_AfterArgs(Params_UpdateFade args);

        public delegate void UpdateFade_WithArgs(Action<FadeSequence> orig, FadeSequence self);
    }

    /// <summary>
    /// Contains Hooks to that run code before orig(self) is called
    /// </summary>
    public static class BeforeOrig
    {
        public static event Delegates.get_IsSkipped_BeforeArgs get_IsSkipped
        {
            add
            {
                HookHandler._beforeget_IsSkipped += value;
                HookHandler.Hookget_IsSkipped();
            }
            remove => HookHandler._beforeget_IsSkipped -= value;
        }

        public static event Delegates.get_FadeRate_BeforeArgs get_FadeRate
        {
            add
            {
                HookHandler._beforeget_FadeRate += value;
                HookHandler.Hookget_FadeRate();
            }
            remove => HookHandler._beforeget_FadeRate -= value;
        }

        public static event Delegates.get_FadeByController_BeforeArgs get_FadeByController
        {
            add
            {
                HookHandler._beforeget_FadeByController += value;
                HookHandler.Hookget_FadeByController();
            }
            remove => HookHandler._beforeget_FadeByController -= value;
        }

        public static event Delegates.set_FadeByController_BeforeArgs set_FadeByController
        {
            add
            {
                HookHandler._beforeset_FadeByController += value;
                HookHandler.Hookset_FadeByController();
            }
            remove => HookHandler._beforeset_FadeByController -= value;
        }

        public static event Delegates.get_IsPlaying_BeforeArgs get_IsPlaying
        {
            add
            {
                HookHandler._beforeget_IsPlaying += value;
                HookHandler.Hookget_IsPlaying();
            }
            remove => HookHandler._beforeget_IsPlaying -= value;
        }

        public static event Delegates.Awake_BeforeArgs Awake
        {
            add
            {
                HookHandler._beforeAwake += value;
                HookHandler.HookAwake();
            }
            remove => HookHandler._beforeAwake -= value;
        }

        public static event Delegates.Begin_BeforeArgs Begin
        {
            add
            {
                HookHandler._beforeBegin += value;
                HookHandler.HookBegin();
            }
            remove => HookHandler._beforeBegin -= value;
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

        public static event Delegates.Skip_BeforeArgs Skip
        {
            add
            {
                HookHandler._beforeSkip += value;
                HookHandler.HookSkip();
            }
            remove => HookHandler._beforeSkip -= value;
        }

        public static event Delegates.UpdateFade_BeforeArgs UpdateFade
        {
            add
            {
                HookHandler._beforeUpdateFade += value;
                HookHandler.HookUpdateFade();
            }
            remove => HookHandler._beforeUpdateFade -= value;
        }
    }

    /// <summary>
    /// Contains Hooks to that run code after orig(self) is called
    /// </summary>
    public static class AfterOrig
    {
        public static event Delegates.get_IsSkipped_AfterArgs get_IsSkipped
        {
            add
            {
                HookHandler._afterget_IsSkipped += value;
                HookHandler.Hookget_IsSkipped();
            }
            remove => HookHandler._afterget_IsSkipped -= value;
        }

        public static event Delegates.get_FadeRate_AfterArgs get_FadeRate
        {
            add
            {
                HookHandler._afterget_FadeRate += value;
                HookHandler.Hookget_FadeRate();
            }
            remove => HookHandler._afterget_FadeRate -= value;
        }

        public static event Delegates.get_FadeByController_AfterArgs get_FadeByController
        {
            add
            {
                HookHandler._afterget_FadeByController += value;
                HookHandler.Hookget_FadeByController();
            }
            remove => HookHandler._afterget_FadeByController -= value;
        }

        public static event Delegates.set_FadeByController_AfterArgs set_FadeByController
        {
            add
            {
                HookHandler._afterset_FadeByController += value;
                HookHandler.Hookset_FadeByController();
            }
            remove => HookHandler._afterset_FadeByController -= value;
        }

        public static event Delegates.get_IsPlaying_AfterArgs get_IsPlaying
        {
            add
            {
                HookHandler._afterget_IsPlaying += value;
                HookHandler.Hookget_IsPlaying();
            }
            remove => HookHandler._afterget_IsPlaying -= value;
        }

        public static event Delegates.Awake_AfterArgs Awake
        {
            add
            {
                HookHandler._afterAwake += value;
                HookHandler.HookAwake();
            }
            remove => HookHandler._afterAwake -= value;
        }

        public static event Delegates.Begin_AfterArgs Begin
        {
            add
            {
                HookHandler._afterBegin += value;
                HookHandler.HookBegin();
            }
            remove => HookHandler._afterBegin -= value;
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

        public static event Delegates.Skip_AfterArgs Skip
        {
            add
            {
                HookHandler._afterSkip += value;
                HookHandler.HookSkip();
            }
            remove => HookHandler._afterSkip -= value;
        }

        public static event Delegates.UpdateFade_AfterArgs UpdateFade
        {
            add
            {
                HookHandler._afterUpdateFade += value;
                HookHandler.HookUpdateFade();
            }
            remove => HookHandler._afterUpdateFade -= value;
        }
    }

    /// <summary>
    /// Contains all On Hooks, even those that aren't in the On namespace such as API generated functions and property getters/setters
    /// </summary>
    public static class WithOrig
    {
        public static event Delegates.get_IsSkipped_WithArgs get_IsSkipped
        {
            add => HookEndpointManager.Add<Delegates.get_IsSkipped_WithArgs>(
                ReflectionHelper.GetMethodInfo(typeof(FadeSequence), "get_IsSkipped", true), value);
            remove => HookEndpointManager.Remove<Delegates.get_IsSkipped_WithArgs>(
                ReflectionHelper.GetMethodInfo(typeof(FadeSequence), "get_IsSkipped", true), value);
        }

        public static event Delegates.get_FadeRate_WithArgs get_FadeRate
        {
            add => HookEndpointManager.Add<Delegates.get_FadeRate_WithArgs>(
                ReflectionHelper.GetMethodInfo(typeof(FadeSequence), "get_FadeRate", true), value);
            remove => HookEndpointManager.Remove<Delegates.get_FadeRate_WithArgs>(
                ReflectionHelper.GetMethodInfo(typeof(FadeSequence), "get_FadeRate", true), value);
        }

        public static event Delegates.get_FadeByController_WithArgs get_FadeByController
        {
            add => HookEndpointManager.Add<Delegates.get_FadeByController_WithArgs>(
                ReflectionHelper.GetMethodInfo(typeof(FadeSequence), "get_FadeByController", true), value);
            remove => HookEndpointManager.Remove<Delegates.get_FadeByController_WithArgs>(
                ReflectionHelper.GetMethodInfo(typeof(FadeSequence), "get_FadeByController", true), value);
        }

        public static event Delegates.set_FadeByController_WithArgs set_FadeByController
        {
            add => HookEndpointManager.Add<Delegates.set_FadeByController_WithArgs>(
                ReflectionHelper.GetMethodInfo(typeof(FadeSequence), "set_FadeByController", true), value);
            remove => HookEndpointManager.Remove<Delegates.set_FadeByController_WithArgs>(
                ReflectionHelper.GetMethodInfo(typeof(FadeSequence), "set_FadeByController", true), value);
        }

        public static event Delegates.get_IsPlaying_WithArgs get_IsPlaying
        {
            add => HookEndpointManager.Add<Delegates.get_IsPlaying_WithArgs>(
                ReflectionHelper.GetMethodInfo(typeof(FadeSequence), "get_IsPlaying", true), value);
            remove => HookEndpointManager.Remove<Delegates.get_IsPlaying_WithArgs>(
                ReflectionHelper.GetMethodInfo(typeof(FadeSequence), "get_IsPlaying", true), value);
        }

        public static event On.FadeSequence.hook_Awake Awake
        {
            add => On.FadeSequence.Awake += value;
            remove => On.FadeSequence.Awake -= value;
        }

        public static event On.FadeSequence.hook_Begin Begin
        {
            add => On.FadeSequence.Begin += value;
            remove => On.FadeSequence.Begin -= value;
        }

        public static event On.FadeSequence.hook_Update Update
        {
            add => On.FadeSequence.Update += value;
            remove => On.FadeSequence.Update -= value;
        }

        public static event On.FadeSequence.hook_Skip Skip
        {
            add => On.FadeSequence.Skip += value;
            remove => On.FadeSequence.Skip -= value;
        }

        public static event On.FadeSequence.hook_UpdateFade UpdateFade
        {
            add => On.FadeSequence.UpdateFade += value;
            remove => On.FadeSequence.UpdateFade -= value;
        }
    }
}