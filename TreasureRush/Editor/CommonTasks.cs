using UnityEditor;
using UnityEngine;

namespace TreasureRush {

	public class CommonTasks {

		[MenuItem("Treasure Rush/Start Game")]
		public static void PlayIntroScene() {
			string introScenePath = EditorBuildSettings.scenes[0].path;
			EditorApplication.SaveCurrentSceneIfUserWantsTo();
			EditorApplication.OpenScene(introScenePath);
			EditorApplication.isPlaying = true;
		}
	}
}