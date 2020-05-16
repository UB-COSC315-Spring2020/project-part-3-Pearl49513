using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerGridDirection : MonoBehaviour
{
    [SerializeField]
    private float speed;
    private Vector2 direction;
    private Animator animator;

    // Start is called before the first frame update
    void Start()
    {
        //Starting to get animation movement from Animator
        direction = Vector2.up;
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        //Using Keyboard
        GetInput();
        //Movement of Character
        GridMove();  
    }

    public void GridMove()
    {
        //Moving character around with a choice of speed
        transform.Translate(direction * speed * Time.deltaTime);

        //Movement for walking
        if (direction.x != 0 || direction.y != 0)
        {
            AnimateMovement(direction);
        }
        else
        {
            animator.SetLayerWeight(1, 0);
        }

        
    }

    //Keyboard Controls
    private void GetInput()
    {
        direction = Vector2.zero;

        if (Input.GetKey(KeyCode.UpArrow))
        {
            direction += Vector2.up;
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            direction += Vector2.left;
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            direction += Vector2.down;
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            direction += Vector2.right;
        }
    }
    //Movement for idleing
        public void AnimateMovement(Vector2 direction)
    {
        animator.SetLayerWeight(1, 1);

        animator.SetFloat("X", direction.x);
        animator.SetFloat("Y", direction.y);
    }
}
