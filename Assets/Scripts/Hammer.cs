using UnityEngine;
using UnityEngine.InputSystem;

public class Hammer : MonoBehaviour
{

    [SerializeField] private Animator whack;
    [SerializeField] private GameObject blocker;
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
            Vector3 position = new Vector3(-31.9f, 6.49776f, -0.86f);
            Instantiate(blocker, position, Quaternion.identity);
            whack.Play("hammerwow");

        }
    }

    public void AnimationEnded()
    {
        isHitting = false;
        
    }
}
