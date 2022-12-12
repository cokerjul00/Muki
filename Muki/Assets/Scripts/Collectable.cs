using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collectable : MonoBehaviour
{


    private void OnTriggerEnter(Collider other)
    {
        PlayerInv playerInventory = other.GetComponent<PlayerInv>();

        if(playerInventory != null)
        {
            playerInventory.PiecesCollected();
            gameObject.SetActive(false);

        }
    }

}
