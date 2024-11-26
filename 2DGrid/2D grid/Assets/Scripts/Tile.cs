using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tile : MonoBehaviour
{
    [SerializeField] private Color baseColor, offsetColor;
    [SerializeField] private SpriteRenderer gridRenderer;
    [SerializeField] private GameObject hightLight;

    public void Init(bool isOffset)
    {
        gridRenderer.color = isOffset ? offsetColor : baseColor;
    }

    private void OnMouseEnter()
    {
        hightLight.SetActive(true);
    }

    private void OnMouseExit()
    {
        hightLight.SetActive(false);
    }
}
