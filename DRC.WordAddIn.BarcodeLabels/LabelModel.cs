using System.Collections.Generic;

namespace DRC.WordAddIn.BarcodeLabels
{
	public class LabelModel
	{
		public List<LabelTemplate> Labels { get; set; }

		private XMLLabelParser _parser;

		public LabelTemplate CurrentLabel { get; set; }

		public LabelModel()
		{
			Labels = new List<LabelTemplate>();
			_parser = new XMLLabelParser();
			SetupDefaultLabel();
		}

		public void AddFromDirectory(string dir)
		{
			List<LabelTemplate> templates = _parser.ProcessDirectory(dir);
			Labels.AddRange(templates);
			SetupDefaultLabel();
		}

		private void SetupDefaultLabel()
		{
			if(Labels.Count < 1)
			{
				CurrentLabel = null;
				return;
			}

			foreach (LabelTemplate label in Labels)
				if (label.Default)
				{
					CurrentLabel = label;
					return;
				}
			CurrentLabel = Labels[0];
		}
	}
}
