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
        animator = GetComponent<Animator>(); // Animator 컴포넌트 참조 얻기
        StartCoroutine(BlendAnimation());
    }

    IEnumerator BlendAnimation()
    {
        float elapsedTime = 0.0f; // 경과 시간

        while (elapsedTime < duration)
        {
            elapsedTime += Time.deltaTime;
            float blendValue = elapsedTime / duration;

            animator.SetFloat("Blend", blendValue); // 'Blend' 변수의 값을 변경

            yield return null;
        }
    }

}
