namespace HKMirror.Hooks.OnHooks;

/// <summary>
///     Contains different types of On Hooks for ColourPainter class.<br />
///     Contains hooks that aren't generated by monomod, and before and after orig hooks for easier hooking.
/// </summary>
public static class OnColourPainter
{
    internal static class HookHandler
    {
        private static readonly List<string> HookedList = new();

        internal static void HookAwake()
        {
            if (!HookedList.Contains("Awake"))
            {
                HookedList.Add("Awake");
                On.ColourPainter.Awake += Awake;
            }
        }

        internal static event Delegates.Awake_BeforeArgs _beforeAwake;
        internal static event Delegates.Awake_AfterArgs _afterAwake;

        private static void Awake(On.ColourPainter.orig_Awake orig, ColourPainter self)
        {
            Delegates.Params_Awake @params = new()
            {
                self = self
            };
            if (_beforeAwake != null)
                foreach (Delegates.Awake_BeforeArgs toInvoke in _beforeAwake.GetInvocationList())
                    try
                    {
                        _beforeAwake?.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }

            self = @params.self;
            orig(self);
            if (_afterAwake != null)
                foreach (Delegates.Awake_AfterArgs toInvoke in _afterAwake.GetInvocationList())
                    try
                    {
                        _afterAwake.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }
        }

        internal static void HookUpdate()
        {
            if (!HookedList.Contains("Update"))
            {
                HookedList.Add("Update");
                On.ColourPainter.Update += Update;
            }
        }

        internal static event Delegates.Update_BeforeArgs _beforeUpdate;
        internal static event Delegates.Update_AfterArgs _afterUpdate;

        private static void Update(On.ColourPainter.orig_Update orig, ColourPainter self)
        {
            Delegates.Params_Update @params = new()
            {
                self = self
            };
            if (_beforeUpdate != null)
                foreach (Delegates.Update_BeforeArgs toInvoke in _beforeUpdate.GetInvocationList())
                    try
                    {
                        _beforeUpdate?.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }

            self = @params.self;
            orig(self);
            if (_afterUpdate != null)
                foreach (Delegates.Update_AfterArgs toInvoke in _afterUpdate.GetInvocationList())
                    try
                    {
                        _afterUpdate.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }
        }

        internal static void HookOnTriggerEnter2D()
        {
            if (!HookedList.Contains("OnTriggerEnter2D"))
            {
                HookedList.Add("OnTriggerEnter2D");
                On.ColourPainter.OnTriggerEnter2D += OnTriggerEnter2D;
            }
        }

        internal static event Delegates.OnTriggerEnter2D_BeforeArgs _beforeOnTriggerEnter2D;
        internal static event Delegates.OnTriggerEnter2D_AfterArgs _afterOnTriggerEnter2D;

        private static void OnTriggerEnter2D(On.ColourPainter.orig_OnTriggerEnter2D orig, ColourPainter self,
            Collider2D collision)
        {
            Delegates.Params_OnTriggerEnter2D @params = new()
            {
                self = self, collision = collision
            };
            if (_beforeOnTriggerEnter2D != null)
                foreach (Delegates.OnTriggerEnter2D_BeforeArgs toInvoke in _beforeOnTriggerEnter2D.GetInvocationList())
                    try
                    {
                        _beforeOnTriggerEnter2D?.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }

            self = @params.self;
            collision = @params.collision;
            orig(self, collision);
            if (_afterOnTriggerEnter2D != null)
                foreach (Delegates.OnTriggerEnter2D_AfterArgs toInvoke in _afterOnTriggerEnter2D.GetInvocationList())
                    try
                    {
                        _afterOnTriggerEnter2D.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }
        }

        internal static void HookDoPaint()
        {
            if (!HookedList.Contains("DoPaint"))
            {
                HookedList.Add("DoPaint");
                On.ColourPainter.DoPaint += DoPaint;
            }
        }

        internal static event Delegates.DoPaint_BeforeArgs _beforeDoPaint;
        internal static event Delegates.DoPaint_AfterArgs _afterDoPaint;

        private static void DoPaint(On.ColourPainter.orig_DoPaint orig, ColourPainter self)
        {
            Delegates.Params_DoPaint @params = new()
            {
                self = self
            };
            if (_beforeDoPaint != null)
                foreach (Delegates.DoPaint_BeforeArgs toInvoke in _beforeDoPaint.GetInvocationList())
                    try
                    {
                        _beforeDoPaint?.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }

            self = @params.self;
            orig(self);
            if (_afterDoPaint != null)
                foreach (Delegates.DoPaint_AfterArgs toInvoke in _afterDoPaint.GetInvocationList())
                    try
                    {
                        _afterDoPaint.Invoke(@params);
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
        public delegate void Awake_AfterArgs(Params_Awake args);

        public delegate void Awake_BeforeArgs(Params_Awake args);

        public delegate void Awake_WithArgs(Action<ColourPainter> orig, ColourPainter self);

        public delegate void DoPaint_AfterArgs(Params_DoPaint args);

        public delegate void DoPaint_BeforeArgs(Params_DoPaint args);

        public delegate void DoPaint_WithArgs(Action<ColourPainter> orig, ColourPainter self);

        public delegate void OnTriggerEnter2D_AfterArgs(Params_OnTriggerEnter2D args);

        public delegate void OnTriggerEnter2D_BeforeArgs(Params_OnTriggerEnter2D args);

        public delegate void OnTriggerEnter2D_WithArgs(Action<ColourPainter, Collider2D> orig, ColourPainter self,
            Collider2D collision);

        public delegate void Update_AfterArgs(Params_Update args);

        public delegate void Update_BeforeArgs(Params_Update args);

        public delegate void Update_WithArgs(Action<ColourPainter> orig, ColourPainter self);

        public sealed class Params_Awake
        {
            public ColourPainter self;
        }

        public sealed class Params_Update
        {
            public ColourPainter self;
        }

        public sealed class Params_OnTriggerEnter2D
        {
            public Collider2D collision;
            public ColourPainter self;
        }

        public sealed class Params_DoPaint
        {
            public ColourPainter self;
        }
    }

    /// <summary>
    ///     Contains Hooks to that run code before orig(self) is called
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

        public static event Delegates.OnTriggerEnter2D_BeforeArgs OnTriggerEnter2D
        {
            add
            {
                HookHandler._beforeOnTriggerEnter2D += value;
                HookHandler.HookOnTriggerEnter2D();
            }
            remove => HookHandler._beforeOnTriggerEnter2D -= value;
        }

        public static event Delegates.DoPaint_BeforeArgs DoPaint
        {
            add
            {
                HookHandler._beforeDoPaint += value;
                HookHandler.HookDoPaint();
            }
            remove => HookHandler._beforeDoPaint -= value;
        }
    }

    /// <summary>
    ///     Contains Hooks to that run code after orig(self) is called
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

        public static event Delegates.OnTriggerEnter2D_AfterArgs OnTriggerEnter2D
        {
            add
            {
                HookHandler._afterOnTriggerEnter2D += value;
                HookHandler.HookOnTriggerEnter2D();
            }
            remove => HookHandler._afterOnTriggerEnter2D -= value;
        }

        public static event Delegates.DoPaint_AfterArgs DoPaint
        {
            add
            {
                HookHandler._afterDoPaint += value;
                HookHandler.HookDoPaint();
            }
            remove => HookHandler._afterDoPaint -= value;
        }
    }

    /// <summary>
    ///     Contains all On Hooks, even those that aren't in the On namespace such as API generated functions and property
    ///     getters/setters
    /// </summary>
    public static class WithOrig
    {
        public static event On.ColourPainter.hook_Awake Awake
        {
            add => On.ColourPainter.Awake += value;
            remove => On.ColourPainter.Awake -= value;
        }

        public static event On.ColourPainter.hook_Update Update
        {
            add => On.ColourPainter.Update += value;
            remove => On.ColourPainter.Update -= value;
        }

        public static event On.ColourPainter.hook_OnTriggerEnter2D OnTriggerEnter2D
        {
            add => On.ColourPainter.OnTriggerEnter2D += value;
            remove => On.ColourPainter.OnTriggerEnter2D -= value;
        }

        public static event On.ColourPainter.hook_DoPaint DoPaint
        {
            add => On.ColourPainter.DoPaint += value;
            remove => On.ColourPainter.DoPaint -= value;
        }
    }
}