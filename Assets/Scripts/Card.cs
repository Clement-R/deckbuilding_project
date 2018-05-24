using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Card : MonoBehaviour
{
    [HideInInspector]
    public int uid;

    protected PlayerResourcesManager _playerResources;
    protected PlayerCardsManagement _playerCards;

    private void Start()
    {
        _playerResources = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerResourcesManager>();
        _playerCards = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerCardsManagement>();
    }

    public Card(PlayerResourcesManager playerResources)
    {
        _playerResources = playerResources;
    }

    public abstract void OnDrawed();
    public abstract void OnPlayed();
    public abstract void OnSacrificed();
}
