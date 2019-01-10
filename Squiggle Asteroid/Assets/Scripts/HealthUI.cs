using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthUI : MonoBehaviour {

    public Sprite[] hearts;
    public Image Health;
    private PlayerHealth player;

    //references PlayerHealth script in order to recognize the amount of health left
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerHealth>();
    }

    //updates the health UI when the player loses health
    void Update()
    {
        Health.sprite = hearts[player.health];
    }
}
