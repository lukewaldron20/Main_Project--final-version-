using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class NoteDisplay : MonoBehaviour
{

    public Card card;

    public Text nameText;
    public Text descriptionText;

    // Start is called before the first frame update
    void Start()
    {
        nameText.text = card.name;
        descriptionText.text = card.description;
    }

}
