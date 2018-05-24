using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DrawCoin : Card
{
    public int numDraw = 1;
    public int amount = 10;

    public DrawCoin(PlayerResourcesManager playerResources) : base(playerResources)
    {
    }

    public override void OnDrawed()
    {
    }

    public override void OnPlayed()
    {
        _playerResources.AddGold(amount);

        for (int i = 0; i < numDraw; i++)
        {
            _playerCards.Draw();
        }
    }

    public override void OnSacrificed()
    {
    }
}
