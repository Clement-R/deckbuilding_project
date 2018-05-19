using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class DropZone : MonoBehaviour, IDropHandler
{
    public PlayerResourcesManager playerResources;

    public void OnDrop(PointerEventData eventData)
    {
        // TODO : Trigger card effect

        Destroy(eventData.pointerDrag);
        playerResources.AddGold(10);
    }
}
