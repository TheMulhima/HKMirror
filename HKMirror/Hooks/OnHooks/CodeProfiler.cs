namespace HKMirror.Hooks.OnHooks;

/// <summary>
///     Contains different types of On Hooks for CodeProfiler class.<br />
///     Contains hooks that aren't generated by monomod, and before and after orig hooks for easier hooking.
/// </summary>
public static class OnCodeProfiler
{
    internal static class HookHandler
    {
        private static readonly List<string> HookedList = new();

        internal static void HookAwake()
        {
            if (!HookedList.Contains("Awake"))
            {
                HookedList.Add("Awake");
                On.CodeProfiler.Awake += Awake;
            }
        }

        internal static event Delegates.Awake_BeforeArgs _beforeAwake;
        internal static event Delegates.Awake_AfterArgs _afterAwake;

        private static void Awake(On.CodeProfiler.orig_Awake orig, CodeProfiler self)
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

        internal static void HookOnGUI()
        {
            if (!HookedList.Contains("OnGUI"))
            {
                HookedList.Add("OnGUI");
                On.CodeProfiler.OnGUI += OnGUI;
            }
        }

        internal static event Delegates.OnGUI_BeforeArgs _beforeOnGUI;
        internal static event Delegates.OnGUI_AfterArgs _afterOnGUI;

        private static void OnGUI(On.CodeProfiler.orig_OnGUI orig, CodeProfiler self)
        {
            Delegates.Params_OnGUI @params = new()
            {
                self = self
            };
            if (_beforeOnGUI != null)
                foreach (Delegates.OnGUI_BeforeArgs toInvoke in _beforeOnGUI.GetInvocationList())
                    try
                    {
                        _beforeOnGUI?.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }

            self = @params.self;
            orig(self);
            if (_afterOnGUI != null)
                foreach (Delegates.OnGUI_AfterArgs toInvoke in _afterOnGUI.GetInvocationList())
                    try
                    {
                        _afterOnGUI.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }
        }

        internal static void HookBegin()
        {
            if (!HookedList.Contains("Begin"))
            {
                HookedList.Add("Begin");
                On.CodeProfiler.Begin += Begin;
            }
        }

        internal static event Delegates.Begin_BeforeArgs _beforeBegin;
        internal static event Delegates.Begin_AfterArgs _afterBegin;

        private static void Begin(On.CodeProfiler.orig_Begin orig, string id)
        {
            Delegates.Params_Begin @params = new()
            {
                id = id
            };
            if (_beforeBegin != null)
                foreach (Delegates.Begin_BeforeArgs toInvoke in _beforeBegin.GetInvocationList())
                    try
                    {
                        _beforeBegin?.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }

            id = @params.id;
            orig(id);
            if (_afterBegin != null)
                foreach (Delegates.Begin_AfterArgs toInvoke in _afterBegin.GetInvocationList())
                    try
                    {
                        _afterBegin.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }
        }

        internal static void HookEnd()
        {
            if (!HookedList.Contains("End"))
            {
                HookedList.Add("End");
                On.CodeProfiler.End += End;
            }
        }

        internal static event Delegates.End_BeforeArgs _beforeEnd;
        internal static event Delegates.End_AfterArgs _afterEnd;

        private static void End(On.CodeProfiler.orig_End orig, string id)
        {
            Delegates.Params_End @params = new()
            {
                id = id
            };
            if (_beforeEnd != null)
                foreach (Delegates.End_BeforeArgs toInvoke in _beforeEnd.GetInvocationList())
                    try
                    {
                        _beforeEnd?.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }

            id = @params.id;
            orig(id);
            if (_afterEnd != null)
                foreach (Delegates.End_AfterArgs toInvoke in _afterEnd.GetInvocationList())
                    try
                    {
                        _afterEnd.Invoke(@params);
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
                On.CodeProfiler.Update += Update;
            }
        }

        internal static event Delegates.Update_BeforeArgs _beforeUpdate;
        internal static event Delegates.Update_AfterArgs _afterUpdate;

        private static void Update(On.CodeProfiler.orig_Update orig, CodeProfiler self)
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
    }

    /// <summary>
    ///     Contains necessary information to create Hooks. Does not contain any hooks
    /// </summary>
    public static class Delegates
    {
        public delegate void Awake_AfterArgs(Params_Awake args);

        public delegate void Awake_BeforeArgs(Params_Awake args);

        public delegate void Awake_WithArgs(Action<CodeProfiler> orig, CodeProfiler self);

        public delegate void Begin_AfterArgs(Params_Begin args);

        public delegate void Begin_BeforeArgs(Params_Begin args);

        public delegate void Begin_WithArgs(Action<string> orig, string id);

        public delegate void End_AfterArgs(Params_End args);

        public delegate void End_BeforeArgs(Params_End args);

        public delegate void End_WithArgs(Action<string> orig, string id);

        public delegate void OnGUI_AfterArgs(Params_OnGUI args);

        public delegate void OnGUI_BeforeArgs(Params_OnGUI args);

        public delegate void OnGUI_WithArgs(Action<CodeProfiler> orig, CodeProfiler self);

        public delegate void Update_AfterArgs(Params_Update args);

        public delegate void Update_BeforeArgs(Params_Update args);

        public delegate void Update_WithArgs(Action<CodeProfiler> orig, CodeProfiler self);

        public sealed class Params_Awake
        {
            public CodeProfiler self;
        }

        public sealed class Params_OnGUI
        {
            public CodeProfiler self;
        }

        public sealed class Params_Begin
        {
            public string id;
        }

        public sealed class Params_End
        {
            public string id;
        }

        public sealed class Params_Update
        {
            public CodeProfiler self;
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

        public static event Delegates.OnGUI_BeforeArgs OnGUI
        {
            add
            {
                HookHandler._beforeOnGUI += value;
                HookHandler.HookOnGUI();
            }
            remove => HookHandler._beforeOnGUI -= value;
        }

        public static event Delegates.Begin_BeforeArgs Begin
        {
            add
            {
                HookHandler._beforeBegin += value;
                HookHandler.HookBegin();
            }
            remove => HookHandler._beforeBegin -= value;
        }

        public static event Delegates.End_BeforeArgs End
        {
            add
            {
                HookHandler._beforeEnd += value;
                HookHandler.HookEnd();
            }
            remove => HookHandler._beforeEnd -= value;
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

        public static event Delegates.OnGUI_AfterArgs OnGUI
        {
            add
            {
                HookHandler._afterOnGUI += value;
                HookHandler.HookOnGUI();
            }
            remove => HookHandler._afterOnGUI -= value;
        }

        public static event Delegates.Begin_AfterArgs Begin
        {
            add
            {
                HookHandler._afterBegin += value;
                HookHandler.HookBegin();
            }
            remove => HookHandler._afterBegin -= value;
        }

        public static event Delegates.End_AfterArgs End
        {
            add
            {
                HookHandler._afterEnd += value;
                HookHandler.HookEnd();
            }
            remove => HookHandler._afterEnd -= value;
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
    }

    /// <summary>
    ///     Contains all On Hooks, even those that aren't in the On namespace such as API generated functions and property
    ///     getters/setters
    /// </summary>
    public static class WithOrig
    {
        public static event On.CodeProfiler.hook_Awake Awake
        {
            add => On.CodeProfiler.Awake += value;
            remove => On.CodeProfiler.Awake -= value;
        }

        public static event On.CodeProfiler.hook_OnGUI OnGUI
        {
            add => On.CodeProfiler.OnGUI += value;
            remove => On.CodeProfiler.OnGUI -= value;
        }

        public static event On.CodeProfiler.hook_Begin Begin
        {
            add => On.CodeProfiler.Begin += value;
            remove => On.CodeProfiler.Begin -= value;
        }

        public static event On.CodeProfiler.hook_End End
        {
            add => On.CodeProfiler.End += value;
            remove => On.CodeProfiler.End -= value;
        }

        public static event On.CodeProfiler.hook_Update Update
        {
            add => On.CodeProfiler.Update += value;
            remove => On.CodeProfiler.Update -= value;
        }
    }
}