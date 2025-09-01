using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NextNumPushScript : MonoBehaviour
{

    [SerializeField] private GameObject[] numImage;
    [SerializeField] private GameObject pushNum;
    //[SerializeField] private int maxPush;

    //public int currentpush = 0;

    private void OnMouseDown()
    {
        MiniBoxManager.Instance.OnMousePushArrow(pushNum);
        if (MiniBoxManager.Instance.curpushnum < 9)
        {
            MiniBoxManager.Instance.Plus();
            numImage[MiniBoxManager.Instance.curpushnum-1].gameObject.SetActive(false);
            numImage[MiniBoxManager.Instance.curpushnum].gameObject.SetActive(true);
            
        }
        else if (MiniBoxManager.Instance.curpushnum == 9)
        {
            numImage[MiniBoxManager.Instance.curpushnum].gameObject.SetActive(false);
            numImage[0].gameObject.SetActive(true);
            MiniBoxManager.Instance.curpushnum = 0;
        }



    }



}
