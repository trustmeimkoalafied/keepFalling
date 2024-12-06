using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Portal1 : MonoBehaviour
{
    private HashSet<GameObject> portalObjects = new HashSet<GameObject>();

    [SerializeField] private Transform destination;

    private void OnTriggerEnter2D(Collider2D collision){


        if(portalObjects.Contains(collision.gameObject)){
            return;
        }

        if(destination.TryGetComponent(out Portal1 destinationPortal)){
            destinationPortal.portalObjects.Add(collision.gameObject);
        }

        collision.transform.position = destination.position;

    }

    private void OnTriggerExit2D(Collider2D collision){
        
        portalObjects.Remove(collision.gameObject);
    }
}
