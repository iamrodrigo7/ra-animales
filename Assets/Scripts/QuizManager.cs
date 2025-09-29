using UnityEngine;
using System;

public class QuizManager : MonoBehaviour
{
    [Header("Nombre EXACTO del target correcto")]
    public string correctTargetName = "BearTarget";

    // Lo llamará el ImageTarget cuando se detecte
    public void CheckAnswer(string detectedTargetName)
    {
        bool ok = string.Equals(detectedTargetName, correctTargetName, StringComparison.OrdinalIgnoreCase);
        if (ok)
            Debug.Log("? ¡Correcto! Detectaste el target: " + detectedTargetName);
        else
            Debug.Log("? Incorrecto. Detectaste: " + detectedTargetName + " (correcto: " + correctTargetName + ")");
    }
}
