using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBody : MonoBehaviour
{
    private float maxHealth = 100f;
    private float currentHealth;

    private PlayerStats playerStats;

    // Start is called before the first frame update
    void Start()
    {
        currentHealth = maxHealth;
        playerStats = gameObject.GetComponent<PlayerStats>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    /// <summary>
    /// Allows the currentHealth to be updated by either increasing it when amount is positive and decreasing it when amount is negative
    /// </summary>
    /// <param name="amount"></param>
    public void ChangeHealth(float amount)
    {
        currentHealth += amount;

    }
}

