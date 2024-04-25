using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trash_Infomation : MonoBehaviour
{
    public Transform playerCamera;

    void Update()
    {
        Vector3 direction = playerCamera.position - transform.position;
        Quaternion rotation = Quaternion.LookRotation(direction);
        transform.rotation = Quaternion.Lerp(transform.rotation, rotation, Time.deltaTime * 5);
    }
}