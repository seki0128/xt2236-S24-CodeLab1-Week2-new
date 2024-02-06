using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Main : MonoBehaviour
{
    public static Main instance { get; private set; }
    public AudioManager audioManager;
    public UIManager UIManager;
    public FlowController flowController;
    
    private void Awake()
    {
        if (instance = null)
        {
            instance = this;
            DontDestroyOnLoad(this);
        }
        else
        {
            Destroy(this);
        }

        audioManager = GetComponentInChildren<AudioManager>();
        UIManager = GetComponentInChildren<UIManager>();
        flowController = GetComponentInChildren<FlowController>();
    }
}
