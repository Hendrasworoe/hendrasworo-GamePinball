using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VFXManager : MonoBehaviour
{
    public GameObject vfxSource;
    public GameObject switchVfxSource;

    public void PlayVFX(Vector3 spawnPosition, string whichSfx)
    {
        switch (whichSfx)
        {
            case "Switch":
                GameObject.Instantiate(switchVfxSource, spawnPosition, Quaternion.identity);
                break;
            case "Bumper":
                GameObject.Instantiate(vfxSource, spawnPosition, Quaternion.identity);
                break;
            default:
                break;
        }
    }

    public void PlayVFX(Vector3 spawnPosition)
    {
        GameObject.Instantiate(vfxSource, spawnPosition, Quaternion.identity);
    }
}
