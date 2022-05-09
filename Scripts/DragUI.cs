using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using DG.Tweening;
public class DragUI : MonoBehaviour, IBeginDragHandler, IEndDragHandler, IDragHandler
{
    float old;
    float new1 = 0;
    float new2 = 0;
    [SerializeField] GameObject[] btn;

    float autoRotateTimer = 0f;
    bool isAutoRotate =false;
    private void Start()
    {

    }

    void Update()
    {

        if (Input.GetMouseButtonDown(0))
        {
            if (isAutoRotate)
            {
                StopCoroutine("TimeOutAutoRotate");
            }

            autoRotateTimer = 0;
            isAutoRotate = false;
        }

        if (!isAutoRotate)
        {
            autoRotateTimer += Time.deltaTime;
            if (autoRotateTimer >= 5f)
            {
                autoRotateTimer = 0;
                isAutoRotate = true;
                StartCoroutine("TimeOutAutoRotate");
            }
        }


    }

    IEnumerator TimeOutAutoRotate()
    {
        back();

        yield return new WaitForSeconds(3f);
        StartCoroutine("TimeOutAutoRotate");


    }
    public void OnBeginDrag(PointerEventData eventData)
    {
        old = eventData.position.y;
        print(old);
    }

    public void OnDrag(PointerEventData eventData)
    {

    }

    public void OnEndDrag(PointerEventData eventData)
    {
        if (old > eventData.position.y)
        {
            back();
            old = 0;
        }
        else
        {
            forward();
            old = 0;
        }
    }

    void back()
    {
        new1 -= 90;
        if (new1 == -360)
        {
            new1 = 0;
        }
        GetComponent<RectTransform>().DOLocalRotate(new Vector3(0, 0, new1), 1);
        new2 += 90;
        if (new2 == 360)
        {
            new2 = 0;
        }
    }
    void forward()
    {
        new1 += 90;
        if (new1 == 360)
        {
            new1 = 0;
        }
        GetComponent<RectTransform>().DOLocalRotate(new Vector3(0, 0, new1), 1);
        new2 -= 90;
        if (new2 == -360)
        {
            new2 = 0;
        }

    }
    void Fun(float F)
    {
        if (F / 45 == 0 || F / 45 == 8)
        {

        }
    }
}