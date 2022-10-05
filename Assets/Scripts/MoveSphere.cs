using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveSphere : MonoBehaviour
{

    private Vector3 target = new Vector3(-3f, 1f, 0f);
    private float duration = 1.5f;
    [SerializeField] public Tweener twn;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //if (twn.TweenExists(transform))
        if (!twn.TweenExists(transform))
        {
            target.x = -target.x;
            target.y = -target.y;
            twn.AddTween(transform, transform.position, target, duration/SpeedManager.SpeedModifier);
        }
    }
}
