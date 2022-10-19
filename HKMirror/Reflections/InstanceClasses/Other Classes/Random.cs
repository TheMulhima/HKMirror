namespace HKMirror.Reflection.InstanceClasses
{
    /// <summary>
    ///     A class that contains all (public and private) fields and methods of System.Random allowing you to easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public class RandomR:InstanceClassWrapper<System.Random>
    {
        public RandomR(System.Random _orig) : base(_orig) {}
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

        public System.Int32[] SeedArray
        {
            get => GetField<System.Int32[]>();
            set => SetField(value);
        }

        public System.Double Sample () =>
            CallMethod<System.Double>();

        public int InternalSample () =>
            CallMethod<int>();

        public int Next () =>
            orig.Next();

        public System.Double GetSampleForLargeRange () =>
            CallMethod<System.Double>();

        public int Next (int minValue, int maxValue) =>
            orig.Next(minValue, maxValue);

        public int Next (int maxValue) =>
            orig.Next(maxValue);

        public System.Double NextDouble () =>
            orig.NextDouble();

        public void NextBytes (System.Byte[] buffer) =>
            orig.NextBytes(buffer);

    }
}