namespace HKMirror;

/// <summary>
/// Provides values types a way to be passed by reference without using ref parameters
/// </summary>
public sealed class uLongBox : IComparable, IFormattable, IConvertible, IComparable<uLongBox>, IEquatable<uLongBox>
{
    public uLongBox() {}
    public uLongBox(ulong value) => Value = value;
    public ulong Value { get; set; } = default;

    public static explicit operator uLongBox(ulong value) => new (value);
    public static implicit operator ulong(uLongBox box) => box.Value;

    public static uLongBox operator + (uLongBox box1, uLongBox box2) => (uLongBox)(box1.Value + box2.Value);
    public static uLongBox operator + (ulong val, uLongBox box) => (uLongBox)(val + box.Value);
    public static uLongBox operator + (uLongBox box, ulong val) => (uLongBox)(box.Value + val);
    
    public static uLongBox operator - (uLongBox box1, uLongBox box2) => (uLongBox)(box1.Value - box2.Value);
    public static uLongBox operator - (ulong val, uLongBox box) => (uLongBox)(val - box.Value);
    public static uLongBox operator - (uLongBox box, ulong val) => (uLongBox)(box.Value - val);
    
    public static uLongBox operator * (uLongBox box1, uLongBox box2) => (uLongBox)(box1.Value * box2.Value);
    public static uLongBox operator * (ulong val, uLongBox box) => (uLongBox)(val * box.Value);
    public static uLongBox operator * (uLongBox box, ulong val) => (uLongBox)(box.Value * val);
    
    public static uLongBox operator / (uLongBox box1, uLongBox box2) => (uLongBox)(box1.Value / box2.Value);
    public static uLongBox operator / (ulong val, uLongBox box) => (uLongBox)(val / box.Value);
    public static uLongBox operator / (uLongBox box, ulong val) => (uLongBox)(box.Value / val);
    
    public static uLongBox operator % (uLongBox box1, uLongBox box2) => (uLongBox)(box1.Value % box2.Value);
    public static uLongBox operator % (ulong val, uLongBox box) => (uLongBox)(val % box.Value);
    public static uLongBox operator % (uLongBox box, ulong val) => (uLongBox)(box.Value % val);
    
    public static uLongBox operator & (uLongBox box1, uLongBox box2) => (uLongBox)(box1.Value & box2.Value);
    public static uLongBox operator & (ulong val, uLongBox box) => (uLongBox)(val & box.Value);
    public static uLongBox operator & (uLongBox box, ulong val) => (uLongBox)(box.Value & val);
    
    public static uLongBox operator | (uLongBox box1, uLongBox box2) => (uLongBox)(box1.Value | box2.Value);
    public static uLongBox operator | (ulong val, uLongBox box) => (uLongBox)(val | box.Value);
    public static uLongBox operator | (uLongBox box, ulong val) => (uLongBox)(box.Value | val);
    
    public static uLongBox operator ^ (uLongBox box1, uLongBox box2) => (uLongBox)(box1.Value ^ box2.Value);
    public static uLongBox operator ^ (ulong val, uLongBox box) => (uLongBox)(val ^ box.Value);
    public static uLongBox operator ^ (uLongBox box, ulong val) => (uLongBox)(box.Value ^ val);
    
    public static uLongBox operator << (uLongBox box, int amount) => (uLongBox)(box.Value << amount);
    public static uLongBox operator >> (uLongBox box, int amount) => (uLongBox)(box.Value >> amount);
    
    public static bool operator == (uLongBox box1, uLongBox box2) => box1.Value == box2.Value;
    public static bool operator == (ulong val, uLongBox box) => val == box.Value;
    public static bool operator == (uLongBox box, ulong val) => box.Value == val;
    
    public static bool operator != (uLongBox box1, uLongBox box2) => box1.Value != box2.Value;
    public static bool operator != (ulong val, uLongBox box) => val != box.Value;
    public static bool operator != (uLongBox box, ulong val) => box.Value != val;
    
    public static bool operator < (uLongBox box1, uLongBox box2) => box1.Value < box2.Value;
    public static bool operator < (ulong val, uLongBox box) => val < box.Value;
    public static bool operator < (uLongBox box, ulong val) => box.Value < val;
    
    public static bool operator > (uLongBox box1, uLongBox box2) => box1.Value > box2.Value;
    public static bool operator > (ulong val, uLongBox box) => val > box.Value;
    public static bool operator > (uLongBox box, ulong val) => box.Value > val;
    
    public static bool operator <= (uLongBox box1, uLongBox box2) => box1.Value <= box2.Value;
    public static bool operator <= (ulong val, uLongBox box) => val <= box.Value;
    public static bool operator <= (uLongBox box, ulong val) => box.Value <= val;
    
    public static bool operator >= (uLongBox box1, uLongBox box2) => box1.Value >= box2.Value;
    public static bool operator >= (ulong val, uLongBox box) => val >= box.Value;
    public static bool operator >= (uLongBox box, ulong val) => box.Value >= val;
    
    public static uLongBox operator + (uLongBox box) => (uLongBox)(+box.Value);
    public static uLongBox operator ~ (uLongBox box) => (uLongBox)(~box.Value);
    public static uLongBox operator ++ (uLongBox box) => (uLongBox)(++box.Value);
    public static uLongBox operator -- (uLongBox box) => (uLongBox)(--box.Value);

    public bool Equals(uLongBox other) => Value.Equals(other);
    public override bool Equals(object obj) => Value.Equals(obj);
    public int CompareTo(uLongBox other) => Value.CompareTo(other);
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
    public DateTime ToDateTime(IFormatProvider provider) => throw new InvalidCastException($"Invalid cast from '{nameof(uLongBox)}' to '{nameof(DateTime)}'.");
    public string ToString(IFormatProvider provider) => Value.ToString(provider);
    public object ToType(Type type, IFormatProvider provider) => (object) Convert.ToUInt64(Value, provider);
}