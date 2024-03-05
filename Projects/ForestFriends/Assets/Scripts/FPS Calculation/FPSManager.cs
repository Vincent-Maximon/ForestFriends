using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class FPSManager : MonoBehaviour
{
    private int lastFrameIndex;
    private float[] frameDeltaTimeArrray;

    public TextMeshProUGUI FPSText;

    void Awake()
    {
        frameDeltaTimeArrray = new float[60];
    }

    void Update()
    {
        DisplayFPS();
    }

    void DisplayFPS()
    {
        frameDeltaTimeArrray[lastFrameIndex] = Time.deltaTime;
        lastFrameIndex = (lastFrameIndex + 1) % frameDeltaTimeArrray.Length;

        FPSText.text = Mathf.RoundToInt(CalculateFPS()).ToString() + " FPS";
    }

    private float CalculateFPS()
    {
        float total = 0;

        foreach (float deltaTime in frameDeltaTimeArrray)
        {
            total += deltaTime;
        }

        return frameDeltaTimeArrray.Length / total;
    }
}
