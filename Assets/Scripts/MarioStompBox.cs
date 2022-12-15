using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MarioStompBox : MonoBehaviour 
{
	private LevelManager t_LevelManager;

	void Start () 
	{
		t_LevelManager = FindObjectOfType<LevelManager> ();
	}

	void OnTriggerEnter2D(Collider2D other) 
	{
		if (other.gameObject.tag.Contains("Enemy") && other.gameObject.tag != "Enemy/Piranha" && other.gameObject.tag != "Enemy/Bowser") 
		{
			Enemy enemy = other.gameObject.GetComponent<Enemy> ();
			t_LevelManager.MarioStompEnemy (enemy);
		}
	}
}
