using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour
{
    public Rigidbody2D rb;
    public ManageGame gm;
    public SpriteRenderer EngineSprite;
    
    private float horizontal = 0f;
    private float vertical = 0f;

    void Update()
    {
        horizontal = Input.GetAxis("Horizontal");
        vertical = Input.GetAxis("Vertical");
        if(vertical<0) vertical = 0f;
        
    }

    void FixedUpdate() {
        if(rb.velocity.magnitude > gm.maxSpeed)
         {
            rb.velocity = rb.velocity.normalized * gm.maxSpeed;
         }
        rb.AddForce(transform.up * vertical * Time.fixedDeltaTime * gm.forwardForce);
        
        rb.transform.Rotate(0f , 0f , gm.rotateSpeed * -horizontal * Time.deltaTime);
        if(vertical!=0){
            EngineSprite.sortingOrder = 1;
        }
        if(vertical==0){
            EngineSprite.sortingOrder = -1;
        }

        
    }
}
