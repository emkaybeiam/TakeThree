using UnityEngine;
using System.Collections;
using System.Linq;
using System.Collections.Generic;

public class LevelManager : MonoBehaviour
{
    public static LevelManager Instance { get; private set; } //STATIC!! when the levelmanager is instantiated it's going to set the public static instance property to itself
    public Player Player { get; private set; }
    public Camera Camera { get; private set; }

    private List<Checkpoint> _checkpoints;
    private int _currentCheckpointIndex;

    public Checkpoint DebugSpawn;

    public void Awake()
    {
        //when a level starts that has a LevelManager we want to set the instance property to the object that was instantiated 
        Instance = this; 
    }

    public void Start()
    {
        _checkpoints = FindObjectsOfType<Checkpoint>().OrderBy(t => t.transform.position.x).ToList();
        _currentCheckpointIndex = _checkpoints.Count > 0 ? 0 : -1;

        Player = FindObjectOfType<Player>();
        Camera = FindObjectOfType<Camera>();
    }

    public void Update()
    {
        
    }

    public void KillPlayer()
    {

    }

    private IEnumerator KillPlayerCo() //is a co-routine that will perform the killing of the player
    {
        yield break;
    }
}

