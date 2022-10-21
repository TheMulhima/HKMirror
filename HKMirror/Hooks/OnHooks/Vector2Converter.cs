using MonoMod.RuntimeDetour;
using MonoMod.RuntimeDetour.HookGen;
namespace HKMirror.Hooks.OnHooks;
/// <summary>
/// Contains different types of On Hooks for Vector2Converter class.<br />
/// Contains hooks that aren't generated by monomod, and before and after orig hooks for easier hooking.
/// </summary>
public static class OnVector2Converter
{
internal static class HookHandler
{
private static List<string> HookedList = new List<string>();
internal static void HookReadJson()
{
if (!HookedList.Contains("ReadJson"))
{
HookedList.Add("ReadJson");
new Hook(ReflectionHelper.GetMethodInfo(typeof(Modding.Converters.Vector2Converter), "ReadJson", true), ReadJson);

}
}
internal static event Delegates.ReadJson_BeforeArgs _beforeReadJson;
internal static event Delegates.ReadJson_AfterArgs _afterReadJson;
private static UnityEngine.Vector2 ReadJson(Func<Modding.Converters.Vector2Converter,  System.Collections.Generic.Dictionary<string,System.Object>,  System.Object, UnityEngine.Vector2> orig, Modding.Converters.Vector2Converter self,  System.Collections.Generic.Dictionary<string,System.Object> token,  System.Object existingValue)
{
Delegates.Params_ReadJson @params = new() 
{
self = self
, token = token
, existingValue = existingValue
};
if (_beforeReadJson != null)
{
foreach (Delegates.ReadJson_BeforeArgs toInvoke in _beforeReadJson.GetInvocationList())
{
try
{
_beforeReadJson?.Invoke(@params);
}
catch (Exception e) 
{ HKMirrorMod.DoLogError(e);
}
}
}
self = @params.self;
token = @params.token;
existingValue = @params.existingValue;
var retVal = orig(self, token, existingValue);
if (_afterReadJson != null)
{
foreach (Delegates.ReadJson_AfterArgs toInvoke in _afterReadJson.GetInvocationList())
{
try
{
retVal = _afterReadJson.Invoke(@params, retVal);
}
catch (Exception e) 
{ HKMirrorMod.DoLogError(e);
}
}
}
return retVal;
}
internal static void HookWriteJson()
{
if (!HookedList.Contains("WriteJson"))
{
HookedList.Add("WriteJson");
new Hook(ReflectionHelper.GetMethodInfo(typeof(Modding.Converters.Vector2Converter), "WriteJson", true), WriteJson);

}
}
internal static event Delegates.WriteJson_BeforeArgs _beforeWriteJson;
internal static event Delegates.WriteJson_AfterArgs _afterWriteJson;
private static void WriteJson(Action<Modding.Converters.Vector2Converter,  Newtonsoft.Json.JsonWriter,  UnityEngine.Vector2> orig, Modding.Converters.Vector2Converter self,  Newtonsoft.Json.JsonWriter writer,  UnityEngine.Vector2 value)
{
Delegates.Params_WriteJson @params = new() 
{
self = self
, writer = writer
, value = value
};
if (_beforeWriteJson != null)
{
foreach (Delegates.WriteJson_BeforeArgs toInvoke in _beforeWriteJson.GetInvocationList())
{
try
{
_beforeWriteJson?.Invoke(@params);
}
catch (Exception e) 
{ HKMirrorMod.DoLogError(e);
}
}
}
self = @params.self;
writer = @params.writer;
value = @params.value;
orig(self, writer, value);
if (_afterWriteJson != null)
{
foreach (Delegates.WriteJson_AfterArgs toInvoke in _afterWriteJson.GetInvocationList())
{
try
{
_afterWriteJson.Invoke(@params);
}
catch (Exception e) 
{ HKMirrorMod.DoLogError(e);
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
public sealed class Params_ReadJson
{
public Modding.Converters.Vector2Converter self;
public System.Collections.Generic.Dictionary<string,System.Object> token;
public System.Object existingValue;
}
public delegate void ReadJson_BeforeArgs(Params_ReadJson args);
public delegate UnityEngine.Vector2 ReadJson_AfterArgs(Params_ReadJson args, UnityEngine.Vector2 ret);
public delegate UnityEngine.Vector2 ReadJson_WithArgs (Func<Modding.Converters.Vector2Converter,  System.Collections.Generic.Dictionary<string,System.Object>,  System.Object, UnityEngine.Vector2> orig, Modding.Converters.Vector2Converter self,  System.Collections.Generic.Dictionary<string,System.Object> token,  System.Object existingValue);
public sealed class Params_WriteJson
{
public Modding.Converters.Vector2Converter self;
public Newtonsoft.Json.JsonWriter writer;
public UnityEngine.Vector2 value;
}
public delegate void WriteJson_BeforeArgs(Params_WriteJson args);
public delegate void WriteJson_AfterArgs(Params_WriteJson args);
public delegate void WriteJson_WithArgs (Action<Modding.Converters.Vector2Converter,  Newtonsoft.Json.JsonWriter,  UnityEngine.Vector2> orig, Modding.Converters.Vector2Converter self,  Newtonsoft.Json.JsonWriter writer,  UnityEngine.Vector2 value);
}

/// <summary>
/// Contains Hooks to that run code before orig(self) is called
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
/// Contains Hooks to that run code after orig(self) is called
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
/// Contains all On Hooks, even those that aren't in the On namespace such as API generated functions and property getters/setters
/// </summary>
public static class WithOrig
{
public static event Delegates.ReadJson_WithArgs ReadJson
{
add => HookEndpointManager.Add<Delegates.ReadJson_WithArgs>(ReflectionHelper.GetMethodInfo(typeof(Modding.Converters.Vector2Converter), "ReadJson", true), value);
remove => HookEndpointManager.Remove<Delegates.ReadJson_WithArgs>(ReflectionHelper.GetMethodInfo(typeof(Modding.Converters.Vector2Converter), "ReadJson", true), value);
}
public static event Delegates.WriteJson_WithArgs WriteJson
{
add => HookEndpointManager.Add<Delegates.WriteJson_WithArgs>(ReflectionHelper.GetMethodInfo(typeof(Modding.Converters.Vector2Converter), "WriteJson", true), value);
remove => HookEndpointManager.Remove<Delegates.WriteJson_WithArgs>(ReflectionHelper.GetMethodInfo(typeof(Modding.Converters.Vector2Converter), "WriteJson", true), value);
}
}

}
