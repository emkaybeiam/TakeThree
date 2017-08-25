using UnityEngine;
   
public class GameManager //NOT a monobehaviour if we had it inherit from monobehaviour we would have to do extra work to make sure that it doesn't get destroyed on load
    //other wise a new level the game manager would be destroyed
{
    //To make this class a singleton we have the public static instance of this class
    public static GameManager Instance { get { return null; } }

    public int Points { get; private set; }

    public void Reset()
    {

    }

    public void AddPoints(int ponts)
    {

    }


}

