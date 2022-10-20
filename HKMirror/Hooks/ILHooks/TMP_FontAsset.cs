using MonoMod.RuntimeDetour.HookGen;
using TMPro;

namespace HKMirror.Hooks.ILHooks;

/// <summary>
///     Contains all correct IL Hooks for TMP_FontAsset.<br />
///     Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
///     Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILTMP_FontAsset
{
    public static event ILContext.Manipulator get_defaultFontAsset
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(TMP_FontAsset), "get_defaultFontAsset", false), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(TMP_FontAsset), "get_defaultFontAsset", false), value);
    }

    public static event ILContext.Manipulator get_fontInfo
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TMP_FontAsset), "get_fontInfo"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(TMP_FontAsset), "get_fontInfo"),
            value);
    }

    public static event ILContext.Manipulator get_characterDictionary
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(TMP_FontAsset), "get_characterDictionary"), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(TMP_FontAsset), "get_characterDictionary"), value);
    }

    public static event ILContext.Manipulator get_kerningDictionary
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(TMP_FontAsset), "get_kerningDictionary"), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(TMP_FontAsset), "get_kerningDictionary"), value);
    }

    public static event ILContext.Manipulator get_kerningInfo
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TMP_FontAsset), "get_kerningInfo"),
            value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(TMP_FontAsset), "get_kerningInfo"),
            value);
    }

    public static event ILContext.Manipulator OnEnable
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TMP_FontAsset), "OnEnable"), value);
        remove =>
            HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(TMP_FontAsset), "OnEnable"), value);
    }

    public static event ILContext.Manipulator OnDisable
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TMP_FontAsset), "OnDisable"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(TMP_FontAsset), "OnDisable"),
            value);
    }

    public static event ILContext.Manipulator AddFaceInfo
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TMP_FontAsset), "AddFaceInfo"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(TMP_FontAsset), "AddFaceInfo"),
            value);
    }

    public static event ILContext.Manipulator AddGlyphInfo
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TMP_FontAsset), "AddGlyphInfo"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(TMP_FontAsset), "AddGlyphInfo"),
            value);
    }

    public static event ILContext.Manipulator AddKerningInfo
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TMP_FontAsset), "AddKerningInfo"),
            value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(TMP_FontAsset), "AddKerningInfo"),
            value);
    }

    public static event ILContext.Manipulator ReadFontDefinition
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TMP_FontAsset), "ReadFontDefinition"),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(TMP_FontAsset), "ReadFontDefinition"), value);
    }

    public static event ILContext.Manipulator HasCharacter_int
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TMP_FontAsset), "HasCharacter"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(TMP_FontAsset), "HasCharacter"),
            value);
    }

    public static event ILContext.Manipulator HasCharacter_Char
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TMP_FontAsset), "HasCharacter"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(TMP_FontAsset), "HasCharacter"),
            value);
    }

    public static event ILContext.Manipulator HasCharacter_Char_bool
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TMP_FontAsset), "HasCharacter"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(TMP_FontAsset), "HasCharacter"),
            value);
    }

    public static event ILContext.Manipulator HasCharacters
    {
        add =>
            HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TMP_FontAsset), "HasCharacters"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(TMP_FontAsset), "HasCharacters"),
            value);
    }

    public static event ILContext.Manipulator GetCharacters
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TMP_FontAsset), "GetCharacters", false),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(TMP_FontAsset), "GetCharacters", false), value);
    }

    public static event ILContext.Manipulator GetCharactersArray
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(TMP_FontAsset), "GetCharactersArray", false), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(TMP_FontAsset), "GetCharactersArray", false), value);
    }
}