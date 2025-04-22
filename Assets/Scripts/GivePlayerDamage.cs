using cowsins;
using UnityEngine;

public class GivePlayerDamage : MonoBehaviour
{


   // public IDamageable damageable;
    public PlayerStats playerStats;
    public float damageValue;
    
    void Start()
    {
        damageValue = 10;
    }

    private void OnTriggerEnter(Collider collide)
    {
        if (collide.gameObject.tag == "Player")
        {
            Debug.Log("Is triggered");
            playerStats.Damage(damageValue,false);
        }
    }
}
