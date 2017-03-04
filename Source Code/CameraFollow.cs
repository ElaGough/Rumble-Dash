using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour {

    /*public GameObject buddy;

    private Vector3 offset;

	// Use this for initialization
	void Start () {
        offset = transform.position - buddy.transform.position;
	}
	
	// Update is called once per frame
	void LateUpdate () {
        transform.position = buddy.transform.position + offset;
	}*/

    public Transform player1, player2;
    public float minSizeY;
    public float maxSizeY;

    void SetCameraPos()
    {
        Vector3 middle = (player1.position + player2.position) * 0.5f;

        GetComponent<Camera>().transform.position = new Vector3(
            middle.x,
            middle.y,
            GetComponent<Camera>().transform.position.z
        );
    }

    void SetCameraSize()
    {
        //horizontal size is based on actual screen ratio
        float minSizeX = minSizeY * Screen.width / Screen.height;
        float maxSizeX = maxSizeY * Screen.width / Screen.height;

        //multiplying by 0.5, because the ortographicSize is actually half the height
        float width = Mathf.Abs(player1.position.x - player2.position.x) * 0.55f;
        float height = Mathf.Abs(player1.position.y - player2.position.y) * 0.55f;

        //computing the size
        float camSizeX = Mathf.Max(width, minSizeX);
        GetComponent<Camera>().orthographicSize = Mathf.Max(height,
            camSizeX * Screen.height / Screen.width, minSizeY);

        camSizeX = Mathf.Max(width, minSizeX);
        GetComponent<Camera>().orthographicSize = Mathf.Clamp(Mathf.Max(height, 
            camSizeX * Screen.height / Screen.width, minSizeY), minSizeY, maxSizeY);
    }

    void Update()
    {
        SetCameraPos();
        SetCameraSize();
    }
}
