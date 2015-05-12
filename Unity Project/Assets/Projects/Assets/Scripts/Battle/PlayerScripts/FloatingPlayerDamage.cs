using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class FloatingPlayerDamage : MonoBehaviour {
	
		public Text myGUItext;
		private float guiTime = 1f;
		
		
		
		
		
		
		
		void Start ()
		{
			animation.Play ("FloatingPlayerDamageAnim");
			
		}
		
		void Update ()
		{
			
			transform.Translate(0, 1, Time.deltaTime);
			transform.Translate(0, Time.deltaTime, 1, Space.World);
			
	
			Color myColor = myGUItext.color;
			myColor.a -= Time.deltaTime / 2;
			myGUItext.color = myColor;


		}
		
		
		
		public void DisplayDamage(string damageMessage)
		{
		if (GameInformation.isWarriorClass && HardHitSkill.hitChance) 
		{
			if (CriticalDamage.critChance1 )
			{
				myGUItext.text = "Critical Hard Hit!" + "\n" + damageMessage;
				myGUItext.color = Color.magenta;
			}
			else{
			myGUItext.text = "Hard Hit!" + "\n" + damageMessage;
			myGUItext.color = Color.white;
			}
		}
		else if (CriticalDamage.critChance1 ) 
			{
			myGUItext.text = "Critical!" + "\n" + damageMessage;
			myGUItext.color = Color.yellow;
		}

			else 
		{
			myGUItext.text = damageMessage;
			myGUItext.color = Color.red;
		}


			
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
