using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OptionsMenu : MonoBehaviour
{
    public Text sliderText;
    public Slider slider;
    public AudioSource gameMusic;

    // Start is called before the first frame update
    void Start()
    {
        slider.value = gameMusic.volume;
    }

    // Update is called once per frame
    void Update()
    {
        sliderText.text = ((int)(slider.value * 100)).ToString() + "%";
    }
}
