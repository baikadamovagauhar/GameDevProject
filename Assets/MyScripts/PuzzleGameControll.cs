using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PuzzleGameControll : MonoBehaviour
{
    [SerializeField]
    private Transform[] pictures;

    [SerializeField]
    private GameObject puzzleLayer;

    public GameObject exit;

    public static bool youWin;
    public Button btn1;
    public Button btn2;
    public Button btn3;
    public Button btn4;
    public Button btn5;
    public Button btn6;
    public Button btn7;
    public Button btn8;
    public Button btn9;
    int[] arr = { 0, 90, 180, 270 };
    // Start is called before the first frame update
    void Start()
    {
        
        btn1.onClick.AddListener(() => rotate(0));
        btn2.onClick.AddListener(() => rotate(1));
        btn3.onClick.AddListener(() => rotate(2));
        btn4.onClick.AddListener(() => rotate(3));
        btn5.onClick.AddListener(() => rotate(4));
        btn6.onClick.AddListener(() => rotate(5));
        btn7.onClick.AddListener(() => rotate(6));
        btn8.onClick.AddListener(() => rotate(7));
        btn9.onClick.AddListener(() => rotate(8));
        youWin = false;
        exit.SetActive(false);
        Debug.Log("started");
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("rotation1: " + pictures[0].transform.eulerAngles.z);
        Debug.Log("rotation2: " + pictures[1].transform.eulerAngles.z);
        Debug.Log("rotation3: " + pictures[2].transform.eulerAngles.z);
        Debug.Log("rotation4: " + pictures[3].transform.eulerAngles.z);
        Debug.Log("rotation5: " + pictures[4].transform.eulerAngles.z);
        Debug.Log("rotation6: " + pictures[5].transform.eulerAngles.z);
        Debug.Log("rotation7: " + pictures[6].transform.eulerAngles.z);
        Debug.Log("rotation8: " + pictures[7].transform.eulerAngles.z);
        Debug.Log("rotation9: " + pictures[8].transform.eulerAngles.z);
        if ((pictures[0].transform.eulerAngles.z > -1 && pictures[0].transform.eulerAngles.z < 1) &&
            (pictures[1].transform.eulerAngles.z > -1 && pictures[1].transform.eulerAngles.z < 1) &&
            (pictures[2].transform.eulerAngles.z > -1 && pictures[2].transform.eulerAngles.z < 1) &&
            (pictures[3].transform.eulerAngles.z > -1 && pictures[3].transform.eulerAngles.z < 1) &&
            (pictures[4].transform.eulerAngles.z > -1 && pictures[4].transform.eulerAngles.z < 1) &&
            (pictures[5].transform.eulerAngles.z > -1 && pictures[5].transform.eulerAngles.z < 1) &&
            (pictures[6].transform.eulerAngles.z > -1 && pictures[6].transform.eulerAngles.z < 1) &&
            (pictures[7].transform.eulerAngles.z > -1 && pictures[7].transform.eulerAngles.z < 1) &&
            (pictures[8].transform.eulerAngles.z > -1 && pictures[8].transform.eulerAngles.z < 1))
        {
            youWin = true;
            
            Debug.Log("You won");
            exit.SetActive(true);
        }
    }
    void rotate(int i)
    {
        Debug.Log("image clicked");
        
        pictures[i].Rotate(0f, 0f, 90f);
        
    }
}
