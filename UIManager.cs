using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UIManager : MonoBehaviour
{
    public GameObject mark;
    public Color[] c;
    private bool hashtag = true;
    private string htag;
    public TMP_InputField hex;

    public void ToggleHashTag()
    {
        hashtag = !hashtag;
    }

    void Update()
    {
        if(hashtag) htag = "#";
        else htag = "";
    }

    public void AddMarker()
    {
        GameObject marker = Instantiate(mark) as GameObject;
        SpriteRenderer sr = marker.GetComponent<SpriteRenderer>();
        string hexCode = htag + hex.text;
        Color color;
        ColorUtility.TryParseHtmlString(hexCode, out color);
        sr.color = color;
    }

    public void AddColoredMarker(int i)
    {
        GameObject marker = Instantiate(mark) as GameObject;
        SpriteRenderer sr = marker.GetComponent<SpriteRenderer>();
        sr.color = c[i];
    }

    public void AddTile(GameObject tile)
    {
        Instantiate(tile, new Vector3(Random.Range(9f, -9f), Random.Range(5f, -5f), 0f),Quaternion.identity);
    }

    public void AddColoredTile(GameObject tile)
    {
        GameObject tiel = Instantiate(tile, new Vector3(Random.Range(9f, -9f), Random.Range(5f, -5f), 0f),Quaternion.identity) as GameObject;
        SpriteRenderer sr = tiel.GetComponent<SpriteRenderer>();
        string hexCode = htag + hex.text;
        Color color;
        ColorUtility.TryParseHtmlString(hexCode, out color);
        sr.color = color;
    }

    public void Quit()
    {
        Debug.Log("Quit");
        #if UNITY_EDITOR
            // Application.Quit() does not work in the editor so
            // UnityEditor.EditorApplication.isPlaying need to be set to false to end the game
            UnityEditor.EditorApplication.isPlaying = false;
        #else
            Application.Quit();
        #endif
    }
}
