using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChanger : MonoBehaviour
{
    public string sceneName;

    public void ChangeScene(string sceneName)
    {
        Debug.Log("ChangeScene called with scene: " + sceneName);
        SceneManager.LoadScene(sceneName);
    }

}
