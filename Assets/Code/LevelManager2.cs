using UnityEngine;
using System.Collections;

public class LevelManager2 : MonoBehaviour
{
    public float waitToRespawn;
    public PlayerController thePlayer;
    public GameObject deathSplotion;

    private ResetOnRespawn[] objectsToReset; //array of game objects that have reset on respawn script attached to it

    private void Start()
    {
        thePlayer = FindObjectOfType<PlayerController>();

        objectsToReset = FindObjectsOfType<ResetOnRespawn>();
    }

    private void Update()
    {
        
    }

    public void Respawn()
    {
        
    }

    private IEnumerator RespawnCo()
    {
        thePlayer.gameObject.SetActive(false);

        Instantiate(deathSplotion, thePlayer.transform.position, thePlayer.transform.rotation);
        yield return new WaitForSeconds(waitToRespawn); //this is needed in a coroutine, coroutines must return a value

        //thePlayer.transform.position = thePlayer.respawnPosition;
        thePlayer.gameObject.SetActive(true);

        for (int i = 0; i < objectsToReset.Length; i++)
        {
            objectsToReset[i].gameObject.SetActive(true);
            objectsToReset[i].ResetObject();
        }
    }

}