using MonoMod.RuntimeDetour;
using MonoMod.RuntimeDetour.HookGen;
namespace HKMirror.Hooks.OnHooks;
/// <summary>
/// Contains different types of On Hooks for GlowResponse class.<br />
/// Contains hooks that aren't generated by monomod, and before and after orig hooks for easier hooking.
/// </summary>
public static class OnGlowResponse
{
internal static class HookHandler
{
private static List<string> HookedList = new List<string>();
internal static void HookOnValidate()
{
if (!HookedList.Contains("OnValidate"))
{
HookedList.Add("OnValidate");
On.GlowResponse.OnValidate += OnValidate;

}
}
internal static event Delegates.OnValidate_BeforeArgs _beforeOnValidate;
internal static event Delegates.OnValidate_AfterArgs _afterOnValidate;
private static void OnValidate(On.GlowResponse.orig_OnValidate orig,GlowResponse self)
{
Delegates.Params_OnValidate @params = new() 
{
self = self
};
if (_beforeOnValidate != null)
{
foreach (Delegates.OnValidate_BeforeArgs toInvoke in _beforeOnValidate.GetInvocationList())
{
try
{
_beforeOnValidate?.Invoke(@params);
}
catch (Exception e) 
{ HKMirrorMod.DoLogError(e);
}
}
}
self = @params.self;
orig(self);
if (_afterOnValidate != null)
{
foreach (Delegates.OnValidate_AfterArgs toInvoke in _afterOnValidate.GetInvocationList())
{
try
{
_afterOnValidate.Invoke(@params);
}
catch (Exception e) 
{ HKMirrorMod.DoLogError(e);
}
}
}
}
internal static void HookAwake()
{
if (!HookedList.Contains("Awake"))
{
HookedList.Add("Awake");
On.GlowResponse.Awake += Awake;

}
}
internal static event Delegates.Awake_BeforeArgs _beforeAwake;
internal static event Delegates.Awake_AfterArgs _afterAwake;
private static void Awake(On.GlowResponse.orig_Awake orig,GlowResponse self)
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
internal static void HookHandleUpgrade()
{
if (!HookedList.Contains("HandleUpgrade"))
{
HookedList.Add("HandleUpgrade");
On.GlowResponse.HandleUpgrade += HandleUpgrade;

}
}
internal static event Delegates.HandleUpgrade_BeforeArgs _beforeHandleUpgrade;
internal static event Delegates.HandleUpgrade_AfterArgs _afterHandleUpgrade;
private static void HandleUpgrade(On.GlowResponse.orig_HandleUpgrade orig,GlowResponse self)
{
Delegates.Params_HandleUpgrade @params = new() 
{
self = self
};
if (_beforeHandleUpgrade != null)
{
foreach (Delegates.HandleUpgrade_BeforeArgs toInvoke in _beforeHandleUpgrade.GetInvocationList())
{
try
{
_beforeHandleUpgrade?.Invoke(@params);
}
catch (Exception e) 
{ HKMirrorMod.DoLogError(e);
}
}
}
self = @params.self;
orig(self);
if (_afterHandleUpgrade != null)
{
foreach (Delegates.HandleUpgrade_AfterArgs toInvoke in _afterHandleUpgrade.GetInvocationList())
{
try
{
_afterHandleUpgrade.Invoke(@params);
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
On.GlowResponse.Start += Start;

}
}
internal static event Delegates.Start_BeforeArgs _beforeStart;
internal static event Delegates.Start_AfterArgs _afterStart;
private static void Start(On.GlowResponse.orig_Start orig,GlowResponse self)
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
On.GlowResponse.OnTriggerEnter2D += OnTriggerEnter2D;

}
}
internal static event Delegates.OnTriggerEnter2D_BeforeArgs _beforeOnTriggerEnter2D;
internal static event Delegates.OnTriggerEnter2D_AfterArgs _afterOnTriggerEnter2D;
private static void OnTriggerEnter2D(On.GlowResponse.orig_OnTriggerEnter2D orig,GlowResponse self,  UnityEngine.Collider2D collision)
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
internal static void HookOnTriggerExit2D()
{
if (!HookedList.Contains("OnTriggerExit2D"))
{
HookedList.Add("OnTriggerExit2D");
On.GlowResponse.OnTriggerExit2D += OnTriggerExit2D;

}
}
internal static event Delegates.OnTriggerExit2D_BeforeArgs _beforeOnTriggerExit2D;
internal static event Delegates.OnTriggerExit2D_AfterArgs _afterOnTriggerExit2D;
private static void OnTriggerExit2D(On.GlowResponse.orig_OnTriggerExit2D orig,GlowResponse self,  UnityEngine.Collider2D collision)
{
Delegates.Params_OnTriggerExit2D @params = new() 
{
self = self
, collision = collision
};
if (_beforeOnTriggerExit2D != null)
{
foreach (Delegates.OnTriggerExit2D_BeforeArgs toInvoke in _beforeOnTriggerExit2D.GetInvocationList())
{
try
{
_beforeOnTriggerExit2D?.Invoke(@params);
}
catch (Exception e) 
{ HKMirrorMod.DoLogError(e);
}
}
}
self = @params.self;
collision = @params.collision;
orig(self, collision);
if (_afterOnTriggerExit2D != null)
{
foreach (Delegates.OnTriggerExit2D_AfterArgs toInvoke in _afterOnTriggerExit2D.GetInvocationList())
{
try
{
_afterOnTriggerExit2D.Invoke(@params);
}
catch (Exception e) 
{ HKMirrorMod.DoLogError(e);
}
}
}
}
internal static void HookFadeTo()
{
if (!HookedList.Contains("FadeTo"))
{
HookedList.Add("FadeTo");
On.GlowResponse.FadeTo += FadeTo;

}
}
internal static event Delegates.FadeTo_BeforeArgs _beforeFadeTo;
internal static event Delegates.FadeTo_AfterArgs _afterFadeTo;
private static void FadeTo(On.GlowResponse.orig_FadeTo orig,GlowResponse self,  float alpha)
{
Delegates.Params_FadeTo @params = new() 
{
self = self
, alpha = alpha
};
if (_beforeFadeTo != null)
{
foreach (Delegates.FadeTo_BeforeArgs toInvoke in _beforeFadeTo.GetInvocationList())
{
try
{
_beforeFadeTo?.Invoke(@params);
}
catch (Exception e) 
{ HKMirrorMod.DoLogError(e);
}
}
}
self = @params.self;
alpha = @params.alpha;
orig(self, alpha);
if (_afterFadeTo != null)
{
foreach (Delegates.FadeTo_AfterArgs toInvoke in _afterFadeTo.GetInvocationList())
{
try
{
_afterFadeTo.Invoke(@params);
}
catch (Exception e) 
{ HKMirrorMod.DoLogError(e);
}
}
}
}
internal static void HookFade()
{
if (!HookedList.Contains("Fade"))
{
HookedList.Add("Fade");
On.GlowResponse.Fade += Fade;

}
}
internal static event Delegates.Fade_BeforeArgs _beforeFade;
private static System.Collections.IEnumerator Fade(On.GlowResponse.orig_Fade orig,GlowResponse self,  float toAlpha,  UnityEngine.SpriteRenderer sprite)
{
Delegates.Params_Fade @params = new() 
{
self = self
, toAlpha = toAlpha
, sprite = sprite
};
if (_beforeFade != null)
{
foreach (Delegates.Fade_BeforeArgs toInvoke in _beforeFade.GetInvocationList())
{
try
{
_beforeFade?.Invoke(@params);
}
catch (Exception e) 
{ HKMirrorMod.DoLogError(e);
}
}
}
self = @params.self;
toAlpha = @params.toAlpha;
sprite = @params.sprite;
return orig(self, toAlpha, sprite);
}
internal static void HookFadeEnd()
{
if (!HookedList.Contains("FadeEnd"))
{
HookedList.Add("FadeEnd");
On.GlowResponse.FadeEnd += FadeEnd;

}
}
internal static event Delegates.FadeEnd_BeforeArgs _beforeFadeEnd;
internal static event Delegates.FadeEnd_AfterArgs _afterFadeEnd;
private static void FadeEnd(On.GlowResponse.orig_FadeEnd orig,GlowResponse self)
{
Delegates.Params_FadeEnd @params = new() 
{
self = self
};
if (_beforeFadeEnd != null)
{
foreach (Delegates.FadeEnd_BeforeArgs toInvoke in _beforeFadeEnd.GetInvocationList())
{
try
{
_beforeFadeEnd?.Invoke(@params);
}
catch (Exception e) 
{ HKMirrorMod.DoLogError(e);
}
}
}
self = @params.self;
orig(self);
if (_afterFadeEnd != null)
{
foreach (Delegates.FadeEnd_AfterArgs toInvoke in _afterFadeEnd.GetInvocationList())
{
try
{
_afterFadeEnd.Invoke(@params);
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
public sealed class Params_OnValidate
{
public GlowResponse self;
}
public delegate void OnValidate_BeforeArgs(Params_OnValidate args);
public delegate void OnValidate_AfterArgs(Params_OnValidate args);
public delegate void OnValidate_WithArgs (Action<GlowResponse> orig, GlowResponse self);
public sealed class Params_Awake
{
public GlowResponse self;
}
public delegate void Awake_BeforeArgs(Params_Awake args);
public delegate void Awake_AfterArgs(Params_Awake args);
public delegate void Awake_WithArgs (Action<GlowResponse> orig, GlowResponse self);
public sealed class Params_HandleUpgrade
{
public GlowResponse self;
}
public delegate void HandleUpgrade_BeforeArgs(Params_HandleUpgrade args);
public delegate void HandleUpgrade_AfterArgs(Params_HandleUpgrade args);
public delegate void HandleUpgrade_WithArgs (Action<GlowResponse> orig, GlowResponse self);
public sealed class Params_Start
{
public GlowResponse self;
}
public delegate void Start_BeforeArgs(Params_Start args);
public delegate void Start_AfterArgs(Params_Start args);
public delegate void Start_WithArgs (Action<GlowResponse> orig, GlowResponse self);
public sealed class Params_OnTriggerEnter2D
{
public GlowResponse self;
public UnityEngine.Collider2D collision;
}
public delegate void OnTriggerEnter2D_BeforeArgs(Params_OnTriggerEnter2D args);
public delegate void OnTriggerEnter2D_AfterArgs(Params_OnTriggerEnter2D args);
public delegate void OnTriggerEnter2D_WithArgs (Action<GlowResponse,  UnityEngine.Collider2D> orig, GlowResponse self,  UnityEngine.Collider2D collision);
public sealed class Params_OnTriggerExit2D
{
public GlowResponse self;
public UnityEngine.Collider2D collision;
}
public delegate void OnTriggerExit2D_BeforeArgs(Params_OnTriggerExit2D args);
public delegate void OnTriggerExit2D_AfterArgs(Params_OnTriggerExit2D args);
public delegate void OnTriggerExit2D_WithArgs (Action<GlowResponse,  UnityEngine.Collider2D> orig, GlowResponse self,  UnityEngine.Collider2D collision);
public sealed class Params_FadeTo
{
public GlowResponse self;
public float alpha;
}
public delegate void FadeTo_BeforeArgs(Params_FadeTo args);
public delegate void FadeTo_AfterArgs(Params_FadeTo args);
public delegate void FadeTo_WithArgs (Action<GlowResponse,  float> orig, GlowResponse self,  float alpha);
public sealed class Params_Fade
{
public GlowResponse self;
public float toAlpha;
public UnityEngine.SpriteRenderer sprite;
}
public delegate void Fade_BeforeArgs(Params_Fade args);
public delegate System.Collections.IEnumerator Fade_AfterArgs(Params_Fade args, System.Collections.IEnumerator ret);
public delegate System.Collections.IEnumerator Fade_WithArgs (Func<GlowResponse,  float,  UnityEngine.SpriteRenderer, System.Collections.IEnumerator> orig, GlowResponse self,  float toAlpha,  UnityEngine.SpriteRenderer sprite);
public sealed class Params_FadeEnd
{
public GlowResponse self;
}
public delegate void FadeEnd_BeforeArgs(Params_FadeEnd args);
public delegate void FadeEnd_AfterArgs(Params_FadeEnd args);
public delegate void FadeEnd_WithArgs (Action<GlowResponse> orig, GlowResponse self);
}

/// <summary>
/// Contains Hooks to that run code before orig(self) is called
/// </summary>
public static class BeforeOrig
{
public static event Delegates.OnValidate_BeforeArgs OnValidate
{
add
{

HookHandler._beforeOnValidate += value;
HookHandler.HookOnValidate();
}
remove => HookHandler._beforeOnValidate -= value;
}
public static event Delegates.Awake_BeforeArgs Awake
{
add
{

HookHandler._beforeAwake += value;
HookHandler.HookAwake();
}
remove => HookHandler._beforeAwake -= value;
}
public static event Delegates.HandleUpgrade_BeforeArgs HandleUpgrade
{
add
{

HookHandler._beforeHandleUpgrade += value;
HookHandler.HookHandleUpgrade();
}
remove => HookHandler._beforeHandleUpgrade -= value;
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
public static event Delegates.OnTriggerExit2D_BeforeArgs OnTriggerExit2D
{
add
{

HookHandler._beforeOnTriggerExit2D += value;
HookHandler.HookOnTriggerExit2D();
}
remove => HookHandler._beforeOnTriggerExit2D -= value;
}
public static event Delegates.FadeTo_BeforeArgs FadeTo
{
add
{

HookHandler._beforeFadeTo += value;
HookHandler.HookFadeTo();
}
remove => HookHandler._beforeFadeTo -= value;
}
public static event Delegates.Fade_BeforeArgs Fade
{
add
{

HookHandler._beforeFade += value;
HookHandler.HookFade();
}
remove => HookHandler._beforeFade -= value;
}
public static event Delegates.FadeEnd_BeforeArgs FadeEnd
{
add
{

HookHandler._beforeFadeEnd += value;
HookHandler.HookFadeEnd();
}
remove => HookHandler._beforeFadeEnd -= value;
}
}

/// <summary>
/// Contains Hooks to that run code after orig(self) is called
/// </summary>
public static class AfterOrig
{
public static event Delegates.OnValidate_AfterArgs OnValidate
{
add
{

HookHandler._afterOnValidate += value;
HookHandler.HookOnValidate();
}
remove => HookHandler._afterOnValidate -= value;
}
public static event Delegates.Awake_AfterArgs Awake
{
add
{

HookHandler._afterAwake += value;
HookHandler.HookAwake();
}
remove => HookHandler._afterAwake -= value;
}
public static event Delegates.HandleUpgrade_AfterArgs HandleUpgrade
{
add
{

HookHandler._afterHandleUpgrade += value;
HookHandler.HookHandleUpgrade();
}
remove => HookHandler._afterHandleUpgrade -= value;
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
public static event Delegates.OnTriggerExit2D_AfterArgs OnTriggerExit2D
{
add
{

HookHandler._afterOnTriggerExit2D += value;
HookHandler.HookOnTriggerExit2D();
}
remove => HookHandler._afterOnTriggerExit2D -= value;
}
public static event Delegates.FadeTo_AfterArgs FadeTo
{
add
{

HookHandler._afterFadeTo += value;
HookHandler.HookFadeTo();
}
remove => HookHandler._afterFadeTo -= value;
}
public static event Delegates.FadeEnd_AfterArgs FadeEnd
{
add
{

HookHandler._afterFadeEnd += value;
HookHandler.HookFadeEnd();
}
remove => HookHandler._afterFadeEnd -= value;
}
}

/// <summary>
/// Contains all On Hooks, even those that aren't in the On namespace such as API generated functions and property getters/setters
/// </summary>
public static class WithOrig
{
public static event On.GlowResponse.hook_OnValidate OnValidate
{
add => On.GlowResponse.OnValidate += value;
remove => On.GlowResponse.OnValidate -= value;
}
public static event On.GlowResponse.hook_Awake Awake
{
add => On.GlowResponse.Awake += value;
remove => On.GlowResponse.Awake -= value;
}
public static event On.GlowResponse.hook_HandleUpgrade HandleUpgrade
{
add => On.GlowResponse.HandleUpgrade += value;
remove => On.GlowResponse.HandleUpgrade -= value;
}
public static event On.GlowResponse.hook_Start Start
{
add => On.GlowResponse.Start += value;
remove => On.GlowResponse.Start -= value;
}
public static event On.GlowResponse.hook_OnTriggerEnter2D OnTriggerEnter2D
{
add => On.GlowResponse.OnTriggerEnter2D += value;
remove => On.GlowResponse.OnTriggerEnter2D -= value;
}
public static event On.GlowResponse.hook_OnTriggerExit2D OnTriggerExit2D
{
add => On.GlowResponse.OnTriggerExit2D += value;
remove => On.GlowResponse.OnTriggerExit2D -= value;
}
public static event On.GlowResponse.hook_FadeTo FadeTo
{
add => On.GlowResponse.FadeTo += value;
remove => On.GlowResponse.FadeTo -= value;
}
public static event On.GlowResponse.hook_Fade Fade
{
add => On.GlowResponse.Fade += value;
remove => On.GlowResponse.Fade -= value;
}
public static event On.GlowResponse.hook_FadeEnd FadeEnd
{
add => On.GlowResponse.FadeEnd += value;
remove => On.GlowResponse.FadeEnd -= value;
}
}

}
