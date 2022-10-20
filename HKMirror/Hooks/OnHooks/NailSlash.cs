using MonoMod.RuntimeDetour;
using MonoMod.RuntimeDetour.HookGen;

namespace HKMirror.Hooks.OnHooks;

/// <summary>
///     Contains different types of On Hooks for NailSlash class.<br />
///     Contains hooks that aren't generated by monomod, and before and after orig hooks for easier hooking.
/// </summary>
public static class OnNailSlash
{
    internal static class HookHandler
    {
        private static readonly List<string> HookedList = new();

        internal static void HookAwake()
        {
            if (!HookedList.Contains("Awake"))
            {
                HookedList.Add("Awake");
                On.NailSlash.Awake += Awake;
            }
        }

        internal static event Delegates.Awake_BeforeArgs _beforeAwake;
        internal static event Delegates.Awake_NormalArgs _afterAwake;

        private static void Awake(On.NailSlash.orig_Awake orig, NailSlash self)
        {
            Delegates.Params_Awake @params = new()
            {
                self = self
            };
            _beforeAwake?.Invoke(@params);
            self = @params.self;
            orig(self);
            if (_afterAwake != null) _afterAwake.Invoke(@params);
        }

        internal static void HookStartSlash()
        {
            if (!HookedList.Contains("StartSlash"))
            {
                HookedList.Add("StartSlash");
                On.NailSlash.StartSlash += StartSlash;
            }
        }

        internal static event Delegates.StartSlash_BeforeArgs _beforeStartSlash;
        internal static event Delegates.StartSlash_NormalArgs _afterStartSlash;

        private static void StartSlash(On.NailSlash.orig_StartSlash orig, NailSlash self)
        {
            Delegates.Params_StartSlash @params = new()
            {
                self = self
            };
            _beforeStartSlash?.Invoke(@params);
            self = @params.self;
            orig(self);
            if (_afterStartSlash != null) _afterStartSlash.Invoke(@params);
        }

        internal static void HookFixedUpdate()
        {
            if (!HookedList.Contains("FixedUpdate"))
            {
                HookedList.Add("FixedUpdate");
                On.NailSlash.FixedUpdate += FixedUpdate;
            }
        }

        internal static event Delegates.FixedUpdate_BeforeArgs _beforeFixedUpdate;
        internal static event Delegates.FixedUpdate_NormalArgs _afterFixedUpdate;

        private static void FixedUpdate(On.NailSlash.orig_FixedUpdate orig, NailSlash self)
        {
            Delegates.Params_FixedUpdate @params = new()
            {
                self = self
            };
            _beforeFixedUpdate?.Invoke(@params);
            self = @params.self;
            orig(self);
            if (_afterFixedUpdate != null) _afterFixedUpdate.Invoke(@params);
        }

        internal static void HookOnTriggerEnter2D()
        {
            if (!HookedList.Contains("OnTriggerEnter2D"))
            {
                HookedList.Add("OnTriggerEnter2D");
                On.NailSlash.OnTriggerEnter2D += OnTriggerEnter2D;
            }
        }

        internal static event Delegates.OnTriggerEnter2D_BeforeArgs _beforeOnTriggerEnter2D;
        internal static event Delegates.OnTriggerEnter2D_NormalArgs _afterOnTriggerEnter2D;

        private static void OnTriggerEnter2D(On.NailSlash.orig_OnTriggerEnter2D orig, NailSlash self,
            Collider2D otherCollider)
        {
            Delegates.Params_OnTriggerEnter2D @params = new()
            {
                self = self, otherCollider = otherCollider
            };
            _beforeOnTriggerEnter2D?.Invoke(@params);
            self = @params.self;
            otherCollider = @params.otherCollider;
            orig(self, otherCollider);
            if (_afterOnTriggerEnter2D != null) _afterOnTriggerEnter2D.Invoke(@params);
        }

        internal static void HookBounce()
        {
            if (!HookedList.Contains("Bounce"))
            {
                HookedList.Add("Bounce");
                On.NailSlash.Bounce += Bounce;
            }
        }

        internal static event Delegates.Bounce_BeforeArgs _beforeBounce;
        internal static event Delegates.Bounce_NormalArgs _afterBounce;

        private static void Bounce(On.NailSlash.orig_Bounce orig, NailSlash self, Collider2D otherCollider,
            bool useEffects)
        {
            Delegates.Params_Bounce @params = new()
            {
                self = self, otherCollider = otherCollider, useEffects = useEffects
            };
            _beforeBounce?.Invoke(@params);
            self = @params.self;
            otherCollider = @params.otherCollider;
            useEffects = @params.useEffects;
            orig(self, otherCollider, useEffects);
            if (_afterBounce != null) _afterBounce.Invoke(@params);
        }

        internal static void HookOnTriggerStay2D()
        {
            if (!HookedList.Contains("OnTriggerStay2D"))
            {
                HookedList.Add("OnTriggerStay2D");
                On.NailSlash.OnTriggerStay2D += OnTriggerStay2D;
            }
        }

        internal static event Delegates.OnTriggerStay2D_BeforeArgs _beforeOnTriggerStay2D;
        internal static event Delegates.OnTriggerStay2D_NormalArgs _afterOnTriggerStay2D;

        private static void OnTriggerStay2D(On.NailSlash.orig_OnTriggerStay2D orig, NailSlash self,
            Collider2D otherCollider)
        {
            Delegates.Params_OnTriggerStay2D @params = new()
            {
                self = self, otherCollider = otherCollider
            };
            _beforeOnTriggerStay2D?.Invoke(@params);
            self = @params.self;
            otherCollider = @params.otherCollider;
            orig(self, otherCollider);
            if (_afterOnTriggerStay2D != null) _afterOnTriggerStay2D.Invoke(@params);
        }

        internal static void HookDisable()
        {
            if (!HookedList.Contains("Disable"))
            {
                HookedList.Add("Disable");
                On.NailSlash.Disable += Disable;
            }
        }

        internal static event Delegates.Disable_BeforeArgs _beforeDisable;
        internal static event Delegates.Disable_NormalArgs _afterDisable;

        private static void Disable(On.NailSlash.orig_Disable orig, NailSlash self, tk2dSpriteAnimator sprite,
            tk2dSpriteAnimationClip clip)
        {
            Delegates.Params_Disable @params = new()
            {
                self = self, sprite = sprite, clip = clip
            };
            _beforeDisable?.Invoke(@params);
            self = @params.self;
            sprite = @params.sprite;
            clip = @params.clip;
            orig(self, sprite, clip);
            if (_afterDisable != null) _afterDisable.Invoke(@params);
        }

        internal static void HookSetLongnail()
        {
            if (!HookedList.Contains("SetLongnail"))
            {
                HookedList.Add("SetLongnail");
                On.NailSlash.SetLongnail += SetLongnail;
            }
        }

        internal static event Delegates.SetLongnail_BeforeArgs _beforeSetLongnail;
        internal static event Delegates.SetLongnail_NormalArgs _afterSetLongnail;

        private static void SetLongnail(On.NailSlash.orig_SetLongnail orig, NailSlash self, bool set)
        {
            Delegates.Params_SetLongnail @params = new()
            {
                self = self, set = set
            };
            _beforeSetLongnail?.Invoke(@params);
            self = @params.self;
            set = @params.set;
            orig(self, set);
            if (_afterSetLongnail != null) _afterSetLongnail.Invoke(@params);
        }

        internal static void HookSetMantis()
        {
            if (!HookedList.Contains("SetMantis"))
            {
                HookedList.Add("SetMantis");
                On.NailSlash.SetMantis += SetMantis;
            }
        }

        internal static event Delegates.SetMantis_BeforeArgs _beforeSetMantis;
        internal static event Delegates.SetMantis_NormalArgs _afterSetMantis;

        private static void SetMantis(On.NailSlash.orig_SetMantis orig, NailSlash self, bool set)
        {
            Delegates.Params_SetMantis @params = new()
            {
                self = self, set = set
            };
            _beforeSetMantis?.Invoke(@params);
            self = @params.self;
            set = @params.set;
            orig(self, set);
            if (_afterSetMantis != null) _afterSetMantis.Invoke(@params);
        }

        internal static void HookSetFury()
        {
            if (!HookedList.Contains("SetFury"))
            {
                HookedList.Add("SetFury");
                On.NailSlash.SetFury += SetFury;
            }
        }

        internal static event Delegates.SetFury_BeforeArgs _beforeSetFury;
        internal static event Delegates.SetFury_NormalArgs _afterSetFury;

        private static void SetFury(On.NailSlash.orig_SetFury orig, NailSlash self, bool set)
        {
            Delegates.Params_SetFury @params = new()
            {
                self = self, set = set
            };
            _beforeSetFury?.Invoke(@params);
            self = @params.self;
            set = @params.set;
            orig(self, set);
            if (_afterSetFury != null) _afterSetFury.Invoke(@params);
        }

        internal static void HookCancelAttack()
        {
            if (!HookedList.Contains("CancelAttack"))
            {
                HookedList.Add("CancelAttack");
                On.NailSlash.CancelAttack += CancelAttack;
            }
        }

        internal static event Delegates.CancelAttack_BeforeArgs _beforeCancelAttack;
        internal static event Delegates.CancelAttack_NormalArgs _afterCancelAttack;

        private static void CancelAttack(On.NailSlash.orig_CancelAttack orig, NailSlash self)
        {
            Delegates.Params_CancelAttack @params = new()
            {
                self = self
            };
            _beforeCancelAttack?.Invoke(@params);
            self = @params.self;
            orig(self);
            if (_afterCancelAttack != null) _afterCancelAttack.Invoke(@params);
        }

        internal static void Hookorig_OnTriggerEnter2D()
        {
            if (!HookedList.Contains("orig_OnTriggerEnter2D"))
            {
                HookedList.Add("orig_OnTriggerEnter2D");
                new Hook(ReflectionHelper.GetMethodInfo(typeof(NailSlash), "orig_OnTriggerEnter2D"),
                    orig_OnTriggerEnter2D);
            }
        }

        internal static event Delegates.orig_OnTriggerEnter2D_BeforeArgs _beforeorig_OnTriggerEnter2D;
        internal static event Delegates.orig_OnTriggerEnter2D_NormalArgs _afterorig_OnTriggerEnter2D;

        private static void orig_OnTriggerEnter2D(Action<NailSlash, Collider2D> orig, NailSlash self,
            Collider2D otherCollider)
        {
            Delegates.Params_orig_OnTriggerEnter2D @params = new()
            {
                self = self, otherCollider = otherCollider
            };
            _beforeorig_OnTriggerEnter2D?.Invoke(@params);
            self = @params.self;
            otherCollider = @params.otherCollider;
            orig(self, otherCollider);
            if (_afterorig_OnTriggerEnter2D != null) _afterorig_OnTriggerEnter2D.Invoke(@params);
        }
    }

    /// <summary>
    ///     Contains necessary information to create Hooks. Does not contain any hooks
    /// </summary>
    public static class Delegates
    {
        public delegate void Awake_BeforeArgs(Params_Awake args);

        public delegate void Awake_NormalArgs(Params_Awake args);

        public delegate void Bounce_BeforeArgs(Params_Bounce args);

        public delegate void Bounce_NormalArgs(Params_Bounce args);

        public delegate void CancelAttack_BeforeArgs(Params_CancelAttack args);

        public delegate void CancelAttack_NormalArgs(Params_CancelAttack args);

        public delegate void Disable_BeforeArgs(Params_Disable args);

        public delegate void Disable_NormalArgs(Params_Disable args);

        public delegate void FixedUpdate_BeforeArgs(Params_FixedUpdate args);

        public delegate void FixedUpdate_NormalArgs(Params_FixedUpdate args);

        public delegate void OnTriggerEnter2D_BeforeArgs(Params_OnTriggerEnter2D args);

        public delegate void OnTriggerEnter2D_NormalArgs(Params_OnTriggerEnter2D args);

        public delegate void OnTriggerStay2D_BeforeArgs(Params_OnTriggerStay2D args);

        public delegate void OnTriggerStay2D_NormalArgs(Params_OnTriggerStay2D args);

        public delegate void orig_OnTriggerEnter2D_BeforeArgs(Params_orig_OnTriggerEnter2D args);

        public delegate void orig_OnTriggerEnter2D_NormalArgs(Params_orig_OnTriggerEnter2D args);

        public delegate void SetFury_BeforeArgs(Params_SetFury args);

        public delegate void SetFury_NormalArgs(Params_SetFury args);

        public delegate void SetLongnail_BeforeArgs(Params_SetLongnail args);

        public delegate void SetLongnail_NormalArgs(Params_SetLongnail args);

        public delegate void SetMantis_BeforeArgs(Params_SetMantis args);

        public delegate void SetMantis_NormalArgs(Params_SetMantis args);

        public delegate void StartSlash_BeforeArgs(Params_StartSlash args);

        public delegate void StartSlash_NormalArgs(Params_StartSlash args);

        public sealed class Params_Awake
        {
            public NailSlash self;
        }

        public sealed class Params_StartSlash
        {
            public NailSlash self;
        }

        public sealed class Params_FixedUpdate
        {
            public NailSlash self;
        }

        public sealed class Params_OnTriggerEnter2D
        {
            public Collider2D otherCollider;
            public NailSlash self;
        }

        public sealed class Params_Bounce
        {
            public Collider2D otherCollider;
            public NailSlash self;
            public bool useEffects;
        }

        public sealed class Params_OnTriggerStay2D
        {
            public Collider2D otherCollider;
            public NailSlash self;
        }

        public sealed class Params_Disable
        {
            public tk2dSpriteAnimationClip clip;
            public NailSlash self;
            public tk2dSpriteAnimator sprite;
        }

        public sealed class Params_SetLongnail
        {
            public NailSlash self;
            public bool set;
        }

        public sealed class Params_SetMantis
        {
            public NailSlash self;
            public bool set;
        }

        public sealed class Params_SetFury
        {
            public NailSlash self;
            public bool set;
        }

        public sealed class Params_CancelAttack
        {
            public NailSlash self;
        }

        public sealed class Params_orig_OnTriggerEnter2D
        {
            public Collider2D otherCollider;
            public NailSlash self;
        }
    }

    /// <summary>
    ///     Contains Hooks to that run code before orig(self) is called
    /// </summary>
    public static class BeforeOrig
    {
        public static event Delegates.Awake_BeforeArgs Awake
        {
            add
            {
                HookHandler._beforeAwake += value;
                HookHandler.HookAwake();
            }
            remove => HookHandler._beforeAwake -= value;
        }

        public static event Delegates.StartSlash_BeforeArgs StartSlash
        {
            add
            {
                HookHandler._beforeStartSlash += value;
                HookHandler.HookStartSlash();
            }
            remove => HookHandler._beforeStartSlash -= value;
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

        public static event Delegates.OnTriggerEnter2D_BeforeArgs OnTriggerEnter2D
        {
            add
            {
                HookHandler._beforeOnTriggerEnter2D += value;
                HookHandler.HookOnTriggerEnter2D();
            }
            remove => HookHandler._beforeOnTriggerEnter2D -= value;
        }

        public static event Delegates.Bounce_BeforeArgs Bounce
        {
            add
            {
                HookHandler._beforeBounce += value;
                HookHandler.HookBounce();
            }
            remove => HookHandler._beforeBounce -= value;
        }

        public static event Delegates.OnTriggerStay2D_BeforeArgs OnTriggerStay2D
        {
            add
            {
                HookHandler._beforeOnTriggerStay2D += value;
                HookHandler.HookOnTriggerStay2D();
            }
            remove => HookHandler._beforeOnTriggerStay2D -= value;
        }

        public static event Delegates.Disable_BeforeArgs Disable
        {
            add
            {
                HookHandler._beforeDisable += value;
                HookHandler.HookDisable();
            }
            remove => HookHandler._beforeDisable -= value;
        }

        public static event Delegates.SetLongnail_BeforeArgs SetLongnail
        {
            add
            {
                HookHandler._beforeSetLongnail += value;
                HookHandler.HookSetLongnail();
            }
            remove => HookHandler._beforeSetLongnail -= value;
        }

        public static event Delegates.SetMantis_BeforeArgs SetMantis
        {
            add
            {
                HookHandler._beforeSetMantis += value;
                HookHandler.HookSetMantis();
            }
            remove => HookHandler._beforeSetMantis -= value;
        }

        public static event Delegates.SetFury_BeforeArgs SetFury
        {
            add
            {
                HookHandler._beforeSetFury += value;
                HookHandler.HookSetFury();
            }
            remove => HookHandler._beforeSetFury -= value;
        }

        public static event Delegates.CancelAttack_BeforeArgs CancelAttack
        {
            add
            {
                HookHandler._beforeCancelAttack += value;
                HookHandler.HookCancelAttack();
            }
            remove => HookHandler._beforeCancelAttack -= value;
        }

        public static event Delegates.orig_OnTriggerEnter2D_BeforeArgs orig_OnTriggerEnter2D
        {
            add
            {
                HookHandler._beforeorig_OnTriggerEnter2D += value;
                HookHandler.Hookorig_OnTriggerEnter2D();
            }
            remove => HookHandler._beforeorig_OnTriggerEnter2D -= value;
        }
    }

    /// <summary>
    ///     Contains Hooks to that run code after orig(self) is called
    /// </summary>
    public static class AfterOrig
    {
        public static event Delegates.Awake_NormalArgs Awake
        {
            add
            {
                HookHandler._afterAwake += value;
                HookHandler.HookAwake();
            }
            remove => HookHandler._afterAwake -= value;
        }

        public static event Delegates.StartSlash_NormalArgs StartSlash
        {
            add
            {
                HookHandler._afterStartSlash += value;
                HookHandler.HookStartSlash();
            }
            remove => HookHandler._afterStartSlash -= value;
        }

        public static event Delegates.FixedUpdate_NormalArgs FixedUpdate
        {
            add
            {
                HookHandler._afterFixedUpdate += value;
                HookHandler.HookFixedUpdate();
            }
            remove => HookHandler._afterFixedUpdate -= value;
        }

        public static event Delegates.OnTriggerEnter2D_NormalArgs OnTriggerEnter2D
        {
            add
            {
                HookHandler._afterOnTriggerEnter2D += value;
                HookHandler.HookOnTriggerEnter2D();
            }
            remove => HookHandler._afterOnTriggerEnter2D -= value;
        }

        public static event Delegates.Bounce_NormalArgs Bounce
        {
            add
            {
                HookHandler._afterBounce += value;
                HookHandler.HookBounce();
            }
            remove => HookHandler._afterBounce -= value;
        }

        public static event Delegates.OnTriggerStay2D_NormalArgs OnTriggerStay2D
        {
            add
            {
                HookHandler._afterOnTriggerStay2D += value;
                HookHandler.HookOnTriggerStay2D();
            }
            remove => HookHandler._afterOnTriggerStay2D -= value;
        }

        public static event Delegates.Disable_NormalArgs Disable
        {
            add
            {
                HookHandler._afterDisable += value;
                HookHandler.HookDisable();
            }
            remove => HookHandler._afterDisable -= value;
        }

        public static event Delegates.SetLongnail_NormalArgs SetLongnail
        {
            add
            {
                HookHandler._afterSetLongnail += value;
                HookHandler.HookSetLongnail();
            }
            remove => HookHandler._afterSetLongnail -= value;
        }

        public static event Delegates.SetMantis_NormalArgs SetMantis
        {
            add
            {
                HookHandler._afterSetMantis += value;
                HookHandler.HookSetMantis();
            }
            remove => HookHandler._afterSetMantis -= value;
        }

        public static event Delegates.SetFury_NormalArgs SetFury
        {
            add
            {
                HookHandler._afterSetFury += value;
                HookHandler.HookSetFury();
            }
            remove => HookHandler._afterSetFury -= value;
        }

        public static event Delegates.CancelAttack_NormalArgs CancelAttack
        {
            add
            {
                HookHandler._afterCancelAttack += value;
                HookHandler.HookCancelAttack();
            }
            remove => HookHandler._afterCancelAttack -= value;
        }

        public static event Delegates.orig_OnTriggerEnter2D_NormalArgs orig_OnTriggerEnter2D
        {
            add
            {
                HookHandler._afterorig_OnTriggerEnter2D += value;
                HookHandler.Hookorig_OnTriggerEnter2D();
            }
            remove => HookHandler._afterorig_OnTriggerEnter2D -= value;
        }
    }

    /// <summary>
    ///     Contains all On Hooks, even those that aren't in the On namespace such as API generated functions and property
    ///     getters/setters
    /// </summary>
    public static class WithOrig
    {
        public static event On.NailSlash.hook_Awake Awake
        {
            add => On.NailSlash.Awake += value;
            remove => On.NailSlash.Awake -= value;
        }

        public static event On.NailSlash.hook_StartSlash StartSlash
        {
            add => On.NailSlash.StartSlash += value;
            remove => On.NailSlash.StartSlash -= value;
        }

        public static event On.NailSlash.hook_FixedUpdate FixedUpdate
        {
            add => On.NailSlash.FixedUpdate += value;
            remove => On.NailSlash.FixedUpdate -= value;
        }

        public static event On.NailSlash.hook_OnTriggerEnter2D OnTriggerEnter2D
        {
            add => On.NailSlash.OnTriggerEnter2D += value;
            remove => On.NailSlash.OnTriggerEnter2D -= value;
        }

        public static event On.NailSlash.hook_Bounce Bounce
        {
            add => On.NailSlash.Bounce += value;
            remove => On.NailSlash.Bounce -= value;
        }

        public static event On.NailSlash.hook_OnTriggerStay2D OnTriggerStay2D
        {
            add => On.NailSlash.OnTriggerStay2D += value;
            remove => On.NailSlash.OnTriggerStay2D -= value;
        }

        public static event On.NailSlash.hook_Disable Disable
        {
            add => On.NailSlash.Disable += value;
            remove => On.NailSlash.Disable -= value;
        }

        public static event On.NailSlash.hook_SetLongnail SetLongnail
        {
            add => On.NailSlash.SetLongnail += value;
            remove => On.NailSlash.SetLongnail -= value;
        }

        public static event On.NailSlash.hook_SetMantis SetMantis
        {
            add => On.NailSlash.SetMantis += value;
            remove => On.NailSlash.SetMantis -= value;
        }

        public static event On.NailSlash.hook_SetFury SetFury
        {
            add => On.NailSlash.SetFury += value;
            remove => On.NailSlash.SetFury -= value;
        }

        public static event On.NailSlash.hook_CancelAttack CancelAttack
        {
            add => On.NailSlash.CancelAttack += value;
            remove => On.NailSlash.CancelAttack -= value;
        }

        public static event Delegates.orig_OnTriggerEnter2D_NormalArgs orig_OnTriggerEnter2D
        {
            add => HookEndpointManager.Add<Delegates.orig_OnTriggerEnter2D_NormalArgs>(
                ReflectionHelper.GetMethodInfo(typeof(NailSlash), "orig_OnTriggerEnter2D"), value);
            remove => HookEndpointManager.Remove<Delegates.orig_OnTriggerEnter2D_NormalArgs>(
                ReflectionHelper.GetMethodInfo(typeof(NailSlash), "orig_OnTriggerEnter2D"), value);
        }
    }
}