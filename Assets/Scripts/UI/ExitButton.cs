using UnityEngine;

public class ExitButton : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public void ExitGame()
    {
        Debug.Log("ExitGame called");

#if UNITY_EDITOR
        // Для выхода в редакторе
        UnityEditor.EditorApplication.isPlaying = false;
#else
        // Для выхода в сборке
        Application.Quit();
#endif
    }
}
