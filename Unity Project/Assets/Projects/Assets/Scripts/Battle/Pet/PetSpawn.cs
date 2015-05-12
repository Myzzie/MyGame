using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class PetSpawn : MonoBehaviour {


		
		public Text myGUItext;
		private float guiTime = 10f;
		private float timer = 10f;
		
		
		
		
		
		
		void start ()
		{
			
		}
		
		void Update ()
		{
			
			timer -= Time.deltaTime;
			myGUItext.text = "Respawn" + " / " + "(" + timer.ToString("f0")+ ")";
			

		}
		
		
		public void DisplayDamage()
		{
			
			
			
			// destory after time is up
			StartCoroutine(GuiDisplayTimer());
			
		}
		
		IEnumerator GuiDisplayTimer()
		{

			yield return new WaitForSeconds(guiTime);
			
		if (SpawnPet.pet1Spawn)
		{
			GameObject Respawn = Instantiate (Resources.Load ("Prefabs/Pets/Pet1")) as GameObject;
			Respawn.transform.SetParent ((GameObject.Find ("PetHolder").transform), false);
			Destroy (gameObject);
		}
		if (CaptureMonster.pet11)
		{
			GameObject Respawn = Instantiate (Resources.Load ("Prefabs/Pets/Pet11")) as GameObject;
			Respawn.transform.SetParent ((GameObject.Find ("PetHolder").transform), false);
			Destroy (gameObject);
		}
		if (SpawnPet.pet2Spawn){
			GameObject Respawn = Instantiate (Resources.Load ("Prefabs/Pets/Pet2")) as GameObject;
			Respawn.transform.SetParent ((GameObject.Find ("PetHolder").transform), false);
			Destroy (gameObject);
		}
		if (CaptureMonster.pet12)
		{
			GameObject Respawn = Instantiate (Resources.Load ("Prefabs/Pets/Pet12")) as GameObject;
			Respawn.transform.SetParent ((GameObject.Find ("PetHolder").transform), false);
			Destroy (gameObject);
		}
		if (SpawnPet.pet3Spawn){
			GameObject Respawn = Instantiate (Resources.Load ("Prefabs/Pets/Pet3")) as GameObject;
			Respawn.transform.SetParent ((GameObject.Find ("PetHolder").transform), false);
			Destroy (gameObject);
		}
		if (CaptureMonster.pet13)
		{
			GameObject Respawn = Instantiate (Resources.Load ("Prefabs/Pets/Pet13")) as GameObject;
			Respawn.transform.SetParent ((GameObject.Find ("PetHolder").transform), false);
			Destroy (gameObject);
		}
		if (SpawnPet.pet4Spawn){
			GameObject Respawn = Instantiate (Resources.Load ("Prefabs/Pets/Pet4")) as GameObject;
			Respawn.transform.SetParent ((GameObject.Find ("PetHolder").transform), false);
			Destroy (gameObject);
		}
		if (CaptureMonster.pet14)
		{
			GameObject Respawn = Instantiate (Resources.Load ("Prefabs/Pets/Pet14")) as GameObject;
			Respawn.transform.SetParent ((GameObject.Find ("PetHolder").transform), false);
			Destroy (gameObject);
		}
		if (SpawnPet.pet5Spawn){
			GameObject Respawn = Instantiate (Resources.Load ("Prefabs/Pets/Pet5")) as GameObject;
			Respawn.transform.SetParent ((GameObject.Find ("PetHolder").transform), false);
			Destroy (gameObject);
		}
		if (CaptureMonster.pet15)
		{
			GameObject Respawn = Instantiate (Resources.Load ("Prefabs/Pets/Pet15")) as GameObject;
			Respawn.transform.SetParent ((GameObject.Find ("PetHolder").transform), false);
			Destroy (gameObject);
		}
		if (SpawnPet.pet6Spawn){
			GameObject Respawn = Instantiate (Resources.Load ("Prefabs/Pets/Pet6")) as GameObject;
			Respawn.transform.SetParent ((GameObject.Find ("PetHolder").transform), false);
			Destroy (gameObject);
		}
		if (CaptureMonster.pet16)
		{
			GameObject Respawn = Instantiate (Resources.Load ("Prefabs/Pets/Pet16")) as GameObject;
			Respawn.transform.SetParent ((GameObject.Find ("PetHolder").transform), false);
			Destroy (gameObject);
		}
		if (SpawnPet.pet7Spawn){
			GameObject Respawn = Instantiate (Resources.Load ("Prefabs/Pets/Pet7")) as GameObject;
			Respawn.transform.SetParent ((GameObject.Find ("PetHolder").transform), false);
			Destroy (gameObject);
		}
		if (CaptureMonster.pet17)
		{
			GameObject Respawn = Instantiate (Resources.Load ("Prefabs/Pets/Pet17")) as GameObject;
			Respawn.transform.SetParent ((GameObject.Find ("PetHolder").transform), false);
			Destroy (gameObject);
		}
		if (SpawnPet.pet8Spawn){
			GameObject Respawn = Instantiate (Resources.Load ("Prefabs/Pets/Pet8")) as GameObject;
			Respawn.transform.SetParent ((GameObject.Find ("PetHolder").transform), false);
			Destroy (gameObject);
		}
		if (CaptureMonster.pet18)
		{
			GameObject Respawn = Instantiate (Resources.Load ("Prefabs/Pets/Pet18")) as GameObject;
			Respawn.transform.SetParent ((GameObject.Find ("PetHolder").transform), false);
			Destroy (gameObject);
		}
		if (SpawnPet.pet9Spawn){
			GameObject Respawn = Instantiate (Resources.Load ("Prefabs/Pets/Pet9")) as GameObject;
			Respawn.transform.SetParent ((GameObject.Find ("PetHolder").transform), false);
			Destroy (gameObject);
		}
		if (CaptureMonster.pet19)
		{
			GameObject Respawn = Instantiate (Resources.Load ("Prefabs/Pets/Pet19")) as GameObject;
			Respawn.transform.SetParent ((GameObject.Find ("PetHolder").transform), false);
			Destroy (gameObject);
		}
		if (SpawnPet.pet10Spawn){
			GameObject Respawn = Instantiate (Resources.Load ("Prefabs/Pets/Pet10")) as GameObject;
			Respawn.transform.SetParent ((GameObject.Find ("PetHolder").transform), false);
			Destroy (gameObject);
		}
		if (CaptureMonster.pet20)
		{
			GameObject Respawn = Instantiate (Resources.Load ("Prefabs/Pets/Pet20")) as GameObject;
			Respawn.transform.SetParent ((GameObject.Find ("PetHolder").transform), false);
			Destroy (gameObject);
		}

		}
		
		
		
		
	}
