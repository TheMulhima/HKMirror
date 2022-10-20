using MonoMod.RuntimeDetour.HookGen;

namespace HKMirror.Hooks.ILHooks;

/// <summary>
///     Contains all correct IL Hooks for tk2dTextMesh.<br />
///     Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
///     Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILtk2dTextMesh
{
    public static event ILContext.Manipulator get_FormattedText
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(tk2dTextMesh), "get_FormattedText"),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(tk2dTextMesh), "get_FormattedText"), value);
    }

    public static event ILContext.Manipulator UpgradeData
    {
        add => IL.tk2dTextMesh.UpgradeData += value;
        remove => IL.tk2dTextMesh.UpgradeData -= value;
    }

    public static event ILContext.Manipulator GetInlineStyleCommandLength
    {
        add => IL.tk2dTextMesh.GetInlineStyleCommandLength += value;
        remove => IL.tk2dTextMesh.GetInlineStyleCommandLength -= value;
    }

    public static event ILContext.Manipulator FormatText_string
    {
        add => IL.tk2dTextMesh.FormatText_string += value;
        remove => IL.tk2dTextMesh.FormatText_string -= value;
    }

    public static event ILContext.Manipulator FormatText
    {
        add => IL.tk2dTextMesh.FormatText += value;
        remove => IL.tk2dTextMesh.FormatText -= value;
    }

    public static event ILContext.Manipulator FormatText_string_string
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(tk2dTextMesh), "FormatText"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(tk2dTextMesh), "FormatText"),
            value);
    }

    public static event ILContext.Manipulator get_font
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(tk2dTextMesh), "get_font"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(tk2dTextMesh), "get_font"), value);
    }

    public static event ILContext.Manipulator set_font
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(tk2dTextMesh), "set_font"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(tk2dTextMesh), "set_font"), value);
    }

    public static event ILContext.Manipulator get_formatting
    {
        add =>
            HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(tk2dTextMesh), "get_formatting"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(tk2dTextMesh), "get_formatting"),
            value);
    }

    public static event ILContext.Manipulator set_formatting
    {
        add =>
            HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(tk2dTextMesh), "set_formatting"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(tk2dTextMesh), "set_formatting"),
            value);
    }

    public static event ILContext.Manipulator get_wordWrapWidth
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(tk2dTextMesh), "get_wordWrapWidth"),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(tk2dTextMesh), "get_wordWrapWidth"), value);
    }

    public static event ILContext.Manipulator set_wordWrapWidth
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(tk2dTextMesh), "set_wordWrapWidth"),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(tk2dTextMesh), "set_wordWrapWidth"), value);
    }

    public static event ILContext.Manipulator get_text
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(tk2dTextMesh), "get_text"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(tk2dTextMesh), "get_text"), value);
    }

    public static event ILContext.Manipulator set_text
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(tk2dTextMesh), "set_text"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(tk2dTextMesh), "set_text"), value);
    }

    public static event ILContext.Manipulator get_color
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(tk2dTextMesh), "get_color"), value);
        remove =>
            HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(tk2dTextMesh), "get_color"), value);
    }

    public static event ILContext.Manipulator set_color
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(tk2dTextMesh), "set_color"), value);
        remove =>
            HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(tk2dTextMesh), "set_color"), value);
    }

    public static event ILContext.Manipulator get_color2
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(tk2dTextMesh), "get_color2"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(tk2dTextMesh), "get_color2"),
            value);
    }

    public static event ILContext.Manipulator set_color2
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(tk2dTextMesh), "set_color2"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(tk2dTextMesh), "set_color2"),
            value);
    }

    public static event ILContext.Manipulator get_useGradient
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(tk2dTextMesh), "get_useGradient"),
            value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(tk2dTextMesh), "get_useGradient"),
            value);
    }

    public static event ILContext.Manipulator set_useGradient
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(tk2dTextMesh), "set_useGradient"),
            value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(tk2dTextMesh), "set_useGradient"),
            value);
    }

    public static event ILContext.Manipulator get_anchor
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(tk2dTextMesh), "get_anchor"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(tk2dTextMesh), "get_anchor"),
            value);
    }

    public static event ILContext.Manipulator set_anchor
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(tk2dTextMesh), "set_anchor"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(tk2dTextMesh), "set_anchor"),
            value);
    }

    public static event ILContext.Manipulator get_scale
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(tk2dTextMesh), "get_scale"), value);
        remove =>
            HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(tk2dTextMesh), "get_scale"), value);
    }

    public static event ILContext.Manipulator set_scale
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(tk2dTextMesh), "set_scale"), value);
        remove =>
            HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(tk2dTextMesh), "set_scale"), value);
    }

    public static event ILContext.Manipulator get_kerning
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(tk2dTextMesh), "get_kerning"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(tk2dTextMesh), "get_kerning"),
            value);
    }

    public static event ILContext.Manipulator set_kerning
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(tk2dTextMesh), "set_kerning"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(tk2dTextMesh), "set_kerning"),
            value);
    }

    public static event ILContext.Manipulator get_maxChars
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(tk2dTextMesh), "get_maxChars"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(tk2dTextMesh), "get_maxChars"),
            value);
    }

    public static event ILContext.Manipulator set_maxChars
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(tk2dTextMesh), "set_maxChars"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(tk2dTextMesh), "set_maxChars"),
            value);
    }

    public static event ILContext.Manipulator get_textureGradient
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(tk2dTextMesh), "get_textureGradient"),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(tk2dTextMesh), "get_textureGradient"), value);
    }

    public static event ILContext.Manipulator set_textureGradient
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(tk2dTextMesh), "set_textureGradient"),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(tk2dTextMesh), "set_textureGradient"), value);
    }

    public static event ILContext.Manipulator get_inlineStyling
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(tk2dTextMesh), "get_inlineStyling"),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(tk2dTextMesh), "get_inlineStyling"), value);
    }

    public static event ILContext.Manipulator set_inlineStyling
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(tk2dTextMesh), "set_inlineStyling"),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(tk2dTextMesh), "set_inlineStyling"), value);
    }

    public static event ILContext.Manipulator get_Spacing
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(tk2dTextMesh), "get_Spacing"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(tk2dTextMesh), "get_Spacing"),
            value);
    }

    public static event ILContext.Manipulator set_Spacing
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(tk2dTextMesh), "set_Spacing"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(tk2dTextMesh), "set_Spacing"),
            value);
    }

    public static event ILContext.Manipulator get_LineSpacing
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(tk2dTextMesh), "get_LineSpacing"),
            value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(tk2dTextMesh), "get_LineSpacing"),
            value);
    }

    public static event ILContext.Manipulator set_LineSpacing
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(tk2dTextMesh), "set_LineSpacing"),
            value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(tk2dTextMesh), "set_LineSpacing"),
            value);
    }

    public static event ILContext.Manipulator get_SortingOrder
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(tk2dTextMesh), "get_SortingOrder"),
            value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(tk2dTextMesh), "get_SortingOrder"),
            value);
    }

    public static event ILContext.Manipulator set_SortingOrder
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(tk2dTextMesh), "set_SortingOrder"),
            value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(tk2dTextMesh), "set_SortingOrder"),
            value);
    }

    public static event ILContext.Manipulator InitInstance
    {
        add => IL.tk2dTextMesh.InitInstance += value;
        remove => IL.tk2dTextMesh.InitInstance -= value;
    }

    public static event ILContext.Manipulator get_CachedRenderer
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(tk2dTextMesh), "get_CachedRenderer"),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(tk2dTextMesh), "get_CachedRenderer"), value);
    }

    public static event ILContext.Manipulator Awake
    {
        add => IL.tk2dTextMesh.Awake += value;
        remove => IL.tk2dTextMesh.Awake -= value;
    }

    public static event ILContext.Manipulator OnDestroy
    {
        add => IL.tk2dTextMesh.OnDestroy += value;
        remove => IL.tk2dTextMesh.OnDestroy -= value;
    }

    public static event ILContext.Manipulator get_useInlineStyling
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(tk2dTextMesh), "get_useInlineStyling"),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(tk2dTextMesh), "get_useInlineStyling"), value);
    }

    public static event ILContext.Manipulator NumDrawnCharacters
    {
        add => IL.tk2dTextMesh.NumDrawnCharacters += value;
        remove => IL.tk2dTextMesh.NumDrawnCharacters -= value;
    }

    public static event ILContext.Manipulator NumTotalCharacters
    {
        add => IL.tk2dTextMesh.NumTotalCharacters += value;
        remove => IL.tk2dTextMesh.NumTotalCharacters -= value;
    }

    public static event ILContext.Manipulator GetMeshDimensionsForString
    {
        add => IL.tk2dTextMesh.GetMeshDimensionsForString += value;
        remove => IL.tk2dTextMesh.GetMeshDimensionsForString -= value;
    }

    public static event ILContext.Manipulator GetEstimatedMeshBoundsForString
    {
        add => IL.tk2dTextMesh.GetEstimatedMeshBoundsForString += value;
        remove => IL.tk2dTextMesh.GetEstimatedMeshBoundsForString -= value;
    }

    public static event ILContext.Manipulator Init_bool
    {
        add => IL.tk2dTextMesh.Init_bool += value;
        remove => IL.tk2dTextMesh.Init_bool -= value;
    }

    public static event ILContext.Manipulator Init
    {
        add => IL.tk2dTextMesh.Init += value;
        remove => IL.tk2dTextMesh.Init -= value;
    }

    public static event ILContext.Manipulator Commit
    {
        add => IL.tk2dTextMesh.Commit += value;
        remove => IL.tk2dTextMesh.Commit -= value;
    }

    public static event ILContext.Manipulator DoNotUse__CommitInternal
    {
        add => IL.tk2dTextMesh.DoNotUse__CommitInternal += value;
        remove => IL.tk2dTextMesh.DoNotUse__CommitInternal -= value;
    }

    public static event ILContext.Manipulator MakePixelPerfect
    {
        add => IL.tk2dTextMesh.MakePixelPerfect += value;
        remove => IL.tk2dTextMesh.MakePixelPerfect -= value;
    }

    public static event ILContext.Manipulator UsesSpriteCollection
    {
        add => IL.tk2dTextMesh.UsesSpriteCollection += value;
        remove => IL.tk2dTextMesh.UsesSpriteCollection -= value;
    }

    public static event ILContext.Manipulator UpdateMaterial
    {
        add => IL.tk2dTextMesh.UpdateMaterial += value;
        remove => IL.tk2dTextMesh.UpdateMaterial -= value;
    }

    public static event ILContext.Manipulator ForceBuild
    {
        add => IL.tk2dTextMesh.ForceBuild += value;
        remove => IL.tk2dTextMesh.ForceBuild -= value;
    }
}