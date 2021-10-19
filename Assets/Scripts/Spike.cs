using System;
using UnityEngine;

public class Spike : MonoBehaviour
{
    [SerializeField] private float speed;
    [SerializeField] private int damage;
    

    void Update()
    {
        transform.Translate(Vector3.left *speed*Time.deltaTime);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            other.GetComponent<BobLifecycle>().TakeDamage(damage);
            Destroy(gameObject);
        }
    }
}
