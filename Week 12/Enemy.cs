using UnityEngine;
using System.Collections;

public class Enemy : MonoBehaviour
{
    public int enemyHealth = 50;
    private bool isDead = false;

    public void TakeDamage(int damage)
    {
        if(isDead)
            return;
        
        enemyHealth -= damage;

        Debug.Log("Enemy Health: " + enemyHealth);

        if (enemyHealth <= 0)
        {
            StartCoroutine(Death());
        }
    }

    IEnumerator Death ()
    {
        isDead = true;

        Debug.Log("ENEMY VANQUISHED");

        yield return new WaitForSeconds(2f);

        Destroy(gameObject);
    }
}