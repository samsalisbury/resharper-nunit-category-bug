using NUnit.Framework;

namespace ResharperTestRunnerCategoryBug
{
	[TestFixture(true, Category = "Cat1")]
	[TestFixture(false, Category = "Cat2")]
	public class MyTestFixture
	{
		private readonly bool _trueOrFalse;

		public MyTestFixture(bool trueOrFalse)
		{
			_trueOrFalse = trueOrFalse;
		}

		[Test]
		public void MyTest()
		{
			Assert.True(_trueOrFalse);
		}
	}
}