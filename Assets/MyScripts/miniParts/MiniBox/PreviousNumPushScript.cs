using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PreviousNumPushScript : MonoBehaviour
{
    [SerializeField] private GameObject[] numImage;
    [SerializeField] private GameObject push;

    //public int currentpush = 0;

    private void OnMouseDown()
    {
        if (MiniBoxManager.Instance.curpushnum > 0)
        {
            numImage[MiniBoxManager.Instance.curpushnum].gameObject.SetActive(false);
            numImage[MiniBoxManager.Instance.curpushnum - 1].gameObject.SetActive(true);
            MiniBoxManager.Instance.Minus();
        }
        else if (MiniBoxManager.Instance.curpushnum == 0)
        {
            numImage[MiniBoxManager.Instance.curpushnum].gameObject.SetActive(false);
            numImage[9].gameObject.SetActive(true);
            MiniBoxManager.Instance.curpushnum = 9;
        }


    }
}
