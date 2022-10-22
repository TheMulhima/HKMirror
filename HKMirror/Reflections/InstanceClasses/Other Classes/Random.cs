using Random = System.Random;

namespace HKMirror.Reflection.InstanceClasses;

/// <summary>
///     A class that contains all (public and private) fields and methods of System.Random allowing you to easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class RandomR : InstanceClassWrapper<Random>
{
    public RandomR(Random _orig) : base(_orig)
    {
    }

    public int MBIG
    {
        get => GetFieldStatic<int>();
        set => SetField(value);
    }

    public int MSEED
    {
        get => GetFieldStatic<int>();
        set => SetField(value);
    }

    public int MZ
    {
        get => GetFieldStatic<int>();
        set => SetField(value);
    }

    public int inext
    {
        get => GetField<int>();
        set => SetField(value);
    }

    public int inextp
    {
        get => GetField<int>();
        set => SetField(value);
    }

    public int[] SeedArray
    {
        get => GetField<int[]>();
        set => SetField(value);
    }

    public double Sample()
    {
        return CallMethod<double>();
    }

    public int InternalSample()
    {
        return CallMethod<int>();
    }

    public int Next()
    {
        return orig.Next();
    }

    public double GetSampleForLargeRange()
    {
        return CallMethod<double>();
    }

    public int Next(int minValue, int maxValue)
    {
        return orig.Next(minValue, maxValue);
    }

    public int Next(int maxValue)
    {
        return orig.Next(maxValue);
    }

    public double NextDouble()
    {
        return orig.NextDouble();
    }

    public void NextBytes(byte[] buffer)
    {
        orig.NextBytes(buffer);
    }
}