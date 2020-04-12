using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DiaryController : MonoBehaviour
{
    public GameObject DiaryContent;
  
    public void openDiary()
    {
        DiaryContent.SetActive(!DiaryContent.activeSelf);
    }
}
