using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class IgnoreScreen : MonoBehaviour
{
    private void Start()
    {
        EventTrigger eventTrigger = gameObject.GetComponent<EventTrigger>();

        EventTrigger.Entry entry = new EventTrigger.Entry();

        entry.eventID = EventTriggerType.PointerDown;

        entry.callback.AddListener((x) =>
        {
            Trigger();
        });

        eventTrigger.triggers.Add(entry);
    }

    public void Trigger()
    {
        Debug.Log("Trigger");
    }
}