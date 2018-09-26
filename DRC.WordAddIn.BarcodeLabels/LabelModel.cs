using System.Collections.Generic;

namespace DRC.WordAddIn.BarcodeLabels
{
	public class LabelModel
	{
        private XMLLabelParser _parser;

        public List<LabelTemplate> Labels { get; private set; }
		public LabelTemplate CurrentLabel { get; set; }

		public LabelModel()
		{
			Labels = new List<LabelTemplate>();
			_parser = new XMLLabelParser();
			SetupCurrentLabel();
		}

		public void LoadFromDirectory(string dir)
		{
			List<LabelTemplate> templates = _parser.ProcessDirectory(dir);
            Labels = templates;
			SetupCurrentLabel();
		}

		private void SetupCurrentLabel()
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
