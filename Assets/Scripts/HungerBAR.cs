using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class HungerBAR : MonoBehaviour
{
    public Slider slider;
    public Image fill;

    public void SetMaxHunger(float hunger)
    {
        slider.maxValue = hunger;
        slider.value = hunger;
    }

    public void SetHunger(float hunger)
    {
        slider.value = hunger;
    }
}
