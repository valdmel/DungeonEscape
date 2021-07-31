using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TemporarySoundEffect : MonoBehaviour
{
    #region VARIABLES
    private AudioSource audioSource;
    #endregion

    #region MONOBEHAVIOUR CALLBACK METHODS
    private void Awake() => audioSource = GetComponent<AudioSource>();

    void Start() => StartCoroutine(StopPlayingSound());
    #endregion

    private IEnumerator StopPlayingSound()
    {
        yield return new WaitForSeconds(audioSource.clip.length);

        Destroy(gameObject);
    }
}
