using RenderHeads.Media.AVProVideo;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AVPro : MonoBehaviour
{
    [SerializeField] MediaPlayer mediaPlayer;
    [SerializeField] Button button;
    void Start()
    {
        button.onClick.AddListener(fun);
    }
    private void Update()
    {

        //if(!mediaPlayer.VideoOpened)
        //{
        //    print("BOf");
        //    button.gameObject.SetActive(true);
        //}
    }
    void fun()
    {
        mediaPlayer.Play();
        button.gameObject.SetActive(false);
    }
}
