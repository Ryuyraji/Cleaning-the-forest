using UnityEngine;

public class Greentrash : MonoBehaviour
{
    public int scoreValue = 10;  // �����⿡ �ο��� ����

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Green"))
        {
            // �浹�� ������Ʈ�� ����� ������Ʈ�� ��쿡�� ������ ������ŵ�ϴ�.
            GameManager.Instance.AddScore(scoreValue);

            // �浹�� ������ ������Ʈ�� �����մϴ�.
            Destroy(gameObject);
        }
    }
}