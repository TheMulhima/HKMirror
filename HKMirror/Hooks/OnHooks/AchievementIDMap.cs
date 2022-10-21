using MonoMod.RuntimeDetour;
using MonoMod.RuntimeDetour.HookGen;
namespace HKMirror.Hooks.OnHooks;
/// <summary>
/// Contains different types of On Hooks for AchievementIDMap class.<br />
/// Contains hooks that aren't generated by monomod, and before and after orig hooks for easier hooking.
/// </summary>
public static class OnAchievementIDMap
{
internal static class HookHandler
{
private static List<string> HookedList = new List<string>();
internal static void HookGetServiceIdForInternalId()
{
if (!HookedList.Contains("GetServiceIdForInternalId"))
{
HookedList.Add("GetServiceIdForInternalId");
On.AchievementIDMap.GetServiceIdForInternalId += GetServiceIdForInternalId;

}
}
internal static event Delegates.GetServiceIdForInternalId_BeforeArgs _beforeGetServiceIdForInternalId;
internal static event Delegates.GetServiceIdForInternalId_AfterArgs _afterGetServiceIdForInternalId;
private static int? GetServiceIdForInternalId(On.AchievementIDMap.orig_GetServiceIdForInternalId orig,AchievementIDMap self,  string internalId)
{
Delegates.Params_GetServiceIdForInternalId @params = new() 
{
self = self
, internalId = internalId
};
if (_beforeGetServiceIdForInternalId != null)
{
foreach (Delegates.GetServiceIdForInternalId_BeforeArgs toInvoke in _beforeGetServiceIdForInternalId.GetInvocationList())
{
try
{
_beforeGetServiceIdForInternalId?.Invoke(@params);
}
catch (Exception e) 
{ HKMirrorMod.DoLogError(e);
}
}
}
self = @params.self;
internalId = @params.internalId;
var retVal = orig(self, internalId);
if (_afterGetServiceIdForInternalId != null)
{
foreach (Delegates.GetServiceIdForInternalId_AfterArgs toInvoke in _afterGetServiceIdForInternalId.GetInvocationList())
{
try
{
retVal = _afterGetServiceIdForInternalId.Invoke(@params, retVal);
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
public sealed class Params_GetServiceIdForInternalId
{
public AchievementIDMap self;
public string internalId;
}
public delegate void GetServiceIdForInternalId_BeforeArgs(Params_GetServiceIdForInternalId args);
public delegate int? GetServiceIdForInternalId_AfterArgs(Params_GetServiceIdForInternalId args, int? ret);
public delegate int? GetServiceIdForInternalId_WithArgs (Func<AchievementIDMap,  string, int?> orig, AchievementIDMap self,  string internalId);
}

/// <summary>
/// Contains Hooks to that run code before orig(self) is called
/// </summary>
public static class BeforeOrig
{
public static event Delegates.GetServiceIdForInternalId_BeforeArgs GetServiceIdForInternalId
{
add
{

HookHandler._beforeGetServiceIdForInternalId += value;
HookHandler.HookGetServiceIdForInternalId();
}
remove => HookHandler._beforeGetServiceIdForInternalId -= value;
}
}

/// <summary>
/// Contains Hooks to that run code after orig(self) is called
/// </summary>
public static class AfterOrig
{
public static event Delegates.GetServiceIdForInternalId_AfterArgs GetServiceIdForInternalId
{
add
{

HookHandler._afterGetServiceIdForInternalId += value;
HookHandler.HookGetServiceIdForInternalId();
}
remove => HookHandler._afterGetServiceIdForInternalId -= value;
}
}

/// <summary>
/// Contains all On Hooks, even those that aren't in the On namespace such as API generated functions and property getters/setters
/// </summary>
public static class WithOrig
{
public static event On.AchievementIDMap.hook_GetServiceIdForInternalId GetServiceIdForInternalId
{
add => On.AchievementIDMap.GetServiceIdForInternalId += value;
remove => On.AchievementIDMap.GetServiceIdForInternalId -= value;
}
}

}
