using Microsoft.Xbox;
using MonoMod.RuntimeDetour.HookGen;

namespace HKMirror.Hooks.ILHooks;

/// <summary>
///     Contains all correct IL Hooks for XboxSdk.<br />
///     Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
///     Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILXboxSdk
{
    public static event ILContext.Manipulator get_Helpers
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(XboxSdk), "get_Helpers", false), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(XboxSdk), "get_Helpers", false),
            value);
    }

    public static event ILContext.Manipulator Start
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(XboxSdk), "Start"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(XboxSdk), "Start"), value);
    }

    public static event ILContext.Manipulator _Initialize
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(XboxSdk), "_Initialize"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(XboxSdk), "_Initialize"), value);
    }

    public static event ILContext.Manipulator SignIn
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(XboxSdk), "SignIn"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(XboxSdk), "SignIn"), value);
    }

    public static event ILContext.Manipulator Save
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(XboxSdk), "Save"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(XboxSdk), "Save"), value);
    }

    public static event ILContext.Manipulator LoadSaveData
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(XboxSdk), "LoadSaveData"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(XboxSdk), "LoadSaveData"), value);
    }

    public static event ILContext.Manipulator UnlockAchievement
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(XboxSdk), "UnlockAchievement"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(XboxSdk), "UnlockAchievement"),
            value);
    }

    public static event ILContext.Manipulator SignInImpl
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(XboxSdk), "SignInImpl"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(XboxSdk), "SignInImpl"), value);
    }

    public static event ILContext.Manipulator AddUserComplete
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(XboxSdk), "AddUserComplete"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(XboxSdk), "AddUserComplete"),
            value);
    }

    public static event ILContext.Manipulator CompletePostSignInInitialization
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(XboxSdk), "CompletePostSignInInitialization"), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(XboxSdk), "CompletePostSignInInitialization"), value);
    }

    public static event ILContext.Manipulator InitializeGameSaves
    {
        add =>
            HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(XboxSdk), "InitializeGameSaves"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(XboxSdk), "InitializeGameSaves"),
            value);
    }

    public static event ILContext.Manipulator XGameSaveInitializeCompleted
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(XboxSdk), "XGameSaveInitializeCompleted"), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(XboxSdk), "XGameSaveInitializeCompleted"), value);
    }

    public static event ILContext.Manipulator SaveImpl
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(XboxSdk), "SaveImpl"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(XboxSdk), "SaveImpl"), value);
    }

    public static event ILContext.Manipulator GameSaveSubmitUpdateCompleted
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(XboxSdk), "GameSaveSubmitUpdateCompleted"), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(XboxSdk), "GameSaveSubmitUpdateCompleted"), value);
    }

    public static event ILContext.Manipulator LoadSaveDataImpl
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(XboxSdk), "LoadSaveDataImpl"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(XboxSdk), "LoadSaveDataImpl"),
            value);
    }

    public static event ILContext.Manipulator GameSaveReadBlobDataCompleted
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(XboxSdk), "GameSaveReadBlobDataCompleted"), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(XboxSdk), "GameSaveReadBlobDataCompleted"), value);
    }

    public static event ILContext.Manipulator UnlockAchievementImpl
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(XboxSdk), "UnlockAchievementImpl"),
            value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(XboxSdk), "UnlockAchievementImpl"),
            value);
    }

    public static event ILContext.Manipulator UnlockAchievementComplete
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(XboxSdk), "UnlockAchievementComplete"),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(XboxSdk), "UnlockAchievementComplete"), value);
    }

    public static event ILContext.Manipulator Update
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(XboxSdk), "Update"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(XboxSdk), "Update"), value);
    }

    public static event ILContext.Manipulator Succeeded
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(XboxSdk), "Succeeded", false), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(XboxSdk), "Succeeded", false),
            value);
    }

    public static event ILContext.Manipulator _LogError
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(XboxSdk), "_LogError", false), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(XboxSdk), "_LogError", false),
            value);
    }
}