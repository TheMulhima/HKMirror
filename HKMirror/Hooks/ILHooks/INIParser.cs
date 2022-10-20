using MonoMod.RuntimeDetour.HookGen;

namespace HKMirror.Hooks.ILHooks;

/// <summary>
///     Contains all correct IL Hooks for INIParser.<br />
///     Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
///     Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILINIParser
{
    public static event ILContext.Manipulator get_FileName
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(INIParser), "get_FileName"), value);
        remove =>
            HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(INIParser), "get_FileName"), value);
    }

    public static event ILContext.Manipulator get_iniString
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(INIParser), "get_iniString"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(INIParser), "get_iniString"),
            value);
    }

    public static event ILContext.Manipulator Open_string
    {
        add => IL.INIParser.Open_string += value;
        remove => IL.INIParser.Open_string -= value;
    }

    public static event ILContext.Manipulator Open_TextAsset
    {
        add => IL.INIParser.Open_TextAsset += value;
        remove => IL.INIParser.Open_TextAsset -= value;
    }

    public static event ILContext.Manipulator OpenFromString
    {
        add => IL.INIParser.OpenFromString += value;
        remove => IL.INIParser.OpenFromString -= value;
    }

    public static event ILContext.Manipulator Initialize
    {
        add => IL.INIParser.Initialize += value;
        remove => IL.INIParser.Initialize -= value;
    }

    public static event ILContext.Manipulator Close
    {
        add => IL.INIParser.Close += value;
        remove => IL.INIParser.Close -= value;
    }

    public static event ILContext.Manipulator ParseSectionName
    {
        add => IL.INIParser.ParseSectionName += value;
        remove => IL.INIParser.ParseSectionName -= value;
    }

    public static event ILContext.Manipulator ParseKeyValuePair
    {
        add => IL.INIParser.ParseKeyValuePair += value;
        remove => IL.INIParser.ParseKeyValuePair -= value;
    }

    public static event ILContext.Manipulator isComment
    {
        add => IL.INIParser.isComment += value;
        remove => IL.INIParser.isComment -= value;
    }

    public static event ILContext.Manipulator Refresh
    {
        add => IL.INIParser.Refresh += value;
        remove => IL.INIParser.Refresh -= value;
    }

    public static event ILContext.Manipulator PerformFlush
    {
        add => IL.INIParser.PerformFlush += value;
        remove => IL.INIParser.PerformFlush -= value;
    }

    public static event ILContext.Manipulator IsSectionExists
    {
        add => IL.INIParser.IsSectionExists += value;
        remove => IL.INIParser.IsSectionExists -= value;
    }

    public static event ILContext.Manipulator IsKeyExists
    {
        add => IL.INIParser.IsKeyExists += value;
        remove => IL.INIParser.IsKeyExists -= value;
    }

    public static event ILContext.Manipulator SectionDelete
    {
        add => IL.INIParser.SectionDelete += value;
        remove => IL.INIParser.SectionDelete -= value;
    }

    public static event ILContext.Manipulator KeyDelete
    {
        add => IL.INIParser.KeyDelete += value;
        remove => IL.INIParser.KeyDelete -= value;
    }

    public static event ILContext.Manipulator ReadValue_string_string_string
    {
        add => IL.INIParser.ReadValue_string_string_string += value;
        remove => IL.INIParser.ReadValue_string_string_string -= value;
    }

    public static event ILContext.Manipulator WriteValue_string_string_string
    {
        add => IL.INIParser.WriteValue_string_string_string += value;
        remove => IL.INIParser.WriteValue_string_string_string -= value;
    }

    public static event ILContext.Manipulator EncodeByteArray
    {
        add => IL.INIParser.EncodeByteArray += value;
        remove => IL.INIParser.EncodeByteArray -= value;
    }

    public static event ILContext.Manipulator DecodeByteArray
    {
        add => IL.INIParser.DecodeByteArray += value;
        remove => IL.INIParser.DecodeByteArray -= value;
    }

    public static event ILContext.Manipulator ReadValue_string_string_bool
    {
        add => IL.INIParser.ReadValue_string_string_bool += value;
        remove => IL.INIParser.ReadValue_string_string_bool -= value;
    }

    public static event ILContext.Manipulator ReadValue_string_string_int
    {
        add => IL.INIParser.ReadValue_string_string_int += value;
        remove => IL.INIParser.ReadValue_string_string_int -= value;
    }

    public static event ILContext.Manipulator ReadValue_string_string_Int64
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(INIParser), "ReadValue"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(INIParser), "ReadValue"), value);
    }

    public static event ILContext.Manipulator ReadValue_string_string_Double
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(INIParser), "ReadValue"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(INIParser), "ReadValue"), value);
    }

    public static event ILContext.Manipulator ReadValue_string_string_Array
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(INIParser), "ReadValue"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(INIParser), "ReadValue"), value);
    }

    public static event ILContext.Manipulator ReadValue_string_string_DateTime
    {
        add => IL.INIParser.ReadValue_string_string_DateTime += value;
        remove => IL.INIParser.ReadValue_string_string_DateTime -= value;
    }

    public static event ILContext.Manipulator WriteValue_string_string_bool
    {
        add => IL.INIParser.WriteValue_string_string_bool += value;
        remove => IL.INIParser.WriteValue_string_string_bool -= value;
    }

    public static event ILContext.Manipulator WriteValue_string_string_int
    {
        add => IL.INIParser.WriteValue_string_string_int += value;
        remove => IL.INIParser.WriteValue_string_string_int -= value;
    }

    public static event ILContext.Manipulator WriteValue_string_string_Int64
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(INIParser), "WriteValue"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(INIParser), "WriteValue"), value);
    }

    public static event ILContext.Manipulator WriteValue_string_string_Double
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(INIParser), "WriteValue"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(INIParser), "WriteValue"), value);
    }

    public static event ILContext.Manipulator WriteValue_string_string_Array
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(INIParser), "WriteValue"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(INIParser), "WriteValue"), value);
    }

    public static event ILContext.Manipulator WriteValue_string_string_DateTime
    {
        add => IL.INIParser.WriteValue_string_string_DateTime += value;
        remove => IL.INIParser.WriteValue_string_string_DateTime -= value;
    }
}