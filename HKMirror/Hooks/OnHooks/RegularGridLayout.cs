using Modding.Menu;
using MonoMod.RuntimeDetour;
using MonoMod.RuntimeDetour.HookGen;

namespace HKMirror.Hooks.OnHooks;

/// <summary>
///     Contains different types of On Hooks for RegularGridLayout class.<br />
///     Contains hooks that aren't generated by monomod, and before and after orig hooks for easier hooking.
/// </summary>
public static class OnRegularGridLayout
{
    internal static class HookHandler
    {
        private static readonly List<string> HookedList = new();

        internal static void Hookget_ItemAdvance()
        {
            if (!HookedList.Contains("get_ItemAdvance"))
            {
                HookedList.Add("get_ItemAdvance");
                new Hook(ReflectionHelper.GetMethodInfo(typeof(RegularGridLayout), "get_ItemAdvance"), get_ItemAdvance);
            }
        }

        internal static event Delegates.get_ItemAdvance_BeforeArgs _beforeget_ItemAdvance;
        internal static event Delegates.get_ItemAdvance_NormalArgs _afterget_ItemAdvance;

        private static RelVector2 get_ItemAdvance(Func<RegularGridLayout, RelVector2> orig, RegularGridLayout self)
        {
            Delegates.Params_get_ItemAdvance @params = new()
            {
                self = self
            };
            _beforeget_ItemAdvance?.Invoke(@params);
            self = @params.self;
            var retVal = orig(self);
            if (_afterget_ItemAdvance != null) retVal = _afterget_ItemAdvance.Invoke(@params);
            return retVal;
        }

        internal static void Hookset_ItemAdvance()
        {
            if (!HookedList.Contains("set_ItemAdvance"))
            {
                HookedList.Add("set_ItemAdvance");
                new Hook(ReflectionHelper.GetMethodInfo(typeof(RegularGridLayout), "set_ItemAdvance"), set_ItemAdvance);
            }
        }

        internal static event Delegates.set_ItemAdvance_BeforeArgs _beforeset_ItemAdvance;
        internal static event Delegates.set_ItemAdvance_NormalArgs _afterset_ItemAdvance;

        private static void set_ItemAdvance(Action<RegularGridLayout, RelVector2> orig, RegularGridLayout self,
            RelVector2 value)
        {
            Delegates.Params_set_ItemAdvance @params = new()
            {
                self = self, value = value
            };
            _beforeset_ItemAdvance?.Invoke(@params);
            self = @params.self;
            value = @params.value;
            orig(self, value);
            if (_afterset_ItemAdvance != null) _afterset_ItemAdvance.Invoke(@params);
        }

        internal static void Hookget_Start()
        {
            if (!HookedList.Contains("get_Start"))
            {
                HookedList.Add("get_Start");
                new Hook(ReflectionHelper.GetMethodInfo(typeof(RegularGridLayout), "get_Start"), get_Start);
            }
        }

        internal static event Delegates.get_Start_BeforeArgs _beforeget_Start;
        internal static event Delegates.get_Start_NormalArgs _afterget_Start;

        private static AnchoredPosition get_Start(Func<RegularGridLayout, AnchoredPosition> orig,
            RegularGridLayout self)
        {
            Delegates.Params_get_Start @params = new()
            {
                self = self
            };
            _beforeget_Start?.Invoke(@params);
            self = @params.self;
            var retVal = orig(self);
            if (_afterget_Start != null) retVal = _afterget_Start.Invoke(@params);
            return retVal;
        }

        internal static void Hookset_Start()
        {
            if (!HookedList.Contains("set_Start"))
            {
                HookedList.Add("set_Start");
                new Hook(ReflectionHelper.GetMethodInfo(typeof(RegularGridLayout), "set_Start"), set_Start);
            }
        }

        internal static event Delegates.set_Start_BeforeArgs _beforeset_Start;
        internal static event Delegates.set_Start_NormalArgs _afterset_Start;

        private static void set_Start(Action<RegularGridLayout, AnchoredPosition> orig, RegularGridLayout self,
            AnchoredPosition value)
        {
            Delegates.Params_set_Start @params = new()
            {
                self = self, value = value
            };
            _beforeset_Start?.Invoke(@params);
            self = @params.self;
            value = @params.value;
            orig(self, value);
            if (_afterset_Start != null) _afterset_Start.Invoke(@params);
        }

        internal static void Hookget_Columns()
        {
            if (!HookedList.Contains("get_Columns"))
            {
                HookedList.Add("get_Columns");
                new Hook(ReflectionHelper.GetMethodInfo(typeof(RegularGridLayout), "get_Columns"), get_Columns);
            }
        }

        internal static event Delegates.get_Columns_BeforeArgs _beforeget_Columns;
        internal static event Delegates.get_Columns_NormalArgs _afterget_Columns;

        private static int get_Columns(Func<RegularGridLayout, int> orig, RegularGridLayout self)
        {
            Delegates.Params_get_Columns @params = new()
            {
                self = self
            };
            _beforeget_Columns?.Invoke(@params);
            self = @params.self;
            var retVal = orig(self);
            if (_afterget_Columns != null) retVal = _afterget_Columns.Invoke(@params);
            return retVal;
        }

        internal static void Hookset_Columns()
        {
            if (!HookedList.Contains("set_Columns"))
            {
                HookedList.Add("set_Columns");
                new Hook(ReflectionHelper.GetMethodInfo(typeof(RegularGridLayout), "set_Columns"), set_Columns);
            }
        }

        internal static event Delegates.set_Columns_BeforeArgs _beforeset_Columns;
        internal static event Delegates.set_Columns_NormalArgs _afterset_Columns;

        private static void set_Columns(Action<RegularGridLayout, int> orig, RegularGridLayout self, int value)
        {
            Delegates.Params_set_Columns @params = new()
            {
                self = self, value = value
            };
            _beforeset_Columns?.Invoke(@params);
            self = @params.self;
            value = @params.value;
            orig(self, value);
            if (_afterset_Columns != null) _afterset_Columns.Invoke(@params);
        }

        internal static void Hookget_Index()
        {
            if (!HookedList.Contains("get_Index"))
            {
                HookedList.Add("get_Index");
                new Hook(ReflectionHelper.GetMethodInfo(typeof(RegularGridLayout), "get_Index"), get_Index);
            }
        }

        internal static event Delegates.get_Index_BeforeArgs _beforeget_Index;
        internal static event Delegates.get_Index_NormalArgs _afterget_Index;

        private static int get_Index(Func<RegularGridLayout, int> orig, RegularGridLayout self)
        {
            Delegates.Params_get_Index @params = new()
            {
                self = self
            };
            _beforeget_Index?.Invoke(@params);
            self = @params.self;
            var retVal = orig(self);
            if (_afterget_Index != null) retVal = _afterget_Index.Invoke(@params);
            return retVal;
        }

        internal static void Hookset_Index()
        {
            if (!HookedList.Contains("set_Index"))
            {
                HookedList.Add("set_Index");
                new Hook(ReflectionHelper.GetMethodInfo(typeof(RegularGridLayout), "set_Index"), set_Index);
            }
        }

        internal static event Delegates.set_Index_BeforeArgs _beforeset_Index;
        internal static event Delegates.set_Index_NormalArgs _afterset_Index;

        private static void set_Index(Action<RegularGridLayout, int> orig, RegularGridLayout self, int value)
        {
            Delegates.Params_set_Index @params = new()
            {
                self = self, value = value
            };
            _beforeset_Index?.Invoke(@params);
            self = @params.self;
            value = @params.value;
            orig(self, value);
            if (_afterset_Index != null) _afterset_Index.Invoke(@params);
        }

        internal static void Hookget_IndexPos()
        {
            if (!HookedList.Contains("get_IndexPos"))
            {
                HookedList.Add("get_IndexPos");
                new Hook(ReflectionHelper.GetMethodInfo(typeof(RegularGridLayout), "get_IndexPos"), get_IndexPos);
            }
        }

        internal static event Delegates.get_IndexPos_BeforeArgs _beforeget_IndexPos;
        internal static event Delegates.get_IndexPos_NormalArgs _afterget_IndexPos;

        private static Vector2Int get_IndexPos(Func<RegularGridLayout, Vector2Int> orig, RegularGridLayout self)
        {
            Delegates.Params_get_IndexPos @params = new()
            {
                self = self
            };
            _beforeget_IndexPos?.Invoke(@params);
            self = @params.self;
            var retVal = orig(self);
            if (_afterget_IndexPos != null) retVal = _afterget_IndexPos.Invoke(@params);
            return retVal;
        }

        internal static void HookCreateVerticalLayout()
        {
            if (!HookedList.Contains("CreateVerticalLayout"))
            {
                HookedList.Add("CreateVerticalLayout");
                new Hook(ReflectionHelper.GetMethodInfo(typeof(RegularGridLayout), "CreateVerticalLayout", false),
                    CreateVerticalLayout);
            }
        }

        internal static event Delegates.CreateVerticalLayout_BeforeArgs _beforeCreateVerticalLayout;
        internal static event Delegates.CreateVerticalLayout_NormalArgs _afterCreateVerticalLayout;

        private static RegularGridLayout CreateVerticalLayout(Func<float, Vector2, RegularGridLayout> orig,
            float itemHeight, Vector2 start)
        {
            Delegates.Params_CreateVerticalLayout @params = new()
            {
                itemHeight = itemHeight, start = start
            };
            _beforeCreateVerticalLayout?.Invoke(@params);
            itemHeight = @params.itemHeight;
            start = @params.start;
            var retVal = orig(itemHeight, start);
            if (_afterCreateVerticalLayout != null) retVal = _afterCreateVerticalLayout.Invoke(@params);
            return retVal;
        }

        internal static void HookModifyNext()
        {
            if (!HookedList.Contains("ModifyNext"))
            {
                HookedList.Add("ModifyNext");
                new Hook(ReflectionHelper.GetMethodInfo(typeof(RegularGridLayout), "ModifyNext"), ModifyNext);
            }
        }

        internal static event Delegates.ModifyNext_BeforeArgs _beforeModifyNext;
        internal static event Delegates.ModifyNext_NormalArgs _afterModifyNext;

        private static void ModifyNext(Action<RegularGridLayout, RectTransform> orig, RegularGridLayout self,
            RectTransform rt)
        {
            Delegates.Params_ModifyNext @params = new()
            {
                self = self, rt = rt
            };
            _beforeModifyNext?.Invoke(@params);
            self = @params.self;
            rt = @params.rt;
            orig(self, rt);
            if (_afterModifyNext != null) _afterModifyNext.Invoke(@params);
        }

        internal static void HookChangeColumns()
        {
            if (!HookedList.Contains("ChangeColumns"))
            {
                HookedList.Add("ChangeColumns");
                new Hook(ReflectionHelper.GetMethodInfo(typeof(RegularGridLayout), "ChangeColumns"), ChangeColumns);
            }
        }

        internal static event Delegates.ChangeColumns_BeforeArgs _beforeChangeColumns;
        internal static event Delegates.ChangeColumns_NormalArgs _afterChangeColumns;

        private static void ChangeColumns(Action<RegularGridLayout, int, float, RelVector2?, float> orig,
            RegularGridLayout self, int columns, float originalAnchor, RelVector2? newSize, float newAnchor)
        {
            Delegates.Params_ChangeColumns @params = new()
            {
                self = self, columns = columns, originalAnchor = originalAnchor, newSize = newSize,
                newAnchor = newAnchor
            };
            _beforeChangeColumns?.Invoke(@params);
            self = @params.self;
            columns = @params.columns;
            originalAnchor = @params.originalAnchor;
            newSize = @params.newSize;
            newAnchor = @params.newAnchor;
            orig(self, columns, originalAnchor, newSize, newAnchor);
            if (_afterChangeColumns != null) _afterChangeColumns.Invoke(@params);
        }
    }

    /// <summary>
    ///     Contains necessary information to create Hooks. Does not contain any hooks
    /// </summary>
    public static class Delegates
    {
        public delegate void ChangeColumns_BeforeArgs(Params_ChangeColumns args);

        public delegate void ChangeColumns_NormalArgs(Params_ChangeColumns args);

        public delegate void CreateVerticalLayout_BeforeArgs(Params_CreateVerticalLayout args);

        public delegate RegularGridLayout CreateVerticalLayout_NormalArgs(Params_CreateVerticalLayout args);

        public delegate void get_Columns_BeforeArgs(Params_get_Columns args);

        public delegate int get_Columns_NormalArgs(Params_get_Columns args);

        public delegate void get_Index_BeforeArgs(Params_get_Index args);

        public delegate int get_Index_NormalArgs(Params_get_Index args);

        public delegate void get_IndexPos_BeforeArgs(Params_get_IndexPos args);

        public delegate Vector2Int get_IndexPos_NormalArgs(Params_get_IndexPos args);

        public delegate void get_ItemAdvance_BeforeArgs(Params_get_ItemAdvance args);

        public delegate RelVector2 get_ItemAdvance_NormalArgs(Params_get_ItemAdvance args);

        public delegate void get_Start_BeforeArgs(Params_get_Start args);

        public delegate AnchoredPosition get_Start_NormalArgs(Params_get_Start args);

        public delegate void ModifyNext_BeforeArgs(Params_ModifyNext args);

        public delegate void ModifyNext_NormalArgs(Params_ModifyNext args);

        public delegate void set_Columns_BeforeArgs(Params_set_Columns args);

        public delegate void set_Columns_NormalArgs(Params_set_Columns args);

        public delegate void set_Index_BeforeArgs(Params_set_Index args);

        public delegate void set_Index_NormalArgs(Params_set_Index args);

        public delegate void set_ItemAdvance_BeforeArgs(Params_set_ItemAdvance args);

        public delegate void set_ItemAdvance_NormalArgs(Params_set_ItemAdvance args);

        public delegate void set_Start_BeforeArgs(Params_set_Start args);

        public delegate void set_Start_NormalArgs(Params_set_Start args);

        public sealed class Params_get_ItemAdvance
        {
            public RegularGridLayout self;
        }

        public sealed class Params_set_ItemAdvance
        {
            public RegularGridLayout self;
            public RelVector2 value;
        }

        public sealed class Params_get_Start
        {
            public RegularGridLayout self;
        }

        public sealed class Params_set_Start
        {
            public RegularGridLayout self;
            public AnchoredPosition value;
        }

        public sealed class Params_get_Columns
        {
            public RegularGridLayout self;
        }

        public sealed class Params_set_Columns
        {
            public RegularGridLayout self;
            public int value;
        }

        public sealed class Params_get_Index
        {
            public RegularGridLayout self;
        }

        public sealed class Params_set_Index
        {
            public RegularGridLayout self;
            public int value;
        }

        public sealed class Params_get_IndexPos
        {
            public RegularGridLayout self;
        }

        public sealed class Params_CreateVerticalLayout
        {
            public float itemHeight;
            public Vector2 start;
        }

        public sealed class Params_ModifyNext
        {
            public RectTransform rt;
            public RegularGridLayout self;
        }

        public sealed class Params_ChangeColumns
        {
            public int columns;
            public float newAnchor;
            public RelVector2? newSize;
            public float originalAnchor;
            public RegularGridLayout self;
        }
    }

    /// <summary>
    ///     Contains Hooks to that run code before orig(self) is called
    /// </summary>
    public static class BeforeOrig
    {
        public static event Delegates.get_ItemAdvance_BeforeArgs get_ItemAdvance
        {
            add
            {
                HookHandler._beforeget_ItemAdvance += value;
                HookHandler.Hookget_ItemAdvance();
            }
            remove => HookHandler._beforeget_ItemAdvance -= value;
        }

        public static event Delegates.set_ItemAdvance_BeforeArgs set_ItemAdvance
        {
            add
            {
                HookHandler._beforeset_ItemAdvance += value;
                HookHandler.Hookset_ItemAdvance();
            }
            remove => HookHandler._beforeset_ItemAdvance -= value;
        }

        public static event Delegates.get_Start_BeforeArgs get_Start
        {
            add
            {
                HookHandler._beforeget_Start += value;
                HookHandler.Hookget_Start();
            }
            remove => HookHandler._beforeget_Start -= value;
        }

        public static event Delegates.set_Start_BeforeArgs set_Start
        {
            add
            {
                HookHandler._beforeset_Start += value;
                HookHandler.Hookset_Start();
            }
            remove => HookHandler._beforeset_Start -= value;
        }

        public static event Delegates.get_Columns_BeforeArgs get_Columns
        {
            add
            {
                HookHandler._beforeget_Columns += value;
                HookHandler.Hookget_Columns();
            }
            remove => HookHandler._beforeget_Columns -= value;
        }

        public static event Delegates.set_Columns_BeforeArgs set_Columns
        {
            add
            {
                HookHandler._beforeset_Columns += value;
                HookHandler.Hookset_Columns();
            }
            remove => HookHandler._beforeset_Columns -= value;
        }

        public static event Delegates.get_Index_BeforeArgs get_Index
        {
            add
            {
                HookHandler._beforeget_Index += value;
                HookHandler.Hookget_Index();
            }
            remove => HookHandler._beforeget_Index -= value;
        }

        public static event Delegates.set_Index_BeforeArgs set_Index
        {
            add
            {
                HookHandler._beforeset_Index += value;
                HookHandler.Hookset_Index();
            }
            remove => HookHandler._beforeset_Index -= value;
        }

        public static event Delegates.get_IndexPos_BeforeArgs get_IndexPos
        {
            add
            {
                HookHandler._beforeget_IndexPos += value;
                HookHandler.Hookget_IndexPos();
            }
            remove => HookHandler._beforeget_IndexPos -= value;
        }

        public static event Delegates.CreateVerticalLayout_BeforeArgs CreateVerticalLayout
        {
            add
            {
                HookHandler._beforeCreateVerticalLayout += value;
                HookHandler.HookCreateVerticalLayout();
            }
            remove => HookHandler._beforeCreateVerticalLayout -= value;
        }

        public static event Delegates.ModifyNext_BeforeArgs ModifyNext
        {
            add
            {
                HookHandler._beforeModifyNext += value;
                HookHandler.HookModifyNext();
            }
            remove => HookHandler._beforeModifyNext -= value;
        }

        public static event Delegates.ChangeColumns_BeforeArgs ChangeColumns
        {
            add
            {
                HookHandler._beforeChangeColumns += value;
                HookHandler.HookChangeColumns();
            }
            remove => HookHandler._beforeChangeColumns -= value;
        }
    }

    /// <summary>
    ///     Contains Hooks to that run code after orig(self) is called
    /// </summary>
    public static class AfterOrig
    {
        public static event Delegates.get_ItemAdvance_NormalArgs get_ItemAdvance
        {
            add
            {
                HookHandler._afterget_ItemAdvance += value;
                HookHandler.Hookget_ItemAdvance();
            }
            remove => HookHandler._afterget_ItemAdvance -= value;
        }

        public static event Delegates.set_ItemAdvance_NormalArgs set_ItemAdvance
        {
            add
            {
                HookHandler._afterset_ItemAdvance += value;
                HookHandler.Hookset_ItemAdvance();
            }
            remove => HookHandler._afterset_ItemAdvance -= value;
        }

        public static event Delegates.get_Start_NormalArgs get_Start
        {
            add
            {
                HookHandler._afterget_Start += value;
                HookHandler.Hookget_Start();
            }
            remove => HookHandler._afterget_Start -= value;
        }

        public static event Delegates.set_Start_NormalArgs set_Start
        {
            add
            {
                HookHandler._afterset_Start += value;
                HookHandler.Hookset_Start();
            }
            remove => HookHandler._afterset_Start -= value;
        }

        public static event Delegates.get_Columns_NormalArgs get_Columns
        {
            add
            {
                HookHandler._afterget_Columns += value;
                HookHandler.Hookget_Columns();
            }
            remove => HookHandler._afterget_Columns -= value;
        }

        public static event Delegates.set_Columns_NormalArgs set_Columns
        {
            add
            {
                HookHandler._afterset_Columns += value;
                HookHandler.Hookset_Columns();
            }
            remove => HookHandler._afterset_Columns -= value;
        }

        public static event Delegates.get_Index_NormalArgs get_Index
        {
            add
            {
                HookHandler._afterget_Index += value;
                HookHandler.Hookget_Index();
            }
            remove => HookHandler._afterget_Index -= value;
        }

        public static event Delegates.set_Index_NormalArgs set_Index
        {
            add
            {
                HookHandler._afterset_Index += value;
                HookHandler.Hookset_Index();
            }
            remove => HookHandler._afterset_Index -= value;
        }

        public static event Delegates.get_IndexPos_NormalArgs get_IndexPos
        {
            add
            {
                HookHandler._afterget_IndexPos += value;
                HookHandler.Hookget_IndexPos();
            }
            remove => HookHandler._afterget_IndexPos -= value;
        }

        public static event Delegates.CreateVerticalLayout_NormalArgs CreateVerticalLayout
        {
            add
            {
                HookHandler._afterCreateVerticalLayout += value;
                HookHandler.HookCreateVerticalLayout();
            }
            remove => HookHandler._afterCreateVerticalLayout -= value;
        }

        public static event Delegates.ModifyNext_NormalArgs ModifyNext
        {
            add
            {
                HookHandler._afterModifyNext += value;
                HookHandler.HookModifyNext();
            }
            remove => HookHandler._afterModifyNext -= value;
        }

        public static event Delegates.ChangeColumns_NormalArgs ChangeColumns
        {
            add
            {
                HookHandler._afterChangeColumns += value;
                HookHandler.HookChangeColumns();
            }
            remove => HookHandler._afterChangeColumns -= value;
        }
    }

    /// <summary>
    ///     Contains all On Hooks, even those that aren't in the On namespace such as API generated functions and property
    ///     getters/setters
    /// </summary>
    public static class WithOrig
    {
        public static event Delegates.get_ItemAdvance_NormalArgs get_ItemAdvance
        {
            add => HookEndpointManager.Add<Delegates.get_ItemAdvance_NormalArgs>(
                ReflectionHelper.GetMethodInfo(typeof(RegularGridLayout), "get_ItemAdvance"), value);
            remove => HookEndpointManager.Remove<Delegates.get_ItemAdvance_NormalArgs>(
                ReflectionHelper.GetMethodInfo(typeof(RegularGridLayout), "get_ItemAdvance"), value);
        }

        public static event Delegates.set_ItemAdvance_NormalArgs set_ItemAdvance
        {
            add => HookEndpointManager.Add<Delegates.set_ItemAdvance_NormalArgs>(
                ReflectionHelper.GetMethodInfo(typeof(RegularGridLayout), "set_ItemAdvance"), value);
            remove => HookEndpointManager.Remove<Delegates.set_ItemAdvance_NormalArgs>(
                ReflectionHelper.GetMethodInfo(typeof(RegularGridLayout), "set_ItemAdvance"), value);
        }

        public static event Delegates.get_Start_NormalArgs get_Start
        {
            add => HookEndpointManager.Add<Delegates.get_Start_NormalArgs>(
                ReflectionHelper.GetMethodInfo(typeof(RegularGridLayout), "get_Start"), value);
            remove => HookEndpointManager.Remove<Delegates.get_Start_NormalArgs>(
                ReflectionHelper.GetMethodInfo(typeof(RegularGridLayout), "get_Start"), value);
        }

        public static event Delegates.set_Start_NormalArgs set_Start
        {
            add => HookEndpointManager.Add<Delegates.set_Start_NormalArgs>(
                ReflectionHelper.GetMethodInfo(typeof(RegularGridLayout), "set_Start"), value);
            remove => HookEndpointManager.Remove<Delegates.set_Start_NormalArgs>(
                ReflectionHelper.GetMethodInfo(typeof(RegularGridLayout), "set_Start"), value);
        }

        public static event Delegates.get_Columns_NormalArgs get_Columns
        {
            add => HookEndpointManager.Add<Delegates.get_Columns_NormalArgs>(
                ReflectionHelper.GetMethodInfo(typeof(RegularGridLayout), "get_Columns"), value);
            remove => HookEndpointManager.Remove<Delegates.get_Columns_NormalArgs>(
                ReflectionHelper.GetMethodInfo(typeof(RegularGridLayout), "get_Columns"), value);
        }

        public static event Delegates.set_Columns_NormalArgs set_Columns
        {
            add => HookEndpointManager.Add<Delegates.set_Columns_NormalArgs>(
                ReflectionHelper.GetMethodInfo(typeof(RegularGridLayout), "set_Columns"), value);
            remove => HookEndpointManager.Remove<Delegates.set_Columns_NormalArgs>(
                ReflectionHelper.GetMethodInfo(typeof(RegularGridLayout), "set_Columns"), value);
        }

        public static event Delegates.get_Index_NormalArgs get_Index
        {
            add => HookEndpointManager.Add<Delegates.get_Index_NormalArgs>(
                ReflectionHelper.GetMethodInfo(typeof(RegularGridLayout), "get_Index"), value);
            remove => HookEndpointManager.Remove<Delegates.get_Index_NormalArgs>(
                ReflectionHelper.GetMethodInfo(typeof(RegularGridLayout), "get_Index"), value);
        }

        public static event Delegates.set_Index_NormalArgs set_Index
        {
            add => HookEndpointManager.Add<Delegates.set_Index_NormalArgs>(
                ReflectionHelper.GetMethodInfo(typeof(RegularGridLayout), "set_Index"), value);
            remove => HookEndpointManager.Remove<Delegates.set_Index_NormalArgs>(
                ReflectionHelper.GetMethodInfo(typeof(RegularGridLayout), "set_Index"), value);
        }

        public static event Delegates.get_IndexPos_NormalArgs get_IndexPos
        {
            add => HookEndpointManager.Add<Delegates.get_IndexPos_NormalArgs>(
                ReflectionHelper.GetMethodInfo(typeof(RegularGridLayout), "get_IndexPos"), value);
            remove => HookEndpointManager.Remove<Delegates.get_IndexPos_NormalArgs>(
                ReflectionHelper.GetMethodInfo(typeof(RegularGridLayout), "get_IndexPos"), value);
        }

        public static event Delegates.CreateVerticalLayout_NormalArgs CreateVerticalLayout
        {
            add => HookEndpointManager.Add<Delegates.CreateVerticalLayout_NormalArgs>(
                ReflectionHelper.GetMethodInfo(typeof(RegularGridLayout), "CreateVerticalLayout", false), value);
            remove => HookEndpointManager.Remove<Delegates.CreateVerticalLayout_NormalArgs>(
                ReflectionHelper.GetMethodInfo(typeof(RegularGridLayout), "CreateVerticalLayout", false), value);
        }

        public static event Delegates.ModifyNext_NormalArgs ModifyNext
        {
            add => HookEndpointManager.Add<Delegates.ModifyNext_NormalArgs>(
                ReflectionHelper.GetMethodInfo(typeof(RegularGridLayout), "ModifyNext"), value);
            remove => HookEndpointManager.Remove<Delegates.ModifyNext_NormalArgs>(
                ReflectionHelper.GetMethodInfo(typeof(RegularGridLayout), "ModifyNext"), value);
        }

        public static event Delegates.ChangeColumns_NormalArgs ChangeColumns
        {
            add => HookEndpointManager.Add<Delegates.ChangeColumns_NormalArgs>(
                ReflectionHelper.GetMethodInfo(typeof(RegularGridLayout), "ChangeColumns"), value);
            remove => HookEndpointManager.Remove<Delegates.ChangeColumns_NormalArgs>(
                ReflectionHelper.GetMethodInfo(typeof(RegularGridLayout), "ChangeColumns"), value);
        }
    }
}