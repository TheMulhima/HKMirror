namespace HKMirror.Reflection.InstanceClasses
{
/// <summary>
///     A class that contains all (public and private) fields and methods of PerformanceHUD_LoadReport allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class PerformanceHUD_LoadReportR:InstanceClassWrapper<PerformanceHUD.LoadReport>
{
public PerformanceHUD_LoadReportR(PerformanceHUD.LoadReport _orig) : base(_orig) {}
public UnityEngine.Color Color
{
get => orig.Color;
set => orig.Color = value;
}

public UnityEngine.GUIContent Content
{
get => orig.Content;
set => orig.Content = value;
}

public bool DidPost
{
get => orig.DidPost;
set => orig.DidPost = value;
}

}
}
