using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MaterialManager : MonoBehaviour
{

    [SerializeField] private Renderer _renderer;

    public void SetMaterial(Material material)
    {
        _renderer.material = material;
    }
    public void SetMaterialAllModels(Material material)
    {
        Renderer[] renderers = gameObject.GetComponentsInChildren<Renderer>(true);
        foreach (Renderer renderer in renderers)
        {
            renderer.material = material;
        }
    }
}
