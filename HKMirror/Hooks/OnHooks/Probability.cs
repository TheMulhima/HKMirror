using MonoMod.RuntimeDetour;
using MonoMod.RuntimeDetour.HookGen;

namespace HKMirror.Hooks.OnHooks;

/// <summary>
/// Contains different types of On Hooks for Probability class.<br />
/// Contains hooks that aren't generated by monomod, and before and after orig hooks for easier hooking.
/// </summary>
public static class OnProbability
{
    internal static class HookHandler
    {
        private static List<string> HookedList = new List<string>();

        internal static void HookGetRandomGameObjectByProbability()
        {
            if (!HookedList.Contains("GetRandomGameObjectByProbability"))
            {
                HookedList.Add("GetRandomGameObjectByProbability");
                On.Probability.GetRandomGameObjectByProbability += GetRandomGameObjectByProbability;
            }
        }

        internal static event Delegates.GetRandomGameObjectByProbability_BeforeArgs
            _beforeGetRandomGameObjectByProbability;

        internal static event Delegates.GetRandomGameObjectByProbability_AfterArgs
            _afterGetRandomGameObjectByProbability;

        private static UnityEngine.GameObject GetRandomGameObjectByProbability(
            On.Probability.orig_GetRandomGameObjectByProbability orig, Probability.ProbabilityGameObject[] array)
        {
            Delegates.Params_GetRandomGameObjectByProbability @params = new()
            {
                array = array
            };
            if (_beforeGetRandomGameObjectByProbability != null)
            {
                foreach (Delegates.GetRandomGameObjectByProbability_BeforeArgs toInvoke in
                         _beforeGetRandomGameObjectByProbability.GetInvocationList())
                {
                    try
                    {
                        _beforeGetRandomGameObjectByProbability?.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }
                }
            }

            array = @params.array;
            var retVal = orig(array);
            if (_afterGetRandomGameObjectByProbability != null)
            {
                foreach (Delegates.GetRandomGameObjectByProbability_AfterArgs toInvoke in
                         _afterGetRandomGameObjectByProbability.GetInvocationList())
                {
                    try
                    {
                        retVal = _afterGetRandomGameObjectByProbability.Invoke(@params, retVal);
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
        public sealed class Params_GetRandomGameObjectByProbability
        {
            public Probability.ProbabilityGameObject[] array;
        }

        public delegate void GetRandomGameObjectByProbability_BeforeArgs(Params_GetRandomGameObjectByProbability args);

        public delegate UnityEngine.GameObject GetRandomGameObjectByProbability_AfterArgs(
            Params_GetRandomGameObjectByProbability args, UnityEngine.GameObject ret);

        public delegate UnityEngine.GameObject GetRandomGameObjectByProbability_WithArgs(
            Func<Probability.ProbabilityGameObject[], UnityEngine.GameObject> orig,
            Probability.ProbabilityGameObject[] array);
    }

    /// <summary>
    /// Contains Hooks to that run code before orig(self) is called
    /// </summary>
    public static class BeforeOrig
    {
        public static event Delegates.GetRandomGameObjectByProbability_BeforeArgs GetRandomGameObjectByProbability
        {
            add
            {
                HookHandler._beforeGetRandomGameObjectByProbability += value;
                HookHandler.HookGetRandomGameObjectByProbability();
            }
            remove => HookHandler._beforeGetRandomGameObjectByProbability -= value;
        }
    }

    /// <summary>
    /// Contains Hooks to that run code after orig(self) is called
    /// </summary>
    public static class AfterOrig
    {
        public static event Delegates.GetRandomGameObjectByProbability_AfterArgs GetRandomGameObjectByProbability
        {
            add
            {
                HookHandler._afterGetRandomGameObjectByProbability += value;
                HookHandler.HookGetRandomGameObjectByProbability();
            }
            remove => HookHandler._afterGetRandomGameObjectByProbability -= value;
        }
    }

    /// <summary>
    /// Contains all On Hooks, even those that aren't in the On namespace such as API generated functions and property getters/setters
    /// </summary>
    public static class WithOrig
    {
        public static event On.Probability.hook_GetRandomGameObjectByProbability GetRandomGameObjectByProbability
        {
            add => On.Probability.GetRandomGameObjectByProbability += value;
            remove => On.Probability.GetRandomGameObjectByProbability -= value;
        }
    }
}