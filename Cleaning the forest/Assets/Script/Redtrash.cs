using UnityEngine;

public class Redtrash : MonoBehaviour
{
    public int scoreValue = 10;  // �����⿡ �ο��� ����

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Red"))
        {
            // �浹�� ������Ʈ�� ����� ������Ʈ�� ��쿡�� ������ ������ŵ�ϴ�.
            GameManager.Instance.AddScore(scoreValue);

            // �浹�� ������ ������Ʈ�� �����մϴ�.
            Destroy(gameObject);
        }
    }
}