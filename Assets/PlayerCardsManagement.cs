using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCardsManagement : MonoBehaviour {

    public GameObject deck;
    public GameObject card;

    private List<Card> cards;

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
        // TODO : Check if there is enough cards to draw, if not shuffle discard pile into deck
        Instantiate(card, deck.transform);
    }

    private void ShuffleDiscardPile()
    {

    }

    private void SendCardToDiscardPile()
    {

    }
}
