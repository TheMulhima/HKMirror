using MonoMod.RuntimeDetour;
using MonoMod.RuntimeDetour.HookGen;
namespace HKMirror.Hooks.OnHooks;
/// <summary>
/// Contains different types of On Hooks for CorpseDeathStunChunker class.<br />
/// Contains hooks that aren't generated by monomod, and before and after orig hooks for easier hooking.
/// </summary>
public static class OnCorpseDeathStunChunker
{
internal static class HookHandler
{
private static List<string> HookedList = new List<string>();
internal static void HookStart()
{
if (!HookedList.Contains("Start"))
{
HookedList.Add("Start");
On.CorpseDeathStunChunker.Start += Start;

}
}
internal static event Delegates.Start_BeforeArgs _beforeStart;
internal static event Delegates.Start_AfterArgs _afterStart;
private static void Start(On.CorpseDeathStunChunker.orig_Start orig,CorpseDeathStunChunker self)
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
internal static void HookDeathStun()
{
if (!HookedList.Contains("DeathStun"))
{
HookedList.Add("DeathStun");
On.CorpseDeathStunChunker.DeathStun += DeathStun;

}
}
internal static event Delegates.DeathStun_BeforeArgs _beforeDeathStun;
private static System.Collections.IEnumerator DeathStun(On.CorpseDeathStunChunker.orig_DeathStun orig,CorpseDeathStunChunker self)
{
Delegates.Params_DeathStun @params = new() 
{
self = self
};
if (_beforeDeathStun != null)
{
foreach (Delegates.DeathStun_BeforeArgs toInvoke in _beforeDeathStun.GetInvocationList())
{
try
{
_beforeDeathStun?.Invoke(@params);
}
catch (Exception e) 
{ HKMirrorMod.DoLogError(e);
}
}
}
self = @params.self;
return orig(self);
}
internal static void HookJitter()
{
if (!HookedList.Contains("Jitter"))
{
HookedList.Add("Jitter");
On.CorpseDeathStunChunker.Jitter += Jitter;

}
}
internal static event Delegates.Jitter_BeforeArgs _beforeJitter;
private static System.Collections.IEnumerator Jitter(On.CorpseDeathStunChunker.orig_Jitter orig,CorpseDeathStunChunker self,  float duration)
{
Delegates.Params_Jitter @params = new() 
{
self = self
, duration = duration
};
if (_beforeJitter != null)
{
foreach (Delegates.Jitter_BeforeArgs toInvoke in _beforeJitter.GetInvocationList())
{
try
{
_beforeJitter?.Invoke(@params);
}
catch (Exception e) 
{ HKMirrorMod.DoLogError(e);
}
}
}
self = @params.self;
duration = @params.duration;
return orig(self, duration);
}
}

/// <summary>
/// Contains necessary information to create Hooks. Does not contain any hooks
/// </summary>
public static class Delegates
{
public sealed class Params_Start
{
public CorpseDeathStunChunker self;
}
public delegate void Start_BeforeArgs(Params_Start args);
public delegate void Start_AfterArgs(Params_Start args);
public delegate void Start_WithArgs (Action<CorpseDeathStunChunker> orig, CorpseDeathStunChunker self);
public sealed class Params_DeathStun
{
public CorpseDeathStunChunker self;
}
public delegate void DeathStun_BeforeArgs(Params_DeathStun args);
public delegate System.Collections.IEnumerator DeathStun_AfterArgs(Params_DeathStun args, System.Collections.IEnumerator ret);
public delegate System.Collections.IEnumerator DeathStun_WithArgs (Func<CorpseDeathStunChunker, System.Collections.IEnumerator> orig, CorpseDeathStunChunker self);
public sealed class Params_Jitter
{
public CorpseDeathStunChunker self;
public float duration;
}
public delegate void Jitter_BeforeArgs(Params_Jitter args);
public delegate System.Collections.IEnumerator Jitter_AfterArgs(Params_Jitter args, System.Collections.IEnumerator ret);
public delegate System.Collections.IEnumerator Jitter_WithArgs (Func<CorpseDeathStunChunker,  float, System.Collections.IEnumerator> orig, CorpseDeathStunChunker self,  float duration);
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
public static event Delegates.DeathStun_BeforeArgs DeathStun
{
add
{

HookHandler._beforeDeathStun += value;
HookHandler.HookDeathStun();
}
remove => HookHandler._beforeDeathStun -= value;
}
public static event Delegates.Jitter_BeforeArgs Jitter
{
add
{

HookHandler._beforeJitter += value;
HookHandler.HookJitter();
}
remove => HookHandler._beforeJitter -= value;
}
}

/// <summary>
/// Contains Hooks to that run code after orig(self) is called
/// </summary>
public static class AfterOrig
{
public static event Delegates.Start_AfterArgs Start
{
add
{

HookHandler._afterStart += value;
HookHandler.HookStart();
}
remove => HookHandler._afterStart -= value;
}
}

/// <summary>
/// Contains all On Hooks, even those that aren't in the On namespace such as API generated functions and property getters/setters
/// </summary>
public static class WithOrig
{
public static event On.CorpseDeathStunChunker.hook_Start Start
{
add => On.CorpseDeathStunChunker.Start += value;
remove => On.CorpseDeathStunChunker.Start -= value;
}
public static event On.CorpseDeathStunChunker.hook_DeathStun DeathStun
{
add => On.CorpseDeathStunChunker.DeathStun += value;
remove => On.CorpseDeathStunChunker.DeathStun -= value;
}
public static event On.CorpseDeathStunChunker.hook_Jitter Jitter
{
add => On.CorpseDeathStunChunker.Jitter += value;
remove => On.CorpseDeathStunChunker.Jitter -= value;
}
}

}
