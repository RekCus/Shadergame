using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Food : MonoBehaviour
{
    public Hunger hunger;
    public GameObject player;
    void Start()
    {
        player = GameObject.FindWithTag("Player");
        hunger = player.GetComponent<Hunger>();
    }

    private void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject == player )
        {
            hunger.AddHunger(0.3f);
            Destroy(gameObject);
        }
    }

   
}
