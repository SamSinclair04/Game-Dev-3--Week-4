using GameDevWithMarco.EnvironmentalProps;
using GameDevWithMarco.Interfaces;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using UnityEngine;

namespace GameDevWithMarco.Player
{
    public class PlayerInteraction : MonoBehaviour
    {
        //To store what we want to interact with
        [SerializeField]GameObject thingIAmCollidingWith;

        

        private void OnTriggerEnter(Collider other)
        {
            //Checks if it is tagged as interactable
            if (other.gameObject.tag == "Interactable")
            {
                //If it is store it so we can interact with it
                thingIAmCollidingWith = other.gameObject;
            }
        }

        private void OnTriggerExit(Collider other)
        {
            //To prevent us from using objects interaction 
            //Even if we are far
            thingIAmCollidingWith = null;
        }

        private void Update()
        {

            //Checks if player is pressing E, then checks if player is colliding with a certain component, if it is, it will fire a method for that specific component
            if (Input.GetKeyDown(KeyCode.E))
            {
               IInteractable interactableObject = thingIAmCollidingWith.GetComponent<IInteractable>();
                if (interactableObject != null)
                {
                    interactableObject.Interact();
                }
            }
        }


    }
}
