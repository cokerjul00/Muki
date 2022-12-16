using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicEnder : MonoBehaviour
{
    private AudioSource Endsong;
    PointHolder points1;
    

    // Start is called before the first frame update
    void Start()
    {
        Endsong = GetComponent<AudioSource>();
        points1 = GameObject.Find("Ending").GetComponent<PointHolder>();

    }

    // Update is called once per frame
    void Update()
    {
        if (points1.Points >= 8)
        {
            Endsong.Play();
        }
    }

    public void playEnd()
    {
        

    }


}
