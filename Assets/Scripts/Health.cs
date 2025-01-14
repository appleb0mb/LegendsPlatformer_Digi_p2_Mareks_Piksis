﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Health : MonoBehaviour
{
    [Tooltip("The particles that appear after the player collects a coin.")]
    public GameObject coinParticles;

PlayerMovement playerMovementScript;

void OnTriggerEnter(Collider other)
{
    if (other.gameObject.tag == "Player")
    {
        playerMovementScript = other.GetComponent<PlayerMovement>();
        playerMovementScript.soundManager.PlayCoinSound();
        ScoreManager.health -= 1;
        GameObject particles = Instantiate(coinParticles, transform.position, new Quaternion());
        Destroy(gameObject);
            
    }
}
}