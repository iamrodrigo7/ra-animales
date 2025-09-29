using UnityEngine;

public class TargetAnswer : MonoBehaviour
{
    [Header("Configura el nombre y el QuizManager")]
    public string targetName;              // Aqu� pondr�s "bear"
    public QuizManager quizManager;        // Aqu� arrastrar�s el objeto QuizManager

    public void OnTargetFound()
    {
        Debug.Log("Target detectado: " + targetName);

        if (quizManager != null)
        {
            quizManager.CheckAnswer(targetName);
        }
        else
        {
            Debug.LogWarning("QuizManager no est� asignado en " + gameObject.name);
        }
    }
}
