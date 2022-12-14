using MonoMod.RuntimeDetour;
using MonoMod.RuntimeDetour.HookGen;

namespace HKMirror.Hooks.OnHooks;

/// <summary>
///     Contains different types of On Hooks for MyGuid class.<br />
///     Contains hooks that aren't generated by monomod, and before and after orig hooks for easier hooking.
/// </summary>
public static class OnMyGuid
{
    internal static class HookHandler
    {
        private static readonly List<string> HookedList = new();

        internal static void Hookget_guid()
        {
            if (!HookedList.Contains("get_guid"))
            {
                HookedList.Add("get_guid");
                new Hook(ReflectionHelper.GetMethodInfo(typeof(MyGuid), "get_guid"), get_guid);
            }
        }

        internal static event Delegates.get_guid_BeforeArgs _beforeget_guid;
        internal static event Delegates.get_guid_AfterArgs _afterget_guid;

        private static Guid get_guid(Func<MyGuid, Guid> orig, MyGuid self)
        {
            Delegates.Params_get_guid @params = new()
            {
                self = self
            };
            if (_beforeget_guid != null)
                foreach (Delegates.get_guid_BeforeArgs toInvoke in _beforeget_guid.GetInvocationList())
                    try
                    {
                        _beforeget_guid?.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }

            self = @params.self;
            var retVal = orig(self);
            if (_afterget_guid != null)
                foreach (Delegates.get_guid_AfterArgs toInvoke in _afterget_guid.GetInvocationList())
                    try
                    {
                        retVal = _afterget_guid.Invoke(@params, retVal);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }

            return retVal;
        }

        internal static void HookGenerate()
        {
            if (!HookedList.Contains("Generate"))
            {
                HookedList.Add("Generate");
                On.MyGuid.Generate += Generate;
            }
        }

        internal static event Delegates.Generate_BeforeArgs _beforeGenerate;
        internal static event Delegates.Generate_AfterArgs _afterGenerate;

        private static void Generate(On.MyGuid.orig_Generate orig, MyGuid self)
        {
            Delegates.Params_Generate @params = new()
            {
                self = self
            };
            if (_beforeGenerate != null)
                foreach (Delegates.Generate_BeforeArgs toInvoke in _beforeGenerate.GetInvocationList())
                    try
                    {
                        _beforeGenerate?.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }

            self = @params.self;
            orig(self);
            if (_afterGenerate != null)
                foreach (Delegates.Generate_AfterArgs toInvoke in _afterGenerate.GetInvocationList())
                    try
                    {
                        _afterGenerate.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }
        }

        internal static void HookGetGuid()
        {
            if (!HookedList.Contains("GetGuid"))
            {
                HookedList.Add("GetGuid");
                On.MyGuid.GetGuid += GetGuid;
            }
        }

        internal static event Delegates.GetGuid_BeforeArgs _beforeGetGuid;
        internal static event Delegates.GetGuid_AfterArgs _afterGetGuid;

        private static string GetGuid(On.MyGuid.orig_GetGuid orig, MyGuid self)
        {
            Delegates.Params_GetGuid @params = new()
            {
                self = self
            };
            if (_beforeGetGuid != null)
                foreach (Delegates.GetGuid_BeforeArgs toInvoke in _beforeGetGuid.GetInvocationList())
                    try
                    {
                        _beforeGetGuid?.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }

            self = @params.self;
            var retVal = orig(self);
            if (_afterGetGuid != null)
                foreach (Delegates.GetGuid_AfterArgs toInvoke in _afterGetGuid.GetInvocationList())
                    try
                    {
                        retVal = _afterGetGuid.Invoke(@params, retVal);
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
        public delegate void Generate_AfterArgs(Params_Generate args);

        public delegate void Generate_BeforeArgs(Params_Generate args);

        public delegate void Generate_WithArgs(Action<MyGuid> orig, MyGuid self);

        public delegate Guid get_guid_AfterArgs(Params_get_guid args, Guid ret);

        public delegate void get_guid_BeforeArgs(Params_get_guid args);

        public delegate Guid get_guid_WithArgs(Func<MyGuid, Guid> orig, MyGuid self);

        public delegate string GetGuid_AfterArgs(Params_GetGuid args, string ret);

        public delegate void GetGuid_BeforeArgs(Params_GetGuid args);

        public delegate string GetGuid_WithArgs(Func<MyGuid, string> orig, MyGuid self);

        public sealed class Params_get_guid
        {
            public MyGuid self;
        }

        public sealed class Params_Generate
        {
            public MyGuid self;
        }

        public sealed class Params_GetGuid
        {
            public MyGuid self;
        }
    }

    /// <summary>
    ///     Contains Hooks to that run code before orig(self) is called
    /// </summary>
    public static class BeforeOrig
    {
        public static event Delegates.get_guid_BeforeArgs get_guid
        {
            add
            {
                HookHandler._beforeget_guid += value;
                HookHandler.Hookget_guid();
            }
            remove => HookHandler._beforeget_guid -= value;
        }

        public static event Delegates.Generate_BeforeArgs Generate
        {
            add
            {
                HookHandler._beforeGenerate += value;
                HookHandler.HookGenerate();
            }
            remove => HookHandler._beforeGenerate -= value;
        }

        public static event Delegates.GetGuid_BeforeArgs GetGuid
        {
            add
            {
                HookHandler._beforeGetGuid += value;
                HookHandler.HookGetGuid();
            }
            remove => HookHandler._beforeGetGuid -= value;
        }
    }

    /// <summary>
    ///     Contains Hooks to that run code after orig(self) is called
    /// </summary>
    public static class AfterOrig
    {
        public static event Delegates.get_guid_AfterArgs get_guid
        {
            add
            {
                HookHandler._afterget_guid += value;
                HookHandler.Hookget_guid();
            }
            remove => HookHandler._afterget_guid -= value;
        }

        public static event Delegates.Generate_AfterArgs Generate
        {
            add
            {
                HookHandler._afterGenerate += value;
                HookHandler.HookGenerate();
            }
            remove => HookHandler._afterGenerate -= value;
        }

        public static event Delegates.GetGuid_AfterArgs GetGuid
        {
            add
            {
                HookHandler._afterGetGuid += value;
                HookHandler.HookGetGuid();
            }
            remove => HookHandler._afterGetGuid -= value;
        }
    }

    /// <summary>
    ///     Contains all On Hooks, even those that aren't in the On namespace such as API generated functions and property
    ///     getters/setters
    /// </summary>
    public static class WithOrig
    {
        public static event Delegates.get_guid_WithArgs get_guid
        {
            add => HookEndpointManager.Add<Delegates.get_guid_WithArgs>(
                ReflectionHelper.GetMethodInfo(typeof(MyGuid), "get_guid"), value);
            remove => HookEndpointManager.Remove<Delegates.get_guid_WithArgs>(
                ReflectionHelper.GetMethodInfo(typeof(MyGuid), "get_guid"), value);
        }

        public static event On.MyGuid.hook_Generate Generate
        {
            add => On.MyGuid.Generate += value;
            remove => On.MyGuid.Generate -= value;
        }

        public static event On.MyGuid.hook_GetGuid GetGuid
        {
            add => On.MyGuid.GetGuid += value;
            remove => On.MyGuid.GetGuid -= value;
        }
    }
}