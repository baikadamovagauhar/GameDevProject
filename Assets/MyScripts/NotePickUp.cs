using UnityEngine;
using UnityEngine.UI;

public class NotePickUp : Interactable
{
	public Note note;
	public Image image1;
	public Image image2;
	public Image image3;
	public Image image4;
	public Image image5;
	public Image image6;
	public Image image7;
	public Image image8;
	public Image image9;
	
	public GameObject puzzleLayer;
	public override void Interact(){
		base.Interact();
		pickUp();
	}
	
	void pickUp() {
		image1.sprite = note.image1;
		image1.enabled = true;
		image2.sprite = note.image2;
		image2.enabled = true;
		image3.sprite = note.image3;
		image3.enabled = true;
		image4.sprite = note.image4;
		image4.enabled = true;
		image5.sprite = note.image5;
		image5.enabled = true;
		image6.sprite = note.image6;
		image6.enabled = true;
		image7.sprite = note.image7;
		image7.enabled = true;
		image8.sprite = note.image8;
		image8.enabled = true;
		image9.sprite = note.image9;
		image9.enabled = true;
		puzzleLayer.SetActive(true);
		Debug.Log("Picking up " + note.name);
		bool pickedUp = Diary.instance.Add(note);
		if (pickedUp){
			gameObject.SetActive(false);
		}
	}
}

