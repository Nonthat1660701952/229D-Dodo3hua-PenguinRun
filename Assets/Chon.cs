using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneTrigger2D : MonoBehaviour
{
    public string sceneName; // ชื่อของซีนที่ต้องการโหลด

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player")) // ตรวจสอบว่าชนกับ Player หรือไม่
        {
            SceneManager.LoadScene(2); // โหลดซีนตามชื่อที่กำหนด
        }
    }
}
