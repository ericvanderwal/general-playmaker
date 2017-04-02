// Custom Action by DumbGameDev
// www.dumbgamedev.com

using UnityEngine;

namespace HutongGames.PlayMaker.Actions 
{

	[ActionCategory (ActionCategory.Material)]
	[Tooltip("Create a New Unity Material")]
	public class createMaterial : FsmStateAction 
	{

		[UIHint(UIHint.Variable)]
		public FsmMaterial newMaterial;

		[TitleAttribute("Shader Name")]
		[Tooltip("Enter the name of the shader. Standard is the default shader")]
		public FsmString setShader;

		[TitleAttribute("Shader Albedo Color")]
		public FsmColor shaderColor;

		[TitleAttribute("Shader Main Texture")]
		public FsmTexture shaderTexture;

		public override void Reset()
		{

			newMaterial = null;
			setShader = "Standard";
			shaderColor = Color.black;
			shaderTexture = null;
		}

		public override void OnEnter()
		{

			makeNewMaterial();
			Finish();

		}

		public void makeNewMaterial ()
		{
			newMaterial.Value = new Material (Shader.Find(setShader.Value));
			newMaterial.Value.SetColor ("_Color", shaderColor.Value);
			newMaterial.Value.SetTexture("_MainTex", shaderTexture.Value);

		}


	}

}