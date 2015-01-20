using UnityEngine;
using System.Collections;
using System;

[RequireComponent(typeof(Stats))]
public class HitDamage : MonoBehaviour, IHittable {

    public Action hasDied;

    Stats stats;
    bool isDied = false;
    IKillable killable;
	// Use this for initialization
	void Start () {
		stats = GetComponent<Stats> ();
        killable = (IKillable) GetComponent(typeof(IKillable));
        if (killable == null)
            throw new MissingComponentException("Cannot find Ikillable");
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void Hit(){
		stats.Health -= 10;
		if (stats.Health <= 0) {
            killable.Kill();


            if (hasDied != null && !isDied)
                hasDied();
            isDied = true;
		}

	}
}
