using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using TMPro;
using System;

public class SettingsMenu : MonoBehaviour
{
    public GameObject firstoptions;
    public TMP_Dropdown resolutionDropdown;

    
    bool isFullscreen;
    public static float roundNumber = 3;

    Resolution[] resolutions;

    void Start()
    {
        showResolutions();     
    }

    private void Awake() 
    {
        DontDestroyOnLoad(this.gameObject);
    }


    private void showResolutions()
    {
        resolutions = Screen.resolutions;
        resolutionDropdown.ClearOptions(); //Clears options in the dropdown
        List<string> options = new List<string>();
        int currentResolutionIndex = 0;
        for (int i = 0; i < resolutions.Length; i++)
        {
            string option = resolutions[i].width + " x " + resolutions[i].height + "@" + resolutions[i].refreshRate + "hz"; ;
            options.Add(option);
            if (resolutions[i].width == Screen.width && resolutions[i].height == Screen.height)
            {
                currentResolutionIndex = i;
            }
        }
        resolutionDropdown.AddOptions(options);
        resolutionDropdown.value = currentResolutionIndex;
        resolutionDropdown.RefreshShownValue();
    }

    public void setfirstoption()
    {
        //clear eventsystem
        EventSystem.current.SetSelectedGameObject(null);
        //Set new eventsystem selected button
        EventSystem.current.SetSelectedGameObject(firstoptions);
    }
    
    public void SetResolution (int resolutionIndex) 
    {
        Resolution resolution = resolutions[resolutionIndex];
        Screen.SetResolution(resolution.width, resolution.height, isFullscreen, resolution.refreshRate);
    }

    public void SetFullscreen (bool isFullscreen)
    {
        Screen.fullScreen = isFullscreen;
    }

    public void SetGraphics (int qualityIndex)
    {
        QualitySettings.SetQualityLevel(qualityIndex);
    }

}
