
using UnityEngine;

public class DoorDisappears : MonoBehaviour
{
    public KeyCode openKey = KeyCode.E; 
    private bool isPlayerNearby = false; 

    void Update()
    {
        
        if (isPlayerNearby && Input.GetKeyDown(openKey) && KeyPickup.hasKey)
        {
            gameObject.SetActive(false); 
            Debug.Log("Door opened!");
            KeyPickup.hasKey = false;
        }
        else if (isPlayerNearby && Input.GetKeyDown(openKey) && !KeyPickup.hasKey)
        {
            Debug.Log("You need a key to open this door!");
        }
    }

    void OnTriggerEnter(Collider other)
    {
        
        if (other.CompareTag("Player"))
        {
            isPlayerNearby = true; 
            Debug.Log("Press E to open the door.");
        }
    }

    void OnTriggerExit(Collider other)
    {
        
        if (other.CompareTag("Player"))
        {
            isPlayerNearby = false; 
        }
    }
}