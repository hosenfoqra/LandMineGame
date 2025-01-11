using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerJump : MonoBehaviour
{
   Rigidbody2D rb;
   [SerializeField] float jumpPower = 15;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

   
    void Update()
    {
     if (Input.GetButtonDown("Jump"))
     {
         rb.velocity = new Vector2(rb.velocity.x , jumpPower);
     }   
    }
}
