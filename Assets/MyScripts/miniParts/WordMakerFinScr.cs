using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WordMakerFinScr : MonoBehaviour
{
    [SerializeField] private GameObject[] letters;
    [SerializeField] private GameObject[] fins;
    //private Collider[] lettersColliders;

    //private Rigidbody2D[] rbsLetters;
    //private Rigidbody2D[] rbsFins;

    private void Start()
    {
        //foreach (var i in letters)


        //for (int i = 0; i< letters.Length; i++)
        //{
        //    rbsLetters[i] = letters[i].GetComponent<Rigidbody2D>();
        //}
        //for (int i = 0; i< fins.Length; i++)
        //{
        //    rbsFins[i] = fins[i].GetComponent<Rigidbody2D>();
        //}

    }

    private void FixedUpdate()
    {
        FinMiniGameTrigger();
        Proverca();
    }

    private void OnCollisionEnter(Collision collision)
    {
        
    }

    private void Proverca() 
    { 
        for (int i = 0; i < fins.Length; i++)
        {
            for (int j = 0; j < letters.Length; j++)
            {
                //if (



                //if (Collider2D.ReferenceEquals(fins[i], letters[i])) { }
                //{

                //}
            }
        }
    }

    private void FinMiniGameTrigger() 
    { 

    }

    



}
