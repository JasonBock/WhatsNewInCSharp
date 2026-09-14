namespace WhatsNewInCSharp;

public sealed class PersonComparer
	: IComparer<Person>
{
	public int Compare(Person? x, Person? y) =>
		x?.Age > y?.Age ?
			1 :
			y?.Age > x?.Age ?
			-1 :
				0;
}
