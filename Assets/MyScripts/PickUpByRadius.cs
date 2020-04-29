using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUpByRadius : MonoBehaviour
{
    public Note note;
    private bool hasInteracted = false;
    public Transform player;
    public float radius = 3f;
    private void Update()
    {
        if (!hasInteracted)
        {
            float distance = Vector3.Distance(player.position, transform.position);
            if (distance <= radius)
            {
                pickUp();
                hasInteracted = true;
            }
        }
    }
    void pickUp() 
    {
        Debug.Log("Picking up by radius " + note.name);
        bool pickedUp = Diary.instance.Add(note);
        if (pickedUp)
        {
            Destroy(gameObject);
        }
    }
}
