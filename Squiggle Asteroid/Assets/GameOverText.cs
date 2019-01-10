using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOverText : MonoBehaviour {

    public GameObject gameOverText;
    public bool test;

    private void Update()
    {
        if (test)
        {
            gameOverText.SetActive(true);
        }
    }
}
