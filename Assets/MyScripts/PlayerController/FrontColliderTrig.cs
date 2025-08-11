using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FrontColliderTrig : MonoBehaviour
{
    [SerializeField] private GameObject front;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Wall"))
        //if (collision.collider.CompareTag("Wall"))
        {
            RoomManager.Instance.CantMoveFront();
            //RoomManager.Instance.FrontCollided = true;
        }
    }
    private void OnCollisionExit(Collision collision)
    {
        RoomManager.Instance.CantMoveFront();
        //RoomManager.Instance.FrontCollided = false;
    }
}
