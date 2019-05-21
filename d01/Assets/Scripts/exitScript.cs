using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class exitScript : MonoBehaviour {
    public GameObject character;
    public bool isOk = false;

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject == character)
            isOk = true;
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject == character)
            isOk = false;
    }
}
