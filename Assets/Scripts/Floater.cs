using UnityEngine;

public class Floater : MonoBehaviour
{
    public Rigidbody rb; // 물체에 적용될 리지드바디 컴포넌트를 참조하기 위한 변수
    public float depthBeforeSubmerged = 1f; // 물체가 완전히 잠기기 전까지의 깊이
    public float displacementAmount = 3f; // 물리적으로 잠긴 정도에 따라 적용될 부력의 양

    private void FixedUpdate()
    {
        if (transform.position.y < 0f)
        {
            // 물체의 y 위치가 0보다 작을 때, 즉 물에 잠겼을 때만 부력을 계산한다.
            float displacementMultiplier = Mathf.Clamp01(-transform.position.y / depthBeforeSubmerged) * displacementAmount;
            // 부력을 계산하여 리지드바디에 힘을 가한다.
            rb.AddForce(new Vector3(0f, Mathf.Abs(Physics.gravity.y) * displacementMultiplier, 0f), ForceMode.Acceleration);
        }
    }
}
