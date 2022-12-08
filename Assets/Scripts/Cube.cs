using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : Shapes
{
    protected override void ShapeSay()
    {
        shapeText.text = "I am a Cube.";
    }
}
