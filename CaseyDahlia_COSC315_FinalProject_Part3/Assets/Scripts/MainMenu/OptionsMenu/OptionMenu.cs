using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class OptionMenu : MonoBehaviour
{

    public AudioMixer audioOption;
    public void SetBackGroundMusic (float volumeBGM)
    {
        Debug.Log(volumeBGM);
        audioOption.SetFloat("volumeBGM", volumeBGM);
    }

    public void SetSoundEffect (float volumeSE)
    {
        Debug.Log(volumeSE);
    }

    public void SetFullscreen (bool isFullscreen)
    {
        Screen.fullScreen = isFullscreen;
        Debug.Log("Is fullscreen");
    }

    public void SetWindow (bool isWindowscreen)
    {
        Screen.SetResolution(800, 600, false);
        Debug.Log("Is windowed");
    }
  


}
