namespace HKMirror.Hooks.OnHooks;

/// <summary>
///     Contains different types of On Hooks for TextMeshSharpener class.<br />
///     Contains hooks that aren't generated by monomod, and before and after orig hooks for easier hooking.
/// </summary>
public static class OnTextMeshSharpener
{
    internal static class HookHandler
    {
        private static readonly List<string> HookedList = new();

        internal static void HookStart()
        {
            if (!HookedList.Contains("Start"))
            {
                HookedList.Add("Start");
                On.TextMeshSharpener.Start += Start;
            }
        }

        internal static event Delegates.Start_BeforeArgs _beforeStart;
        internal static event Delegates.Start_AfterArgs _afterStart;

        private static void Start(On.TextMeshSharpener.orig_Start orig, TextMeshSharpener self)
        {
            Delegates.Params_Start @params = new()
            {
                self = self
            };
            if (_beforeStart != null)
                foreach (Delegates.Start_BeforeArgs toInvoke in _beforeStart.GetInvocationList())
                    try
                    {
                        _beforeStart?.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }

            self = @params.self;
            orig(self);
            if (_afterStart != null)
                foreach (Delegates.Start_AfterArgs toInvoke in _afterStart.GetInvocationList())
                    try
                    {
                        _afterStart.Invoke(@params);
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
                On.TextMeshSharpener.Update += Update;
            }
        }

        internal static event Delegates.Update_BeforeArgs _beforeUpdate;
        internal static event Delegates.Update_AfterArgs _afterUpdate;

        private static void Update(On.TextMeshSharpener.orig_Update orig, TextMeshSharpener self)
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

        internal static void Hookresize()
        {
            if (!HookedList.Contains("resize"))
            {
                HookedList.Add("resize");
                On.TextMeshSharpener.resize += resize;
            }
        }

        internal static event Delegates.resize_BeforeArgs _beforeresize;
        internal static event Delegates.resize_AfterArgs _afterresize;

        private static void resize(On.TextMeshSharpener.orig_resize orig, TextMeshSharpener self)
        {
            Delegates.Params_resize @params = new()
            {
                self = self
            };
            if (_beforeresize != null)
                foreach (Delegates.resize_BeforeArgs toInvoke in _beforeresize.GetInvocationList())
                    try
                    {
                        _beforeresize?.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }

            self = @params.self;
            orig(self);
            if (_afterresize != null)
                foreach (Delegates.resize_AfterArgs toInvoke in _afterresize.GetInvocationList())
                    try
                    {
                        _afterresize.Invoke(@params);
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
        public delegate void resize_AfterArgs(Params_resize args);

        public delegate void resize_BeforeArgs(Params_resize args);

        public delegate void resize_WithArgs(Action<TextMeshSharpener> orig, TextMeshSharpener self);

        public delegate void Start_AfterArgs(Params_Start args);

        public delegate void Start_BeforeArgs(Params_Start args);

        public delegate void Start_WithArgs(Action<TextMeshSharpener> orig, TextMeshSharpener self);

        public delegate void Update_AfterArgs(Params_Update args);

        public delegate void Update_BeforeArgs(Params_Update args);

        public delegate void Update_WithArgs(Action<TextMeshSharpener> orig, TextMeshSharpener self);

        public sealed class Params_Start
        {
            public TextMeshSharpener self;
        }

        public sealed class Params_Update
        {
            public TextMeshSharpener self;
        }

        public sealed class Params_resize
        {
            public TextMeshSharpener self;
        }
    }

    /// <summary>
    ///     Contains Hooks to that run code before orig(self) is called
    /// </summary>
    public static class BeforeOrig
    {
        public static event Delegates.Start_BeforeArgs Start
        {
            add
            {
                HookHandler._beforeStart += value;
                HookHandler.HookStart();
            }
            remove => HookHandler._beforeStart -= value;
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

        public static event Delegates.resize_BeforeArgs resize
        {
            add
            {
                HookHandler._beforeresize += value;
                HookHandler.Hookresize();
            }
            remove => HookHandler._beforeresize -= value;
        }
    }

    /// <summary>
    ///     Contains Hooks to that run code after orig(self) is called
    /// </summary>
    public static class AfterOrig
    {
        public static event Delegates.Start_AfterArgs Start
        {
            add
            {
                HookHandler._afterStart += value;
                HookHandler.HookStart();
            }
            remove => HookHandler._afterStart -= value;
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

        public static event Delegates.resize_AfterArgs resize
        {
            add
            {
                HookHandler._afterresize += value;
                HookHandler.Hookresize();
            }
            remove => HookHandler._afterresize -= value;
        }
    }

    /// <summary>
    ///     Contains all On Hooks, even those that aren't in the On namespace such as API generated functions and property
    ///     getters/setters
    /// </summary>
    public static class WithOrig
    {
        public static event On.TextMeshSharpener.hook_Start Start
        {
            add => On.TextMeshSharpener.Start += value;
            remove => On.TextMeshSharpener.Start -= value;
        }

        public static event On.TextMeshSharpener.hook_Update Update
        {
            add => On.TextMeshSharpener.Update += value;
            remove => On.TextMeshSharpener.Update -= value;
        }

        public static event On.TextMeshSharpener.hook_resize resize
        {
            add => On.TextMeshSharpener.resize += value;
            remove => On.TextMeshSharpener.resize -= value;
        }
    }
}