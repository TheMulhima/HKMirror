using MonoMod.RuntimeDetour;
using MonoMod.RuntimeDetour.HookGen;
namespace HKMirror.Hooks.OnHooks;
/// <summary>
/// Contains different types of On Hooks for InvNailSprite class.<br />
/// Contains hooks that aren't generated by monomod, and before and after orig hooks for easier hooking.
/// </summary>
public static class OnInvNailSprite
{
internal static class HookHandler
{
private static List<string> HookedList = new List<string>();
internal static void HookAwake()
{
if (!HookedList.Contains("Awake"))
{
HookedList.Add("Awake");
On.InvNailSprite.Awake += Awake;

}
}
internal static event Delegates.Awake_BeforeArgs _beforeAwake;
internal static event Delegates.Awake_AfterArgs _afterAwake;
private static void Awake(On.InvNailSprite.orig_Awake orig,InvNailSprite self)
{
Delegates.Params_Awake @params = new() 
{
self = self
};
if (_beforeAwake != null)
{
foreach (Delegates.Awake_BeforeArgs toInvoke in _beforeAwake.GetInvocationList())
{
try
{
_beforeAwake?.Invoke(@params);
}
catch (Exception e) 
{ HKMirrorMod.DoLogError(e);
}
}
}
self = @params.self;
orig(self);
if (_afterAwake != null)
{
foreach (Delegates.Awake_AfterArgs toInvoke in _afterAwake.GetInvocationList())
{
try
{
_afterAwake.Invoke(@params);
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
On.InvNailSprite.OnEnable += OnEnable;

}
}
internal static event Delegates.OnEnable_BeforeArgs _beforeOnEnable;
internal static event Delegates.OnEnable_AfterArgs _afterOnEnable;
private static void OnEnable(On.InvNailSprite.orig_OnEnable orig,InvNailSprite self)
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
}

/// <summary>
/// Contains necessary information to create Hooks. Does not contain any hooks
/// </summary>
public static class Delegates
{
public sealed class Params_Awake
{
public InvNailSprite self;
}
public delegate void Awake_BeforeArgs(Params_Awake args);
public delegate void Awake_AfterArgs(Params_Awake args);
public delegate void Awake_WithArgs (Action<InvNailSprite> orig, InvNailSprite self);
public sealed class Params_OnEnable
{
public InvNailSprite self;
}
public delegate void OnEnable_BeforeArgs(Params_OnEnable args);
public delegate void OnEnable_AfterArgs(Params_OnEnable args);
public delegate void OnEnable_WithArgs (Action<InvNailSprite> orig, InvNailSprite self);
}

/// <summary>
/// Contains Hooks to that run code before orig(self) is called
/// </summary>
public static class BeforeOrig
{
public static event Delegates.Awake_BeforeArgs Awake
{
add
{

HookHandler._beforeAwake += value;
HookHandler.HookAwake();
}
remove => HookHandler._beforeAwake -= value;
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
}

/// <summary>
/// Contains Hooks to that run code after orig(self) is called
/// </summary>
public static class AfterOrig
{
public static event Delegates.Awake_AfterArgs Awake
{
add
{

HookHandler._afterAwake += value;
HookHandler.HookAwake();
}
remove => HookHandler._afterAwake -= value;
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
}

/// <summary>
/// Contains all On Hooks, even those that aren't in the On namespace such as API generated functions and property getters/setters
/// </summary>
public static class WithOrig
{
public static event On.InvNailSprite.hook_Awake Awake
{
add => On.InvNailSprite.Awake += value;
remove => On.InvNailSprite.Awake -= value;
}
public static event On.InvNailSprite.hook_OnEnable OnEnable
{
add => On.InvNailSprite.OnEnable += value;
remove => On.InvNailSprite.OnEnable -= value;
}
}

}
