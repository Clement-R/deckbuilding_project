using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCardsManagement : MonoBehaviour {

    public GameObject deck;
    public GameObject card;

    void Update ()
    {
		if(deck.transform.childCount == 0)
        {
            for (int ii = 0; ii < 5; ii++)
            {
                Draw();
            }
        }
	}

    private void Draw()
    {
        Instantiate(card, deck.transform);
    }
}
