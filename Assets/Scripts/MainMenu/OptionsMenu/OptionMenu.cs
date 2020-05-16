using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class OptionMenu : MonoBehaviour
{
    //Detecting Music
    public AudioMixer audioOption;

    //Background music setting from high to low
    public void SetBackGroundMusic (float volumeBGM)
    {
        Debug.Log(volumeBGM);
        audioOption.SetFloat("volumeBGM", volumeBGM);
    }

    //Sound effects setting from high to low
    public void SetSoundEffect (float volumeSE)
    {
        Debug.Log(volumeSE);
        audioOption.SetFloat("volumeSE", volumeSE);
    }

    //Player select to get game fullscreen
    public void SetFullscreen (bool isFullscreen)
    {
        Screen.fullScreen = isFullscreen;
        Debug.Log("Is fullscreen");
    }

    //Player select to get game in a window
    public void SetWindow (bool isWindowscreen)
    {
        Screen.SetResolution(800, 600, false);
        Debug.Log("Is windowed");
    }
  


}
