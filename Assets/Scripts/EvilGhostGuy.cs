using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class EvilGhostGuy : MonoBehaviour
{
    public GameObject NikeLogo;
    public AudioSource source;
    public AudioClip swoonSound;
    public void SwoonActivator()
    {
        StartCoroutine(SWOON());
    }
    IEnumerator SWOON()
    {

        NikeLogo.SetActive(true);
        source.PlayOneShot(swoonSound);
        yield return new WaitForSeconds(2);
        transform.position = new Vector3(0, 0, 0);
        NikeLogo.SetActive(false);

    }
}
