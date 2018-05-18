using UnityEngine;
using System.Collections;

public class ButtonActions : MonoBehaviour {

	public void MENU_ACTION_GoToPage(string sceneName) {
        Application.LoadLevel(sceneName);
    }
}
