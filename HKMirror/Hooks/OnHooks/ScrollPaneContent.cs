using Modding.Menu;
using Modding.Menu.Config;
using MonoMod.RuntimeDetour;
using MonoMod.RuntimeDetour.HookGen;
using UnityEngine.UI;

namespace HKMirror.Hooks.OnHooks;

/// <summary>
///     Contains different types of On Hooks for ScrollPaneContent class.<br />
///     Contains hooks that aren't generated by monomod, and before and after orig hooks for easier hooking.
/// </summary>
public static class OnScrollPaneContent
{
    internal static class HookHandler
    {
        private static readonly List<string> HookedList = new();

        internal static void HookAddScrollPaneContent_ContentArea_ScrollbarConfig_RelLength_IContentLayout_ContentArea()
        {
            if (!HookedList.Contains(
                    "AddScrollPaneContent_ContentArea_ScrollbarConfig_RelLength_IContentLayout_ContentArea"))
            {
                HookedList.Add("AddScrollPaneContent_ContentArea_ScrollbarConfig_RelLength_IContentLayout_ContentArea");
                new Hook(
                    ReflectionHelper.GetMethodInfo(typeof(ScrollPaneContent),
                        "AddScrollPaneContent_ContentArea_ScrollbarConfig_RelLength_IContentLayout_ContentArea", false),
                    AddScrollPaneContent_ContentArea_ScrollbarConfig_RelLength_IContentLayout_ContentArea);
            }
        }

        internal static event
            Delegates.AddScrollPaneContent_ContentArea_ScrollbarConfig_RelLength_IContentLayout_ContentArea_BeforeArgs
            _beforeAddScrollPaneContent_ContentArea_ScrollbarConfig_RelLength_IContentLayout_ContentArea;

        internal static event
            Delegates.AddScrollPaneContent_ContentArea_ScrollbarConfig_RelLength_IContentLayout_ContentArea_AfterArgs
            _afterAddScrollPaneContent_ContentArea_ScrollbarConfig_RelLength_IContentLayout_ContentArea;

        private static ContentArea
            AddScrollPaneContent_ContentArea_ScrollbarConfig_RelLength_IContentLayout_ContentArea(
                Func<ContentArea, ScrollbarConfig, RelLength, IContentLayout, Action<ContentArea>, ContentArea> orig,
                ContentArea content, ScrollbarConfig config, RelLength contentHeight, IContentLayout layout,
                Action<ContentArea> action)
        {
            Delegates.Params_AddScrollPaneContent_ContentArea_ScrollbarConfig_RelLength_IContentLayout_ContentArea
                @params = new()
                {
                    content = content, config = config, contentHeight = contentHeight, layout = layout, action = action
                };
            if (_beforeAddScrollPaneContent_ContentArea_ScrollbarConfig_RelLength_IContentLayout_ContentArea != null)
                foreach
                    (Delegates.
                         AddScrollPaneContent_ContentArea_ScrollbarConfig_RelLength_IContentLayout_ContentArea_BeforeArgs
                         toInvoke in
                     _beforeAddScrollPaneContent_ContentArea_ScrollbarConfig_RelLength_IContentLayout_ContentArea
                         .GetInvocationList())
                    try
                    {
                        _beforeAddScrollPaneContent_ContentArea_ScrollbarConfig_RelLength_IContentLayout_ContentArea
                            ?.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }

            content = @params.content;
            config = @params.config;
            contentHeight = @params.contentHeight;
            layout = @params.layout;
            action = @params.action;
            var retVal = orig(content, config, contentHeight, layout, action);
            if (_afterAddScrollPaneContent_ContentArea_ScrollbarConfig_RelLength_IContentLayout_ContentArea != null)
                foreach
                    (Delegates.
                         AddScrollPaneContent_ContentArea_ScrollbarConfig_RelLength_IContentLayout_ContentArea_AfterArgs
                         toInvoke in
                     _afterAddScrollPaneContent_ContentArea_ScrollbarConfig_RelLength_IContentLayout_ContentArea
                         .GetInvocationList())
                    try
                    {
                        retVal =
                            _afterAddScrollPaneContent_ContentArea_ScrollbarConfig_RelLength_IContentLayout_ContentArea
                                .Invoke(@params, retVal);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }

            return retVal;
        }

        internal static void
            HookAddScrollPaneContent_ContentArea_ScrollbarConfig_RelLength_IContentLayout_ContentArea_GameObject_Scrollbar()
        {
            if (!HookedList.Contains(
                    "AddScrollPaneContent_ContentArea_ScrollbarConfig_RelLength_IContentLayout_ContentArea_GameObject_Scrollbar"))
            {
                HookedList.Add(
                    "AddScrollPaneContent_ContentArea_ScrollbarConfig_RelLength_IContentLayout_ContentArea_GameObject_Scrollbar");
                new Hook(
                    ReflectionHelper.GetMethodInfo(typeof(ScrollPaneContent),
                        "AddScrollPaneContent_ContentArea_ScrollbarConfig_RelLength_IContentLayout_ContentArea_GameObject_Scrollbar",
                        false),
                    AddScrollPaneContent_ContentArea_ScrollbarConfig_RelLength_IContentLayout_ContentArea_GameObject_Scrollbar);
            }
        }

        internal static event
            Delegates.
            AddScrollPaneContent_ContentArea_ScrollbarConfig_RelLength_IContentLayout_ContentArea_GameObject_Scrollbar_BeforeArgs
            _beforeAddScrollPaneContent_ContentArea_ScrollbarConfig_RelLength_IContentLayout_ContentArea_GameObject_Scrollbar;

        internal static event
            Delegates.
            AddScrollPaneContent_ContentArea_ScrollbarConfig_RelLength_IContentLayout_ContentArea_GameObject_Scrollbar_AfterArgs
            _afterAddScrollPaneContent_ContentArea_ScrollbarConfig_RelLength_IContentLayout_ContentArea_GameObject_Scrollbar;

        private static ContentArea
            AddScrollPaneContent_ContentArea_ScrollbarConfig_RelLength_IContentLayout_ContentArea_GameObject_Scrollbar(
                Func<ContentArea, ScrollbarConfig, RelLength, IContentLayout, Action<ContentArea>, GameObject, Scrollbar
                    , ContentArea> orig, ContentArea content, ScrollbarConfig config, RelLength contentHeight,
                IContentLayout layout, Action<ContentArea> action, GameObject scrollContent, Scrollbar scroll)
        {
            Delegates.
                Params_AddScrollPaneContent_ContentArea_ScrollbarConfig_RelLength_IContentLayout_ContentArea_GameObject_Scrollbar
                @params = new()
                {
                    content = content, config = config, contentHeight = contentHeight, layout = layout, action = action,
                    scrollContent = scrollContent, scroll = scroll
                };
            if (_beforeAddScrollPaneContent_ContentArea_ScrollbarConfig_RelLength_IContentLayout_ContentArea_GameObject_Scrollbar !=
                null)
                foreach
                    (Delegates.
                         AddScrollPaneContent_ContentArea_ScrollbarConfig_RelLength_IContentLayout_ContentArea_GameObject_Scrollbar_BeforeArgs
                         toInvoke in
                     _beforeAddScrollPaneContent_ContentArea_ScrollbarConfig_RelLength_IContentLayout_ContentArea_GameObject_Scrollbar
                         .GetInvocationList())
                    try
                    {
                        _beforeAddScrollPaneContent_ContentArea_ScrollbarConfig_RelLength_IContentLayout_ContentArea_GameObject_Scrollbar
                            ?.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }

            content = @params.content;
            config = @params.config;
            contentHeight = @params.contentHeight;
            layout = @params.layout;
            action = @params.action;
            scrollContent = @params.scrollContent;
            scroll = @params.scroll;
            var retVal = orig(content, config, contentHeight, layout, action, scrollContent, scroll);
            if (_afterAddScrollPaneContent_ContentArea_ScrollbarConfig_RelLength_IContentLayout_ContentArea_GameObject_Scrollbar !=
                null)
                foreach
                    (Delegates.
                         AddScrollPaneContent_ContentArea_ScrollbarConfig_RelLength_IContentLayout_ContentArea_GameObject_Scrollbar_AfterArgs
                         toInvoke in
                     _afterAddScrollPaneContent_ContentArea_ScrollbarConfig_RelLength_IContentLayout_ContentArea_GameObject_Scrollbar
                         .GetInvocationList())
                    try
                    {
                        retVal =
                            _afterAddScrollPaneContent_ContentArea_ScrollbarConfig_RelLength_IContentLayout_ContentArea_GameObject_Scrollbar
                                .Invoke(@params, retVal);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }

            return retVal;
        }

        internal static void HookAddScrollbar()
        {
            if (!HookedList.Contains("AddScrollbar"))
            {
                HookedList.Add("AddScrollbar");
                new Hook(ReflectionHelper.GetMethodInfo(typeof(ScrollPaneContent), "AddScrollbar", false),
                    AddScrollbar);
            }
        }

        internal static event Delegates.AddScrollbar_BeforeArgs _beforeAddScrollbar;
        internal static event Delegates.AddScrollbar_AfterArgs _afterAddScrollbar;

        private static ContentArea AddScrollbar(Func<ContentArea, ScrollbarConfig, Scrollbar, ContentArea> orig,
            ContentArea content, ScrollbarConfig config, Scrollbar scroll)
        {
            Delegates.Params_AddScrollbar @params = new()
            {
                content = content, config = config, scroll = scroll
            };
            if (_beforeAddScrollbar != null)
                foreach (Delegates.AddScrollbar_BeforeArgs toInvoke in _beforeAddScrollbar.GetInvocationList())
                    try
                    {
                        _beforeAddScrollbar?.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }

            content = @params.content;
            config = @params.config;
            scroll = @params.scroll;
            var retVal = orig(content, config, scroll);
            if (_afterAddScrollbar != null)
                foreach (Delegates.AddScrollbar_AfterArgs toInvoke in _afterAddScrollbar.GetInvocationList())
                    try
                    {
                        retVal = _afterAddScrollbar.Invoke(@params, retVal);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }

            return retVal;
        }
    }

    /// <summary>
    ///     Contains necessary information to create Hooks. Does not contain any hooks
    /// </summary>
    public static class Delegates
    {
        public delegate ContentArea AddScrollbar_AfterArgs(Params_AddScrollbar args, ContentArea ret);

        public delegate void AddScrollbar_BeforeArgs(Params_AddScrollbar args);

        public delegate ContentArea AddScrollbar_WithArgs(
            Func<ContentArea, ScrollbarConfig, Scrollbar, ContentArea> orig, ContentArea content,
            ScrollbarConfig config, Scrollbar scroll);

        public delegate ContentArea
            AddScrollPaneContent_ContentArea_ScrollbarConfig_RelLength_IContentLayout_ContentArea_AfterArgs(
                Params_AddScrollPaneContent_ContentArea_ScrollbarConfig_RelLength_IContentLayout_ContentArea args,
                ContentArea ret);

        public delegate void
            AddScrollPaneContent_ContentArea_ScrollbarConfig_RelLength_IContentLayout_ContentArea_BeforeArgs(
                Params_AddScrollPaneContent_ContentArea_ScrollbarConfig_RelLength_IContentLayout_ContentArea args);

        public delegate ContentArea
            AddScrollPaneContent_ContentArea_ScrollbarConfig_RelLength_IContentLayout_ContentArea_GameObject_Scrollbar_AfterArgs(
                Params_AddScrollPaneContent_ContentArea_ScrollbarConfig_RelLength_IContentLayout_ContentArea_GameObject_Scrollbar
                    args, ContentArea ret);

        public delegate void
            AddScrollPaneContent_ContentArea_ScrollbarConfig_RelLength_IContentLayout_ContentArea_GameObject_Scrollbar_BeforeArgs(
                Params_AddScrollPaneContent_ContentArea_ScrollbarConfig_RelLength_IContentLayout_ContentArea_GameObject_Scrollbar
                    args);

        public delegate ContentArea
            AddScrollPaneContent_ContentArea_ScrollbarConfig_RelLength_IContentLayout_ContentArea_GameObject_Scrollbar_WithArgs(
                Func<ContentArea, ScrollbarConfig, RelLength, IContentLayout, Action<ContentArea>, GameObject, Scrollbar
                    , ContentArea> orig, ContentArea content, ScrollbarConfig config, RelLength contentHeight,
                IContentLayout layout, Action<ContentArea> action, GameObject scrollContent, Scrollbar scroll);

        public delegate ContentArea
            AddScrollPaneContent_ContentArea_ScrollbarConfig_RelLength_IContentLayout_ContentArea_WithArgs(
                Func<ContentArea, ScrollbarConfig, RelLength, IContentLayout, Action<ContentArea>, ContentArea> orig,
                ContentArea content, ScrollbarConfig config, RelLength contentHeight, IContentLayout layout,
                Action<ContentArea> action);

        public sealed class Params_AddScrollPaneContent_ContentArea_ScrollbarConfig_RelLength_IContentLayout_ContentArea
        {
            public Action<ContentArea> action;
            public ScrollbarConfig config;
            public ContentArea content;
            public RelLength contentHeight;
            public IContentLayout layout;
        }

        public sealed class
            Params_AddScrollPaneContent_ContentArea_ScrollbarConfig_RelLength_IContentLayout_ContentArea_GameObject_Scrollbar
        {
            public Action<ContentArea> action;
            public ScrollbarConfig config;
            public ContentArea content;
            public RelLength contentHeight;
            public IContentLayout layout;
            public Scrollbar scroll;
            public GameObject scrollContent;
        }

        public sealed class Params_AddScrollbar
        {
            public ScrollbarConfig config;
            public ContentArea content;
            public Scrollbar scroll;
        }
    }

    /// <summary>
    ///     Contains Hooks to that run code before orig(self) is called
    /// </summary>
    public static class BeforeOrig
    {
        public static event
            Delegates.AddScrollPaneContent_ContentArea_ScrollbarConfig_RelLength_IContentLayout_ContentArea_BeforeArgs
            AddScrollPaneContent_ContentArea_ScrollbarConfig_RelLength_IContentLayout_ContentArea
            {
                add
                {
                    HookHandler
                            ._beforeAddScrollPaneContent_ContentArea_ScrollbarConfig_RelLength_IContentLayout_ContentArea +=
                        value;
                    HookHandler
                        .HookAddScrollPaneContent_ContentArea_ScrollbarConfig_RelLength_IContentLayout_ContentArea();
                }
                remove => HookHandler
                        ._beforeAddScrollPaneContent_ContentArea_ScrollbarConfig_RelLength_IContentLayout_ContentArea -=
                    value;
            }

        public static event
            Delegates.
            AddScrollPaneContent_ContentArea_ScrollbarConfig_RelLength_IContentLayout_ContentArea_GameObject_Scrollbar_BeforeArgs
            AddScrollPaneContent_ContentArea_ScrollbarConfig_RelLength_IContentLayout_ContentArea_GameObject_Scrollbar
            {
                add
                {
                    HookHandler
                            ._beforeAddScrollPaneContent_ContentArea_ScrollbarConfig_RelLength_IContentLayout_ContentArea_GameObject_Scrollbar +=
                        value;
                    HookHandler
                        .HookAddScrollPaneContent_ContentArea_ScrollbarConfig_RelLength_IContentLayout_ContentArea_GameObject_Scrollbar();
                }
                remove => HookHandler
                        ._beforeAddScrollPaneContent_ContentArea_ScrollbarConfig_RelLength_IContentLayout_ContentArea_GameObject_Scrollbar -=
                    value;
            }

        public static event Delegates.AddScrollbar_BeforeArgs AddScrollbar
        {
            add
            {
                HookHandler._beforeAddScrollbar += value;
                HookHandler.HookAddScrollbar();
            }
            remove => HookHandler._beforeAddScrollbar -= value;
        }
    }

    /// <summary>
    ///     Contains Hooks to that run code after orig(self) is called
    /// </summary>
    public static class AfterOrig
    {
        public static event
            Delegates.AddScrollPaneContent_ContentArea_ScrollbarConfig_RelLength_IContentLayout_ContentArea_AfterArgs
            AddScrollPaneContent_ContentArea_ScrollbarConfig_RelLength_IContentLayout_ContentArea
            {
                add
                {
                    HookHandler
                            ._afterAddScrollPaneContent_ContentArea_ScrollbarConfig_RelLength_IContentLayout_ContentArea +=
                        value;
                    HookHandler
                        .HookAddScrollPaneContent_ContentArea_ScrollbarConfig_RelLength_IContentLayout_ContentArea();
                }
                remove => HookHandler
                        ._afterAddScrollPaneContent_ContentArea_ScrollbarConfig_RelLength_IContentLayout_ContentArea -=
                    value;
            }

        public static event
            Delegates.
            AddScrollPaneContent_ContentArea_ScrollbarConfig_RelLength_IContentLayout_ContentArea_GameObject_Scrollbar_AfterArgs
            AddScrollPaneContent_ContentArea_ScrollbarConfig_RelLength_IContentLayout_ContentArea_GameObject_Scrollbar
            {
                add
                {
                    HookHandler
                            ._afterAddScrollPaneContent_ContentArea_ScrollbarConfig_RelLength_IContentLayout_ContentArea_GameObject_Scrollbar +=
                        value;
                    HookHandler
                        .HookAddScrollPaneContent_ContentArea_ScrollbarConfig_RelLength_IContentLayout_ContentArea_GameObject_Scrollbar();
                }
                remove => HookHandler
                        ._afterAddScrollPaneContent_ContentArea_ScrollbarConfig_RelLength_IContentLayout_ContentArea_GameObject_Scrollbar -=
                    value;
            }

        public static event Delegates.AddScrollbar_AfterArgs AddScrollbar
        {
            add
            {
                HookHandler._afterAddScrollbar += value;
                HookHandler.HookAddScrollbar();
            }
            remove => HookHandler._afterAddScrollbar -= value;
        }
    }

    /// <summary>
    ///     Contains all On Hooks, even those that aren't in the On namespace such as API generated functions and property
    ///     getters/setters
    /// </summary>
    public static class WithOrig
    {
        public static event
            Delegates.AddScrollPaneContent_ContentArea_ScrollbarConfig_RelLength_IContentLayout_ContentArea_WithArgs
            AddScrollPaneContent_ContentArea_ScrollbarConfig_RelLength_IContentLayout_ContentArea
            {
                add => HookEndpointManager
                    .Add<Delegates.
                        AddScrollPaneContent_ContentArea_ScrollbarConfig_RelLength_IContentLayout_ContentArea_WithArgs>(
                        ReflectionHelper.GetMethodInfo(typeof(ScrollPaneContent), "AddScrollPaneContent", false),
                        value);
                remove =>
                    HookEndpointManager
                        .Remove<
                            Delegates.
                            AddScrollPaneContent_ContentArea_ScrollbarConfig_RelLength_IContentLayout_ContentArea_WithArgs>(
                            ReflectionHelper.GetMethodInfo(typeof(ScrollPaneContent), "AddScrollPaneContent", false),
                            value);
            }

        public static event
            Delegates.
            AddScrollPaneContent_ContentArea_ScrollbarConfig_RelLength_IContentLayout_ContentArea_GameObject_Scrollbar_WithArgs
            AddScrollPaneContent_ContentArea_ScrollbarConfig_RelLength_IContentLayout_ContentArea_GameObject_Scrollbar
            {
                add => HookEndpointManager
                    .Add<Delegates.
                        AddScrollPaneContent_ContentArea_ScrollbarConfig_RelLength_IContentLayout_ContentArea_GameObject_Scrollbar_WithArgs>(
                        ReflectionHelper.GetMethodInfo(typeof(ScrollPaneContent), "AddScrollPaneContent", false),
                        value);
                remove => HookEndpointManager
                    .Remove<
                        Delegates.
                        AddScrollPaneContent_ContentArea_ScrollbarConfig_RelLength_IContentLayout_ContentArea_GameObject_Scrollbar_WithArgs>(
                        ReflectionHelper.GetMethodInfo(typeof(ScrollPaneContent), "AddScrollPaneContent", false),
                        value);
            }

        public static event Delegates.AddScrollbar_WithArgs AddScrollbar
        {
            add => HookEndpointManager.Add<Delegates.AddScrollbar_WithArgs>(
                ReflectionHelper.GetMethodInfo(typeof(ScrollPaneContent), "AddScrollbar", false), value);
            remove => HookEndpointManager.Remove<Delegates.AddScrollbar_WithArgs>(
                ReflectionHelper.GetMethodInfo(typeof(ScrollPaneContent), "AddScrollbar", false), value);
        }
    }
}