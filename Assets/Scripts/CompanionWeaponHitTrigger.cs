using UnityEngine;

public class CompanionWeaponHitTrigger : MonoBehaviour
{
    public BoxCollider CompanionBoxTrigger;
    void Start()
    {
        
        CompanionBoxTrigger.enabled = false;
        Debug.Log("Box Disabled");
    }

    public void CompanionAttackStart()
    {
        CompanionBoxTrigger.enabled = true;
        Debug.Log("Box Enabled");
    }

    public void CompanionAttackEnd()
    {
        CompanionBoxTrigger.enabled = false;
        Debug.Log("Box Disabled");
    }
}
