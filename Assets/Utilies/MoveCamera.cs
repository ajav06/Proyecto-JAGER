using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCamera : MonoBehaviour
{
    Vector2 touchDeltaPosition;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            float pointer_y = Input.GetAxis("Mouse X");
            Vector3 pos = new Vector3(0, pointer_y, 0);
            transform.RotateAround(transform.parent.position, pos, 30 * Time.deltaTime);
        }

        if (Input.touchCount == 1)
        {
            Touch touchZero = Input.GetTouch(0);
            if (touchZero.phase == TouchPhase.Moved)
            {
                touchDeltaPosition = Input.GetTouch(0).deltaPosition;
                float y = gameObject.transform.position.y + touchDeltaPosition.x;
                Vector3 pos = new Vector3(0, y, 0);
                gameObject.transform.RotateAround(transform.parent.position, pos, 30 * Time.deltaTime);
            }
        }
    }
}
