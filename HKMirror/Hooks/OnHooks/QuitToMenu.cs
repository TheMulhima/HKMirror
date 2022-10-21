using MonoMod.RuntimeDetour;
using MonoMod.RuntimeDetour.HookGen;
namespace HKMirror.Hooks.OnHooks;
/// <summary>
/// Contains different types of On Hooks for QuitToMenu class.<br />
/// Contains hooks that aren't generated by monomod, and before and after orig hooks for easier hooking.
/// </summary>
public static class OnQuitToMenu
{
internal static class HookHandler
{
private static List<string> HookedList = new List<string>();
internal static void HookStart()
{
if (!HookedList.Contains("Start"))
{
HookedList.Add("Start");
On.QuitToMenu.Start += Start;

}
}
internal static event Delegates.Start_BeforeArgs _beforeStart;
private static System.Collections.IEnumerator Start(On.QuitToMenu.orig_Start orig,QuitToMenu self)
{
Delegates.Params_Start @params = new() 
{
self = self
};
if (_beforeStart != null)
{
foreach (Delegates.Start_BeforeArgs toInvoke in _beforeStart.GetInvocationList())
{
try
{
_beforeStart?.Invoke(@params);
}
catch (Exception e) 
{ HKMirrorMod.DoLogError(e);
}
}
}
self = @params.self;
return orig(self);
}
}

/// <summary>
/// Contains necessary information to create Hooks. Does not contain any hooks
/// </summary>
public static class Delegates
{
public sealed class Params_Start
{
public QuitToMenu self;
}
public delegate void Start_BeforeArgs(Params_Start args);
public delegate System.Collections.IEnumerator Start_AfterArgs(Params_Start args, System.Collections.IEnumerator ret);
public delegate System.Collections.IEnumerator Start_WithArgs (Func<QuitToMenu, System.Collections.IEnumerator> orig, QuitToMenu self);
}

/// <summary>
/// Contains Hooks to that run code before orig(self) is called
/// </summary>
public static class BeforeOrig
{
public static event Delegates.Start_BeforeArgs Start
{
add
{

HookHandler._beforeStart += value;
HookHandler.HookStart();
}
remove => HookHandler._beforeStart -= value;
}
}

/// <summary>
/// Contains Hooks to that run code after orig(self) is called
/// </summary>
public static class AfterOrig
{
}

/// <summary>
/// Contains all On Hooks, even those that aren't in the On namespace such as API generated functions and property getters/setters
/// </summary>
public static class WithOrig
{
public static event On.QuitToMenu.hook_Start Start
{
add => On.QuitToMenu.Start += value;
remove => On.QuitToMenu.Start -= value;
}
}

}
