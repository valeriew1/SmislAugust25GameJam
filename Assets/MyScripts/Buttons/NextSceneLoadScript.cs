using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class NextSceneLoadScript : MonoBehaviour
{

    [SerializeField] Button NextSceneLoadButton;
    //[SerializeField] Scene scene;
    private int currentSceneIndex;



    void Start()
    {
        NextSceneLoadButton.onClick.AddListener(onNextSceneLoadButton);
        currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
    }

    public void onNextSceneLoadButton()
    {
        SceneManager.LoadScene(currentSceneIndex+1);
        //GameManager.Instance.AutoNextState();
        //GameManager.Instance.ChangeState(Gam);

        //GameManager.Instance.LoadScene("MainMenu");
    }






}
