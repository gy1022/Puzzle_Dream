using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CanvasCloser : MonoBehaviour
{
    public GameObject canvasToClose;

    public void CloseCanvas()
    {
        if (canvasToClose != null)
            canvasToClose.SetActive(false);
    }
}
