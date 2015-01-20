using UnityEngine;
using System.Collections;

public class EnemyKill : MonoBehaviour, IKillable {
    public AudioClip DeathSound;
    public AnimationClip deathAnimation;
    
    AIFollow aifollow;

    void Start()
    {
        aifollow = GetComponent<AIFollow>();
        if (aifollow == null)
            throw new MissingComponentException("Mising AIFollow component");
    }

    public void Kill()
    {
        Destroy(gameObject, 2);
        audio.PlayOneShot(DeathSound);

        animation.CrossFade(deathAnimation.name);
        aifollow.canMove = false;
    }
}
