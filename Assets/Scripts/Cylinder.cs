using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cylinder : Shapes
{
    protected override void ShapeSay()
    {
        shapeText.text = "I am a Cylinder.";
    }
}
