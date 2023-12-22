using UnityEngine;

public class Floater : MonoBehaviour
{
    public Rigidbody rb; // ��ü�� ����� ������ٵ� ������Ʈ�� �����ϱ� ���� ����
    public float depthBeforeSubmerged = 1f; // ��ü�� ������ ���� �������� ����
    public float displacementAmount = 3f; // ���������� ��� ������ ���� ����� �η��� ��

    private void FixedUpdate()
    {
        if (transform.position.y < 0f)
        {
            // ��ü�� y ��ġ�� 0���� ���� ��, �� ���� ����� ���� �η��� ����Ѵ�.
            float displacementMultiplier = Mathf.Clamp01(-transform.position.y / depthBeforeSubmerged) * displacementAmount;
            // �η��� ����Ͽ� ������ٵ� ���� ���Ѵ�.
            rb.AddForce(new Vector3(0f, Mathf.Abs(Physics.gravity.y) * displacementMultiplier, 0f), ForceMode.Acceleration);
        }
    }
}
