using UnityEngine;

/// <summary>
/// Control Puppy 1 by setting parameter values on the animator and using conditions to trigger transitions between animation clips.
/// This is the type of animation seen in the Lab 1 project folder: "2. 3D Animation".
/// </summary>

public class Transitions : MonoBehaviour
{
    [SerializeField] private Animator puppy1Animator;
    [SerializeField] private float walkSpeed;

    private void Update()
    {
        float input = Input.GetAxisRaw("Horizontal");
        if (Input.GetAxisRaw("Vertical") > 0f) //Walk
        {
            transform.position += new Vector3(Time.deltaTime * 0.3f, 0f);
        }
        else if (input < 0) //Idle
        {
            transform.eulerAngles = Vector3.Lerp(transform.eulerAngles, new Vector3(0f, 90f, 0f), Time.deltaTime * 4f);
            puppy1Animator.SetFloat("walkSpeed", Mathf.Abs(input));

        }
    }
}