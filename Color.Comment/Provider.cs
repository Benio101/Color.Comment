using Microsoft.VisualStudio.Text;
using Microsoft.VisualStudio.Text.Classification;
using Microsoft.VisualStudio.Utilities;
using System.ComponentModel.Composition;

namespace Color.Comment
{
	[
		Export(typeof(IClassifierProvider)),
		ContentType("C/C++")
	]

	internal sealed class ClassifierProvider
	:
		IClassifierProvider
	{
		#pragma warning disable 649

		// > The field is never used
		// Reason: The field is used by MEF.

		[Import]
		private readonly IClassificationTypeRegistryService ClassificationTypeRegistryService;

        [Import]
        private readonly IClassifierAggregatorService ClassifierAggregatorService;

		#pragma warning restore 649

		private static bool IgnoreRequest;

		public IClassifier GetClassifier(ITextBuffer Buffer)
		{
			if (IgnoreRequest) return null;

			try
			{
				IgnoreRequest = true;

				return Buffer.Properties.GetOrCreateSingletonProperty
				(
					() => new Classifier
					(
						ClassificationTypeRegistryService,
						ClassifierAggregatorService.GetClassifier(Buffer)
					)
				);
			}

			finally
			{
				IgnoreRequest = false;
			}
		}
	}
}