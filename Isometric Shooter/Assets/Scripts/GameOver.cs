﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOver : MonoBehaviour
{
    [SerializeField] private GameObject gameOverPanel;
    public void GameOverPanel()
    {
        gameOverPanel.SetActive(true);
    }
}
