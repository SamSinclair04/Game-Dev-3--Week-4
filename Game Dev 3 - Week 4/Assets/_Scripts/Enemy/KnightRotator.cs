using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace GameDevWithMarco
{
    public class KnightRotator : MonoBehaviour
    {

        [SerializeField] float speed;
        
        
        
        // Start is called before the first frame update
        void Start()
        {
        
        }

        // Update is called once per frame
        void Update()
        {
            transform.Rotate(Vector3.up, speed * Time.deltaTime);
         
        }
    }
}
