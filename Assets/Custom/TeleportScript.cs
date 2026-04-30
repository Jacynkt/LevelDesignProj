using UnityEngine;

public class TeleportScript: MonoBehaviour
{
    public float distance;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            other.transform.position = new Vector3(other.transform.position.x + distance, other.transform.position.y, other.transform.position.z);

        }
    }
}
    