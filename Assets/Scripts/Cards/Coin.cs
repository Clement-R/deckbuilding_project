using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : Card
{
    public int amount = 10;

    public Coin(PlayerResourcesManager playerResources) : base(playerResources)
    {
    }

    public override void OnDrawed()
    {
    }

    public override void OnPlayed()
    {
        _playerResources.AddGold(amount);
    }

    public override void OnSacrificed()
    {
    }
}
