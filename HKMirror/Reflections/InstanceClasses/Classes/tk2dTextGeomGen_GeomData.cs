namespace HKMirror.Reflection.InstanceClasses
{
/// <summary>
///     A class that contains all (public and private) fields and methods of tk2dTextGeomGen_GeomData allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class tk2dTextGeomGen_GeomDataR:InstanceClassWrapper<tk2dTextGeomGen.GeomData>
{
public tk2dTextGeomGen_GeomDataR(tk2dTextGeomGen.GeomData _orig) : base(_orig) {}
public tk2dTextMeshData textMeshData
{
get => GetField<tk2dTextMeshData>();
set => SetField(value);
}

public tk2dFontData fontInst
{
get => GetField<tk2dFontData>();
set => SetField(value);
}

public string formattedText
{
get => GetField<string>();
set => SetField(value);
}

}
}
