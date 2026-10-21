using UnityEngine;

public class HideByDefault : MonoBehaviour
{

    public GameObject AbilityUI1;
    public GameObject AbilityUI2;
    public GameObject LitTorch;
    public GameObject SWOON;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        AbilityUI1.SetActive(false);
        AbilityUI2.SetActive(false);
        LitTorch.SetActive(false);
        SWOON.SetActive(false);

    }

}
