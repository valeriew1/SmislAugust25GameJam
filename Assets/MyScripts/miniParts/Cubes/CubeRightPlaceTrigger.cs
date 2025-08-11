using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeRightPlaceTrigger : MonoBehaviour
{
    [SerializeField] private GameObject cube;
    [SerializeField] private GameObject fin;

    //CubeLevelManager.Instance.NumProv(cube);

    //private Rigidbody2D rb;

    //private void Start()
    //{
    //    rb = cube.GetComponent<Rigidbody2D>();
    //}

    //private void OnCollisionEnter2D(Collision2D collision)
    //{
    //    cube.SetActive(false);
    //    Debug.Log("++++++");
    //}

    protected virtual void Awake() 
    {
        //cube = GetComponent<GameObject>();
        //fin = GetComponent<GameObject>();
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        int n = CubeLevelManager.Instance.NumProv(cube) +1;

        //if (other.gameObject.name == cube.name)
        //if (other.gameObject == cube)


        if (other.gameObject.CompareTag("cub" + n))
        {
            //CubeLevelManager.Instance.pribavka();
            
        CubeLevelManager.Instance.PLUSprovercaLetters(cube, fin);
            Debug.Log("++");
        }
    }
    private void OnTriggerExit2D(Collider2D other)
    {
        int n = CubeLevelManager.Instance.NumProv(cube) + 1;

        if (other.gameObject.CompareTag("cub" + n))
        {
            CubeLevelManager.Instance.MINUSprovercaLetters(cube, fin);
        }
    }





}
