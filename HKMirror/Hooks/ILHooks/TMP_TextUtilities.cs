using MonoMod.RuntimeDetour.HookGen;
using TMPro;

namespace HKMirror.Hooks.ILHooks;

/// <summary>
///     Contains all correct IL Hooks for TMP_TextUtilities,
///     Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
///     Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILTMP_TextUtilities
{
    public static event ILContext.Manipulator GetCursorInsertionIndex
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(TMP_TextUtilities), "GetCursorInsertionIndex", false), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(TMP_TextUtilities), "GetCursorInsertionIndex", false), value);
    }

    public static event ILContext.Manipulator GetCursorIndexFromPosition_TMP_Text_Vector3_Camera
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(TMP_TextUtilities), "GetCursorIndexFromPosition", false), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(TMP_TextUtilities), "GetCursorIndexFromPosition", false), value);
    }

    public static event ILContext.Manipulator GetCursorIndexFromPosition_TMP_Text_Vector3_Camera_CaretPosition
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(TMP_TextUtilities), "GetCursorIndexFromPosition", false), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(TMP_TextUtilities), "GetCursorIndexFromPosition", false), value);
    }

    public static event ILContext.Manipulator IsIntersectingRectTransform
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(TMP_TextUtilities), "IsIntersectingRectTransform", false), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(TMP_TextUtilities), "IsIntersectingRectTransform", false), value);
    }

    public static event ILContext.Manipulator FindIntersectingCharacter
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(TMP_TextUtilities), "FindIntersectingCharacter", false), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(TMP_TextUtilities), "FindIntersectingCharacter", false), value);
    }

    public static event ILContext.Manipulator FindNearestCharacter
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(TMP_TextUtilities), "FindNearestCharacter", false), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(TMP_TextUtilities), "FindNearestCharacter", false), value);
    }

    public static event ILContext.Manipulator FindIntersectingWord
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(TMP_TextUtilities), "FindIntersectingWord", false), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(TMP_TextUtilities), "FindIntersectingWord", false), value);
    }

    public static event ILContext.Manipulator FindNearestWord
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(TMP_TextUtilities), "FindNearestWord", false), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(TMP_TextUtilities), "FindNearestWord", false), value);
    }

    public static event ILContext.Manipulator FindIntersectingLink
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(TMP_TextUtilities), "FindIntersectingLink", false), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(TMP_TextUtilities), "FindIntersectingLink", false), value);
    }

    public static event ILContext.Manipulator FindNearestLink
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(TMP_TextUtilities), "FindNearestLink", false), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(TMP_TextUtilities), "FindNearestLink", false), value);
    }

    public static event ILContext.Manipulator PointIntersectRectangle
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(TMP_TextUtilities), "PointIntersectRectangle", false), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(TMP_TextUtilities), "PointIntersectRectangle", false), value);
    }

    public static event ILContext.Manipulator ScreenPointToWorldPointInRectangle
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(TMP_TextUtilities), "ScreenPointToWorldPointInRectangle", false),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(TMP_TextUtilities), "ScreenPointToWorldPointInRectangle", false),
            value);
    }

    public static event ILContext.Manipulator DistanceToLine
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(TMP_TextUtilities), "DistanceToLine", false), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(TMP_TextUtilities), "DistanceToLine", false), value);
    }

    public static event ILContext.Manipulator ToLowerFast
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(TMP_TextUtilities), "ToLowerFast", false), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(TMP_TextUtilities), "ToLowerFast", false), value);
    }

    public static event ILContext.Manipulator ToUpperFast
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(TMP_TextUtilities), "ToUpperFast", false), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(TMP_TextUtilities), "ToUpperFast", false), value);
    }

    public static event ILContext.Manipulator GetSimpleHashCode
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(TMP_TextUtilities), "GetSimpleHashCode", false), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(TMP_TextUtilities), "GetSimpleHashCode", false), value);
    }

    public static event ILContext.Manipulator GetSimpleHashCodeLowercase
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(TMP_TextUtilities), "GetSimpleHashCodeLowercase", false), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(TMP_TextUtilities), "GetSimpleHashCodeLowercase", false), value);
    }

    public static event ILContext.Manipulator HexToInt
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TMP_TextUtilities), "HexToInt", false),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(TMP_TextUtilities), "HexToInt", false), value);
    }

    public static event ILContext.Manipulator StringToInt
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(TMP_TextUtilities), "StringToInt", false), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(TMP_TextUtilities), "StringToInt", false), value);
    }
}