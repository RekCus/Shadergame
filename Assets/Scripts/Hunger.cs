using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hunger : MonoBehaviour
{
    public Material material;
    public float hungerValue;
    public HungerBAR hungerbar;
    public float minHunger;
    public float maxHunger;
    // Start is called before the first frame update
    void Start()
    {
        minHunger = -0.02f;
        maxHunger = 0.04f;
        hungerValue = maxHunger;
        hungerbar.SetMaxHunger(maxHunger);
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(hungerValue);
        if(hungerValue > maxHunger)
        {
            hungerValue = maxHunger;
        }
        else if(hungerValue > minHunger)
        {
            hungerValue -= Time.deltaTime / 55;
        }
        else if(hungerValue <= minHunger)
        {
            hungerValue = minHunger;
        }

        hungerbar.SetHunger(hungerValue);
        material.SetFloat("Hunger", hungerValue);
    }

    public void AddHunger(float food)
    {
        hungerValue += food;
    }
}
