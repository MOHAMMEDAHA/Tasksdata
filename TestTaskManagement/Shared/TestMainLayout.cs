using Bunit;
using Microsoft.Extensions.DependencyInjection;
using TaskManagement.Shared;

namespace TestTaskManagement
{
	[Collection("TaskManagement")]
	public class TestMainLayout
	{
		[Fact]
		public void ViewIsCreated()
		{
			using var ctx = new TestContext();
			ctx.JSInterop.Mode = JSRuntimeMode.Loose;
			ctx.Services.AddIgniteUIBlazor(
				typeof(IgbNavbarModule),
				typeof(IgbIconButtonModule),
				typeof(IgbRippleModule),
				typeof(IgbAvatarModule),
				typeof(IgbDropdownModule),
				typeof(IgbDropdownHeaderModule),
				typeof(IgbDropdownItemModule),
				typeof(IgbButtonGroupModule),
				typeof(IgbToggleButtonModule),
				typeof(IgbInputModule),
				typeof(IgbSelectModule),
				typeof(IgbButtonModule));
			var componentUnderTest = ctx.RenderComponent<MainLayout>();
			Assert.NotNull(componentUnderTest);
		}
	}
}
