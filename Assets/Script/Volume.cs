using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Volume : MonoBehaviour {

    public Slider VolumeSlider;

    public AudioSource test;

    public void OnValueChanged()
    {
        AudioListener.volume = VolumeSlider.value;
    }
}
