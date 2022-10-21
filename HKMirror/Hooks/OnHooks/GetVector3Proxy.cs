using MonoMod.RuntimeDetour;
using MonoMod.RuntimeDetour.HookGen;
namespace HKMirror.Hooks.OnHooks;
/// <summary>
/// Contains different types of On Hooks for GetVector3Proxy class.<br />
/// Contains hooks that aren't generated by monomod, and before and after orig hooks for easier hooking.
/// </summary>
public static class OnGetVector3Proxy
{
internal static class HookHandler
{
private static List<string> HookedList = new List<string>();
internal static void HookInvoke()
{
if (!HookedList.Contains("Invoke"))
{
HookedList.Add("Invoke");
new Hook(ReflectionHelper.GetMethodInfo(typeof(Modding.Delegates.GetVector3Proxy), "Invoke", true), Invoke);

}
}
internal static event Delegates.Invoke_BeforeArgs _beforeInvoke;
internal static event Delegates.Invoke_AfterArgs _afterInvoke;
private static UnityEngine.Vector3 Invoke(Func<Modding.Delegates.GetVector3Proxy,  string,  UnityEngine.Vector3, UnityEngine.Vector3> orig, Modding.Delegates.GetVector3Proxy self,  string name,  UnityEngine.Vector3 orig_)
{
Delegates.Params_Invoke @params = new() 
{
self = self
, name = name
, orig_ = orig_
};
if (_beforeInvoke != null)
{
foreach (Delegates.Invoke_BeforeArgs toInvoke in _beforeInvoke.GetInvocationList())
{
try
{
_beforeInvoke?.Invoke(@params);
}
catch (Exception e) 
{ HKMirrorMod.DoLogError(e);
}
}
}
self = @params.self;
name = @params.name;
orig_ = @params.orig_;
var retVal = orig(self, name, orig_);
if (_afterInvoke != null)
{
foreach (Delegates.Invoke_AfterArgs toInvoke in _afterInvoke.GetInvocationList())
{
try
{
retVal = _afterInvoke.Invoke(@params, retVal);
}
catch (Exception e) 
{ HKMirrorMod.DoLogError(e);
}
}
}
return retVal;
}
internal static void HookEndInvoke()
{
if (!HookedList.Contains("EndInvoke"))
{
HookedList.Add("EndInvoke");
new Hook(ReflectionHelper.GetMethodInfo(typeof(Modding.Delegates.GetVector3Proxy), "EndInvoke", true), EndInvoke);

}
}
internal static event Delegates.EndInvoke_BeforeArgs _beforeEndInvoke;
internal static event Delegates.EndInvoke_AfterArgs _afterEndInvoke;
private static UnityEngine.Vector3 EndInvoke(Func<Modding.Delegates.GetVector3Proxy,  System.IAsyncResult, UnityEngine.Vector3> orig, Modding.Delegates.GetVector3Proxy self,  System.IAsyncResult result)
{
Delegates.Params_EndInvoke @params = new() 
{
self = self
, result = result
};
if (_beforeEndInvoke != null)
{
foreach (Delegates.EndInvoke_BeforeArgs toInvoke in _beforeEndInvoke.GetInvocationList())
{
try
{
_beforeEndInvoke?.Invoke(@params);
}
catch (Exception e) 
{ HKMirrorMod.DoLogError(e);
}
}
}
self = @params.self;
result = @params.result;
var retVal = orig(self, result);
if (_afterEndInvoke != null)
{
foreach (Delegates.EndInvoke_AfterArgs toInvoke in _afterEndInvoke.GetInvocationList())
{
try
{
retVal = _afterEndInvoke.Invoke(@params, retVal);
}
catch (Exception e) 
{ HKMirrorMod.DoLogError(e);
}
}
}
return retVal;
}
}

/// <summary>
/// Contains necessary information to create Hooks. Does not contain any hooks
/// </summary>
public static class Delegates
{
public sealed class Params_Invoke
{
public Modding.Delegates.GetVector3Proxy self;
public string name;
public UnityEngine.Vector3 orig_;
}
public delegate void Invoke_BeforeArgs(Params_Invoke args);
public delegate UnityEngine.Vector3 Invoke_AfterArgs(Params_Invoke args, UnityEngine.Vector3 ret);
public delegate UnityEngine.Vector3 Invoke_WithArgs (Func<Modding.Delegates.GetVector3Proxy,  string,  UnityEngine.Vector3, UnityEngine.Vector3> orig, Modding.Delegates.GetVector3Proxy self,  string name,  UnityEngine.Vector3 orig_);
public sealed class Params_EndInvoke
{
public Modding.Delegates.GetVector3Proxy self;
public System.IAsyncResult result;
}
public delegate void EndInvoke_BeforeArgs(Params_EndInvoke args);
public delegate UnityEngine.Vector3 EndInvoke_AfterArgs(Params_EndInvoke args, UnityEngine.Vector3 ret);
public delegate UnityEngine.Vector3 EndInvoke_WithArgs (Func<Modding.Delegates.GetVector3Proxy,  System.IAsyncResult, UnityEngine.Vector3> orig, Modding.Delegates.GetVector3Proxy self,  System.IAsyncResult result);
}

/// <summary>
/// Contains Hooks to that run code before orig(self) is called
/// </summary>
public static class BeforeOrig
{
public static event Delegates.Invoke_BeforeArgs Invoke
{
add
{

HookHandler._beforeInvoke += value;
HookHandler.HookInvoke();
}
remove => HookHandler._beforeInvoke -= value;
}
public static event Delegates.EndInvoke_BeforeArgs EndInvoke
{
add
{

HookHandler._beforeEndInvoke += value;
HookHandler.HookEndInvoke();
}
remove => HookHandler._beforeEndInvoke -= value;
}
}

/// <summary>
/// Contains Hooks to that run code after orig(self) is called
/// </summary>
public static class AfterOrig
{
public static event Delegates.Invoke_AfterArgs Invoke
{
add
{

HookHandler._afterInvoke += value;
HookHandler.HookInvoke();
}
remove => HookHandler._afterInvoke -= value;
}
public static event Delegates.EndInvoke_AfterArgs EndInvoke
{
add
{

HookHandler._afterEndInvoke += value;
HookHandler.HookEndInvoke();
}
remove => HookHandler._afterEndInvoke -= value;
}
}

/// <summary>
/// Contains all On Hooks, even those that aren't in the On namespace such as API generated functions and property getters/setters
/// </summary>
public static class WithOrig
{
public static event Delegates.Invoke_WithArgs Invoke
{
add => HookEndpointManager.Add<Delegates.Invoke_WithArgs>(ReflectionHelper.GetMethodInfo(typeof(Modding.Delegates.GetVector3Proxy), "Invoke", true), value);
remove => HookEndpointManager.Remove<Delegates.Invoke_WithArgs>(ReflectionHelper.GetMethodInfo(typeof(Modding.Delegates.GetVector3Proxy), "Invoke", true), value);
}
public static event Delegates.EndInvoke_WithArgs EndInvoke
{
add => HookEndpointManager.Add<Delegates.EndInvoke_WithArgs>(ReflectionHelper.GetMethodInfo(typeof(Modding.Delegates.GetVector3Proxy), "EndInvoke", true), value);
remove => HookEndpointManager.Remove<Delegates.EndInvoke_WithArgs>(ReflectionHelper.GetMethodInfo(typeof(Modding.Delegates.GetVector3Proxy), "EndInvoke", true), value);
}
}

}
