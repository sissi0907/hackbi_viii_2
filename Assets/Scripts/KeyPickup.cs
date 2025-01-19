
using UnityEngine;

public class KeyPickup : MonoBehaviour
{
    public static bool hasKey = false; 
    public KeyCode pickupKey = KeyCode.F; 
    private bool isPlayerNearby = false; 

    void Update()
    {
        
        if ( Input.GetKeyDown(pickupKey))
        {
            hasKey = true; 
            Debug.Log("Key picked up!");
            gameObject.SetActive(false); 
        }

        
    }

   
}