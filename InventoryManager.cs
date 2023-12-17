using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryManager : MonoBehaviour
{
    [SerializeField] private GameObject InventoryCanvas = null;
    //public bool isInteracting;
    public bool showInventory;
    public bool inventoryOpened;
    // Start is called before the first frame update
    [SerializeField] public GameObject ArtFiguresUI;
    [SerializeField] public GameObject PoolBallsUI;
    [SerializeField] public GameObject ChessPiecesUI;
    [SerializeField] public GameObject ToolsUI;

    //Structure: CollectionObject.TypeCollection - List of objects
    private Dictionary<TypeCollection, List<CollectionObject>> collectibles;
    //Structure: Name of object - Counter (until 5 each)
    private Dictionary<string, int> artFiguresCounter;

    private CollectionType collectionObject;

    //Art figures pics:
    [SerializeField] private Image artFigure1;
    [SerializeField] private Image artFigure2;
    [SerializeField] private Image artFigure3;

    private Text countArtFigures1;
    private Text countArtFigures2;
    private Text countArtFigures3;
    private int totalArtFigures = 0;

    //Pool balls pics:
    [SerializeField] private Image poolBall1;
    [SerializeField] private Image poolBall2;
    [SerializeField] private Image poolBall3;
    [SerializeField] private Image poolBall4;

    //Lottery numbers:
    [SerializeField] private Image lotteryNumber1;
    [SerializeField] private Image lotteryNumber2;
    [SerializeField] private Image lotteryNumber3;

    //Tools pics:
    [SerializeField] private Image flashlight;
    [SerializeField] private Image battery1;
    [SerializeField] private Image battery2;
    [SerializeField] private Image battery3;
    [SerializeField] private Image screwdriver;
    [SerializeField] private Image ;

    [SerializeField] private MonoBehaviour detectiveMovementScript;
    [SerializeField] private MonoBehaviour detectiveViewScript;

    void Awake() {
        InventoryCanvas.SetActive(false);
        ArtFiguresUI.SetActive(false);
        PoolBallsUI.SetActive(false);
        ChessPiecesUI.SetActive(false);
        ToolsUI.SetActive(false);
    }

    void Start() {
        collectibles = new Dictionary<TypeCollection, List<CollectionObject>>();
        artFiguresCounter = new Dictionary<string, int>();
    }


    // Update is called once per frame
    void Update()
    { 
        if (Input.GetKeyDown(KeyCode.Q))
        {
            //We invert the current Inventory status
            showInventory = !showInventory;
            if (showInventory)
            {
                openInventory();
            }
            else
                closeInventory();
        }
    }

    void openInventory() {
        InventoryCanvas.SetActive(true);
        inventoryOpened = true;
        showInventory = true;
        detectiveMovementScript.enabled = false;
        detectiveViewScript.enabled = false;
    }

    void closeInventory() {
        InventoryCanvas.SetActive(false);
        inventoryOpened = false;
        showInventory = false;
        detectiveMovementScript.enabled = true;
        detectiveViewScript.enabled = true;
    }

    private void addObjectToInventory(TypeCollection objectTypeCollection, string objectName) {
        //Is an art figure
        if (objectTypeCollection == 0) {
            ArtFiguresUI.SetActive(true);
            if(objectName==)
        }

        collectionObject = new collectionObject(objectTypeCollection, objectName);
        collectibles.Add(collectionObject.getTypeCollection(), collectionObject.ObjectName());


    }


        }

    }
}

