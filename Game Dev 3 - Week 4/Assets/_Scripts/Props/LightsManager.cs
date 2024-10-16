using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace GameDevWithMarco.EnvironmentalProps
{
    public class LightsManager : MonoBehaviour
    {

        private List<Light> lightsWeWantToInteractWith;

        [SerializeField] Color ominousColour;
        
        
        
        // Start is called before the first frame update
        void Start()
        {
            lightsWeWantToInteractWith = new List<Light>();
            
            Light[] lightsInTheScene = FindObjectsOfType<Light>();

            foreach (Light light in lightsInTheScene)
            {
                lightsWeWantToInteractWith.Add(light);
            }
        }


        public void ChangeToOminousColour()
        {
            foreach (Light light in lightsWeWantToInteractWith)
            {
                light.DOColor(ominousColour, 0.5f);
            }
        }




        // Update is called once per frame
        void Update()
        {
        
        }
    }
}
