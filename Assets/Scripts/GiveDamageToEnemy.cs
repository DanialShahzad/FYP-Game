using cowsins;
using UnityEngine;

public class GiveDamageToEnemy : MonoBehaviour
{

    // public IDamageable damageable;
    private EnemyHealth enemyHealth;
    public float damageValue;

    void Start()
    {
        /*Rigidbody rb = gameObject.AddComponent<Rigidbody>();
        rb.isKinematic = true;*/
        damageValue = 1;
    }

    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("Collided with enemy" + collision.gameObject.name);
        if (collision.gameObject.CompareTag("Enemy"))
        {
            enemyHealth = collision.gameObject.GetComponent<EnemyHealth>();
            if (enemyHealth != null)
            {
                Debug.Log("Collided with enemy" +collision.gameObject.name);
                enemyHealth.Damage(damageValue, false);
            }
        }
    }

}
