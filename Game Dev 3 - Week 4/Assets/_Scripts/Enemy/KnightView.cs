using GameDevWithMarco.ObserverPattern;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace GameDevWithMarco.Enemies
{
    public class KnightView : MonoBehaviour
    {
        [SerializeField] GameEvent playerSpottedEvent;

        bool hasPlayerBeenSpotted = false;
        private void OnTriggerEnter(Collider other)
        {
            if (other.tag == "Player")
            {
                Debug.Log("Player Spotted!");

                playerSpottedEvent.Raise();

                hasPlayerBeenSpotted = true;
            }
        }





        void Start()
        {
        
        }

        // Update is called once per frame
        void Update()
        {
        
        }
    }
}
