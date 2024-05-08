using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyBuilding : MonoBehaviour
{
        void OnCollisionEnter(Collision collision)
        {
            if (collision.gameObject.name == "Player")
            {
                Destroy(collision.gameObject);
               
            }
        }
    
}