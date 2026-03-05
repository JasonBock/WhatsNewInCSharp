namespace WhatsNewInCSharp;

public interface IPersonRepository
{
	Person? Retrieve(Guid id);
}