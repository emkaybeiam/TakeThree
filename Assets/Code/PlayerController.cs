using UnityEngine;
using System.Collections;
public class PlayerController : MonoBehaviour
{
    //these public fields can be modified in the inspector window
    public float moveSpeed;
    public float jumpSpeed;
    public float groundCheckRadius;
    public Transform groundCheck;
    public LayerMask isGround;
    public bool isGrounded;
    public GameObject stompBox;
    public float knockBackForce;
    public float knockBackLength;
    public AudioSource jumpSound;
    public AudioSource hurtSound;

    private float knockBackCounter;
    private Rigidbody2D myRigidbody;
    private Animator myAnim;


    private void Start()
    {
        myRigidbody = GetComponent<Rigidbody2D>();
        myAnim = GetComponent<Animator>();
    }

    public void Update()
    {

        isGrounded = Physics2D.OverlapCircle(groundCheck.position, groundCheckRadius, isGround);

        if (knockBackCounter <= 0)
        {
            if (Input.GetAxisRaw("Horizontal") > 0f)
            {
                myRigidbody.velocity = new Vector3(moveSpeed, myRigidbody.velocity.y, 0f);
                transform.localScale = new Vector3(1f, 1f, 1f);
            }
            else if (Input.GetAxisRaw("Horizontal") < 0f)
            {
                myRigidbody.velocity = new Vector3(moveSpeed, myRigidbody.velocity.y, 0f);
                transform.localScale = new Vector3(1f, 1f, 1f);
            }
            else
            {
                myRigidbody.velocity = new Vector3(0f, myRigidbody.velocity.y, 0f);
            }
        }
        if(knockBackCounter > 0)
        {
            knockBackCounter -= Time.deltaTime;
        }

            //jumping
            if (Input.GetButton("Jump") && isGrounded)
            {
                myRigidbody.velocity = new Vector3(myRigidbody.velocity.x, jumpSpeed, 0f);
                jumpSound.Play();
            }


            //animation the "Speed" and "Grounded" strings are the parameter names we placed in the animator
            myAnim.SetFloat("Speed", Mathf.Abs(myRigidbody.velocity.x));//math function to return the absolute value (any negative number gets turned into a positive number)
            myAnim.SetBool("Grounded", isGrounded);


            if (myRigidbody.velocity.y < 0)
            {
                stompBox.SetActive(true);
            }
            else { stompBox.SetActive(false); }
        

    }


    public void KnockBack()
    {

    }
}
