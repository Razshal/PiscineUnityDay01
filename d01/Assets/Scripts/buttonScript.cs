using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class buttonScript : MonoBehaviour {
    public GameObject door;
    public bool isRestricted = false;
    public GameObject player;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (!isRestricted || collision.gameObject == player)
            Destroy(door);
    }
}
