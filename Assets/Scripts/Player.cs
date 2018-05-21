using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

	public bool CanPlay { get { return _canPlay; } }

	private bool _canPlay = true;
	private PlayerCardsManagement cardsManager;
}
