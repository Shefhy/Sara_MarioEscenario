using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Grownchek : MonoBehaviour
{
    player _player;

    void Awake()
    {
        _player = GameObject.Find("Mario").GetComponent<player>();
    }

    void OnTriggerStay2D(Collider2D col)
    {
        _player.isGrounded = true;
        _player._animator.SetBool("jumping", false);
    }

    void OnTriggerExit2D(Collider2D col)
    {
        _player.isGrounded = false;
    }

}
