using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VideoPlayer : MonoBehaviour
{
    public GameObject videoPlayer;
    public int timeToStop;

    private void Start()
    {
        videoPlayer.SetActive(false);
    }

    void OnTriggerEnter2D(Collider2D player)
    {
        if (player.gameObject.tag == "Player")
        {
            videoPlayer.SetActive(true);
            Destroy(videoPlayer, timeToStop);
        }
    }

}
