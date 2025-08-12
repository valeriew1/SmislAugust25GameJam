using UnityEngine;
using System;
using Unity.VisualScripting;

public class InputManager : Singleton<InputManager>
{

    public event Action OnRightPressed;
    public event Action OnLeftPressed;
    public event Action OnForwardPressed;
    public event Action OnBackPressed;

    public event Action OnRightRotate;
    public event Action OnLeftRotate;


    public event Action OnPressF;

    //public event Action OnRightReleased;
    //public event Action OnLeftReleased;
    //public event Action OnForwardReleased;
    //public event Action OnBackReleased;


    protected override void Awake()
    {
        base.Awake();
    }

    void Update()
    {
        if (GameManager.Instance.CurrentState == GameManager.GameState.RoomPlay)
        {
            HandleKeyInput();
        }

        //HandleKeyInput();

        //HandleMovementInput();
        //HandleActionInput();
        //HandleMouseInput();
    }

    void HandleKeyInput() 
    {
        if (Input.GetKey(KeyCode.W))
        { 
            OnForwardPressed?.Invoke(); 
        }
        //if (Input.GetKeyUp(KeyCode.W))
        //{
        //    OnForwardReleased?.Invoke(); 
        //}


        if (Input.GetKey(KeyCode.S))
        {
            OnBackPressed?.Invoke();
        }
        if (Input.GetKey(KeyCode.D))
        {
            OnRightPressed?.Invoke();
        }
        if (Input.GetKey(KeyCode.A))
        {
            OnLeftPressed?.Invoke();
        }
        if (Input.GetKey(KeyCode.F)) 
        {
            OnPressF?.Invoke(); 
        }

        if (Input.GetKey(KeyCode.RightArrow))
        {
            OnRightRotate?.Invoke();
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            OnLeftRotate?.Invoke();
        }


    }
    

}
