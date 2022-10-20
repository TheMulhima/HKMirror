namespace HKMirror.Hooks.ILHooks;

/// <summary>
///     Contains all correct IL Hooks for GetPreInstantiatedGameObject.<br />
///     Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
///     Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILGetPreInstantiatedGameObject
{
    public static event ILContext.Manipulator Reset
    {
        add => IL.GetPreInstantiatedGameObject.Reset += value;
        remove => IL.GetPreInstantiatedGameObject.Reset -= value;
    }

    public static event ILContext.Manipulator OnEnter
    {
        add => IL.GetPreInstantiatedGameObject.OnEnter += value;
        remove => IL.GetPreInstantiatedGameObject.OnEnter -= value;
    }
}