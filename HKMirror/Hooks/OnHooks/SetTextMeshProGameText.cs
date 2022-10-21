using MonoMod.RuntimeDetour;
using MonoMod.RuntimeDetour.HookGen;
namespace HKMirror.Hooks.OnHooks;
/// <summary>
/// Contains different types of On Hooks for SetTextMeshProGameText class.<br />
/// Contains hooks that aren't generated by monomod, and before and after orig hooks for easier hooking.
/// </summary>
public static class OnSetTextMeshProGameText
{
internal static class HookHandler
{
private static List<string> HookedList = new List<string>();
internal static void HookAwake()
{
if (!HookedList.Contains("Awake"))
{
HookedList.Add("Awake");
On.SetTextMeshProGameText.Awake += Awake;

}
}
internal static event Delegates.Awake_BeforeArgs _beforeAwake;
internal static event Delegates.Awake_AfterArgs _afterAwake;
private static void Awake(On.SetTextMeshProGameText.orig_Awake orig,SetTextMeshProGameText self)
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
On.SetTextMeshProGameText.Start += Start;

}
}
internal static event Delegates.Start_BeforeArgs _beforeStart;
internal static event Delegates.Start_AfterArgs _afterStart;
private static void Start(On.SetTextMeshProGameText.orig_Start orig,SetTextMeshProGameText self)
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
internal static void HookUpdateText()
{
if (!HookedList.Contains("UpdateText"))
{
HookedList.Add("UpdateText");
On.SetTextMeshProGameText.UpdateText += UpdateText;

}
}
internal static event Delegates.UpdateText_BeforeArgs _beforeUpdateText;
internal static event Delegates.UpdateText_AfterArgs _afterUpdateText;
private static void UpdateText(On.SetTextMeshProGameText.orig_UpdateText orig,SetTextMeshProGameText self)
{
Delegates.Params_UpdateText @params = new() 
{
self = self
};
if (_beforeUpdateText != null)
{
foreach (Delegates.UpdateText_BeforeArgs toInvoke in _beforeUpdateText.GetInvocationList())
{
try
{
_beforeUpdateText?.Invoke(@params);
}
catch (Exception e) 
{ HKMirrorMod.DoLogError(e);
}
}
}
self = @params.self;
orig(self);
if (_afterUpdateText != null)
{
foreach (Delegates.UpdateText_AfterArgs toInvoke in _afterUpdateText.GetInvocationList())
{
try
{
_afterUpdateText.Invoke(@params);
}
catch (Exception e) 
{ HKMirrorMod.DoLogError(e);
}
}
}
}
internal static void HookChangedLanguage()
{
if (!HookedList.Contains("ChangedLanguage"))
{
HookedList.Add("ChangedLanguage");
On.SetTextMeshProGameText.ChangedLanguage += ChangedLanguage;

}
}
internal static event Delegates.ChangedLanguage_BeforeArgs _beforeChangedLanguage;
internal static event Delegates.ChangedLanguage_AfterArgs _afterChangedLanguage;
private static void ChangedLanguage(On.SetTextMeshProGameText.orig_ChangedLanguage orig,SetTextMeshProGameText self,  Language.LanguageCode code)
{
Delegates.Params_ChangedLanguage @params = new() 
{
self = self
, code = code
};
if (_beforeChangedLanguage != null)
{
foreach (Delegates.ChangedLanguage_BeforeArgs toInvoke in _beforeChangedLanguage.GetInvocationList())
{
try
{
_beforeChangedLanguage?.Invoke(@params);
}
catch (Exception e) 
{ HKMirrorMod.DoLogError(e);
}
}
}
self = @params.self;
code = @params.code;
orig(self, code);
if (_afterChangedLanguage != null)
{
foreach (Delegates.ChangedLanguage_AfterArgs toInvoke in _afterChangedLanguage.GetInvocationList())
{
try
{
_afterChangedLanguage.Invoke(@params);
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
public SetTextMeshProGameText self;
}
public delegate void Awake_BeforeArgs(Params_Awake args);
public delegate void Awake_AfterArgs(Params_Awake args);
public delegate void Awake_WithArgs (Action<SetTextMeshProGameText> orig, SetTextMeshProGameText self);
public sealed class Params_Start
{
public SetTextMeshProGameText self;
}
public delegate void Start_BeforeArgs(Params_Start args);
public delegate void Start_AfterArgs(Params_Start args);
public delegate void Start_WithArgs (Action<SetTextMeshProGameText> orig, SetTextMeshProGameText self);
public sealed class Params_UpdateText
{
public SetTextMeshProGameText self;
}
public delegate void UpdateText_BeforeArgs(Params_UpdateText args);
public delegate void UpdateText_AfterArgs(Params_UpdateText args);
public delegate void UpdateText_WithArgs (Action<SetTextMeshProGameText> orig, SetTextMeshProGameText self);
public sealed class Params_ChangedLanguage
{
public SetTextMeshProGameText self;
public Language.LanguageCode code;
}
public delegate void ChangedLanguage_BeforeArgs(Params_ChangedLanguage args);
public delegate void ChangedLanguage_AfterArgs(Params_ChangedLanguage args);
public delegate void ChangedLanguage_WithArgs (Action<SetTextMeshProGameText,  Language.LanguageCode> orig, SetTextMeshProGameText self,  Language.LanguageCode code);
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
public static event Delegates.UpdateText_BeforeArgs UpdateText
{
add
{

HookHandler._beforeUpdateText += value;
HookHandler.HookUpdateText();
}
remove => HookHandler._beforeUpdateText -= value;
}
public static event Delegates.ChangedLanguage_BeforeArgs ChangedLanguage
{
add
{

HookHandler._beforeChangedLanguage += value;
HookHandler.HookChangedLanguage();
}
remove => HookHandler._beforeChangedLanguage -= value;
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
public static event Delegates.UpdateText_AfterArgs UpdateText
{
add
{

HookHandler._afterUpdateText += value;
HookHandler.HookUpdateText();
}
remove => HookHandler._afterUpdateText -= value;
}
public static event Delegates.ChangedLanguage_AfterArgs ChangedLanguage
{
add
{

HookHandler._afterChangedLanguage += value;
HookHandler.HookChangedLanguage();
}
remove => HookHandler._afterChangedLanguage -= value;
}
}

/// <summary>
/// Contains all On Hooks, even those that aren't in the On namespace such as API generated functions and property getters/setters
/// </summary>
public static class WithOrig
{
public static event On.SetTextMeshProGameText.hook_Awake Awake
{
add => On.SetTextMeshProGameText.Awake += value;
remove => On.SetTextMeshProGameText.Awake -= value;
}
public static event On.SetTextMeshProGameText.hook_Start Start
{
add => On.SetTextMeshProGameText.Start += value;
remove => On.SetTextMeshProGameText.Start -= value;
}
public static event On.SetTextMeshProGameText.hook_UpdateText UpdateText
{
add => On.SetTextMeshProGameText.UpdateText += value;
remove => On.SetTextMeshProGameText.UpdateText -= value;
}
public static event On.SetTextMeshProGameText.hook_ChangedLanguage ChangedLanguage
{
add => On.SetTextMeshProGameText.ChangedLanguage += value;
remove => On.SetTextMeshProGameText.ChangedLanguage -= value;
}
}

}
