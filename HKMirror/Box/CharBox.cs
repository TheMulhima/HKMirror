namespace HKMirror;

/// <summary>
/// Provides values types a way to be passed by reference without using ref parameters
/// </summary>
public sealed class CharBox : IComparable, IConvertible, IComparable<CharBox>, IEquatable<CharBox>
{
    public CharBox() {}
    public CharBox(char value) => Value = value;
    public char Value { get; set; } = default;

    public static explicit operator CharBox(char value) => new (value);
    public static implicit operator char(CharBox box) => box.Value;

    public static CharBox operator + (CharBox box1, CharBox box2) => (CharBox)(box1.Value + box2.Value);
    public static CharBox operator + (char val, CharBox box) => (CharBox)(val + box.Value);
    public static CharBox operator + (CharBox box, char val) => (CharBox)(box.Value + val);
    
    public static CharBox operator - (CharBox box1, CharBox box2) => (CharBox)(box1.Value - box2.Value);
    public static CharBox operator - (char val, CharBox box) => (CharBox)(val - box.Value);
    public static CharBox operator - (CharBox box, char val) => (CharBox)(box.Value - val);
    
    public static CharBox operator * (CharBox box1, CharBox box2) => (CharBox)(box1.Value * box2.Value);
    public static CharBox operator * (char val, CharBox box) => (CharBox)(val * box.Value);
    public static CharBox operator * (CharBox box, char val) => (CharBox)(box.Value * val);
    
    public static CharBox operator / (CharBox box1, CharBox box2) => (CharBox)(box1.Value / box2.Value);
    public static CharBox operator / (char val, CharBox box) => (CharBox)(val / box.Value);
    public static CharBox operator / (CharBox box, char val) => (CharBox)(box.Value / val);
    
    public static CharBox operator % (CharBox box1, CharBox box2) => (CharBox)(box1.Value % box2.Value);
    public static CharBox operator % (char val, CharBox box) => (CharBox)(val % box.Value);
    public static CharBox operator % (CharBox box, char val) => (CharBox)(box.Value % val);
    
    public static CharBox operator & (CharBox box1, CharBox box2) => (CharBox)(box1.Value & box2.Value);
    public static CharBox operator & (char val, CharBox box) => (CharBox)(val & box.Value);
    public static CharBox operator & (CharBox box, char val) => (CharBox)(box.Value & val);
    
    public static CharBox operator | (CharBox box1, CharBox box2) => (CharBox)(box1.Value | box2.Value);
    public static CharBox operator | (char val, CharBox box) => (CharBox)(val | box.Value);
    public static CharBox operator | (CharBox box, char val) => (CharBox)(box.Value | val);
    
    public static CharBox operator ^ (CharBox box1, CharBox box2) => (CharBox)(box1.Value ^ box2.Value);
    public static CharBox operator ^ (char val, CharBox box) => (CharBox)(val ^ box.Value);
    public static CharBox operator ^ (CharBox box, char val) => (CharBox)(box.Value ^ val);
    
    public static CharBox operator << (CharBox box, int amount) => (CharBox)(box.Value << amount);
    public static CharBox operator >> (CharBox box, int amount) => (CharBox)(box.Value >> amount);
    
    public static bool operator == (CharBox box1, CharBox box2) => box1.Value == box2.Value;
    public static bool operator == (char val, CharBox box) => val == box.Value;
    public static bool operator == (CharBox box, char val) => box.Value == val;
    
    public static bool operator != (CharBox box1, CharBox box2) => box1.Value != box2.Value;
    public static bool operator != (char val, CharBox box) => val != box.Value;
    public static bool operator != (CharBox box, char val) => box.Value != val;
    
    public static bool operator < (CharBox box1, CharBox box2) => box1.Value < box2.Value;
    public static bool operator < (char val, CharBox box) => val < box.Value;
    public static bool operator < (CharBox box, char val) => box.Value < val;
    
    public static bool operator > (CharBox box1, CharBox box2) => box1.Value > box2.Value;
    public static bool operator > (char val, CharBox box) => val > box.Value;
    public static bool operator > (CharBox box, char val) => box.Value > val;
    
    public static bool operator <= (CharBox box1, CharBox box2) => box1.Value <= box2.Value;
    public static bool operator <= (char val, CharBox box) => val <= box.Value;
    public static bool operator <= (CharBox box, char val) => box.Value <= val;
    
    public static bool operator >= (CharBox box1, CharBox box2) => box1.Value >= box2.Value;
    public static bool operator >= (char val, CharBox box) => val >= box.Value;
    public static bool operator >= (CharBox box, char val) => box.Value >= val;
    
    public static CharBox operator + (CharBox box) => (CharBox)(+box.Value);
    public static CharBox operator ~ (CharBox box) => (CharBox)(~box.Value);
    public static CharBox operator ++ (CharBox box) => (CharBox)(++box.Value);
    public static CharBox operator -- (CharBox box) => (CharBox)(--box.Value);

    public bool Equals(CharBox other) => Value.Equals(other);
    public override bool Equals(object obj) => Value.Equals(obj);
    public int CompareTo(CharBox other) => Value.CompareTo(other);
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
    public DateTime ToDateTime(IFormatProvider provider) => throw new InvalidCastException($"Invalid cast from '{nameof(CharBox)}' to '{nameof(DateTime)}'.");
    public string ToString(IFormatProvider provider) => Value.ToString(provider);
    public object ToType(Type type, IFormatProvider provider) => (object) Convert.ToChar(Value, provider);
}