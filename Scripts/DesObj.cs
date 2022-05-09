using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DesObj : MonoBehaviour
{
    public GameObject OBJ;
    void Start()
    {
        transform.GetComponent<Button>().onClick.AddListener(fun);
    }

    void fun()
    {
        OBJ.SetActive(true);
        //OBJ.GetComponent<Test>().Fun1();
    }
}
