using UnityEngine;
using UnityEngine.SceneManagement;

public class ReturnToMainMenu : MonoBehaviour
{
    public string mainMenuSceneName = "MainMenu"; // ตั้งชื่อซีน Main Menu ไว้ที่นี่

    void Update()
    {
        // กดปุ่มอะไรก็ได้เพื่อกลับเมนู เช่น Space หรือคลิกเมาส์
        if (Input.GetKeyDown(KeyCode.Space) || Input.GetMouseButtonDown(0))
        {
            SceneManager.LoadScene(mainMenuSceneName);
        }
    }
}
