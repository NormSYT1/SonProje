using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SetBrightness : MonoBehaviour
{
    public Image brightnessPanel;
    public Slider brightnessSlider;
    private float sliderValue;
    void Start()
    {
        brightnessSlider.value = PlayerPrefs.GetFloat("brightness", 0.5f);
        brightnessPanel.color = new Color(brightnessPanel.color.r, brightnessPanel.color.g, brightnessPanel.color.b, sliderValue);
    }
    void Update()
    {
        
    }
    public void Brightness(float value1)
    {
        sliderValue = value1;
        PlayerPrefs.SetFloat("brightness", sliderValue);
        brightnessPanel.color = new Color(brightnessPanel.color.r, brightnessPanel.color.g, brightnessPanel.color.b, sliderValue);
    }
}
