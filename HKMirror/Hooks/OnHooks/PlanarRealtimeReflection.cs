namespace HKMirror.Hooks.OnHooks;

/// <summary>
///     Contains different types of On Hooks for PlanarRealtimeReflection class.<br />
///     Contains hooks that aren't generated by monomod, and before and after orig hooks for easier hooking.
/// </summary>
public static class OnPlanarRealtimeReflection
{
    internal static class HookHandler
    {
        private static readonly List<string> HookedList = new();

        internal static void HookOnWillRenderObject()
        {
            if (!HookedList.Contains("OnWillRenderObject"))
            {
                HookedList.Add("OnWillRenderObject");
                On.PlanarRealtimeReflection.OnWillRenderObject += OnWillRenderObject;
            }
        }

        internal static event Delegates.OnWillRenderObject_BeforeArgs _beforeOnWillRenderObject;
        internal static event Delegates.OnWillRenderObject_NormalArgs _afterOnWillRenderObject;

        private static void OnWillRenderObject(On.PlanarRealtimeReflection.orig_OnWillRenderObject orig,
            PlanarRealtimeReflection self)
        {
            Delegates.Params_OnWillRenderObject @params = new()
            {
                self = self
            };
            _beforeOnWillRenderObject?.Invoke(@params);
            self = @params.self;
            orig(self);
            if (_afterOnWillRenderObject != null) _afterOnWillRenderObject.Invoke(@params);
        }

        internal static void HookOnDisable()
        {
            if (!HookedList.Contains("OnDisable"))
            {
                HookedList.Add("OnDisable");
                On.PlanarRealtimeReflection.OnDisable += OnDisable;
            }
        }

        internal static event Delegates.OnDisable_BeforeArgs _beforeOnDisable;
        internal static event Delegates.OnDisable_NormalArgs _afterOnDisable;

        private static void OnDisable(On.PlanarRealtimeReflection.orig_OnDisable orig, PlanarRealtimeReflection self)
        {
            Delegates.Params_OnDisable @params = new()
            {
                self = self
            };
            _beforeOnDisable?.Invoke(@params);
            self = @params.self;
            orig(self);
            if (_afterOnDisable != null) _afterOnDisable.Invoke(@params);
        }

        internal static void HookUpdateCameraModes()
        {
            if (!HookedList.Contains("UpdateCameraModes"))
            {
                HookedList.Add("UpdateCameraModes");
                On.PlanarRealtimeReflection.UpdateCameraModes += UpdateCameraModes;
            }
        }

        internal static event Delegates.UpdateCameraModes_BeforeArgs _beforeUpdateCameraModes;
        internal static event Delegates.UpdateCameraModes_NormalArgs _afterUpdateCameraModes;

        private static void UpdateCameraModes(On.PlanarRealtimeReflection.orig_UpdateCameraModes orig,
            PlanarRealtimeReflection self, Camera src, Camera dest)
        {
            Delegates.Params_UpdateCameraModes @params = new()
            {
                self = self, src = src, dest = dest
            };
            _beforeUpdateCameraModes?.Invoke(@params);
            self = @params.self;
            src = @params.src;
            dest = @params.dest;
            orig(self, src, dest);
            if (_afterUpdateCameraModes != null) _afterUpdateCameraModes.Invoke(@params);
        }

        internal static void HookCreateSurfaceObjects()
        {
            if (!HookedList.Contains("CreateSurfaceObjects"))
            {
                HookedList.Add("CreateSurfaceObjects");
                On.PlanarRealtimeReflection.CreateSurfaceObjects += CreateSurfaceObjects;
            }
        }

        internal static event Delegates.CreateSurfaceObjects_BeforeArgs _beforeCreateSurfaceObjects;
        internal static event Delegates.CreateSurfaceObjects_NormalArgs _afterCreateSurfaceObjects;

        private static void CreateSurfaceObjects(On.PlanarRealtimeReflection.orig_CreateSurfaceObjects orig,
            PlanarRealtimeReflection self, Camera currentCamera, out Camera reflectionCamera)
        {
            Delegates.Params_CreateSurfaceObjects @params = new()
            {
                self = self, currentCamera = currentCamera
            };
            _beforeCreateSurfaceObjects?.Invoke(@params);
            self = @params.self;
            currentCamera = @params.currentCamera;
            reflectionCamera = @params.reflectionCamera;
            orig(self, currentCamera, out reflectionCamera);
            if (_afterCreateSurfaceObjects != null) _afterCreateSurfaceObjects.Invoke(@params);
        }

        internal static void Hooksgn()
        {
            if (!HookedList.Contains("sgn"))
            {
                HookedList.Add("sgn");
                On.PlanarRealtimeReflection.sgn += sgn;
            }
        }

        internal static event Delegates.sgn_BeforeArgs _beforesgn;
        internal static event Delegates.sgn_NormalArgs _aftersgn;

        private static float sgn(On.PlanarRealtimeReflection.orig_sgn orig, float a)
        {
            Delegates.Params_sgn @params = new()
            {
                a = a
            };
            _beforesgn?.Invoke(@params);
            a = @params.a;
            var retVal = orig(a);
            if (_aftersgn != null) retVal = _aftersgn.Invoke(@params);

            return retVal;
        }

        internal static void HookCameraSpacePlane()
        {
            if (!HookedList.Contains("CameraSpacePlane"))
            {
                HookedList.Add("CameraSpacePlane");
                On.PlanarRealtimeReflection.CameraSpacePlane += CameraSpacePlane;
            }
        }

        internal static event Delegates.CameraSpacePlane_BeforeArgs _beforeCameraSpacePlane;
        internal static event Delegates.CameraSpacePlane_NormalArgs _afterCameraSpacePlane;

        private static Vector4 CameraSpacePlane(On.PlanarRealtimeReflection.orig_CameraSpacePlane orig,
            PlanarRealtimeReflection self, Camera cam, Vector3 pos, Vector3 normal,
            float sideSign)
        {
            Delegates.Params_CameraSpacePlane @params = new()
            {
                self = self, cam = cam, pos = pos, normal = normal, sideSign = sideSign
            };
            _beforeCameraSpacePlane?.Invoke(@params);
            self = @params.self;
            cam = @params.cam;
            pos = @params.pos;
            normal = @params.normal;
            sideSign = @params.sideSign;
            var retVal = orig(self, cam, pos, normal, sideSign);
            if (_afterCameraSpacePlane != null) retVal = _afterCameraSpacePlane.Invoke(@params);

            return retVal;
        }

        internal static void HookCalculateObliqueMatrix()
        {
            if (!HookedList.Contains("CalculateObliqueMatrix"))
            {
                HookedList.Add("CalculateObliqueMatrix");
                On.PlanarRealtimeReflection.CalculateObliqueMatrix += CalculateObliqueMatrix;
            }
        }

        internal static event Delegates.CalculateObliqueMatrix_BeforeArgs _beforeCalculateObliqueMatrix;
        internal static event Delegates.CalculateObliqueMatrix_NormalArgs _afterCalculateObliqueMatrix;

        private static void CalculateObliqueMatrix(On.PlanarRealtimeReflection.orig_CalculateObliqueMatrix orig,
            ref Matrix4x4 projection, Vector4 clipPlane)
        {
            Delegates.Params_CalculateObliqueMatrix @params = new()
            {
                projection = projection, clipPlane = clipPlane
            };
            _beforeCalculateObliqueMatrix?.Invoke(@params);
            projection = @params.projection;
            clipPlane = @params.clipPlane;
            orig(ref projection, clipPlane);
            if (_afterCalculateObliqueMatrix != null) _afterCalculateObliqueMatrix.Invoke(@params);
        }

        internal static void HookCalculateReflectionMatrix()
        {
            if (!HookedList.Contains("CalculateReflectionMatrix"))
            {
                HookedList.Add("CalculateReflectionMatrix");
                On.PlanarRealtimeReflection.CalculateReflectionMatrix += CalculateReflectionMatrix;
            }
        }

        internal static event Delegates.CalculateReflectionMatrix_BeforeArgs _beforeCalculateReflectionMatrix;
        internal static event Delegates.CalculateReflectionMatrix_NormalArgs _afterCalculateReflectionMatrix;

        private static void CalculateReflectionMatrix(On.PlanarRealtimeReflection.orig_CalculateReflectionMatrix orig,
            ref Matrix4x4 reflectionMat, Vector4 plane)
        {
            Delegates.Params_CalculateReflectionMatrix @params = new()
            {
                reflectionMat = reflectionMat, plane = plane
            };
            _beforeCalculateReflectionMatrix?.Invoke(@params);
            reflectionMat = @params.reflectionMat;
            plane = @params.plane;
            orig(ref reflectionMat, plane);
            if (_afterCalculateReflectionMatrix != null) _afterCalculateReflectionMatrix.Invoke(@params);
        }
    }

    /// <summary>
    ///     Contains necessary information to create Hooks. Does not contain any hooks
    /// </summary>
    public static class Delegates
    {
        public delegate void CalculateObliqueMatrix_BeforeArgs(Params_CalculateObliqueMatrix args);

        public delegate void CalculateObliqueMatrix_NormalArgs(Params_CalculateObliqueMatrix args);

        public delegate void CalculateReflectionMatrix_BeforeArgs(Params_CalculateReflectionMatrix args);

        public delegate void CalculateReflectionMatrix_NormalArgs(Params_CalculateReflectionMatrix args);

        public delegate void CameraSpacePlane_BeforeArgs(Params_CameraSpacePlane args);

        public delegate Vector4 CameraSpacePlane_NormalArgs(Params_CameraSpacePlane args);

        public delegate void CreateSurfaceObjects_BeforeArgs(Params_CreateSurfaceObjects args);

        public delegate void CreateSurfaceObjects_NormalArgs(Params_CreateSurfaceObjects args);

        public delegate void OnDisable_BeforeArgs(Params_OnDisable args);

        public delegate void OnDisable_NormalArgs(Params_OnDisable args);

        public delegate void OnWillRenderObject_BeforeArgs(Params_OnWillRenderObject args);

        public delegate void OnWillRenderObject_NormalArgs(Params_OnWillRenderObject args);

        public delegate void sgn_BeforeArgs(Params_sgn args);

        public delegate float sgn_NormalArgs(Params_sgn args);

        public delegate void UpdateCameraModes_BeforeArgs(Params_UpdateCameraModes args);

        public delegate void UpdateCameraModes_NormalArgs(Params_UpdateCameraModes args);

        public sealed class Params_OnWillRenderObject
        {
            public PlanarRealtimeReflection self;
        }

        public sealed class Params_OnDisable
        {
            public PlanarRealtimeReflection self;
        }

        public sealed class Params_UpdateCameraModes
        {
            public Camera dest;
            public PlanarRealtimeReflection self;
            public Camera src;
        }

        public sealed class Params_CreateSurfaceObjects
        {
            public Camera currentCamera;
            public Camera reflectionCamera;
            public PlanarRealtimeReflection self;
        }

        public sealed class Params_sgn
        {
            public float a;
        }

        public sealed class Params_CameraSpacePlane
        {
            public Camera cam;
            public Vector3 normal;
            public Vector3 pos;
            public PlanarRealtimeReflection self;
            public float sideSign;
        }

        public sealed class Params_CalculateObliqueMatrix
        {
            public Vector4 clipPlane;
            public Matrix4x4 projection;
        }

        public sealed class Params_CalculateReflectionMatrix
        {
            public Vector4 plane;
            public Matrix4x4 reflectionMat;
        }
    }

    /// <summary>
    ///     Contains Hooks to that run code before orig(self) is called
    /// </summary>
    public static class BeforeOrig
    {
        public static event Delegates.OnWillRenderObject_BeforeArgs OnWillRenderObject
        {
            add
            {
                HookHandler._beforeOnWillRenderObject += value;
                HookHandler.HookOnWillRenderObject();
            }
            remove => HookHandler._beforeOnWillRenderObject -= value;
        }

        public static event Delegates.OnDisable_BeforeArgs OnDisable
        {
            add
            {
                HookHandler._beforeOnDisable += value;
                HookHandler.HookOnDisable();
            }
            remove => HookHandler._beforeOnDisable -= value;
        }

        public static event Delegates.UpdateCameraModes_BeforeArgs UpdateCameraModes
        {
            add
            {
                HookHandler._beforeUpdateCameraModes += value;
                HookHandler.HookUpdateCameraModes();
            }
            remove => HookHandler._beforeUpdateCameraModes -= value;
        }

        public static event Delegates.CreateSurfaceObjects_BeforeArgs CreateSurfaceObjects
        {
            add
            {
                HookHandler._beforeCreateSurfaceObjects += value;
                HookHandler.HookCreateSurfaceObjects();
            }
            remove => HookHandler._beforeCreateSurfaceObjects -= value;
        }

        public static event Delegates.sgn_BeforeArgs sgn
        {
            add
            {
                HookHandler._beforesgn += value;
                HookHandler.Hooksgn();
            }
            remove => HookHandler._beforesgn -= value;
        }

        public static event Delegates.CameraSpacePlane_BeforeArgs CameraSpacePlane
        {
            add
            {
                HookHandler._beforeCameraSpacePlane += value;
                HookHandler.HookCameraSpacePlane();
            }
            remove => HookHandler._beforeCameraSpacePlane -= value;
        }

        public static event Delegates.CalculateObliqueMatrix_BeforeArgs CalculateObliqueMatrix
        {
            add
            {
                HookHandler._beforeCalculateObliqueMatrix += value;
                HookHandler.HookCalculateObliqueMatrix();
            }
            remove => HookHandler._beforeCalculateObliqueMatrix -= value;
        }

        public static event Delegates.CalculateReflectionMatrix_BeforeArgs CalculateReflectionMatrix
        {
            add
            {
                HookHandler._beforeCalculateReflectionMatrix += value;
                HookHandler.HookCalculateReflectionMatrix();
            }
            remove => HookHandler._beforeCalculateReflectionMatrix -= value;
        }
    }

    /// <summary>
    ///     Contains Hooks to that run code after orig(self) is called
    /// </summary>
    public static class AfterOrig
    {
        public static event Delegates.OnWillRenderObject_NormalArgs OnWillRenderObject
        {
            add
            {
                HookHandler._afterOnWillRenderObject += value;
                HookHandler.HookOnWillRenderObject();
            }
            remove => HookHandler._afterOnWillRenderObject -= value;
        }

        public static event Delegates.OnDisable_NormalArgs OnDisable
        {
            add
            {
                HookHandler._afterOnDisable += value;
                HookHandler.HookOnDisable();
            }
            remove => HookHandler._afterOnDisable -= value;
        }

        public static event Delegates.UpdateCameraModes_NormalArgs UpdateCameraModes
        {
            add
            {
                HookHandler._afterUpdateCameraModes += value;
                HookHandler.HookUpdateCameraModes();
            }
            remove => HookHandler._afterUpdateCameraModes -= value;
        }

        public static event Delegates.CreateSurfaceObjects_NormalArgs CreateSurfaceObjects
        {
            add
            {
                HookHandler._afterCreateSurfaceObjects += value;
                HookHandler.HookCreateSurfaceObjects();
            }
            remove => HookHandler._afterCreateSurfaceObjects -= value;
        }

        public static event Delegates.sgn_NormalArgs sgn
        {
            add
            {
                HookHandler._aftersgn += value;
                HookHandler.Hooksgn();
            }
            remove => HookHandler._aftersgn -= value;
        }

        public static event Delegates.CameraSpacePlane_NormalArgs CameraSpacePlane
        {
            add
            {
                HookHandler._afterCameraSpacePlane += value;
                HookHandler.HookCameraSpacePlane();
            }
            remove => HookHandler._afterCameraSpacePlane -= value;
        }

        public static event Delegates.CalculateObliqueMatrix_NormalArgs CalculateObliqueMatrix
        {
            add
            {
                HookHandler._afterCalculateObliqueMatrix += value;
                HookHandler.HookCalculateObliqueMatrix();
            }
            remove => HookHandler._afterCalculateObliqueMatrix -= value;
        }

        public static event Delegates.CalculateReflectionMatrix_NormalArgs CalculateReflectionMatrix
        {
            add
            {
                HookHandler._afterCalculateReflectionMatrix += value;
                HookHandler.HookCalculateReflectionMatrix();
            }
            remove => HookHandler._afterCalculateReflectionMatrix -= value;
        }
    }

    /// <summary>
    ///     Contains all On Hooks, even those that aren't in the On namespace such as API generated functions and property
    ///     getters/setters
    /// </summary>
    public static class WithOrig
    {
        public static event On.PlanarRealtimeReflection.hook_OnWillRenderObject OnWillRenderObject
        {
            add => On.PlanarRealtimeReflection.OnWillRenderObject += value;
            remove => On.PlanarRealtimeReflection.OnWillRenderObject -= value;
        }

        public static event On.PlanarRealtimeReflection.hook_OnDisable OnDisable
        {
            add => On.PlanarRealtimeReflection.OnDisable += value;
            remove => On.PlanarRealtimeReflection.OnDisable -= value;
        }

        public static event On.PlanarRealtimeReflection.hook_UpdateCameraModes UpdateCameraModes
        {
            add => On.PlanarRealtimeReflection.UpdateCameraModes += value;
            remove => On.PlanarRealtimeReflection.UpdateCameraModes -= value;
        }

        public static event On.PlanarRealtimeReflection.hook_CreateSurfaceObjects CreateSurfaceObjects
        {
            add => On.PlanarRealtimeReflection.CreateSurfaceObjects += value;
            remove => On.PlanarRealtimeReflection.CreateSurfaceObjects -= value;
        }

        public static event On.PlanarRealtimeReflection.hook_sgn sgn
        {
            add => On.PlanarRealtimeReflection.sgn += value;
            remove => On.PlanarRealtimeReflection.sgn -= value;
        }

        public static event On.PlanarRealtimeReflection.hook_CameraSpacePlane CameraSpacePlane
        {
            add => On.PlanarRealtimeReflection.CameraSpacePlane += value;
            remove => On.PlanarRealtimeReflection.CameraSpacePlane -= value;
        }

        public static event On.PlanarRealtimeReflection.hook_CalculateObliqueMatrix CalculateObliqueMatrix
        {
            add => On.PlanarRealtimeReflection.CalculateObliqueMatrix += value;
            remove => On.PlanarRealtimeReflection.CalculateObliqueMatrix -= value;
        }

        public static event On.PlanarRealtimeReflection.hook_CalculateReflectionMatrix CalculateReflectionMatrix
        {
            add => On.PlanarRealtimeReflection.CalculateReflectionMatrix += value;
            remove => On.PlanarRealtimeReflection.CalculateReflectionMatrix -= value;
        }
    }
}