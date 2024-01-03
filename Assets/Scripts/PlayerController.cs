using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float moveSpeed;
    public Rigidbody2D theRB;
    public float jumpForce;
    private bool isGrounded;
    public Transform groundCheckPoint;
    public LayerMask whatIsGround;
    private bool canDoubleJump;
    private Animator anim;

    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        theRB.velocity = new Vector2(moveSpeed * Input.GetAxisRaw("Horizontal"),theRB.velocity.y);
        
        isGrounded = Physics2D.OverlapCircle(groundCheckPoint.position,.2f,whatIsGround);
        
        if (isGrounded)
        {
            canDoubleJump = true;
        }

        if(Input.GetButtonDown("Jump"))
        {
            if (isGrounded)
            {
                theRB.velocity = new Vector2(theRB.velocity.x , jumpForce );
            }else
            {
                if (canDoubleJump)
                {
                    theRB.velocity = new Vector2(theRB.velocity.x , jumpForce );
                    canDoubleJump = false;
                }
            }
        }
       

        //anim.SetBool("isGrounded",isGrounded);
        //anim.SetFloat("moveSpeed",theRB.velocity.x);
        
    }
}