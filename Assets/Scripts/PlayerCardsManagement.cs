using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class PlayerCardsManagement : MonoBehaviour {

    // TODO : Rework this value to be stored by GameOrchestrator's GameRules
    //        and be flexible (draw 3 on first turn) and also extract this value
    //        from here and GameOrchestrator should ask the PlayerCardsManagement
    //        to draw
    public int numberOfCardsInHand = 5;
    public GameObject deckObject;
    public GameObject card;

    private Stack<Card> deck = new Stack<Card>();
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

        for (int i = 0; i < 25; i++)
        {
            deck.Push(new Coin(GetComponent<PlayerResourcesManager>()));
        }
	}

    private void SendCardToDeck(Card card)
    {
        deck.Push(card);
    }

    public void Draw()
    {
        // Check if there is enough a card to draw, if not shuffle discard pile into deck
        if(deck.Count == 0)
        {
            ShuffleDiscardPile();
            Draw();
        }
        else
        {
            // TODO : Move this call to an orchestrator who should do that
            Instantiate(card, deckObject.transform);
        }
    }

    private void ShuffleDiscardPile()
    {
        discard = discard.OrderBy(x => Random.value).ToList();
    }

    private void SendCardToDiscardPile(Card card)
    {
        // TODO : Remove from deck using card's uid
        discard.Add(card);
    }
}
