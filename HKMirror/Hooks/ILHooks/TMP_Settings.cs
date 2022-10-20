using MonoMod.RuntimeDetour.HookGen;
using TMPro;

namespace HKMirror.Hooks.ILHooks;

/// <summary>
///     Contains all correct IL Hooks for TMP_Settings.<br />
///     Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
///     Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILTMP_Settings
{
    public static event ILContext.Manipulator get_enableWordWrapping
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(TMP_Settings), "get_enableWordWrapping", false), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(TMP_Settings), "get_enableWordWrapping", false), value);
    }

    public static event ILContext.Manipulator get_enableKerning
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(TMP_Settings), "get_enableKerning", false), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(TMP_Settings), "get_enableKerning", false), value);
    }

    public static event ILContext.Manipulator get_enableExtraPadding
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(TMP_Settings), "get_enableExtraPadding", false), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(TMP_Settings), "get_enableExtraPadding", false), value);
    }

    public static event ILContext.Manipulator get_enableTintAllSprites
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(TMP_Settings), "get_enableTintAllSprites", false), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(TMP_Settings), "get_enableTintAllSprites", false), value);
    }

    public static event ILContext.Manipulator get_enableParseEscapeCharacters
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(TMP_Settings), "get_enableParseEscapeCharacters", false), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(TMP_Settings), "get_enableParseEscapeCharacters", false), value);
    }

    public static event ILContext.Manipulator get_missingGlyphCharacter
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(TMP_Settings), "get_missingGlyphCharacter", false), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(TMP_Settings), "get_missingGlyphCharacter", false), value);
    }

    public static event ILContext.Manipulator get_warningsDisabled
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(TMP_Settings), "get_warningsDisabled", false), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(TMP_Settings), "get_warningsDisabled", false), value);
    }

    public static event ILContext.Manipulator get_defaultFontAsset
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(TMP_Settings), "get_defaultFontAsset", false), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(TMP_Settings), "get_defaultFontAsset", false), value);
    }

    public static event ILContext.Manipulator get_defaultFontAssetPath
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(TMP_Settings), "get_defaultFontAssetPath", false), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(TMP_Settings), "get_defaultFontAssetPath", false), value);
    }

    public static event ILContext.Manipulator get_defaultFontSize
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(TMP_Settings), "get_defaultFontSize", false), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(TMP_Settings), "get_defaultFontSize", false), value);
    }

    public static event ILContext.Manipulator get_defaultTextContainerWidth
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(TMP_Settings), "get_defaultTextContainerWidth", false), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(TMP_Settings), "get_defaultTextContainerWidth", false), value);
    }

    public static event ILContext.Manipulator get_defaultTextContainerHeight
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(TMP_Settings), "get_defaultTextContainerHeight", false), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(TMP_Settings), "get_defaultTextContainerHeight", false), value);
    }

    public static event ILContext.Manipulator get_fallbackFontAssets
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(TMP_Settings), "get_fallbackFontAssets", false), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(TMP_Settings), "get_fallbackFontAssets", false), value);
    }

    public static event ILContext.Manipulator get_matchMaterialPreset
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(TMP_Settings), "get_matchMaterialPreset", false), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(TMP_Settings), "get_matchMaterialPreset", false), value);
    }

    public static event ILContext.Manipulator get_defaultSpriteAsset
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(TMP_Settings), "get_defaultSpriteAsset", false), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(TMP_Settings), "get_defaultSpriteAsset", false), value);
    }

    public static event ILContext.Manipulator get_defaultSpriteAssetPath
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(TMP_Settings), "get_defaultSpriteAssetPath", false), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(TMP_Settings), "get_defaultSpriteAssetPath", false), value);
    }

    public static event ILContext.Manipulator get_defaultStyleSheet
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(TMP_Settings), "get_defaultStyleSheet", false), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(TMP_Settings), "get_defaultStyleSheet", false), value);
    }

    public static event ILContext.Manipulator get_leadingCharacters
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(TMP_Settings), "get_leadingCharacters", false), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(TMP_Settings), "get_leadingCharacters", false), value);
    }

    public static event ILContext.Manipulator get_followingCharacters
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(TMP_Settings), "get_followingCharacters", false), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(TMP_Settings), "get_followingCharacters", false), value);
    }

    public static event ILContext.Manipulator get_instance
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TMP_Settings), "get_instance", false),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(TMP_Settings), "get_instance", false), value);
    }

    public static event ILContext.Manipulator LoadDefaultSettings
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(TMP_Settings), "LoadDefaultSettings", false), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(TMP_Settings), "LoadDefaultSettings", false), value);
    }

    public static event ILContext.Manipulator GetSettings
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TMP_Settings), "GetSettings", false),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(TMP_Settings), "GetSettings", false), value);
    }

    public static event ILContext.Manipulator GetFontAsset
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TMP_Settings), "GetFontAsset", false),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(TMP_Settings), "GetFontAsset", false), value);
    }

    public static event ILContext.Manipulator GetSpriteAsset
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TMP_Settings), "GetSpriteAsset", false),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(TMP_Settings), "GetSpriteAsset", false), value);
    }

    public static event ILContext.Manipulator GetStyleSheet
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TMP_Settings), "GetStyleSheet", false),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(TMP_Settings), "GetStyleSheet", false), value);
    }

    public static event ILContext.Manipulator LoadLinebreakingRules
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(TMP_Settings), "LoadLinebreakingRules", false), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(TMP_Settings), "LoadLinebreakingRules", false), value);
    }

    public static event ILContext.Manipulator GetCharacters
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TMP_Settings), "GetCharacters", false),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(TMP_Settings), "GetCharacters", false), value);
    }
}