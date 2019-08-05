using UnityEngine;

public class weaponScript : MonoBehaviour
{

    public Transform shotPrefab;
    void Start()
    {
        PlayerPrefs.SetInt("score", 0);
    }


    void Update()
    {

        /*if (Input.touchCount > 0) {
			var shotTransform = Instantiate(shotPrefab) as Transform;
			
			shotTransform.position = transform.position;
	}*/


        bool shoot = Input.GetButtonDown("Fire1");
        if (shoot)
        {
            var shotTransform = Instantiate(shotPrefab) as Transform;

            shotTransform.position = transform.position + new Vector3(2, 0, 0);
        }


    }


}