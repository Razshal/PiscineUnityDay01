﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class teleporterScript : MonoBehaviour {
    public GameObject teleporterExit;

	private void OnTriggerEnter2D(Collider2D collision)
	{
        if (collision.gameObject.tag == "Player")
            collision.gameObject.transform.position = teleporterExit.transform.position;
	}
}
