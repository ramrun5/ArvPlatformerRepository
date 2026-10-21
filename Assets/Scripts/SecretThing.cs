using UnityEngine;

public class SecretThing : TorchScript
{
    private void OnTriggerEnter2D(Collider2D collision)
    {


        if (collision.CompareTag("Secret"))
        {
            SwoonActivator();
        }
        if (collision.CompareTag("Secret2"))
        {
            LightTorch();
        }

    }
}
