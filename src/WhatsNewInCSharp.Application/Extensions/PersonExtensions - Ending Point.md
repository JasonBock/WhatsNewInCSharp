This is the final state for `PersonExtensions`:

```c#
namespace WhatsNewInCSharp.Application.Extensions;

internal static class PersonExtensions
{
	extension(Person self)
	{
		internal string DescribeAgeBetter() =>
			self.Age == 55 ? "Perfection" : "Nope";

		internal string Description => $"Name: {self.Name}, Id: {self.Id}, Age: {self.Age} - {self.DescribeAgeBetter()}";
	}

	extension(Person)
	{
		internal static Person Create(uint age, string name) => new(Guid.NewGuid(), name, age);
	}
}
```