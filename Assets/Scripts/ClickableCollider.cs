using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickableCollider : MonoBehaviour
{
    [SerializeField] private Clickable _clickable;

    public void Click()
    {
        _clickable.Hit();
    }
}
