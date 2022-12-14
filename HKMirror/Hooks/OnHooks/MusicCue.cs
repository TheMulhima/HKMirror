using MonoMod.RuntimeDetour;
using MonoMod.RuntimeDetour.HookGen;
using UnityEngine.Audio;

namespace HKMirror.Hooks.OnHooks;

/// <summary>
///     Contains different types of On Hooks for MusicCue class.<br />
///     Contains hooks that aren't generated by monomod, and before and after orig hooks for easier hooking.
/// </summary>
public static class OnMusicCue
{
    internal static class HookHandler
    {
        private static readonly List<string> HookedList = new();

        internal static void Hookget_OriginalMusicEventName()
        {
            if (!HookedList.Contains("get_OriginalMusicEventName"))
            {
                HookedList.Add("get_OriginalMusicEventName");
                new Hook(ReflectionHelper.GetMethodInfo(typeof(MusicCue), "get_OriginalMusicEventName"),
                    get_OriginalMusicEventName);
            }
        }

        internal static event Delegates.get_OriginalMusicEventName_BeforeArgs _beforeget_OriginalMusicEventName;
        internal static event Delegates.get_OriginalMusicEventName_AfterArgs _afterget_OriginalMusicEventName;

        private static string get_OriginalMusicEventName(Func<MusicCue, string> orig, MusicCue self)
        {
            Delegates.Params_get_OriginalMusicEventName @params = new()
            {
                self = self
            };
            if (_beforeget_OriginalMusicEventName != null)
                foreach (Delegates.get_OriginalMusicEventName_BeforeArgs toInvoke in _beforeget_OriginalMusicEventName
                             .GetInvocationList())
                    try
                    {
                        _beforeget_OriginalMusicEventName?.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }

            self = @params.self;
            var retVal = orig(self);
            if (_afterget_OriginalMusicEventName != null)
                foreach (Delegates.get_OriginalMusicEventName_AfterArgs toInvoke in _afterget_OriginalMusicEventName
                             .GetInvocationList())
                    try
                    {
                        retVal = _afterget_OriginalMusicEventName.Invoke(@params, retVal);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }

            return retVal;
        }

        internal static void Hookget_OriginalMusicTrackNumber()
        {
            if (!HookedList.Contains("get_OriginalMusicTrackNumber"))
            {
                HookedList.Add("get_OriginalMusicTrackNumber");
                new Hook(ReflectionHelper.GetMethodInfo(typeof(MusicCue), "get_OriginalMusicTrackNumber"),
                    get_OriginalMusicTrackNumber);
            }
        }

        internal static event Delegates.get_OriginalMusicTrackNumber_BeforeArgs _beforeget_OriginalMusicTrackNumber;
        internal static event Delegates.get_OriginalMusicTrackNumber_AfterArgs _afterget_OriginalMusicTrackNumber;

        private static int get_OriginalMusicTrackNumber(Func<MusicCue, int> orig, MusicCue self)
        {
            Delegates.Params_get_OriginalMusicTrackNumber @params = new()
            {
                self = self
            };
            if (_beforeget_OriginalMusicTrackNumber != null)
                foreach (Delegates.get_OriginalMusicTrackNumber_BeforeArgs toInvoke in
                         _beforeget_OriginalMusicTrackNumber.GetInvocationList())
                    try
                    {
                        _beforeget_OriginalMusicTrackNumber?.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }

            self = @params.self;
            var retVal = orig(self);
            if (_afterget_OriginalMusicTrackNumber != null)
                foreach (Delegates.get_OriginalMusicTrackNumber_AfterArgs toInvoke in _afterget_OriginalMusicTrackNumber
                             .GetInvocationList())
                    try
                    {
                        retVal = _afterget_OriginalMusicTrackNumber.Invoke(@params, retVal);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }

            return retVal;
        }

        internal static void Hookget_Snapshot()
        {
            if (!HookedList.Contains("get_Snapshot"))
            {
                HookedList.Add("get_Snapshot");
                new Hook(ReflectionHelper.GetMethodInfo(typeof(MusicCue), "get_Snapshot"), get_Snapshot);
            }
        }

        internal static event Delegates.get_Snapshot_BeforeArgs _beforeget_Snapshot;
        internal static event Delegates.get_Snapshot_AfterArgs _afterget_Snapshot;

        private static AudioMixerSnapshot get_Snapshot(Func<MusicCue, AudioMixerSnapshot> orig, MusicCue self)
        {
            Delegates.Params_get_Snapshot @params = new()
            {
                self = self
            };
            if (_beforeget_Snapshot != null)
                foreach (Delegates.get_Snapshot_BeforeArgs toInvoke in _beforeget_Snapshot.GetInvocationList())
                    try
                    {
                        _beforeget_Snapshot?.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }

            self = @params.self;
            var retVal = orig(self);
            if (_afterget_Snapshot != null)
                foreach (Delegates.get_Snapshot_AfterArgs toInvoke in _afterget_Snapshot.GetInvocationList())
                    try
                    {
                        retVal = _afterget_Snapshot.Invoke(@params, retVal);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }

            return retVal;
        }

        internal static void HookResolveAlternatives()
        {
            if (!HookedList.Contains("ResolveAlternatives"))
            {
                HookedList.Add("ResolveAlternatives");
                On.MusicCue.ResolveAlternatives += ResolveAlternatives;
            }
        }

        internal static event Delegates.ResolveAlternatives_BeforeArgs _beforeResolveAlternatives;
        internal static event Delegates.ResolveAlternatives_AfterArgs _afterResolveAlternatives;

        private static MusicCue ResolveAlternatives(On.MusicCue.orig_ResolveAlternatives orig, MusicCue self,
            PlayerData playerData)
        {
            Delegates.Params_ResolveAlternatives @params = new()
            {
                self = self, playerData = playerData
            };
            if (_beforeResolveAlternatives != null)
                foreach (Delegates.ResolveAlternatives_BeforeArgs toInvoke in _beforeResolveAlternatives
                             .GetInvocationList())
                    try
                    {
                        _beforeResolveAlternatives?.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }

            self = @params.self;
            playerData = @params.playerData;
            var retVal = orig(self, playerData);
            if (_afterResolveAlternatives != null)
                foreach (Delegates.ResolveAlternatives_AfterArgs toInvoke in
                         _afterResolveAlternatives.GetInvocationList())
                    try
                    {
                        retVal = _afterResolveAlternatives.Invoke(@params, retVal);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }

            return retVal;
        }
    }

    /// <summary>
    ///     Contains necessary information to create Hooks. Does not contain any hooks
    /// </summary>
    public static class Delegates
    {
        public delegate string get_OriginalMusicEventName_AfterArgs(Params_get_OriginalMusicEventName args, string ret);

        public delegate void get_OriginalMusicEventName_BeforeArgs(Params_get_OriginalMusicEventName args);

        public delegate string get_OriginalMusicEventName_WithArgs(Func<MusicCue, string> orig, MusicCue self);

        public delegate int get_OriginalMusicTrackNumber_AfterArgs(Params_get_OriginalMusicTrackNumber args, int ret);

        public delegate void get_OriginalMusicTrackNumber_BeforeArgs(Params_get_OriginalMusicTrackNumber args);

        public delegate int get_OriginalMusicTrackNumber_WithArgs(Func<MusicCue, int> orig, MusicCue self);

        public delegate AudioMixerSnapshot get_Snapshot_AfterArgs(Params_get_Snapshot args, AudioMixerSnapshot ret);

        public delegate void get_Snapshot_BeforeArgs(Params_get_Snapshot args);

        public delegate AudioMixerSnapshot
            get_Snapshot_WithArgs(Func<MusicCue, AudioMixerSnapshot> orig, MusicCue self);

        public delegate MusicCue ResolveAlternatives_AfterArgs(Params_ResolveAlternatives args, MusicCue ret);

        public delegate void ResolveAlternatives_BeforeArgs(Params_ResolveAlternatives args);

        public delegate MusicCue ResolveAlternatives_WithArgs(Func<MusicCue, PlayerData, MusicCue> orig, MusicCue self,
            PlayerData playerData);

        public sealed class Params_get_OriginalMusicEventName
        {
            public MusicCue self;
        }

        public sealed class Params_get_OriginalMusicTrackNumber
        {
            public MusicCue self;
        }

        public sealed class Params_get_Snapshot
        {
            public MusicCue self;
        }

        public sealed class Params_ResolveAlternatives
        {
            public PlayerData playerData;
            public MusicCue self;
        }
    }

    /// <summary>
    ///     Contains Hooks to that run code before orig(self) is called
    /// </summary>
    public static class BeforeOrig
    {
        public static event Delegates.get_OriginalMusicEventName_BeforeArgs get_OriginalMusicEventName
        {
            add
            {
                HookHandler._beforeget_OriginalMusicEventName += value;
                HookHandler.Hookget_OriginalMusicEventName();
            }
            remove => HookHandler._beforeget_OriginalMusicEventName -= value;
        }

        public static event Delegates.get_OriginalMusicTrackNumber_BeforeArgs get_OriginalMusicTrackNumber
        {
            add
            {
                HookHandler._beforeget_OriginalMusicTrackNumber += value;
                HookHandler.Hookget_OriginalMusicTrackNumber();
            }
            remove => HookHandler._beforeget_OriginalMusicTrackNumber -= value;
        }

        public static event Delegates.get_Snapshot_BeforeArgs get_Snapshot
        {
            add
            {
                HookHandler._beforeget_Snapshot += value;
                HookHandler.Hookget_Snapshot();
            }
            remove => HookHandler._beforeget_Snapshot -= value;
        }

        public static event Delegates.ResolveAlternatives_BeforeArgs ResolveAlternatives
        {
            add
            {
                HookHandler._beforeResolveAlternatives += value;
                HookHandler.HookResolveAlternatives();
            }
            remove => HookHandler._beforeResolveAlternatives -= value;
        }
    }

    /// <summary>
    ///     Contains Hooks to that run code after orig(self) is called
    /// </summary>
    public static class AfterOrig
    {
        public static event Delegates.get_OriginalMusicEventName_AfterArgs get_OriginalMusicEventName
        {
            add
            {
                HookHandler._afterget_OriginalMusicEventName += value;
                HookHandler.Hookget_OriginalMusicEventName();
            }
            remove => HookHandler._afterget_OriginalMusicEventName -= value;
        }

        public static event Delegates.get_OriginalMusicTrackNumber_AfterArgs get_OriginalMusicTrackNumber
        {
            add
            {
                HookHandler._afterget_OriginalMusicTrackNumber += value;
                HookHandler.Hookget_OriginalMusicTrackNumber();
            }
            remove => HookHandler._afterget_OriginalMusicTrackNumber -= value;
        }

        public static event Delegates.get_Snapshot_AfterArgs get_Snapshot
        {
            add
            {
                HookHandler._afterget_Snapshot += value;
                HookHandler.Hookget_Snapshot();
            }
            remove => HookHandler._afterget_Snapshot -= value;
        }

        public static event Delegates.ResolveAlternatives_AfterArgs ResolveAlternatives
        {
            add
            {
                HookHandler._afterResolveAlternatives += value;
                HookHandler.HookResolveAlternatives();
            }
            remove => HookHandler._afterResolveAlternatives -= value;
        }
    }

    /// <summary>
    ///     Contains all On Hooks, even those that aren't in the On namespace such as API generated functions and property
    ///     getters/setters
    /// </summary>
    public static class WithOrig
    {
        public static event Delegates.get_OriginalMusicEventName_WithArgs get_OriginalMusicEventName
        {
            add => HookEndpointManager.Add<Delegates.get_OriginalMusicEventName_WithArgs>(
                ReflectionHelper.GetMethodInfo(typeof(MusicCue), "get_OriginalMusicEventName"), value);
            remove => HookEndpointManager.Remove<Delegates.get_OriginalMusicEventName_WithArgs>(
                ReflectionHelper.GetMethodInfo(typeof(MusicCue), "get_OriginalMusicEventName"), value);
        }

        public static event Delegates.get_OriginalMusicTrackNumber_WithArgs get_OriginalMusicTrackNumber
        {
            add => HookEndpointManager.Add<Delegates.get_OriginalMusicTrackNumber_WithArgs>(
                ReflectionHelper.GetMethodInfo(typeof(MusicCue), "get_OriginalMusicTrackNumber"), value);
            remove => HookEndpointManager.Remove<Delegates.get_OriginalMusicTrackNumber_WithArgs>(
                ReflectionHelper.GetMethodInfo(typeof(MusicCue), "get_OriginalMusicTrackNumber"), value);
        }

        public static event Delegates.get_Snapshot_WithArgs get_Snapshot
        {
            add => HookEndpointManager.Add<Delegates.get_Snapshot_WithArgs>(
                ReflectionHelper.GetMethodInfo(typeof(MusicCue), "get_Snapshot"), value);
            remove => HookEndpointManager.Remove<Delegates.get_Snapshot_WithArgs>(
                ReflectionHelper.GetMethodInfo(typeof(MusicCue), "get_Snapshot"), value);
        }

        public static event On.MusicCue.hook_ResolveAlternatives ResolveAlternatives
        {
            add => On.MusicCue.ResolveAlternatives += value;
            remove => On.MusicCue.ResolveAlternatives -= value;
        }
    }
}