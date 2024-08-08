
using UnityEngine;

public class Animation : MonoBehaviour
{
    private Animator _animator;

    private void Start()
    {
        _animator = GetComponent<Animator>();
    }
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.U))
        {
            _animator.SetInteger("Hello", 1);
        }
    }
}
