using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectingInteraction : MonoBehaviour, InterfaceInteractable
{


    [SerializeField] private Transform handTarget;
    public GameObject detective;
    private Animator detectiveAnimator;
    private bool isMoving = false;
    public GameObject objectCollectable;
    public InventoryManager inventory;
    public collectionType collectionObject;

    private void Awake(){
        detectiveAnimator = detective.GetComponent<Animator>();
        collectionObject = gameObject;
    }

    public string GetDescription()
    {
        return "Coger";
    }

    public void Interact()
    {
        //handTarget.position = gameObject.transform.position;
        if (gameObject != null) {
            detectiveAnimator.SetTrigger("CollectingObject");
            inventory.addObjectToInventory(collectionObject.getTypeCollection(), collectionObject.ObjectName());
            Destroy(gameObject);
        }
    }
}
