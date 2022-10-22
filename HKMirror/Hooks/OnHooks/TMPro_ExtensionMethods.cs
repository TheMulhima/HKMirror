using MonoMod.RuntimeDetour;
using MonoMod.RuntimeDetour.HookGen;
using TMPro;

namespace HKMirror.Hooks.OnHooks;

/// <summary>
///     Contains different types of On Hooks for TMPro_ExtensionMethods class.<br />
///     Contains hooks that aren't generated by monomod, and before and after orig hooks for easier hooking.
/// </summary>
public static class OnTMPro_ExtensionMethods
{
    internal static class HookHandler
    {
        private static readonly List<string> HookedList = new();

        internal static void HookCompare_Color32_Color32()
        {
            if (!HookedList.Contains("Compare_Color32_Color32"))
            {
                HookedList.Add("Compare_Color32_Color32");
                new Hook(
                    ReflectionHelper.GetMethodInfo(typeof(TMPro_ExtensionMethods), "Compare_Color32_Color32", false),
                    Compare_Color32_Color32);
            }
        }

        internal static event Delegates.Compare_Color32_Color32_BeforeArgs _beforeCompare_Color32_Color32;
        internal static event Delegates.Compare_Color32_Color32_AfterArgs _afterCompare_Color32_Color32;

        private static bool Compare_Color32_Color32(Func<Color32, Color32, bool> orig, Color32 a, Color32 b)
        {
            Delegates.Params_Compare_Color32_Color32 @params = new()
            {
                a = a, b = b
            };
            if (_beforeCompare_Color32_Color32 != null)
                foreach (Delegates.Compare_Color32_Color32_BeforeArgs toInvoke in _beforeCompare_Color32_Color32
                             .GetInvocationList())
                    try
                    {
                        _beforeCompare_Color32_Color32?.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }

            a = @params.a;
            b = @params.b;
            var retVal = orig(a, b);
            if (_afterCompare_Color32_Color32 != null)
                foreach (Delegates.Compare_Color32_Color32_AfterArgs toInvoke in _afterCompare_Color32_Color32
                             .GetInvocationList())
                    try
                    {
                        retVal = _afterCompare_Color32_Color32.Invoke(@params, retVal);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }

            return retVal;
        }

        internal static void HookCompareRGB_Color32_Color32()
        {
            if (!HookedList.Contains("CompareRGB_Color32_Color32"))
            {
                HookedList.Add("CompareRGB_Color32_Color32");
                new Hook(
                    ReflectionHelper.GetMethodInfo(typeof(TMPro_ExtensionMethods), "CompareRGB_Color32_Color32", false),
                    CompareRGB_Color32_Color32);
            }
        }

        internal static event Delegates.CompareRGB_Color32_Color32_BeforeArgs _beforeCompareRGB_Color32_Color32;
        internal static event Delegates.CompareRGB_Color32_Color32_AfterArgs _afterCompareRGB_Color32_Color32;

        private static bool CompareRGB_Color32_Color32(Func<Color32, Color32, bool> orig, Color32 a, Color32 b)
        {
            Delegates.Params_CompareRGB_Color32_Color32 @params = new()
            {
                a = a, b = b
            };
            if (_beforeCompareRGB_Color32_Color32 != null)
                foreach (Delegates.CompareRGB_Color32_Color32_BeforeArgs toInvoke in _beforeCompareRGB_Color32_Color32
                             .GetInvocationList())
                    try
                    {
                        _beforeCompareRGB_Color32_Color32?.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }

            a = @params.a;
            b = @params.b;
            var retVal = orig(a, b);
            if (_afterCompareRGB_Color32_Color32 != null)
                foreach (Delegates.CompareRGB_Color32_Color32_AfterArgs toInvoke in _afterCompareRGB_Color32_Color32
                             .GetInvocationList())
                    try
                    {
                        retVal = _afterCompareRGB_Color32_Color32.Invoke(@params, retVal);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }

            return retVal;
        }

        internal static void HookCompare_Color_Color()
        {
            if (!HookedList.Contains("Compare_Color_Color"))
            {
                HookedList.Add("Compare_Color_Color");
                new Hook(ReflectionHelper.GetMethodInfo(typeof(TMPro_ExtensionMethods), "Compare_Color_Color", false),
                    Compare_Color_Color);
            }
        }

        internal static event Delegates.Compare_Color_Color_BeforeArgs _beforeCompare_Color_Color;
        internal static event Delegates.Compare_Color_Color_AfterArgs _afterCompare_Color_Color;

        private static bool Compare_Color_Color(Func<Color, Color, bool> orig, Color a, Color b)
        {
            Delegates.Params_Compare_Color_Color @params = new()
            {
                a = a, b = b
            };
            if (_beforeCompare_Color_Color != null)
                foreach (Delegates.Compare_Color_Color_BeforeArgs toInvoke in _beforeCompare_Color_Color
                             .GetInvocationList())
                    try
                    {
                        _beforeCompare_Color_Color?.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }

            a = @params.a;
            b = @params.b;
            var retVal = orig(a, b);
            if (_afterCompare_Color_Color != null)
                foreach (Delegates.Compare_Color_Color_AfterArgs toInvoke in
                         _afterCompare_Color_Color.GetInvocationList())
                    try
                    {
                        retVal = _afterCompare_Color_Color.Invoke(@params, retVal);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }

            return retVal;
        }

        internal static void HookCompareRGB_Color_Color()
        {
            if (!HookedList.Contains("CompareRGB_Color_Color"))
            {
                HookedList.Add("CompareRGB_Color_Color");
                new Hook(
                    ReflectionHelper.GetMethodInfo(typeof(TMPro_ExtensionMethods), "CompareRGB_Color_Color", false),
                    CompareRGB_Color_Color);
            }
        }

        internal static event Delegates.CompareRGB_Color_Color_BeforeArgs _beforeCompareRGB_Color_Color;
        internal static event Delegates.CompareRGB_Color_Color_AfterArgs _afterCompareRGB_Color_Color;

        private static bool CompareRGB_Color_Color(Func<Color, Color, bool> orig, Color a, Color b)
        {
            Delegates.Params_CompareRGB_Color_Color @params = new()
            {
                a = a, b = b
            };
            if (_beforeCompareRGB_Color_Color != null)
                foreach (Delegates.CompareRGB_Color_Color_BeforeArgs toInvoke in _beforeCompareRGB_Color_Color
                             .GetInvocationList())
                    try
                    {
                        _beforeCompareRGB_Color_Color?.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }

            a = @params.a;
            b = @params.b;
            var retVal = orig(a, b);
            if (_afterCompareRGB_Color_Color != null)
                foreach (Delegates.CompareRGB_Color_Color_AfterArgs toInvoke in _afterCompareRGB_Color_Color
                             .GetInvocationList())
                    try
                    {
                        retVal = _afterCompareRGB_Color_Color.Invoke(@params, retVal);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }

            return retVal;
        }

        internal static void HookMultiply()
        {
            if (!HookedList.Contains("Multiply"))
            {
                HookedList.Add("Multiply");
                new Hook(ReflectionHelper.GetMethodInfo(typeof(TMPro_ExtensionMethods), "Multiply", false), Multiply);
            }
        }

        internal static event Delegates.Multiply_BeforeArgs _beforeMultiply;
        internal static event Delegates.Multiply_AfterArgs _afterMultiply;

        private static Color32 Multiply(Func<Color32, Color32, Color32> orig, Color32 c1, Color32 c2)
        {
            Delegates.Params_Multiply @params = new()
            {
                c1 = c1, c2 = c2
            };
            if (_beforeMultiply != null)
                foreach (Delegates.Multiply_BeforeArgs toInvoke in _beforeMultiply.GetInvocationList())
                    try
                    {
                        _beforeMultiply?.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }

            c1 = @params.c1;
            c2 = @params.c2;
            var retVal = orig(c1, c2);
            if (_afterMultiply != null)
                foreach (Delegates.Multiply_AfterArgs toInvoke in _afterMultiply.GetInvocationList())
                    try
                    {
                        retVal = _afterMultiply.Invoke(@params, retVal);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }

            return retVal;
        }

        internal static void HookTint_Color32_Color32()
        {
            if (!HookedList.Contains("Tint_Color32_Color32"))
            {
                HookedList.Add("Tint_Color32_Color32");
                new Hook(ReflectionHelper.GetMethodInfo(typeof(TMPro_ExtensionMethods), "Tint_Color32_Color32", false),
                    Tint_Color32_Color32);
            }
        }

        internal static event Delegates.Tint_Color32_Color32_BeforeArgs _beforeTint_Color32_Color32;
        internal static event Delegates.Tint_Color32_Color32_AfterArgs _afterTint_Color32_Color32;

        private static Color32 Tint_Color32_Color32(Func<Color32, Color32, Color32> orig, Color32 c1, Color32 c2)
        {
            Delegates.Params_Tint_Color32_Color32 @params = new()
            {
                c1 = c1, c2 = c2
            };
            if (_beforeTint_Color32_Color32 != null)
                foreach (Delegates.Tint_Color32_Color32_BeforeArgs toInvoke in _beforeTint_Color32_Color32
                             .GetInvocationList())
                    try
                    {
                        _beforeTint_Color32_Color32?.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }

            c1 = @params.c1;
            c2 = @params.c2;
            var retVal = orig(c1, c2);
            if (_afterTint_Color32_Color32 != null)
                foreach (Delegates.Tint_Color32_Color32_AfterArgs toInvoke in _afterTint_Color32_Color32
                             .GetInvocationList())
                    try
                    {
                        retVal = _afterTint_Color32_Color32.Invoke(@params, retVal);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }

            return retVal;
        }

        internal static void HookTint_Color32_float()
        {
            if (!HookedList.Contains("Tint_Color32_float"))
            {
                HookedList.Add("Tint_Color32_float");
                new Hook(ReflectionHelper.GetMethodInfo(typeof(TMPro_ExtensionMethods), "Tint_Color32_float", false),
                    Tint_Color32_float);
            }
        }

        internal static event Delegates.Tint_Color32_float_BeforeArgs _beforeTint_Color32_float;
        internal static event Delegates.Tint_Color32_float_AfterArgs _afterTint_Color32_float;

        private static Color32 Tint_Color32_float(Func<Color32, float, Color32> orig, Color32 c1, float tint)
        {
            Delegates.Params_Tint_Color32_float @params = new()
            {
                c1 = c1, tint = tint
            };
            if (_beforeTint_Color32_float != null)
                foreach (Delegates.Tint_Color32_float_BeforeArgs toInvoke in
                         _beforeTint_Color32_float.GetInvocationList())
                    try
                    {
                        _beforeTint_Color32_float?.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }

            c1 = @params.c1;
            tint = @params.tint;
            var retVal = orig(c1, tint);
            if (_afterTint_Color32_float != null)
                foreach (Delegates.Tint_Color32_float_AfterArgs toInvoke in
                         _afterTint_Color32_float.GetInvocationList())
                    try
                    {
                        retVal = _afterTint_Color32_float.Invoke(@params, retVal);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }

            return retVal;
        }

        internal static void HookCompare_Vector3_Vector3_int()
        {
            if (!HookedList.Contains("Compare_Vector3_Vector3_int"))
            {
                HookedList.Add("Compare_Vector3_Vector3_int");
                new Hook(
                    ReflectionHelper.GetMethodInfo(typeof(TMPro_ExtensionMethods), "Compare_Vector3_Vector3_int",
                        false), Compare_Vector3_Vector3_int);
            }
        }

        internal static event Delegates.Compare_Vector3_Vector3_int_BeforeArgs _beforeCompare_Vector3_Vector3_int;
        internal static event Delegates.Compare_Vector3_Vector3_int_AfterArgs _afterCompare_Vector3_Vector3_int;

        private static bool Compare_Vector3_Vector3_int(Func<Vector3, Vector3, int, bool> orig, Vector3 v1, Vector3 v2,
            int accuracy)
        {
            Delegates.Params_Compare_Vector3_Vector3_int @params = new()
            {
                v1 = v1, v2 = v2, accuracy = accuracy
            };
            if (_beforeCompare_Vector3_Vector3_int != null)
                foreach (Delegates.Compare_Vector3_Vector3_int_BeforeArgs toInvoke in _beforeCompare_Vector3_Vector3_int
                             .GetInvocationList())
                    try
                    {
                        _beforeCompare_Vector3_Vector3_int?.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }

            v1 = @params.v1;
            v2 = @params.v2;
            accuracy = @params.accuracy;
            var retVal = orig(v1, v2, accuracy);
            if (_afterCompare_Vector3_Vector3_int != null)
                foreach (Delegates.Compare_Vector3_Vector3_int_AfterArgs toInvoke in _afterCompare_Vector3_Vector3_int
                             .GetInvocationList())
                    try
                    {
                        retVal = _afterCompare_Vector3_Vector3_int.Invoke(@params, retVal);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }

            return retVal;
        }

        internal static void HookCompare_Quaternion_Quaternion_int()
        {
            if (!HookedList.Contains("Compare_Quaternion_Quaternion_int"))
            {
                HookedList.Add("Compare_Quaternion_Quaternion_int");
                new Hook(
                    ReflectionHelper.GetMethodInfo(typeof(TMPro_ExtensionMethods), "Compare_Quaternion_Quaternion_int",
                        false), Compare_Quaternion_Quaternion_int);
            }
        }

        internal static event Delegates.Compare_Quaternion_Quaternion_int_BeforeArgs
            _beforeCompare_Quaternion_Quaternion_int;

        internal static event Delegates.Compare_Quaternion_Quaternion_int_AfterArgs
            _afterCompare_Quaternion_Quaternion_int;

        private static bool Compare_Quaternion_Quaternion_int(Func<Quaternion, Quaternion, int, bool> orig,
            Quaternion q1, Quaternion q2, int accuracy)
        {
            Delegates.Params_Compare_Quaternion_Quaternion_int @params = new()
            {
                q1 = q1, q2 = q2, accuracy = accuracy
            };
            if (_beforeCompare_Quaternion_Quaternion_int != null)
                foreach (Delegates.Compare_Quaternion_Quaternion_int_BeforeArgs toInvoke in
                         _beforeCompare_Quaternion_Quaternion_int.GetInvocationList())
                    try
                    {
                        _beforeCompare_Quaternion_Quaternion_int?.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }

            q1 = @params.q1;
            q2 = @params.q2;
            accuracy = @params.accuracy;
            var retVal = orig(q1, q2, accuracy);
            if (_afterCompare_Quaternion_Quaternion_int != null)
                foreach (Delegates.Compare_Quaternion_Quaternion_int_AfterArgs toInvoke in
                         _afterCompare_Quaternion_Quaternion_int.GetInvocationList())
                    try
                    {
                        retVal = _afterCompare_Quaternion_Quaternion_int.Invoke(@params, retVal);
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
        public delegate bool Compare_Color_Color_AfterArgs(Params_Compare_Color_Color args, bool ret);

        public delegate void Compare_Color_Color_BeforeArgs(Params_Compare_Color_Color args);

        public delegate bool Compare_Color_Color_WithArgs(Func<Color, Color, bool> orig, Color a, Color b);

        public delegate bool Compare_Color32_Color32_AfterArgs(Params_Compare_Color32_Color32 args, bool ret);

        public delegate void Compare_Color32_Color32_BeforeArgs(Params_Compare_Color32_Color32 args);

        public delegate bool Compare_Color32_Color32_WithArgs(Func<Color32, Color32, bool> orig, Color32 a, Color32 b);

        public delegate bool Compare_Quaternion_Quaternion_int_AfterArgs(Params_Compare_Quaternion_Quaternion_int args,
            bool ret);

        public delegate void
            Compare_Quaternion_Quaternion_int_BeforeArgs(Params_Compare_Quaternion_Quaternion_int args);

        public delegate bool Compare_Quaternion_Quaternion_int_WithArgs(Func<Quaternion, Quaternion, int, bool> orig,
            Quaternion q1, Quaternion q2, int accuracy);

        public delegate bool Compare_Vector3_Vector3_int_AfterArgs(Params_Compare_Vector3_Vector3_int args, bool ret);

        public delegate void Compare_Vector3_Vector3_int_BeforeArgs(Params_Compare_Vector3_Vector3_int args);

        public delegate bool Compare_Vector3_Vector3_int_WithArgs(Func<Vector3, Vector3, int, bool> orig, Vector3 v1,
            Vector3 v2, int accuracy);

        public delegate bool CompareRGB_Color_Color_AfterArgs(Params_CompareRGB_Color_Color args, bool ret);

        public delegate void CompareRGB_Color_Color_BeforeArgs(Params_CompareRGB_Color_Color args);

        public delegate bool CompareRGB_Color_Color_WithArgs(Func<Color, Color, bool> orig, Color a, Color b);

        public delegate bool CompareRGB_Color32_Color32_AfterArgs(Params_CompareRGB_Color32_Color32 args, bool ret);

        public delegate void CompareRGB_Color32_Color32_BeforeArgs(Params_CompareRGB_Color32_Color32 args);

        public delegate bool CompareRGB_Color32_Color32_WithArgs(Func<Color32, Color32, bool> orig, Color32 a,
            Color32 b);

        public delegate Color32 Multiply_AfterArgs(Params_Multiply args, Color32 ret);

        public delegate void Multiply_BeforeArgs(Params_Multiply args);

        public delegate Color32 Multiply_WithArgs(Func<Color32, Color32, Color32> orig, Color32 c1, Color32 c2);

        public delegate Color32 Tint_Color32_Color32_AfterArgs(Params_Tint_Color32_Color32 args, Color32 ret);

        public delegate void Tint_Color32_Color32_BeforeArgs(Params_Tint_Color32_Color32 args);

        public delegate Color32 Tint_Color32_Color32_WithArgs(Func<Color32, Color32, Color32> orig, Color32 c1,
            Color32 c2);

        public delegate Color32 Tint_Color32_float_AfterArgs(Params_Tint_Color32_float args, Color32 ret);

        public delegate void Tint_Color32_float_BeforeArgs(Params_Tint_Color32_float args);

        public delegate Color32 Tint_Color32_float_WithArgs(Func<Color32, float, Color32> orig, Color32 c1, float tint);

        public sealed class Params_Compare_Color32_Color32
        {
            public Color32 a;
            public Color32 b;
        }

        public sealed class Params_CompareRGB_Color32_Color32
        {
            public Color32 a;
            public Color32 b;
        }

        public sealed class Params_Compare_Color_Color
        {
            public Color a;
            public Color b;
        }

        public sealed class Params_CompareRGB_Color_Color
        {
            public Color a;
            public Color b;
        }

        public sealed class Params_Multiply
        {
            public Color32 c1;
            public Color32 c2;
        }

        public sealed class Params_Tint_Color32_Color32
        {
            public Color32 c1;
            public Color32 c2;
        }

        public sealed class Params_Tint_Color32_float
        {
            public Color32 c1;
            public float tint;
        }

        public sealed class Params_Compare_Vector3_Vector3_int
        {
            public int accuracy;
            public Vector3 v1;
            public Vector3 v2;
        }

        public sealed class Params_Compare_Quaternion_Quaternion_int
        {
            public int accuracy;
            public Quaternion q1;
            public Quaternion q2;
        }
    }

    /// <summary>
    ///     Contains Hooks to that run code before orig(self) is called
    /// </summary>
    public static class BeforeOrig
    {
        public static event Delegates.Compare_Color32_Color32_BeforeArgs Compare_Color32_Color32
        {
            add
            {
                HookHandler._beforeCompare_Color32_Color32 += value;
                HookHandler.HookCompare_Color32_Color32();
            }
            remove => HookHandler._beforeCompare_Color32_Color32 -= value;
        }

        public static event Delegates.CompareRGB_Color32_Color32_BeforeArgs CompareRGB_Color32_Color32
        {
            add
            {
                HookHandler._beforeCompareRGB_Color32_Color32 += value;
                HookHandler.HookCompareRGB_Color32_Color32();
            }
            remove => HookHandler._beforeCompareRGB_Color32_Color32 -= value;
        }

        public static event Delegates.Compare_Color_Color_BeforeArgs Compare_Color_Color
        {
            add
            {
                HookHandler._beforeCompare_Color_Color += value;
                HookHandler.HookCompare_Color_Color();
            }
            remove => HookHandler._beforeCompare_Color_Color -= value;
        }

        public static event Delegates.CompareRGB_Color_Color_BeforeArgs CompareRGB_Color_Color
        {
            add
            {
                HookHandler._beforeCompareRGB_Color_Color += value;
                HookHandler.HookCompareRGB_Color_Color();
            }
            remove => HookHandler._beforeCompareRGB_Color_Color -= value;
        }

        public static event Delegates.Multiply_BeforeArgs Multiply
        {
            add
            {
                HookHandler._beforeMultiply += value;
                HookHandler.HookMultiply();
            }
            remove => HookHandler._beforeMultiply -= value;
        }

        public static event Delegates.Tint_Color32_Color32_BeforeArgs Tint_Color32_Color32
        {
            add
            {
                HookHandler._beforeTint_Color32_Color32 += value;
                HookHandler.HookTint_Color32_Color32();
            }
            remove => HookHandler._beforeTint_Color32_Color32 -= value;
        }

        public static event Delegates.Tint_Color32_float_BeforeArgs Tint_Color32_float
        {
            add
            {
                HookHandler._beforeTint_Color32_float += value;
                HookHandler.HookTint_Color32_float();
            }
            remove => HookHandler._beforeTint_Color32_float -= value;
        }

        public static event Delegates.Compare_Vector3_Vector3_int_BeforeArgs Compare_Vector3_Vector3_int
        {
            add
            {
                HookHandler._beforeCompare_Vector3_Vector3_int += value;
                HookHandler.HookCompare_Vector3_Vector3_int();
            }
            remove => HookHandler._beforeCompare_Vector3_Vector3_int -= value;
        }

        public static event Delegates.Compare_Quaternion_Quaternion_int_BeforeArgs Compare_Quaternion_Quaternion_int
        {
            add
            {
                HookHandler._beforeCompare_Quaternion_Quaternion_int += value;
                HookHandler.HookCompare_Quaternion_Quaternion_int();
            }
            remove => HookHandler._beforeCompare_Quaternion_Quaternion_int -= value;
        }
    }

    /// <summary>
    ///     Contains Hooks to that run code after orig(self) is called
    /// </summary>
    public static class AfterOrig
    {
        public static event Delegates.Compare_Color32_Color32_AfterArgs Compare_Color32_Color32
        {
            add
            {
                HookHandler._afterCompare_Color32_Color32 += value;
                HookHandler.HookCompare_Color32_Color32();
            }
            remove => HookHandler._afterCompare_Color32_Color32 -= value;
        }

        public static event Delegates.CompareRGB_Color32_Color32_AfterArgs CompareRGB_Color32_Color32
        {
            add
            {
                HookHandler._afterCompareRGB_Color32_Color32 += value;
                HookHandler.HookCompareRGB_Color32_Color32();
            }
            remove => HookHandler._afterCompareRGB_Color32_Color32 -= value;
        }

        public static event Delegates.Compare_Color_Color_AfterArgs Compare_Color_Color
        {
            add
            {
                HookHandler._afterCompare_Color_Color += value;
                HookHandler.HookCompare_Color_Color();
            }
            remove => HookHandler._afterCompare_Color_Color -= value;
        }

        public static event Delegates.CompareRGB_Color_Color_AfterArgs CompareRGB_Color_Color
        {
            add
            {
                HookHandler._afterCompareRGB_Color_Color += value;
                HookHandler.HookCompareRGB_Color_Color();
            }
            remove => HookHandler._afterCompareRGB_Color_Color -= value;
        }

        public static event Delegates.Multiply_AfterArgs Multiply
        {
            add
            {
                HookHandler._afterMultiply += value;
                HookHandler.HookMultiply();
            }
            remove => HookHandler._afterMultiply -= value;
        }

        public static event Delegates.Tint_Color32_Color32_AfterArgs Tint_Color32_Color32
        {
            add
            {
                HookHandler._afterTint_Color32_Color32 += value;
                HookHandler.HookTint_Color32_Color32();
            }
            remove => HookHandler._afterTint_Color32_Color32 -= value;
        }

        public static event Delegates.Tint_Color32_float_AfterArgs Tint_Color32_float
        {
            add
            {
                HookHandler._afterTint_Color32_float += value;
                HookHandler.HookTint_Color32_float();
            }
            remove => HookHandler._afterTint_Color32_float -= value;
        }

        public static event Delegates.Compare_Vector3_Vector3_int_AfterArgs Compare_Vector3_Vector3_int
        {
            add
            {
                HookHandler._afterCompare_Vector3_Vector3_int += value;
                HookHandler.HookCompare_Vector3_Vector3_int();
            }
            remove => HookHandler._afterCompare_Vector3_Vector3_int -= value;
        }

        public static event Delegates.Compare_Quaternion_Quaternion_int_AfterArgs Compare_Quaternion_Quaternion_int
        {
            add
            {
                HookHandler._afterCompare_Quaternion_Quaternion_int += value;
                HookHandler.HookCompare_Quaternion_Quaternion_int();
            }
            remove => HookHandler._afterCompare_Quaternion_Quaternion_int -= value;
        }
    }

    /// <summary>
    ///     Contains all On Hooks, even those that aren't in the On namespace such as API generated functions and property
    ///     getters/setters
    /// </summary>
    public static class WithOrig
    {
        public static event Delegates.Compare_Color32_Color32_WithArgs Compare_Color32_Color32
        {
            add => HookEndpointManager.Add<Delegates.Compare_Color32_Color32_WithArgs>(
                ReflectionHelper.GetMethodInfo(typeof(TMPro_ExtensionMethods), "Compare", false), value);
            remove => HookEndpointManager.Remove<Delegates.Compare_Color32_Color32_WithArgs>(
                ReflectionHelper.GetMethodInfo(typeof(TMPro_ExtensionMethods), "Compare", false), value);
        }

        public static event Delegates.CompareRGB_Color32_Color32_WithArgs CompareRGB_Color32_Color32
        {
            add => HookEndpointManager.Add<Delegates.CompareRGB_Color32_Color32_WithArgs>(
                ReflectionHelper.GetMethodInfo(typeof(TMPro_ExtensionMethods), "CompareRGB", false), value);
            remove => HookEndpointManager.Remove<Delegates.CompareRGB_Color32_Color32_WithArgs>(
                ReflectionHelper.GetMethodInfo(typeof(TMPro_ExtensionMethods), "CompareRGB", false), value);
        }

        public static event Delegates.Compare_Color_Color_WithArgs Compare_Color_Color
        {
            add => HookEndpointManager.Add<Delegates.Compare_Color_Color_WithArgs>(
                ReflectionHelper.GetMethodInfo(typeof(TMPro_ExtensionMethods), "Compare", false), value);
            remove => HookEndpointManager.Remove<Delegates.Compare_Color_Color_WithArgs>(
                ReflectionHelper.GetMethodInfo(typeof(TMPro_ExtensionMethods), "Compare", false), value);
        }

        public static event Delegates.CompareRGB_Color_Color_WithArgs CompareRGB_Color_Color
        {
            add => HookEndpointManager.Add<Delegates.CompareRGB_Color_Color_WithArgs>(
                ReflectionHelper.GetMethodInfo(typeof(TMPro_ExtensionMethods), "CompareRGB", false), value);
            remove => HookEndpointManager.Remove<Delegates.CompareRGB_Color_Color_WithArgs>(
                ReflectionHelper.GetMethodInfo(typeof(TMPro_ExtensionMethods), "CompareRGB", false), value);
        }

        public static event Delegates.Multiply_WithArgs Multiply
        {
            add => HookEndpointManager.Add<Delegates.Multiply_WithArgs>(
                ReflectionHelper.GetMethodInfo(typeof(TMPro_ExtensionMethods), "Multiply", false), value);
            remove => HookEndpointManager.Remove<Delegates.Multiply_WithArgs>(
                ReflectionHelper.GetMethodInfo(typeof(TMPro_ExtensionMethods), "Multiply", false), value);
        }

        public static event Delegates.Tint_Color32_Color32_WithArgs Tint_Color32_Color32
        {
            add => HookEndpointManager.Add<Delegates.Tint_Color32_Color32_WithArgs>(
                ReflectionHelper.GetMethodInfo(typeof(TMPro_ExtensionMethods), "Tint", false), value);
            remove => HookEndpointManager.Remove<Delegates.Tint_Color32_Color32_WithArgs>(
                ReflectionHelper.GetMethodInfo(typeof(TMPro_ExtensionMethods), "Tint", false), value);
        }

        public static event Delegates.Tint_Color32_float_WithArgs Tint_Color32_float
        {
            add => HookEndpointManager.Add<Delegates.Tint_Color32_float_WithArgs>(
                ReflectionHelper.GetMethodInfo(typeof(TMPro_ExtensionMethods), "Tint", false), value);
            remove => HookEndpointManager.Remove<Delegates.Tint_Color32_float_WithArgs>(
                ReflectionHelper.GetMethodInfo(typeof(TMPro_ExtensionMethods), "Tint", false), value);
        }

        public static event Delegates.Compare_Vector3_Vector3_int_WithArgs Compare_Vector3_Vector3_int
        {
            add => HookEndpointManager.Add<Delegates.Compare_Vector3_Vector3_int_WithArgs>(
                ReflectionHelper.GetMethodInfo(typeof(TMPro_ExtensionMethods), "Compare", false), value);
            remove => HookEndpointManager.Remove<Delegates.Compare_Vector3_Vector3_int_WithArgs>(
                ReflectionHelper.GetMethodInfo(typeof(TMPro_ExtensionMethods), "Compare", false), value);
        }

        public static event Delegates.Compare_Quaternion_Quaternion_int_WithArgs Compare_Quaternion_Quaternion_int
        {
            add => HookEndpointManager.Add<Delegates.Compare_Quaternion_Quaternion_int_WithArgs>(
                ReflectionHelper.GetMethodInfo(typeof(TMPro_ExtensionMethods), "Compare", false), value);
            remove => HookEndpointManager.Remove<Delegates.Compare_Quaternion_Quaternion_int_WithArgs>(
                ReflectionHelper.GetMethodInfo(typeof(TMPro_ExtensionMethods), "Compare", false), value);
        }
    }
}