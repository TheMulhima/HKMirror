using MonoMod.RuntimeDetour;
using MonoMod.RuntimeDetour.HookGen;

namespace HKMirror.Hooks.OnHooks;

/// <summary>
/// Contains different types of On Hooks for AudioManager class.<br />
/// Contains hooks that aren't generated by monomod, and before and after orig hooks for easier hooking.
/// </summary>
public static class OnAudioManager
{
    internal static class HookHandler
    {
        private static List<string> HookedList = new List<string>();

        internal static void Hookget_CurrentMusicCue()
        {
            if (!HookedList.Contains("get_CurrentMusicCue"))
            {
                HookedList.Add("get_CurrentMusicCue");
                new Hook(ReflectionHelper.GetMethodInfo(typeof(AudioManager), "get_CurrentMusicCue", true),
                    get_CurrentMusicCue);
            }
        }

        internal static event Delegates.get_CurrentMusicCue_BeforeArgs _beforeget_CurrentMusicCue;
        internal static event Delegates.get_CurrentMusicCue_AfterArgs _afterget_CurrentMusicCue;

        private static MusicCue get_CurrentMusicCue(Func<AudioManager, MusicCue> orig, AudioManager self)
        {
            Delegates.Params_get_CurrentMusicCue @params = new()
            {
                self = self
            };
            if (_beforeget_CurrentMusicCue != null)
            {
                foreach (Delegates.get_CurrentMusicCue_BeforeArgs toInvoke in _beforeget_CurrentMusicCue
                             .GetInvocationList())
                {
                    try
                    {
                        _beforeget_CurrentMusicCue?.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }
                }
            }

            self = @params.self;
            var retVal = orig(self);
            if (_afterget_CurrentMusicCue != null)
            {
                foreach (Delegates.get_CurrentMusicCue_AfterArgs toInvoke in
                         _afterget_CurrentMusicCue.GetInvocationList())
                {
                    try
                    {
                        retVal = _afterget_CurrentMusicCue.Invoke(@params, retVal);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }
                }
            }

            return retVal;
        }

        internal static void HookStart()
        {
            if (!HookedList.Contains("Start"))
            {
                HookedList.Add("Start");
                On.AudioManager.Start += Start;
            }
        }

        internal static event Delegates.Start_BeforeArgs _beforeStart;
        internal static event Delegates.Start_AfterArgs _afterStart;

        private static void Start(On.AudioManager.orig_Start orig, AudioManager self)
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

        internal static void HookApplyAtmosCue()
        {
            if (!HookedList.Contains("ApplyAtmosCue"))
            {
                HookedList.Add("ApplyAtmosCue");
                On.AudioManager.ApplyAtmosCue += ApplyAtmosCue;
            }
        }

        internal static event Delegates.ApplyAtmosCue_BeforeArgs _beforeApplyAtmosCue;
        internal static event Delegates.ApplyAtmosCue_AfterArgs _afterApplyAtmosCue;

        private static void ApplyAtmosCue(On.AudioManager.orig_ApplyAtmosCue orig, AudioManager self, AtmosCue atmosCue,
            float transitionTime)
        {
            Delegates.Params_ApplyAtmosCue @params = new()
            {
                self = self, atmosCue = atmosCue, transitionTime = transitionTime
            };
            if (_beforeApplyAtmosCue != null)
            {
                foreach (Delegates.ApplyAtmosCue_BeforeArgs toInvoke in _beforeApplyAtmosCue.GetInvocationList())
                {
                    try
                    {
                        _beforeApplyAtmosCue?.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }
                }
            }

            self = @params.self;
            atmosCue = @params.atmosCue;
            transitionTime = @params.transitionTime;
            orig(self, atmosCue, transitionTime);
            if (_afterApplyAtmosCue != null)
            {
                foreach (Delegates.ApplyAtmosCue_AfterArgs toInvoke in _afterApplyAtmosCue.GetInvocationList())
                {
                    try
                    {
                        _afterApplyAtmosCue.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }
                }
            }
        }

        internal static void HookBeginApplyAtmosCue()
        {
            if (!HookedList.Contains("BeginApplyAtmosCue"))
            {
                HookedList.Add("BeginApplyAtmosCue");
                On.AudioManager.BeginApplyAtmosCue += BeginApplyAtmosCue;
            }
        }

        internal static event Delegates.BeginApplyAtmosCue_BeforeArgs _beforeBeginApplyAtmosCue;

        private static System.Collections.IEnumerator BeginApplyAtmosCue(On.AudioManager.orig_BeginApplyAtmosCue orig,
            AudioManager self, AtmosCue atmosCue, float transitionTime)
        {
            Delegates.Params_BeginApplyAtmosCue @params = new()
            {
                self = self, atmosCue = atmosCue, transitionTime = transitionTime
            };
            if (_beforeBeginApplyAtmosCue != null)
            {
                foreach (Delegates.BeginApplyAtmosCue_BeforeArgs toInvoke in
                         _beforeBeginApplyAtmosCue.GetInvocationList())
                {
                    try
                    {
                        _beforeBeginApplyAtmosCue?.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }
                }
            }

            self = @params.self;
            atmosCue = @params.atmosCue;
            transitionTime = @params.transitionTime;
            return orig(self, atmosCue, transitionTime);
        }

        internal static void HookApplyMusicCue()
        {
            if (!HookedList.Contains("ApplyMusicCue"))
            {
                HookedList.Add("ApplyMusicCue");
                On.AudioManager.ApplyMusicCue += ApplyMusicCue;
            }
        }

        internal static event Delegates.ApplyMusicCue_BeforeArgs _beforeApplyMusicCue;
        internal static event Delegates.ApplyMusicCue_AfterArgs _afterApplyMusicCue;

        private static void ApplyMusicCue(On.AudioManager.orig_ApplyMusicCue orig, AudioManager self, MusicCue musicCue,
            float delayTime, float transitionTime, bool applySnapshot)
        {
            Delegates.Params_ApplyMusicCue @params = new()
            {
                self = self, musicCue = musicCue, delayTime = delayTime, transitionTime = transitionTime,
                applySnapshot = applySnapshot
            };
            if (_beforeApplyMusicCue != null)
            {
                foreach (Delegates.ApplyMusicCue_BeforeArgs toInvoke in _beforeApplyMusicCue.GetInvocationList())
                {
                    try
                    {
                        _beforeApplyMusicCue?.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }
                }
            }

            self = @params.self;
            musicCue = @params.musicCue;
            delayTime = @params.delayTime;
            transitionTime = @params.transitionTime;
            applySnapshot = @params.applySnapshot;
            orig(self, musicCue, delayTime, transitionTime, applySnapshot);
            if (_afterApplyMusicCue != null)
            {
                foreach (Delegates.ApplyMusicCue_AfterArgs toInvoke in _afterApplyMusicCue.GetInvocationList())
                {
                    try
                    {
                        _afterApplyMusicCue.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }
                }
            }
        }

        internal static void HookBeginApplyMusicCue()
        {
            if (!HookedList.Contains("BeginApplyMusicCue"))
            {
                HookedList.Add("BeginApplyMusicCue");
                On.AudioManager.BeginApplyMusicCue += BeginApplyMusicCue;
            }
        }

        internal static event Delegates.BeginApplyMusicCue_BeforeArgs _beforeBeginApplyMusicCue;

        private static System.Collections.IEnumerator BeginApplyMusicCue(On.AudioManager.orig_BeginApplyMusicCue orig,
            AudioManager self, MusicCue musicCue, float delayTime, float transitionTime, bool applySnapshot)
        {
            Delegates.Params_BeginApplyMusicCue @params = new()
            {
                self = self, musicCue = musicCue, delayTime = delayTime, transitionTime = transitionTime,
                applySnapshot = applySnapshot
            };
            if (_beforeBeginApplyMusicCue != null)
            {
                foreach (Delegates.BeginApplyMusicCue_BeforeArgs toInvoke in
                         _beforeBeginApplyMusicCue.GetInvocationList())
                {
                    try
                    {
                        _beforeBeginApplyMusicCue?.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }
                }
            }

            self = @params.self;
            musicCue = @params.musicCue;
            delayTime = @params.delayTime;
            transitionTime = @params.transitionTime;
            applySnapshot = @params.applySnapshot;
            return orig(self, musicCue, delayTime, transitionTime, applySnapshot);
        }

        internal static void HookUpdateMusicSync()
        {
            if (!HookedList.Contains("UpdateMusicSync"))
            {
                HookedList.Add("UpdateMusicSync");
                On.AudioManager.UpdateMusicSync += UpdateMusicSync;
            }
        }

        internal static event Delegates.UpdateMusicSync_BeforeArgs _beforeUpdateMusicSync;
        internal static event Delegates.UpdateMusicSync_AfterArgs _afterUpdateMusicSync;

        private static void UpdateMusicSync(On.AudioManager.orig_UpdateMusicSync orig, AudioManager self,
            MusicChannels musicChannel, bool isSyncRequired)
        {
            Delegates.Params_UpdateMusicSync @params = new()
            {
                self = self, musicChannel = musicChannel, isSyncRequired = isSyncRequired
            };
            if (_beforeUpdateMusicSync != null)
            {
                foreach (Delegates.UpdateMusicSync_BeforeArgs toInvoke in _beforeUpdateMusicSync.GetInvocationList())
                {
                    try
                    {
                        _beforeUpdateMusicSync?.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }
                }
            }

            self = @params.self;
            musicChannel = @params.musicChannel;
            isSyncRequired = @params.isSyncRequired;
            orig(self, musicChannel, isSyncRequired);
            if (_afterUpdateMusicSync != null)
            {
                foreach (Delegates.UpdateMusicSync_AfterArgs toInvoke in _afterUpdateMusicSync.GetInvocationList())
                {
                    try
                    {
                        _afterUpdateMusicSync.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }
                }
            }
        }

        internal static void HookApplyMusicSnapshot()
        {
            if (!HookedList.Contains("ApplyMusicSnapshot"))
            {
                HookedList.Add("ApplyMusicSnapshot");
                On.AudioManager.ApplyMusicSnapshot += ApplyMusicSnapshot;
            }
        }

        internal static event Delegates.ApplyMusicSnapshot_BeforeArgs _beforeApplyMusicSnapshot;
        internal static event Delegates.ApplyMusicSnapshot_AfterArgs _afterApplyMusicSnapshot;

        private static void ApplyMusicSnapshot(On.AudioManager.orig_ApplyMusicSnapshot orig, AudioManager self,
            UnityEngine.Audio.AudioMixerSnapshot snapshot, float delayTime, float transitionTime)
        {
            Delegates.Params_ApplyMusicSnapshot @params = new()
            {
                self = self, snapshot = snapshot, delayTime = delayTime, transitionTime = transitionTime
            };
            if (_beforeApplyMusicSnapshot != null)
            {
                foreach (Delegates.ApplyMusicSnapshot_BeforeArgs toInvoke in
                         _beforeApplyMusicSnapshot.GetInvocationList())
                {
                    try
                    {
                        _beforeApplyMusicSnapshot?.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }
                }
            }

            self = @params.self;
            snapshot = @params.snapshot;
            delayTime = @params.delayTime;
            transitionTime = @params.transitionTime;
            orig(self, snapshot, delayTime, transitionTime);
            if (_afterApplyMusicSnapshot != null)
            {
                foreach (Delegates.ApplyMusicSnapshot_AfterArgs toInvoke in
                         _afterApplyMusicSnapshot.GetInvocationList())
                {
                    try
                    {
                        _afterApplyMusicSnapshot.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }
                }
            }
        }

        internal static void HookBeginApplyMusicSnapshot()
        {
            if (!HookedList.Contains("BeginApplyMusicSnapshot"))
            {
                HookedList.Add("BeginApplyMusicSnapshot");
                On.AudioManager.BeginApplyMusicSnapshot += BeginApplyMusicSnapshot;
            }
        }

        internal static event Delegates.BeginApplyMusicSnapshot_BeforeArgs _beforeBeginApplyMusicSnapshot;

        private static System.Collections.IEnumerator BeginApplyMusicSnapshot(
            On.AudioManager.orig_BeginApplyMusicSnapshot orig, AudioManager self,
            UnityEngine.Audio.AudioMixerSnapshot snapshot, float delayTime, float transitionTime)
        {
            Delegates.Params_BeginApplyMusicSnapshot @params = new()
            {
                self = self, snapshot = snapshot, delayTime = delayTime, transitionTime = transitionTime
            };
            if (_beforeBeginApplyMusicSnapshot != null)
            {
                foreach (Delegates.BeginApplyMusicSnapshot_BeforeArgs toInvoke in _beforeBeginApplyMusicSnapshot
                             .GetInvocationList())
                {
                    try
                    {
                        _beforeBeginApplyMusicSnapshot?.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }
                }
            }

            self = @params.self;
            snapshot = @params.snapshot;
            delayTime = @params.delayTime;
            transitionTime = @params.transitionTime;
            return orig(self, snapshot, delayTime, transitionTime);
        }
    }

    /// <summary>
    /// Contains necessary information to create Hooks. Does not contain any hooks
    /// </summary>
    public static class Delegates
    {
        public sealed class Params_get_CurrentMusicCue
        {
            public AudioManager self;
        }

        public delegate void get_CurrentMusicCue_BeforeArgs(Params_get_CurrentMusicCue args);

        public delegate MusicCue get_CurrentMusicCue_AfterArgs(Params_get_CurrentMusicCue args, MusicCue ret);

        public delegate MusicCue get_CurrentMusicCue_WithArgs(Func<AudioManager, MusicCue> orig, AudioManager self);

        public sealed class Params_Start
        {
            public AudioManager self;
        }

        public delegate void Start_BeforeArgs(Params_Start args);

        public delegate void Start_AfterArgs(Params_Start args);

        public delegate void Start_WithArgs(Action<AudioManager> orig, AudioManager self);

        public sealed class Params_ApplyAtmosCue
        {
            public AudioManager self;
            public AtmosCue atmosCue;
            public float transitionTime;
        }

        public delegate void ApplyAtmosCue_BeforeArgs(Params_ApplyAtmosCue args);

        public delegate void ApplyAtmosCue_AfterArgs(Params_ApplyAtmosCue args);

        public delegate void ApplyAtmosCue_WithArgs(Action<AudioManager, AtmosCue, float> orig, AudioManager self,
            AtmosCue atmosCue, float transitionTime);

        public sealed class Params_BeginApplyAtmosCue
        {
            public AudioManager self;
            public AtmosCue atmosCue;
            public float transitionTime;
        }

        public delegate void BeginApplyAtmosCue_BeforeArgs(Params_BeginApplyAtmosCue args);

        public delegate System.Collections.IEnumerator BeginApplyAtmosCue_AfterArgs(Params_BeginApplyAtmosCue args,
            System.Collections.IEnumerator ret);

        public delegate System.Collections.IEnumerator BeginApplyAtmosCue_WithArgs(
            Func<AudioManager, AtmosCue, float, System.Collections.IEnumerator> orig, AudioManager self,
            AtmosCue atmosCue, float transitionTime);

        public sealed class Params_ApplyMusicCue
        {
            public AudioManager self;
            public MusicCue musicCue;
            public float delayTime;
            public float transitionTime;
            public bool applySnapshot;
        }

        public delegate void ApplyMusicCue_BeforeArgs(Params_ApplyMusicCue args);

        public delegate void ApplyMusicCue_AfterArgs(Params_ApplyMusicCue args);

        public delegate void ApplyMusicCue_WithArgs(Action<AudioManager, MusicCue, float, float, bool> orig,
            AudioManager self, MusicCue musicCue, float delayTime, float transitionTime, bool applySnapshot);

        public sealed class Params_BeginApplyMusicCue
        {
            public AudioManager self;
            public MusicCue musicCue;
            public float delayTime;
            public float transitionTime;
            public bool applySnapshot;
        }

        public delegate void BeginApplyMusicCue_BeforeArgs(Params_BeginApplyMusicCue args);

        public delegate System.Collections.IEnumerator BeginApplyMusicCue_AfterArgs(Params_BeginApplyMusicCue args,
            System.Collections.IEnumerator ret);

        public delegate System.Collections.IEnumerator BeginApplyMusicCue_WithArgs(
            Func<AudioManager, MusicCue, float, float, bool, System.Collections.IEnumerator> orig, AudioManager self,
            MusicCue musicCue, float delayTime, float transitionTime, bool applySnapshot);

        public sealed class Params_UpdateMusicSync
        {
            public AudioManager self;
            public MusicChannels musicChannel;
            public bool isSyncRequired;
        }

        public delegate void UpdateMusicSync_BeforeArgs(Params_UpdateMusicSync args);

        public delegate void UpdateMusicSync_AfterArgs(Params_UpdateMusicSync args);

        public delegate void UpdateMusicSync_WithArgs(Action<AudioManager, MusicChannels, bool> orig, AudioManager self,
            MusicChannels musicChannel, bool isSyncRequired);

        public sealed class Params_ApplyMusicSnapshot
        {
            public AudioManager self;
            public UnityEngine.Audio.AudioMixerSnapshot snapshot;
            public float delayTime;
            public float transitionTime;
        }

        public delegate void ApplyMusicSnapshot_BeforeArgs(Params_ApplyMusicSnapshot args);

        public delegate void ApplyMusicSnapshot_AfterArgs(Params_ApplyMusicSnapshot args);

        public delegate void ApplyMusicSnapshot_WithArgs(
            Action<AudioManager, UnityEngine.Audio.AudioMixerSnapshot, float, float> orig, AudioManager self,
            UnityEngine.Audio.AudioMixerSnapshot snapshot, float delayTime, float transitionTime);

        public sealed class Params_BeginApplyMusicSnapshot
        {
            public AudioManager self;
            public UnityEngine.Audio.AudioMixerSnapshot snapshot;
            public float delayTime;
            public float transitionTime;
        }

        public delegate void BeginApplyMusicSnapshot_BeforeArgs(Params_BeginApplyMusicSnapshot args);

        public delegate System.Collections.IEnumerator BeginApplyMusicSnapshot_AfterArgs(
            Params_BeginApplyMusicSnapshot args, System.Collections.IEnumerator ret);

        public delegate System.Collections.IEnumerator BeginApplyMusicSnapshot_WithArgs(
            Func<AudioManager, UnityEngine.Audio.AudioMixerSnapshot, float, float, System.Collections.IEnumerator> orig,
            AudioManager self, UnityEngine.Audio.AudioMixerSnapshot snapshot, float delayTime, float transitionTime);
    }

    /// <summary>
    /// Contains Hooks to that run code before orig(self) is called
    /// </summary>
    public static class BeforeOrig
    {
        public static event Delegates.get_CurrentMusicCue_BeforeArgs get_CurrentMusicCue
        {
            add
            {
                HookHandler._beforeget_CurrentMusicCue += value;
                HookHandler.Hookget_CurrentMusicCue();
            }
            remove => HookHandler._beforeget_CurrentMusicCue -= value;
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

        public static event Delegates.ApplyAtmosCue_BeforeArgs ApplyAtmosCue
        {
            add
            {
                HookHandler._beforeApplyAtmosCue += value;
                HookHandler.HookApplyAtmosCue();
            }
            remove => HookHandler._beforeApplyAtmosCue -= value;
        }

        public static event Delegates.BeginApplyAtmosCue_BeforeArgs BeginApplyAtmosCue
        {
            add
            {
                HookHandler._beforeBeginApplyAtmosCue += value;
                HookHandler.HookBeginApplyAtmosCue();
            }
            remove => HookHandler._beforeBeginApplyAtmosCue -= value;
        }

        public static event Delegates.ApplyMusicCue_BeforeArgs ApplyMusicCue
        {
            add
            {
                HookHandler._beforeApplyMusicCue += value;
                HookHandler.HookApplyMusicCue();
            }
            remove => HookHandler._beforeApplyMusicCue -= value;
        }

        public static event Delegates.BeginApplyMusicCue_BeforeArgs BeginApplyMusicCue
        {
            add
            {
                HookHandler._beforeBeginApplyMusicCue += value;
                HookHandler.HookBeginApplyMusicCue();
            }
            remove => HookHandler._beforeBeginApplyMusicCue -= value;
        }

        public static event Delegates.UpdateMusicSync_BeforeArgs UpdateMusicSync
        {
            add
            {
                HookHandler._beforeUpdateMusicSync += value;
                HookHandler.HookUpdateMusicSync();
            }
            remove => HookHandler._beforeUpdateMusicSync -= value;
        }

        public static event Delegates.ApplyMusicSnapshot_BeforeArgs ApplyMusicSnapshot
        {
            add
            {
                HookHandler._beforeApplyMusicSnapshot += value;
                HookHandler.HookApplyMusicSnapshot();
            }
            remove => HookHandler._beforeApplyMusicSnapshot -= value;
        }

        public static event Delegates.BeginApplyMusicSnapshot_BeforeArgs BeginApplyMusicSnapshot
        {
            add
            {
                HookHandler._beforeBeginApplyMusicSnapshot += value;
                HookHandler.HookBeginApplyMusicSnapshot();
            }
            remove => HookHandler._beforeBeginApplyMusicSnapshot -= value;
        }
    }

    /// <summary>
    /// Contains Hooks to that run code after orig(self) is called
    /// </summary>
    public static class AfterOrig
    {
        public static event Delegates.get_CurrentMusicCue_AfterArgs get_CurrentMusicCue
        {
            add
            {
                HookHandler._afterget_CurrentMusicCue += value;
                HookHandler.Hookget_CurrentMusicCue();
            }
            remove => HookHandler._afterget_CurrentMusicCue -= value;
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

        public static event Delegates.ApplyAtmosCue_AfterArgs ApplyAtmosCue
        {
            add
            {
                HookHandler._afterApplyAtmosCue += value;
                HookHandler.HookApplyAtmosCue();
            }
            remove => HookHandler._afterApplyAtmosCue -= value;
        }

        public static event Delegates.ApplyMusicCue_AfterArgs ApplyMusicCue
        {
            add
            {
                HookHandler._afterApplyMusicCue += value;
                HookHandler.HookApplyMusicCue();
            }
            remove => HookHandler._afterApplyMusicCue -= value;
        }

        public static event Delegates.UpdateMusicSync_AfterArgs UpdateMusicSync
        {
            add
            {
                HookHandler._afterUpdateMusicSync += value;
                HookHandler.HookUpdateMusicSync();
            }
            remove => HookHandler._afterUpdateMusicSync -= value;
        }

        public static event Delegates.ApplyMusicSnapshot_AfterArgs ApplyMusicSnapshot
        {
            add
            {
                HookHandler._afterApplyMusicSnapshot += value;
                HookHandler.HookApplyMusicSnapshot();
            }
            remove => HookHandler._afterApplyMusicSnapshot -= value;
        }
    }

    /// <summary>
    /// Contains all On Hooks, even those that aren't in the On namespace such as API generated functions and property getters/setters
    /// </summary>
    public static class WithOrig
    {
        public static event Delegates.get_CurrentMusicCue_WithArgs get_CurrentMusicCue
        {
            add => HookEndpointManager.Add<Delegates.get_CurrentMusicCue_WithArgs>(
                ReflectionHelper.GetMethodInfo(typeof(AudioManager), "get_CurrentMusicCue", true), value);
            remove => HookEndpointManager.Remove<Delegates.get_CurrentMusicCue_WithArgs>(
                ReflectionHelper.GetMethodInfo(typeof(AudioManager), "get_CurrentMusicCue", true), value);
        }

        public static event On.AudioManager.hook_Start Start
        {
            add => On.AudioManager.Start += value;
            remove => On.AudioManager.Start -= value;
        }

        public static event On.AudioManager.hook_ApplyAtmosCue ApplyAtmosCue
        {
            add => On.AudioManager.ApplyAtmosCue += value;
            remove => On.AudioManager.ApplyAtmosCue -= value;
        }

        public static event On.AudioManager.hook_BeginApplyAtmosCue BeginApplyAtmosCue
        {
            add => On.AudioManager.BeginApplyAtmosCue += value;
            remove => On.AudioManager.BeginApplyAtmosCue -= value;
        }

        public static event On.AudioManager.hook_ApplyMusicCue ApplyMusicCue
        {
            add => On.AudioManager.ApplyMusicCue += value;
            remove => On.AudioManager.ApplyMusicCue -= value;
        }

        public static event On.AudioManager.hook_BeginApplyMusicCue BeginApplyMusicCue
        {
            add => On.AudioManager.BeginApplyMusicCue += value;
            remove => On.AudioManager.BeginApplyMusicCue -= value;
        }

        public static event On.AudioManager.hook_UpdateMusicSync UpdateMusicSync
        {
            add => On.AudioManager.UpdateMusicSync += value;
            remove => On.AudioManager.UpdateMusicSync -= value;
        }

        public static event On.AudioManager.hook_ApplyMusicSnapshot ApplyMusicSnapshot
        {
            add => On.AudioManager.ApplyMusicSnapshot += value;
            remove => On.AudioManager.ApplyMusicSnapshot -= value;
        }

        public static event On.AudioManager.hook_BeginApplyMusicSnapshot BeginApplyMusicSnapshot
        {
            add => On.AudioManager.BeginApplyMusicSnapshot += value;
            remove => On.AudioManager.BeginApplyMusicSnapshot -= value;
        }
    }
}