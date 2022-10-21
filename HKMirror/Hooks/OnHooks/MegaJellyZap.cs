using MonoMod.RuntimeDetour;
using MonoMod.RuntimeDetour.HookGen;
namespace HKMirror.Hooks.OnHooks;
/// <summary>
/// Contains different types of On Hooks for MegaJellyZap class.<br />
/// Contains hooks that aren't generated by monomod, and before and after orig hooks for easier hooking.
/// </summary>
public static class OnMegaJellyZap
{
internal static class HookHandler
{
private static List<string> HookedList = new List<string>();
internal static void HookAwake()
{
if (!HookedList.Contains("Awake"))
{
HookedList.Add("Awake");
On.MegaJellyZap.Awake += Awake;

}
}
internal static event Delegates.Awake_BeforeArgs _beforeAwake;
internal static event Delegates.Awake_AfterArgs _afterAwake;
private static void Awake(On.MegaJellyZap.orig_Awake orig,MegaJellyZap self)
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
On.MegaJellyZap.OnEnable += OnEnable;

}
}
internal static event Delegates.OnEnable_BeforeArgs _beforeOnEnable;
internal static event Delegates.OnEnable_AfterArgs _afterOnEnable;
private static void OnEnable(On.MegaJellyZap.orig_OnEnable orig,MegaJellyZap self)
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
On.MegaJellyZap.OnDisable += OnDisable;

}
}
internal static event Delegates.OnDisable_BeforeArgs _beforeOnDisable;
internal static event Delegates.OnDisable_AfterArgs _afterOnDisable;
private static void OnDisable(On.MegaJellyZap.orig_OnDisable orig,MegaJellyZap self)
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
internal static void HookZapSequence()
{
if (!HookedList.Contains("ZapSequence"))
{
HookedList.Add("ZapSequence");
On.MegaJellyZap.ZapSequence += ZapSequence;

}
}
internal static event Delegates.ZapSequence_BeforeArgs _beforeZapSequence;
private static System.Collections.IEnumerator ZapSequence(On.MegaJellyZap.orig_ZapSequence orig,MegaJellyZap self)
{
Delegates.Params_ZapSequence @params = new() 
{
self = self
};
if (_beforeZapSequence != null)
{
foreach (Delegates.ZapSequence_BeforeArgs toInvoke in _beforeZapSequence.GetInvocationList())
{
try
{
_beforeZapSequence?.Invoke(@params);
}
catch (Exception e) 
{ HKMirrorMod.DoLogError(e);
}
}
}
self = @params.self;
return orig(self);
}
internal static void HookMultiZapSequence()
{
if (!HookedList.Contains("MultiZapSequence"))
{
HookedList.Add("MultiZapSequence");
On.MegaJellyZap.MultiZapSequence += MultiZapSequence;

}
}
internal static event Delegates.MultiZapSequence_BeforeArgs _beforeMultiZapSequence;
private static System.Collections.IEnumerator MultiZapSequence(On.MegaJellyZap.orig_MultiZapSequence orig,MegaJellyZap self)
{
Delegates.Params_MultiZapSequence @params = new() 
{
self = self
};
if (_beforeMultiZapSequence != null)
{
foreach (Delegates.MultiZapSequence_BeforeArgs toInvoke in _beforeMultiZapSequence.GetInvocationList())
{
try
{
_beforeMultiZapSequence?.Invoke(@params);
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
public sealed class Params_Awake
{
public MegaJellyZap self;
}
public delegate void Awake_BeforeArgs(Params_Awake args);
public delegate void Awake_AfterArgs(Params_Awake args);
public delegate void Awake_WithArgs (Action<MegaJellyZap> orig, MegaJellyZap self);
public sealed class Params_OnEnable
{
public MegaJellyZap self;
}
public delegate void OnEnable_BeforeArgs(Params_OnEnable args);
public delegate void OnEnable_AfterArgs(Params_OnEnable args);
public delegate void OnEnable_WithArgs (Action<MegaJellyZap> orig, MegaJellyZap self);
public sealed class Params_OnDisable
{
public MegaJellyZap self;
}
public delegate void OnDisable_BeforeArgs(Params_OnDisable args);
public delegate void OnDisable_AfterArgs(Params_OnDisable args);
public delegate void OnDisable_WithArgs (Action<MegaJellyZap> orig, MegaJellyZap self);
public sealed class Params_ZapSequence
{
public MegaJellyZap self;
}
public delegate void ZapSequence_BeforeArgs(Params_ZapSequence args);
public delegate System.Collections.IEnumerator ZapSequence_AfterArgs(Params_ZapSequence args, System.Collections.IEnumerator ret);
public delegate System.Collections.IEnumerator ZapSequence_WithArgs (Func<MegaJellyZap, System.Collections.IEnumerator> orig, MegaJellyZap self);
public sealed class Params_MultiZapSequence
{
public MegaJellyZap self;
}
public delegate void MultiZapSequence_BeforeArgs(Params_MultiZapSequence args);
public delegate System.Collections.IEnumerator MultiZapSequence_AfterArgs(Params_MultiZapSequence args, System.Collections.IEnumerator ret);
public delegate System.Collections.IEnumerator MultiZapSequence_WithArgs (Func<MegaJellyZap, System.Collections.IEnumerator> orig, MegaJellyZap self);
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
public static event Delegates.OnDisable_BeforeArgs OnDisable
{
add
{

HookHandler._beforeOnDisable += value;
HookHandler.HookOnDisable();
}
remove => HookHandler._beforeOnDisable -= value;
}
public static event Delegates.ZapSequence_BeforeArgs ZapSequence
{
add
{

HookHandler._beforeZapSequence += value;
HookHandler.HookZapSequence();
}
remove => HookHandler._beforeZapSequence -= value;
}
public static event Delegates.MultiZapSequence_BeforeArgs MultiZapSequence
{
add
{

HookHandler._beforeMultiZapSequence += value;
HookHandler.HookMultiZapSequence();
}
remove => HookHandler._beforeMultiZapSequence -= value;
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
public static event Delegates.OnDisable_AfterArgs OnDisable
{
add
{

HookHandler._afterOnDisable += value;
HookHandler.HookOnDisable();
}
remove => HookHandler._afterOnDisable -= value;
}
}

/// <summary>
/// Contains all On Hooks, even those that aren't in the On namespace such as API generated functions and property getters/setters
/// </summary>
public static class WithOrig
{
public static event On.MegaJellyZap.hook_Awake Awake
{
add => On.MegaJellyZap.Awake += value;
remove => On.MegaJellyZap.Awake -= value;
}
public static event On.MegaJellyZap.hook_OnEnable OnEnable
{
add => On.MegaJellyZap.OnEnable += value;
remove => On.MegaJellyZap.OnEnable -= value;
}
public static event On.MegaJellyZap.hook_OnDisable OnDisable
{
add => On.MegaJellyZap.OnDisable += value;
remove => On.MegaJellyZap.OnDisable -= value;
}
public static event On.MegaJellyZap.hook_ZapSequence ZapSequence
{
add => On.MegaJellyZap.ZapSequence += value;
remove => On.MegaJellyZap.ZapSequence -= value;
}
public static event On.MegaJellyZap.hook_MultiZapSequence MultiZapSequence
{
add => On.MegaJellyZap.MultiZapSequence += value;
remove => On.MegaJellyZap.MultiZapSequence -= value;
}
}

}
