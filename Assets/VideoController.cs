using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class VideoController : MonoBehaviour
{
    public GameObject[] vps;

    public void changeVideo(GameObject myGameObject)
    {
        for (int i = 0; i < vps.Length; i++)
        {
            vps[i].GetComponent<VideoPlayer>().Stop();
            vps[i].SetActive(false);
            myGameObject.SetActive(true);
            myGameObject.GetComponent<VideoPlayer>().Play();
        }
    }
}
