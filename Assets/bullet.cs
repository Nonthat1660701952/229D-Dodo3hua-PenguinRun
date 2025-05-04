using UnityEngine;

public class Bullet : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D other)
    {
        // แสดงชื่อวัตถุที่โดนกระสุน
        Debug.Log("Hit: " + other.name);

        // ตรวจสอบว่าเป็น Enemy หรือไม่
        if (other.CompareTag("Enemy"))
        {
            Debug.Log("Enemy hit! Destroying.");

            // ลบศัตรูและกระสุน
            Destroy(other.gameObject);
            Destroy(gameObject);
        }
    }
}
