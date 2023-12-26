using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimController : MonoBehaviour
{
    // Start is called before the first frame update
    Animator animator;
    [SerializeField] float duration;
    void Start()
    {
        animator = GetComponent<Animator>(); // Animator ������Ʈ ���� ���
        StartCoroutine(BlendAnimation());
    }

    IEnumerator BlendAnimation()
    {
        float elapsedTime = 0.0f; // ��� �ð�

        while (elapsedTime < duration)
        {
            elapsedTime += Time.deltaTime;
            float blendValue = elapsedTime / duration;

            animator.SetFloat("Blend", blendValue); // 'Blend' ������ ���� ����

            yield return null;
        }
    }

}
