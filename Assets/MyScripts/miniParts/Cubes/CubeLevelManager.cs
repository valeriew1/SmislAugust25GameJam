using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeLevelManager : MonoBehaviour
{
    [SerializeField] private StateMachine statemach;
    [SerializeField] private int LettersNum;

    [SerializeField] private GameObject[] cubes;
    [SerializeField] private GameObject[] fins;
    private GameObject cubPROV;
    private GameObject finsPROV;
    private GameObject letNum;


    public bool isworddone = false;


    public static CubeLevelManager Instance { get; private set; }

    protected virtual void Awake()
    {
        Instance = this;
    }

    private int LettersCounter = 0;

    public void pribavka() 
    {
        LettersCounter++;
    }

    public void minus()
    {
        if (LettersCounter > 0)
        { 
            LettersCounter--;
        }
    }

    public void WordDone() 
    {
        //LC = LettersNum;
        if (LettersCounter == LettersNum && isworddone == false)
        {
            isworddone = true;
            Debug.Log("wtf");
        }
    }

    public int LetterNum;
    public int NumProv(GameObject _letNum)
    {
        letNum = _letNum;

        for (int i = 0; i < cubes.Length; i++)
        {
            if (cubes[i] == _letNum)
            { LetterNum = i; }
        }

        return LetterNum;
    }

    public void PLUSprovercaLetters(GameObject _cubPROV, GameObject _finsPROV) 
    {
        cubPROV = _cubPROV;
        finsPROV = _finsPROV;
        for (int i = 0; i < cubes.Length; i++)
        {
            if (cubes[i].name == cubPROV.name)
            {
                for (int j = 0; j < fins.Length; j++) 
                {
                    if (fins[j].name == finsPROV.name) 
                    {
                        pribavka();
                    }
                }
            }


        }
    }

    public void MINUSprovercaLetters(GameObject _cubPROV, GameObject _finsPROV) 
    {
        cubPROV = _cubPROV;
        finsPROV = _finsPROV;
        for (int i = 0; i < cubes.Length; i++)
        {
            if (cubes[i].name == cubPROV.name)
            {
                for (int j = 0; j < fins.Length; j++)
                {
                    if (fins[j].name == finsPROV.name && LetterNum > 0)
                    {
                        minus();
                    }
                }
            }


        }
    }





}
