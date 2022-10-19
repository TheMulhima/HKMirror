namespace HKMirror;

/// <summary>
/// Provides values types a way to be passed by reference without using ref parameters
/// </summary>
public sealed class DoubleBox : IComparable, IFormattable, IConvertible, IComparable<DoubleBox>, IEquatable<DoubleBox>
{
    public DoubleBox() {}
    public DoubleBox(double value) => Value = value;
    public double Value { get; set; } = default;

    public static explicit operator DoubleBox(double value) => new (value);
    public static implicit operator double(DoubleBox box) => box.Value;

    public static DoubleBox operator + (DoubleBox box1, DoubleBox box2) => (DoubleBox)(box1.Value + box2.Value);
    public static DoubleBox operator + (double val, DoubleBox box) => (DoubleBox)(val + box.Value);
    public static DoubleBox operator + (DoubleBox box, double val) => (DoubleBox)(box.Value + val);
    
    public static DoubleBox operator - (DoubleBox box1, DoubleBox box2) => (DoubleBox)(box1.Value - box2.Value);
    public static DoubleBox operator - (double val, DoubleBox box) => (DoubleBox)(val - box.Value);
    public static DoubleBox operator - (DoubleBox box, double val) => (DoubleBox)(box.Value - val);
    
    public static DoubleBox operator * (DoubleBox box1, DoubleBox box2) => (DoubleBox)(box1.Value * box2.Value);
    public static DoubleBox operator * (double val, DoubleBox box) => (DoubleBox)(val * box.Value);
    public static DoubleBox operator * (DoubleBox box, double val) => (DoubleBox)(box.Value * val);
    
    public static DoubleBox operator / (DoubleBox box1, DoubleBox box2) => (DoubleBox)(box1.Value / box2.Value);
    public static DoubleBox operator / (double val, DoubleBox box) => (DoubleBox)(val / box.Value);
    public static DoubleBox operator / (DoubleBox box, double val) => (DoubleBox)(box.Value / val);
    
    public static DoubleBox operator % (DoubleBox box1, DoubleBox box2) => (DoubleBox)(box1.Value % box2.Value);
    public static DoubleBox operator % (double val, DoubleBox box) => (DoubleBox)(val % box.Value);
    public static DoubleBox operator % (DoubleBox box, double val) => (DoubleBox)(box.Value % val);

    public static bool operator == (DoubleBox box1, DoubleBox box2) => box1.Value == box2.Value;
    public static bool operator == (double val, DoubleBox box) => val == box.Value;
    public static bool operator == (DoubleBox box, double val) => box.Value == val;
    
    public static bool operator != (DoubleBox box1, DoubleBox box2) => box1.Value != box2.Value;
    public static bool operator != (double val, DoubleBox box) => val != box.Value;
    public static bool operator != (DoubleBox box, double val) => box.Value != val;
    
    public static bool operator < (DoubleBox box1, DoubleBox box2) => box1.Value < box2.Value;
    public static bool operator < (double val, DoubleBox box) => val < box.Value;
    public static bool operator < (DoubleBox box, double val) => box.Value < val;
    
    public static bool operator > (DoubleBox box1, DoubleBox box2) => box1.Value > box2.Value;
    public static bool operator > (double val, DoubleBox box) => val > box.Value;
    public static bool operator > (DoubleBox box, double val) => box.Value > val;
    
    public static bool operator <= (DoubleBox box1, DoubleBox box2) => box1.Value <= box2.Value;
    public static bool operator <= (double val, DoubleBox box) => val <= box.Value;
    public static bool operator <= (DoubleBox box, double val) => box.Value <= val;
    
    public static bool operator >= (DoubleBox box1, DoubleBox box2) => box1.Value >= box2.Value;
    public static bool operator >= (double val, DoubleBox box) => val >= box.Value;
    public static bool operator >= (DoubleBox box, double val) => box.Value >= val;
    
    public static DoubleBox operator - (DoubleBox box) => (DoubleBox)(-box.Value);
    public static DoubleBox operator + (DoubleBox box) => (DoubleBox)(+box.Value);
    public static DoubleBox operator ++ (DoubleBox box) => (DoubleBox)(++box.Value);
    public static DoubleBox operator -- (DoubleBox box) => (DoubleBox)(--box.Value);

    public bool Equals(DoubleBox other) => Value.Equals(other);
    public override bool Equals(object obj) => Value.Equals(obj);
    public int CompareTo(DoubleBox other) => Value.CompareTo(other);
    public int CompareTo(object other) => Value.CompareTo(other);
    public override int GetHashCode() => Value.GetHashCode();
    public string ToString(string format, IFormatProvider formatProvider) => Value.ToString(format, formatProvider);
    public TypeCode GetTypeCode() => Value.GetTypeCode();
    public bool ToBoolean(IFormatProvider provider) => Convert.ToBoolean(Value);
    public char ToChar(IFormatProvider provider) => Convert.ToChar(Value);
    public sbyte ToSByte(IFormatProvider provider) => Convert.ToSByte(Value);
    public byte ToByte(IFormatProvider provider) => Convert.ToByte(Value);
    public short ToInt16(IFormatProvider provider) => Convert.ToInt16(Value);
    public ushort ToUInt16(IFormatProvider provider) => Convert.ToUInt16(Value);
    public int ToInt32(IFormatProvider provider) => Convert.ToInt32(Value);
    public uint ToUInt32(IFormatProvider provider) => Convert.ToUInt32(Value);
    public long ToInt64(IFormatProvider provider) => Convert.ToInt64(Value);
    public ulong ToUInt64(IFormatProvider provider) => Convert.ToUInt64(Value);
    public float ToSingle(IFormatProvider provider) => Convert.ToSingle(Value);
    public double ToDouble(IFormatProvider provider) => Convert.ToDouble(Value);
    public decimal ToDecimal(IFormatProvider provider) => Convert.ToDecimal(Value);
    public DateTime ToDateTime(IFormatProvider provider) => throw new InvalidCastException($"Invalid cast from '{nameof(DoubleBox)}' to '{nameof(DateTime)}'.");
    public string ToString(IFormatProvider provider) => Value.ToString(provider);
    public object ToType(Type type, IFormatProvider provider) => (object) Convert.ToDouble(Value, provider);
}