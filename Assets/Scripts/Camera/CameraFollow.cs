using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform player;

    public float minXClamp = -33.3f;
    public float maxXClamp = 51.2f;

    public float minYClamp = -12.58f;
    public float maxYClamp = 10.92f;

    //this function always runs after fixed update - unity specifies this is where camera movement should happen
    private void LateUpdate()
    {
        Vector3 cameraPos = transform.position;

        cameraPos.x = Mathf.Clamp(player.transform.position.x, minXClamp, maxXClamp);
        cameraPos.y = Mathf.Clamp(player.transform.position.y, minYClamp, maxYClamp);

        transform.position = cameraPos;
    }
}