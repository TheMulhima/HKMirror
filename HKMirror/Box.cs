namespace HKMirror;
public sealed class Box<T>
{
    public Box() {}

    public Box(T value) => Value = value;

    public T Value { get; set; }

    public static implicit operator T(Box<T> box) => box.Value;

    public static explicit operator Box<T>(T value) => new(value);
}