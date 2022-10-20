using Modding.Menu;
using MonoMod.RuntimeDetour;
using MonoMod.RuntimeDetour.HookGen;
using UnityEngine.UI;

namespace HKMirror.Hooks.OnHooks;

/// <summary>
///     Contains different types of On Hooks for GridNavGraph class.<br />
///     Contains hooks that aren't generated by monomod, and before and after orig hooks for easier hooking.
/// </summary>
public static class OnGridNavGraph
{
    internal static class HookHandler
    {
        private static readonly List<string> HookedList = new();

        internal static void Hookget_Columns()
        {
            if (!HookedList.Contains("get_Columns"))
            {
                HookedList.Add("get_Columns");
                new Hook(ReflectionHelper.GetMethodInfo(typeof(GridNavGraph), "get_Columns"), get_Columns);
            }
        }

        internal static event Delegates.get_Columns_BeforeArgs _beforeget_Columns;
        internal static event Delegates.get_Columns_NormalArgs _afterget_Columns;

        private static int get_Columns(Func<GridNavGraph, int> orig, GridNavGraph self)
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
                new Hook(ReflectionHelper.GetMethodInfo(typeof(GridNavGraph), "set_Columns"), set_Columns);
            }
        }

        internal static event Delegates.set_Columns_BeforeArgs _beforeset_Columns;
        internal static event Delegates.set_Columns_NormalArgs _afterset_Columns;

        private static void set_Columns(Action<GridNavGraph, int> orig, GridNavGraph self, int value)
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

        internal static void HookChangeColumns()
        {
            if (!HookedList.Contains("ChangeColumns"))
            {
                HookedList.Add("ChangeColumns");
                new Hook(ReflectionHelper.GetMethodInfo(typeof(GridNavGraph), "ChangeColumns"), ChangeColumns);
            }
        }

        internal static event Delegates.ChangeColumns_BeforeArgs _beforeChangeColumns;
        internal static event Delegates.ChangeColumns_NormalArgs _afterChangeColumns;

        private static void ChangeColumns(Action<GridNavGraph, int> orig, GridNavGraph self, int columns)
        {
            Delegates.Params_ChangeColumns @params = new()
            {
                self = self, columns = columns
            };
            _beforeChangeColumns?.Invoke(@params);
            self = @params.self;
            columns = @params.columns;
            orig(self, columns);
            if (_afterChangeColumns != null) _afterChangeColumns.Invoke(@params);
        }

        internal static void HookAddNavigationNode()
        {
            if (!HookedList.Contains("AddNavigationNode"))
            {
                HookedList.Add("AddNavigationNode");
                new Hook(ReflectionHelper.GetMethodInfo(typeof(GridNavGraph), "AddNavigationNode"), AddNavigationNode);
            }
        }

        internal static event Delegates.AddNavigationNode_BeforeArgs _beforeAddNavigationNode;
        internal static event Delegates.AddNavigationNode_NormalArgs _afterAddNavigationNode;

        private static void AddNavigationNode(Action<GridNavGraph, Selectable> orig, GridNavGraph self,
            Selectable selectable)
        {
            Delegates.Params_AddNavigationNode @params = new()
            {
                self = self, selectable = selectable
            };
            _beforeAddNavigationNode?.Invoke(@params);
            self = @params.self;
            selectable = @params.selectable;
            orig(self, selectable);
            if (_afterAddNavigationNode != null) _afterAddNavigationNode.Invoke(@params);
        }

        internal static void HookBuildNavigation()
        {
            if (!HookedList.Contains("BuildNavigation"))
            {
                HookedList.Add("BuildNavigation");
                new Hook(ReflectionHelper.GetMethodInfo(typeof(GridNavGraph), "BuildNavigation"), BuildNavigation);
            }
        }

        internal static event Delegates.BuildNavigation_BeforeArgs _beforeBuildNavigation;
        internal static event Delegates.BuildNavigation_NormalArgs _afterBuildNavigation;

        private static Selectable BuildNavigation(Func<GridNavGraph, Selectable> orig, GridNavGraph self)
        {
            Delegates.Params_BuildNavigation @params = new()
            {
                self = self
            };
            _beforeBuildNavigation?.Invoke(@params);
            self = @params.self;
            var retVal = orig(self);
            if (_afterBuildNavigation != null) retVal = _afterBuildNavigation.Invoke(@params);
            return retVal;
        }
    }

    /// <summary>
    ///     Contains necessary information to create Hooks. Does not contain any hooks
    /// </summary>
    public static class Delegates
    {
        public delegate void AddNavigationNode_BeforeArgs(Params_AddNavigationNode args);

        public delegate void AddNavigationNode_NormalArgs(Params_AddNavigationNode args);

        public delegate void BuildNavigation_BeforeArgs(Params_BuildNavigation args);

        public delegate Selectable BuildNavigation_NormalArgs(Params_BuildNavigation args);

        public delegate void ChangeColumns_BeforeArgs(Params_ChangeColumns args);

        public delegate void ChangeColumns_NormalArgs(Params_ChangeColumns args);

        public delegate void get_Columns_BeforeArgs(Params_get_Columns args);

        public delegate int get_Columns_NormalArgs(Params_get_Columns args);

        public delegate void set_Columns_BeforeArgs(Params_set_Columns args);

        public delegate void set_Columns_NormalArgs(Params_set_Columns args);

        public sealed class Params_get_Columns
        {
            public GridNavGraph self;
        }

        public sealed class Params_set_Columns
        {
            public GridNavGraph self;
            public int value;
        }

        public sealed class Params_ChangeColumns
        {
            public int columns;
            public GridNavGraph self;
        }

        public sealed class Params_AddNavigationNode
        {
            public Selectable selectable;
            public GridNavGraph self;
        }

        public sealed class Params_BuildNavigation
        {
            public GridNavGraph self;
        }
    }

    /// <summary>
    ///     Contains Hooks to that run code before orig(self) is called
    /// </summary>
    public static class BeforeOrig
    {
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

        public static event Delegates.ChangeColumns_BeforeArgs ChangeColumns
        {
            add
            {
                HookHandler._beforeChangeColumns += value;
                HookHandler.HookChangeColumns();
            }
            remove => HookHandler._beforeChangeColumns -= value;
        }

        public static event Delegates.AddNavigationNode_BeforeArgs AddNavigationNode
        {
            add
            {
                HookHandler._beforeAddNavigationNode += value;
                HookHandler.HookAddNavigationNode();
            }
            remove => HookHandler._beforeAddNavigationNode -= value;
        }

        public static event Delegates.BuildNavigation_BeforeArgs BuildNavigation
        {
            add
            {
                HookHandler._beforeBuildNavigation += value;
                HookHandler.HookBuildNavigation();
            }
            remove => HookHandler._beforeBuildNavigation -= value;
        }
    }

    /// <summary>
    ///     Contains Hooks to that run code after orig(self) is called
    /// </summary>
    public static class AfterOrig
    {
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

        public static event Delegates.ChangeColumns_NormalArgs ChangeColumns
        {
            add
            {
                HookHandler._afterChangeColumns += value;
                HookHandler.HookChangeColumns();
            }
            remove => HookHandler._afterChangeColumns -= value;
        }

        public static event Delegates.AddNavigationNode_NormalArgs AddNavigationNode
        {
            add
            {
                HookHandler._afterAddNavigationNode += value;
                HookHandler.HookAddNavigationNode();
            }
            remove => HookHandler._afterAddNavigationNode -= value;
        }

        public static event Delegates.BuildNavigation_NormalArgs BuildNavigation
        {
            add
            {
                HookHandler._afterBuildNavigation += value;
                HookHandler.HookBuildNavigation();
            }
            remove => HookHandler._afterBuildNavigation -= value;
        }
    }

    /// <summary>
    ///     Contains all On Hooks, even those that aren't in the On namespace such as API generated functions and property
    ///     getters/setters
    /// </summary>
    public static class WithOrig
    {
        public static event Delegates.get_Columns_NormalArgs get_Columns
        {
            add => HookEndpointManager.Add<Delegates.get_Columns_NormalArgs>(
                ReflectionHelper.GetMethodInfo(typeof(GridNavGraph), "get_Columns"), value);
            remove => HookEndpointManager.Remove<Delegates.get_Columns_NormalArgs>(
                ReflectionHelper.GetMethodInfo(typeof(GridNavGraph), "get_Columns"), value);
        }

        public static event Delegates.set_Columns_NormalArgs set_Columns
        {
            add => HookEndpointManager.Add<Delegates.set_Columns_NormalArgs>(
                ReflectionHelper.GetMethodInfo(typeof(GridNavGraph), "set_Columns"), value);
            remove => HookEndpointManager.Remove<Delegates.set_Columns_NormalArgs>(
                ReflectionHelper.GetMethodInfo(typeof(GridNavGraph), "set_Columns"), value);
        }

        public static event Delegates.ChangeColumns_NormalArgs ChangeColumns
        {
            add => HookEndpointManager.Add<Delegates.ChangeColumns_NormalArgs>(
                ReflectionHelper.GetMethodInfo(typeof(GridNavGraph), "ChangeColumns"), value);
            remove => HookEndpointManager.Remove<Delegates.ChangeColumns_NormalArgs>(
                ReflectionHelper.GetMethodInfo(typeof(GridNavGraph), "ChangeColumns"), value);
        }

        public static event Delegates.AddNavigationNode_NormalArgs AddNavigationNode
        {
            add => HookEndpointManager.Add<Delegates.AddNavigationNode_NormalArgs>(
                ReflectionHelper.GetMethodInfo(typeof(GridNavGraph), "AddNavigationNode"), value);
            remove => HookEndpointManager.Remove<Delegates.AddNavigationNode_NormalArgs>(
                ReflectionHelper.GetMethodInfo(typeof(GridNavGraph), "AddNavigationNode"), value);
        }

        public static event Delegates.BuildNavigation_NormalArgs BuildNavigation
        {
            add => HookEndpointManager.Add<Delegates.BuildNavigation_NormalArgs>(
                ReflectionHelper.GetMethodInfo(typeof(GridNavGraph), "BuildNavigation"), value);
            remove => HookEndpointManager.Remove<Delegates.BuildNavigation_NormalArgs>(
                ReflectionHelper.GetMethodInfo(typeof(GridNavGraph), "BuildNavigation"), value);
        }
    }
}