using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class buttonScript : MonoBehaviour {
    public GameObject door;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Destroy(door);
    }
}
