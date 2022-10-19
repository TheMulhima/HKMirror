namespace HKMirror;

/// <summary>
/// Provides values types a way to be passed by reference without using ref parameters
/// </summary>
public sealed class DecimalBox : IComparable, IFormattable, IConvertible, IComparable<DecimalBox>, IEquatable<DecimalBox>
{
    public DecimalBox() {}
    public DecimalBox(decimal value) => Value = value;
    public decimal Value { get; set; } = default;

    public static explicit operator DecimalBox(decimal value) => new (value);
    public static implicit operator decimal(DecimalBox box) => box.Value;

    public static DecimalBox operator + (DecimalBox box1, DecimalBox box2) => (DecimalBox)(box1.Value + box2.Value);
    public static DecimalBox operator + (decimal val, DecimalBox box) => (DecimalBox)(val + box.Value);
    public static DecimalBox operator + (DecimalBox box, decimal val) => (DecimalBox)(box.Value + val);
    
    public static DecimalBox operator - (DecimalBox box1, DecimalBox box2) => (DecimalBox)(box1.Value - box2.Value);
    public static DecimalBox operator - (decimal val, DecimalBox box) => (DecimalBox)(val - box.Value);
    public static DecimalBox operator - (DecimalBox box, decimal val) => (DecimalBox)(box.Value - val);
    
    public static DecimalBox operator * (DecimalBox box1, DecimalBox box2) => (DecimalBox)(box1.Value * box2.Value);
    public static DecimalBox operator * (decimal val, DecimalBox box) => (DecimalBox)(val * box.Value);
    public static DecimalBox operator * (DecimalBox box, decimal val) => (DecimalBox)(box.Value * val);
    
    public static DecimalBox operator / (DecimalBox box1, DecimalBox box2) => (DecimalBox)(box1.Value / box2.Value);
    public static DecimalBox operator / (decimal val, DecimalBox box) => (DecimalBox)(val / box.Value);
    public static DecimalBox operator / (DecimalBox box, decimal val) => (DecimalBox)(box.Value / val);
    
    public static DecimalBox operator % (DecimalBox box1, DecimalBox box2) => (DecimalBox)(box1.Value % box2.Value);
    public static DecimalBox operator % (decimal val, DecimalBox box) => (DecimalBox)(val % box.Value);
    public static DecimalBox operator % (DecimalBox box, decimal val) => (DecimalBox)(box.Value % val);

    public static bool operator == (DecimalBox box1, DecimalBox box2) => box1.Value == box2.Value;
    public static bool operator == (decimal val, DecimalBox box) => val == box.Value;
    public static bool operator == (DecimalBox box, decimal val) => box.Value == val;
    
    public static bool operator != (DecimalBox box1, DecimalBox box2) => box1.Value != box2.Value;
    public static bool operator != (decimal val, DecimalBox box) => val != box.Value;
    public static bool operator != (DecimalBox box, decimal val) => box.Value != val;
    
    public static bool operator < (DecimalBox box1, DecimalBox box2) => box1.Value < box2.Value;
    public static bool operator < (decimal val, DecimalBox box) => val < box.Value;
    public static bool operator < (DecimalBox box, decimal val) => box.Value < val;
    
    public static bool operator > (DecimalBox box1, DecimalBox box2) => box1.Value > box2.Value;
    public static bool operator > (decimal val, DecimalBox box) => val > box.Value;
    public static bool operator > (DecimalBox box, decimal val) => box.Value > val;
    
    public static bool operator <= (DecimalBox box1, DecimalBox box2) => box1.Value <= box2.Value;
    public static bool operator <= (decimal val, DecimalBox box) => val <= box.Value;
    public static bool operator <= (DecimalBox box, decimal val) => box.Value <= val;
    
    public static bool operator >= (DecimalBox box1, DecimalBox box2) => box1.Value >= box2.Value;
    public static bool operator >= (decimal val, DecimalBox box) => val >= box.Value;
    public static bool operator >= (DecimalBox box, decimal val) => box.Value >= val;
    
    public static DecimalBox operator - (DecimalBox box) => (DecimalBox)(-box.Value);
    public static DecimalBox operator + (DecimalBox box) => (DecimalBox)(+box.Value);
    public static DecimalBox operator ++ (DecimalBox box) => (DecimalBox)(++box.Value);
    public static DecimalBox operator -- (DecimalBox box) => (DecimalBox)(--box.Value);

    public bool Equals(DecimalBox other) => Value.Equals(other);
    public override bool Equals(object obj) => Value.Equals(obj);
    public int CompareTo(DecimalBox other) => Value.CompareTo(other);
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
    public DateTime ToDateTime(IFormatProvider provider) => throw new InvalidCastException($"Invalid cast from '{nameof(DecimalBox)}' to '{nameof(DateTime)}'.");
    public string ToString(IFormatProvider provider) => Value.ToString(provider);
    public object ToType(Type type, IFormatProvider provider) => (object) Convert.ToDecimal(Value, provider);
}