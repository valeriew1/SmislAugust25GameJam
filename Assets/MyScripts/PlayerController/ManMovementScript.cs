using Assets.MyScripts.PlayerController;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class ManMovementScript : PlayerStateBase
{
    [SerializeField] private GameObject player;

    Rigidbody rb;

    [SerializeField] private float speed;
    [SerializeField] private float distance;

    private bool canMoveForward = true;
    private bool canMoveBack = true;
    private bool canMoveLeft = true;
    private bool canMoveRight = true;

    private float rotationSpeed = 10f;

    //float x;
    //float z;
    private float SCRwidth;
    private float SCRleft;
    private float SCRright;
    private Vector3 curentMousePos;
    ////private float curentMousePos;
    private float centralPos;
    private Vector3 mouseWorldPos;
    private Vector3 originalPosition;

    //Vector3 Vector3 = Vector3.x;



    //Gizmos.color = Color.red;
    //        Gizmos.DrawWireSphere(transform.position, AttackRange);


    protected override void Start()
    {
        base.Start();
        rb = player.GetComponent<Rigidbody>();
        InputManager.Instance.OnForwardPressed += MoveForward;
        InputManager.Instance.OnBackPressed += MoveBack;
        InputManager.Instance.OnRightPressed += MoveRight; 
        InputManager.Instance.OnLeftPressed += MoveLeft;

        InputManager.Instance.OnRightRotate += RotateRight;
        InputManager.Instance.OnLeftRotate += RotateLeft;

        ScreenPieces();
        //centralPos = Screen.width / 2;

        //InputManager.Instance.OnForwardReleased += StopMoveForward;

    }
    private void ScreenPieces()
    {
        SCRwidth = Screen.width;
        SCRleft = SCRwidth / 3;
        SCRright = (SCRwidth / 3) * 2;

    }


    void MoveForward() 
    {
        if (canMoveForward == true) 
        {
            Vector3 moveForward = new Vector3(0, 0, -distance) * speed * Time.deltaTime;
            transform.Translate(moveForward, Space.Self);
        }
    }

    void MoveBack() 
    {
        if(canMoveBack == true)
        {
            Vector3 moveBack = new Vector3(0, 0, distance) * speed * Time.deltaTime;
            
            transform.Translate(moveBack, Space.Self);
        }
    }

    void MoveRight() 
    {
        if (canMoveRight == true)
        {
            Vector3 moveRight = new Vector3(-distance, 0, 0) * speed * Time.deltaTime;
            transform.Translate(moveRight, Space.Self);
        }
    }
    void MoveLeft() 
    {
        if (canMoveLeft == true)
        {
            Vector3 moveLeft = new Vector3(distance, 0, 0) * speed * Time.deltaTime;
            transform.Translate(moveLeft, Space.Self);
        }
    }


    void RotateRight() 
    { 
        transform.Rotate(0, 1, 0);
    }
    void RotateLeft() 
    { 
        transform.Rotate(0, -1, 0);
    }


    //private void OnCollisionEnter(Collision collision)
    //{
    //    if (collision.collider.CompareTag("FrontCollider"))
    //    {
    //        Vector3 moveBack = new Vector3(0, 0, distance * 10) * speed * 10 * Time.deltaTime;
    //        transform.Translate(moveBack, Space.Self);
    //        //canMoveForward = false;
    //    }
    //    if (collision.collider.CompareTag("BackCollider"))
    //    {
    //        canMoveBack = false;
    //    }
    //    if (collision.collider.CompareTag("RightCollider"))
    //    {
    //        canMoveRight = false;
    //    }
    //    if (collision.collider.CompareTag("LeftCollider"))
    //    {
    //        canMoveLeft = false;
    //    }
    //    //if (collision.collider.CompareTag("FrontWall")) 
    //    //{
    //    //    //transform.Translate()
    //    //    canMoveForward = false;
    //    //}
    //    //if (collision.collider.CompareTag("BackWall")) 
    //    //{
    //    //    canMoveBack = false;
    //    //}
    //    //if (collision.collider.CompareTag("RightWall")) 
    //    //{
    //    //    canMoveRight = false;
    //    //}
    //    //if (collision.collider.CompareTag("LeftWall")) 
    //    //{
    //    //    canMoveLeft = false;
    //    //}
    //}

    //private void OnCollisionStay(Collision collision)
    //{
    //    if (collision.collider.CompareTag("FrontCollider"))
    //    {
    //        //Vector3 moveBack = new Vector3(0, 0, distance * 10) * speed * 10 * Time.deltaTime;
    //        //transform.Translate(moveBack, Space.Self);

    //        //transform.Translate()
    //        canMoveForward = false;
    //    }
    //    if (collision.collider.CompareTag("BackCollider"))
    //    {
    //        canMoveBack = false;
    //    }
    //    if (collision.collider.CompareTag("RightCollider"))
    //    {
    //        canMoveRight = false;
    //    }
    //    if (collision.collider.CompareTag("LeftCollider"))
    //    {
    //        canMoveLeft = false;
    //    }
    //}

    //private void OnCollisionExit(Collision collision)
    //{
    //    if (collision.collider.CompareTag("FrontCollider"))
    //    {
    //        //transform.Translate()
    //        canMoveForward = true;
    //    }
    //    if (collision.collider.CompareTag("BackCollider"))
    //    {
    //        canMoveBack = true;
    //    }
    //    if (collision.collider.CompareTag("RightCollider"))
    //    {
    //        canMoveRight = true;
    //    }
    //    if (collision.collider.CompareTag("LeftCollider"))
    //    {
    //        canMoveLeft = true;
    //    }
    //}


    public override void Enter()
    {

    }
    
    //private void onMouse()
    //{
    //    curentMousePos.x = Input.mousePosition.x;

    //    if (curentMousePos.x < SCRleft)
    //    {
    //        //player.transform.Rotate(0, -50f, 0);
    //        player.transform.rotation = Quaternion.identity;
    //    }
    //    else if (curentMousePos.x > SCRright)
    //    {
    //        //player.transform.Rotate(0, 50f, 0);
    //        player.transform.rotation = Quaternion.identity;
    //    }
    //}

    public override void Execute()
    {

        if (RoomManager.Instance.FrontCollided is true) 
        {
            canMoveForward = false;
        }
        else if (RoomManager.Instance.FrontCollided is false)
        {
            canMoveForward = true;
        }

        //curentMousePos.x = Input.mousePosition.x;

        //if (curentMousePos.x < SCRleft)
        //{
        //    Vector3 currentMouseRotationPosition = Input.mousePosition;
        //    float deltaY = (curentMousePos.x - originalPosition.x) * rotationSpeed * Time.deltaTime;
        //    //float rotationAmount = invertRotation ? -deltaX : deltaX;
        //    player.transform.Rotate(0, deltaY/50, 0);
        //    //player.transform.Rotate(0, -50f, 0);
        //}
        //else if (curentMousePos.x > SCRright)
        //{
        //    //player.transform.Rotate(0, 50f, 0);
        //}



        //mouseWorldPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        //mouseWorldPos.z = transform.position.z;
        //originalPosition = mouseWorldPos;
        ////originalPosition = ClampPositionToCameraView(originalPosition);


        //curentMousePos = Input.mousePosition;

        //if (curentMousePos.x - 5 < centralPos) 
        //{
        //    //player.transform.rotation = Quaternion.identity;
        //    //Vector3 currentMouseRotationPosition = Input.mousePosition;
        //    float deltaY = (curentMousePos.x - originalPosition.x) * rotationSpeed * Time.deltaTime;
        //    //float rotationAmount = invertRotation ? -deltaX : deltaX;
        //    transform.Rotate(0, deltaY, 0);
        //}
        //else if (curentMousePos.x + 5 > centralPos) 
        //{
        //    float deltaY = (curentMousePos.x + originalPosition.x) * rotationSpeed * Time.deltaTime;
        //    transform.Rotate(0, deltaY, 0);
        //}


    }

    public override void Exit()
    {
        
    }

    public override void ProcessFixedUpdate()
    {

        //x = Input.GetAxis("Horizontal");
        //z = Input.GetAxis("Vertical");

        //if ()

        //Vector3 movement = new Vector3(x, 0, z);
        //player.transform.Translate(movement * speed * Time.deltaTime);
    }

    


}
