namespace HKMirror.Reflection.InstanceClasses;

/// <summary>
///     A class that contains all (public and private) fields and methods of LightBlur allowing you to easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class LightBlurR : InstanceClassWrapper<LightBlur>
{
    public LightBlurR(LightBlur _orig) : base(_orig)
    {
    }

    public string BlurShaderName
    {
        get => GetFieldStatic<string>();
        set => SetField(value);
    }

    public int BlurMaterialPassCount
    {
        get => GetFieldStatic<int>();
        set => SetField(value);
    }

    public int passGroupCount
    {
        get => GetField<int>();
        set => SetField(value);
    }

    public int BlurPassCountMax
    {
        get => GetFieldStatic<int>();
        set => SetField(value);
    }

    public string BlurInfoPropertyName
    {
        get => GetFieldStatic<string>();
        set => SetField(value);
    }

    public int blurInfoId
    {
        get => GetField<int>();
        set => SetField(value);
    }

    public Shader blurShader
    {
        get => GetField<Shader>();
        set => SetField(value);
    }

    public Material blurMaterial
    {
        get => GetField<Material>();
        set => SetField(value);
    }

    public bool supportHDRTextures
    {
        get => GetField<bool>();
        set => SetField(value);
    }

    public bool supportDX11
    {
        get => GetField<bool>();
        set => SetField(value);
    }

    public bool isSupported
    {
        get => GetField<bool>();
        set => SetField(value);
    }

    public int PassGroupCount
    {
        get => orig.PassGroupCount;
        set => orig.PassGroupCount = value;
    }

    public int BlurPassCount => orig.BlurPassCount;


    public void Awake()
    {
        CallMethod();
    }

    public void OnDestroy()
    {
        CallMethod();
    }


    public void OnRenderImage(RenderTexture source, RenderTexture destination)
    {
        CallMethod(new object[] { source, destination });
    }
}