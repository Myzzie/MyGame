using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class MenuFade : MonoBehaviour {

	public Image fade;
	public Text fadeText;
	public bool fadeOutBlack;
	public bool fadeOutText1;
	private Color fadeOutBlack1;
	private bool fadeInText1;

	private bool newGame;

	// Use this for initialization
	void Start () 
	{
		StartCoroutine (FadeInText());
		StartCoroutine (FadeIn());
		StartCoroutine (Destroy());
		StartCoroutine (FadeOutBlack3());
	
	}
	
	// Update is called once per frame
	void Update () 
	{

		if (fadeInText1)
		{
			Color fadeInText = fadeText.color;
			fadeInText.a += Time.deltaTime / 4;
			fadeText.color = fadeInText;
		}

		if (fadeOutText1)
		{
			Color fadeOutText = fadeText.color;
			fadeOutText.a -= Time.deltaTime / 2.5f;
			fadeText.color = fadeOutText;
		}

		if (fadeOutBlack)
		{
		fadeOutBlack1 = fade.color;
		fadeOutBlack1.a -= Time.deltaTime / 5;
		fade.color = fadeOutBlack1;
		}

		if (Input.GetMouseButtonDown(0))
		{
			CreateNewCharacter.newGame = (PlayerPrefs.GetInt("NewGame") != 0);
			if (CreateNewCharacter.newGame)
			{
				Application.LoadLevel (1);

			}
			else Destroy(gameObject);

		}
	}

	IEnumerator FadeInText()
	{
		
		yield return new WaitForSeconds(1);
		fadeInText1 = true;
		
	}

	IEnumerator FadeIn()
	{

		yield return new WaitForSeconds(3);
		fadeOutText1 = true;


	}
	IEnumerator FadeOutBlack3()
	{
		
		yield return new WaitForSeconds(5);
		fadeOutBlack = true;
		CreateNewCharacter.newGame = (PlayerPrefs.GetInt("NewGame") != 0);
		if (CreateNewCharacter.newGame)
		{
			Application.LoadLevel (1);
		}

	
	}

	IEnumerator Destroy()
	{
		
		yield return new WaitForSeconds(10);

		Destroy(gameObject);
	}

	

}
