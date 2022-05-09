using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Test : MonoBehaviour
{
    public Button[] Btn;
    public GameObject gameobj;
    void Start()
    {
        Btn[0].onClick.AddListener(delegate { Fun(0); });
        Btn[1].onClick.AddListener(delegate { Fun(2); });
        Btn[2].onClick.AddListener(delegate { Fun(1); });
        Btn[3].onClick.AddListener(delegate { Fun(3); });
    }
    void Fun(int index)
    {
        gameobj.SetActive(true);
        gameobj.GetComponent<Theerbtn>().Btnmove(index);
        if (index == 0)
        {
            gameobj.GetComponent<CreateObj>().CreateGameObj(0);
            gameobj.GetComponent<Test4>().GK(0);
        }
        if (index == 1)
        {
            gameobj.GetComponent<CreateObj>().CreateGameObj(1);
            gameobj.GetComponent<Btntwo>().GK(0);
            gameobj.GetComponent<Test4>().GK(1);
        }
        if (index == 2)
        {
            gameobj.GetComponent<CreateObj>().CreateGameObj(3);
            gameobj.GetComponent<Btntwo>().GK(2);
            gameobj.GetComponent<Test4>().GK(2);
        }
        if (index == 3)
        {
            gameobj.GetComponent<CreateObj>().CreateGameObj(6);
            gameobj.GetComponent<Btntwo>().GK(5);
            gameobj.GetComponent<Test4>().GK(3);
        }
        gameObject.SetActive(false);
    }
}
