using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectibleController : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        // Log the name of the object that entered the trigger
        Debug.Log(other.gameObject.name + " entered the trigger of " + gameObject.name);

        // Check if the other object has the "Player" tag and if this object has the "Collectible" tag
        if (other.gameObject.CompareTag("Player") && gameObject.CompareTag("Collectible"))
        {
            // Log the destruction of the collectible
            Debug.Log("Collectible " + gameObject.name + " touched by the player. Destroying the collectible.");
            // Destroy the collectible
            Destroy(gameObject);
        }
    }
}
