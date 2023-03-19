using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gold : MonoBehaviour
{
    [SerializeField] private HitEffect HitEffectPrefab;
    public Resources Resources;
    public void Hover()
    {
        Resources.CollectCoins(1, transform.position);
        HitEffect hitEffect = Instantiate(HitEffectPrefab, transform.position, Quaternion.identity);
        hitEffect.Init(1);
        Destroy(gameObject);
    }
}
