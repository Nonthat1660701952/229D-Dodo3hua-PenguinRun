using UnityEngine;
using UnityEngine.SceneManagement;

public class ReturnToMainMenu : MonoBehaviour
{
    public string mainMenuSceneName = "MainMenu"; // ��駪��ͫչ Main Menu �������

    void Update()
    {
        // ���������á������͡�Ѻ���� �� Space ���ͤ�ԡ�����
        if (Input.GetKeyDown(KeyCode.Space) || Input.GetMouseButtonDown(0))
        {
            SceneManager.LoadScene(mainMenuSceneName);
        }
    }
}
