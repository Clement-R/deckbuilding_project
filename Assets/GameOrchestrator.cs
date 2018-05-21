﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOrchestrator : MonoBehaviour {

	private List<Player> _players;
	private Player _activePlayer;

	private Queue<Card> graveyard = new Queue<Card>();

	private void StartPlayerTurn(Player player)
	{
		// TODO
	}

    private void EndTurn()
    {
        // TODO
        if(CheckForVictory(_activePlayer))
        {
        	EndGame(_activePlayer);
        }
        else
        {
        	_activePlayer = GetNextPlayer();
        	StartPlayerTurn(_activePlayer);
        }
    }

    private Player GetNextPlayer()
    {
		// TODO
		return new Player();
    }

    /// <summary>
    /// Take the active player as parameter and will return true
    /// if this player wins
    /// </summary>
    private bool CheckForVictory(Player activePlayer)
    {
		return false;
    }

    /// <summary>
    /// Take the winning player as parameter and will trigger the end game
    /// event
    /// </summary>
    private void EndGame(Player activePlayer)
    {

    }
}
