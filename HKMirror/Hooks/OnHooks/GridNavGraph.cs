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
        internal static event Delegates.get_Columns_AfterArgs _afterget_Columns;

        private static int get_Columns(Func<GridNavGraph, int> orig, GridNavGraph self)
        {
            Delegates.Params_get_Columns @params = new()
            {
                self = self
            };
            if (_beforeget_Columns != null)
                foreach (Delegates.get_Columns_BeforeArgs toInvoke in _beforeget_Columns.GetInvocationList())
                    try
                    {
                        _beforeget_Columns?.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }

            self = @params.self;
            var retVal = orig(self);
            if (_afterget_Columns != null)
                foreach (Delegates.get_Columns_AfterArgs toInvoke in _afterget_Columns.GetInvocationList())
                    try
                    {
                        retVal = _afterget_Columns.Invoke(@params, retVal);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }

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
        internal static event Delegates.set_Columns_AfterArgs _afterset_Columns;

        private static void set_Columns(Action<GridNavGraph, int> orig, GridNavGraph self, int value)
        {
            Delegates.Params_set_Columns @params = new()
            {
                self = self, value = value
            };
            if (_beforeset_Columns != null)
                foreach (Delegates.set_Columns_BeforeArgs toInvoke in _beforeset_Columns.GetInvocationList())
                    try
                    {
                        _beforeset_Columns?.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }

            self = @params.self;
            value = @params.value;
            orig(self, value);
            if (_afterset_Columns != null)
                foreach (Delegates.set_Columns_AfterArgs toInvoke in _afterset_Columns.GetInvocationList())
                    try
                    {
                        _afterset_Columns.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }
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
        internal static event Delegates.ChangeColumns_AfterArgs _afterChangeColumns;

        private static void ChangeColumns(Action<GridNavGraph, int> orig, GridNavGraph self, int columns)
        {
            Delegates.Params_ChangeColumns @params = new()
            {
                self = self, columns = columns
            };
            if (_beforeChangeColumns != null)
                foreach (Delegates.ChangeColumns_BeforeArgs toInvoke in _beforeChangeColumns.GetInvocationList())
                    try
                    {
                        _beforeChangeColumns?.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }

            self = @params.self;
            columns = @params.columns;
            orig(self, columns);
            if (_afterChangeColumns != null)
                foreach (Delegates.ChangeColumns_AfterArgs toInvoke in _afterChangeColumns.GetInvocationList())
                    try
                    {
                        _afterChangeColumns.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }
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
        internal static event Delegates.AddNavigationNode_AfterArgs _afterAddNavigationNode;

        private static void AddNavigationNode(Action<GridNavGraph, Selectable> orig, GridNavGraph self,
            Selectable selectable)
        {
            Delegates.Params_AddNavigationNode @params = new()
            {
                self = self, selectable = selectable
            };
            if (_beforeAddNavigationNode != null)
                foreach (Delegates.AddNavigationNode_BeforeArgs toInvoke in
                         _beforeAddNavigationNode.GetInvocationList())
                    try
                    {
                        _beforeAddNavigationNode?.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }

            self = @params.self;
            selectable = @params.selectable;
            orig(self, selectable);
            if (_afterAddNavigationNode != null)
                foreach (Delegates.AddNavigationNode_AfterArgs toInvoke in _afterAddNavigationNode.GetInvocationList())
                    try
                    {
                        _afterAddNavigationNode.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }
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
        internal static event Delegates.BuildNavigation_AfterArgs _afterBuildNavigation;

        private static Selectable BuildNavigation(Func<GridNavGraph, Selectable> orig, GridNavGraph self)
        {
            Delegates.Params_BuildNavigation @params = new()
            {
                self = self
            };
            if (_beforeBuildNavigation != null)
                foreach (Delegates.BuildNavigation_BeforeArgs toInvoke in _beforeBuildNavigation.GetInvocationList())
                    try
                    {
                        _beforeBuildNavigation?.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }

            self = @params.self;
            var retVal = orig(self);
            if (_afterBuildNavigation != null)
                foreach (Delegates.BuildNavigation_AfterArgs toInvoke in _afterBuildNavigation.GetInvocationList())
                    try
                    {
                        retVal = _afterBuildNavigation.Invoke(@params, retVal);
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
        public delegate void AddNavigationNode_AfterArgs(Params_AddNavigationNode args);

        public delegate void AddNavigationNode_BeforeArgs(Params_AddNavigationNode args);

        public delegate void AddNavigationNode_WithArgs(Action<GridNavGraph, Selectable> orig, GridNavGraph self,
            Selectable selectable);

        public delegate Selectable BuildNavigation_AfterArgs(Params_BuildNavigation args, Selectable ret);

        public delegate void BuildNavigation_BeforeArgs(Params_BuildNavigation args);

        public delegate Selectable BuildNavigation_WithArgs(Func<GridNavGraph, Selectable> orig, GridNavGraph self);

        public delegate void ChangeColumns_AfterArgs(Params_ChangeColumns args);

        public delegate void ChangeColumns_BeforeArgs(Params_ChangeColumns args);

        public delegate void ChangeColumns_WithArgs(Action<GridNavGraph, int> orig, GridNavGraph self, int columns);

        public delegate int get_Columns_AfterArgs(Params_get_Columns args, int ret);

        public delegate void get_Columns_BeforeArgs(Params_get_Columns args);

        public delegate int get_Columns_WithArgs(Func<GridNavGraph, int> orig, GridNavGraph self);

        public delegate void set_Columns_AfterArgs(Params_set_Columns args);

        public delegate void set_Columns_BeforeArgs(Params_set_Columns args);

        public delegate void set_Columns_WithArgs(Action<GridNavGraph, int> orig, GridNavGraph self, int value);

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
        public static event Delegates.get_Columns_AfterArgs get_Columns
        {
            add
            {
                HookHandler._afterget_Columns += value;
                HookHandler.Hookget_Columns();
            }
            remove => HookHandler._afterget_Columns -= value;
        }

        public static event Delegates.set_Columns_AfterArgs set_Columns
        {
            add
            {
                HookHandler._afterset_Columns += value;
                HookHandler.Hookset_Columns();
            }
            remove => HookHandler._afterset_Columns -= value;
        }

        public static event Delegates.ChangeColumns_AfterArgs ChangeColumns
        {
            add
            {
                HookHandler._afterChangeColumns += value;
                HookHandler.HookChangeColumns();
            }
            remove => HookHandler._afterChangeColumns -= value;
        }

        public static event Delegates.AddNavigationNode_AfterArgs AddNavigationNode
        {
            add
            {
                HookHandler._afterAddNavigationNode += value;
                HookHandler.HookAddNavigationNode();
            }
            remove => HookHandler._afterAddNavigationNode -= value;
        }

        public static event Delegates.BuildNavigation_AfterArgs BuildNavigation
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
        public static event Delegates.get_Columns_WithArgs get_Columns
        {
            add => HookEndpointManager.Add<Delegates.get_Columns_WithArgs>(
                ReflectionHelper.GetMethodInfo(typeof(GridNavGraph), "get_Columns"), value);
            remove => HookEndpointManager.Remove<Delegates.get_Columns_WithArgs>(
                ReflectionHelper.GetMethodInfo(typeof(GridNavGraph), "get_Columns"), value);
        }

        public static event Delegates.set_Columns_WithArgs set_Columns
        {
            add => HookEndpointManager.Add<Delegates.set_Columns_WithArgs>(
                ReflectionHelper.GetMethodInfo(typeof(GridNavGraph), "set_Columns"), value);
            remove => HookEndpointManager.Remove<Delegates.set_Columns_WithArgs>(
                ReflectionHelper.GetMethodInfo(typeof(GridNavGraph), "set_Columns"), value);
        }

        public static event Delegates.ChangeColumns_WithArgs ChangeColumns
        {
            add => HookEndpointManager.Add<Delegates.ChangeColumns_WithArgs>(
                ReflectionHelper.GetMethodInfo(typeof(GridNavGraph), "ChangeColumns"), value);
            remove => HookEndpointManager.Remove<Delegates.ChangeColumns_WithArgs>(
                ReflectionHelper.GetMethodInfo(typeof(GridNavGraph), "ChangeColumns"), value);
        }

        public static event Delegates.AddNavigationNode_WithArgs AddNavigationNode
        {
            add => HookEndpointManager.Add<Delegates.AddNavigationNode_WithArgs>(
                ReflectionHelper.GetMethodInfo(typeof(GridNavGraph), "AddNavigationNode"), value);
            remove => HookEndpointManager.Remove<Delegates.AddNavigationNode_WithArgs>(
                ReflectionHelper.GetMethodInfo(typeof(GridNavGraph), "AddNavigationNode"), value);
        }

        public static event Delegates.BuildNavigation_WithArgs BuildNavigation
        {
            add => HookEndpointManager.Add<Delegates.BuildNavigation_WithArgs>(
                ReflectionHelper.GetMethodInfo(typeof(GridNavGraph), "BuildNavigation"), value);
            remove => HookEndpointManager.Remove<Delegates.BuildNavigation_WithArgs>(
                ReflectionHelper.GetMethodInfo(typeof(GridNavGraph), "BuildNavigation"), value);
        }
    }
}