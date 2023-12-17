using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChattingNPC : MonoBehaviour, InterfaceInteractable
{
    public string GetDescription() {
        return "Hablar";
    }

    public void Interact()
    {
        Debug.Log("Hola inspector");
    }

}
