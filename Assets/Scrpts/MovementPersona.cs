using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementPersona : MonoBehaviour
{
    public SpriteRenderer mySpriteRenderer;
    public Sprite[] mySprites;
    private int index = 0;
    // Start is called before the first frame update
    void Start()
    {
        mySpriteRenderer = GetComponent<SpriteRenderer>();
        StartCoroutine(TurnCoRutine());
    }
    IEnumerator TurnCoRutine()
   {
        yield return new WaitForSeconds(0.2f);
        mySpriteRenderer.sprite = mySprites[index];
        index++;
        if (index == 4)
        {
            index = 0;
        }
        StartCoroutine(TurnCoRutine());
    }
}
