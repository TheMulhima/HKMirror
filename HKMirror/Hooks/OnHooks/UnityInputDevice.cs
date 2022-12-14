using MonoMod.RuntimeDetour;
using MonoMod.RuntimeDetour.HookGen;

namespace HKMirror.Hooks.OnHooks;

/// <summary>
///     Contains different types of On Hooks for UnityInputDevice class.<br />
///     Contains hooks that aren't generated by monomod, and before and after orig hooks for easier hooking.
/// </summary>
public static class OnUnityInputDevice
{
    internal static class HookHandler
    {
        private static readonly List<string> HookedList = new();

        internal static void Hookget_JoystickId()
        {
            if (!HookedList.Contains("get_JoystickId"))
            {
                HookedList.Add("get_JoystickId");
                new Hook(ReflectionHelper.GetMethodInfo(typeof(UnityInputDevice), "get_JoystickId"), get_JoystickId);
            }
        }

        internal static event Delegates.get_JoystickId_BeforeArgs _beforeget_JoystickId;
        internal static event Delegates.get_JoystickId_AfterArgs _afterget_JoystickId;

        private static int get_JoystickId(Func<UnityInputDevice, int> orig, UnityInputDevice self)
        {
            Delegates.Params_get_JoystickId @params = new()
            {
                self = self
            };
            if (_beforeget_JoystickId != null)
                foreach (Delegates.get_JoystickId_BeforeArgs toInvoke in _beforeget_JoystickId.GetInvocationList())
                    try
                    {
                        _beforeget_JoystickId?.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }

            self = @params.self;
            var retVal = orig(self);
            if (_afterget_JoystickId != null)
                foreach (Delegates.get_JoystickId_AfterArgs toInvoke in _afterget_JoystickId.GetInvocationList())
                    try
                    {
                        retVal = _afterget_JoystickId.Invoke(@params, retVal);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }

            return retVal;
        }

        internal static void Hookset_JoystickId()
        {
            if (!HookedList.Contains("set_JoystickId"))
            {
                HookedList.Add("set_JoystickId");
                new Hook(ReflectionHelper.GetMethodInfo(typeof(UnityInputDevice), "set_JoystickId"), set_JoystickId);
            }
        }

        internal static event Delegates.set_JoystickId_BeforeArgs _beforeset_JoystickId;
        internal static event Delegates.set_JoystickId_AfterArgs _afterset_JoystickId;

        private static void set_JoystickId(Action<UnityInputDevice, int> orig, UnityInputDevice self, int value)
        {
            Delegates.Params_set_JoystickId @params = new()
            {
                self = self, value = value
            };
            if (_beforeset_JoystickId != null)
                foreach (Delegates.set_JoystickId_BeforeArgs toInvoke in _beforeset_JoystickId.GetInvocationList())
                    try
                    {
                        _beforeset_JoystickId?.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }

            self = @params.self;
            value = @params.value;
            orig(self, value);
            if (_afterset_JoystickId != null)
                foreach (Delegates.set_JoystickId_AfterArgs toInvoke in _afterset_JoystickId.GetInvocationList())
                    try
                    {
                        _afterset_JoystickId.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }
        }

        internal static void HookUpdate()
        {
            if (!HookedList.Contains("Update"))
            {
                HookedList.Add("Update");
                new Hook(ReflectionHelper.GetMethodInfo(typeof(UnityInputDevice), "Update"), Update);
            }
        }

        internal static event Delegates.Update_BeforeArgs _beforeUpdate;
        internal static event Delegates.Update_AfterArgs _afterUpdate;

        private static void Update(Action<UnityInputDevice, ulong, float> orig, UnityInputDevice self, ulong updateTick,
            float deltaTime)
        {
            Delegates.Params_Update @params = new()
            {
                self = self, updateTick = updateTick, deltaTime = deltaTime
            };
            if (_beforeUpdate != null)
                foreach (Delegates.Update_BeforeArgs toInvoke in _beforeUpdate.GetInvocationList())
                    try
                    {
                        _beforeUpdate?.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }

            self = @params.self;
            updateTick = @params.updateTick;
            deltaTime = @params.deltaTime;
            orig(self, updateTick, deltaTime);
            if (_afterUpdate != null)
                foreach (Delegates.Update_AfterArgs toInvoke in _afterUpdate.GetInvocationList())
                    try
                    {
                        _afterUpdate.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }
        }

        internal static void HookSetupAnalogQueries()
        {
            if (!HookedList.Contains("SetupAnalogQueries"))
            {
                HookedList.Add("SetupAnalogQueries");
                new Hook(ReflectionHelper.GetMethodInfo(typeof(UnityInputDevice), "SetupAnalogQueries", false),
                    SetupAnalogQueries);
            }
        }

        internal static event Delegates.SetupAnalogQueries_BeforeArgs _beforeSetupAnalogQueries;
        internal static event Delegates.SetupAnalogQueries_AfterArgs _afterSetupAnalogQueries;

        private static void SetupAnalogQueries(Action orig)
        {
            if (_beforeSetupAnalogQueries != null)
                foreach (Delegates.SetupAnalogQueries_BeforeArgs toInvoke in
                         _beforeSetupAnalogQueries.GetInvocationList())
                    try
                    {
                        _beforeSetupAnalogQueries?.Invoke();
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }

            orig();
            if (_afterSetupAnalogQueries != null)
                foreach (Delegates.SetupAnalogQueries_AfterArgs toInvoke in
                         _afterSetupAnalogQueries.GetInvocationList())
                    try
                    {
                        _afterSetupAnalogQueries.Invoke();
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }
        }

        internal static void HookSetupButtonQueries()
        {
            if (!HookedList.Contains("SetupButtonQueries"))
            {
                HookedList.Add("SetupButtonQueries");
                new Hook(ReflectionHelper.GetMethodInfo(typeof(UnityInputDevice), "SetupButtonQueries", false),
                    SetupButtonQueries);
            }
        }

        internal static event Delegates.SetupButtonQueries_BeforeArgs _beforeSetupButtonQueries;
        internal static event Delegates.SetupButtonQueries_AfterArgs _afterSetupButtonQueries;

        private static void SetupButtonQueries(Action orig)
        {
            if (_beforeSetupButtonQueries != null)
                foreach (Delegates.SetupButtonQueries_BeforeArgs toInvoke in
                         _beforeSetupButtonQueries.GetInvocationList())
                    try
                    {
                        _beforeSetupButtonQueries?.Invoke();
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }

            orig();
            if (_afterSetupButtonQueries != null)
                foreach (Delegates.SetupButtonQueries_AfterArgs toInvoke in
                         _afterSetupButtonQueries.GetInvocationList())
                    try
                    {
                        _afterSetupButtonQueries.Invoke();
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }
        }

        internal static void HookReadRawButtonState()
        {
            if (!HookedList.Contains("ReadRawButtonState"))
            {
                HookedList.Add("ReadRawButtonState");
                new Hook(ReflectionHelper.GetMethodInfo(typeof(UnityInputDevice), "ReadRawButtonState"),
                    ReadRawButtonState);
            }
        }

        internal static event Delegates.ReadRawButtonState_BeforeArgs _beforeReadRawButtonState;
        internal static event Delegates.ReadRawButtonState_AfterArgs _afterReadRawButtonState;

        private static bool ReadRawButtonState(Func<UnityInputDevice, int, bool> orig, UnityInputDevice self, int index)
        {
            Delegates.Params_ReadRawButtonState @params = new()
            {
                self = self, index = index
            };
            if (_beforeReadRawButtonState != null)
                foreach (Delegates.ReadRawButtonState_BeforeArgs toInvoke in
                         _beforeReadRawButtonState.GetInvocationList())
                    try
                    {
                        _beforeReadRawButtonState?.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }

            self = @params.self;
            index = @params.index;
            var retVal = orig(self, index);
            if (_afterReadRawButtonState != null)
                foreach (Delegates.ReadRawButtonState_AfterArgs toInvoke in
                         _afterReadRawButtonState.GetInvocationList())
                    try
                    {
                        retVal = _afterReadRawButtonState.Invoke(@params, retVal);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }

            return retVal;
        }

        internal static void HookReadRawAnalogValue()
        {
            if (!HookedList.Contains("ReadRawAnalogValue"))
            {
                HookedList.Add("ReadRawAnalogValue");
                new Hook(ReflectionHelper.GetMethodInfo(typeof(UnityInputDevice), "ReadRawAnalogValue"),
                    ReadRawAnalogValue);
            }
        }

        internal static event Delegates.ReadRawAnalogValue_BeforeArgs _beforeReadRawAnalogValue;
        internal static event Delegates.ReadRawAnalogValue_AfterArgs _afterReadRawAnalogValue;

        private static float ReadRawAnalogValue(Func<UnityInputDevice, int, float> orig, UnityInputDevice self,
            int index)
        {
            Delegates.Params_ReadRawAnalogValue @params = new()
            {
                self = self, index = index
            };
            if (_beforeReadRawAnalogValue != null)
                foreach (Delegates.ReadRawAnalogValue_BeforeArgs toInvoke in
                         _beforeReadRawAnalogValue.GetInvocationList())
                    try
                    {
                        _beforeReadRawAnalogValue?.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }

            self = @params.self;
            index = @params.index;
            var retVal = orig(self, index);
            if (_afterReadRawAnalogValue != null)
                foreach (Delegates.ReadRawAnalogValue_AfterArgs toInvoke in
                         _afterReadRawAnalogValue.GetInvocationList())
                    try
                    {
                        retVal = _afterReadRawAnalogValue.Invoke(@params, retVal);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }

            return retVal;
        }

        internal static void Hookget_IsSupportedOnThisPlatform()
        {
            if (!HookedList.Contains("get_IsSupportedOnThisPlatform"))
            {
                HookedList.Add("get_IsSupportedOnThisPlatform");
                new Hook(ReflectionHelper.GetMethodInfo(typeof(UnityInputDevice), "get_IsSupportedOnThisPlatform"),
                    get_IsSupportedOnThisPlatform);
            }
        }

        internal static event Delegates.get_IsSupportedOnThisPlatform_BeforeArgs _beforeget_IsSupportedOnThisPlatform;
        internal static event Delegates.get_IsSupportedOnThisPlatform_AfterArgs _afterget_IsSupportedOnThisPlatform;

        private static bool get_IsSupportedOnThisPlatform(Func<UnityInputDevice, bool> orig, UnityInputDevice self)
        {
            Delegates.Params_get_IsSupportedOnThisPlatform @params = new()
            {
                self = self
            };
            if (_beforeget_IsSupportedOnThisPlatform != null)
                foreach (Delegates.get_IsSupportedOnThisPlatform_BeforeArgs toInvoke in
                         _beforeget_IsSupportedOnThisPlatform.GetInvocationList())
                    try
                    {
                        _beforeget_IsSupportedOnThisPlatform?.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }

            self = @params.self;
            var retVal = orig(self);
            if (_afterget_IsSupportedOnThisPlatform != null)
                foreach (Delegates.get_IsSupportedOnThisPlatform_AfterArgs toInvoke in
                         _afterget_IsSupportedOnThisPlatform.GetInvocationList())
                    try
                    {
                        retVal = _afterget_IsSupportedOnThisPlatform.Invoke(@params, retVal);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }

            return retVal;
        }

        internal static void Hookget_IsKnown()
        {
            if (!HookedList.Contains("get_IsKnown"))
            {
                HookedList.Add("get_IsKnown");
                new Hook(ReflectionHelper.GetMethodInfo(typeof(UnityInputDevice), "get_IsKnown"), get_IsKnown);
            }
        }

        internal static event Delegates.get_IsKnown_BeforeArgs _beforeget_IsKnown;
        internal static event Delegates.get_IsKnown_AfterArgs _afterget_IsKnown;

        private static bool get_IsKnown(Func<UnityInputDevice, bool> orig, UnityInputDevice self)
        {
            Delegates.Params_get_IsKnown @params = new()
            {
                self = self
            };
            if (_beforeget_IsKnown != null)
                foreach (Delegates.get_IsKnown_BeforeArgs toInvoke in _beforeget_IsKnown.GetInvocationList())
                    try
                    {
                        _beforeget_IsKnown?.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }

            self = @params.self;
            var retVal = orig(self);
            if (_afterget_IsKnown != null)
                foreach (Delegates.get_IsKnown_AfterArgs toInvoke in _afterget_IsKnown.GetInvocationList())
                    try
                    {
                        retVal = _afterget_IsKnown.Invoke(@params, retVal);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }

            return retVal;
        }

        internal static void Hookget_NumUnknownButtons()
        {
            if (!HookedList.Contains("get_NumUnknownButtons"))
            {
                HookedList.Add("get_NumUnknownButtons");
                new Hook(ReflectionHelper.GetMethodInfo(typeof(UnityInputDevice), "get_NumUnknownButtons"),
                    get_NumUnknownButtons);
            }
        }

        internal static event Delegates.get_NumUnknownButtons_BeforeArgs _beforeget_NumUnknownButtons;
        internal static event Delegates.get_NumUnknownButtons_AfterArgs _afterget_NumUnknownButtons;

        private static int get_NumUnknownButtons(Func<UnityInputDevice, int> orig, UnityInputDevice self)
        {
            Delegates.Params_get_NumUnknownButtons @params = new()
            {
                self = self
            };
            if (_beforeget_NumUnknownButtons != null)
                foreach (Delegates.get_NumUnknownButtons_BeforeArgs toInvoke in _beforeget_NumUnknownButtons
                             .GetInvocationList())
                    try
                    {
                        _beforeget_NumUnknownButtons?.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }

            self = @params.self;
            var retVal = orig(self);
            if (_afterget_NumUnknownButtons != null)
                foreach (Delegates.get_NumUnknownButtons_AfterArgs toInvoke in _afterget_NumUnknownButtons
                             .GetInvocationList())
                    try
                    {
                        retVal = _afterget_NumUnknownButtons.Invoke(@params, retVal);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }

            return retVal;
        }

        internal static void Hookget_NumUnknownAnalogs()
        {
            if (!HookedList.Contains("get_NumUnknownAnalogs"))
            {
                HookedList.Add("get_NumUnknownAnalogs");
                new Hook(ReflectionHelper.GetMethodInfo(typeof(UnityInputDevice), "get_NumUnknownAnalogs"),
                    get_NumUnknownAnalogs);
            }
        }

        internal static event Delegates.get_NumUnknownAnalogs_BeforeArgs _beforeget_NumUnknownAnalogs;
        internal static event Delegates.get_NumUnknownAnalogs_AfterArgs _afterget_NumUnknownAnalogs;

        private static int get_NumUnknownAnalogs(Func<UnityInputDevice, int> orig, UnityInputDevice self)
        {
            Delegates.Params_get_NumUnknownAnalogs @params = new()
            {
                self = self
            };
            if (_beforeget_NumUnknownAnalogs != null)
                foreach (Delegates.get_NumUnknownAnalogs_BeforeArgs toInvoke in _beforeget_NumUnknownAnalogs
                             .GetInvocationList())
                    try
                    {
                        _beforeget_NumUnknownAnalogs?.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }

            self = @params.self;
            var retVal = orig(self);
            if (_afterget_NumUnknownAnalogs != null)
                foreach (Delegates.get_NumUnknownAnalogs_AfterArgs toInvoke in _afterget_NumUnknownAnalogs
                             .GetInvocationList())
                    try
                    {
                        retVal = _afterget_NumUnknownAnalogs.Invoke(@params, retVal);
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
        public delegate bool get_IsKnown_AfterArgs(Params_get_IsKnown args, bool ret);

        public delegate void get_IsKnown_BeforeArgs(Params_get_IsKnown args);

        public delegate bool get_IsKnown_WithArgs(Func<UnityInputDevice, bool> orig, UnityInputDevice self);

        public delegate bool get_IsSupportedOnThisPlatform_AfterArgs(Params_get_IsSupportedOnThisPlatform args,
            bool ret);

        public delegate void get_IsSupportedOnThisPlatform_BeforeArgs(Params_get_IsSupportedOnThisPlatform args);

        public delegate bool get_IsSupportedOnThisPlatform_WithArgs(Func<UnityInputDevice, bool> orig,
            UnityInputDevice self);

        public delegate int get_JoystickId_AfterArgs(Params_get_JoystickId args, int ret);

        public delegate void get_JoystickId_BeforeArgs(Params_get_JoystickId args);

        public delegate int get_JoystickId_WithArgs(Func<UnityInputDevice, int> orig, UnityInputDevice self);

        public delegate int get_NumUnknownAnalogs_AfterArgs(Params_get_NumUnknownAnalogs args, int ret);

        public delegate void get_NumUnknownAnalogs_BeforeArgs(Params_get_NumUnknownAnalogs args);

        public delegate int get_NumUnknownAnalogs_WithArgs(Func<UnityInputDevice, int> orig, UnityInputDevice self);

        public delegate int get_NumUnknownButtons_AfterArgs(Params_get_NumUnknownButtons args, int ret);

        public delegate void get_NumUnknownButtons_BeforeArgs(Params_get_NumUnknownButtons args);

        public delegate int get_NumUnknownButtons_WithArgs(Func<UnityInputDevice, int> orig, UnityInputDevice self);

        public delegate float ReadRawAnalogValue_AfterArgs(Params_ReadRawAnalogValue args, float ret);

        public delegate void ReadRawAnalogValue_BeforeArgs(Params_ReadRawAnalogValue args);

        public delegate float ReadRawAnalogValue_WithArgs(Func<UnityInputDevice, int, float> orig,
            UnityInputDevice self, int index);

        public delegate bool ReadRawButtonState_AfterArgs(Params_ReadRawButtonState args, bool ret);

        public delegate void ReadRawButtonState_BeforeArgs(Params_ReadRawButtonState args);

        public delegate bool ReadRawButtonState_WithArgs(Func<UnityInputDevice, int, bool> orig, UnityInputDevice self,
            int index);

        public delegate void set_JoystickId_AfterArgs(Params_set_JoystickId args);

        public delegate void set_JoystickId_BeforeArgs(Params_set_JoystickId args);

        public delegate void set_JoystickId_WithArgs(Action<UnityInputDevice, int> orig, UnityInputDevice self,
            int value);

        public delegate void SetupAnalogQueries_AfterArgs();

        public delegate void SetupAnalogQueries_BeforeArgs();

        public delegate void SetupAnalogQueries_WithArgs(Action orig);

        public delegate void SetupButtonQueries_AfterArgs();

        public delegate void SetupButtonQueries_BeforeArgs();

        public delegate void SetupButtonQueries_WithArgs(Action orig);

        public delegate void Update_AfterArgs(Params_Update args);

        public delegate void Update_BeforeArgs(Params_Update args);

        public delegate void Update_WithArgs(Action<UnityInputDevice, ulong, float> orig, UnityInputDevice self,
            ulong updateTick, float deltaTime);

        public sealed class Params_get_JoystickId
        {
            public UnityInputDevice self;
        }

        public sealed class Params_set_JoystickId
        {
            public UnityInputDevice self;
            public int value;
        }

        public sealed class Params_Update
        {
            public float deltaTime;
            public UnityInputDevice self;
            public ulong updateTick;
        }

        public sealed class Params_ReadRawButtonState
        {
            public int index;
            public UnityInputDevice self;
        }

        public sealed class Params_ReadRawAnalogValue
        {
            public int index;
            public UnityInputDevice self;
        }

        public sealed class Params_get_IsSupportedOnThisPlatform
        {
            public UnityInputDevice self;
        }

        public sealed class Params_get_IsKnown
        {
            public UnityInputDevice self;
        }

        public sealed class Params_get_NumUnknownButtons
        {
            public UnityInputDevice self;
        }

        public sealed class Params_get_NumUnknownAnalogs
        {
            public UnityInputDevice self;
        }
    }

    /// <summary>
    ///     Contains Hooks to that run code before orig(self) is called
    /// </summary>
    public static class BeforeOrig
    {
        public static event Delegates.get_JoystickId_BeforeArgs get_JoystickId
        {
            add
            {
                HookHandler._beforeget_JoystickId += value;
                HookHandler.Hookget_JoystickId();
            }
            remove => HookHandler._beforeget_JoystickId -= value;
        }

        public static event Delegates.set_JoystickId_BeforeArgs set_JoystickId
        {
            add
            {
                HookHandler._beforeset_JoystickId += value;
                HookHandler.Hookset_JoystickId();
            }
            remove => HookHandler._beforeset_JoystickId -= value;
        }

        public static event Delegates.Update_BeforeArgs Update
        {
            add
            {
                HookHandler._beforeUpdate += value;
                HookHandler.HookUpdate();
            }
            remove => HookHandler._beforeUpdate -= value;
        }

        public static event Delegates.SetupAnalogQueries_BeforeArgs SetupAnalogQueries
        {
            add
            {
                HookHandler._beforeSetupAnalogQueries += value;
                HookHandler.HookSetupAnalogQueries();
            }
            remove => HookHandler._beforeSetupAnalogQueries -= value;
        }

        public static event Delegates.SetupButtonQueries_BeforeArgs SetupButtonQueries
        {
            add
            {
                HookHandler._beforeSetupButtonQueries += value;
                HookHandler.HookSetupButtonQueries();
            }
            remove => HookHandler._beforeSetupButtonQueries -= value;
        }

        public static event Delegates.ReadRawButtonState_BeforeArgs ReadRawButtonState
        {
            add
            {
                HookHandler._beforeReadRawButtonState += value;
                HookHandler.HookReadRawButtonState();
            }
            remove => HookHandler._beforeReadRawButtonState -= value;
        }

        public static event Delegates.ReadRawAnalogValue_BeforeArgs ReadRawAnalogValue
        {
            add
            {
                HookHandler._beforeReadRawAnalogValue += value;
                HookHandler.HookReadRawAnalogValue();
            }
            remove => HookHandler._beforeReadRawAnalogValue -= value;
        }

        public static event Delegates.get_IsSupportedOnThisPlatform_BeforeArgs get_IsSupportedOnThisPlatform
        {
            add
            {
                HookHandler._beforeget_IsSupportedOnThisPlatform += value;
                HookHandler.Hookget_IsSupportedOnThisPlatform();
            }
            remove => HookHandler._beforeget_IsSupportedOnThisPlatform -= value;
        }

        public static event Delegates.get_IsKnown_BeforeArgs get_IsKnown
        {
            add
            {
                HookHandler._beforeget_IsKnown += value;
                HookHandler.Hookget_IsKnown();
            }
            remove => HookHandler._beforeget_IsKnown -= value;
        }

        public static event Delegates.get_NumUnknownButtons_BeforeArgs get_NumUnknownButtons
        {
            add
            {
                HookHandler._beforeget_NumUnknownButtons += value;
                HookHandler.Hookget_NumUnknownButtons();
            }
            remove => HookHandler._beforeget_NumUnknownButtons -= value;
        }

        public static event Delegates.get_NumUnknownAnalogs_BeforeArgs get_NumUnknownAnalogs
        {
            add
            {
                HookHandler._beforeget_NumUnknownAnalogs += value;
                HookHandler.Hookget_NumUnknownAnalogs();
            }
            remove => HookHandler._beforeget_NumUnknownAnalogs -= value;
        }
    }

    /// <summary>
    ///     Contains Hooks to that run code after orig(self) is called
    /// </summary>
    public static class AfterOrig
    {
        public static event Delegates.get_JoystickId_AfterArgs get_JoystickId
        {
            add
            {
                HookHandler._afterget_JoystickId += value;
                HookHandler.Hookget_JoystickId();
            }
            remove => HookHandler._afterget_JoystickId -= value;
        }

        public static event Delegates.set_JoystickId_AfterArgs set_JoystickId
        {
            add
            {
                HookHandler._afterset_JoystickId += value;
                HookHandler.Hookset_JoystickId();
            }
            remove => HookHandler._afterset_JoystickId -= value;
        }

        public static event Delegates.Update_AfterArgs Update
        {
            add
            {
                HookHandler._afterUpdate += value;
                HookHandler.HookUpdate();
            }
            remove => HookHandler._afterUpdate -= value;
        }

        public static event Delegates.SetupAnalogQueries_AfterArgs SetupAnalogQueries
        {
            add
            {
                HookHandler._afterSetupAnalogQueries += value;
                HookHandler.HookSetupAnalogQueries();
            }
            remove => HookHandler._afterSetupAnalogQueries -= value;
        }

        public static event Delegates.SetupButtonQueries_AfterArgs SetupButtonQueries
        {
            add
            {
                HookHandler._afterSetupButtonQueries += value;
                HookHandler.HookSetupButtonQueries();
            }
            remove => HookHandler._afterSetupButtonQueries -= value;
        }

        public static event Delegates.ReadRawButtonState_AfterArgs ReadRawButtonState
        {
            add
            {
                HookHandler._afterReadRawButtonState += value;
                HookHandler.HookReadRawButtonState();
            }
            remove => HookHandler._afterReadRawButtonState -= value;
        }

        public static event Delegates.ReadRawAnalogValue_AfterArgs ReadRawAnalogValue
        {
            add
            {
                HookHandler._afterReadRawAnalogValue += value;
                HookHandler.HookReadRawAnalogValue();
            }
            remove => HookHandler._afterReadRawAnalogValue -= value;
        }

        public static event Delegates.get_IsSupportedOnThisPlatform_AfterArgs get_IsSupportedOnThisPlatform
        {
            add
            {
                HookHandler._afterget_IsSupportedOnThisPlatform += value;
                HookHandler.Hookget_IsSupportedOnThisPlatform();
            }
            remove => HookHandler._afterget_IsSupportedOnThisPlatform -= value;
        }

        public static event Delegates.get_IsKnown_AfterArgs get_IsKnown
        {
            add
            {
                HookHandler._afterget_IsKnown += value;
                HookHandler.Hookget_IsKnown();
            }
            remove => HookHandler._afterget_IsKnown -= value;
        }

        public static event Delegates.get_NumUnknownButtons_AfterArgs get_NumUnknownButtons
        {
            add
            {
                HookHandler._afterget_NumUnknownButtons += value;
                HookHandler.Hookget_NumUnknownButtons();
            }
            remove => HookHandler._afterget_NumUnknownButtons -= value;
        }

        public static event Delegates.get_NumUnknownAnalogs_AfterArgs get_NumUnknownAnalogs
        {
            add
            {
                HookHandler._afterget_NumUnknownAnalogs += value;
                HookHandler.Hookget_NumUnknownAnalogs();
            }
            remove => HookHandler._afterget_NumUnknownAnalogs -= value;
        }
    }

    /// <summary>
    ///     Contains all On Hooks, even those that aren't in the On namespace such as API generated functions and property
    ///     getters/setters
    /// </summary>
    public static class WithOrig
    {
        public static event Delegates.get_JoystickId_WithArgs get_JoystickId
        {
            add => HookEndpointManager.Add<Delegates.get_JoystickId_WithArgs>(
                ReflectionHelper.GetMethodInfo(typeof(UnityInputDevice), "get_JoystickId"), value);
            remove => HookEndpointManager.Remove<Delegates.get_JoystickId_WithArgs>(
                ReflectionHelper.GetMethodInfo(typeof(UnityInputDevice), "get_JoystickId"), value);
        }

        public static event Delegates.set_JoystickId_WithArgs set_JoystickId
        {
            add => HookEndpointManager.Add<Delegates.set_JoystickId_WithArgs>(
                ReflectionHelper.GetMethodInfo(typeof(UnityInputDevice), "set_JoystickId"), value);
            remove => HookEndpointManager.Remove<Delegates.set_JoystickId_WithArgs>(
                ReflectionHelper.GetMethodInfo(typeof(UnityInputDevice), "set_JoystickId"), value);
        }

        public static event Delegates.Update_WithArgs Update
        {
            add => HookEndpointManager.Add<Delegates.Update_WithArgs>(
                ReflectionHelper.GetMethodInfo(typeof(UnityInputDevice), "Update"), value);
            remove => HookEndpointManager.Remove<Delegates.Update_WithArgs>(
                ReflectionHelper.GetMethodInfo(typeof(UnityInputDevice), "Update"), value);
        }

        public static event Delegates.SetupAnalogQueries_WithArgs SetupAnalogQueries
        {
            add => HookEndpointManager.Add<Delegates.SetupAnalogQueries_WithArgs>(
                ReflectionHelper.GetMethodInfo(typeof(UnityInputDevice), "SetupAnalogQueries", false), value);
            remove => HookEndpointManager.Remove<Delegates.SetupAnalogQueries_WithArgs>(
                ReflectionHelper.GetMethodInfo(typeof(UnityInputDevice), "SetupAnalogQueries", false), value);
        }

        public static event Delegates.SetupButtonQueries_WithArgs SetupButtonQueries
        {
            add => HookEndpointManager.Add<Delegates.SetupButtonQueries_WithArgs>(
                ReflectionHelper.GetMethodInfo(typeof(UnityInputDevice), "SetupButtonQueries", false), value);
            remove => HookEndpointManager.Remove<Delegates.SetupButtonQueries_WithArgs>(
                ReflectionHelper.GetMethodInfo(typeof(UnityInputDevice), "SetupButtonQueries", false), value);
        }

        public static event Delegates.ReadRawButtonState_WithArgs ReadRawButtonState
        {
            add => HookEndpointManager.Add<Delegates.ReadRawButtonState_WithArgs>(
                ReflectionHelper.GetMethodInfo(typeof(UnityInputDevice), "ReadRawButtonState"), value);
            remove => HookEndpointManager.Remove<Delegates.ReadRawButtonState_WithArgs>(
                ReflectionHelper.GetMethodInfo(typeof(UnityInputDevice), "ReadRawButtonState"), value);
        }

        public static event Delegates.ReadRawAnalogValue_WithArgs ReadRawAnalogValue
        {
            add => HookEndpointManager.Add<Delegates.ReadRawAnalogValue_WithArgs>(
                ReflectionHelper.GetMethodInfo(typeof(UnityInputDevice), "ReadRawAnalogValue"), value);
            remove => HookEndpointManager.Remove<Delegates.ReadRawAnalogValue_WithArgs>(
                ReflectionHelper.GetMethodInfo(typeof(UnityInputDevice), "ReadRawAnalogValue"), value);
        }

        public static event Delegates.get_IsSupportedOnThisPlatform_WithArgs get_IsSupportedOnThisPlatform
        {
            add => HookEndpointManager.Add<Delegates.get_IsSupportedOnThisPlatform_WithArgs>(
                ReflectionHelper.GetMethodInfo(typeof(UnityInputDevice), "get_IsSupportedOnThisPlatform"), value);
            remove => HookEndpointManager.Remove<Delegates.get_IsSupportedOnThisPlatform_WithArgs>(
                ReflectionHelper.GetMethodInfo(typeof(UnityInputDevice), "get_IsSupportedOnThisPlatform"), value);
        }

        public static event Delegates.get_IsKnown_WithArgs get_IsKnown
        {
            add => HookEndpointManager.Add<Delegates.get_IsKnown_WithArgs>(
                ReflectionHelper.GetMethodInfo(typeof(UnityInputDevice), "get_IsKnown"), value);
            remove => HookEndpointManager.Remove<Delegates.get_IsKnown_WithArgs>(
                ReflectionHelper.GetMethodInfo(typeof(UnityInputDevice), "get_IsKnown"), value);
        }

        public static event Delegates.get_NumUnknownButtons_WithArgs get_NumUnknownButtons
        {
            add => HookEndpointManager.Add<Delegates.get_NumUnknownButtons_WithArgs>(
                ReflectionHelper.GetMethodInfo(typeof(UnityInputDevice), "get_NumUnknownButtons"), value);
            remove => HookEndpointManager.Remove<Delegates.get_NumUnknownButtons_WithArgs>(
                ReflectionHelper.GetMethodInfo(typeof(UnityInputDevice), "get_NumUnknownButtons"), value);
        }

        public static event Delegates.get_NumUnknownAnalogs_WithArgs get_NumUnknownAnalogs
        {
            add => HookEndpointManager.Add<Delegates.get_NumUnknownAnalogs_WithArgs>(
                ReflectionHelper.GetMethodInfo(typeof(UnityInputDevice), "get_NumUnknownAnalogs"), value);
            remove => HookEndpointManager.Remove<Delegates.get_NumUnknownAnalogs_WithArgs>(
                ReflectionHelper.GetMethodInfo(typeof(UnityInputDevice), "get_NumUnknownAnalogs"), value);
        }
    }
}