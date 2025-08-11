using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class OpenCodeScene : MonoBehaviour
{
    [SerializeField] private int currentSceneIndex;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnMouseDown()
    {
        SceneManager.LoadScene(currentSceneIndex + 1);
    }
}

