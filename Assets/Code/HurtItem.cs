using UnityEngine;
using System.Collections;
 
public class HurtItem : MonoBehaviour
{
    private LevelManager theLevelManager; //declaring a private field of type LevelManager class

    void Start()
    {
        theLevelManager = FindObjectOfType<LevelManager>(); //setting the private field to the LevelManager Class to use throught the HurtItem class
    }

    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag == "Player")
        {
            
        }
    }
}

