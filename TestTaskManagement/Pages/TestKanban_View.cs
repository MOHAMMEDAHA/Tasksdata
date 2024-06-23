using Bunit;
using Microsoft.Extensions.DependencyInjection;
using TaskManagement.Pages;

namespace TestTaskManagement
{
	[Collection("TaskManagement")]
	public class TestKanban_View
	{
		[Fact]
		public void ViewIsCreated()
		{
			using var ctx = new TestContext();
			ctx.JSInterop.Mode = JSRuntimeMode.Loose;
			ctx.Services.AddIgniteUIBlazor(
				typeof(IgbAvatarModule),
				typeof(IgbCardModule),
				typeof(IgbIconButtonModule),
				typeof(IgbRippleModule),
				typeof(IgbButtonModule),
				typeof(IgbInputModule),
				typeof(IgbSelectModule));
			var componentUnderTest = ctx.RenderComponent<Kanban_View>();
			Assert.NotNull(componentUnderTest);
		}
	}
}
