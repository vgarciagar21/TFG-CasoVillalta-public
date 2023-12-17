using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GrabbingObject : MonoBehaviour, InterfaceInteractable
{
    [SerializeField] private Transform handTarget;
    [SerializeField] private Transform gameObjectStartingPosition;
    public GameObject detective;
    private Animator detectiveAnimator;
    public float velocidadMovimiento = 2.0f;
    private bool isGrabbing = false;

    private void Awake() {
      detectiveAnimator = detective.GetComponent<Animator>();
      gameObjectStartingPosition.position = gameObject.transform.position;
    }

    public string GetDescription(){
        return "Ver";
    }

    public void Interact(){
        if (!isGrabbing)
        {
            handTarget.position = gameObject.transform.position;
            detectiveAnimator.SetTrigger("GrabbingObject");
            //gameObject.transform.position = handTarget.position;
            isGrabbing = true;
        }
        else {
            detectiveAnimator.Rebind();
            isGrabbing = false;
        }

    }

    private void Update() {
        if (isGrabbing && Input.GetKeyDown(KeyCode.E))
            Interact();
    }

}
