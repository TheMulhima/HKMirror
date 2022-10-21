using MonoMod.RuntimeDetour;
using MonoMod.RuntimeDetour.HookGen;

namespace HKMirror.Hooks.OnHooks;

/// <summary>
/// Contains different types of On Hooks for IgnoreHeroCollision class.<br />
/// Contains hooks that aren't generated by monomod, and before and after orig hooks for easier hooking.
/// </summary>
public static class OnIgnoreHeroCollision
{
    internal static class HookHandler
    {
        private static List<string> HookedList = new List<string>();

        internal static void HookStart()
        {
            if (!HookedList.Contains("Start"))
            {
                HookedList.Add("Start");
                On.IgnoreHeroCollision.Start += Start;
            }
        }

        internal static event Delegates.Start_BeforeArgs _beforeStart;
        internal static event Delegates.Start_AfterArgs _afterStart;

        private static void Start(On.IgnoreHeroCollision.orig_Start orig, IgnoreHeroCollision self)
        {
            Delegates.Params_Start @params = new()
            {
                self = self
            };
            if (_beforeStart != null)
            {
                foreach (Delegates.Start_BeforeArgs toInvoke in _beforeStart.GetInvocationList())
                {
                    try
                    {
                        _beforeStart?.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }
                }
            }

            self = @params.self;
            orig(self);
            if (_afterStart != null)
            {
                foreach (Delegates.Start_AfterArgs toInvoke in _afterStart.GetInvocationList())
                {
                    try
                    {
                        _afterStart.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }
                }
            }
        }

        internal static void HookIgnore()
        {
            if (!HookedList.Contains("Ignore"))
            {
                HookedList.Add("Ignore");
                On.IgnoreHeroCollision.Ignore += Ignore;
            }
        }

        internal static event Delegates.Ignore_BeforeArgs _beforeIgnore;
        internal static event Delegates.Ignore_AfterArgs _afterIgnore;

        private static void Ignore(On.IgnoreHeroCollision.orig_Ignore orig, IgnoreHeroCollision self)
        {
            Delegates.Params_Ignore @params = new()
            {
                self = self
            };
            if (_beforeIgnore != null)
            {
                foreach (Delegates.Ignore_BeforeArgs toInvoke in _beforeIgnore.GetInvocationList())
                {
                    try
                    {
                        _beforeIgnore?.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }
                }
            }

            self = @params.self;
            orig(self);
            if (_afterIgnore != null)
            {
                foreach (Delegates.Ignore_AfterArgs toInvoke in _afterIgnore.GetInvocationList())
                {
                    try
                    {
                        _afterIgnore.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }
                }
            }
        }

        internal static void HookOnCollisionEnter2D()
        {
            if (!HookedList.Contains("OnCollisionEnter2D"))
            {
                HookedList.Add("OnCollisionEnter2D");
                On.IgnoreHeroCollision.OnCollisionEnter2D += OnCollisionEnter2D;
            }
        }

        internal static event Delegates.OnCollisionEnter2D_BeforeArgs _beforeOnCollisionEnter2D;
        internal static event Delegates.OnCollisionEnter2D_AfterArgs _afterOnCollisionEnter2D;

        private static void OnCollisionEnter2D(On.IgnoreHeroCollision.orig_OnCollisionEnter2D orig,
            IgnoreHeroCollision self, UnityEngine.Collision2D collision)
        {
            Delegates.Params_OnCollisionEnter2D @params = new()
            {
                self = self, collision = collision
            };
            if (_beforeOnCollisionEnter2D != null)
            {
                foreach (Delegates.OnCollisionEnter2D_BeforeArgs toInvoke in
                         _beforeOnCollisionEnter2D.GetInvocationList())
                {
                    try
                    {
                        _beforeOnCollisionEnter2D?.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }
                }
            }

            self = @params.self;
            collision = @params.collision;
            orig(self, collision);
            if (_afterOnCollisionEnter2D != null)
            {
                foreach (Delegates.OnCollisionEnter2D_AfterArgs toInvoke in
                         _afterOnCollisionEnter2D.GetInvocationList())
                {
                    try
                    {
                        _afterOnCollisionEnter2D.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }
                }
            }
        }
    }

    /// <summary>
    /// Contains necessary information to create Hooks. Does not contain any hooks
    /// </summary>
    public static class Delegates
    {
        public sealed class Params_Start
        {
            public IgnoreHeroCollision self;
        }

        public delegate void Start_BeforeArgs(Params_Start args);

        public delegate void Start_AfterArgs(Params_Start args);

        public delegate void Start_WithArgs(Action<IgnoreHeroCollision> orig, IgnoreHeroCollision self);

        public sealed class Params_Ignore
        {
            public IgnoreHeroCollision self;
        }

        public delegate void Ignore_BeforeArgs(Params_Ignore args);

        public delegate void Ignore_AfterArgs(Params_Ignore args);

        public delegate void Ignore_WithArgs(Action<IgnoreHeroCollision> orig, IgnoreHeroCollision self);

        public sealed class Params_OnCollisionEnter2D
        {
            public IgnoreHeroCollision self;
            public UnityEngine.Collision2D collision;
        }

        public delegate void OnCollisionEnter2D_BeforeArgs(Params_OnCollisionEnter2D args);

        public delegate void OnCollisionEnter2D_AfterArgs(Params_OnCollisionEnter2D args);

        public delegate void OnCollisionEnter2D_WithArgs(Action<IgnoreHeroCollision, UnityEngine.Collision2D> orig,
            IgnoreHeroCollision self, UnityEngine.Collision2D collision);
    }

    /// <summary>
    /// Contains Hooks to that run code before orig(self) is called
    /// </summary>
    public static class BeforeOrig
    {
        public static event Delegates.Start_BeforeArgs Start
        {
            add
            {
                HookHandler._beforeStart += value;
                HookHandler.HookStart();
            }
            remove => HookHandler._beforeStart -= value;
        }

        public static event Delegates.Ignore_BeforeArgs Ignore
        {
            add
            {
                HookHandler._beforeIgnore += value;
                HookHandler.HookIgnore();
            }
            remove => HookHandler._beforeIgnore -= value;
        }

        public static event Delegates.OnCollisionEnter2D_BeforeArgs OnCollisionEnter2D
        {
            add
            {
                HookHandler._beforeOnCollisionEnter2D += value;
                HookHandler.HookOnCollisionEnter2D();
            }
            remove => HookHandler._beforeOnCollisionEnter2D -= value;
        }
    }

    /// <summary>
    /// Contains Hooks to that run code after orig(self) is called
    /// </summary>
    public static class AfterOrig
    {
        public static event Delegates.Start_AfterArgs Start
        {
            add
            {
                HookHandler._afterStart += value;
                HookHandler.HookStart();
            }
            remove => HookHandler._afterStart -= value;
        }

        public static event Delegates.Ignore_AfterArgs Ignore
        {
            add
            {
                HookHandler._afterIgnore += value;
                HookHandler.HookIgnore();
            }
            remove => HookHandler._afterIgnore -= value;
        }

        public static event Delegates.OnCollisionEnter2D_AfterArgs OnCollisionEnter2D
        {
            add
            {
                HookHandler._afterOnCollisionEnter2D += value;
                HookHandler.HookOnCollisionEnter2D();
            }
            remove => HookHandler._afterOnCollisionEnter2D -= value;
        }
    }

    /// <summary>
    /// Contains all On Hooks, even those that aren't in the On namespace such as API generated functions and property getters/setters
    /// </summary>
    public static class WithOrig
    {
        public static event On.IgnoreHeroCollision.hook_Start Start
        {
            add => On.IgnoreHeroCollision.Start += value;
            remove => On.IgnoreHeroCollision.Start -= value;
        }

        public static event On.IgnoreHeroCollision.hook_Ignore Ignore
        {
            add => On.IgnoreHeroCollision.Ignore += value;
            remove => On.IgnoreHeroCollision.Ignore -= value;
        }

        public static event On.IgnoreHeroCollision.hook_OnCollisionEnter2D OnCollisionEnter2D
        {
            add => On.IgnoreHeroCollision.OnCollisionEnter2D += value;
            remove => On.IgnoreHeroCollision.OnCollisionEnter2D -= value;
        }
    }
}