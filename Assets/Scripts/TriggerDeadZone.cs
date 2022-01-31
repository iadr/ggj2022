using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerDeadZone : MonoBehaviour
{
    public GameObject spawnZone;

 void OnTriggerEnter2D(Collider2D col)
    {
        Debug.Log(col.gameObject.name + " : " + gameObject.name + " : " + Time.time);
        if (col.tag == "Player") 
        {
            col.GetComponent<PlayerInput>().ReceiveDamage(); 
            Debug.Log("on trigger");           
            // col.gameObject.transform.position = spawnZone.transform.position;
        }
    }
}
