using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PuzzleGame : MonoBehaviour
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
    // Start is called before the first frame update
    void Start()
    {

        /*for (int i = 0; i < 8; i++)
        {
            int rnd = Random.Range(0, 3);
            Debug.Log("random num: " + rnd);
            int z = 90 * rnd;
            pictures[i].Rotate(0f, 0f, z);
        }*/
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
        if (pictures[0].transform.eulerAngles.z == 0 &&
            pictures[1].transform.eulerAngles.z == 0 &&
            pictures[2].transform.eulerAngles.z == 0 &&
            pictures[3].transform.eulerAngles.z == 0 &&
            pictures[4].transform.eulerAngles.z == 0 &&
            pictures[5].transform.eulerAngles.z == 0 &&
            pictures[6].transform.eulerAngles.z == 0 &&
            pictures[7].transform.eulerAngles.z == 0 &&
            pictures[8].transform.eulerAngles.z == 0)
        {
            youWin = true;
            Debug.Log("You won");
            exit.SetActive(true);
        }
    }
    void rotate(int i)
    {
        Debug.Log("image clicked");
        if (!youWin)
        {
            pictures[i].Rotate(0f, 0f, 90);
        }
    }

}
