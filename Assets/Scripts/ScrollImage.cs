using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScrollImage : MonoBehaviour
{
    [SerializeField]
    RawImage scrollImage;
    [SerializeField]
    float scrollSpeed;
    [SerializeField]
    Vector2 scrollDirection;
    Rect rect;
    // Start is called before the first frame update
    void Start()
    {
        rect = scrollImage.uvRect;
    }

    // Update is called once per frame
    void Update()
    {
        rect.y += scrollDirection.y*scrollSpeed*Time.deltaTime;
        rect.x += scrollDirection.x * scrollSpeed * Time.deltaTime;
        scrollImage.uvRect= rect;
    }
}
