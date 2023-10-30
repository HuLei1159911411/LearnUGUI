using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class EventTriggerTest : MonoBehaviour
{
    public RectTransform joy;
    public PlayerController player;

    private EventTrigger eventTrigger;

    private void Start()
    {
        if (joy.TryGetComponent<EventTrigger>(out eventTrigger))
        {
            EventTrigger.Entry entryDrag = new EventTrigger.Entry();
            entryDrag.eventID = EventTriggerType.Drag;
            entryDrag.callback.AddListener(JoyOnDrag);
            eventTrigger.triggers.Add(entryDrag);
            
            EventTrigger.Entry entryEndDrag = new EventTrigger.Entry();
            entryEndDrag.eventID = EventTriggerType.EndDrag;
            entryEndDrag.callback.AddListener(JoyEndDrag);
            eventTrigger.triggers.Add(entryEndDrag);
        }
    }

    private void JoyOnDrag(BaseEventData Data)
    {
        Vector2 delta = (Data as PointerEventData).delta;
        // print("--------------------------");
        // print("anchoredPosition = " + joy.anchoredPosition);
        // print("position = " + joy.position);
        // print("delta = " + delta);
        joy.position += new Vector3(delta.x, delta.y, 0);
        if (joy.anchoredPosition.magnitude > 130)
        {
            joy.anchoredPosition = joy.anchoredPosition.normalized * 130;
        }
        player.ChangeMoveDir(joy.anchoredPosition);
    }

    private void JoyEndDrag(BaseEventData Data)
    {
        joy.anchoredPosition = Vector2.zero;
        player.ChangeMoveDir(Vector2.zero);
    }
}
