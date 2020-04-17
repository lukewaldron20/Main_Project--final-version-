using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorAction : MonoBehaviour
{
    private void Start()
    {
        GameEvents.current.onDoorwayPlayAudio += OnDoorwayPlayAudio;
    }

    private void OnDoorwayPlayAudio()
    {
    }
}
