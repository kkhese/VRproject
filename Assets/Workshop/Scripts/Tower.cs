using UnityEngine;
using System.Collections;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class Tower : MonoBehaviour
{

	public static Tower Instance;

	// Slider
	public Slider hpSlider;
	public int MAX_HP = 100;
	int hp = 0;
	// Die and Mission Success
	public GameObject die;
	public GameObject succeed;

	void Awake()
	{
		if (Instance == null)
			Instance = this;
	}
	// Start with Max HP
	void Start()
	{
		hp = MAX_HP;
	}
	// If hp becomes less than or equal with 0, the player die
	public void Damage()
	{
		hp = hp - 1;
		hpSlider.value = hp;
		if (hp <= 0)
		{
			if (die)
			{
				die.SetActive(true);
			}
		}
	}
	// Somehow hp drops whenever enemy is spawned
	public void Plus()
	{
		hp++;
	}
	// 'K-pop star' come and collide with right hand, game over
	void OnCollisionEnter(Collision collision)
	{
		if (collision.gameObject.CompareTag("star"))
		{
			succeed.SetActive(true);
		}
	}
}
