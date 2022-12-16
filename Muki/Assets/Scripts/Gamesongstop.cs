using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gamesongstop : MonoBehaviour
{

    private AudioSource gamesong;
    PointHolder point2;


    // Start is called before the first frame update
    void Start()
    {
        GameObject.Find("Ending").GetComponent<PointHolder>();
        gamesong = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (point2.Points >= 8)
        {
            gamesong.Stop();
        }
    }
}
