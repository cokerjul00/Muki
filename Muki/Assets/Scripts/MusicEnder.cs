using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicEnder : MonoBehaviour
{
    public AudioSource Endsong;
    bool Song;
    PointHolder points1;
    GameObject ending;

    // Start is called before the first frame update
    void Start()
    {
        Endsong = gameObject.GetComponent<AudioSource>();
        points1 = GameObject.Find("Ending").GetComponent<PointHolder>();

    }

    // Update is called once per frame
    void Update()
    {
        if (points1.Points == 8)
        {
            //Plays an Audio Source
            //audioSource.Play();
        }
    }



}
