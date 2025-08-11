using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoomManager : MonoBehaviour
{
    public static RoomManager Instance { get; private set; }
   
    protected virtual void Awake()
    {
        Instance = this;
    }

    public bool FrontCollided;
    public bool BackCollided;
    public bool LeftCollided;
    public bool RightCollided;


    public bool CantMoveFront() 
    {
        FrontCollided = false;
        return FrontCollided;
    }

    //protected override 
}
