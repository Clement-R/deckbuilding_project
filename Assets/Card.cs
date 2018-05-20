using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Card : MonoBehaviour {

    public PlayerResourcesManager playerResources;

    private void Start()
    {
        playerResources = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerResourcesManager>();
    }

    public void PlayEffect()
    {
        playerResources.AddGold(10);
    }
}
