using UnityEngine;

public class Stadium_Text : MonoBehaviour
{
    public Camera cameraToLookAt;

    void Update()
    {
        // Makes the object face the camera with an upright orientation
        Vector3 v = cameraToLookAt.transform.position - transform.position;
        v.x = v.z = 0.0f; // This zeroes out unwanted rotation on the x and z axes
        transform.LookAt(cameraToLookAt.transform.position - v);
        transform.rotation = (cameraToLookAt.transform.rotation); // Optional: align rotation according to the camera's rotation
    }
   
}
