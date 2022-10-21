using MonoMod.RuntimeDetour;
using MonoMod.RuntimeDetour.HookGen;

namespace HKMirror.Hooks.OnHooks;

/// <summary>
/// Contains different types of On Hooks for CanvasGroupRemap class.<br />
/// Contains hooks that aren't generated by monomod, and before and after orig hooks for easier hooking.
/// </summary>
public static class OnCanvasGroupRemap
{
    internal static class HookHandler
    {
        private static List<string> HookedList = new List<string>();

        internal static void HookAwake()
        {
            if (!HookedList.Contains("Awake"))
            {
                HookedList.Add("Awake");
                On.CanvasGroupRemap.Awake += Awake;
            }
        }

        internal static event Delegates.Awake_BeforeArgs _beforeAwake;
        internal static event Delegates.Awake_AfterArgs _afterAwake;

        private static void Awake(On.CanvasGroupRemap.orig_Awake orig, CanvasGroupRemap self)
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
                On.CanvasGroupRemap.Update += Update;
            }
        }

        internal static event Delegates.Update_BeforeArgs _beforeUpdate;
        internal static event Delegates.Update_AfterArgs _afterUpdate;

        private static void Update(On.CanvasGroupRemap.orig_Update orig, CanvasGroupRemap self)
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

        internal static void HookSync()
        {
            if (!HookedList.Contains("Sync"))
            {
                HookedList.Add("Sync");
                On.CanvasGroupRemap.Sync += Sync;
            }
        }

        internal static event Delegates.Sync_BeforeArgs _beforeSync;
        internal static event Delegates.Sync_AfterArgs _afterSync;

        private static void Sync(On.CanvasGroupRemap.orig_Sync orig, CanvasGroupRemap self, float alpha)
        {
            Delegates.Params_Sync @params = new()
            {
                self = self, alpha = alpha
            };
            if (_beforeSync != null)
            {
                foreach (Delegates.Sync_BeforeArgs toInvoke in _beforeSync.GetInvocationList())
                {
                    try
                    {
                        _beforeSync?.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }
                }
            }

            self = @params.self;
            alpha = @params.alpha;
            orig(self, alpha);
            if (_afterSync != null)
            {
                foreach (Delegates.Sync_AfterArgs toInvoke in _afterSync.GetInvocationList())
                {
                    try
                    {
                        _afterSync.Invoke(@params);
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
            public CanvasGroupRemap self;
        }

        public delegate void Awake_BeforeArgs(Params_Awake args);

        public delegate void Awake_AfterArgs(Params_Awake args);

        public delegate void Awake_WithArgs(Action<CanvasGroupRemap> orig, CanvasGroupRemap self);

        public sealed class Params_Update
        {
            public CanvasGroupRemap self;
        }

        public delegate void Update_BeforeArgs(Params_Update args);

        public delegate void Update_AfterArgs(Params_Update args);

        public delegate void Update_WithArgs(Action<CanvasGroupRemap> orig, CanvasGroupRemap self);

        public sealed class Params_Sync
        {
            public CanvasGroupRemap self;
            public float alpha;
        }

        public delegate void Sync_BeforeArgs(Params_Sync args);

        public delegate void Sync_AfterArgs(Params_Sync args);

        public delegate void Sync_WithArgs(Action<CanvasGroupRemap, float> orig, CanvasGroupRemap self, float alpha);
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

        public static event Delegates.Sync_BeforeArgs Sync
        {
            add
            {
                HookHandler._beforeSync += value;
                HookHandler.HookSync();
            }
            remove => HookHandler._beforeSync -= value;
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

        public static event Delegates.Sync_AfterArgs Sync
        {
            add
            {
                HookHandler._afterSync += value;
                HookHandler.HookSync();
            }
            remove => HookHandler._afterSync -= value;
        }
    }

    /// <summary>
    /// Contains all On Hooks, even those that aren't in the On namespace such as API generated functions and property getters/setters
    /// </summary>
    public static class WithOrig
    {
        public static event On.CanvasGroupRemap.hook_Awake Awake
        {
            add => On.CanvasGroupRemap.Awake += value;
            remove => On.CanvasGroupRemap.Awake -= value;
        }

        public static event On.CanvasGroupRemap.hook_Update Update
        {
            add => On.CanvasGroupRemap.Update += value;
            remove => On.CanvasGroupRemap.Update -= value;
        }

        public static event On.CanvasGroupRemap.hook_Sync Sync
        {
            add => On.CanvasGroupRemap.Sync += value;
            remove => On.CanvasGroupRemap.Sync -= value;
        }
    }
}