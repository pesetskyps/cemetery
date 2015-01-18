using UnityEngine;
using System.Collections;

public class MoveAnimation : MonoBehaviour {
    public CharacterMotor motor;
	public float BaseAnimationSpeed = 0.5f;
	public float AnimationspeedModifier = 0.25f;
	Animator anim;

	// Use this for initialization
	void Start () {
        anim = GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {
		//http://answers.unity3d.com/questions/367876/mecanim-changing-animation-clip-speed-through-scri.html
		anim.speed = motor.movement.velocity.magnitude * AnimationspeedModifier + BaseAnimationSpeed;

	}
}
