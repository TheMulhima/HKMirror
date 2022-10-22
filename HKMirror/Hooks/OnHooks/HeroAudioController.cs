namespace HKMirror.Hooks.OnHooks;

/// <summary>
///     Contains different types of On Hooks for HeroAudioController class.<br />
///     Contains hooks that aren't generated by monomod, and before and after orig hooks for easier hooking.
/// </summary>
public static class OnHeroAudioController
{
    internal static class HookHandler
    {
        private static readonly List<string> HookedList = new();

        internal static void HookAwake()
        {
            if (!HookedList.Contains("Awake"))
            {
                HookedList.Add("Awake");
                On.HeroAudioController.Awake += Awake;
            }
        }

        internal static event Delegates.Awake_BeforeArgs _beforeAwake;
        internal static event Delegates.Awake_AfterArgs _afterAwake;

        private static void Awake(On.HeroAudioController.orig_Awake orig, HeroAudioController self)
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

        internal static void HookPlaySound()
        {
            if (!HookedList.Contains("PlaySound"))
            {
                HookedList.Add("PlaySound");
                On.HeroAudioController.PlaySound += PlaySound;
            }
        }

        internal static event Delegates.PlaySound_BeforeArgs _beforePlaySound;
        internal static event Delegates.PlaySound_AfterArgs _afterPlaySound;

        private static void PlaySound(On.HeroAudioController.orig_PlaySound orig, HeroAudioController self,
            HeroSounds soundEffect)
        {
            Delegates.Params_PlaySound @params = new()
            {
                self = self, soundEffect = soundEffect
            };
            if (_beforePlaySound != null)
                foreach (Delegates.PlaySound_BeforeArgs toInvoke in _beforePlaySound.GetInvocationList())
                    try
                    {
                        _beforePlaySound?.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }

            self = @params.self;
            soundEffect = @params.soundEffect;
            orig(self, soundEffect);
            if (_afterPlaySound != null)
                foreach (Delegates.PlaySound_AfterArgs toInvoke in _afterPlaySound.GetInvocationList())
                    try
                    {
                        _afterPlaySound.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }
        }

        internal static void HookStopSound()
        {
            if (!HookedList.Contains("StopSound"))
            {
                HookedList.Add("StopSound");
                On.HeroAudioController.StopSound += StopSound;
            }
        }

        internal static event Delegates.StopSound_BeforeArgs _beforeStopSound;
        internal static event Delegates.StopSound_AfterArgs _afterStopSound;

        private static void StopSound(On.HeroAudioController.orig_StopSound orig, HeroAudioController self,
            HeroSounds soundEffect)
        {
            Delegates.Params_StopSound @params = new()
            {
                self = self, soundEffect = soundEffect
            };
            if (_beforeStopSound != null)
                foreach (Delegates.StopSound_BeforeArgs toInvoke in _beforeStopSound.GetInvocationList())
                    try
                    {
                        _beforeStopSound?.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }

            self = @params.self;
            soundEffect = @params.soundEffect;
            orig(self, soundEffect);
            if (_afterStopSound != null)
                foreach (Delegates.StopSound_AfterArgs toInvoke in _afterStopSound.GetInvocationList())
                    try
                    {
                        _afterStopSound.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }
        }

        internal static void HookStopAllSounds()
        {
            if (!HookedList.Contains("StopAllSounds"))
            {
                HookedList.Add("StopAllSounds");
                On.HeroAudioController.StopAllSounds += StopAllSounds;
            }
        }

        internal static event Delegates.StopAllSounds_BeforeArgs _beforeStopAllSounds;
        internal static event Delegates.StopAllSounds_AfterArgs _afterStopAllSounds;

        private static void StopAllSounds(On.HeroAudioController.orig_StopAllSounds orig, HeroAudioController self)
        {
            Delegates.Params_StopAllSounds @params = new()
            {
                self = self
            };
            if (_beforeStopAllSounds != null)
                foreach (Delegates.StopAllSounds_BeforeArgs toInvoke in _beforeStopAllSounds.GetInvocationList())
                    try
                    {
                        _beforeStopAllSounds?.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }

            self = @params.self;
            orig(self);
            if (_afterStopAllSounds != null)
                foreach (Delegates.StopAllSounds_AfterArgs toInvoke in _afterStopAllSounds.GetInvocationList())
                    try
                    {
                        _afterStopAllSounds.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }
        }

        internal static void HookPauseAllSounds()
        {
            if (!HookedList.Contains("PauseAllSounds"))
            {
                HookedList.Add("PauseAllSounds");
                On.HeroAudioController.PauseAllSounds += PauseAllSounds;
            }
        }

        internal static event Delegates.PauseAllSounds_BeforeArgs _beforePauseAllSounds;
        internal static event Delegates.PauseAllSounds_AfterArgs _afterPauseAllSounds;

        private static void PauseAllSounds(On.HeroAudioController.orig_PauseAllSounds orig, HeroAudioController self)
        {
            Delegates.Params_PauseAllSounds @params = new()
            {
                self = self
            };
            if (_beforePauseAllSounds != null)
                foreach (Delegates.PauseAllSounds_BeforeArgs toInvoke in _beforePauseAllSounds.GetInvocationList())
                    try
                    {
                        _beforePauseAllSounds?.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }

            self = @params.self;
            orig(self);
            if (_afterPauseAllSounds != null)
                foreach (Delegates.PauseAllSounds_AfterArgs toInvoke in _afterPauseAllSounds.GetInvocationList())
                    try
                    {
                        _afterPauseAllSounds.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }
        }

        internal static void HookUnPauseAllSounds()
        {
            if (!HookedList.Contains("UnPauseAllSounds"))
            {
                HookedList.Add("UnPauseAllSounds");
                On.HeroAudioController.UnPauseAllSounds += UnPauseAllSounds;
            }
        }

        internal static event Delegates.UnPauseAllSounds_BeforeArgs _beforeUnPauseAllSounds;
        internal static event Delegates.UnPauseAllSounds_AfterArgs _afterUnPauseAllSounds;

        private static void UnPauseAllSounds(On.HeroAudioController.orig_UnPauseAllSounds orig,
            HeroAudioController self)
        {
            Delegates.Params_UnPauseAllSounds @params = new()
            {
                self = self
            };
            if (_beforeUnPauseAllSounds != null)
                foreach (Delegates.UnPauseAllSounds_BeforeArgs toInvoke in _beforeUnPauseAllSounds.GetInvocationList())
                    try
                    {
                        _beforeUnPauseAllSounds?.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }

            self = @params.self;
            orig(self);
            if (_afterUnPauseAllSounds != null)
                foreach (Delegates.UnPauseAllSounds_AfterArgs toInvoke in _afterUnPauseAllSounds.GetInvocationList())
                    try
                    {
                        _afterUnPauseAllSounds.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }
        }

        internal static void HookRandomizePitch()
        {
            if (!HookedList.Contains("RandomizePitch"))
            {
                HookedList.Add("RandomizePitch");
                On.HeroAudioController.RandomizePitch += RandomizePitch;
            }
        }

        internal static event Delegates.RandomizePitch_BeforeArgs _beforeRandomizePitch;
        internal static event Delegates.RandomizePitch_AfterArgs _afterRandomizePitch;

        private static void RandomizePitch(On.HeroAudioController.orig_RandomizePitch orig, HeroAudioController self,
            AudioSource src, float minPitch, float maxPitch)
        {
            Delegates.Params_RandomizePitch @params = new()
            {
                self = self, src = src, minPitch = minPitch, maxPitch = maxPitch
            };
            if (_beforeRandomizePitch != null)
                foreach (Delegates.RandomizePitch_BeforeArgs toInvoke in _beforeRandomizePitch.GetInvocationList())
                    try
                    {
                        _beforeRandomizePitch?.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }

            self = @params.self;
            src = @params.src;
            minPitch = @params.minPitch;
            maxPitch = @params.maxPitch;
            orig(self, src, minPitch, maxPitch);
            if (_afterRandomizePitch != null)
                foreach (Delegates.RandomizePitch_AfterArgs toInvoke in _afterRandomizePitch.GetInvocationList())
                    try
                    {
                        _afterRandomizePitch.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }
        }

        internal static void HookResetPitch()
        {
            if (!HookedList.Contains("ResetPitch"))
            {
                HookedList.Add("ResetPitch");
                On.HeroAudioController.ResetPitch += ResetPitch;
            }
        }

        internal static event Delegates.ResetPitch_BeforeArgs _beforeResetPitch;
        internal static event Delegates.ResetPitch_AfterArgs _afterResetPitch;

        private static void ResetPitch(On.HeroAudioController.orig_ResetPitch orig, HeroAudioController self,
            AudioSource src)
        {
            Delegates.Params_ResetPitch @params = new()
            {
                self = self, src = src
            };
            if (_beforeResetPitch != null)
                foreach (Delegates.ResetPitch_BeforeArgs toInvoke in _beforeResetPitch.GetInvocationList())
                    try
                    {
                        _beforeResetPitch?.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }

            self = @params.self;
            src = @params.src;
            orig(self, src);
            if (_afterResetPitch != null)
                foreach (Delegates.ResetPitch_AfterArgs toInvoke in _afterResetPitch.GetInvocationList())
                    try
                    {
                        _afterResetPitch.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }
        }

        internal static void HookFadeInVolume()
        {
            if (!HookedList.Contains("FadeInVolume"))
            {
                HookedList.Add("FadeInVolume");
                On.HeroAudioController.FadeInVolume += FadeInVolume;
            }
        }

        internal static event Delegates.FadeInVolume_BeforeArgs _beforeFadeInVolume;

        private static IEnumerator FadeInVolume(On.HeroAudioController.orig_FadeInVolume orig, HeroAudioController self,
            AudioSource src, float duration)
        {
            Delegates.Params_FadeInVolume @params = new()
            {
                self = self, src = src, duration = duration
            };
            if (_beforeFadeInVolume != null)
                foreach (Delegates.FadeInVolume_BeforeArgs toInvoke in _beforeFadeInVolume.GetInvocationList())
                    try
                    {
                        _beforeFadeInVolume?.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }

            self = @params.self;
            src = @params.src;
            duration = @params.duration;
            return orig(self, src, duration);
        }
    }

    /// <summary>
    ///     Contains necessary information to create Hooks. Does not contain any hooks
    /// </summary>
    public static class Delegates
    {
        public delegate void Awake_AfterArgs(Params_Awake args);

        public delegate void Awake_BeforeArgs(Params_Awake args);

        public delegate void Awake_WithArgs(Action<HeroAudioController> orig, HeroAudioController self);

        public delegate IEnumerator FadeInVolume_AfterArgs(Params_FadeInVolume args, IEnumerator ret);

        public delegate void FadeInVolume_BeforeArgs(Params_FadeInVolume args);

        public delegate IEnumerator FadeInVolume_WithArgs(
            Func<HeroAudioController, AudioSource, float, IEnumerator> orig, HeroAudioController self, AudioSource src,
            float duration);

        public delegate void PauseAllSounds_AfterArgs(Params_PauseAllSounds args);

        public delegate void PauseAllSounds_BeforeArgs(Params_PauseAllSounds args);

        public delegate void PauseAllSounds_WithArgs(Action<HeroAudioController> orig, HeroAudioController self);

        public delegate void PlaySound_AfterArgs(Params_PlaySound args);

        public delegate void PlaySound_BeforeArgs(Params_PlaySound args);

        public delegate void PlaySound_WithArgs(Action<HeroAudioController, HeroSounds> orig, HeroAudioController self,
            HeroSounds soundEffect);

        public delegate void RandomizePitch_AfterArgs(Params_RandomizePitch args);

        public delegate void RandomizePitch_BeforeArgs(Params_RandomizePitch args);

        public delegate void RandomizePitch_WithArgs(Action<HeroAudioController, AudioSource, float, float> orig,
            HeroAudioController self, AudioSource src, float minPitch, float maxPitch);

        public delegate void ResetPitch_AfterArgs(Params_ResetPitch args);

        public delegate void ResetPitch_BeforeArgs(Params_ResetPitch args);

        public delegate void ResetPitch_WithArgs(Action<HeroAudioController, AudioSource> orig,
            HeroAudioController self, AudioSource src);

        public delegate void StopAllSounds_AfterArgs(Params_StopAllSounds args);

        public delegate void StopAllSounds_BeforeArgs(Params_StopAllSounds args);

        public delegate void StopAllSounds_WithArgs(Action<HeroAudioController> orig, HeroAudioController self);

        public delegate void StopSound_AfterArgs(Params_StopSound args);

        public delegate void StopSound_BeforeArgs(Params_StopSound args);

        public delegate void StopSound_WithArgs(Action<HeroAudioController, HeroSounds> orig, HeroAudioController self,
            HeroSounds soundEffect);

        public delegate void UnPauseAllSounds_AfterArgs(Params_UnPauseAllSounds args);

        public delegate void UnPauseAllSounds_BeforeArgs(Params_UnPauseAllSounds args);

        public delegate void UnPauseAllSounds_WithArgs(Action<HeroAudioController> orig, HeroAudioController self);

        public sealed class Params_Awake
        {
            public HeroAudioController self;
        }

        public sealed class Params_PlaySound
        {
            public HeroAudioController self;
            public HeroSounds soundEffect;
        }

        public sealed class Params_StopSound
        {
            public HeroAudioController self;
            public HeroSounds soundEffect;
        }

        public sealed class Params_StopAllSounds
        {
            public HeroAudioController self;
        }

        public sealed class Params_PauseAllSounds
        {
            public HeroAudioController self;
        }

        public sealed class Params_UnPauseAllSounds
        {
            public HeroAudioController self;
        }

        public sealed class Params_RandomizePitch
        {
            public float maxPitch;
            public float minPitch;
            public HeroAudioController self;
            public AudioSource src;
        }

        public sealed class Params_ResetPitch
        {
            public HeroAudioController self;
            public AudioSource src;
        }

        public sealed class Params_FadeInVolume
        {
            public float duration;
            public HeroAudioController self;
            public AudioSource src;
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

        public static event Delegates.PlaySound_BeforeArgs PlaySound
        {
            add
            {
                HookHandler._beforePlaySound += value;
                HookHandler.HookPlaySound();
            }
            remove => HookHandler._beforePlaySound -= value;
        }

        public static event Delegates.StopSound_BeforeArgs StopSound
        {
            add
            {
                HookHandler._beforeStopSound += value;
                HookHandler.HookStopSound();
            }
            remove => HookHandler._beforeStopSound -= value;
        }

        public static event Delegates.StopAllSounds_BeforeArgs StopAllSounds
        {
            add
            {
                HookHandler._beforeStopAllSounds += value;
                HookHandler.HookStopAllSounds();
            }
            remove => HookHandler._beforeStopAllSounds -= value;
        }

        public static event Delegates.PauseAllSounds_BeforeArgs PauseAllSounds
        {
            add
            {
                HookHandler._beforePauseAllSounds += value;
                HookHandler.HookPauseAllSounds();
            }
            remove => HookHandler._beforePauseAllSounds -= value;
        }

        public static event Delegates.UnPauseAllSounds_BeforeArgs UnPauseAllSounds
        {
            add
            {
                HookHandler._beforeUnPauseAllSounds += value;
                HookHandler.HookUnPauseAllSounds();
            }
            remove => HookHandler._beforeUnPauseAllSounds -= value;
        }

        public static event Delegates.RandomizePitch_BeforeArgs RandomizePitch
        {
            add
            {
                HookHandler._beforeRandomizePitch += value;
                HookHandler.HookRandomizePitch();
            }
            remove => HookHandler._beforeRandomizePitch -= value;
        }

        public static event Delegates.ResetPitch_BeforeArgs ResetPitch
        {
            add
            {
                HookHandler._beforeResetPitch += value;
                HookHandler.HookResetPitch();
            }
            remove => HookHandler._beforeResetPitch -= value;
        }

        public static event Delegates.FadeInVolume_BeforeArgs FadeInVolume
        {
            add
            {
                HookHandler._beforeFadeInVolume += value;
                HookHandler.HookFadeInVolume();
            }
            remove => HookHandler._beforeFadeInVolume -= value;
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

        public static event Delegates.PlaySound_AfterArgs PlaySound
        {
            add
            {
                HookHandler._afterPlaySound += value;
                HookHandler.HookPlaySound();
            }
            remove => HookHandler._afterPlaySound -= value;
        }

        public static event Delegates.StopSound_AfterArgs StopSound
        {
            add
            {
                HookHandler._afterStopSound += value;
                HookHandler.HookStopSound();
            }
            remove => HookHandler._afterStopSound -= value;
        }

        public static event Delegates.StopAllSounds_AfterArgs StopAllSounds
        {
            add
            {
                HookHandler._afterStopAllSounds += value;
                HookHandler.HookStopAllSounds();
            }
            remove => HookHandler._afterStopAllSounds -= value;
        }

        public static event Delegates.PauseAllSounds_AfterArgs PauseAllSounds
        {
            add
            {
                HookHandler._afterPauseAllSounds += value;
                HookHandler.HookPauseAllSounds();
            }
            remove => HookHandler._afterPauseAllSounds -= value;
        }

        public static event Delegates.UnPauseAllSounds_AfterArgs UnPauseAllSounds
        {
            add
            {
                HookHandler._afterUnPauseAllSounds += value;
                HookHandler.HookUnPauseAllSounds();
            }
            remove => HookHandler._afterUnPauseAllSounds -= value;
        }

        public static event Delegates.RandomizePitch_AfterArgs RandomizePitch
        {
            add
            {
                HookHandler._afterRandomizePitch += value;
                HookHandler.HookRandomizePitch();
            }
            remove => HookHandler._afterRandomizePitch -= value;
        }

        public static event Delegates.ResetPitch_AfterArgs ResetPitch
        {
            add
            {
                HookHandler._afterResetPitch += value;
                HookHandler.HookResetPitch();
            }
            remove => HookHandler._afterResetPitch -= value;
        }
    }

    /// <summary>
    ///     Contains all On Hooks, even those that aren't in the On namespace such as API generated functions and property
    ///     getters/setters
    /// </summary>
    public static class WithOrig
    {
        public static event On.HeroAudioController.hook_Awake Awake
        {
            add => On.HeroAudioController.Awake += value;
            remove => On.HeroAudioController.Awake -= value;
        }

        public static event On.HeroAudioController.hook_PlaySound PlaySound
        {
            add => On.HeroAudioController.PlaySound += value;
            remove => On.HeroAudioController.PlaySound -= value;
        }

        public static event On.HeroAudioController.hook_StopSound StopSound
        {
            add => On.HeroAudioController.StopSound += value;
            remove => On.HeroAudioController.StopSound -= value;
        }

        public static event On.HeroAudioController.hook_StopAllSounds StopAllSounds
        {
            add => On.HeroAudioController.StopAllSounds += value;
            remove => On.HeroAudioController.StopAllSounds -= value;
        }

        public static event On.HeroAudioController.hook_PauseAllSounds PauseAllSounds
        {
            add => On.HeroAudioController.PauseAllSounds += value;
            remove => On.HeroAudioController.PauseAllSounds -= value;
        }

        public static event On.HeroAudioController.hook_UnPauseAllSounds UnPauseAllSounds
        {
            add => On.HeroAudioController.UnPauseAllSounds += value;
            remove => On.HeroAudioController.UnPauseAllSounds -= value;
        }

        public static event On.HeroAudioController.hook_RandomizePitch RandomizePitch
        {
            add => On.HeroAudioController.RandomizePitch += value;
            remove => On.HeroAudioController.RandomizePitch -= value;
        }

        public static event On.HeroAudioController.hook_ResetPitch ResetPitch
        {
            add => On.HeroAudioController.ResetPitch += value;
            remove => On.HeroAudioController.ResetPitch -= value;
        }

        public static event On.HeroAudioController.hook_FadeInVolume FadeInVolume
        {
            add => On.HeroAudioController.FadeInVolume += value;
            remove => On.HeroAudioController.FadeInVolume -= value;
        }
    }
}