using UnityEngine;
using System.Collections;

public class Paddle : MonoBehaviour {

	void Update () {
        // Initial paddle position
        Vector3 paddlePos = new Vector3(0.5f, this.transform.position.y, 0f);
        // Get the X position from mouse input
        float mousePosInBlocks = Input.mousePosition.x / Screen.width * 16;
        // Set minimum and max width
        paddlePos.x = Mathf.Clamp(mousePosInBlocks, 0.5f, 15.5f);
        // Move paddle depends on position
        this.transform.position = paddlePos; 
	}
}
