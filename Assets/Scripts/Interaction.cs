using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Interaction : MonoBehaviour
{
    [SerializeField] private Camera _camera;

    private void Update()
    {
        Ray ray = _camera.ScreenPointToRay(Input.mousePosition);
        if (Physics.Raycast(ray, out RaycastHit hit))
        {
            if (hit.collider.TryGetComponent(out ClickableCollider clickableCollider))
            {
                if (Input.GetMouseButtonDown(0) && !EventSystem.current.IsPointerOverGameObject())
                {
                    clickableCollider.Click();
                }
            }

            if (hit.collider.TryGetComponent(out Gold gold) && !EventSystem.current.IsPointerOverGameObject())
            {
                gold.Hover();
            }
        }
    }
}
