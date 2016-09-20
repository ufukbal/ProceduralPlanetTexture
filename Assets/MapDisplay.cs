using UnityEngine;
using System.Collections;

public class MapDisplay : MonoBehaviour {

	public Renderer textureRenderer;

	public void DrawTexture(Texture2D texture){




		textureRenderer.sharedMaterial.mainTexture = texture; // using shared material for edit mode display
		textureRenderer.transform.localScale = new Vector3 (texture.width, 1, texture.height);

	}

}
