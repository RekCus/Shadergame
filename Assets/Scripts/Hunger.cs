using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hunger : MonoBehaviour
{
    public Material material;
    public float hungerValue;
    public HungerBAR hungerbar;
    // Start is called before the first frame update
    void Start()
    {
        hungerValue = 1f;
        hungerbar.SetMaxHunger(hungerValue);
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(hungerValue);
        if(hungerValue > 1f)
        {
            hungerValue = 1f;
        }
        else if(hungerValue > 0)
        {
            hungerValue -= Time.deltaTime / 5;
        }
        else if(hungerValue <= 0)
        {
            hungerValue = 0;
        }

        hungerbar.SetHunger(hungerValue);
        material.SetFloat("Hunger", hungerValue);
    }

    public void AddHunger(float food)
    {
        hungerValue += food;
    }
}
