using UnityEngine;
using System.Collections;

public class AttackAnimation : MonoBehaviour
{
		Animator anim;
	int AttackHash = Animator.StringToHash("Attack");
		// Use this for initialization
		void Start ()
		{
				anim = GetComponent<Animator> ();
		}
	
		// Update is called once per frame
		void Update ()
		{
				if (Input.GetMouseButton (0)) {
					anim.SetTrigger(AttackHash);
				}
		}
}
