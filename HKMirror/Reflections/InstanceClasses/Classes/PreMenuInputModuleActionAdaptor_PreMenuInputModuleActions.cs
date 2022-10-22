namespace HKMirror.Reflection.InstanceClasses
{
/// <summary>
///     A class that contains all (public and private) fields and methods of PreMenuInputModuleActionAdaptor_PreMenuInputModuleActions allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class PreMenuInputModuleActionAdaptor_PreMenuInputModuleActionsR:InstanceClassWrapper<PreMenuInputModuleActionAdaptor.PreMenuInputModuleActions>
{
public PreMenuInputModuleActionAdaptor_PreMenuInputModuleActionsR(PreMenuInputModuleActionAdaptor.PreMenuInputModuleActions _orig) : base(_orig) {}
public InControl.PlayerAction Submit
{
get => orig.Submit;
set => orig.Submit = value;
}

public InControl.PlayerAction Cancel
{
get => orig.Cancel;
set => orig.Cancel = value;
}

public InControl.PlayerAction Left
{
get => orig.Left;
set => orig.Left = value;
}

public InControl.PlayerAction Right
{
get => orig.Right;
set => orig.Right = value;
}

public InControl.PlayerAction Up
{
get => orig.Up;
set => orig.Up = value;
}

public InControl.PlayerAction Down
{
get => orig.Down;
set => orig.Down = value;
}

public InControl.PlayerTwoAxisAction Move
{
get => orig.Move;
set => orig.Move = value;
}

public InControl.BindingSourceType LastInputType
{
get => orig.LastInputType;
set => orig.LastInputType = value;
}

public ulong LastInputTypeChangedTick
{
get => orig.LastInputTypeChangedTick;
set => orig.LastInputTypeChangedTick = value;
}

public InControl.InputDeviceClass LastDeviceClass
{
get => orig.LastDeviceClass;
set => orig.LastDeviceClass = value;
}

public InControl.InputDeviceStyle LastDeviceStyle
{
get => orig.LastDeviceStyle;
set => orig.LastDeviceStyle = value;
}

public InControl.PlayerAction listenWithAction
{
get => GetField<InControl.PlayerAction>();
set => SetField(value);
}

public InControl.InputDevice Device
{
get => orig.Device;
set => orig.Device = value;
}

public System.Collections.Generic.List<InControl.InputDevice> IncludeDevices
{
get => orig.IncludeDevices;
}

public System.Collections.Generic.List<InControl.InputDevice> ExcludeDevices
{
get => orig.ExcludeDevices;
}

public System.Collections.ObjectModel.ReadOnlyCollection<InControl.PlayerAction> Actions
{
get => orig.Actions;
}

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

public System.Object UserData
{
get => orig.UserData;
set => orig.UserData = value;
}

public bool IsListeningForBinding
{
get => orig.IsListeningForBinding;
}

public InControl.BindingListenOptions ListenOptions
{
get => orig.ListenOptions;
set => orig.ListenOptions = value;
}

public InControl.InputDevice ActiveDevice
{
get => orig.ActiveDevice;
}

}
}
