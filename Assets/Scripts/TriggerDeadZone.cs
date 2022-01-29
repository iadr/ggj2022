using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerDeadZone : MonoBehaviour
{
    public GameObject spawnZone;

    void OnTriggerEnter2D(Collider2D collider)
    {
        var p = collider.gameObject.GetComponent<Transform>();

    }
}
