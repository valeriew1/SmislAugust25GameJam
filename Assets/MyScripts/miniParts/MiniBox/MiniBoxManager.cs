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
    int firstNum = 0;
    int secondNum = 0;
    int thirdNum = 0;
    int fourthNum = 0;

    public GameObject[] numsObjSSSS;
    public GameObject numsObj;
    public GameObject previousNumObj;
    

    public void OnMousePushArrow(GameObject newNumObj)
    {
        //if (numsObj = null) { numsObj =  }
        previousNumObj = numsObj;
        if (newNumObj != previousNumObj)
        {
            numsObj = newNumObj;
        }
        
    }


    public void Plus()
    {
        if (numsObj == numsObjSSSS[0])
        {
            curpushnum = firstNum  +1;
            //curpushnum++;
            if (curpushnum<9)
                firstNum = curpushnum;
            if (curpushnum==9)
                firstNum = 0;
            
        }
        if (numsObj == numsObjSSSS[1])
        {
            curpushnum = secondNum;
            curpushnum++;
            if (curpushnum < 9)
                secondNum = curpushnum;
            if(curpushnum == 9)
                secondNum = 0;
        }
        if (numsObj == numsObjSSSS[2])
        {
            curpushnum = thirdNum;
            curpushnum++;
            if (curpushnum < 9)
                thirdNum = curpushnum;
            if(curpushnum == 9)
                thirdNum = 0;
        }
        if (numsObj == numsObjSSSS[3])
        {
            curpushnum = fourthNum;
            curpushnum++;
            if (curpushnum < 9)
                fourthNum = curpushnum;
            if(curpushnum == 9)
                fourthNum = 0;
        }
        
    }

    public void Minus()
    {
        //curpushnum--;

        if (numsObj == numsObjSSSS[0] && firstNum != 0)
        {
            curpushnum = firstNum - 1;

            if (curpushnum > 0)
                firstNum = curpushnum;
            if (curpushnum == 0)
                firstNum = 9;

        }
        else if (numsObj == numsObjSSSS[0] && firstNum == 0)
        {
            curpushnum = 9;
            firstNum = 9;
        }
        if (numsObj == numsObjSSSS[1])
        {
            curpushnum = secondNum;
            curpushnum--;
            if (curpushnum != 0)
                secondNum = curpushnum;
            if (curpushnum == 0)
                secondNum = 9;
        }
        if (numsObj == numsObjSSSS[2])
        {
            curpushnum = thirdNum;
            curpushnum--;
            if (curpushnum != 0)
                thirdNum = curpushnum;
            if (curpushnum == 0)
                thirdNum = 9;
        }
        if (numsObj == numsObjSSSS[3])
        {
            curpushnum = fourthNum;
            curpushnum--;
            if (curpushnum != 0)
                fourthNum = curpushnum;
            if (curpushnum == 0)
                fourthNum = 9;
        }
    }


    public void RightPosition() 
    {
       
    }

}
