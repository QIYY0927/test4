using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Common;
using UnityEngine.UI;
using DG.Tweening;

public class Theerbtn : MonoBehaviour
{
    public GameObject[] window;
    public GameObject[] Swindow;
    public GameObject DesObj;
    void Start()
    {
        window[0].GetComponent<Button>().onClick.AddListener(delegate { Btnmove(0); });
        window[1].GetComponent<Button>().onClick.AddListener(delegate { Btnmove(1); });
        window[2].GetComponent<Button>().onClick.AddListener(delegate { Btnmove(2); });
        window[3].GetComponent<Button>().onClick.AddListener(delegate { Btnmove(3); });
    }

    public void Xianshi(int inde)
    {
      
        for (int i = 0; i < window.Length; i++)
        {
            if (i == inde)
            {
                window[i].transform.FindChilderByName("Page-red").gameObject.SetActive(true);
                window[i].transform.FindChilderByName("Page-back").gameObject.SetActive(false);
                 
            }
            else
                window[i].transform.FindChilderByName("Page-red").gameObject.SetActive(false);
                window[i].transform.FindChilderByName("Page-back").gameObject.SetActive(true);
        }
    }

    public void Btnmove(int btnindex)
    {
        if (btnindex == 0)
        {
            window[0].transform.DOLocalMoveY(92.5f, 1);
            window[1].transform.DOLocalMoveY(-95.3f, 1);
            window[2].transform.DOLocalMoveY(-284, 1);
            window[3].transform.DOLocalMoveY(-472.8f, 1);
            Swindow[0].transform.DOLocalMoveY(288, 1);
            Swindow[1].transform.DOLocalMoveY(356, 1);
            Swindow[2].transform.DOLocalMoveY(288, 1);
        }
        if (btnindex==1)
        {
            window[0].transform.DOLocalMoveY(92.5f, 1);
            window[1].transform.DOLocalMoveY(-95.3f, 1);
            window[2].transform.DOLocalMoveY(-485, 1);
            window[3].transform.DOLocalMoveY(-673.8f, 1);
            Swindow[0].transform.DOLocalMoveY(0,1);
            Swindow[1].transform.DOLocalMoveY(356, 1);
            Swindow[2].transform.DOLocalMoveY(288, 1);
        }
        if (btnindex==2)
        {
            window[0].transform.DOLocalMoveY(92.5f, 1);
            window[1].transform.DOLocalMoveY(-95.3f, 1);
            window[2].transform.DOLocalMoveY(-284, 1);
            window[3].transform.DOLocalMoveY(-773, 1);
            Swindow[0].transform.DOLocalMoveY(288, 1);
            Swindow[1].transform.DOLocalMoveY(0, 1);
            Swindow[2].transform.DOLocalMoveY(288, 1);
        }
        if (btnindex==3)
        {
            window[0].transform.DOLocalMoveY(92.5f, 1);
            window[1].transform.DOLocalMoveY(-95.3f, 1);
            window[2].transform.DOLocalMoveY(-284, 1);
            window[3].transform.DOLocalMoveY(-472.8f, 1);
            Swindow[0].transform.DOLocalMoveY(288, 1);
            Swindow[1].transform.DOLocalMoveY(356, 1);
            Swindow[2].transform.DOLocalMoveY(0, 1);
        }
    }
}
