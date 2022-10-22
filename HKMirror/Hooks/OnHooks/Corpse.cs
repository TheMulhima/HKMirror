namespace HKMirror.Hooks.OnHooks;

/// <summary>
///     Contains different types of On Hooks for Corpse class.<br />
///     Contains hooks that aren't generated by monomod, and before and after orig hooks for easier hooking.
/// </summary>
public static class OnCorpse
{
    internal static class HookHandler
    {
        private static readonly List<string> HookedList = new();

        internal static void HookAwake()
        {
            if (!HookedList.Contains("Awake"))
            {
                HookedList.Add("Awake");
                On.Corpse.Awake += Awake;
            }
        }

        internal static event Delegates.Awake_BeforeArgs _beforeAwake;
        internal static event Delegates.Awake_AfterArgs _afterAwake;

        private static void Awake(On.Corpse.orig_Awake orig, Corpse self)
        {
            Delegates.Params_Awake @params = new()
            {
                self = self
            };
            if (_beforeAwake != null)
                foreach (Delegates.Awake_BeforeArgs toInvoke in _beforeAwake.GetInvocationList())
                    try
                    {
                        _beforeAwake?.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }

            self = @params.self;
            orig(self);
            if (_afterAwake != null)
                foreach (Delegates.Awake_AfterArgs toInvoke in _afterAwake.GetInvocationList())
                    try
                    {
                        _afterAwake.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }
        }

        internal static void HookSetup()
        {
            if (!HookedList.Contains("Setup"))
            {
                HookedList.Add("Setup");
                On.Corpse.Setup += Setup;
            }
        }

        internal static event Delegates.Setup_BeforeArgs _beforeSetup;
        internal static event Delegates.Setup_AfterArgs _afterSetup;

        private static void Setup(On.Corpse.orig_Setup orig, Corpse self, bool noSteam, bool spellBurn)
        {
            Delegates.Params_Setup @params = new()
            {
                self = self, noSteam = noSteam, spellBurn = spellBurn
            };
            if (_beforeSetup != null)
                foreach (Delegates.Setup_BeforeArgs toInvoke in _beforeSetup.GetInvocationList())
                    try
                    {
                        _beforeSetup?.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }

            self = @params.self;
            noSteam = @params.noSteam;
            spellBurn = @params.spellBurn;
            orig(self, noSteam, spellBurn);
            if (_afterSetup != null)
                foreach (Delegates.Setup_AfterArgs toInvoke in _afterSetup.GetInvocationList())
                    try
                    {
                        _afterSetup.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }
        }

        internal static void HookStart()
        {
            if (!HookedList.Contains("Start"))
            {
                HookedList.Add("Start");
                On.Corpse.Start += Start;
            }
        }

        internal static event Delegates.Start_BeforeArgs _beforeStart;
        internal static event Delegates.Start_AfterArgs _afterStart;

        private static void Start(On.Corpse.orig_Start orig, Corpse self)
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
                On.Corpse.Update += Update;
            }
        }

        internal static event Delegates.Update_BeforeArgs _beforeUpdate;
        internal static event Delegates.Update_AfterArgs _afterUpdate;

        private static void Update(On.Corpse.orig_Update orig, Corpse self)
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

        internal static void HookComplete()
        {
            if (!HookedList.Contains("Complete"))
            {
                HookedList.Add("Complete");
                On.Corpse.Complete += Complete;
            }
        }

        internal static event Delegates.Complete_BeforeArgs _beforeComplete;
        internal static event Delegates.Complete_AfterArgs _afterComplete;

        private static void Complete(On.Corpse.orig_Complete orig, Corpse self, bool detachChildren, bool destroyMe)
        {
            Delegates.Params_Complete @params = new()
            {
                self = self, detachChildren = detachChildren, destroyMe = destroyMe
            };
            if (_beforeComplete != null)
                foreach (Delegates.Complete_BeforeArgs toInvoke in _beforeComplete.GetInvocationList())
                    try
                    {
                        _beforeComplete?.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }

            self = @params.self;
            detachChildren = @params.detachChildren;
            destroyMe = @params.destroyMe;
            orig(self, detachChildren, destroyMe);
            if (_afterComplete != null)
                foreach (Delegates.Complete_AfterArgs toInvoke in _afterComplete.GetInvocationList())
                    try
                    {
                        _afterComplete.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }
        }

        internal static void HookOnCollisionEnter2D()
        {
            if (!HookedList.Contains("OnCollisionEnter2D"))
            {
                HookedList.Add("OnCollisionEnter2D");
                On.Corpse.OnCollisionEnter2D += OnCollisionEnter2D;
            }
        }

        internal static event Delegates.OnCollisionEnter2D_BeforeArgs _beforeOnCollisionEnter2D;
        internal static event Delegates.OnCollisionEnter2D_AfterArgs _afterOnCollisionEnter2D;

        private static void OnCollisionEnter2D(On.Corpse.orig_OnCollisionEnter2D orig, Corpse self,
            Collision2D collision)
        {
            Delegates.Params_OnCollisionEnter2D @params = new()
            {
                self = self, collision = collision
            };
            if (_beforeOnCollisionEnter2D != null)
                foreach (Delegates.OnCollisionEnter2D_BeforeArgs toInvoke in
                         _beforeOnCollisionEnter2D.GetInvocationList())
                    try
                    {
                        _beforeOnCollisionEnter2D?.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }

            self = @params.self;
            collision = @params.collision;
            orig(self, collision);
            if (_afterOnCollisionEnter2D != null)
                foreach (Delegates.OnCollisionEnter2D_AfterArgs toInvoke in
                         _afterOnCollisionEnter2D.GetInvocationList())
                    try
                    {
                        _afterOnCollisionEnter2D.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }
        }

        internal static void HookOnCollisionStay2D()
        {
            if (!HookedList.Contains("OnCollisionStay2D"))
            {
                HookedList.Add("OnCollisionStay2D");
                On.Corpse.OnCollisionStay2D += OnCollisionStay2D;
            }
        }

        internal static event Delegates.OnCollisionStay2D_BeforeArgs _beforeOnCollisionStay2D;
        internal static event Delegates.OnCollisionStay2D_AfterArgs _afterOnCollisionStay2D;

        private static void OnCollisionStay2D(On.Corpse.orig_OnCollisionStay2D orig, Corpse self,
            Collision2D collision)
        {
            Delegates.Params_OnCollisionStay2D @params = new()
            {
                self = self, collision = collision
            };
            if (_beforeOnCollisionStay2D != null)
                foreach (Delegates.OnCollisionStay2D_BeforeArgs toInvoke in
                         _beforeOnCollisionStay2D.GetInvocationList())
                    try
                    {
                        _beforeOnCollisionStay2D?.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }

            self = @params.self;
            collision = @params.collision;
            orig(self, collision);
            if (_afterOnCollisionStay2D != null)
                foreach (Delegates.OnCollisionStay2D_AfterArgs toInvoke in _afterOnCollisionStay2D.GetInvocationList())
                    try
                    {
                        _afterOnCollisionStay2D.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }
        }

        internal static void HookOnCollision()
        {
            if (!HookedList.Contains("OnCollision"))
            {
                HookedList.Add("OnCollision");
                On.Corpse.OnCollision += OnCollision;
            }
        }

        internal static event Delegates.OnCollision_BeforeArgs _beforeOnCollision;
        internal static event Delegates.OnCollision_AfterArgs _afterOnCollision;

        private static void OnCollision(On.Corpse.orig_OnCollision orig, Corpse self, Collision2D collision)
        {
            Delegates.Params_OnCollision @params = new()
            {
                self = self, collision = collision
            };
            if (_beforeOnCollision != null)
                foreach (Delegates.OnCollision_BeforeArgs toInvoke in _beforeOnCollision.GetInvocationList())
                    try
                    {
                        _beforeOnCollision?.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }

            self = @params.self;
            collision = @params.collision;
            orig(self, collision);
            if (_afterOnCollision != null)
                foreach (Delegates.OnCollision_AfterArgs toInvoke in _afterOnCollision.GetInvocationList())
                    try
                    {
                        _afterOnCollision.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }
        }

        internal static void HookLand()
        {
            if (!HookedList.Contains("Land"))
            {
                HookedList.Add("Land");
                On.Corpse.Land += Land;
            }
        }

        internal static event Delegates.Land_BeforeArgs _beforeLand;
        internal static event Delegates.Land_AfterArgs _afterLand;

        private static void Land(On.Corpse.orig_Land orig, Corpse self)
        {
            Delegates.Params_Land @params = new()
            {
                self = self
            };
            if (_beforeLand != null)
                foreach (Delegates.Land_BeforeArgs toInvoke in _beforeLand.GetInvocationList())
                    try
                    {
                        _beforeLand?.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }

            self = @params.self;
            orig(self);
            if (_afterLand != null)
                foreach (Delegates.Land_AfterArgs toInvoke in _afterLand.GetInvocationList())
                    try
                    {
                        _afterLand.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }
        }

        internal static void HookLandEffects()
        {
            if (!HookedList.Contains("LandEffects"))
            {
                HookedList.Add("LandEffects");
                On.Corpse.LandEffects += LandEffects;
            }
        }

        internal static event Delegates.LandEffects_BeforeArgs _beforeLandEffects;
        internal static event Delegates.LandEffects_AfterArgs _afterLandEffects;

        private static void LandEffects(On.Corpse.orig_LandEffects orig, Corpse self)
        {
            Delegates.Params_LandEffects @params = new()
            {
                self = self
            };
            if (_beforeLandEffects != null)
                foreach (Delegates.LandEffects_BeforeArgs toInvoke in _beforeLandEffects.GetInvocationList())
                    try
                    {
                        _beforeLandEffects?.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }

            self = @params.self;
            orig(self);
            if (_afterLandEffects != null)
                foreach (Delegates.LandEffects_AfterArgs toInvoke in _afterLandEffects.GetInvocationList())
                    try
                    {
                        _afterLandEffects.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }
        }

        internal static void HookSmash()
        {
            if (!HookedList.Contains("Smash"))
            {
                HookedList.Add("Smash");
                On.Corpse.Smash += Smash;
            }
        }

        internal static event Delegates.Smash_BeforeArgs _beforeSmash;
        internal static event Delegates.Smash_AfterArgs _afterSmash;

        private static void Smash(On.Corpse.orig_Smash orig, Corpse self)
        {
            Delegates.Params_Smash @params = new()
            {
                self = self
            };
            if (_beforeSmash != null)
                foreach (Delegates.Smash_BeforeArgs toInvoke in _beforeSmash.GetInvocationList())
                    try
                    {
                        _beforeSmash?.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }

            self = @params.self;
            orig(self);
            if (_afterSmash != null)
                foreach (Delegates.Smash_AfterArgs toInvoke in _afterSmash.GetInvocationList())
                    try
                    {
                        _afterSmash.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }
        }

        internal static void HookAcid()
        {
            if (!HookedList.Contains("Acid"))
            {
                HookedList.Add("Acid");
                On.Corpse.Acid += Acid;
            }
        }

        internal static event Delegates.Acid_BeforeArgs _beforeAcid;
        internal static event Delegates.Acid_AfterArgs _afterAcid;

        private static void Acid(On.Corpse.orig_Acid orig, Corpse self)
        {
            Delegates.Params_Acid @params = new()
            {
                self = self
            };
            if (_beforeAcid != null)
                foreach (Delegates.Acid_BeforeArgs toInvoke in _beforeAcid.GetInvocationList())
                    try
                    {
                        _beforeAcid?.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }

            self = @params.self;
            orig(self);
            if (_afterAcid != null)
                foreach (Delegates.Acid_AfterArgs toInvoke in _afterAcid.GetInvocationList())
                    try
                    {
                        _afterAcid.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }
        }

        internal static void HookDropThroughFloor()
        {
            if (!HookedList.Contains("DropThroughFloor"))
            {
                HookedList.Add("DropThroughFloor");
                On.Corpse.DropThroughFloor += DropThroughFloor;
            }
        }

        internal static event Delegates.DropThroughFloor_BeforeArgs _beforeDropThroughFloor;

        private static IEnumerator DropThroughFloor(On.Corpse.orig_DropThroughFloor orig,
            Corpse self)
        {
            Delegates.Params_DropThroughFloor @params = new()
            {
                self = self
            };
            if (_beforeDropThroughFloor != null)
                foreach (Delegates.DropThroughFloor_BeforeArgs toInvoke in _beforeDropThroughFloor.GetInvocationList())
                    try
                    {
                        _beforeDropThroughFloor?.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }

            self = @params.self;
            return orig(self);
        }

        internal static void HookDisableFlame()
        {
            if (!HookedList.Contains("DisableFlame"))
            {
                HookedList.Add("DisableFlame");
                On.Corpse.DisableFlame += DisableFlame;
            }
        }

        internal static event Delegates.DisableFlame_BeforeArgs _beforeDisableFlame;

        private static IEnumerator DisableFlame(On.Corpse.orig_DisableFlame orig, Corpse self)
        {
            Delegates.Params_DisableFlame @params = new()
            {
                self = self
            };
            if (_beforeDisableFlame != null)
                foreach (Delegates.DisableFlame_BeforeArgs toInvoke in _beforeDisableFlame.GetInvocationList())
                    try
                    {
                        _beforeDisableFlame?.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }

            self = @params.self;
            return orig(self);
        }
    }

    /// <summary>
    ///     Contains necessary information to create Hooks. Does not contain any hooks
    /// </summary>
    public static class Delegates
    {
        public delegate void Acid_AfterArgs(Params_Acid args);

        public delegate void Acid_BeforeArgs(Params_Acid args);

        public delegate void Acid_WithArgs(Action<Corpse> orig, Corpse self);

        public delegate void Awake_AfterArgs(Params_Awake args);

        public delegate void Awake_BeforeArgs(Params_Awake args);

        public delegate void Awake_WithArgs(Action<Corpse> orig, Corpse self);

        public delegate void Complete_AfterArgs(Params_Complete args);

        public delegate void Complete_BeforeArgs(Params_Complete args);

        public delegate void Complete_WithArgs(Action<Corpse, bool, bool> orig, Corpse self, bool detachChildren,
            bool destroyMe);

        public delegate IEnumerator DisableFlame_AfterArgs(Params_DisableFlame args,
            IEnumerator ret);

        public delegate void DisableFlame_BeforeArgs(Params_DisableFlame args);

        public delegate IEnumerator DisableFlame_WithArgs(
            Func<Corpse, IEnumerator> orig, Corpse self);

        public delegate IEnumerator DropThroughFloor_AfterArgs(Params_DropThroughFloor args,
            IEnumerator ret);

        public delegate void DropThroughFloor_BeforeArgs(Params_DropThroughFloor args);

        public delegate IEnumerator DropThroughFloor_WithArgs(
            Func<Corpse, IEnumerator> orig, Corpse self);

        public delegate void Land_AfterArgs(Params_Land args);

        public delegate void Land_BeforeArgs(Params_Land args);

        public delegate void Land_WithArgs(Action<Corpse> orig, Corpse self);

        public delegate void LandEffects_AfterArgs(Params_LandEffects args);

        public delegate void LandEffects_BeforeArgs(Params_LandEffects args);

        public delegate void LandEffects_WithArgs(Action<Corpse> orig, Corpse self);

        public delegate void OnCollision_AfterArgs(Params_OnCollision args);

        public delegate void OnCollision_BeforeArgs(Params_OnCollision args);

        public delegate void OnCollision_WithArgs(Action<Corpse, Collision2D> orig, Corpse self,
            Collision2D collision);

        public delegate void OnCollisionEnter2D_AfterArgs(Params_OnCollisionEnter2D args);

        public delegate void OnCollisionEnter2D_BeforeArgs(Params_OnCollisionEnter2D args);

        public delegate void OnCollisionEnter2D_WithArgs(Action<Corpse, Collision2D> orig, Corpse self,
            Collision2D collision);

        public delegate void OnCollisionStay2D_AfterArgs(Params_OnCollisionStay2D args);

        public delegate void OnCollisionStay2D_BeforeArgs(Params_OnCollisionStay2D args);

        public delegate void OnCollisionStay2D_WithArgs(Action<Corpse, Collision2D> orig, Corpse self,
            Collision2D collision);

        public delegate void Setup_AfterArgs(Params_Setup args);

        public delegate void Setup_BeforeArgs(Params_Setup args);

        public delegate void Setup_WithArgs(Action<Corpse, bool, bool> orig, Corpse self, bool noSteam, bool spellBurn);

        public delegate void Smash_AfterArgs(Params_Smash args);

        public delegate void Smash_BeforeArgs(Params_Smash args);

        public delegate void Smash_WithArgs(Action<Corpse> orig, Corpse self);

        public delegate void Start_AfterArgs(Params_Start args);

        public delegate void Start_BeforeArgs(Params_Start args);

        public delegate void Start_WithArgs(Action<Corpse> orig, Corpse self);

        public delegate void Update_AfterArgs(Params_Update args);

        public delegate void Update_BeforeArgs(Params_Update args);

        public delegate void Update_WithArgs(Action<Corpse> orig, Corpse self);

        public sealed class Params_Awake
        {
            public Corpse self;
        }

        public sealed class Params_Setup
        {
            public bool noSteam;
            public Corpse self;
            public bool spellBurn;
        }

        public sealed class Params_Start
        {
            public Corpse self;
        }

        public sealed class Params_Update
        {
            public Corpse self;
        }

        public sealed class Params_Complete
        {
            public bool destroyMe;
            public bool detachChildren;
            public Corpse self;
        }

        public sealed class Params_OnCollisionEnter2D
        {
            public Collision2D collision;
            public Corpse self;
        }

        public sealed class Params_OnCollisionStay2D
        {
            public Collision2D collision;
            public Corpse self;
        }

        public sealed class Params_OnCollision
        {
            public Collision2D collision;
            public Corpse self;
        }

        public sealed class Params_Land
        {
            public Corpse self;
        }

        public sealed class Params_LandEffects
        {
            public Corpse self;
        }

        public sealed class Params_Smash
        {
            public Corpse self;
        }

        public sealed class Params_Acid
        {
            public Corpse self;
        }

        public sealed class Params_DropThroughFloor
        {
            public Corpse self;
        }

        public sealed class Params_DisableFlame
        {
            public Corpse self;
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

        public static event Delegates.Setup_BeforeArgs Setup
        {
            add
            {
                HookHandler._beforeSetup += value;
                HookHandler.HookSetup();
            }
            remove => HookHandler._beforeSetup -= value;
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

        public static event Delegates.Update_BeforeArgs Update
        {
            add
            {
                HookHandler._beforeUpdate += value;
                HookHandler.HookUpdate();
            }
            remove => HookHandler._beforeUpdate -= value;
        }

        public static event Delegates.Complete_BeforeArgs Complete
        {
            add
            {
                HookHandler._beforeComplete += value;
                HookHandler.HookComplete();
            }
            remove => HookHandler._beforeComplete -= value;
        }

        public static event Delegates.OnCollisionEnter2D_BeforeArgs OnCollisionEnter2D
        {
            add
            {
                HookHandler._beforeOnCollisionEnter2D += value;
                HookHandler.HookOnCollisionEnter2D();
            }
            remove => HookHandler._beforeOnCollisionEnter2D -= value;
        }

        public static event Delegates.OnCollisionStay2D_BeforeArgs OnCollisionStay2D
        {
            add
            {
                HookHandler._beforeOnCollisionStay2D += value;
                HookHandler.HookOnCollisionStay2D();
            }
            remove => HookHandler._beforeOnCollisionStay2D -= value;
        }

        public static event Delegates.OnCollision_BeforeArgs OnCollision
        {
            add
            {
                HookHandler._beforeOnCollision += value;
                HookHandler.HookOnCollision();
            }
            remove => HookHandler._beforeOnCollision -= value;
        }

        public static event Delegates.Land_BeforeArgs Land
        {
            add
            {
                HookHandler._beforeLand += value;
                HookHandler.HookLand();
            }
            remove => HookHandler._beforeLand -= value;
        }

        public static event Delegates.LandEffects_BeforeArgs LandEffects
        {
            add
            {
                HookHandler._beforeLandEffects += value;
                HookHandler.HookLandEffects();
            }
            remove => HookHandler._beforeLandEffects -= value;
        }

        public static event Delegates.Smash_BeforeArgs Smash
        {
            add
            {
                HookHandler._beforeSmash += value;
                HookHandler.HookSmash();
            }
            remove => HookHandler._beforeSmash -= value;
        }

        public static event Delegates.Acid_BeforeArgs Acid
        {
            add
            {
                HookHandler._beforeAcid += value;
                HookHandler.HookAcid();
            }
            remove => HookHandler._beforeAcid -= value;
        }

        public static event Delegates.DropThroughFloor_BeforeArgs DropThroughFloor
        {
            add
            {
                HookHandler._beforeDropThroughFloor += value;
                HookHandler.HookDropThroughFloor();
            }
            remove => HookHandler._beforeDropThroughFloor -= value;
        }

        public static event Delegates.DisableFlame_BeforeArgs DisableFlame
        {
            add
            {
                HookHandler._beforeDisableFlame += value;
                HookHandler.HookDisableFlame();
            }
            remove => HookHandler._beforeDisableFlame -= value;
        }
    }

    /// <summary>
    ///     Contains Hooks to that run code after orig(self) is called
    /// </summary>
    public static class AfterOrig
    {
        public static event Delegates.Awake_AfterArgs Awake
        {
            add
            {
                HookHandler._afterAwake += value;
                HookHandler.HookAwake();
            }
            remove => HookHandler._afterAwake -= value;
        }

        public static event Delegates.Setup_AfterArgs Setup
        {
            add
            {
                HookHandler._afterSetup += value;
                HookHandler.HookSetup();
            }
            remove => HookHandler._afterSetup -= value;
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

        public static event Delegates.Update_AfterArgs Update
        {
            add
            {
                HookHandler._afterUpdate += value;
                HookHandler.HookUpdate();
            }
            remove => HookHandler._afterUpdate -= value;
        }

        public static event Delegates.Complete_AfterArgs Complete
        {
            add
            {
                HookHandler._afterComplete += value;
                HookHandler.HookComplete();
            }
            remove => HookHandler._afterComplete -= value;
        }

        public static event Delegates.OnCollisionEnter2D_AfterArgs OnCollisionEnter2D
        {
            add
            {
                HookHandler._afterOnCollisionEnter2D += value;
                HookHandler.HookOnCollisionEnter2D();
            }
            remove => HookHandler._afterOnCollisionEnter2D -= value;
        }

        public static event Delegates.OnCollisionStay2D_AfterArgs OnCollisionStay2D
        {
            add
            {
                HookHandler._afterOnCollisionStay2D += value;
                HookHandler.HookOnCollisionStay2D();
            }
            remove => HookHandler._afterOnCollisionStay2D -= value;
        }

        public static event Delegates.OnCollision_AfterArgs OnCollision
        {
            add
            {
                HookHandler._afterOnCollision += value;
                HookHandler.HookOnCollision();
            }
            remove => HookHandler._afterOnCollision -= value;
        }

        public static event Delegates.Land_AfterArgs Land
        {
            add
            {
                HookHandler._afterLand += value;
                HookHandler.HookLand();
            }
            remove => HookHandler._afterLand -= value;
        }

        public static event Delegates.LandEffects_AfterArgs LandEffects
        {
            add
            {
                HookHandler._afterLandEffects += value;
                HookHandler.HookLandEffects();
            }
            remove => HookHandler._afterLandEffects -= value;
        }

        public static event Delegates.Smash_AfterArgs Smash
        {
            add
            {
                HookHandler._afterSmash += value;
                HookHandler.HookSmash();
            }
            remove => HookHandler._afterSmash -= value;
        }

        public static event Delegates.Acid_AfterArgs Acid
        {
            add
            {
                HookHandler._afterAcid += value;
                HookHandler.HookAcid();
            }
            remove => HookHandler._afterAcid -= value;
        }
    }

    /// <summary>
    ///     Contains all On Hooks, even those that aren't in the On namespace such as API generated functions and property
    ///     getters/setters
    /// </summary>
    public static class WithOrig
    {
        public static event On.Corpse.hook_Awake Awake
        {
            add => On.Corpse.Awake += value;
            remove => On.Corpse.Awake -= value;
        }

        public static event On.Corpse.hook_Setup Setup
        {
            add => On.Corpse.Setup += value;
            remove => On.Corpse.Setup -= value;
        }

        public static event On.Corpse.hook_Start Start
        {
            add => On.Corpse.Start += value;
            remove => On.Corpse.Start -= value;
        }

        public static event On.Corpse.hook_Update Update
        {
            add => On.Corpse.Update += value;
            remove => On.Corpse.Update -= value;
        }

        public static event On.Corpse.hook_Complete Complete
        {
            add => On.Corpse.Complete += value;
            remove => On.Corpse.Complete -= value;
        }

        public static event On.Corpse.hook_OnCollisionEnter2D OnCollisionEnter2D
        {
            add => On.Corpse.OnCollisionEnter2D += value;
            remove => On.Corpse.OnCollisionEnter2D -= value;
        }

        public static event On.Corpse.hook_OnCollisionStay2D OnCollisionStay2D
        {
            add => On.Corpse.OnCollisionStay2D += value;
            remove => On.Corpse.OnCollisionStay2D -= value;
        }

        public static event On.Corpse.hook_OnCollision OnCollision
        {
            add => On.Corpse.OnCollision += value;
            remove => On.Corpse.OnCollision -= value;
        }

        public static event On.Corpse.hook_Land Land
        {
            add => On.Corpse.Land += value;
            remove => On.Corpse.Land -= value;
        }

        public static event On.Corpse.hook_LandEffects LandEffects
        {
            add => On.Corpse.LandEffects += value;
            remove => On.Corpse.LandEffects -= value;
        }

        public static event On.Corpse.hook_Smash Smash
        {
            add => On.Corpse.Smash += value;
            remove => On.Corpse.Smash -= value;
        }

        public static event On.Corpse.hook_Acid Acid
        {
            add => On.Corpse.Acid += value;
            remove => On.Corpse.Acid -= value;
        }

        public static event On.Corpse.hook_DropThroughFloor DropThroughFloor
        {
            add => On.Corpse.DropThroughFloor += value;
            remove => On.Corpse.DropThroughFloor -= value;
        }

        public static event On.Corpse.hook_DisableFlame DisableFlame
        {
            add => On.Corpse.DisableFlame += value;
            remove => On.Corpse.DisableFlame -= value;
        }
    }
}