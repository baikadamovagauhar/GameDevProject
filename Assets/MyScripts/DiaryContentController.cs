using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;
public class DiaryContentController : MonoBehaviour
{
    public GameObject leftBtn;
    public GameObject rightBtn;
    public Transform page1;
    public Transform page2;
    Diary diary;
    
    int currentPage = 1;
    double totalPages;
    public List<Text> texts = new List<Text>();
    Text[] textsPage1;
    Text[] textsPage2;
    // Start is called before the first frame update
    void Start()
    {
        diary = Diary.instance;
        diary.onNoteChangedCallBack += UpdatePages;
        totalPages = (diary.notes.Count / 6.0);
        textsPage1 = page1.GetComponentsInChildren<Text>();
        textsPage2 = page2.GetComponentsInChildren<Text>();

        if (textsPage1.Length > 0)
        {
            for (int i = 0; i < textsPage1.Length; i++)
            {
                texts.Add(textsPage1[i]);
            }
            if (textsPage2.Length > 0)
            {
                for (int i = 0; i < textsPage2.Length; i++)
                {
                    texts.Add(textsPage2[i]);
                }
            }
        }
    }


    void UpdatePages()
    {
        if (diary.notes != null && diary.notes.Count>0)
        {
            leftBtn.SetActive(true);
            /*if (currentPage == 1) {
                leftBtn.SetActive(false);
            }
            if (currentPage < (diary.notes.Count / 6.0))
            {  
                rightBtn.SetActive(false);
            } else {
                Debug.Log("current: " + currentPage);
                Debug.Log("diary count: " + (diary.notes.Count / 6.0));
                rightBtn.SetActive(true);
            }*/

            for (int i = (currentPage-1)*6; i < diary.notes.Count; i++)
            {
                if (i == currentPage * 6)
                {
                    break;
                }
                texts[i].text = diary.notes[i].text;
            }
        }
    }

    public void leftClick()
    {
        currentPage--;
        UpdatePages();
        Debug.Log("Left btn clicked");
    }
    public void rightClick()
    {
        Debug.Log("Right btn clicked");
        currentPage++;
        UpdatePages();
       
    }
}
