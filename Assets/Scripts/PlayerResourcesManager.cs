using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerResourcesManager : MonoBehaviour {

    public Text debugGoldText;

    private int _gold;

	public void AddGold(int amount)
    {
        _gold += amount;
        debugGoldText.text = _gold.ToString();
    }
}
