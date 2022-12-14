using MonoMod.RuntimeDetour;
using MonoMod.RuntimeDetour.HookGen;

namespace HKMirror.Hooks.OnHooks;

/// <summary>
///     Contains different types of On Hooks for OuyaEverywhereDevice class.<br />
///     Contains hooks that aren't generated by monomod, and before and after orig hooks for easier hooking.
/// </summary>
public static class OnOuyaEverywhereDevice
{
    internal static class HookHandler
    {
        private static readonly List<string> HookedList = new();

        internal static void Hookget_DeviceIndex()
        {
            if (!HookedList.Contains("get_DeviceIndex"))
            {
                HookedList.Add("get_DeviceIndex");
                new Hook(ReflectionHelper.GetMethodInfo(typeof(OuyaEverywhereDevice), "get_DeviceIndex"),
                    get_DeviceIndex);
            }
        }

        internal static event Delegates.get_DeviceIndex_BeforeArgs _beforeget_DeviceIndex;
        internal static event Delegates.get_DeviceIndex_AfterArgs _afterget_DeviceIndex;

        private static int get_DeviceIndex(Func<OuyaEverywhereDevice, int> orig, OuyaEverywhereDevice self)
        {
            Delegates.Params_get_DeviceIndex @params = new()
            {
                self = self
            };
            if (_beforeget_DeviceIndex != null)
                foreach (Delegates.get_DeviceIndex_BeforeArgs toInvoke in _beforeget_DeviceIndex.GetInvocationList())
                    try
                    {
                        _beforeget_DeviceIndex?.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }

            self = @params.self;
            var retVal = orig(self);
            if (_afterget_DeviceIndex != null)
                foreach (Delegates.get_DeviceIndex_AfterArgs toInvoke in _afterget_DeviceIndex.GetInvocationList())
                    try
                    {
                        retVal = _afterget_DeviceIndex.Invoke(@params, retVal);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }

            return retVal;
        }

        internal static void Hookset_DeviceIndex()
        {
            if (!HookedList.Contains("set_DeviceIndex"))
            {
                HookedList.Add("set_DeviceIndex");
                new Hook(ReflectionHelper.GetMethodInfo(typeof(OuyaEverywhereDevice), "set_DeviceIndex"),
                    set_DeviceIndex);
            }
        }

        internal static event Delegates.set_DeviceIndex_BeforeArgs _beforeset_DeviceIndex;
        internal static event Delegates.set_DeviceIndex_AfterArgs _afterset_DeviceIndex;

        private static void set_DeviceIndex(Action<OuyaEverywhereDevice, int> orig, OuyaEverywhereDevice self,
            int value)
        {
            Delegates.Params_set_DeviceIndex @params = new()
            {
                self = self, value = value
            };
            if (_beforeset_DeviceIndex != null)
                foreach (Delegates.set_DeviceIndex_BeforeArgs toInvoke in _beforeset_DeviceIndex.GetInvocationList())
                    try
                    {
                        _beforeset_DeviceIndex?.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }

            self = @params.self;
            value = @params.value;
            orig(self, value);
            if (_afterset_DeviceIndex != null)
                foreach (Delegates.set_DeviceIndex_AfterArgs toInvoke in _afterset_DeviceIndex.GetInvocationList())
                    try
                    {
                        _afterset_DeviceIndex.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }
        }

        internal static void HookBeforeAttach()
        {
            if (!HookedList.Contains("BeforeAttach"))
            {
                HookedList.Add("BeforeAttach");
                new Hook(ReflectionHelper.GetMethodInfo(typeof(OuyaEverywhereDevice), "BeforeAttach"), BeforeAttach);
            }
        }

        internal static event Delegates.BeforeAttach_BeforeArgs _beforeBeforeAttach;
        internal static event Delegates.BeforeAttach_AfterArgs _afterBeforeAttach;

        private static void BeforeAttach(Action<OuyaEverywhereDevice> orig, OuyaEverywhereDevice self)
        {
            Delegates.Params_BeforeAttach @params = new()
            {
                self = self
            };
            if (_beforeBeforeAttach != null)
                foreach (Delegates.BeforeAttach_BeforeArgs toInvoke in _beforeBeforeAttach.GetInvocationList())
                    try
                    {
                        _beforeBeforeAttach?.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }

            self = @params.self;
            orig(self);
            if (_afterBeforeAttach != null)
                foreach (Delegates.BeforeAttach_AfterArgs toInvoke in _afterBeforeAttach.GetInvocationList())
                    try
                    {
                        _afterBeforeAttach.Invoke(@params);
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
                new Hook(ReflectionHelper.GetMethodInfo(typeof(OuyaEverywhereDevice), "Update"), Update);
            }
        }

        internal static event Delegates.Update_BeforeArgs _beforeUpdate;
        internal static event Delegates.Update_AfterArgs _afterUpdate;

        private static void Update(Action<OuyaEverywhereDevice, ulong, float> orig, OuyaEverywhereDevice self,
            ulong updateTick, float deltaTime)
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

        internal static void Hookget_IsConnected()
        {
            if (!HookedList.Contains("get_IsConnected"))
            {
                HookedList.Add("get_IsConnected");
                new Hook(ReflectionHelper.GetMethodInfo(typeof(OuyaEverywhereDevice), "get_IsConnected"),
                    get_IsConnected);
            }
        }

        internal static event Delegates.get_IsConnected_BeforeArgs _beforeget_IsConnected;
        internal static event Delegates.get_IsConnected_AfterArgs _afterget_IsConnected;

        private static bool get_IsConnected(Func<OuyaEverywhereDevice, bool> orig, OuyaEverywhereDevice self)
        {
            Delegates.Params_get_IsConnected @params = new()
            {
                self = self
            };
            if (_beforeget_IsConnected != null)
                foreach (Delegates.get_IsConnected_BeforeArgs toInvoke in _beforeget_IsConnected.GetInvocationList())
                    try
                    {
                        _beforeget_IsConnected?.Invoke(@params);
                    }
                    catch (Exception e)
                    {
                        HKMirrorMod.DoLogError(e);
                    }

            self = @params.self;
            var retVal = orig(self);
            if (_afterget_IsConnected != null)
                foreach (Delegates.get_IsConnected_AfterArgs toInvoke in _afterget_IsConnected.GetInvocationList())
                    try
                    {
                        retVal = _afterget_IsConnected.Invoke(@params, retVal);
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
        public delegate void BeforeAttach_AfterArgs(Params_BeforeAttach args);

        public delegate void BeforeAttach_BeforeArgs(Params_BeforeAttach args);

        public delegate void BeforeAttach_WithArgs(Action<OuyaEverywhereDevice> orig, OuyaEverywhereDevice self);

        public delegate int get_DeviceIndex_AfterArgs(Params_get_DeviceIndex args, int ret);

        public delegate void get_DeviceIndex_BeforeArgs(Params_get_DeviceIndex args);

        public delegate int get_DeviceIndex_WithArgs(Func<OuyaEverywhereDevice, int> orig, OuyaEverywhereDevice self);

        public delegate bool get_IsConnected_AfterArgs(Params_get_IsConnected args, bool ret);

        public delegate void get_IsConnected_BeforeArgs(Params_get_IsConnected args);

        public delegate bool get_IsConnected_WithArgs(Func<OuyaEverywhereDevice, bool> orig, OuyaEverywhereDevice self);

        public delegate void set_DeviceIndex_AfterArgs(Params_set_DeviceIndex args);

        public delegate void set_DeviceIndex_BeforeArgs(Params_set_DeviceIndex args);

        public delegate void set_DeviceIndex_WithArgs(Action<OuyaEverywhereDevice, int> orig, OuyaEverywhereDevice self,
            int value);

        public delegate void Update_AfterArgs(Params_Update args);

        public delegate void Update_BeforeArgs(Params_Update args);

        public delegate void Update_WithArgs(Action<OuyaEverywhereDevice, ulong, float> orig, OuyaEverywhereDevice self,
            ulong updateTick, float deltaTime);

        public sealed class Params_get_DeviceIndex
        {
            public OuyaEverywhereDevice self;
        }

        public sealed class Params_set_DeviceIndex
        {
            public OuyaEverywhereDevice self;
            public int value;
        }

        public sealed class Params_BeforeAttach
        {
            public OuyaEverywhereDevice self;
        }

        public sealed class Params_Update
        {
            public float deltaTime;
            public OuyaEverywhereDevice self;
            public ulong updateTick;
        }

        public sealed class Params_get_IsConnected
        {
            public OuyaEverywhereDevice self;
        }
    }

    /// <summary>
    ///     Contains Hooks to that run code before orig(self) is called
    /// </summary>
    public static class BeforeOrig
    {
        public static event Delegates.get_DeviceIndex_BeforeArgs get_DeviceIndex
        {
            add
            {
                HookHandler._beforeget_DeviceIndex += value;
                HookHandler.Hookget_DeviceIndex();
            }
            remove => HookHandler._beforeget_DeviceIndex -= value;
        }

        public static event Delegates.set_DeviceIndex_BeforeArgs set_DeviceIndex
        {
            add
            {
                HookHandler._beforeset_DeviceIndex += value;
                HookHandler.Hookset_DeviceIndex();
            }
            remove => HookHandler._beforeset_DeviceIndex -= value;
        }

        public static event Delegates.BeforeAttach_BeforeArgs BeforeAttach
        {
            add
            {
                HookHandler._beforeBeforeAttach += value;
                HookHandler.HookBeforeAttach();
            }
            remove => HookHandler._beforeBeforeAttach -= value;
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

        public static event Delegates.get_IsConnected_BeforeArgs get_IsConnected
        {
            add
            {
                HookHandler._beforeget_IsConnected += value;
                HookHandler.Hookget_IsConnected();
            }
            remove => HookHandler._beforeget_IsConnected -= value;
        }
    }

    /// <summary>
    ///     Contains Hooks to that run code after orig(self) is called
    /// </summary>
    public static class AfterOrig
    {
        public static event Delegates.get_DeviceIndex_AfterArgs get_DeviceIndex
        {
            add
            {
                HookHandler._afterget_DeviceIndex += value;
                HookHandler.Hookget_DeviceIndex();
            }
            remove => HookHandler._afterget_DeviceIndex -= value;
        }

        public static event Delegates.set_DeviceIndex_AfterArgs set_DeviceIndex
        {
            add
            {
                HookHandler._afterset_DeviceIndex += value;
                HookHandler.Hookset_DeviceIndex();
            }
            remove => HookHandler._afterset_DeviceIndex -= value;
        }

        public static event Delegates.BeforeAttach_AfterArgs BeforeAttach
        {
            add
            {
                HookHandler._afterBeforeAttach += value;
                HookHandler.HookBeforeAttach();
            }
            remove => HookHandler._afterBeforeAttach -= value;
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

        public static event Delegates.get_IsConnected_AfterArgs get_IsConnected
        {
            add
            {
                HookHandler._afterget_IsConnected += value;
                HookHandler.Hookget_IsConnected();
            }
            remove => HookHandler._afterget_IsConnected -= value;
        }
    }

    /// <summary>
    ///     Contains all On Hooks, even those that aren't in the On namespace such as API generated functions and property
    ///     getters/setters
    /// </summary>
    public static class WithOrig
    {
        public static event Delegates.get_DeviceIndex_WithArgs get_DeviceIndex
        {
            add => HookEndpointManager.Add<Delegates.get_DeviceIndex_WithArgs>(
                ReflectionHelper.GetMethodInfo(typeof(OuyaEverywhereDevice), "get_DeviceIndex"), value);
            remove => HookEndpointManager.Remove<Delegates.get_DeviceIndex_WithArgs>(
                ReflectionHelper.GetMethodInfo(typeof(OuyaEverywhereDevice), "get_DeviceIndex"), value);
        }

        public static event Delegates.set_DeviceIndex_WithArgs set_DeviceIndex
        {
            add => HookEndpointManager.Add<Delegates.set_DeviceIndex_WithArgs>(
                ReflectionHelper.GetMethodInfo(typeof(OuyaEverywhereDevice), "set_DeviceIndex"), value);
            remove => HookEndpointManager.Remove<Delegates.set_DeviceIndex_WithArgs>(
                ReflectionHelper.GetMethodInfo(typeof(OuyaEverywhereDevice), "set_DeviceIndex"), value);
        }

        public static event Delegates.BeforeAttach_WithArgs BeforeAttach
        {
            add => HookEndpointManager.Add<Delegates.BeforeAttach_WithArgs>(
                ReflectionHelper.GetMethodInfo(typeof(OuyaEverywhereDevice), "BeforeAttach"), value);
            remove => HookEndpointManager.Remove<Delegates.BeforeAttach_WithArgs>(
                ReflectionHelper.GetMethodInfo(typeof(OuyaEverywhereDevice), "BeforeAttach"), value);
        }

        public static event Delegates.Update_WithArgs Update
        {
            add => HookEndpointManager.Add<Delegates.Update_WithArgs>(
                ReflectionHelper.GetMethodInfo(typeof(OuyaEverywhereDevice), "Update"), value);
            remove => HookEndpointManager.Remove<Delegates.Update_WithArgs>(
                ReflectionHelper.GetMethodInfo(typeof(OuyaEverywhereDevice), "Update"), value);
        }

        public static event Delegates.get_IsConnected_WithArgs get_IsConnected
        {
            add => HookEndpointManager.Add<Delegates.get_IsConnected_WithArgs>(
                ReflectionHelper.GetMethodInfo(typeof(OuyaEverywhereDevice), "get_IsConnected"), value);
            remove => HookEndpointManager.Remove<Delegates.get_IsConnected_WithArgs>(
                ReflectionHelper.GetMethodInfo(typeof(OuyaEverywhereDevice), "get_IsConnected"), value);
        }
    }
}