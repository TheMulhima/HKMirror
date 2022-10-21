using MonoMod.RuntimeDetour;
using MonoMod.RuntimeDetour.HookGen;

namespace HKMirror.Hooks.OnHooks;

/// <summary>
/// Contains different types of On Hooks for GetStringProxy class.<br />
/// Contains hooks that aren't generated by monomod, and before and after orig hooks for easier hooking.
/// </summary>
public static class OnGetStringProxy
{
    internal static class HookHandler
    {
        private static List<string> HookedList = new List<string>();

        internal static void HookInvoke()
        {
            if (!HookedList.Contains("Invoke"))
            {
                HookedList.Add("Invoke");
                new Hook(ReflectionHelper.GetMethodInfo(typeof(Modding.Delegates.GetStringProxy), "Invoke", true),
                    Invoke);
            }
        }

        internal static event Delegates.Invoke_BeforeArgs _beforeInvoke;
        internal static event Delegates.Invoke_AfterArgs _afterInvoke;

        private static string Invoke(Func<Modding.Delegates.GetStringProxy, string, string, string> orig,
            Modding.Delegates.GetStringProxy self, string name, string res)
        {
            Delegates.Params_Invoke @params = new()
            {
                self = self, name = name, res = res
            };
            if (_beforeInvoke != null)
            {
                foreach (Delegates.Invoke_BeforeArgs toInvoke in _beforeInvoke.GetInvocationList())
                {
                    try
                    {
                        _beforeInvoke?.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }
                }
            }

            self = @params.self;
            name = @params.name;
            res = @params.res;
            var retVal = orig(self, name, res);
            if (_afterInvoke != null)
            {
                foreach (Delegates.Invoke_AfterArgs toInvoke in _afterInvoke.GetInvocationList())
                {
                    try
                    {
                        retVal = _afterInvoke.Invoke(@params, retVal);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }
                }
            }

            return retVal;
        }

        internal static void HookEndInvoke()
        {
            if (!HookedList.Contains("EndInvoke"))
            {
                HookedList.Add("EndInvoke");
                new Hook(ReflectionHelper.GetMethodInfo(typeof(Modding.Delegates.GetStringProxy), "EndInvoke", true),
                    EndInvoke);
            }
        }

        internal static event Delegates.EndInvoke_BeforeArgs _beforeEndInvoke;
        internal static event Delegates.EndInvoke_AfterArgs _afterEndInvoke;

        private static string EndInvoke(Func<Modding.Delegates.GetStringProxy, System.IAsyncResult, string> orig,
            Modding.Delegates.GetStringProxy self, System.IAsyncResult result)
        {
            Delegates.Params_EndInvoke @params = new()
            {
                self = self, result = result
            };
            if (_beforeEndInvoke != null)
            {
                foreach (Delegates.EndInvoke_BeforeArgs toInvoke in _beforeEndInvoke.GetInvocationList())
                {
                    try
                    {
                        _beforeEndInvoke?.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }
                }
            }

            self = @params.self;
            result = @params.result;
            var retVal = orig(self, result);
            if (_afterEndInvoke != null)
            {
                foreach (Delegates.EndInvoke_AfterArgs toInvoke in _afterEndInvoke.GetInvocationList())
                {
                    try
                    {
                        retVal = _afterEndInvoke.Invoke(@params, retVal);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }
                }
            }

            return retVal;
        }
    }

    /// <summary>
    /// Contains necessary information to create Hooks. Does not contain any hooks
    /// </summary>
    public static class Delegates
    {
        public sealed class Params_Invoke
        {
            public Modding.Delegates.GetStringProxy self;
            public string name;
            public string res;
        }

        public delegate void Invoke_BeforeArgs(Params_Invoke args);

        public delegate string Invoke_AfterArgs(Params_Invoke args, string ret);

        public delegate string Invoke_WithArgs(Func<Modding.Delegates.GetStringProxy, string, string, string> orig,
            Modding.Delegates.GetStringProxy self, string name, string res);

        public sealed class Params_EndInvoke
        {
            public Modding.Delegates.GetStringProxy self;
            public System.IAsyncResult result;
        }

        public delegate void EndInvoke_BeforeArgs(Params_EndInvoke args);

        public delegate string EndInvoke_AfterArgs(Params_EndInvoke args, string ret);

        public delegate string EndInvoke_WithArgs(
            Func<Modding.Delegates.GetStringProxy, System.IAsyncResult, string> orig,
            Modding.Delegates.GetStringProxy self, System.IAsyncResult result);
    }

    /// <summary>
    /// Contains Hooks to that run code before orig(self) is called
    /// </summary>
    public static class BeforeOrig
    {
        public static event Delegates.Invoke_BeforeArgs Invoke
        {
            add
            {
                HookHandler._beforeInvoke += value;
                HookHandler.HookInvoke();
            }
            remove => HookHandler._beforeInvoke -= value;
        }

        public static event Delegates.EndInvoke_BeforeArgs EndInvoke
        {
            add
            {
                HookHandler._beforeEndInvoke += value;
                HookHandler.HookEndInvoke();
            }
            remove => HookHandler._beforeEndInvoke -= value;
        }
    }

    /// <summary>
    /// Contains Hooks to that run code after orig(self) is called
    /// </summary>
    public static class AfterOrig
    {
        public static event Delegates.Invoke_AfterArgs Invoke
        {
            add
            {
                HookHandler._afterInvoke += value;
                HookHandler.HookInvoke();
            }
            remove => HookHandler._afterInvoke -= value;
        }

        public static event Delegates.EndInvoke_AfterArgs EndInvoke
        {
            add
            {
                HookHandler._afterEndInvoke += value;
                HookHandler.HookEndInvoke();
            }
            remove => HookHandler._afterEndInvoke -= value;
        }
    }

    /// <summary>
    /// Contains all On Hooks, even those that aren't in the On namespace such as API generated functions and property getters/setters
    /// </summary>
    public static class WithOrig
    {
        public static event Delegates.Invoke_WithArgs Invoke
        {
            add => HookEndpointManager.Add<Delegates.Invoke_WithArgs>(
                ReflectionHelper.GetMethodInfo(typeof(Modding.Delegates.GetStringProxy), "Invoke", true), value);
            remove => HookEndpointManager.Remove<Delegates.Invoke_WithArgs>(
                ReflectionHelper.GetMethodInfo(typeof(Modding.Delegates.GetStringProxy), "Invoke", true), value);
        }

        public static event Delegates.EndInvoke_WithArgs EndInvoke
        {
            add => HookEndpointManager.Add<Delegates.EndInvoke_WithArgs>(
                ReflectionHelper.GetMethodInfo(typeof(Modding.Delegates.GetStringProxy), "EndInvoke", true), value);
            remove => HookEndpointManager.Remove<Delegates.EndInvoke_WithArgs>(
                ReflectionHelper.GetMethodInfo(typeof(Modding.Delegates.GetStringProxy), "EndInvoke", true), value);
        }
    }
}