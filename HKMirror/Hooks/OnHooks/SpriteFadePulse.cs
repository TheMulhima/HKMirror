using MonoMod.RuntimeDetour;
using MonoMod.RuntimeDetour.HookGen;
namespace HKMirror.Hooks.OnHooks;
/// <summary>
/// Contains different types of On Hooks for SpriteFadePulse class.<br />
/// Contains hooks that aren't generated by monomod, and before and after orig hooks for easier hooking.
/// </summary>
public static class OnSpriteFadePulse
{
internal static class HookHandler
{
private static List<string> HookedList = new List<string>();
internal static void HookAwake()
{
if (!HookedList.Contains("Awake"))
{
HookedList.Add("Awake");
On.SpriteFadePulse.Awake += Awake;

}
}
internal static event Delegates.Awake_BeforeArgs _beforeAwake;
internal static event Delegates.Awake_AfterArgs _afterAwake;
private static void Awake(On.SpriteFadePulse.orig_Awake orig,SpriteFadePulse self)
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
On.SpriteFadePulse.OnEnable += OnEnable;

}
}
internal static event Delegates.OnEnable_BeforeArgs _beforeOnEnable;
internal static event Delegates.OnEnable_AfterArgs _afterOnEnable;
private static void OnEnable(On.SpriteFadePulse.orig_OnEnable orig,SpriteFadePulse self)
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
On.SpriteFadePulse.Update += Update;

}
}
internal static event Delegates.Update_BeforeArgs _beforeUpdate;
internal static event Delegates.Update_AfterArgs _afterUpdate;
private static void Update(On.SpriteFadePulse.orig_Update orig,SpriteFadePulse self)
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
internal static void HookFadeIn()
{
if (!HookedList.Contains("FadeIn"))
{
HookedList.Add("FadeIn");
On.SpriteFadePulse.FadeIn += FadeIn;

}
}
internal static event Delegates.FadeIn_BeforeArgs _beforeFadeIn;
internal static event Delegates.FadeIn_AfterArgs _afterFadeIn;
private static void FadeIn(On.SpriteFadePulse.orig_FadeIn orig,SpriteFadePulse self)
{
Delegates.Params_FadeIn @params = new() 
{
self = self
};
if (_beforeFadeIn != null)
{
foreach (Delegates.FadeIn_BeforeArgs toInvoke in _beforeFadeIn.GetInvocationList())
{
try
{
_beforeFadeIn?.Invoke(@params);
}
catch (Exception e) 
{ HKMirrorMod.DoLogError(e);
}
}
}
self = @params.self;
orig(self);
if (_afterFadeIn != null)
{
foreach (Delegates.FadeIn_AfterArgs toInvoke in _afterFadeIn.GetInvocationList())
{
try
{
_afterFadeIn.Invoke(@params);
}
catch (Exception e) 
{ HKMirrorMod.DoLogError(e);
}
}
}
}
internal static void HookFadeOut()
{
if (!HookedList.Contains("FadeOut"))
{
HookedList.Add("FadeOut");
On.SpriteFadePulse.FadeOut += FadeOut;

}
}
internal static event Delegates.FadeOut_BeforeArgs _beforeFadeOut;
internal static event Delegates.FadeOut_AfterArgs _afterFadeOut;
private static void FadeOut(On.SpriteFadePulse.orig_FadeOut orig,SpriteFadePulse self)
{
Delegates.Params_FadeOut @params = new() 
{
self = self
};
if (_beforeFadeOut != null)
{
foreach (Delegates.FadeOut_BeforeArgs toInvoke in _beforeFadeOut.GetInvocationList())
{
try
{
_beforeFadeOut?.Invoke(@params);
}
catch (Exception e) 
{ HKMirrorMod.DoLogError(e);
}
}
}
self = @params.self;
orig(self);
if (_afterFadeOut != null)
{
foreach (Delegates.FadeOut_AfterArgs toInvoke in _afterFadeOut.GetInvocationList())
{
try
{
_afterFadeOut.Invoke(@params);
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
public SpriteFadePulse self;
}
public delegate void Awake_BeforeArgs(Params_Awake args);
public delegate void Awake_AfterArgs(Params_Awake args);
public delegate void Awake_WithArgs (Action<SpriteFadePulse> orig, SpriteFadePulse self);
public sealed class Params_OnEnable
{
public SpriteFadePulse self;
}
public delegate void OnEnable_BeforeArgs(Params_OnEnable args);
public delegate void OnEnable_AfterArgs(Params_OnEnable args);
public delegate void OnEnable_WithArgs (Action<SpriteFadePulse> orig, SpriteFadePulse self);
public sealed class Params_Update
{
public SpriteFadePulse self;
}
public delegate void Update_BeforeArgs(Params_Update args);
public delegate void Update_AfterArgs(Params_Update args);
public delegate void Update_WithArgs (Action<SpriteFadePulse> orig, SpriteFadePulse self);
public sealed class Params_FadeIn
{
public SpriteFadePulse self;
}
public delegate void FadeIn_BeforeArgs(Params_FadeIn args);
public delegate void FadeIn_AfterArgs(Params_FadeIn args);
public delegate void FadeIn_WithArgs (Action<SpriteFadePulse> orig, SpriteFadePulse self);
public sealed class Params_FadeOut
{
public SpriteFadePulse self;
}
public delegate void FadeOut_BeforeArgs(Params_FadeOut args);
public delegate void FadeOut_AfterArgs(Params_FadeOut args);
public delegate void FadeOut_WithArgs (Action<SpriteFadePulse> orig, SpriteFadePulse self);
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
public static event Delegates.Update_BeforeArgs Update
{
add
{

HookHandler._beforeUpdate += value;
HookHandler.HookUpdate();
}
remove => HookHandler._beforeUpdate -= value;
}
public static event Delegates.FadeIn_BeforeArgs FadeIn
{
add
{

HookHandler._beforeFadeIn += value;
HookHandler.HookFadeIn();
}
remove => HookHandler._beforeFadeIn -= value;
}
public static event Delegates.FadeOut_BeforeArgs FadeOut
{
add
{

HookHandler._beforeFadeOut += value;
HookHandler.HookFadeOut();
}
remove => HookHandler._beforeFadeOut -= value;
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
public static event Delegates.Update_AfterArgs Update
{
add
{

HookHandler._afterUpdate += value;
HookHandler.HookUpdate();
}
remove => HookHandler._afterUpdate -= value;
}
public static event Delegates.FadeIn_AfterArgs FadeIn
{
add
{

HookHandler._afterFadeIn += value;
HookHandler.HookFadeIn();
}
remove => HookHandler._afterFadeIn -= value;
}
public static event Delegates.FadeOut_AfterArgs FadeOut
{
add
{

HookHandler._afterFadeOut += value;
HookHandler.HookFadeOut();
}
remove => HookHandler._afterFadeOut -= value;
}
}

/// <summary>
/// Contains all On Hooks, even those that aren't in the On namespace such as API generated functions and property getters/setters
/// </summary>
public static class WithOrig
{
public static event On.SpriteFadePulse.hook_Awake Awake
{
add => On.SpriteFadePulse.Awake += value;
remove => On.SpriteFadePulse.Awake -= value;
}
public static event On.SpriteFadePulse.hook_OnEnable OnEnable
{
add => On.SpriteFadePulse.OnEnable += value;
remove => On.SpriteFadePulse.OnEnable -= value;
}
public static event On.SpriteFadePulse.hook_Update Update
{
add => On.SpriteFadePulse.Update += value;
remove => On.SpriteFadePulse.Update -= value;
}
public static event On.SpriteFadePulse.hook_FadeIn FadeIn
{
add => On.SpriteFadePulse.FadeIn += value;
remove => On.SpriteFadePulse.FadeIn -= value;
}
public static event On.SpriteFadePulse.hook_FadeOut FadeOut
{
add => On.SpriteFadePulse.FadeOut += value;
remove => On.SpriteFadePulse.FadeOut -= value;
}
}

}
