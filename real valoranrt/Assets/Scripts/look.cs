using UnityEngine;
// This complete script can be attached to a camera to make it
// continuously point at another object.

public class look : MonoBehaviour
{
    public float m_Speed = 5;
    public Transform m_Target;

    void Update()
    {
        var targetRotation = Quaternion.LookRotation(m_Target.transform.position - transform.position);

        // Smoothly rotate towards the target point.
        transform.rotation = Quaternion.Slerp(transform.rotation, targetRotation, m_Speed * Time.deltaTime);
    }
}