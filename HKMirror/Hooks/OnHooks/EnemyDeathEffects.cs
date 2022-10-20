using MonoMod.RuntimeDetour;
using MonoMod.RuntimeDetour.HookGen;

namespace HKMirror.Hooks.OnHooks;

/// <summary>
///     Contains different types of On Hooks for EnemyDeathEffects class.<br />
///     Contains hooks that aren't generated by monomod, and before and after orig hooks for easier hooking.
/// </summary>
public static class OnEnemyDeathEffects
{
    internal static class HookHandler
    {
        private static readonly List<string> HookedList = new();

        internal static void HookStart()
        {
            if (!HookedList.Contains("Start"))
            {
                HookedList.Add("Start");
                On.EnemyDeathEffects.Start += Start;
            }
        }

        internal static event Delegates.Start_BeforeArgs _beforeStart;
        internal static event Delegates.Start_NormalArgs _afterStart;

        private static void Start(On.EnemyDeathEffects.orig_Start orig, EnemyDeathEffects self)
        {
            Delegates.Params_Start @params = new()
            {
                self = self
            };
            _beforeStart?.Invoke(@params);
            self = @params.self;
            orig(self);
            if (_afterStart != null) _afterStart.Invoke(@params);
        }

        internal static void HookPreInstantiate()
        {
            if (!HookedList.Contains("PreInstantiate"))
            {
                HookedList.Add("PreInstantiate");
                On.EnemyDeathEffects.PreInstantiate += PreInstantiate;
            }
        }

        internal static event Delegates.PreInstantiate_BeforeArgs _beforePreInstantiate;
        internal static event Delegates.PreInstantiate_NormalArgs _afterPreInstantiate;

        private static void PreInstantiate(On.EnemyDeathEffects.orig_PreInstantiate orig, EnemyDeathEffects self)
        {
            Delegates.Params_PreInstantiate @params = new()
            {
                self = self
            };
            _beforePreInstantiate?.Invoke(@params);
            self = @params.self;
            orig(self);
            if (_afterPreInstantiate != null) _afterPreInstantiate.Invoke(@params);
        }

        internal static void HookRecieveDeathEvent()
        {
            if (!HookedList.Contains("RecieveDeathEvent"))
            {
                HookedList.Add("RecieveDeathEvent");
                On.EnemyDeathEffects.RecieveDeathEvent += RecieveDeathEvent;
            }
        }

        internal static event Delegates.RecieveDeathEvent_BeforeArgs _beforeRecieveDeathEvent;
        internal static event Delegates.RecieveDeathEvent_NormalArgs _afterRecieveDeathEvent;

        private static void RecieveDeathEvent(On.EnemyDeathEffects.orig_RecieveDeathEvent orig, EnemyDeathEffects self,
            float? attackDirection, bool resetDeathEvent, bool spellBurn, bool isWatery)
        {
            Delegates.Params_RecieveDeathEvent @params = new()
            {
                self = self, attackDirection = attackDirection, resetDeathEvent = resetDeathEvent,
                spellBurn = spellBurn, isWatery = isWatery
            };
            _beforeRecieveDeathEvent?.Invoke(@params);
            self = @params.self;
            attackDirection = @params.attackDirection;
            resetDeathEvent = @params.resetDeathEvent;
            spellBurn = @params.spellBurn;
            isWatery = @params.isWatery;
            orig(self, attackDirection, resetDeathEvent, spellBurn, isWatery);
            if (_afterRecieveDeathEvent != null) _afterRecieveDeathEvent.Invoke(@params);
        }

        internal static void HookRecordKillForJournal()
        {
            if (!HookedList.Contains("RecordKillForJournal"))
            {
                HookedList.Add("RecordKillForJournal");
                On.EnemyDeathEffects.RecordKillForJournal += RecordKillForJournal;
            }
        }

        internal static event Delegates.RecordKillForJournal_BeforeArgs _beforeRecordKillForJournal;
        internal static event Delegates.RecordKillForJournal_NormalArgs _afterRecordKillForJournal;

        private static void RecordKillForJournal(On.EnemyDeathEffects.orig_RecordKillForJournal orig,
            EnemyDeathEffects self)
        {
            Delegates.Params_RecordKillForJournal @params = new()
            {
                self = self
            };
            _beforeRecordKillForJournal?.Invoke(@params);
            self = @params.self;
            orig(self);
            if (_afterRecordKillForJournal != null) _afterRecordKillForJournal.Invoke(@params);
        }

        internal static void HookEmitCorpse()
        {
            if (!HookedList.Contains("EmitCorpse"))
            {
                HookedList.Add("EmitCorpse");
                On.EnemyDeathEffects.EmitCorpse += EmitCorpse;
            }
        }

        internal static event Delegates.EmitCorpse_BeforeArgs _beforeEmitCorpse;
        internal static event Delegates.EmitCorpse_NormalArgs _afterEmitCorpse;

        private static void EmitCorpse(On.EnemyDeathEffects.orig_EmitCorpse orig, EnemyDeathEffects self,
            float? attackDirection, bool isWatery, bool spellBurn)
        {
            Delegates.Params_EmitCorpse @params = new()
            {
                self = self, attackDirection = attackDirection, isWatery = isWatery, spellBurn = spellBurn
            };
            _beforeEmitCorpse?.Invoke(@params);
            self = @params.self;
            attackDirection = @params.attackDirection;
            isWatery = @params.isWatery;
            spellBurn = @params.spellBurn;
            orig(self, attackDirection, isWatery, spellBurn);
            if (_afterEmitCorpse != null) _afterEmitCorpse.Invoke(@params);
        }

        internal static void HookEmitEffects()
        {
            if (!HookedList.Contains("EmitEffects"))
            {
                HookedList.Add("EmitEffects");
                On.EnemyDeathEffects.EmitEffects += EmitEffects;
            }
        }

        internal static event Delegates.EmitEffects_BeforeArgs _beforeEmitEffects;
        internal static event Delegates.EmitEffects_NormalArgs _afterEmitEffects;

        private static void EmitEffects(On.EnemyDeathEffects.orig_EmitEffects orig, EnemyDeathEffects self)
        {
            Delegates.Params_EmitEffects @params = new()
            {
                self = self
            };
            _beforeEmitEffects?.Invoke(@params);
            self = @params.self;
            orig(self);
            if (_afterEmitEffects != null) _afterEmitEffects.Invoke(@params);
        }

        internal static void HookEmitSound()
        {
            if (!HookedList.Contains("EmitSound"))
            {
                HookedList.Add("EmitSound");
                On.EnemyDeathEffects.EmitSound += EmitSound;
            }
        }

        internal static event Delegates.EmitSound_BeforeArgs _beforeEmitSound;
        internal static event Delegates.EmitSound_NormalArgs _afterEmitSound;

        private static void EmitSound(On.EnemyDeathEffects.orig_EmitSound orig, EnemyDeathEffects self)
        {
            Delegates.Params_EmitSound @params = new()
            {
                self = self
            };
            _beforeEmitSound?.Invoke(@params);
            self = @params.self;
            orig(self);
            if (_afterEmitSound != null) _afterEmitSound.Invoke(@params);
        }

        internal static void HookEmitInfectedEffects()
        {
            if (!HookedList.Contains("EmitInfectedEffects"))
            {
                HookedList.Add("EmitInfectedEffects");
                On.EnemyDeathEffects.EmitInfectedEffects += EmitInfectedEffects;
            }
        }

        internal static event Delegates.EmitInfectedEffects_BeforeArgs _beforeEmitInfectedEffects;
        internal static event Delegates.EmitInfectedEffects_NormalArgs _afterEmitInfectedEffects;

        private static void EmitInfectedEffects(On.EnemyDeathEffects.orig_EmitInfectedEffects orig,
            EnemyDeathEffects self)
        {
            Delegates.Params_EmitInfectedEffects @params = new()
            {
                self = self
            };
            _beforeEmitInfectedEffects?.Invoke(@params);
            self = @params.self;
            orig(self);
            if (_afterEmitInfectedEffects != null) _afterEmitInfectedEffects.Invoke(@params);
        }

        internal static void HookEmitSmallInfectedEffects()
        {
            if (!HookedList.Contains("EmitSmallInfectedEffects"))
            {
                HookedList.Add("EmitSmallInfectedEffects");
                On.EnemyDeathEffects.EmitSmallInfectedEffects += EmitSmallInfectedEffects;
            }
        }

        internal static event Delegates.EmitSmallInfectedEffects_BeforeArgs _beforeEmitSmallInfectedEffects;
        internal static event Delegates.EmitSmallInfectedEffects_NormalArgs _afterEmitSmallInfectedEffects;

        private static void EmitSmallInfectedEffects(On.EnemyDeathEffects.orig_EmitSmallInfectedEffects orig,
            EnemyDeathEffects self)
        {
            Delegates.Params_EmitSmallInfectedEffects @params = new()
            {
                self = self
            };
            _beforeEmitSmallInfectedEffects?.Invoke(@params);
            self = @params.self;
            orig(self);
            if (_afterEmitSmallInfectedEffects != null) _afterEmitSmallInfectedEffects.Invoke(@params);
        }

        internal static void HookEmitLargeInfectedEffects()
        {
            if (!HookedList.Contains("EmitLargeInfectedEffects"))
            {
                HookedList.Add("EmitLargeInfectedEffects");
                On.EnemyDeathEffects.EmitLargeInfectedEffects += EmitLargeInfectedEffects;
            }
        }

        internal static event Delegates.EmitLargeInfectedEffects_BeforeArgs _beforeEmitLargeInfectedEffects;
        internal static event Delegates.EmitLargeInfectedEffects_NormalArgs _afterEmitLargeInfectedEffects;

        private static void EmitLargeInfectedEffects(On.EnemyDeathEffects.orig_EmitLargeInfectedEffects orig,
            EnemyDeathEffects self)
        {
            Delegates.Params_EmitLargeInfectedEffects @params = new()
            {
                self = self
            };
            _beforeEmitLargeInfectedEffects?.Invoke(@params);
            self = @params.self;
            orig(self);
            if (_afterEmitLargeInfectedEffects != null) _afterEmitLargeInfectedEffects.Invoke(@params);
        }

        internal static void HookShakeCameraIfVisible()
        {
            if (!HookedList.Contains("ShakeCameraIfVisible"))
            {
                HookedList.Add("ShakeCameraIfVisible");
                On.EnemyDeathEffects.ShakeCameraIfVisible += ShakeCameraIfVisible;
            }
        }

        internal static event Delegates.ShakeCameraIfVisible_BeforeArgs _beforeShakeCameraIfVisible;
        internal static event Delegates.ShakeCameraIfVisible_NormalArgs _afterShakeCameraIfVisible;

        private static void ShakeCameraIfVisible(On.EnemyDeathEffects.orig_ShakeCameraIfVisible orig,
            EnemyDeathEffects self, string eventName)
        {
            Delegates.Params_ShakeCameraIfVisible @params = new()
            {
                self = self, eventName = eventName
            };
            _beforeShakeCameraIfVisible?.Invoke(@params);
            self = @params.self;
            eventName = @params.eventName;
            orig(self, eventName);
            if (_afterShakeCameraIfVisible != null) _afterShakeCameraIfVisible.Invoke(@params);
        }

        internal static void HookEmitEssence()
        {
            if (!HookedList.Contains("EmitEssence"))
            {
                HookedList.Add("EmitEssence");
                On.EnemyDeathEffects.EmitEssence += EmitEssence;
            }
        }

        internal static event Delegates.EmitEssence_BeforeArgs _beforeEmitEssence;
        internal static event Delegates.EmitEssence_NormalArgs _afterEmitEssence;

        private static void EmitEssence(On.EnemyDeathEffects.orig_EmitEssence orig, EnemyDeathEffects self)
        {
            Delegates.Params_EmitEssence @params = new()
            {
                self = self
            };
            _beforeEmitEssence?.Invoke(@params);
            self = @params.self;
            orig(self);
            if (_afterEmitEssence != null) _afterEmitEssence.Invoke(@params);
        }

        internal static void Hookorig_RecieveDeathEvent()
        {
            if (!HookedList.Contains("orig_RecieveDeathEvent"))
            {
                HookedList.Add("orig_RecieveDeathEvent");
                new Hook(ReflectionHelper.GetMethodInfo(typeof(EnemyDeathEffects), "orig_RecieveDeathEvent"),
                    orig_RecieveDeathEvent);
            }
        }

        internal static event Delegates.orig_RecieveDeathEvent_BeforeArgs _beforeorig_RecieveDeathEvent;
        internal static event Delegates.orig_RecieveDeathEvent_NormalArgs _afterorig_RecieveDeathEvent;

        private static void orig_RecieveDeathEvent(Action<EnemyDeathEffects, float?, bool, bool, bool> orig,
            EnemyDeathEffects self, float? attackDirection, bool resetDeathEvent, bool spellBurn, bool isWatery)
        {
            Delegates.Params_orig_RecieveDeathEvent @params = new()
            {
                self = self, attackDirection = attackDirection, resetDeathEvent = resetDeathEvent,
                spellBurn = spellBurn, isWatery = isWatery
            };
            _beforeorig_RecieveDeathEvent?.Invoke(@params);
            self = @params.self;
            attackDirection = @params.attackDirection;
            resetDeathEvent = @params.resetDeathEvent;
            spellBurn = @params.spellBurn;
            isWatery = @params.isWatery;
            orig(self, attackDirection, resetDeathEvent, spellBurn, isWatery);
            if (_afterorig_RecieveDeathEvent != null) _afterorig_RecieveDeathEvent.Invoke(@params);
        }

        internal static void Hookorig_RecordKillForJournal()
        {
            if (!HookedList.Contains("orig_RecordKillForJournal"))
            {
                HookedList.Add("orig_RecordKillForJournal");
                new Hook(ReflectionHelper.GetMethodInfo(typeof(EnemyDeathEffects), "orig_RecordKillForJournal"),
                    orig_RecordKillForJournal);
            }
        }

        internal static event Delegates.orig_RecordKillForJournal_BeforeArgs _beforeorig_RecordKillForJournal;
        internal static event Delegates.orig_RecordKillForJournal_NormalArgs _afterorig_RecordKillForJournal;

        private static void orig_RecordKillForJournal(Action<EnemyDeathEffects> orig, EnemyDeathEffects self)
        {
            Delegates.Params_orig_RecordKillForJournal @params = new()
            {
                self = self
            };
            _beforeorig_RecordKillForJournal?.Invoke(@params);
            self = @params.self;
            orig(self);
            if (_afterorig_RecordKillForJournal != null) _afterorig_RecordKillForJournal.Invoke(@params);
        }
    }

    /// <summary>
    ///     Contains necessary information to create Hooks. Does not contain any hooks
    /// </summary>
    public static class Delegates
    {
        public delegate void EmitCorpse_BeforeArgs(Params_EmitCorpse args);

        public delegate void EmitCorpse_NormalArgs(Params_EmitCorpse args);

        public delegate void EmitEffects_BeforeArgs(Params_EmitEffects args);

        public delegate void EmitEffects_NormalArgs(Params_EmitEffects args);

        public delegate void EmitEssence_BeforeArgs(Params_EmitEssence args);

        public delegate void EmitEssence_NormalArgs(Params_EmitEssence args);

        public delegate void EmitInfectedEffects_BeforeArgs(Params_EmitInfectedEffects args);

        public delegate void EmitInfectedEffects_NormalArgs(Params_EmitInfectedEffects args);

        public delegate void EmitLargeInfectedEffects_BeforeArgs(Params_EmitLargeInfectedEffects args);

        public delegate void EmitLargeInfectedEffects_NormalArgs(Params_EmitLargeInfectedEffects args);

        public delegate void EmitSmallInfectedEffects_BeforeArgs(Params_EmitSmallInfectedEffects args);

        public delegate void EmitSmallInfectedEffects_NormalArgs(Params_EmitSmallInfectedEffects args);

        public delegate void EmitSound_BeforeArgs(Params_EmitSound args);

        public delegate void EmitSound_NormalArgs(Params_EmitSound args);

        public delegate void orig_RecieveDeathEvent_BeforeArgs(Params_orig_RecieveDeathEvent args);

        public delegate void orig_RecieveDeathEvent_NormalArgs(Params_orig_RecieveDeathEvent args);

        public delegate void orig_RecordKillForJournal_BeforeArgs(Params_orig_RecordKillForJournal args);

        public delegate void orig_RecordKillForJournal_NormalArgs(Params_orig_RecordKillForJournal args);

        public delegate void PreInstantiate_BeforeArgs(Params_PreInstantiate args);

        public delegate void PreInstantiate_NormalArgs(Params_PreInstantiate args);

        public delegate void RecieveDeathEvent_BeforeArgs(Params_RecieveDeathEvent args);

        public delegate void RecieveDeathEvent_NormalArgs(Params_RecieveDeathEvent args);

        public delegate void RecordKillForJournal_BeforeArgs(Params_RecordKillForJournal args);

        public delegate void RecordKillForJournal_NormalArgs(Params_RecordKillForJournal args);

        public delegate void ShakeCameraIfVisible_BeforeArgs(Params_ShakeCameraIfVisible args);

        public delegate void ShakeCameraIfVisible_NormalArgs(Params_ShakeCameraIfVisible args);

        public delegate void Start_BeforeArgs(Params_Start args);

        public delegate void Start_NormalArgs(Params_Start args);

        public sealed class Params_Start
        {
            public EnemyDeathEffects self;
        }

        public sealed class Params_PreInstantiate
        {
            public EnemyDeathEffects self;
        }

        public sealed class Params_RecieveDeathEvent
        {
            public float? attackDirection;
            public bool isWatery;
            public bool resetDeathEvent;
            public EnemyDeathEffects self;
            public bool spellBurn;
        }

        public sealed class Params_RecordKillForJournal
        {
            public EnemyDeathEffects self;
        }

        public sealed class Params_EmitCorpse
        {
            public float? attackDirection;
            public bool isWatery;
            public EnemyDeathEffects self;
            public bool spellBurn;
        }

        public sealed class Params_EmitEffects
        {
            public EnemyDeathEffects self;
        }

        public sealed class Params_EmitSound
        {
            public EnemyDeathEffects self;
        }

        public sealed class Params_EmitInfectedEffects
        {
            public EnemyDeathEffects self;
        }

        public sealed class Params_EmitSmallInfectedEffects
        {
            public EnemyDeathEffects self;
        }

        public sealed class Params_EmitLargeInfectedEffects
        {
            public EnemyDeathEffects self;
        }

        public sealed class Params_ShakeCameraIfVisible
        {
            public string eventName;
            public EnemyDeathEffects self;
        }

        public sealed class Params_EmitEssence
        {
            public EnemyDeathEffects self;
        }

        public sealed class Params_orig_RecieveDeathEvent
        {
            public float? attackDirection;
            public bool isWatery;
            public bool resetDeathEvent;
            public EnemyDeathEffects self;
            public bool spellBurn;
        }

        public sealed class Params_orig_RecordKillForJournal
        {
            public EnemyDeathEffects self;
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

        public static event Delegates.PreInstantiate_BeforeArgs PreInstantiate
        {
            add
            {
                HookHandler._beforePreInstantiate += value;
                HookHandler.HookPreInstantiate();
            }
            remove => HookHandler._beforePreInstantiate -= value;
        }

        public static event Delegates.RecieveDeathEvent_BeforeArgs RecieveDeathEvent
        {
            add
            {
                HookHandler._beforeRecieveDeathEvent += value;
                HookHandler.HookRecieveDeathEvent();
            }
            remove => HookHandler._beforeRecieveDeathEvent -= value;
        }

        public static event Delegates.RecordKillForJournal_BeforeArgs RecordKillForJournal
        {
            add
            {
                HookHandler._beforeRecordKillForJournal += value;
                HookHandler.HookRecordKillForJournal();
            }
            remove => HookHandler._beforeRecordKillForJournal -= value;
        }

        public static event Delegates.EmitCorpse_BeforeArgs EmitCorpse
        {
            add
            {
                HookHandler._beforeEmitCorpse += value;
                HookHandler.HookEmitCorpse();
            }
            remove => HookHandler._beforeEmitCorpse -= value;
        }

        public static event Delegates.EmitEffects_BeforeArgs EmitEffects
        {
            add
            {
                HookHandler._beforeEmitEffects += value;
                HookHandler.HookEmitEffects();
            }
            remove => HookHandler._beforeEmitEffects -= value;
        }

        public static event Delegates.EmitSound_BeforeArgs EmitSound
        {
            add
            {
                HookHandler._beforeEmitSound += value;
                HookHandler.HookEmitSound();
            }
            remove => HookHandler._beforeEmitSound -= value;
        }

        public static event Delegates.EmitInfectedEffects_BeforeArgs EmitInfectedEffects
        {
            add
            {
                HookHandler._beforeEmitInfectedEffects += value;
                HookHandler.HookEmitInfectedEffects();
            }
            remove => HookHandler._beforeEmitInfectedEffects -= value;
        }

        public static event Delegates.EmitSmallInfectedEffects_BeforeArgs EmitSmallInfectedEffects
        {
            add
            {
                HookHandler._beforeEmitSmallInfectedEffects += value;
                HookHandler.HookEmitSmallInfectedEffects();
            }
            remove => HookHandler._beforeEmitSmallInfectedEffects -= value;
        }

        public static event Delegates.EmitLargeInfectedEffects_BeforeArgs EmitLargeInfectedEffects
        {
            add
            {
                HookHandler._beforeEmitLargeInfectedEffects += value;
                HookHandler.HookEmitLargeInfectedEffects();
            }
            remove => HookHandler._beforeEmitLargeInfectedEffects -= value;
        }

        public static event Delegates.ShakeCameraIfVisible_BeforeArgs ShakeCameraIfVisible
        {
            add
            {
                HookHandler._beforeShakeCameraIfVisible += value;
                HookHandler.HookShakeCameraIfVisible();
            }
            remove => HookHandler._beforeShakeCameraIfVisible -= value;
        }

        public static event Delegates.EmitEssence_BeforeArgs EmitEssence
        {
            add
            {
                HookHandler._beforeEmitEssence += value;
                HookHandler.HookEmitEssence();
            }
            remove => HookHandler._beforeEmitEssence -= value;
        }

        public static event Delegates.orig_RecieveDeathEvent_BeforeArgs orig_RecieveDeathEvent
        {
            add
            {
                HookHandler._beforeorig_RecieveDeathEvent += value;
                HookHandler.Hookorig_RecieveDeathEvent();
            }
            remove => HookHandler._beforeorig_RecieveDeathEvent -= value;
        }

        public static event Delegates.orig_RecordKillForJournal_BeforeArgs orig_RecordKillForJournal
        {
            add
            {
                HookHandler._beforeorig_RecordKillForJournal += value;
                HookHandler.Hookorig_RecordKillForJournal();
            }
            remove => HookHandler._beforeorig_RecordKillForJournal -= value;
        }
    }

    /// <summary>
    ///     Contains Hooks to that run code after orig(self) is called
    /// </summary>
    public static class AfterOrig
    {
        public static event Delegates.Start_NormalArgs Start
        {
            add
            {
                HookHandler._afterStart += value;
                HookHandler.HookStart();
            }
            remove => HookHandler._afterStart -= value;
        }

        public static event Delegates.PreInstantiate_NormalArgs PreInstantiate
        {
            add
            {
                HookHandler._afterPreInstantiate += value;
                HookHandler.HookPreInstantiate();
            }
            remove => HookHandler._afterPreInstantiate -= value;
        }

        public static event Delegates.RecieveDeathEvent_NormalArgs RecieveDeathEvent
        {
            add
            {
                HookHandler._afterRecieveDeathEvent += value;
                HookHandler.HookRecieveDeathEvent();
            }
            remove => HookHandler._afterRecieveDeathEvent -= value;
        }

        public static event Delegates.RecordKillForJournal_NormalArgs RecordKillForJournal
        {
            add
            {
                HookHandler._afterRecordKillForJournal += value;
                HookHandler.HookRecordKillForJournal();
            }
            remove => HookHandler._afterRecordKillForJournal -= value;
        }

        public static event Delegates.EmitCorpse_NormalArgs EmitCorpse
        {
            add
            {
                HookHandler._afterEmitCorpse += value;
                HookHandler.HookEmitCorpse();
            }
            remove => HookHandler._afterEmitCorpse -= value;
        }

        public static event Delegates.EmitEffects_NormalArgs EmitEffects
        {
            add
            {
                HookHandler._afterEmitEffects += value;
                HookHandler.HookEmitEffects();
            }
            remove => HookHandler._afterEmitEffects -= value;
        }

        public static event Delegates.EmitSound_NormalArgs EmitSound
        {
            add
            {
                HookHandler._afterEmitSound += value;
                HookHandler.HookEmitSound();
            }
            remove => HookHandler._afterEmitSound -= value;
        }

        public static event Delegates.EmitInfectedEffects_NormalArgs EmitInfectedEffects
        {
            add
            {
                HookHandler._afterEmitInfectedEffects += value;
                HookHandler.HookEmitInfectedEffects();
            }
            remove => HookHandler._afterEmitInfectedEffects -= value;
        }

        public static event Delegates.EmitSmallInfectedEffects_NormalArgs EmitSmallInfectedEffects
        {
            add
            {
                HookHandler._afterEmitSmallInfectedEffects += value;
                HookHandler.HookEmitSmallInfectedEffects();
            }
            remove => HookHandler._afterEmitSmallInfectedEffects -= value;
        }

        public static event Delegates.EmitLargeInfectedEffects_NormalArgs EmitLargeInfectedEffects
        {
            add
            {
                HookHandler._afterEmitLargeInfectedEffects += value;
                HookHandler.HookEmitLargeInfectedEffects();
            }
            remove => HookHandler._afterEmitLargeInfectedEffects -= value;
        }

        public static event Delegates.ShakeCameraIfVisible_NormalArgs ShakeCameraIfVisible
        {
            add
            {
                HookHandler._afterShakeCameraIfVisible += value;
                HookHandler.HookShakeCameraIfVisible();
            }
            remove => HookHandler._afterShakeCameraIfVisible -= value;
        }

        public static event Delegates.EmitEssence_NormalArgs EmitEssence
        {
            add
            {
                HookHandler._afterEmitEssence += value;
                HookHandler.HookEmitEssence();
            }
            remove => HookHandler._afterEmitEssence -= value;
        }

        public static event Delegates.orig_RecieveDeathEvent_NormalArgs orig_RecieveDeathEvent
        {
            add
            {
                HookHandler._afterorig_RecieveDeathEvent += value;
                HookHandler.Hookorig_RecieveDeathEvent();
            }
            remove => HookHandler._afterorig_RecieveDeathEvent -= value;
        }

        public static event Delegates.orig_RecordKillForJournal_NormalArgs orig_RecordKillForJournal
        {
            add
            {
                HookHandler._afterorig_RecordKillForJournal += value;
                HookHandler.Hookorig_RecordKillForJournal();
            }
            remove => HookHandler._afterorig_RecordKillForJournal -= value;
        }
    }

    /// <summary>
    ///     Contains all On Hooks, even those that aren't in the On namespace such as API generated functions and property
    ///     getters/setters
    /// </summary>
    public static class WithOrig
    {
        public static event On.EnemyDeathEffects.hook_Start Start
        {
            add => On.EnemyDeathEffects.Start += value;
            remove => On.EnemyDeathEffects.Start -= value;
        }

        public static event On.EnemyDeathEffects.hook_PreInstantiate PreInstantiate
        {
            add => On.EnemyDeathEffects.PreInstantiate += value;
            remove => On.EnemyDeathEffects.PreInstantiate -= value;
        }

        public static event On.EnemyDeathEffects.hook_RecieveDeathEvent RecieveDeathEvent
        {
            add => On.EnemyDeathEffects.RecieveDeathEvent += value;
            remove => On.EnemyDeathEffects.RecieveDeathEvent -= value;
        }

        public static event On.EnemyDeathEffects.hook_RecordKillForJournal RecordKillForJournal
        {
            add => On.EnemyDeathEffects.RecordKillForJournal += value;
            remove => On.EnemyDeathEffects.RecordKillForJournal -= value;
        }

        public static event On.EnemyDeathEffects.hook_EmitCorpse EmitCorpse
        {
            add => On.EnemyDeathEffects.EmitCorpse += value;
            remove => On.EnemyDeathEffects.EmitCorpse -= value;
        }

        public static event On.EnemyDeathEffects.hook_EmitEffects EmitEffects
        {
            add => On.EnemyDeathEffects.EmitEffects += value;
            remove => On.EnemyDeathEffects.EmitEffects -= value;
        }

        public static event On.EnemyDeathEffects.hook_EmitSound EmitSound
        {
            add => On.EnemyDeathEffects.EmitSound += value;
            remove => On.EnemyDeathEffects.EmitSound -= value;
        }

        public static event On.EnemyDeathEffects.hook_EmitInfectedEffects EmitInfectedEffects
        {
            add => On.EnemyDeathEffects.EmitInfectedEffects += value;
            remove => On.EnemyDeathEffects.EmitInfectedEffects -= value;
        }

        public static event On.EnemyDeathEffects.hook_EmitSmallInfectedEffects EmitSmallInfectedEffects
        {
            add => On.EnemyDeathEffects.EmitSmallInfectedEffects += value;
            remove => On.EnemyDeathEffects.EmitSmallInfectedEffects -= value;
        }

        public static event On.EnemyDeathEffects.hook_EmitLargeInfectedEffects EmitLargeInfectedEffects
        {
            add => On.EnemyDeathEffects.EmitLargeInfectedEffects += value;
            remove => On.EnemyDeathEffects.EmitLargeInfectedEffects -= value;
        }

        public static event On.EnemyDeathEffects.hook_ShakeCameraIfVisible ShakeCameraIfVisible
        {
            add => On.EnemyDeathEffects.ShakeCameraIfVisible += value;
            remove => On.EnemyDeathEffects.ShakeCameraIfVisible -= value;
        }

        public static event On.EnemyDeathEffects.hook_EmitEssence EmitEssence
        {
            add => On.EnemyDeathEffects.EmitEssence += value;
            remove => On.EnemyDeathEffects.EmitEssence -= value;
        }

        public static event Delegates.orig_RecieveDeathEvent_NormalArgs orig_RecieveDeathEvent
        {
            add => HookEndpointManager.Add<Delegates.orig_RecieveDeathEvent_NormalArgs>(
                ReflectionHelper.GetMethodInfo(typeof(EnemyDeathEffects), "orig_RecieveDeathEvent"), value);
            remove => HookEndpointManager.Remove<Delegates.orig_RecieveDeathEvent_NormalArgs>(
                ReflectionHelper.GetMethodInfo(typeof(EnemyDeathEffects), "orig_RecieveDeathEvent"), value);
        }

        public static event Delegates.orig_RecordKillForJournal_NormalArgs orig_RecordKillForJournal
        {
            add => HookEndpointManager.Add<Delegates.orig_RecordKillForJournal_NormalArgs>(
                ReflectionHelper.GetMethodInfo(typeof(EnemyDeathEffects), "orig_RecordKillForJournal"), value);
            remove => HookEndpointManager.Remove<Delegates.orig_RecordKillForJournal_NormalArgs>(
                ReflectionHelper.GetMethodInfo(typeof(EnemyDeathEffects), "orig_RecordKillForJournal"), value);
        }
    }
}