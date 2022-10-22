using System.Collections.ObjectModel;

namespace HKMirror.Reflection.InstanceClasses;

/// <summary>
///     A class that contains all (public and private) fields and methods of InputModuleBinder_MyActionSet allowing you to easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class InputModuleBinder_MyActionSetR : InstanceClassWrapper<InputModuleBinder.MyActionSet>
{
    public InputModuleBinder_MyActionSetR(InputModuleBinder.MyActionSet _orig) : base(_orig)
    {
    }

    public PlayerAction Submit
    {
        get => orig.Submit;
        set => orig.Submit = value;
    }

    public PlayerAction Cancel
    {
        get => orig.Cancel;
        set => orig.Cancel = value;
    }

    public PlayerAction Left
    {
        get => orig.Left;
        set => orig.Left = value;
    }

    public PlayerAction Right
    {
        get => orig.Right;
        set => orig.Right = value;
    }

    public PlayerAction Up
    {
        get => orig.Up;
        set => orig.Up = value;
    }

    public PlayerAction Down
    {
        get => orig.Down;
        set => orig.Down = value;
    }

    public PlayerTwoAxisAction Move
    {
        get => orig.Move;
        set => orig.Move = value;
    }

    public BindingSourceType LastInputType
    {
        get => orig.LastInputType;
        set => orig.LastInputType = value;
    }

    public ulong LastInputTypeChangedTick
    {
        get => orig.LastInputTypeChangedTick;
        set => orig.LastInputTypeChangedTick = value;
    }

    public InputDeviceClass LastDeviceClass
    {
        get => orig.LastDeviceClass;
        set => orig.LastDeviceClass = value;
    }

    public InputDeviceStyle LastDeviceStyle
    {
        get => orig.LastDeviceStyle;
        set => orig.LastDeviceStyle = value;
    }

    public PlayerAction listenWithAction
    {
        get => GetField<PlayerAction>();
        set => SetField(value);
    }

    public InputDevice Device
    {
        get => orig.Device;
        set => orig.Device = value;
    }

    public List<InputDevice> IncludeDevices => orig.IncludeDevices;

    public List<InputDevice> ExcludeDevices => orig.ExcludeDevices;

    public ReadOnlyCollection<PlayerAction> Actions => orig.Actions;

    public ulong UpdateTick
    {
        get => orig.UpdateTick;
        set => SetProperty(value);
    }

    public bool Enabled
    {
        get => orig.Enabled;
        set => orig.Enabled = value;
    }

    public bool PreventInputWhileListeningForBinding
    {
        get => orig.PreventInputWhileListeningForBinding;
        set => orig.PreventInputWhileListeningForBinding = value;
    }

    public object UserData
    {
        get => orig.UserData;
        set => orig.UserData = value;
    }

    public bool IsListeningForBinding => orig.IsListeningForBinding;

    public BindingListenOptions ListenOptions
    {
        get => orig.ListenOptions;
        set => orig.ListenOptions = value;
    }

    public InputDevice ActiveDevice => orig.ActiveDevice;
}