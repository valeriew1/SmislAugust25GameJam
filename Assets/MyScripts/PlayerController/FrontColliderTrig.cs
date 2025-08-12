using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEditor.Experimental.GraphView.GraphView;

public class FrontColliderTrig : MonoBehaviour
{
    [SerializeField] private GameObject front;
    Rigidbody rbF;
    void Start()
    {
        rbF = front.GetComponent<Rigidbody>();
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
        if (collision.gameObject.CompareTag("Wall"))
        RoomManager.Instance.CanMoveFront();
        //RoomManager.Instance.FrontCollided = false;
    }
}
