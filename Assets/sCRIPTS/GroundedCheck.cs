using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundedCheck : MonoBehaviour
{

    public CharacterControl player;
    public float jumpHeight = 2f;


    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.layer == 8)
        {
            player.isGrounded = true;
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.layer == 8)
        {
            player.isGrounded = false;

            //teleport jump
            player.height = player.transform.position.y + 2;
            player.transform.position = new Vector3(player.transform.position.x, jumpHeight, player.transform.position.z);
        }
    }
}
