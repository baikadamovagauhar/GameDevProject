using UnityEngine;

public class Interactable : MonoBehaviour
{
   public float radius = 3f;
   
   bool isFocused = false;
   bool hasInteracted = false;
   Transform player;
   
   public virtual void Interact()
   {
	   Debug.Log("Interacting with" + transform.name);
   }
   
   void Update()
   {
	   if(isFocused && !hasInteracted)
	   {
		   float distance = Vector3.Distance(player.position, transform.position);
		   if(distance <= radius)
		   {
			   Interact();
			   hasInteracted = true;
		   }
	   }
   }
   
   public void onFocused(Transform playerTransform)
   {
	   isFocused = true;
	   player = playerTransform;
	   hasInteracted = false;
   }
   
   public void onDeFocused()
   {
	   isFocused = false;
	   player = null;
	   hasInteracted = false;
   }
   
   void OnDrawGizmosSelected()
   {
	   Gizmos.color = Color.yellow;
	   Gizmos.DrawWireSphere(transform.position, radius);
   }
}
