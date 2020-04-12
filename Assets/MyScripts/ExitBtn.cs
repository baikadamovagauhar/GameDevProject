using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ExitBtn : MonoBehaviour
{
    public GameObject Diary;
    public void closDiary()
    {
        Diary.SetActive(!Diary.activeSelf);
    }
}
