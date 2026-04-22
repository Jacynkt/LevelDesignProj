using UnityEngine;

public class EnableObject: MonoBehaviour
{
    public GameObject EnabledObject;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {

            EnabledObject.SetActive(true);

        }
    }
}
