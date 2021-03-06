using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.ControlGallery.WindowsUniversal.Tests;
using Xamarin.Forms.Controls.Tests;

[assembly: Dependency(typeof(TestingPlatformService))]
namespace Xamarin.Forms.ControlGallery.WindowsUniversal.Tests
{
	class TestingPlatformService : ITestingPlatformService
	{
		public async Task CreateRenderer(VisualElement visualElement)
		{
			await Device.InvokeOnMainThreadAsync(() => Platform.UWP.Platform.CreateRenderer(visualElement));
		}
	}
}
