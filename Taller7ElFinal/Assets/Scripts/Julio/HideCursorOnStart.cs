using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HideCursor : MonoBehaviour
{
    public bool hideCursor;
    void Update()
    {
        if (hideCursor)
            Cursor.visible = false;
    }
}
