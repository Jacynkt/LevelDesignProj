using UnityEngine;

public class DisableObject: MonoBehaviour
{
    public GameObject DisabledObject;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {

            DisabledObject.SetActive(false);

        }
    }
}
