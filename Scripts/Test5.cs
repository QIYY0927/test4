using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Test5 : MonoBehaviour
{
    [SerializeField] Button[] Btn;
    [SerializeField] GameObject[] OBJ;
    void Start()
    {
        Btn[0].onClick.AddListener(delegate { GK(0); });
        Btn[1].onClick.AddListener(delegate { GK(1); });
    }
    public void GK(int index)
    {
        for (int i = 0; i < Btn.Length; i++)
        {
            if (index == i)
            {
                Btn[i].gameObject.transform.GetChild(0).gameObject.SetActive(true);
                Btn[i].gameObject.transform.GetChild(1).gameObject.SetActive(false);
            }
            else
            {
                Btn[i].gameObject.transform.GetChild(0).gameObject.SetActive(false);
                Btn[i].gameObject.transform.GetChild(1).gameObject.SetActive(true);
            }
        }
        if(index==0)
        {
            OBJ[0].SetActive(true);
            OBJ[1].SetActive(false);
        }
        if (index == 1)
        {
            OBJ[0].SetActive(false);
            OBJ[1].SetActive(true);
        }
    }
}
