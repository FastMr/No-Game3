﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    public float value = 100;
    public RectTransform valueRectTransform;
    public GameObject gameplayUI;
    public GameObject gameOverScreen;

    private float maxValue;
    // Start is called before the first frame update
    void Start()
    {
        maxValue = value;
        DrawHealthBar();
    }

    // Update is called once per frame
    void Update()
    {

    }
    public void DealDamage(float damage)
    {
        value -= damage;
        if (value <= 0)
        {
            PlayerIsDead();
        }

        DrawHealthBar();
    }
    private void DrawHealthBar()
    {
        valueRectTransform.anchorMax = new Vector2(value/maxValue, 1);
    }
    private void PlayerIsDead()
    {
            gameplayUI.SetActive(false);
            gameOverScreen.SetActive(true);
            GetComponent<PlayerController>().enabled = false;
            GetComponent<FireballCaster>().enabled = false;
            GetComponent<CameraRotation>().enabled = false;
    }

}
