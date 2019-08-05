using UnityEngine;

public class enemyScript : MonoBehaviour
{
    public Vector2 speed = new Vector2(10, 10);
    public Vector2 direction = new Vector2(-1, 0);

    private Vector2 movement;

    void Update()
    {
        movement = new Vector2(
            speed.x * direction.x,
            speed.y * direction.y);

        if (transform.position.x < Camera.main.transform.position.x - 10)
        {
            Destroy(gameObject);
        }
    }
    //void OnTriggerEnter2D()

    void FixedUpdate()
    {
        GetComponent<Rigidbody2D>().velocity = movement;
    }

}