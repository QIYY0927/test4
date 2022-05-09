using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Test4 : MonoBehaviour
{
    [SerializeField]Button[] btns;
    void Start()
    {
        btns[0].onClick.AddListener(delegate { fun(0); });
        btns[1].onClick.AddListener(delegate { fun(1); });
        btns[2].onClick.AddListener(delegate { fun(2); });
        btns[3].onClick.AddListener(delegate { fun(3); });
        btns[0].onClick.AddListener(delegate { GK(0); });
        btns[1].onClick.AddListener(delegate { GK(1); });
        btns[2].onClick.AddListener(delegate { GK(2); });
        btns[3].onClick.AddListener(delegate { GK(3); });
    }

    public void GK(int index)
    {
        for (int i = 0; i < btns.Length; i++)
        {
            if (index == i)
            {
                btns[i].gameObject.transform.GetChild(0).gameObject.SetActive(false);
                btns[i].gameObject.transform.GetChild(1).gameObject.SetActive(true);
            }
            else
            {
                btns[i].gameObject.transform.GetChild(0).gameObject.SetActive(true);
                btns[i].gameObject.transform.GetChild(1).gameObject.SetActive(false);
            }
        }
    }
    void fun(int index)
    {
        if (index == 1)
        {
            GetComponent<CreateObj>().CreateGameObj(1);
            GetComponent<Btntwo>().GK(0);
        }
        if (index == 2)
        {
            GetComponent<CreateObj>().CreateGameObj(3);
            GetComponent<Btntwo>().GK(2);
        }
        if (index == 3)
        {
            GetComponent<CreateObj>().CreateGameObj(6);
            GetComponent<Btntwo>().GK(5);
        }
    }
}
