using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractByRadius : MonoBehaviour
{
    public float radius = 3f;

    bool hasInteracted = false;
    Transform player;
    
    Note note;
    public virtual void Interact()
    {
        Debug.Log("Interacting by radius with" + transform.name);
        
    }

    // Update is called once per frame
    void Update()
    {
        if (!hasInteracted)
        {
            float distance = Vector3.Distance(player.position, transform.position);
            if (distance <= radius)
            {
                Interact();
                hasInteracted = true;
            }
        }
    }

    void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.yellow;
        Gizmos.DrawWireSphere(transform.position, radius);
    }
}
