using Assets.MyScripts.PlayerController;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class ManMovementScript : PlayerStateBase
{
    [SerializeField] private GameObject player;
    [SerializeField] private Canvas ResctrictCanvas;

    //[SerializeField] private GameObject playerL;
    //[SerializeField] private GameObject playerR;
    //[SerializeField] private GameObject playerF;
    //[SerializeField] private GameObject playerB;

    //Rigidbody rb;

    //Rigidbody rgL;
    //Rigidbody rbR;
    //Rigidbody rbF;
    //Rigidbody rbB;

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


    //protected virtual void Awake()
    //{
    //    if (GameManager.Instance.CurrentState == GameManager.GameState.RoomPlay)
    //    { DontDestroyOnLoad(gameObject); }
        
    //}

    protected override void Start()
    {
        base.Start();
        //rb = player.GetComponent<Rigidbody>();
        //rbF = playerF.GetComponent<Rigidbody>();
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
            //transform.Translate(moveForward, Space.Self);
            
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

    private void OnCollisionStay(Collision collision)
    {
        ResctrictCanvas.gameObject.SetActive(true);
    }
    private void OnCollisionExit(Collision collision)
    {
        ResctrictCanvas.gameObject.SetActive(false);
    }

    public override void Enter()
    {

    }
    

    public override void Execute()
    {

    }

    public override void Exit()
    {
        
    }

    public override void ProcessFixedUpdate()
    {

    }

    private void OnDestroy()
    {
        InputManager.Instance.OnForwardPressed -= MoveForward;
        InputManager.Instance.OnBackPressed -= MoveBack;
        InputManager.Instance.OnRightPressed -= MoveRight;
        InputManager.Instance.OnLeftPressed -= MoveLeft;

        InputManager.Instance.OnRightRotate -= RotateRight;
        InputManager.Instance.OnLeftRotate -= RotateLeft;
    }




}
