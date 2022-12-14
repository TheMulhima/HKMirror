using System.Text;
using MonoMod.RuntimeDetour;
using MonoMod.RuntimeDetour.HookGen;

namespace HKMirror.Hooks.OnHooks;

/// <summary>
///     Contains different types of On Hooks for SteamOnlineSubsystem class.<br />
///     Contains hooks that aren't generated by monomod, and before and after orig hooks for easier hooking.
/// </summary>
public static class OnSteamOnlineSubsystem
{
    internal static class HookHandler
    {
        private static readonly List<string> HookedList = new();

        internal static void HookIsPackaged()
        {
            if (!HookedList.Contains("IsPackaged"))
            {
                HookedList.Add("IsPackaged");
                On.SteamOnlineSubsystem.IsPackaged += IsPackaged;
            }
        }

        internal static event Delegates.IsPackaged_BeforeArgs _beforeIsPackaged;
        internal static event Delegates.IsPackaged_AfterArgs _afterIsPackaged;

        private static bool IsPackaged(On.SteamOnlineSubsystem.orig_IsPackaged orig, DesktopPlatform desktopPlatform)
        {
            Delegates.Params_IsPackaged @params = new()
            {
                desktopPlatform = desktopPlatform
            };
            if (_beforeIsPackaged != null)
                foreach (Delegates.IsPackaged_BeforeArgs toInvoke in _beforeIsPackaged.GetInvocationList())
                    try
                    {
                        _beforeIsPackaged?.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }

            desktopPlatform = @params.desktopPlatform;
            var retVal = orig(desktopPlatform);
            if (_afterIsPackaged != null)
                foreach (Delegates.IsPackaged_AfterArgs toInvoke in _afterIsPackaged.GetInvocationList())
                    try
                    {
                        retVal = _afterIsPackaged.Invoke(@params, retVal);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }

            return retVal;
        }

        internal static void HookDispose()
        {
            if (!HookedList.Contains("Dispose"))
            {
                HookedList.Add("Dispose");
                On.SteamOnlineSubsystem.Dispose += Dispose;
            }
        }

        internal static event Delegates.Dispose_BeforeArgs _beforeDispose;
        internal static event Delegates.Dispose_AfterArgs _afterDispose;

        private static void Dispose(On.SteamOnlineSubsystem.orig_Dispose orig, SteamOnlineSubsystem self)
        {
            Delegates.Params_Dispose @params = new()
            {
                self = self
            };
            if (_beforeDispose != null)
                foreach (Delegates.Dispose_BeforeArgs toInvoke in _beforeDispose.GetInvocationList())
                    try
                    {
                        _beforeDispose?.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }

            self = @params.self;
            orig(self);
            if (_afterDispose != null)
                foreach (Delegates.Dispose_AfterArgs toInvoke in _afterDispose.GetInvocationList())
                    try
                    {
                        _afterDispose.Invoke(@params);
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
                On.SteamOnlineSubsystem.Update += Update;
            }
        }

        internal static event Delegates.Update_BeforeArgs _beforeUpdate;
        internal static event Delegates.Update_AfterArgs _afterUpdate;

        private static void Update(On.SteamOnlineSubsystem.orig_Update orig, SteamOnlineSubsystem self)
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

        internal static void HookOnSteamLogMessage()
        {
            if (!HookedList.Contains("OnSteamLogMessage"))
            {
                HookedList.Add("OnSteamLogMessage");
                On.SteamOnlineSubsystem.OnSteamLogMessage += OnSteamLogMessage;
            }
        }

        internal static event Delegates.OnSteamLogMessage_BeforeArgs _beforeOnSteamLogMessage;
        internal static event Delegates.OnSteamLogMessage_AfterArgs _afterOnSteamLogMessage;

        private static void OnSteamLogMessage(On.SteamOnlineSubsystem.orig_OnSteamLogMessage orig,
            SteamOnlineSubsystem self, int severity, StringBuilder content)
        {
            Delegates.Params_OnSteamLogMessage @params = new()
            {
                self = self, severity = severity, content = content
            };
            if (_beforeOnSteamLogMessage != null)
                foreach (Delegates.OnSteamLogMessage_BeforeArgs toInvoke in
                         _beforeOnSteamLogMessage.GetInvocationList())
                    try
                    {
                        _beforeOnSteamLogMessage?.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }

            self = @params.self;
            severity = @params.severity;
            content = @params.content;
            orig(self, severity, content);
            if (_afterOnSteamLogMessage != null)
                foreach (Delegates.OnSteamLogMessage_AfterArgs toInvoke in _afterOnSteamLogMessage.GetInvocationList())
                    try
                    {
                        _afterOnSteamLogMessage.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }
        }

        internal static void Hookget_AreAchievementsFetched()
        {
            if (!HookedList.Contains("get_AreAchievementsFetched"))
            {
                HookedList.Add("get_AreAchievementsFetched");
                new Hook(
                    ReflectionHelper.GetMethodInfo(typeof(SteamOnlineSubsystem), "get_AreAchievementsFetched"),
                    get_AreAchievementsFetched);
            }
        }

        internal static event Delegates.get_AreAchievementsFetched_BeforeArgs _beforeget_AreAchievementsFetched;
        internal static event Delegates.get_AreAchievementsFetched_AfterArgs _afterget_AreAchievementsFetched;

        private static bool get_AreAchievementsFetched(Func<SteamOnlineSubsystem, bool> orig, SteamOnlineSubsystem self)
        {
            Delegates.Params_get_AreAchievementsFetched @params = new()
            {
                self = self
            };
            if (_beforeget_AreAchievementsFetched != null)
                foreach (Delegates.get_AreAchievementsFetched_BeforeArgs toInvoke in _beforeget_AreAchievementsFetched
                             .GetInvocationList())
                    try
                    {
                        _beforeget_AreAchievementsFetched?.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }

            self = @params.self;
            var retVal = orig(self);
            if (_afterget_AreAchievementsFetched != null)
                foreach (Delegates.get_AreAchievementsFetched_AfterArgs toInvoke in _afterget_AreAchievementsFetched
                             .GetInvocationList())
                    try
                    {
                        retVal = _afterget_AreAchievementsFetched.Invoke(@params, retVal);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }

            return retVal;
        }

        internal static void HookPushAchievementUnlock()
        {
            if (!HookedList.Contains("PushAchievementUnlock"))
            {
                HookedList.Add("PushAchievementUnlock");
                On.SteamOnlineSubsystem.PushAchievementUnlock += PushAchievementUnlock;
            }
        }

        internal static event Delegates.PushAchievementUnlock_BeforeArgs _beforePushAchievementUnlock;
        internal static event Delegates.PushAchievementUnlock_AfterArgs _afterPushAchievementUnlock;

        private static void PushAchievementUnlock(On.SteamOnlineSubsystem.orig_PushAchievementUnlock orig,
            SteamOnlineSubsystem self, string achievementId)
        {
            Delegates.Params_PushAchievementUnlock @params = new()
            {
                self = self, achievementId = achievementId
            };
            if (_beforePushAchievementUnlock != null)
                foreach (Delegates.PushAchievementUnlock_BeforeArgs toInvoke in _beforePushAchievementUnlock
                             .GetInvocationList())
                    try
                    {
                        _beforePushAchievementUnlock?.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }

            self = @params.self;
            achievementId = @params.achievementId;
            orig(self, achievementId);
            if (_afterPushAchievementUnlock != null)
                foreach (Delegates.PushAchievementUnlock_AfterArgs toInvoke in _afterPushAchievementUnlock
                             .GetInvocationList())
                    try
                    {
                        _afterPushAchievementUnlock.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }
        }

        internal static void HookIsAchievementUnlocked()
        {
            if (!HookedList.Contains("IsAchievementUnlocked"))
            {
                HookedList.Add("IsAchievementUnlocked");
                On.SteamOnlineSubsystem.IsAchievementUnlocked += IsAchievementUnlocked;
            }
        }

        internal static event Delegates.IsAchievementUnlocked_BeforeArgs _beforeIsAchievementUnlocked;
        internal static event Delegates.IsAchievementUnlocked_AfterArgs _afterIsAchievementUnlocked;

        private static bool? IsAchievementUnlocked(On.SteamOnlineSubsystem.orig_IsAchievementUnlocked orig,
            SteamOnlineSubsystem self, string achievementId)
        {
            Delegates.Params_IsAchievementUnlocked @params = new()
            {
                self = self, achievementId = achievementId
            };
            if (_beforeIsAchievementUnlocked != null)
                foreach (Delegates.IsAchievementUnlocked_BeforeArgs toInvoke in _beforeIsAchievementUnlocked
                             .GetInvocationList())
                    try
                    {
                        _beforeIsAchievementUnlocked?.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }

            self = @params.self;
            achievementId = @params.achievementId;
            var retVal = orig(self, achievementId);
            if (_afterIsAchievementUnlocked != null)
                foreach (Delegates.IsAchievementUnlocked_AfterArgs toInvoke in _afterIsAchievementUnlocked
                             .GetInvocationList())
                    try
                    {
                        retVal = _afterIsAchievementUnlocked.Invoke(@params, retVal);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }

            return retVal;
        }

        internal static void HookResetAchievements()
        {
            if (!HookedList.Contains("ResetAchievements"))
            {
                HookedList.Add("ResetAchievements");
                On.SteamOnlineSubsystem.ResetAchievements += ResetAchievements;
            }
        }

        internal static event Delegates.ResetAchievements_BeforeArgs _beforeResetAchievements;
        internal static event Delegates.ResetAchievements_AfterArgs _afterResetAchievements;

        private static void ResetAchievements(On.SteamOnlineSubsystem.orig_ResetAchievements orig,
            SteamOnlineSubsystem self)
        {
            Delegates.Params_ResetAchievements @params = new()
            {
                self = self
            };
            if (_beforeResetAchievements != null)
                foreach (Delegates.ResetAchievements_BeforeArgs toInvoke in
                         _beforeResetAchievements.GetInvocationList())
                    try
                    {
                        _beforeResetAchievements?.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }

            self = @params.self;
            orig(self);
            if (_afterResetAchievements != null)
                foreach (Delegates.ResetAchievements_AfterArgs toInvoke in _afterResetAchievements.GetInvocationList())
                    try
                    {
                        _afterResetAchievements.Invoke(@params);
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
        public delegate void Dispose_AfterArgs(Params_Dispose args);

        public delegate void Dispose_BeforeArgs(Params_Dispose args);

        public delegate void Dispose_WithArgs(Action<SteamOnlineSubsystem> orig, SteamOnlineSubsystem self);

        public delegate bool get_AreAchievementsFetched_AfterArgs(Params_get_AreAchievementsFetched args, bool ret);

        public delegate void get_AreAchievementsFetched_BeforeArgs(Params_get_AreAchievementsFetched args);

        public delegate bool get_AreAchievementsFetched_WithArgs(Func<SteamOnlineSubsystem, bool> orig,
            SteamOnlineSubsystem self);

        public delegate bool? IsAchievementUnlocked_AfterArgs(Params_IsAchievementUnlocked args, bool? ret);

        public delegate void IsAchievementUnlocked_BeforeArgs(Params_IsAchievementUnlocked args);

        public delegate bool? IsAchievementUnlocked_WithArgs(Func<SteamOnlineSubsystem, string, bool?> orig,
            SteamOnlineSubsystem self, string achievementId);

        public delegate bool IsPackaged_AfterArgs(Params_IsPackaged args, bool ret);

        public delegate void IsPackaged_BeforeArgs(Params_IsPackaged args);

        public delegate bool IsPackaged_WithArgs(Func<DesktopPlatform, bool> orig, DesktopPlatform desktopPlatform);

        public delegate void OnSteamLogMessage_AfterArgs(Params_OnSteamLogMessage args);

        public delegate void OnSteamLogMessage_BeforeArgs(Params_OnSteamLogMessage args);

        public delegate void OnSteamLogMessage_WithArgs(
            Action<SteamOnlineSubsystem, int, StringBuilder> orig, SteamOnlineSubsystem self, int severity,
            StringBuilder content);

        public delegate void PushAchievementUnlock_AfterArgs(Params_PushAchievementUnlock args);

        public delegate void PushAchievementUnlock_BeforeArgs(Params_PushAchievementUnlock args);

        public delegate void PushAchievementUnlock_WithArgs(Action<SteamOnlineSubsystem, string> orig,
            SteamOnlineSubsystem self, string achievementId);

        public delegate void ResetAchievements_AfterArgs(Params_ResetAchievements args);

        public delegate void ResetAchievements_BeforeArgs(Params_ResetAchievements args);

        public delegate void ResetAchievements_WithArgs(Action<SteamOnlineSubsystem> orig, SteamOnlineSubsystem self);

        public delegate void Update_AfterArgs(Params_Update args);

        public delegate void Update_BeforeArgs(Params_Update args);

        public delegate void Update_WithArgs(Action<SteamOnlineSubsystem> orig, SteamOnlineSubsystem self);

        public sealed class Params_IsPackaged
        {
            public DesktopPlatform desktopPlatform;
        }

        public sealed class Params_Dispose
        {
            public SteamOnlineSubsystem self;
        }

        public sealed class Params_Update
        {
            public SteamOnlineSubsystem self;
        }

        public sealed class Params_OnSteamLogMessage
        {
            public StringBuilder content;
            public SteamOnlineSubsystem self;
            public int severity;
        }

        public sealed class Params_get_AreAchievementsFetched
        {
            public SteamOnlineSubsystem self;
        }

        public sealed class Params_PushAchievementUnlock
        {
            public string achievementId;
            public SteamOnlineSubsystem self;
        }

        public sealed class Params_IsAchievementUnlocked
        {
            public string achievementId;
            public SteamOnlineSubsystem self;
        }

        public sealed class Params_ResetAchievements
        {
            public SteamOnlineSubsystem self;
        }
    }

    /// <summary>
    ///     Contains Hooks to that run code before orig(self) is called
    /// </summary>
    public static class BeforeOrig
    {
        public static event Delegates.IsPackaged_BeforeArgs IsPackaged
        {
            add
            {
                HookHandler._beforeIsPackaged += value;
                HookHandler.HookIsPackaged();
            }
            remove => HookHandler._beforeIsPackaged -= value;
        }

        public static event Delegates.Dispose_BeforeArgs Dispose
        {
            add
            {
                HookHandler._beforeDispose += value;
                HookHandler.HookDispose();
            }
            remove => HookHandler._beforeDispose -= value;
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

        public static event Delegates.OnSteamLogMessage_BeforeArgs OnSteamLogMessage
        {
            add
            {
                HookHandler._beforeOnSteamLogMessage += value;
                HookHandler.HookOnSteamLogMessage();
            }
            remove => HookHandler._beforeOnSteamLogMessage -= value;
        }

        public static event Delegates.get_AreAchievementsFetched_BeforeArgs get_AreAchievementsFetched
        {
            add
            {
                HookHandler._beforeget_AreAchievementsFetched += value;
                HookHandler.Hookget_AreAchievementsFetched();
            }
            remove => HookHandler._beforeget_AreAchievementsFetched -= value;
        }


        public static event Delegates.PushAchievementUnlock_BeforeArgs PushAchievementUnlock
        {
            add
            {
                HookHandler._beforePushAchievementUnlock += value;
                HookHandler.HookPushAchievementUnlock();
            }
            remove => HookHandler._beforePushAchievementUnlock -= value;
        }

        public static event Delegates.IsAchievementUnlocked_BeforeArgs IsAchievementUnlocked
        {
            add
            {
                HookHandler._beforeIsAchievementUnlocked += value;
                HookHandler.HookIsAchievementUnlocked();
            }
            remove => HookHandler._beforeIsAchievementUnlocked -= value;
        }

        public static event Delegates.ResetAchievements_BeforeArgs ResetAchievements
        {
            add
            {
                HookHandler._beforeResetAchievements += value;
                HookHandler.HookResetAchievements();
            }
            remove => HookHandler._beforeResetAchievements -= value;
        }
    }

    /// <summary>
    ///     Contains Hooks to that run code after orig(self) is called
    /// </summary>
    public static class AfterOrig
    {
        public static event Delegates.IsPackaged_AfterArgs IsPackaged
        {
            add
            {
                HookHandler._afterIsPackaged += value;
                HookHandler.HookIsPackaged();
            }
            remove => HookHandler._afterIsPackaged -= value;
        }

        public static event Delegates.Dispose_AfterArgs Dispose
        {
            add
            {
                HookHandler._afterDispose += value;
                HookHandler.HookDispose();
            }
            remove => HookHandler._afterDispose -= value;
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

        public static event Delegates.OnSteamLogMessage_AfterArgs OnSteamLogMessage
        {
            add
            {
                HookHandler._afterOnSteamLogMessage += value;
                HookHandler.HookOnSteamLogMessage();
            }
            remove => HookHandler._afterOnSteamLogMessage -= value;
        }


        public static event Delegates.get_AreAchievementsFetched_AfterArgs get_AreAchievementsFetched
        {
            add
            {
                HookHandler._afterget_AreAchievementsFetched += value;
                HookHandler.Hookget_AreAchievementsFetched();
            }
            remove => HookHandler._afterget_AreAchievementsFetched -= value;
        }


        public static event Delegates.PushAchievementUnlock_AfterArgs PushAchievementUnlock
        {
            add
            {
                HookHandler._afterPushAchievementUnlock += value;
                HookHandler.HookPushAchievementUnlock();
            }
            remove => HookHandler._afterPushAchievementUnlock -= value;
        }

        public static event Delegates.IsAchievementUnlocked_AfterArgs IsAchievementUnlocked
        {
            add
            {
                HookHandler._afterIsAchievementUnlocked += value;
                HookHandler.HookIsAchievementUnlocked();
            }
            remove => HookHandler._afterIsAchievementUnlocked -= value;
        }

        public static event Delegates.ResetAchievements_AfterArgs ResetAchievements
        {
            add
            {
                HookHandler._afterResetAchievements += value;
                HookHandler.HookResetAchievements();
            }
            remove => HookHandler._afterResetAchievements -= value;
        }
    }

    /// <summary>
    ///     Contains all On Hooks, even those that aren't in the On namespace such as API generated functions and property
    ///     getters/setters
    /// </summary>
    public static class WithOrig
    {
        public static event On.SteamOnlineSubsystem.hook_IsPackaged IsPackaged
        {
            add => On.SteamOnlineSubsystem.IsPackaged += value;
            remove => On.SteamOnlineSubsystem.IsPackaged -= value;
        }

        public static event On.SteamOnlineSubsystem.hook_Dispose Dispose
        {
            add => On.SteamOnlineSubsystem.Dispose += value;
            remove => On.SteamOnlineSubsystem.Dispose -= value;
        }

        public static event On.SteamOnlineSubsystem.hook_Update Update
        {
            add => On.SteamOnlineSubsystem.Update += value;
            remove => On.SteamOnlineSubsystem.Update -= value;
        }

        public static event On.SteamOnlineSubsystem.hook_OnSteamLogMessage OnSteamLogMessage
        {
            add => On.SteamOnlineSubsystem.OnSteamLogMessage += value;
            remove => On.SteamOnlineSubsystem.OnSteamLogMessage -= value;
        }

        public static event On.SteamOnlineSubsystem.hook_OnGameOverlayActivated OnGameOverlayActivated
        {
            add => On.SteamOnlineSubsystem.OnGameOverlayActivated += value;
            remove => On.SteamOnlineSubsystem.OnGameOverlayActivated -= value;
        }

        public static event On.SteamOnlineSubsystem.hook_OnStatsReceived OnStatsReceived
        {
            add => On.SteamOnlineSubsystem.OnStatsReceived += value;
            remove => On.SteamOnlineSubsystem.OnStatsReceived -= value;
        }

        public static event Delegates.get_AreAchievementsFetched_WithArgs get_AreAchievementsFetched
        {
            add => HookEndpointManager.Add<Delegates.get_AreAchievementsFetched_WithArgs>(
                ReflectionHelper.GetMethodInfo(typeof(SteamOnlineSubsystem), "get_AreAchievementsFetched"),
                value);
            remove => HookEndpointManager.Remove<Delegates.get_AreAchievementsFetched_WithArgs>(
                ReflectionHelper.GetMethodInfo(typeof(SteamOnlineSubsystem), "get_AreAchievementsFetched"),
                value);
        }

        public static event On.SteamOnlineSubsystem.hook_OnSteamShutdown OnSteamShutdown
        {
            add => On.SteamOnlineSubsystem.OnSteamShutdown += value;
            remove => On.SteamOnlineSubsystem.OnSteamShutdown -= value;
        }

        public static event On.SteamOnlineSubsystem.hook_OnAchievementStored OnAchievementStored
        {
            add => On.SteamOnlineSubsystem.OnAchievementStored += value;
            remove => On.SteamOnlineSubsystem.OnAchievementStored -= value;
        }

        public static event On.SteamOnlineSubsystem.hook_PushAchievementUnlock PushAchievementUnlock
        {
            add => On.SteamOnlineSubsystem.PushAchievementUnlock += value;
            remove => On.SteamOnlineSubsystem.PushAchievementUnlock -= value;
        }

        public static event On.SteamOnlineSubsystem.hook_IsAchievementUnlocked IsAchievementUnlocked
        {
            add => On.SteamOnlineSubsystem.IsAchievementUnlocked += value;
            remove => On.SteamOnlineSubsystem.IsAchievementUnlocked -= value;
        }

        public static event On.SteamOnlineSubsystem.hook_ResetAchievements ResetAchievements
        {
            add => On.SteamOnlineSubsystem.ResetAchievements += value;
            remove => On.SteamOnlineSubsystem.ResetAchievements -= value;
        }
    }
}