using UnityEngine;
using System.Collections;

public class HitParticle : MonoBehaviour, IHittable {

    public ParticleSystem particle;

    public void Hit()
    {
        particle.Play();
    }
}
