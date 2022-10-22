using MonoMod.RuntimeDetour;
using MonoMod.RuntimeDetour.HookGen;

namespace HKMirror.Hooks.OnHooks;

/// <summary>
///     Contains different types of On Hooks for Vector2Converter class.<br />
///     Contains hooks that aren't generated by monomod, and before and after orig hooks for easier hooking.
/// </summary>
public static class OnVector2Converter
{
    internal static class HookHandler
    {
        private static readonly List<string> HookedList = new();

        internal static void HookReadJson()
        {
            if (!HookedList.Contains("ReadJson"))
            {
                HookedList.Add("ReadJson");
                new Hook(ReflectionHelper.GetMethodInfo(typeof(Vector2Converter), "ReadJson"), ReadJson);
            }
        }

        internal static event Delegates.ReadJson_BeforeArgs _beforeReadJson;
        internal static event Delegates.ReadJson_AfterArgs _afterReadJson;

        private static Vector2 ReadJson(Func<Vector2Converter, Dictionary<string, object>, object, Vector2> orig,
            Vector2Converter self, Dictionary<string, object> token, object existingValue)
        {
            Delegates.Params_ReadJson @params = new()
            {
                self = self, token = token, existingValue = existingValue
            };
            if (_beforeReadJson != null)
                foreach (Delegates.ReadJson_BeforeArgs toInvoke in _beforeReadJson.GetInvocationList())
                    try
                    {
                        _beforeReadJson?.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }

            self = @params.self;
            token = @params.token;
            existingValue = @params.existingValue;
            var retVal = orig(self, token, existingValue);
            if (_afterReadJson != null)
                foreach (Delegates.ReadJson_AfterArgs toInvoke in _afterReadJson.GetInvocationList())
                    try
                    {
                        retVal = _afterReadJson.Invoke(@params, retVal);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }

            return retVal;
        }

        internal static void HookWriteJson()
        {
            if (!HookedList.Contains("WriteJson"))
            {
                HookedList.Add("WriteJson");
                new Hook(ReflectionHelper.GetMethodInfo(typeof(Vector2Converter), "WriteJson"), WriteJson);
            }
        }

        internal static event Delegates.WriteJson_BeforeArgs _beforeWriteJson;
        internal static event Delegates.WriteJson_AfterArgs _afterWriteJson;

        private static void WriteJson(Action<Vector2Converter, JsonWriter, Vector2> orig, Vector2Converter self,
            JsonWriter writer, Vector2 value)
        {
            Delegates.Params_WriteJson @params = new()
            {
                self = self, writer = writer, value = value
            };
            if (_beforeWriteJson != null)
                foreach (Delegates.WriteJson_BeforeArgs toInvoke in _beforeWriteJson.GetInvocationList())
                    try
                    {
                        _beforeWriteJson?.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }

            self = @params.self;
            writer = @params.writer;
            value = @params.value;
            orig(self, writer, value);
            if (_afterWriteJson != null)
                foreach (Delegates.WriteJson_AfterArgs toInvoke in _afterWriteJson.GetInvocationList())
                    try
                    {
                        _afterWriteJson.Invoke(@params);
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
        public delegate Vector2 ReadJson_AfterArgs(Params_ReadJson args, Vector2 ret);

        public delegate void ReadJson_BeforeArgs(Params_ReadJson args);

        public delegate Vector2 ReadJson_WithArgs(
            Func<Vector2Converter, Dictionary<string, object>, object, Vector2> orig, Vector2Converter self,
            Dictionary<string, object> token, object existingValue);

        public delegate void WriteJson_AfterArgs(Params_WriteJson args);

        public delegate void WriteJson_BeforeArgs(Params_WriteJson args);

        public delegate void WriteJson_WithArgs(Action<Vector2Converter, JsonWriter, Vector2> orig,
            Vector2Converter self, JsonWriter writer, Vector2 value);

        public sealed class Params_ReadJson
        {
            public object existingValue;
            public Vector2Converter self;
            public Dictionary<string, object> token;
        }

        public sealed class Params_WriteJson
        {
            public Vector2Converter self;
            public Vector2 value;
            public JsonWriter writer;
        }
    }

    /// <summary>
    ///     Contains Hooks to that run code before orig(self) is called
    /// </summary>
    public static class BeforeOrig
    {
        public static event Delegates.ReadJson_BeforeArgs ReadJson
        {
            add
            {
                HookHandler._beforeReadJson += value;
                HookHandler.HookReadJson();
            }
            remove => HookHandler._beforeReadJson -= value;
        }

        public static event Delegates.WriteJson_BeforeArgs WriteJson
        {
            add
            {
                HookHandler._beforeWriteJson += value;
                HookHandler.HookWriteJson();
            }
            remove => HookHandler._beforeWriteJson -= value;
        }
    }

    /// <summary>
    ///     Contains Hooks to that run code after orig(self) is called
    /// </summary>
    public static class AfterOrig
    {
        public static event Delegates.ReadJson_AfterArgs ReadJson
        {
            add
            {
                HookHandler._afterReadJson += value;
                HookHandler.HookReadJson();
            }
            remove => HookHandler._afterReadJson -= value;
        }

        public static event Delegates.WriteJson_AfterArgs WriteJson
        {
            add
            {
                HookHandler._afterWriteJson += value;
                HookHandler.HookWriteJson();
            }
            remove => HookHandler._afterWriteJson -= value;
        }
    }

    /// <summary>
    ///     Contains all On Hooks, even those that aren't in the On namespace such as API generated functions and property
    ///     getters/setters
    /// </summary>
    public static class WithOrig
    {
        public static event Delegates.ReadJson_WithArgs ReadJson
        {
            add => HookEndpointManager.Add<Delegates.ReadJson_WithArgs>(
                ReflectionHelper.GetMethodInfo(typeof(Vector2Converter), "ReadJson"), value);
            remove => HookEndpointManager.Remove<Delegates.ReadJson_WithArgs>(
                ReflectionHelper.GetMethodInfo(typeof(Vector2Converter), "ReadJson"), value);
        }

        public static event Delegates.WriteJson_WithArgs WriteJson
        {
            add => HookEndpointManager.Add<Delegates.WriteJson_WithArgs>(
                ReflectionHelper.GetMethodInfo(typeof(Vector2Converter), "WriteJson"), value);
            remove => HookEndpointManager.Remove<Delegates.WriteJson_WithArgs>(
                ReflectionHelper.GetMethodInfo(typeof(Vector2Converter), "WriteJson"), value);
        }
    }
}