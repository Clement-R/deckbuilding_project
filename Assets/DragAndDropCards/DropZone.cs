using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class DropZone : MonoBehaviour, IDropHandler
{
    public void OnDrop(PointerEventData eventData)
    {
        // Trigger card effect
        eventData.pointerDrag.GetComponent<Card>().OnPlayed();
        Destroy(eventData.pointerDrag);
    }
}
