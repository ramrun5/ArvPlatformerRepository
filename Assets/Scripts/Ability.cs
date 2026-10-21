using UnityEngine;
using UnityEngine.UI;
public class Ability : AbilitySelectionButtons
{
    
    public Rigidbody2D rb;

    public void Update()
    {
        abilityText.text = abilityName;
    }

    public void TriggerAbility()
    {
        if (DAS)
        {
            rb.linearVelocity = new Vector3(0, -15, 0); 
        }
        if (LAS)
        {
            rb.linearVelocity = new Vector3(0, 15, 0);
        }
    }
}
