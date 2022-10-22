using GUIBlendModes;
using MonoMod.RuntimeDetour.HookGen;

namespace HKMirror.Hooks.ILHooks;

/// <summary>
///     Contains all correct IL Hooks for BlendMaterials,
///     Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
///     Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILBlendMaterials
{
    public static event ILContext.Manipulator Initialize
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(BlendMaterials), "Initialize", false),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(BlendMaterials), "Initialize", false), value);
    }

    public static event ILContext.Manipulator GetMaterial
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(BlendMaterials), "GetMaterial", false),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(BlendMaterials), "GetMaterial", false), value);
    }
}