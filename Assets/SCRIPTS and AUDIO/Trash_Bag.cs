using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trash_Bag : MonoBehaviour

{
    public GameObject rubbishPrefab;  // Assign this in the inspector
    public Transform spawnPoint;      // Assign a spawn point in the inspector

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))  // Use spacebar as the button
        {
            for (int i = 0; i < 10; i++)  // Instantiate 10 pieces of rubbish
            {
                Instantiate(rubbishPrefab, spawnPoint.position + Random.insideUnitSphere * 2, Random.rotation);
            }
        }
    }
}