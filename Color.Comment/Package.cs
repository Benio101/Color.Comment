using System;
using System.Runtime.InteropServices;
using System.Threading;

using Microsoft.VisualStudio;
using Microsoft.VisualStudio.Shell;

namespace Color.Comment
{
	[ProvideAutoLoad(
		VSConstants.UICONTEXT.ShellInitialized_string,
		PackageAutoLoadFlags.BackgroundLoad
	)]
	[PackageRegistration(UseManagedResourcesOnly = true, AllowsBackgroundLoading = true)]
	[InstalledProductRegistration("#110", "#112", "0.0.1", IconResourceID = 400)]
	[ProvideMenuResource("Menus.ctmenu", 1)]
	[Guid("00000043-6F6C-6F72-2E43-6F6D6D2E6374")]
	[ProvideOptionPage(typeof(OptionsPage), "Color.Comment", "Options", 0, 0, true)]
	public sealed class Package
		: AsyncPackage
	{
		protected override async System.Threading.Tasks.Task InitializeAsync(
			CancellationToken cancellationToken,
			IProgress<ServiceProgressData> progress
		){
			Project.Package = this;

			await base.InitializeAsync(cancellationToken, progress);
			await ThreadHelper.JoinableTaskFactory.SwitchToMainThreadAsync(cancellationToken);
		}
	}

	internal static class Project
	{
		internal static Package Package = null;
	}
}