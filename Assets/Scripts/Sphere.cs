using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sphere : Shapes
{
    protected override void ShapeSay()
    {
        shapeText.text = "I am a Sphere.";
    }
}
