using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance { get; private set; }
    public AudioManager AudioManager { get; private set; }
    /*
    public GameStateManager GameStateManager { get; private set; }
    public UIManager UIManager { get; private set; }
    */

    private void Awake()
    {
        if (Instance != null && Instance != this)
        {
            Destroy(this);
            return;
        }

        Instance = this;
        
        AudioManager = GetComponentInChildren<AudioManager>();
        
        /*
         * GameStateManager = GetComponentInChildren<GameStateManager>();
         * UIManager = GetComponentInChildren<UIManager>();
         * 
         */
    }
}
