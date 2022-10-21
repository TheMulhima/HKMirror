using MonoMod.RuntimeDetour;
using MonoMod.RuntimeDetour.HookGen;

namespace HKMirror.Hooks.OnHooks;

/// <summary>
/// Contains different types of On Hooks for GetChild class.<br />
/// Contains hooks that aren't generated by monomod, and before and after orig hooks for easier hooking.
/// </summary>
public static class OnGetChild
{
    internal static class HookHandler
    {
        private static List<string> HookedList = new List<string>();

        internal static void HookReset()
        {
            if (!HookedList.Contains("Reset"))
            {
                HookedList.Add("Reset");
                new Hook(ReflectionHelper.GetMethodInfo(typeof(HutongGames.PlayMaker.Actions.GetChild), "Reset", true),
                    Reset);
            }
        }

        internal static event Delegates.Reset_BeforeArgs _beforeReset;
        internal static event Delegates.Reset_AfterArgs _afterReset;

        private static void Reset(Action<HutongGames.PlayMaker.Actions.GetChild> orig,
            HutongGames.PlayMaker.Actions.GetChild self)
        {
            Delegates.Params_Reset @params = new()
            {
                self = self
            };
            if (_beforeReset != null)
            {
                foreach (Delegates.Reset_BeforeArgs toInvoke in _beforeReset.GetInvocationList())
                {
                    try
                    {
                        _beforeReset?.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }
                }
            }

            self = @params.self;
            orig(self);
            if (_afterReset != null)
            {
                foreach (Delegates.Reset_AfterArgs toInvoke in _afterReset.GetInvocationList())
                {
                    try
                    {
                        _afterReset.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }
                }
            }
        }

        internal static void HookOnEnter()
        {
            if (!HookedList.Contains("OnEnter"))
            {
                HookedList.Add("OnEnter");
                new Hook(
                    ReflectionHelper.GetMethodInfo(typeof(HutongGames.PlayMaker.Actions.GetChild), "OnEnter", true),
                    OnEnter);
            }
        }

        internal static event Delegates.OnEnter_BeforeArgs _beforeOnEnter;
        internal static event Delegates.OnEnter_AfterArgs _afterOnEnter;

        private static void OnEnter(Action<HutongGames.PlayMaker.Actions.GetChild> orig,
            HutongGames.PlayMaker.Actions.GetChild self)
        {
            Delegates.Params_OnEnter @params = new()
            {
                self = self
            };
            if (_beforeOnEnter != null)
            {
                foreach (Delegates.OnEnter_BeforeArgs toInvoke in _beforeOnEnter.GetInvocationList())
                {
                    try
                    {
                        _beforeOnEnter?.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }
                }
            }

            self = @params.self;
            orig(self);
            if (_afterOnEnter != null)
            {
                foreach (Delegates.OnEnter_AfterArgs toInvoke in _afterOnEnter.GetInvocationList())
                {
                    try
                    {
                        _afterOnEnter.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }
                }
            }
        }

        internal static void HookDoGetChildByName()
        {
            if (!HookedList.Contains("DoGetChildByName"))
            {
                HookedList.Add("DoGetChildByName");
                new Hook(
                    ReflectionHelper.GetMethodInfo(typeof(HutongGames.PlayMaker.Actions.GetChild), "DoGetChildByName",
                        false), DoGetChildByName);
            }
        }

        internal static event Delegates.DoGetChildByName_BeforeArgs _beforeDoGetChildByName;
        internal static event Delegates.DoGetChildByName_AfterArgs _afterDoGetChildByName;

        private static UnityEngine.GameObject DoGetChildByName(
            Func<UnityEngine.GameObject, string, string, UnityEngine.GameObject> orig, UnityEngine.GameObject root,
            string name, string tag)
        {
            Delegates.Params_DoGetChildByName @params = new()
            {
                root = root, name = name, tag = tag
            };
            if (_beforeDoGetChildByName != null)
            {
                foreach (Delegates.DoGetChildByName_BeforeArgs toInvoke in _beforeDoGetChildByName.GetInvocationList())
                {
                    try
                    {
                        _beforeDoGetChildByName?.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }
                }
            }

            root = @params.root;
            name = @params.name;
            tag = @params.tag;
            var retVal = orig(root, name, tag);
            if (_afterDoGetChildByName != null)
            {
                foreach (Delegates.DoGetChildByName_AfterArgs toInvoke in _afterDoGetChildByName.GetInvocationList())
                {
                    try
                    {
                        retVal = _afterDoGetChildByName.Invoke(@params, retVal);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }
                }
            }

            return retVal;
        }

        internal static void HookErrorCheck()
        {
            if (!HookedList.Contains("ErrorCheck"))
            {
                HookedList.Add("ErrorCheck");
                new Hook(
                    ReflectionHelper.GetMethodInfo(typeof(HutongGames.PlayMaker.Actions.GetChild), "ErrorCheck", true),
                    ErrorCheck);
            }
        }

        internal static event Delegates.ErrorCheck_BeforeArgs _beforeErrorCheck;
        internal static event Delegates.ErrorCheck_AfterArgs _afterErrorCheck;

        private static string ErrorCheck(Func<HutongGames.PlayMaker.Actions.GetChild, string> orig,
            HutongGames.PlayMaker.Actions.GetChild self)
        {
            Delegates.Params_ErrorCheck @params = new()
            {
                self = self
            };
            if (_beforeErrorCheck != null)
            {
                foreach (Delegates.ErrorCheck_BeforeArgs toInvoke in _beforeErrorCheck.GetInvocationList())
                {
                    try
                    {
                        _beforeErrorCheck?.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }
                }
            }

            self = @params.self;
            var retVal = orig(self);
            if (_afterErrorCheck != null)
            {
                foreach (Delegates.ErrorCheck_AfterArgs toInvoke in _afterErrorCheck.GetInvocationList())
                {
                    try
                    {
                        retVal = _afterErrorCheck.Invoke(@params, retVal);
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
        public sealed class Params_Reset
        {
            public HutongGames.PlayMaker.Actions.GetChild self;
        }

        public delegate void Reset_BeforeArgs(Params_Reset args);

        public delegate void Reset_AfterArgs(Params_Reset args);

        public delegate void Reset_WithArgs(Action<HutongGames.PlayMaker.Actions.GetChild> orig,
            HutongGames.PlayMaker.Actions.GetChild self);

        public sealed class Params_OnEnter
        {
            public HutongGames.PlayMaker.Actions.GetChild self;
        }

        public delegate void OnEnter_BeforeArgs(Params_OnEnter args);

        public delegate void OnEnter_AfterArgs(Params_OnEnter args);

        public delegate void OnEnter_WithArgs(Action<HutongGames.PlayMaker.Actions.GetChild> orig,
            HutongGames.PlayMaker.Actions.GetChild self);

        public sealed class Params_DoGetChildByName
        {
            public UnityEngine.GameObject root;
            public string name;
            public string tag;
        }

        public delegate void DoGetChildByName_BeforeArgs(Params_DoGetChildByName args);

        public delegate UnityEngine.GameObject DoGetChildByName_AfterArgs(Params_DoGetChildByName args,
            UnityEngine.GameObject ret);

        public delegate UnityEngine.GameObject DoGetChildByName_WithArgs(
            Func<UnityEngine.GameObject, string, string, UnityEngine.GameObject> orig, UnityEngine.GameObject root,
            string name, string tag);

        public sealed class Params_ErrorCheck
        {
            public HutongGames.PlayMaker.Actions.GetChild self;
        }

        public delegate void ErrorCheck_BeforeArgs(Params_ErrorCheck args);

        public delegate string ErrorCheck_AfterArgs(Params_ErrorCheck args, string ret);

        public delegate string ErrorCheck_WithArgs(Func<HutongGames.PlayMaker.Actions.GetChild, string> orig,
            HutongGames.PlayMaker.Actions.GetChild self);
    }

    /// <summary>
    /// Contains Hooks to that run code before orig(self) is called
    /// </summary>
    public static class BeforeOrig
    {
        public static event Delegates.Reset_BeforeArgs Reset
        {
            add
            {
                HookHandler._beforeReset += value;
                HookHandler.HookReset();
            }
            remove => HookHandler._beforeReset -= value;
        }

        public static event Delegates.OnEnter_BeforeArgs OnEnter
        {
            add
            {
                HookHandler._beforeOnEnter += value;
                HookHandler.HookOnEnter();
            }
            remove => HookHandler._beforeOnEnter -= value;
        }

        public static event Delegates.DoGetChildByName_BeforeArgs DoGetChildByName
        {
            add
            {
                HookHandler._beforeDoGetChildByName += value;
                HookHandler.HookDoGetChildByName();
            }
            remove => HookHandler._beforeDoGetChildByName -= value;
        }

        public static event Delegates.ErrorCheck_BeforeArgs ErrorCheck
        {
            add
            {
                HookHandler._beforeErrorCheck += value;
                HookHandler.HookErrorCheck();
            }
            remove => HookHandler._beforeErrorCheck -= value;
        }
    }

    /// <summary>
    /// Contains Hooks to that run code after orig(self) is called
    /// </summary>
    public static class AfterOrig
    {
        public static event Delegates.Reset_AfterArgs Reset
        {
            add
            {
                HookHandler._afterReset += value;
                HookHandler.HookReset();
            }
            remove => HookHandler._afterReset -= value;
        }

        public static event Delegates.OnEnter_AfterArgs OnEnter
        {
            add
            {
                HookHandler._afterOnEnter += value;
                HookHandler.HookOnEnter();
            }
            remove => HookHandler._afterOnEnter -= value;
        }

        public static event Delegates.DoGetChildByName_AfterArgs DoGetChildByName
        {
            add
            {
                HookHandler._afterDoGetChildByName += value;
                HookHandler.HookDoGetChildByName();
            }
            remove => HookHandler._afterDoGetChildByName -= value;
        }

        public static event Delegates.ErrorCheck_AfterArgs ErrorCheck
        {
            add
            {
                HookHandler._afterErrorCheck += value;
                HookHandler.HookErrorCheck();
            }
            remove => HookHandler._afterErrorCheck -= value;
        }
    }

    /// <summary>
    /// Contains all On Hooks, even those that aren't in the On namespace such as API generated functions and property getters/setters
    /// </summary>
    public static class WithOrig
    {
        public static event Delegates.Reset_WithArgs Reset
        {
            add => HookEndpointManager.Add<Delegates.Reset_WithArgs>(
                ReflectionHelper.GetMethodInfo(typeof(HutongGames.PlayMaker.Actions.GetChild), "Reset", true), value);
            remove => HookEndpointManager.Remove<Delegates.Reset_WithArgs>(
                ReflectionHelper.GetMethodInfo(typeof(HutongGames.PlayMaker.Actions.GetChild), "Reset", true), value);
        }

        public static event Delegates.OnEnter_WithArgs OnEnter
        {
            add => HookEndpointManager.Add<Delegates.OnEnter_WithArgs>(
                ReflectionHelper.GetMethodInfo(typeof(HutongGames.PlayMaker.Actions.GetChild), "OnEnter", true), value);
            remove => HookEndpointManager.Remove<Delegates.OnEnter_WithArgs>(
                ReflectionHelper.GetMethodInfo(typeof(HutongGames.PlayMaker.Actions.GetChild), "OnEnter", true), value);
        }

        public static event Delegates.DoGetChildByName_WithArgs DoGetChildByName
        {
            add => HookEndpointManager.Add<Delegates.DoGetChildByName_WithArgs>(
                ReflectionHelper.GetMethodInfo(typeof(HutongGames.PlayMaker.Actions.GetChild), "DoGetChildByName",
                    false), value);
            remove => HookEndpointManager.Remove<Delegates.DoGetChildByName_WithArgs>(
                ReflectionHelper.GetMethodInfo(typeof(HutongGames.PlayMaker.Actions.GetChild), "DoGetChildByName",
                    false), value);
        }

        public static event Delegates.ErrorCheck_WithArgs ErrorCheck
        {
            add => HookEndpointManager.Add<Delegates.ErrorCheck_WithArgs>(
                ReflectionHelper.GetMethodInfo(typeof(HutongGames.PlayMaker.Actions.GetChild), "ErrorCheck", true),
                value);
            remove => HookEndpointManager.Remove<Delegates.ErrorCheck_WithArgs>(
                ReflectionHelper.GetMethodInfo(typeof(HutongGames.PlayMaker.Actions.GetChild), "ErrorCheck", true),
                value);
        }
    }
}