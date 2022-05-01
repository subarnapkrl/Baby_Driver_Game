using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Delivery : MonoBehaviour
{   bool hasPackage;
    [SerializeField]float destroyDelay=0.5f;

    [SerializeField] Color32 hasPackageColor=new Color32(1,1,1,1);

    [SerializeField] Color32 noPackageColor=new Color32(1,1,1,1);

    SpriteRenderer spriteRenderer;

    void Start(){
        spriteRenderer=GetComponent<SpriteRenderer>();
    }
    void OnCollisionEnter2D(Collision2D other) {
       Debug.Log("Ouch!!!");
   }
    void OnTriggerEnter2D(Collider2D other) {
        if(other.tag=="Package" && hasPackage==false){
            Debug.Log("Package been successfully picked up!!!");
            hasPackage=true;
            Destroy(other.gameObject,destroyDelay);
            spriteRenderer.color=hasPackageColor;
        }
         if(other.tag=="Customer" && hasPackage){
            Debug.Log("Successfully delivered the package to the customer!!!");
            hasPackage=false;
            spriteRenderer.color=noPackageColor;

        }
   }
}
