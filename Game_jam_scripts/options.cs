using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class options : MonoBehaviour
{

    public AudioMixer mixer;
    Resolution[] resolutions;
    public Dropdown resdrop;

    void Start()
    {
       resolutions = Screen.resolutions;
       resdrop.ClearOptions();
       List<string> options = new List<string>();
        int currentResolutionIndex = 0;
        for (int i=0; i<resolutions.Length; i++)
        {
            string option = resolutions[i].width + " x " + resolutions[i].height;
            options.Add(option);

            if (resolutions[i].width == Screen.currentResolution.width && resolutions[i].height == Screen.currentResolution.height)
            {
                currentResolutionIndex = i;
            }
        }

       resdrop.AddOptions(options);
       resdrop.value = currentResolutionIndex;
       resdrop.RefreshShownValue();
    }

    public void SetResolution (int resIndex)
    {
        Resolution resolution = resolutions[resIndex];
        Screen.SetResolution(resolution.width, resolution.height, Screen.fullScreen);
    }

    public void SetVolume(float volume)
    {
        mixer.SetFloat("volume", volume);
    }
    
    public void SetFullscreen(bool isFull)
    {
        Screen.fullScreen = isFull;
    }
}
