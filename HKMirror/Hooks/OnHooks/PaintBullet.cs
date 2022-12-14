namespace HKMirror.Hooks.OnHooks;

/// <summary>
///     Contains different types of On Hooks for PaintBullet class.<br />
///     Contains hooks that aren't generated by monomod, and before and after orig hooks for easier hooking.
/// </summary>
public static class OnPaintBullet
{
    internal static class HookHandler
    {
        private static readonly List<string> HookedList = new();

        internal static void HookAwake()
        {
            if (!HookedList.Contains("Awake"))
            {
                HookedList.Add("Awake");
                On.PaintBullet.Awake += Awake;
            }
        }

        internal static event Delegates.Awake_BeforeArgs _beforeAwake;
        internal static event Delegates.Awake_AfterArgs _afterAwake;

        private static void Awake(On.PaintBullet.orig_Awake orig, PaintBullet self)
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

        internal static void HookOnEnable()
        {
            if (!HookedList.Contains("OnEnable"))
            {
                HookedList.Add("OnEnable");
                On.PaintBullet.OnEnable += OnEnable;
            }
        }

        internal static event Delegates.OnEnable_BeforeArgs _beforeOnEnable;
        internal static event Delegates.OnEnable_AfterArgs _afterOnEnable;

        private static void OnEnable(On.PaintBullet.orig_OnEnable orig, PaintBullet self)
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

        internal static void HookUpdate()
        {
            if (!HookedList.Contains("Update"))
            {
                HookedList.Add("Update");
                On.PaintBullet.Update += Update;
            }
        }

        internal static event Delegates.Update_BeforeArgs _beforeUpdate;
        internal static event Delegates.Update_AfterArgs _afterUpdate;

        private static void Update(On.PaintBullet.orig_Update orig, PaintBullet self)
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

        internal static void HookOnTriggerEnter2D()
        {
            if (!HookedList.Contains("OnTriggerEnter2D"))
            {
                HookedList.Add("OnTriggerEnter2D");
                On.PaintBullet.OnTriggerEnter2D += OnTriggerEnter2D;
            }
        }

        internal static event Delegates.OnTriggerEnter2D_BeforeArgs _beforeOnTriggerEnter2D;
        internal static event Delegates.OnTriggerEnter2D_AfterArgs _afterOnTriggerEnter2D;

        private static void OnTriggerEnter2D(On.PaintBullet.orig_OnTriggerEnter2D orig, PaintBullet self,
            Collider2D collision)
        {
            Delegates.Params_OnTriggerEnter2D @params = new()
            {
                self = self, collision = collision
            };
            if (_beforeOnTriggerEnter2D != null)
                foreach (Delegates.OnTriggerEnter2D_BeforeArgs toInvoke in _beforeOnTriggerEnter2D.GetInvocationList())
                    try
                    {
                        _beforeOnTriggerEnter2D?.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }

            self = @params.self;
            collision = @params.collision;
            orig(self, collision);
            if (_afterOnTriggerEnter2D != null)
                foreach (Delegates.OnTriggerEnter2D_AfterArgs toInvoke in _afterOnTriggerEnter2D.GetInvocationList())
                    try
                    {
                        _afterOnTriggerEnter2D.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }
        }

        internal static void HookOnTriggerExit2D()
        {
            if (!HookedList.Contains("OnTriggerExit2D"))
            {
                HookedList.Add("OnTriggerExit2D");
                On.PaintBullet.OnTriggerExit2D += OnTriggerExit2D;
            }
        }

        internal static event Delegates.OnTriggerExit2D_BeforeArgs _beforeOnTriggerExit2D;
        internal static event Delegates.OnTriggerExit2D_AfterArgs _afterOnTriggerExit2D;

        private static void OnTriggerExit2D(On.PaintBullet.orig_OnTriggerExit2D orig, PaintBullet self,
            Collider2D collision)
        {
            Delegates.Params_OnTriggerExit2D @params = new()
            {
                self = self, collision = collision
            };
            if (_beforeOnTriggerExit2D != null)
                foreach (Delegates.OnTriggerExit2D_BeforeArgs toInvoke in _beforeOnTriggerExit2D.GetInvocationList())
                    try
                    {
                        _beforeOnTriggerExit2D?.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }

            self = @params.self;
            collision = @params.collision;
            orig(self, collision);
            if (_afterOnTriggerExit2D != null)
                foreach (Delegates.OnTriggerExit2D_AfterArgs toInvoke in _afterOnTriggerExit2D.GetInvocationList())
                    try
                    {
                        _afterOnTriggerExit2D.Invoke(@params);
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
                On.PaintBullet.OnCollisionEnter2D += OnCollisionEnter2D;
            }
        }

        internal static event Delegates.OnCollisionEnter2D_BeforeArgs _beforeOnCollisionEnter2D;
        internal static event Delegates.OnCollisionEnter2D_AfterArgs _afterOnCollisionEnter2D;

        private static void OnCollisionEnter2D(On.PaintBullet.orig_OnCollisionEnter2D orig, PaintBullet self,
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

        internal static void HookOrbitShieldHit()
        {
            if (!HookedList.Contains("OrbitShieldHit"))
            {
                HookedList.Add("OrbitShieldHit");
                On.PaintBullet.OrbitShieldHit += OrbitShieldHit;
            }
        }

        internal static event Delegates.OrbitShieldHit_BeforeArgs _beforeOrbitShieldHit;
        internal static event Delegates.OrbitShieldHit_AfterArgs _afterOrbitShieldHit;

        private static void OrbitShieldHit(On.PaintBullet.orig_OrbitShieldHit orig, PaintBullet self, Transform shield)
        {
            Delegates.Params_OrbitShieldHit @params = new()
            {
                self = self, shield = shield
            };
            if (_beforeOrbitShieldHit != null)
                foreach (Delegates.OrbitShieldHit_BeforeArgs toInvoke in _beforeOrbitShieldHit.GetInvocationList())
                    try
                    {
                        _beforeOrbitShieldHit?.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }

            self = @params.self;
            shield = @params.shield;
            orig(self, shield);
            if (_afterOrbitShieldHit != null)
                foreach (Delegates.OrbitShieldHit_AfterArgs toInvoke in _afterOrbitShieldHit.GetInvocationList())
                    try
                    {
                        _afterOrbitShieldHit.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }
        }

        internal static void HookCollision()
        {
            if (!HookedList.Contains("Collision"))
            {
                HookedList.Add("Collision");
                On.PaintBullet.Collision += Collision;
            }
        }

        internal static event Delegates.Collision_BeforeArgs _beforeCollision;

        private static IEnumerator Collision(On.PaintBullet.orig_Collision orig, PaintBullet self, Vector2 normal,
            bool doRotation)
        {
            Delegates.Params_Collision @params = new()
            {
                self = self, normal = normal, doRotation = doRotation
            };
            if (_beforeCollision != null)
                foreach (Delegates.Collision_BeforeArgs toInvoke in _beforeCollision.GetInvocationList())
                    try
                    {
                        _beforeCollision?.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }

            self = @params.self;
            normal = @params.normal;
            doRotation = @params.doRotation;
            return orig(self, normal, doRotation);
        }

        internal static void HookSetColourBlue()
        {
            if (!HookedList.Contains("SetColourBlue"))
            {
                HookedList.Add("SetColourBlue");
                On.PaintBullet.SetColourBlue += SetColourBlue;
            }
        }

        internal static event Delegates.SetColourBlue_BeforeArgs _beforeSetColourBlue;
        internal static event Delegates.SetColourBlue_AfterArgs _afterSetColourBlue;

        private static void SetColourBlue(On.PaintBullet.orig_SetColourBlue orig, PaintBullet self)
        {
            Delegates.Params_SetColourBlue @params = new()
            {
                self = self
            };
            if (_beforeSetColourBlue != null)
                foreach (Delegates.SetColourBlue_BeforeArgs toInvoke in _beforeSetColourBlue.GetInvocationList())
                    try
                    {
                        _beforeSetColourBlue?.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }

            self = @params.self;
            orig(self);
            if (_afterSetColourBlue != null)
                foreach (Delegates.SetColourBlue_AfterArgs toInvoke in _afterSetColourBlue.GetInvocationList())
                    try
                    {
                        _afterSetColourBlue.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }
        }

        internal static void HookSetColourRed()
        {
            if (!HookedList.Contains("SetColourRed"))
            {
                HookedList.Add("SetColourRed");
                On.PaintBullet.SetColourRed += SetColourRed;
            }
        }

        internal static event Delegates.SetColourRed_BeforeArgs _beforeSetColourRed;
        internal static event Delegates.SetColourRed_AfterArgs _afterSetColourRed;

        private static void SetColourRed(On.PaintBullet.orig_SetColourRed orig, PaintBullet self)
        {
            Delegates.Params_SetColourRed @params = new()
            {
                self = self
            };
            if (_beforeSetColourRed != null)
                foreach (Delegates.SetColourRed_BeforeArgs toInvoke in _beforeSetColourRed.GetInvocationList())
                    try
                    {
                        _beforeSetColourRed?.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }

            self = @params.self;
            orig(self);
            if (_afterSetColourRed != null)
                foreach (Delegates.SetColourRed_AfterArgs toInvoke in _afterSetColourRed.GetInvocationList())
                    try
                    {
                        _afterSetColourRed.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }
        }

        internal static void HookSetBlue()
        {
            if (!HookedList.Contains("SetBlue"))
            {
                HookedList.Add("SetBlue");
                On.PaintBullet.SetBlue += SetBlue;
            }
        }

        internal static event Delegates.SetBlue_BeforeArgs _beforeSetBlue;
        internal static event Delegates.SetBlue_AfterArgs _afterSetBlue;

        private static void SetBlue(On.PaintBullet.orig_SetBlue orig, PaintBullet self)
        {
            Delegates.Params_SetBlue @params = new()
            {
                self = self
            };
            if (_beforeSetBlue != null)
                foreach (Delegates.SetBlue_BeforeArgs toInvoke in _beforeSetBlue.GetInvocationList())
                    try
                    {
                        _beforeSetBlue?.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }

            self = @params.self;
            orig(self);
            if (_afterSetBlue != null)
                foreach (Delegates.SetBlue_AfterArgs toInvoke in _afterSetBlue.GetInvocationList())
                    try
                    {
                        _afterSetBlue.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }
        }

        internal static void HookSetRed()
        {
            if (!HookedList.Contains("SetRed"))
            {
                HookedList.Add("SetRed");
                On.PaintBullet.SetRed += SetRed;
            }
        }

        internal static event Delegates.SetRed_BeforeArgs _beforeSetRed;
        internal static event Delegates.SetRed_AfterArgs _afterSetRed;

        private static void SetRed(On.PaintBullet.orig_SetRed orig, PaintBullet self)
        {
            Delegates.Params_SetRed @params = new()
            {
                self = self
            };
            if (_beforeSetRed != null)
                foreach (Delegates.SetRed_BeforeArgs toInvoke in _beforeSetRed.GetInvocationList())
                    try
                    {
                        _beforeSetRed?.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }

            self = @params.self;
            orig(self);
            if (_afterSetRed != null)
                foreach (Delegates.SetRed_AfterArgs toInvoke in _afterSetRed.GetInvocationList())
                    try
                    {
                        _afterSetRed.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }
        }

        internal static void HookSetPink()
        {
            if (!HookedList.Contains("SetPink"))
            {
                HookedList.Add("SetPink");
                On.PaintBullet.SetPink += SetPink;
            }
        }

        internal static event Delegates.SetPink_BeforeArgs _beforeSetPink;
        internal static event Delegates.SetPink_AfterArgs _afterSetPink;

        private static void SetPink(On.PaintBullet.orig_SetPink orig, PaintBullet self)
        {
            Delegates.Params_SetPink @params = new()
            {
                self = self
            };
            if (_beforeSetPink != null)
                foreach (Delegates.SetPink_BeforeArgs toInvoke in _beforeSetPink.GetInvocationList())
                    try
                    {
                        _beforeSetPink?.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }

            self = @params.self;
            orig(self);
            if (_afterSetPink != null)
                foreach (Delegates.SetPink_AfterArgs toInvoke in _afterSetPink.GetInvocationList())
                    try
                    {
                        _afterSetPink.Invoke(@params);
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
        public delegate void Awake_AfterArgs(Params_Awake args);

        public delegate void Awake_BeforeArgs(Params_Awake args);

        public delegate void Awake_WithArgs(Action<PaintBullet> orig, PaintBullet self);

        public delegate IEnumerator Collision_AfterArgs(Params_Collision args, IEnumerator ret);

        public delegate void Collision_BeforeArgs(Params_Collision args);

        public delegate IEnumerator Collision_WithArgs(Func<PaintBullet, Vector2, bool, IEnumerator> orig,
            PaintBullet self, Vector2 normal, bool doRotation);

        public delegate void OnCollisionEnter2D_AfterArgs(Params_OnCollisionEnter2D args);

        public delegate void OnCollisionEnter2D_BeforeArgs(Params_OnCollisionEnter2D args);

        public delegate void OnCollisionEnter2D_WithArgs(Action<PaintBullet, Collision2D> orig, PaintBullet self,
            Collision2D collision);

        public delegate void OnEnable_AfterArgs(Params_OnEnable args);

        public delegate void OnEnable_BeforeArgs(Params_OnEnable args);

        public delegate void OnEnable_WithArgs(Action<PaintBullet> orig, PaintBullet self);

        public delegate void OnTriggerEnter2D_AfterArgs(Params_OnTriggerEnter2D args);

        public delegate void OnTriggerEnter2D_BeforeArgs(Params_OnTriggerEnter2D args);

        public delegate void OnTriggerEnter2D_WithArgs(Action<PaintBullet, Collider2D> orig, PaintBullet self,
            Collider2D collision);

        public delegate void OnTriggerExit2D_AfterArgs(Params_OnTriggerExit2D args);

        public delegate void OnTriggerExit2D_BeforeArgs(Params_OnTriggerExit2D args);

        public delegate void OnTriggerExit2D_WithArgs(Action<PaintBullet, Collider2D> orig, PaintBullet self,
            Collider2D collision);

        public delegate void OrbitShieldHit_AfterArgs(Params_OrbitShieldHit args);

        public delegate void OrbitShieldHit_BeforeArgs(Params_OrbitShieldHit args);

        public delegate void OrbitShieldHit_WithArgs(Action<PaintBullet, Transform> orig, PaintBullet self,
            Transform shield);

        public delegate void SetBlue_AfterArgs(Params_SetBlue args);

        public delegate void SetBlue_BeforeArgs(Params_SetBlue args);

        public delegate void SetBlue_WithArgs(Action<PaintBullet> orig, PaintBullet self);

        public delegate void SetColourBlue_AfterArgs(Params_SetColourBlue args);

        public delegate void SetColourBlue_BeforeArgs(Params_SetColourBlue args);

        public delegate void SetColourBlue_WithArgs(Action<PaintBullet> orig, PaintBullet self);

        public delegate void SetColourRed_AfterArgs(Params_SetColourRed args);

        public delegate void SetColourRed_BeforeArgs(Params_SetColourRed args);

        public delegate void SetColourRed_WithArgs(Action<PaintBullet> orig, PaintBullet self);

        public delegate void SetPink_AfterArgs(Params_SetPink args);

        public delegate void SetPink_BeforeArgs(Params_SetPink args);

        public delegate void SetPink_WithArgs(Action<PaintBullet> orig, PaintBullet self);

        public delegate void SetRed_AfterArgs(Params_SetRed args);

        public delegate void SetRed_BeforeArgs(Params_SetRed args);

        public delegate void SetRed_WithArgs(Action<PaintBullet> orig, PaintBullet self);

        public delegate void Update_AfterArgs(Params_Update args);

        public delegate void Update_BeforeArgs(Params_Update args);

        public delegate void Update_WithArgs(Action<PaintBullet> orig, PaintBullet self);

        public sealed class Params_Awake
        {
            public PaintBullet self;
        }

        public sealed class Params_OnEnable
        {
            public PaintBullet self;
        }

        public sealed class Params_Update
        {
            public PaintBullet self;
        }

        public sealed class Params_OnTriggerEnter2D
        {
            public Collider2D collision;
            public PaintBullet self;
        }

        public sealed class Params_OnTriggerExit2D
        {
            public Collider2D collision;
            public PaintBullet self;
        }

        public sealed class Params_OnCollisionEnter2D
        {
            public Collision2D collision;
            public PaintBullet self;
        }

        public sealed class Params_OrbitShieldHit
        {
            public PaintBullet self;
            public Transform shield;
        }

        public sealed class Params_Collision
        {
            public bool doRotation;
            public Vector2 normal;
            public PaintBullet self;
        }

        public sealed class Params_SetColourBlue
        {
            public PaintBullet self;
        }

        public sealed class Params_SetColourRed
        {
            public PaintBullet self;
        }

        public sealed class Params_SetBlue
        {
            public PaintBullet self;
        }

        public sealed class Params_SetRed
        {
            public PaintBullet self;
        }

        public sealed class Params_SetPink
        {
            public PaintBullet self;
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

        public static event Delegates.OnTriggerEnter2D_BeforeArgs OnTriggerEnter2D
        {
            add
            {
                HookHandler._beforeOnTriggerEnter2D += value;
                HookHandler.HookOnTriggerEnter2D();
            }
            remove => HookHandler._beforeOnTriggerEnter2D -= value;
        }

        public static event Delegates.OnTriggerExit2D_BeforeArgs OnTriggerExit2D
        {
            add
            {
                HookHandler._beforeOnTriggerExit2D += value;
                HookHandler.HookOnTriggerExit2D();
            }
            remove => HookHandler._beforeOnTriggerExit2D -= value;
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

        public static event Delegates.OrbitShieldHit_BeforeArgs OrbitShieldHit
        {
            add
            {
                HookHandler._beforeOrbitShieldHit += value;
                HookHandler.HookOrbitShieldHit();
            }
            remove => HookHandler._beforeOrbitShieldHit -= value;
        }

        public static event Delegates.Collision_BeforeArgs Collision
        {
            add
            {
                HookHandler._beforeCollision += value;
                HookHandler.HookCollision();
            }
            remove => HookHandler._beforeCollision -= value;
        }

        public static event Delegates.SetColourBlue_BeforeArgs SetColourBlue
        {
            add
            {
                HookHandler._beforeSetColourBlue += value;
                HookHandler.HookSetColourBlue();
            }
            remove => HookHandler._beforeSetColourBlue -= value;
        }

        public static event Delegates.SetColourRed_BeforeArgs SetColourRed
        {
            add
            {
                HookHandler._beforeSetColourRed += value;
                HookHandler.HookSetColourRed();
            }
            remove => HookHandler._beforeSetColourRed -= value;
        }

        public static event Delegates.SetBlue_BeforeArgs SetBlue
        {
            add
            {
                HookHandler._beforeSetBlue += value;
                HookHandler.HookSetBlue();
            }
            remove => HookHandler._beforeSetBlue -= value;
        }

        public static event Delegates.SetRed_BeforeArgs SetRed
        {
            add
            {
                HookHandler._beforeSetRed += value;
                HookHandler.HookSetRed();
            }
            remove => HookHandler._beforeSetRed -= value;
        }

        public static event Delegates.SetPink_BeforeArgs SetPink
        {
            add
            {
                HookHandler._beforeSetPink += value;
                HookHandler.HookSetPink();
            }
            remove => HookHandler._beforeSetPink -= value;
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

        public static event Delegates.OnTriggerEnter2D_AfterArgs OnTriggerEnter2D
        {
            add
            {
                HookHandler._afterOnTriggerEnter2D += value;
                HookHandler.HookOnTriggerEnter2D();
            }
            remove => HookHandler._afterOnTriggerEnter2D -= value;
        }

        public static event Delegates.OnTriggerExit2D_AfterArgs OnTriggerExit2D
        {
            add
            {
                HookHandler._afterOnTriggerExit2D += value;
                HookHandler.HookOnTriggerExit2D();
            }
            remove => HookHandler._afterOnTriggerExit2D -= value;
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

        public static event Delegates.OrbitShieldHit_AfterArgs OrbitShieldHit
        {
            add
            {
                HookHandler._afterOrbitShieldHit += value;
                HookHandler.HookOrbitShieldHit();
            }
            remove => HookHandler._afterOrbitShieldHit -= value;
        }

        public static event Delegates.SetColourBlue_AfterArgs SetColourBlue
        {
            add
            {
                HookHandler._afterSetColourBlue += value;
                HookHandler.HookSetColourBlue();
            }
            remove => HookHandler._afterSetColourBlue -= value;
        }

        public static event Delegates.SetColourRed_AfterArgs SetColourRed
        {
            add
            {
                HookHandler._afterSetColourRed += value;
                HookHandler.HookSetColourRed();
            }
            remove => HookHandler._afterSetColourRed -= value;
        }

        public static event Delegates.SetBlue_AfterArgs SetBlue
        {
            add
            {
                HookHandler._afterSetBlue += value;
                HookHandler.HookSetBlue();
            }
            remove => HookHandler._afterSetBlue -= value;
        }

        public static event Delegates.SetRed_AfterArgs SetRed
        {
            add
            {
                HookHandler._afterSetRed += value;
                HookHandler.HookSetRed();
            }
            remove => HookHandler._afterSetRed -= value;
        }

        public static event Delegates.SetPink_AfterArgs SetPink
        {
            add
            {
                HookHandler._afterSetPink += value;
                HookHandler.HookSetPink();
            }
            remove => HookHandler._afterSetPink -= value;
        }
    }

    /// <summary>
    ///     Contains all On Hooks, even those that aren't in the On namespace such as API generated functions and property
    ///     getters/setters
    /// </summary>
    public static class WithOrig
    {
        public static event On.PaintBullet.hook_Awake Awake
        {
            add => On.PaintBullet.Awake += value;
            remove => On.PaintBullet.Awake -= value;
        }

        public static event On.PaintBullet.hook_OnEnable OnEnable
        {
            add => On.PaintBullet.OnEnable += value;
            remove => On.PaintBullet.OnEnable -= value;
        }

        public static event On.PaintBullet.hook_Update Update
        {
            add => On.PaintBullet.Update += value;
            remove => On.PaintBullet.Update -= value;
        }

        public static event On.PaintBullet.hook_OnTriggerEnter2D OnTriggerEnter2D
        {
            add => On.PaintBullet.OnTriggerEnter2D += value;
            remove => On.PaintBullet.OnTriggerEnter2D -= value;
        }

        public static event On.PaintBullet.hook_OnTriggerExit2D OnTriggerExit2D
        {
            add => On.PaintBullet.OnTriggerExit2D += value;
            remove => On.PaintBullet.OnTriggerExit2D -= value;
        }

        public static event On.PaintBullet.hook_OnCollisionEnter2D OnCollisionEnter2D
        {
            add => On.PaintBullet.OnCollisionEnter2D += value;
            remove => On.PaintBullet.OnCollisionEnter2D -= value;
        }

        public static event On.PaintBullet.hook_OrbitShieldHit OrbitShieldHit
        {
            add => On.PaintBullet.OrbitShieldHit += value;
            remove => On.PaintBullet.OrbitShieldHit -= value;
        }

        public static event On.PaintBullet.hook_Collision Collision
        {
            add => On.PaintBullet.Collision += value;
            remove => On.PaintBullet.Collision -= value;
        }

        public static event On.PaintBullet.hook_SetColourBlue SetColourBlue
        {
            add => On.PaintBullet.SetColourBlue += value;
            remove => On.PaintBullet.SetColourBlue -= value;
        }

        public static event On.PaintBullet.hook_SetColourRed SetColourRed
        {
            add => On.PaintBullet.SetColourRed += value;
            remove => On.PaintBullet.SetColourRed -= value;
        }

        public static event On.PaintBullet.hook_SetBlue SetBlue
        {
            add => On.PaintBullet.SetBlue += value;
            remove => On.PaintBullet.SetBlue -= value;
        }

        public static event On.PaintBullet.hook_SetRed SetRed
        {
            add => On.PaintBullet.SetRed += value;
            remove => On.PaintBullet.SetRed -= value;
        }

        public static event On.PaintBullet.hook_SetPink SetPink
        {
            add => On.PaintBullet.SetPink += value;
            remove => On.PaintBullet.SetPink -= value;
        }
    }
}