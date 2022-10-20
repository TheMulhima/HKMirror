namespace HKMirror.Hooks.ILHooks;

/// <summary>
///     Contains all correct IL Hooks for LookAnimNPC.<br />
///     Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
///     Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILLookAnimNPC
{
    public static event ILContext.Manipulator Awake
    {
        add => IL.LookAnimNPC.Awake += value;
        remove => IL.LookAnimNPC.Awake -= value;
    }

    public static event ILContext.Manipulator Start
    {
        add => IL.LookAnimNPC.Start += value;
        remove => IL.LookAnimNPC.Start -= value;
    }

    public static event ILContext.Manipulator OnDrawGizmosSelected
    {
        add => IL.LookAnimNPC.OnDrawGizmosSelected += value;
        remove => IL.LookAnimNPC.OnDrawGizmosSelected -= value;
    }

    public static event ILContext.Manipulator Update
    {
        add => IL.LookAnimNPC.Update += value;
        remove => IL.LookAnimNPC.Update -= value;
    }
}