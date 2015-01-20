using UnityEngine;
using System.Collections;

public class ActivateHittables : MonoBehaviour {

    public static void HitAll(GameObject gameobj)
    {
        var hitables = gameobj.GetComponents(typeof(IHittable));
        if (hitables == null)
            return;
        foreach (IHittable hittable in hitables)
        {
            hittable.Hit();
        }
    }
}
