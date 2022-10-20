using MonoMod.RuntimeDetour.HookGen;
using UnityEngine.UI;

namespace HKMirror.Hooks.ILHooks;

/// <summary>
///     Contains all correct IL Hooks for MenuOptionHorizontal.<br />
///     Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
///     Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILMenuOptionHorizontal
{
    public static event ILContext.Manipulator Awake
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(MenuOptionHorizontal), "Awake"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(MenuOptionHorizontal), "Awake"),
            value);
    }

    public static event ILContext.Manipulator OnEnable
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(MenuOptionHorizontal), "OnEnable"),
            value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(MenuOptionHorizontal), "OnEnable"),
            value);
    }

    public static event ILContext.Manipulator OnDisable
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(MenuOptionHorizontal), "OnDisable"),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(MenuOptionHorizontal), "OnDisable"), value);
    }

    public static event ILContext.Manipulator OnMove
    {
        add =>
            HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(MenuOptionHorizontal), "OnMove"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(MenuOptionHorizontal), "OnMove"),
            value);
    }

    public static event ILContext.Manipulator OnPointerClick
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(MenuOptionHorizontal), "OnPointerClick"), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(MenuOptionHorizontal), "OnPointerClick"), value);
    }

    public static event ILContext.Manipulator MoveOption
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(MenuOptionHorizontal), "MoveOption"),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(MenuOptionHorizontal), "MoveOption"), value);
    }

    public static event ILContext.Manipulator PointerClickCheckArrows
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(MenuOptionHorizontal), "PointerClickCheckArrows"), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(MenuOptionHorizontal), "PointerClickCheckArrows"), value);
    }

    public static event ILContext.Manipulator IsInside
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(MenuOptionHorizontal), "IsInside"),
            value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(MenuOptionHorizontal), "IsInside"),
            value);
    }

    public static event ILContext.Manipulator SetOptionList
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(MenuOptionHorizontal), "SetOptionList"),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(MenuOptionHorizontal), "SetOptionList"), value);
    }

    public static event ILContext.Manipulator GetSelectedOptionText
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(MenuOptionHorizontal), "GetSelectedOptionText"), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(MenuOptionHorizontal), "GetSelectedOptionText"), value);
    }

    public static event ILContext.Manipulator GetSelectedOptionTextRaw
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(MenuOptionHorizontal), "GetSelectedOptionTextRaw"), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(MenuOptionHorizontal), "GetSelectedOptionTextRaw"), value);
    }

    public static event ILContext.Manipulator SetOptionTo
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(MenuOptionHorizontal), "SetOptionTo"),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(MenuOptionHorizontal), "SetOptionTo"), value);
    }

    public static event ILContext.Manipulator UpdateText
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(MenuOptionHorizontal), "UpdateText"),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(MenuOptionHorizontal), "UpdateText"), value);
    }

    public static event ILContext.Manipulator UpdateSetting
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(MenuOptionHorizontal), "UpdateSetting"),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(MenuOptionHorizontal), "UpdateSetting"), value);
    }

    public static event ILContext.Manipulator DecrementOption
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(MenuOptionHorizontal), "DecrementOption"), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(MenuOptionHorizontal), "DecrementOption"), value);
    }

    public static event ILContext.Manipulator IncrementOption
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(MenuOptionHorizontal), "IncrementOption"), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(MenuOptionHorizontal), "IncrementOption"), value);
    }
}