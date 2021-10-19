using System.Security.Cryptography;
using UnityEngine;

public class BobLifecycle : MonoBehaviour
{
    [SerializeField] private int health;
    [SerializeField] private GameObject explosion;
    

    public void TakeDamage(int damage)
    {
        health -= damage;
        if (health <= 0)
        {
            print("Game Over");
            Instantiate(explosion, transform.position, Quaternion.identity);
            Destroy(gameObject);
        }
    }
}
