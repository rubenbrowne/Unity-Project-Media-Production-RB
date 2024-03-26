using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThirdPersonMovement : MonoBehaviour
{
   public CharacterController controller;

   public float speed = 0.01f;


    // Update is called once per frame
    void Update()
    {
        float horizontal = Input.GetAxisRaw("Horizontal");
        float vertical = Input.GetAxisRaw("Vertical");
        Vector3 direction = new Vector3(horizontal, 0f, vertical).normalized * speed;

        if(direction.magnitude >= 0.1f)
        {
            controller.Move(direction );
        }
    }
}
