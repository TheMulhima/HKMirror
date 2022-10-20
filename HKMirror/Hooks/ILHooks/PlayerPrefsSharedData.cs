using MonoMod.RuntimeDetour.HookGen;

namespace HKMirror.Hooks.ILHooks;

/// <summary>
///     Contains all correct IL Hooks for PlayerPrefsSharedData.<br />
///     Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
///     Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILPlayerPrefsSharedData
{
    public static event ILContext.Manipulator get_IsEncrypted
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(PlayerPrefsSharedData), "get_IsEncrypted"), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(PlayerPrefsSharedData), "get_IsEncrypted"), value);
    }

    public static event ILContext.Manipulator ReadEncrypted
    {
        add => IL.PlayerPrefsSharedData.ReadEncrypted += value;
        remove => IL.PlayerPrefsSharedData.ReadEncrypted -= value;
    }

    public static event ILContext.Manipulator WriteEncrypted
    {
        add => IL.PlayerPrefsSharedData.WriteEncrypted += value;
        remove => IL.PlayerPrefsSharedData.WriteEncrypted -= value;
    }

    public static event ILContext.Manipulator HasKey
    {
        add => IL.PlayerPrefsSharedData.HasKey += value;
        remove => IL.PlayerPrefsSharedData.HasKey -= value;
    }

    public static event ILContext.Manipulator DeleteKey
    {
        add => IL.PlayerPrefsSharedData.DeleteKey += value;
        remove => IL.PlayerPrefsSharedData.DeleteKey -= value;
    }

    public static event ILContext.Manipulator DeleteAll
    {
        add => IL.PlayerPrefsSharedData.DeleteAll += value;
        remove => IL.PlayerPrefsSharedData.DeleteAll -= value;
    }

    public static event ILContext.Manipulator GetBool
    {
        add => IL.PlayerPrefsSharedData.GetBool += value;
        remove => IL.PlayerPrefsSharedData.GetBool -= value;
    }

    public static event ILContext.Manipulator SetBool
    {
        add => IL.PlayerPrefsSharedData.SetBool += value;
        remove => IL.PlayerPrefsSharedData.SetBool -= value;
    }

    public static event ILContext.Manipulator GetInt
    {
        add => IL.PlayerPrefsSharedData.GetInt += value;
        remove => IL.PlayerPrefsSharedData.GetInt -= value;
    }

    public static event ILContext.Manipulator SetInt
    {
        add => IL.PlayerPrefsSharedData.SetInt += value;
        remove => IL.PlayerPrefsSharedData.SetInt -= value;
    }

    public static event ILContext.Manipulator GetFloat
    {
        add => IL.PlayerPrefsSharedData.GetFloat += value;
        remove => IL.PlayerPrefsSharedData.GetFloat -= value;
    }

    public static event ILContext.Manipulator SetFloat
    {
        add => IL.PlayerPrefsSharedData.SetFloat += value;
        remove => IL.PlayerPrefsSharedData.SetFloat -= value;
    }

    public static event ILContext.Manipulator GetString
    {
        add => IL.PlayerPrefsSharedData.GetString += value;
        remove => IL.PlayerPrefsSharedData.GetString -= value;
    }

    public static event ILContext.Manipulator SetString
    {
        add => IL.PlayerPrefsSharedData.SetString += value;
        remove => IL.PlayerPrefsSharedData.SetString -= value;
    }

    public static event ILContext.Manipulator Save
    {
        add => IL.PlayerPrefsSharedData.Save += value;
        remove => IL.PlayerPrefsSharedData.Save -= value;
    }
}