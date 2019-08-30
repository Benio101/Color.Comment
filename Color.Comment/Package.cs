using Microsoft.VisualStudio;
using Microsoft.VisualStudio.Shell;
using System;
using System.Runtime.InteropServices;
using System.Threading;
using Task = System.Threading.Tasks.Task;

namespace Color.Comment
{
	[
		PackageRegistration
		(
			AllowsBackgroundLoading = true,
			UseManagedResourcesOnly = true
		),

		ProvideAutoLoad
		(
			VSConstants.UICONTEXT.ShellInitialized_string,
			PackageAutoLoadFlags.BackgroundLoad
		),

		InstalledProductRegistration("#110", "#112", "0.0.2", IconResourceID = 400),
		Guid("00000043-6F6C-6F72-2E43-6F6D6D2E6374"),

		ProvideMenuResource("Menus.ctmenu", 1),
		ProvideOptionPage(typeof(OptionsPage), "Color.Comment", "Options", 0, 0, true)
	]

	public sealed class Package
	:
		AsyncPackage
	{
		protected override async Task InitializeAsync
		(
			CancellationToken              Token,
			IProgress<ServiceProgressData> Progress
		)
		{
			Project.Package = this;

			await base.InitializeAsync(Token, Progress);
			await ThreadHelper.JoinableTaskFactory.SwitchToMainThreadAsync(Token);
		}
	}

	internal static class Project
	{
		internal static Package Package;
	}
}