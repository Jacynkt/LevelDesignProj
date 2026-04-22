using UnityEngine;

public class KillScript: MonoBehaviour
{
    public Vector3 Spawnpoint;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            other.transform.position = Spawnpoint;//(where you want to teleport)

        }
    }
}
