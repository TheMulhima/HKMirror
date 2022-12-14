using System.Diagnostics;

namespace HKMirror.Reflection.InstanceClasses;

/// <summary>
///     A class that contains all (public and private) fields and methods of OptionalTypeHasNoValueException allowing you
///     to easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class OptionalTypeHasNoValueExceptionR : InstanceClassWrapper<OptionalTypeHasNoValueException>
{
    public OptionalTypeHasNoValueExceptionR(OptionalTypeHasNoValueException _orig) : base(_orig)
    {
    }

    public string _message
    {
        get => GetField<string>();
        set => SetField(value);
    }

    public int _HResult
    {
        get => GetField<int>();
        set => SetField(value);
    }

    public StackTrace[] captured_traces
    {
        get => GetField<StackTrace[]>();
        set => SetField(value);
    }

    public string Message => orig.Message;

    public IDictionary Data => orig.Data;

    public Exception InnerException => orig.InnerException;

    public MethodBase TargetSite => orig.TargetSite;

    public string StackTrace => orig.StackTrace;

    public string HelpLink
    {
        get => orig.HelpLink;
        set => orig.HelpLink = value;
    }

    public string Source
    {
        get => orig.Source;
        set => orig.Source = value;
    }

    public string RemoteStackTrace => GetProperty<string>();

    public int HResult
    {
        get => orig.HResult;
        set => SetProperty(value);
    }

    public bool IsTransient => GetProperty<bool>();
}