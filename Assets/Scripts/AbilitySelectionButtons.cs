using UnityEngine;
using UnityEngine.UI;


public class AbilitySelectionButtons : MonoBehaviour
{
    public string abilityName;
    public Text abilityText;
    public GameObject DiveAbility;
    public bool DAS = false;
    public GameObject LeapAbility;
    public bool LAS = false;
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
        LAS = true;
        abilityName = "Leap";
        LeapAbility.SetActive(true);
        AbilitySelector.SetActive(false);
    }

    
}
