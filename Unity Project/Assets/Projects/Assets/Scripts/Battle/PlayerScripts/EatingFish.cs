using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class EatingFish : MonoBehaviour {


	static EatingFish eatingFish;
	public GameObject instance;
	public Transform button;
	public Image fish1;
	public float coolDown = 10f;
	public float coolingDown;
	public bool Delay;


	void Awake ()
	{
		eatingFish = this;
		eatingFish.instance.SetActive (false);
	}



	// Use this for initialization
	void Start () 
	{
		coolingDown = coolDown;
	
	}
	
	// Update is called once per frame
	void Update () 
	{

		if (Materials.materials.fish1 < 1) 
		{
		
		}

		if (Delay) {
			coolingDown -= 1 * Time.deltaTime;
		}

		if (coolingDown >= coolDown) 
		{
			coolingDown = coolDown;
		}
		if (coolingDown < 0) 
		{
			coolingDown = coolDown;
		}

		if (Materials.materials.fish1 == 0)
		{
			fish1.fillAmount = 0;
		}
		else fish1.fillAmount = coolingDown / coolDown;
		if (Delay) 
		{
			PlayerHealth.currentHealth += 1 * Time.deltaTime;
		}

	}


	public static void ShowFish1()
	{
		eatingFish.instance.SetActive(true);
	}

	public static void HideFish1 ()
	{
		eatingFish.instance.SetActive(false);
	}
	

	public void EatFish1 ()
	{
		if (Delay == false)	
		{
			if (Materials.materials.fish1 >= 1)
			{

			coolingDown = 0;
			
			StartCoroutine (ClickDelay ());
			Debug.Log ("Cooldown Begin");
			}
		}
	}


			







	public IEnumerator ClickDelay()//This is delay to prevent clicking faster than playerAttackSpeed
	{
		Delay = true;
		button.GetComponent<Button>().interactable = false;
		yield return new WaitForSeconds(coolDown);
		Delay = false;
		Materials.materials.fish1 -= 1;
		button.GetComponent<Button>().interactable = true;
	}












}
