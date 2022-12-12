using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;
using TMPro;

public class SliderValue : MonoBehaviour
{
    [SerializeField] private Slider volumeSlider = null;
    [SerializeField] private TMP_Text volumeTextUI = null;
    [SerializeField] private AudioMixer audioMixer = null;

    [SerializeField] private Slider timerSlider;
    [SerializeField] private TMP_Text timerSliderTextUI;

    void Start()
    {
    LoadValues();
    }

    public void showVolumeValue(float volume) 
    {
        volumeTextUI.text = volume.ToString("0.0");
    }

    public void showTimerValue(float timer)
    {
        timerSliderTextUI.text = timer.ToString("0.0");
    }

    public void changeVolume()
    {
        audioMixer.SetFloat("Volume", volumeSlider.value);
    }

    public void SaveButton()
    {
        float volumeValue = volumeSlider.value;
        PlayerPrefs.SetFloat("VolumeValue", volumeValue);
        float timerValue = timerSlider.value;
        PlayerPrefs.SetFloat("TimerValue", timerValue);

        LoadValues();
    }

    void LoadValues()
    {
        float volumeValue = PlayerPrefs.GetFloat("VolumeValue");
        volumeSlider.value = volumeValue;

        float timerValue = PlayerPrefs.GetFloat("TimerValue");
        timerSlider.value = timerValue;
    }

    /*public void SetRoundnumber()
    {
        roundNumber = timerSlider.value;
    } */

}
