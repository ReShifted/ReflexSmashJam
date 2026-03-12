using UnityEngine;
using UnityEngine.InputSystem;

public class Pillow : MonoBehaviour
{
    [SerializeField] private Animator block;

    [SerializeField] public bool isBlocking;

    private void Start()
    {
        isBlocking = false;
    }

    void Update()
    {
        if (Keyboard.current.enterKey.wasPressedThisFrame == true && isBlocking == false)
        {
            isBlocking = true;
            block.Play("pillowblock");
        }
    }

    public void AnimationEnded()
    {
        isBlocking = false;
    }
}
