using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Buttons : MonoBehaviour {

    //when Play button is pressed, script loads gaame scene
    public void Play()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex+1);
    }

    //when Exit button is pressed, script quits the game
    public void Exit()
    {
        Application.Quit();
    }

}
