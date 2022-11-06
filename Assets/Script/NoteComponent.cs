using UnityEngine;

namespace YARG {
	public class NoteComponent : MonoBehaviour {
		public NotePool notePool;

		[SerializeField]
		private MeshRenderer meshRenderer;

		public void SetColor(Color c) {
			meshRenderer.materials[0].color = c;
		}

		private void Update() {
			transform.localPosition -= new Vector3(0f, 0f, Time.deltaTime * Game.Instance.SongSpeed);

			if (transform.localPosition.z < -3f) {
				notePool.RemoveNote(this);
			}
		}
	}
}