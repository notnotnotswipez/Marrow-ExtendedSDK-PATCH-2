using TMPro;
using UnityEngine;

namespace SLZ.Bonelab
{
	public class HubModule_InfoBoard : MonoBehaviour
	{
		private int displayState;

		[Header("WELCOME INFO")]
		public TextMeshProUGUI txt_boardName;

		public TextMeshProUGUI txt_buildInfo;

		public TextMeshProUGUI txt_patchNotes;

		public TextMeshProUGUI txt_hotfixNotes;

		public GameObject[] boards;

		public int startBoard;

		public string[] boardName;

		public string patchNotes;

		public string[] oldPatchNotes;

		public string hotfixNotes;

		public string buildState;

		private string buildDate;

		public GameObject storyButton;

		private void Awake()
		{
		}

		private void OnEnable()
		{
		}

		public void UPDATEUI()
		{
		}

		private void PullPatchNotes()
		{
		}

		public void PAGECHANGE(bool forward)
		{
		}

		public HubModule_InfoBoard()
			: base()
		{
		}
	}
}
