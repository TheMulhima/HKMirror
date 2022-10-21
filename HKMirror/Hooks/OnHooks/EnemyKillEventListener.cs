using MonoMod.RuntimeDetour;
using MonoMod.RuntimeDetour.HookGen;
namespace HKMirror.Hooks.OnHooks;
/// <summary>
/// Contains different types of On Hooks for EnemyKillEventListener class.<br />
/// Contains hooks that aren't generated by monomod, and before and after orig hooks for easier hooking.
/// </summary>
public static class OnEnemyKillEventListener
{
internal static class HookHandler
{
private static List<string> HookedList = new List<string>();
internal static void HookAwake()
{
if (!HookedList.Contains("Awake"))
{
HookedList.Add("Awake");
On.EnemyKillEventListener.Awake += Awake;

}
}
internal static event Delegates.Awake_BeforeArgs _beforeAwake;
internal static event Delegates.Awake_AfterArgs _afterAwake;
private static void Awake(On.EnemyKillEventListener.orig_Awake orig,EnemyKillEventListener self)
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
On.EnemyKillEventListener.OnEnable += OnEnable;

}
}
internal static event Delegates.OnEnable_BeforeArgs _beforeOnEnable;
internal static event Delegates.OnEnable_AfterArgs _afterOnEnable;
private static void OnEnable(On.EnemyKillEventListener.orig_OnEnable orig,EnemyKillEventListener self)
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
On.EnemyKillEventListener.OnDisable += OnDisable;

}
}
internal static event Delegates.OnDisable_BeforeArgs _beforeOnDisable;
internal static event Delegates.OnDisable_AfterArgs _afterOnDisable;
private static void OnDisable(On.EnemyKillEventListener.orig_OnDisable orig,EnemyKillEventListener self)
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
internal static void HookDie()
{
if (!HookedList.Contains("Die"))
{
HookedList.Add("Die");
On.EnemyKillEventListener.Die += Die;

}
}
internal static event Delegates.Die_BeforeArgs _beforeDie;
internal static event Delegates.Die_AfterArgs _afterDie;
private static void Die(On.EnemyKillEventListener.orig_Die orig,EnemyKillEventListener self)
{
Delegates.Params_Die @params = new() 
{
self = self
};
if (_beforeDie != null)
{
foreach (Delegates.Die_BeforeArgs toInvoke in _beforeDie.GetInvocationList())
{
try
{
_beforeDie?.Invoke(@params);
}
catch (Exception e) 
{ HKMirrorMod.DoLogError(e);
}
}
}
self = @params.self;
orig(self);
if (_afterDie != null)
{
foreach (Delegates.Die_AfterArgs toInvoke in _afterDie.GetInvocationList())
{
try
{
_afterDie.Invoke(@params);
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
public EnemyKillEventListener self;
}
public delegate void Awake_BeforeArgs(Params_Awake args);
public delegate void Awake_AfterArgs(Params_Awake args);
public delegate void Awake_WithArgs (Action<EnemyKillEventListener> orig, EnemyKillEventListener self);
public sealed class Params_OnEnable
{
public EnemyKillEventListener self;
}
public delegate void OnEnable_BeforeArgs(Params_OnEnable args);
public delegate void OnEnable_AfterArgs(Params_OnEnable args);
public delegate void OnEnable_WithArgs (Action<EnemyKillEventListener> orig, EnemyKillEventListener self);
public sealed class Params_OnDisable
{
public EnemyKillEventListener self;
}
public delegate void OnDisable_BeforeArgs(Params_OnDisable args);
public delegate void OnDisable_AfterArgs(Params_OnDisable args);
public delegate void OnDisable_WithArgs (Action<EnemyKillEventListener> orig, EnemyKillEventListener self);
public sealed class Params_Die
{
public EnemyKillEventListener self;
}
public delegate void Die_BeforeArgs(Params_Die args);
public delegate void Die_AfterArgs(Params_Die args);
public delegate void Die_WithArgs (Action<EnemyKillEventListener> orig, EnemyKillEventListener self);
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
public static event Delegates.Die_BeforeArgs Die
{
add
{

HookHandler._beforeDie += value;
HookHandler.HookDie();
}
remove => HookHandler._beforeDie -= value;
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
public static event Delegates.Die_AfterArgs Die
{
add
{

HookHandler._afterDie += value;
HookHandler.HookDie();
}
remove => HookHandler._afterDie -= value;
}
}

/// <summary>
/// Contains all On Hooks, even those that aren't in the On namespace such as API generated functions and property getters/setters
/// </summary>
public static class WithOrig
{
public static event On.EnemyKillEventListener.hook_Awake Awake
{
add => On.EnemyKillEventListener.Awake += value;
remove => On.EnemyKillEventListener.Awake -= value;
}
public static event On.EnemyKillEventListener.hook_OnEnable OnEnable
{
add => On.EnemyKillEventListener.OnEnable += value;
remove => On.EnemyKillEventListener.OnEnable -= value;
}
public static event On.EnemyKillEventListener.hook_OnDisable OnDisable
{
add => On.EnemyKillEventListener.OnDisable += value;
remove => On.EnemyKillEventListener.OnDisable -= value;
}
public static event On.EnemyKillEventListener.hook_Die Die
{
add => On.EnemyKillEventListener.Die += value;
remove => On.EnemyKillEventListener.Die -= value;
}
}

}
