using UnityEngine;
using UnityEngine.InputSystem;
using static Unity.Collections.AllocatorManager;

public class Pillow : MonoBehaviour
{
    [SerializeField] private Animator block;
    [SerializeField] private GameObject blockerPillow;
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
            Vector3 position = new Vector3(-31.9f, 6.49776f, -0.86f);
            Instantiate(blockerPillow, position, Quaternion.identity);
            block.Play("pillowblock");
        }
    }

    public void AnimationEnded()
    {
        isBlocking = false;
    }
}
