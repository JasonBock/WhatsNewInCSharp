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
			return new Result<Person, string>("Person ID cannot be empty.");
		}

		return new Result<Person, string>(this.Repository.Retrieve(id)!);
	}

	private IPersonRepository Repository { get; }
}

#pragma warning disable CA1815 // Override equals and operator equals on value types
public union Result<TSuccess, TFailure>(TSuccess, TFailure);
#pragma warning restore CA1815 // Override equals and operator equals on value types