using Bunit;
using Microsoft.Extensions.DependencyInjection;
using TaskManagement.Pages;

namespace TestTaskManagement
{
	[Collection("TaskManagement")]
	public class TestList_View
	{
		[Fact]
		public void ViewIsCreated()
		{
			using var ctx = new TestContext();
			ctx.JSInterop.Mode = JSRuntimeMode.Loose;
			ctx.Services.AddIgniteUIBlazor(
				typeof(IgbAvatarModule),
				typeof(IgbListModule),
				typeof(IgbInputModule),
				typeof(IgbSelectModule),
				typeof(IgbButtonModule),
				typeof(IgbRippleModule));
			var componentUnderTest = ctx.RenderComponent<List_View>();
			Assert.NotNull(componentUnderTest);
		}
	}
}
