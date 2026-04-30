using UnityEngine;

public class TeleportScriptY: MonoBehaviour
{
    public float distanceY;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            other.transform.position = new Vector3(other.transform.position.x, other.transform.position.y + distanceY, other.transform.position.z);

        }
    }
}
    