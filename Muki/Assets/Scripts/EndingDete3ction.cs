using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndingDete3ction : MonoBehaviour
{
    public InvUI Invui;
    public Collectable Collect;


    // Start is called before the first frame update
    void Start()
    {
        Invui = GetComponent<InvUI>();
        Collect = GetComponent<Collectable>();
    }

    // Update is called once per frame
    void Update()
    {
    
    }
}
