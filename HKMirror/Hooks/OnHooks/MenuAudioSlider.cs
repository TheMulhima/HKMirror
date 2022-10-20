namespace HKMirror.Hooks.OnHooks;

/// <summary>
///     Contains different types of On Hooks for MenuAudioSlider class.<br />
///     Contains hooks that aren't generated by monomod, and before and after orig hooks for easier hooking.
/// </summary>
public static class OnMenuAudioSlider
{
    internal static class HookHandler
    {
        private static readonly List<string> HookedList = new();

        internal static void HookStart()
        {
            if (!HookedList.Contains("Start"))
            {
                HookedList.Add("Start");
                On.MenuAudioSlider.Start += Start;
            }
        }

        internal static event Delegates.Start_BeforeArgs _beforeStart;
        internal static event Delegates.Start_NormalArgs _afterStart;

        private static void Start(On.MenuAudioSlider.orig_Start orig, MenuAudioSlider self)
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

        internal static void HookUpdateValue()
        {
            if (!HookedList.Contains("UpdateValue"))
            {
                HookedList.Add("UpdateValue");
                On.MenuAudioSlider.UpdateValue += UpdateValue;
            }
        }

        internal static event Delegates.UpdateValue_BeforeArgs _beforeUpdateValue;
        internal static event Delegates.UpdateValue_NormalArgs _afterUpdateValue;

        private static void UpdateValue(On.MenuAudioSlider.orig_UpdateValue orig, MenuAudioSlider self)
        {
            Delegates.Params_UpdateValue @params = new()
            {
                self = self
            };
            _beforeUpdateValue?.Invoke(@params);
            self = @params.self;
            orig(self);
            if (_afterUpdateValue != null) _afterUpdateValue.Invoke(@params);
        }

        internal static void HookRefreshValueFromSettings()
        {
            if (!HookedList.Contains("RefreshValueFromSettings"))
            {
                HookedList.Add("RefreshValueFromSettings");
                On.MenuAudioSlider.RefreshValueFromSettings += RefreshValueFromSettings;
            }
        }

        internal static event Delegates.RefreshValueFromSettings_BeforeArgs _beforeRefreshValueFromSettings;
        internal static event Delegates.RefreshValueFromSettings_NormalArgs _afterRefreshValueFromSettings;

        private static void RefreshValueFromSettings(On.MenuAudioSlider.orig_RefreshValueFromSettings orig,
            MenuAudioSlider self)
        {
            Delegates.Params_RefreshValueFromSettings @params = new()
            {
                self = self
            };
            _beforeRefreshValueFromSettings?.Invoke(@params);
            self = @params.self;
            orig(self);
            if (_afterRefreshValueFromSettings != null) _afterRefreshValueFromSettings.Invoke(@params);
        }

        internal static void HookUpdateTextValue()
        {
            if (!HookedList.Contains("UpdateTextValue"))
            {
                HookedList.Add("UpdateTextValue");
                On.MenuAudioSlider.UpdateTextValue += UpdateTextValue;
            }
        }

        internal static event Delegates.UpdateTextValue_BeforeArgs _beforeUpdateTextValue;
        internal static event Delegates.UpdateTextValue_NormalArgs _afterUpdateTextValue;

        private static void UpdateTextValue(On.MenuAudioSlider.orig_UpdateTextValue orig, MenuAudioSlider self,
            float value)
        {
            Delegates.Params_UpdateTextValue @params = new()
            {
                self = self, value = value
            };
            _beforeUpdateTextValue?.Invoke(@params);
            self = @params.self;
            value = @params.value;
            orig(self, value);
            if (_afterUpdateTextValue != null) _afterUpdateTextValue.Invoke(@params);
        }

        internal static void HookSetMasterLevel()
        {
            if (!HookedList.Contains("SetMasterLevel"))
            {
                HookedList.Add("SetMasterLevel");
                On.MenuAudioSlider.SetMasterLevel += SetMasterLevel;
            }
        }

        internal static event Delegates.SetMasterLevel_BeforeArgs _beforeSetMasterLevel;
        internal static event Delegates.SetMasterLevel_NormalArgs _afterSetMasterLevel;

        private static void SetMasterLevel(On.MenuAudioSlider.orig_SetMasterLevel orig, MenuAudioSlider self,
            float masterLevel)
        {
            Delegates.Params_SetMasterLevel @params = new()
            {
                self = self, masterLevel = masterLevel
            };
            _beforeSetMasterLevel?.Invoke(@params);
            self = @params.self;
            masterLevel = @params.masterLevel;
            orig(self, masterLevel);
            if (_afterSetMasterLevel != null) _afterSetMasterLevel.Invoke(@params);
        }

        internal static void HookSetMusicLevel()
        {
            if (!HookedList.Contains("SetMusicLevel"))
            {
                HookedList.Add("SetMusicLevel");
                On.MenuAudioSlider.SetMusicLevel += SetMusicLevel;
            }
        }

        internal static event Delegates.SetMusicLevel_BeforeArgs _beforeSetMusicLevel;
        internal static event Delegates.SetMusicLevel_NormalArgs _afterSetMusicLevel;

        private static void SetMusicLevel(On.MenuAudioSlider.orig_SetMusicLevel orig, MenuAudioSlider self,
            float musicLevel)
        {
            Delegates.Params_SetMusicLevel @params = new()
            {
                self = self, musicLevel = musicLevel
            };
            _beforeSetMusicLevel?.Invoke(@params);
            self = @params.self;
            musicLevel = @params.musicLevel;
            orig(self, musicLevel);
            if (_afterSetMusicLevel != null) _afterSetMusicLevel.Invoke(@params);
        }

        internal static void HookSetSoundLevel()
        {
            if (!HookedList.Contains("SetSoundLevel"))
            {
                HookedList.Add("SetSoundLevel");
                On.MenuAudioSlider.SetSoundLevel += SetSoundLevel;
            }
        }

        internal static event Delegates.SetSoundLevel_BeforeArgs _beforeSetSoundLevel;
        internal static event Delegates.SetSoundLevel_NormalArgs _afterSetSoundLevel;

        private static void SetSoundLevel(On.MenuAudioSlider.orig_SetSoundLevel orig, MenuAudioSlider self,
            float soundLevel)
        {
            Delegates.Params_SetSoundLevel @params = new()
            {
                self = self, soundLevel = soundLevel
            };
            _beforeSetSoundLevel?.Invoke(@params);
            self = @params.self;
            soundLevel = @params.soundLevel;
            orig(self, soundLevel);
            if (_afterSetSoundLevel != null) _afterSetSoundLevel.Invoke(@params);
        }

        internal static void HookGetVolumeLevel()
        {
            if (!HookedList.Contains("GetVolumeLevel"))
            {
                HookedList.Add("GetVolumeLevel");
                On.MenuAudioSlider.GetVolumeLevel += GetVolumeLevel;
            }
        }

        internal static event Delegates.GetVolumeLevel_BeforeArgs _beforeGetVolumeLevel;
        internal static event Delegates.GetVolumeLevel_NormalArgs _afterGetVolumeLevel;

        private static float GetVolumeLevel(On.MenuAudioSlider.orig_GetVolumeLevel orig, MenuAudioSlider self, float x)
        {
            Delegates.Params_GetVolumeLevel @params = new()
            {
                self = self, x = x
            };
            _beforeGetVolumeLevel?.Invoke(@params);
            self = @params.self;
            x = @params.x;
            var retVal = orig(self, x);
            if (_afterGetVolumeLevel != null) retVal = _afterGetVolumeLevel.Invoke(@params);
            return retVal;
        }
    }

    /// <summary>
    ///     Contains necessary information to create Hooks. Does not contain any hooks
    /// </summary>
    public static class Delegates
    {
        public delegate void GetVolumeLevel_BeforeArgs(Params_GetVolumeLevel args);

        public delegate float GetVolumeLevel_NormalArgs(Params_GetVolumeLevel args);

        public delegate void RefreshValueFromSettings_BeforeArgs(Params_RefreshValueFromSettings args);

        public delegate void RefreshValueFromSettings_NormalArgs(Params_RefreshValueFromSettings args);

        public delegate void SetMasterLevel_BeforeArgs(Params_SetMasterLevel args);

        public delegate void SetMasterLevel_NormalArgs(Params_SetMasterLevel args);

        public delegate void SetMusicLevel_BeforeArgs(Params_SetMusicLevel args);

        public delegate void SetMusicLevel_NormalArgs(Params_SetMusicLevel args);

        public delegate void SetSoundLevel_BeforeArgs(Params_SetSoundLevel args);

        public delegate void SetSoundLevel_NormalArgs(Params_SetSoundLevel args);

        public delegate void Start_BeforeArgs(Params_Start args);

        public delegate void Start_NormalArgs(Params_Start args);

        public delegate void UpdateTextValue_BeforeArgs(Params_UpdateTextValue args);

        public delegate void UpdateTextValue_NormalArgs(Params_UpdateTextValue args);

        public delegate void UpdateValue_BeforeArgs(Params_UpdateValue args);

        public delegate void UpdateValue_NormalArgs(Params_UpdateValue args);

        public sealed class Params_Start
        {
            public MenuAudioSlider self;
        }

        public sealed class Params_UpdateValue
        {
            public MenuAudioSlider self;
        }

        public sealed class Params_RefreshValueFromSettings
        {
            public MenuAudioSlider self;
        }

        public sealed class Params_UpdateTextValue
        {
            public MenuAudioSlider self;
            public float value;
        }

        public sealed class Params_SetMasterLevel
        {
            public float masterLevel;
            public MenuAudioSlider self;
        }

        public sealed class Params_SetMusicLevel
        {
            public float musicLevel;
            public MenuAudioSlider self;
        }

        public sealed class Params_SetSoundLevel
        {
            public MenuAudioSlider self;
            public float soundLevel;
        }

        public sealed class Params_GetVolumeLevel
        {
            public MenuAudioSlider self;
            public float x;
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

        public static event Delegates.UpdateValue_BeforeArgs UpdateValue
        {
            add
            {
                HookHandler._beforeUpdateValue += value;
                HookHandler.HookUpdateValue();
            }
            remove => HookHandler._beforeUpdateValue -= value;
        }

        public static event Delegates.RefreshValueFromSettings_BeforeArgs RefreshValueFromSettings
        {
            add
            {
                HookHandler._beforeRefreshValueFromSettings += value;
                HookHandler.HookRefreshValueFromSettings();
            }
            remove => HookHandler._beforeRefreshValueFromSettings -= value;
        }

        public static event Delegates.UpdateTextValue_BeforeArgs UpdateTextValue
        {
            add
            {
                HookHandler._beforeUpdateTextValue += value;
                HookHandler.HookUpdateTextValue();
            }
            remove => HookHandler._beforeUpdateTextValue -= value;
        }

        public static event Delegates.SetMasterLevel_BeforeArgs SetMasterLevel
        {
            add
            {
                HookHandler._beforeSetMasterLevel += value;
                HookHandler.HookSetMasterLevel();
            }
            remove => HookHandler._beforeSetMasterLevel -= value;
        }

        public static event Delegates.SetMusicLevel_BeforeArgs SetMusicLevel
        {
            add
            {
                HookHandler._beforeSetMusicLevel += value;
                HookHandler.HookSetMusicLevel();
            }
            remove => HookHandler._beforeSetMusicLevel -= value;
        }

        public static event Delegates.SetSoundLevel_BeforeArgs SetSoundLevel
        {
            add
            {
                HookHandler._beforeSetSoundLevel += value;
                HookHandler.HookSetSoundLevel();
            }
            remove => HookHandler._beforeSetSoundLevel -= value;
        }

        public static event Delegates.GetVolumeLevel_BeforeArgs GetVolumeLevel
        {
            add
            {
                HookHandler._beforeGetVolumeLevel += value;
                HookHandler.HookGetVolumeLevel();
            }
            remove => HookHandler._beforeGetVolumeLevel -= value;
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

        public static event Delegates.UpdateValue_NormalArgs UpdateValue
        {
            add
            {
                HookHandler._afterUpdateValue += value;
                HookHandler.HookUpdateValue();
            }
            remove => HookHandler._afterUpdateValue -= value;
        }

        public static event Delegates.RefreshValueFromSettings_NormalArgs RefreshValueFromSettings
        {
            add
            {
                HookHandler._afterRefreshValueFromSettings += value;
                HookHandler.HookRefreshValueFromSettings();
            }
            remove => HookHandler._afterRefreshValueFromSettings -= value;
        }

        public static event Delegates.UpdateTextValue_NormalArgs UpdateTextValue
        {
            add
            {
                HookHandler._afterUpdateTextValue += value;
                HookHandler.HookUpdateTextValue();
            }
            remove => HookHandler._afterUpdateTextValue -= value;
        }

        public static event Delegates.SetMasterLevel_NormalArgs SetMasterLevel
        {
            add
            {
                HookHandler._afterSetMasterLevel += value;
                HookHandler.HookSetMasterLevel();
            }
            remove => HookHandler._afterSetMasterLevel -= value;
        }

        public static event Delegates.SetMusicLevel_NormalArgs SetMusicLevel
        {
            add
            {
                HookHandler._afterSetMusicLevel += value;
                HookHandler.HookSetMusicLevel();
            }
            remove => HookHandler._afterSetMusicLevel -= value;
        }

        public static event Delegates.SetSoundLevel_NormalArgs SetSoundLevel
        {
            add
            {
                HookHandler._afterSetSoundLevel += value;
                HookHandler.HookSetSoundLevel();
            }
            remove => HookHandler._afterSetSoundLevel -= value;
        }

        public static event Delegates.GetVolumeLevel_NormalArgs GetVolumeLevel
        {
            add
            {
                HookHandler._afterGetVolumeLevel += value;
                HookHandler.HookGetVolumeLevel();
            }
            remove => HookHandler._afterGetVolumeLevel -= value;
        }
    }

    /// <summary>
    ///     Contains all On Hooks, even those that aren't in the On namespace such as API generated functions and property
    ///     getters/setters
    /// </summary>
    public static class WithOrig
    {
        public static event On.MenuAudioSlider.hook_Start Start
        {
            add => On.MenuAudioSlider.Start += value;
            remove => On.MenuAudioSlider.Start -= value;
        }

        public static event On.MenuAudioSlider.hook_UpdateValue UpdateValue
        {
            add => On.MenuAudioSlider.UpdateValue += value;
            remove => On.MenuAudioSlider.UpdateValue -= value;
        }

        public static event On.MenuAudioSlider.hook_RefreshValueFromSettings RefreshValueFromSettings
        {
            add => On.MenuAudioSlider.RefreshValueFromSettings += value;
            remove => On.MenuAudioSlider.RefreshValueFromSettings -= value;
        }

        public static event On.MenuAudioSlider.hook_UpdateTextValue UpdateTextValue
        {
            add => On.MenuAudioSlider.UpdateTextValue += value;
            remove => On.MenuAudioSlider.UpdateTextValue -= value;
        }

        public static event On.MenuAudioSlider.hook_SetMasterLevel SetMasterLevel
        {
            add => On.MenuAudioSlider.SetMasterLevel += value;
            remove => On.MenuAudioSlider.SetMasterLevel -= value;
        }

        public static event On.MenuAudioSlider.hook_SetMusicLevel SetMusicLevel
        {
            add => On.MenuAudioSlider.SetMusicLevel += value;
            remove => On.MenuAudioSlider.SetMusicLevel -= value;
        }

        public static event On.MenuAudioSlider.hook_SetSoundLevel SetSoundLevel
        {
            add => On.MenuAudioSlider.SetSoundLevel += value;
            remove => On.MenuAudioSlider.SetSoundLevel -= value;
        }

        public static event On.MenuAudioSlider.hook_GetVolumeLevel GetVolumeLevel
        {
            add => On.MenuAudioSlider.GetVolumeLevel += value;
            remove => On.MenuAudioSlider.GetVolumeLevel -= value;
        }
    }
}