using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyPlayer : MonoBehaviour
{
    public int maxHealth = 10;
    public int currentHealth;
    public MyHealthBar healthBar;
    //public GameObject postprocessVolume;

    private void Start()
    {
        currentHealth = maxHealth;
        healthBar.SetMaxHealth(maxHealth);
    }

    /* private void Update()
     {
         if (Input.GetButtonDown("Fire1"))
         {
             TakeDamage(1);

         }
     }*/

    void OnTriggerEnter(Collider other)
    {

        if (other.gameObject.tag == "Enemy")
        {
            TakeDamage(1);
            //postprocessVolume.SetActive(true);

        }
    }


        public void TakeDamage (int damage)
    {
        currentHealth -= damage;
        healthBar.SetHealth(currentHealth);
    }

}
