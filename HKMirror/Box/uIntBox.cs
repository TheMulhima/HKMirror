namespace HKMirror;

/// <summary>
/// Provides values types a way to be passed by reference without using ref parameters
/// </summary>
public sealed class uIntBox : IComparable, IFormattable, IConvertible, IComparable<uIntBox>, IEquatable<uIntBox>
{
    public uIntBox() {}
    public uIntBox(uint value) => Value = value;
    public uint Value { get; set; } = default;

    public static explicit operator uIntBox(uint value) => new (value);
    public static implicit operator uint(uIntBox box) => box.Value;

    public static uIntBox operator + (uIntBox box1, uIntBox box2) => (uIntBox)(box1.Value + box2.Value);
    public static uIntBox operator + (uint val, uIntBox box) => (uIntBox)(val + box.Value);
    public static uIntBox operator + (uIntBox box, uint val) => (uIntBox)(box.Value + val);
    
    public static uIntBox operator - (uIntBox box1, uIntBox box2) => (uIntBox)(box1.Value - box2.Value);
    public static uIntBox operator - (uint val, uIntBox box) => (uIntBox)(val - box.Value);
    public static uIntBox operator - (uIntBox box, uint val) => (uIntBox)(box.Value - val);
    
    public static uIntBox operator * (uIntBox box1, uIntBox box2) => (uIntBox)(box1.Value * box2.Value);
    public static uIntBox operator * (uint val, uIntBox box) => (uIntBox)(val * box.Value);
    public static uIntBox operator * (uIntBox box, uint val) => (uIntBox)(box.Value * val);
    
    public static uIntBox operator / (uIntBox box1, uIntBox box2) => (uIntBox)(box1.Value / box2.Value);
    public static uIntBox operator / (uint val, uIntBox box) => (uIntBox)(val / box.Value);
    public static uIntBox operator / (uIntBox box, uint val) => (uIntBox)(box.Value / val);
    
    public static uIntBox operator % (uIntBox box1, uIntBox box2) => (uIntBox)(box1.Value % box2.Value);
    public static uIntBox operator % (uint val, uIntBox box) => (uIntBox)(val % box.Value);
    public static uIntBox operator % (uIntBox box, uint val) => (uIntBox)(box.Value % val);
    
    public static uIntBox operator & (uIntBox box1, uIntBox box2) => (uIntBox)(box1.Value & box2.Value);
    public static uIntBox operator & (uint val, uIntBox box) => (uIntBox)(val & box.Value);
    public static uIntBox operator & (uIntBox box, uint val) => (uIntBox)(box.Value & val);
    
    public static uIntBox operator | (uIntBox box1, uIntBox box2) => (uIntBox)(box1.Value | box2.Value);
    public static uIntBox operator | (uint val, uIntBox box) => (uIntBox)(val | box.Value);
    public static uIntBox operator | (uIntBox box, uint val) => (uIntBox)(box.Value | val);
    
    public static uIntBox operator ^ (uIntBox box1, uIntBox box2) => (uIntBox)(box1.Value ^ box2.Value);
    public static uIntBox operator ^ (uint val, uIntBox box) => (uIntBox)(val ^ box.Value);
    public static uIntBox operator ^ (uIntBox box, uint val) => (uIntBox)(box.Value ^ val);
    
    public static uIntBox operator << (uIntBox box, int amount) => (uIntBox)(box.Value << amount);
    public static uIntBox operator >> (uIntBox box, int amount) => (uIntBox)(box.Value >> amount);
    
    public static bool operator == (uIntBox box1, uIntBox box2) => box1.Value == box2.Value;
    public static bool operator == (uint val, uIntBox box) => val == box.Value;
    public static bool operator == (uIntBox box, uint val) => box.Value == val;
    
    public static bool operator != (uIntBox box1, uIntBox box2) => box1.Value != box2.Value;
    public static bool operator != (uint val, uIntBox box) => val != box.Value;
    public static bool operator != (uIntBox box, uint val) => box.Value != val;
    
    public static bool operator < (uIntBox box1, uIntBox box2) => box1.Value < box2.Value;
    public static bool operator < (uint val, uIntBox box) => val < box.Value;
    public static bool operator < (uIntBox box, uint val) => box.Value < val;
    
    public static bool operator > (uIntBox box1, uIntBox box2) => box1.Value > box2.Value;
    public static bool operator > (uint val, uIntBox box) => val > box.Value;
    public static bool operator > (uIntBox box, uint val) => box.Value > val;
    
    public static bool operator <= (uIntBox box1, uIntBox box2) => box1.Value <= box2.Value;
    public static bool operator <= (uint val, uIntBox box) => val <= box.Value;
    public static bool operator <= (uIntBox box, uint val) => box.Value <= val;
    
    public static bool operator >= (uIntBox box1, uIntBox box2) => box1.Value >= box2.Value;
    public static bool operator >= (uint val, uIntBox box) => val >= box.Value;
    public static bool operator >= (uIntBox box, uint val) => box.Value >= val;
    
    public static uIntBox operator - (uIntBox box) => (uIntBox)(-box.Value);
    public static uIntBox operator + (uIntBox box) => (uIntBox)(+box.Value);
    public static uIntBox operator ~ (uIntBox box) => (uIntBox)(~box.Value);
    public static uIntBox operator ++ (uIntBox box) => (uIntBox)(++box.Value);
    public static uIntBox operator -- (uIntBox box) => (uIntBox)(--box.Value);

    public bool Equals(uIntBox other) => Value.Equals(other);
    public override bool Equals(object obj) => Value.Equals(obj);
    public int CompareTo(uIntBox other) => Value.CompareTo(other);
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
    public DateTime ToDateTime(IFormatProvider provider) => throw new InvalidCastException($"Invalid cast from '{nameof(uIntBox)}' to '{nameof(DateTime)}'.");
    public string ToString(IFormatProvider provider) => Value.ToString(provider);
    public object ToType(Type type, IFormatProvider provider) => (object) Convert.ToUInt32(Value, provider);
}