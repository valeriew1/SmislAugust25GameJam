using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CubeWordDoneTrigger : MonoBehaviour
{
    private Color undonecolor = Color.red;
    private Color donecolor = Color.green;
    [SerializeField] private Button wordButton;
    [SerializeField] private Button BackToRoomButton;
    [SerializeField] private Image ToRoomImage;

    private void Start()
    {
        wordButton.image.color = undonecolor;
    }

    private void Update()
    {
        CubeLevelManager.Instance.WordDone();
        Done();
    }

    private void Done() 
    {
        if(CubeLevelManager.Instance.isworddone == true)
        {
            wordButton.image.color = donecolor;
            BackToRoomButton.gameObject.SetActive(true);
            ToRoomImage.gameObject.SetActive(true);


        }
    
    }
    //private Color selectedColor = Color.darkGreen;

    //renderer.material.color = selectedColor;

}
