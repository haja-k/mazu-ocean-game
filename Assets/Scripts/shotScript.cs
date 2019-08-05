using UnityEngine;

public class shotScript : MonoBehaviour
{
    public int score;

    void Start()
    {
        Destroy(gameObject, 5);
    }

    void OnTriggerEnter2D(Collider2D otherCollider)
    {
        enemyScript hit = otherCollider.gameObject.GetComponent<enemyScript>();
        if (hit != null)
        {
            Destroy(hit.gameObject);
            Destroy(gameObject);
            PlayerPrefs.SetInt("score", PlayerPrefs.GetInt("score", 0) + 1);
            if (PlayerPrefs.GetInt("score", 0) > PlayerPrefs.GetInt("hscore", 0))
            {
                PlayerPrefs.SetInt("hscore", PlayerPrefs.GetInt("score", 0));
            }
         
        }

    }

}