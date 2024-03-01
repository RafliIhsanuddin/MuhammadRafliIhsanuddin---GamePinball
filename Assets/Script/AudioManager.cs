using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{


    public AudioSource bgmAudioSource;
    public GameObject sfxAudioSource;
    public GameObject switchSfxOnAudioSource;
    public GameObject switchSfxOffAudioSource;


    // Start is called before the first frame update
    void Start()
    {
        PlayBGM();
    }

    
    private void PlayBGM()
    {
        bgmAudioSource.Play();
    }


    public void PlaySFX(Vector3 spawnPosition)
    {
        GameObject.Instantiate(sfxAudioSource, spawnPosition, Quaternion.identity);
    }


    public void PlaySwitchOnSFX(Vector3 spawnPosition)
    {
        GameObject.Instantiate(switchSfxOnAudioSource, spawnPosition, Quaternion.identity);
    }

    public void PlaySwitchOffSFX(Vector3 spawnPosition)
    {
        GameObject.Instantiate(switchSfxOffAudioSource, spawnPosition, Quaternion.identity);
    }




}
