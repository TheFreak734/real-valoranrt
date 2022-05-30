using UnityEngine;
// This complete script can be attached to a camera to make it
// continuously point at another object.

public class follow : MonoBehaviour
{
    public float m_Speed = 5;
    public Transform m_Target;

    public float maxYRot;
    public float minYRot;


    void Update()
    {
        var targetRotation = Quaternion.LookRotation(m_Target.transform.position - transform.position);

        // Smoothly rotate towards the target point.
        transform.rotation = Quaternion.Slerp(transform.rotation, targetRotation, m_Speed * Time.deltaTime);

        LimitRot();
    }

    private void LimitRot()
    {
        Vector3 playerEulerAngles = transform.rotation.eulerAngles;

        playerEulerAngles.y = (playerEulerAngles.y > 180) ? playerEulerAngles.y - 360 : playerEulerAngles.y;
        playerEulerAngles.y = Mathf.Clamp(playerEulerAngles.y, minYRot, maxYRot);

        transform.rotation = Quaternion.Euler(playerEulerAngles);
    }

    
}