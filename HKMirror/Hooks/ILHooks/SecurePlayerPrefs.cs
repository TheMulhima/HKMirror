using MonoMod.RuntimeDetour.HookGen;
using SecPlayerPrefs;

namespace HKMirror.Hooks.ILHooks;

/// <summary>
///     Contains all correct IL Hooks for SecurePlayerPrefs.<br />
///     Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
///     Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILSecurePlayerPrefs
{
    public static event ILContext.Manipulator Encrypt
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(SecurePlayerPrefs), "Encrypt", false),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(SecurePlayerPrefs), "Encrypt", false), value);
    }

    public static event ILContext.Manipulator Decrypt
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(SecurePlayerPrefs), "Decrypt", false),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(SecurePlayerPrefs), "Decrypt", false), value);
    }

    public static event ILContext.Manipulator UTF8ByteArrayToString
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(SecurePlayerPrefs), "UTF8ByteArrayToString", false), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(SecurePlayerPrefs), "UTF8ByteArrayToString", false), value);
    }

    public static event ILContext.Manipulator StringToUTF8ByteArray
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(SecurePlayerPrefs), "StringToUTF8ByteArray", false), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(SecurePlayerPrefs), "StringToUTF8ByteArray", false), value);
    }

    public static event ILContext.Manipulator SetInt
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(SecurePlayerPrefs), "SetInt", false),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(SecurePlayerPrefs), "SetInt", false), value);
    }

    public static event ILContext.Manipulator SetString
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(SecurePlayerPrefs), "SetString", false),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(SecurePlayerPrefs), "SetString", false), value);
    }

    public static event ILContext.Manipulator SetFloat
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(SecurePlayerPrefs), "SetFloat", false),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(SecurePlayerPrefs), "SetFloat", false), value);
    }

    public static event ILContext.Manipulator SetBool
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(SecurePlayerPrefs), "SetBool", false),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(SecurePlayerPrefs), "SetBool", false), value);
    }

    public static event ILContext.Manipulator GetString
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(SecurePlayerPrefs), "GetString", false),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(SecurePlayerPrefs), "GetString", false), value);
    }

    public static event ILContext.Manipulator GetInt
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(SecurePlayerPrefs), "GetInt", false),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(SecurePlayerPrefs), "GetInt", false), value);
    }

    public static event ILContext.Manipulator GetFloat
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(SecurePlayerPrefs), "GetFloat", false),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(SecurePlayerPrefs), "GetFloat", false), value);
    }

    public static event ILContext.Manipulator GetBool
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(SecurePlayerPrefs), "GetBool", false),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(SecurePlayerPrefs), "GetBool", false), value);
    }

    public static event ILContext.Manipulator DeleteKey
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(SecurePlayerPrefs), "DeleteKey", false),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(SecurePlayerPrefs), "DeleteKey", false), value);
    }

    public static event ILContext.Manipulator DeleteAll
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(SecurePlayerPrefs), "DeleteAll", false),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(SecurePlayerPrefs), "DeleteAll", false), value);
    }

    public static event ILContext.Manipulator Save
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(SecurePlayerPrefs), "Save", false),
            value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(SecurePlayerPrefs), "Save", false),
            value);
    }

    public static event ILContext.Manipulator HasKey
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(SecurePlayerPrefs), "HasKey", false),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(SecurePlayerPrefs), "HasKey", false), value);
    }
}