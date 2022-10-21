using MonoMod.RuntimeDetour;
using MonoMod.RuntimeDetour.HookGen;
namespace HKMirror.Hooks.OnHooks;
/// <summary>
/// Contains different types of On Hooks for BuildMetadata class.<br />
/// Contains hooks that aren't generated by monomod, and before and after orig hooks for easier hooking.
/// </summary>
public static class OnBuildMetadata
{
internal static class HookHandler
{
private static List<string> HookedList = new List<string>();
internal static void Hookget_BranchName()
{
if (!HookedList.Contains("get_BranchName"))
{
HookedList.Add("get_BranchName");
new Hook(ReflectionHelper.GetMethodInfo(typeof(BuildMetadata), "get_BranchName", true), get_BranchName);

}
}
internal static event Delegates.get_BranchName_BeforeArgs _beforeget_BranchName;
internal static event Delegates.get_BranchName_AfterArgs _afterget_BranchName;
private static string get_BranchName(Func<BuildMetadata, string> orig, BuildMetadata self)
{
Delegates.Params_get_BranchName @params = new() 
{
self = self
};
if (_beforeget_BranchName != null)
{
foreach (Delegates.get_BranchName_BeforeArgs toInvoke in _beforeget_BranchName.GetInvocationList())
{
try
{
_beforeget_BranchName?.Invoke(@params);
}
catch (Exception e) 
{ HKMirrorMod.DoLogError(e);
}
}
}
self = @params.self;
var retVal = orig(self);
if (_afterget_BranchName != null)
{
foreach (Delegates.get_BranchName_AfterArgs toInvoke in _afterget_BranchName.GetInvocationList())
{
try
{
retVal = _afterget_BranchName.Invoke(@params, retVal);
}
catch (Exception e) 
{ HKMirrorMod.DoLogError(e);
}
}
}
return retVal;
}
internal static void Hookget_Revision()
{
if (!HookedList.Contains("get_Revision"))
{
HookedList.Add("get_Revision");
new Hook(ReflectionHelper.GetMethodInfo(typeof(BuildMetadata), "get_Revision", true), get_Revision);

}
}
internal static event Delegates.get_Revision_BeforeArgs _beforeget_Revision;
internal static event Delegates.get_Revision_AfterArgs _afterget_Revision;
private static string get_Revision(Func<BuildMetadata, string> orig, BuildMetadata self)
{
Delegates.Params_get_Revision @params = new() 
{
self = self
};
if (_beforeget_Revision != null)
{
foreach (Delegates.get_Revision_BeforeArgs toInvoke in _beforeget_Revision.GetInvocationList())
{
try
{
_beforeget_Revision?.Invoke(@params);
}
catch (Exception e) 
{ HKMirrorMod.DoLogError(e);
}
}
}
self = @params.self;
var retVal = orig(self);
if (_afterget_Revision != null)
{
foreach (Delegates.get_Revision_AfterArgs toInvoke in _afterget_Revision.GetInvocationList())
{
try
{
retVal = _afterget_Revision.Invoke(@params, retVal);
}
catch (Exception e) 
{ HKMirrorMod.DoLogError(e);
}
}
}
return retVal;
}
internal static void Hookget_CommitTime()
{
if (!HookedList.Contains("get_CommitTime"))
{
HookedList.Add("get_CommitTime");
new Hook(ReflectionHelper.GetMethodInfo(typeof(BuildMetadata), "get_CommitTime", true), get_CommitTime);

}
}
internal static event Delegates.get_CommitTime_BeforeArgs _beforeget_CommitTime;
internal static event Delegates.get_CommitTime_AfterArgs _afterget_CommitTime;
private static System.DateTime get_CommitTime(Func<BuildMetadata, System.DateTime> orig, BuildMetadata self)
{
Delegates.Params_get_CommitTime @params = new() 
{
self = self
};
if (_beforeget_CommitTime != null)
{
foreach (Delegates.get_CommitTime_BeforeArgs toInvoke in _beforeget_CommitTime.GetInvocationList())
{
try
{
_beforeget_CommitTime?.Invoke(@params);
}
catch (Exception e) 
{ HKMirrorMod.DoLogError(e);
}
}
}
self = @params.self;
var retVal = orig(self);
if (_afterget_CommitTime != null)
{
foreach (Delegates.get_CommitTime_AfterArgs toInvoke in _afterget_CommitTime.GetInvocationList())
{
try
{
retVal = _afterget_CommitTime.Invoke(@params, retVal);
}
catch (Exception e) 
{ HKMirrorMod.DoLogError(e);
}
}
}
return retVal;
}
internal static void Hookget_MachineName()
{
if (!HookedList.Contains("get_MachineName"))
{
HookedList.Add("get_MachineName");
new Hook(ReflectionHelper.GetMethodInfo(typeof(BuildMetadata), "get_MachineName", true), get_MachineName);

}
}
internal static event Delegates.get_MachineName_BeforeArgs _beforeget_MachineName;
internal static event Delegates.get_MachineName_AfterArgs _afterget_MachineName;
private static string get_MachineName(Func<BuildMetadata, string> orig, BuildMetadata self)
{
Delegates.Params_get_MachineName @params = new() 
{
self = self
};
if (_beforeget_MachineName != null)
{
foreach (Delegates.get_MachineName_BeforeArgs toInvoke in _beforeget_MachineName.GetInvocationList())
{
try
{
_beforeget_MachineName?.Invoke(@params);
}
catch (Exception e) 
{ HKMirrorMod.DoLogError(e);
}
}
}
self = @params.self;
var retVal = orig(self);
if (_afterget_MachineName != null)
{
foreach (Delegates.get_MachineName_AfterArgs toInvoke in _afterget_MachineName.GetInvocationList())
{
try
{
retVal = _afterget_MachineName.Invoke(@params, retVal);
}
catch (Exception e) 
{ HKMirrorMod.DoLogError(e);
}
}
}
return retVal;
}
internal static void Hookget_BuildTime()
{
if (!HookedList.Contains("get_BuildTime"))
{
HookedList.Add("get_BuildTime");
new Hook(ReflectionHelper.GetMethodInfo(typeof(BuildMetadata), "get_BuildTime", true), get_BuildTime);

}
}
internal static event Delegates.get_BuildTime_BeforeArgs _beforeget_BuildTime;
internal static event Delegates.get_BuildTime_AfterArgs _afterget_BuildTime;
private static System.DateTime get_BuildTime(Func<BuildMetadata, System.DateTime> orig, BuildMetadata self)
{
Delegates.Params_get_BuildTime @params = new() 
{
self = self
};
if (_beforeget_BuildTime != null)
{
foreach (Delegates.get_BuildTime_BeforeArgs toInvoke in _beforeget_BuildTime.GetInvocationList())
{
try
{
_beforeget_BuildTime?.Invoke(@params);
}
catch (Exception e) 
{ HKMirrorMod.DoLogError(e);
}
}
}
self = @params.self;
var retVal = orig(self);
if (_afterget_BuildTime != null)
{
foreach (Delegates.get_BuildTime_AfterArgs toInvoke in _afterget_BuildTime.GetInvocationList())
{
try
{
retVal = _afterget_BuildTime.Invoke(@params, retVal);
}
catch (Exception e) 
{ HKMirrorMod.DoLogError(e);
}
}
}
return retVal;
}
internal static void Hookget_Embedded()
{
if (!HookedList.Contains("get_Embedded"))
{
HookedList.Add("get_Embedded");
new Hook(ReflectionHelper.GetMethodInfo(typeof(BuildMetadata), "get_Embedded", false), get_Embedded);

}
}
internal static event Delegates.get_Embedded_BeforeArgs _beforeget_Embedded;
internal static event Delegates.get_Embedded_AfterArgs _afterget_Embedded;
private static BuildMetadata get_Embedded(Func<BuildMetadata> orig)
{
if (_beforeget_Embedded != null)
{
foreach (Delegates.get_Embedded_BeforeArgs toInvoke in _beforeget_Embedded.GetInvocationList())
{
try
{
_beforeget_Embedded?.Invoke();
}
catch (Exception e) 
{ HKMirrorMod.DoLogError(e);
}
}
}
var retVal = orig();
if (_afterget_Embedded != null)
{
foreach (Delegates.get_Embedded_AfterArgs toInvoke in _afterget_Embedded.GetInvocationList())
{
try
{
retVal = _afterget_Embedded.Invoke(retVal);
}
catch (Exception e) 
{ HKMirrorMod.DoLogError(e);
}
}
}
return retVal;
}
internal static void HookCreate()
{
if (!HookedList.Contains("Create"))
{
HookedList.Add("Create");
On.BuildMetadata.Create += Create;

}
}
internal static event Delegates.Create_BeforeArgs _beforeCreate;
internal static event Delegates.Create_AfterArgs _afterCreate;
private static BuildMetadata Create(On.BuildMetadata.orig_Create orig, string branchName,  string revision,  System.DateTime commitTime,  string machineName,  System.DateTime buildTime)
{
Delegates.Params_Create @params = new() 
{
branchName = branchName
, revision = revision
, commitTime = commitTime
, machineName = machineName
, buildTime = buildTime
};
if (_beforeCreate != null)
{
foreach (Delegates.Create_BeforeArgs toInvoke in _beforeCreate.GetInvocationList())
{
try
{
_beforeCreate?.Invoke(@params);
}
catch (Exception e) 
{ HKMirrorMod.DoLogError(e);
}
}
}
branchName = @params.branchName;
revision = @params.revision;
commitTime = @params.commitTime;
machineName = @params.machineName;
buildTime = @params.buildTime;
var retVal = orig(branchName, revision, commitTime, machineName, buildTime);
if (_afterCreate != null)
{
foreach (Delegates.Create_AfterArgs toInvoke in _afterCreate.GetInvocationList())
{
try
{
retVal = _afterCreate.Invoke(@params, retVal);
}
catch (Exception e) 
{ HKMirrorMod.DoLogError(e);
}
}
}
return retVal;
}
}

/// <summary>
/// Contains necessary information to create Hooks. Does not contain any hooks
/// </summary>
public static class Delegates
{
public sealed class Params_get_BranchName
{
public BuildMetadata self;
}
public delegate void get_BranchName_BeforeArgs(Params_get_BranchName args);
public delegate string get_BranchName_AfterArgs(Params_get_BranchName args, string ret);
public delegate string get_BranchName_WithArgs (Func<BuildMetadata, string> orig, BuildMetadata self);
public sealed class Params_get_Revision
{
public BuildMetadata self;
}
public delegate void get_Revision_BeforeArgs(Params_get_Revision args);
public delegate string get_Revision_AfterArgs(Params_get_Revision args, string ret);
public delegate string get_Revision_WithArgs (Func<BuildMetadata, string> orig, BuildMetadata self);
public sealed class Params_get_CommitTime
{
public BuildMetadata self;
}
public delegate void get_CommitTime_BeforeArgs(Params_get_CommitTime args);
public delegate System.DateTime get_CommitTime_AfterArgs(Params_get_CommitTime args, System.DateTime ret);
public delegate System.DateTime get_CommitTime_WithArgs (Func<BuildMetadata, System.DateTime> orig, BuildMetadata self);
public sealed class Params_get_MachineName
{
public BuildMetadata self;
}
public delegate void get_MachineName_BeforeArgs(Params_get_MachineName args);
public delegate string get_MachineName_AfterArgs(Params_get_MachineName args, string ret);
public delegate string get_MachineName_WithArgs (Func<BuildMetadata, string> orig, BuildMetadata self);
public sealed class Params_get_BuildTime
{
public BuildMetadata self;
}
public delegate void get_BuildTime_BeforeArgs(Params_get_BuildTime args);
public delegate System.DateTime get_BuildTime_AfterArgs(Params_get_BuildTime args, System.DateTime ret);
public delegate System.DateTime get_BuildTime_WithArgs (Func<BuildMetadata, System.DateTime> orig, BuildMetadata self);
public delegate void get_Embedded_BeforeArgs();
public delegate BuildMetadata get_Embedded_AfterArgs(BuildMetadata ret);
public delegate BuildMetadata get_Embedded_WithArgs (Func<BuildMetadata> orig);
public sealed class Params_Create
{
public string branchName;
public string revision;
public System.DateTime commitTime;
public string machineName;
public System.DateTime buildTime;
}
public delegate void Create_BeforeArgs(Params_Create args);
public delegate BuildMetadata Create_AfterArgs(Params_Create args, BuildMetadata ret);
public delegate BuildMetadata Create_WithArgs (Func< string,  string,  System.DateTime,  string,  System.DateTime, BuildMetadata> orig,  string branchName,  string revision,  System.DateTime commitTime,  string machineName,  System.DateTime buildTime);
}

/// <summary>
/// Contains Hooks to that run code before orig(self) is called
/// </summary>
public static class BeforeOrig
{
public static event Delegates.get_BranchName_BeforeArgs get_BranchName
{
add
{

HookHandler._beforeget_BranchName += value;
HookHandler.Hookget_BranchName();
}
remove => HookHandler._beforeget_BranchName -= value;
}
public static event Delegates.get_Revision_BeforeArgs get_Revision
{
add
{

HookHandler._beforeget_Revision += value;
HookHandler.Hookget_Revision();
}
remove => HookHandler._beforeget_Revision -= value;
}
public static event Delegates.get_CommitTime_BeforeArgs get_CommitTime
{
add
{

HookHandler._beforeget_CommitTime += value;
HookHandler.Hookget_CommitTime();
}
remove => HookHandler._beforeget_CommitTime -= value;
}
public static event Delegates.get_MachineName_BeforeArgs get_MachineName
{
add
{

HookHandler._beforeget_MachineName += value;
HookHandler.Hookget_MachineName();
}
remove => HookHandler._beforeget_MachineName -= value;
}
public static event Delegates.get_BuildTime_BeforeArgs get_BuildTime
{
add
{

HookHandler._beforeget_BuildTime += value;
HookHandler.Hookget_BuildTime();
}
remove => HookHandler._beforeget_BuildTime -= value;
}
public static event Delegates.get_Embedded_BeforeArgs get_Embedded
{
add
{

HookHandler._beforeget_Embedded += value;
HookHandler.Hookget_Embedded();
}
remove => HookHandler._beforeget_Embedded -= value;
}
public static event Delegates.Create_BeforeArgs Create
{
add
{

HookHandler._beforeCreate += value;
HookHandler.HookCreate();
}
remove => HookHandler._beforeCreate -= value;
}
}

/// <summary>
/// Contains Hooks to that run code after orig(self) is called
/// </summary>
public static class AfterOrig
{
public static event Delegates.get_BranchName_AfterArgs get_BranchName
{
add
{

HookHandler._afterget_BranchName += value;
HookHandler.Hookget_BranchName();
}
remove => HookHandler._afterget_BranchName -= value;
}
public static event Delegates.get_Revision_AfterArgs get_Revision
{
add
{

HookHandler._afterget_Revision += value;
HookHandler.Hookget_Revision();
}
remove => HookHandler._afterget_Revision -= value;
}
public static event Delegates.get_CommitTime_AfterArgs get_CommitTime
{
add
{

HookHandler._afterget_CommitTime += value;
HookHandler.Hookget_CommitTime();
}
remove => HookHandler._afterget_CommitTime -= value;
}
public static event Delegates.get_MachineName_AfterArgs get_MachineName
{
add
{

HookHandler._afterget_MachineName += value;
HookHandler.Hookget_MachineName();
}
remove => HookHandler._afterget_MachineName -= value;
}
public static event Delegates.get_BuildTime_AfterArgs get_BuildTime
{
add
{

HookHandler._afterget_BuildTime += value;
HookHandler.Hookget_BuildTime();
}
remove => HookHandler._afterget_BuildTime -= value;
}
public static event Delegates.get_Embedded_AfterArgs get_Embedded
{
add
{

HookHandler._afterget_Embedded += value;
HookHandler.Hookget_Embedded();
}
remove => HookHandler._afterget_Embedded -= value;
}
public static event Delegates.Create_AfterArgs Create
{
add
{

HookHandler._afterCreate += value;
HookHandler.HookCreate();
}
remove => HookHandler._afterCreate -= value;
}
}

/// <summary>
/// Contains all On Hooks, even those that aren't in the On namespace such as API generated functions and property getters/setters
/// </summary>
public static class WithOrig
{
public static event Delegates.get_BranchName_WithArgs get_BranchName
{
add => HookEndpointManager.Add<Delegates.get_BranchName_WithArgs>(ReflectionHelper.GetMethodInfo(typeof(BuildMetadata), "get_BranchName", true), value);
remove => HookEndpointManager.Remove<Delegates.get_BranchName_WithArgs>(ReflectionHelper.GetMethodInfo(typeof(BuildMetadata), "get_BranchName", true), value);
}
public static event Delegates.get_Revision_WithArgs get_Revision
{
add => HookEndpointManager.Add<Delegates.get_Revision_WithArgs>(ReflectionHelper.GetMethodInfo(typeof(BuildMetadata), "get_Revision", true), value);
remove => HookEndpointManager.Remove<Delegates.get_Revision_WithArgs>(ReflectionHelper.GetMethodInfo(typeof(BuildMetadata), "get_Revision", true), value);
}
public static event Delegates.get_CommitTime_WithArgs get_CommitTime
{
add => HookEndpointManager.Add<Delegates.get_CommitTime_WithArgs>(ReflectionHelper.GetMethodInfo(typeof(BuildMetadata), "get_CommitTime", true), value);
remove => HookEndpointManager.Remove<Delegates.get_CommitTime_WithArgs>(ReflectionHelper.GetMethodInfo(typeof(BuildMetadata), "get_CommitTime", true), value);
}
public static event Delegates.get_MachineName_WithArgs get_MachineName
{
add => HookEndpointManager.Add<Delegates.get_MachineName_WithArgs>(ReflectionHelper.GetMethodInfo(typeof(BuildMetadata), "get_MachineName", true), value);
remove => HookEndpointManager.Remove<Delegates.get_MachineName_WithArgs>(ReflectionHelper.GetMethodInfo(typeof(BuildMetadata), "get_MachineName", true), value);
}
public static event Delegates.get_BuildTime_WithArgs get_BuildTime
{
add => HookEndpointManager.Add<Delegates.get_BuildTime_WithArgs>(ReflectionHelper.GetMethodInfo(typeof(BuildMetadata), "get_BuildTime", true), value);
remove => HookEndpointManager.Remove<Delegates.get_BuildTime_WithArgs>(ReflectionHelper.GetMethodInfo(typeof(BuildMetadata), "get_BuildTime", true), value);
}
public static event Delegates.get_Embedded_WithArgs get_Embedded
{
add => HookEndpointManager.Add<Delegates.get_Embedded_WithArgs>(ReflectionHelper.GetMethodInfo(typeof(BuildMetadata), "get_Embedded", false), value);
remove => HookEndpointManager.Remove<Delegates.get_Embedded_WithArgs>(ReflectionHelper.GetMethodInfo(typeof(BuildMetadata), "get_Embedded", false), value);
}
public static event On.BuildMetadata.hook_Create Create
{
add => On.BuildMetadata.Create += value;
remove => On.BuildMetadata.Create -= value;
}
}

}
