namespace HKMirror;

/// <summary>
/// Provides values types a way to be passed by reference without using ref parameters
/// </summary>
public sealed class uShortBox : IComparable, IFormattable, IConvertible, IComparable<uShortBox>, IEquatable<uShortBox>
{
    public uShortBox() {}
    public uShortBox(ushort value) => Value = value;
    public ushort Value { get; set; } = default;

    public static explicit operator uShortBox(ushort value) => new (value);
    public static implicit operator ushort(uShortBox box) => box.Value;

    public static uShortBox operator + (uShortBox box1, uShortBox box2) => (uShortBox)(box1.Value + box2.Value);
    public static uShortBox operator + (ushort val, uShortBox box) => (uShortBox)(val + box.Value);
    public static uShortBox operator + (uShortBox box, ushort val) => (uShortBox)(box.Value + val);
    
    public static uShortBox operator - (uShortBox box1, uShortBox box2) => (uShortBox)(box1.Value - box2.Value);
    public static uShortBox operator - (ushort val, uShortBox box) => (uShortBox)(val - box.Value);
    public static uShortBox operator - (uShortBox box, ushort val) => (uShortBox)(box.Value - val);
    
    public static uShortBox operator * (uShortBox box1, uShortBox box2) => (uShortBox)(box1.Value * box2.Value);
    public static uShortBox operator * (ushort val, uShortBox box) => (uShortBox)(val * box.Value);
    public static uShortBox operator * (uShortBox box, ushort val) => (uShortBox)(box.Value * val);
    
    public static uShortBox operator / (uShortBox box1, uShortBox box2) => (uShortBox)(box1.Value / box2.Value);
    public static uShortBox operator / (ushort val, uShortBox box) => (uShortBox)(val / box.Value);
    public static uShortBox operator / (uShortBox box, ushort val) => (uShortBox)(box.Value / val);
    
    public static uShortBox operator % (uShortBox box1, uShortBox box2) => (uShortBox)(box1.Value % box2.Value);
    public static uShortBox operator % (ushort val, uShortBox box) => (uShortBox)(val % box.Value);
    public static uShortBox operator % (uShortBox box, ushort val) => (uShortBox)(box.Value % val);
    
    public static uShortBox operator & (uShortBox box1, uShortBox box2) => (uShortBox)(box1.Value & box2.Value);
    public static uShortBox operator & (ushort val, uShortBox box) => (uShortBox)(val & box.Value);
    public static uShortBox operator & (uShortBox box, ushort val) => (uShortBox)(box.Value & val);
    
    public static uShortBox operator | (uShortBox box1, uShortBox box2) => (uShortBox)(box1.Value | box2.Value);
    public static uShortBox operator | (ushort val, uShortBox box) => (uShortBox)(val | box.Value);
    public static uShortBox operator | (uShortBox box, ushort val) => (uShortBox)(box.Value | val);
    
    public static uShortBox operator ^ (uShortBox box1, uShortBox box2) => (uShortBox)(box1.Value ^ box2.Value);
    public static uShortBox operator ^ (ushort val, uShortBox box) => (uShortBox)(val ^ box.Value);
    public static uShortBox operator ^ (uShortBox box, ushort val) => (uShortBox)(box.Value ^ val);
    
    public static uShortBox operator << (uShortBox box, int amount) => (uShortBox)(box.Value << amount);
    public static uShortBox operator >> (uShortBox box, int amount) => (uShortBox)(box.Value >> amount);
    
    public static bool operator == (uShortBox box1, uShortBox box2) => box1.Value == box2.Value;
    public static bool operator == (ushort val, uShortBox box) => val == box.Value;
    public static bool operator == (uShortBox box, ushort val) => box.Value == val;
    
    public static bool operator != (uShortBox box1, uShortBox box2) => box1.Value != box2.Value;
    public static bool operator != (ushort val, uShortBox box) => val != box.Value;
    public static bool operator != (uShortBox box, ushort val) => box.Value != val;
    
    public static bool operator < (uShortBox box1, uShortBox box2) => box1.Value < box2.Value;
    public static bool operator < (ushort val, uShortBox box) => val < box.Value;
    public static bool operator < (uShortBox box, ushort val) => box.Value < val;
    
    public static bool operator > (uShortBox box1, uShortBox box2) => box1.Value > box2.Value;
    public static bool operator > (ushort val, uShortBox box) => val > box.Value;
    public static bool operator > (uShortBox box, ushort val) => box.Value > val;
    
    public static bool operator <= (uShortBox box1, uShortBox box2) => box1.Value <= box2.Value;
    public static bool operator <= (ushort val, uShortBox box) => val <= box.Value;
    public static bool operator <= (uShortBox box, ushort val) => box.Value <= val;
    
    public static bool operator >= (uShortBox box1, uShortBox box2) => box1.Value >= box2.Value;
    public static bool operator >= (ushort val, uShortBox box) => val >= box.Value;
    public static bool operator >= (uShortBox box, ushort val) => box.Value >= val;
    
    public static uShortBox operator + (uShortBox box) => (uShortBox)(+box.Value);
    public static uShortBox operator ~ (uShortBox box) => (uShortBox)(~box.Value);
    public static uShortBox operator ++ (uShortBox box) => (uShortBox)(++box.Value);
    public static uShortBox operator -- (uShortBox box) => (uShortBox)(--box.Value);

    public bool Equals(uShortBox other) => Value.Equals(other);
    public override bool Equals(object obj) => Value.Equals(obj);
    public int CompareTo(uShortBox other) => Value.CompareTo(other);
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
    public DateTime ToDateTime(IFormatProvider provider) => throw new InvalidCastException($"Invalid cast from '{nameof(uShortBox)}' to '{nameof(DateTime)}'.");
    public string ToString(IFormatProvider provider) => Value.ToString(provider);
    public object ToType(Type type, IFormatProvider provider) => (object) Convert.ToInt32(Value, provider);
}