using System.IO;
using System.Linq;
using HKMirror.Generator;

namespace HKMirror;

public sealed class HKMirrorMod : Mod
{
    public override string GetVersion()
    {
        return "v1.0.0.0";
    }

    public override void Initialize()
    {
        Log("Loading HKMirror Mod");

        var Dir = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) + "/Hooks";

        if (!Directory.Exists(Dir))
        {
            Directory.CreateDirectory(Dir);
        }

        foreach (var type in typeof(HeroController).Assembly.GetTypes().Where(t => t.IsClass && !t.IsAbstract))
        {
            try
            {
                _ = new HookGenerator(type, type.Name, Dir, false);
            }
            catch (Exception e)
            {
                LogError($"Did not generate for {type}");
                LogError(e);
            }
        }

        MyEvent += (self, amount) =>
        {
            amount.Value += 5;
        };
    }
    /// <summary>
    /// A wrapper around value types. Use .Value to get and set the value of it
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public sealed class Box<T> where T : struct {
        public Box() {
        }

        public Box(T value) =>
            Value = value;

        public T Value { get; set; }

        public static implicit operator T(Box<T> box) => box.Value;

        public static explicit operator Box<T>(T value) => new(value);
    }
    
    public delegate void AppendLineFormat_args(GameManager self, Box<int> amount);

    public static event AppendLineFormat_args MyEvent;
}