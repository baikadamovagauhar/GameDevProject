using UnityEngine;
using UnityEngine.UI;

[CreateAssetMenu(fileName = "New Note", menuName = "Inventory/Note")]

public class Note : ScriptableObject
{
    new public string name = "New Note";
    public string text = "Some text";
    public int type = 2;
    public Sprite image1;
    public Sprite image2;
    public Sprite image3;
    public Sprite image4;
    public Sprite image5;
    public Sprite image6;
    public Sprite image7;
    public Sprite image8;
    public Sprite image9;
}
