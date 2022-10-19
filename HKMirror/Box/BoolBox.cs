namespace HKMirror;

/// <summary>
/// Provides values types a way to be passed by reference without using ref parameters
/// </summary>
public sealed class BoolBox : IComparable, IConvertible, IComparable<BoolBox>, IEquatable<BoolBox>
{
    public BoolBox() {}
    public BoolBox(bool value) => Value = value;
    public bool Value { get; set; } = default;

    public static explicit operator BoolBox(bool value) => new (value);
    public static implicit operator bool(BoolBox box) => box.Value;

    public static BoolBox operator & (BoolBox box1, BoolBox box2) => (BoolBox)(box1.Value & box2.Value);
    public static BoolBox operator & (bool val, BoolBox box) => (BoolBox)(val & box.Value);
    public static BoolBox operator & (BoolBox box, bool val) => (BoolBox)(box.Value & val);
    
    public static BoolBox operator | (BoolBox box1, BoolBox box2) => (BoolBox)(box1.Value | box2.Value);
    public static BoolBox operator | (bool val, BoolBox box) => (BoolBox)(val | box.Value);
    public static BoolBox operator | (BoolBox box, bool val) => (BoolBox)(box.Value | val);
    
    public static BoolBox operator ^ (BoolBox box1, BoolBox box2) => (BoolBox)(box1.Value ^ box2.Value);
    public static BoolBox operator ^ (bool val, BoolBox box) => (BoolBox)(val ^ box.Value);
    public static BoolBox operator ^ (BoolBox box, bool val) => (BoolBox)(box.Value ^ val);
    
    public static bool operator == (BoolBox box1, BoolBox box2) => box1.Value == box2.Value;
    public static bool operator == (bool val, BoolBox box) => val == box.Value;
    public static bool operator == (BoolBox box, bool val) => box.Value == val;
    
    public static bool operator != (BoolBox box1, BoolBox box2) => box1.Value != box2.Value;
    public static bool operator != (bool val, BoolBox box) => val != box.Value;
    public static bool operator != (BoolBox box, bool val) => box.Value != val;

    public bool Equals(BoolBox other) => Value.Equals(other);
    public override bool Equals(object obj) => Value.Equals(obj);
    public int CompareTo(BoolBox other) => Value.CompareTo(other);
    public int CompareTo(object other) => Value.CompareTo(other);
    public override int GetHashCode() => Value.GetHashCode();
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
    public DateTime ToDateTime(IFormatProvider provider) => throw new InvalidCastException($"Invalid cast from '{nameof(BoolBox)}' to '{nameof(DateTime)}'.");
    public string ToString(IFormatProvider provider) => Value.ToString(provider);
    public object ToType(Type type, IFormatProvider provider) => (object) Convert.ToInt32(Value, provider);
}