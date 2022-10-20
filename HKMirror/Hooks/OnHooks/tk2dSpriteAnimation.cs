using MonoMod.RuntimeDetour;
using MonoMod.RuntimeDetour.HookGen;

namespace HKMirror.Hooks.OnHooks;

/// <summary>
///     Contains different types of On Hooks for tk2dSpriteAnimation class.<br />
///     Contains hooks that aren't generated by monomod, and before and after orig hooks for easier hooking.
/// </summary>
public static class Ontk2dSpriteAnimation
{
    internal static class HookHandler
    {
        private static readonly List<string> HookedList = new();

        internal static void HookGetClipByName()
        {
            if (!HookedList.Contains("GetClipByName"))
            {
                HookedList.Add("GetClipByName");
                On.tk2dSpriteAnimation.GetClipByName += GetClipByName;
            }
        }

        internal static event Delegates.GetClipByName_BeforeArgs _beforeGetClipByName;
        internal static event Delegates.GetClipByName_NormalArgs _afterGetClipByName;

        private static tk2dSpriteAnimationClip GetClipByName(On.tk2dSpriteAnimation.orig_GetClipByName orig,
            tk2dSpriteAnimation self, string name)
        {
            Delegates.Params_GetClipByName @params = new()
            {
                self = self, name = name
            };
            _beforeGetClipByName?.Invoke(@params);
            self = @params.self;
            name = @params.name;
            var retVal = orig(self, name);
            if (_afterGetClipByName != null) retVal = _afterGetClipByName.Invoke(@params);
            return retVal;
        }

        internal static void HookGetClipById()
        {
            if (!HookedList.Contains("GetClipById"))
            {
                HookedList.Add("GetClipById");
                On.tk2dSpriteAnimation.GetClipById += GetClipById;
            }
        }

        internal static event Delegates.GetClipById_BeforeArgs _beforeGetClipById;
        internal static event Delegates.GetClipById_NormalArgs _afterGetClipById;

        private static tk2dSpriteAnimationClip GetClipById(On.tk2dSpriteAnimation.orig_GetClipById orig,
            tk2dSpriteAnimation self, int id)
        {
            Delegates.Params_GetClipById @params = new()
            {
                self = self, id = id
            };
            _beforeGetClipById?.Invoke(@params);
            self = @params.self;
            id = @params.id;
            var retVal = orig(self, id);
            if (_afterGetClipById != null) retVal = _afterGetClipById.Invoke(@params);
            return retVal;
        }

        internal static void HookGetClipIdByName_string()
        {
            if (!HookedList.Contains("GetClipIdByName_string"))
            {
                HookedList.Add("GetClipIdByName_string");
                On.tk2dSpriteAnimation.GetClipIdByName_string += GetClipIdByName_string;
            }
        }

        internal static event Delegates.GetClipIdByName_string_BeforeArgs _beforeGetClipIdByName_string;
        internal static event Delegates.GetClipIdByName_string_NormalArgs _afterGetClipIdByName_string;

        private static int GetClipIdByName_string(On.tk2dSpriteAnimation.orig_GetClipIdByName_string orig,
            tk2dSpriteAnimation self, string name)
        {
            Delegates.Params_GetClipIdByName_string @params = new()
            {
                self = self, name = name
            };
            _beforeGetClipIdByName_string?.Invoke(@params);
            self = @params.self;
            name = @params.name;
            var retVal = orig(self, name);
            if (_afterGetClipIdByName_string != null) retVal = _afterGetClipIdByName_string.Invoke(@params);
            return retVal;
        }

        internal static void HookGetClipIdByName_tk2dSpriteAnimationClip()
        {
            if (!HookedList.Contains("GetClipIdByName_tk2dSpriteAnimationClip"))
            {
                HookedList.Add("GetClipIdByName_tk2dSpriteAnimationClip");
                On.tk2dSpriteAnimation.GetClipIdByName_tk2dSpriteAnimationClip +=
                    GetClipIdByName_tk2dSpriteAnimationClip;
            }
        }

        internal static event Delegates.GetClipIdByName_tk2dSpriteAnimationClip_BeforeArgs
            _beforeGetClipIdByName_tk2dSpriteAnimationClip;

        internal static event Delegates.GetClipIdByName_tk2dSpriteAnimationClip_NormalArgs
            _afterGetClipIdByName_tk2dSpriteAnimationClip;

        private static int GetClipIdByName_tk2dSpriteAnimationClip(
            On.tk2dSpriteAnimation.orig_GetClipIdByName_tk2dSpriteAnimationClip orig, tk2dSpriteAnimation self,
            tk2dSpriteAnimationClip clip)
        {
            Delegates.Params_GetClipIdByName_tk2dSpriteAnimationClip @params = new()
            {
                self = self, clip = clip
            };
            _beforeGetClipIdByName_tk2dSpriteAnimationClip?.Invoke(@params);
            self = @params.self;
            clip = @params.clip;
            var retVal = orig(self, clip);
            if (_afterGetClipIdByName_tk2dSpriteAnimationClip != null)
                retVal = _afterGetClipIdByName_tk2dSpriteAnimationClip.Invoke(@params);
            return retVal;
        }

        internal static void Hookget_FirstValidClip()
        {
            if (!HookedList.Contains("get_FirstValidClip"))
            {
                HookedList.Add("get_FirstValidClip");
                new Hook(ReflectionHelper.GetMethodInfo(typeof(tk2dSpriteAnimation), "get_FirstValidClip"),
                    get_FirstValidClip);
            }
        }

        internal static event Delegates.get_FirstValidClip_BeforeArgs _beforeget_FirstValidClip;
        internal static event Delegates.get_FirstValidClip_NormalArgs _afterget_FirstValidClip;

        private static tk2dSpriteAnimationClip get_FirstValidClip(
            Func<tk2dSpriteAnimation, tk2dSpriteAnimationClip> orig, tk2dSpriteAnimation self)
        {
            Delegates.Params_get_FirstValidClip @params = new()
            {
                self = self
            };
            _beforeget_FirstValidClip?.Invoke(@params);
            self = @params.self;
            var retVal = orig(self);
            if (_afterget_FirstValidClip != null) retVal = _afterget_FirstValidClip.Invoke(@params);
            return retVal;
        }
    }

    /// <summary>
    ///     Contains necessary information to create Hooks. Does not contain any hooks
    /// </summary>
    public static class Delegates
    {
        public delegate void get_FirstValidClip_BeforeArgs(Params_get_FirstValidClip args);

        public delegate tk2dSpriteAnimationClip get_FirstValidClip_NormalArgs(Params_get_FirstValidClip args);

        public delegate void GetClipById_BeforeArgs(Params_GetClipById args);

        public delegate tk2dSpriteAnimationClip GetClipById_NormalArgs(Params_GetClipById args);

        public delegate void GetClipByName_BeforeArgs(Params_GetClipByName args);

        public delegate tk2dSpriteAnimationClip GetClipByName_NormalArgs(Params_GetClipByName args);

        public delegate void GetClipIdByName_string_BeforeArgs(Params_GetClipIdByName_string args);

        public delegate int GetClipIdByName_string_NormalArgs(Params_GetClipIdByName_string args);

        public delegate void GetClipIdByName_tk2dSpriteAnimationClip_BeforeArgs(
            Params_GetClipIdByName_tk2dSpriteAnimationClip args);

        public delegate int GetClipIdByName_tk2dSpriteAnimationClip_NormalArgs(
            Params_GetClipIdByName_tk2dSpriteAnimationClip args);

        public sealed class Params_GetClipByName
        {
            public string name;
            public tk2dSpriteAnimation self;
        }

        public sealed class Params_GetClipById
        {
            public int id;
            public tk2dSpriteAnimation self;
        }

        public sealed class Params_GetClipIdByName_string
        {
            public string name;
            public tk2dSpriteAnimation self;
        }

        public sealed class Params_GetClipIdByName_tk2dSpriteAnimationClip
        {
            public tk2dSpriteAnimationClip clip;
            public tk2dSpriteAnimation self;
        }

        public sealed class Params_get_FirstValidClip
        {
            public tk2dSpriteAnimation self;
        }
    }

    /// <summary>
    ///     Contains Hooks to that run code before orig(self) is called
    /// </summary>
    public static class BeforeOrig
    {
        public static event Delegates.GetClipByName_BeforeArgs GetClipByName
        {
            add
            {
                HookHandler._beforeGetClipByName += value;
                HookHandler.HookGetClipByName();
            }
            remove => HookHandler._beforeGetClipByName -= value;
        }

        public static event Delegates.GetClipById_BeforeArgs GetClipById
        {
            add
            {
                HookHandler._beforeGetClipById += value;
                HookHandler.HookGetClipById();
            }
            remove => HookHandler._beforeGetClipById -= value;
        }

        public static event Delegates.GetClipIdByName_string_BeforeArgs GetClipIdByName_string
        {
            add
            {
                HookHandler._beforeGetClipIdByName_string += value;
                HookHandler.HookGetClipIdByName_string();
            }
            remove => HookHandler._beforeGetClipIdByName_string -= value;
        }

        public static event Delegates.GetClipIdByName_tk2dSpriteAnimationClip_BeforeArgs
            GetClipIdByName_tk2dSpriteAnimationClip
            {
                add
                {
                    HookHandler._beforeGetClipIdByName_tk2dSpriteAnimationClip += value;
                    HookHandler.HookGetClipIdByName_tk2dSpriteAnimationClip();
                }
                remove => HookHandler._beforeGetClipIdByName_tk2dSpriteAnimationClip -= value;
            }

        public static event Delegates.get_FirstValidClip_BeforeArgs get_FirstValidClip
        {
            add
            {
                HookHandler._beforeget_FirstValidClip += value;
                HookHandler.Hookget_FirstValidClip();
            }
            remove => HookHandler._beforeget_FirstValidClip -= value;
        }
    }

    /// <summary>
    ///     Contains Hooks to that run code after orig(self) is called
    /// </summary>
    public static class AfterOrig
    {
        public static event Delegates.GetClipByName_NormalArgs GetClipByName
        {
            add
            {
                HookHandler._afterGetClipByName += value;
                HookHandler.HookGetClipByName();
            }
            remove => HookHandler._afterGetClipByName -= value;
        }

        public static event Delegates.GetClipById_NormalArgs GetClipById
        {
            add
            {
                HookHandler._afterGetClipById += value;
                HookHandler.HookGetClipById();
            }
            remove => HookHandler._afterGetClipById -= value;
        }

        public static event Delegates.GetClipIdByName_string_NormalArgs GetClipIdByName_string
        {
            add
            {
                HookHandler._afterGetClipIdByName_string += value;
                HookHandler.HookGetClipIdByName_string();
            }
            remove => HookHandler._afterGetClipIdByName_string -= value;
        }

        public static event Delegates.GetClipIdByName_tk2dSpriteAnimationClip_NormalArgs
            GetClipIdByName_tk2dSpriteAnimationClip
            {
                add
                {
                    HookHandler._afterGetClipIdByName_tk2dSpriteAnimationClip += value;
                    HookHandler.HookGetClipIdByName_tk2dSpriteAnimationClip();
                }
                remove => HookHandler._afterGetClipIdByName_tk2dSpriteAnimationClip -= value;
            }

        public static event Delegates.get_FirstValidClip_NormalArgs get_FirstValidClip
        {
            add
            {
                HookHandler._afterget_FirstValidClip += value;
                HookHandler.Hookget_FirstValidClip();
            }
            remove => HookHandler._afterget_FirstValidClip -= value;
        }
    }

    /// <summary>
    ///     Contains all On Hooks, even those that aren't in the On namespace such as API generated functions and property
    ///     getters/setters
    /// </summary>
    public static class WithOrig
    {
        public static event On.tk2dSpriteAnimation.hook_GetClipByName GetClipByName
        {
            add => On.tk2dSpriteAnimation.GetClipByName += value;
            remove => On.tk2dSpriteAnimation.GetClipByName -= value;
        }

        public static event On.tk2dSpriteAnimation.hook_GetClipById GetClipById
        {
            add => On.tk2dSpriteAnimation.GetClipById += value;
            remove => On.tk2dSpriteAnimation.GetClipById -= value;
        }

        public static event On.tk2dSpriteAnimation.hook_GetClipIdByName_string GetClipIdByName_string
        {
            add => On.tk2dSpriteAnimation.GetClipIdByName_string += value;
            remove => On.tk2dSpriteAnimation.GetClipIdByName_string -= value;
        }

        public static event On.tk2dSpriteAnimation.hook_GetClipIdByName_tk2dSpriteAnimationClip
            GetClipIdByName_tk2dSpriteAnimationClip
            {
                add => On.tk2dSpriteAnimation.GetClipIdByName_tk2dSpriteAnimationClip += value;
                remove => On.tk2dSpriteAnimation.GetClipIdByName_tk2dSpriteAnimationClip -= value;
            }

        public static event Delegates.get_FirstValidClip_NormalArgs get_FirstValidClip
        {
            add => HookEndpointManager.Add<Delegates.get_FirstValidClip_NormalArgs>(
                ReflectionHelper.GetMethodInfo(typeof(tk2dSpriteAnimation), "get_FirstValidClip"), value);
            remove => HookEndpointManager.Remove<Delegates.get_FirstValidClip_NormalArgs>(
                ReflectionHelper.GetMethodInfo(typeof(tk2dSpriteAnimation), "get_FirstValidClip"), value);
        }
    }
}