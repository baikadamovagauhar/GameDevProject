using UnityEngine;

public class ItemPickUp : Interactable
{
	public Item item;
	
    public override void Interact()
	{
		base.Interact();
		pickUp();
	}
	
	void pickUp()
	{
		Debug.Log("Picking up " + item.name);
		bool pickedUp = Inventory.instance.Add(item);
		if(pickedUp)
		{
			Destroy(gameObject);
		}
	}
}
