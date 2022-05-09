using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CreateObj : MonoBehaviour
{
    [SerializeField]GameObject[] CreObjs;
    [SerializeField] Button[] CreBtns;
    public GameObject desObj;
    [SerializeField] Transform Par;
    [SerializeField] GameObject obj;
    [SerializeField] Button Retbutton;
    void Start()
    {
        CreBtns[0].onClick.AddListener(delegate { CreateGameObj(0); });
        CreBtns[1].onClick.AddListener(delegate { CreateGameObj(1); });
        CreBtns[2].onClick.AddListener(delegate { CreateGameObj(2); });
        CreBtns[3].onClick.AddListener(delegate { CreateGameObj(3); });
        CreBtns[4].onClick.AddListener(delegate { CreateGameObj(4); });
        CreBtns[5].onClick.AddListener(delegate { CreateGameObj(5); });
        CreBtns[6].onClick.AddListener(delegate { CreateGameObj(6); });
        CreBtns[7].onClick.AddListener(delegate { CreateGameObj(7); });
        Retbutton.onClick.AddListener(fun);
    }
    void fun()
    {
        if(desObj!=null)
        Destroy(desObj);
        obj.SetActive(true);
        gameObject.SetActive(false);
    }
    public void CreateGameObj(int index)
    {
        if (desObj != null) Destroy(desObj);
        desObj=Instantiate(CreObjs[index],Par);
    }
}
