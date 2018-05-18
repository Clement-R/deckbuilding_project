using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class DropZone : MonoBehaviour, IDropHandler
{
    public PlayerResourcesManager playerResources;

    public void OnDrop(PointerEventData eventData)
    {
        Debug.Log("Hello card");
        Destroy(eventData.selectedObject.gameObject);
        playerResources.AddGold(10);
    }
}
