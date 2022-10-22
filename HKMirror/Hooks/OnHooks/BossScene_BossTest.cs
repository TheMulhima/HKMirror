using MonoMod.RuntimeDetour;
using MonoMod.RuntimeDetour.HookGen;
namespace HKMirror.Hooks.OnHooks;
/// <summary>
/// Contains different types of On Hooks for BossScene_BossTest class.<br />
/// Contains hooks that aren't generated by monomod, and before and after orig hooks for easier hooking.
/// </summary>
public static class OnBossScene_BossTest
{
internal static class HookHandler
{
private static List<string> HookedList = new List<string>();
internal static void HookIsUnlocked()
{
if (!HookedList.Contains("IsUnlocked"))
{
HookedList.Add("IsUnlocked");
new Hook(ReflectionHelper.GetMethodInfo(typeof(BossScene.BossTest), "IsUnlocked", true), IsUnlocked);

}
}
internal static event Delegates.IsUnlocked_BeforeArgs _beforeIsUnlocked;
internal static event Delegates.IsUnlocked_AfterArgs _afterIsUnlocked;
private static bool IsUnlocked(Func<BossScene.BossTest, bool> orig, BossScene.BossTest self)
{
Delegates.Params_IsUnlocked @params = new() 
{
self = self
};
if (_beforeIsUnlocked != null)
{
foreach (Delegates.IsUnlocked_BeforeArgs toInvoke in _beforeIsUnlocked.GetInvocationList())
{
try
{
_beforeIsUnlocked?.Invoke(@params);
}
catch (Exception e) 
{ HKMirrorMod.DoLogError(e);
}
}
}
self = @params.self;
var retVal = orig(self);
if (_afterIsUnlocked != null)
{
foreach (Delegates.IsUnlocked_AfterArgs toInvoke in _afterIsUnlocked.GetInvocationList())
{
try
{
retVal = _afterIsUnlocked.Invoke(@params, retVal);
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
public sealed class Params_IsUnlocked
{
public BossScene.BossTest self;
}
public delegate void IsUnlocked_BeforeArgs(Params_IsUnlocked args);
public delegate bool IsUnlocked_AfterArgs(Params_IsUnlocked args, bool ret);
public delegate bool IsUnlocked_WithArgs (Func<BossScene.BossTest, bool> orig, BossScene.BossTest self);
}

/// <summary>
/// Contains Hooks to that run code before orig(self) is called
/// </summary>
public static class BeforeOrig
{
public static event Delegates.IsUnlocked_BeforeArgs IsUnlocked
{
add
{

HookHandler._beforeIsUnlocked += value;
HookHandler.HookIsUnlocked();
}
remove => HookHandler._beforeIsUnlocked -= value;
}
}

/// <summary>
/// Contains Hooks to that run code after orig(self) is called
/// </summary>
public static class AfterOrig
{
public static event Delegates.IsUnlocked_AfterArgs IsUnlocked
{
add
{

HookHandler._afterIsUnlocked += value;
HookHandler.HookIsUnlocked();
}
remove => HookHandler._afterIsUnlocked -= value;
}
}

/// <summary>
/// Contains all On Hooks, even those that aren't in the On namespace such as API generated functions and property getters/setters
/// </summary>
public static class WithOrig
{
public static event Delegates.IsUnlocked_WithArgs IsUnlocked
{
add => HookEndpointManager.Add<Delegates.IsUnlocked_WithArgs>(ReflectionHelper.GetMethodInfo(typeof(BossScene.BossTest), "IsUnlocked", true), value);
remove => HookEndpointManager.Remove<Delegates.IsUnlocked_WithArgs>(ReflectionHelper.GetMethodInfo(typeof(BossScene.BossTest), "IsUnlocked", true), value);
}
}

}
