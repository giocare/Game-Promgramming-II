using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private float moveInput;
    private Rigidbody2D rb;
    public float speed;

    private bool faceR = true;

    public float jumpForce;

    private bool isGrounded;
    public Transform groundCheck;
    public LayerMask whatIsGroundl;
    public float checkRadius;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow) && isGrounded)
        {
            rb.velocity = Vector2.up * jumpForce;
        }
      
    }

    //called every frame - use for physics
    private void FixedUpdate()
    {
        isGrounded = Physics2D.OverlapCircle(groundCheck.position, checkRadius, whatIsGroundl); //

        moveInput = Input.GetAxis("Horizontal");
        rb.velocity = new Vector2(moveInput*speed, rb.velocity.y);
        //if we're facing right and the move input is negative(moving to left) -> then flip
        if (faceR && moveInput < 0){
            Flip();
        }
        else if( !faceR && moveInput > 0)
        {
            Flip();
        }
    }

    void Flip()
    {
        faceR = !faceR;
        Vector3 scalar = transform.localScale;
        scalar.x *= -1;
        transform.localScale = scalar; //flips our player

    }
}
