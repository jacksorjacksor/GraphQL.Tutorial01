using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EIT.GraphQL.Test02
{
	public class PersonRepository
	{
		private List<Person> people = new List<Person>() {
			                                                 new Person() { Id = 1, Name = "Poornima" },
			                                                 new Person() { Id = 2, Name = "Kavya" } };

		public Person GetPerson(int id) { return people.FirstOrDefault(p => p.Id == id); }

		public List<Person> GetPersons() { return people; }

		public Person AddPerson(Person person)
		{
			people.Add(person);
			return person;
		}

	}
}
