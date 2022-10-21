using MonoMod.RuntimeDetour;
using MonoMod.RuntimeDetour.HookGen;
namespace HKMirror.Hooks.OnHooks;
/// <summary>
/// Contains different types of On Hooks for tk2dSpriteSheetSource class.<br />
/// Contains hooks that aren't generated by monomod, and before and after orig hooks for easier hooking.
/// </summary>
public static class Ontk2dSpriteSheetSource
{
internal static class HookHandler
{
private static List<string> HookedList = new List<string>();
internal static void HookCopyFrom()
{
if (!HookedList.Contains("CopyFrom"))
{
HookedList.Add("CopyFrom");
On.tk2dSpriteSheetSource.CopyFrom += CopyFrom;

}
}
internal static event Delegates.CopyFrom_BeforeArgs _beforeCopyFrom;
internal static event Delegates.CopyFrom_AfterArgs _afterCopyFrom;
private static void CopyFrom(On.tk2dSpriteSheetSource.orig_CopyFrom orig,tk2dSpriteSheetSource self,  tk2dSpriteSheetSource src)
{
Delegates.Params_CopyFrom @params = new() 
{
self = self
, src = src
};
if (_beforeCopyFrom != null)
{
foreach (Delegates.CopyFrom_BeforeArgs toInvoke in _beforeCopyFrom.GetInvocationList())
{
try
{
_beforeCopyFrom?.Invoke(@params);
}
catch (Exception e) 
{ HKMirrorMod.DoLogError(e);
}
}
}
self = @params.self;
src = @params.src;
orig(self, src);
if (_afterCopyFrom != null)
{
foreach (Delegates.CopyFrom_AfterArgs toInvoke in _afterCopyFrom.GetInvocationList())
{
try
{
_afterCopyFrom.Invoke(@params);
}
catch (Exception e) 
{ HKMirrorMod.DoLogError(e);
}
}
}
}
internal static void HookCompareTo()
{
if (!HookedList.Contains("CompareTo"))
{
HookedList.Add("CompareTo");
On.tk2dSpriteSheetSource.CompareTo += CompareTo;

}
}
internal static event Delegates.CompareTo_BeforeArgs _beforeCompareTo;
internal static event Delegates.CompareTo_AfterArgs _afterCompareTo;
private static bool CompareTo(On.tk2dSpriteSheetSource.orig_CompareTo orig,tk2dSpriteSheetSource self,  tk2dSpriteSheetSource src)
{
Delegates.Params_CompareTo @params = new() 
{
self = self
, src = src
};
if (_beforeCompareTo != null)
{
foreach (Delegates.CompareTo_BeforeArgs toInvoke in _beforeCompareTo.GetInvocationList())
{
try
{
_beforeCompareTo?.Invoke(@params);
}
catch (Exception e) 
{ HKMirrorMod.DoLogError(e);
}
}
}
self = @params.self;
src = @params.src;
var retVal = orig(self, src);
if (_afterCompareTo != null)
{
foreach (Delegates.CompareTo_AfterArgs toInvoke in _afterCompareTo.GetInvocationList())
{
try
{
retVal = _afterCompareTo.Invoke(@params, retVal);
}
catch (Exception e) 
{ HKMirrorMod.DoLogError(e);
}
}
}
return retVal;
}
internal static void Hookget_Name()
{
if (!HookedList.Contains("get_Name"))
{
HookedList.Add("get_Name");
new Hook(ReflectionHelper.GetMethodInfo(typeof(tk2dSpriteSheetSource), "get_Name", true), get_Name);

}
}
internal static event Delegates.get_Name_BeforeArgs _beforeget_Name;
internal static event Delegates.get_Name_AfterArgs _afterget_Name;
private static string get_Name(Func<tk2dSpriteSheetSource, string> orig, tk2dSpriteSheetSource self)
{
Delegates.Params_get_Name @params = new() 
{
self = self
};
if (_beforeget_Name != null)
{
foreach (Delegates.get_Name_BeforeArgs toInvoke in _beforeget_Name.GetInvocationList())
{
try
{
_beforeget_Name?.Invoke(@params);
}
catch (Exception e) 
{ HKMirrorMod.DoLogError(e);
}
}
}
self = @params.self;
var retVal = orig(self);
if (_afterget_Name != null)
{
foreach (Delegates.get_Name_AfterArgs toInvoke in _afterget_Name.GetInvocationList())
{
try
{
retVal = _afterget_Name.Invoke(@params, retVal);
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
public sealed class Params_CopyFrom
{
public tk2dSpriteSheetSource self;
public tk2dSpriteSheetSource src;
}
public delegate void CopyFrom_BeforeArgs(Params_CopyFrom args);
public delegate void CopyFrom_AfterArgs(Params_CopyFrom args);
public delegate void CopyFrom_WithArgs (Action<tk2dSpriteSheetSource,  tk2dSpriteSheetSource> orig, tk2dSpriteSheetSource self,  tk2dSpriteSheetSource src);
public sealed class Params_CompareTo
{
public tk2dSpriteSheetSource self;
public tk2dSpriteSheetSource src;
}
public delegate void CompareTo_BeforeArgs(Params_CompareTo args);
public delegate bool CompareTo_AfterArgs(Params_CompareTo args, bool ret);
public delegate bool CompareTo_WithArgs (Func<tk2dSpriteSheetSource,  tk2dSpriteSheetSource, bool> orig, tk2dSpriteSheetSource self,  tk2dSpriteSheetSource src);
public sealed class Params_get_Name
{
public tk2dSpriteSheetSource self;
}
public delegate void get_Name_BeforeArgs(Params_get_Name args);
public delegate string get_Name_AfterArgs(Params_get_Name args, string ret);
public delegate string get_Name_WithArgs (Func<tk2dSpriteSheetSource, string> orig, tk2dSpriteSheetSource self);
}

/// <summary>
/// Contains Hooks to that run code before orig(self) is called
/// </summary>
public static class BeforeOrig
{
public static event Delegates.CopyFrom_BeforeArgs CopyFrom
{
add
{

HookHandler._beforeCopyFrom += value;
HookHandler.HookCopyFrom();
}
remove => HookHandler._beforeCopyFrom -= value;
}
public static event Delegates.CompareTo_BeforeArgs CompareTo
{
add
{

HookHandler._beforeCompareTo += value;
HookHandler.HookCompareTo();
}
remove => HookHandler._beforeCompareTo -= value;
}
public static event Delegates.get_Name_BeforeArgs get_Name
{
add
{

HookHandler._beforeget_Name += value;
HookHandler.Hookget_Name();
}
remove => HookHandler._beforeget_Name -= value;
}
}

/// <summary>
/// Contains Hooks to that run code after orig(self) is called
/// </summary>
public static class AfterOrig
{
public static event Delegates.CopyFrom_AfterArgs CopyFrom
{
add
{

HookHandler._afterCopyFrom += value;
HookHandler.HookCopyFrom();
}
remove => HookHandler._afterCopyFrom -= value;
}
public static event Delegates.CompareTo_AfterArgs CompareTo
{
add
{

HookHandler._afterCompareTo += value;
HookHandler.HookCompareTo();
}
remove => HookHandler._afterCompareTo -= value;
}
public static event Delegates.get_Name_AfterArgs get_Name
{
add
{

HookHandler._afterget_Name += value;
HookHandler.Hookget_Name();
}
remove => HookHandler._afterget_Name -= value;
}
}

/// <summary>
/// Contains all On Hooks, even those that aren't in the On namespace such as API generated functions and property getters/setters
/// </summary>
public static class WithOrig
{
public static event On.tk2dSpriteSheetSource.hook_CopyFrom CopyFrom
{
add => On.tk2dSpriteSheetSource.CopyFrom += value;
remove => On.tk2dSpriteSheetSource.CopyFrom -= value;
}
public static event On.tk2dSpriteSheetSource.hook_CompareTo CompareTo
{
add => On.tk2dSpriteSheetSource.CompareTo += value;
remove => On.tk2dSpriteSheetSource.CompareTo -= value;
}
public static event Delegates.get_Name_WithArgs get_Name
{
add => HookEndpointManager.Add<Delegates.get_Name_WithArgs>(ReflectionHelper.GetMethodInfo(typeof(tk2dSpriteSheetSource), "get_Name", true), value);
remove => HookEndpointManager.Remove<Delegates.get_Name_WithArgs>(ReflectionHelper.GetMethodInfo(typeof(tk2dSpriteSheetSource), "get_Name", true), value);
}
}

}
