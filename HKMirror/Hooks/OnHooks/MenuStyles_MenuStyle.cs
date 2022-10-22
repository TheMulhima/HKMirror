using MonoMod.RuntimeDetour;
using MonoMod.RuntimeDetour.HookGen;

namespace HKMirror.Hooks.OnHooks;

/// <summary>
///     Contains different types of On Hooks for MenuStyles_MenuStyle class.<br />
///     Contains hooks that aren't generated by monomod, and before and after orig hooks for easier hooking.
/// </summary>
public static class OnMenuStyles_MenuStyle
{
    internal static class HookHandler
    {
        private static readonly List<string> HookedList = new();

        internal static void Hookget_IsAvailable()
        {
            if (!HookedList.Contains("get_IsAvailable"))
            {
                HookedList.Add("get_IsAvailable");
                new Hook(ReflectionHelper.GetMethodInfo(typeof(MenuStyles.MenuStyle), "get_IsAvailable"),
                    get_IsAvailable);
            }
        }

        internal static event Delegates.get_IsAvailable_BeforeArgs _beforeget_IsAvailable;
        internal static event Delegates.get_IsAvailable_AfterArgs _afterget_IsAvailable;

        private static bool get_IsAvailable(Func<MenuStyles.MenuStyle, bool> orig, MenuStyles.MenuStyle self)
        {
            Delegates.Params_get_IsAvailable @params = new()
            {
                self = self
            };
            if (_beforeget_IsAvailable != null)
                foreach (Delegates.get_IsAvailable_BeforeArgs toInvoke in _beforeget_IsAvailable.GetInvocationList())
                    try
                    {
                        _beforeget_IsAvailable?.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }

            self = @params.self;
            var retVal = orig(self);
            if (_afterget_IsAvailable != null)
                foreach (Delegates.get_IsAvailable_AfterArgs toInvoke in _afterget_IsAvailable.GetInvocationList())
                    try
                    {
                        retVal = _afterget_IsAvailable.Invoke(@params, retVal);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }

            return retVal;
        }

        internal static void HookSetInitialAudioVolumes()
        {
            if (!HookedList.Contains("SetInitialAudioVolumes"))
            {
                HookedList.Add("SetInitialAudioVolumes");
                new Hook(ReflectionHelper.GetMethodInfo(typeof(MenuStyles.MenuStyle), "SetInitialAudioVolumes"),
                    SetInitialAudioVolumes);
            }
        }

        internal static event Delegates.SetInitialAudioVolumes_BeforeArgs _beforeSetInitialAudioVolumes;
        internal static event Delegates.SetInitialAudioVolumes_AfterArgs _afterSetInitialAudioVolumes;

        private static void SetInitialAudioVolumes(Action<MenuStyles.MenuStyle, AudioSource[]> orig,
            MenuStyles.MenuStyle self, AudioSource[] sources)
        {
            Delegates.Params_SetInitialAudioVolumes @params = new()
            {
                self = self, sources = sources
            };
            if (_beforeSetInitialAudioVolumes != null)
                foreach (Delegates.SetInitialAudioVolumes_BeforeArgs toInvoke in _beforeSetInitialAudioVolumes
                             .GetInvocationList())
                    try
                    {
                        _beforeSetInitialAudioVolumes?.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }

            self = @params.self;
            sources = @params.sources;
            orig(self, sources);
            if (_afterSetInitialAudioVolumes != null)
                foreach (Delegates.SetInitialAudioVolumes_AfterArgs toInvoke in _afterSetInitialAudioVolumes
                             .GetInvocationList())
                    try
                    {
                        _afterSetInitialAudioVolumes.Invoke(@params);
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
        public delegate bool get_IsAvailable_AfterArgs(Params_get_IsAvailable args, bool ret);

        public delegate void get_IsAvailable_BeforeArgs(Params_get_IsAvailable args);

        public delegate bool get_IsAvailable_WithArgs(Func<MenuStyles.MenuStyle, bool> orig, MenuStyles.MenuStyle self);

        public delegate void SetInitialAudioVolumes_AfterArgs(Params_SetInitialAudioVolumes args);

        public delegate void SetInitialAudioVolumes_BeforeArgs(Params_SetInitialAudioVolumes args);

        public delegate void SetInitialAudioVolumes_WithArgs(Action<MenuStyles.MenuStyle, AudioSource[]> orig,
            MenuStyles.MenuStyle self, AudioSource[] sources);

        public sealed class Params_get_IsAvailable
        {
            public MenuStyles.MenuStyle self;
        }

        public sealed class Params_SetInitialAudioVolumes
        {
            public MenuStyles.MenuStyle self;
            public AudioSource[] sources;
        }
    }

    /// <summary>
    ///     Contains Hooks to that run code before orig(self) is called
    /// </summary>
    public static class BeforeOrig
    {
        public static event Delegates.get_IsAvailable_BeforeArgs get_IsAvailable
        {
            add
            {
                HookHandler._beforeget_IsAvailable += value;
                HookHandler.Hookget_IsAvailable();
            }
            remove => HookHandler._beforeget_IsAvailable -= value;
        }

        public static event Delegates.SetInitialAudioVolumes_BeforeArgs SetInitialAudioVolumes
        {
            add
            {
                HookHandler._beforeSetInitialAudioVolumes += value;
                HookHandler.HookSetInitialAudioVolumes();
            }
            remove => HookHandler._beforeSetInitialAudioVolumes -= value;
        }
    }

    /// <summary>
    ///     Contains Hooks to that run code after orig(self) is called
    /// </summary>
    public static class AfterOrig
    {
        public static event Delegates.get_IsAvailable_AfterArgs get_IsAvailable
        {
            add
            {
                HookHandler._afterget_IsAvailable += value;
                HookHandler.Hookget_IsAvailable();
            }
            remove => HookHandler._afterget_IsAvailable -= value;
        }

        public static event Delegates.SetInitialAudioVolumes_AfterArgs SetInitialAudioVolumes
        {
            add
            {
                HookHandler._afterSetInitialAudioVolumes += value;
                HookHandler.HookSetInitialAudioVolumes();
            }
            remove => HookHandler._afterSetInitialAudioVolumes -= value;
        }
    }

    /// <summary>
    ///     Contains all On Hooks, even those that aren't in the On namespace such as API generated functions and property
    ///     getters/setters
    /// </summary>
    public static class WithOrig
    {
        public static event Delegates.get_IsAvailable_WithArgs get_IsAvailable
        {
            add => HookEndpointManager.Add<Delegates.get_IsAvailable_WithArgs>(
                ReflectionHelper.GetMethodInfo(typeof(MenuStyles.MenuStyle), "get_IsAvailable"), value);
            remove => HookEndpointManager.Remove<Delegates.get_IsAvailable_WithArgs>(
                ReflectionHelper.GetMethodInfo(typeof(MenuStyles.MenuStyle), "get_IsAvailable"), value);
        }

        public static event Delegates.SetInitialAudioVolumes_WithArgs SetInitialAudioVolumes
        {
            add => HookEndpointManager.Add<Delegates.SetInitialAudioVolumes_WithArgs>(
                ReflectionHelper.GetMethodInfo(typeof(MenuStyles.MenuStyle), "SetInitialAudioVolumes"), value);
            remove => HookEndpointManager.Remove<Delegates.SetInitialAudioVolumes_WithArgs>(
                ReflectionHelper.GetMethodInfo(typeof(MenuStyles.MenuStyle), "SetInitialAudioVolumes"), value);
        }
    }
}