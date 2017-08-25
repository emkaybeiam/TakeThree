using System.Collections;
using UnityEngine;

public class SpiderController : MonoBehaviour
{
    public float moveSpeed;
    public bool canMove;

    private Rigidbody2D myRigidbody2D;

    private void Start()
    {
        myRigidbody2D = GetComponent<Rigidbody2D>();    
    }

    private void Update()
    {
        if (canMove)
        {
            myRigidbody2D.velocity = new Vector3(-moveSpeed, myRigidbody2D.velocity.y, 0f); //using -movespeed to make the spider move left on the x axis
        }
    }

    private void OnBecameVisible()
    {
        canMove = true;
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag == "Kill Plane")
        {
            Destroy(gameObject);
        }
    }
}
