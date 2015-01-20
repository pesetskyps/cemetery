using UnityEngine;
using System.Collections;

public class EnemyAttack : MonoBehaviour {
       
    public float AttackRange = 2f;
    public float AttackDelay= 10.0f;
    public AnimationClip AttackAnimation;


    Transform player;
    bool isCharging = false;
    
    void Start()
    {
        player = GameObject.Find("Player").transform;
    }
	// Update is called once per frame
	void Update () {
        if (IsInAttackRange() && !isCharging)
        {            
            StartCoroutine(Attack());
        }
	}

    private bool IsInAttackRange()
    {
        return Vector3.Distance(transform.position, player.position) < AttackRange;
    }

    private IEnumerator Attack()
    {
        if (!IsInAttackRange())
            yield return null;
        this.isCharging = true;
        ActivateHittables.HitAll(player.gameObject);
        animation.CrossFade(AttackAnimation.name);
        yield return new WaitForSeconds(2);
        this.isCharging = false;
    }
}
