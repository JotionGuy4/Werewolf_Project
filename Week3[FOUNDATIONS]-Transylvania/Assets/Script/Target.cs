﻿using UnityEngine;


public class Target : MonoBehaviour {

    public float health = 50f;

    public void TakeDamge(float amount)
    {
        health -= amount;
        if (health <= 0f)
        {
            Die();
        }
    }

    void Die ()
    {
        Destroy(gameObject);
    }    

}
