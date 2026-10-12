using UnityEngine;



public class AbilitySelectionButtons : MonoBehaviour
{
    public string abilityName;
    public GameObject DiveAbility;
    public bool DAS = false;
    public GameObject JumpBoostAbility;
    public bool JBAS = false;
    public GameObject SpeedAbility;
    public bool SAS = false;
    public GameObject AbilitySelector;

    public void SelectAbility1()
    {
        DAS = true;
        abilityName = "Dive";
        DiveAbility.SetActive(true);
        AbilitySelector.SetActive(false);
    }

    public void SelectAbility2()
    {
        JBAS = true;
        abilityName = "Jump Boost";
        JumpBoostAbility.SetActive(true);
        AbilitySelector.SetActive(false);
    }

    public void SelectAbility3()
    {
        SAS = true;
        abilityName = "Speed";
        SpeedAbility.SetActive(true);
        AbilitySelector.SetActive(false);
    }
}
