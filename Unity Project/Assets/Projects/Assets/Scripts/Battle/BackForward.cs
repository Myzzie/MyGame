using UnityEngine;
using System.Collections;

public class BackForward : MonoBehaviour {

	public EnemySpawner enemySpawner;
	public GameObject back;
	public GameObject forward;
	public GameObject startBattle;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	

		

		if (enemySpawner.count == 0) 
		{
			back.SetActive(false);
			forward.SetActive(false);
			startBattle.SetActive(true);
		}
	
		if (enemySpawner.count >= 1) 
		{
			back.SetActive(true);
			forward.SetActive(true);
			startBattle.SetActive(false);
		}
		if (enemySpawner.count == 1)
		{
			if (Monster1.enemyDeathCount > 0)
			{
				forward.SetActive(true);
			}
			else 	forward.SetActive(false);
		}
		if (enemySpawner.count == 2)
		{
			if (Monster2.enemyDeathCount > 0)
			{
				forward.SetActive(true);
			}
			else 	forward.SetActive(false);
		}
		if (enemySpawner.count == 3)
		{
			if (Monster3.enemyDeathCount > 0)
			{
				forward.SetActive(true);
			}
			else 	forward.SetActive(false);
		}
		if (enemySpawner.count == 4)
		{
			if (Monster4.enemyDeathCount > 0)
			{
				forward.SetActive(true);
			}
			else 	forward.SetActive(false);
		}
		if (enemySpawner.count == 5)
		{
			if (Monster5.enemyDeathCount > 0)
			{
				forward.SetActive(true);
			}
			else 	forward.SetActive(false);
		}
		if (enemySpawner.count == 6)
		{
			if (Monster6.enemyDeathCount > 0)
			{
				forward.SetActive(true);
			}
			else 	forward.SetActive(false);
		}
		if (enemySpawner.count == 7)
		{
			if (Monster7.enemyDeathCount > 0)
			{
				forward.SetActive(true);
			}
			else 	forward.SetActive(false);
		}
		if (enemySpawner.count == 8)
		{
			if (Monster8.enemyDeathCount > 0)
			{
				forward.SetActive(true);
			}
			else 	forward.SetActive(false);
		}
		if (enemySpawner.count == 9)
		{
			if (Monster9.enemyDeathCount > 0)
			{
				forward.SetActive(true);
			}
			else 	forward.SetActive(false);
		}
		//Last boss will not activate the forward button


	}


	public void Back ()
	{
		enemySpawner.count --;
		enemySpawner.Spawn ();
	}

	public void Forward ()
	{
	
		enemySpawner.count ++;
		enemySpawner.Spawn ();
		
	}
	public void StartBattle()
	{
		enemySpawner.count ++;
		enemySpawner.Spawn ();
	}



}
