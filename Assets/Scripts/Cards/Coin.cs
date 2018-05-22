using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : Card
{
    public Coin(PlayerResourcesManager playerResources) : base(playerResources)
    {
    }

    public override void OnDrawed()
    {
    }

    public override void OnPlayed()
    {
        _playerResources.AddGold(10);
    }

    public override void OnSacrificed()
    {
    }
}
