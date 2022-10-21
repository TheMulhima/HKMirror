using MonoMod.RuntimeDetour;
using MonoMod.RuntimeDetour.HookGen;

namespace HKMirror.Hooks.OnHooks;

/// <summary>
/// Contains different types of On Hooks for PlayMakerUnity2d class.<br />
/// Contains hooks that aren't generated by monomod, and before and after orig hooks for easier hooking.
/// </summary>
public static class OnPlayMakerUnity2d
{
    internal static class HookHandler
    {
        private static List<string> HookedList = new List<string>();

        internal static void HookRecordLastRaycastHitInfo()
        {
            if (!HookedList.Contains("RecordLastRaycastHitInfo"))
            {
                HookedList.Add("RecordLastRaycastHitInfo");
                On.PlayMakerUnity2d.RecordLastRaycastHitInfo += RecordLastRaycastHitInfo;
            }
        }

        internal static event Delegates.RecordLastRaycastHitInfo_BeforeArgs _beforeRecordLastRaycastHitInfo;
        internal static event Delegates.RecordLastRaycastHitInfo_AfterArgs _afterRecordLastRaycastHitInfo;

        private static void RecordLastRaycastHitInfo(On.PlayMakerUnity2d.orig_RecordLastRaycastHitInfo orig,
            HutongGames.PlayMaker.Fsm fsm, UnityEngine.RaycastHit2D info)
        {
            Delegates.Params_RecordLastRaycastHitInfo @params = new()
            {
                fsm = fsm, info = info
            };
            if (_beforeRecordLastRaycastHitInfo != null)
            {
                foreach (Delegates.RecordLastRaycastHitInfo_BeforeArgs toInvoke in _beforeRecordLastRaycastHitInfo
                             .GetInvocationList())
                {
                    try
                    {
                        _beforeRecordLastRaycastHitInfo?.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }
                }
            }

            fsm = @params.fsm;
            info = @params.info;
            orig(fsm, info);
            if (_afterRecordLastRaycastHitInfo != null)
            {
                foreach (Delegates.RecordLastRaycastHitInfo_AfterArgs toInvoke in _afterRecordLastRaycastHitInfo
                             .GetInvocationList())
                {
                    try
                    {
                        _afterRecordLastRaycastHitInfo.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }
                }
            }
        }

        internal static void HookGetLastRaycastHitInfo()
        {
            if (!HookedList.Contains("GetLastRaycastHitInfo"))
            {
                HookedList.Add("GetLastRaycastHitInfo");
                On.PlayMakerUnity2d.GetLastRaycastHitInfo += GetLastRaycastHitInfo;
            }
        }

        internal static event Delegates.GetLastRaycastHitInfo_BeforeArgs _beforeGetLastRaycastHitInfo;
        internal static event Delegates.GetLastRaycastHitInfo_AfterArgs _afterGetLastRaycastHitInfo;

        private static UnityEngine.RaycastHit2D GetLastRaycastHitInfo(
            On.PlayMakerUnity2d.orig_GetLastRaycastHitInfo orig, HutongGames.PlayMaker.Fsm fsm)
        {
            Delegates.Params_GetLastRaycastHitInfo @params = new()
            {
                fsm = fsm
            };
            if (_beforeGetLastRaycastHitInfo != null)
            {
                foreach (Delegates.GetLastRaycastHitInfo_BeforeArgs toInvoke in _beforeGetLastRaycastHitInfo
                             .GetInvocationList())
                {
                    try
                    {
                        _beforeGetLastRaycastHitInfo?.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }
                }
            }

            fsm = @params.fsm;
            var retVal = orig(fsm);
            if (_afterGetLastRaycastHitInfo != null)
            {
                foreach (Delegates.GetLastRaycastHitInfo_AfterArgs toInvoke in _afterGetLastRaycastHitInfo
                             .GetInvocationList())
                {
                    try
                    {
                        retVal = _afterGetLastRaycastHitInfo.Invoke(@params, retVal);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }
                }
            }

            return retVal;
        }

        internal static void HookAwake()
        {
            if (!HookedList.Contains("Awake"))
            {
                HookedList.Add("Awake");
                On.PlayMakerUnity2d.Awake += Awake;
            }
        }

        internal static event Delegates.Awake_BeforeArgs _beforeAwake;
        internal static event Delegates.Awake_AfterArgs _afterAwake;

        private static void Awake(On.PlayMakerUnity2d.orig_Awake orig, PlayMakerUnity2d self)
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

        internal static void HookOnLevelWasLoaded()
        {
            if (!HookedList.Contains("OnLevelWasLoaded"))
            {
                HookedList.Add("OnLevelWasLoaded");
                On.PlayMakerUnity2d.OnLevelWasLoaded += OnLevelWasLoaded;
            }
        }

        internal static event Delegates.OnLevelWasLoaded_BeforeArgs _beforeOnLevelWasLoaded;
        internal static event Delegates.OnLevelWasLoaded_AfterArgs _afterOnLevelWasLoaded;

        private static void OnLevelWasLoaded(On.PlayMakerUnity2d.orig_OnLevelWasLoaded orig, PlayMakerUnity2d self,
            int level)
        {
            Delegates.Params_OnLevelWasLoaded @params = new()
            {
                self = self, level = level
            };
            if (_beforeOnLevelWasLoaded != null)
            {
                foreach (Delegates.OnLevelWasLoaded_BeforeArgs toInvoke in _beforeOnLevelWasLoaded.GetInvocationList())
                {
                    try
                    {
                        _beforeOnLevelWasLoaded?.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }
                }
            }

            self = @params.self;
            level = @params.level;
            orig(self, level);
            if (_afterOnLevelWasLoaded != null)
            {
                foreach (Delegates.OnLevelWasLoaded_AfterArgs toInvoke in _afterOnLevelWasLoaded.GetInvocationList())
                {
                    try
                    {
                        _afterOnLevelWasLoaded.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }
                }
            }
        }

        internal static void HookisAvailable()
        {
            if (!HookedList.Contains("isAvailable"))
            {
                HookedList.Add("isAvailable");
                On.PlayMakerUnity2d.isAvailable += isAvailable;
            }
        }

        internal static event Delegates.isAvailable_BeforeArgs _beforeisAvailable;
        internal static event Delegates.isAvailable_AfterArgs _afterisAvailable;

        private static bool isAvailable(On.PlayMakerUnity2d.orig_isAvailable orig)
        {
            if (_beforeisAvailable != null)
            {
                foreach (Delegates.isAvailable_BeforeArgs toInvoke in _beforeisAvailable.GetInvocationList())
                {
                    try
                    {
                        _beforeisAvailable?.Invoke();
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }
                }
            }

            var retVal = orig();
            if (_afterisAvailable != null)
            {
                foreach (Delegates.isAvailable_AfterArgs toInvoke in _afterisAvailable.GetInvocationList())
                {
                    try
                    {
                        retVal = _afterisAvailable.Invoke(retVal);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }
                }
            }

            return retVal;
        }

        internal static void HookForwardEventToGameObject()
        {
            if (!HookedList.Contains("ForwardEventToGameObject"))
            {
                HookedList.Add("ForwardEventToGameObject");
                On.PlayMakerUnity2d.ForwardEventToGameObject += ForwardEventToGameObject;
            }
        }

        internal static event Delegates.ForwardEventToGameObject_BeforeArgs _beforeForwardEventToGameObject;
        internal static event Delegates.ForwardEventToGameObject_AfterArgs _afterForwardEventToGameObject;

        private static void ForwardEventToGameObject(On.PlayMakerUnity2d.orig_ForwardEventToGameObject orig,
            UnityEngine.GameObject target, string eventName)
        {
            Delegates.Params_ForwardEventToGameObject @params = new()
            {
                target = target, eventName = eventName
            };
            if (_beforeForwardEventToGameObject != null)
            {
                foreach (Delegates.ForwardEventToGameObject_BeforeArgs toInvoke in _beforeForwardEventToGameObject
                             .GetInvocationList())
                {
                    try
                    {
                        _beforeForwardEventToGameObject?.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }
                }
            }

            target = @params.target;
            eventName = @params.eventName;
            orig(target, eventName);
            if (_afterForwardEventToGameObject != null)
            {
                foreach (Delegates.ForwardEventToGameObject_AfterArgs toInvoke in _afterForwardEventToGameObject
                             .GetInvocationList())
                {
                    try
                    {
                        _afterForwardEventToGameObject.Invoke(@params);
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
        public sealed class Params_RecordLastRaycastHitInfo
        {
            public HutongGames.PlayMaker.Fsm fsm;
            public UnityEngine.RaycastHit2D info;
        }

        public delegate void RecordLastRaycastHitInfo_BeforeArgs(Params_RecordLastRaycastHitInfo args);

        public delegate void RecordLastRaycastHitInfo_AfterArgs(Params_RecordLastRaycastHitInfo args);

        public delegate void RecordLastRaycastHitInfo_WithArgs(
            Action<HutongGames.PlayMaker.Fsm, UnityEngine.RaycastHit2D> orig, HutongGames.PlayMaker.Fsm fsm,
            UnityEngine.RaycastHit2D info);

        public sealed class Params_GetLastRaycastHitInfo
        {
            public HutongGames.PlayMaker.Fsm fsm;
        }

        public delegate void GetLastRaycastHitInfo_BeforeArgs(Params_GetLastRaycastHitInfo args);

        public delegate UnityEngine.RaycastHit2D GetLastRaycastHitInfo_AfterArgs(Params_GetLastRaycastHitInfo args,
            UnityEngine.RaycastHit2D ret);

        public delegate UnityEngine.RaycastHit2D GetLastRaycastHitInfo_WithArgs(
            Func<HutongGames.PlayMaker.Fsm, UnityEngine.RaycastHit2D> orig, HutongGames.PlayMaker.Fsm fsm);

        public sealed class Params_Awake
        {
            public PlayMakerUnity2d self;
        }

        public delegate void Awake_BeforeArgs(Params_Awake args);

        public delegate void Awake_AfterArgs(Params_Awake args);

        public delegate void Awake_WithArgs(Action<PlayMakerUnity2d> orig, PlayMakerUnity2d self);

        public sealed class Params_OnLevelWasLoaded
        {
            public PlayMakerUnity2d self;
            public int level;
        }

        public delegate void OnLevelWasLoaded_BeforeArgs(Params_OnLevelWasLoaded args);

        public delegate void OnLevelWasLoaded_AfterArgs(Params_OnLevelWasLoaded args);

        public delegate void OnLevelWasLoaded_WithArgs(Action<PlayMakerUnity2d, int> orig, PlayMakerUnity2d self,
            int level);

        public delegate void isAvailable_BeforeArgs();

        public delegate bool isAvailable_AfterArgs(bool ret);

        public delegate bool isAvailable_WithArgs(Func<bool> orig);

        public sealed class Params_ForwardEventToGameObject
        {
            public UnityEngine.GameObject target;
            public string eventName;
        }

        public delegate void ForwardEventToGameObject_BeforeArgs(Params_ForwardEventToGameObject args);

        public delegate void ForwardEventToGameObject_AfterArgs(Params_ForwardEventToGameObject args);

        public delegate void ForwardEventToGameObject_WithArgs(Action<UnityEngine.GameObject, string> orig,
            UnityEngine.GameObject target, string eventName);
    }

    /// <summary>
    /// Contains Hooks to that run code before orig(self) is called
    /// </summary>
    public static class BeforeOrig
    {
        public static event Delegates.RecordLastRaycastHitInfo_BeforeArgs RecordLastRaycastHitInfo
        {
            add
            {
                HookHandler._beforeRecordLastRaycastHitInfo += value;
                HookHandler.HookRecordLastRaycastHitInfo();
            }
            remove => HookHandler._beforeRecordLastRaycastHitInfo -= value;
        }

        public static event Delegates.GetLastRaycastHitInfo_BeforeArgs GetLastRaycastHitInfo
        {
            add
            {
                HookHandler._beforeGetLastRaycastHitInfo += value;
                HookHandler.HookGetLastRaycastHitInfo();
            }
            remove => HookHandler._beforeGetLastRaycastHitInfo -= value;
        }

        public static event Delegates.Awake_BeforeArgs Awake
        {
            add
            {
                HookHandler._beforeAwake += value;
                HookHandler.HookAwake();
            }
            remove => HookHandler._beforeAwake -= value;
        }

        public static event Delegates.OnLevelWasLoaded_BeforeArgs OnLevelWasLoaded
        {
            add
            {
                HookHandler._beforeOnLevelWasLoaded += value;
                HookHandler.HookOnLevelWasLoaded();
            }
            remove => HookHandler._beforeOnLevelWasLoaded -= value;
        }

        public static event Delegates.isAvailable_BeforeArgs isAvailable
        {
            add
            {
                HookHandler._beforeisAvailable += value;
                HookHandler.HookisAvailable();
            }
            remove => HookHandler._beforeisAvailable -= value;
        }

        public static event Delegates.ForwardEventToGameObject_BeforeArgs ForwardEventToGameObject
        {
            add
            {
                HookHandler._beforeForwardEventToGameObject += value;
                HookHandler.HookForwardEventToGameObject();
            }
            remove => HookHandler._beforeForwardEventToGameObject -= value;
        }
    }

    /// <summary>
    /// Contains Hooks to that run code after orig(self) is called
    /// </summary>
    public static class AfterOrig
    {
        public static event Delegates.RecordLastRaycastHitInfo_AfterArgs RecordLastRaycastHitInfo
        {
            add
            {
                HookHandler._afterRecordLastRaycastHitInfo += value;
                HookHandler.HookRecordLastRaycastHitInfo();
            }
            remove => HookHandler._afterRecordLastRaycastHitInfo -= value;
        }

        public static event Delegates.GetLastRaycastHitInfo_AfterArgs GetLastRaycastHitInfo
        {
            add
            {
                HookHandler._afterGetLastRaycastHitInfo += value;
                HookHandler.HookGetLastRaycastHitInfo();
            }
            remove => HookHandler._afterGetLastRaycastHitInfo -= value;
        }

        public static event Delegates.Awake_AfterArgs Awake
        {
            add
            {
                HookHandler._afterAwake += value;
                HookHandler.HookAwake();
            }
            remove => HookHandler._afterAwake -= value;
        }

        public static event Delegates.OnLevelWasLoaded_AfterArgs OnLevelWasLoaded
        {
            add
            {
                HookHandler._afterOnLevelWasLoaded += value;
                HookHandler.HookOnLevelWasLoaded();
            }
            remove => HookHandler._afterOnLevelWasLoaded -= value;
        }

        public static event Delegates.isAvailable_AfterArgs isAvailable
        {
            add
            {
                HookHandler._afterisAvailable += value;
                HookHandler.HookisAvailable();
            }
            remove => HookHandler._afterisAvailable -= value;
        }

        public static event Delegates.ForwardEventToGameObject_AfterArgs ForwardEventToGameObject
        {
            add
            {
                HookHandler._afterForwardEventToGameObject += value;
                HookHandler.HookForwardEventToGameObject();
            }
            remove => HookHandler._afterForwardEventToGameObject -= value;
        }
    }

    /// <summary>
    /// Contains all On Hooks, even those that aren't in the On namespace such as API generated functions and property getters/setters
    /// </summary>
    public static class WithOrig
    {
        public static event On.PlayMakerUnity2d.hook_RecordLastRaycastHitInfo RecordLastRaycastHitInfo
        {
            add => On.PlayMakerUnity2d.RecordLastRaycastHitInfo += value;
            remove => On.PlayMakerUnity2d.RecordLastRaycastHitInfo -= value;
        }

        public static event On.PlayMakerUnity2d.hook_GetLastRaycastHitInfo GetLastRaycastHitInfo
        {
            add => On.PlayMakerUnity2d.GetLastRaycastHitInfo += value;
            remove => On.PlayMakerUnity2d.GetLastRaycastHitInfo -= value;
        }

        public static event On.PlayMakerUnity2d.hook_Awake Awake
        {
            add => On.PlayMakerUnity2d.Awake += value;
            remove => On.PlayMakerUnity2d.Awake -= value;
        }

        public static event On.PlayMakerUnity2d.hook_OnLevelWasLoaded OnLevelWasLoaded
        {
            add => On.PlayMakerUnity2d.OnLevelWasLoaded += value;
            remove => On.PlayMakerUnity2d.OnLevelWasLoaded -= value;
        }

        public static event On.PlayMakerUnity2d.hook_isAvailable isAvailable
        {
            add => On.PlayMakerUnity2d.isAvailable += value;
            remove => On.PlayMakerUnity2d.isAvailable -= value;
        }

        public static event On.PlayMakerUnity2d.hook_ForwardEventToGameObject ForwardEventToGameObject
        {
            add => On.PlayMakerUnity2d.ForwardEventToGameObject += value;
            remove => On.PlayMakerUnity2d.ForwardEventToGameObject -= value;
        }
    }
}