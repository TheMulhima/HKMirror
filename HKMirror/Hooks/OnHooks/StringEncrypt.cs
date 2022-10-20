namespace HKMirror.Hooks.OnHooks;

/// <summary>
///     Contains different types of On Hooks for StringEncrypt class.<br />
///     Contains hooks that aren't generated by monomod, and before and after orig hooks for easier hooking.
/// </summary>
public static class OnStringEncrypt
{
    internal static class HookHandler
    {
        private static readonly List<string> HookedList = new();

        internal static void HookEncryptData()
        {
            if (!HookedList.Contains("EncryptData"))
            {
                HookedList.Add("EncryptData");
                On.StringEncrypt.EncryptData += EncryptData;
            }
        }

        internal static event Delegates.EncryptData_BeforeArgs _beforeEncryptData;
        internal static event Delegates.EncryptData_NormalArgs _afterEncryptData;

        private static string EncryptData(On.StringEncrypt.orig_EncryptData orig, string toEncrypt)
        {
            Delegates.Params_EncryptData @params = new()
            {
                toEncrypt = toEncrypt
            };
            _beforeEncryptData?.Invoke(@params);
            toEncrypt = @params.toEncrypt;
            var retVal = orig(toEncrypt);
            if (_afterEncryptData != null) retVal = _afterEncryptData.Invoke(@params);
            return retVal;
        }

        internal static void HookDecryptData()
        {
            if (!HookedList.Contains("DecryptData"))
            {
                HookedList.Add("DecryptData");
                On.StringEncrypt.DecryptData += DecryptData;
            }
        }

        internal static event Delegates.DecryptData_BeforeArgs _beforeDecryptData;
        internal static event Delegates.DecryptData_NormalArgs _afterDecryptData;

        private static string DecryptData(On.StringEncrypt.orig_DecryptData orig, string toDecrypt)
        {
            Delegates.Params_DecryptData @params = new()
            {
                toDecrypt = toDecrypt
            };
            _beforeDecryptData?.Invoke(@params);
            toDecrypt = @params.toDecrypt;
            var retVal = orig(toDecrypt);
            if (_afterDecryptData != null) retVal = _afterDecryptData.Invoke(@params);
            return retVal;
        }
    }

    /// <summary>
    ///     Contains necessary information to create Hooks. Does not contain any hooks
    /// </summary>
    public static class Delegates
    {
        public delegate void DecryptData_BeforeArgs(Params_DecryptData args);

        public delegate string DecryptData_NormalArgs(Params_DecryptData args);

        public delegate void EncryptData_BeforeArgs(Params_EncryptData args);

        public delegate string EncryptData_NormalArgs(Params_EncryptData args);

        public sealed class Params_EncryptData
        {
            public string toEncrypt;
        }

        public sealed class Params_DecryptData
        {
            public string toDecrypt;
        }
    }

    /// <summary>
    ///     Contains Hooks to that run code before orig(self) is called
    /// </summary>
    public static class BeforeOrig
    {
        public static event Delegates.EncryptData_BeforeArgs EncryptData
        {
            add
            {
                HookHandler._beforeEncryptData += value;
                HookHandler.HookEncryptData();
            }
            remove => HookHandler._beforeEncryptData -= value;
        }

        public static event Delegates.DecryptData_BeforeArgs DecryptData
        {
            add
            {
                HookHandler._beforeDecryptData += value;
                HookHandler.HookDecryptData();
            }
            remove => HookHandler._beforeDecryptData -= value;
        }
    }

    /// <summary>
    ///     Contains Hooks to that run code after orig(self) is called
    /// </summary>
    public static class AfterOrig
    {
        public static event Delegates.EncryptData_NormalArgs EncryptData
        {
            add
            {
                HookHandler._afterEncryptData += value;
                HookHandler.HookEncryptData();
            }
            remove => HookHandler._afterEncryptData -= value;
        }

        public static event Delegates.DecryptData_NormalArgs DecryptData
        {
            add
            {
                HookHandler._afterDecryptData += value;
                HookHandler.HookDecryptData();
            }
            remove => HookHandler._afterDecryptData -= value;
        }
    }

    /// <summary>
    ///     Contains all On Hooks, even those that aren't in the On namespace such as API generated functions and property
    ///     getters/setters
    /// </summary>
    public static class WithOrig
    {
        public static event On.StringEncrypt.hook_EncryptData EncryptData
        {
            add => On.StringEncrypt.EncryptData += value;
            remove => On.StringEncrypt.EncryptData -= value;
        }

        public static event On.StringEncrypt.hook_DecryptData DecryptData
        {
            add => On.StringEncrypt.DecryptData += value;
            remove => On.StringEncrypt.DecryptData -= value;
        }
    }
}