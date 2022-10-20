namespace HKMirror.Hooks.ILHooks;

/// <summary>
///     Contains all correct IL Hooks for PlayMakerUGuiComponentProxy.<br />
///     Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
///     Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILPlayMakerUGuiComponentProxy
{
    public static event ILContext.Manipulator Start
    {
        add => IL.PlayMakerUGuiComponentProxy.Start += value;
        remove => IL.PlayMakerUGuiComponentProxy.Start -= value;
    }

    public static event ILContext.Manipulator Update
    {
        add => IL.PlayMakerUGuiComponentProxy.Update += value;
        remove => IL.PlayMakerUGuiComponentProxy.Update -= value;
    }

    public static event ILContext.Manipulator SetupEventTarget
    {
        add => IL.PlayMakerUGuiComponentProxy.SetupEventTarget += value;
        remove => IL.PlayMakerUGuiComponentProxy.SetupEventTarget -= value;
    }

    public static event ILContext.Manipulator SetupVariableTarget
    {
        add => IL.PlayMakerUGuiComponentProxy.SetupVariableTarget += value;
        remove => IL.PlayMakerUGuiComponentProxy.SetupVariableTarget -= value;
    }

    public static event ILContext.Manipulator SetupUiListeners
    {
        add => IL.PlayMakerUGuiComponentProxy.SetupUiListeners += value;
        remove => IL.PlayMakerUGuiComponentProxy.SetupUiListeners -= value;
    }

    public static event ILContext.Manipulator OnClick
    {
        add => IL.PlayMakerUGuiComponentProxy.OnClick += value;
        remove => IL.PlayMakerUGuiComponentProxy.OnClick -= value;
    }

    public static event ILContext.Manipulator OnValueChanged_bool
    {
        add => IL.PlayMakerUGuiComponentProxy.OnValueChanged_bool += value;
        remove => IL.PlayMakerUGuiComponentProxy.OnValueChanged_bool -= value;
    }

    public static event ILContext.Manipulator OnValueChanged_float
    {
        add => IL.PlayMakerUGuiComponentProxy.OnValueChanged_float += value;
        remove => IL.PlayMakerUGuiComponentProxy.OnValueChanged_float -= value;
    }

    public static event ILContext.Manipulator OnValueChanged_Vector2
    {
        add => IL.PlayMakerUGuiComponentProxy.OnValueChanged_Vector2 += value;
        remove => IL.PlayMakerUGuiComponentProxy.OnValueChanged_Vector2 -= value;
    }

    public static event ILContext.Manipulator onEndEdit
    {
        add => IL.PlayMakerUGuiComponentProxy.onEndEdit += value;
        remove => IL.PlayMakerUGuiComponentProxy.onEndEdit -= value;
    }

    public static event ILContext.Manipulator SetFsmVariable_Vector2
    {
        add => IL.PlayMakerUGuiComponentProxy.SetFsmVariable_Vector2 += value;
        remove => IL.PlayMakerUGuiComponentProxy.SetFsmVariable_Vector2 -= value;
    }

    public static event ILContext.Manipulator SetFsmVariable_bool
    {
        add => IL.PlayMakerUGuiComponentProxy.SetFsmVariable_bool += value;
        remove => IL.PlayMakerUGuiComponentProxy.SetFsmVariable_bool -= value;
    }

    public static event ILContext.Manipulator SetFsmVariable_float
    {
        add => IL.PlayMakerUGuiComponentProxy.SetFsmVariable_float += value;
        remove => IL.PlayMakerUGuiComponentProxy.SetFsmVariable_float -= value;
    }

    public static event ILContext.Manipulator SetFsmVariable_string
    {
        add => IL.PlayMakerUGuiComponentProxy.SetFsmVariable_string += value;
        remove => IL.PlayMakerUGuiComponentProxy.SetFsmVariable_string -= value;
    }

    public static event ILContext.Manipulator FirePlayMakerEvent
    {
        add => IL.PlayMakerUGuiComponentProxy.FirePlayMakerEvent += value;
        remove => IL.PlayMakerUGuiComponentProxy.FirePlayMakerEvent -= value;
    }

    public static event ILContext.Manipulator DoesTargetImplementsEvent
    {
        add => IL.PlayMakerUGuiComponentProxy.DoesTargetImplementsEvent += value;
        remove => IL.PlayMakerUGuiComponentProxy.DoesTargetImplementsEvent -= value;
    }

    public static event ILContext.Manipulator GetEventString
    {
        add => IL.PlayMakerUGuiComponentProxy.GetEventString += value;
        remove => IL.PlayMakerUGuiComponentProxy.GetEventString -= value;
    }
}