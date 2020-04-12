using UnityEngine;

public class NotePickUp : Interactable
{
	public Note note;

	public override void Interact()
	{
		base.Interact();
		pickUp();
	}

	void pickUp() 
	{
		Debug.Log("Picking up " + note.name);
		bool pickedUp = Diary.instance.Add(note);
		if (pickedUp)
		{
			Destroy(gameObject);
		}
	}
}

