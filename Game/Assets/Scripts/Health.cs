using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    public int health;
    public int maxHealth;

    public void TakeHit(int damage)
    {
        health -= damage;

        if (health < 0)
        {
            Death();
        }
    }

    private void Death()
    {
       var movement = gameObject.GetComponent<Movement>();
        Destroy (movement);
        print("Game Over");
    }







 public void GetHeal(int Healing)
    {
        health += Healing;

        if (health > maxHealth)
        {
            health = maxHealth;
        }

    }










}
