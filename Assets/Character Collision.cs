using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterCollision : MonoBehaviour
{
   void OnTriggerEnter(Collider other) {
   if (other.gameObject.tag == "obstacle") {

    print("Enter");
   }
}



   void OnTriggerStay(Collider other) {
   if (other.gameObject.tag == "obstacle") {

    print("Stay");
   }

   }

   void onTriggerExit(Collider other) {
   if (other.gameObject.tag == "obstacle") {

    print("Exit");
   }

   }
}
