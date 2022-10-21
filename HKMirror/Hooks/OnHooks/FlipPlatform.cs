using MonoMod.RuntimeDetour;
using MonoMod.RuntimeDetour.HookGen;

namespace HKMirror.Hooks.OnHooks;

/// <summary>
/// Contains different types of On Hooks for FlipPlatform class.<br />
/// Contains hooks that aren't generated by monomod, and before and after orig hooks for easier hooking.
/// </summary>
public static class OnFlipPlatform
{
    internal static class HookHandler
    {
        private static List<string> HookedList = new List<string>();

        internal static void HookAwake()
        {
            if (!HookedList.Contains("Awake"))
            {
                HookedList.Add("Awake");
                On.FlipPlatform.Awake += Awake;
            }
        }

        internal static event Delegates.Awake_BeforeArgs _beforeAwake;
        internal static event Delegates.Awake_AfterArgs _afterAwake;

        private static void Awake(On.FlipPlatform.orig_Awake orig, FlipPlatform self)
        {
            Delegates.Params_Awake @params = new()
            {
                self = self
            };
            if (_beforeAwake != null)
            {
                foreach (Delegates.Awake_BeforeArgs toInvoke in _beforeAwake.GetInvocationList())
                {
                    try
                    {
                        _beforeAwake?.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }
                }
            }

            self = @params.self;
            orig(self);
            if (_afterAwake != null)
            {
                foreach (Delegates.Awake_AfterArgs toInvoke in _afterAwake.GetInvocationList())
                {
                    try
                    {
                        _afterAwake.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }
                }
            }
        }

        internal static void HookStart()
        {
            if (!HookedList.Contains("Start"))
            {
                HookedList.Add("Start");
                On.FlipPlatform.Start += Start;
            }
        }

        internal static event Delegates.Start_BeforeArgs _beforeStart;
        internal static event Delegates.Start_AfterArgs _afterStart;

        private static void Start(On.FlipPlatform.orig_Start orig, FlipPlatform self)
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

        internal static void HookOnCollisionEnter2D()
        {
            if (!HookedList.Contains("OnCollisionEnter2D"))
            {
                HookedList.Add("OnCollisionEnter2D");
                On.FlipPlatform.OnCollisionEnter2D += OnCollisionEnter2D;
            }
        }

        internal static event Delegates.OnCollisionEnter2D_BeforeArgs _beforeOnCollisionEnter2D;
        internal static event Delegates.OnCollisionEnter2D_AfterArgs _afterOnCollisionEnter2D;

        private static void OnCollisionEnter2D(On.FlipPlatform.orig_OnCollisionEnter2D orig, FlipPlatform self,
            UnityEngine.Collision2D collision)
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

        internal static void HookPlaySound()
        {
            if (!HookedList.Contains("PlaySound"))
            {
                HookedList.Add("PlaySound");
                On.FlipPlatform.PlaySound += PlaySound;
            }
        }

        internal static event Delegates.PlaySound_BeforeArgs _beforePlaySound;
        internal static event Delegates.PlaySound_AfterArgs _afterPlaySound;

        private static void PlaySound(On.FlipPlatform.orig_PlaySound orig, FlipPlatform self,
            UnityEngine.AudioClip clip)
        {
            Delegates.Params_PlaySound @params = new()
            {
                self = self, clip = clip
            };
            if (_beforePlaySound != null)
            {
                foreach (Delegates.PlaySound_BeforeArgs toInvoke in _beforePlaySound.GetInvocationList())
                {
                    try
                    {
                        _beforePlaySound?.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }
                }
            }

            self = @params.self;
            clip = @params.clip;
            orig(self, clip);
            if (_afterPlaySound != null)
            {
                foreach (Delegates.PlaySound_AfterArgs toInvoke in _afterPlaySound.GetInvocationList())
                {
                    try
                    {
                        _afterPlaySound.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }
                }
            }
        }

        internal static void HookIdle()
        {
            if (!HookedList.Contains("Idle"))
            {
                HookedList.Add("Idle");
                On.FlipPlatform.Idle += Idle;
            }
        }

        internal static event Delegates.Idle_BeforeArgs _beforeIdle;

        private static System.Collections.IEnumerator Idle(On.FlipPlatform.orig_Idle orig, FlipPlatform self)
        {
            Delegates.Params_Idle @params = new()
            {
                self = self
            };
            if (_beforeIdle != null)
            {
                foreach (Delegates.Idle_BeforeArgs toInvoke in _beforeIdle.GetInvocationList())
                {
                    try
                    {
                        _beforeIdle?.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }
                }
            }

            self = @params.self;
            return orig(self);
        }

        internal static void HookFlip()
        {
            if (!HookedList.Contains("Flip"))
            {
                HookedList.Add("Flip");
                On.FlipPlatform.Flip += Flip;
            }
        }

        internal static event Delegates.Flip_BeforeArgs _beforeFlip;

        private static System.Collections.IEnumerator Flip(On.FlipPlatform.orig_Flip orig, FlipPlatform self)
        {
            Delegates.Params_Flip @params = new()
            {
                self = self
            };
            if (_beforeFlip != null)
            {
                foreach (Delegates.Flip_BeforeArgs toInvoke in _beforeFlip.GetInvocationList())
                {
                    try
                    {
                        _beforeFlip?.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }
                }
            }

            self = @params.self;
            return orig(self);
        }

        internal static void HookJitter()
        {
            if (!HookedList.Contains("Jitter"))
            {
                HookedList.Add("Jitter");
                On.FlipPlatform.Jitter += Jitter;
            }
        }

        internal static event Delegates.Jitter_BeforeArgs _beforeJitter;

        private static System.Collections.IEnumerator Jitter(On.FlipPlatform.orig_Jitter orig, FlipPlatform self,
            float duration)
        {
            Delegates.Params_Jitter @params = new()
            {
                self = self, duration = duration
            };
            if (_beforeJitter != null)
            {
                foreach (Delegates.Jitter_BeforeArgs toInvoke in _beforeJitter.GetInvocationList())
                {
                    try
                    {
                        _beforeJitter?.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }
                }
            }

            self = @params.self;
            duration = @params.duration;
            return orig(self, duration);
        }
    }

    /// <summary>
    /// Contains necessary information to create Hooks. Does not contain any hooks
    /// </summary>
    public static class Delegates
    {
        public sealed class Params_Awake
        {
            public FlipPlatform self;
        }

        public delegate void Awake_BeforeArgs(Params_Awake args);

        public delegate void Awake_AfterArgs(Params_Awake args);

        public delegate void Awake_WithArgs(Action<FlipPlatform> orig, FlipPlatform self);

        public sealed class Params_Start
        {
            public FlipPlatform self;
        }

        public delegate void Start_BeforeArgs(Params_Start args);

        public delegate void Start_AfterArgs(Params_Start args);

        public delegate void Start_WithArgs(Action<FlipPlatform> orig, FlipPlatform self);

        public sealed class Params_OnCollisionEnter2D
        {
            public FlipPlatform self;
            public UnityEngine.Collision2D collision;
        }

        public delegate void OnCollisionEnter2D_BeforeArgs(Params_OnCollisionEnter2D args);

        public delegate void OnCollisionEnter2D_AfterArgs(Params_OnCollisionEnter2D args);

        public delegate void OnCollisionEnter2D_WithArgs(Action<FlipPlatform, UnityEngine.Collision2D> orig,
            FlipPlatform self, UnityEngine.Collision2D collision);

        public sealed class Params_PlaySound
        {
            public FlipPlatform self;
            public UnityEngine.AudioClip clip;
        }

        public delegate void PlaySound_BeforeArgs(Params_PlaySound args);

        public delegate void PlaySound_AfterArgs(Params_PlaySound args);

        public delegate void PlaySound_WithArgs(Action<FlipPlatform, UnityEngine.AudioClip> orig, FlipPlatform self,
            UnityEngine.AudioClip clip);

        public sealed class Params_Idle
        {
            public FlipPlatform self;
        }

        public delegate void Idle_BeforeArgs(Params_Idle args);

        public delegate System.Collections.IEnumerator Idle_AfterArgs(Params_Idle args,
            System.Collections.IEnumerator ret);

        public delegate System.Collections.IEnumerator Idle_WithArgs(
            Func<FlipPlatform, System.Collections.IEnumerator> orig, FlipPlatform self);

        public sealed class Params_Flip
        {
            public FlipPlatform self;
        }

        public delegate void Flip_BeforeArgs(Params_Flip args);

        public delegate System.Collections.IEnumerator Flip_AfterArgs(Params_Flip args,
            System.Collections.IEnumerator ret);

        public delegate System.Collections.IEnumerator Flip_WithArgs(
            Func<FlipPlatform, System.Collections.IEnumerator> orig, FlipPlatform self);

        public sealed class Params_Jitter
        {
            public FlipPlatform self;
            public float duration;
        }

        public delegate void Jitter_BeforeArgs(Params_Jitter args);

        public delegate System.Collections.IEnumerator Jitter_AfterArgs(Params_Jitter args,
            System.Collections.IEnumerator ret);

        public delegate System.Collections.IEnumerator Jitter_WithArgs(
            Func<FlipPlatform, float, System.Collections.IEnumerator> orig, FlipPlatform self, float duration);
    }

    /// <summary>
    /// Contains Hooks to that run code before orig(self) is called
    /// </summary>
    public static class BeforeOrig
    {
        public static event Delegates.Awake_BeforeArgs Awake
        {
            add
            {
                HookHandler._beforeAwake += value;
                HookHandler.HookAwake();
            }
            remove => HookHandler._beforeAwake -= value;
        }

        public static event Delegates.Start_BeforeArgs Start
        {
            add
            {
                HookHandler._beforeStart += value;
                HookHandler.HookStart();
            }
            remove => HookHandler._beforeStart -= value;
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

        public static event Delegates.PlaySound_BeforeArgs PlaySound
        {
            add
            {
                HookHandler._beforePlaySound += value;
                HookHandler.HookPlaySound();
            }
            remove => HookHandler._beforePlaySound -= value;
        }

        public static event Delegates.Idle_BeforeArgs Idle
        {
            add
            {
                HookHandler._beforeIdle += value;
                HookHandler.HookIdle();
            }
            remove => HookHandler._beforeIdle -= value;
        }

        public static event Delegates.Flip_BeforeArgs Flip
        {
            add
            {
                HookHandler._beforeFlip += value;
                HookHandler.HookFlip();
            }
            remove => HookHandler._beforeFlip -= value;
        }

        public static event Delegates.Jitter_BeforeArgs Jitter
        {
            add
            {
                HookHandler._beforeJitter += value;
                HookHandler.HookJitter();
            }
            remove => HookHandler._beforeJitter -= value;
        }
    }

    /// <summary>
    /// Contains Hooks to that run code after orig(self) is called
    /// </summary>
    public static class AfterOrig
    {
        public static event Delegates.Awake_AfterArgs Awake
        {
            add
            {
                HookHandler._afterAwake += value;
                HookHandler.HookAwake();
            }
            remove => HookHandler._afterAwake -= value;
        }

        public static event Delegates.Start_AfterArgs Start
        {
            add
            {
                HookHandler._afterStart += value;
                HookHandler.HookStart();
            }
            remove => HookHandler._afterStart -= value;
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

        public static event Delegates.PlaySound_AfterArgs PlaySound
        {
            add
            {
                HookHandler._afterPlaySound += value;
                HookHandler.HookPlaySound();
            }
            remove => HookHandler._afterPlaySound -= value;
        }
    }

    /// <summary>
    /// Contains all On Hooks, even those that aren't in the On namespace such as API generated functions and property getters/setters
    /// </summary>
    public static class WithOrig
    {
        public static event On.FlipPlatform.hook_Awake Awake
        {
            add => On.FlipPlatform.Awake += value;
            remove => On.FlipPlatform.Awake -= value;
        }

        public static event On.FlipPlatform.hook_Start Start
        {
            add => On.FlipPlatform.Start += value;
            remove => On.FlipPlatform.Start -= value;
        }

        public static event On.FlipPlatform.hook_OnCollisionEnter2D OnCollisionEnter2D
        {
            add => On.FlipPlatform.OnCollisionEnter2D += value;
            remove => On.FlipPlatform.OnCollisionEnter2D -= value;
        }

        public static event On.FlipPlatform.hook_PlaySound PlaySound
        {
            add => On.FlipPlatform.PlaySound += value;
            remove => On.FlipPlatform.PlaySound -= value;
        }

        public static event On.FlipPlatform.hook_Idle Idle
        {
            add => On.FlipPlatform.Idle += value;
            remove => On.FlipPlatform.Idle -= value;
        }

        public static event On.FlipPlatform.hook_Flip Flip
        {
            add => On.FlipPlatform.Flip += value;
            remove => On.FlipPlatform.Flip -= value;
        }

        public static event On.FlipPlatform.hook_Jitter Jitter
        {
            add => On.FlipPlatform.Jitter += value;
            remove => On.FlipPlatform.Jitter -= value;
        }
    }
}