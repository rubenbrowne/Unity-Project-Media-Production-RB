using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickupItem : MonoBehaviour
{
    public AudioClip pickupSound;  // Drag and drop the pickup sound in the inspector

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))  // Make sure your player GameObject has the tag "Player"
        {
            if (pickupSound != null)
            {
                AudioSource.PlayClipAtPoint(pickupSound, transform.position);
            }
            Destroy(gameObject);  // Destroy the water bottle object
        }
    }
}