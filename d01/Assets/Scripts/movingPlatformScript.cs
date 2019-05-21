using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movingPlatformScript : MonoBehaviour {

    public float speed = 0.05f;
    public bool moveToTheLeft = true;
    public GameObject delimiter1;
    public GameObject delimiter2;

	private void OnCollisionStay2D(Collision2D collision)
	{
        if (collision.gameObject.tag == "Player")
            collision.gameObject.transform.parent = gameObject.transform;
	}

	private void OnCollisionExit2D(Collision2D collision)
	{
        if (collision.gameObject.tag == "Player")
            collision.gameObject.transform.parent = null;
	}

	private void OnTriggerEnter2D(Collider2D collision)
	{
        if (collision.gameObject.tag == "Delimiter")
            moveToTheLeft = !moveToTheLeft;
	}

	void Update () {
        gameObject.transform.Translate(moveToTheLeft ? speed : -speed, 0, 0);
	}
}
