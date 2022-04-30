using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Delivery : MonoBehaviour
{   bool hasPackage;
    [SerializeField]float destroyDelay=0.5f;
    void OnCollisionEnter2D(Collision2D other) {
       Debug.Log("Ouch!!!");
   }
    void OnTriggerEnter2D(Collider2D other) {
        if(other.tag=="Package" && hasPackage==false){
            Debug.Log("Package been successfully picked up!!!");
            hasPackage=true;
            Destroy(other.gameObject,destroyDelay);
        }
         if(other.tag=="Customer" && hasPackage){
            Debug.Log("Successfully delivered the package to the customer!!!");
            hasPackage=false;

        }
   }
}
