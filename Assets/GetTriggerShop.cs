using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetTriggerShop : MonoBehaviour
{
   private void OnTriggerEnter (Collider Other)
   {
    Debug.Log ("TRIGGERED");
   }
}
