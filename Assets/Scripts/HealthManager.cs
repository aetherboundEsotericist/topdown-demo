using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;

public class HealthManager : MonoBehaviour
{
    [SerializeField] private int currentHealth;
    [SerializeField] public EnemyDataSO enemyStats;
    void Start()
    {
        currentHealth = enemyStats.maxHealth;
    }

    // Update is called once per frame
    void Update()
    {
        if (currentHealth == 0)
        {
            Destroy(gameObject);
        }
    }

    public void updateHealth(int healthToSubtract)
    {
        currentHealth = currentHealth - healthToSubtract;
    }
}
