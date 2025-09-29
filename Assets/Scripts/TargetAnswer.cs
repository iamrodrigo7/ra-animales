using UnityEngine;

public class TargetAnswer : MonoBehaviour
{
    [Header("Configura el nombre y el QuizManager")]
    public string targetName;              // Aquí pondrás "bear"
    public QuizManager quizManager;        // Aquí arrastrarás el objeto QuizManager

    public void OnTargetFound()
    {
        Debug.Log("Target detectado: " + targetName);

        if (quizManager != null)
        {
            quizManager.CheckAnswer(targetName);
        }
        else
        {
            Debug.LogWarning("QuizManager no está asignado en " + gameObject.name);
        }
    }
}
