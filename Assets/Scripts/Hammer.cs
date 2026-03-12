using UnityEngine;
using UnityEngine.InputSystem;

public class Hammer : MonoBehaviour
{

    [SerializeField] private Animator whack;

    [SerializeField] public bool isHitting;

    private void Start()
    {
        isHitting = false;
    }

    void Update()
    {
        if (Keyboard.current.spaceKey.wasPressedThisFrame == true && isHitting == false)
        {
            isHitting = true;
            whack.Play("hammerwow");
        }
    }

    public void AnimationEnded()
    {
        isHitting = false;
    }
}
