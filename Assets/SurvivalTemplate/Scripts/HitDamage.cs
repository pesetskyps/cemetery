using UnityEngine;
using System.Collections;

[RequireComponent(typeof(Stats))]
public class HitDamage : MonoBehaviour, IHittable {
	Stats stats;
	public AudioClip DeathClip;
	// Use this for initialization
	void Start () {
		stats = GetComponent<Stats> ();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void Hit(){
		stats.Health -= 10;
		if (stats.Health <= 0) {
			Destroy(gameObject,2);
			audio.PlayOneShot(DeathClip);
		}

	}
}
