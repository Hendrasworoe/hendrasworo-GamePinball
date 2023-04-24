using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public AudioSource bgmAudioSource;

    public GameObject bumperSfxAudioSource;
    public GameObject switchSfxAudioSource;

    private void Start()
    {
        PlayBGM();
    }

    public void PlayBGM()
    {
        bgmAudioSource.Play();
    }

    public void PlaySFX(Vector3 spawnPosition, string whichSfx)
    {
        switch (whichSfx)
        {
            case "Switch":
                GameObject.Instantiate(switchSfxAudioSource, spawnPosition, Quaternion.identity);
                break;
            case "Bumper":
                GameObject.Instantiate(bumperSfxAudioSource, spawnPosition, Quaternion.identity);
                break;
            default:
                break;
        }
    }

    public void PlaySFX(Vector3 spawnPosition)
    {
        GameObject.Instantiate(bumperSfxAudioSource, spawnPosition, Quaternion.identity);
    }
}
