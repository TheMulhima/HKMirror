using MonoMod.RuntimeDetour.HookGen;

namespace HKMirror.Hooks.ILHooks;

/// <summary>
///     Contains all correct IL Hooks for SpellFluke.<br />
///     Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
///     Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILSpellFluke
{
    public static event ILContext.Manipulator Awake
    {
        add => IL.SpellFluke.Awake += value;
        remove => IL.SpellFluke.Awake -= value;
    }

    public static event ILContext.Manipulator Start
    {
        add => IL.SpellFluke.Start += value;
        remove => IL.SpellFluke.Start -= value;
    }

    public static event ILContext.Manipulator DoDamage
    {
        add => IL.SpellFluke.DoDamage += value;
        remove => IL.SpellFluke.DoDamage -= value;
    }

    public static event ILContext.Manipulator OnEnable
    {
        add => IL.SpellFluke.OnEnable += value;
        remove => IL.SpellFluke.OnEnable -= value;
    }

    public static event ILContext.Manipulator Update
    {
        add => IL.SpellFluke.Update += value;
        remove => IL.SpellFluke.Update -= value;
    }

    public static event ILContext.Manipulator Burst
    {
        add => IL.SpellFluke.Burst += value;
        remove => IL.SpellFluke.Burst -= value;
    }

    public static event ILContext.Manipulator BurstSequence
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(SpellFluke), "BurstSequence").GetStateMachineTarget(), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(SpellFluke), "BurstSequence").GetStateMachineTarget(), value);
    }
}