using MonoMod.RuntimeDetour;
using MonoMod.RuntimeDetour.HookGen;

namespace HKMirror.Hooks.OnHooks;

/// <summary>
///     Contains different types of On Hooks for KeybindUtil class.<br />
///     Contains hooks that aren't generated by monomod, and before and after orig hooks for easier hooking.
/// </summary>
public static class OnKeybindUtil
{
    internal static class HookHandler
    {
        private static readonly List<string> HookedList = new();

        internal static void HookParseBinding()
        {
            if (!HookedList.Contains("ParseBinding"))
            {
                HookedList.Add("ParseBinding");
                new Hook(ReflectionHelper.GetMethodInfo(typeof(KeybindUtil), "ParseBinding", false), ParseBinding);
            }
        }

        internal static event Delegates.ParseBinding_BeforeArgs _beforeParseBinding;
        internal static event Delegates.ParseBinding_AfterArgs _afterParseBinding;

        private static InputHandler.KeyOrMouseBinding? ParseBinding(Func<string, InputHandler.KeyOrMouseBinding?> orig,
            string src)
        {
            Delegates.Params_ParseBinding @params = new()
            {
                src = src
            };
            if (_beforeParseBinding != null)
                foreach (Delegates.ParseBinding_BeforeArgs toInvoke in _beforeParseBinding.GetInvocationList())
                    try
                    {
                        _beforeParseBinding?.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }

            src = @params.src;
            var retVal = orig(src);
            if (_afterParseBinding != null)
                foreach (Delegates.ParseBinding_AfterArgs toInvoke in _afterParseBinding.GetInvocationList())
                    try
                    {
                        retVal = _afterParseBinding.Invoke(@params, retVal);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }

            return retVal;
        }

        internal static void HookGetControllerButtonBinding()
        {
            if (!HookedList.Contains("GetControllerButtonBinding"))
            {
                HookedList.Add("GetControllerButtonBinding");
                new Hook(ReflectionHelper.GetMethodInfo(typeof(KeybindUtil), "GetControllerButtonBinding", false),
                    GetControllerButtonBinding);
            }
        }

        internal static event Delegates.GetControllerButtonBinding_BeforeArgs _beforeGetControllerButtonBinding;
        internal static event Delegates.GetControllerButtonBinding_AfterArgs _afterGetControllerButtonBinding;

        private static InputControlType GetControllerButtonBinding(Func<PlayerAction, InputControlType> orig,
            PlayerAction ac)
        {
            Delegates.Params_GetControllerButtonBinding @params = new()
            {
                ac = ac
            };
            if (_beforeGetControllerButtonBinding != null)
                foreach (Delegates.GetControllerButtonBinding_BeforeArgs toInvoke in _beforeGetControllerButtonBinding
                             .GetInvocationList())
                    try
                    {
                        _beforeGetControllerButtonBinding?.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }

            ac = @params.ac;
            var retVal = orig(ac);
            if (_afterGetControllerButtonBinding != null)
                foreach (Delegates.GetControllerButtonBinding_AfterArgs toInvoke in _afterGetControllerButtonBinding
                             .GetInvocationList())
                    try
                    {
                        retVal = _afterGetControllerButtonBinding.Invoke(@params, retVal);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }

            return retVal;
        }

        internal static void HookAddInputControlType()
        {
            if (!HookedList.Contains("AddInputControlType"))
            {
                HookedList.Add("AddInputControlType");
                new Hook(ReflectionHelper.GetMethodInfo(typeof(KeybindUtil), "AddInputControlType", false),
                    AddInputControlType);
            }
        }

        internal static event Delegates.AddInputControlType_BeforeArgs _beforeAddInputControlType;
        internal static event Delegates.AddInputControlType_AfterArgs _afterAddInputControlType;

        private static void AddInputControlType(Action<PlayerAction, InputControlType> orig, PlayerAction action,
            InputControlType binding)
        {
            Delegates.Params_AddInputControlType @params = new()
            {
                action = action, binding = binding
            };
            if (_beforeAddInputControlType != null)
                foreach (Delegates.AddInputControlType_BeforeArgs toInvoke in _beforeAddInputControlType
                             .GetInvocationList())
                    try
                    {
                        _beforeAddInputControlType?.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }

            action = @params.action;
            binding = @params.binding;
            orig(action, binding);
            if (_afterAddInputControlType != null)
                foreach (Delegates.AddInputControlType_AfterArgs toInvoke in
                         _afterAddInputControlType.GetInvocationList())
                    try
                    {
                        _afterAddInputControlType.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }
        }

        internal static void HookParseInputControlTypeBinding()
        {
            if (!HookedList.Contains("ParseInputControlTypeBinding"))
            {
                HookedList.Add("ParseInputControlTypeBinding");
                new Hook(ReflectionHelper.GetMethodInfo(typeof(KeybindUtil), "ParseInputControlTypeBinding", false),
                    ParseInputControlTypeBinding);
            }
        }

        internal static event Delegates.ParseInputControlTypeBinding_BeforeArgs _beforeParseInputControlTypeBinding;
        internal static event Delegates.ParseInputControlTypeBinding_AfterArgs _afterParseInputControlTypeBinding;

        private static InputControlType? ParseInputControlTypeBinding(Func<string, InputControlType?> orig, string src)
        {
            Delegates.Params_ParseInputControlTypeBinding @params = new()
            {
                src = src
            };
            if (_beforeParseInputControlTypeBinding != null)
                foreach (Delegates.ParseInputControlTypeBinding_BeforeArgs toInvoke in
                         _beforeParseInputControlTypeBinding.GetInvocationList())
                    try
                    {
                        _beforeParseInputControlTypeBinding?.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }

            src = @params.src;
            var retVal = orig(src);
            if (_afterParseInputControlTypeBinding != null)
                foreach (Delegates.ParseInputControlTypeBinding_AfterArgs toInvoke in _afterParseInputControlTypeBinding
                             .GetInvocationList())
                    try
                    {
                        retVal = _afterParseInputControlTypeBinding.Invoke(@params, retVal);
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
        public delegate void AddInputControlType_AfterArgs(Params_AddInputControlType args);

        public delegate void AddInputControlType_BeforeArgs(Params_AddInputControlType args);

        public delegate void AddInputControlType_WithArgs(Action<PlayerAction, InputControlType> orig,
            PlayerAction action, InputControlType binding);

        public delegate InputControlType GetControllerButtonBinding_AfterArgs(Params_GetControllerButtonBinding args,
            InputControlType ret);

        public delegate void GetControllerButtonBinding_BeforeArgs(Params_GetControllerButtonBinding args);

        public delegate InputControlType GetControllerButtonBinding_WithArgs(Func<PlayerAction, InputControlType> orig,
            PlayerAction ac);

        public delegate InputHandler.KeyOrMouseBinding? ParseBinding_AfterArgs(Params_ParseBinding args,
            InputHandler.KeyOrMouseBinding? ret);

        public delegate void ParseBinding_BeforeArgs(Params_ParseBinding args);

        public delegate InputHandler.KeyOrMouseBinding? ParseBinding_WithArgs(
            Func<string, InputHandler.KeyOrMouseBinding?> orig, string src);

        public delegate InputControlType? ParseInputControlTypeBinding_AfterArgs(
            Params_ParseInputControlTypeBinding args, InputControlType? ret);

        public delegate void ParseInputControlTypeBinding_BeforeArgs(Params_ParseInputControlTypeBinding args);

        public delegate InputControlType? ParseInputControlTypeBinding_WithArgs(Func<string, InputControlType?> orig,
            string src);

        public sealed class Params_ParseBinding
        {
            public string src;
        }

        public sealed class Params_GetControllerButtonBinding
        {
            public PlayerAction ac;
        }

        public sealed class Params_AddInputControlType
        {
            public PlayerAction action;
            public InputControlType binding;
        }

        public sealed class Params_ParseInputControlTypeBinding
        {
            public string src;
        }
    }

    /// <summary>
    ///     Contains Hooks to that run code before orig(self) is called
    /// </summary>
    public static class BeforeOrig
    {
        public static event Delegates.ParseBinding_BeforeArgs ParseBinding
        {
            add
            {
                HookHandler._beforeParseBinding += value;
                HookHandler.HookParseBinding();
            }
            remove => HookHandler._beforeParseBinding -= value;
        }

        public static event Delegates.GetControllerButtonBinding_BeforeArgs GetControllerButtonBinding
        {
            add
            {
                HookHandler._beforeGetControllerButtonBinding += value;
                HookHandler.HookGetControllerButtonBinding();
            }
            remove => HookHandler._beforeGetControllerButtonBinding -= value;
        }

        public static event Delegates.AddInputControlType_BeforeArgs AddInputControlType
        {
            add
            {
                HookHandler._beforeAddInputControlType += value;
                HookHandler.HookAddInputControlType();
            }
            remove => HookHandler._beforeAddInputControlType -= value;
        }

        public static event Delegates.ParseInputControlTypeBinding_BeforeArgs ParseInputControlTypeBinding
        {
            add
            {
                HookHandler._beforeParseInputControlTypeBinding += value;
                HookHandler.HookParseInputControlTypeBinding();
            }
            remove => HookHandler._beforeParseInputControlTypeBinding -= value;
        }
    }

    /// <summary>
    ///     Contains Hooks to that run code after orig(self) is called
    /// </summary>
    public static class AfterOrig
    {
        public static event Delegates.ParseBinding_AfterArgs ParseBinding
        {
            add
            {
                HookHandler._afterParseBinding += value;
                HookHandler.HookParseBinding();
            }
            remove => HookHandler._afterParseBinding -= value;
        }

        public static event Delegates.GetControllerButtonBinding_AfterArgs GetControllerButtonBinding
        {
            add
            {
                HookHandler._afterGetControllerButtonBinding += value;
                HookHandler.HookGetControllerButtonBinding();
            }
            remove => HookHandler._afterGetControllerButtonBinding -= value;
        }

        public static event Delegates.AddInputControlType_AfterArgs AddInputControlType
        {
            add
            {
                HookHandler._afterAddInputControlType += value;
                HookHandler.HookAddInputControlType();
            }
            remove => HookHandler._afterAddInputControlType -= value;
        }

        public static event Delegates.ParseInputControlTypeBinding_AfterArgs ParseInputControlTypeBinding
        {
            add
            {
                HookHandler._afterParseInputControlTypeBinding += value;
                HookHandler.HookParseInputControlTypeBinding();
            }
            remove => HookHandler._afterParseInputControlTypeBinding -= value;
        }
    }

    /// <summary>
    ///     Contains all On Hooks, even those that aren't in the On namespace such as API generated functions and property
    ///     getters/setters
    /// </summary>
    public static class WithOrig
    {
        public static event Delegates.ParseBinding_WithArgs ParseBinding
        {
            add => HookEndpointManager.Add<Delegates.ParseBinding_WithArgs>(
                ReflectionHelper.GetMethodInfo(typeof(KeybindUtil), "ParseBinding", false), value);
            remove => HookEndpointManager.Remove<Delegates.ParseBinding_WithArgs>(
                ReflectionHelper.GetMethodInfo(typeof(KeybindUtil), "ParseBinding", false), value);
        }

        public static event Delegates.GetControllerButtonBinding_WithArgs GetControllerButtonBinding
        {
            add => HookEndpointManager.Add<Delegates.GetControllerButtonBinding_WithArgs>(
                ReflectionHelper.GetMethodInfo(typeof(KeybindUtil), "GetControllerButtonBinding", false), value);
            remove => HookEndpointManager.Remove<Delegates.GetControllerButtonBinding_WithArgs>(
                ReflectionHelper.GetMethodInfo(typeof(KeybindUtil), "GetControllerButtonBinding", false), value);
        }

        public static event Delegates.AddInputControlType_WithArgs AddInputControlType
        {
            add => HookEndpointManager.Add<Delegates.AddInputControlType_WithArgs>(
                ReflectionHelper.GetMethodInfo(typeof(KeybindUtil), "AddInputControlType", false), value);
            remove => HookEndpointManager.Remove<Delegates.AddInputControlType_WithArgs>(
                ReflectionHelper.GetMethodInfo(typeof(KeybindUtil), "AddInputControlType", false), value);
        }

        public static event Delegates.ParseInputControlTypeBinding_WithArgs ParseInputControlTypeBinding
        {
            add => HookEndpointManager.Add<Delegates.ParseInputControlTypeBinding_WithArgs>(
                ReflectionHelper.GetMethodInfo(typeof(KeybindUtil), "ParseInputControlTypeBinding", false), value);
            remove => HookEndpointManager.Remove<Delegates.ParseInputControlTypeBinding_WithArgs>(
                ReflectionHelper.GetMethodInfo(typeof(KeybindUtil), "ParseInputControlTypeBinding", false), value);
        }
    }
}