namespace HKMirror.Hooks.OnHooks;

/// <summary>
///     Contains different types of On Hooks for InvCharmBackboard class.<br />
///     Contains hooks that aren't generated by monomod, and before and after orig hooks for easier hooking.
/// </summary>
public static class OnInvCharmBackboard
{
    internal static class HookHandler
    {
        private static readonly List<string> HookedList = new();

        internal static void HookAwake()
        {
            if (!HookedList.Contains("Awake"))
            {
                HookedList.Add("Awake");
                On.InvCharmBackboard.Awake += Awake;
            }
        }

        internal static event Delegates.Awake_BeforeArgs _beforeAwake;
        internal static event Delegates.Awake_AfterArgs _afterAwake;

        private static void Awake(On.InvCharmBackboard.orig_Awake orig, InvCharmBackboard self)
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
                On.InvCharmBackboard.OnEnable += OnEnable;
            }
        }

        internal static event Delegates.OnEnable_BeforeArgs _beforeOnEnable;
        internal static event Delegates.OnEnable_AfterArgs _afterOnEnable;

        private static void OnEnable(On.InvCharmBackboard.orig_OnEnable orig, InvCharmBackboard self)
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

        internal static void HookSelectCharm()
        {
            if (!HookedList.Contains("SelectCharm"))
            {
                HookedList.Add("SelectCharm");
                On.InvCharmBackboard.SelectCharm += SelectCharm;
            }
        }

        internal static event Delegates.SelectCharm_BeforeArgs _beforeSelectCharm;
        internal static event Delegates.SelectCharm_AfterArgs _afterSelectCharm;

        private static void SelectCharm(On.InvCharmBackboard.orig_SelectCharm orig, InvCharmBackboard self)
        {
            Delegates.Params_SelectCharm @params = new()
            {
                self = self
            };
            if (_beforeSelectCharm != null)
                foreach (Delegates.SelectCharm_BeforeArgs toInvoke in _beforeSelectCharm.GetInvocationList())
                    try
                    {
                        _beforeSelectCharm?.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }

            self = @params.self;
            orig(self);
            if (_afterSelectCharm != null)
                foreach (Delegates.SelectCharm_AfterArgs toInvoke in _afterSelectCharm.GetInvocationList())
                    try
                    {
                        _afterSelectCharm.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }
        }

        internal static void HookGetCharmNum()
        {
            if (!HookedList.Contains("GetCharmNum"))
            {
                HookedList.Add("GetCharmNum");
                On.InvCharmBackboard.GetCharmNum += GetCharmNum;
            }
        }

        internal static event Delegates.GetCharmNum_BeforeArgs _beforeGetCharmNum;
        internal static event Delegates.GetCharmNum_AfterArgs _afterGetCharmNum;

        private static int GetCharmNum(On.InvCharmBackboard.orig_GetCharmNum orig, InvCharmBackboard self)
        {
            Delegates.Params_GetCharmNum @params = new()
            {
                self = self
            };
            if (_beforeGetCharmNum != null)
                foreach (Delegates.GetCharmNum_BeforeArgs toInvoke in _beforeGetCharmNum.GetInvocationList())
                    try
                    {
                        _beforeGetCharmNum?.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }

            self = @params.self;
            var retVal = orig(self);
            if (_afterGetCharmNum != null)
                foreach (Delegates.GetCharmNum_AfterArgs toInvoke in _afterGetCharmNum.GetInvocationList())
                    try
                    {
                        retVal = _afterGetCharmNum.Invoke(@params, retVal);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }

            return retVal;
        }

        internal static void HookGetCharmString()
        {
            if (!HookedList.Contains("GetCharmString"))
            {
                HookedList.Add("GetCharmString");
                On.InvCharmBackboard.GetCharmString += GetCharmString;
            }
        }

        internal static event Delegates.GetCharmString_BeforeArgs _beforeGetCharmString;
        internal static event Delegates.GetCharmString_AfterArgs _afterGetCharmString;

        private static string GetCharmString(On.InvCharmBackboard.orig_GetCharmString orig, InvCharmBackboard self)
        {
            Delegates.Params_GetCharmString @params = new()
            {
                self = self
            };
            if (_beforeGetCharmString != null)
                foreach (Delegates.GetCharmString_BeforeArgs toInvoke in _beforeGetCharmString.GetInvocationList())
                    try
                    {
                        _beforeGetCharmString?.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }

            self = @params.self;
            var retVal = orig(self);
            if (_afterGetCharmString != null)
                foreach (Delegates.GetCharmString_AfterArgs toInvoke in _afterGetCharmString.GetInvocationList())
                    try
                    {
                        retVal = _afterGetCharmString.Invoke(@params, retVal);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }

            return retVal;
        }

        internal static void HookGetCharmNumString()
        {
            if (!HookedList.Contains("GetCharmNumString"))
            {
                HookedList.Add("GetCharmNumString");
                On.InvCharmBackboard.GetCharmNumString += GetCharmNumString;
            }
        }

        internal static event Delegates.GetCharmNumString_BeforeArgs _beforeGetCharmNumString;
        internal static event Delegates.GetCharmNumString_AfterArgs _afterGetCharmNumString;

        private static string GetCharmNumString(On.InvCharmBackboard.orig_GetCharmNumString orig,
            InvCharmBackboard self)
        {
            Delegates.Params_GetCharmNumString @params = new()
            {
                self = self
            };
            if (_beforeGetCharmNumString != null)
                foreach (Delegates.GetCharmNumString_BeforeArgs toInvoke in
                         _beforeGetCharmNumString.GetInvocationList())
                    try
                    {
                        _beforeGetCharmNumString?.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }

            self = @params.self;
            var retVal = orig(self);
            if (_afterGetCharmNumString != null)
                foreach (Delegates.GetCharmNumString_AfterArgs toInvoke in _afterGetCharmNumString.GetInvocationList())
                    try
                    {
                        retVal = _afterGetCharmNumString.Invoke(@params, retVal);
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
        public delegate void Awake_AfterArgs(Params_Awake args);

        public delegate void Awake_BeforeArgs(Params_Awake args);

        public delegate void Awake_WithArgs(Action<InvCharmBackboard> orig, InvCharmBackboard self);

        public delegate int GetCharmNum_AfterArgs(Params_GetCharmNum args, int ret);

        public delegate void GetCharmNum_BeforeArgs(Params_GetCharmNum args);

        public delegate int GetCharmNum_WithArgs(Func<InvCharmBackboard, int> orig, InvCharmBackboard self);

        public delegate string GetCharmNumString_AfterArgs(Params_GetCharmNumString args, string ret);

        public delegate void GetCharmNumString_BeforeArgs(Params_GetCharmNumString args);

        public delegate string GetCharmNumString_WithArgs(Func<InvCharmBackboard, string> orig, InvCharmBackboard self);

        public delegate string GetCharmString_AfterArgs(Params_GetCharmString args, string ret);

        public delegate void GetCharmString_BeforeArgs(Params_GetCharmString args);

        public delegate string GetCharmString_WithArgs(Func<InvCharmBackboard, string> orig, InvCharmBackboard self);

        public delegate void OnEnable_AfterArgs(Params_OnEnable args);

        public delegate void OnEnable_BeforeArgs(Params_OnEnable args);

        public delegate void OnEnable_WithArgs(Action<InvCharmBackboard> orig, InvCharmBackboard self);

        public delegate void SelectCharm_AfterArgs(Params_SelectCharm args);

        public delegate void SelectCharm_BeforeArgs(Params_SelectCharm args);

        public delegate void SelectCharm_WithArgs(Action<InvCharmBackboard> orig, InvCharmBackboard self);

        public sealed class Params_Awake
        {
            public InvCharmBackboard self;
        }

        public sealed class Params_OnEnable
        {
            public InvCharmBackboard self;
        }

        public sealed class Params_SelectCharm
        {
            public InvCharmBackboard self;
        }

        public sealed class Params_GetCharmNum
        {
            public InvCharmBackboard self;
        }

        public sealed class Params_GetCharmString
        {
            public InvCharmBackboard self;
        }

        public sealed class Params_GetCharmNumString
        {
            public InvCharmBackboard self;
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

        public static event Delegates.SelectCharm_BeforeArgs SelectCharm
        {
            add
            {
                HookHandler._beforeSelectCharm += value;
                HookHandler.HookSelectCharm();
            }
            remove => HookHandler._beforeSelectCharm -= value;
        }

        public static event Delegates.GetCharmNum_BeforeArgs GetCharmNum
        {
            add
            {
                HookHandler._beforeGetCharmNum += value;
                HookHandler.HookGetCharmNum();
            }
            remove => HookHandler._beforeGetCharmNum -= value;
        }

        public static event Delegates.GetCharmString_BeforeArgs GetCharmString
        {
            add
            {
                HookHandler._beforeGetCharmString += value;
                HookHandler.HookGetCharmString();
            }
            remove => HookHandler._beforeGetCharmString -= value;
        }

        public static event Delegates.GetCharmNumString_BeforeArgs GetCharmNumString
        {
            add
            {
                HookHandler._beforeGetCharmNumString += value;
                HookHandler.HookGetCharmNumString();
            }
            remove => HookHandler._beforeGetCharmNumString -= value;
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

        public static event Delegates.SelectCharm_AfterArgs SelectCharm
        {
            add
            {
                HookHandler._afterSelectCharm += value;
                HookHandler.HookSelectCharm();
            }
            remove => HookHandler._afterSelectCharm -= value;
        }

        public static event Delegates.GetCharmNum_AfterArgs GetCharmNum
        {
            add
            {
                HookHandler._afterGetCharmNum += value;
                HookHandler.HookGetCharmNum();
            }
            remove => HookHandler._afterGetCharmNum -= value;
        }

        public static event Delegates.GetCharmString_AfterArgs GetCharmString
        {
            add
            {
                HookHandler._afterGetCharmString += value;
                HookHandler.HookGetCharmString();
            }
            remove => HookHandler._afterGetCharmString -= value;
        }

        public static event Delegates.GetCharmNumString_AfterArgs GetCharmNumString
        {
            add
            {
                HookHandler._afterGetCharmNumString += value;
                HookHandler.HookGetCharmNumString();
            }
            remove => HookHandler._afterGetCharmNumString -= value;
        }
    }

    /// <summary>
    ///     Contains all On Hooks, even those that aren't in the On namespace such as API generated functions and property
    ///     getters/setters
    /// </summary>
    public static class WithOrig
    {
        public static event On.InvCharmBackboard.hook_Awake Awake
        {
            add => On.InvCharmBackboard.Awake += value;
            remove => On.InvCharmBackboard.Awake -= value;
        }

        public static event On.InvCharmBackboard.hook_OnEnable OnEnable
        {
            add => On.InvCharmBackboard.OnEnable += value;
            remove => On.InvCharmBackboard.OnEnable -= value;
        }

        public static event On.InvCharmBackboard.hook_SelectCharm SelectCharm
        {
            add => On.InvCharmBackboard.SelectCharm += value;
            remove => On.InvCharmBackboard.SelectCharm -= value;
        }

        public static event On.InvCharmBackboard.hook_GetCharmNum GetCharmNum
        {
            add => On.InvCharmBackboard.GetCharmNum += value;
            remove => On.InvCharmBackboard.GetCharmNum -= value;
        }

        public static event On.InvCharmBackboard.hook_GetCharmString GetCharmString
        {
            add => On.InvCharmBackboard.GetCharmString += value;
            remove => On.InvCharmBackboard.GetCharmString -= value;
        }

        public static event On.InvCharmBackboard.hook_GetCharmNumString GetCharmNumString
        {
            add => On.InvCharmBackboard.GetCharmNumString += value;
            remove => On.InvCharmBackboard.GetCharmNumString -= value;
        }
    }
}