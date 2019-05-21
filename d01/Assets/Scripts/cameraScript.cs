using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraScript : MonoBehaviour {
    public GameObject selectedPlayer;

	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.R))
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);

        gameObject.transform.position =
            new Vector3(
                selectedPlayer.transform.position.x,
                selectedPlayer.transform.position.y,
                -10
            );
	}
}
