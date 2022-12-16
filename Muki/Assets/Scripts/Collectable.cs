using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collectable : MonoBehaviour
{
    PointHolder Pointss;
    GameObject Ending;
    public void Start()
    {
        Pointss = GameObject.Find("Ending").GetComponent<PointHolder>();
    }

    private void OnTriggerEnter(Collider other)
    {
        PlayerInv playerInventory = other.GetComponent<PlayerInv>();

        if(playerInventory != null)
        {
            playerInventory.PiecesCollected();
            gameObject.SetActive(false);
            Pointss.Points ++;
        }
    }



}
