namespace HKMirror.Hooks.ILHooks;

/// <summary>
///     Contains all correct IL Hooks for StringEncrypt.<br />
///     Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
///     Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILStringEncrypt
{
    public static event ILContext.Manipulator EncryptData
    {
        add => IL.StringEncrypt.EncryptData += value;
        remove => IL.StringEncrypt.EncryptData -= value;
    }

    public static event ILContext.Manipulator DecryptData
    {
        add => IL.StringEncrypt.DecryptData += value;
        remove => IL.StringEncrypt.DecryptData -= value;
    }
}