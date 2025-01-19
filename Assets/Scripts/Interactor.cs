using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using static Scoring;

interface IInteractable {
    public void Interact();
}
public class Interactor : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public Transform InteractorSource;
    public float InteractRange;
    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Z)){
            Ray r = new Ray(InteractorSource.position, InteractorSource.forward);
            if (Physics.Raycast(r, out RaycastHit hitInfo, InteractRange)){
                if (hitInfo.collider.gameObject.TryGetComponent(out IInteractable interactObj)){
                    interactObj.Interact();
                    // coin.AddScore(1);
                }
            }
        }
    }
}
