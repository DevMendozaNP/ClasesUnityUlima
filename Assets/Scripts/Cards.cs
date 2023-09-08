using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cards : MonoBehaviour
{
    public GameObject CardOpen;
    public GameObject CardClosed;
    public GameManager GameManager;

    private bool isClosed = true;


    public void cardOnClick()
    {
        if (isClosed == true)
        {
            OpenCard();
            int pos = int.Parse(name);
            GameManager.PlayCard(pos, this);
        }else
        {
            CloseCard();
        }
    }

    public void OpenCard()
    {
        CardClosed.SetActive(false);
        CardOpen.SetActive(true);
        isClosed = false; 
    }

    public void CloseCard()
    {
        CardClosed.SetActive(true);
        CardOpen.SetActive(false);
        isClosed = true;
    }
}
