using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ClickRotate : MonoBehaviour
{
    public Button btn;
    private void Start()
    {
        btn.onClick.AddListener(() => rotate());
    }
    void rotate()
    {
        Debug.Log("image clicked");
        if (!PuzzleGameControll.youWin) {
            transform.Rotate(0f, 0f, 90f);
        }
    }
}
