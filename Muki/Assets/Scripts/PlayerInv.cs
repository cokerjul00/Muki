using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class PlayerInv : MonoBehaviour
{

    public int piecesCollected { get; private set; }


    public UnityEvent<PlayerInv> OnPieceCollected;


    public void PiecesCollected ()
    {
        piecesCollected++;
        OnPieceCollected.Invoke(this);
    }


}
