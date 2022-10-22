namespace HKMirror.Hooks.OnHooks;

/// <summary>
///     Contains different types of On Hooks for GizmoUtility class.<br />
///     Contains hooks that aren't generated by monomod, and before and after orig hooks for easier hooking.
/// </summary>
public static class OnGizmoUtility
{
    internal static class HookHandler
    {
        private static readonly List<string> HookedList = new();

        internal static void HookDrawText()
        {
            if (!HookedList.Contains("DrawText"))
            {
                HookedList.Add("DrawText");
                On.GizmoUtility.DrawText += DrawText;
            }
        }

        internal static event Delegates.DrawText_BeforeArgs _beforeDrawText;
        internal static event Delegates.DrawText_AfterArgs _afterDrawText;

        private static void DrawText(On.GizmoUtility.orig_DrawText orig, GUISkin guiSkin, string text, Vector3 position,
            Color? color, int fontSize, float yOffset)
        {
            Delegates.Params_DrawText @params = new()
            {
                guiSkin = guiSkin, text = text, position = position, color = color, fontSize = fontSize,
                yOffset = yOffset
            };
            if (_beforeDrawText != null)
                foreach (Delegates.DrawText_BeforeArgs toInvoke in _beforeDrawText.GetInvocationList())
                    try
                    {
                        _beforeDrawText?.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }

            guiSkin = @params.guiSkin;
            text = @params.text;
            position = @params.position;
            color = @params.color;
            fontSize = @params.fontSize;
            yOffset = @params.yOffset;
            orig(guiSkin, text, position, color, fontSize, yOffset);
            if (_afterDrawText != null)
                foreach (Delegates.DrawText_AfterArgs toInvoke in _afterDrawText.GetInvocationList())
                    try
                    {
                        _afterDrawText.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }
        }
    }

    /// <summary>
    ///     Contains necessary information to create Hooks. Does not contain any hooks
    /// </summary>
    public static class Delegates
    {
        public delegate void DrawText_AfterArgs(Params_DrawText args);

        public delegate void DrawText_BeforeArgs(Params_DrawText args);

        public delegate void DrawText_WithArgs(Action<GUISkin, string, Vector3, Color?, int, float> orig,
            GUISkin guiSkin, string text, Vector3 position, Color? color, int fontSize, float yOffset);

        public sealed class Params_DrawText
        {
            public Color? color;
            public int fontSize;
            public GUISkin guiSkin;
            public Vector3 position;
            public string text;
            public float yOffset;
        }
    }

    /// <summary>
    ///     Contains Hooks to that run code before orig(self) is called
    /// </summary>
    public static class BeforeOrig
    {
        public static event Delegates.DrawText_BeforeArgs DrawText
        {
            add
            {
                HookHandler._beforeDrawText += value;
                HookHandler.HookDrawText();
            }
            remove => HookHandler._beforeDrawText -= value;
        }
    }

    /// <summary>
    ///     Contains Hooks to that run code after orig(self) is called
    /// </summary>
    public static class AfterOrig
    {
        public static event Delegates.DrawText_AfterArgs DrawText
        {
            add
            {
                HookHandler._afterDrawText += value;
                HookHandler.HookDrawText();
            }
            remove => HookHandler._afterDrawText -= value;
        }
    }

    /// <summary>
    ///     Contains all On Hooks, even those that aren't in the On namespace such as API generated functions and property
    ///     getters/setters
    /// </summary>
    public static class WithOrig
    {
        public static event On.GizmoUtility.hook_DrawText DrawText
        {
            add => On.GizmoUtility.DrawText += value;
            remove => On.GizmoUtility.DrawText -= value;
        }
    }
}