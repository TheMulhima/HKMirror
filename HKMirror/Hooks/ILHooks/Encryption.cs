using MonoMod.RuntimeDetour.HookGen;

namespace HKMirror.Hooks.ILHooks;

/// <summary>
///     Contains all correct IL Hooks for Encryption,
///     Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
///     Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILEncryption
{
    public static event ILContext.Manipulator Encrypt_Array
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(Encryption), "Encrypt", false), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(Encryption), "Encrypt", false),
            value);
    }

    public static event ILContext.Manipulator Decrypt_Array
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(Encryption), "Decrypt", false), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(Encryption), "Decrypt", false),
            value);
    }

    public static event ILContext.Manipulator Encrypt_string
    {
        add => IL.Encryption.Encrypt_string += value;
        remove => IL.Encryption.Encrypt_string -= value;
    }

    public static event ILContext.Manipulator Decrypt_string
    {
        add => IL.Encryption.Decrypt_string += value;
        remove => IL.Encryption.Decrypt_string -= value;
    }
}