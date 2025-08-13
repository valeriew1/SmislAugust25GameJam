using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MiniBoxManager : MonoBehaviour
{
    public static MiniBoxManager Instance { get; private set; }

    protected virtual void Awake()
    {
        Instance = this;
    }

    public int curpushnum = 0;


    public void Plus() 
    { curpushnum++;  }
    public void Minus()
    {
        if (curpushnum > 0)
        {
            curpushnum--;
        }
    }

}
