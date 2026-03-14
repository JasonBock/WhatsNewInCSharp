namespace WhatsNewInCSharp.Application.Extensions;

internal static class PersonExtensions
{
	internal static string DescribeAgeBetter(this Person self) =>
		self.Age == 55 ? "Perfection" : "Nope";
}