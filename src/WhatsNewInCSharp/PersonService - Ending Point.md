This is the final state for `PersonService`:

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

	public Result<Person, string> GetWithId(Guid id)
	{
		if (id == Guid.Empty)
		{
			return new Result<Person, string>(default!, "Person ID cannot be empty.");
		}

		return new Result<Person, string>(this.Repository.Retrieve(id), default!);
	}

	private IPersonRepository Repository { get; }
}

public union Result<TSuccess, TFailure>(TSuccess, TFailure);
```