using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlashLightController : MonoBehaviour
{
	public bool isOn = true;
	public GameObject lightSource;
	public AudioSource onSound;
	public AudioSource offSound;
    public bool failSafe = false;
    // Update is called once per frame
    void Update()
    {
		if(Input.GetButtonDown("FKey"))
		{
			if(isOn == false && failSafe == false)
			{
				failSafe = true;
				lightSource.SetActive(true);
				onSound.Play();
				isOn = true;
				StartCoroutine(FailSafe());
			} 
			if(isOn == true && failSafe == false){
				failSafe = true;
				lightSource.SetActive(false);
				offSound.Play();
				isOn = false;
				StartCoroutine(FailSafe());
			}
		}
    }
	IEnumerator FailSafe()
	{
		yield return new WaitForSeconds(0.25f);
		failSafe = false;
	}
}
