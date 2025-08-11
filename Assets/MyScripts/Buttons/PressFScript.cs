using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PressFScript : MonoBehaviour
{
    [SerializeField] private int currentSceneIndex;

    void Start()
    {
        InputManager.Instance.OnPressF += LoadPressF;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void LoadPressF() 
    { 
        SceneManager.LoadScene(currentSceneIndex + 1); 
    }

}
