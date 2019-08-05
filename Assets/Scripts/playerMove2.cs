using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMove2 : MonoBehaviour
{

    public Vector2 speed = new Vector2(50, 50);
    //private bool isandroid
    private Vector2 movement;
    private float inputX;
    private float inputY;
    public GameObject menuContainer;
    public GameObject enemyGen;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        inputX = Input.GetAxis("Horizontal");
        inputY = Input.GetAxis("Vertical");

        movement = new Vector2(
            speed.x * inputX,
            speed.y * inputY);

        var dist = (transform.position - Camera.main.transform.position).z;
        var leftBorder = Camera.main.ViewportToWorldPoint(
            new Vector3(0, 0, dist)
            ).x;

        var rightBorder = Camera.main.ViewportToWorldPoint(
            new Vector3(1, 0, dist)
            ).x;

        var topBorder = Camera.main.ViewportToWorldPoint(
            new Vector3(0, 0, dist)
            ).y;

        var bottomBorder = Camera.main.ViewportToWorldPoint(
            new Vector3(0, 1, dist)
            ).y;

        transform.position = new Vector3(
            Mathf.Clamp(transform.position.x, leftBorder, rightBorder),
            Mathf.Clamp(transform.position.y, topBorder, bottomBorder),
            transform.position.z
            );
    }

    void FixedUpdate()
    {
        GetComponent<Rigidbody2D>().velocity = movement;
    }

    void OnTriggerEnter2D(Collider2D otherCollider)
    {
        enemyScript hit = otherCollider.gameObject.GetComponent<enemyScript>();
        if (hit != null)
        {
            Destroy(enemyGen);
            Destroy(hit.gameObject);
            Destroy(gameObject);
            menuContainer.SetActive(true);
        }


    }
}
