using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;

public class ControllerPlayer : MonoBehaviour
{
    public static ControllerPlayer instance;

    public float moveSpeed;
    public Rigidbody2D rb;
    public float jumpForce;
    public Transform groundCheck;
    public LayerMask ground;
    public Animator anim;
    private SpriteRenderer sr;
    private bool isGrounded;
    private bool doubleJump;

   public void Awake()
    {
       instance = this;
    }
    void Start()
    {
        anim = GetComponent<Animator>();
        sr = GetComponent<SpriteRenderer>();    
        
    }

    // Update is called once per frame
    void Update()
    {
        rb.velocity = new Vector2(moveSpeed * Input.GetAxis("Horizontal"), rb.velocity.y);

        isGrounded = Physics2D.OverlapCircle(groundCheck.position, .2f, ground);

        if(isGrounded)
        {
            doubleJump = true;
        }

        if(Input.GetButtonDown("Jump"))
        {
               if(isGrounded)
            {
                rb.velocity = new Vector2(rb.velocity.x, jumpForce);
            }else
            {
                if(doubleJump)
                {
                    rb.velocity = new Vector2(rb.velocity.x, jumpForce);
                    doubleJump = false;
                 
                }
            }
            
        }

        if(rb.velocity.x < 0)
        {
            sr.flipX  = true;
        }else if(rb.velocity.x > 0)
        {
            sr.flipX = false;
        }

        anim.SetFloat("moveSpeed", Mathf.Abs(rb.velocity.x));
        anim.SetBool("isGrounded", isGrounded);

    }
}
