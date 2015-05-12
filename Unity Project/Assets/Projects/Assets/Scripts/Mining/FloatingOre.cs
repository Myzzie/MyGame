using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class FloatingOre : MonoBehaviour
{
	public Text oreText;
	private float guiTime = 1f;

	
	
	
	
	
	
	
	void Start ()
	{
		animation.Play ("FloatingTextAnim");



	}
	
	
	
	
	
	void Update ()
	{
		
		transform.Translate(0, 1, Time.deltaTime);
		transform.Translate(0, Time.deltaTime, 1, Space.World);

		Color myColor = oreText.color;
		myColor.a -= Time.deltaTime / guiTime;
		oreText.color = myColor;


	}


	
	
	
	public void DisplayOre(string OreMessage)
	{
		
		oreText.text = OreMessage;
		
		// destory after time is up
		StartCoroutine(GuiDisplayTimer());

	}
	
	IEnumerator GuiDisplayTimer()
	{
	
		// Waits an amount of time
		yield return new WaitForSeconds(guiTime);
		
		
		Destroy(gameObject);
	}
	
}

