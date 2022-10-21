using MonoMod.RuntimeDetour;
using MonoMod.RuntimeDetour.HookGen;

namespace HKMirror.Hooks.OnHooks;

/// <summary>
/// Contains different types of On Hooks for BrokenVesselGlob class.<br />
/// Contains hooks that aren't generated by monomod, and before and after orig hooks for easier hooking.
/// </summary>
public static class OnBrokenVesselGlob
{
    internal static class HookHandler
    {
        private static List<string> HookedList = new List<string>();

        internal static void HookOnEnable()
        {
            if (!HookedList.Contains("OnEnable"))
            {
                HookedList.Add("OnEnable");
                On.BrokenVesselGlob.OnEnable += OnEnable;
            }
        }

        internal static event Delegates.OnEnable_BeforeArgs _beforeOnEnable;
        internal static event Delegates.OnEnable_AfterArgs _afterOnEnable;

        private static void OnEnable(On.BrokenVesselGlob.orig_OnEnable orig, BrokenVesselGlob self)
        {
            Delegates.Params_OnEnable @params = new()
            {
                self = self
            };
            if (_beforeOnEnable != null)
            {
                foreach (Delegates.OnEnable_BeforeArgs toInvoke in _beforeOnEnable.GetInvocationList())
                {
                    try
                    {
                        _beforeOnEnable?.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }
                }
            }

            self = @params.self;
            orig(self);
            if (_afterOnEnable != null)
            {
                foreach (Delegates.OnEnable_AfterArgs toInvoke in _afterOnEnable.GetInvocationList())
                {
                    try
                    {
                        _afterOnEnable.Invoke(@params);
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
                On.BrokenVesselGlob.Update += Update;
            }
        }

        internal static event Delegates.Update_BeforeArgs _beforeUpdate;
        internal static event Delegates.Update_AfterArgs _afterUpdate;

        private static void Update(On.BrokenVesselGlob.orig_Update orig, BrokenVesselGlob self)
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

        internal static void HookFixedUpdate()
        {
            if (!HookedList.Contains("FixedUpdate"))
            {
                HookedList.Add("FixedUpdate");
                On.BrokenVesselGlob.FixedUpdate += FixedUpdate;
            }
        }

        internal static event Delegates.FixedUpdate_BeforeArgs _beforeFixedUpdate;
        internal static event Delegates.FixedUpdate_AfterArgs _afterFixedUpdate;

        private static void FixedUpdate(On.BrokenVesselGlob.orig_FixedUpdate orig, BrokenVesselGlob self)
        {
            Delegates.Params_FixedUpdate @params = new()
            {
                self = self
            };
            if (_beforeFixedUpdate != null)
            {
                foreach (Delegates.FixedUpdate_BeforeArgs toInvoke in _beforeFixedUpdate.GetInvocationList())
                {
                    try
                    {
                        _beforeFixedUpdate?.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }
                }
            }

            self = @params.self;
            orig(self);
            if (_afterFixedUpdate != null)
            {
                foreach (Delegates.FixedUpdate_AfterArgs toInvoke in _afterFixedUpdate.GetInvocationList())
                {
                    try
                    {
                        _afterFixedUpdate.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }
                }
            }
        }

        internal static void HookFaceAngle()
        {
            if (!HookedList.Contains("FaceAngle"))
            {
                HookedList.Add("FaceAngle");
                On.BrokenVesselGlob.FaceAngle += FaceAngle;
            }
        }

        internal static event Delegates.FaceAngle_BeforeArgs _beforeFaceAngle;
        internal static event Delegates.FaceAngle_AfterArgs _afterFaceAngle;

        private static void FaceAngle(On.BrokenVesselGlob.orig_FaceAngle orig, BrokenVesselGlob self)
        {
            Delegates.Params_FaceAngle @params = new()
            {
                self = self
            };
            if (_beforeFaceAngle != null)
            {
                foreach (Delegates.FaceAngle_BeforeArgs toInvoke in _beforeFaceAngle.GetInvocationList())
                {
                    try
                    {
                        _beforeFaceAngle?.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }
                }
            }

            self = @params.self;
            orig(self);
            if (_afterFaceAngle != null)
            {
                foreach (Delegates.FaceAngle_AfterArgs toInvoke in _afterFaceAngle.GetInvocationList())
                {
                    try
                    {
                        _afterFaceAngle.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }
                }
            }
        }

        internal static void HookProjectileSquash()
        {
            if (!HookedList.Contains("ProjectileSquash"))
            {
                HookedList.Add("ProjectileSquash");
                On.BrokenVesselGlob.ProjectileSquash += ProjectileSquash;
            }
        }

        internal static event Delegates.ProjectileSquash_BeforeArgs _beforeProjectileSquash;
        internal static event Delegates.ProjectileSquash_AfterArgs _afterProjectileSquash;

        private static void ProjectileSquash(On.BrokenVesselGlob.orig_ProjectileSquash orig, BrokenVesselGlob self)
        {
            Delegates.Params_ProjectileSquash @params = new()
            {
                self = self
            };
            if (_beforeProjectileSquash != null)
            {
                foreach (Delegates.ProjectileSquash_BeforeArgs toInvoke in _beforeProjectileSquash.GetInvocationList())
                {
                    try
                    {
                        _beforeProjectileSquash?.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }
                }
            }

            self = @params.self;
            orig(self);
            if (_afterProjectileSquash != null)
            {
                foreach (Delegates.ProjectileSquash_AfterArgs toInvoke in _afterProjectileSquash.GetInvocationList())
                {
                    try
                    {
                        _afterProjectileSquash.Invoke(@params);
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
        public sealed class Params_OnEnable
        {
            public BrokenVesselGlob self;
        }

        public delegate void OnEnable_BeforeArgs(Params_OnEnable args);

        public delegate void OnEnable_AfterArgs(Params_OnEnable args);

        public delegate void OnEnable_WithArgs(Action<BrokenVesselGlob> orig, BrokenVesselGlob self);

        public sealed class Params_Update
        {
            public BrokenVesselGlob self;
        }

        public delegate void Update_BeforeArgs(Params_Update args);

        public delegate void Update_AfterArgs(Params_Update args);

        public delegate void Update_WithArgs(Action<BrokenVesselGlob> orig, BrokenVesselGlob self);

        public sealed class Params_FixedUpdate
        {
            public BrokenVesselGlob self;
        }

        public delegate void FixedUpdate_BeforeArgs(Params_FixedUpdate args);

        public delegate void FixedUpdate_AfterArgs(Params_FixedUpdate args);

        public delegate void FixedUpdate_WithArgs(Action<BrokenVesselGlob> orig, BrokenVesselGlob self);

        public sealed class Params_FaceAngle
        {
            public BrokenVesselGlob self;
        }

        public delegate void FaceAngle_BeforeArgs(Params_FaceAngle args);

        public delegate void FaceAngle_AfterArgs(Params_FaceAngle args);

        public delegate void FaceAngle_WithArgs(Action<BrokenVesselGlob> orig, BrokenVesselGlob self);

        public sealed class Params_ProjectileSquash
        {
            public BrokenVesselGlob self;
        }

        public delegate void ProjectileSquash_BeforeArgs(Params_ProjectileSquash args);

        public delegate void ProjectileSquash_AfterArgs(Params_ProjectileSquash args);

        public delegate void ProjectileSquash_WithArgs(Action<BrokenVesselGlob> orig, BrokenVesselGlob self);
    }

    /// <summary>
    /// Contains Hooks to that run code before orig(self) is called
    /// </summary>
    public static class BeforeOrig
    {
        public static event Delegates.OnEnable_BeforeArgs OnEnable
        {
            add
            {
                HookHandler._beforeOnEnable += value;
                HookHandler.HookOnEnable();
            }
            remove => HookHandler._beforeOnEnable -= value;
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

        public static event Delegates.FixedUpdate_BeforeArgs FixedUpdate
        {
            add
            {
                HookHandler._beforeFixedUpdate += value;
                HookHandler.HookFixedUpdate();
            }
            remove => HookHandler._beforeFixedUpdate -= value;
        }

        public static event Delegates.FaceAngle_BeforeArgs FaceAngle
        {
            add
            {
                HookHandler._beforeFaceAngle += value;
                HookHandler.HookFaceAngle();
            }
            remove => HookHandler._beforeFaceAngle -= value;
        }

        public static event Delegates.ProjectileSquash_BeforeArgs ProjectileSquash
        {
            add
            {
                HookHandler._beforeProjectileSquash += value;
                HookHandler.HookProjectileSquash();
            }
            remove => HookHandler._beforeProjectileSquash -= value;
        }
    }

    /// <summary>
    /// Contains Hooks to that run code after orig(self) is called
    /// </summary>
    public static class AfterOrig
    {
        public static event Delegates.OnEnable_AfterArgs OnEnable
        {
            add
            {
                HookHandler._afterOnEnable += value;
                HookHandler.HookOnEnable();
            }
            remove => HookHandler._afterOnEnable -= value;
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

        public static event Delegates.FixedUpdate_AfterArgs FixedUpdate
        {
            add
            {
                HookHandler._afterFixedUpdate += value;
                HookHandler.HookFixedUpdate();
            }
            remove => HookHandler._afterFixedUpdate -= value;
        }

        public static event Delegates.FaceAngle_AfterArgs FaceAngle
        {
            add
            {
                HookHandler._afterFaceAngle += value;
                HookHandler.HookFaceAngle();
            }
            remove => HookHandler._afterFaceAngle -= value;
        }

        public static event Delegates.ProjectileSquash_AfterArgs ProjectileSquash
        {
            add
            {
                HookHandler._afterProjectileSquash += value;
                HookHandler.HookProjectileSquash();
            }
            remove => HookHandler._afterProjectileSquash -= value;
        }
    }

    /// <summary>
    /// Contains all On Hooks, even those that aren't in the On namespace such as API generated functions and property getters/setters
    /// </summary>
    public static class WithOrig
    {
        public static event On.BrokenVesselGlob.hook_OnEnable OnEnable
        {
            add => On.BrokenVesselGlob.OnEnable += value;
            remove => On.BrokenVesselGlob.OnEnable -= value;
        }

        public static event On.BrokenVesselGlob.hook_Update Update
        {
            add => On.BrokenVesselGlob.Update += value;
            remove => On.BrokenVesselGlob.Update -= value;
        }

        public static event On.BrokenVesselGlob.hook_FixedUpdate FixedUpdate
        {
            add => On.BrokenVesselGlob.FixedUpdate += value;
            remove => On.BrokenVesselGlob.FixedUpdate -= value;
        }

        public static event On.BrokenVesselGlob.hook_FaceAngle FaceAngle
        {
            add => On.BrokenVesselGlob.FaceAngle += value;
            remove => On.BrokenVesselGlob.FaceAngle -= value;
        }

        public static event On.BrokenVesselGlob.hook_ProjectileSquash ProjectileSquash
        {
            add => On.BrokenVesselGlob.ProjectileSquash += value;
            remove => On.BrokenVesselGlob.ProjectileSquash -= value;
        }
    }
}