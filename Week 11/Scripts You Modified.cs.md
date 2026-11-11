# Computer As A Medium
### This is a repo for the Computer As A Medium Fall 2026.
### Group Name: [Strawhat Crew]
### Group Members: [Andre Belokonev]


Task 1: Andre

using TMPro;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMana : MonoBehaviour
{
    public int mana = 100;
    public TMP_Text manaText;
    public Animator animator;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        manaText.text = "Mana: " + mana;
    }

    // Update is called once per frame
    void Update()
    {
        if (Keyboard.current.rKey.wasPressedThisFrame)
        {
            if(mana >= 10)
            {
                mana -= 10;
                animator.SetTrigger("Cast");

            }
        }

        manaText.text = "Mana: " + mana;
    }
}


Task 2: Andre


using UnityEngine;

public class HealthPack : MonoBehaviour
{
    public PlayerHealth playerHealth;
   
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            if (playerHealth.health < 100)
            {
                playerHealth.health = Mathf.Min(playerHealth.health + 10, 100);
            }

            Destroy(gameObject);

        }
    }
}


Task 3: Deniz

using UnityEngine;

public class Trap : MonoBehaviour
{
    public PlayerHealth playerHealth;
    public GameObject trapEffect;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            trapEffect.SetActive(true);
            playerHealth.health -= 10;
        }
    }
}