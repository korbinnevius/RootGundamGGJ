using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndTrigger : MonoBehaviour
{
    public RootsGameManager rootsGM;
    [SerializeField] private HealthComponent bossHealth;
    [SerializeField] private HealthComponent playerHealth;
    [SerializeField] private BoxCollider playerHitbox;
    [SerializeField] private BoxCollider bossHitbox;

    private void Update()
    {
        BossIsDead();
        PlayerIsDead();
    }

    private void BossIsDead()
    {
        if (bossHealth.CurrentHealth <= 0)
        {
            rootsGM.CompleteLevel();
            playerHitbox.enabled = false;
        }
    }
    
    private void PlayerIsDead()
    {
        if (playerHealth.CurrentHealth <= 0)
        {
            rootsGM.EndGame();
            bossHitbox.enabled = false;
        }
    }
}
