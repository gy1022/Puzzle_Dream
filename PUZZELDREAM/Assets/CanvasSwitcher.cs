using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CanvasSwitcher : MonoBehaviour
{
    public GameObject canvasToEnable;

    public void EnableCanvasOnly()
    {
        if (canvasToEnable != null)
            canvasToEnable.SetActive(true);
    }
    public void ToggleCanvas()
    {
        if (canvasToEnable != null)
            canvasToEnable.SetActive(!canvasToEnable.activeSelf);
    }
}
