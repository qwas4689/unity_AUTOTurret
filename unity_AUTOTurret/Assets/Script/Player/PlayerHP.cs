using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHP : MonoBehaviour
{
    public GameObject gamePlayer;

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Bullet")
        {
            Die();
            FindObjectOfType<GameManager>().End();
        }
    }

    private void Die()
    {
        gamePlayer.SetActive(false);
    }
}
