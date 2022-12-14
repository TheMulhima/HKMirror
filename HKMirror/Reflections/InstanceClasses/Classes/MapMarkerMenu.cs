using TMPro;

namespace HKMirror.Reflection.InstanceClasses;

/// <summary>
///     A class that contains all (public and private) fields and methods of MapMarkerMenu allowing you to easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class MapMarkerMenuR : InstanceClassWrapper<MapMarkerMenu>
{
    public MapMarkerMenuR(MapMarkerMenu _orig) : base(_orig)
    {
    }

    public float xPos_start
    {
        get => orig.xPos_start;
        set => orig.xPos_start = value;
    }

    public float xPos_interval
    {
        get => orig.xPos_interval;
        set => orig.xPos_interval = value;
    }

    public float markerY
    {
        get => orig.markerY;
        set => orig.markerY = value;
    }

    public float markerZ
    {
        get => orig.markerZ;
        set => orig.markerZ = value;
    }

    public float uiPause
    {
        get => orig.uiPause;
        set => orig.uiPause = value;
    }

    public FadeGroup fadeGroup
    {
        get => orig.fadeGroup;
        set => orig.fadeGroup = value;
    }

    public AudioSource audioSource
    {
        get => orig.audioSource;
        set => orig.audioSource = value;
    }

    public AudioClip placeClip
    {
        get => orig.placeClip;
        set => orig.placeClip = value;
    }

    public AudioClip removeClip
    {
        get => orig.removeClip;
        set => orig.removeClip = value;
    }

    public AudioClip cursorClip
    {
        get => orig.cursorClip;
        set => orig.cursorClip = value;
    }

    public AudioClip failureClip
    {
        get => orig.failureClip;
        set => orig.failureClip = value;
    }

    public VibrationData placementVibration
    {
        get => orig.placementVibration;
        set => orig.placementVibration = value;
    }

    public GameObject cursor
    {
        get => orig.cursor;
        set => orig.cursor = value;
    }

    public PlayMakerFSM cursorTweenFSM
    {
        get => orig.cursorTweenFSM;
        set => orig.cursorTweenFSM = value;
    }

    public GameObject placementCursor
    {
        get => orig.placementCursor;
        set => orig.placementCursor = value;
    }

    public GameObject placementBox
    {
        get => orig.placementBox;
        set => orig.placementBox = value;
    }

    public GameObject changeButton
    {
        get => orig.changeButton;
        set => orig.changeButton = value;
    }

    public GameObject cancelButton
    {
        get => orig.cancelButton;
        set => orig.cancelButton = value;
    }

    public TextMeshPro actionText
    {
        get => orig.actionText;
        set => orig.actionText = value;
    }

    public GameObject marker_b
    {
        get => orig.marker_b;
        set => orig.marker_b = value;
    }

    public GameObject marker_r
    {
        get => orig.marker_r;
        set => orig.marker_r = value;
    }

    public GameObject marker_w
    {
        get => orig.marker_w;
        set => orig.marker_w = value;
    }

    public GameObject marker_y
    {
        get => orig.marker_y;
        set => orig.marker_y = value;
    }

    public TextMeshPro amount_b
    {
        get => orig.amount_b;
        set => orig.amount_b = value;
    }

    public TextMeshPro amount_r
    {
        get => orig.amount_r;
        set => orig.amount_r = value;
    }

    public TextMeshPro amount_w
    {
        get => orig.amount_w;
        set => orig.amount_w = value;
    }

    public TextMeshPro amount_y
    {
        get => orig.amount_y;
        set => orig.amount_y = value;
    }

    public Vector3 placementCursorOrigin
    {
        get => orig.placementCursorOrigin;
        set => orig.placementCursorOrigin = value;
    }

    public float panSpeed
    {
        get => orig.panSpeed;
        set => orig.panSpeed = value;
    }

    public float placementCursorMinX
    {
        get => orig.placementCursorMinX;
        set => orig.placementCursorMinX = value;
    }

    public float placementCursorMaxX
    {
        get => orig.placementCursorMaxX;
        set => orig.placementCursorMaxX = value;
    }

    public float placementCursorMinY
    {
        get => orig.placementCursorMinY;
        set => orig.placementCursorMinY = value;
    }

    public float placementCursorMaxY
    {
        get => orig.placementCursorMaxY;
        set => orig.placementCursorMaxY = value;
    }

    public List<GameObject> collidingMarkers
    {
        get => orig.collidingMarkers;
        set => orig.collidingMarkers = value;
    }

    public GameObject placeEffectPrefab
    {
        get => orig.placeEffectPrefab;
        set => orig.placeEffectPrefab = value;
    }

    public GameObject removeEffectPrefab
    {
        get => orig.removeEffectPrefab;
        set => orig.removeEffectPrefab = value;
    }

    public Sprite spriteBlue
    {
        get => orig.spriteBlue;
        set => orig.spriteBlue = value;
    }

    public Sprite spriteRed
    {
        get => orig.spriteRed;
        set => orig.spriteRed = value;
    }

    public Sprite spriteYellow
    {
        get => orig.spriteYellow;
        set => orig.spriteYellow = value;
    }

    public Sprite spriteWhite
    {
        get => orig.spriteWhite;
        set => orig.spriteWhite = value;
    }

    public GameManager gm
    {
        get => GetField<GameManager>();
        set => SetField(value);
    }

    public PlayerData pd
    {
        get => GetField<PlayerData>();
        set => SetField(value);
    }

    public InputHandler inputHandler
    {
        get => GetField<InputHandler>();
        set => SetField(value);
    }

    public GameObject gameMapObject
    {
        get => GetField<GameObject>();
        set => SetField(value);
    }

    public GameMap gameMap
    {
        get => GetField<GameMap>();
        set => SetField(value);
    }

    public bool hasMarker_r
    {
        get => GetField<bool>();
        set => SetField(value);
    }

    public bool hasMarker_b
    {
        get => GetField<bool>();
        set => SetField(value);
    }

    public bool hasMarker_y
    {
        get => GetField<bool>();
        set => SetField(value);
    }

    public bool hasMarker_w
    {
        get => GetField<bool>();
        set => SetField(value);
    }

    public int spareMarkers_r
    {
        get => GetField<int>();
        set => SetField(value);
    }

    public int spareMarkers_b
    {
        get => GetField<int>();
        set => SetField(value);
    }

    public int spareMarkers_y
    {
        get => GetField<int>();
        set => SetField(value);
    }

    public int spareMarkers_w
    {
        get => GetField<int>();
        set => SetField(value);
    }

    public int state
    {
        get => GetField<int>();
        set => SetField(value);
    }

    public int markerSelected
    {
        get => GetField<int>();
        set => SetField(value);
    }

    public float timer
    {
        get => GetField<float>();
        set => SetField(value);
    }

    public float confirmTimer
    {
        get => GetField<float>();
        set => SetField(value);
    }

    public float placementTimer
    {
        get => GetField<float>();
        set => SetField(value);
    }

    public Color enabledColour
    {
        get => GetField<Color>();
        set => SetField(value);
    }

    public Color disabledColour
    {
        get => GetField<Color>();
        set => SetField(value);
    }

    public bool collidingWithMarker
    {
        get => GetField<bool>();
        set => SetField(value);
    }

    public string placeString
    {
        get => GetField<string>();
        set => SetField(value);
    }

    public string removeString
    {
        get => GetField<string>();
        set => SetField(value);
    }


    public void Update()
    {
        CallMethod();
    }

    public void Open()
    {
        orig.Open();
    }

    public void Close()
    {
        orig.Close();
    }

    public void StartMarkerPlacement()
    {
        CallMethod();
    }

    public void PanMap()
    {
        CallMethod();
    }

    public void MarkerSelect(int selection)
    {
        CallMethod(new object[] { selection });
    }

    public void PlaceMarker()
    {
        CallMethod();
    }

    public void RemoveMarker()
    {
        CallMethod();
    }

    public void MarkerSelectLeft()
    {
        CallMethod();
    }

    public void MarkerSelectRight()
    {
        CallMethod();
    }

    public void UpdateAmounts()
    {
        CallMethod();
    }

    public void AddToCollidingList(GameObject go)
    {
        orig.AddToCollidingList(go);
    }

    public void RemoveFromCollidingList(GameObject go)
    {
        orig.RemoveFromCollidingList(go);
    }

    public void IsColliding()
    {
        CallMethod();
    }

    public void IsNotColliding()
    {
        CallMethod();
    }
}