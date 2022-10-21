using MonoMod.RuntimeDetour;
using MonoMod.RuntimeDetour.HookGen;
namespace HKMirror.Hooks.OnHooks;
/// <summary>
/// Contains different types of On Hooks for tk2dSpriteCollectionDefinition class.<br />
/// Contains hooks that aren't generated by monomod, and before and after orig hooks for easier hooking.
/// </summary>
public static class Ontk2dSpriteCollectionDefinition
{
internal static class HookHandler
{
private static List<string> HookedList = new List<string>();
internal static void HookCopyFrom()
{
if (!HookedList.Contains("CopyFrom"))
{
HookedList.Add("CopyFrom");
On.tk2dSpriteCollectionDefinition.CopyFrom += CopyFrom;

}
}
internal static event Delegates.CopyFrom_BeforeArgs _beforeCopyFrom;
internal static event Delegates.CopyFrom_AfterArgs _afterCopyFrom;
private static void CopyFrom(On.tk2dSpriteCollectionDefinition.orig_CopyFrom orig,tk2dSpriteCollectionDefinition self,  tk2dSpriteCollectionDefinition src)
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
internal static void HookClear()
{
if (!HookedList.Contains("Clear"))
{
HookedList.Add("Clear");
On.tk2dSpriteCollectionDefinition.Clear += Clear;

}
}
internal static event Delegates.Clear_BeforeArgs _beforeClear;
internal static event Delegates.Clear_AfterArgs _afterClear;
private static void Clear(On.tk2dSpriteCollectionDefinition.orig_Clear orig,tk2dSpriteCollectionDefinition self)
{
Delegates.Params_Clear @params = new() 
{
self = self
};
if (_beforeClear != null)
{
foreach (Delegates.Clear_BeforeArgs toInvoke in _beforeClear.GetInvocationList())
{
try
{
_beforeClear?.Invoke(@params);
}
catch (Exception e) 
{ HKMirrorMod.DoLogError(e);
}
}
}
self = @params.self;
orig(self);
if (_afterClear != null)
{
foreach (Delegates.Clear_AfterArgs toInvoke in _afterClear.GetInvocationList())
{
try
{
_afterClear.Invoke(@params);
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
On.tk2dSpriteCollectionDefinition.CompareTo += CompareTo;

}
}
internal static event Delegates.CompareTo_BeforeArgs _beforeCompareTo;
internal static event Delegates.CompareTo_AfterArgs _afterCompareTo;
private static bool CompareTo(On.tk2dSpriteCollectionDefinition.orig_CompareTo orig,tk2dSpriteCollectionDefinition self,  tk2dSpriteCollectionDefinition src)
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
}

/// <summary>
/// Contains necessary information to create Hooks. Does not contain any hooks
/// </summary>
public static class Delegates
{
public sealed class Params_CopyFrom
{
public tk2dSpriteCollectionDefinition self;
public tk2dSpriteCollectionDefinition src;
}
public delegate void CopyFrom_BeforeArgs(Params_CopyFrom args);
public delegate void CopyFrom_AfterArgs(Params_CopyFrom args);
public delegate void CopyFrom_WithArgs (Action<tk2dSpriteCollectionDefinition,  tk2dSpriteCollectionDefinition> orig, tk2dSpriteCollectionDefinition self,  tk2dSpriteCollectionDefinition src);
public sealed class Params_Clear
{
public tk2dSpriteCollectionDefinition self;
}
public delegate void Clear_BeforeArgs(Params_Clear args);
public delegate void Clear_AfterArgs(Params_Clear args);
public delegate void Clear_WithArgs (Action<tk2dSpriteCollectionDefinition> orig, tk2dSpriteCollectionDefinition self);
public sealed class Params_CompareTo
{
public tk2dSpriteCollectionDefinition self;
public tk2dSpriteCollectionDefinition src;
}
public delegate void CompareTo_BeforeArgs(Params_CompareTo args);
public delegate bool CompareTo_AfterArgs(Params_CompareTo args, bool ret);
public delegate bool CompareTo_WithArgs (Func<tk2dSpriteCollectionDefinition,  tk2dSpriteCollectionDefinition, bool> orig, tk2dSpriteCollectionDefinition self,  tk2dSpriteCollectionDefinition src);
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
public static event Delegates.Clear_BeforeArgs Clear
{
add
{

HookHandler._beforeClear += value;
HookHandler.HookClear();
}
remove => HookHandler._beforeClear -= value;
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
public static event Delegates.Clear_AfterArgs Clear
{
add
{

HookHandler._afterClear += value;
HookHandler.HookClear();
}
remove => HookHandler._afterClear -= value;
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
}

/// <summary>
/// Contains all On Hooks, even those that aren't in the On namespace such as API generated functions and property getters/setters
/// </summary>
public static class WithOrig
{
public static event On.tk2dSpriteCollectionDefinition.hook_CopyFrom CopyFrom
{
add => On.tk2dSpriteCollectionDefinition.CopyFrom += value;
remove => On.tk2dSpriteCollectionDefinition.CopyFrom -= value;
}
public static event On.tk2dSpriteCollectionDefinition.hook_Clear Clear
{
add => On.tk2dSpriteCollectionDefinition.Clear += value;
remove => On.tk2dSpriteCollectionDefinition.Clear -= value;
}
public static event On.tk2dSpriteCollectionDefinition.hook_CompareTo CompareTo
{
add => On.tk2dSpriteCollectionDefinition.CompareTo += value;
remove => On.tk2dSpriteCollectionDefinition.CompareTo -= value;
}
}

}
