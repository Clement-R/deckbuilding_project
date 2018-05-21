using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Card : MonoBehaviour {

    public PlayerResourcesManager playerResources;
    public int uid;

    // TODO :
    // Events :
    // 	OnDrawed()
    //  OnPlayed()
    //  OnSacrificed()
    //  // OnDiscarded()

    private void Start()
    {
    	// TODO : Use the game orchestrator to avoid direct binding
        playerResources = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerResourcesManager>();
    }

    public void PlayEffect()
    {
        playerResources.AddGold(10);
    }
}
