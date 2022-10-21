using MonoMod.RuntimeDetour;
using MonoMod.RuntimeDetour.HookGen;
namespace HKMirror.Hooks.OnHooks;
/// <summary>
/// Contains different types of On Hooks for BossSequenceBindingsDoor class.<br />
/// Contains hooks that aren't generated by monomod, and before and after orig hooks for easier hooking.
/// </summary>
public static class OnBossSequenceBindingsDoor
{
internal static class HookHandler
{
private static List<string> HookedList = new List<string>();
internal static void HookAwake()
{
if (!HookedList.Contains("Awake"))
{
HookedList.Add("Awake");
On.BossSequenceBindingsDoor.Awake += Awake;

}
}
internal static event Delegates.Awake_BeforeArgs _beforeAwake;
internal static event Delegates.Awake_AfterArgs _afterAwake;
private static void Awake(On.BossSequenceBindingsDoor.orig_Awake orig,BossSequenceBindingsDoor self)
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
internal static void HookStart()
{
if (!HookedList.Contains("Start"))
{
HookedList.Add("Start");
On.BossSequenceBindingsDoor.Start += Start;

}
}
internal static event Delegates.Start_BeforeArgs _beforeStart;
internal static event Delegates.Start_AfterArgs _afterStart;
private static void Start(On.BossSequenceBindingsDoor.orig_Start orig,BossSequenceBindingsDoor self)
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
orig(self);
if (_afterStart != null)
{
foreach (Delegates.Start_AfterArgs toInvoke in _afterStart.GetInvocationList())
{
try
{
_afterStart.Invoke(@params);
}
catch (Exception e) 
{ HKMirrorMod.DoLogError(e);
}
}
}
}
internal static void HookOnTriggerEnter2D()
{
if (!HookedList.Contains("OnTriggerEnter2D"))
{
HookedList.Add("OnTriggerEnter2D");
On.BossSequenceBindingsDoor.OnTriggerEnter2D += OnTriggerEnter2D;

}
}
internal static event Delegates.OnTriggerEnter2D_BeforeArgs _beforeOnTriggerEnter2D;
internal static event Delegates.OnTriggerEnter2D_AfterArgs _afterOnTriggerEnter2D;
private static void OnTriggerEnter2D(On.BossSequenceBindingsDoor.orig_OnTriggerEnter2D orig,BossSequenceBindingsDoor self,  UnityEngine.Collider2D collision)
{
Delegates.Params_OnTriggerEnter2D @params = new() 
{
self = self
, collision = collision
};
if (_beforeOnTriggerEnter2D != null)
{
foreach (Delegates.OnTriggerEnter2D_BeforeArgs toInvoke in _beforeOnTriggerEnter2D.GetInvocationList())
{
try
{
_beforeOnTriggerEnter2D?.Invoke(@params);
}
catch (Exception e) 
{ HKMirrorMod.DoLogError(e);
}
}
}
self = @params.self;
collision = @params.collision;
orig(self, collision);
if (_afterOnTriggerEnter2D != null)
{
foreach (Delegates.OnTriggerEnter2D_AfterArgs toInvoke in _afterOnTriggerEnter2D.GetInvocationList())
{
try
{
_afterOnTriggerEnter2D.Invoke(@params);
}
catch (Exception e) 
{ HKMirrorMod.DoLogError(e);
}
}
}
}
internal static void HookSetUnlocked()
{
if (!HookedList.Contains("SetUnlocked"))
{
HookedList.Add("SetUnlocked");
On.BossSequenceBindingsDoor.SetUnlocked += SetUnlocked;

}
}
internal static event Delegates.SetUnlocked_BeforeArgs _beforeSetUnlocked;
internal static event Delegates.SetUnlocked_AfterArgs _afterSetUnlocked;
private static void SetUnlocked(On.BossSequenceBindingsDoor.orig_SetUnlocked orig,BossSequenceBindingsDoor self,  bool value,  bool doUnlockAnimation)
{
Delegates.Params_SetUnlocked @params = new() 
{
self = self
, value = value
, doUnlockAnimation = doUnlockAnimation
};
if (_beforeSetUnlocked != null)
{
foreach (Delegates.SetUnlocked_BeforeArgs toInvoke in _beforeSetUnlocked.GetInvocationList())
{
try
{
_beforeSetUnlocked?.Invoke(@params);
}
catch (Exception e) 
{ HKMirrorMod.DoLogError(e);
}
}
}
self = @params.self;
value = @params.value;
doUnlockAnimation = @params.doUnlockAnimation;
orig(self, value, doUnlockAnimation);
if (_afterSetUnlocked != null)
{
foreach (Delegates.SetUnlocked_AfterArgs toInvoke in _afterSetUnlocked.GetInvocationList())
{
try
{
_afterSetUnlocked.Invoke(@params);
}
catch (Exception e) 
{ HKMirrorMod.DoLogError(e);
}
}
}
}
internal static void HookDoUnlockAnimation()
{
if (!HookedList.Contains("DoUnlockAnimation"))
{
HookedList.Add("DoUnlockAnimation");
On.BossSequenceBindingsDoor.DoUnlockAnimation += DoUnlockAnimation;

}
}
internal static event Delegates.DoUnlockAnimation_BeforeArgs _beforeDoUnlockAnimation;
private static System.Collections.IEnumerator DoUnlockAnimation(On.BossSequenceBindingsDoor.orig_DoUnlockAnimation orig,BossSequenceBindingsDoor self)
{
Delegates.Params_DoUnlockAnimation @params = new() 
{
self = self
};
if (_beforeDoUnlockAnimation != null)
{
foreach (Delegates.DoUnlockAnimation_BeforeArgs toInvoke in _beforeDoUnlockAnimation.GetInvocationList())
{
try
{
_beforeDoUnlockAnimation?.Invoke(@params);
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
public BossSequenceBindingsDoor self;
}
public delegate void Awake_BeforeArgs(Params_Awake args);
public delegate void Awake_AfterArgs(Params_Awake args);
public delegate void Awake_WithArgs (Action<BossSequenceBindingsDoor> orig, BossSequenceBindingsDoor self);
public sealed class Params_Start
{
public BossSequenceBindingsDoor self;
}
public delegate void Start_BeforeArgs(Params_Start args);
public delegate void Start_AfterArgs(Params_Start args);
public delegate void Start_WithArgs (Action<BossSequenceBindingsDoor> orig, BossSequenceBindingsDoor self);
public sealed class Params_OnTriggerEnter2D
{
public BossSequenceBindingsDoor self;
public UnityEngine.Collider2D collision;
}
public delegate void OnTriggerEnter2D_BeforeArgs(Params_OnTriggerEnter2D args);
public delegate void OnTriggerEnter2D_AfterArgs(Params_OnTriggerEnter2D args);
public delegate void OnTriggerEnter2D_WithArgs (Action<BossSequenceBindingsDoor,  UnityEngine.Collider2D> orig, BossSequenceBindingsDoor self,  UnityEngine.Collider2D collision);
public sealed class Params_SetUnlocked
{
public BossSequenceBindingsDoor self;
public bool value;
public bool doUnlockAnimation;
}
public delegate void SetUnlocked_BeforeArgs(Params_SetUnlocked args);
public delegate void SetUnlocked_AfterArgs(Params_SetUnlocked args);
public delegate void SetUnlocked_WithArgs (Action<BossSequenceBindingsDoor,  bool,  bool> orig, BossSequenceBindingsDoor self,  bool value,  bool doUnlockAnimation);
public sealed class Params_DoUnlockAnimation
{
public BossSequenceBindingsDoor self;
}
public delegate void DoUnlockAnimation_BeforeArgs(Params_DoUnlockAnimation args);
public delegate System.Collections.IEnumerator DoUnlockAnimation_AfterArgs(Params_DoUnlockAnimation args, System.Collections.IEnumerator ret);
public delegate System.Collections.IEnumerator DoUnlockAnimation_WithArgs (Func<BossSequenceBindingsDoor, System.Collections.IEnumerator> orig, BossSequenceBindingsDoor self);
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
public static event Delegates.Start_BeforeArgs Start
{
add
{

HookHandler._beforeStart += value;
HookHandler.HookStart();
}
remove => HookHandler._beforeStart -= value;
}
public static event Delegates.OnTriggerEnter2D_BeforeArgs OnTriggerEnter2D
{
add
{

HookHandler._beforeOnTriggerEnter2D += value;
HookHandler.HookOnTriggerEnter2D();
}
remove => HookHandler._beforeOnTriggerEnter2D -= value;
}
public static event Delegates.SetUnlocked_BeforeArgs SetUnlocked
{
add
{

HookHandler._beforeSetUnlocked += value;
HookHandler.HookSetUnlocked();
}
remove => HookHandler._beforeSetUnlocked -= value;
}
public static event Delegates.DoUnlockAnimation_BeforeArgs DoUnlockAnimation
{
add
{

HookHandler._beforeDoUnlockAnimation += value;
HookHandler.HookDoUnlockAnimation();
}
remove => HookHandler._beforeDoUnlockAnimation -= value;
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
public static event Delegates.Start_AfterArgs Start
{
add
{

HookHandler._afterStart += value;
HookHandler.HookStart();
}
remove => HookHandler._afterStart -= value;
}
public static event Delegates.OnTriggerEnter2D_AfterArgs OnTriggerEnter2D
{
add
{

HookHandler._afterOnTriggerEnter2D += value;
HookHandler.HookOnTriggerEnter2D();
}
remove => HookHandler._afterOnTriggerEnter2D -= value;
}
public static event Delegates.SetUnlocked_AfterArgs SetUnlocked
{
add
{

HookHandler._afterSetUnlocked += value;
HookHandler.HookSetUnlocked();
}
remove => HookHandler._afterSetUnlocked -= value;
}
}

/// <summary>
/// Contains all On Hooks, even those that aren't in the On namespace such as API generated functions and property getters/setters
/// </summary>
public static class WithOrig
{
public static event On.BossSequenceBindingsDoor.hook_Awake Awake
{
add => On.BossSequenceBindingsDoor.Awake += value;
remove => On.BossSequenceBindingsDoor.Awake -= value;
}
public static event On.BossSequenceBindingsDoor.hook_Start Start
{
add => On.BossSequenceBindingsDoor.Start += value;
remove => On.BossSequenceBindingsDoor.Start -= value;
}
public static event On.BossSequenceBindingsDoor.hook_OnTriggerEnter2D OnTriggerEnter2D
{
add => On.BossSequenceBindingsDoor.OnTriggerEnter2D += value;
remove => On.BossSequenceBindingsDoor.OnTriggerEnter2D -= value;
}
public static event On.BossSequenceBindingsDoor.hook_SetUnlocked SetUnlocked
{
add => On.BossSequenceBindingsDoor.SetUnlocked += value;
remove => On.BossSequenceBindingsDoor.SetUnlocked -= value;
}
public static event On.BossSequenceBindingsDoor.hook_DoUnlockAnimation DoUnlockAnimation
{
add => On.BossSequenceBindingsDoor.DoUnlockAnimation += value;
remove => On.BossSequenceBindingsDoor.DoUnlockAnimation -= value;
}
}

}
