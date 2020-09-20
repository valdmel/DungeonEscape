﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DungeonEscape : MonoBehaviour
{
    [SerializeField] Text textComponent;
    [SerializeField] State startingState;
    State[] nextStates;
    State state;

    // Start is called before the first frame update
    void Start()
    {
        state = startingState;
        textComponent.text = state.getStateStory();
    }

    // Update is called once per frame
    void Update()
    {
        changeState();
    }

    public void changeState() {
        var nextStates = state.getNextStates();

        for (int i = 0; i < nextStates.Length; i++) {
            if (Input.GetKeyDown(KeyCode.Alpha1 + i)) {
                state = nextStates[i];
            }
        }

        //playStateAudio(state.getStateAudioClips()[0]);
        textComponent.text = state.getStateStory();
    }
}
