using MonoMod.RuntimeDetour;
using MonoMod.RuntimeDetour.HookGen;

namespace HKMirror.Hooks.OnHooks;

/// <summary>
/// Contains different types of On Hooks for DashEffect class.<br />
/// Contains hooks that aren't generated by monomod, and before and after orig hooks for easier hooking.
/// </summary>
public static class OnDashEffect
{
    internal static class HookHandler
    {
        private static List<string> HookedList = new List<string>();

        internal static void HookOnEnable()
        {
            if (!HookedList.Contains("OnEnable"))
            {
                HookedList.Add("OnEnable");
                On.DashEffect.OnEnable += OnEnable;
            }
        }

        internal static event Delegates.OnEnable_BeforeArgs _beforeOnEnable;
        internal static event Delegates.OnEnable_AfterArgs _afterOnEnable;

        private static void OnEnable(On.DashEffect.orig_OnEnable orig, DashEffect self)
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

        internal static void HookPlayDashPuff()
        {
            if (!HookedList.Contains("PlayDashPuff"))
            {
                HookedList.Add("PlayDashPuff");
                On.DashEffect.PlayDashPuff += PlayDashPuff;
            }
        }

        internal static event Delegates.PlayDashPuff_BeforeArgs _beforePlayDashPuff;
        internal static event Delegates.PlayDashPuff_AfterArgs _afterPlayDashPuff;

        private static void PlayDashPuff(On.DashEffect.orig_PlayDashPuff orig, DashEffect self)
        {
            Delegates.Params_PlayDashPuff @params = new()
            {
                self = self
            };
            if (_beforePlayDashPuff != null)
            {
                foreach (Delegates.PlayDashPuff_BeforeArgs toInvoke in _beforePlayDashPuff.GetInvocationList())
                {
                    try
                    {
                        _beforePlayDashPuff?.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }
                }
            }

            self = @params.self;
            orig(self);
            if (_afterPlayDashPuff != null)
            {
                foreach (Delegates.PlayDashPuff_AfterArgs toInvoke in _afterPlayDashPuff.GetInvocationList())
                {
                    try
                    {
                        _afterPlayDashPuff.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }
                }
            }
        }

        internal static void HookPlayDust()
        {
            if (!HookedList.Contains("PlayDust"))
            {
                HookedList.Add("PlayDust");
                On.DashEffect.PlayDust += PlayDust;
            }
        }

        internal static event Delegates.PlayDust_BeforeArgs _beforePlayDust;
        internal static event Delegates.PlayDust_AfterArgs _afterPlayDust;

        private static void PlayDust(On.DashEffect.orig_PlayDust orig, DashEffect self)
        {
            Delegates.Params_PlayDust @params = new()
            {
                self = self
            };
            if (_beforePlayDust != null)
            {
                foreach (Delegates.PlayDust_BeforeArgs toInvoke in _beforePlayDust.GetInvocationList())
                {
                    try
                    {
                        _beforePlayDust?.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }
                }
            }

            self = @params.self;
            orig(self);
            if (_afterPlayDust != null)
            {
                foreach (Delegates.PlayDust_AfterArgs toInvoke in _afterPlayDust.GetInvocationList())
                {
                    try
                    {
                        _afterPlayDust.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }
                }
            }
        }

        internal static void HookPlayGrass()
        {
            if (!HookedList.Contains("PlayGrass"))
            {
                HookedList.Add("PlayGrass");
                On.DashEffect.PlayGrass += PlayGrass;
            }
        }

        internal static event Delegates.PlayGrass_BeforeArgs _beforePlayGrass;
        internal static event Delegates.PlayGrass_AfterArgs _afterPlayGrass;

        private static void PlayGrass(On.DashEffect.orig_PlayGrass orig, DashEffect self)
        {
            Delegates.Params_PlayGrass @params = new()
            {
                self = self
            };
            if (_beforePlayGrass != null)
            {
                foreach (Delegates.PlayGrass_BeforeArgs toInvoke in _beforePlayGrass.GetInvocationList())
                {
                    try
                    {
                        _beforePlayGrass?.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }
                }
            }

            self = @params.self;
            orig(self);
            if (_afterPlayGrass != null)
            {
                foreach (Delegates.PlayGrass_AfterArgs toInvoke in _afterPlayGrass.GetInvocationList())
                {
                    try
                    {
                        _afterPlayGrass.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }
                }
            }
        }

        internal static void HookPlayBone()
        {
            if (!HookedList.Contains("PlayBone"))
            {
                HookedList.Add("PlayBone");
                On.DashEffect.PlayBone += PlayBone;
            }
        }

        internal static event Delegates.PlayBone_BeforeArgs _beforePlayBone;
        internal static event Delegates.PlayBone_AfterArgs _afterPlayBone;

        private static void PlayBone(On.DashEffect.orig_PlayBone orig, DashEffect self)
        {
            Delegates.Params_PlayBone @params = new()
            {
                self = self
            };
            if (_beforePlayBone != null)
            {
                foreach (Delegates.PlayBone_BeforeArgs toInvoke in _beforePlayBone.GetInvocationList())
                {
                    try
                    {
                        _beforePlayBone?.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }
                }
            }

            self = @params.self;
            orig(self);
            if (_afterPlayBone != null)
            {
                foreach (Delegates.PlayBone_AfterArgs toInvoke in _afterPlayBone.GetInvocationList())
                {
                    try
                    {
                        _afterPlayBone.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }
                }
            }
        }

        internal static void HookPlaySpaEffects()
        {
            if (!HookedList.Contains("PlaySpaEffects"))
            {
                HookedList.Add("PlaySpaEffects");
                On.DashEffect.PlaySpaEffects += PlaySpaEffects;
            }
        }

        internal static event Delegates.PlaySpaEffects_BeforeArgs _beforePlaySpaEffects;
        internal static event Delegates.PlaySpaEffects_AfterArgs _afterPlaySpaEffects;

        private static void PlaySpaEffects(On.DashEffect.orig_PlaySpaEffects orig, DashEffect self)
        {
            Delegates.Params_PlaySpaEffects @params = new()
            {
                self = self
            };
            if (_beforePlaySpaEffects != null)
            {
                foreach (Delegates.PlaySpaEffects_BeforeArgs toInvoke in _beforePlaySpaEffects.GetInvocationList())
                {
                    try
                    {
                        _beforePlaySpaEffects?.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }
                }
            }

            self = @params.self;
            orig(self);
            if (_afterPlaySpaEffects != null)
            {
                foreach (Delegates.PlaySpaEffects_AfterArgs toInvoke in _afterPlaySpaEffects.GetInvocationList())
                {
                    try
                    {
                        _afterPlaySpaEffects.Invoke(@params);
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
                On.DashEffect.Update += Update;
            }
        }

        internal static event Delegates.Update_BeforeArgs _beforeUpdate;
        internal static event Delegates.Update_AfterArgs _afterUpdate;

        private static void Update(On.DashEffect.orig_Update orig, DashEffect self)
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
    }

    /// <summary>
    /// Contains necessary information to create Hooks. Does not contain any hooks
    /// </summary>
    public static class Delegates
    {
        public sealed class Params_OnEnable
        {
            public DashEffect self;
        }

        public delegate void OnEnable_BeforeArgs(Params_OnEnable args);

        public delegate void OnEnable_AfterArgs(Params_OnEnable args);

        public delegate void OnEnable_WithArgs(Action<DashEffect> orig, DashEffect self);

        public sealed class Params_PlayDashPuff
        {
            public DashEffect self;
        }

        public delegate void PlayDashPuff_BeforeArgs(Params_PlayDashPuff args);

        public delegate void PlayDashPuff_AfterArgs(Params_PlayDashPuff args);

        public delegate void PlayDashPuff_WithArgs(Action<DashEffect> orig, DashEffect self);

        public sealed class Params_PlayDust
        {
            public DashEffect self;
        }

        public delegate void PlayDust_BeforeArgs(Params_PlayDust args);

        public delegate void PlayDust_AfterArgs(Params_PlayDust args);

        public delegate void PlayDust_WithArgs(Action<DashEffect> orig, DashEffect self);

        public sealed class Params_PlayGrass
        {
            public DashEffect self;
        }

        public delegate void PlayGrass_BeforeArgs(Params_PlayGrass args);

        public delegate void PlayGrass_AfterArgs(Params_PlayGrass args);

        public delegate void PlayGrass_WithArgs(Action<DashEffect> orig, DashEffect self);

        public sealed class Params_PlayBone
        {
            public DashEffect self;
        }

        public delegate void PlayBone_BeforeArgs(Params_PlayBone args);

        public delegate void PlayBone_AfterArgs(Params_PlayBone args);

        public delegate void PlayBone_WithArgs(Action<DashEffect> orig, DashEffect self);

        public sealed class Params_PlaySpaEffects
        {
            public DashEffect self;
        }

        public delegate void PlaySpaEffects_BeforeArgs(Params_PlaySpaEffects args);

        public delegate void PlaySpaEffects_AfterArgs(Params_PlaySpaEffects args);

        public delegate void PlaySpaEffects_WithArgs(Action<DashEffect> orig, DashEffect self);

        public sealed class Params_Update
        {
            public DashEffect self;
        }

        public delegate void Update_BeforeArgs(Params_Update args);

        public delegate void Update_AfterArgs(Params_Update args);

        public delegate void Update_WithArgs(Action<DashEffect> orig, DashEffect self);
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

        public static event Delegates.PlayDashPuff_BeforeArgs PlayDashPuff
        {
            add
            {
                HookHandler._beforePlayDashPuff += value;
                HookHandler.HookPlayDashPuff();
            }
            remove => HookHandler._beforePlayDashPuff -= value;
        }

        public static event Delegates.PlayDust_BeforeArgs PlayDust
        {
            add
            {
                HookHandler._beforePlayDust += value;
                HookHandler.HookPlayDust();
            }
            remove => HookHandler._beforePlayDust -= value;
        }

        public static event Delegates.PlayGrass_BeforeArgs PlayGrass
        {
            add
            {
                HookHandler._beforePlayGrass += value;
                HookHandler.HookPlayGrass();
            }
            remove => HookHandler._beforePlayGrass -= value;
        }

        public static event Delegates.PlayBone_BeforeArgs PlayBone
        {
            add
            {
                HookHandler._beforePlayBone += value;
                HookHandler.HookPlayBone();
            }
            remove => HookHandler._beforePlayBone -= value;
        }

        public static event Delegates.PlaySpaEffects_BeforeArgs PlaySpaEffects
        {
            add
            {
                HookHandler._beforePlaySpaEffects += value;
                HookHandler.HookPlaySpaEffects();
            }
            remove => HookHandler._beforePlaySpaEffects -= value;
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

        public static event Delegates.PlayDashPuff_AfterArgs PlayDashPuff
        {
            add
            {
                HookHandler._afterPlayDashPuff += value;
                HookHandler.HookPlayDashPuff();
            }
            remove => HookHandler._afterPlayDashPuff -= value;
        }

        public static event Delegates.PlayDust_AfterArgs PlayDust
        {
            add
            {
                HookHandler._afterPlayDust += value;
                HookHandler.HookPlayDust();
            }
            remove => HookHandler._afterPlayDust -= value;
        }

        public static event Delegates.PlayGrass_AfterArgs PlayGrass
        {
            add
            {
                HookHandler._afterPlayGrass += value;
                HookHandler.HookPlayGrass();
            }
            remove => HookHandler._afterPlayGrass -= value;
        }

        public static event Delegates.PlayBone_AfterArgs PlayBone
        {
            add
            {
                HookHandler._afterPlayBone += value;
                HookHandler.HookPlayBone();
            }
            remove => HookHandler._afterPlayBone -= value;
        }

        public static event Delegates.PlaySpaEffects_AfterArgs PlaySpaEffects
        {
            add
            {
                HookHandler._afterPlaySpaEffects += value;
                HookHandler.HookPlaySpaEffects();
            }
            remove => HookHandler._afterPlaySpaEffects -= value;
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
    }

    /// <summary>
    /// Contains all On Hooks, even those that aren't in the On namespace such as API generated functions and property getters/setters
    /// </summary>
    public static class WithOrig
    {
        public static event On.DashEffect.hook_OnEnable OnEnable
        {
            add => On.DashEffect.OnEnable += value;
            remove => On.DashEffect.OnEnable -= value;
        }

        public static event On.DashEffect.hook_PlayDashPuff PlayDashPuff
        {
            add => On.DashEffect.PlayDashPuff += value;
            remove => On.DashEffect.PlayDashPuff -= value;
        }

        public static event On.DashEffect.hook_PlayDust PlayDust
        {
            add => On.DashEffect.PlayDust += value;
            remove => On.DashEffect.PlayDust -= value;
        }

        public static event On.DashEffect.hook_PlayGrass PlayGrass
        {
            add => On.DashEffect.PlayGrass += value;
            remove => On.DashEffect.PlayGrass -= value;
        }

        public static event On.DashEffect.hook_PlayBone PlayBone
        {
            add => On.DashEffect.PlayBone += value;
            remove => On.DashEffect.PlayBone -= value;
        }

        public static event On.DashEffect.hook_PlaySpaEffects PlaySpaEffects
        {
            add => On.DashEffect.PlaySpaEffects += value;
            remove => On.DashEffect.PlaySpaEffects -= value;
        }

        public static event On.DashEffect.hook_Update Update
        {
            add => On.DashEffect.Update += value;
            remove => On.DashEffect.Update -= value;
        }
    }
}