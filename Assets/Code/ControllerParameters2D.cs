using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//this is just a public class, it does not inherit from anything, even MonoBehaviour 
public class ControllerParameters2D
{
    public enum JumpBehavior
    {
        CanJumpOnGround,
        CanJumpAnywhere,
        CantJump
    }


    public Vector2 MaxVelocity = new Vector2(float.MaxValue, float.MaxValue);

    [Range(0, 90)]
    public float SloapLimit = 30; //this is the degree our player can climb

    public float Gravity = -25f;

    public JumpBehavior JumpRestrictions;

    public float JumpFrequency = .25f;
}
