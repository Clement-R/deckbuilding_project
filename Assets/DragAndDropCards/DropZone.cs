using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class DropZone : MonoBehaviour, IDropHandler
{
    public void OnDrop(PointerEventData eventData)
    {
        // TODO : Trigger card effect

        Destroy(eventData.pointerDrag);
        eventData.pointerDrag.GetComponent<Card>().PlayEffect();
    }
}
