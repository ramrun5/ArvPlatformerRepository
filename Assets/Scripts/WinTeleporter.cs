using UnityEngine;

public class WinTeleporter : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {


        if (collision.CompareTag("WinThing"))
        {
            UnityEngine.SceneManagement.SceneManager.LoadScene("Win Screen");
        }


    }
}

