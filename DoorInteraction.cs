using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorInteraction : MonoBehaviour, InterfaceInteractable
{ 
    public Animator openCloseAnimation;
    public AudioSource openDoorSound;
    public AudioSource closeDoorSound;
    public bool isOpen;

    void Awake()
    {
        isOpen = false;
        //openDoorSound.enabled = false;
        //closeDoorSound.enabled = false;
    }
    public string GetDescription()
    {
        if (!isOpen) {
            return "Abrir";
        } else return "Cerrar";
    }

    public void Interact()
    {
        if (isOpen == false) {
            //StartCoroutine(opening());
            openingDoor();
        } else
            closingDoor();
    }

    private void openingDoor()
    {
        openCloseAnimation.Play("Opening");
        isOpen = true;
        openDoorSound.enabled=true;
        //openDoorSound.enabled = false;
    }

    private void closingDoor()
    {
        openCloseAnimation.Play("Closing");
        isOpen = false;
        closeDoorSound.enabled = true;
        //yield return new WaitForSeconds(.5f);
        //closeDoorSound.enabled = false;
    }


}
