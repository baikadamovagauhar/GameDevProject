using UnityEngine;

[CreateAssetMenu(fileName = "New Note", menuName = "Inventory/Note")]

public class Note : ScriptableObject
{
    new public string name = "New Note";
    public string text = "Some text";
    public int type = 2;
}
