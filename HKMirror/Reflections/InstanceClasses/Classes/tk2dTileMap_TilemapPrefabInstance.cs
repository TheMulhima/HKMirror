namespace HKMirror.Reflection.InstanceClasses;

/// <summary>
///     A class that contains all (public and private) fields and methods of tk2dTileMap_TilemapPrefabInstance allowing you
///     to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class tk2dTileMap_TilemapPrefabInstanceR : InstanceClassWrapper<tk2dTileMap.TilemapPrefabInstance>
{
    public tk2dTileMap_TilemapPrefabInstanceR(tk2dTileMap.TilemapPrefabInstance _orig) : base(_orig)
    {
    }

    public int x
    {
        get => orig.x;
        set => orig.x = value;
    }

    public int y
    {
        get => orig.y;
        set => orig.y = value;
    }

    public int layer
    {
        get => orig.layer;
        set => orig.layer = value;
    }

    public GameObject instance
    {
        get => orig.instance;
        set => orig.instance = value;
    }
}