This is the starting state for `PersonService`:

```c#
namespace WhatsNewInCSharp;

public sealed class PersonService
{
	public PersonService(IPersonRepository repository)
	{
		ArgumentNullException.ThrowIfNull(repository);
		this.Repository = repository;
	}

	public Person? Get(Guid id) =>
		this.Repository.Retrieve(id);

	private IPersonRepository Repository { get; }
}
```