using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class Helper
{
    public static Vector2 mousePosition()
    {
        Vector3 mousePos = Input.mousePosition;

        Vector3 point = Camera.main.ScreenToWorldPoint(mousePos);
        var positionMouse2D = (Vector2)point;

        return positionMouse2D;
    }
}