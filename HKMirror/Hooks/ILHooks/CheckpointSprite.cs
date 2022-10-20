namespace HKMirror.Hooks.ILHooks;

/// <summary>
///     Contains all correct IL Hooks for CheckpointSprite.<br />
///     Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
///     Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILCheckpointSprite
{
    public static event ILContext.Manipulator Awake
    {
        add => IL.CheckpointSprite.Awake += value;
        remove => IL.CheckpointSprite.Awake -= value;
    }

    public static event ILContext.Manipulator OnEnable
    {
        add => IL.CheckpointSprite.OnEnable += value;
        remove => IL.CheckpointSprite.OnEnable -= value;
    }

    public static event ILContext.Manipulator Start
    {
        add => IL.CheckpointSprite.Start += value;
        remove => IL.CheckpointSprite.Start -= value;
    }

    public static event ILContext.Manipulator Show
    {
        add => IL.CheckpointSprite.Show += value;
        remove => IL.CheckpointSprite.Show -= value;
    }

    public static event ILContext.Manipulator Hide
    {
        add => IL.CheckpointSprite.Hide += value;
        remove => IL.CheckpointSprite.Hide -= value;
    }

    public static event ILContext.Manipulator Update
    {
        add => IL.CheckpointSprite.Update += value;
        remove => IL.CheckpointSprite.Update -= value;
    }

    public static event ILContext.Manipulator Update_float
    {
        add => IL.CheckpointSprite.Update_float += value;
        remove => IL.CheckpointSprite.Update_float -= value;
    }
}