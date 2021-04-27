using System.Threading;
using System.Xml;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class DialogueAnimationSystem : MonoBehaviour
{
    [SerializeField] public Vector3 _relativeFinalPosition;
    [SerializeField] public Vector3 _relativeFinalScale;
    public Vector3 targetPosition;
    private TMP_Text textComponent;

    // Start is called before the first frame update
    void Start()
    {
        textComponent = gameObject.GetComponent<TMP_Text>();
        _relativeFinalScale = new Vector3(1.0f, 1.0f, 1.0f);
    }

    public void StartDialogue() {
            LeanTween.moveLocal(this.gameObject, _relativeFinalPosition, 1.0f);
            LeanTween.scale(this.gameObject, _relativeFinalScale, 1.0f);
    }


}
