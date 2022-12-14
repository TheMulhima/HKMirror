namespace HKMirror.Hooks.OnHooks;

/// <summary>
///     Contains different types of On Hooks for DirectionUtils class.<br />
///     Contains hooks that aren't generated by monomod, and before and after orig hooks for easier hooking.
/// </summary>
public static class OnDirectionUtils
{
    internal static class HookHandler
    {
        private static readonly List<string> HookedList = new();

        internal static void HookGetCardinalDirection()
        {
            if (!HookedList.Contains("GetCardinalDirection"))
            {
                HookedList.Add("GetCardinalDirection");
                On.DirectionUtils.GetCardinalDirection += GetCardinalDirection;
            }
        }

        internal static event Delegates.GetCardinalDirection_BeforeArgs _beforeGetCardinalDirection;
        internal static event Delegates.GetCardinalDirection_AfterArgs _afterGetCardinalDirection;

        private static int GetCardinalDirection(On.DirectionUtils.orig_GetCardinalDirection orig, float degrees)
        {
            Delegates.Params_GetCardinalDirection @params = new()
            {
                degrees = degrees
            };
            if (_beforeGetCardinalDirection != null)
                foreach (Delegates.GetCardinalDirection_BeforeArgs toInvoke in _beforeGetCardinalDirection
                             .GetInvocationList())
                    try
                    {
                        _beforeGetCardinalDirection?.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }

            degrees = @params.degrees;
            var retVal = orig(degrees);
            if (_afterGetCardinalDirection != null)
                foreach (Delegates.GetCardinalDirection_AfterArgs toInvoke in _afterGetCardinalDirection
                             .GetInvocationList())
                    try
                    {
                        retVal = _afterGetCardinalDirection.Invoke(@params, retVal);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }

            return retVal;
        }

        internal static void HookNegSafeMod()
        {
            if (!HookedList.Contains("NegSafeMod"))
            {
                HookedList.Add("NegSafeMod");
                On.DirectionUtils.NegSafeMod += NegSafeMod;
            }
        }

        internal static event Delegates.NegSafeMod_BeforeArgs _beforeNegSafeMod;
        internal static event Delegates.NegSafeMod_AfterArgs _afterNegSafeMod;

        private static int NegSafeMod(On.DirectionUtils.orig_NegSafeMod orig, int val, int len)
        {
            Delegates.Params_NegSafeMod @params = new()
            {
                val = val, len = len
            };
            if (_beforeNegSafeMod != null)
                foreach (Delegates.NegSafeMod_BeforeArgs toInvoke in _beforeNegSafeMod.GetInvocationList())
                    try
                    {
                        _beforeNegSafeMod?.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }

            val = @params.val;
            len = @params.len;
            var retVal = orig(val, len);
            if (_afterNegSafeMod != null)
                foreach (Delegates.NegSafeMod_AfterArgs toInvoke in _afterNegSafeMod.GetInvocationList())
                    try
                    {
                        retVal = _afterNegSafeMod.Invoke(@params, retVal);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }

            return retVal;
        }

        internal static void HookGetX()
        {
            if (!HookedList.Contains("GetX"))
            {
                HookedList.Add("GetX");
                On.DirectionUtils.GetX += GetX;
            }
        }

        internal static event Delegates.GetX_BeforeArgs _beforeGetX;
        internal static event Delegates.GetX_AfterArgs _afterGetX;

        private static int GetX(On.DirectionUtils.orig_GetX orig, int cardinalDirection)
        {
            Delegates.Params_GetX @params = new()
            {
                cardinalDirection = cardinalDirection
            };
            if (_beforeGetX != null)
                foreach (Delegates.GetX_BeforeArgs toInvoke in _beforeGetX.GetInvocationList())
                    try
                    {
                        _beforeGetX?.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }

            cardinalDirection = @params.cardinalDirection;
            var retVal = orig(cardinalDirection);
            if (_afterGetX != null)
                foreach (Delegates.GetX_AfterArgs toInvoke in _afterGetX.GetInvocationList())
                    try
                    {
                        retVal = _afterGetX.Invoke(@params, retVal);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }

            return retVal;
        }

        internal static void HookGetY()
        {
            if (!HookedList.Contains("GetY"))
            {
                HookedList.Add("GetY");
                On.DirectionUtils.GetY += GetY;
            }
        }

        internal static event Delegates.GetY_BeforeArgs _beforeGetY;
        internal static event Delegates.GetY_AfterArgs _afterGetY;

        private static int GetY(On.DirectionUtils.orig_GetY orig, int cardinalDirection)
        {
            Delegates.Params_GetY @params = new()
            {
                cardinalDirection = cardinalDirection
            };
            if (_beforeGetY != null)
                foreach (Delegates.GetY_BeforeArgs toInvoke in _beforeGetY.GetInvocationList())
                    try
                    {
                        _beforeGetY?.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }

            cardinalDirection = @params.cardinalDirection;
            var retVal = orig(cardinalDirection);
            if (_afterGetY != null)
                foreach (Delegates.GetY_AfterArgs toInvoke in _afterGetY.GetInvocationList())
                    try
                    {
                        retVal = _afterGetY.Invoke(@params, retVal);
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
        public delegate int GetCardinalDirection_AfterArgs(Params_GetCardinalDirection args, int ret);

        public delegate void GetCardinalDirection_BeforeArgs(Params_GetCardinalDirection args);

        public delegate int GetCardinalDirection_WithArgs(Func<float, int> orig, float degrees);

        public delegate int GetX_AfterArgs(Params_GetX args, int ret);

        public delegate void GetX_BeforeArgs(Params_GetX args);

        public delegate int GetX_WithArgs(Func<int, int> orig, int cardinalDirection);

        public delegate int GetY_AfterArgs(Params_GetY args, int ret);

        public delegate void GetY_BeforeArgs(Params_GetY args);

        public delegate int GetY_WithArgs(Func<int, int> orig, int cardinalDirection);

        public delegate int NegSafeMod_AfterArgs(Params_NegSafeMod args, int ret);

        public delegate void NegSafeMod_BeforeArgs(Params_NegSafeMod args);

        public delegate int NegSafeMod_WithArgs(Func<int, int, int> orig, int val, int len);

        public sealed class Params_GetCardinalDirection
        {
            public float degrees;
        }

        public sealed class Params_NegSafeMod
        {
            public int len;
            public int val;
        }

        public sealed class Params_GetX
        {
            public int cardinalDirection;
        }

        public sealed class Params_GetY
        {
            public int cardinalDirection;
        }
    }

    /// <summary>
    ///     Contains Hooks to that run code before orig(self) is called
    /// </summary>
    public static class BeforeOrig
    {
        public static event Delegates.GetCardinalDirection_BeforeArgs GetCardinalDirection
        {
            add
            {
                HookHandler._beforeGetCardinalDirection += value;
                HookHandler.HookGetCardinalDirection();
            }
            remove => HookHandler._beforeGetCardinalDirection -= value;
        }

        public static event Delegates.NegSafeMod_BeforeArgs NegSafeMod
        {
            add
            {
                HookHandler._beforeNegSafeMod += value;
                HookHandler.HookNegSafeMod();
            }
            remove => HookHandler._beforeNegSafeMod -= value;
        }

        public static event Delegates.GetX_BeforeArgs GetX
        {
            add
            {
                HookHandler._beforeGetX += value;
                HookHandler.HookGetX();
            }
            remove => HookHandler._beforeGetX -= value;
        }

        public static event Delegates.GetY_BeforeArgs GetY
        {
            add
            {
                HookHandler._beforeGetY += value;
                HookHandler.HookGetY();
            }
            remove => HookHandler._beforeGetY -= value;
        }
    }

    /// <summary>
    ///     Contains Hooks to that run code after orig(self) is called
    /// </summary>
    public static class AfterOrig
    {
        public static event Delegates.GetCardinalDirection_AfterArgs GetCardinalDirection
        {
            add
            {
                HookHandler._afterGetCardinalDirection += value;
                HookHandler.HookGetCardinalDirection();
            }
            remove => HookHandler._afterGetCardinalDirection -= value;
        }

        public static event Delegates.NegSafeMod_AfterArgs NegSafeMod
        {
            add
            {
                HookHandler._afterNegSafeMod += value;
                HookHandler.HookNegSafeMod();
            }
            remove => HookHandler._afterNegSafeMod -= value;
        }

        public static event Delegates.GetX_AfterArgs GetX
        {
            add
            {
                HookHandler._afterGetX += value;
                HookHandler.HookGetX();
            }
            remove => HookHandler._afterGetX -= value;
        }

        public static event Delegates.GetY_AfterArgs GetY
        {
            add
            {
                HookHandler._afterGetY += value;
                HookHandler.HookGetY();
            }
            remove => HookHandler._afterGetY -= value;
        }
    }

    /// <summary>
    ///     Contains all On Hooks, even those that aren't in the On namespace such as API generated functions and property
    ///     getters/setters
    /// </summary>
    public static class WithOrig
    {
        public static event On.DirectionUtils.hook_GetCardinalDirection GetCardinalDirection
        {
            add => On.DirectionUtils.GetCardinalDirection += value;
            remove => On.DirectionUtils.GetCardinalDirection -= value;
        }

        public static event On.DirectionUtils.hook_NegSafeMod NegSafeMod
        {
            add => On.DirectionUtils.NegSafeMod += value;
            remove => On.DirectionUtils.NegSafeMod -= value;
        }

        public static event On.DirectionUtils.hook_GetX GetX
        {
            add => On.DirectionUtils.GetX += value;
            remove => On.DirectionUtils.GetX -= value;
        }

        public static event On.DirectionUtils.hook_GetY GetY
        {
            add => On.DirectionUtils.GetY += value;
            remove => On.DirectionUtils.GetY -= value;
        }
    }
}