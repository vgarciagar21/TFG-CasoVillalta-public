using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ChatBubble : MonoBehaviour
{
    /*public static void Create(Transform parent, Vector3 localPosition, CharacterNarrators character, string narrator, string text) {
        Transform chatBubbleTransform = Instantiate(ReferenceAssets._x.pfChatBubble, parent);
        chatBubbleTransform.position = localPosition;
        chatBubbleTransform.GetComponent<ChatBubble>().Setup(character, narrator, text);
        //Destroy(chatBubbleTransform.gameObject,4f);
    }*/
    
    private SpriteRenderer bubbleSR;
    private SpriteRenderer shortImageSR;
    private TextMeshPro narratorMP;
    private TextMeshPro textMP;

    [SerializeField] private Sprite MarioPic;
    [SerializeField] private Sprite ForensePic;
    [SerializeField] private Sprite CatalinaPic;
    [SerializeField] private Sprite ReporteraPic;

    public enum CharacterNarrators { 
        Mario,
        Forense,
        Catalina,
        Reportera,
    }

    private void Awake() {
        bubbleSR = transform.Find("Bubble").GetComponent<SpriteRenderer>();
        shortImageSR = transform.Find("Photograph").GetComponent<SpriteRenderer>();
        narratorMP = transform.Find("Narrator").GetComponent<TextMeshPro>();
        textMP = transform.Find("Text").GetComponent<TextMeshPro>();
    }

    private void Start() {
        Setup(CharacterNarrators.Mario, "Myself", "Testing the outcome message");
    }

    private void Setup(CharacterNarrators character, string narrator, string text) {
        shortImageSR.sprite = GetNarrator(character);
        narratorMP.SetText(narrator);
        textMP.SetText(text);
    }

    private Sprite GetNarrator(CharacterNarrators character) {
        switch (character) {
            default:
                case CharacterNarrators.Mario:
                    return MarioPic;
                case CharacterNarrators.Catalina:
                    return CatalinaPic;
                case CharacterNarrators.Forense:
                    return ForensePic;
                case CharacterNarrators.Reportera:
                    return ReporteraPic;
        }
    }
}