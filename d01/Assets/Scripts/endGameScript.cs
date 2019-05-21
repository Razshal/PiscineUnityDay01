using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class endGameScript : MonoBehaviour {
    public GameObject end1;
    public GameObject end2;
    public GameObject end3;
    private bool playerWin = false;
    public bool loadSceneOnWin = false;
    public string sceneToLoadOnWin = "ex01";

    // Update is called once per frame
    void Update()
    {
        if (!playerWin
            && end1.GetComponent<exitScript>().isOk
            && end2.GetComponent<exitScript>().isOk
            && end3.GetComponent<exitScript>().isOk)
        {
            Debug.Log("You win");
            playerWin = true;
            if (loadSceneOnWin)
                SceneManager.LoadScene(sceneToLoadOnWin);
        }
    }
}
