using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class End : MonoBehaviour {
    public TMP_Text victoryText;

    private void OnTriggerEnter(Collider other) {
        if (other.CompareTag("Player")) {
            victoryText.gameObject.SetActive(true);

            Invoke("ExitApp", 3f);
        }
    }

    private void ExitApp() {
        Application.Quit();
    }
}
