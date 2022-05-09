using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test2 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.GetComponent<RectTransform>().rect.height<400)
        {
            transform.GetComponent<RectTransform>().sizeDelta = new Vector2(1254, transform.GetComponent<RectTransform>().rect.height+Time.deltaTime*300);
        }
    }
}
