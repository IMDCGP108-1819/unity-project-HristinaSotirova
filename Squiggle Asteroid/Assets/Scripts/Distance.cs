using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class Distance : MonoBehaviour {

    public TextMeshProUGUI distanceTracker;
    private float lightYearCount;
    private int parsecCount;

    void Update()
    {
        UpdateDistanceUI();
    }

    //changes text of the Units text box on the principles of a timer
    public void UpdateDistanceUI()
    {
        lightYearCount += Time.deltaTime;
        distanceTracker.text = parsecCount + "pc" + (int)lightYearCount + "lyr";
        if (lightYearCount >= 3.26)
        {
            parsecCount++;
            lightYearCount = 0;
        }
    }
}
