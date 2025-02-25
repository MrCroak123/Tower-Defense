using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageTester : MonoBehaviour
{
    public AttributesManager playerAtm;
    public AttributesManager enemyAtm;

    private void Update()
    {
        //Deal player damage to the enemy health
        if (Input.GetKeyDown(KeyCode.E))
        {
            playerAtm.DealDamage(enemyAtm.gameObject);
        }

        //Deal enemy damage to the player health
        if (Input.GetKeyDown(KeyCode.R))
        {
            enemyAtm.DealDamage(playerAtm.gameObject);
        }
    }
}
