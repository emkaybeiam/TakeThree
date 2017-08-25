using System.Collections;
using UnityEngine;

public class Stomp : MonoBehaviour
{
    private Rigidbody2D playerRigidbody;
    public GameObject deathSpolsion;
    public float bounceForce;

    private void Start()
    {
        playerRigidbody = transform.parent.GetComponent<Rigidbody2D>();
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag == "Enemy")
        {
            Destroy(other.gameObject);
            Instantiate(deathSpolsion, other.transform.position, other.transform.rotation);
            playerRigidbody.velocity = new Vector3(playerRigidbody.velocity.x, bounceForce, 0f); //this bounces the player up
        }
    }
}

