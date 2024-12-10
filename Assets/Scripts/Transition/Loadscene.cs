using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Loadscene : MonoBehaviour
{
 [SerializeField] RectTransform fader;

    private void Start()
    {
        fader.gameObject.SetActive(true);

        LeanTween.scale(fader, new Vector3 (100,100,100),0.1f);
        LeanTween.scale(fader, Vector3.zero, 0.5f).setOnComplete(() => {
        fader.gameObject.SetActive (false);
        });
        
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
