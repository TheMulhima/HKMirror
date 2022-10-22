using MonoMod.RuntimeDetour;
using MonoMod.RuntimeDetour.HookGen;
namespace HKMirror.Hooks.OnHooks;
/// <summary>
/// Contains different types of On Hooks for BossDoorTargetLock_BossDoorTarget class.<br />
/// Contains hooks that aren't generated by monomod, and before and after orig hooks for easier hooking.
/// </summary>
public static class OnBossDoorTargetLock_BossDoorTarget
{
internal static class HookHandler
{
private static List<string> HookedList = new List<string>();
internal static void HookEvaluate()
{
if (!HookedList.Contains("Evaluate"))
{
HookedList.Add("Evaluate");
new Hook(ReflectionHelper.GetMethodInfo(typeof(BossDoorTargetLock.BossDoorTarget), "Evaluate", true), Evaluate);

}
}
internal static event Delegates.Evaluate_BeforeArgs _beforeEvaluate;
internal static event Delegates.Evaluate_AfterArgs _afterEvaluate;
private static bool Evaluate(Func<BossDoorTargetLock.BossDoorTarget, bool> orig, BossDoorTargetLock.BossDoorTarget self)
{
Delegates.Params_Evaluate @params = new() 
{
self = self
};
if (_beforeEvaluate != null)
{
foreach (Delegates.Evaluate_BeforeArgs toInvoke in _beforeEvaluate.GetInvocationList())
{
try
{
_beforeEvaluate?.Invoke(@params);
}
catch (Exception e) 
{ HKMirrorMod.DoLogError(e);
}
}
}
self = @params.self;
var retVal = orig(self);
if (_afterEvaluate != null)
{
foreach (Delegates.Evaluate_AfterArgs toInvoke in _afterEvaluate.GetInvocationList())
{
try
{
retVal = _afterEvaluate.Invoke(@params, retVal);
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
public sealed class Params_Evaluate
{
public BossDoorTargetLock.BossDoorTarget self;
}
public delegate void Evaluate_BeforeArgs(Params_Evaluate args);
public delegate bool Evaluate_AfterArgs(Params_Evaluate args, bool ret);
public delegate bool Evaluate_WithArgs (Func<BossDoorTargetLock.BossDoorTarget, bool> orig, BossDoorTargetLock.BossDoorTarget self);
}

/// <summary>
/// Contains Hooks to that run code before orig(self) is called
/// </summary>
public static class BeforeOrig
{
public static event Delegates.Evaluate_BeforeArgs Evaluate
{
add
{

HookHandler._beforeEvaluate += value;
HookHandler.HookEvaluate();
}
remove => HookHandler._beforeEvaluate -= value;
}
}

/// <summary>
/// Contains Hooks to that run code after orig(self) is called
/// </summary>
public static class AfterOrig
{
public static event Delegates.Evaluate_AfterArgs Evaluate
{
add
{

HookHandler._afterEvaluate += value;
HookHandler.HookEvaluate();
}
remove => HookHandler._afterEvaluate -= value;
}
}

/// <summary>
/// Contains all On Hooks, even those that aren't in the On namespace such as API generated functions and property getters/setters
/// </summary>
public static class WithOrig
{
public static event Delegates.Evaluate_WithArgs Evaluate
{
add => HookEndpointManager.Add<Delegates.Evaluate_WithArgs>(ReflectionHelper.GetMethodInfo(typeof(BossDoorTargetLock.BossDoorTarget), "Evaluate", true), value);
remove => HookEndpointManager.Remove<Delegates.Evaluate_WithArgs>(ReflectionHelper.GetMethodInfo(typeof(BossDoorTargetLock.BossDoorTarget), "Evaluate", true), value);
}
}

}
