using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class InvUI : MonoBehaviour
{

    private TextMeshProUGUI CollectableText;



    // Start is called before the first frame update
    void Start()
    {

        CollectableText = GetComponent<TextMeshProUGUI>();

    }

   public void UpdateCollectableText(PlayerInv playerInventory)
    {
        CollectableText.text = playerInventory.piecesCollected.ToString();

    }



}
