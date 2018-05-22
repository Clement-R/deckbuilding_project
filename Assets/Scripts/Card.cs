using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Card
{
    public int uid;

    protected PlayerResourcesManager _playerResources;

    public Card(PlayerResourcesManager playerResources)
    {
        _playerResources = playerResources;
    }

    public abstract void OnDrawed();
    public abstract void OnPlayed();
    public abstract void OnSacrificed();
}
