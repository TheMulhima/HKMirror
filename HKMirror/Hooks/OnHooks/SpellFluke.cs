using MonoMod.RuntimeDetour;
using MonoMod.RuntimeDetour.HookGen;
namespace HKMirror.Hooks.OnHooks;
/// <summary>
/// Contains different types of On Hooks for SpellFluke class.<br />
/// Contains hooks that aren't generated by monomod, and before and after orig hooks for easier hooking.
/// </summary>
public static class OnSpellFluke
{
internal static class HookHandler
{
private static List<string> HookedList = new List<string>();
internal static void HookAwake()
{
if (!HookedList.Contains("Awake"))
{
HookedList.Add("Awake");
On.SpellFluke.Awake += Awake;

}
}
internal static event Delegates.Awake_BeforeArgs _beforeAwake;
internal static event Delegates.Awake_AfterArgs _afterAwake;
private static void Awake(On.SpellFluke.orig_Awake orig,SpellFluke self)
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
On.SpellFluke.Start += Start;

}
}
internal static event Delegates.Start_BeforeArgs _beforeStart;
internal static event Delegates.Start_AfterArgs _afterStart;
private static void Start(On.SpellFluke.orig_Start orig,SpellFluke self)
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
internal static void HookDoDamage()
{
if (!HookedList.Contains("DoDamage"))
{
HookedList.Add("DoDamage");
On.SpellFluke.DoDamage += DoDamage;

}
}
internal static event Delegates.DoDamage_BeforeArgs _beforeDoDamage;
internal static event Delegates.DoDamage_AfterArgs _afterDoDamage;
private static void DoDamage(On.SpellFluke.orig_DoDamage orig,SpellFluke self,  UnityEngine.GameObject obj,  int upwardRecursionAmount,  bool burst)
{
Delegates.Params_DoDamage @params = new() 
{
self = self
, obj = obj
, upwardRecursionAmount = upwardRecursionAmount
, burst = burst
};
if (_beforeDoDamage != null)
{
foreach (Delegates.DoDamage_BeforeArgs toInvoke in _beforeDoDamage.GetInvocationList())
{
try
{
_beforeDoDamage?.Invoke(@params);
}
catch (Exception e) 
{ HKMirrorMod.DoLogError(e);
}
}
}
self = @params.self;
obj = @params.obj;
upwardRecursionAmount = @params.upwardRecursionAmount;
burst = @params.burst;
orig(self, obj, upwardRecursionAmount, burst);
if (_afterDoDamage != null)
{
foreach (Delegates.DoDamage_AfterArgs toInvoke in _afterDoDamage.GetInvocationList())
{
try
{
_afterDoDamage.Invoke(@params);
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
On.SpellFluke.OnEnable += OnEnable;

}
}
internal static event Delegates.OnEnable_BeforeArgs _beforeOnEnable;
internal static event Delegates.OnEnable_AfterArgs _afterOnEnable;
private static void OnEnable(On.SpellFluke.orig_OnEnable orig,SpellFluke self)
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
internal static void HookUpdate()
{
if (!HookedList.Contains("Update"))
{
HookedList.Add("Update");
On.SpellFluke.Update += Update;

}
}
internal static event Delegates.Update_BeforeArgs _beforeUpdate;
internal static event Delegates.Update_AfterArgs _afterUpdate;
private static void Update(On.SpellFluke.orig_Update orig,SpellFluke self)
{
Delegates.Params_Update @params = new() 
{
self = self
};
if (_beforeUpdate != null)
{
foreach (Delegates.Update_BeforeArgs toInvoke in _beforeUpdate.GetInvocationList())
{
try
{
_beforeUpdate?.Invoke(@params);
}
catch (Exception e) 
{ HKMirrorMod.DoLogError(e);
}
}
}
self = @params.self;
orig(self);
if (_afterUpdate != null)
{
foreach (Delegates.Update_AfterArgs toInvoke in _afterUpdate.GetInvocationList())
{
try
{
_afterUpdate.Invoke(@params);
}
catch (Exception e) 
{ HKMirrorMod.DoLogError(e);
}
}
}
}
internal static void HookBurst()
{
if (!HookedList.Contains("Burst"))
{
HookedList.Add("Burst");
On.SpellFluke.Burst += Burst;

}
}
internal static event Delegates.Burst_BeforeArgs _beforeBurst;
internal static event Delegates.Burst_AfterArgs _afterBurst;
private static void Burst(On.SpellFluke.orig_Burst orig,SpellFluke self)
{
Delegates.Params_Burst @params = new() 
{
self = self
};
if (_beforeBurst != null)
{
foreach (Delegates.Burst_BeforeArgs toInvoke in _beforeBurst.GetInvocationList())
{
try
{
_beforeBurst?.Invoke(@params);
}
catch (Exception e) 
{ HKMirrorMod.DoLogError(e);
}
}
}
self = @params.self;
orig(self);
if (_afterBurst != null)
{
foreach (Delegates.Burst_AfterArgs toInvoke in _afterBurst.GetInvocationList())
{
try
{
_afterBurst.Invoke(@params);
}
catch (Exception e) 
{ HKMirrorMod.DoLogError(e);
}
}
}
}
internal static void HookBurstSequence()
{
if (!HookedList.Contains("BurstSequence"))
{
HookedList.Add("BurstSequence");
On.SpellFluke.BurstSequence += BurstSequence;

}
}
internal static event Delegates.BurstSequence_BeforeArgs _beforeBurstSequence;
private static System.Collections.IEnumerator BurstSequence(On.SpellFluke.orig_BurstSequence orig,SpellFluke self)
{
Delegates.Params_BurstSequence @params = new() 
{
self = self
};
if (_beforeBurstSequence != null)
{
foreach (Delegates.BurstSequence_BeforeArgs toInvoke in _beforeBurstSequence.GetInvocationList())
{
try
{
_beforeBurstSequence?.Invoke(@params);
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
public SpellFluke self;
}
public delegate void Awake_BeforeArgs(Params_Awake args);
public delegate void Awake_AfterArgs(Params_Awake args);
public delegate void Awake_WithArgs (Action<SpellFluke> orig, SpellFluke self);
public sealed class Params_Start
{
public SpellFluke self;
}
public delegate void Start_BeforeArgs(Params_Start args);
public delegate void Start_AfterArgs(Params_Start args);
public delegate void Start_WithArgs (Action<SpellFluke> orig, SpellFluke self);
public sealed class Params_DoDamage
{
public SpellFluke self;
public UnityEngine.GameObject obj;
public int upwardRecursionAmount;
public bool burst;
}
public delegate void DoDamage_BeforeArgs(Params_DoDamage args);
public delegate void DoDamage_AfterArgs(Params_DoDamage args);
public delegate void DoDamage_WithArgs (Action<SpellFluke,  UnityEngine.GameObject,  int,  bool> orig, SpellFluke self,  UnityEngine.GameObject obj,  int upwardRecursionAmount,  bool burst);
public sealed class Params_OnEnable
{
public SpellFluke self;
}
public delegate void OnEnable_BeforeArgs(Params_OnEnable args);
public delegate void OnEnable_AfterArgs(Params_OnEnable args);
public delegate void OnEnable_WithArgs (Action<SpellFluke> orig, SpellFluke self);
public sealed class Params_Update
{
public SpellFluke self;
}
public delegate void Update_BeforeArgs(Params_Update args);
public delegate void Update_AfterArgs(Params_Update args);
public delegate void Update_WithArgs (Action<SpellFluke> orig, SpellFluke self);
public sealed class Params_Burst
{
public SpellFluke self;
}
public delegate void Burst_BeforeArgs(Params_Burst args);
public delegate void Burst_AfterArgs(Params_Burst args);
public delegate void Burst_WithArgs (Action<SpellFluke> orig, SpellFluke self);
public sealed class Params_BurstSequence
{
public SpellFluke self;
}
public delegate void BurstSequence_BeforeArgs(Params_BurstSequence args);
public delegate System.Collections.IEnumerator BurstSequence_AfterArgs(Params_BurstSequence args, System.Collections.IEnumerator ret);
public delegate System.Collections.IEnumerator BurstSequence_WithArgs (Func<SpellFluke, System.Collections.IEnumerator> orig, SpellFluke self);
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
public static event Delegates.DoDamage_BeforeArgs DoDamage
{
add
{

HookHandler._beforeDoDamage += value;
HookHandler.HookDoDamage();
}
remove => HookHandler._beforeDoDamage -= value;
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
public static event Delegates.Update_BeforeArgs Update
{
add
{

HookHandler._beforeUpdate += value;
HookHandler.HookUpdate();
}
remove => HookHandler._beforeUpdate -= value;
}
public static event Delegates.Burst_BeforeArgs Burst
{
add
{

HookHandler._beforeBurst += value;
HookHandler.HookBurst();
}
remove => HookHandler._beforeBurst -= value;
}
public static event Delegates.BurstSequence_BeforeArgs BurstSequence
{
add
{

HookHandler._beforeBurstSequence += value;
HookHandler.HookBurstSequence();
}
remove => HookHandler._beforeBurstSequence -= value;
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
public static event Delegates.DoDamage_AfterArgs DoDamage
{
add
{

HookHandler._afterDoDamage += value;
HookHandler.HookDoDamage();
}
remove => HookHandler._afterDoDamage -= value;
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
public static event Delegates.Update_AfterArgs Update
{
add
{

HookHandler._afterUpdate += value;
HookHandler.HookUpdate();
}
remove => HookHandler._afterUpdate -= value;
}
public static event Delegates.Burst_AfterArgs Burst
{
add
{

HookHandler._afterBurst += value;
HookHandler.HookBurst();
}
remove => HookHandler._afterBurst -= value;
}
}

/// <summary>
/// Contains all On Hooks, even those that aren't in the On namespace such as API generated functions and property getters/setters
/// </summary>
public static class WithOrig
{
public static event On.SpellFluke.hook_Awake Awake
{
add => On.SpellFluke.Awake += value;
remove => On.SpellFluke.Awake -= value;
}
public static event On.SpellFluke.hook_Start Start
{
add => On.SpellFluke.Start += value;
remove => On.SpellFluke.Start -= value;
}
public static event On.SpellFluke.hook_DoDamage DoDamage
{
add => On.SpellFluke.DoDamage += value;
remove => On.SpellFluke.DoDamage -= value;
}
public static event On.SpellFluke.hook_OnEnable OnEnable
{
add => On.SpellFluke.OnEnable += value;
remove => On.SpellFluke.OnEnable -= value;
}
public static event On.SpellFluke.hook_Update Update
{
add => On.SpellFluke.Update += value;
remove => On.SpellFluke.Update -= value;
}
public static event On.SpellFluke.hook_Burst Burst
{
add => On.SpellFluke.Burst += value;
remove => On.SpellFluke.Burst -= value;
}
public static event On.SpellFluke.hook_BurstSequence BurstSequence
{
add => On.SpellFluke.BurstSequence += value;
remove => On.SpellFluke.BurstSequence -= value;
}
}

}
