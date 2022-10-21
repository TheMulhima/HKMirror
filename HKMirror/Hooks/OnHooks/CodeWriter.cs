using MonoMod.RuntimeDetour;
using MonoMod.RuntimeDetour.HookGen;

namespace HKMirror.Hooks.OnHooks;

/// <summary>
/// Contains different types of On Hooks for CodeWriter class.<br />
/// Contains hooks that aren't generated by monomod, and before and after orig hooks for easier hooking.
/// </summary>
public static class OnCodeWriter
{
    internal static class HookHandler
    {
        private static List<string> HookedList = new List<string>();

        internal static void HookIncreaseIndent()
        {
            if (!HookedList.Contains("IncreaseIndent"))
            {
                HookedList.Add("IncreaseIndent");
                new Hook(ReflectionHelper.GetMethodInfo(typeof(InControl.Internal.CodeWriter), "IncreaseIndent", true),
                    IncreaseIndent);
            }
        }

        internal static event Delegates.IncreaseIndent_BeforeArgs _beforeIncreaseIndent;
        internal static event Delegates.IncreaseIndent_AfterArgs _afterIncreaseIndent;

        private static void IncreaseIndent(Action<InControl.Internal.CodeWriter> orig,
            InControl.Internal.CodeWriter self)
        {
            Delegates.Params_IncreaseIndent @params = new()
            {
                self = self
            };
            if (_beforeIncreaseIndent != null)
            {
                foreach (Delegates.IncreaseIndent_BeforeArgs toInvoke in _beforeIncreaseIndent.GetInvocationList())
                {
                    try
                    {
                        _beforeIncreaseIndent?.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }
                }
            }

            self = @params.self;
            orig(self);
            if (_afterIncreaseIndent != null)
            {
                foreach (Delegates.IncreaseIndent_AfterArgs toInvoke in _afterIncreaseIndent.GetInvocationList())
                {
                    try
                    {
                        _afterIncreaseIndent.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }
                }
            }
        }

        internal static void HookDecreaseIndent()
        {
            if (!HookedList.Contains("DecreaseIndent"))
            {
                HookedList.Add("DecreaseIndent");
                new Hook(ReflectionHelper.GetMethodInfo(typeof(InControl.Internal.CodeWriter), "DecreaseIndent", true),
                    DecreaseIndent);
            }
        }

        internal static event Delegates.DecreaseIndent_BeforeArgs _beforeDecreaseIndent;
        internal static event Delegates.DecreaseIndent_AfterArgs _afterDecreaseIndent;

        private static void DecreaseIndent(Action<InControl.Internal.CodeWriter> orig,
            InControl.Internal.CodeWriter self)
        {
            Delegates.Params_DecreaseIndent @params = new()
            {
                self = self
            };
            if (_beforeDecreaseIndent != null)
            {
                foreach (Delegates.DecreaseIndent_BeforeArgs toInvoke in _beforeDecreaseIndent.GetInvocationList())
                {
                    try
                    {
                        _beforeDecreaseIndent?.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }
                }
            }

            self = @params.self;
            orig(self);
            if (_afterDecreaseIndent != null)
            {
                foreach (Delegates.DecreaseIndent_AfterArgs toInvoke in _afterDecreaseIndent.GetInvocationList())
                {
                    try
                    {
                        _afterDecreaseIndent.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }
                }
            }
        }

        internal static void HookAppend_string()
        {
            if (!HookedList.Contains("Append_string"))
            {
                HookedList.Add("Append_string");
                new Hook(ReflectionHelper.GetMethodInfo(typeof(InControl.Internal.CodeWriter), "Append_string", true),
                    Append_string);
            }
        }

        internal static event Delegates.Append_string_BeforeArgs _beforeAppend_string;
        internal static event Delegates.Append_string_AfterArgs _afterAppend_string;

        private static void Append_string(Action<InControl.Internal.CodeWriter, string> orig,
            InControl.Internal.CodeWriter self, string code)
        {
            Delegates.Params_Append_string @params = new()
            {
                self = self, code = code
            };
            if (_beforeAppend_string != null)
            {
                foreach (Delegates.Append_string_BeforeArgs toInvoke in _beforeAppend_string.GetInvocationList())
                {
                    try
                    {
                        _beforeAppend_string?.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }
                }
            }

            self = @params.self;
            code = @params.code;
            orig(self, code);
            if (_afterAppend_string != null)
            {
                foreach (Delegates.Append_string_AfterArgs toInvoke in _afterAppend_string.GetInvocationList())
                {
                    try
                    {
                        _afterAppend_string.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }
                }
            }
        }

        internal static void HookAppend_bool_string()
        {
            if (!HookedList.Contains("Append_bool_string"))
            {
                HookedList.Add("Append_bool_string");
                new Hook(
                    ReflectionHelper.GetMethodInfo(typeof(InControl.Internal.CodeWriter), "Append_bool_string", true),
                    Append_bool_string);
            }
        }

        internal static event Delegates.Append_bool_string_BeforeArgs _beforeAppend_bool_string;
        internal static event Delegates.Append_bool_string_AfterArgs _afterAppend_bool_string;

        private static void Append_bool_string(Action<InControl.Internal.CodeWriter, bool, string> orig,
            InControl.Internal.CodeWriter self, bool trim, string code)
        {
            Delegates.Params_Append_bool_string @params = new()
            {
                self = self, trim = trim, code = code
            };
            if (_beforeAppend_bool_string != null)
            {
                foreach (Delegates.Append_bool_string_BeforeArgs toInvoke in
                         _beforeAppend_bool_string.GetInvocationList())
                {
                    try
                    {
                        _beforeAppend_bool_string?.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }
                }
            }

            self = @params.self;
            trim = @params.trim;
            code = @params.code;
            orig(self, trim, code);
            if (_afterAppend_bool_string != null)
            {
                foreach (Delegates.Append_bool_string_AfterArgs toInvoke in
                         _afterAppend_bool_string.GetInvocationList())
                {
                    try
                    {
                        _afterAppend_bool_string.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }
                }
            }
        }

        internal static void HookAppendLine_string()
        {
            if (!HookedList.Contains("AppendLine_string"))
            {
                HookedList.Add("AppendLine_string");
                new Hook(
                    ReflectionHelper.GetMethodInfo(typeof(InControl.Internal.CodeWriter), "AppendLine_string", true),
                    AppendLine_string);
            }
        }

        internal static event Delegates.AppendLine_string_BeforeArgs _beforeAppendLine_string;
        internal static event Delegates.AppendLine_string_AfterArgs _afterAppendLine_string;

        private static void AppendLine_string(Action<InControl.Internal.CodeWriter, string> orig,
            InControl.Internal.CodeWriter self, string code)
        {
            Delegates.Params_AppendLine_string @params = new()
            {
                self = self, code = code
            };
            if (_beforeAppendLine_string != null)
            {
                foreach (Delegates.AppendLine_string_BeforeArgs toInvoke in
                         _beforeAppendLine_string.GetInvocationList())
                {
                    try
                    {
                        _beforeAppendLine_string?.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }
                }
            }

            self = @params.self;
            code = @params.code;
            orig(self, code);
            if (_afterAppendLine_string != null)
            {
                foreach (Delegates.AppendLine_string_AfterArgs toInvoke in _afterAppendLine_string.GetInvocationList())
                {
                    try
                    {
                        _afterAppendLine_string.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }
                }
            }
        }

        internal static void HookAppendLine_int()
        {
            if (!HookedList.Contains("AppendLine_int"))
            {
                HookedList.Add("AppendLine_int");
                new Hook(ReflectionHelper.GetMethodInfo(typeof(InControl.Internal.CodeWriter), "AppendLine_int", true),
                    AppendLine_int);
            }
        }

        internal static event Delegates.AppendLine_int_BeforeArgs _beforeAppendLine_int;
        internal static event Delegates.AppendLine_int_AfterArgs _afterAppendLine_int;

        private static void AppendLine_int(Action<InControl.Internal.CodeWriter, int> orig,
            InControl.Internal.CodeWriter self, int count)
        {
            Delegates.Params_AppendLine_int @params = new()
            {
                self = self, count = count
            };
            if (_beforeAppendLine_int != null)
            {
                foreach (Delegates.AppendLine_int_BeforeArgs toInvoke in _beforeAppendLine_int.GetInvocationList())
                {
                    try
                    {
                        _beforeAppendLine_int?.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }
                }
            }

            self = @params.self;
            count = @params.count;
            orig(self, count);
            if (_afterAppendLine_int != null)
            {
                foreach (Delegates.AppendLine_int_AfterArgs toInvoke in _afterAppendLine_int.GetInvocationList())
                {
                    try
                    {
                        _afterAppendLine_int.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }
                }
            }
        }

        internal static void HookAppendFormat()
        {
            if (!HookedList.Contains("AppendFormat"))
            {
                HookedList.Add("AppendFormat");
                new Hook(ReflectionHelper.GetMethodInfo(typeof(InControl.Internal.CodeWriter), "AppendFormat", true),
                    AppendFormat);
            }
        }

        internal static event Delegates.AppendFormat_BeforeArgs _beforeAppendFormat;
        internal static event Delegates.AppendFormat_AfterArgs _afterAppendFormat;

        private static void AppendFormat(Action<InControl.Internal.CodeWriter, string, System.Object[]> orig,
            InControl.Internal.CodeWriter self, string format, System.Object[] args)
        {
            Delegates.Params_AppendFormat @params = new()
            {
                self = self, format = format, args = args
            };
            if (_beforeAppendFormat != null)
            {
                foreach (Delegates.AppendFormat_BeforeArgs toInvoke in _beforeAppendFormat.GetInvocationList())
                {
                    try
                    {
                        _beforeAppendFormat?.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }
                }
            }

            self = @params.self;
            format = @params.format;
            args = @params.args;
            orig(self, format, args);
            if (_afterAppendFormat != null)
            {
                foreach (Delegates.AppendFormat_AfterArgs toInvoke in _afterAppendFormat.GetInvocationList())
                {
                    try
                    {
                        _afterAppendFormat.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }
                }
            }
        }

        internal static void HookAppendLineFormat()
        {
            if (!HookedList.Contains("AppendLineFormat"))
            {
                HookedList.Add("AppendLineFormat");
                new Hook(
                    ReflectionHelper.GetMethodInfo(typeof(InControl.Internal.CodeWriter), "AppendLineFormat", true),
                    AppendLineFormat);
            }
        }

        internal static event Delegates.AppendLineFormat_BeforeArgs _beforeAppendLineFormat;
        internal static event Delegates.AppendLineFormat_AfterArgs _afterAppendLineFormat;

        private static void AppendLineFormat(Action<InControl.Internal.CodeWriter, string, System.Object[]> orig,
            InControl.Internal.CodeWriter self, string format, System.Object[] args)
        {
            Delegates.Params_AppendLineFormat @params = new()
            {
                self = self, format = format, args = args
            };
            if (_beforeAppendLineFormat != null)
            {
                foreach (Delegates.AppendLineFormat_BeforeArgs toInvoke in _beforeAppendLineFormat.GetInvocationList())
                {
                    try
                    {
                        _beforeAppendLineFormat?.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }
                }
            }

            self = @params.self;
            format = @params.format;
            args = @params.args;
            orig(self, format, args);
            if (_afterAppendLineFormat != null)
            {
                foreach (Delegates.AppendLineFormat_AfterArgs toInvoke in _afterAppendLineFormat.GetInvocationList())
                {
                    try
                    {
                        _afterAppendLineFormat.Invoke(@params);
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
        public sealed class Params_IncreaseIndent
        {
            public InControl.Internal.CodeWriter self;
        }

        public delegate void IncreaseIndent_BeforeArgs(Params_IncreaseIndent args);

        public delegate void IncreaseIndent_AfterArgs(Params_IncreaseIndent args);

        public delegate void IncreaseIndent_WithArgs(Action<InControl.Internal.CodeWriter> orig,
            InControl.Internal.CodeWriter self);

        public sealed class Params_DecreaseIndent
        {
            public InControl.Internal.CodeWriter self;
        }

        public delegate void DecreaseIndent_BeforeArgs(Params_DecreaseIndent args);

        public delegate void DecreaseIndent_AfterArgs(Params_DecreaseIndent args);

        public delegate void DecreaseIndent_WithArgs(Action<InControl.Internal.CodeWriter> orig,
            InControl.Internal.CodeWriter self);

        public sealed class Params_Append_string
        {
            public InControl.Internal.CodeWriter self;
            public string code;
        }

        public delegate void Append_string_BeforeArgs(Params_Append_string args);

        public delegate void Append_string_AfterArgs(Params_Append_string args);

        public delegate void Append_string_WithArgs(Action<InControl.Internal.CodeWriter, string> orig,
            InControl.Internal.CodeWriter self, string code);

        public sealed class Params_Append_bool_string
        {
            public InControl.Internal.CodeWriter self;
            public bool trim;
            public string code;
        }

        public delegate void Append_bool_string_BeforeArgs(Params_Append_bool_string args);

        public delegate void Append_bool_string_AfterArgs(Params_Append_bool_string args);

        public delegate void Append_bool_string_WithArgs(Action<InControl.Internal.CodeWriter, bool, string> orig,
            InControl.Internal.CodeWriter self, bool trim, string code);

        public sealed class Params_AppendLine_string
        {
            public InControl.Internal.CodeWriter self;
            public string code;
        }

        public delegate void AppendLine_string_BeforeArgs(Params_AppendLine_string args);

        public delegate void AppendLine_string_AfterArgs(Params_AppendLine_string args);

        public delegate void AppendLine_string_WithArgs(Action<InControl.Internal.CodeWriter, string> orig,
            InControl.Internal.CodeWriter self, string code);

        public sealed class Params_AppendLine_int
        {
            public InControl.Internal.CodeWriter self;
            public int count;
        }

        public delegate void AppendLine_int_BeforeArgs(Params_AppendLine_int args);

        public delegate void AppendLine_int_AfterArgs(Params_AppendLine_int args);

        public delegate void AppendLine_int_WithArgs(Action<InControl.Internal.CodeWriter, int> orig,
            InControl.Internal.CodeWriter self, int count);

        public sealed class Params_AppendFormat
        {
            public InControl.Internal.CodeWriter self;
            public string format;
            public System.Object[] args;
        }

        public delegate void AppendFormat_BeforeArgs(Params_AppendFormat args);

        public delegate void AppendFormat_AfterArgs(Params_AppendFormat args);

        public delegate void AppendFormat_WithArgs(Action<InControl.Internal.CodeWriter, string, System.Object[]> orig,
            InControl.Internal.CodeWriter self, string format, System.Object[] args);

        public sealed class Params_AppendLineFormat
        {
            public InControl.Internal.CodeWriter self;
            public string format;
            public System.Object[] args;
        }

        public delegate void AppendLineFormat_BeforeArgs(Params_AppendLineFormat args);

        public delegate void AppendLineFormat_AfterArgs(Params_AppendLineFormat args);

        public delegate void AppendLineFormat_WithArgs(
            Action<InControl.Internal.CodeWriter, string, System.Object[]> orig, InControl.Internal.CodeWriter self,
            string format, System.Object[] args);
    }

    /// <summary>
    /// Contains Hooks to that run code before orig(self) is called
    /// </summary>
    public static class BeforeOrig
    {
        public static event Delegates.IncreaseIndent_BeforeArgs IncreaseIndent
        {
            add
            {
                HookHandler._beforeIncreaseIndent += value;
                HookHandler.HookIncreaseIndent();
            }
            remove => HookHandler._beforeIncreaseIndent -= value;
        }

        public static event Delegates.DecreaseIndent_BeforeArgs DecreaseIndent
        {
            add
            {
                HookHandler._beforeDecreaseIndent += value;
                HookHandler.HookDecreaseIndent();
            }
            remove => HookHandler._beforeDecreaseIndent -= value;
        }

        public static event Delegates.Append_string_BeforeArgs Append_string
        {
            add
            {
                HookHandler._beforeAppend_string += value;
                HookHandler.HookAppend_string();
            }
            remove => HookHandler._beforeAppend_string -= value;
        }

        public static event Delegates.Append_bool_string_BeforeArgs Append_bool_string
        {
            add
            {
                HookHandler._beforeAppend_bool_string += value;
                HookHandler.HookAppend_bool_string();
            }
            remove => HookHandler._beforeAppend_bool_string -= value;
        }

        public static event Delegates.AppendLine_string_BeforeArgs AppendLine_string
        {
            add
            {
                HookHandler._beforeAppendLine_string += value;
                HookHandler.HookAppendLine_string();
            }
            remove => HookHandler._beforeAppendLine_string -= value;
        }

        public static event Delegates.AppendLine_int_BeforeArgs AppendLine_int
        {
            add
            {
                HookHandler._beforeAppendLine_int += value;
                HookHandler.HookAppendLine_int();
            }
            remove => HookHandler._beforeAppendLine_int -= value;
        }

        public static event Delegates.AppendFormat_BeforeArgs AppendFormat
        {
            add
            {
                HookHandler._beforeAppendFormat += value;
                HookHandler.HookAppendFormat();
            }
            remove => HookHandler._beforeAppendFormat -= value;
        }

        public static event Delegates.AppendLineFormat_BeforeArgs AppendLineFormat
        {
            add
            {
                HookHandler._beforeAppendLineFormat += value;
                HookHandler.HookAppendLineFormat();
            }
            remove => HookHandler._beforeAppendLineFormat -= value;
        }
    }

    /// <summary>
    /// Contains Hooks to that run code after orig(self) is called
    /// </summary>
    public static class AfterOrig
    {
        public static event Delegates.IncreaseIndent_AfterArgs IncreaseIndent
        {
            add
            {
                HookHandler._afterIncreaseIndent += value;
                HookHandler.HookIncreaseIndent();
            }
            remove => HookHandler._afterIncreaseIndent -= value;
        }

        public static event Delegates.DecreaseIndent_AfterArgs DecreaseIndent
        {
            add
            {
                HookHandler._afterDecreaseIndent += value;
                HookHandler.HookDecreaseIndent();
            }
            remove => HookHandler._afterDecreaseIndent -= value;
        }

        public static event Delegates.Append_string_AfterArgs Append_string
        {
            add
            {
                HookHandler._afterAppend_string += value;
                HookHandler.HookAppend_string();
            }
            remove => HookHandler._afterAppend_string -= value;
        }

        public static event Delegates.Append_bool_string_AfterArgs Append_bool_string
        {
            add
            {
                HookHandler._afterAppend_bool_string += value;
                HookHandler.HookAppend_bool_string();
            }
            remove => HookHandler._afterAppend_bool_string -= value;
        }

        public static event Delegates.AppendLine_string_AfterArgs AppendLine_string
        {
            add
            {
                HookHandler._afterAppendLine_string += value;
                HookHandler.HookAppendLine_string();
            }
            remove => HookHandler._afterAppendLine_string -= value;
        }

        public static event Delegates.AppendLine_int_AfterArgs AppendLine_int
        {
            add
            {
                HookHandler._afterAppendLine_int += value;
                HookHandler.HookAppendLine_int();
            }
            remove => HookHandler._afterAppendLine_int -= value;
        }

        public static event Delegates.AppendFormat_AfterArgs AppendFormat
        {
            add
            {
                HookHandler._afterAppendFormat += value;
                HookHandler.HookAppendFormat();
            }
            remove => HookHandler._afterAppendFormat -= value;
        }

        public static event Delegates.AppendLineFormat_AfterArgs AppendLineFormat
        {
            add
            {
                HookHandler._afterAppendLineFormat += value;
                HookHandler.HookAppendLineFormat();
            }
            remove => HookHandler._afterAppendLineFormat -= value;
        }
    }

    /// <summary>
    /// Contains all On Hooks, even those that aren't in the On namespace such as API generated functions and property getters/setters
    /// </summary>
    public static class WithOrig
    {
        public static event Delegates.IncreaseIndent_WithArgs IncreaseIndent
        {
            add => HookEndpointManager.Add<Delegates.IncreaseIndent_WithArgs>(
                ReflectionHelper.GetMethodInfo(typeof(InControl.Internal.CodeWriter), "IncreaseIndent", true), value);
            remove => HookEndpointManager.Remove<Delegates.IncreaseIndent_WithArgs>(
                ReflectionHelper.GetMethodInfo(typeof(InControl.Internal.CodeWriter), "IncreaseIndent", true), value);
        }

        public static event Delegates.DecreaseIndent_WithArgs DecreaseIndent
        {
            add => HookEndpointManager.Add<Delegates.DecreaseIndent_WithArgs>(
                ReflectionHelper.GetMethodInfo(typeof(InControl.Internal.CodeWriter), "DecreaseIndent", true), value);
            remove => HookEndpointManager.Remove<Delegates.DecreaseIndent_WithArgs>(
                ReflectionHelper.GetMethodInfo(typeof(InControl.Internal.CodeWriter), "DecreaseIndent", true), value);
        }

        public static event Delegates.Append_string_WithArgs Append_string
        {
            add => HookEndpointManager.Add<Delegates.Append_string_WithArgs>(
                ReflectionHelper.GetMethodInfo(typeof(InControl.Internal.CodeWriter), "Append", true), value);
            remove => HookEndpointManager.Remove<Delegates.Append_string_WithArgs>(
                ReflectionHelper.GetMethodInfo(typeof(InControl.Internal.CodeWriter), "Append", true), value);
        }

        public static event Delegates.Append_bool_string_WithArgs Append_bool_string
        {
            add => HookEndpointManager.Add<Delegates.Append_bool_string_WithArgs>(
                ReflectionHelper.GetMethodInfo(typeof(InControl.Internal.CodeWriter), "Append", true), value);
            remove => HookEndpointManager.Remove<Delegates.Append_bool_string_WithArgs>(
                ReflectionHelper.GetMethodInfo(typeof(InControl.Internal.CodeWriter), "Append", true), value);
        }

        public static event Delegates.AppendLine_string_WithArgs AppendLine_string
        {
            add => HookEndpointManager.Add<Delegates.AppendLine_string_WithArgs>(
                ReflectionHelper.GetMethodInfo(typeof(InControl.Internal.CodeWriter), "AppendLine", true), value);
            remove => HookEndpointManager.Remove<Delegates.AppendLine_string_WithArgs>(
                ReflectionHelper.GetMethodInfo(typeof(InControl.Internal.CodeWriter), "AppendLine", true), value);
        }

        public static event Delegates.AppendLine_int_WithArgs AppendLine_int
        {
            add => HookEndpointManager.Add<Delegates.AppendLine_int_WithArgs>(
                ReflectionHelper.GetMethodInfo(typeof(InControl.Internal.CodeWriter), "AppendLine", true), value);
            remove => HookEndpointManager.Remove<Delegates.AppendLine_int_WithArgs>(
                ReflectionHelper.GetMethodInfo(typeof(InControl.Internal.CodeWriter), "AppendLine", true), value);
        }

        public static event Delegates.AppendFormat_WithArgs AppendFormat
        {
            add => HookEndpointManager.Add<Delegates.AppendFormat_WithArgs>(
                ReflectionHelper.GetMethodInfo(typeof(InControl.Internal.CodeWriter), "AppendFormat", true), value);
            remove => HookEndpointManager.Remove<Delegates.AppendFormat_WithArgs>(
                ReflectionHelper.GetMethodInfo(typeof(InControl.Internal.CodeWriter), "AppendFormat", true), value);
        }

        public static event Delegates.AppendLineFormat_WithArgs AppendLineFormat
        {
            add => HookEndpointManager.Add<Delegates.AppendLineFormat_WithArgs>(
                ReflectionHelper.GetMethodInfo(typeof(InControl.Internal.CodeWriter), "AppendLineFormat", true), value);
            remove => HookEndpointManager.Remove<Delegates.AppendLineFormat_WithArgs>(
                ReflectionHelper.GetMethodInfo(typeof(InControl.Internal.CodeWriter), "AppendLineFormat", true), value);
        }
    }
}