using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class HurtEffect : MonoBehaviour
{

    public TMP_Text text;
    public Image image;
    int found = 0;
    Color color1;
    Color color2;
    float time = 1.5f;

    void Start()
    {

        image = GetComponent<Image>();
        color1 = new Color(image.color.r, image.color.g, image.color.b, 0.0f);
        color2 = new Color(image.color.r, image.color.g, image.color.b, 0.5f);

    }


    // Update is called once per frame
    void Update()
    {

        found = text.text.IndexOf("/");
        
        if (int.Parse(text.text.Substring(1, found - 1)) < 20) {

            image.color = Color.Lerp(color1, color2, Mathf.PingPong(Time.time, time)/time);

        } else {

            image.color = new Color(image.color.r, image.color.b, image.color.g, 0f);

        }
        

    }
}
