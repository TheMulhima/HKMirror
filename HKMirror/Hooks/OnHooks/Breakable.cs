using MonoMod.RuntimeDetour;
using MonoMod.RuntimeDetour.HookGen;

namespace HKMirror.Hooks.OnHooks;

/// <summary>
/// Contains different types of On Hooks for Breakable class.<br />
/// Contains hooks that aren't generated by monomod, and before and after orig hooks for easier hooking.
/// </summary>
public static class OnBreakable
{
    internal static class HookHandler
    {
        private static List<string> HookedList = new List<string>();

        internal static void HookReset()
        {
            if (!HookedList.Contains("Reset"))
            {
                HookedList.Add("Reset");
                On.Breakable.Reset += Reset;
            }
        }

        internal static event Delegates.Reset_BeforeArgs _beforeReset;
        internal static event Delegates.Reset_AfterArgs _afterReset;

        private static void Reset(On.Breakable.orig_Reset orig, Breakable self)
        {
            Delegates.Params_Reset @params = new()
            {
                self = self
            };
            if (_beforeReset != null)
            {
                foreach (Delegates.Reset_BeforeArgs toInvoke in _beforeReset.GetInvocationList())
                {
                    try
                    {
                        _beforeReset?.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }
                }
            }

            self = @params.self;
            orig(self);
            if (_afterReset != null)
            {
                foreach (Delegates.Reset_AfterArgs toInvoke in _afterReset.GetInvocationList())
                {
                    try
                    {
                        _afterReset.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }
                }
            }
        }

        internal static void HookAwake()
        {
            if (!HookedList.Contains("Awake"))
            {
                HookedList.Add("Awake");
                On.Breakable.Awake += Awake;
            }
        }

        internal static event Delegates.Awake_BeforeArgs _beforeAwake;
        internal static event Delegates.Awake_AfterArgs _afterAwake;

        private static void Awake(On.Breakable.orig_Awake orig, Breakable self)
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

        internal static void HookStart()
        {
            if (!HookedList.Contains("Start"))
            {
                HookedList.Add("Start");
                On.Breakable.Start += Start;
            }
        }

        internal static event Delegates.Start_BeforeArgs _beforeStart;
        internal static event Delegates.Start_AfterArgs _afterStart;

        private static void Start(On.Breakable.orig_Start orig, Breakable self)
        {
            Delegates.Params_Start @params = new()
            {
                self = self
            };
            if (_beforeStart != null)
            {
                foreach (Delegates.Start_BeforeArgs toInvoke in _beforeStart.GetInvocationList())
                {
                    try
                    {
                        _beforeStart?.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }
                }
            }

            self = @params.self;
            orig(self);
            if (_afterStart != null)
            {
                foreach (Delegates.Start_AfterArgs toInvoke in _afterStart.GetInvocationList())
                {
                    try
                    {
                        _afterStart.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }
                }
            }
        }

        internal static void HookCreateAdditionalDebrisParts()
        {
            if (!HookedList.Contains("CreateAdditionalDebrisParts"))
            {
                HookedList.Add("CreateAdditionalDebrisParts");
                On.Breakable.CreateAdditionalDebrisParts += CreateAdditionalDebrisParts;
            }
        }

        internal static event Delegates.CreateAdditionalDebrisParts_BeforeArgs _beforeCreateAdditionalDebrisParts;
        internal static event Delegates.CreateAdditionalDebrisParts_AfterArgs _afterCreateAdditionalDebrisParts;

        private static void CreateAdditionalDebrisParts(On.Breakable.orig_CreateAdditionalDebrisParts orig,
            Breakable self, System.Collections.Generic.List<UnityEngine.GameObject> debrisParts)
        {
            Delegates.Params_CreateAdditionalDebrisParts @params = new()
            {
                self = self, debrisParts = debrisParts
            };
            if (_beforeCreateAdditionalDebrisParts != null)
            {
                foreach (Delegates.CreateAdditionalDebrisParts_BeforeArgs toInvoke in _beforeCreateAdditionalDebrisParts
                             .GetInvocationList())
                {
                    try
                    {
                        _beforeCreateAdditionalDebrisParts?.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }
                }
            }

            self = @params.self;
            debrisParts = @params.debrisParts;
            orig(self, debrisParts);
            if (_afterCreateAdditionalDebrisParts != null)
            {
                foreach (Delegates.CreateAdditionalDebrisParts_AfterArgs toInvoke in _afterCreateAdditionalDebrisParts
                             .GetInvocationList())
                {
                    try
                    {
                        _afterCreateAdditionalDebrisParts.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }
                }
            }
        }

        internal static void HookBreakSelf()
        {
            if (!HookedList.Contains("BreakSelf"))
            {
                HookedList.Add("BreakSelf");
                On.Breakable.BreakSelf += BreakSelf;
            }
        }

        internal static event Delegates.BreakSelf_BeforeArgs _beforeBreakSelf;
        internal static event Delegates.BreakSelf_AfterArgs _afterBreakSelf;

        private static void BreakSelf(On.Breakable.orig_BreakSelf orig, Breakable self)
        {
            Delegates.Params_BreakSelf @params = new()
            {
                self = self
            };
            if (_beforeBreakSelf != null)
            {
                foreach (Delegates.BreakSelf_BeforeArgs toInvoke in _beforeBreakSelf.GetInvocationList())
                {
                    try
                    {
                        _beforeBreakSelf?.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }
                }
            }

            self = @params.self;
            orig(self);
            if (_afterBreakSelf != null)
            {
                foreach (Delegates.BreakSelf_AfterArgs toInvoke in _afterBreakSelf.GetInvocationList())
                {
                    try
                    {
                        _afterBreakSelf.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }
                }
            }
        }

        internal static void HookHit()
        {
            if (!HookedList.Contains("Hit"))
            {
                HookedList.Add("Hit");
                On.Breakable.Hit += Hit;
            }
        }

        internal static event Delegates.Hit_BeforeArgs _beforeHit;
        internal static event Delegates.Hit_AfterArgs _afterHit;

        private static void Hit(On.Breakable.orig_Hit orig, Breakable self, HitInstance damageInstance)
        {
            Delegates.Params_Hit @params = new()
            {
                self = self, damageInstance = damageInstance
            };
            if (_beforeHit != null)
            {
                foreach (Delegates.Hit_BeforeArgs toInvoke in _beforeHit.GetInvocationList())
                {
                    try
                    {
                        _beforeHit?.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }
                }
            }

            self = @params.self;
            damageInstance = @params.damageInstance;
            orig(self, damageInstance);
            if (_afterHit != null)
            {
                foreach (Delegates.Hit_AfterArgs toInvoke in _afterHit.GetInvocationList())
                {
                    try
                    {
                        _afterHit.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }
                }
            }
        }

        internal static void HookSpawnNailHitEffect()
        {
            if (!HookedList.Contains("SpawnNailHitEffect"))
            {
                HookedList.Add("SpawnNailHitEffect");
                On.Breakable.SpawnNailHitEffect += SpawnNailHitEffect;
            }
        }

        internal static event Delegates.SpawnNailHitEffect_BeforeArgs _beforeSpawnNailHitEffect;
        internal static event Delegates.SpawnNailHitEffect_AfterArgs _afterSpawnNailHitEffect;

        private static UnityEngine.Transform SpawnNailHitEffect(On.Breakable.orig_SpawnNailHitEffect orig,
            UnityEngine.Transform nailHitEffectPrefab, UnityEngine.Vector3 position, float impactAngle)
        {
            Delegates.Params_SpawnNailHitEffect @params = new()
            {
                nailHitEffectPrefab = nailHitEffectPrefab, position = position, impactAngle = impactAngle
            };
            if (_beforeSpawnNailHitEffect != null)
            {
                foreach (Delegates.SpawnNailHitEffect_BeforeArgs toInvoke in
                         _beforeSpawnNailHitEffect.GetInvocationList())
                {
                    try
                    {
                        _beforeSpawnNailHitEffect?.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }
                }
            }

            nailHitEffectPrefab = @params.nailHitEffectPrefab;
            position = @params.position;
            impactAngle = @params.impactAngle;
            var retVal = orig(nailHitEffectPrefab, position, impactAngle);
            if (_afterSpawnNailHitEffect != null)
            {
                foreach (Delegates.SpawnNailHitEffect_AfterArgs toInvoke in
                         _afterSpawnNailHitEffect.GetInvocationList())
                {
                    try
                    {
                        retVal = _afterSpawnNailHitEffect.Invoke(@params, retVal);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }
                }
            }

            return retVal;
        }

        internal static void HookSetStaticPartsActivation()
        {
            if (!HookedList.Contains("SetStaticPartsActivation"))
            {
                HookedList.Add("SetStaticPartsActivation");
                On.Breakable.SetStaticPartsActivation += SetStaticPartsActivation;
            }
        }

        internal static event Delegates.SetStaticPartsActivation_BeforeArgs _beforeSetStaticPartsActivation;
        internal static event Delegates.SetStaticPartsActivation_AfterArgs _afterSetStaticPartsActivation;

        private static void SetStaticPartsActivation(On.Breakable.orig_SetStaticPartsActivation orig, Breakable self,
            bool broken)
        {
            Delegates.Params_SetStaticPartsActivation @params = new()
            {
                self = self, broken = broken
            };
            if (_beforeSetStaticPartsActivation != null)
            {
                foreach (Delegates.SetStaticPartsActivation_BeforeArgs toInvoke in _beforeSetStaticPartsActivation
                             .GetInvocationList())
                {
                    try
                    {
                        _beforeSetStaticPartsActivation?.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }
                }
            }

            self = @params.self;
            broken = @params.broken;
            orig(self, broken);
            if (_afterSetStaticPartsActivation != null)
            {
                foreach (Delegates.SetStaticPartsActivation_AfterArgs toInvoke in _afterSetStaticPartsActivation
                             .GetInvocationList())
                {
                    try
                    {
                        _afterSetStaticPartsActivation.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }
                }
            }
        }

        internal static void HookBreak()
        {
            if (!HookedList.Contains("Break"))
            {
                HookedList.Add("Break");
                On.Breakable.Break += Break;
            }
        }

        internal static event Delegates.Break_BeforeArgs _beforeBreak;
        internal static event Delegates.Break_AfterArgs _afterBreak;

        private static void Break(On.Breakable.orig_Break orig, Breakable self, float flingAngleMin,
            float flingAngleMax, float impactMultiplier)
        {
            Delegates.Params_Break @params = new()
            {
                self = self, flingAngleMin = flingAngleMin, flingAngleMax = flingAngleMax,
                impactMultiplier = impactMultiplier
            };
            if (_beforeBreak != null)
            {
                foreach (Delegates.Break_BeforeArgs toInvoke in _beforeBreak.GetInvocationList())
                {
                    try
                    {
                        _beforeBreak?.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }
                }
            }

            self = @params.self;
            flingAngleMin = @params.flingAngleMin;
            flingAngleMax = @params.flingAngleMax;
            impactMultiplier = @params.impactMultiplier;
            orig(self, flingAngleMin, flingAngleMax, impactMultiplier);
            if (_afterBreak != null)
            {
                foreach (Delegates.Break_AfterArgs toInvoke in _afterBreak.GetInvocationList())
                {
                    try
                    {
                        _afterBreak.Invoke(@params);
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
        public sealed class Params_Reset
        {
            public Breakable self;
        }

        public delegate void Reset_BeforeArgs(Params_Reset args);

        public delegate void Reset_AfterArgs(Params_Reset args);

        public delegate void Reset_WithArgs(Action<Breakable> orig, Breakable self);

        public sealed class Params_Awake
        {
            public Breakable self;
        }

        public delegate void Awake_BeforeArgs(Params_Awake args);

        public delegate void Awake_AfterArgs(Params_Awake args);

        public delegate void Awake_WithArgs(Action<Breakable> orig, Breakable self);

        public sealed class Params_Start
        {
            public Breakable self;
        }

        public delegate void Start_BeforeArgs(Params_Start args);

        public delegate void Start_AfterArgs(Params_Start args);

        public delegate void Start_WithArgs(Action<Breakable> orig, Breakable self);

        public sealed class Params_CreateAdditionalDebrisParts
        {
            public Breakable self;
            public System.Collections.Generic.List<UnityEngine.GameObject> debrisParts;
        }

        public delegate void CreateAdditionalDebrisParts_BeforeArgs(Params_CreateAdditionalDebrisParts args);

        public delegate void CreateAdditionalDebrisParts_AfterArgs(Params_CreateAdditionalDebrisParts args);

        public delegate void CreateAdditionalDebrisParts_WithArgs(
            Action<Breakable, System.Collections.Generic.List<UnityEngine.GameObject>> orig, Breakable self,
            System.Collections.Generic.List<UnityEngine.GameObject> debrisParts);

        public sealed class Params_BreakSelf
        {
            public Breakable self;
        }

        public delegate void BreakSelf_BeforeArgs(Params_BreakSelf args);

        public delegate void BreakSelf_AfterArgs(Params_BreakSelf args);

        public delegate void BreakSelf_WithArgs(Action<Breakable> orig, Breakable self);

        public sealed class Params_Hit
        {
            public Breakable self;
            public HitInstance damageInstance;
        }

        public delegate void Hit_BeforeArgs(Params_Hit args);

        public delegate void Hit_AfterArgs(Params_Hit args);

        public delegate void Hit_WithArgs(Action<Breakable, HitInstance> orig, Breakable self,
            HitInstance damageInstance);

        public sealed class Params_SpawnNailHitEffect
        {
            public UnityEngine.Transform nailHitEffectPrefab;
            public UnityEngine.Vector3 position;
            public float impactAngle;
        }

        public delegate void SpawnNailHitEffect_BeforeArgs(Params_SpawnNailHitEffect args);

        public delegate UnityEngine.Transform SpawnNailHitEffect_AfterArgs(Params_SpawnNailHitEffect args,
            UnityEngine.Transform ret);

        public delegate UnityEngine.Transform SpawnNailHitEffect_WithArgs(
            Func<UnityEngine.Transform, UnityEngine.Vector3, float, UnityEngine.Transform> orig,
            UnityEngine.Transform nailHitEffectPrefab, UnityEngine.Vector3 position, float impactAngle);

        public sealed class Params_SetStaticPartsActivation
        {
            public Breakable self;
            public bool broken;
        }

        public delegate void SetStaticPartsActivation_BeforeArgs(Params_SetStaticPartsActivation args);

        public delegate void SetStaticPartsActivation_AfterArgs(Params_SetStaticPartsActivation args);

        public delegate void SetStaticPartsActivation_WithArgs(Action<Breakable, bool> orig, Breakable self,
            bool broken);

        public sealed class Params_Break
        {
            public Breakable self;
            public float flingAngleMin;
            public float flingAngleMax;
            public float impactMultiplier;
        }

        public delegate void Break_BeforeArgs(Params_Break args);

        public delegate void Break_AfterArgs(Params_Break args);

        public delegate void Break_WithArgs(Action<Breakable, float, float, float> orig, Breakable self,
            float flingAngleMin, float flingAngleMax, float impactMultiplier);
    }

    /// <summary>
    /// Contains Hooks to that run code before orig(self) is called
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

        public static event Delegates.Awake_BeforeArgs Awake
        {
            add
            {
                HookHandler._beforeAwake += value;
                HookHandler.HookAwake();
            }
            remove => HookHandler._beforeAwake -= value;
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

        public static event Delegates.CreateAdditionalDebrisParts_BeforeArgs CreateAdditionalDebrisParts
        {
            add
            {
                HookHandler._beforeCreateAdditionalDebrisParts += value;
                HookHandler.HookCreateAdditionalDebrisParts();
            }
            remove => HookHandler._beforeCreateAdditionalDebrisParts -= value;
        }

        public static event Delegates.BreakSelf_BeforeArgs BreakSelf
        {
            add
            {
                HookHandler._beforeBreakSelf += value;
                HookHandler.HookBreakSelf();
            }
            remove => HookHandler._beforeBreakSelf -= value;
        }

        public static event Delegates.Hit_BeforeArgs Hit
        {
            add
            {
                HookHandler._beforeHit += value;
                HookHandler.HookHit();
            }
            remove => HookHandler._beforeHit -= value;
        }

        public static event Delegates.SpawnNailHitEffect_BeforeArgs SpawnNailHitEffect
        {
            add
            {
                HookHandler._beforeSpawnNailHitEffect += value;
                HookHandler.HookSpawnNailHitEffect();
            }
            remove => HookHandler._beforeSpawnNailHitEffect -= value;
        }

        public static event Delegates.SetStaticPartsActivation_BeforeArgs SetStaticPartsActivation
        {
            add
            {
                HookHandler._beforeSetStaticPartsActivation += value;
                HookHandler.HookSetStaticPartsActivation();
            }
            remove => HookHandler._beforeSetStaticPartsActivation -= value;
        }

        public static event Delegates.Break_BeforeArgs Break
        {
            add
            {
                HookHandler._beforeBreak += value;
                HookHandler.HookBreak();
            }
            remove => HookHandler._beforeBreak -= value;
        }
    }

    /// <summary>
    /// Contains Hooks to that run code after orig(self) is called
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

        public static event Delegates.Awake_AfterArgs Awake
        {
            add
            {
                HookHandler._afterAwake += value;
                HookHandler.HookAwake();
            }
            remove => HookHandler._afterAwake -= value;
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

        public static event Delegates.CreateAdditionalDebrisParts_AfterArgs CreateAdditionalDebrisParts
        {
            add
            {
                HookHandler._afterCreateAdditionalDebrisParts += value;
                HookHandler.HookCreateAdditionalDebrisParts();
            }
            remove => HookHandler._afterCreateAdditionalDebrisParts -= value;
        }

        public static event Delegates.BreakSelf_AfterArgs BreakSelf
        {
            add
            {
                HookHandler._afterBreakSelf += value;
                HookHandler.HookBreakSelf();
            }
            remove => HookHandler._afterBreakSelf -= value;
        }

        public static event Delegates.Hit_AfterArgs Hit
        {
            add
            {
                HookHandler._afterHit += value;
                HookHandler.HookHit();
            }
            remove => HookHandler._afterHit -= value;
        }

        public static event Delegates.SpawnNailHitEffect_AfterArgs SpawnNailHitEffect
        {
            add
            {
                HookHandler._afterSpawnNailHitEffect += value;
                HookHandler.HookSpawnNailHitEffect();
            }
            remove => HookHandler._afterSpawnNailHitEffect -= value;
        }

        public static event Delegates.SetStaticPartsActivation_AfterArgs SetStaticPartsActivation
        {
            add
            {
                HookHandler._afterSetStaticPartsActivation += value;
                HookHandler.HookSetStaticPartsActivation();
            }
            remove => HookHandler._afterSetStaticPartsActivation -= value;
        }

        public static event Delegates.Break_AfterArgs Break
        {
            add
            {
                HookHandler._afterBreak += value;
                HookHandler.HookBreak();
            }
            remove => HookHandler._afterBreak -= value;
        }
    }

    /// <summary>
    /// Contains all On Hooks, even those that aren't in the On namespace such as API generated functions and property getters/setters
    /// </summary>
    public static class WithOrig
    {
        public static event On.Breakable.hook_Reset Reset
        {
            add => On.Breakable.Reset += value;
            remove => On.Breakable.Reset -= value;
        }

        public static event On.Breakable.hook_Awake Awake
        {
            add => On.Breakable.Awake += value;
            remove => On.Breakable.Awake -= value;
        }

        public static event On.Breakable.hook_Start Start
        {
            add => On.Breakable.Start += value;
            remove => On.Breakable.Start -= value;
        }

        public static event On.Breakable.hook_CreateAdditionalDebrisParts CreateAdditionalDebrisParts
        {
            add => On.Breakable.CreateAdditionalDebrisParts += value;
            remove => On.Breakable.CreateAdditionalDebrisParts -= value;
        }

        public static event On.Breakable.hook_BreakSelf BreakSelf
        {
            add => On.Breakable.BreakSelf += value;
            remove => On.Breakable.BreakSelf -= value;
        }

        public static event On.Breakable.hook_Hit Hit
        {
            add => On.Breakable.Hit += value;
            remove => On.Breakable.Hit -= value;
        }

        public static event On.Breakable.hook_SpawnNailHitEffect SpawnNailHitEffect
        {
            add => On.Breakable.SpawnNailHitEffect += value;
            remove => On.Breakable.SpawnNailHitEffect -= value;
        }

        public static event On.Breakable.hook_SetStaticPartsActivation SetStaticPartsActivation
        {
            add => On.Breakable.SetStaticPartsActivation += value;
            remove => On.Breakable.SetStaticPartsActivation -= value;
        }

        public static event On.Breakable.hook_Break Break
        {
            add => On.Breakable.Break += value;
            remove => On.Breakable.Break -= value;
        }
    }
}