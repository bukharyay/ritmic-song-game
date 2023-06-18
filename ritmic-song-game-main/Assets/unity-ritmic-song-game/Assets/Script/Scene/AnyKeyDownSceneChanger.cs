using UnityEngine;
using UnityEditor.SceneManagement;

public class AnyKeyDownSceneChanger : MonoBehaviour
{
    public string nextSceneName;

    private void Update()
    {
        if (Input.anyKeyDown)
        {
            UnityEditor.SceneManagement.EditorSceneManager.LoadScene(nextSceneName);
        }
    }
}
