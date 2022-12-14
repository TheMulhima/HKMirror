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
        internal static event Delegates.EncryptData_AfterArgs _afterEncryptData;

        private static string EncryptData(On.StringEncrypt.orig_EncryptData orig, string toEncrypt)
        {
            Delegates.Params_EncryptData @params = new()
            {
                toEncrypt = toEncrypt
            };
            if (_beforeEncryptData != null)
                foreach (Delegates.EncryptData_BeforeArgs toInvoke in _beforeEncryptData.GetInvocationList())
                    try
                    {
                        _beforeEncryptData?.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }

            toEncrypt = @params.toEncrypt;
            var retVal = orig(toEncrypt);
            if (_afterEncryptData != null)
                foreach (Delegates.EncryptData_AfterArgs toInvoke in _afterEncryptData.GetInvocationList())
                    try
                    {
                        retVal = _afterEncryptData.Invoke(@params, retVal);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }

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
        internal static event Delegates.DecryptData_AfterArgs _afterDecryptData;

        private static string DecryptData(On.StringEncrypt.orig_DecryptData orig, string toDecrypt)
        {
            Delegates.Params_DecryptData @params = new()
            {
                toDecrypt = toDecrypt
            };
            if (_beforeDecryptData != null)
                foreach (Delegates.DecryptData_BeforeArgs toInvoke in _beforeDecryptData.GetInvocationList())
                    try
                    {
                        _beforeDecryptData?.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }

            toDecrypt = @params.toDecrypt;
            var retVal = orig(toDecrypt);
            if (_afterDecryptData != null)
                foreach (Delegates.DecryptData_AfterArgs toInvoke in _afterDecryptData.GetInvocationList())
                    try
                    {
                        retVal = _afterDecryptData.Invoke(@params, retVal);
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
        public delegate string DecryptData_AfterArgs(Params_DecryptData args, string ret);

        public delegate void DecryptData_BeforeArgs(Params_DecryptData args);

        public delegate string DecryptData_WithArgs(Func<string, string> orig, string toDecrypt);

        public delegate string EncryptData_AfterArgs(Params_EncryptData args, string ret);

        public delegate void EncryptData_BeforeArgs(Params_EncryptData args);

        public delegate string EncryptData_WithArgs(Func<string, string> orig, string toEncrypt);

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
        public static event Delegates.EncryptData_AfterArgs EncryptData
        {
            add
            {
                HookHandler._afterEncryptData += value;
                HookHandler.HookEncryptData();
            }
            remove => HookHandler._afterEncryptData -= value;
        }

        public static event Delegates.DecryptData_AfterArgs DecryptData
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