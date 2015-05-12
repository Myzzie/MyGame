using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class FloatingMonsterDamage : MonoBehaviour
{
	public Text myGUItext;
	private float guiTime = 1f;



	


		
	void Start ()
	{
		animation.Play ("FloatingMonsterDamageAnim");
	}

	void Update ()
	{
		


		Color myColor = myGUItext.color;
		myColor.a -= Time.deltaTime / guiTime;
		myGUItext.color = myColor;

	}


	
	public void DisplayDamage(string damageMessage)
	{

			myGUItext.text = damageMessage;

		
		// destory after time is up
		StartCoroutine(GuiDisplayTimer());
	}
	
	IEnumerator GuiDisplayTimer()
	{
		// Waits an amount of time
		yield return new WaitForSeconds(guiTime);
		
		// destory game object
		Destroy(gameObject);
	}
	
}

