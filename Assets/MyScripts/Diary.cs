using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Diary : MonoBehaviour
{
    public static Diary instance;

    void Awake()
    {
        if (instance != null)
        {
            Debug.LogWarning("More than one instance of Diary found!!!");
            return;
        }
        
        instance = this;
    }

    public delegate void OnNoteChanged();

    public OnNoteChanged onNoteChangedCallBack;

    public List<Note> notes = new List<Note>();

    public bool PuzzleWin = false;

    public void togglePuzzleWin() {
        PuzzleWin = !PuzzleWin;
    }

	public bool Add(Note note)
	{
				
		notes.Add(note);
        
        if (onNoteChangedCallBack != null)
		{
            Debug.Log("Invoking diary");
            onNoteChangedCallBack.Invoke();
		}

		return true;
	}
}
