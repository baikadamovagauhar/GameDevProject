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
        totalPages = diary.notes.Count / 6.0;
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

    // Update is called once per frame
    void Update()
    {
        if (currentPage == 1)
            leftBtn.SetActive(false);
        if (currentPage >= totalPages)
        {
            rightBtn.SetActive(false);
        }
    }

    void UpdatePages()
    {
        Debug.Log("Updating page");
        if (diary.notes != null && diary.notes.Count>0)
        {
            for (int i = 0; i < diary.notes.Count; i++)
            {
                texts[i].text = diary.notes[i].text;
            }
        }
    }

    public void leftClick()
    {
        Debug.Log("Left btn clicked");
    }
}
