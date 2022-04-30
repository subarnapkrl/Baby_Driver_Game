using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Delivery : MonoBehaviour
{   bool hasPackage;
    void OnCollisionEnter2D(Collision2D other) {
       Debug.Log("Ouch!!!");
   }
    void OnTriggerEnter2D(Collider2D other) {
        if(other.tag=="Package"){
            Debug.Log("Package been successfully picked up!!!");
            hasPackage=true;
        }
         if(other.tag=="Customer" && hasPackage){
            Debug.Log("Successfully delivered the package to the customer!!!");
            hasPackage=false;

        }
   }
}
