using Modding.Menu;
using Modding.Menu.Config;
using MonoMod.RuntimeDetour;
using MonoMod.RuntimeDetour.HookGen;
using UnityEngine.UI;

namespace HKMirror.Hooks.OnHooks;

/// <summary>
///     Contains different types of On Hooks for StaticContent class.<br />
///     Contains hooks that aren't generated by monomod, and before and after orig hooks for easier hooking.
/// </summary>
public static class OnStaticContent
{
    internal static class HookHandler
    {
        private static readonly List<string> HookedList = new();

        internal static void HookAddStaticPanel()
        {
            if (!HookedList.Contains("AddStaticPanel"))
            {
                HookedList.Add("AddStaticPanel");
                new Hook(ReflectionHelper.GetMethodInfo(typeof(StaticContent), "AddStaticPanel", false),
                    AddStaticPanel);
            }
        }

        internal static event Delegates.AddStaticPanel_BeforeArgs _beforeAddStaticPanel;
        internal static event Delegates.AddStaticPanel_AfterArgs _afterAddStaticPanel;

        private static ContentArea AddStaticPanel(Func<ContentArea, string, RelVector2, GameObject, ContentArea> orig,
            ContentArea content, string name, RelVector2 size, GameObject obj)
        {
            Delegates.Params_AddStaticPanel @params = new()
            {
                content = content, name = name, size = size, obj = obj
            };
            if (_beforeAddStaticPanel != null)
                foreach (Delegates.AddStaticPanel_BeforeArgs toInvoke in _beforeAddStaticPanel.GetInvocationList())
                    try
                    {
                        _beforeAddStaticPanel?.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }

            content = @params.content;
            name = @params.name;
            size = @params.size;
            obj = @params.obj;
            var retVal = orig(content, name, size, obj);
            if (_afterAddStaticPanel != null)
                foreach (Delegates.AddStaticPanel_AfterArgs toInvoke in _afterAddStaticPanel.GetInvocationList())
                    try
                    {
                        retVal = _afterAddStaticPanel.Invoke(@params, retVal);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }

            return retVal;
        }

        internal static void HookAddTextPanel_ContentArea_string_RelVector2_TextPanelConfig()
        {
            if (!HookedList.Contains("AddTextPanel_ContentArea_string_RelVector2_TextPanelConfig"))
            {
                HookedList.Add("AddTextPanel_ContentArea_string_RelVector2_TextPanelConfig");
                new Hook(
                    ReflectionHelper.GetMethodInfo(typeof(StaticContent),
                        "AddTextPanel_ContentArea_string_RelVector2_TextPanelConfig", false),
                    AddTextPanel_ContentArea_string_RelVector2_TextPanelConfig);
            }
        }

        internal static event Delegates.AddTextPanel_ContentArea_string_RelVector2_TextPanelConfig_BeforeArgs
            _beforeAddTextPanel_ContentArea_string_RelVector2_TextPanelConfig;

        internal static event Delegates.AddTextPanel_ContentArea_string_RelVector2_TextPanelConfig_AfterArgs
            _afterAddTextPanel_ContentArea_string_RelVector2_TextPanelConfig;

        private static ContentArea AddTextPanel_ContentArea_string_RelVector2_TextPanelConfig(
            Func<ContentArea, string, RelVector2, TextPanelConfig, ContentArea> orig, ContentArea content, string name,
            RelVector2 size, TextPanelConfig config)
        {
            Delegates.Params_AddTextPanel_ContentArea_string_RelVector2_TextPanelConfig @params = new()
            {
                content = content, name = name, size = size, config = config
            };
            if (_beforeAddTextPanel_ContentArea_string_RelVector2_TextPanelConfig != null)
                foreach (Delegates.AddTextPanel_ContentArea_string_RelVector2_TextPanelConfig_BeforeArgs toInvoke in
                         _beforeAddTextPanel_ContentArea_string_RelVector2_TextPanelConfig.GetInvocationList())
                    try
                    {
                        _beforeAddTextPanel_ContentArea_string_RelVector2_TextPanelConfig?.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }

            content = @params.content;
            name = @params.name;
            size = @params.size;
            config = @params.config;
            var retVal = orig(content, name, size, config);
            if (_afterAddTextPanel_ContentArea_string_RelVector2_TextPanelConfig != null)
                foreach (Delegates.AddTextPanel_ContentArea_string_RelVector2_TextPanelConfig_AfterArgs toInvoke in
                         _afterAddTextPanel_ContentArea_string_RelVector2_TextPanelConfig.GetInvocationList())
                    try
                    {
                        retVal = _afterAddTextPanel_ContentArea_string_RelVector2_TextPanelConfig.Invoke(@params,
                            retVal);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }

            return retVal;
        }

        internal static void HookAddTextPanel_ContentArea_string_RelVector2_TextPanelConfig_Text()
        {
            if (!HookedList.Contains("AddTextPanel_ContentArea_string_RelVector2_TextPanelConfig_Text"))
            {
                HookedList.Add("AddTextPanel_ContentArea_string_RelVector2_TextPanelConfig_Text");
                new Hook(
                    ReflectionHelper.GetMethodInfo(typeof(StaticContent),
                        "AddTextPanel_ContentArea_string_RelVector2_TextPanelConfig_Text", false),
                    AddTextPanel_ContentArea_string_RelVector2_TextPanelConfig_Text);
            }
        }

        internal static event Delegates.AddTextPanel_ContentArea_string_RelVector2_TextPanelConfig_Text_BeforeArgs
            _beforeAddTextPanel_ContentArea_string_RelVector2_TextPanelConfig_Text;

        internal static event Delegates.AddTextPanel_ContentArea_string_RelVector2_TextPanelConfig_Text_AfterArgs
            _afterAddTextPanel_ContentArea_string_RelVector2_TextPanelConfig_Text;

        private static ContentArea AddTextPanel_ContentArea_string_RelVector2_TextPanelConfig_Text(
            Func<ContentArea, string, RelVector2, TextPanelConfig, Text, ContentArea> orig, ContentArea content,
            string name, RelVector2 size, TextPanelConfig config, Text text)
        {
            Delegates.Params_AddTextPanel_ContentArea_string_RelVector2_TextPanelConfig_Text @params = new()
            {
                content = content, name = name, size = size, config = config, text = text
            };
            if (_beforeAddTextPanel_ContentArea_string_RelVector2_TextPanelConfig_Text != null)
                foreach (Delegates.AddTextPanel_ContentArea_string_RelVector2_TextPanelConfig_Text_BeforeArgs toInvoke
                         in _beforeAddTextPanel_ContentArea_string_RelVector2_TextPanelConfig_Text.GetInvocationList())
                    try
                    {
                        _beforeAddTextPanel_ContentArea_string_RelVector2_TextPanelConfig_Text?.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }

            content = @params.content;
            name = @params.name;
            size = @params.size;
            config = @params.config;
            text = @params.text;
            var retVal = orig(content, name, size, config, text);
            if (_afterAddTextPanel_ContentArea_string_RelVector2_TextPanelConfig_Text != null)
                foreach (Delegates.AddTextPanel_ContentArea_string_RelVector2_TextPanelConfig_Text_AfterArgs toInvoke in
                         _afterAddTextPanel_ContentArea_string_RelVector2_TextPanelConfig_Text.GetInvocationList())
                    try
                    {
                        retVal = _afterAddTextPanel_ContentArea_string_RelVector2_TextPanelConfig_Text.Invoke(@params,
                            retVal);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }

            return retVal;
        }

        internal static void HookAddImagePanel_ContentArea_string_RelVector2_Sprite()
        {
            if (!HookedList.Contains("AddImagePanel_ContentArea_string_RelVector2_Sprite"))
            {
                HookedList.Add("AddImagePanel_ContentArea_string_RelVector2_Sprite");
                new Hook(
                    ReflectionHelper.GetMethodInfo(typeof(StaticContent),
                        "AddImagePanel_ContentArea_string_RelVector2_Sprite", false),
                    AddImagePanel_ContentArea_string_RelVector2_Sprite);
            }
        }

        internal static event Delegates.AddImagePanel_ContentArea_string_RelVector2_Sprite_BeforeArgs
            _beforeAddImagePanel_ContentArea_string_RelVector2_Sprite;

        internal static event Delegates.AddImagePanel_ContentArea_string_RelVector2_Sprite_AfterArgs
            _afterAddImagePanel_ContentArea_string_RelVector2_Sprite;

        private static ContentArea AddImagePanel_ContentArea_string_RelVector2_Sprite(
            Func<ContentArea, string, RelVector2, Sprite, ContentArea> orig, ContentArea content, string name,
            RelVector2 size, Sprite image)
        {
            Delegates.Params_AddImagePanel_ContentArea_string_RelVector2_Sprite @params = new()
            {
                content = content, name = name, size = size, image = image
            };
            if (_beforeAddImagePanel_ContentArea_string_RelVector2_Sprite != null)
                foreach (Delegates.AddImagePanel_ContentArea_string_RelVector2_Sprite_BeforeArgs toInvoke in
                         _beforeAddImagePanel_ContentArea_string_RelVector2_Sprite.GetInvocationList())
                    try
                    {
                        _beforeAddImagePanel_ContentArea_string_RelVector2_Sprite?.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }

            content = @params.content;
            name = @params.name;
            size = @params.size;
            image = @params.image;
            var retVal = orig(content, name, size, image);
            if (_afterAddImagePanel_ContentArea_string_RelVector2_Sprite != null)
                foreach (Delegates.AddImagePanel_ContentArea_string_RelVector2_Sprite_AfterArgs toInvoke in
                         _afterAddImagePanel_ContentArea_string_RelVector2_Sprite.GetInvocationList())
                    try
                    {
                        retVal = _afterAddImagePanel_ContentArea_string_RelVector2_Sprite.Invoke(@params, retVal);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }

            return retVal;
        }

        internal static void HookAddImagePanel_ContentArea_string_RelVector2_Sprite_Image()
        {
            if (!HookedList.Contains("AddImagePanel_ContentArea_string_RelVector2_Sprite_Image"))
            {
                HookedList.Add("AddImagePanel_ContentArea_string_RelVector2_Sprite_Image");
                new Hook(
                    ReflectionHelper.GetMethodInfo(typeof(StaticContent),
                        "AddImagePanel_ContentArea_string_RelVector2_Sprite_Image", false),
                    AddImagePanel_ContentArea_string_RelVector2_Sprite_Image);
            }
        }

        internal static event Delegates.AddImagePanel_ContentArea_string_RelVector2_Sprite_Image_BeforeArgs
            _beforeAddImagePanel_ContentArea_string_RelVector2_Sprite_Image;

        internal static event Delegates.AddImagePanel_ContentArea_string_RelVector2_Sprite_Image_AfterArgs
            _afterAddImagePanel_ContentArea_string_RelVector2_Sprite_Image;

        private static ContentArea AddImagePanel_ContentArea_string_RelVector2_Sprite_Image(
            Func<ContentArea, string, RelVector2, Sprite, Image, ContentArea> orig, ContentArea content, string name,
            RelVector2 size, Sprite sprite, Image image)
        {
            Delegates.Params_AddImagePanel_ContentArea_string_RelVector2_Sprite_Image @params = new()
            {
                content = content, name = name, size = size, sprite = sprite, image = image
            };
            if (_beforeAddImagePanel_ContentArea_string_RelVector2_Sprite_Image != null)
                foreach (Delegates.AddImagePanel_ContentArea_string_RelVector2_Sprite_Image_BeforeArgs toInvoke in
                         _beforeAddImagePanel_ContentArea_string_RelVector2_Sprite_Image.GetInvocationList())
                    try
                    {
                        _beforeAddImagePanel_ContentArea_string_RelVector2_Sprite_Image?.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }

            content = @params.content;
            name = @params.name;
            size = @params.size;
            sprite = @params.sprite;
            image = @params.image;
            var retVal = orig(content, name, size, sprite, image);
            if (_afterAddImagePanel_ContentArea_string_RelVector2_Sprite_Image != null)
                foreach (Delegates.AddImagePanel_ContentArea_string_RelVector2_Sprite_Image_AfterArgs toInvoke in
                         _afterAddImagePanel_ContentArea_string_RelVector2_Sprite_Image.GetInvocationList())
                    try
                    {
                        retVal = _afterAddImagePanel_ContentArea_string_RelVector2_Sprite_Image.Invoke(@params, retVal);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }

            return retVal;
        }

        internal static void HookAddWrappedItem_ContentArea_string_ContentArea()
        {
            if (!HookedList.Contains("AddWrappedItem_ContentArea_string_ContentArea"))
            {
                HookedList.Add("AddWrappedItem_ContentArea_string_ContentArea");
                new Hook(
                    ReflectionHelper.GetMethodInfo(typeof(StaticContent),
                        "AddWrappedItem_ContentArea_string_ContentArea", false),
                    AddWrappedItem_ContentArea_string_ContentArea);
            }
        }

        internal static event Delegates.AddWrappedItem_ContentArea_string_ContentArea_BeforeArgs
            _beforeAddWrappedItem_ContentArea_string_ContentArea;

        internal static event Delegates.AddWrappedItem_ContentArea_string_ContentArea_AfterArgs
            _afterAddWrappedItem_ContentArea_string_ContentArea;

        private static ContentArea AddWrappedItem_ContentArea_string_ContentArea(
            Func<ContentArea, string, Action<ContentArea>, ContentArea> orig, ContentArea content, string name,
            Action<ContentArea> action)
        {
            Delegates.Params_AddWrappedItem_ContentArea_string_ContentArea @params = new()
            {
                content = content, name = name, action = action
            };
            if (_beforeAddWrappedItem_ContentArea_string_ContentArea != null)
                foreach (Delegates.AddWrappedItem_ContentArea_string_ContentArea_BeforeArgs toInvoke in
                         _beforeAddWrappedItem_ContentArea_string_ContentArea.GetInvocationList())
                    try
                    {
                        _beforeAddWrappedItem_ContentArea_string_ContentArea?.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }

            content = @params.content;
            name = @params.name;
            action = @params.action;
            var retVal = orig(content, name, action);
            if (_afterAddWrappedItem_ContentArea_string_ContentArea != null)
                foreach (Delegates.AddWrappedItem_ContentArea_string_ContentArea_AfterArgs toInvoke in
                         _afterAddWrappedItem_ContentArea_string_ContentArea.GetInvocationList())
                    try
                    {
                        retVal = _afterAddWrappedItem_ContentArea_string_ContentArea.Invoke(@params, retVal);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }

            return retVal;
        }

        internal static void HookAddWrappedItem_ContentArea_string_ContentArea_GameObject()
        {
            if (!HookedList.Contains("AddWrappedItem_ContentArea_string_ContentArea_GameObject"))
            {
                HookedList.Add("AddWrappedItem_ContentArea_string_ContentArea_GameObject");
                new Hook(
                    ReflectionHelper.GetMethodInfo(typeof(StaticContent),
                        "AddWrappedItem_ContentArea_string_ContentArea_GameObject", false),
                    AddWrappedItem_ContentArea_string_ContentArea_GameObject);
            }
        }

        internal static event Delegates.AddWrappedItem_ContentArea_string_ContentArea_GameObject_BeforeArgs
            _beforeAddWrappedItem_ContentArea_string_ContentArea_GameObject;

        internal static event Delegates.AddWrappedItem_ContentArea_string_ContentArea_GameObject_AfterArgs
            _afterAddWrappedItem_ContentArea_string_ContentArea_GameObject;

        private static ContentArea AddWrappedItem_ContentArea_string_ContentArea_GameObject(
            Func<ContentArea, string, Action<ContentArea>, GameObject, ContentArea> orig, ContentArea content,
            string name, Action<ContentArea> action, GameObject wrapper)
        {
            Delegates.Params_AddWrappedItem_ContentArea_string_ContentArea_GameObject @params = new()
            {
                content = content, name = name, action = action, wrapper = wrapper
            };
            if (_beforeAddWrappedItem_ContentArea_string_ContentArea_GameObject != null)
                foreach (Delegates.AddWrappedItem_ContentArea_string_ContentArea_GameObject_BeforeArgs toInvoke in
                         _beforeAddWrappedItem_ContentArea_string_ContentArea_GameObject.GetInvocationList())
                    try
                    {
                        _beforeAddWrappedItem_ContentArea_string_ContentArea_GameObject?.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }

            content = @params.content;
            name = @params.name;
            action = @params.action;
            wrapper = @params.wrapper;
            var retVal = orig(content, name, action, wrapper);
            if (_afterAddWrappedItem_ContentArea_string_ContentArea_GameObject != null)
                foreach (Delegates.AddWrappedItem_ContentArea_string_ContentArea_GameObject_AfterArgs toInvoke in
                         _afterAddWrappedItem_ContentArea_string_ContentArea_GameObject.GetInvocationList())
                    try
                    {
                        retVal = _afterAddWrappedItem_ContentArea_string_ContentArea_GameObject.Invoke(@params, retVal);
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
        public delegate ContentArea AddImagePanel_ContentArea_string_RelVector2_Sprite_AfterArgs(
            Params_AddImagePanel_ContentArea_string_RelVector2_Sprite args, ContentArea ret);

        public delegate void AddImagePanel_ContentArea_string_RelVector2_Sprite_BeforeArgs(
            Params_AddImagePanel_ContentArea_string_RelVector2_Sprite args);

        public delegate ContentArea AddImagePanel_ContentArea_string_RelVector2_Sprite_Image_AfterArgs(
            Params_AddImagePanel_ContentArea_string_RelVector2_Sprite_Image args, ContentArea ret);

        public delegate void AddImagePanel_ContentArea_string_RelVector2_Sprite_Image_BeforeArgs(
            Params_AddImagePanel_ContentArea_string_RelVector2_Sprite_Image args);

        public delegate ContentArea AddImagePanel_ContentArea_string_RelVector2_Sprite_Image_WithArgs(
            Func<ContentArea, string, RelVector2, Sprite, Image, ContentArea> orig, ContentArea content, string name,
            RelVector2 size, Sprite sprite, Image image);

        public delegate ContentArea AddImagePanel_ContentArea_string_RelVector2_Sprite_WithArgs(
            Func<ContentArea, string, RelVector2, Sprite, ContentArea> orig, ContentArea content, string name,
            RelVector2 size, Sprite image);

        public delegate ContentArea AddStaticPanel_AfterArgs(Params_AddStaticPanel args, ContentArea ret);

        public delegate void AddStaticPanel_BeforeArgs(Params_AddStaticPanel args);

        public delegate ContentArea AddStaticPanel_WithArgs(
            Func<ContentArea, string, RelVector2, GameObject, ContentArea> orig, ContentArea content, string name,
            RelVector2 size, GameObject obj);

        public delegate ContentArea AddTextPanel_ContentArea_string_RelVector2_TextPanelConfig_AfterArgs(
            Params_AddTextPanel_ContentArea_string_RelVector2_TextPanelConfig args, ContentArea ret);

        public delegate void AddTextPanel_ContentArea_string_RelVector2_TextPanelConfig_BeforeArgs(
            Params_AddTextPanel_ContentArea_string_RelVector2_TextPanelConfig args);

        public delegate ContentArea AddTextPanel_ContentArea_string_RelVector2_TextPanelConfig_Text_AfterArgs(
            Params_AddTextPanel_ContentArea_string_RelVector2_TextPanelConfig_Text args, ContentArea ret);

        public delegate void AddTextPanel_ContentArea_string_RelVector2_TextPanelConfig_Text_BeforeArgs(
            Params_AddTextPanel_ContentArea_string_RelVector2_TextPanelConfig_Text args);

        public delegate ContentArea AddTextPanel_ContentArea_string_RelVector2_TextPanelConfig_Text_WithArgs(
            Func<ContentArea, string, RelVector2, TextPanelConfig, Text, ContentArea> orig, ContentArea content,
            string name, RelVector2 size, TextPanelConfig config, Text text);

        public delegate ContentArea AddTextPanel_ContentArea_string_RelVector2_TextPanelConfig_WithArgs(
            Func<ContentArea, string, RelVector2, TextPanelConfig, ContentArea> orig, ContentArea content, string name,
            RelVector2 size, TextPanelConfig config);

        public delegate ContentArea AddWrappedItem_ContentArea_string_ContentArea_AfterArgs(
            Params_AddWrappedItem_ContentArea_string_ContentArea args, ContentArea ret);

        public delegate void AddWrappedItem_ContentArea_string_ContentArea_BeforeArgs(
            Params_AddWrappedItem_ContentArea_string_ContentArea args);

        public delegate ContentArea AddWrappedItem_ContentArea_string_ContentArea_GameObject_AfterArgs(
            Params_AddWrappedItem_ContentArea_string_ContentArea_GameObject args, ContentArea ret);

        public delegate void AddWrappedItem_ContentArea_string_ContentArea_GameObject_BeforeArgs(
            Params_AddWrappedItem_ContentArea_string_ContentArea_GameObject args);

        public delegate ContentArea AddWrappedItem_ContentArea_string_ContentArea_GameObject_WithArgs(
            Func<ContentArea, string, Action<ContentArea>, GameObject, ContentArea> orig, ContentArea content,
            string name, Action<ContentArea> action, GameObject wrapper);

        public delegate ContentArea AddWrappedItem_ContentArea_string_ContentArea_WithArgs(
            Func<ContentArea, string, Action<ContentArea>, ContentArea> orig, ContentArea content, string name,
            Action<ContentArea> action);

        public sealed class Params_AddStaticPanel
        {
            public ContentArea content;
            public string name;
            public GameObject obj;
            public RelVector2 size;
        }

        public sealed class Params_AddTextPanel_ContentArea_string_RelVector2_TextPanelConfig
        {
            public TextPanelConfig config;
            public ContentArea content;
            public string name;
            public RelVector2 size;
        }

        public sealed class Params_AddTextPanel_ContentArea_string_RelVector2_TextPanelConfig_Text
        {
            public TextPanelConfig config;
            public ContentArea content;
            public string name;
            public RelVector2 size;
            public Text text;
        }

        public sealed class Params_AddImagePanel_ContentArea_string_RelVector2_Sprite
        {
            public ContentArea content;
            public Sprite image;
            public string name;
            public RelVector2 size;
        }

        public sealed class Params_AddImagePanel_ContentArea_string_RelVector2_Sprite_Image
        {
            public ContentArea content;
            public Image image;
            public string name;
            public RelVector2 size;
            public Sprite sprite;
        }

        public sealed class Params_AddWrappedItem_ContentArea_string_ContentArea
        {
            public Action<ContentArea> action;
            public ContentArea content;
            public string name;
        }

        public sealed class Params_AddWrappedItem_ContentArea_string_ContentArea_GameObject
        {
            public Action<ContentArea> action;
            public ContentArea content;
            public string name;
            public GameObject wrapper;
        }
    }

    /// <summary>
    ///     Contains Hooks to that run code before orig(self) is called
    /// </summary>
    public static class BeforeOrig
    {
        public static event Delegates.AddStaticPanel_BeforeArgs AddStaticPanel
        {
            add
            {
                HookHandler._beforeAddStaticPanel += value;
                HookHandler.HookAddStaticPanel();
            }
            remove => HookHandler._beforeAddStaticPanel -= value;
        }

        public static event Delegates.AddTextPanel_ContentArea_string_RelVector2_TextPanelConfig_BeforeArgs
            AddTextPanel_ContentArea_string_RelVector2_TextPanelConfig
            {
                add
                {
                    HookHandler._beforeAddTextPanel_ContentArea_string_RelVector2_TextPanelConfig += value;
                    HookHandler.HookAddTextPanel_ContentArea_string_RelVector2_TextPanelConfig();
                }
                remove => HookHandler._beforeAddTextPanel_ContentArea_string_RelVector2_TextPanelConfig -= value;
            }

        public static event Delegates.AddTextPanel_ContentArea_string_RelVector2_TextPanelConfig_Text_BeforeArgs
            AddTextPanel_ContentArea_string_RelVector2_TextPanelConfig_Text
            {
                add
                {
                    HookHandler._beforeAddTextPanel_ContentArea_string_RelVector2_TextPanelConfig_Text += value;
                    HookHandler.HookAddTextPanel_ContentArea_string_RelVector2_TextPanelConfig_Text();
                }
                remove => HookHandler._beforeAddTextPanel_ContentArea_string_RelVector2_TextPanelConfig_Text -= value;
            }

        public static event Delegates.AddImagePanel_ContentArea_string_RelVector2_Sprite_BeforeArgs
            AddImagePanel_ContentArea_string_RelVector2_Sprite
            {
                add
                {
                    HookHandler._beforeAddImagePanel_ContentArea_string_RelVector2_Sprite += value;
                    HookHandler.HookAddImagePanel_ContentArea_string_RelVector2_Sprite();
                }
                remove => HookHandler._beforeAddImagePanel_ContentArea_string_RelVector2_Sprite -= value;
            }

        public static event Delegates.AddImagePanel_ContentArea_string_RelVector2_Sprite_Image_BeforeArgs
            AddImagePanel_ContentArea_string_RelVector2_Sprite_Image
            {
                add
                {
                    HookHandler._beforeAddImagePanel_ContentArea_string_RelVector2_Sprite_Image += value;
                    HookHandler.HookAddImagePanel_ContentArea_string_RelVector2_Sprite_Image();
                }
                remove => HookHandler._beforeAddImagePanel_ContentArea_string_RelVector2_Sprite_Image -= value;
            }

        public static event Delegates.AddWrappedItem_ContentArea_string_ContentArea_BeforeArgs
            AddWrappedItem_ContentArea_string_ContentArea
            {
                add
                {
                    HookHandler._beforeAddWrappedItem_ContentArea_string_ContentArea += value;
                    HookHandler.HookAddWrappedItem_ContentArea_string_ContentArea();
                }
                remove => HookHandler._beforeAddWrappedItem_ContentArea_string_ContentArea -= value;
            }

        public static event Delegates.AddWrappedItem_ContentArea_string_ContentArea_GameObject_BeforeArgs
            AddWrappedItem_ContentArea_string_ContentArea_GameObject
            {
                add
                {
                    HookHandler._beforeAddWrappedItem_ContentArea_string_ContentArea_GameObject += value;
                    HookHandler.HookAddWrappedItem_ContentArea_string_ContentArea_GameObject();
                }
                remove => HookHandler._beforeAddWrappedItem_ContentArea_string_ContentArea_GameObject -= value;
            }
    }

    /// <summary>
    ///     Contains Hooks to that run code after orig(self) is called
    /// </summary>
    public static class AfterOrig
    {
        public static event Delegates.AddStaticPanel_AfterArgs AddStaticPanel
        {
            add
            {
                HookHandler._afterAddStaticPanel += value;
                HookHandler.HookAddStaticPanel();
            }
            remove => HookHandler._afterAddStaticPanel -= value;
        }

        public static event Delegates.AddTextPanel_ContentArea_string_RelVector2_TextPanelConfig_AfterArgs
            AddTextPanel_ContentArea_string_RelVector2_TextPanelConfig
            {
                add
                {
                    HookHandler._afterAddTextPanel_ContentArea_string_RelVector2_TextPanelConfig += value;
                    HookHandler.HookAddTextPanel_ContentArea_string_RelVector2_TextPanelConfig();
                }
                remove => HookHandler._afterAddTextPanel_ContentArea_string_RelVector2_TextPanelConfig -= value;
            }

        public static event Delegates.AddTextPanel_ContentArea_string_RelVector2_TextPanelConfig_Text_AfterArgs
            AddTextPanel_ContentArea_string_RelVector2_TextPanelConfig_Text
            {
                add
                {
                    HookHandler._afterAddTextPanel_ContentArea_string_RelVector2_TextPanelConfig_Text += value;
                    HookHandler.HookAddTextPanel_ContentArea_string_RelVector2_TextPanelConfig_Text();
                }
                remove => HookHandler._afterAddTextPanel_ContentArea_string_RelVector2_TextPanelConfig_Text -= value;
            }

        public static event Delegates.AddImagePanel_ContentArea_string_RelVector2_Sprite_AfterArgs
            AddImagePanel_ContentArea_string_RelVector2_Sprite
            {
                add
                {
                    HookHandler._afterAddImagePanel_ContentArea_string_RelVector2_Sprite += value;
                    HookHandler.HookAddImagePanel_ContentArea_string_RelVector2_Sprite();
                }
                remove => HookHandler._afterAddImagePanel_ContentArea_string_RelVector2_Sprite -= value;
            }

        public static event Delegates.AddImagePanel_ContentArea_string_RelVector2_Sprite_Image_AfterArgs
            AddImagePanel_ContentArea_string_RelVector2_Sprite_Image
            {
                add
                {
                    HookHandler._afterAddImagePanel_ContentArea_string_RelVector2_Sprite_Image += value;
                    HookHandler.HookAddImagePanel_ContentArea_string_RelVector2_Sprite_Image();
                }
                remove => HookHandler._afterAddImagePanel_ContentArea_string_RelVector2_Sprite_Image -= value;
            }

        public static event Delegates.AddWrappedItem_ContentArea_string_ContentArea_AfterArgs
            AddWrappedItem_ContentArea_string_ContentArea
            {
                add
                {
                    HookHandler._afterAddWrappedItem_ContentArea_string_ContentArea += value;
                    HookHandler.HookAddWrappedItem_ContentArea_string_ContentArea();
                }
                remove => HookHandler._afterAddWrappedItem_ContentArea_string_ContentArea -= value;
            }

        public static event Delegates.AddWrappedItem_ContentArea_string_ContentArea_GameObject_AfterArgs
            AddWrappedItem_ContentArea_string_ContentArea_GameObject
            {
                add
                {
                    HookHandler._afterAddWrappedItem_ContentArea_string_ContentArea_GameObject += value;
                    HookHandler.HookAddWrappedItem_ContentArea_string_ContentArea_GameObject();
                }
                remove => HookHandler._afterAddWrappedItem_ContentArea_string_ContentArea_GameObject -= value;
            }
    }

    /// <summary>
    ///     Contains all On Hooks, even those that aren't in the On namespace such as API generated functions and property
    ///     getters/setters
    /// </summary>
    public static class WithOrig
    {
        public static event Delegates.AddStaticPanel_WithArgs AddStaticPanel
        {
            add => HookEndpointManager.Add<Delegates.AddStaticPanel_WithArgs>(
                ReflectionHelper.GetMethodInfo(typeof(StaticContent), "AddStaticPanel", false), value);
            remove => HookEndpointManager.Remove<Delegates.AddStaticPanel_WithArgs>(
                ReflectionHelper.GetMethodInfo(typeof(StaticContent), "AddStaticPanel", false), value);
        }

        public static event Delegates.AddTextPanel_ContentArea_string_RelVector2_TextPanelConfig_WithArgs
            AddTextPanel_ContentArea_string_RelVector2_TextPanelConfig
            {
                add => HookEndpointManager
                    .Add<Delegates.AddTextPanel_ContentArea_string_RelVector2_TextPanelConfig_WithArgs>(
                        ReflectionHelper.GetMethodInfo(typeof(StaticContent), "AddTextPanel", false), value);
                remove =>
                    HookEndpointManager
                        .Remove<Delegates.AddTextPanel_ContentArea_string_RelVector2_TextPanelConfig_WithArgs>(
                            ReflectionHelper.GetMethodInfo(typeof(StaticContent), "AddTextPanel", false), value);
            }

        public static event Delegates.AddTextPanel_ContentArea_string_RelVector2_TextPanelConfig_Text_WithArgs
            AddTextPanel_ContentArea_string_RelVector2_TextPanelConfig_Text
            {
                add => HookEndpointManager
                    .Add<Delegates.AddTextPanel_ContentArea_string_RelVector2_TextPanelConfig_Text_WithArgs>(
                        ReflectionHelper.GetMethodInfo(typeof(StaticContent), "AddTextPanel", false), value);
                remove =>
                    HookEndpointManager
                        .Remove<Delegates.AddTextPanel_ContentArea_string_RelVector2_TextPanelConfig_Text_WithArgs>(
                            ReflectionHelper.GetMethodInfo(typeof(StaticContent), "AddTextPanel", false), value);
            }

        public static event Delegates.AddImagePanel_ContentArea_string_RelVector2_Sprite_WithArgs
            AddImagePanel_ContentArea_string_RelVector2_Sprite
            {
                add => HookEndpointManager.Add<Delegates.AddImagePanel_ContentArea_string_RelVector2_Sprite_WithArgs>(
                    ReflectionHelper.GetMethodInfo(typeof(StaticContent), "AddImagePanel", false), value);
                remove =>
                    HookEndpointManager.Remove<Delegates.AddImagePanel_ContentArea_string_RelVector2_Sprite_WithArgs>(
                        ReflectionHelper.GetMethodInfo(typeof(StaticContent), "AddImagePanel", false), value);
            }

        public static event Delegates.AddImagePanel_ContentArea_string_RelVector2_Sprite_Image_WithArgs
            AddImagePanel_ContentArea_string_RelVector2_Sprite_Image
            {
                add => HookEndpointManager
                    .Add<Delegates.AddImagePanel_ContentArea_string_RelVector2_Sprite_Image_WithArgs>(
                        ReflectionHelper.GetMethodInfo(typeof(StaticContent), "AddImagePanel", false), value);
                remove =>
                    HookEndpointManager
                        .Remove<Delegates.AddImagePanel_ContentArea_string_RelVector2_Sprite_Image_WithArgs>(
                            ReflectionHelper.GetMethodInfo(typeof(StaticContent), "AddImagePanel", false), value);
            }

        public static event Delegates.AddWrappedItem_ContentArea_string_ContentArea_WithArgs
            AddWrappedItem_ContentArea_string_ContentArea
            {
                add => HookEndpointManager.Add<Delegates.AddWrappedItem_ContentArea_string_ContentArea_WithArgs>(
                    ReflectionHelper.GetMethodInfo(typeof(StaticContent), "AddWrappedItem", false), value);
                remove => HookEndpointManager.Remove<Delegates.AddWrappedItem_ContentArea_string_ContentArea_WithArgs>(
                    ReflectionHelper.GetMethodInfo(typeof(StaticContent), "AddWrappedItem", false), value);
            }

        public static event Delegates.AddWrappedItem_ContentArea_string_ContentArea_GameObject_WithArgs
            AddWrappedItem_ContentArea_string_ContentArea_GameObject
            {
                add => HookEndpointManager
                    .Add<Delegates.AddWrappedItem_ContentArea_string_ContentArea_GameObject_WithArgs>(
                        ReflectionHelper.GetMethodInfo(typeof(StaticContent), "AddWrappedItem", false), value);
                remove =>
                    HookEndpointManager
                        .Remove<Delegates.AddWrappedItem_ContentArea_string_ContentArea_GameObject_WithArgs>(
                            ReflectionHelper.GetMethodInfo(typeof(StaticContent), "AddWrappedItem", false), value);
            }
    }
}