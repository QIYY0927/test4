using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Test3 : MonoBehaviour
{
    [SerializeField] Button[] Btn;
    void Start()
    {
        Btn[0].onClick.AddListener(delegate { GK(0); });
        Btn[1].onClick.AddListener(delegate { GK(1); });
        Btn[2].onClick.AddListener(delegate { GK(2); });
        Btn[3].onClick.AddListener(delegate { GK(3); });
    }
    public void GK(int index)
    {
        for (int i = 0; i < Btn.Length; i++)
        {
            if (index == i)
            {
                Btn[i].gameObject.transform.GetChild(0).gameObject.SetActive(false);
                Btn[i].gameObject.transform.GetChild(1).gameObject.SetActive(true);
            }
            else
            {
                Btn[i].gameObject.transform.GetChild(0).gameObject.SetActive(true);
                Btn[i].gameObject.transform.GetChild(1).gameObject.SetActive(false);
            }
        }
    }
}
