using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneTrigger2D : MonoBehaviour
{
    public string sceneName; // ���ͧ͢�չ����ͧ�����Ŵ

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player")) // ��Ǩ�ͺ��Ҫ��Ѻ Player �������
        {
            SceneManager.LoadScene(2); // ��Ŵ�չ������ͷ���˹�
        }
    }
}
