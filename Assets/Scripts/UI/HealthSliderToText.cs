using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class HealthSliderToText : MonoBehaviour
{

    public TMP_Text text;
    public Slider slider;

    void Start()
    {

        slider = GetComponent<Slider>();

    }

    // Update is called once per frame
    void Update()
    {
        text.text = " " + Mathf.Round(slider.value * 100) + "/100";
    }
}
