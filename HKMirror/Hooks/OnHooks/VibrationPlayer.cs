using MonoMod.RuntimeDetour;
using MonoMod.RuntimeDetour.HookGen;
namespace HKMirror.Hooks.OnHooks;
/// <summary>
/// Contains different types of On Hooks for VibrationPlayer class.<br />
/// Contains hooks that aren't generated by monomod, and before and after orig hooks for easier hooking.
/// </summary>
public static class OnVibrationPlayer
{
internal static class HookHandler
{
private static List<string> HookedList = new List<string>();
internal static void Hookget_VibrationData()
{
if (!HookedList.Contains("get_VibrationData"))
{
HookedList.Add("get_VibrationData");
new Hook(ReflectionHelper.GetMethodInfo(typeof(VibrationPlayer), "get_VibrationData", true), get_VibrationData);

}
}
internal static event Delegates.get_VibrationData_BeforeArgs _beforeget_VibrationData;
internal static event Delegates.get_VibrationData_AfterArgs _afterget_VibrationData;
private static VibrationData get_VibrationData(Func<VibrationPlayer, VibrationData> orig, VibrationPlayer self)
{
Delegates.Params_get_VibrationData @params = new() 
{
self = self
};
if (_beforeget_VibrationData != null)
{
foreach (Delegates.get_VibrationData_BeforeArgs toInvoke in _beforeget_VibrationData.GetInvocationList())
{
try
{
_beforeget_VibrationData?.Invoke(@params);
}
catch (Exception e) 
{ HKMirrorMod.DoLogError(e);
}
}
}
self = @params.self;
var retVal = orig(self);
if (_afterget_VibrationData != null)
{
foreach (Delegates.get_VibrationData_AfterArgs toInvoke in _afterget_VibrationData.GetInvocationList())
{
try
{
retVal = _afterget_VibrationData.Invoke(@params, retVal);
}
catch (Exception e) 
{ HKMirrorMod.DoLogError(e);
}
}
}
return retVal;
}
internal static void Hookset_VibrationData()
{
if (!HookedList.Contains("set_VibrationData"))
{
HookedList.Add("set_VibrationData");
new Hook(ReflectionHelper.GetMethodInfo(typeof(VibrationPlayer), "set_VibrationData", true), set_VibrationData);

}
}
internal static event Delegates.set_VibrationData_BeforeArgs _beforeset_VibrationData;
internal static event Delegates.set_VibrationData_AfterArgs _afterset_VibrationData;
private static void set_VibrationData(Action<VibrationPlayer,  VibrationData> orig, VibrationPlayer self,  VibrationData value)
{
Delegates.Params_set_VibrationData @params = new() 
{
self = self
, value = value
};
if (_beforeset_VibrationData != null)
{
foreach (Delegates.set_VibrationData_BeforeArgs toInvoke in _beforeset_VibrationData.GetInvocationList())
{
try
{
_beforeset_VibrationData?.Invoke(@params);
}
catch (Exception e) 
{ HKMirrorMod.DoLogError(e);
}
}
}
self = @params.self;
value = @params.value;
orig(self, value);
if (_afterset_VibrationData != null)
{
foreach (Delegates.set_VibrationData_AfterArgs toInvoke in _afterset_VibrationData.GetInvocationList())
{
try
{
_afterset_VibrationData.Invoke(@params);
}
catch (Exception e) 
{ HKMirrorMod.DoLogError(e);
}
}
}
}
internal static void Hookget_Target()
{
if (!HookedList.Contains("get_Target"))
{
HookedList.Add("get_Target");
new Hook(ReflectionHelper.GetMethodInfo(typeof(VibrationPlayer), "get_Target", true), get_Target);

}
}
internal static event Delegates.get_Target_BeforeArgs _beforeget_Target;
internal static event Delegates.get_Target_AfterArgs _afterget_Target;
private static VibrationTarget get_Target(Func<VibrationPlayer, VibrationTarget> orig, VibrationPlayer self)
{
Delegates.Params_get_Target @params = new() 
{
self = self
};
if (_beforeget_Target != null)
{
foreach (Delegates.get_Target_BeforeArgs toInvoke in _beforeget_Target.GetInvocationList())
{
try
{
_beforeget_Target?.Invoke(@params);
}
catch (Exception e) 
{ HKMirrorMod.DoLogError(e);
}
}
}
self = @params.self;
var retVal = orig(self);
if (_afterget_Target != null)
{
foreach (Delegates.get_Target_AfterArgs toInvoke in _afterget_Target.GetInvocationList())
{
try
{
retVal = _afterget_Target.Invoke(@params, retVal);
}
catch (Exception e) 
{ HKMirrorMod.DoLogError(e);
}
}
}
return retVal;
}
internal static void Hookset_Target()
{
if (!HookedList.Contains("set_Target"))
{
HookedList.Add("set_Target");
new Hook(ReflectionHelper.GetMethodInfo(typeof(VibrationPlayer), "set_Target", true), set_Target);

}
}
internal static event Delegates.set_Target_BeforeArgs _beforeset_Target;
internal static event Delegates.set_Target_AfterArgs _afterset_Target;
private static void set_Target(Action<VibrationPlayer,  VibrationTarget> orig, VibrationPlayer self,  VibrationTarget value)
{
Delegates.Params_set_Target @params = new() 
{
self = self
, value = value
};
if (_beforeset_Target != null)
{
foreach (Delegates.set_Target_BeforeArgs toInvoke in _beforeset_Target.GetInvocationList())
{
try
{
_beforeset_Target?.Invoke(@params);
}
catch (Exception e) 
{ HKMirrorMod.DoLogError(e);
}
}
}
self = @params.self;
value = @params.value;
orig(self, value);
if (_afterset_Target != null)
{
foreach (Delegates.set_Target_AfterArgs toInvoke in _afterset_Target.GetInvocationList())
{
try
{
_afterset_Target.Invoke(@params);
}
catch (Exception e) 
{ HKMirrorMod.DoLogError(e);
}
}
}
}
internal static void Hookget_PlayAutomatically()
{
if (!HookedList.Contains("get_PlayAutomatically"))
{
HookedList.Add("get_PlayAutomatically");
new Hook(ReflectionHelper.GetMethodInfo(typeof(VibrationPlayer), "get_PlayAutomatically", true), get_PlayAutomatically);

}
}
internal static event Delegates.get_PlayAutomatically_BeforeArgs _beforeget_PlayAutomatically;
internal static event Delegates.get_PlayAutomatically_AfterArgs _afterget_PlayAutomatically;
private static bool get_PlayAutomatically(Func<VibrationPlayer, bool> orig, VibrationPlayer self)
{
Delegates.Params_get_PlayAutomatically @params = new() 
{
self = self
};
if (_beforeget_PlayAutomatically != null)
{
foreach (Delegates.get_PlayAutomatically_BeforeArgs toInvoke in _beforeget_PlayAutomatically.GetInvocationList())
{
try
{
_beforeget_PlayAutomatically?.Invoke(@params);
}
catch (Exception e) 
{ HKMirrorMod.DoLogError(e);
}
}
}
self = @params.self;
var retVal = orig(self);
if (_afterget_PlayAutomatically != null)
{
foreach (Delegates.get_PlayAutomatically_AfterArgs toInvoke in _afterget_PlayAutomatically.GetInvocationList())
{
try
{
retVal = _afterget_PlayAutomatically.Invoke(@params, retVal);
}
catch (Exception e) 
{ HKMirrorMod.DoLogError(e);
}
}
}
return retVal;
}
internal static void Hookset_PlayAutomatically()
{
if (!HookedList.Contains("set_PlayAutomatically"))
{
HookedList.Add("set_PlayAutomatically");
new Hook(ReflectionHelper.GetMethodInfo(typeof(VibrationPlayer), "set_PlayAutomatically", true), set_PlayAutomatically);

}
}
internal static event Delegates.set_PlayAutomatically_BeforeArgs _beforeset_PlayAutomatically;
internal static event Delegates.set_PlayAutomatically_AfterArgs _afterset_PlayAutomatically;
private static void set_PlayAutomatically(Action<VibrationPlayer,  bool> orig, VibrationPlayer self,  bool value)
{
Delegates.Params_set_PlayAutomatically @params = new() 
{
self = self
, value = value
};
if (_beforeset_PlayAutomatically != null)
{
foreach (Delegates.set_PlayAutomatically_BeforeArgs toInvoke in _beforeset_PlayAutomatically.GetInvocationList())
{
try
{
_beforeset_PlayAutomatically?.Invoke(@params);
}
catch (Exception e) 
{ HKMirrorMod.DoLogError(e);
}
}
}
self = @params.self;
value = @params.value;
orig(self, value);
if (_afterset_PlayAutomatically != null)
{
foreach (Delegates.set_PlayAutomatically_AfterArgs toInvoke in _afterset_PlayAutomatically.GetInvocationList())
{
try
{
_afterset_PlayAutomatically.Invoke(@params);
}
catch (Exception e) 
{ HKMirrorMod.DoLogError(e);
}
}
}
}
internal static void Hookget_IsLooping()
{
if (!HookedList.Contains("get_IsLooping"))
{
HookedList.Add("get_IsLooping");
new Hook(ReflectionHelper.GetMethodInfo(typeof(VibrationPlayer), "get_IsLooping", true), get_IsLooping);

}
}
internal static event Delegates.get_IsLooping_BeforeArgs _beforeget_IsLooping;
internal static event Delegates.get_IsLooping_AfterArgs _afterget_IsLooping;
private static bool get_IsLooping(Func<VibrationPlayer, bool> orig, VibrationPlayer self)
{
Delegates.Params_get_IsLooping @params = new() 
{
self = self
};
if (_beforeget_IsLooping != null)
{
foreach (Delegates.get_IsLooping_BeforeArgs toInvoke in _beforeget_IsLooping.GetInvocationList())
{
try
{
_beforeget_IsLooping?.Invoke(@params);
}
catch (Exception e) 
{ HKMirrorMod.DoLogError(e);
}
}
}
self = @params.self;
var retVal = orig(self);
if (_afterget_IsLooping != null)
{
foreach (Delegates.get_IsLooping_AfterArgs toInvoke in _afterget_IsLooping.GetInvocationList())
{
try
{
retVal = _afterget_IsLooping.Invoke(@params, retVal);
}
catch (Exception e) 
{ HKMirrorMod.DoLogError(e);
}
}
}
return retVal;
}
internal static void Hookset_IsLooping()
{
if (!HookedList.Contains("set_IsLooping"))
{
HookedList.Add("set_IsLooping");
new Hook(ReflectionHelper.GetMethodInfo(typeof(VibrationPlayer), "set_IsLooping", true), set_IsLooping);

}
}
internal static event Delegates.set_IsLooping_BeforeArgs _beforeset_IsLooping;
internal static event Delegates.set_IsLooping_AfterArgs _afterset_IsLooping;
private static void set_IsLooping(Action<VibrationPlayer,  bool> orig, VibrationPlayer self,  bool value)
{
Delegates.Params_set_IsLooping @params = new() 
{
self = self
, value = value
};
if (_beforeset_IsLooping != null)
{
foreach (Delegates.set_IsLooping_BeforeArgs toInvoke in _beforeset_IsLooping.GetInvocationList())
{
try
{
_beforeset_IsLooping?.Invoke(@params);
}
catch (Exception e) 
{ HKMirrorMod.DoLogError(e);
}
}
}
self = @params.self;
value = @params.value;
orig(self, value);
if (_afterset_IsLooping != null)
{
foreach (Delegates.set_IsLooping_AfterArgs toInvoke in _afterset_IsLooping.GetInvocationList())
{
try
{
_afterset_IsLooping.Invoke(@params);
}
catch (Exception e) 
{ HKMirrorMod.DoLogError(e);
}
}
}
}
internal static void Hookget_VibrationTag()
{
if (!HookedList.Contains("get_VibrationTag"))
{
HookedList.Add("get_VibrationTag");
new Hook(ReflectionHelper.GetMethodInfo(typeof(VibrationPlayer), "get_VibrationTag", true), get_VibrationTag);

}
}
internal static event Delegates.get_VibrationTag_BeforeArgs _beforeget_VibrationTag;
internal static event Delegates.get_VibrationTag_AfterArgs _afterget_VibrationTag;
private static string get_VibrationTag(Func<VibrationPlayer, string> orig, VibrationPlayer self)
{
Delegates.Params_get_VibrationTag @params = new() 
{
self = self
};
if (_beforeget_VibrationTag != null)
{
foreach (Delegates.get_VibrationTag_BeforeArgs toInvoke in _beforeget_VibrationTag.GetInvocationList())
{
try
{
_beforeget_VibrationTag?.Invoke(@params);
}
catch (Exception e) 
{ HKMirrorMod.DoLogError(e);
}
}
}
self = @params.self;
var retVal = orig(self);
if (_afterget_VibrationTag != null)
{
foreach (Delegates.get_VibrationTag_AfterArgs toInvoke in _afterget_VibrationTag.GetInvocationList())
{
try
{
retVal = _afterget_VibrationTag.Invoke(@params, retVal);
}
catch (Exception e) 
{ HKMirrorMod.DoLogError(e);
}
}
}
return retVal;
}
internal static void Hookset_VibrationTag()
{
if (!HookedList.Contains("set_VibrationTag"))
{
HookedList.Add("set_VibrationTag");
new Hook(ReflectionHelper.GetMethodInfo(typeof(VibrationPlayer), "set_VibrationTag", true), set_VibrationTag);

}
}
internal static event Delegates.set_VibrationTag_BeforeArgs _beforeset_VibrationTag;
internal static event Delegates.set_VibrationTag_AfterArgs _afterset_VibrationTag;
private static void set_VibrationTag(Action<VibrationPlayer,  string> orig, VibrationPlayer self,  string value)
{
Delegates.Params_set_VibrationTag @params = new() 
{
self = self
, value = value
};
if (_beforeset_VibrationTag != null)
{
foreach (Delegates.set_VibrationTag_BeforeArgs toInvoke in _beforeset_VibrationTag.GetInvocationList())
{
try
{
_beforeset_VibrationTag?.Invoke(@params);
}
catch (Exception e) 
{ HKMirrorMod.DoLogError(e);
}
}
}
self = @params.self;
value = @params.value;
orig(self, value);
if (_afterset_VibrationTag != null)
{
foreach (Delegates.set_VibrationTag_AfterArgs toInvoke in _afterset_VibrationTag.GetInvocationList())
{
try
{
_afterset_VibrationTag.Invoke(@params);
}
catch (Exception e) 
{ HKMirrorMod.DoLogError(e);
}
}
}
}
internal static void HookOnEnable()
{
if (!HookedList.Contains("OnEnable"))
{
HookedList.Add("OnEnable");
On.VibrationPlayer.OnEnable += OnEnable;

}
}
internal static event Delegates.OnEnable_BeforeArgs _beforeOnEnable;
internal static event Delegates.OnEnable_AfterArgs _afterOnEnable;
private static void OnEnable(On.VibrationPlayer.orig_OnEnable orig,VibrationPlayer self)
{
Delegates.Params_OnEnable @params = new() 
{
self = self
};
if (_beforeOnEnable != null)
{
foreach (Delegates.OnEnable_BeforeArgs toInvoke in _beforeOnEnable.GetInvocationList())
{
try
{
_beforeOnEnable?.Invoke(@params);
}
catch (Exception e) 
{ HKMirrorMod.DoLogError(e);
}
}
}
self = @params.self;
orig(self);
if (_afterOnEnable != null)
{
foreach (Delegates.OnEnable_AfterArgs toInvoke in _afterOnEnable.GetInvocationList())
{
try
{
_afterOnEnable.Invoke(@params);
}
catch (Exception e) 
{ HKMirrorMod.DoLogError(e);
}
}
}
}
internal static void HookOnDisable()
{
if (!HookedList.Contains("OnDisable"))
{
HookedList.Add("OnDisable");
On.VibrationPlayer.OnDisable += OnDisable;

}
}
internal static event Delegates.OnDisable_BeforeArgs _beforeOnDisable;
internal static event Delegates.OnDisable_AfterArgs _afterOnDisable;
private static void OnDisable(On.VibrationPlayer.orig_OnDisable orig,VibrationPlayer self)
{
Delegates.Params_OnDisable @params = new() 
{
self = self
};
if (_beforeOnDisable != null)
{
foreach (Delegates.OnDisable_BeforeArgs toInvoke in _beforeOnDisable.GetInvocationList())
{
try
{
_beforeOnDisable?.Invoke(@params);
}
catch (Exception e) 
{ HKMirrorMod.DoLogError(e);
}
}
}
self = @params.self;
orig(self);
if (_afterOnDisable != null)
{
foreach (Delegates.OnDisable_AfterArgs toInvoke in _afterOnDisable.GetInvocationList())
{
try
{
_afterOnDisable.Invoke(@params);
}
catch (Exception e) 
{ HKMirrorMod.DoLogError(e);
}
}
}
}
internal static void HookPlay()
{
if (!HookedList.Contains("Play"))
{
HookedList.Add("Play");
On.VibrationPlayer.Play += Play;

}
}
internal static event Delegates.Play_BeforeArgs _beforePlay;
internal static event Delegates.Play_AfterArgs _afterPlay;
private static void Play(On.VibrationPlayer.orig_Play orig,VibrationPlayer self)
{
Delegates.Params_Play @params = new() 
{
self = self
};
if (_beforePlay != null)
{
foreach (Delegates.Play_BeforeArgs toInvoke in _beforePlay.GetInvocationList())
{
try
{
_beforePlay?.Invoke(@params);
}
catch (Exception e) 
{ HKMirrorMod.DoLogError(e);
}
}
}
self = @params.self;
orig(self);
if (_afterPlay != null)
{
foreach (Delegates.Play_AfterArgs toInvoke in _afterPlay.GetInvocationList())
{
try
{
_afterPlay.Invoke(@params);
}
catch (Exception e) 
{ HKMirrorMod.DoLogError(e);
}
}
}
}
internal static void HookStop()
{
if (!HookedList.Contains("Stop"))
{
HookedList.Add("Stop");
On.VibrationPlayer.Stop += Stop;

}
}
internal static event Delegates.Stop_BeforeArgs _beforeStop;
internal static event Delegates.Stop_AfterArgs _afterStop;
private static void Stop(On.VibrationPlayer.orig_Stop orig,VibrationPlayer self)
{
Delegates.Params_Stop @params = new() 
{
self = self
};
if (_beforeStop != null)
{
foreach (Delegates.Stop_BeforeArgs toInvoke in _beforeStop.GetInvocationList())
{
try
{
_beforeStop?.Invoke(@params);
}
catch (Exception e) 
{ HKMirrorMod.DoLogError(e);
}
}
}
self = @params.self;
orig(self);
if (_afterStop != null)
{
foreach (Delegates.Stop_AfterArgs toInvoke in _afterStop.GetInvocationList())
{
try
{
_afterStop.Invoke(@params);
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
public sealed class Params_get_VibrationData
{
public VibrationPlayer self;
}
public delegate void get_VibrationData_BeforeArgs(Params_get_VibrationData args);
public delegate VibrationData get_VibrationData_AfterArgs(Params_get_VibrationData args, VibrationData ret);
public delegate VibrationData get_VibrationData_WithArgs (Func<VibrationPlayer, VibrationData> orig, VibrationPlayer self);
public sealed class Params_set_VibrationData
{
public VibrationPlayer self;
public VibrationData value;
}
public delegate void set_VibrationData_BeforeArgs(Params_set_VibrationData args);
public delegate void set_VibrationData_AfterArgs(Params_set_VibrationData args);
public delegate void set_VibrationData_WithArgs (Action<VibrationPlayer,  VibrationData> orig, VibrationPlayer self,  VibrationData value);
public sealed class Params_get_Target
{
public VibrationPlayer self;
}
public delegate void get_Target_BeforeArgs(Params_get_Target args);
public delegate VibrationTarget get_Target_AfterArgs(Params_get_Target args, VibrationTarget ret);
public delegate VibrationTarget get_Target_WithArgs (Func<VibrationPlayer, VibrationTarget> orig, VibrationPlayer self);
public sealed class Params_set_Target
{
public VibrationPlayer self;
public VibrationTarget value;
}
public delegate void set_Target_BeforeArgs(Params_set_Target args);
public delegate void set_Target_AfterArgs(Params_set_Target args);
public delegate void set_Target_WithArgs (Action<VibrationPlayer,  VibrationTarget> orig, VibrationPlayer self,  VibrationTarget value);
public sealed class Params_get_PlayAutomatically
{
public VibrationPlayer self;
}
public delegate void get_PlayAutomatically_BeforeArgs(Params_get_PlayAutomatically args);
public delegate bool get_PlayAutomatically_AfterArgs(Params_get_PlayAutomatically args, bool ret);
public delegate bool get_PlayAutomatically_WithArgs (Func<VibrationPlayer, bool> orig, VibrationPlayer self);
public sealed class Params_set_PlayAutomatically
{
public VibrationPlayer self;
public bool value;
}
public delegate void set_PlayAutomatically_BeforeArgs(Params_set_PlayAutomatically args);
public delegate void set_PlayAutomatically_AfterArgs(Params_set_PlayAutomatically args);
public delegate void set_PlayAutomatically_WithArgs (Action<VibrationPlayer,  bool> orig, VibrationPlayer self,  bool value);
public sealed class Params_get_IsLooping
{
public VibrationPlayer self;
}
public delegate void get_IsLooping_BeforeArgs(Params_get_IsLooping args);
public delegate bool get_IsLooping_AfterArgs(Params_get_IsLooping args, bool ret);
public delegate bool get_IsLooping_WithArgs (Func<VibrationPlayer, bool> orig, VibrationPlayer self);
public sealed class Params_set_IsLooping
{
public VibrationPlayer self;
public bool value;
}
public delegate void set_IsLooping_BeforeArgs(Params_set_IsLooping args);
public delegate void set_IsLooping_AfterArgs(Params_set_IsLooping args);
public delegate void set_IsLooping_WithArgs (Action<VibrationPlayer,  bool> orig, VibrationPlayer self,  bool value);
public sealed class Params_get_VibrationTag
{
public VibrationPlayer self;
}
public delegate void get_VibrationTag_BeforeArgs(Params_get_VibrationTag args);
public delegate string get_VibrationTag_AfterArgs(Params_get_VibrationTag args, string ret);
public delegate string get_VibrationTag_WithArgs (Func<VibrationPlayer, string> orig, VibrationPlayer self);
public sealed class Params_set_VibrationTag
{
public VibrationPlayer self;
public string value;
}
public delegate void set_VibrationTag_BeforeArgs(Params_set_VibrationTag args);
public delegate void set_VibrationTag_AfterArgs(Params_set_VibrationTag args);
public delegate void set_VibrationTag_WithArgs (Action<VibrationPlayer,  string> orig, VibrationPlayer self,  string value);
public sealed class Params_OnEnable
{
public VibrationPlayer self;
}
public delegate void OnEnable_BeforeArgs(Params_OnEnable args);
public delegate void OnEnable_AfterArgs(Params_OnEnable args);
public delegate void OnEnable_WithArgs (Action<VibrationPlayer> orig, VibrationPlayer self);
public sealed class Params_OnDisable
{
public VibrationPlayer self;
}
public delegate void OnDisable_BeforeArgs(Params_OnDisable args);
public delegate void OnDisable_AfterArgs(Params_OnDisable args);
public delegate void OnDisable_WithArgs (Action<VibrationPlayer> orig, VibrationPlayer self);
public sealed class Params_Play
{
public VibrationPlayer self;
}
public delegate void Play_BeforeArgs(Params_Play args);
public delegate void Play_AfterArgs(Params_Play args);
public delegate void Play_WithArgs (Action<VibrationPlayer> orig, VibrationPlayer self);
public sealed class Params_Stop
{
public VibrationPlayer self;
}
public delegate void Stop_BeforeArgs(Params_Stop args);
public delegate void Stop_AfterArgs(Params_Stop args);
public delegate void Stop_WithArgs (Action<VibrationPlayer> orig, VibrationPlayer self);
}

/// <summary>
/// Contains Hooks to that run code before orig(self) is called
/// </summary>
public static class BeforeOrig
{
public static event Delegates.get_VibrationData_BeforeArgs get_VibrationData
{
add
{

HookHandler._beforeget_VibrationData += value;
HookHandler.Hookget_VibrationData();
}
remove => HookHandler._beforeget_VibrationData -= value;
}
public static event Delegates.set_VibrationData_BeforeArgs set_VibrationData
{
add
{

HookHandler._beforeset_VibrationData += value;
HookHandler.Hookset_VibrationData();
}
remove => HookHandler._beforeset_VibrationData -= value;
}
public static event Delegates.get_Target_BeforeArgs get_Target
{
add
{

HookHandler._beforeget_Target += value;
HookHandler.Hookget_Target();
}
remove => HookHandler._beforeget_Target -= value;
}
public static event Delegates.set_Target_BeforeArgs set_Target
{
add
{

HookHandler._beforeset_Target += value;
HookHandler.Hookset_Target();
}
remove => HookHandler._beforeset_Target -= value;
}
public static event Delegates.get_PlayAutomatically_BeforeArgs get_PlayAutomatically
{
add
{

HookHandler._beforeget_PlayAutomatically += value;
HookHandler.Hookget_PlayAutomatically();
}
remove => HookHandler._beforeget_PlayAutomatically -= value;
}
public static event Delegates.set_PlayAutomatically_BeforeArgs set_PlayAutomatically
{
add
{

HookHandler._beforeset_PlayAutomatically += value;
HookHandler.Hookset_PlayAutomatically();
}
remove => HookHandler._beforeset_PlayAutomatically -= value;
}
public static event Delegates.get_IsLooping_BeforeArgs get_IsLooping
{
add
{

HookHandler._beforeget_IsLooping += value;
HookHandler.Hookget_IsLooping();
}
remove => HookHandler._beforeget_IsLooping -= value;
}
public static event Delegates.set_IsLooping_BeforeArgs set_IsLooping
{
add
{

HookHandler._beforeset_IsLooping += value;
HookHandler.Hookset_IsLooping();
}
remove => HookHandler._beforeset_IsLooping -= value;
}
public static event Delegates.get_VibrationTag_BeforeArgs get_VibrationTag
{
add
{

HookHandler._beforeget_VibrationTag += value;
HookHandler.Hookget_VibrationTag();
}
remove => HookHandler._beforeget_VibrationTag -= value;
}
public static event Delegates.set_VibrationTag_BeforeArgs set_VibrationTag
{
add
{

HookHandler._beforeset_VibrationTag += value;
HookHandler.Hookset_VibrationTag();
}
remove => HookHandler._beforeset_VibrationTag -= value;
}
public static event Delegates.OnEnable_BeforeArgs OnEnable
{
add
{

HookHandler._beforeOnEnable += value;
HookHandler.HookOnEnable();
}
remove => HookHandler._beforeOnEnable -= value;
}
public static event Delegates.OnDisable_BeforeArgs OnDisable
{
add
{

HookHandler._beforeOnDisable += value;
HookHandler.HookOnDisable();
}
remove => HookHandler._beforeOnDisable -= value;
}
public static event Delegates.Play_BeforeArgs Play
{
add
{

HookHandler._beforePlay += value;
HookHandler.HookPlay();
}
remove => HookHandler._beforePlay -= value;
}
public static event Delegates.Stop_BeforeArgs Stop
{
add
{

HookHandler._beforeStop += value;
HookHandler.HookStop();
}
remove => HookHandler._beforeStop -= value;
}
}

/// <summary>
/// Contains Hooks to that run code after orig(self) is called
/// </summary>
public static class AfterOrig
{
public static event Delegates.get_VibrationData_AfterArgs get_VibrationData
{
add
{

HookHandler._afterget_VibrationData += value;
HookHandler.Hookget_VibrationData();
}
remove => HookHandler._afterget_VibrationData -= value;
}
public static event Delegates.set_VibrationData_AfterArgs set_VibrationData
{
add
{

HookHandler._afterset_VibrationData += value;
HookHandler.Hookset_VibrationData();
}
remove => HookHandler._afterset_VibrationData -= value;
}
public static event Delegates.get_Target_AfterArgs get_Target
{
add
{

HookHandler._afterget_Target += value;
HookHandler.Hookget_Target();
}
remove => HookHandler._afterget_Target -= value;
}
public static event Delegates.set_Target_AfterArgs set_Target
{
add
{

HookHandler._afterset_Target += value;
HookHandler.Hookset_Target();
}
remove => HookHandler._afterset_Target -= value;
}
public static event Delegates.get_PlayAutomatically_AfterArgs get_PlayAutomatically
{
add
{

HookHandler._afterget_PlayAutomatically += value;
HookHandler.Hookget_PlayAutomatically();
}
remove => HookHandler._afterget_PlayAutomatically -= value;
}
public static event Delegates.set_PlayAutomatically_AfterArgs set_PlayAutomatically
{
add
{

HookHandler._afterset_PlayAutomatically += value;
HookHandler.Hookset_PlayAutomatically();
}
remove => HookHandler._afterset_PlayAutomatically -= value;
}
public static event Delegates.get_IsLooping_AfterArgs get_IsLooping
{
add
{

HookHandler._afterget_IsLooping += value;
HookHandler.Hookget_IsLooping();
}
remove => HookHandler._afterget_IsLooping -= value;
}
public static event Delegates.set_IsLooping_AfterArgs set_IsLooping
{
add
{

HookHandler._afterset_IsLooping += value;
HookHandler.Hookset_IsLooping();
}
remove => HookHandler._afterset_IsLooping -= value;
}
public static event Delegates.get_VibrationTag_AfterArgs get_VibrationTag
{
add
{

HookHandler._afterget_VibrationTag += value;
HookHandler.Hookget_VibrationTag();
}
remove => HookHandler._afterget_VibrationTag -= value;
}
public static event Delegates.set_VibrationTag_AfterArgs set_VibrationTag
{
add
{

HookHandler._afterset_VibrationTag += value;
HookHandler.Hookset_VibrationTag();
}
remove => HookHandler._afterset_VibrationTag -= value;
}
public static event Delegates.OnEnable_AfterArgs OnEnable
{
add
{

HookHandler._afterOnEnable += value;
HookHandler.HookOnEnable();
}
remove => HookHandler._afterOnEnable -= value;
}
public static event Delegates.OnDisable_AfterArgs OnDisable
{
add
{

HookHandler._afterOnDisable += value;
HookHandler.HookOnDisable();
}
remove => HookHandler._afterOnDisable -= value;
}
public static event Delegates.Play_AfterArgs Play
{
add
{

HookHandler._afterPlay += value;
HookHandler.HookPlay();
}
remove => HookHandler._afterPlay -= value;
}
public static event Delegates.Stop_AfterArgs Stop
{
add
{

HookHandler._afterStop += value;
HookHandler.HookStop();
}
remove => HookHandler._afterStop -= value;
}
}

/// <summary>
/// Contains all On Hooks, even those that aren't in the On namespace such as API generated functions and property getters/setters
/// </summary>
public static class WithOrig
{
public static event Delegates.get_VibrationData_WithArgs get_VibrationData
{
add => HookEndpointManager.Add<Delegates.get_VibrationData_WithArgs>(ReflectionHelper.GetMethodInfo(typeof(VibrationPlayer), "get_VibrationData", true), value);
remove => HookEndpointManager.Remove<Delegates.get_VibrationData_WithArgs>(ReflectionHelper.GetMethodInfo(typeof(VibrationPlayer), "get_VibrationData", true), value);
}
public static event Delegates.set_VibrationData_WithArgs set_VibrationData
{
add => HookEndpointManager.Add<Delegates.set_VibrationData_WithArgs>(ReflectionHelper.GetMethodInfo(typeof(VibrationPlayer), "set_VibrationData", true), value);
remove => HookEndpointManager.Remove<Delegates.set_VibrationData_WithArgs>(ReflectionHelper.GetMethodInfo(typeof(VibrationPlayer), "set_VibrationData", true), value);
}
public static event Delegates.get_Target_WithArgs get_Target
{
add => HookEndpointManager.Add<Delegates.get_Target_WithArgs>(ReflectionHelper.GetMethodInfo(typeof(VibrationPlayer), "get_Target", true), value);
remove => HookEndpointManager.Remove<Delegates.get_Target_WithArgs>(ReflectionHelper.GetMethodInfo(typeof(VibrationPlayer), "get_Target", true), value);
}
public static event Delegates.set_Target_WithArgs set_Target
{
add => HookEndpointManager.Add<Delegates.set_Target_WithArgs>(ReflectionHelper.GetMethodInfo(typeof(VibrationPlayer), "set_Target", true), value);
remove => HookEndpointManager.Remove<Delegates.set_Target_WithArgs>(ReflectionHelper.GetMethodInfo(typeof(VibrationPlayer), "set_Target", true), value);
}
public static event Delegates.get_PlayAutomatically_WithArgs get_PlayAutomatically
{
add => HookEndpointManager.Add<Delegates.get_PlayAutomatically_WithArgs>(ReflectionHelper.GetMethodInfo(typeof(VibrationPlayer), "get_PlayAutomatically", true), value);
remove => HookEndpointManager.Remove<Delegates.get_PlayAutomatically_WithArgs>(ReflectionHelper.GetMethodInfo(typeof(VibrationPlayer), "get_PlayAutomatically", true), value);
}
public static event Delegates.set_PlayAutomatically_WithArgs set_PlayAutomatically
{
add => HookEndpointManager.Add<Delegates.set_PlayAutomatically_WithArgs>(ReflectionHelper.GetMethodInfo(typeof(VibrationPlayer), "set_PlayAutomatically", true), value);
remove => HookEndpointManager.Remove<Delegates.set_PlayAutomatically_WithArgs>(ReflectionHelper.GetMethodInfo(typeof(VibrationPlayer), "set_PlayAutomatically", true), value);
}
public static event Delegates.get_IsLooping_WithArgs get_IsLooping
{
add => HookEndpointManager.Add<Delegates.get_IsLooping_WithArgs>(ReflectionHelper.GetMethodInfo(typeof(VibrationPlayer), "get_IsLooping", true), value);
remove => HookEndpointManager.Remove<Delegates.get_IsLooping_WithArgs>(ReflectionHelper.GetMethodInfo(typeof(VibrationPlayer), "get_IsLooping", true), value);
}
public static event Delegates.set_IsLooping_WithArgs set_IsLooping
{
add => HookEndpointManager.Add<Delegates.set_IsLooping_WithArgs>(ReflectionHelper.GetMethodInfo(typeof(VibrationPlayer), "set_IsLooping", true), value);
remove => HookEndpointManager.Remove<Delegates.set_IsLooping_WithArgs>(ReflectionHelper.GetMethodInfo(typeof(VibrationPlayer), "set_IsLooping", true), value);
}
public static event Delegates.get_VibrationTag_WithArgs get_VibrationTag
{
add => HookEndpointManager.Add<Delegates.get_VibrationTag_WithArgs>(ReflectionHelper.GetMethodInfo(typeof(VibrationPlayer), "get_VibrationTag", true), value);
remove => HookEndpointManager.Remove<Delegates.get_VibrationTag_WithArgs>(ReflectionHelper.GetMethodInfo(typeof(VibrationPlayer), "get_VibrationTag", true), value);
}
public static event Delegates.set_VibrationTag_WithArgs set_VibrationTag
{
add => HookEndpointManager.Add<Delegates.set_VibrationTag_WithArgs>(ReflectionHelper.GetMethodInfo(typeof(VibrationPlayer), "set_VibrationTag", true), value);
remove => HookEndpointManager.Remove<Delegates.set_VibrationTag_WithArgs>(ReflectionHelper.GetMethodInfo(typeof(VibrationPlayer), "set_VibrationTag", true), value);
}
public static event On.VibrationPlayer.hook_OnEnable OnEnable
{
add => On.VibrationPlayer.OnEnable += value;
remove => On.VibrationPlayer.OnEnable -= value;
}
public static event On.VibrationPlayer.hook_OnDisable OnDisable
{
add => On.VibrationPlayer.OnDisable += value;
remove => On.VibrationPlayer.OnDisable -= value;
}
public static event On.VibrationPlayer.hook_Play Play
{
add => On.VibrationPlayer.Play += value;
remove => On.VibrationPlayer.Play -= value;
}
public static event On.VibrationPlayer.hook_Stop Stop
{
add => On.VibrationPlayer.Stop += value;
remove => On.VibrationPlayer.Stop -= value;
}
}

}
