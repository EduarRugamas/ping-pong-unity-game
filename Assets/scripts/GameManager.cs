using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    [SerializeField] private TMP_Text paleta1PuntosText;
    [SerializeField] private TMP_Text paleta2PuntosText;

    [SerializeField] private Transform paleta1Transform;
    [SerializeField] private Transform paleta2Transform;
    [SerializeField] private Transform pelotaTransform;

    private int paleta1Puntos;
    private int paleta2Puntos;

    private static GameManager instance;

    public static GameManager Instance
    {
        get
        {
            if (instance == null)
            {
                instance = FindObjectOfType<GameManager>();
            }
            return instance;
        }       
    }

    public void PaletaPuntos1 ()
    {
        paleta1Puntos++;
        paleta1PuntosText.text = paleta1Puntos.ToString();
    }

    public void PaletaPuntos2()
    {
        paleta2Puntos++;
        paleta2PuntosText.text = paleta2Puntos.ToString();
    }

    public void Restart ()
    {
        paleta1Transform.position = new Vector2(paleta1Transform.position.x, 0);
        paleta2Transform.position = new Vector2(paleta2Transform.position.x, 0);
        pelotaTransform.position = new Vector2(0, 0);
    }
}
