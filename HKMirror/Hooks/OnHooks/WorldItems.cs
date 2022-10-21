using MonoMod.RuntimeDetour;
using MonoMod.RuntimeDetour.HookGen;
namespace HKMirror.Hooks.OnHooks;
/// <summary>
/// Contains different types of On Hooks for WorldItems class.<br />
/// Contains hooks that aren't generated by monomod, and before and after orig hooks for easier hooking.
/// </summary>
public static class OnWorldItems
{
internal static class HookHandler
{
private static List<string> HookedList = new List<string>();
internal static void HookOnEnable()
{
if (!HookedList.Contains("OnEnable"))
{
HookedList.Add("OnEnable");
new Hook(ReflectionHelper.GetMethodInfo(typeof(TeamCherry.WorldItems), "OnEnable", true), OnEnable);

}
}
internal static event Delegates.OnEnable_BeforeArgs _beforeOnEnable;
internal static event Delegates.OnEnable_AfterArgs _afterOnEnable;
private static void OnEnable(Action<TeamCherry.WorldItems> orig, TeamCherry.WorldItems self)
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
internal static void HookRegisterGeoRock()
{
if (!HookedList.Contains("RegisterGeoRock"))
{
HookedList.Add("RegisterGeoRock");
new Hook(ReflectionHelper.GetMethodInfo(typeof(TeamCherry.WorldItems), "RegisterGeoRock", true), RegisterGeoRock);

}
}
internal static event Delegates.RegisterGeoRock_BeforeArgs _beforeRegisterGeoRock;
internal static event Delegates.RegisterGeoRock_AfterArgs _afterRegisterGeoRock;
private static void RegisterGeoRock(Action<TeamCherry.WorldItems> orig, TeamCherry.WorldItems self)
{
Delegates.Params_RegisterGeoRock @params = new() 
{
self = self
};
if (_beforeRegisterGeoRock != null)
{
foreach (Delegates.RegisterGeoRock_BeforeArgs toInvoke in _beforeRegisterGeoRock.GetInvocationList())
{
try
{
_beforeRegisterGeoRock?.Invoke(@params);
}
catch (Exception e) 
{ HKMirrorMod.DoLogError(e);
}
}
}
self = @params.self;
orig(self);
if (_afterRegisterGeoRock != null)
{
foreach (Delegates.RegisterGeoRock_AfterArgs toInvoke in _afterRegisterGeoRock.GetInvocationList())
{
try
{
_afterRegisterGeoRock.Invoke(@params);
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
public sealed class Params_OnEnable
{
public TeamCherry.WorldItems self;
}
public delegate void OnEnable_BeforeArgs(Params_OnEnable args);
public delegate void OnEnable_AfterArgs(Params_OnEnable args);
public delegate void OnEnable_WithArgs (Action<TeamCherry.WorldItems> orig, TeamCherry.WorldItems self);
public sealed class Params_RegisterGeoRock
{
public TeamCherry.WorldItems self;
}
public delegate void RegisterGeoRock_BeforeArgs(Params_RegisterGeoRock args);
public delegate void RegisterGeoRock_AfterArgs(Params_RegisterGeoRock args);
public delegate void RegisterGeoRock_WithArgs (Action<TeamCherry.WorldItems> orig, TeamCherry.WorldItems self);
}

/// <summary>
/// Contains Hooks to that run code before orig(self) is called
/// </summary>
public static class BeforeOrig
{
public static event Delegates.OnEnable_BeforeArgs OnEnable
{
add
{

HookHandler._beforeOnEnable += value;
HookHandler.HookOnEnable();
}
remove => HookHandler._beforeOnEnable -= value;
}
public static event Delegates.RegisterGeoRock_BeforeArgs RegisterGeoRock
{
add
{

HookHandler._beforeRegisterGeoRock += value;
HookHandler.HookRegisterGeoRock();
}
remove => HookHandler._beforeRegisterGeoRock -= value;
}
}

/// <summary>
/// Contains Hooks to that run code after orig(self) is called
/// </summary>
public static class AfterOrig
{
public static event Delegates.OnEnable_AfterArgs OnEnable
{
add
{

HookHandler._afterOnEnable += value;
HookHandler.HookOnEnable();
}
remove => HookHandler._afterOnEnable -= value;
}
public static event Delegates.RegisterGeoRock_AfterArgs RegisterGeoRock
{
add
{

HookHandler._afterRegisterGeoRock += value;
HookHandler.HookRegisterGeoRock();
}
remove => HookHandler._afterRegisterGeoRock -= value;
}
}

/// <summary>
/// Contains all On Hooks, even those that aren't in the On namespace such as API generated functions and property getters/setters
/// </summary>
public static class WithOrig
{
public static event Delegates.OnEnable_WithArgs OnEnable
{
add => HookEndpointManager.Add<Delegates.OnEnable_WithArgs>(ReflectionHelper.GetMethodInfo(typeof(TeamCherry.WorldItems), "OnEnable", true), value);
remove => HookEndpointManager.Remove<Delegates.OnEnable_WithArgs>(ReflectionHelper.GetMethodInfo(typeof(TeamCherry.WorldItems), "OnEnable", true), value);
}
public static event Delegates.RegisterGeoRock_WithArgs RegisterGeoRock
{
add => HookEndpointManager.Add<Delegates.RegisterGeoRock_WithArgs>(ReflectionHelper.GetMethodInfo(typeof(TeamCherry.WorldItems), "RegisterGeoRock", true), value);
remove => HookEndpointManager.Remove<Delegates.RegisterGeoRock_WithArgs>(ReflectionHelper.GetMethodInfo(typeof(TeamCherry.WorldItems), "RegisterGeoRock", true), value);
}
}

}
