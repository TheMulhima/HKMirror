using Object = UnityEngine.Object;

namespace HKMirror.InstanceClasses;

/// <summary>
///     A class that contains all (public and private) fields and methods of PlayMakerArrayListProxy allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class PlayMakerArrayListProxyR : InstanceClassWrapper<PlayMakerArrayListProxy>
{
    public PlayMakerArrayListProxyR(PlayMakerArrayListProxy _orig) : base(_orig)
    {
    }

    public ArrayList _arrayList
    {
        get => orig._arrayList;
        set => orig._arrayList = value;
    }

    public ArrayList _snapShot
    {
        get => GetField<ArrayList>();
        set => SetField(value);
    }

    public bool showEvents
    {
        get => orig.showEvents;
        set => orig.showEvents = value;
    }

    public bool showContent
    {
        get => orig.showContent;
        set => orig.showContent = value;
    }

    public bool TextureElementSmall
    {
        get => orig.TextureElementSmall;
        set => orig.TextureElementSmall = value;
    }

    public bool condensedView
    {
        get => orig.condensedView;
        set => orig.condensedView = value;
    }

    public bool liveUpdate
    {
        get => orig.liveUpdate;
        set => orig.liveUpdate = value;
    }

    public string referenceName
    {
        get => orig.referenceName;
        set => orig.referenceName = value;
    }

    public bool enablePlayMakerEvents
    {
        get => orig.enablePlayMakerEvents;
        set => orig.enablePlayMakerEvents = value;
    }

    public string addEvent
    {
        get => orig.addEvent;
        set => orig.addEvent = value;
    }

    public string setEvent
    {
        get => orig.setEvent;
        set => orig.setEvent = value;
    }

    public string removeEvent
    {
        get => orig.removeEvent;
        set => orig.removeEvent = value;
    }

    public int contentPreviewStartIndex
    {
        get => orig.contentPreviewStartIndex;
        set => orig.contentPreviewStartIndex = value;
    }

    public int contentPreviewMaxRows
    {
        get => orig.contentPreviewMaxRows;
        set => orig.contentPreviewMaxRows = value;
    }

    public int preFillObjectTypeIndex
    {
        get => orig.preFillObjectTypeIndex;
        set => orig.preFillObjectTypeIndex = value;
    }

    public int preFillCount
    {
        get => orig.preFillCount;
        set => orig.preFillCount = value;
    }

    public List<string> preFillKeyList
    {
        get => orig.preFillKeyList;
        set => orig.preFillKeyList = value;
    }

    public List<bool> preFillBoolList
    {
        get => orig.preFillBoolList;
        set => orig.preFillBoolList = value;
    }

    public List<Color> preFillColorList
    {
        get => orig.preFillColorList;
        set => orig.preFillColorList = value;
    }

    public List<float> preFillFloatList
    {
        get => orig.preFillFloatList;
        set => orig.preFillFloatList = value;
    }

    public List<GameObject> preFillGameObjectList
    {
        get => orig.preFillGameObjectList;
        set => orig.preFillGameObjectList = value;
    }

    public List<int> preFillIntList
    {
        get => orig.preFillIntList;
        set => orig.preFillIntList = value;
    }

    public List<Material> preFillMaterialList
    {
        get => orig.preFillMaterialList;
        set => orig.preFillMaterialList = value;
    }

    public List<Object> preFillObjectList
    {
        get => orig.preFillObjectList;
        set => orig.preFillObjectList = value;
    }

    public List<Quaternion> preFillQuaternionList
    {
        get => orig.preFillQuaternionList;
        set => orig.preFillQuaternionList = value;
    }

    public List<Rect> preFillRectList
    {
        get => orig.preFillRectList;
        set => orig.preFillRectList = value;
    }

    public List<string> preFillStringList
    {
        get => orig.preFillStringList;
        set => orig.preFillStringList = value;
    }

    public List<Texture2D> preFillTextureList
    {
        get => orig.preFillTextureList;
        set => orig.preFillTextureList = value;
    }

    public List<Vector2> preFillVector2List
    {
        get => orig.preFillVector2List;
        set => orig.preFillVector2List = value;
    }

    public List<Vector3> preFillVector3List
    {
        get => orig.preFillVector3List;
        set => orig.preFillVector3List = value;
    }

    public List<AudioClip> preFillAudioClipList
    {
        get => orig.preFillAudioClipList;
        set => orig.preFillAudioClipList = value;
    }

    public ArrayList arrayList => orig.arrayList;


    public void Awake()
    {
        orig.Awake();
    }

    public bool isCollectionDefined()
    {
        return orig.isCollectionDefined();
    }

    public void TakeSnapShot()
    {
        orig.TakeSnapShot();
    }

    public void RevertToSnapShot()
    {
        orig.RevertToSnapShot();
    }

    public void Add(object value, string type, bool silent = false)
    {
        orig.Add(value, type, silent);
    }

    public int AddRange(ICollection collection, string type)
    {
        return orig.AddRange(collection, type);
    }

    public void InspectorEdit(int index)
    {
        orig.InspectorEdit(index);
    }

    public void Set(int index, object value, string type)
    {
        orig.Set(index, value, type);
    }

    public bool Remove(object value, string type, bool silent = false)
    {
        return orig.Remove(value, type, silent);
    }

    public void PreFillArrayList()
    {
        CallMethod();
    }
}