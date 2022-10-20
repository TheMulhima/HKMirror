using MonoMod.RuntimeDetour.HookGen;
using TMPro;

namespace HKMirror.Hooks.ILHooks;

/// <summary>
///     Contains all correct IL Hooks for TMP_Text.<br />
///     Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
///     Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILTMP_Text
{
    public static event ILContext.Manipulator get_text
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TMP_Text), "get_text"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(TMP_Text), "get_text"), value);
    }

    public static event ILContext.Manipulator set_text
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TMP_Text), "set_text"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(TMP_Text), "set_text"), value);
    }

    public static event ILContext.Manipulator get_isRightToLeftText
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TMP_Text), "get_isRightToLeftText"),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(TMP_Text), "get_isRightToLeftText"), value);
    }

    public static event ILContext.Manipulator set_isRightToLeftText
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TMP_Text), "set_isRightToLeftText"),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(TMP_Text), "set_isRightToLeftText"), value);
    }

    public static event ILContext.Manipulator get_font
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TMP_Text), "get_font"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(TMP_Text), "get_font"), value);
    }

    public static event ILContext.Manipulator set_font
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TMP_Text), "set_font"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(TMP_Text), "set_font"), value);
    }

    public static event ILContext.Manipulator get_fontSharedMaterial
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TMP_Text), "get_fontSharedMaterial"),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(TMP_Text), "get_fontSharedMaterial"), value);
    }

    public static event ILContext.Manipulator set_fontSharedMaterial
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TMP_Text), "set_fontSharedMaterial"),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(TMP_Text), "set_fontSharedMaterial"), value);
    }

    public static event ILContext.Manipulator get_fontSharedMaterials
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TMP_Text), "get_fontSharedMaterials"),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(TMP_Text), "get_fontSharedMaterials"), value);
    }

    public static event ILContext.Manipulator set_fontSharedMaterials
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TMP_Text), "set_fontSharedMaterials"),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(TMP_Text), "set_fontSharedMaterials"), value);
    }

    public static event ILContext.Manipulator get_fontMaterial
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TMP_Text), "get_fontMaterial"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(TMP_Text), "get_fontMaterial"),
            value);
    }

    public static event ILContext.Manipulator set_fontMaterial
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TMP_Text), "set_fontMaterial"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(TMP_Text), "set_fontMaterial"),
            value);
    }

    public static event ILContext.Manipulator get_fontMaterials
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TMP_Text), "get_fontMaterials"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(TMP_Text), "get_fontMaterials"),
            value);
    }

    public static event ILContext.Manipulator set_fontMaterials
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TMP_Text), "set_fontMaterials"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(TMP_Text), "set_fontMaterials"),
            value);
    }

    public static event ILContext.Manipulator get_color
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TMP_Text), "get_color"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(TMP_Text), "get_color"), value);
    }

    public static event ILContext.Manipulator set_color
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TMP_Text), "set_color"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(TMP_Text), "set_color"), value);
    }

    public static event ILContext.Manipulator get_alpha
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TMP_Text), "get_alpha"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(TMP_Text), "get_alpha"), value);
    }

    public static event ILContext.Manipulator set_alpha
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TMP_Text), "set_alpha"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(TMP_Text), "set_alpha"), value);
    }

    public static event ILContext.Manipulator get_enableVertexGradient
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TMP_Text), "get_enableVertexGradient"),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(TMP_Text), "get_enableVertexGradient"), value);
    }

    public static event ILContext.Manipulator set_enableVertexGradient
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TMP_Text), "set_enableVertexGradient"),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(TMP_Text), "set_enableVertexGradient"), value);
    }

    public static event ILContext.Manipulator get_colorGradient
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TMP_Text), "get_colorGradient"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(TMP_Text), "get_colorGradient"),
            value);
    }

    public static event ILContext.Manipulator set_colorGradient
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TMP_Text), "set_colorGradient"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(TMP_Text), "set_colorGradient"),
            value);
    }

    public static event ILContext.Manipulator get_colorGradientPreset
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TMP_Text), "get_colorGradientPreset"),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(TMP_Text), "get_colorGradientPreset"), value);
    }

    public static event ILContext.Manipulator set_colorGradientPreset
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TMP_Text), "set_colorGradientPreset"),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(TMP_Text), "set_colorGradientPreset"), value);
    }

    public static event ILContext.Manipulator get_spriteAsset
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TMP_Text), "get_spriteAsset"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(TMP_Text), "get_spriteAsset"),
            value);
    }

    public static event ILContext.Manipulator set_spriteAsset
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TMP_Text), "set_spriteAsset"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(TMP_Text), "set_spriteAsset"),
            value);
    }

    public static event ILContext.Manipulator get_tintAllSprites
    {
        add =>
            HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TMP_Text), "get_tintAllSprites"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(TMP_Text), "get_tintAllSprites"),
            value);
    }

    public static event ILContext.Manipulator set_tintAllSprites
    {
        add =>
            HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TMP_Text), "set_tintAllSprites"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(TMP_Text), "set_tintAllSprites"),
            value);
    }

    public static event ILContext.Manipulator get_overrideColorTags
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TMP_Text), "get_overrideColorTags"),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(TMP_Text), "get_overrideColorTags"), value);
    }

    public static event ILContext.Manipulator set_overrideColorTags
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TMP_Text), "set_overrideColorTags"),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(TMP_Text), "set_overrideColorTags"), value);
    }

    public static event ILContext.Manipulator get_faceColor
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TMP_Text), "get_faceColor"), value);
        remove =>
            HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(TMP_Text), "get_faceColor"), value);
    }

    public static event ILContext.Manipulator set_faceColor
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TMP_Text), "set_faceColor"), value);
        remove =>
            HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(TMP_Text), "set_faceColor"), value);
    }

    public static event ILContext.Manipulator get_outlineColor
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TMP_Text), "get_outlineColor"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(TMP_Text), "get_outlineColor"),
            value);
    }

    public static event ILContext.Manipulator set_outlineColor
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TMP_Text), "set_outlineColor"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(TMP_Text), "set_outlineColor"),
            value);
    }

    public static event ILContext.Manipulator get_outlineWidth
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TMP_Text), "get_outlineWidth"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(TMP_Text), "get_outlineWidth"),
            value);
    }

    public static event ILContext.Manipulator set_outlineWidth
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TMP_Text), "set_outlineWidth"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(TMP_Text), "set_outlineWidth"),
            value);
    }

    public static event ILContext.Manipulator get_fontSize
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TMP_Text), "get_fontSize"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(TMP_Text), "get_fontSize"), value);
    }

    public static event ILContext.Manipulator set_fontSize
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TMP_Text), "set_fontSize"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(TMP_Text), "set_fontSize"), value);
    }

    public static event ILContext.Manipulator get_fontScale
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TMP_Text), "get_fontScale"), value);
        remove =>
            HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(TMP_Text), "get_fontScale"), value);
    }

    public static event ILContext.Manipulator get_fontWeight
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TMP_Text), "get_fontWeight"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(TMP_Text), "get_fontWeight"),
            value);
    }

    public static event ILContext.Manipulator set_fontWeight
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TMP_Text), "set_fontWeight"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(TMP_Text), "set_fontWeight"),
            value);
    }

    public static event ILContext.Manipulator get_pixelsPerUnit
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TMP_Text), "get_pixelsPerUnit"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(TMP_Text), "get_pixelsPerUnit"),
            value);
    }

    public static event ILContext.Manipulator get_enableAutoSizing
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TMP_Text), "get_enableAutoSizing"),
            value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(TMP_Text), "get_enableAutoSizing"),
            value);
    }

    public static event ILContext.Manipulator set_enableAutoSizing
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TMP_Text), "set_enableAutoSizing"),
            value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(TMP_Text), "set_enableAutoSizing"),
            value);
    }

    public static event ILContext.Manipulator get_fontSizeMin
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TMP_Text), "get_fontSizeMin"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(TMP_Text), "get_fontSizeMin"),
            value);
    }

    public static event ILContext.Manipulator set_fontSizeMin
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TMP_Text), "set_fontSizeMin"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(TMP_Text), "set_fontSizeMin"),
            value);
    }

    public static event ILContext.Manipulator get_fontSizeMax
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TMP_Text), "get_fontSizeMax"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(TMP_Text), "get_fontSizeMax"),
            value);
    }

    public static event ILContext.Manipulator set_fontSizeMax
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TMP_Text), "set_fontSizeMax"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(TMP_Text), "set_fontSizeMax"),
            value);
    }

    public static event ILContext.Manipulator get_fontStyle
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TMP_Text), "get_fontStyle"), value);
        remove =>
            HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(TMP_Text), "get_fontStyle"), value);
    }

    public static event ILContext.Manipulator set_fontStyle
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TMP_Text), "set_fontStyle"), value);
        remove =>
            HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(TMP_Text), "set_fontStyle"), value);
    }

    public static event ILContext.Manipulator get_isUsingBold
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TMP_Text), "get_isUsingBold"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(TMP_Text), "get_isUsingBold"),
            value);
    }

    public static event ILContext.Manipulator get_alignment
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TMP_Text), "get_alignment"), value);
        remove =>
            HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(TMP_Text), "get_alignment"), value);
    }

    public static event ILContext.Manipulator set_alignment
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TMP_Text), "set_alignment"), value);
        remove =>
            HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(TMP_Text), "set_alignment"), value);
    }

    public static event ILContext.Manipulator get_characterSpacing
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TMP_Text), "get_characterSpacing"),
            value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(TMP_Text), "get_characterSpacing"),
            value);
    }

    public static event ILContext.Manipulator set_characterSpacing
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TMP_Text), "set_characterSpacing"),
            value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(TMP_Text), "set_characterSpacing"),
            value);
    }

    public static event ILContext.Manipulator get_lineSpacing
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TMP_Text), "get_lineSpacing"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(TMP_Text), "get_lineSpacing"),
            value);
    }

    public static event ILContext.Manipulator set_lineSpacing
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TMP_Text), "set_lineSpacing"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(TMP_Text), "set_lineSpacing"),
            value);
    }

    public static event ILContext.Manipulator get_paragraphSpacing
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TMP_Text), "get_paragraphSpacing"),
            value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(TMP_Text), "get_paragraphSpacing"),
            value);
    }

    public static event ILContext.Manipulator set_paragraphSpacing
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TMP_Text), "set_paragraphSpacing"),
            value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(TMP_Text), "set_paragraphSpacing"),
            value);
    }

    public static event ILContext.Manipulator get_characterWidthAdjustment
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(TMP_Text), "get_characterWidthAdjustment"), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(TMP_Text), "get_characterWidthAdjustment"), value);
    }

    public static event ILContext.Manipulator set_characterWidthAdjustment
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(TMP_Text), "set_characterWidthAdjustment"), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(TMP_Text), "set_characterWidthAdjustment"), value);
    }

    public static event ILContext.Manipulator get_enableWordWrapping
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TMP_Text), "get_enableWordWrapping"),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(TMP_Text), "get_enableWordWrapping"), value);
    }

    public static event ILContext.Manipulator set_enableWordWrapping
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TMP_Text), "set_enableWordWrapping"),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(TMP_Text), "set_enableWordWrapping"), value);
    }

    public static event ILContext.Manipulator get_wordWrappingRatios
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TMP_Text), "get_wordWrappingRatios"),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(TMP_Text), "get_wordWrappingRatios"), value);
    }

    public static event ILContext.Manipulator set_wordWrappingRatios
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TMP_Text), "set_wordWrappingRatios"),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(TMP_Text), "set_wordWrappingRatios"), value);
    }

    public static event ILContext.Manipulator get_enableAdaptiveJustification
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(TMP_Text), "get_enableAdaptiveJustification"), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(TMP_Text), "get_enableAdaptiveJustification"), value);
    }

    public static event ILContext.Manipulator set_enableAdaptiveJustification
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(TMP_Text), "set_enableAdaptiveJustification"), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(TMP_Text), "set_enableAdaptiveJustification"), value);
    }

    public static event ILContext.Manipulator get_OverflowMode
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TMP_Text), "get_OverflowMode"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(TMP_Text), "get_OverflowMode"),
            value);
    }

    public static event ILContext.Manipulator set_OverflowMode
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TMP_Text), "set_OverflowMode"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(TMP_Text), "set_OverflowMode"),
            value);
    }

    public static event ILContext.Manipulator get_enableKerning
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TMP_Text), "get_enableKerning"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(TMP_Text), "get_enableKerning"),
            value);
    }

    public static event ILContext.Manipulator set_enableKerning
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TMP_Text), "set_enableKerning"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(TMP_Text), "set_enableKerning"),
            value);
    }

    public static event ILContext.Manipulator get_extraPadding
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TMP_Text), "get_extraPadding"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(TMP_Text), "get_extraPadding"),
            value);
    }

    public static event ILContext.Manipulator set_extraPadding
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TMP_Text), "set_extraPadding"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(TMP_Text), "set_extraPadding"),
            value);
    }

    public static event ILContext.Manipulator get_richText
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TMP_Text), "get_richText"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(TMP_Text), "get_richText"), value);
    }

    public static event ILContext.Manipulator set_richText
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TMP_Text), "set_richText"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(TMP_Text), "set_richText"), value);
    }

    public static event ILContext.Manipulator get_parseCtrlCharacters
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TMP_Text), "get_parseCtrlCharacters"),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(TMP_Text), "get_parseCtrlCharacters"), value);
    }

    public static event ILContext.Manipulator set_parseCtrlCharacters
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TMP_Text), "set_parseCtrlCharacters"),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(TMP_Text), "set_parseCtrlCharacters"), value);
    }

    public static event ILContext.Manipulator get_isOverlay
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TMP_Text), "get_isOverlay"), value);
        remove =>
            HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(TMP_Text), "get_isOverlay"), value);
    }

    public static event ILContext.Manipulator set_isOverlay
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TMP_Text), "set_isOverlay"), value);
        remove =>
            HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(TMP_Text), "set_isOverlay"), value);
    }

    public static event ILContext.Manipulator get_isOrthographic
    {
        add =>
            HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TMP_Text), "get_isOrthographic"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(TMP_Text), "get_isOrthographic"),
            value);
    }

    public static event ILContext.Manipulator set_isOrthographic
    {
        add =>
            HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TMP_Text), "set_isOrthographic"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(TMP_Text), "set_isOrthographic"),
            value);
    }

    public static event ILContext.Manipulator get_enableCulling
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TMP_Text), "get_enableCulling"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(TMP_Text), "get_enableCulling"),
            value);
    }

    public static event ILContext.Manipulator set_enableCulling
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TMP_Text), "set_enableCulling"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(TMP_Text), "set_enableCulling"),
            value);
    }

    public static event ILContext.Manipulator get_ignoreVisibility
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TMP_Text), "get_ignoreVisibility"),
            value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(TMP_Text), "get_ignoreVisibility"),
            value);
    }

    public static event ILContext.Manipulator set_ignoreVisibility
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TMP_Text), "set_ignoreVisibility"),
            value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(TMP_Text), "set_ignoreVisibility"),
            value);
    }

    public static event ILContext.Manipulator get_horizontalMapping
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TMP_Text), "get_horizontalMapping"),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(TMP_Text), "get_horizontalMapping"), value);
    }

    public static event ILContext.Manipulator set_horizontalMapping
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TMP_Text), "set_horizontalMapping"),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(TMP_Text), "set_horizontalMapping"), value);
    }

    public static event ILContext.Manipulator get_verticalMapping
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TMP_Text), "get_verticalMapping"),
            value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(TMP_Text), "get_verticalMapping"),
            value);
    }

    public static event ILContext.Manipulator set_verticalMapping
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TMP_Text), "set_verticalMapping"),
            value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(TMP_Text), "set_verticalMapping"),
            value);
    }

    public static event ILContext.Manipulator get_renderMode
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TMP_Text), "get_renderMode"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(TMP_Text), "get_renderMode"),
            value);
    }

    public static event ILContext.Manipulator set_renderMode
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TMP_Text), "set_renderMode"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(TMP_Text), "set_renderMode"),
            value);
    }

    public static event ILContext.Manipulator get_maxVisibleCharacters
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TMP_Text), "get_maxVisibleCharacters"),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(TMP_Text), "get_maxVisibleCharacters"), value);
    }

    public static event ILContext.Manipulator set_maxVisibleCharacters
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TMP_Text), "set_maxVisibleCharacters"),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(TMP_Text), "set_maxVisibleCharacters"), value);
    }

    public static event ILContext.Manipulator get_maxVisibleWords
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TMP_Text), "get_maxVisibleWords"),
            value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(TMP_Text), "get_maxVisibleWords"),
            value);
    }

    public static event ILContext.Manipulator set_maxVisibleWords
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TMP_Text), "set_maxVisibleWords"),
            value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(TMP_Text), "set_maxVisibleWords"),
            value);
    }

    public static event ILContext.Manipulator get_maxVisibleLines
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TMP_Text), "get_maxVisibleLines"),
            value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(TMP_Text), "get_maxVisibleLines"),
            value);
    }

    public static event ILContext.Manipulator set_maxVisibleLines
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TMP_Text), "set_maxVisibleLines"),
            value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(TMP_Text), "set_maxVisibleLines"),
            value);
    }

    public static event ILContext.Manipulator get_useMaxVisibleDescender
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(TMP_Text), "get_useMaxVisibleDescender"), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(TMP_Text), "get_useMaxVisibleDescender"), value);
    }

    public static event ILContext.Manipulator set_useMaxVisibleDescender
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(TMP_Text), "set_useMaxVisibleDescender"), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(TMP_Text), "set_useMaxVisibleDescender"), value);
    }

    public static event ILContext.Manipulator get_pageToDisplay
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TMP_Text), "get_pageToDisplay"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(TMP_Text), "get_pageToDisplay"),
            value);
    }

    public static event ILContext.Manipulator set_pageToDisplay
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TMP_Text), "set_pageToDisplay"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(TMP_Text), "set_pageToDisplay"),
            value);
    }

    public static event ILContext.Manipulator get_margin
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TMP_Text), "get_margin"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(TMP_Text), "get_margin"), value);
    }

    public static event ILContext.Manipulator set_margin
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TMP_Text), "set_margin"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(TMP_Text), "set_margin"), value);
    }

    public static event ILContext.Manipulator get_textInfo
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TMP_Text), "get_textInfo"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(TMP_Text), "get_textInfo"), value);
    }

    public static event ILContext.Manipulator get_havePropertiesChanged
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TMP_Text), "get_havePropertiesChanged"),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(TMP_Text), "get_havePropertiesChanged"), value);
    }

    public static event ILContext.Manipulator set_havePropertiesChanged
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TMP_Text), "set_havePropertiesChanged"),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(TMP_Text), "set_havePropertiesChanged"), value);
    }

    public static event ILContext.Manipulator get_isUsingLegacyAnimationComponent
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(TMP_Text), "get_isUsingLegacyAnimationComponent"), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(TMP_Text), "get_isUsingLegacyAnimationComponent"), value);
    }

    public static event ILContext.Manipulator set_isUsingLegacyAnimationComponent
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(TMP_Text), "set_isUsingLegacyAnimationComponent"), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(TMP_Text), "set_isUsingLegacyAnimationComponent"), value);
    }

    public static event ILContext.Manipulator get_transform
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TMP_Text), "get_transform"), value);
        remove =>
            HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(TMP_Text), "get_transform"), value);
    }

    public static event ILContext.Manipulator get_rectTransform
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TMP_Text), "get_rectTransform"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(TMP_Text), "get_rectTransform"),
            value);
    }

    public static event ILContext.Manipulator get_autoSizeTextContainer
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TMP_Text), "get_autoSizeTextContainer"),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(TMP_Text), "get_autoSizeTextContainer"), value);
    }

    public static event ILContext.Manipulator set_autoSizeTextContainer
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TMP_Text), "set_autoSizeTextContainer"),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(TMP_Text), "set_autoSizeTextContainer"), value);
    }

    public static event ILContext.Manipulator get_mesh
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TMP_Text), "get_mesh"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(TMP_Text), "get_mesh"), value);
    }

    public static event ILContext.Manipulator get_isVolumetricText
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TMP_Text), "get_isVolumetricText"),
            value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(TMP_Text), "get_isVolumetricText"),
            value);
    }

    public static event ILContext.Manipulator set_isVolumetricText
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TMP_Text), "set_isVolumetricText"),
            value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(TMP_Text), "set_isVolumetricText"),
            value);
    }

    public static event ILContext.Manipulator get_bounds
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TMP_Text), "get_bounds"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(TMP_Text), "get_bounds"), value);
    }

    public static event ILContext.Manipulator get_textBounds
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TMP_Text), "get_textBounds"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(TMP_Text), "get_textBounds"),
            value);
    }

    public static event ILContext.Manipulator get_flexibleHeight
    {
        add =>
            HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TMP_Text), "get_flexibleHeight"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(TMP_Text), "get_flexibleHeight"),
            value);
    }

    public static event ILContext.Manipulator get_flexibleWidth
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TMP_Text), "get_flexibleWidth"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(TMP_Text), "get_flexibleWidth"),
            value);
    }

    public static event ILContext.Manipulator get_minHeight
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TMP_Text), "get_minHeight"), value);
        remove =>
            HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(TMP_Text), "get_minHeight"), value);
    }

    public static event ILContext.Manipulator get_minWidth
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TMP_Text), "get_minWidth"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(TMP_Text), "get_minWidth"), value);
    }

    public static event ILContext.Manipulator get_preferredWidth
    {
        add =>
            HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TMP_Text), "get_preferredWidth"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(TMP_Text), "get_preferredWidth"),
            value);
    }

    public static event ILContext.Manipulator get_preferredHeight
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TMP_Text), "get_preferredHeight"),
            value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(TMP_Text), "get_preferredHeight"),
            value);
    }

    public static event ILContext.Manipulator get_renderedWidth
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TMP_Text), "get_renderedWidth"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(TMP_Text), "get_renderedWidth"),
            value);
    }

    public static event ILContext.Manipulator get_renderedHeight
    {
        add =>
            HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TMP_Text), "get_renderedHeight"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(TMP_Text), "get_renderedHeight"),
            value);
    }

    public static event ILContext.Manipulator get_layoutPriority
    {
        add =>
            HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TMP_Text), "get_layoutPriority"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(TMP_Text), "get_layoutPriority"),
            value);
    }

    public static event ILContext.Manipulator LoadFontAsset
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TMP_Text), "LoadFontAsset"), value);
        remove =>
            HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(TMP_Text), "LoadFontAsset"), value);
    }

    public static event ILContext.Manipulator SetSharedMaterial
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TMP_Text), "SetSharedMaterial"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(TMP_Text), "SetSharedMaterial"),
            value);
    }

    public static event ILContext.Manipulator GetMaterial
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TMP_Text), "GetMaterial"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(TMP_Text), "GetMaterial"), value);
    }

    public static event ILContext.Manipulator SetFontBaseMaterial
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TMP_Text), "SetFontBaseMaterial"),
            value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(TMP_Text), "SetFontBaseMaterial"),
            value);
    }

    public static event ILContext.Manipulator GetSharedMaterials
    {
        add =>
            HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TMP_Text), "GetSharedMaterials"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(TMP_Text), "GetSharedMaterials"),
            value);
    }

    public static event ILContext.Manipulator SetSharedMaterials
    {
        add =>
            HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TMP_Text), "SetSharedMaterials"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(TMP_Text), "SetSharedMaterials"),
            value);
    }

    public static event ILContext.Manipulator GetMaterials
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TMP_Text), "GetMaterials"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(TMP_Text), "GetMaterials"), value);
    }

    public static event ILContext.Manipulator CreateMaterialInstance
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TMP_Text), "CreateMaterialInstance"),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(TMP_Text), "CreateMaterialInstance"), value);
    }

    public static event ILContext.Manipulator SetVertexColorGradient
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TMP_Text), "SetVertexColorGradient"),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(TMP_Text), "SetVertexColorGradient"), value);
    }

    public static event ILContext.Manipulator SetFaceColor
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TMP_Text), "SetFaceColor"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(TMP_Text), "SetFaceColor"), value);
    }

    public static event ILContext.Manipulator SetOutlineColor
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TMP_Text), "SetOutlineColor"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(TMP_Text), "SetOutlineColor"),
            value);
    }

    public static event ILContext.Manipulator SetOutlineThickness
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TMP_Text), "SetOutlineThickness"),
            value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(TMP_Text), "SetOutlineThickness"),
            value);
    }

    public static event ILContext.Manipulator SetShaderDepth
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TMP_Text), "SetShaderDepth"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(TMP_Text), "SetShaderDepth"),
            value);
    }

    public static event ILContext.Manipulator SetCulling
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TMP_Text), "SetCulling"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(TMP_Text), "SetCulling"), value);
    }

    public static event ILContext.Manipulator GetPaddingForMaterial
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TMP_Text), "GetPaddingForMaterial"),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(TMP_Text), "GetPaddingForMaterial"), value);
    }

    public static event ILContext.Manipulator GetPaddingForMaterial_Material
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TMP_Text), "GetPaddingForMaterial"),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(TMP_Text), "GetPaddingForMaterial"), value);
    }

    public static event ILContext.Manipulator GetTextContainerLocalCorners
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(TMP_Text), "GetTextContainerLocalCorners"), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(TMP_Text), "GetTextContainerLocalCorners"), value);
    }

    public static event ILContext.Manipulator ForceMeshUpdate
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TMP_Text), "ForceMeshUpdate"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(TMP_Text), "ForceMeshUpdate"),
            value);
    }

    public static event ILContext.Manipulator ForceMeshUpdate_bool
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TMP_Text), "ForceMeshUpdate"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(TMP_Text), "ForceMeshUpdate"),
            value);
    }

    public static event ILContext.Manipulator SetTextInternal
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TMP_Text), "SetTextInternal"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(TMP_Text), "SetTextInternal"),
            value);
    }

    public static event ILContext.Manipulator UpdateGeometry
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TMP_Text), "UpdateGeometry"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(TMP_Text), "UpdateGeometry"),
            value);
    }

    public static event ILContext.Manipulator UpdateVertexData_TMP_VertexDataUpdateFlags
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TMP_Text), "UpdateVertexData"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(TMP_Text), "UpdateVertexData"),
            value);
    }

    public static event ILContext.Manipulator UpdateVertexData
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TMP_Text), "UpdateVertexData"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(TMP_Text), "UpdateVertexData"),
            value);
    }

    public static event ILContext.Manipulator SetVertices
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TMP_Text), "SetVertices"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(TMP_Text), "SetVertices"), value);
    }

    public static event ILContext.Manipulator UpdateMeshPadding
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TMP_Text), "UpdateMeshPadding"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(TMP_Text), "UpdateMeshPadding"),
            value);
    }

    public static event ILContext.Manipulator CrossFadeColor
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TMP_Text), "CrossFadeColor"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(TMP_Text), "CrossFadeColor"),
            value);
    }

    public static event ILContext.Manipulator CrossFadeAlpha
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TMP_Text), "CrossFadeAlpha"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(TMP_Text), "CrossFadeAlpha"),
            value);
    }

    public static event ILContext.Manipulator InternalCrossFadeColor
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TMP_Text), "InternalCrossFadeColor"),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(TMP_Text), "InternalCrossFadeColor"), value);
    }

    public static event ILContext.Manipulator InternalCrossFadeAlpha
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TMP_Text), "InternalCrossFadeAlpha"),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(TMP_Text), "InternalCrossFadeAlpha"), value);
    }

    public static event ILContext.Manipulator ParseInputText
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TMP_Text), "ParseInputText"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(TMP_Text), "ParseInputText"),
            value);
    }

    public static event ILContext.Manipulator SetText_string
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TMP_Text), "SetText"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(TMP_Text), "SetText"), value);
    }

    public static event ILContext.Manipulator SetText_string_float
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TMP_Text), "SetText"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(TMP_Text), "SetText"), value);
    }

    public static event ILContext.Manipulator SetText_string_float_float
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TMP_Text), "SetText"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(TMP_Text), "SetText"), value);
    }

    public static event ILContext.Manipulator SetText_string_float_float_float
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TMP_Text), "SetText"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(TMP_Text), "SetText"), value);
    }

    public static event ILContext.Manipulator SetText_StringBuilder
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TMP_Text), "SetText"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(TMP_Text), "SetText"), value);
    }

    public static event ILContext.Manipulator SetCharArray
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TMP_Text), "SetCharArray"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(TMP_Text), "SetCharArray"), value);
    }

    public static event ILContext.Manipulator SetTextArrayToCharArray
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TMP_Text), "SetTextArrayToCharArray"),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(TMP_Text), "SetTextArrayToCharArray"), value);
    }

    public static event ILContext.Manipulator StringToCharArray
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TMP_Text), "StringToCharArray"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(TMP_Text), "StringToCharArray"),
            value);
    }

    public static event ILContext.Manipulator StringBuilderToIntArray
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TMP_Text), "StringBuilderToIntArray"),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(TMP_Text), "StringBuilderToIntArray"), value);
    }

    public static event ILContext.Manipulator AddFloatToCharArray
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TMP_Text), "AddFloatToCharArray"),
            value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(TMP_Text), "AddFloatToCharArray"),
            value);
    }

    public static event ILContext.Manipulator AddIntToCharArray
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TMP_Text), "AddIntToCharArray"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(TMP_Text), "AddIntToCharArray"),
            value);
    }

    public static event ILContext.Manipulator SetArraySizes
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TMP_Text), "SetArraySizes"), value);
        remove =>
            HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(TMP_Text), "SetArraySizes"), value);
    }

    public static event ILContext.Manipulator GenerateTextMesh
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TMP_Text), "GenerateTextMesh"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(TMP_Text), "GenerateTextMesh"),
            value);
    }

    public static event ILContext.Manipulator GetPreferredValues
    {
        add =>
            HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TMP_Text), "GetPreferredValues"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(TMP_Text), "GetPreferredValues"),
            value);
    }

    public static event ILContext.Manipulator GetPreferredValues_float_float
    {
        add =>
            HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TMP_Text), "GetPreferredValues"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(TMP_Text), "GetPreferredValues"),
            value);
    }

    public static event ILContext.Manipulator GetPreferredValues_string
    {
        add =>
            HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TMP_Text), "GetPreferredValues"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(TMP_Text), "GetPreferredValues"),
            value);
    }

    public static event ILContext.Manipulator GetPreferredValues_string_float_float
    {
        add =>
            HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TMP_Text), "GetPreferredValues"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(TMP_Text), "GetPreferredValues"),
            value);
    }

    public static event ILContext.Manipulator GetPreferredWidth
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TMP_Text), "GetPreferredWidth"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(TMP_Text), "GetPreferredWidth"),
            value);
    }

    public static event ILContext.Manipulator GetPreferredWidth_Vector2
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TMP_Text), "GetPreferredWidth"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(TMP_Text), "GetPreferredWidth"),
            value);
    }

    public static event ILContext.Manipulator GetPreferredHeight
    {
        add =>
            HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TMP_Text), "GetPreferredHeight"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(TMP_Text), "GetPreferredHeight"),
            value);
    }

    public static event ILContext.Manipulator GetPreferredHeight_Vector2
    {
        add =>
            HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TMP_Text), "GetPreferredHeight"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(TMP_Text), "GetPreferredHeight"),
            value);
    }

    public static event ILContext.Manipulator GetRenderedValues
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TMP_Text), "GetRenderedValues"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(TMP_Text), "GetRenderedValues"),
            value);
    }

    public static event ILContext.Manipulator GetRenderedWidth
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TMP_Text), "GetRenderedWidth"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(TMP_Text), "GetRenderedWidth"),
            value);
    }

    public static event ILContext.Manipulator GetRenderedHeight
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TMP_Text), "GetRenderedHeight"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(TMP_Text), "GetRenderedHeight"),
            value);
    }

    public static event ILContext.Manipulator CalculatePreferredValues
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TMP_Text), "CalculatePreferredValues"),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(TMP_Text), "CalculatePreferredValues"), value);
    }

    public static event ILContext.Manipulator GetCompoundBounds
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TMP_Text), "GetCompoundBounds"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(TMP_Text), "GetCompoundBounds"),
            value);
    }

    public static event ILContext.Manipulator GetTextBounds
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TMP_Text), "GetTextBounds"), value);
        remove =>
            HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(TMP_Text), "GetTextBounds"), value);
    }

    public static event ILContext.Manipulator AdjustLineOffset
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TMP_Text), "AdjustLineOffset"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(TMP_Text), "AdjustLineOffset"),
            value);
    }

    public static event ILContext.Manipulator ResizeLineExtents
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TMP_Text), "ResizeLineExtents"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(TMP_Text), "ResizeLineExtents"),
            value);
    }

    public static event ILContext.Manipulator GetTextInfo
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TMP_Text), "GetTextInfo"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(TMP_Text), "GetTextInfo"), value);
    }

    public static event ILContext.Manipulator ComputeMarginSize
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TMP_Text), "ComputeMarginSize"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(TMP_Text), "ComputeMarginSize"),
            value);
    }

    public static event ILContext.Manipulator GetArraySizes
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TMP_Text), "GetArraySizes"), value);
        remove =>
            HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(TMP_Text), "GetArraySizes"), value);
    }

    public static event ILContext.Manipulator SaveWordWrappingState
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TMP_Text), "SaveWordWrappingState"),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(TMP_Text), "SaveWordWrappingState"), value);
    }

    public static event ILContext.Manipulator RestoreWordWrappingState
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TMP_Text), "RestoreWordWrappingState"),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(TMP_Text), "RestoreWordWrappingState"), value);
    }

    public static event ILContext.Manipulator SaveGlyphVertexInfo
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TMP_Text), "SaveGlyphVertexInfo"),
            value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(TMP_Text), "SaveGlyphVertexInfo"),
            value);
    }

    public static event ILContext.Manipulator SaveSpriteVertexInfo
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TMP_Text), "SaveSpriteVertexInfo"),
            value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(TMP_Text), "SaveSpriteVertexInfo"),
            value);
    }

    public static event ILContext.Manipulator FillCharacterVertexBuffers_int_int
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(TMP_Text), "FillCharacterVertexBuffers"), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(TMP_Text), "FillCharacterVertexBuffers"), value);
    }

    public static event ILContext.Manipulator FillCharacterVertexBuffers_int_int_bool
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(TMP_Text), "FillCharacterVertexBuffers"), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(TMP_Text), "FillCharacterVertexBuffers"), value);
    }

    public static event ILContext.Manipulator FillSpriteVertexBuffers
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TMP_Text), "FillSpriteVertexBuffers"),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(TMP_Text), "FillSpriteVertexBuffers"), value);
    }

    public static event ILContext.Manipulator DrawUnderlineMesh
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TMP_Text), "DrawUnderlineMesh"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(TMP_Text), "DrawUnderlineMesh"),
            value);
    }

    public static event ILContext.Manipulator GetSpecialCharacters
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TMP_Text), "GetSpecialCharacters"),
            value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(TMP_Text), "GetSpecialCharacters"),
            value);
    }

    public static event ILContext.Manipulator GetFontAssetForWeight
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TMP_Text), "GetFontAssetForWeight"),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(TMP_Text), "GetFontAssetForWeight"), value);
    }

    public static event ILContext.Manipulator SetActiveSubMeshes
    {
        add =>
            HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TMP_Text), "SetActiveSubMeshes"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(TMP_Text), "SetActiveSubMeshes"),
            value);
    }

    public static event ILContext.Manipulator PackUV_float_float_float
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TMP_Text), "PackUV"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(TMP_Text), "PackUV"), value);
    }

    public static event ILContext.Manipulator PackUV_float_float
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TMP_Text), "PackUV"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(TMP_Text), "PackUV"), value);
    }

    public static event ILContext.Manipulator HexToInt
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TMP_Text), "HexToInt"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(TMP_Text), "HexToInt"), value);
    }

    public static event ILContext.Manipulator GetUTF16
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TMP_Text), "GetUTF16"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(TMP_Text), "GetUTF16"), value);
    }

    public static event ILContext.Manipulator GetUTF32
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TMP_Text), "GetUTF32"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(TMP_Text), "GetUTF32"), value);
    }

    public static event ILContext.Manipulator HexCharsToColor_Array_int
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TMP_Text), "HexCharsToColor"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(TMP_Text), "HexCharsToColor"),
            value);
    }

    public static event ILContext.Manipulator HexCharsToColor_Array_int_int
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TMP_Text), "HexCharsToColor"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(TMP_Text), "HexCharsToColor"),
            value);
    }

    public static event ILContext.Manipulator ConvertToFloat
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TMP_Text), "ConvertToFloat"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(TMP_Text), "ConvertToFloat"),
            value);
    }

    public static event ILContext.Manipulator ValidateHtmlTag
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TMP_Text), "ValidateHtmlTag"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(TMP_Text), "ValidateHtmlTag"),
            value);
    }
}