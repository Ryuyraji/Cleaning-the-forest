using UnityEngine;

public class Bluetrash : MonoBehaviour
{
    public int scoreValue = 10;  // 쓰레기에 부여할 점수
    public AudioClip dingSound;  // 띵동 소리 클립
    private AudioSource audioSource;

    private void Awake()
    {
        // AudioSource 컴포넌트를 가져옵니다.
        audioSource = GetComponent<AudioSource>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Blue"))
        {
            // 충돌한 오브젝트가 파란색 오브젝트인 경우에만 점수를 증가시킵니다.
            GameManager.Instance.AddScore(scoreValue);

            // 충돌한 쓰레기 오브젝트를 삭제합니다.
            Destroy(gameObject);

            // 띵동 소리를 재생합니다.
            PlayDingSound();
        }
    }

    private void PlayDingSound()
    {
        // AudioSource를 통해 띵동 소리를 재생합니다.
        audioSource.PlayOneShot(dingSound);
    }
}
