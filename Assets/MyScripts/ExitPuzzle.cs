using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExitPuzzle : MonoBehaviour
{
    [SerializeField]
    private Transform[] pictures;
    public GameObject puzzleLayer;
    public GameObject self;
    float[] arr = { 0f, 90f, 180f, 270f };
    public void Update()
    {
        if (Input.GetMouseButtonDown(0)) {
            puzzleLayer.SetActive(false);
            for (int i = 0; i < 8; i++)
            {
                int rnd = UnityEngine.Random.Range(0, 3);

                pictures[i].eulerAngles = new Vector3(0f, 0f, arr[rnd]);

            }
            self.SetActive(false);
        }
    }
}
