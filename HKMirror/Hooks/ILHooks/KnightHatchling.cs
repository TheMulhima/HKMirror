using MonoMod.RuntimeDetour.HookGen;
namespace HKMirror.Hooks.ILHooks;
/// <summary>
/// Contains all correct IL Hooks for KnightHatchling,
/// Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
/// Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILKnightHatchling
{
public static event ILContext.Manipulator get_IsGrounded
{
add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(KnightHatchling), "get_IsGrounded", true), value);
remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(KnightHatchling), "get_IsGrounded", true), value);
}
public static event ILContext.Manipulator set_CurrentState
{
add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(KnightHatchling), "set_CurrentState", true), value);
remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(KnightHatchling), "set_CurrentState", true), value);
}
public static event ILContext.Manipulator set_LastFrameState
{
add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(KnightHatchling), "set_LastFrameState", true), value);
remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(KnightHatchling), "set_LastFrameState", true), value);
}
public static event ILContext.Manipulator set_PreviousState
{
add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(KnightHatchling), "set_PreviousState", true), value);
remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(KnightHatchling), "set_PreviousState", true), value);
}
public static event ILContext.Manipulator Awake
{
add => IL.KnightHatchling.Awake += value;
remove => IL.KnightHatchling.Awake -= value;
}
public static event ILContext.Manipulator Start
{
add => IL.KnightHatchling.Start += value;
remove => IL.KnightHatchling.Start -= value;
}
public static event ILContext.Manipulator OnEnable
{
add => IL.KnightHatchling.OnEnable += value;
remove => IL.KnightHatchling.OnEnable -= value;
}
public static event ILContext.Manipulator OnDisable
{
add => IL.KnightHatchling.OnDisable += value;
remove => IL.KnightHatchling.OnDisable -= value;
}
public static event ILContext.Manipulator FixedUpdate
{
add => IL.KnightHatchling.FixedUpdate += value;
remove => IL.KnightHatchling.FixedUpdate -= value;
}
public static event ILContext.Manipulator Spawn
{
add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(KnightHatchling), "Spawn", true).GetStateMachineTarget(), value);
remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(KnightHatchling), "Spawn", true).GetStateMachineTarget(), value);
}
public static event ILContext.Manipulator GetHeroDistance
{
add => IL.KnightHatchling.GetHeroDistance += value;
remove => IL.KnightHatchling.GetHeroDistance -= value;
}
public static event ILContext.Manipulator TeleEnd
{
add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(KnightHatchling), "TeleEnd", true).GetStateMachineTarget(), value);
remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(KnightHatchling), "TeleEnd", true).GetStateMachineTarget(), value);
}
public static event ILContext.Manipulator FsmHitLanded
{
add => IL.KnightHatchling.FsmHitLanded += value;
remove => IL.KnightHatchling.FsmHitLanded -= value;
}
public static event ILContext.Manipulator Explode
{
add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(KnightHatchling), "Explode", true).GetStateMachineTarget(), value);
remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(KnightHatchling), "Explode", true).GetStateMachineTarget(), value);
}
public static event ILContext.Manipulator FsmCharmsEnd
{
add => IL.KnightHatchling.FsmCharmsEnd += value;
remove => IL.KnightHatchling.FsmCharmsEnd -= value;
}
public static event ILContext.Manipulator CharmsEnd
{
add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(KnightHatchling), "CharmsEnd", true).GetStateMachineTarget(), value);
remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(KnightHatchling), "CharmsEnd", true).GetStateMachineTarget(), value);
}
public static event ILContext.Manipulator FsmHazardReload
{
add => IL.KnightHatchling.FsmHazardReload += value;
remove => IL.KnightHatchling.FsmHazardReload -= value;
}
public static event ILContext.Manipulator FsmBenchRestStart
{
add => IL.KnightHatchling.FsmBenchRestStart += value;
remove => IL.KnightHatchling.FsmBenchRestStart -= value;
}
public static event ILContext.Manipulator FsmBenchRestEnd
{
add => IL.KnightHatchling.FsmBenchRestEnd += value;
remove => IL.KnightHatchling.FsmBenchRestEnd -= value;
}
public static event ILContext.Manipulator WakeUp
{
add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(KnightHatchling), "WakeUp", true).GetStateMachineTarget(), value);
remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(KnightHatchling), "WakeUp", true).GetStateMachineTarget(), value);
}
public static event ILContext.Manipulator FsmQuickSpawn
{
add => IL.KnightHatchling.FsmQuickSpawn += value;
remove => IL.KnightHatchling.FsmQuickSpawn -= value;
}
public static event ILContext.Manipulator FsmDreamGateOut
{
add => IL.KnightHatchling.FsmDreamGateOut += value;
remove => IL.KnightHatchling.FsmDreamGateOut -= value;
}
public static event ILContext.Manipulator DreamGateOut
{
add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(KnightHatchling), "DreamGateOut", true).GetStateMachineTarget(), value);
remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(KnightHatchling), "DreamGateOut", true).GetStateMachineTarget(), value);
}
public static event ILContext.Manipulator DoFace
{
add => IL.KnightHatchling.DoFace += value;
remove => IL.KnightHatchling.DoFace -= value;
}
public static event ILContext.Manipulator DoChase
{
add => IL.KnightHatchling.DoChase += value;
remove => IL.KnightHatchling.DoChase -= value;
}
public static event ILContext.Manipulator DoBuzz
{
add => IL.KnightHatchling.DoBuzz += value;
remove => IL.KnightHatchling.DoBuzz -= value;
}
public static event ILContext.Manipulator DoChaseSimple
{
add => IL.KnightHatchling.DoChaseSimple += value;
remove => IL.KnightHatchling.DoChaseSimple -= value;
}
}
