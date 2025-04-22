using UnityEngine;

public class ZombieHitTrigger : MonoBehaviour
{
    public BoxCollider box;
    void Start()
    {
        box.enabled = false;
        Debug.Log("Box Disabled");
    }

    public void ZombieAttackStart()
    {
        box.enabled = true;
        Debug.Log("Box Enabled");
    }

    public void ZombieAttackEnd()
    {
        box.enabled = false;
        Debug.Log("Box Disabled");
    }
}
