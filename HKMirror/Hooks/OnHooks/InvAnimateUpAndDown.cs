using MonoMod.RuntimeDetour;
using MonoMod.RuntimeDetour.HookGen;

namespace HKMirror.Hooks.OnHooks;

/// <summary>
/// Contains different types of On Hooks for InvAnimateUpAndDown class.<br />
/// Contains hooks that aren't generated by monomod, and before and after orig hooks for easier hooking.
/// </summary>
public static class OnInvAnimateUpAndDown
{
    internal static class HookHandler
    {
        private static List<string> HookedList = new List<string>();

        internal static void HookAwake()
        {
            if (!HookedList.Contains("Awake"))
            {
                HookedList.Add("Awake");
                On.InvAnimateUpAndDown.Awake += Awake;
            }
        }

        internal static event Delegates.Awake_BeforeArgs _beforeAwake;
        internal static event Delegates.Awake_AfterArgs _afterAwake;

        private static void Awake(On.InvAnimateUpAndDown.orig_Awake orig, InvAnimateUpAndDown self)
        {
            Delegates.Params_Awake @params = new()
            {
                self = self
            };
            if (_beforeAwake != null)
            {
                foreach (Delegates.Awake_BeforeArgs toInvoke in _beforeAwake.GetInvocationList())
                {
                    try
                    {
                        _beforeAwake?.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }
                }
            }

            self = @params.self;
            orig(self);
            if (_afterAwake != null)
            {
                foreach (Delegates.Awake_AfterArgs toInvoke in _afterAwake.GetInvocationList())
                {
                    try
                    {
                        _afterAwake.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }
                }
            }
        }

        internal static void HookUpdate()
        {
            if (!HookedList.Contains("Update"))
            {
                HookedList.Add("Update");
                On.InvAnimateUpAndDown.Update += Update;
            }
        }

        internal static event Delegates.Update_BeforeArgs _beforeUpdate;
        internal static event Delegates.Update_AfterArgs _afterUpdate;

        private static void Update(On.InvAnimateUpAndDown.orig_Update orig, InvAnimateUpAndDown self)
        {
            Delegates.Params_Update @params = new()
            {
                self = self
            };
            if (_beforeUpdate != null)
            {
                foreach (Delegates.Update_BeforeArgs toInvoke in _beforeUpdate.GetInvocationList())
                {
                    try
                    {
                        _beforeUpdate?.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }
                }
            }

            self = @params.self;
            orig(self);
            if (_afterUpdate != null)
            {
                foreach (Delegates.Update_AfterArgs toInvoke in _afterUpdate.GetInvocationList())
                {
                    try
                    {
                        _afterUpdate.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }
                }
            }
        }

        internal static void HookAnimateUp()
        {
            if (!HookedList.Contains("AnimateUp"))
            {
                HookedList.Add("AnimateUp");
                On.InvAnimateUpAndDown.AnimateUp += AnimateUp;
            }
        }

        internal static event Delegates.AnimateUp_BeforeArgs _beforeAnimateUp;
        internal static event Delegates.AnimateUp_AfterArgs _afterAnimateUp;

        private static void AnimateUp(On.InvAnimateUpAndDown.orig_AnimateUp orig, InvAnimateUpAndDown self)
        {
            Delegates.Params_AnimateUp @params = new()
            {
                self = self
            };
            if (_beforeAnimateUp != null)
            {
                foreach (Delegates.AnimateUp_BeforeArgs toInvoke in _beforeAnimateUp.GetInvocationList())
                {
                    try
                    {
                        _beforeAnimateUp?.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }
                }
            }

            self = @params.self;
            orig(self);
            if (_afterAnimateUp != null)
            {
                foreach (Delegates.AnimateUp_AfterArgs toInvoke in _afterAnimateUp.GetInvocationList())
                {
                    try
                    {
                        _afterAnimateUp.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }
                }
            }
        }

        internal static void HookAnimateDown()
        {
            if (!HookedList.Contains("AnimateDown"))
            {
                HookedList.Add("AnimateDown");
                On.InvAnimateUpAndDown.AnimateDown += AnimateDown;
            }
        }

        internal static event Delegates.AnimateDown_BeforeArgs _beforeAnimateDown;
        internal static event Delegates.AnimateDown_AfterArgs _afterAnimateDown;

        private static void AnimateDown(On.InvAnimateUpAndDown.orig_AnimateDown orig, InvAnimateUpAndDown self)
        {
            Delegates.Params_AnimateDown @params = new()
            {
                self = self
            };
            if (_beforeAnimateDown != null)
            {
                foreach (Delegates.AnimateDown_BeforeArgs toInvoke in _beforeAnimateDown.GetInvocationList())
                {
                    try
                    {
                        _beforeAnimateDown?.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }
                }
            }

            self = @params.self;
            orig(self);
            if (_afterAnimateDown != null)
            {
                foreach (Delegates.AnimateDown_AfterArgs toInvoke in _afterAnimateDown.GetInvocationList())
                {
                    try
                    {
                        _afterAnimateDown.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }
                }
            }
        }

        internal static void HookReplayUpAnim()
        {
            if (!HookedList.Contains("ReplayUpAnim"))
            {
                HookedList.Add("ReplayUpAnim");
                On.InvAnimateUpAndDown.ReplayUpAnim += ReplayUpAnim;
            }
        }

        internal static event Delegates.ReplayUpAnim_BeforeArgs _beforeReplayUpAnim;
        internal static event Delegates.ReplayUpAnim_AfterArgs _afterReplayUpAnim;

        private static void ReplayUpAnim(On.InvAnimateUpAndDown.orig_ReplayUpAnim orig, InvAnimateUpAndDown self)
        {
            Delegates.Params_ReplayUpAnim @params = new()
            {
                self = self
            };
            if (_beforeReplayUpAnim != null)
            {
                foreach (Delegates.ReplayUpAnim_BeforeArgs toInvoke in _beforeReplayUpAnim.GetInvocationList())
                {
                    try
                    {
                        _beforeReplayUpAnim?.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }
                }
            }

            self = @params.self;
            orig(self);
            if (_afterReplayUpAnim != null)
            {
                foreach (Delegates.ReplayUpAnim_AfterArgs toInvoke in _afterReplayUpAnim.GetInvocationList())
                {
                    try
                    {
                        _afterReplayUpAnim.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }
                }
            }
        }
    }

    /// <summary>
    /// Contains necessary information to create Hooks. Does not contain any hooks
    /// </summary>
    public static class Delegates
    {
        public sealed class Params_Awake
        {
            public InvAnimateUpAndDown self;
        }

        public delegate void Awake_BeforeArgs(Params_Awake args);

        public delegate void Awake_AfterArgs(Params_Awake args);

        public delegate void Awake_WithArgs(Action<InvAnimateUpAndDown> orig, InvAnimateUpAndDown self);

        public sealed class Params_Update
        {
            public InvAnimateUpAndDown self;
        }

        public delegate void Update_BeforeArgs(Params_Update args);

        public delegate void Update_AfterArgs(Params_Update args);

        public delegate void Update_WithArgs(Action<InvAnimateUpAndDown> orig, InvAnimateUpAndDown self);

        public sealed class Params_AnimateUp
        {
            public InvAnimateUpAndDown self;
        }

        public delegate void AnimateUp_BeforeArgs(Params_AnimateUp args);

        public delegate void AnimateUp_AfterArgs(Params_AnimateUp args);

        public delegate void AnimateUp_WithArgs(Action<InvAnimateUpAndDown> orig, InvAnimateUpAndDown self);

        public sealed class Params_AnimateDown
        {
            public InvAnimateUpAndDown self;
        }

        public delegate void AnimateDown_BeforeArgs(Params_AnimateDown args);

        public delegate void AnimateDown_AfterArgs(Params_AnimateDown args);

        public delegate void AnimateDown_WithArgs(Action<InvAnimateUpAndDown> orig, InvAnimateUpAndDown self);

        public sealed class Params_ReplayUpAnim
        {
            public InvAnimateUpAndDown self;
        }

        public delegate void ReplayUpAnim_BeforeArgs(Params_ReplayUpAnim args);

        public delegate void ReplayUpAnim_AfterArgs(Params_ReplayUpAnim args);

        public delegate void ReplayUpAnim_WithArgs(Action<InvAnimateUpAndDown> orig, InvAnimateUpAndDown self);
    }

    /// <summary>
    /// Contains Hooks to that run code before orig(self) is called
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

        public static event Delegates.Update_BeforeArgs Update
        {
            add
            {
                HookHandler._beforeUpdate += value;
                HookHandler.HookUpdate();
            }
            remove => HookHandler._beforeUpdate -= value;
        }

        public static event Delegates.AnimateUp_BeforeArgs AnimateUp
        {
            add
            {
                HookHandler._beforeAnimateUp += value;
                HookHandler.HookAnimateUp();
            }
            remove => HookHandler._beforeAnimateUp -= value;
        }

        public static event Delegates.AnimateDown_BeforeArgs AnimateDown
        {
            add
            {
                HookHandler._beforeAnimateDown += value;
                HookHandler.HookAnimateDown();
            }
            remove => HookHandler._beforeAnimateDown -= value;
        }

        public static event Delegates.ReplayUpAnim_BeforeArgs ReplayUpAnim
        {
            add
            {
                HookHandler._beforeReplayUpAnim += value;
                HookHandler.HookReplayUpAnim();
            }
            remove => HookHandler._beforeReplayUpAnim -= value;
        }
    }

    /// <summary>
    /// Contains Hooks to that run code after orig(self) is called
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

        public static event Delegates.Update_AfterArgs Update
        {
            add
            {
                HookHandler._afterUpdate += value;
                HookHandler.HookUpdate();
            }
            remove => HookHandler._afterUpdate -= value;
        }

        public static event Delegates.AnimateUp_AfterArgs AnimateUp
        {
            add
            {
                HookHandler._afterAnimateUp += value;
                HookHandler.HookAnimateUp();
            }
            remove => HookHandler._afterAnimateUp -= value;
        }

        public static event Delegates.AnimateDown_AfterArgs AnimateDown
        {
            add
            {
                HookHandler._afterAnimateDown += value;
                HookHandler.HookAnimateDown();
            }
            remove => HookHandler._afterAnimateDown -= value;
        }

        public static event Delegates.ReplayUpAnim_AfterArgs ReplayUpAnim
        {
            add
            {
                HookHandler._afterReplayUpAnim += value;
                HookHandler.HookReplayUpAnim();
            }
            remove => HookHandler._afterReplayUpAnim -= value;
        }
    }

    /// <summary>
    /// Contains all On Hooks, even those that aren't in the On namespace such as API generated functions and property getters/setters
    /// </summary>
    public static class WithOrig
    {
        public static event On.InvAnimateUpAndDown.hook_Awake Awake
        {
            add => On.InvAnimateUpAndDown.Awake += value;
            remove => On.InvAnimateUpAndDown.Awake -= value;
        }

        public static event On.InvAnimateUpAndDown.hook_Update Update
        {
            add => On.InvAnimateUpAndDown.Update += value;
            remove => On.InvAnimateUpAndDown.Update -= value;
        }

        public static event On.InvAnimateUpAndDown.hook_AnimateUp AnimateUp
        {
            add => On.InvAnimateUpAndDown.AnimateUp += value;
            remove => On.InvAnimateUpAndDown.AnimateUp -= value;
        }

        public static event On.InvAnimateUpAndDown.hook_AnimateDown AnimateDown
        {
            add => On.InvAnimateUpAndDown.AnimateDown += value;
            remove => On.InvAnimateUpAndDown.AnimateDown -= value;
        }

        public static event On.InvAnimateUpAndDown.hook_ReplayUpAnim ReplayUpAnim
        {
            add => On.InvAnimateUpAndDown.ReplayUpAnim += value;
            remove => On.InvAnimateUpAndDown.ReplayUpAnim -= value;
        }
    }
}