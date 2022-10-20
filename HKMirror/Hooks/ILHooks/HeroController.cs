using MonoMod.RuntimeDetour.HookGen;

namespace HKMirror.Hooks.ILHooks;

/// <summary>
///     Contains all correct IL Hooks for HeroController.<br />
///     Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
///     Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILHeroController
{
    public static event ILContext.Manipulator get_fallTimer
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(HeroController), "get_fallTimer"),
            value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(HeroController), "get_fallTimer"),
            value);
    }

    public static event ILContext.Manipulator set_fallTimer
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(HeroController), "set_fallTimer"),
            value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(HeroController), "set_fallTimer"),
            value);
    }

    public static event ILContext.Manipulator get_geoCounter
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(HeroController), "get_geoCounter"),
            value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(HeroController), "get_geoCounter"),
            value);
    }

    public static event ILContext.Manipulator set_geoCounter
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(HeroController), "set_geoCounter"),
            value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(HeroController), "set_geoCounter"),
            value);
    }

    public static event ILContext.Manipulator get_proxyFSM
    {
        add =>
            HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(HeroController), "get_proxyFSM"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(HeroController), "get_proxyFSM"),
            value);
    }

    public static event ILContext.Manipulator set_proxyFSM
    {
        add =>
            HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(HeroController), "set_proxyFSM"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(HeroController), "set_proxyFSM"),
            value);
    }

    public static event ILContext.Manipulator get_sceneEntryGate
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(HeroController), "get_sceneEntryGate"),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(HeroController), "get_sceneEntryGate"), value);
    }

    public static event ILContext.Manipulator set_sceneEntryGate
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(HeroController), "set_sceneEntryGate"),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(HeroController), "set_sceneEntryGate"), value);
    }

    public static event ILContext.Manipulator get_IsDreamReturning
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(HeroController), "get_IsDreamReturning"), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(HeroController), "get_IsDreamReturning"), value);
    }

    public static event ILContext.Manipulator get_instance
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(HeroController), "get_instance", false),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(HeroController), "get_instance", false), value);
    }

    public static event ILContext.Manipulator get_SilentInstance
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(HeroController), "get_SilentInstance", false), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(HeroController), "get_SilentInstance", false), value);
    }

    public static event ILContext.Manipulator get_UnsafeInstance
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(HeroController), "get_UnsafeInstance", false), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(HeroController), "get_UnsafeInstance", false), value);
    }

    public static event ILContext.Manipulator Awake
    {
        add => IL.HeroController.Awake += value;
        remove => IL.HeroController.Awake -= value;
    }

    public static event ILContext.Manipulator Start
    {
        add => IL.HeroController.Start += value;
        remove => IL.HeroController.Start -= value;
    }

    public static event ILContext.Manipulator SceneInit
    {
        add => IL.HeroController.SceneInit += value;
        remove => IL.HeroController.SceneInit -= value;
    }

    public static event ILContext.Manipulator Update
    {
        add => IL.HeroController.Update += value;
        remove => IL.HeroController.Update -= value;
    }

    public static event ILContext.Manipulator FixedUpdate
    {
        add => IL.HeroController.FixedUpdate += value;
        remove => IL.HeroController.FixedUpdate -= value;
    }

    public static event ILContext.Manipulator Update10
    {
        add => IL.HeroController.Update10 += value;
        remove => IL.HeroController.Update10 -= value;
    }

    public static event ILContext.Manipulator OnLevelUnload
    {
        add => IL.HeroController.OnLevelUnload += value;
        remove => IL.HeroController.OnLevelUnload -= value;
    }

    public static event ILContext.Manipulator OnDisable
    {
        add => IL.HeroController.OnDisable += value;
        remove => IL.HeroController.OnDisable -= value;
    }

    public static event ILContext.Manipulator Move
    {
        add => IL.HeroController.Move += value;
        remove => IL.HeroController.Move -= value;
    }

    public static event ILContext.Manipulator Jump
    {
        add => IL.HeroController.Jump += value;
        remove => IL.HeroController.Jump -= value;
    }

    public static event ILContext.Manipulator DoubleJump
    {
        add => IL.HeroController.DoubleJump += value;
        remove => IL.HeroController.DoubleJump -= value;
    }

    public static event ILContext.Manipulator Attack
    {
        add => IL.HeroController.Attack += value;
        remove => IL.HeroController.Attack -= value;
    }

    public static event ILContext.Manipulator Dash
    {
        add => IL.HeroController.Dash += value;
        remove => IL.HeroController.Dash -= value;
    }

    public static event ILContext.Manipulator BackDash
    {
        add => IL.HeroController.BackDash += value;
        remove => IL.HeroController.BackDash -= value;
    }

    public static event ILContext.Manipulator ShadowDash
    {
        add => IL.HeroController.ShadowDash += value;
        remove => IL.HeroController.ShadowDash -= value;
    }

    public static event ILContext.Manipulator SuperDash
    {
        add => IL.HeroController.SuperDash += value;
        remove => IL.HeroController.SuperDash -= value;
    }

    public static event ILContext.Manipulator FaceRight
    {
        add => IL.HeroController.FaceRight += value;
        remove => IL.HeroController.FaceRight -= value;
    }

    public static event ILContext.Manipulator FaceLeft
    {
        add => IL.HeroController.FaceLeft += value;
        remove => IL.HeroController.FaceLeft -= value;
    }

    public static event ILContext.Manipulator StartMPDrain
    {
        add => IL.HeroController.StartMPDrain += value;
        remove => IL.HeroController.StartMPDrain -= value;
    }

    public static event ILContext.Manipulator StopMPDrain
    {
        add => IL.HeroController.StopMPDrain += value;
        remove => IL.HeroController.StopMPDrain -= value;
    }

    public static event ILContext.Manipulator SetBackOnGround
    {
        add => IL.HeroController.SetBackOnGround += value;
        remove => IL.HeroController.SetBackOnGround -= value;
    }

    public static event ILContext.Manipulator SetStartWithWallslide
    {
        add => IL.HeroController.SetStartWithWallslide += value;
        remove => IL.HeroController.SetStartWithWallslide -= value;
    }

    public static event ILContext.Manipulator SetStartWithJump
    {
        add => IL.HeroController.SetStartWithJump += value;
        remove => IL.HeroController.SetStartWithJump -= value;
    }

    public static event ILContext.Manipulator SetStartWithFullJump
    {
        add => IL.HeroController.SetStartWithFullJump += value;
        remove => IL.HeroController.SetStartWithFullJump -= value;
    }

    public static event ILContext.Manipulator SetStartWithDash
    {
        add => IL.HeroController.SetStartWithDash += value;
        remove => IL.HeroController.SetStartWithDash -= value;
    }

    public static event ILContext.Manipulator SetStartWithAttack
    {
        add => IL.HeroController.SetStartWithAttack += value;
        remove => IL.HeroController.SetStartWithAttack -= value;
    }

    public static event ILContext.Manipulator SetSuperDashExit
    {
        add => IL.HeroController.SetSuperDashExit += value;
        remove => IL.HeroController.SetSuperDashExit -= value;
    }

    public static event ILContext.Manipulator SetQuakeExit
    {
        add => IL.HeroController.SetQuakeExit += value;
        remove => IL.HeroController.SetQuakeExit -= value;
    }

    public static event ILContext.Manipulator SetTakeNoDamage
    {
        add => IL.HeroController.SetTakeNoDamage += value;
        remove => IL.HeroController.SetTakeNoDamage -= value;
    }

    public static event ILContext.Manipulator EndTakeNoDamage
    {
        add => IL.HeroController.EndTakeNoDamage += value;
        remove => IL.HeroController.EndTakeNoDamage -= value;
    }

    public static event ILContext.Manipulator SetHeroParent
    {
        add => IL.HeroController.SetHeroParent += value;
        remove => IL.HeroController.SetHeroParent -= value;
    }

    public static event ILContext.Manipulator IsSwimming
    {
        add => IL.HeroController.IsSwimming += value;
        remove => IL.HeroController.IsSwimming -= value;
    }

    public static event ILContext.Manipulator NotSwimming
    {
        add => IL.HeroController.NotSwimming += value;
        remove => IL.HeroController.NotSwimming -= value;
    }

    public static event ILContext.Manipulator EnableRenderer
    {
        add => IL.HeroController.EnableRenderer += value;
        remove => IL.HeroController.EnableRenderer -= value;
    }

    public static event ILContext.Manipulator ResetAirMoves
    {
        add => IL.HeroController.ResetAirMoves += value;
        remove => IL.HeroController.ResetAirMoves -= value;
    }

    public static event ILContext.Manipulator SetConveyorSpeed
    {
        add => IL.HeroController.SetConveyorSpeed += value;
        remove => IL.HeroController.SetConveyorSpeed -= value;
    }

    public static event ILContext.Manipulator SetConveyorSpeedV
    {
        add => IL.HeroController.SetConveyorSpeedV += value;
        remove => IL.HeroController.SetConveyorSpeedV -= value;
    }

    public static event ILContext.Manipulator EnterWithoutInput
    {
        add => IL.HeroController.EnterWithoutInput += value;
        remove => IL.HeroController.EnterWithoutInput -= value;
    }

    public static event ILContext.Manipulator SetDarkness
    {
        add => IL.HeroController.SetDarkness += value;
        remove => IL.HeroController.SetDarkness -= value;
    }

    public static event ILContext.Manipulator CancelHeroJump
    {
        add => IL.HeroController.CancelHeroJump += value;
        remove => IL.HeroController.CancelHeroJump -= value;
    }

    public static event ILContext.Manipulator CharmUpdate
    {
        add => IL.HeroController.CharmUpdate += value;
        remove => IL.HeroController.CharmUpdate -= value;
    }

    public static event ILContext.Manipulator checkEnvironment
    {
        add => IL.HeroController.checkEnvironment += value;
        remove => IL.HeroController.checkEnvironment -= value;
    }

    public static event ILContext.Manipulator SetBenchRespawn
    {
        add => IL.HeroController.SetBenchRespawn += value;
        remove => IL.HeroController.SetBenchRespawn -= value;
    }

    public static event ILContext.Manipulator SetHazardRespawn
    {
        add => IL.HeroController.SetHazardRespawn += value;
        remove => IL.HeroController.SetHazardRespawn -= value;
    }

    public static event ILContext.Manipulator AddGeo
    {
        add => IL.HeroController.AddGeo += value;
        remove => IL.HeroController.AddGeo -= value;
    }

    public static event ILContext.Manipulator ToZero
    {
        add => IL.HeroController.ToZero += value;
        remove => IL.HeroController.ToZero -= value;
    }

    public static event ILContext.Manipulator AddGeoQuietly
    {
        add => IL.HeroController.AddGeoQuietly += value;
        remove => IL.HeroController.AddGeoQuietly -= value;
    }

    public static event ILContext.Manipulator AddGeoToCounter
    {
        add => IL.HeroController.AddGeoToCounter += value;
        remove => IL.HeroController.AddGeoToCounter -= value;
    }

    public static event ILContext.Manipulator TakeGeo
    {
        add => IL.HeroController.TakeGeo += value;
        remove => IL.HeroController.TakeGeo -= value;
    }

    public static event ILContext.Manipulator UpdateGeo
    {
        add => IL.HeroController.UpdateGeo += value;
        remove => IL.HeroController.UpdateGeo -= value;
    }

    public static event ILContext.Manipulator CanInput
    {
        add => IL.HeroController.CanInput += value;
        remove => IL.HeroController.CanInput -= value;
    }

    public static event ILContext.Manipulator CanTalk
    {
        add => IL.HeroController.CanTalk += value;
        remove => IL.HeroController.CanTalk -= value;
    }

    public static event ILContext.Manipulator FlipSprite
    {
        add => IL.HeroController.FlipSprite += value;
        remove => IL.HeroController.FlipSprite -= value;
    }

    public static event ILContext.Manipulator NailParry
    {
        add => IL.HeroController.NailParry += value;
        remove => IL.HeroController.NailParry -= value;
    }

    public static event ILContext.Manipulator NailParryRecover
    {
        add => IL.HeroController.NailParryRecover += value;
        remove => IL.HeroController.NailParryRecover -= value;
    }

    public static event ILContext.Manipulator QuakeInvuln
    {
        add => IL.HeroController.QuakeInvuln += value;
        remove => IL.HeroController.QuakeInvuln -= value;
    }

    public static event ILContext.Manipulator CancelParryInvuln
    {
        add => IL.HeroController.CancelParryInvuln += value;
        remove => IL.HeroController.CancelParryInvuln -= value;
    }

    public static event ILContext.Manipulator CycloneInvuln
    {
        add => IL.HeroController.CycloneInvuln += value;
        remove => IL.HeroController.CycloneInvuln -= value;
    }

    public static event ILContext.Manipulator SetWieldingLantern
    {
        add => IL.HeroController.SetWieldingLantern += value;
        remove => IL.HeroController.SetWieldingLantern -= value;
    }

    public static event ILContext.Manipulator TakeDamage
    {
        add => IL.HeroController.TakeDamage += value;
        remove => IL.HeroController.TakeDamage -= value;
    }

    public static event ILContext.Manipulator GetEntryGateName
    {
        add => IL.HeroController.GetEntryGateName += value;
        remove => IL.HeroController.GetEntryGateName -= value;
    }

    public static event ILContext.Manipulator AddMPCharge
    {
        add => IL.HeroController.AddMPCharge += value;
        remove => IL.HeroController.AddMPCharge -= value;
    }

    public static event ILContext.Manipulator SoulGain
    {
        add => IL.HeroController.SoulGain += value;
        remove => IL.HeroController.SoulGain -= value;
    }

    public static event ILContext.Manipulator AddMPChargeSpa
    {
        add => IL.HeroController.AddMPChargeSpa += value;
        remove => IL.HeroController.AddMPChargeSpa -= value;
    }

    public static event ILContext.Manipulator TryAddMPChargeSpa
    {
        add => IL.HeroController.TryAddMPChargeSpa += value;
        remove => IL.HeroController.TryAddMPChargeSpa -= value;
    }

    public static event ILContext.Manipulator SetMPCharge
    {
        add => IL.HeroController.SetMPCharge += value;
        remove => IL.HeroController.SetMPCharge -= value;
    }

    public static event ILContext.Manipulator TakeMP
    {
        add => IL.HeroController.TakeMP += value;
        remove => IL.HeroController.TakeMP -= value;
    }

    public static event ILContext.Manipulator TakeMPQuick
    {
        add => IL.HeroController.TakeMPQuick += value;
        remove => IL.HeroController.TakeMPQuick -= value;
    }

    public static event ILContext.Manipulator TakeReserveMP
    {
        add => IL.HeroController.TakeReserveMP += value;
        remove => IL.HeroController.TakeReserveMP -= value;
    }

    public static event ILContext.Manipulator AddHealth
    {
        add => IL.HeroController.AddHealth += value;
        remove => IL.HeroController.AddHealth -= value;
    }

    public static event ILContext.Manipulator TakeHealth
    {
        add => IL.HeroController.TakeHealth += value;
        remove => IL.HeroController.TakeHealth -= value;
    }

    public static event ILContext.Manipulator MaxHealth
    {
        add => IL.HeroController.MaxHealth += value;
        remove => IL.HeroController.MaxHealth -= value;
    }

    public static event ILContext.Manipulator MaxHealthKeepBlue
    {
        add => IL.HeroController.MaxHealthKeepBlue += value;
        remove => IL.HeroController.MaxHealthKeepBlue -= value;
    }

    public static event ILContext.Manipulator AddToMaxHealth
    {
        add => IL.HeroController.AddToMaxHealth += value;
        remove => IL.HeroController.AddToMaxHealth -= value;
    }

    public static event ILContext.Manipulator ClearMP
    {
        add => IL.HeroController.ClearMP += value;
        remove => IL.HeroController.ClearMP -= value;
    }

    public static event ILContext.Manipulator ClearMPSendEvents
    {
        add => IL.HeroController.ClearMPSendEvents += value;
        remove => IL.HeroController.ClearMPSendEvents -= value;
    }

    public static event ILContext.Manipulator AddToMaxMPReserve
    {
        add => IL.HeroController.AddToMaxMPReserve += value;
        remove => IL.HeroController.AddToMaxMPReserve -= value;
    }

    public static event ILContext.Manipulator Bounce
    {
        add => IL.HeroController.Bounce += value;
        remove => IL.HeroController.Bounce -= value;
    }

    public static event ILContext.Manipulator BounceHigh
    {
        add => IL.HeroController.BounceHigh += value;
        remove => IL.HeroController.BounceHigh -= value;
    }

    public static event ILContext.Manipulator ShroomBounce
    {
        add => IL.HeroController.ShroomBounce += value;
        remove => IL.HeroController.ShroomBounce -= value;
    }

    public static event ILContext.Manipulator RecoilLeft
    {
        add => IL.HeroController.RecoilLeft += value;
        remove => IL.HeroController.RecoilLeft -= value;
    }

    public static event ILContext.Manipulator RecoilRight
    {
        add => IL.HeroController.RecoilRight += value;
        remove => IL.HeroController.RecoilRight -= value;
    }

    public static event ILContext.Manipulator RecoilRightLong
    {
        add => IL.HeroController.RecoilRightLong += value;
        remove => IL.HeroController.RecoilRightLong -= value;
    }

    public static event ILContext.Manipulator RecoilLeftLong
    {
        add => IL.HeroController.RecoilLeftLong += value;
        remove => IL.HeroController.RecoilLeftLong -= value;
    }

    public static event ILContext.Manipulator RecoilDown
    {
        add => IL.HeroController.RecoilDown += value;
        remove => IL.HeroController.RecoilDown -= value;
    }

    public static event ILContext.Manipulator ForceHardLanding
    {
        add => IL.HeroController.ForceHardLanding += value;
        remove => IL.HeroController.ForceHardLanding -= value;
    }

    public static event ILContext.Manipulator EnterSceneDreamGate
    {
        add => IL.HeroController.EnterSceneDreamGate += value;
        remove => IL.HeroController.EnterSceneDreamGate -= value;
    }

    public static event ILContext.Manipulator EnterScene
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(HeroController), "EnterScene").GetStateMachineTarget(), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(HeroController), "EnterScene").GetStateMachineTarget(), value);
    }

    public static event ILContext.Manipulator LeaveScene
    {
        add => IL.HeroController.LeaveScene += value;
        remove => IL.HeroController.LeaveScene -= value;
    }

    public static event ILContext.Manipulator BetaLeave
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(HeroController), "BetaLeave").GetStateMachineTarget(), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(HeroController), "BetaLeave").GetStateMachineTarget(), value);
    }

    public static event ILContext.Manipulator BetaReturn
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(HeroController), "BetaReturn").GetStateMachineTarget(), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(HeroController), "BetaReturn").GetStateMachineTarget(), value);
    }

    public static event ILContext.Manipulator Respawn
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(HeroController), "Respawn").GetStateMachineTarget(), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(HeroController), "Respawn").GetStateMachineTarget(), value);
    }

    public static event ILContext.Manipulator HazardRespawn
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(HeroController), "HazardRespawn").GetStateMachineTarget(), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(HeroController), "HazardRespawn").GetStateMachineTarget(), value);
    }

    public static event ILContext.Manipulator StartCyclone
    {
        add => IL.HeroController.StartCyclone += value;
        remove => IL.HeroController.StartCyclone -= value;
    }

    public static event ILContext.Manipulator EndCyclone
    {
        add => IL.HeroController.EndCyclone += value;
        remove => IL.HeroController.EndCyclone -= value;
    }

    public static event ILContext.Manipulator GetState
    {
        add => IL.HeroController.GetState += value;
        remove => IL.HeroController.GetState -= value;
    }

    public static event ILContext.Manipulator GetCState
    {
        add => IL.HeroController.GetCState += value;
        remove => IL.HeroController.GetCState -= value;
    }

    public static event ILContext.Manipulator SetCState
    {
        add => IL.HeroController.SetCState += value;
        remove => IL.HeroController.SetCState -= value;
    }

    public static event ILContext.Manipulator ResetHardLandingTimer
    {
        add => IL.HeroController.ResetHardLandingTimer += value;
        remove => IL.HeroController.ResetHardLandingTimer -= value;
    }

    public static event ILContext.Manipulator CancelSuperDash
    {
        add => IL.HeroController.CancelSuperDash += value;
        remove => IL.HeroController.CancelSuperDash -= value;
    }

    public static event ILContext.Manipulator RelinquishControlNotVelocity
    {
        add => IL.HeroController.RelinquishControlNotVelocity += value;
        remove => IL.HeroController.RelinquishControlNotVelocity -= value;
    }

    public static event ILContext.Manipulator RelinquishControl
    {
        add => IL.HeroController.RelinquishControl += value;
        remove => IL.HeroController.RelinquishControl -= value;
    }

    public static event ILContext.Manipulator RegainControl
    {
        add => IL.HeroController.RegainControl += value;
        remove => IL.HeroController.RegainControl -= value;
    }

    public static event ILContext.Manipulator PreventCastByDialogueEnd
    {
        add => IL.HeroController.PreventCastByDialogueEnd += value;
        remove => IL.HeroController.PreventCastByDialogueEnd -= value;
    }

    public static event ILContext.Manipulator CanCast
    {
        add => IL.HeroController.CanCast += value;
        remove => IL.HeroController.CanCast -= value;
    }

    public static event ILContext.Manipulator CanFocus
    {
        add => IL.HeroController.CanFocus += value;
        remove => IL.HeroController.CanFocus -= value;
    }

    public static event ILContext.Manipulator CanNailArt
    {
        add => IL.HeroController.CanNailArt += value;
        remove => IL.HeroController.CanNailArt -= value;
    }

    public static event ILContext.Manipulator CanQuickMap
    {
        add => IL.HeroController.CanQuickMap += value;
        remove => IL.HeroController.CanQuickMap -= value;
    }

    public static event ILContext.Manipulator CanInspect
    {
        add => IL.HeroController.CanInspect += value;
        remove => IL.HeroController.CanInspect -= value;
    }

    public static event ILContext.Manipulator CanBackDash
    {
        add => IL.HeroController.CanBackDash += value;
        remove => IL.HeroController.CanBackDash -= value;
    }

    public static event ILContext.Manipulator CanSuperDash
    {
        add => IL.HeroController.CanSuperDash += value;
        remove => IL.HeroController.CanSuperDash -= value;
    }

    public static event ILContext.Manipulator CanDreamNail
    {
        add => IL.HeroController.CanDreamNail += value;
        remove => IL.HeroController.CanDreamNail -= value;
    }

    public static event ILContext.Manipulator CanDreamGate
    {
        add => IL.HeroController.CanDreamGate += value;
        remove => IL.HeroController.CanDreamGate -= value;
    }

    public static event ILContext.Manipulator CanInteract
    {
        add => IL.HeroController.CanInteract += value;
        remove => IL.HeroController.CanInteract -= value;
    }

    public static event ILContext.Manipulator CanOpenInventory
    {
        add => IL.HeroController.CanOpenInventory += value;
        remove => IL.HeroController.CanOpenInventory -= value;
    }

    public static event ILContext.Manipulator SetDamageMode_int
    {
        add => IL.HeroController.SetDamageMode_int += value;
        remove => IL.HeroController.SetDamageMode_int -= value;
    }

    public static event ILContext.Manipulator SetDamageModeFSM
    {
        add => IL.HeroController.SetDamageModeFSM += value;
        remove => IL.HeroController.SetDamageModeFSM -= value;
    }

    public static event ILContext.Manipulator ResetQuakeDamage
    {
        add => IL.HeroController.ResetQuakeDamage += value;
        remove => IL.HeroController.ResetQuakeDamage -= value;
    }

    public static event ILContext.Manipulator SetDamageMode_DamageMode
    {
        add => IL.HeroController.SetDamageMode_DamageMode += value;
        remove => IL.HeroController.SetDamageMode_DamageMode -= value;
    }

    public static event ILContext.Manipulator StopAnimationControl
    {
        add => IL.HeroController.StopAnimationControl += value;
        remove => IL.HeroController.StopAnimationControl -= value;
    }

    public static event ILContext.Manipulator StartAnimationControl
    {
        add => IL.HeroController.StartAnimationControl += value;
        remove => IL.HeroController.StartAnimationControl -= value;
    }

    public static event ILContext.Manipulator IgnoreInput
    {
        add => IL.HeroController.IgnoreInput += value;
        remove => IL.HeroController.IgnoreInput -= value;
    }

    public static event ILContext.Manipulator IgnoreInputWithoutReset
    {
        add => IL.HeroController.IgnoreInputWithoutReset += value;
        remove => IL.HeroController.IgnoreInputWithoutReset -= value;
    }

    public static event ILContext.Manipulator AcceptInput
    {
        add => IL.HeroController.AcceptInput += value;
        remove => IL.HeroController.AcceptInput -= value;
    }

    public static event ILContext.Manipulator Pause
    {
        add => IL.HeroController.Pause += value;
        remove => IL.HeroController.Pause -= value;
    }

    public static event ILContext.Manipulator UnPause
    {
        add => IL.HeroController.UnPause += value;
        remove => IL.HeroController.UnPause -= value;
    }

    public static event ILContext.Manipulator NearBench
    {
        add => IL.HeroController.NearBench += value;
        remove => IL.HeroController.NearBench -= value;
    }

    public static event ILContext.Manipulator SetWalkZone
    {
        add => IL.HeroController.SetWalkZone += value;
        remove => IL.HeroController.SetWalkZone -= value;
    }

    public static event ILContext.Manipulator ResetState
    {
        add => IL.HeroController.ResetState += value;
        remove => IL.HeroController.ResetState -= value;
    }

    public static event ILContext.Manipulator StopPlayingAudio
    {
        add => IL.HeroController.StopPlayingAudio += value;
        remove => IL.HeroController.StopPlayingAudio -= value;
    }

    public static event ILContext.Manipulator PauseAudio
    {
        add => IL.HeroController.PauseAudio += value;
        remove => IL.HeroController.PauseAudio -= value;
    }

    public static event ILContext.Manipulator UnPauseAudio
    {
        add => IL.HeroController.UnPauseAudio += value;
        remove => IL.HeroController.UnPauseAudio -= value;
    }

    public static event ILContext.Manipulator PauseInput
    {
        add => IL.HeroController.PauseInput += value;
        remove => IL.HeroController.PauseInput -= value;
    }

    public static event ILContext.Manipulator UnPauseInput
    {
        add => IL.HeroController.UnPauseInput += value;
        remove => IL.HeroController.UnPauseInput -= value;
    }

    public static event ILContext.Manipulator SpawnSoftLandingPrefab
    {
        add => IL.HeroController.SpawnSoftLandingPrefab += value;
        remove => IL.HeroController.SpawnSoftLandingPrefab -= value;
    }

    public static event ILContext.Manipulator AffectedByGravity
    {
        add => IL.HeroController.AffectedByGravity += value;
        remove => IL.HeroController.AffectedByGravity -= value;
    }

    public static event ILContext.Manipulator LookForInput
    {
        add => IL.HeroController.LookForInput += value;
        remove => IL.HeroController.LookForInput -= value;
    }

    public static event ILContext.Manipulator LookForQueueInput
    {
        add => IL.HeroController.LookForQueueInput += value;
        remove => IL.HeroController.LookForQueueInput -= value;
    }

    public static event ILContext.Manipulator HeroJump
    {
        add => IL.HeroController.HeroJump += value;
        remove => IL.HeroController.HeroJump -= value;
    }

    public static event ILContext.Manipulator HeroJumpNoEffect
    {
        add => IL.HeroController.HeroJumpNoEffect += value;
        remove => IL.HeroController.HeroJumpNoEffect -= value;
    }

    public static event ILContext.Manipulator DoWallJump
    {
        add => IL.HeroController.DoWallJump += value;
        remove => IL.HeroController.DoWallJump -= value;
    }

    public static event ILContext.Manipulator DoDoubleJump
    {
        add => IL.HeroController.DoDoubleJump += value;
        remove => IL.HeroController.DoDoubleJump -= value;
    }

    public static event ILContext.Manipulator DoHardLanding
    {
        add => IL.HeroController.DoHardLanding += value;
        remove => IL.HeroController.DoHardLanding -= value;
    }

    public static event ILContext.Manipulator DoAttack
    {
        add => IL.HeroController.DoAttack += value;
        remove => IL.HeroController.DoAttack -= value;
    }

    public static event ILContext.Manipulator HeroDash
    {
        add => IL.HeroController.HeroDash += value;
        remove => IL.HeroController.HeroDash -= value;
    }

    public static event ILContext.Manipulator StartFallRumble
    {
        add => IL.HeroController.StartFallRumble += value;
        remove => IL.HeroController.StartFallRumble -= value;
    }

    public static event ILContext.Manipulator SetState
    {
        add => IL.HeroController.SetState += value;
        remove => IL.HeroController.SetState -= value;
    }

    public static event ILContext.Manipulator FinishedEnteringScene
    {
        add => IL.HeroController.FinishedEnteringScene += value;
        remove => IL.HeroController.FinishedEnteringScene -= value;
    }

    public static event ILContext.Manipulator Die
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(HeroController), "Die").GetStateMachineTarget(), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(HeroController), "Die").GetStateMachineTarget(), value);
    }

    public static event ILContext.Manipulator DieFromHazard
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(HeroController), "DieFromHazard").GetStateMachineTarget(), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(HeroController), "DieFromHazard").GetStateMachineTarget(), value);
    }

    public static event ILContext.Manipulator StartRecoil
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(HeroController), "StartRecoil").GetStateMachineTarget(), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(HeroController), "StartRecoil").GetStateMachineTarget(), value);
    }

    public static event ILContext.Manipulator Invulnerable
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(HeroController), "Invulnerable").GetStateMachineTarget(), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(HeroController), "Invulnerable").GetStateMachineTarget(), value);
    }

    public static event ILContext.Manipulator FirstFadeIn
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(HeroController), "FirstFadeIn").GetStateMachineTarget(), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(HeroController), "FirstFadeIn").GetStateMachineTarget(), value);
    }

    public static event ILContext.Manipulator FallCheck
    {
        add => IL.HeroController.FallCheck += value;
        remove => IL.HeroController.FallCheck -= value;
    }

    public static event ILContext.Manipulator OutOfBoundsCheck
    {
        add => IL.HeroController.OutOfBoundsCheck += value;
        remove => IL.HeroController.OutOfBoundsCheck -= value;
    }

    public static event ILContext.Manipulator ConfirmOutOfBounds
    {
        add => IL.HeroController.ConfirmOutOfBounds += value;
        remove => IL.HeroController.ConfirmOutOfBounds -= value;
    }

    public static event ILContext.Manipulator FailSafeChecks
    {
        add => IL.HeroController.FailSafeChecks += value;
        remove => IL.HeroController.FailSafeChecks -= value;
    }

    public static event ILContext.Manipulator LocateSpawnPoint
    {
        add => IL.HeroController.LocateSpawnPoint += value;
        remove => IL.HeroController.LocateSpawnPoint -= value;
    }

    public static event ILContext.Manipulator CancelJump
    {
        add => IL.HeroController.CancelJump += value;
        remove => IL.HeroController.CancelJump -= value;
    }

    public static event ILContext.Manipulator CancelDoubleJump
    {
        add => IL.HeroController.CancelDoubleJump += value;
        remove => IL.HeroController.CancelDoubleJump -= value;
    }

    public static event ILContext.Manipulator CancelDash
    {
        add => IL.HeroController.CancelDash += value;
        remove => IL.HeroController.CancelDash -= value;
    }

    public static event ILContext.Manipulator CancelWallsliding
    {
        add => IL.HeroController.CancelWallsliding += value;
        remove => IL.HeroController.CancelWallsliding -= value;
    }

    public static event ILContext.Manipulator CancelBackDash
    {
        add => IL.HeroController.CancelBackDash += value;
        remove => IL.HeroController.CancelBackDash -= value;
    }

    public static event ILContext.Manipulator CancelDownAttack
    {
        add => IL.HeroController.CancelDownAttack += value;
        remove => IL.HeroController.CancelDownAttack -= value;
    }

    public static event ILContext.Manipulator CancelAttack
    {
        add => IL.HeroController.CancelAttack += value;
        remove => IL.HeroController.CancelAttack -= value;
    }

    public static event ILContext.Manipulator CancelBounce
    {
        add => IL.HeroController.CancelBounce += value;
        remove => IL.HeroController.CancelBounce -= value;
    }

    public static event ILContext.Manipulator CancelRecoilHorizontal
    {
        add => IL.HeroController.CancelRecoilHorizontal += value;
        remove => IL.HeroController.CancelRecoilHorizontal -= value;
    }

    public static event ILContext.Manipulator CancelDamageRecoil
    {
        add => IL.HeroController.CancelDamageRecoil += value;
        remove => IL.HeroController.CancelDamageRecoil -= value;
    }

    public static event ILContext.Manipulator CancelFallEffects
    {
        add => IL.HeroController.CancelFallEffects += value;
        remove => IL.HeroController.CancelFallEffects -= value;
    }

    public static event ILContext.Manipulator ResetAttacks
    {
        add => IL.HeroController.ResetAttacks += value;
        remove => IL.HeroController.ResetAttacks -= value;
    }

    public static event ILContext.Manipulator ResetAttacksDash
    {
        add => IL.HeroController.ResetAttacksDash += value;
        remove => IL.HeroController.ResetAttacksDash -= value;
    }

    public static event ILContext.Manipulator ResetMotion
    {
        add => IL.HeroController.ResetMotion += value;
        remove => IL.HeroController.ResetMotion -= value;
    }

    public static event ILContext.Manipulator ResetMotionNotVelocity
    {
        add => IL.HeroController.ResetMotionNotVelocity += value;
        remove => IL.HeroController.ResetMotionNotVelocity -= value;
    }

    public static event ILContext.Manipulator ResetLook
    {
        add => IL.HeroController.ResetLook += value;
        remove => IL.HeroController.ResetLook -= value;
    }

    public static event ILContext.Manipulator ResetInput
    {
        add => IL.HeroController.ResetInput += value;
        remove => IL.HeroController.ResetInput -= value;
    }

    public static event ILContext.Manipulator BackOnGround
    {
        add => IL.HeroController.BackOnGround += value;
        remove => IL.HeroController.BackOnGround -= value;
    }

    public static event ILContext.Manipulator JumpReleased
    {
        add => IL.HeroController.JumpReleased += value;
        remove => IL.HeroController.JumpReleased -= value;
    }

    public static event ILContext.Manipulator FinishedDashing
    {
        add => IL.HeroController.FinishedDashing += value;
        remove => IL.HeroController.FinishedDashing -= value;
    }

    public static event ILContext.Manipulator SetStartingMotionState
    {
        add => IL.HeroController.SetStartingMotionState += value;
        remove => IL.HeroController.SetStartingMotionState -= value;
    }

    public static event ILContext.Manipulator SetStartingMotionState_bool
    {
        add => IL.HeroController.SetStartingMotionState_bool += value;
        remove => IL.HeroController.SetStartingMotionState_bool -= value;
    }

    public static event ILContext.Manipulator EnterAcid
    {
        add => IL.HeroController.EnterAcid += value;
        remove => IL.HeroController.EnterAcid -= value;
    }

    public static event ILContext.Manipulator ExitAcid
    {
        add => IL.HeroController.ExitAcid += value;
        remove => IL.HeroController.ExitAcid -= value;
    }

    public static event ILContext.Manipulator TileMapTest
    {
        add => IL.HeroController.TileMapTest += value;
        remove => IL.HeroController.TileMapTest -= value;
    }

    public static event ILContext.Manipulator TilemapTestPause
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(HeroController), "TilemapTestPause").GetStateMachineTarget(), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(HeroController), "TilemapTestPause").GetStateMachineTarget(), value);
    }

    public static event ILContext.Manipulator StopTilemapTest
    {
        add => IL.HeroController.StopTilemapTest += value;
        remove => IL.HeroController.StopTilemapTest -= value;
    }

    public static event ILContext.Manipulator CheckForTerrainThunk
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(HeroController), "CheckForTerrainThunk").GetStateMachineTarget(),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(HeroController), "CheckForTerrainThunk").GetStateMachineTarget(),
            value);
    }

    public static event ILContext.Manipulator CheckStillTouchingWall
    {
        add => IL.HeroController.CheckStillTouchingWall += value;
        remove => IL.HeroController.CheckStillTouchingWall -= value;
    }

    public static event ILContext.Manipulator CheckForBump
    {
        add => IL.HeroController.CheckForBump += value;
        remove => IL.HeroController.CheckForBump -= value;
    }

    public static event ILContext.Manipulator CheckNearRoof
    {
        add => IL.HeroController.CheckNearRoof += value;
        remove => IL.HeroController.CheckNearRoof -= value;
    }

    public static event ILContext.Manipulator CheckTouchingGround
    {
        add => IL.HeroController.CheckTouchingGround += value;
        remove => IL.HeroController.CheckTouchingGround -= value;
    }

    public static event ILContext.Manipulator CheckTouching
    {
        add => IL.HeroController.CheckTouching += value;
        remove => IL.HeroController.CheckTouching -= value;
    }

    public static event ILContext.Manipulator CheckTouchingAdvanced
    {
        add => IL.HeroController.CheckTouchingAdvanced += value;
        remove => IL.HeroController.CheckTouchingAdvanced -= value;
    }

    public static event ILContext.Manipulator FindCollisionDirection
    {
        add => IL.HeroController.FindCollisionDirection += value;
        remove => IL.HeroController.FindCollisionDirection -= value;
    }

    public static event ILContext.Manipulator CanJump
    {
        add => IL.HeroController.CanJump += value;
        remove => IL.HeroController.CanJump -= value;
    }

    public static event ILContext.Manipulator CanDoubleJump
    {
        add => IL.HeroController.CanDoubleJump += value;
        remove => IL.HeroController.CanDoubleJump -= value;
    }

    public static event ILContext.Manipulator CanInfiniteAirJump
    {
        add => IL.HeroController.CanInfiniteAirJump += value;
        remove => IL.HeroController.CanInfiniteAirJump -= value;
    }

    public static event ILContext.Manipulator CanSwim
    {
        add => IL.HeroController.CanSwim += value;
        remove => IL.HeroController.CanSwim -= value;
    }

    public static event ILContext.Manipulator CanDash
    {
        add => IL.HeroController.CanDash += value;
        remove => IL.HeroController.CanDash -= value;
    }

    public static event ILContext.Manipulator CanAttack
    {
        add => IL.HeroController.CanAttack += value;
        remove => IL.HeroController.CanAttack -= value;
    }

    public static event ILContext.Manipulator CanNailCharge
    {
        add => IL.HeroController.CanNailCharge += value;
        remove => IL.HeroController.CanNailCharge -= value;
    }

    public static event ILContext.Manipulator CanWallSlide
    {
        add => IL.HeroController.CanWallSlide += value;
        remove => IL.HeroController.CanWallSlide -= value;
    }

    public static event ILContext.Manipulator CanTakeDamage
    {
        add => IL.HeroController.CanTakeDamage += value;
        remove => IL.HeroController.CanTakeDamage -= value;
    }

    public static event ILContext.Manipulator CanWallJump
    {
        add => IL.HeroController.CanWallJump += value;
        remove => IL.HeroController.CanWallJump -= value;
    }

    public static event ILContext.Manipulator ShouldHardLand
    {
        add => IL.HeroController.ShouldHardLand += value;
        remove => IL.HeroController.ShouldHardLand -= value;
    }

    public static event ILContext.Manipulator OnCollisionEnter2D
    {
        add => IL.HeroController.OnCollisionEnter2D += value;
        remove => IL.HeroController.OnCollisionEnter2D -= value;
    }

    public static event ILContext.Manipulator OnCollisionStay2D
    {
        add => IL.HeroController.OnCollisionStay2D += value;
        remove => IL.HeroController.OnCollisionStay2D -= value;
    }

    public static event ILContext.Manipulator OnCollisionExit2D
    {
        add => IL.HeroController.OnCollisionExit2D += value;
        remove => IL.HeroController.OnCollisionExit2D -= value;
    }

    public static event ILContext.Manipulator SetupGameRefs
    {
        add => IL.HeroController.SetupGameRefs += value;
        remove => IL.HeroController.SetupGameRefs -= value;
    }

    public static event ILContext.Manipulator SetupPools
    {
        add => IL.HeroController.SetupPools += value;
        remove => IL.HeroController.SetupPools -= value;
    }

    public static event ILContext.Manipulator FilterInput
    {
        add => IL.HeroController.FilterInput += value;
        remove => IL.HeroController.FilterInput -= value;
    }

    public static event ILContext.Manipulator FindGroundPoint
    {
        add => IL.HeroController.FindGroundPoint += value;
        remove => IL.HeroController.FindGroundPoint -= value;
    }

    public static event ILContext.Manipulator FindGroundPointY
    {
        add => IL.HeroController.FindGroundPointY += value;
        remove => IL.HeroController.FindGroundPointY -= value;
    }

    public static event ILContext.Manipulator orig_StartMPDrain
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(HeroController), "orig_StartMPDrain"),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(HeroController), "orig_StartMPDrain"), value);
    }

    public static event ILContext.Manipulator orig_Update
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(HeroController), "orig_Update"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(HeroController), "orig_Update"),
            value);
    }

    public static event ILContext.Manipulator OrigDashVector
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(HeroController), "OrigDashVector"),
            value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(HeroController), "OrigDashVector"),
            value);
    }

    public static event ILContext.Manipulator orig_Dash
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(HeroController), "orig_Dash"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(HeroController), "orig_Dash"),
            value);
    }

    public static event ILContext.Manipulator orig_CharmUpdate
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(HeroController), "orig_CharmUpdate"),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(HeroController), "orig_CharmUpdate"), value);
    }

    public static event ILContext.Manipulator orig_DoAttack
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(HeroController), "orig_DoAttack"),
            value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(HeroController), "orig_DoAttack"),
            value);
    }
}