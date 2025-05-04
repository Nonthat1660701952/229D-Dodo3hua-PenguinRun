using UnityEngine;

public class Bullet : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D other)
    {
        // �ʴ������ѵ�ط��ⴹ����ع
        Debug.Log("Hit: " + other.name);

        // ��Ǩ�ͺ����� Enemy �������
        if (other.CompareTag("Enemy"))
        {
            Debug.Log("Enemy hit! Destroying.");

            // ź�ѵ����С���ع
            Destroy(other.gameObject);
            Destroy(gameObject);
        }
    }
}
