using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootableItem : MonoBehaviour
{
    public int currentHealth = 3;
    

   

    public void Damage(int damageAmount)
    {
        currentHealth -= damageAmount; //substract damage from currenthealth

        if (currentHealth <=0) // if no more health
        {

           
            gameObject.SetActive(false); //set this item inactive
           
        }

        

    }
}
