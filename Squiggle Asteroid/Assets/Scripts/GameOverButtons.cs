using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverButtons : MonoBehaviour {

    //loads menu scene
    public void BackToMenu()
    {
        SceneManager.LoadScene(0);
    }

    //loads game scene
    public void Restart()
    {
        SceneManager.LoadScene(1);
    }

}
