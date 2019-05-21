using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movingPlatformScript : MonoBehaviour {

    public float speed = 0.05f;
    public float secondsBeforeChangingDirection = 2;
    public float timer;

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

	void Start()
	{
        timer = secondsBeforeChangingDirection;
	}

	void Update () {
        timer -= Time.deltaTime;
        if (timer <= 0)
        {
            timer = secondsBeforeChangingDirection;
            speed = -speed;
        }
        gameObject.transform.Translate(speed, 0, 0);
	}
}
