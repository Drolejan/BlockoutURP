using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class change : MonoBehaviour
{
    Slider slider;
    // Start is called before the first frame update
    void Start()
    {
        slider = GetComponent<Slider>();
        slider.value = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (slider.value < 10)
        {
            slider.value+=0.1f;
        }
        else
        {
            slider.value = 0;
        }
        
    }
}
