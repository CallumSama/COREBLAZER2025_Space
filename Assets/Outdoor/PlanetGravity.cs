using UnityEngine;

public class PlanetGravity : MonoBehaviour
{
    public float gravityForce = 9.8f; // ����ǿ��
    public float orbitRadius = 1f;   // ����ж��뾶

    public bool isActiveGravity = true;


    private void OnTriggerStay2D(Collider2D other)
    {
        if (other.CompareTag("Spaceship"))
        {
            SpaceshipController ship = other.GetComponent<SpaceshipController>();
            if (ship.GetCurrentPlanet() == this)
            { // ֻ�е�ǰ����������Ч
              // ʩ�������Ĵ���
                Rigidbody2D rb = other.GetComponent<Rigidbody2D>();
                Vector2 direction = (transform.position - other.transform.position).normalized;
                rb.AddForce(direction * gravityForce * Time.deltaTime);
            }
        }
    }
}