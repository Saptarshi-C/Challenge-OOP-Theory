using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public abstract class Shapes : MonoBehaviour
{
    [SerializeField]
    protected TextMeshProUGUI shapeText;

    protected void OnMouseDown()
    {
        ShapeSay();
    }

    protected abstract void ShapeSay();
}
