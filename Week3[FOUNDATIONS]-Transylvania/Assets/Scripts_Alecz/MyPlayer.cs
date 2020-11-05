using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MyPlayer : MonoBehaviour
{
    public int maxHealth = 20;
    public int currentHealth;
    public MyHealthBar healthBar;

    //public GameObject postprocessVolume;

    private void Start()
    {
        currentHealth = maxHealth;
        healthBar.SetMaxHealth(maxHealth);

        switch (GameValues.Difficulty)
        {
            case GameValues.Difficulties.Easy:
                maxHealth = 10;

                break;
            case GameValues.Difficulties.Hard:
                maxHealth = 40;
                break;
        }


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
            TakeDamage(3);
            //postprocessVolume.SetActive(true);

        }
    }


        public void TakeDamage (int damage)
        {
        currentHealth -= damage;
        healthBar.SetHealth(currentHealth);
        }

  /*  void Update()
    {
        if(maxHealth<=0)
        {
            Restart();
        }
    }

    void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

  */

}
