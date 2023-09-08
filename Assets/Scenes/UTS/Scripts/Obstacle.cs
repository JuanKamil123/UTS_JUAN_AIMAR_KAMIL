using UnityEngine;

public class Destroyer : MonoBehaviour
{
    public void OnCollisionEnter2D(Collision2D other)
    {
        if (!other.gameObject.CompareTag("Bola")) return;
        Destroy(gameObject);
    }
}