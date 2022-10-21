using MonoMod.RuntimeDetour;
using MonoMod.RuntimeDetour.HookGen;

namespace HKMirror.Hooks.OnHooks;

/// <summary>
/// Contains different types of On Hooks for ChainedNavGraph class.<br />
/// Contains hooks that aren't generated by monomod, and before and after orig hooks for easier hooking.
/// </summary>
public static class OnChainedNavGraph
{
    internal static class HookHandler
    {
        private static List<string> HookedList = new List<string>();

        internal static void HookAddNavigationNode()
        {
            if (!HookedList.Contains("AddNavigationNode"))
            {
                HookedList.Add("AddNavigationNode");
                new Hook(
                    ReflectionHelper.GetMethodInfo(typeof(Modding.Menu.ChainedNavGraph), "AddNavigationNode", true),
                    AddNavigationNode);
            }
        }

        internal static event Delegates.AddNavigationNode_BeforeArgs _beforeAddNavigationNode;
        internal static event Delegates.AddNavigationNode_AfterArgs _afterAddNavigationNode;

        private static void AddNavigationNode(Action<Modding.Menu.ChainedNavGraph, UnityEngine.UI.Selectable> orig,
            Modding.Menu.ChainedNavGraph self, UnityEngine.UI.Selectable selectable)
        {
            Delegates.Params_AddNavigationNode @params = new()
            {
                self = self, selectable = selectable
            };
            if (_beforeAddNavigationNode != null)
            {
                foreach (Delegates.AddNavigationNode_BeforeArgs toInvoke in
                         _beforeAddNavigationNode.GetInvocationList())
                {
                    try
                    {
                        _beforeAddNavigationNode?.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }
                }
            }

            self = @params.self;
            selectable = @params.selectable;
            orig(self, selectable);
            if (_afterAddNavigationNode != null)
            {
                foreach (Delegates.AddNavigationNode_AfterArgs toInvoke in _afterAddNavigationNode.GetInvocationList())
                {
                    try
                    {
                        _afterAddNavigationNode.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }
                }
            }
        }

        internal static void HookBuildNavigation()
        {
            if (!HookedList.Contains("BuildNavigation"))
            {
                HookedList.Add("BuildNavigation");
                new Hook(ReflectionHelper.GetMethodInfo(typeof(Modding.Menu.ChainedNavGraph), "BuildNavigation", true),
                    BuildNavigation);
            }
        }

        internal static event Delegates.BuildNavigation_BeforeArgs _beforeBuildNavigation;
        internal static event Delegates.BuildNavigation_AfterArgs _afterBuildNavigation;

        private static UnityEngine.UI.Selectable BuildNavigation(
            Func<Modding.Menu.ChainedNavGraph, UnityEngine.UI.Selectable> orig, Modding.Menu.ChainedNavGraph self)
        {
            Delegates.Params_BuildNavigation @params = new()
            {
                self = self
            };
            if (_beforeBuildNavigation != null)
            {
                foreach (Delegates.BuildNavigation_BeforeArgs toInvoke in _beforeBuildNavigation.GetInvocationList())
                {
                    try
                    {
                        _beforeBuildNavigation?.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }
                }
            }

            self = @params.self;
            var retVal = orig(self);
            if (_afterBuildNavigation != null)
            {
                foreach (Delegates.BuildNavigation_AfterArgs toInvoke in _afterBuildNavigation.GetInvocationList())
                {
                    try
                    {
                        retVal = _afterBuildNavigation.Invoke(@params, retVal);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }
                }
            }

            return retVal;
        }
    }

    /// <summary>
    /// Contains necessary information to create Hooks. Does not contain any hooks
    /// </summary>
    public static class Delegates
    {
        public sealed class Params_AddNavigationNode
        {
            public Modding.Menu.ChainedNavGraph self;
            public UnityEngine.UI.Selectable selectable;
        }

        public delegate void AddNavigationNode_BeforeArgs(Params_AddNavigationNode args);

        public delegate void AddNavigationNode_AfterArgs(Params_AddNavigationNode args);

        public delegate void AddNavigationNode_WithArgs(
            Action<Modding.Menu.ChainedNavGraph, UnityEngine.UI.Selectable> orig, Modding.Menu.ChainedNavGraph self,
            UnityEngine.UI.Selectable selectable);

        public sealed class Params_BuildNavigation
        {
            public Modding.Menu.ChainedNavGraph self;
        }

        public delegate void BuildNavigation_BeforeArgs(Params_BuildNavigation args);

        public delegate UnityEngine.UI.Selectable BuildNavigation_AfterArgs(Params_BuildNavigation args,
            UnityEngine.UI.Selectable ret);

        public delegate UnityEngine.UI.Selectable BuildNavigation_WithArgs(
            Func<Modding.Menu.ChainedNavGraph, UnityEngine.UI.Selectable> orig, Modding.Menu.ChainedNavGraph self);
    }

    /// <summary>
    /// Contains Hooks to that run code before orig(self) is called
    /// </summary>
    public static class BeforeOrig
    {
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
    /// Contains Hooks to that run code after orig(self) is called
    /// </summary>
    public static class AfterOrig
    {
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
    /// Contains all On Hooks, even those that aren't in the On namespace such as API generated functions and property getters/setters
    /// </summary>
    public static class WithOrig
    {
        public static event Delegates.AddNavigationNode_WithArgs AddNavigationNode
        {
            add => HookEndpointManager.Add<Delegates.AddNavigationNode_WithArgs>(
                ReflectionHelper.GetMethodInfo(typeof(Modding.Menu.ChainedNavGraph), "AddNavigationNode", true), value);
            remove => HookEndpointManager.Remove<Delegates.AddNavigationNode_WithArgs>(
                ReflectionHelper.GetMethodInfo(typeof(Modding.Menu.ChainedNavGraph), "AddNavigationNode", true), value);
        }

        public static event Delegates.BuildNavigation_WithArgs BuildNavigation
        {
            add => HookEndpointManager.Add<Delegates.BuildNavigation_WithArgs>(
                ReflectionHelper.GetMethodInfo(typeof(Modding.Menu.ChainedNavGraph), "BuildNavigation", true), value);
            remove => HookEndpointManager.Remove<Delegates.BuildNavigation_WithArgs>(
                ReflectionHelper.GetMethodInfo(typeof(Modding.Menu.ChainedNavGraph), "BuildNavigation", true), value);
        }
    }
}