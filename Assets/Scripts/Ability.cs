using UnityEngine;

public class Ability : AbilitySelectionButtons
{
    public Rigidbody2D rb;

    void Start()
    {
        
    }

   public void TriggerAbility()
    {
        if (DAS)
        {
            rb.linearVelocity = new Vector3(0, -5, -10);
        }
    }
}
