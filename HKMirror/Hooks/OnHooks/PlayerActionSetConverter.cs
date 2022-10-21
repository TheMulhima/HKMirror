using MonoMod.RuntimeDetour;
using MonoMod.RuntimeDetour.HookGen;
namespace HKMirror.Hooks.OnHooks;
/// <summary>
/// Contains different types of On Hooks for PlayerActionSetConverter class.<br />
/// Contains hooks that aren't generated by monomod, and before and after orig hooks for easier hooking.
/// </summary>
public static class OnPlayerActionSetConverter
{
internal static class HookHandler
{
private static List<string> HookedList = new List<string>();
internal static void HookCanConvert()
{
if (!HookedList.Contains("CanConvert"))
{
HookedList.Add("CanConvert");
new Hook(ReflectionHelper.GetMethodInfo(typeof(Modding.Converters.PlayerActionSetConverter), "CanConvert", true), CanConvert);

}
}
internal static event Delegates.CanConvert_BeforeArgs _beforeCanConvert;
internal static event Delegates.CanConvert_AfterArgs _afterCanConvert;
private static bool CanConvert(Func<Modding.Converters.PlayerActionSetConverter,  System.Type, bool> orig, Modding.Converters.PlayerActionSetConverter self,  System.Type objectType)
{
Delegates.Params_CanConvert @params = new() 
{
self = self
, objectType = objectType
};
if (_beforeCanConvert != null)
{
foreach (Delegates.CanConvert_BeforeArgs toInvoke in _beforeCanConvert.GetInvocationList())
{
try
{
_beforeCanConvert?.Invoke(@params);
}
catch (Exception e) 
{ HKMirrorMod.DoLogError(e);
}
}
}
self = @params.self;
objectType = @params.objectType;
var retVal = orig(self, objectType);
if (_afterCanConvert != null)
{
foreach (Delegates.CanConvert_AfterArgs toInvoke in _afterCanConvert.GetInvocationList())
{
try
{
retVal = _afterCanConvert.Invoke(@params, retVal);
}
catch (Exception e) 
{ HKMirrorMod.DoLogError(e);
}
}
}
return retVal;
}
internal static void HookReadJson()
{
if (!HookedList.Contains("ReadJson"))
{
HookedList.Add("ReadJson");
new Hook(ReflectionHelper.GetMethodInfo(typeof(Modding.Converters.PlayerActionSetConverter), "ReadJson", true), ReadJson);

}
}
internal static event Delegates.ReadJson_BeforeArgs _beforeReadJson;
internal static event Delegates.ReadJson_AfterArgs _afterReadJson;
private static System.Object ReadJson(Func<Modding.Converters.PlayerActionSetConverter,  Newtonsoft.Json.JsonReader,  System.Type,  System.Object,  Newtonsoft.Json.JsonSerializer, System.Object> orig, Modding.Converters.PlayerActionSetConverter self,  Newtonsoft.Json.JsonReader reader,  System.Type objectType,  System.Object existingValue,  Newtonsoft.Json.JsonSerializer serializer)
{
Delegates.Params_ReadJson @params = new() 
{
self = self
, reader = reader
, objectType = objectType
, existingValue = existingValue
, serializer = serializer
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
reader = @params.reader;
objectType = @params.objectType;
existingValue = @params.existingValue;
serializer = @params.serializer;
var retVal = orig(self, reader, objectType, existingValue, serializer);
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
new Hook(ReflectionHelper.GetMethodInfo(typeof(Modding.Converters.PlayerActionSetConverter), "WriteJson", true), WriteJson);

}
}
internal static event Delegates.WriteJson_BeforeArgs _beforeWriteJson;
internal static event Delegates.WriteJson_AfterArgs _afterWriteJson;
private static void WriteJson(Action<Modding.Converters.PlayerActionSetConverter,  Newtonsoft.Json.JsonWriter,  System.Object,  Newtonsoft.Json.JsonSerializer> orig, Modding.Converters.PlayerActionSetConverter self,  Newtonsoft.Json.JsonWriter writer,  System.Object value,  Newtonsoft.Json.JsonSerializer serializer)
{
Delegates.Params_WriteJson @params = new() 
{
self = self
, writer = writer
, value = value
, serializer = serializer
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
serializer = @params.serializer;
orig(self, writer, value, serializer);
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
public sealed class Params_CanConvert
{
public Modding.Converters.PlayerActionSetConverter self;
public System.Type objectType;
}
public delegate void CanConvert_BeforeArgs(Params_CanConvert args);
public delegate bool CanConvert_AfterArgs(Params_CanConvert args, bool ret);
public delegate bool CanConvert_WithArgs (Func<Modding.Converters.PlayerActionSetConverter,  System.Type, bool> orig, Modding.Converters.PlayerActionSetConverter self,  System.Type objectType);
public sealed class Params_ReadJson
{
public Modding.Converters.PlayerActionSetConverter self;
public Newtonsoft.Json.JsonReader reader;
public System.Type objectType;
public System.Object existingValue;
public Newtonsoft.Json.JsonSerializer serializer;
}
public delegate void ReadJson_BeforeArgs(Params_ReadJson args);
public delegate System.Object ReadJson_AfterArgs(Params_ReadJson args, System.Object ret);
public delegate System.Object ReadJson_WithArgs (Func<Modding.Converters.PlayerActionSetConverter,  Newtonsoft.Json.JsonReader,  System.Type,  System.Object,  Newtonsoft.Json.JsonSerializer, System.Object> orig, Modding.Converters.PlayerActionSetConverter self,  Newtonsoft.Json.JsonReader reader,  System.Type objectType,  System.Object existingValue,  Newtonsoft.Json.JsonSerializer serializer);
public sealed class Params_WriteJson
{
public Modding.Converters.PlayerActionSetConverter self;
public Newtonsoft.Json.JsonWriter writer;
public System.Object value;
public Newtonsoft.Json.JsonSerializer serializer;
}
public delegate void WriteJson_BeforeArgs(Params_WriteJson args);
public delegate void WriteJson_AfterArgs(Params_WriteJson args);
public delegate void WriteJson_WithArgs (Action<Modding.Converters.PlayerActionSetConverter,  Newtonsoft.Json.JsonWriter,  System.Object,  Newtonsoft.Json.JsonSerializer> orig, Modding.Converters.PlayerActionSetConverter self,  Newtonsoft.Json.JsonWriter writer,  System.Object value,  Newtonsoft.Json.JsonSerializer serializer);
}

/// <summary>
/// Contains Hooks to that run code before orig(self) is called
/// </summary>
public static class BeforeOrig
{
public static event Delegates.CanConvert_BeforeArgs CanConvert
{
add
{

HookHandler._beforeCanConvert += value;
HookHandler.HookCanConvert();
}
remove => HookHandler._beforeCanConvert -= value;
}
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
public static event Delegates.CanConvert_AfterArgs CanConvert
{
add
{

HookHandler._afterCanConvert += value;
HookHandler.HookCanConvert();
}
remove => HookHandler._afterCanConvert -= value;
}
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
public static event Delegates.CanConvert_WithArgs CanConvert
{
add => HookEndpointManager.Add<Delegates.CanConvert_WithArgs>(ReflectionHelper.GetMethodInfo(typeof(Modding.Converters.PlayerActionSetConverter), "CanConvert", true), value);
remove => HookEndpointManager.Remove<Delegates.CanConvert_WithArgs>(ReflectionHelper.GetMethodInfo(typeof(Modding.Converters.PlayerActionSetConverter), "CanConvert", true), value);
}
public static event Delegates.ReadJson_WithArgs ReadJson
{
add => HookEndpointManager.Add<Delegates.ReadJson_WithArgs>(ReflectionHelper.GetMethodInfo(typeof(Modding.Converters.PlayerActionSetConverter), "ReadJson", true), value);
remove => HookEndpointManager.Remove<Delegates.ReadJson_WithArgs>(ReflectionHelper.GetMethodInfo(typeof(Modding.Converters.PlayerActionSetConverter), "ReadJson", true), value);
}
public static event Delegates.WriteJson_WithArgs WriteJson
{
add => HookEndpointManager.Add<Delegates.WriteJson_WithArgs>(ReflectionHelper.GetMethodInfo(typeof(Modding.Converters.PlayerActionSetConverter), "WriteJson", true), value);
remove => HookEndpointManager.Remove<Delegates.WriteJson_WithArgs>(ReflectionHelper.GetMethodInfo(typeof(Modding.Converters.PlayerActionSetConverter), "WriteJson", true), value);
}
}

}
