using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCardsManagement : MonoBehaviour {

    // TODO : Rework this value to be stored by GameOrchestrator's GameRules
    //        and be flexible (draw 3 on first turn) and also extract this value
    //        from here and GameOrchestrator should ask the PlayerCardsManagement
    //        to draw
    public int numberOfCardsInHand = 5;
    public GameObject deckObject;
    public GameObject card;

    // Use a Queue instead for deck
    private Queue<Card> deck = new Queue<Card>();
    private List<Card> discard;

    void Update ()
    {
		if(deckObject.transform.childCount == 0)
        {
            for (int ii = 0; ii < numberOfCardsInHand; ii++)
            {
                Draw();
            }
        }
	}

    private void Draw()
    {
        // Check if there is enough a card to draw, if not shuffle discard pile into deck
        if(deck.Count == 0)
        {
            ShuffleDiscardPile();
            Draw();
        }
        else
        {
            // TODO : Move this call to an orchestrator who should do thats
            Instantiate(card, deckObject.transform);
        }
    }

    private void ShuffleDiscardPile()
    {
        // TODO
    }

    private void SendCardToDiscardPile(Card card)
    {
        // TODO : Remove from deck
        discard.Add(card);
    }
}
